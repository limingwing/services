using System;
using System.Text;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class manager_member_al_read5 : System.Web.UI.Page
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
        //判断是否登录
        if (!mym.IsAdminLogin())
        {
            Response.Write("<script>parent.location.href='../login.aspx'</script>");
            Response.End();
        }
        //判断权限
        tbl_admin_role_value myrv = new tbl_admin_role_value();
        int role_id = Convert.ToInt32(Session["RoleID"]);
        int nav_id = 74;
        if (!myrv.QXExists(role_id, nav_id))
        {
            Response.Redirect("../error.html");
            Response.End();
        }

        this.jiebie = AXRequest.GetQueryInt("huiyuan_jiebie");

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





            RptBind("1=1" + CombSqlTxt(this.jiebie, this.note_no, this.start_time, this.stop_time, this.cha_type), "qiangdian_date desc");


        }
    }

     


    #region 数据绑定=================================
    private void RptBind(string _strWhere, string _orderby)
    {
        this.page = AXRequest.GetQueryInt("page", 1);


       
        txtNote_no.Text = this.note_no;
       
        this.type.SelectedValue = this.cha_type.ToString();
        tbl_qiangdian bll = new tbl_qiangdian();
        this.rptList.DataSource = bll.GetList(this.pageSize, this.page, _strWhere, _orderby, out this.totalCount);
        this.rptList.DataBind();

        //绑定页码
        txtPageNum.Text = this.pageSize.ToString();
        string pageUrl = Utils.CombUrlTxt("al_read5.aspx", "start_time={0}&stop_time={1}&huiyuan_jiebie={2}&note_no={3}&page={4}&type={5}", this.start_time.ToString(), this.stop_time.ToString(), this.jiebie.ToString(), this.note_no, "__id__", this.cha_type.ToString());
        PageContent.InnerHtml = Utils.OutPageList(this.pageSize, this.page, this.totalCount, pageUrl, 8);
    }
    #endregion

    #region 组合SQL查询语句==========================
    protected string CombSqlTxt(int _product_category_id, string _note_no, string _start_time, string _stop_time, int cha_type)
    {
        StringBuilder strTemp = new StringBuilder();

      


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
        if (int.TryParse(Utils.GetCookie("al_read5_page_size"), out _pagesize))
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
        Response.Redirect(Utils.CombUrlTxt("al_read5.aspx", "start_time={0}&stop_time={1}&huiyuan_jiebie={2}&note_no={3}&type={4}", "", "", "", txtNote_no.Text, this.type.SelectedValue));
    }

    //筛选会员级别
    protected void ddlproduct_category_id_SelectedIndexChanged(object sender, EventArgs e)
    {
        Response.Redirect(Utils.CombUrlTxt("al_read5.aspx", "start_time={0}&stop_time={1}&huiyuan_jiebie={2}&note_no={3}","", "", "", txtNote_no.Text));

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
                Utils.WriteCookie("al_read5_page_size", _pagesize.ToString(), 14400);
            }
        }
        Response.Redirect(Utils.CombUrlTxt("al_read5.aspx", "start_time={0}&stop_time={1}&huiyuan_jiebie={2}&note_no={3}&type={4}", "", "", "", txtNote_no.Text, this.type.SelectedValue));
    }

    //导出报表
 







    // 单个冻结
 

    // 单个冻结
 

    #region 返回状态=============================
    protected string GetOrderStatus(int _id, int _js_flag)
    {
        string _title = string.Empty;
        string _title1 = string.Empty;
        switch (_id)
        {
            case 0:
                _title = "<font color=green>普通会员</font>";
                break;
            case 1:
                _title = "<font color=green>主任</font>";
                break;
            case 2:
                _title = "<font color=green>初级经理</font>";
                break;
            case 3:
                _title = "<font color=green>高级经理</font>";
                break;
            case 4:
                _title = "<font color=green>总监</font>";
                break;
            case 5:
                _title = "<font color=green>董事</font>";
                break;


        }

        //switch (_js_flag)
        //{
        //    case 0:
        //        _title1 = "<font color=red>(未合格)</font>";
        //        break;
        //    case 1:
        //        _title1 = "<font color=green>(合格)</font>";
        //        break;



        //}
        if (_id > 0)
        {
            return _title + _title1;
        }
        else
        {
            return _title;
        }
    }
    #endregion
    #region 返回状态=============================
    protected string show_kongdan(int _kd_flag)
    {
        string _title = string.Empty;

        switch (_kd_flag)
        {
            case 0:
                _title = "<font color=green>正常会员</font>";
                break;
            case 1:
                _title = "<font color=red>二轮出局</font>";
                break;



        }



        return _title;

    }
    #endregion


}