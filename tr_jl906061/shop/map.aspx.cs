using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class shop_map : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string ak=HttpContext.Current.Request.QueryString["ak"].ToString();
            tbl_supplier supplier = new tbl_supplier();
            supplier.GetModel(Convert.ToInt32(ak));
            this.lblAddress.InnerHtml = supplier.supplyAddress;
        }
    }
}