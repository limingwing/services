using System;
using System.Web.UI;
using System.Text;

public partial class manager_product_timeList : System.Web.UI.Page
{
    protected int totalCount;
    protected int page;
    protected int pageSize;

    protected int depot_category_id;
    protected int depot_id;
    protected int status, zhifu1;
    protected int cha_type;
    protected string note_no = string.Empty;

    protected string start_time = string.Empty;
    protected string stop_time = string.Empty;
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
        int nav_id = 96;
        if (!myrv.QXExists(role_id, nav_id))
        {
            Response.Redirect("../error.html");
            Response.End();
        }


        this.status = AXRequest.GetQueryInt("status");
        this.zhifu1 = AXRequest.GetQueryInt("zhifu");
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
            //this.stop_time = DateTime.Now.ToString("yyyy-MM-dd");
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

            RptBind(" 1=1 " + CombSqlTxt(this.cha_type, this.status, this.note_no, this.start_time, this.stop_time, this.zhifu1), "CreateTime desc,kid desc");

        }
    }





    #region 数据绑定=================================
    private void RptBind(string _strWhere, string _orderby)
    {
        this.page = AXRequest.GetQueryInt("page", 1);




        //txtNote_no.Text = this.note_no;
        txtstart_time.Value = this.start_time;
        txtstop_time.Value = this.stop_time;
        //this.type.SelectedValue = this.cha_type.ToString();
        tbl_Seckill bll = new tbl_Seckill();



        //this.Literal_pa.Text = MyConvert(bll.GetTitleSum(_strWhere + " and  status<>4", "sum(payable_amount)"));

        this.rptList.DataSource = bll.GetList(this.pageSize, this.page, _strWhere, _orderby, out this.totalCount);
        this.rptList.DataBind();

        //绑定页码
        txtPageNum.Text = this.pageSize.ToString();
        string pageUrl = Utils.CombUrlTxt("timeList.aspx", "type={0}&status={1}&page={2}&start_time={3}&stop_time={4}", this.cha_type.ToString(), this.status.ToString(), "__id__", this.start_time.ToString(), this.stop_time.ToString());
        PageContent.InnerHtml = Utils.OutPageList(this.pageSize, this.page, this.totalCount, pageUrl, 8);
    }
    #endregion

    #region 组合SQL查询语句==========================
    protected string CombSqlTxt(int _cha_type, int _status, string _note_no, string _start_time, string _stop_time, int _zhifu)
    {
        StringBuilder strTemp = new StringBuilder();

        //strTemp.Append(" and status=1");

        if (_status > 0)
        {

            strTemp.Append(" and status=" + _status);


        }

        if (_zhifu > 0)
        {

            strTemp.Append(" and payment_status=" + _zhifu);


        }

        if (string.IsNullOrEmpty(_start_time))
        {
            _start_time = "1900-01-01";
        }
        if (string.IsNullOrEmpty(_stop_time))
        {
            _stop_time = "2099-01-01";
        }

        strTemp.Append(" and StartTime >=  '" + DateTime.Parse(_start_time) + "' and EndTime <= '" + DateTime.Parse(_stop_time + " 23:59:59") + "'");

        _note_no = _note_no.Replace("'", "");
        if (!string.IsNullOrEmpty(_note_no))
        {

            if (cha_type == 1)
            {
                strTemp.Append(" and user_bianhao like  '%" + _note_no + "%' ");
            }
            if (cha_type == 2)
            {
                strTemp.Append(" and user_name like  '%" + _note_no + "%' ");
            }
            if (cha_type == 3)
            {
                strTemp.Append(" and order_no like  '%" + _note_no + "%' ");
            }

        }
        return strTemp.ToString();
    }
    #endregion

    #region 返回每页数量=============================
    private int GetPageSize(int _default_size)
    {
        int _pagesize;
        if (int.TryParse(Utils.GetCookie("d_order_page_size"), out _pagesize))
        {
            if (_pagesize > 0)
            {
                return _pagesize;
            }
        }
        return _default_size;
    }
    #endregion



    #region 返回订单状态=============================
    protected string zhifu_type(int _id)
    {
        string _title = string.Empty;

        switch (_id)
        {
            case 0:
                _title = "未开始";
                break;
            case 1:
                _title = "进行中";
                break;
            case 2:
                _title = "已结束";
                break;

        }

        return _title;
    }
    #endregion

    //查询
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        Response.Redirect(Utils.CombUrlTxt("timeList.aspx", "start_time={0}&stop_time={1}&status={2}", this.txtstart_time.Value, this.txtstop_time.Value, this.status.ToString()));
    }


    //设置分页数量
    protected void txtPageNum_TextChanged(object sender, EventArgs e)
    {
        int _pagesize;
        if (int.TryParse(txtPageNum.Text.Trim(), out _pagesize))
        {
            if (_pagesize > 0)
            {
                Utils.WriteCookie("d_order_page_size", _pagesize.ToString(), 14400);
            }
        }
        Response.Redirect(Utils.CombUrlTxt("timeList.aspx", "start_time={0}&stop_time={1}&status={2}", this.txtstart_time.Value, this.txtstop_time.Value, this.status.ToString()));

    }
    //订单状态
    protected void ddlStatus_SelectedIndexChanged(object sender, EventArgs e)
    {
        Response.Redirect(Utils.CombUrlTxt("timeList.aspx", "start_time={0}&stop_time={1}&status={2}", this.txtstart_time.Value, this.txtstop_time.Value, this.ddlStatus.SelectedValue));

    }
    //支付状态
    protected void zhifu_SelectedIndexChanged1(object sender, EventArgs e)
    {
        Response.Redirect(Utils.CombUrlTxt("timeList.aspx", "start_time={0}&stop_time={1}&status={2}", this.txtstart_time.Value, this.txtstop_time.Value, this.ddlStatus.SelectedValue));

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
}