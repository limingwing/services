using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class shop_left : System.Web.UI.UserControl
{
    public int flag_4;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            tbl_huiyuan tb = new tbl_huiyuan();
            tb.GetModel_hui_id(Session["hy_id1"].ToString());
            //if (tb.supply != 0)
            //    liSupply.Visible = false;
            //if (tb.supply != 2)
            //    lis.Visible = false;
            if (Session["flag4"] != null)
            {
                flag_4 = int.Parse(Session["flag4"].ToString());
            }
            else
            {
                flag_4 = 0;
            }
            if (tb.net_hege == 0)
            {
                this.li1.Visible = false;
                this.li2.Visible = false;
                //this.li3.Visible = false;
                //this.li4.Visible = false;
                //this.lis.Visible = false;
                //this.liSupply.Visible = false;
            }
            else
            {
                if (string.IsNullOrEmpty(tb.zl_pinju_src.ToString()) || string.IsNullOrEmpty(tb.sf_pinju_src.ToString()))
                {
                    //this.info1.Visible = false;
                    //this.li6.Visible = false;
                }
                else
                {
                    this.info.Visible = false;
                    if (tb.huiyuan_jiebie == 2)
                    {
                        //this.li6.Visible = false;
                    }
                    else
                    {
                        //this.li3.Visible = false;
                        //this.li5.Visible = false;
                    }
                }
            }
        }
    }
}