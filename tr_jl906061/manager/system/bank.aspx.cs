using System;
using System.Text;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class manager_system_bank : System.Web.UI.Page
{
    protected int totalCount;
    protected int page;
    protected int pageSize;
    protected int status;
    protected int category_id;
    protected int depot_id;
    protected int role_id;

    protected string keywords = string.Empty;

    ManagePage mym = new ManagePage();
    protected void Page_Load(object sender, EventArgs e)
    {
        //判断是否登录
        if (!mym.IsAdminLogin())
        {
            Response.Write("<script>parent.location.href='../login.aspx'</script>");
            Response.End();
        }
        //判断权限
        tbl_admin_role_value myrv = new tbl_admin_role_value();
        int role_id = Convert.ToInt32(Session["RoleID"]);
        int nav_id = 90;
        if (!myrv.QXExists(role_id, nav_id))
        {
            Response.Redirect("../error.html");
            Response.End();
        }
        this.status = AXRequest.GetQueryInt("status");
        this.category_id = AXRequest.GetQueryInt("category_id");
        this.depot_id = AXRequest.GetQueryInt("depot_id");
        this.keywords = AXRequest.GetQueryString("keywords");
        this.pageSize = GetPageSize(10); //每页数量
        this.page = AXRequest.GetQueryInt("page", 1);

        if (!Page.IsPostBack)
        {

            //RoleBind(ddlRoleId, Convert.ToInt32(Session["RoleID"]));//绑定角色


            RptBind(CombSqlTxt(this.status, this.keywords), "id desc");

        }
    }

    //#region 角色类型=================================
    //private void RoleBind(DropDownList ddl, int role_type)
    //{
    //    tbl_admin_role bll = new tbl_admin_role();
    //    DataTable dt = bll.GetList("").Tables[0];

    //    ddl.Items.Clear();
    //    ddl.Items.Add(new ListItem("==全部==", ""));
    //    foreach (DataRow dr in dt.Rows)
    //    {
    //        if (Convert.ToInt32(dr["role_type"]) > role_type)
    //        {
    //            ddl.Items.Add(new ListItem(dr["role_name"].ToString(), dr["id"].ToString()));
    //        }
    //    }
    //}
    //#endregion



    #region 数据绑定=================================
    private void RptBind(string _strWhere, string _orderby)
    {
        this.page = AXRequest.GetQueryInt("page", 1);
        if (this.status > 0)
        {
            this.ddlStatus.SelectedValue = this.status.ToString();
        }


        txtKeywords.Text = this.keywords;
        tbl_bank bll = new tbl_bank();
        this.rptList.DataSource = bll.GetList(this.pageSize, this.page, _strWhere, _orderby, out this.totalCount);
        this.rptList.DataBind();

        //绑定页码
        txtPageNum.Text = this.pageSize.ToString();
        string pageUrl = Utils.CombUrlTxt("manage.aspx", "status={0}&category_id={1}&depot_id={2}&keywords={3}&page={4}", this.status.ToString(), this.category_id.ToString(), this.depot_id.ToString(), this.keywords, "__id__");
        PageContent.InnerHtml = Utils.OutPageList(this.pageSize, this.page, this.totalCount, pageUrl, 8);
    }
    #endregion

    #region 组合SQL查询语句==========================
    protected string CombSqlTxt(int _status, string _keywords)
    {
        StringBuilder strTemp = new StringBuilder();
        if (_status > 0)
        {
            strTemp.Append(" and is_lock=" + _status);
        }

        _keywords = _keywords.Replace("'", "");
        if (!string.IsNullOrEmpty(_keywords))
        {
            strTemp.Append(" and (huiyuan_bianhao like  '%" + _keywords + "%' or huiyuan_name like '%" + _keywords + "%'   )");
        }
        return strTemp.ToString();
    }
    #endregion

    #region 返回每页数量=============================
    private int GetPageSize(int _default_size)
    {
        int _pagesize;
        if (int.TryParse(Utils.GetCookie("manager_page_size"), out _pagesize))
        {
            if (_pagesize > 0)
            {
                return _pagesize;
            }
        }
        return _default_size;
    }
    #endregion


    //关健字查询
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        Response.Redirect(Utils.CombUrlTxt("manage.aspx", "status={0}&category_id={1}&depot_id={2}&keywords={3}", this.status.ToString(), this.category_id.ToString(), this.depot_id.ToString(), txtKeywords.Text));
    }




    //筛选角色
    protected void ddlRoleId_SelectedIndexChanged(object sender, EventArgs e)
    {
        Response.Redirect(Utils.CombUrlTxt("manage.aspx", "status={0}&category_id={1}&depot_id={2}&keywords={3}",
            this.status.ToString(), this.category_id.ToString(), this.depot_id.ToString(), this.keywords));
    }

    //筛选状态
    protected void ddlStatus_SelectedIndexChanged(object sender, EventArgs e)
    {
        Response.Redirect(Utils.CombUrlTxt("manage.aspx", "status={0}&category_id={1}&depot_id={2}&keywords={3}",
            ddlStatus.SelectedValue, this.category_id.ToString(), this.depot_id.ToString(), this.keywords));
    }

    //设置分页数量
    protected void txtPageNum_TextChanged(object sender, EventArgs e)
    {
        int _pagesize;
        if (int.TryParse(txtPageNum.Text.Trim(), out _pagesize))
        {
            if (_pagesize > 0)
            {
                Utils.WriteCookie("manager_page_size", _pagesize.ToString(), 14400);
            }
        }
        Response.Redirect(Utils.CombUrlTxt("manage.aspx", "status={0}&category_id={1}&depot_id={2}&keywords={3}", this.status.ToString(), this.category_id.ToString(), this.depot_id.ToString(), this.keywords));
    }

    // 单个删除
    protected void lbtnDelCa_Click(object sender, EventArgs e)
    {
        // 当前点击的按钮
        LinkButton lb = (LinkButton)sender;
        int caId = int.Parse(lb.CommandArgument);
        tbl_bank bll = new tbl_bank();
        bll.GetModel(caId);
        string title = bll.accountname;

        bll.Delete(caId);

        mym.JscriptMsg(this.Page, " 成功删除开户名：" + title + "", Utils.CombUrlTxt("manage.aspx", "status={0}&category_id={1}&depot_id={2}&keywords={3}&page={4}", this.status.ToString(), this.category_id.ToString(), this.depot_id.ToString(), this.keywords, this.page.ToString()), "Success");


    }
}