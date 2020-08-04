using System;
using System.Text;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class manager_yeji_jiangjin : System.Web.UI.Page
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
        //判断是否登录
        if (!mym.IsAdminLogin())
        {
            Response.Write("<script>parent.location.href='../login.aspx'</script>");
            Response.End();
        }
        //判断权限
        tbl_admin_role_value myrv = new tbl_admin_role_value();
        int role_id = Convert.ToInt32(Session["RoleID"]);
        int nav_id = 56;
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

            RptBind(" 1=1 " + CombSqlTxt( this.note_no, this.start_time, this.stop_time, this.cha_type), "id desc");


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
        tbl_cha bll = new tbl_cha();
        this.rptList.DataSource = bll.GetList(this.pageSize, this.page, _strWhere, _orderby, out this.totalCount);
        this.rptList.DataBind();
        //this.Literal1.Text = MyConvert(Convert.ToDecimal(bll.GetTitleSum(_strWhere, "sum(cha_002)")).ToString("0.00"));
        //this.Literal2.Text = MyConvert(Convert.ToDecimal(bll.GetTitleSum(_strWhere, "sum(cha_003)")).ToString("0.00"));
        //this.Literal3.Text = MyConvert(Convert.ToDecimal(bll.GetTitleSum(_strWhere, "sum(cha_014)")).ToString("0.00"));
        //绑定页码
        txtPageNum.Text = this.pageSize.ToString();
        string pageUrl = Utils.CombUrlTxt("jiangjin.aspx", "start_time={0}&stop_time={1}&note_no={2}&page={3}&type={4}", this.start_time.ToString(), this.stop_time.ToString(), this.note_no, "__id__", this.cha_type.ToString());
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
        strTemp.Append(" and  cha_date between  '" + DateTime.Parse(_start_time) + "' and '" + DateTime.Parse(_stop_time + " 23:59:59") + "'");

        _note_no = _note_no.Replace("'", "");


        if (!string.IsNullOrEmpty(_note_no))
        {
            if (cha_type == 1)
            {
                strTemp.Append(" and cha_hui_bianhao =  '" + _note_no + "' ");
            }

            if (cha_type == 2)
            {
                strTemp.Append(" and cha_name =  '" + _note_no + "' ");
            }
        }
        return strTemp.ToString();
    }
    #endregion

    #region 返回每页数量=============================
    private int GetPageSize(int _default_size)
    {
        int _pagesize;
        if (int.TryParse(Utils.GetCookie("jiangjin_page_size"), out _pagesize))
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
        Response.Redirect(Utils.CombUrlTxt("jiangjin.aspx", "start_time={0}&stop_time={1}&note_no={2}&type={3}", this.txtstart_time.Value, this.txtstop_time.Value, txtNote_no.Text, this.type.SelectedValue));
    }

    //筛选会员级别
    protected void ddlproduct_category_id_SelectedIndexChanged(object sender, EventArgs e)
    {
        Response.Redirect(Utils.CombUrlTxt("jiangjin.aspx", "start_time={0}&stop_time={1}&note_no={2}", this.txtstart_time.Value, this.txtstop_time.Value, txtNote_no.Text));

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
                Utils.WriteCookie("jiangjin_page_size", _pagesize.ToString(), 14400);
            }
        }
        Response.Redirect(Utils.CombUrlTxt("jiangjin.aspx", "start_time={0}&stop_time={1}&note_no={2}&type={3}", this.txtstart_time.Value, this.txtstop_time.Value, txtNote_no.Text, this.type.SelectedValue));
    }

    //导出报表
    protected void btnExport_Click(object sender, EventArgs e)
    {

        //  Response.Redirect(Utils.CombUrlTxt("jiangjin.aspx", "start_time={0}&stop_time={1}&huiyuan_jiebie={2}&note_no={3}", this.txtstart_time.Value, this.txtstop_time.Value, this.jiebie.ToString(), txtNote_no.Text));
        StringBuilder strTemp = new StringBuilder();

        if (!string.IsNullOrEmpty(txtNote_no.Text))
        {
            if (cha_type == 1)
            {
                strTemp.Append(" and cha_hui_bianhao like  '%" + txtNote_no.Text + "%' ");
            }

            if (cha_type == 2)
            {
                strTemp.Append(" and cha_name like  '%" + txtNote_no.Text + "%' ");
            }
        }

        string sBeginTime = this.txtstart_time.Value;
        string sEndTime = this.txtstop_time.Value;




        if (sBeginTime.Length > 6 && sEndTime.Length > 6)
        {
            strTemp.Append(" and huiyuan_add_time between '" + sBeginTime + " 00:00:00' and '" + sEndTime + " 23:59:59'");

        }
        DataTable dt = null;
        string dc_sql = "select cha_hui_bianhao as 编号,cha_name as 姓名,cha_001 as 分享利润 ,cha_002 as 管理团队奖,cha_004 as 特享分公司后续进货奖,cha_005 as 特别分享奖,cha_006 as 报单奖,cha_007 as 发货奖,cha_008 as 购物提成,cha_012 as 总计,cha_011 as 系统产品税,cha_013 as 合计,cha_date as 结算时间 from tbl_huiyuan where  1=1  " + strTemp.ToString() + " and huiyuan_id<>'A00000000' order by huiyuan_add_time desc";
        //Response.Write(dc_sql);
        //Response.End();
        dt = DbHelperSQL.Query(dc_sql).Tables[0];
        if (dt.Rows.Count == 0)
        {
            Response.Write("<script>alert('导出数据无效'); location.href='jiangjin.aspx';</script>");
            return;
        }
        string filename = "";
        filename += "已开通会员汇总表" + DateTime.Now.ToString("d") + "";
        PMS.Common.NPOIHelper.ExportByWeb(dt, filename, filename + ".xls");

    }

 


    //负数红色显示
    public string MyZF(object d)
    {
        string myNum = d.ToString();
        if (double.Parse( d.ToString()) <= 0)
        {
            myNum = "<font color=red> " + d.ToString() + "</font>";
        }
        return myNum;
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

    //小数位是0的不显示
    public string money_Convert(string money)
    {
        decimal num = decimal.Parse(money);
        string s4 = "";
        s4 = num.ToString().Substring(0, num.ToString().IndexOf('.') + 3);
        decimal num1 = Convert.ToDecimal(s4);
        return num1.ToString();
    }

   
   
}