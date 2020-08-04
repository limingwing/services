using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class manager_yeji_beizhu : System.Web.UI.Page
{
    private int id = 0;
    ManagePage mym = new ManagePage();
    protected void Page_Load(object sender, EventArgs e)
    {
        //判断是否登录
        if (!mym.IsAdminLogin())
        {
            Response.Write("<script>parent.location.href='../login.aspx'</script>");
            Response.End();
        }
        // int id =int.Parse(Utils.Decrypt(Request.QueryString["id"]));

        if (!int.TryParse(Request.QueryString["id"] as string, out this.id))
        {
            mym.JscriptMsg(this.Page, "传输参数不正确！", "back", "Error");
            return;
        }

        if (!Page.IsPostBack)
        {
            ShowInfo(this.id);
        }
    }

    #region 赋值操作=================================
    private void ShowInfo(int _id)
    {
        tbl_xiaofei model = new tbl_xiaofei();
        model.GetModel_id(_id);
        LitAddTime.Text = model.xiaofei_id.ToString();
        LitClickCount.Text = model.xiaofei_date.ToString();

        LitContent.Text = model.xiaofei_memo.ToString();
 

    }
    #endregion
}