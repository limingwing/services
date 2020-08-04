using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class manager_news_show : System.Web.UI.Page
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
   
        if (!int.TryParse(Utils.Decrypt(Request.QueryString["id"]) as string, out this.id))
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
        tbl_news model = new tbl_news();
        model.GetModel(_id);
        Littitle.Text = model.title;
        LitContent.Text = model.memo;
        LitAddTime.Text = Convert.ToDateTime(model.news_date).ToString("yyyy-MM-dd HH:mm:ss");
        LitClickCount.Text = model.read_count.ToString();

        //更新浏览次数
        int click = int.Parse(model.read_count.ToString()) + 1;
        model.UpdateField(id, "read_count=" + click);

    }
    #endregion
}