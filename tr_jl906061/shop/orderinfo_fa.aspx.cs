using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Web.UI.WebControls;

public partial class shop_orderinfo_fa : System.Web.UI.Page
{
    private int id = 0;
    protected tbl_orders model = new tbl_orders();
    public static string fh_num = string.Empty;
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

            ShowInfo(this.id);

            show_address(Session["hy_id1"].ToString());
             

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
    private void ShowInfo(int _id)
    {
        model.GetModel(_id);
        if (model.status == 2)
        {
            this.msg.Attributes.Add("style", "display:none");
        }
        //绑定商品列表
        tbl_order_goods bll = new tbl_order_goods();
        string sql = " order_id =" + _id;

        DataTable dt = bll.GetList(sql).Tables[0];
        this.Repeater3.DataSource = dt;
        this.Repeater3.DataBind();

        
        this.zong_price.Text = model.payable_amount.ToString();
        this.dd_no.Text = model.order_no.ToString();
        this.add_time.Text = model.add_time.ToString();
        fh_num = model.wuliu_no.ToString();
        this.shouhuo_name.Text = model.shouhuo_name.ToString();
        this.mob.Text = model.phone.ToString();

        this.status.Text = new tbl_orders().GetOrderStatus(Convert.ToInt32(model.status.ToString()));
    }
    #endregion


   
    protected void LinkButton1_Click(object sender, EventArgs e)
    {

        model.GetModel(this.id);
        if (model.status == 3)
        {
            Response.Write("<script language=javascript>alert('已经确认收货，请不要重复操作！');history.go(-1);</script>");
            return;
            
        }

      

        model.status = 3;
       


        if (model.Update())
        {
            Response.Write("<script language=javascript>alert('收货成功！');location.href='orderSend.aspx';</script>");
            return;
        }
    }

    #region 返回订单状态=============================
    protected bool isshow(int _id)
    {
        bool status = false;

        switch (_id)
        {
            case 1:
                status = false;
                break;
            case 2:
                status = true;
                break;
            case 3:
                status = false;
                break;

        }

        return status;
    }
    #endregion
    protected void Button1_Click(object sender, EventArgs e)
    {
        string com=this.txtName.Value.Trim();
        string sn=this.txtSn.Value.Trim();
        model.GetModel(this.id);
        if (string.IsNullOrEmpty(com))
        {
            Response.Write("<script language=javascript>alert('请填写物流公司！');history.go(-1);</script>");
            return;

        }
        if (string.IsNullOrEmpty(sn))
        {
            Response.Write("<script language=javascript>alert('请填写物流单号！');history.go(-1);</script>");
            return;

        }
        if (model.status == 2)
        {
            Response.Write("<script language=javascript>alert('已经发货，请不要重复操作！');history.go(-1);</script>");
            return;

        }
        model.wuliu_company = com;
        model.wuliu_no = sn;
        model.status = 2;



        if (model.Update())
        {
            Response.Write("<script language=javascript>alert('发货成功！');location.href='orderSend.aspx';</script>");
            return;
        }
    }
}