using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Web.UI.WebControls;
using Com.Alipay;
using System.Text;
using System.Configuration;

public partial class shop_pay : System.Web.UI.Page
{
    ManagePage mym = new ManagePage();
    private int id = 0;
    protected tbl_orders model = new tbl_orders();
    public static string shen, shi, xian, name, address, mob1;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["hy_id1"] == null)
        {
            Response.Write("<script language=javascript>alert('请重新登录！');top.location.href='login.aspx';</script>");
            Response.End();

        }
        if (!int.TryParse(Request.QueryString["order_id"] as string, out this.id))
        {
            Response.Write("<script language=javascript>alert('参数不正确！');top.location.href='index.aspx';</script>");
            return;
        }

        if (!Page.IsPostBack)
        {

            ShowInfo(this.id, Session["hy_id1"].ToString());
            show_address(Session["hy_id1"].ToString());
            //tbl_orders order = new tbl_orders();
            //order.GetModel(this.id);
            //if (order.flag == 0 || order.flag == 1 || order.flag == 3)
            //{
            //    //this.li2.Visible = false;
            //}
            //else if (order.flag == 2)
            //{
            //    //this.li1.Visible = false;
            //    //this.li3.Visible = false;
            //    this.li4.Visible = false;
            //}

        }

    }
    #region 赋值操作=================================
    private void show_address(string _hui_id)
    {
        tbl_huiyuan bll = new tbl_huiyuan();
        bll.GetModel_hui_id(_hui_id);
        shen = bll.Getshen("ProID=" + bll.bid.ToString() + "", "ProName");
        shi = bll.Getshi("CityID=" + bll.mmid.ToString() + "", "CityName");
        xian = bll.Getxian("Id=" + bll.sid.ToString() + "", "DisName");
        address = bll.huiyuan_address;

    }
    #endregion

    #region 赋值操作=================================
    private void ShowInfo(int _id, string _hui_id)
    {
        tbl_canshu canshu = new tbl_canshu();
        canshu.GetModel(1);
        model.GetModel(_id);
        //绑定商品列表
        tbl_order_goods bll = new tbl_order_goods();
        string sql = " order_id =" + _id;

        DataTable dt = bll.GetList(sql).Tables[0];
        this.rptList.DataSource = dt;
        this.rptList.DataBind();

        //获得商家信息
        if (model.user_id != "")
        {
            view_huiyuan user_info = new view_huiyuan();
            user_info.GetModel(model.user_id);
            name = model.user_name;

            //contact_address.Text = user_info.huiyuan_address;
            //contact_name.Text = user_info.huiyuan_name;
            mob1 = user_info.huiyuan_mob;
        }
        tbl_huiyuan bll1 = new tbl_huiyuan();
        bll1.GetModel_hui_id(_hui_id);
        int jibie = int.Parse(bll1.huiyuan_jiebie.ToString());
        tbl_reg_jiebie bll4 = new tbl_reg_jiebie();
        bll4.GetModeljibie(Convert.ToInt32(Session["hy_jiebie1"].ToString()));
        //this.jibie.Text = bll4.jiebie_name;
        tbl_order_goods bll2 = new tbl_order_goods();
        bll2.GetModel(_id);
        int goodsid = int.Parse(bll2.goods_id.ToString());
        tbl_product pro = new tbl_product();
        pro.GetModel(goodsid);
        decimal money = 1;
        //switch (jibie)
        //{
        //    case 1:
        //        money = decimal.Parse("1");
        //        break;
        //    case 2:
        //        money = decimal.Parse(canshu.canshu_024.ToString()) * 0.1m;
        //        break;
        //    case 3:
        //        money = decimal.Parse(canshu.canshu_025.ToString()) * 0.1m;
        //        break;
        //    case 4:
        //        money = decimal.Parse(canshu.canshu_026.ToString()) * 0.1m;
        //        break;
        //    case 5:
        //        money = decimal.Parse(canshu.canshu_027.ToString()) * 0.1m;
        //        break;
        //    case 6:
        //        money = decimal.Parse(canshu.canshu_028.ToString()) * 0.1m;
        //        break;
        //    default:
        //        money = decimal.Parse("1");
        //        break;
        //}
        this.zong_price.Text = decimal.Parse((model.payable_amount * money).ToString()).ToString("0.00");
        this.zong_money.Text = model.payable_amount.ToString();

    }
    #endregion
    #region 提交订单=================================
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        tbl_canshu canshu = new tbl_canshu();
        canshu.GetModel(1);
        if (string.IsNullOrEmpty(this.zz_type.Value.ToString()))
        {
            Response.Write("<script language=javascript>alert('请先选择支付方式！');history.go(-1);</script>");
            return;
        }
        if (this.two.Value.Trim() == "")
        {
            Response.Write("<script language=javascript>alert('请输入二级支付密码！');history.go(-1);</script>");
            return;
        }

        if (!tbl_huiyuan.Exists_erji(Session["hy_bianhao1"].ToString(), this.two.Value.Trim()))
        {
            Response.Write("<script language=javascript>alert('二级支付密码不正确！');history.go(-1);</script>");
            return;

        }
        tbl_huiyuan bll1 = new tbl_huiyuan();
        bll1.GetModel_hui_id(Session["hy_id1"].ToString());
        decimal money = 1;
        int jibie = int.Parse(bll1.huiyuan_jiebie.ToString());
        if (bll1.huiyuan_address == "")
        {
            Response.Write("<script language=javascript>alert('完善资料填写地址！');history.go(-1);</script>");
            return;
        }
        //switch (jibie)
        //{
        //    case 1:
        //        money = decimal.Parse("1");
        //        break;
        //    case 2:
        //        money = decimal.Parse(canshu.canshu_024.ToString()) * 0.1m;
        //        break;
        //    case 3:
        //        money = decimal.Parse(canshu.canshu_025.ToString()) * 0.1m;
        //        break;
        //    case 4:
        //        money = decimal.Parse(canshu.canshu_026.ToString()) * 0.1m;
        //        break;
        //    case 5:
        //        money = decimal.Parse(canshu.canshu_027.ToString()) * 0.1m;
        //        break;
        //    case 6:
        //        money = decimal.Parse(canshu.canshu_028.ToString()) * 0.1m;
        //        break;
        //    default:
        //        money = decimal.Parse("1");
        //        break;
        //}
        model.GetModel(this.id);//总订单查看

        if (model.payment_status.ToString() == "2")
        {

            Response.Write("<script language=javascript>alert('该订单已经支付！');location.href='member_center.aspx';</script>");
            return;

        }
        model.message = this.message.Value;
        tbl_huiyuan tmodel = new tbl_huiyuan();
        if (this.zz_type.Value.ToString() == "li1")
        {
            
                //判断该会员是否有足够消费比支付

                tbl_huiyuan model1 = new tbl_huiyuan();
                model1.GetModel_hui_id(Session["hy_id1"].ToString());
                //string shang_id = model1.huiyuan_shang_id;
                decimal qianbao = decimal.Parse(model1.chongfu_zong.ToString());
                decimal moneybefore = decimal.Parse(model1.chongfu_zong.ToString());//改变前余额
                string memo = "会员购物消费" + model.order_amount * money + "元";
                decimal moneyafter = moneybefore - decimal.Parse((model.order_amount * money).ToString());//改变后余额
                if (qianbao < model.order_amount * money)
                {

                    Response.Write("<script language=javascript>alert('奖励积分不足，请联系管理员充值！');history.go(-1);</script>");
                    return;

                }
                else
                {
                    tbl_order_goods og = new tbl_order_goods();
                    DataTable dt = og.GetList(" 1=1 and order_id=" + this.id + "").Tables[0];
                    tbl_product pro;
                    decimal? f = 0;
                    foreach (DataRow dr in dt.Rows)
                    {
                        pro = new tbl_product();
                        pro.GetModel(int.Parse(dr["goods_id"].ToString()));
                        f += pro.shop_fen * int.Parse(dr["quantity"].ToString());
                        pro.pro_num = pro.pro_num - int.Parse(dr["quantity"].ToString());
                        pro.Update();
                    }
                    model1.chongfu_zong -= model.order_amount;
                    model1.huiyuan_jiebie = 1;
                    model1.Update();
                    model.payment_status = 2;
                    model.status = 1;

                    if (model.Update())
                    {
                        DbHelperSQL.ExecuteSql("exec sp_zhixing '" + Session["hy_id1"].ToString() + "'," + model.order_amount + "");
                        DbHelperSQL.ExecuteSql("exec sp_jiangjin_4 '" + Session["hy_id1"].ToString() + "'");
                        mym.queren_insert(Session["hy_id1"].ToString(), Session["hy_bianhao1"].ToString(), "奖励积分购物", memo, -decimal.Parse((model.order_amount).ToString()), qianbao);
                    }
                }
        }
        else if (this.zz_type.Value.ToString() == "li2")
        {
            tmodel.GetModel_hui_id(Session["hy_id1"].ToString());
            ////判断该会员是否有足够消费比支付

            //tbl_huiyuan model1 = new tbl_huiyuan();
            //model1.GetModel_hui_id(Session["hy_id1"].ToString());
            //decimal qianbao = decimal.Parse(model1.fh_money.ToString());
            //decimal moneybefore = decimal.Parse(model1.fh_money.ToString());//改变前余额
            //string memo = "会员购物消费" + model.order_amount + "元";
            //decimal moneyafter = moneybefore - decimal.Parse(model.order_amount.ToString());//改变后余额
            //if (qianbao < model.order_amount)
            //{

            //    Response.Write("<script language=javascript>alert('分享积分不足，请联系管理员充值！');history.go(-1);</script>");
            //    return;

            //}
            ////-----------------使用消费币购买

            //tmodel.GetModel_hui_id(Session["hy_id1"].ToString());
            //tmodel.fh_money -= model.order_amount;
            //tmodel.Update();

            //mym.queren_insert(Session["hy_id1"].ToString(), Session["hy_bianhao1"].ToString(), "分享积分购物", memo, -decimal.Parse(model.order_amount.ToString()), qianbao);
            //model.message = this.message.Value;
            model.status = 1;
            ////model.payment_status = 2;
            //model.address = tmodel.Getshen("ProID=" + tmodel.bid.ToString() + "", "ProName") + tmodel.Getshi("CityID=" + tmodel.mmid.ToString() + "", "CityName") + tmodel.Getxian("Id=" + tmodel.sid.ToString() + "", "DisName") + tmodel.huiyuan_address;
            //model.shouhuo_name = tmodel.huiyuan_name;
            //model.phone = tmodel.huiyuan_mob;
            model.Update();
            Response.Redirect("../weixing/example/JsApiPayPage.aspx?openid=" + tmodel.beizhu + "&total_fee=" + model.order_amount+"&orderNo=" + model.order_no.ToString());
        }
       

        
    #endregion
    }
}
