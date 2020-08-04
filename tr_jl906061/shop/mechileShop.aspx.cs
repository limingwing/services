using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class shop_mechileShop : A_BasePage
{
    ManagePage mym = new ManagePage();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["hy_id1"] == null)
        {
            Response.Write("<script language=javascript>alert('请重新登录！');top.location.href='login.aspx';</script>");
            Response.End();

        }
        tbl_huiyuan model = new tbl_huiyuan();
        model.GetModel_hui_id(Session["hy_id1"].ToString());
        this.Literal1.Text = double.Parse(model.chongfu_zong.ToString()).ToString();
        //this.Literal2.Text = double.Parse((model.jiangjin_zong - model.jiangjin_yong).ToString()).ToString();
        if (!Page.IsPostBack)
        {
            QDBind();
            RptBind();
        }
    }
    #region 数据绑定=================================
    private void RptBind()
    {
        //tbl_product bll = new tbl_product();
        //this.rptList.DataSource = bll.GetList(" flag=0 and pro_isok=1 order by salse_price asc");
        //this.rptList.DataBind();
    }
    #endregion
    #region 绑定级别=================================
    private void QDBind()
    {
        tbl_machine bll = new tbl_machine();
        DataTable dt = bll.GetList("1=1 order by id asc").Tables[0];
        this.huiyuan_jiebie.Items.Clear();
        this.huiyuan_jiebie.Items.Add(new ListItem("请选择打印机...", ""));
        foreach (DataRow dr in dt.Rows)
        {
            string Id = dr["id"].ToString();
            string Title = double.Parse(dr["price"].ToString()).ToString();
            this.huiyuan_jiebie.Items.Add(new ListItem(Title, Id));
        }
    }
    #endregion
    protected void btnSubmit_Click1(object sender, EventArgs e)
    {
        tbl_canshu canshu = new tbl_canshu();
        canshu.GetModel(1);

        tbl_xiaofei xf = new tbl_xiaofei();
        DataTable dt=xf.GetList(" 1=1 and xiaofei_hui_id='" + hy_id1 + "' and zhuce_flag=3 and xiaofei_qr_flag=1").Tables[0];
        int xg = Convert.ToInt32(canshu.canshu_009);
        if (dt.Rows.Count >= xg)
        {
            Response.Write("<script language=javascript>alert('限购数量" + Convert.ToInt32(canshu.canshu_009) + "台！');location.href='mechileShop.aspx';</script>");
            return;
        }
        //decimal can = decimal.Parse(canshu.canshu_035.ToString()) * 0.01m;
        //decimal xiaofei;
        string huiyuan_id = Session["hy_id1"].ToString();
        string sPassWord = this.pass_two.Value.Trim();
        if (!tbl_huiyuan.Exists_erji(hy_bianhao1, sPassWord))
        {
            Response.Write("<script language=javascript>alert('二级密码不正确！');location.href='mechileShop.aspx';</script>");
            return;

        }
        //if (this.xiaofei.Value.Trim() == "")
        //{
        //    xiaofei = 0;
        //}
        //else
        //{
        //    xiaofei = decimal.Parse(this.xiaofei.Value.Trim().ToString());
        //}
        tbl_huiyuan huiyuanmodel = new tbl_huiyuan();
        huiyuanmodel.GetModel_hui_id(huiyuan_id);
        int zuoyou = int.Parse(huiyuanmodel.zuoyou.ToString());
        //tbl_reg_jiebie jb = new tbl_reg_jiebie();
        //decimal yuan_money = jb.Get_Need_money(int.Parse(huiyuanmodel.huiyuan_jiebie.ToString()));
        decimal need_money = Convert.ToDecimal(this.huiyuan_jiebie.SelectedItem.Text);
        decimal bu_money = need_money;
        //decimal xiaofeineed = bu_money * can;
        //if (xiaofei > xiaofeineed)
        //{
        //    Response.Write("<script language=javascript>alert('可使用消费积分不超过" + xiaofeineed.ToString("0.00") + "！');history.go(-1);</script>");
        //    return;
        //}
        decimal sum_zong = 0, sum_pv = 0;
        //for (int x = 0; x < rptList.Items.Count; x++)
        //{
        //    TextBox cbx = (TextBox)rptList.Items[x].FindControl("shuliang");//数量
        //    Label textControl = (Label)rptList.Items[x].FindControl("Label2");//价格
        //    //Label Label1 = (Label)rptList.Items[x].FindControl("Label1");//PV
        //    if (int.Parse(cbx.Text) > 0)
        //    {
        //        sum_zong = sum_zong + decimal.Parse(textControl.Text) * decimal.Parse(cbx.Text);
        //        // sum_pv = sum_pv + decimal.Parse(Label1.Text) * decimal.Parse(cbx.Text);
        //    }



        //}
        //if (sum_zong == 0)
        //{
        //    Response.Write("<script language=javascript>alert('您还没选择产品！');history.go(-1);</script>");
        //    return;
        //}

        //if (bu_money != sum_zong)
        //{
        //    Response.Write("<script language=javascript>alert('您选择的产品和注册级别不符！');history.go(-1);</script>");
        //    return;
        //}
        //int yuan_jb = int.Parse(huiyuanmodel.huiyuan_jiebie.ToString());
        //int new_jb = int.Parse(this.huiyuan_jiebie.SelectedValue);
        //if (new_jb <= yuan_jb)
        //{
        //    Response.Write("<script language=javascript>alert('不能小于原有级别！');location.href='mechileShop.aspx';</script>");
        //    return;
        //}
        decimal nowMoney = decimal.Parse(huiyuanmodel.chongfu_zong.ToString());
        //decimal nowMoney1 = decimal.Parse((huiyuanmodel.jiangjin_zong - huiyuanmodel.jiangjin_yong).ToString());
        if (nowMoney >= bu_money)
        {

            huiyuanmodel.huiyuan_id = hy_id1;
            huiyuanmodel.huiyuan_jiebie = int.Parse(this.huiyuan_jiebie.SelectedValue);
            huiyuanmodel.chongfu_zong -= bu_money;
            huiyuanmodel.Update();
        }
        else
        {
            Response.Write("<script language=javascript>alert('奖励积分不足！');location.href='mechileShop.aspx';</script>");
            return;
        }

        //if (sum_zong > 0)
        //{
        //    tbl_orders model = new tbl_orders();
        //    model.order_no = Utils.GetOrderNumber(); //订单号B开头为商品订单
        //    model.user_id = huiyuan_id;
        //    model.user_bianhao = huiyuanmodel.huiyuan_bianhao;
        //    //  model.depot_category_id = depot_category_id;
        //    //  model.depot_id = depot_id;
        //    model.user_name = huiyuanmodel.huiyuan_name;
        //    model.payment_id = 3;//支付方式
        //    //model.message = message.Text;
        //    model.payable_amount = sum_zong;
        //    model.real_amount = 0;
        //    model.phone = huiyuanmodel.huiyuan_mob;
        //    model.address = huiyuanmodel.huiyuan_address;
        //    model.payment_status = 2;
        //    //订单总金额=实付商品金额
        //    model.order_amount = sum_zong;//pv总值
        //    model.add_time = DateTime.Now;
        //    if (model.Add() == 0)
        //    {
        //        Response.Write("<script language=javascript>alert('保存失败！');history.go(-1);</script>");
        //        return;
        //    }
        //    tbl_order_goods gls = new tbl_order_goods();
        //    tbl_product my = new tbl_product();
        //    for (int x = 0; x < rptList.Items.Count; x++)
        //    {

        //        int id = Convert.ToInt32(((HiddenField)rptList.Items[x].FindControl("hidId")).Value);
        //        TextBox cbx = (TextBox)rptList.Items[x].FindControl("shuliang");//数量
        //        if (int.Parse(cbx.Text) > 0)
        //        {
        //            my.GetModel(id);
        //            gls.order_id = model.GetMaxId();
        //            gls.goods_id = id;
        //            gls.goods_title = my.pro_name;
        //            gls.goods_price = my.go_price;
        //            gls.real_price = my.go_price;
        //            gls.quantity = int.Parse(cbx.Text);
        //            gls.product_category_id = my.pro_pid;
        //            gls.dw = my.pro_danwei;
        //            gls.Add();

        //        }
        //        //TextBox cbx = (TextBox)rptList.Items[x].FindControl("shuliang");//数量
        //        //Label textControl = (Label)rptList.Items[x].FindControl("Label2");//价格

        //    }

        tbl_xiaofei model_xf = new tbl_xiaofei();
        model_xf.xiaofei_hui_id = huiyuan_id;
        model_xf.xiaofei_money = bu_money;
        model_xf.xiaofei_money1 = sum_zong;
        model_xf.zhuce_flag = 3;
        model_xf.xiaofei_qr_date = DateTime.Now;
        model_xf.xiaofei_qr_flag = 1;
        model_xf.jiebie = int.Parse(this.huiyuan_jiebie.SelectedValue);
        if (model_xf.Add() > 0)
        {
            //tbl_mechileShop tsj = new tbl_mechileShop();
            //tsj.huiyuan_bianhao = hy_bianhao1;
            //tsj.huiyuan_id = hy_id1;
            //tsj.huiyuan_jiebie = yuan_jb;
            //tsj.huiyuan_jiebie_name = new tbl_reg_jiebie().GetTitle(Convert.ToInt32(yuan_jb));
            //tsj.sj_date = DateTime.Now;
            //tsj.sj_jiebie = int.Parse(this.huiyuan_jiebie.SelectedValue);
            //tsj.sj_jiebie_name = new tbl_reg_jiebie().GetTitle(Convert.ToInt32(this.huiyuan_jiebie.SelectedValue));
            //tsj.sj_money = bu_money;
            //tsj.Add();

            //DbHelperSQL.ExecuteSql("exec sp_kt002 '" + hy_id1 + "'," + bu_money + "");

            decimal moneyafter2 = nowMoney - bu_money;//改变后余额

            string memo = "会员" + hy_bianhao1 + "购买打印机" + bu_money + "元";

            mym.queren_insert(hy_id1, hy_bianhao1, "购买打印机", memo, -bu_money, moneyafter2);

            //int i = DbHelperSQL.ExecuteSql("exec sp_kt003 '" + huiyuan_id + "',"+bu_money+"");

            //int i1 = DbHelperSQL.ExecuteSql("exec sp_kt004 '" + huiyuan_id + "'," + bu_money + "");
            //int i2 = DbHelperSQL.ExecuteSql("exec sp_kt005 '" + huiyuan_id + "'," + bu_money + "");
            //int i3 = DbHelperSQL.ExecuteSql("exec sp_kt006 '" + huiyuan_id + "'," + bu_money + "");
            Response.Write("<script language=javascript>alert('购买成功！');location.href='mechileShop.aspx';</script>");
            return;
        }

        //}
    }
    //protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    //{
    //    tbl_huiyuan tbll = new tbl_huiyuan();
    //    tbll.GetModel_hui_id(hy_id1);

    //    tbl_reg_jiebie jb = new tbl_reg_jiebie();
    //    decimal yuan_money = jb.Get_Need_money(int.Parse(tbll.huiyuan_jiebie.ToString()));
    //    decimal need_money = jb.Get_Need_money(int.Parse(this.huiyuan_jiebie.SelectedValue));
    //    decimal bu_money = need_money - yuan_money;
    //    if (bu_money <= 0)
    //    {
    //        Response.Write("<script language=javascript>alert('不能低于原有级别！');history.go(-1);</script>");
    //        return;
    //    }
    //    //this.Label2.Text = (need_money - yuan_money).ToString();
    //}
}