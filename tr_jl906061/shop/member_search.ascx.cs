using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class shop_member_search : System.Web.UI.UserControl
{
    public static string big_img;
   
    protected void Page_Load(object sender, EventArgs e)
    {
        logobind();//logo绑定

    }

    #region 新闻绑定=================================
    private void logobind()
    {




        tbl_sinkia_config bll = new tbl_sinkia_config();
        bll.GetModel(1);

        big_img = bll.logo_web_img;
        


    }
    #endregion
}