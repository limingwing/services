﻿using System;
using System.Text;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class manager_member_al_read4 : System.Web.UI.Page
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
        int nav_id = 73;
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

            ZYBind();//绑定会员级别

            txtstart_time.Value = DateTime.Now.ToString("d");
            txtstop_time.Value = DateTime.Now.ToString("d");

            RptBind("huiyuan_id<>'A00000000' and net_hege=1  and xuhao2>0 " + CombSqlTxt(this.jiebie, this.note_no, this.start_time, this.stop_time, this.cha_type), "xuhao2 asc");


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
        txtstart_time.Value = this.start_time;
        txtstop_time.Value = this.stop_time;
        this.type.SelectedValue = this.cha_type.ToString();
        view_huiyuan bll = new view_huiyuan();
        this.rptList.DataSource = bll.GetList(this.pageSize, this.page, _strWhere, _orderby, out this.totalCount);
        this.rptList.DataBind();

        //绑定页码
        txtPageNum.Text = this.pageSize.ToString();
        string pageUrl = Utils.CombUrlTxt("al_read4.aspx", "start_time={0}&stop_time={1}&huiyuan_jiebie={2}&note_no={3}&page={4}&type={5}", this.start_time.ToString(), this.stop_time.ToString(), this.jiebie.ToString(), this.note_no, "__id__", this.cha_type.ToString());
        PageContent.InnerHtml = Utils.OutPageList(this.pageSize, this.page, this.totalCount, pageUrl, 8);
    }
    #endregion

    #region 组合SQL查询语句==========================
    protected string CombSqlTxt(int _product_category_id, string _note_no, string _start_time, string _stop_time, int cha_type)
    {
        StringBuilder strTemp = new StringBuilder();

        if (_product_category_id > 0)
        {
            strTemp.Append(" and huiyuan_jiebie=" + _product_category_id);
        }

        if (string.IsNullOrEmpty(_start_time))
        {
            _start_time = "1900-01-01";
        }
        if (string.IsNullOrEmpty(_stop_time))
        {
            _stop_time = "2099-01-01";
        }

        strTemp.Append(" and huiyuan_add_time between  '" + DateTime.Parse(_start_time) + "' and '" + DateTime.Parse(_stop_time + " 23:59:59") + "'");

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
        if (int.TryParse(Utils.GetCookie("al_read4_page_size"), out _pagesize))
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
        Response.Redirect(Utils.CombUrlTxt("al_read4.aspx", "start_time={0}&stop_time={1}&huiyuan_jiebie={2}&note_no={3}&type={4}", this.txtstart_time.Value, this.txtstop_time.Value, this.ddlproduct_category_id.SelectedValue, txtNote_no.Text, this.type.SelectedValue));
    }

    //筛选会员级别
    protected void ddlproduct_category_id_SelectedIndexChanged(object sender, EventArgs e)
    {
        Response.Redirect(Utils.CombUrlTxt("al_read4.aspx", "start_time={0}&stop_time={1}&huiyuan_jiebie={2}&note_no={3}", this.txtstart_time.Value, this.txtstop_time.Value, this.ddlproduct_category_id.SelectedValue, txtNote_no.Text));

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
                Utils.WriteCookie("al_read4_page_size", _pagesize.ToString(), 14400);
            }
        }
        Response.Redirect(Utils.CombUrlTxt("al_read4.aspx", "start_time={0}&stop_time={1}&huiyuan_jiebie={2}&note_no={3}&type={4}", this.txtstart_time.Value, this.txtstop_time.Value, this.ddlproduct_category_id.SelectedValue, txtNote_no.Text, this.type.SelectedValue));
    }

    //导出报表
    protected void btnExport_Click(object sender, EventArgs e)
    {

        //  Response.Redirect(Utils.CombUrlTxt("al_read4.aspx", "start_time={0}&stop_time={1}&huiyuan_jiebie={2}&note_no={3}", this.txtstart_time.Value, this.txtstop_time.Value, this.jiebie.ToString(), txtNote_no.Text));
        StringBuilder strTemp = new StringBuilder();

        if (!string.IsNullOrEmpty(txtNote_no.Text))
        {
            if (cha_type == 1)
            {
                strTemp.Append(" and huiyuan_bianhao like  '%" + txtNote_no.Text + "%' ");
            }

            if (cha_type == 2)
            {
                strTemp.Append(" and huiyuan_name like  '%" + txtNote_no.Text + "%' ");
            }
        }

        string sBeginTime = this.txtstart_time.Value;
        string sEndTime = this.txtstop_time.Value;




        if (sBeginTime.Length > 6 && sEndTime.Length > 6)
        {
            strTemp.Append(" and huiyuan_add_time between '" + sBeginTime + " 00:00:00' and '" + sEndTime + " 23:59:59'");

        }
        DataTable dt = null;
        string dc_sql = "select huiyuan_bianhao as 编号,huiyuan_name as 姓名,huiyuan_pass as 密码,huiyuan_add_time as 注册时间 from tbl_huiyuan where  1=1  " + strTemp.ToString() + " and huiyuan_id<>'A00000000' order by huiyuan_add_time desc";
        //Response.Write(dc_sql);
        //Response.End();
        dt = DbHelperSQL.Query(dc_sql).Tables[0];
        if (dt.Rows.Count == 0)
        {
            Response.Write("<script>alert('导出数据无效'); location.href='al_read4.aspx';</script>");
            return;
        }
        string filename = "";
        filename += "已开通会员汇总表" + DateTime.Now.ToString("d") + "";
        PMS.Common.NPOIHelper.ExportByWeb(dt, filename, filename + ".xls");

    }







    // 单个冻结
    protected void lbtnAcceptCaDG_Click(object sender, EventArgs e)
    {
        // 当前点击的按钮

        this.page = AXRequest.GetQueryInt("page");

        LinkButton lb = (LinkButton)sender;
        string huiyuan_id = lb.CommandArgument.ToString().Split(',')[0];

        int dongjie = Convert.ToInt32(lb.CommandArgument.ToString().Split(',')[1]);
        tbl_huiyuan bll = new tbl_huiyuan();
        bll.GetModel_hui_id(huiyuan_id);
        bll.huiyuan_id = huiyuan_id;

        if (dongjie == 0)
        {
            bll.huiyuan_suoding = 1;
        }
        else
        {

            bll.huiyuan_suoding = 0;
        }
        bll.UpdateStatus(); //更新冻结


        mym.JscriptMsg(this.Page, " 设置成功！", Utils.CombUrlTxt("al_read4.aspx", "start_time={0}&stop_time={1}&huiyuan_jiebie={2}&note_no={3}&type={4}&page={5}", this.txtstart_time.Value, this.txtstop_time.Value, this.ddlproduct_category_id.SelectedValue, txtNote_no.Text, this.type.SelectedValue, this.page.ToString()), "Success");


    }

    // 单个冻结
    protected void lbtnAcceptCaDG_Click1(object sender, EventArgs e)
    {
        // 当前点击的按钮

        this.page = AXRequest.GetQueryInt("page");

        LinkButton lb = (LinkButton)sender;
        string huiyuan_id = lb.CommandArgument.ToString().Split(',')[0];

        int xinxi_flag = Convert.ToInt32(lb.CommandArgument.ToString().Split(',')[1]);
        tbl_huiyuan bll = new tbl_huiyuan();
        bll.GetModel_hui_id(huiyuan_id);
        bll.huiyuan_id = huiyuan_id;

        if (xinxi_flag == 0)
        {
            bll.xinxi_flag = 1;
        }
        else
        {

            bll.xinxi_flag = 0;
        }
        bll.Update_fending(); //更新封顶


        mym.JscriptMsg(this.Page, " 设置成功！", Utils.CombUrlTxt("al_read4.aspx", "start_time={0}&stop_time={1}&huiyuan_jiebie={2}&note_no={3}&type={4}&page={5}", this.txtstart_time.Value, this.txtstop_time.Value, this.ddlproduct_category_id.SelectedValue, txtNote_no.Text, this.type.SelectedValue, this.page.ToString()), "Success");


    }

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