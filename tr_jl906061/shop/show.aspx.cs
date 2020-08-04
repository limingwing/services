using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class shop_show : System.Web.UI.Page
{
    ManagePage mym = new ManagePage();
    private int id = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["hy_id1"] == null)
        {
            Response.Write("<script language=javascript>alert('请重新登录！');top.location.href='login.aspx';</script>");
            Response.End();

        }
        if (!Page.IsPostBack)
        {
            id = int.Parse(Request.QueryString["id"].ToString());
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




    }
    #endregion
}