using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class shop_shopcart : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (Session["hy_id1"] == null)
            {
                Response.Write("<script language=javascript>alert('请重新登录！');top.location.href='login.aspx';</script>");
                Response.End();

            }
            RptBind();
        }
    }

    #region 数据绑定=================================
    private void RptBind()
    {
        ShopCart bll = new ShopCart();
        IList<cart_items> ls1 = bll.get_cart_list();
        this.rptList.DataSource = ls1;
        this.rptList.DataBind();
        cart_total cartModel = ShopCart.GetTotal();
        total_quantity.Text = cartModel.total_quantity.ToString();
        payable_amount.Text = cartModel.payable_amount.ToString("n2");
        //payable_amount1.Text = cartModel.payable_amount.ToString();
    }
    #endregion

    //小数位是0的不显示
    public string MyConvert(object d)
    {
        string myNum = d.ToString();
        string[] strs = d.ToString().Split('.');
        if (strs.Length > 1)
        {
            if (Convert.ToInt32(strs[1]) == 0)
            {
                myNum = strs[0];
            }
        }
        return myNum;
    }

 

    protected void LinkButton1_Click(object sender, EventArgs e)//提交订单
    {
        string user_id = "";
        int depot_category_id = 0;
        int depot_id = 0;
        string user_bianhao = string.Empty;
        string user_name = string.Empty;
        user_id = Session["hy_id1"].ToString();

        user_bianhao = Session["hy_bianhao1"].ToString();

        user_name = Session["hy_name1"].ToString();

        //检查购物车商品
        IList<cart_items> iList = ShopCart.GetList();
        if (iList == null)
        {

            Response.Write("<script language=javascript>alert('对不起，购物车为空，无法结算！！');location.href='index.aspx';</script>");
            return;

        }

        //统计购物车
        cart_total cartModel = ShopCart.GetTotal();
        //判断是否有商品
        if (cartModel.payable_amount == 0)
        {
            Response.Write("<script language=javascript>alert('对不起，购物车为空，无法结算！！');location.href='index.aspx';</script>");
            return;
        }
        //判断该员工是否有足够消费比支付

        //tbl_huiyuan model1 = new tbl_huiyuan();
        //model1.GetModel_hui_id(user_id);
        //decimal qianbao = decimal.Parse(model1.fh_money.ToString());
        //decimal moneybefore = decimal.Parse((model1.chongfu_money).ToString());//改变前余额
        //string memo = "员工购物消费" + cartModel.payable_amount + "元";
        //decimal moneyafter = moneybefore - cartModel.payable_amount;//改变后余额
        //if (qianbao < cartModel.payable_amount)
        //{

        //    Response.Write("<script language=javascript>alert('购物币不足，请联系管理员充值！');location.href='shopping.aspx';</script>");
        //    return;

        //}
        //mym.queren_insert(user_id, user_bianhao, "购物", memo, cartModel.payable_amount, moneyafter);
        //保存订单=======================================================================
        tbl_orders model = new tbl_orders();
        string order_no = Utils.GetOrderNumber(); //订单号B开头为商品订单
        model.order_no = order_no; //订单号B开头为商品订单
        model.user_id = user_id;
        model.user_bianhao = user_bianhao;
        //  model.depot_category_id = depot_category_id;
        //  model.depot_id = depot_id;
        model.user_name = user_name;
        model.payment_id = 1; 
        //model.message = message.Text;
        model.payable_amount = cartModel.payable_amount;
        model.real_amount = cartModel.payable_amount;

        //订单总金额=实付商品金额
        model.order_amount = cartModel.payable_amount;
        model.add_time = DateTime.Now;
        model.payment_status = 1;//未付款
        if (model.Add() == 0)
        {

            Response.Write("<script language=javascript>alert('订单保存过程中发生错误，请重新提交！');location.href='shopcart.aspx';</script>");
            return;

        }
        int GetMaxId = model.GetMaxId();
        //商品详细列表
        tbl_order_goods gls = new tbl_order_goods();
        tbl_product my = new tbl_product();
        decimal all_money = 0;
        foreach (cart_items item in iList)
        {
            my.GetModel(item.id);
            gls.order_id = GetMaxId;
            gls.goods_id = item.id;
            gls.goods_title = item.title;
            gls.goods_price = my.go_price;
            gls.real_price = item.price;
            gls.quantity = item.quantity;
            gls.product_category_id = item.product_category_id;
            gls.dw = item.dw;
            gls.shuxing = item.shuxing;
            gls.Add();
            my.pro_sum = my.pro_sum + item.quantity;//已售出多少？
            my.Update();
            all_money += decimal.Parse((my.go_price * item.quantity).ToString());


        }
        model.GetModel(order_no);
        if (all_money != model.order_amount)
        {
            model.flag = 1;//打折购买
            model.Update();
        }
        //tbl_huiyuan tmodel = new tbl_huiyuan();
        //tmodel.GetModel_hui_id(user_id);
        //tmodel.fh_money = tmodel.fh_money - cartModel.payable_amount;
        //tmodel.Update();


        //清空购物车
        ShopCart.Clear("0");
        //提交成功，返回URL
        Response.Redirect("pay.aspx?order_id=" + GetMaxId + "");
        //Response.Write("<script language=javascript>alert('恭喜您，订单已成功提交！');location.href='pay.aspx';</script>");
        return;
    }
}