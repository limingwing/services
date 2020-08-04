using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class shop_news : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (Session["hy_id1"] == null)
            {
                Response.Write("<script language=javascript>alert('请重新登录！');top.location.href='login.aspx';</script>");
                Response.End();

            }
            news_bind();//绑定新闻
            
        }
    }
    #region 绑定新闻=================================
    private void news_bind()
    {





        tbl_news bll = new tbl_news();
        this.news.DataSource = bll.GetList(" is_show=1   order by news_date desc");
        this.news.DataBind();



    }
    #endregion
}