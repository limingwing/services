using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class shop_blog : System.Web.UI.Page
{
    private int id = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
         

        if (!int.TryParse(Request.QueryString["id"] as string, out this.id))
        {
            Response.Write("<script language=javascript>alert('参数不正确！');top.location.href='news.aspx';</script>");
            Response.End();
        }
        if (!Page.IsPostBack)
        {
            ShowInfo(this.id);
        }
    
    }

    private void ShowInfo(int _id)
    {
        tbl_news model = new tbl_news();
        
        model.GetModel(_id);
        new_title.Text = model.title;
        news_date.Text = model.news_date.ToString();
        memo.Text = model.memo;
        this.news.DataSource = model.GetList(" is_show=1   order by news_date desc");
        this.news.DataBind();
    }
}