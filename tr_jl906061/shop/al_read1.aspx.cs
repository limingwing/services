using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;

public partial class shop_al_read1 : System.Web.UI.Page
{
    protected int totalCount;
    protected int page;
    protected int pageSize;

    protected int jiebie;
    protected int cha_type;
    protected string note_no = string.Empty;
    protected string start_time = string.Empty;
    protected string stop_time = string.Empty;

    ManagePage mym = new ManagePage();
    protected void Page_Load(object sender, EventArgs e)
    {
        this.jiebie = AXRequest.GetQueryInt("huiyuan_jiebie");
        this.pageSize = GetPageSize(20); //每页数量
        if (!Page.IsPostBack)
        {
            if (Session["hy_id1"] == null)
            {
                Response.Write("<script language=javascript>alert('请重新登录！');top.location.href='login.aspx';</script>");
                Response.End();

            }
            RptBind("huiyuan_shang_id='" + Session["hy_id1"] + "' and huiyuan_xuhao>0 and huiyuan_xuhao<=2  " + CombSqlTxt(this.jiebie, this.note_no, this.start_time, this.stop_time, this.cha_type), "huiyuan_add_time desc");


        }
    }

    #region 数据绑定=================================
    private void RptBind(string _strWhere, string _orderby)
    {
        this.page = AXRequest.GetQueryInt("page", 1);

        view_shangshu2 bll = new view_shangshu2();
        this.rptList.DataSource = bll.GetList(this.pageSize, this.page, _strWhere, _orderby, out this.totalCount);
        this.rptList.DataBind();

        //绑定页码
        //txtPageNum.Text = this.pageSize.ToString();
        string pageUrl = Utils.CombUrlTxt("al_read1.aspx", "page={0}", "__id__");
        PageContent.InnerHtml = Utils.OutPageList(this.pageSize, this.page, this.totalCount, pageUrl, 8);
    }
    #endregion

    #region 组合SQL查询语句==========================
    protected string CombSqlTxt(int _product_category_id, string _note_no, string _start_time, string _stop_time, int cha_type)
    {
        StringBuilder strTemp = new StringBuilder();

        _note_no = _note_no.Replace("'", "");


        if (!string.IsNullOrEmpty(_note_no))
        {
            if (cha_type == 1)
            {
                strTemp.Append(" and huiyuan_bianhao like  '%" + _note_no + "%' ");
            }

            if (cha_type == 2)
            {
                strTemp.Append(" and huiyuan_name like  '%" + _note_no + "%' ");
            }
        }
        return strTemp.ToString();
    }
    #endregion

    #region 返回每页数量=============================
    private int GetPageSize(int _default_size)
    {
        int _pagesize;
        if (int.TryParse(Utils.GetCookie("al_readxxx_page_size"), out _pagesize))
        {

            if (_pagesize > 0)
            {
                return _pagesize;
            }
        }
        return _default_size;
    }
    #endregion
}