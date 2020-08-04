using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;

public partial class shop_member_center : System.Web.UI.Page
{
    public int flag_4;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (Session["hy_id1"] == null)
            {
                //Response.Write("<script language=javascript>alert('请重新登录！');top.location.href='login.aspx';</script>");
                //Response.End();
                Response.Redirect("~/shop/login.aspx");
            }
            if (Session["flag4"] != null)
            {
                flag_4 = int.Parse(Session["flag4"].ToString());
            }
            else
            {
                flag_4 = 0;
            }
            //weekbind();//绑定日历
            //new_product_bind();
            //hot_pro_bind();
            order_count();//绑定订单未付款已付款数量
            member_info();
            tbl_news news = new tbl_news();
            string a = news.CountNews().Tables[0].Rows[0]["news"].ToString();
            this.news.Text = a + "条";

            tbl_huiyuan tb = new tbl_huiyuan();
            tb.GetModel_hui_id(Session["hy_id1"].ToString());
            
            //if (tb.supply != 0)
            //    liSupply.Visible = false;
            //if (tb.supply != 2)
            //    li1.Visible = false;
            if (tb.net_hege == 0)
            {
                
                this.ul2.Visible = false;
            }
            else
            {
                if (string.IsNullOrEmpty(tb.zl_pinju_src.ToString()) || string.IsNullOrEmpty(tb.sf_pinju_src.ToString()))
                {
                    //this.info1.Visible = false;
                    //this.li6.Visible = false;
                }
                else
                {
                    this.info.Visible = false;
                    
                }
            }
            if (tb.huiyuan_jiebie == 0)
            {
                this.ul1.Visible = false;
            }
            else
            {
                //this.liwlt.Visible = false;
                //this.likt.Visible = false;
                this.ul1.Visible = true;
            }
            if (tb.net_hege == 1)
            {
                //DateTime tdate = DateTime.Now;
                //string tDays = ConfigurationManager.AppSettings["tDays"];
                //string dd = DbHelperSQL.GetDataRow("SELECT TOP 1 xiaofei_date FROM tbl_xiaofei WHERE xiaofei_hui_id='" + Session["hy_id1"].ToString() + "' ORDER BY xiaofei_date desc")["xiaofei_date"].ToString();
                //TimeSpan ts = tdate - Convert.ToDateTime(dd);
                //if (Convert.ToInt32(ts.TotalDays) > 0)
                //{
                //    if (Convert.ToInt32(ts.TotalDays) > Convert.ToDouble(tDays))
                //    {
                //        this.timeShow.InnerHtml = "您的喂养周期已到，请点击";
                //        this.timeUrl.HRef = "feeding.aspx";
                //    }
                //    else
                //    {
                //        this.timeShow.InnerText = "喂养周期" + Math.Floor(((Convert.ToDouble(tDays) * 24) - ts.TotalHours) / 24) + "天" + Math.Floor((((Convert.ToDouble(tDays) * 24) - ts.TotalHours) / 24 - Math.Floor(((Convert.ToDouble(tDays) * 24) - ts.TotalHours) / 24)) * 24) + "时";
                //    }
                //}
                //else
                //    this.timeShow.InnerText = "喂养周期" + Math.Floor(Convert.ToDouble(tDays) - 1) + "天" + Math.Floor(24 - ts.TotalHours) + "时";
                this.timeShow.InnerText = "";

            }
            else
                this.timeShow.InnerText = "请完善会员信息";
        }
    }

    #region 绑定日历=================================
    private void order_count()
    {

        tbl_orders bll = new tbl_orders();
        this.is_pay.Text = bll.GetTitleSum("user_id='" + Session["hy_id1"].ToString() + "' and payment_status=1", " count(*)");
        this.is_fa.Text = bll.GetTitleSum("user_id='" + Session["hy_id1"].ToString() + "' and payment_status=2 and status=1", " count(*)");
        this.is_shou.Text = bll.GetTitleSum("user_id='" + Session["hy_id1"].ToString() + "' and payment_status=2 and status=2", " count(*)");
 

    }
    #endregion

    #region 绑定日历=================================
    private void weekbind()
    {





       // this.week.Text = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetDayName(DateTime.Now.DayOfWeek);
       // this.rili.Text = DateTime.Now.ToLongDateString().ToString();
       // this.hao.Text = DateTime.Now.Day.ToString();
       //// this.news_bind.DataBind();



    }
    #endregion

    #region 绑定新品上市=================================
    private void new_product_bind()
    {





        //tbl_product bll = new tbl_product();
        //this.new_product.DataSource = bll.GetList_top_1(" pro_isok=1   order by pro_date desc", 3);
        //this.new_product.DataBind();



    }
    #endregion
    #region 绑定新品上市=================================
    private void hot_pro_bind()
    {





        //tbl_product bll = new tbl_product();
        //this.hot_pro.DataSource = bll.GetList_top_1(" pro_isok=1 and pro_hot=1   order by NEWID()", 8);
        //this.hot_pro.DataBind();



    }
    #endregion
    #region 绑定会员钱包=================================
    private void member_info()
    {





        tbl_huiyuan model1 = new tbl_huiyuan();

        model1.GetModel_hui_id(Session["hy_id1"].ToString());
        username.Text = model1.huiyuan_name;
        int jibie1 = int.Parse(model1.huiyuan_jiebie.ToString());
        int jibie2=int .Parse(model1.huiyuan_jiebie1.ToString());
        tbl_reg_jiebie bll = new tbl_reg_jiebie();
        bll.GetModeljibie(jibie1);
        jibie.Text = bll.jiebie_name;
        //this.dianzi.Text = money_Convert((model1.jiangjin_zong - model1.jiangjin_yong).ToString()).ToString();
        //this.Literal3.Text = money_Convert((model1.fh_money).ToString()).ToString();
        this.Literal1.Text = money_Convert((model1.chongfu_zong).ToString()).ToString();
        this.Image1.ImageUrl = model1.huiyuan_shangshu;
        //this.Literal2.Text = money_Convert((model1.glf_money).ToString()).ToString();
        //this.Literal4.Text = money_Convert((model1.jiangjing).ToString()).ToString();
        //this.Literal5.Text = money_Convert((model1.zuo_zong).ToString()).ToString();
        //this.Literal6.Text = money_Convert((model1.you_zong).ToString()).ToString();
        //switch (jibie2)
        //{
        //    case 1: this.jibie1.Text = "初级经理";
        //       break;
        //    case 2: this.jibie1.Text = "中级经理";
        //        break;
        //    case 3: this.jibie1.Text = "高级经理";
        //        break;
        //    case 4: this.jibie1.Text = "名誉董事";
        //        break;
        //    default: this.jibie1.Text = "";
        //        break;
        //}
        //this.tuijian_c.InnerText = model1.GetList("huiyuan_shang_id='" + Session["hy_id1"] + "'").Tables[0].Rows.Count.ToString();

    }
    #endregion

    //小数位是0的不显示
    public string money_Convert(string money)
    {
        decimal num = decimal.Parse(money);
        string s4 = "";
        s4 = num.ToString().Substring(0, num.ToString().IndexOf('.') + 3);
        decimal num1 = Convert.ToDecimal(s4);
        return num1.ToString();
    }

 protected void LinkButton1_Click(object sender, EventArgs e)
    {
        ShopCart.Clear("0");


        Session["hy_id1"] = null;
        Session["hy_bianhao1"] = null;
        Session["hy_name1"] = null;
        Session["zhongyao1"] = null;
        // Session["RoleID"] = null;



        Response.Write("<script language=javascript>alert('成功退出！');parent.location.href='index.aspx'</script>");
        Response.End();
    }
   
}