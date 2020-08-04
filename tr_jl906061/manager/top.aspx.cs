using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class manager_top : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //判断是否登录
        ManagePage mym = new ManagePage();
        if (!mym.IsAdminLogin())
        {
            Response.Write("<script>parent.location.href='login.aspx'</script>");
            Response.End();
        }
        if (!IsPostBack)
        {
            Lit_Name.Text = Session["hy_name"].ToString();
        }
    }

    //安全退出
    protected void lbtnExit_Click(object sender, EventArgs e)
    {
        Utils.WriteCookie("hy_id", "AoXiang", -14400);
        Utils.WriteCookie("hy_bianhao", "AoXiang", -14400);
        Utils.WriteCookie("hy_name", "AoXiang", -14400);
        Utils.WriteCookie("RoleID", "AoXiang", -14400);

 

        Session["hy_id"] = null;
        Session["hy_bianhao"] = null;
        Session["hy_name"] = null;
        Session["RoleID"] = null;
        

        Response.Write("<script>parent.location.href='login.aspx'</script>");
        Response.End();
    }
}