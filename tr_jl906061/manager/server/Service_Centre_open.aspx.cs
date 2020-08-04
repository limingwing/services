using System;
using System.Text;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
 
 

public partial class manager_server_Service_Centre_open : System.Web.UI.Page
{
    protected int totalCount;
    protected int page;
    protected int pageSize;

    protected int jiebie;
    protected int cha_type;
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
        int nav_id = 17;
        if (!myrv.QXExists(role_id, nav_id))
        {
            Response.Redirect("../error.html");
            Response.End();
        }

        this.jiebie = AXRequest.GetQueryInt("huiyuan_jiebie");

        this.note_no = AXRequest.GetQueryString("note_no");
        this.cha_type = AXRequest.GetQueryInt("type");



        this.pageSize = GetPageSize(10); //每页数量

        if (!Page.IsPostBack)
        {

            ZYBind();//绑定会员级别



            RptBind("huiyuan_id<>'A00000000'   and huiyuan_zhuanmai=1 and huiyuan_zhuanmai_sq=1 " + CombSqlTxt(this.jiebie, this.note_no, this.cha_type), "huiyuan_add_time desc");


        }
    }

    #region 绑定会员级别=================================
    private void ZYBind()
    {
        tbl_reg_jiebie bll = new tbl_reg_jiebie();
        DataTable dt = bll.GetList("1=1").Tables[0];
        this.ddlproduct_category_id.Items.Clear();
        this.ddlproduct_category_id.Items.Add(new ListItem("==全部==", "0"));
        foreach (DataRow dr in dt.Rows)
        {
            string Id = dr["jiebie_value"].ToString();
            string Title = dr["jiebie_name"].ToString().Trim();
            this.ddlproduct_category_id.Items.Add(new ListItem(Title, Id));
        }
    }
    #endregion


    #region 数据绑定=================================
    private void RptBind(string _strWhere, string _orderby)
    {
        this.page = AXRequest.GetQueryInt("page", 1);


        if (this.jiebie > 0)
        {
            this.ddlproduct_category_id.SelectedValue = this.jiebie.ToString();
        }

        txtNote_no.Text = this.note_no;

        this.type.SelectedValue = this.cha_type.ToString();
        view_huiyuan bll = new view_huiyuan();
        this.rptList.DataSource = bll.GetList(this.pageSize, this.page, _strWhere, _orderby, out this.totalCount);
        this.rptList.DataBind();
       
        //绑定页码
        txtPageNum.Text = this.pageSize.ToString();
        string pageUrl = Utils.CombUrlTxt("Service_Centre_open.aspx", "huiyuan_jiebie={0}&note_no={1}&page={2}&type={3}", this.jiebie.ToString(), this.note_no, "__id__", this.cha_type.ToString());
        PageContent.InnerHtml = Utils.OutPageList(this.pageSize, this.page, this.totalCount, pageUrl, 8);
    }
    #endregion

    #region 组合SQL查询语句==========================
    protected string CombSqlTxt(int _product_category_id, string _note_no, int cha_type)
    {
        StringBuilder strTemp = new StringBuilder();

        if (_product_category_id > 0)
        {
            strTemp.Append(" and huiyuan_jiebie=" + _product_category_id);
        }




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
        if (int.TryParse(Utils.GetCookie("Service_Centre_page_size"), out _pagesize))
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
        Response.Redirect(Utils.CombUrlTxt("Service_Centre_open.aspx", "huiyuan_jiebie={0}&note_no={1}&type={2}", this.ddlproduct_category_id.SelectedValue, txtNote_no.Text, this.type.SelectedValue));
    }

    //筛选会员级别
    protected void ddlproduct_category_id_SelectedIndexChanged(object sender, EventArgs e)
    {
        Response.Redirect(Utils.CombUrlTxt("Service_Centre_open.aspx", "huiyuan_jiebie={0}&note_no={1}", this.ddlproduct_category_id.SelectedValue, txtNote_no.Text));

    }

    //设置分页数量
    protected void txtPageNum_TextChanged(object sender, EventArgs e)
    {
        int _pagesize;
        if (int.TryParse(txtPageNum.Text.Trim(), out _pagesize))
        {

            if (_pagesize > 300)
            {
                mym.JscriptMsg(this.Page, "页面设置最大分页数为300数据，请重新输入！", "", "Error");
                return;
            }
            if (_pagesize > 0)
            {
                Utils.WriteCookie("Service_Centre_page_size", _pagesize.ToString(), 14400);
            }
        }
        Response.Redirect(Utils.CombUrlTxt("Service_Centre_open.aspx", "huiyuan_jiebie={0}&note_no={1}&type={2}", this.ddlproduct_category_id.SelectedValue, txtNote_no.Text, this.type.SelectedValue));
    }
    protected string GetOrderStatus(string bid, string sid, string mmid)
    {
        string shenname = DbHelperSQL.GetDataRow("select ProName from T_Province where ProID=" + bid + "")["ProName"].ToString();
        string shiname = DbHelperSQL.GetDataRow("select CityName from T_City where CityID=" + sid + "")["CityName"].ToString();
        string xianname = DbHelperSQL.GetDataRow("select DisName from T_District where Id=" + mmid + "")["DisName"].ToString();
        return shenname + "-" + shiname + "-" + xianname;
      
    }

    // 单个删除
    protected void lbtnDelCa_Click(object sender, EventArgs e)
    {
        // 当前点击的按钮
        LinkButton lb = (LinkButton)sender;
        string caId = lb.CommandArgument;

        tbl_huiyuan bll = new tbl_huiyuan();
        bll.GetModel_hui_id(caId);
        string title = bll.huiyuan_bianhao;
        bll.huiyuan_id = caId;
        bll.huiyuan_zhuanmai_sq = 0;
        bll.huiyuan_zhuanmai = 0;
        bll.Update_service_centre();

        mym.JscriptMsg(this.Page, " 成功解除用户名（账号）：" + title + "的服务中心资格！", Utils.CombUrlTxt("Service_Centre_open.aspx", "huiyuan_jiebie={0}&note_no={1}&type={2}", this.ddlproduct_category_id.SelectedValue, txtNote_no.Text, this.type.SelectedValue), "Success");


    }
    // 单个确认
    protected void queren_click(object sender, EventArgs e)
    {
        // 当前点击的按钮
        LinkButton lb = (LinkButton)sender;
        string caId = lb.CommandArgument;

        tbl_huiyuan bll = new tbl_huiyuan();
        bll.GetModel_hui_id(caId);
        string title = bll.huiyuan_bianhao;
        bll.huiyuan_id = caId;
        bll.huiyuan_zhuanmai_sq = 0;
        bll.huiyuan_zhuanmai = 0;
        bll.Update_service_centre();

        mym.JscriptMsg(this.Page, " 确认成功（账号）：" + title + "的服务中心资格！", Utils.CombUrlTxt("Service_Centre_open.aspx", "huiyuan_jiebie={0}&note_no={1}&type={2}", this.ddlproduct_category_id.SelectedValue, txtNote_no.Text, this.type.SelectedValue), "Success");


    }

    #region 返回状态=============================
    protected string Getstatus(string _id, string _jb)
    {
        string _title = string.Empty;

        _title = DbHelperSQL.GetDataRow("select aa=count(*) from tbl_huiyuan where huiyuan_shangshu2 like '%" + _id + "%' and zhuanmai_jb=" + _jb + " and huiyuan_id<>'" + _id + "'")["aa"].ToString();

        return _title;
    }
    #endregion

}