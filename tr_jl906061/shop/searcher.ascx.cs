using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class shop_searcher : System.Web.UI.UserControl
{
    public static string big_img;
    public static string mob_img;
    protected void Page_Load(object sender, EventArgs e)
    {
        logobind();//logo绑定

    }

    #region logo绑定=================================
    private void logobind()
    {




        tbl_sinkia_config bll = new tbl_sinkia_config();
        bll.GetModel(1);

        big_img = bll.logo_web_img;
        mob_img = bll.logo_mobel_img;


    }
    #endregion
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("bai");
    }
}