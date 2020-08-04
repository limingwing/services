using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class shop_fa : System.Web.UI.Page
{
    protected int totalCount;
    protected int page;
    protected int pageSize;
    protected string keywords = string.Empty;
    ManagePage mym = new ManagePage();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["hy_id1"] == null)
        {
            Response.Write("<script language=javascript>alert('请重新登录！');top.location.href='login.aspx';</script>");
            Response.End();

        }
        this.pageSize = GetPageSize(10); //每页数量
        if (!Page.IsPostBack)
        {
            RptBind("liuyan_bianhao='" + Session["hy_bianhao1"].ToString() + "' ", "id desc");
        }
    }
    #region 数据绑定=================================
    private void RptBind(string _strWhere, string _orderby)
    {
        this.page = AXRequest.GetQueryInt("page", 1);

        tbl_liuyan bll = new tbl_liuyan();
        this.rptList.DataSource = bll.GetList(this.pageSize, this.page, _strWhere, _orderby, out this.totalCount);
        this.rptList.DataBind();

        //绑定页码
        //txtPageNum.Text = this.pageSize.ToString();
        string pageUrl = Utils.CombUrlTxt("fa.aspx", "keywords={0}&page={1}", this.keywords, "__id__");
        PageContent.InnerHtml = Utils.OutPageList(this.pageSize, this.page, this.totalCount, pageUrl, 8);
    }
    #endregion



    #region 返回每页数量=============================
    private int GetPageSize(int _default_size)
    {
        int _pagesize;
        if (int.TryParse(Utils.GetCookie("fa"), out _pagesize))
        {
            if (_pagesize > 0)
            {
                return _pagesize;
            }
        }
        return _default_size;
    }
    #endregion




    //设置分页数量
    //protected void txtPageNum_TextChanged(object sender, EventArgs e)
    //{
    //    int _pagesize;
    //    if (int.TryParse(txtPageNum.Text.Trim(), out _pagesize))
    //    {
    //        if (_pagesize >= 300)
    //        {
    //            mym.JscriptMsg(this.Page, "页面设置最大分页数为500数据，请重新输入！", "", "Error");
    //            return;
    //        }
    //        if (_pagesize > 0)
    //        {
    //            Utils.WriteCookie("liuyan_log_page_size", _pagesize.ToString(), 14400);
    //        }
    //    }
    //    Response.Redirect(Utils.CombUrlTxt("out_box.aspx", "keywords={0}", this.keywords));
    //}

    #region 增加操作=================================
    //private bool DoAdd()
    //{
    //    tbl_liuyan model = new tbl_liuyan();

    //    model.liuyan_title = liuyan_title.Value.Trim();
    //    model.liuyan_memo = liuyan_memo.Value.Trim();
    //    model.liuyan_date = DateTime.Now;
    //    model.liuyan_bianhao = hy_bianhao1;
    //    model.liuyan_to_name = "公司";
    //    model.liuyan_to = "A00000000";

    //    tbl_huiyuan model_hui = new tbl_huiyuan();
    //    model_hui.GetModel_hui_bianhao(hy_bianhao1);

    //    model.liuyan_name = model_hui.huiyuan_name;
    //    if (model.Add() > 0)
    //    {

    //        return true;
    //    }

    //    return false;
    //}
    #endregion
    //protected void btnSubmit_Click(object sender, EventArgs e)
    //{

    //    string sPassWord = this.pass_two.Value.Trim();
    //    if (!tbl_huiyuan.Exists_erji(hy_bianhao1, sPassWord))
    //    {
    //        Response.Write("<script language=javascript>alert('二级密码不正确！');location.href='fa.aspx';</script>");
    //        return;

    //    }

    //    if (!DoAdd())
    //    {
    //        Response.Write("<script language=javascript>alert('发送失败！');location.href='fa.aspx';</script>");
    //        return;
    //    }
    //    Response.Write("<script language=javascript>alert('发送成功！');location.href='fa.aspx';</script>");
    //    return;

    //}
}