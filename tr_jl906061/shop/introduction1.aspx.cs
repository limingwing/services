﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;

public partial class shop_introduction1 : System.Web.UI.Page
{
    private int id = 0;
    public static string pro_imgs, pro_imgs1, pro_imgs2;

    protected int totalCount;//分页
    protected int page;     //分页
    protected int pageSize;     //分页
    protected int pro_id;
    protected int kid;
    protected void Page_Load(object sender, EventArgs e)
    {
        this.pageSize = GetPageSize(2); //每页数量
        this.pro_id = AXRequest.GetQueryInt("pro_id");
        this.kid = AXRequest.GetQueryInt("id");

        if (!Page.IsPostBack)
        {
            if (!int.TryParse(Request.QueryString["pro_id"] as string, out this.id))
            {
                Response.Write("<script language=javascript>alert('参数不正确！');top.location.href='index.aspx';</script>");
                Response.End();
            }
            ShowInfo(this.pro_id,kid);
            RptBind("   pro_isok=1 and pro_pid=(select pro_pid from tbl_product where pro_id=" + this.pro_id + ")", "pro_id asc,pro_date desc");//绑定喜欢产品

            hotbind();//热卖绑定
            bindrptarry();  //属性绑定
        }
    }

    #region 绑定属性=================================
    public void bindrptarry()
    {
        tbl_product bll = new tbl_product();
        bll.GetModel(this.pro_id);


        int shuxing_pid = int.Parse(bll.pro_level.ToString());
        tbl_sinkia_attribute att = new tbl_sinkia_attribute();
        att.GetModel(shuxing_pid);
        string strs = "";
        if (att.attribute_name != null && att.attribute_name.ToString().Length > 0)
        {
            strs = att.attribute_value.ToString();

        }
        else
        {
            strs = "暂无";
        }
        //2.按照 | 标记将字符串分为三个字符串并赋值给str数组  
        string[] str = strs.Split('|');

        //3.Repeater绑定数组  
        Repeater1.DataSource = str;
        Repeater1.DataBind();

        DataTable dt = new DataTable();
        dt.Columns.Add("AttrStr", typeof(string));
        dt.Columns.Add("AttrPrice", typeof(string));
        DataRow dr = dt.NewRow();


        dr["AttrStr"] = "折扣";
        dr["AttrPrice"] = Convert.ToDecimal(bll.shop_fen.ToString()).ToString("n2");
        dt.Rows.Add(dr.ItemArray);  //数组填充dr
        //tbl_huiyuan hui = new tbl_huiyuan();
        //if (Session["hy_id1"] != null)
        //{
        //    hui.GetModel_hui_id(Session["hy_id1"].ToString());
        //    if (hui.net_hege == 1)
        //    {
        //        dr["AttrStr"] = "三折";
        //        dr["AttrPrice"] = (Convert.ToDecimal(bll.salse_price.ToString()) * 0.3m).ToString("n2");
        //        dt.Rows.Add(dr.ItemArray);  //数组填充dr
        //    }
        //}

        Repeater2.DataSource = dt;
        Repeater2.DataBind();


    }
    #endregion
    #region 绑定新闻=================================
    private void hotbind()
    {





        tbl_product bll = new tbl_product();
        this.hot.DataSource = bll.GetList_top_1(" pro_isok=1      order by pro_date desc", 5);
        this.hot.DataBind();



    }
    #endregion
    private void ShowInfo(int _id, int kid)
    {
        tbl_product model = new tbl_product();

        model.GetModel(_id);
        //this.go_price.Text = model.go_price.ToString();
        this.sale_price.Text = decimal.Parse((model.shop_fen * 1m).ToString()).ToString("n2");
        this.pro_title.Text = model.pro_name.ToString();
        this.Literal1.Text = model.shop_fen.ToString();
        pro_imgs = model.pro_imgs.ToString();
        pro_imgs1 = model.pro_imgs1.ToString();
        pro_imgs2 = model.pro_imgs2.ToString();

        this.pro_content.Text = model.pro_memo.ToString();
        // this.zhuImage.ImageUrl = model.pro_imgs;
        // this.zhuImage1.ImageUrl = model.pro_imgs;
        //this.hidLI.Value = "暂无";
        //this.hidLP.Value = model.salse_price.ToString();

        tbl_Seckill kill = new tbl_Seckill();
        kill.GetModel(kid);
        this.Stock.InnerText = this.Stock1.InnerText = "限购" + kill.LimitQTY + "件";
        this.B1.InnerHtml = kill.StartTime + "~" + kill.EndTime;
        if (DateTime.Now < kill.StartTime)
        {
            this.LinkButton1.Text = this.LinkButton3.Text = "暂未开始";
            this.LinkButton1.Enabled = this.LinkButton3.Enabled = false;
            this.LinkButton2.Text = this.LinkButton4.Text = "00:00:00";
            this.LinkButton4.Enabled = this.LinkButton2.Enabled = false;
        }
        else if (DateTime.Now > kill.EndTime)
        {
            this.LinkButton1.Text = this.LinkButton3.Text = "秒杀结束";
            this.LinkButton1.Enabled = this.LinkButton3.Enabled = false;
            this.LinkButton2.Text = this.LinkButton4.Text = "00:00:00";
            this.LinkButton4.Enabled = this.LinkButton2.Enabled = false;
        }
    }

