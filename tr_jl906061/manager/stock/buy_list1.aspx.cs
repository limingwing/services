using System;
using System.Web.UI;
using System.Text;

public partial class manager_stock_buy_list1 : System.Web.UI.Page
{
    protected int totalCount;
    protected int page;
    protected int pageSize;

    protected int cha_type;
    protected string note_no = string.Empty;
    protected string start_time = string.Empty;
    protected string stop_time = string.Empty;

    ManagePage mym = new ManagePage();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
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
            int nav_id = 76;
            if (!myrv.QXExists(role_id, nav_id))
            {
                Response.Redirect("../error.html");
                Response.End();
            }



            this.note_no = AXRequest.GetQueryString("note_no");
            this.cha_type = AXRequest.GetQueryInt("type");

            if (AXRequest.GetQueryString("start_time") == "")
            {
                this.start_time = DateTime.Now.ToString("2015-01-01");
            }
            else
            {

                this.start_time = AXRequest.GetQueryString("start_time");
            }
            if (AXRequest.GetQueryString("stop_time") == "")
            {
                this.stop_time = DateTime.Now.ToString("yyyy-MM-dd");
            }
            else
            {
                this.stop_time = AXRequest.GetQueryString("stop_time");
            }
            this.pageSize = GetPageSize(10); //每页数量

            if (!Page.IsPostBack)
            {


                txtstart_time.Value = DateTime.Now.ToString("d");
                txtstop_time.Value = DateTime.Now.ToString("d");

                RptBind(" 1=1 " + CombSqlTxt(this.note_no, this.start_time, this.stop_time, this.cha_type), "id desc");


            }
        }
    }
    #region 数据绑定=================================
    private void RptBind(string _strWhere, string _orderby)
    {
        this.page = AXRequest.GetQueryInt("page", 1);

        txtNote_no.Text = this.note_no;
        txtstart_time.Value = this.start_time;
        txtstop_time.Value = this.stop_time;
        this.type.SelectedValue = this.cha_type.ToString();
        tbl_buy bll = new tbl_buy();
        this.rptList.DataSource = bll.GetList(this.pageSize, this.page, _strWhere, _orderby, out this.totalCount);
        this.rptList.DataBind();

        this.Literal_hj.Text = MyConvert(Convert.ToDecimal(bll.GetTitleSum(_strWhere, "sum(sq_money)")) * 0.9m);
        //绑定页码
        txtPageNum.Text = this.pageSize.ToString();
        string pageUrl = Utils.CombUrlTxt("buy_list1.aspx", "start_time={0}&stop_time={1}&note_no={2}&page={3}&type={4}", this.start_time.ToString(), this.stop_time.ToString(), this.note_no, "__id__", this.cha_type.ToString());
        PageContent.InnerHtml = Utils.OutPageList(this.pageSize, this.page, this.totalCount, pageUrl, 8);
    }
    #endregion

    #region 组合SQL查询语句==========================
    protected string CombSqlTxt(string _note_no, string _start_time, string _stop_time, int cha_type)
    {
        StringBuilder strTemp = new StringBuilder();



        if (string.IsNullOrEmpty(_start_time))
        {
            _start_time = "1900-01-01";
        }
        if (string.IsNullOrEmpty(_stop_time))
        {
            _stop_time = "2099-01-01";
        }
        strTemp.Append(" and  cj_date between  '" + DateTime.Parse(_start_time) + "' and '" + DateTime.Parse(_stop_time + " 23:59:59") + "'");

        _note_no = _note_no.Replace("'", "");


        if (!string.IsNullOrEmpty(_note_no))
        {
            if (cha_type == 1)
            {
                strTemp.Append(" and huiyuan_bianhao =  '" + _note_no + "' ");
            }

            if (cha_type == 2)
            {
                strTemp.Append(" and huiyuan_name =  '" + _note_no + "' ");
            }
        }
        return strTemp.ToString();
    }
    #endregion

    #region 返回每页数量=============================
    private int GetPageSize(int _default_size)
    {
        int _pagesize;
        if (int.TryParse(Utils.GetCookie("buy_list_page_size"), out _pagesize))
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
        Response.Redirect(Utils.CombUrlTxt("buy_list1.aspx", "start_time={0}&stop_time={1}&note_no={2}&type={3}", this.txtstart_time.Value, this.txtstop_time.Value, txtNote_no.Text, this.type.SelectedValue));
    }

    //负数红色显示
    public string MyZF(string d)
    {
        decimal myNum = Convert.ToDecimal(d) * 0.9m;
        return myNum.ToString("n2");
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
                Utils.WriteCookie("buy_list_page_size", _pagesize.ToString(), 14400);
            }
        }
        Response.Redirect(Utils.CombUrlTxt("buy_list1.aspx", "start_time={0}&stop_time={1}&note_no={2}&type={3}", this.txtstart_time.Value, this.txtstop_time.Value, txtNote_no.Text, this.type.SelectedValue));
    }
    #region 返回状态=============================
    protected string GetOrderStatus(string _id)
    {
        string _title = string.Empty;

        switch (_id)
        {
            
            case "3":
                _title = "已购买";
                break;

        }

        return _title;
    }
    #endregion
}