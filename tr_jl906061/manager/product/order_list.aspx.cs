using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;
public partial class manager_product_order_list : System.Web.UI.Page
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
        int nav_id = 22;
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

            RptBind("id>0 " + CombSqlTxt(this.cha_type, this.status, this.note_no,this.start_time, this.stop_time,this.zhifu1), "add_time desc,id desc");

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
        tbl_orders bll = new tbl_orders();
 


        //this.Literal_pa.Text = MyConvert(bll.GetTitleSum(_strWhere + " and  status<>4", "sum(payable_amount)"));
         
        this.rptList.DataSource = bll.GetList(this.pageSize, this.page, _strWhere, _orderby, out this.totalCount);
        this.rptList.DataBind();

        //绑定页码
        txtPageNum.Text = this.pageSize.ToString();
        string pageUrl = Utils.CombUrlTxt("order_list.aspx", "type={0}&status={1}&note_no={2}&page={3}&start_time={4}&stop_time={5}", this.cha_type.ToString(), this.status.ToString(), txtNote_no.Text, "__id__", this.start_time.ToString(), this.stop_time.ToString());
        PageContent.InnerHtml = Utils.OutPageList(this.pageSize, this.page, this.totalCount, pageUrl, 8);
    }
    #endregion

    #region 组合SQL查询语句==========================
    protected string CombSqlTxt(int _cha_type, int _status, string _note_no, string _start_time, string _stop_time,int _zhifu)
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

        strTemp.Append(" and add_time between  '" + DateTime.Parse(_start_time) + "' and '" + DateTime.Parse(_stop_time + " 23:59:59") + "'");

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
                _title = "零售单";
                break;
            case 1:
                _title = "分公司后续进货";
                break;
            case 2:
                _title = "下级后续进货";
                break;
            case 3:
                _title = "同级后续进货";
                break;
            case 4:
                _title = "上级后续进货";
                break;
         default:
                _title = "";
                break;
        }

        return _title;
    }
    #endregion

    //查询
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        Response.Redirect(Utils.CombUrlTxt("order_list.aspx", "start_time={0}&stop_time={1}&status={2}&note_no={3}&type={4}", this.txtstart_time.Value, this.txtstop_time.Value, this.status.ToString(), txtNote_no.Text, this.type.SelectedValue));
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
        Response.Redirect(Utils.CombUrlTxt("order_list.aspx", "start_time={0}&stop_time={1}&status={2}&note_no={3}&type={4}", this.txtstart_time.Value, this.txtstop_time.Value, this.status.ToString(), txtNote_no.Text, this.type.SelectedValue));

    }
    //订单状态
    protected void ddlStatus_SelectedIndexChanged(object sender, EventArgs e)
    {
        Response.Redirect(Utils.CombUrlTxt("order_list.aspx", "start_time={0}&stop_time={1}&status={2}&note_no={3}&type={4}", this.txtstart_time.Value, this.txtstop_time.Value, this.ddlStatus.SelectedValue, txtNote_no.Text, this.type.SelectedValue));

    }
     //支付状态
    protected void zhifu_SelectedIndexChanged1(object sender, EventArgs e)
    {
        Response.Redirect(Utils.CombUrlTxt("order_list.aspx", "start_time={0}&stop_time={1}&status={2}&note_no={3}&type={4}&zhifu={5}", this.txtstart_time.Value, this.txtstop_time.Value, this.ddlStatus.SelectedValue, txtNote_no.Text, this.type.SelectedValue,this.zhifu.SelectedValue));

    }
    protected string zhifu_type1(int? id)
    {
        string xiaofeimoney;
        DataRow dr = DbHelperSQL.GetDataRow("select aa=isnull(xiaofei_money,0) from tbl_xiaofei where xiaofei_qr_flag=1 and xiaofei_flag_jiezhang=" + id + "");
        if (dr != null)
        {
            xiaofeimoney = dr["aa"].ToString();//放置人huiyuan_id
        }
        else
        {
            xiaofeimoney = "";
        }
        return xiaofeimoney;
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
    //导出报表
    protected void btnExport_Click(object sender, EventArgs e)
    {
        
        DataTable dt = null;
        string dc_sql = "select order_no as 订单号,user_bianhao as 会员编号,user_name as 会员姓名,(case when status=1 then '已生成' when status=2 then '已发货' when status=3 then '已收货' when status=4 then '已取消' when status=5 then '已作废' else '' end) as 订单状态,(case when payment_status=1 then '未付款' when payment_status=2 then '已付款' else '' end) as 支付状态,payable_amount as 订单原价金额,(select aa=isnull(xiaofei_money,0) from tbl_xiaofei where xiaofei_qr_flag=1 and xiaofei_flag_jiezhang=id) as 付款金额,add_time as 下单时间 FROM  tbl_orders order by add_time desc,id desc";
        //Response.Write(dc_sql);
        //Response.End();
        dt = DbHelperSQL.Query(dc_sql).Tables[0];
        if (dt.Rows.Count == 0)
        {
            Response.Write("<script>alert('导出数据无效'); location.href='order_list.aspx';</script>");
            return;
        }
        string filename = "";
        filename += "已开通会员汇总表" + DateTime.Now.ToString("d") + "";
        PMS.Common.NPOIHelper.ExportByWeb(dt, filename, filename + ".xls");
    }
}