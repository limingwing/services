using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class shop_index_top : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

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