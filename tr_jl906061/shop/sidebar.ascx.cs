using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class shop_sidebar : System.Web.UI.UserControl
{

    public static string qq;
    public static string mp_qrcode;
    protected void Page_Load(object sender, EventArgs e)
    {

        bind();



    }

    #region 基本数据绑定=================================
    private void bind()
    {


        if (Session["hy_bianhao1"] != null)
        {

            Literal1.Text = "用户名" + Session["hy_bianhao1"].ToString();

        }
        else
        {
            Literal1.Text = "您还未登录";
        
        }
        Literal2.Text = "VIP会员";

        tbl_sinkia_config config = new tbl_sinkia_config();
        config.GetModel(1);
        qq = config.home_qq.ToString();
        mp_qrcode = config.home_code.ToString();


    }
    #endregion
}