using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class shop_footer : System.Web.UI.UserControl
{
    public static string copy_right;
    protected void Page_Load(object sender, EventArgs e)
    {

        help_bind();

    }


    #region 帮助中心绑定=================================
    private void help_bind()
    {




        tbl_sinkia_help bll = new tbl_sinkia_help();
        this.Repeater3.DataSource = bll.GetList(" 1=1   order by sort_id asc");
        this.Repeater3.DataBind();
        tbl_sinkia_config config = new tbl_sinkia_config();
        config.GetModel(1);
        copy_right = config.home_copyright;



    }
    #endregion
}