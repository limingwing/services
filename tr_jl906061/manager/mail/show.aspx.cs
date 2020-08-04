using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class manager_mail_show : System.Web.UI.Page
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
        tbl_liuyan model = new tbl_liuyan();
        model.GetModel(_id);
        Littitle.Text = model.liuyan_title;
        LitContent.Text = model.liuyan_memo;
        LitAddTime.Text = Convert.ToDateTime(model.liuyan_date).ToString("yyyy-MM-dd HH:mm:ss");
   

        //更新
        if (model.kan_flag == 0)
        {
            int click = 1;
            model.UpdateField(id, "kan_flag=" + click);
        }

    }
    #endregion
}