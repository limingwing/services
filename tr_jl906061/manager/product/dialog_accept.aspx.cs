using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class manager_product_dialog_accept : System.Web.UI.Page
{

    protected tbl_orders model = new tbl_orders();
    protected void Page_Load(object sender, EventArgs e)
    {
        DataBind();
    }

}