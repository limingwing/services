using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Template_muban2_MasterPage : System.Web.UI.MasterPage
{
    tbl_canshu model = new tbl_canshu();
    public string title = string.Empty;
    protected void Page_Load(object sender, EventArgs e)
    {
        
        model.GetModel(1);
        title = model.sys_name;
       
    }
}
