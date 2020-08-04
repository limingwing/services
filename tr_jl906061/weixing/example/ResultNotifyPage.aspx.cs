using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class weixing_example_ResultNotifyPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
        ResultNotify resultNotify = new ResultNotify(this);
        resultNotify.ProcessNotify();
    }    
}