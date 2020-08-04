using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class manager_product_order_edit : System.Web.UI.Page
{
    protected int page;
    private string action = ""; //操作类型
    public int id = 0;
    ManagePage mym = new ManagePage();
    protected tbl_orders model = new tbl_orders();

    protected void Page_Load(object sender, EventArgs e)
    {
        //判断是否登录
        if (!mym.IsAdminLogin())
        {
            Response.Write("<script>parent.location.href='../login.aspx'</script>");
            Response.End();
        }
        //判断权限
        tbl_admin_role_value myrv = new tbl_admin_role_value();
        int role_id = Convert.ToInt32(Session["RoleID"]);
        int nav_id = 22;
        if (!myrv.QXExists(role_id, nav_id))
        {
            Response.Redirect("../error.html");
            Response.End();
        }
        string _action = AXRequest.GetQueryString("action");
        this.page = AXRequest.GetQueryInt("page", 1);
        if (!string.IsNullOrEmpty(_action) && _action == "Edit")
        {
            this.action = "Edit";//修改类型
            if (!int.TryParse(Request.QueryString["id"] as string, out this.id))
            {
                mym.JscriptMsg(this.Page, "传输参数不正确！", "back", "Error");
                return;
            }

        }
        if (!Page.IsPostBack)
        {
            if (action == "Edit") //修改
            {
                ShowInfo(this.id);
            }
        }

    }

    #region 赋值操作=================================
    private void ShowInfo(int _id)
    {
        model.GetModel(_id);
        //绑定商品列表
        tbl_order_goods bll = new tbl_order_goods();
        string sql = " order_id =" + _id;

        DataTable dt = bll.GetList(sql).Tables[0];
        this.rptList.DataSource = dt;
        this.rptList.DataBind();

        //获得商家信息
        if (model.user_id != null)
        {
            tbl_huiyuan user_info = new tbl_huiyuan();
            user_info.GetModel_hui_id(model.user_id);
            user_name.Text = model.user_bianhao;
            title.Text = model.user_bianhao;
            contact_address.Text = model.address;
            contact_name.Text = model.shouhuo_name;
            contact_tel.Text = model.phone;
            wuliu_company.Text = model.wuliu_company;
            wuliu_no.Text = model.wuliu_no;
        }
        //根据订单状态，显示各类操作按钮
        switch (model.status)
        {
            case 1: //订单为已生成状态     
                //确认订单、取消订单显示
                btnConfirm.Visible = btnCancel.Visible = true;
                //修改订单备注、调价按钮显示
                btnEditRemark.Visible = btnEditPaymentFee.Visible = true;
                break;
            case 2: //如果订单为已确认状态
                //完成显示
                btnComplete.Visible = true;
                //修改订单备注按钮可见
                btnEditRemark.Visible = true;
                break;

        }
        this.zf_type.Text = zhifu_type(model.payment_id);
        this.contact_ly.Text = model.message;
      
    }
    #endregion

    protected string zhifu_type(int? _id)
    {
        string _title = string.Empty;

        switch (_id)
        {
            case 1:
                _title = "零售单";
                break;
            case 2:
                _title = "重销单";
                break;
            case 3:
                _title = "增值单";
                break;

        }

        return _title;
    }
    protected string zhifu_type1(int? _id)
    {
        string xiaofeimoney;
        string xiaofeimoney1;
        DataRow dr = DbHelperSQL.GetDataRow("select aa=isnull(xiaofei_zhuanmai,0) from tbl_xiaofei where xiaofei_qr_flag=1 and xiaofei_flag_jiezhang=" + _id + "");
        if (dr != null)
        {
            xiaofeimoney1 = dr["aa"].ToString();//放置人huiyuan_id
            tbl_huiyuan huiyuan=new tbl_huiyuan();
            huiyuan.GetModel_hui_id(xiaofeimoney1);
            xiaofeimoney = huiyuan.huiyuan_bianhao;
        }
        else
        {
            xiaofeimoney = "";
        }
        return xiaofeimoney;
    }
}