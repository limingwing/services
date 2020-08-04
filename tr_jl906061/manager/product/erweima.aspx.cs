using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Text;
using System.Web.UI.WebControls;

public partial class manager_product_erweima : System.Web.UI.Page
{
    protected int totalCount;
    protected int page;
    protected int pageSize;
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
        int nav_id = 83;
        if (!myrv.QXExists(role_id, nav_id))
        {
            Response.Redirect("../error.html");
            Response.End();
        }
        this.keywords = AXRequest.GetQueryString("keywords");
        this.pageSize = GetPageSize(10); //每页数量
        this.page = AXRequest.GetQueryInt("page", 1);
        if (!Page.IsPostBack)
        {
            RptBind(CombSqlTxt(this.keywords), "id desc");
        }
    }
    #region 数据绑定=================================
    private void RptBind(string _strWhere, string _orderby)
    {
        this.page = AXRequest.GetQueryInt("page", 1);

        tbl_erweima bll = new tbl_erweima();
        this.rptList.DataSource = bll.GetList(this.pageSize, this.page, _strWhere, _orderby, out this.totalCount);
        this.rptList.DataBind();
    }
    #endregion

    #region 组合SQL查询语句==========================
    protected string CombSqlTxt(string _keywords)
    {
        StringBuilder strTemp = new StringBuilder();
        _keywords = _keywords.Replace("'", "");
        if (!string.IsNullOrEmpty(_keywords))
        {
            strTemp.Append(_keywords);
        }
        return strTemp.ToString();
    }
    #endregion

    #region 返回每页数量=============================
    private int GetPageSize(int _default_size)
    {
        int _pagesize;
        if (int.TryParse(Utils.GetCookie("class_page_size"), out _pagesize))
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
        //Response.Redirect(Utils.CombUrlTxt("pro_sub_list.aspx", "keywords={0}", txtKeywords.Text));
    }

    //设置分页数量
    protected void txtPageNum_TextChanged(object sender, EventArgs e)
    {
        //int _pagesize;
        //if (int.TryParse(txtPageNum.Text.Trim(), out _pagesize))
        //{
        //    if (_pagesize > 0)
        //    {
        //        Utils.WriteCookie("class_page_size", _pagesize.ToString(), 14400);
        //    }
        //}
        //Response.Redirect(Utils.CombUrlTxt("pro_sub_list.aspx", "keywords={0}", this.keywords));
    }

    // 单个删除
    protected void lbtnDelCa_Click(object sender, EventArgs e)
    {
        // 当前点击的按钮
        LinkButton lb = (LinkButton)sender;
        int caId = int.Parse(lb.CommandArgument);
        tbl_sinkia_sub bll = new tbl_sinkia_sub();
        bll.GetModel(caId);

        string pro_class = bll.pro_class;
        tbl_product bllpp = new tbl_product();
        bllpp.pro_pid = caId;
        if (!bllpp.ExistsBM())//查找是否存在下级商品
        {
            bll.Delete(caId);

            mym.JscriptMsg(this.Page, " 成功删除商品类别：" + pro_class + "", Utils.CombUrlTxt("pro_sub_list.aspx", "keywords={0}&page={1}", this.keywords, this.page.ToString()), "Success");
        }
        else
        {
            mym.JscriptMsg(this.Page, "有商品属于该商品类别，不能删除！", "", "Error");
            return;
        }


    }



    //保存排序
    protected void btnSave_Click(object sender, EventArgs e)
    {
        tbl_sinkia_sub bll = new tbl_sinkia_sub();
        Repeater rptList = new Repeater();
        rptList = this.rptList;

        for (int i = 0; i < rptList.Items.Count; i++)
        {
            int id = Convert.ToInt32(((HiddenField)rptList.Items[i].FindControl("hidId")).Value);
            int sortId;
            if (!int.TryParse(((TextBox)rptList.Items[i].FindControl("txtSortId")).Text.Trim(), out sortId))
            {
                sortId = 99;
            }
            bll.UpdateField(id, "sort_id=" + sortId.ToString());
        }

        mym.JscriptMsg(this.Page, " 排序保存成功", Utils.CombUrlTxt("pro_sub_list.aspx", "keywords={0}&page={1}", this.keywords, this.page.ToString()), "Success");
    }
}