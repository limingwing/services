using System;
using System.Text;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class manager_product_pro_list : System.Web.UI.Page
{
    protected int totalCount;
    protected int page;
    protected int pageSize;

    protected int product_category_id;
    protected string note_no = string.Empty;

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
        int nav_id = 65;
        if (!myrv.QXExists(role_id, nav_id))
        {
            Response.Redirect("../error.html");
            Response.End();
        }
        this.product_category_id = AXRequest.GetQueryInt("product_category_id");

        this.note_no = AXRequest.GetQueryString("note_no");

        this.pageSize = GetPageSize(10); //每页数量

        if (!Page.IsPostBack)
        {
            ZYBind();//绑定商品类别


            RptBind("pro_id>0" + CombSqlTxt(this.product_category_id, this.note_no), "pro_date desc,pro_id desc");
        

        }
    }


    #region 绑定商品类别=================================
    private void ZYBind()
    {
        tbl_sinkia_sub bll = new tbl_sinkia_sub();
        DataTable dt = bll.GetList("1=1").Tables[0];
        this.ddlproduct_category_id.Items.Clear();
        this.ddlproduct_category_id.Items.Add(new ListItem("==全部==", "0"));
        foreach (DataRow dr in dt.Rows)
        {
            string Id = dr["id"].ToString();
            string Title = dr["pro_class"].ToString().Trim();
            this.ddlproduct_category_id.Items.Add(new ListItem(Title, Id));
        }
    }
    #endregion


    #region 数据绑定=================================
    private void RptBind(string _strWhere, string _orderby)
    {
        this.page = AXRequest.GetQueryInt("page", 1);

        if (this.product_category_id > 0)
        {
            this.ddlproduct_category_id.SelectedValue = this.product_category_id.ToString();
        }

        txtNote_no.Text = this.note_no;

        tbl_product bll = new tbl_product();
        this.rptList.DataSource = bll.GetList(this.pageSize, this.page, _strWhere, _orderby, out this.totalCount);
        this.rptList.DataBind();

        //绑定页码
        txtPageNum.Text = this.pageSize.ToString();
        string pageUrl = Utils.CombUrlTxt("pro_list.aspx", "product_category_id={0}&note_no={1}&page={2}", this.product_category_id.ToString(), this.note_no, "__id__");
        PageContent.InnerHtml = Utils.OutPageList(this.pageSize, this.page, this.totalCount, pageUrl, 8);
    }
    #endregion

    #region 组合SQL查询语句==========================
    protected string CombSqlTxt(int _product_category_id, string _note_no)
    {
        StringBuilder strTemp = new StringBuilder();

        if (_product_category_id > 0)
        {
            strTemp.Append(" and pro_pid=" + _product_category_id);
        }

        _note_no = _note_no.Replace("'", "");
        if (!string.IsNullOrEmpty(_note_no))
        {
            strTemp.Append(" and pro_name like  '%" + _note_no + "%' ");
        }
        return strTemp.ToString();
    }
    #endregion

    #region 返回每页数量=============================
    private int GetPageSize(int _default_size)
    {
        int _pagesize;
        if (int.TryParse(Utils.GetCookie("pro_list_page_size"), out _pagesize))
        {
            if (_pagesize > 0)
            {
                return _pagesize;
            }
        }
        return _default_size;
    }
    #endregion


    //查询
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        Response.Redirect(Utils.CombUrlTxt("pro_list.aspx", "product_category_id={0}&note_no={1}", this.product_category_id.ToString(), txtNote_no.Text));
    }


    //筛选商品类别
    protected void ddlproduct_category_id_SelectedIndexChanged(object sender, EventArgs e)
    {
        Response.Redirect(Utils.CombUrlTxt("pro_list.aspx", "product_category_id={0}&note_no={1}", this.ddlproduct_category_id.SelectedValue, txtNote_no.Text));
    }


    //设置分页数量
    protected void txtPageNum_TextChanged(object sender, EventArgs e)
    {
        int _pagesize;
        if (int.TryParse(txtPageNum.Text.Trim(), out _pagesize))
        {
            if (_pagesize > 0)
            {
                Utils.WriteCookie("pro_list_page_size", _pagesize.ToString(), 14400);
            }
        }
        Response.Redirect(Utils.CombUrlTxt("pro_list.aspx", "product_category_id={0}&note_no={1}", this.product_category_id.ToString(), txtNote_no.Text));
    }

    //小数位是0的不显示
    public string MyConvert(object d)
    {
        string myNum = d.ToString();
        string[] strs = d.ToString().Split('.');
        if (strs.Length > 1)
        {
            if (Convert.ToInt32(strs[1]) == 0)
            {
                myNum = strs[0];
            }
        }
        return myNum;
    }
    //负数红色显示
    public string MyZF(object d)
    {
        string myNum = d.ToString();
        if (Convert.ToInt32(d.ToString()) <= 0)
        {
            myNum = "<font color=red> " + d.ToString() + "</font>";
        }
        return myNum;
    }

   

    //暂停订购
    protected void lbtnAcceptCaDG_Click(object sender, EventArgs e)
    {
        this.page = AXRequest.GetQueryInt("page", 1);
        // 当前点击的按钮
        LinkButton lb = (LinkButton)sender;
        int caId = int.Parse(lb.CommandArgument);
        tbl_product bll = new tbl_product ();
        bll.GetModel(caId);
        bll.pro_id = caId;
        bll.pro_isok = 0;
        bll.UpdateXS(); //更新是否暂停订购

        mym.JscriptMsg(this.Page, " 设置成功！", Utils.CombUrlTxt("pro_list.aspx", "product_category_id={0}&note_no={1}", this.product_category_id.ToString(), txtNote_no.Text), "Success");
    }

    // 可以订购
    protected void lbtnRefuseCaDG_Click(object sender, EventArgs e)
    {
        this.page = AXRequest.GetQueryInt("page", 1);
        // 当前点击的按钮
        LinkButton lb = (LinkButton)sender;
        int caId = int.Parse(lb.CommandArgument);
        tbl_product bll = new tbl_product();
        bll.GetModel(caId);
        bll.pro_id = caId;
        bll.pro_isok = 1;
        bll.UpdateXS(); //更新是否暂停订购

        mym.JscriptMsg(this.Page, " 设置成功！", Utils.CombUrlTxt("pro_list.aspx", "product_category_id={0}&note_no={1}", this.product_category_id.ToString(), txtNote_no.Text), "Success");
    }

    // 单个删除
    protected void lbtnDelCa_Click(object sender, EventArgs e)
    {
        // 当前点击的按钮
        LinkButton lb = (LinkButton)sender;
        int caId = int.Parse(lb.CommandArgument);
        tbl_product bll = new tbl_product();
        bll.GetModel(caId);
        string title = bll.pro_name;

        string sql = "select aa=count(*) from tbl_order_goods where goods_id=" + caId + "";
        if (int.Parse(DbHelperSQL.GetDataRow(sql)["aa"].ToString()) > 0)
        {
            mym.JscriptMsg(this.Page, "很抱歉， 会员的订单中有该产品", "", "Error");
            return;
        }
        bll.Delete(caId);
        // mym.AddAdminLog("删除", "删除公告：" + title + ""); //记录日志
        mym.JscriptMsg(this.Page, " 成功删除产品：" + title + "", Utils.CombUrlTxt("pro_list.aspx", "product_category_id={0}&note_no={1}", this.product_category_id.ToString(), txtNote_no.Text), "Success");
    }
}