    #region 组合SQL查询语句==========================
    protected string CombSqlTxt(int _pro_id)
    {
        StringBuilder strTemp = new StringBuilder();

        if (_pro_id > 0)
        {
            strTemp.Append(" and pro_id=" + _pro_id);
        }


        return strTemp.ToString();
    }
    #endregion
    #region 数据绑定=================================
    private void RptBind(string _strWhere, string _orderby)
    {
        this.page = AXRequest.GetQueryInt("page", 1);



        tbl_product bll = new tbl_product();
        this.rptList.DataSource = bll.GetList_top(8, this.pageSize, this.page, _strWhere, _orderby, out this.totalCount);
        this.rptList.DataBind();


        //绑定页码
        //txtPageNum.Text = this.pageSize.ToString();
        string pageUrl = Utils.CombUrlTxt("introduction.aspx", "page={0}&pro_id={1}", "__id__", this.pro_id.ToString());
        PageContent.InnerHtml = Utils.OutPageList(this.pageSize, this.page, this.totalCount, pageUrl, 8);
    }
    #endregion


    #region 返回每页数量=============================
    private int GetPageSize(int _default_size)
    {
        int _pagesize;
        if (int.TryParse(Utils.GetCookie("jiangjin_page_size"), out _pagesize))
        {

            if (_pagesize > 0)
            {
                return _pagesize;
            }
        }
        return _default_size;
    }
    #endregion



    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        int goods_quantity = int.Parse(this.text_box.Value);
        if (Session["hy_id1"] == null)
        {
            Response.Write("<script language=javascript>alert('请重新登录！');top.location.href='login.aspx';</script>");
            Response.End();

        }
        if (string.IsNullOrEmpty(this.hidLI.Value.ToString()) || string.IsNullOrEmpty(this.hidLP.Value.ToString()))
        {
            Response.Write("<script language=javascript>alert('请选择产品折扣和规格！');history.go(-1);</script>");
            Response.End();
        }
        tbl_product modelp = new tbl_product();

        modelp.GetModel(this.pro_id);


        string user_bianhao = string.Empty;
        string user_name = string.Empty;
        string user_id = string.Empty;
        user_id = Session["hy_id1"].ToString();

        user_bianhao = Session["hy_bianhao1"].ToString();

        user_name = Session["hy_name1"].ToString();

        tbl_huiyuan huiyuanmodel = new tbl_huiyuan();
        huiyuanmodel.GetModel_hui_id(user_id);

        tbl_orders model = new tbl_orders();
        string order_no = Utils.GetOrderNumber(); //订单号B开头为商品订单
        model.order_no = order_no; //订单号B开头为商品订单
        model.user_id = user_id;
        model.user_bianhao = user_bianhao;
        //  model.depot_category_id = depot_category_id;
        //  model.depot_id = depot_id;
        model.user_name = user_name;
        model.payment_id = 1;//未支付
        //model.message = message.Text;
        model.payable_amount = decimal.Parse(this.hidLP.Value.ToString()) * goods_quantity;
        model.real_amount = decimal.Parse(this.hidLP.Value.ToString()) * goods_quantity;
        model.phone = huiyuanmodel.huiyuan_mob;
        model.address = huiyuanmodel.huiyuan_address;
        model.status = 1;
        model.payment_status = 1;//未支付
        if (modelp.salse_price != decimal.Parse(this.hidLP.Value.ToString()))
            model.flag = 3;//打折购买
        //订单总金额=实付商品金额
        model.order_amount = decimal.Parse(this.hidLP.Value.ToString()) * goods_quantity;
        model.add_time = DateTime.Now;

        if (model.Add() == 0)
        {

            Response.Write("<script language=javascript>alert('订单保存过程中发生错误，请重新提交！');location.href='shopcart.aspx';</script>");
            return;

        }

        int GetMaxId = model.GetMaxId();
        //商品详细列表
        tbl_order_goods gls = new tbl_order_goods();

        gls.order_id = GetMaxId;
        gls.goods_id = this.pro_id;
        gls.goods_title = modelp.pro_name;
        gls.goods_price = modelp.go_price;
        gls.real_price = decimal.Parse(this.hidLP.Value.ToString());
        gls.quantity = goods_quantity;
        gls.product_category_id = modelp.pro_pid;

        gls.shuxing = this.hidLI.Value;
        gls.Add();

        Response.Redirect("pay.aspx?order_id=" + GetMaxId + "");
        return;

    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {


        if (Session["hy_id1"] == null)
        {
            Response.Write("<script language=javascript>alert('请重新登录！');top.location.href='login.aspx';</script>");
            Response.End();

        }
        if (string.IsNullOrEmpty(this.hidLI.Value.ToString()) || string.IsNullOrEmpty(this.hidLP.Value.ToString()))
        {
            Response.Write("<script language=javascript>alert('请选择产品折扣和规格！');history.go(-1);</script>");
            Response.End();
        }
        int goods_quantity = int.Parse(this.text_box.Value);
        if (this.pro_id.ToString() == "")
        {
            Response.Write("<script language=javascript>alert('参数不正确！');top.location.href='index.aspx';</script>");
            Response.End();
        }
        ShopCart.Add(this.pro_id.ToString() + '|' + this.hidLI.Value + '|' + decimal.Parse(this.hidLP.Value.ToString()), goods_quantity);
        cart_total cartModel = ShopCart.GetTotal();
        Response.Write("<script language=javascript>alert('加入购物车成功！');top.location.href='introduction.aspx?pro_id=" + this.pro_id.ToString() + "';</script>");
        Response.End();
    }
}