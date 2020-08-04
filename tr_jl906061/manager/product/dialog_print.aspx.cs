using System;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class manager_product_dialog_print : System.Web.UI.Page
{
    private string order_no = string.Empty;
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
        order_no = AXRequest.GetQueryString("order_no");
        if (order_no == "")
        {
            mym.JscriptMsg(this.Page, "传输参数不正确！", "back", "Error");
            return;
        }
        if (!new tbl_orders().Exists(order_no))
        {
            mym.JscriptMsg(this.Page, "订单不存在或已被删除！", "back", "Error");
            return;
        }
        if (!Page.IsPostBack)
        {
            ShowInfo(order_no);
        }
    }

    #region 赋值操作=================================
    private void ShowInfo(string _order_no)
    {
        model.GetModel(_order_no);

        tbl_order_goods bll = new tbl_order_goods();
        string sql = " order_id =" + model.id;
        DataTable dt = bll.GetList(sql).Tables[0];
        this.rptList.DataSource = dt;
        this.rptList.DataBind();
        //获得商家信息
        //获得商家信息
        if (model.user_id != null)
        {
            tbl_huiyuan user_info = new tbl_huiyuan();
            user_info.GetModel_hui_id(model.user_id);
            
            title.Text = model.user_bianhao;
            contact_address.Text = model.address;
            contact_name.Text = model.shouhuo_name;
            contact_tel.Text = model.phone;
        }
    }
    #endregion
}