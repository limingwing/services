using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;

public partial class manager_yeji_chezi_list : System.Web.UI.Page
{
    protected int totalCount;
    protected int page;
    protected int pageSize;


    protected int cha_type;
    protected string note_no = string.Empty;
    protected string start_time = string.Empty;
    protected string stop_time = string.Empty;
    protected int status1;

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
        int nav_id = 79;
        if (!myrv.QXExists(role_id, nav_id))
        {
            Response.Redirect("../error.html");
            Response.End();
        }


        this.status1 = AXRequest.GetQueryInt("status");
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

            RptBind(" 1=1 " + CombSqlTxt(this.note_no, this.start_time, this.stop_time, this.cha_type,this.status1), "id desc");


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
        tbl_chezi bll = new tbl_chezi();
        this.rptList.DataSource = bll.GetList_view(this.pageSize, this.page, _strWhere, _orderby, out this.totalCount);
        this.rptList.DataBind();

        this.Literal2.Text = MyConvert(Convert.ToDecimal(bll.GetTitleSum(_strWhere, "sum(xiaofei_money)")));
        //this.Literal3.Text = MyConvert(Convert.ToDecimal(bll.GetTitleSum(_strWhere, "sum(money_sj)")));

        //绑定页码
        txtPageNum.Text = this.pageSize.ToString();
        string pageUrl = Utils.CombUrlTxt("chezi_list.aspx", "start_time={0}&stop_time={1}&note_no={2}&page={3}&type={4}", this.start_time.ToString(), this.stop_time.ToString(), this.note_no, "__id__", this.cha_type.ToString());
        PageContent.InnerHtml = Utils.OutPageList(this.pageSize, this.page, this.totalCount, pageUrl, 8);
    }
    #endregion

    #region 组合SQL查询语句==========================
    protected string CombSqlTxt(string _note_no, string _start_time, string _stop_time, int cha_type, int _status)
    {
        StringBuilder strTemp = new StringBuilder();

        if (_status > 0)
        {
            if (_status == 1)
            {
                strTemp.Append(" and flag=" + (_status - 1));
            }
            if (_status == 2)
            {
                strTemp.Append(" and flag<>0" );
            }
        }

        if (string.IsNullOrEmpty(_start_time))
        {
            _start_time = "1900-01-01";
        }
        if (string.IsNullOrEmpty(_stop_time))
        {
            _stop_time = "2099-01-01";
        }
        strTemp.Append(" and  xiaofei_qr_date between  '" + DateTime.Parse(_start_time) + "' and '" + DateTime.Parse(_stop_time + " 23:59:59") + "'");

        _note_no = _note_no.Replace("'", "");


        if (!string.IsNullOrEmpty(_note_no))
        {
            if (cha_type == 1)
            {
                strTemp.Append(" and xiaofei_bianhao =  '" + _note_no + "' ");
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
        if (int.TryParse(Utils.GetCookie("tikuan_page_size"), out _pagesize))
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
        Response.Redirect(Utils.CombUrlTxt("chezi_list.aspx", "start_time={0}&stop_time={1}&note_no={2}&type={3}", this.txtstart_time.Value, this.txtstop_time.Value, txtNote_no.Text, this.type.SelectedValue));
    }

    //筛选会员级别
    protected void ddlproduct_category_id_SelectedIndexChanged(object sender, EventArgs e)
    {
        Response.Redirect(Utils.CombUrlTxt("chezi_list.aspx", "start_time={0}&stop_time={1}&note_no={2}", this.txtstart_time.Value, this.txtstop_time.Value, txtNote_no.Text));

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
                Utils.WriteCookie("tikuan_page_size", _pagesize.ToString(), 14400);
            }
        }
        Response.Redirect(Utils.CombUrlTxt("chezi_list.aspx", "start_time={0}&stop_time={1}&note_no={2}&type={3}", this.txtstart_time.Value, this.txtstop_time.Value, txtNote_no.Text, this.type.SelectedValue));
    }


    //筛选状态
    protected void ddlproduct_category_id_SelectedIndexChanged2(object sender, EventArgs e)
    {
        Response.Redirect(Utils.CombUrlTxt("chezi_list.aspx", "start_time={0}&stop_time={1}&note_no={2}&type={3}&status={4}", this.txtstart_time.Value, this.txtstop_time.Value, txtNote_no.Text, this.type.SelectedValue, this.status.SelectedValue));

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

    #region 返回状态=============================
    protected string GetOrderStatus(int _id)
    {
        string _title = string.Empty;

        switch (_id)
        {
            case 0:
                _title = "<font color=red>未处理</font>";
                break;
            case 1:
                _title = "<font color=green>批准</font>";
                break;
            case 2:
                _title = "<font color=orange>退回</font>";
                break;

        }

        return _title;
    }
    #endregion

    #region 返回状态=============================
    protected string GetzhifuStatus(int _id)
    {
        string _title = string.Empty;

        switch (_id)
        {

            case 1:
                _title = "<font color=green>积分币</font>";
                break;
            case 2:
                _title = "<font color=green>分红币</font>";
                break;

        }

        return _title;
    }
    #endregion

    protected void GetWhichCommand(object sender, CommandEventArgs e)
    {
        if (e.CommandName == "zhifu")
        {
            if (e.CommandArgument != null)
            {
                try
                {

                    int KindID = int.Parse(e.CommandArgument.ToString().Split(',')[0]);

                    decimal xiaofei_money1 =decimal.Parse(e.CommandArgument.ToString().Split(',')[1]);
                    decimal benjin =decimal.Parse(e.CommandArgument.ToString().Split(',')[2]);

                    tbl_chezi model = new tbl_chezi();
                    model.GetModel(KindID);
                   
                    decimal sq_money=decimal.Parse(model.xiaofei_money.ToString());
                    int yuan_id = int.Parse(model.yuanshi_id.ToString());
                  
                    model.flag = 1;
                    model.quxiao_date = DateTime.Now;
                  

                    tbl_xiaofei bll = new tbl_xiaofei();
                    bll.GetModel_id(yuan_id);
                    int zhuce_flag = int.Parse(bll.zhuce_flag.ToString());
                
                    if (sq_money > benjin )
                        {
                            mym.JscriptMsg(this.Page, "操作失败，本金不足或部分资金冻结！", "", "Error");
                            return;
                        }
                   
                    bll.xiaofei_money = bll.xiaofei_money - sq_money;
                    bll.Update();
                    model.Update(); //更新支付
                    this.page = AXRequest.GetQueryInt("page");

                    mym.JscriptMsg(this.Page, " 支付成功！", Utils.CombUrlTxt("chezi_list.aspx", "start_time={0}&stop_time={1}&note_no={2}&type={3}&page={4}", this.txtstart_time.Value, this.txtstop_time.Value, txtNote_no.Text, this.type.SelectedValue, this.page.ToString()), "Success");
                }
                catch
                {
                    mym.JscriptMsg(this.Page, "很抱歉，遇到了一个技术问题，操作没有成功，请稍后重试，或与技术人员联系。", "", "Error");
                    return;
                }
            }
        }
        if (e.CommandName == "zhifu_no")
        {
            if (e.CommandArgument != null)
            {
                try
                {

                    int KindID = int.Parse(e.CommandArgument.ToString().Split(',')[0]);




                    tbl_chezi model1 = new tbl_chezi();
                    model1.GetModel(KindID);
                    model1.flag = 2;
                    model1.Update();

                    mym.JscriptMsg(this.Page, " 处理成功！", Utils.CombUrlTxt("chezi_list.aspx", "start_time={0}&stop_time={1}&note_no={2}&type={3}&page={4}", this.txtstart_time.Value, this.txtstop_time.Value, txtNote_no.Text, this.type.SelectedValue, this.page.ToString()), "Success");
                    
                }
                catch
                {

                    mym.JscriptMsg(this.Page, "很抱歉，遇到了一个技术问题，操作没有成功，请稍后重试，或与技术人员联系。", "", "Error");
                    return;

                }
            }
        }




    }

    //批量确认
    protected void btnDelete_Click(object sender, EventArgs e)
    {





        int sucCount = 0; //成功数量
        int errorCount = 0; //失败数量
        
        for (int i = 0; i < rptList.Items.Count; i++)
        {
            string id =  ((HiddenField)rptList.Items[i].FindControl("hidId")).Value ;

            int KindID = int.Parse(id.ToString().Split(',')[0]);

            decimal xiaofei_money1 = decimal.Parse(id.ToString().Split(',')[1]);
            decimal benjin = decimal.Parse(id.ToString().Split(',')[2]);

            CheckBox cb = (CheckBox)rptList.Items[i].FindControl("chkId");
            if (cb.Checked)
            {



                tbl_chezi model = new tbl_chezi();
                model.GetModel(KindID);
                if (model.flag == 1 || model.flag == 2)
                {
                    mym.JscriptMsg(this.Page, "数据中有操作确认过，请检查去掉勾选！", "", "Error");
                    return;
                }

                decimal sq_money = decimal.Parse(model.xiaofei_money.ToString());
                int yuan_id = int.Parse(model.yuanshi_id.ToString());

                model.flag = 1;
                model.quxiao_date = DateTime.Now;


                tbl_xiaofei bll = new tbl_xiaofei();
                bll.GetModel_id(yuan_id);
                int zhuce_flag = int.Parse(bll.zhuce_flag.ToString());
                if (sq_money > (benjin - xiaofei_money1))
                {
                    mym.JscriptMsg(this.Page, "操作失败，本金不足或部分资金冻结！", "", "Error");
                    return;
                }
                bll.xiaofei_money = bll.xiaofei_money - sq_money;
                bll.Update();
                model.Update(); //更新支付
            }
        }
        //mym.AddAdminLog("删除", "删除用户操作日志成功" + sucCount + "条，失败" + errorCount + "条"); //记录日志
        mym.JscriptMsg(this.Page, "操作成功", Utils.CombUrlTxt("chezi_list.aspx", "start_time={0}&stop_time={1}&note_no={2}&type={3}&page={4}", this.txtstart_time.Value, this.txtstop_time.Value, txtNote_no.Text, this.type.SelectedValue, this.page.ToString()), "Success");
    }
    protected void btnExport_Click(object sender, EventArgs e)
    {
        StringBuilder strTemp = new StringBuilder();







        DataTable dt = null;
        string dc_sql = "select xiaofei_bianhao as 编号,huiyuan_name as 姓名,xiaofei_money as 撤资金额,xiaofei_qr_date as 撤资时间,huiyuan_yinhang as 会员银行,huiyuan_yinhang_zh as 银行账号,huiyuan_yinhang_name as 开户姓名  from view_chezi where flag=0   order by id desc";
        //Response.Write(dc_sql);
        //Response.End();
        dt = DbHelperSQL.Query(dc_sql).Tables[0];
        if (dt.Rows.Count == 0)
        {
            Response.Write("<script>alert('导出数据无效'); location.href='chezi_list.aspx';</script>");
            return;
        }
        string filename = "";
        filename += "未处理订单" + DateTime.Now.ToString("d") + "";
        PMS.Common.NPOIHelper.ExportByWeb(dt, filename, filename + ".xls");
    }
    protected void btnExport_Click1(object sender, EventArgs e)
    {
        StringBuilder strTemp = new StringBuilder();







        DataTable dt = null;
        string dc_sql = "select xiaofei_bianhao as 编号,huiyuan_name as 姓名,xiaofei_money as 撤资金额,xiaofei_qr_date as 撤资时间,huiyuan_yinhang as 会员银行,huiyuan_yinhang_zh as 银行账号,huiyuan_yinhang_name as 开户姓名   from view_chezi where flag<>0   order by id desc";
        //Response.Write(dc_sql);
        //Response.End();
        dt = DbHelperSQL.Query(dc_sql).Tables[0];
        if (dt.Rows.Count == 0)
        {
            Response.Write("<script>alert('导出数据无效'); location.href='chezi_list.aspx';</script>");
            return;
        }
        string filename = "";
        filename += "已处理订单" + DateTime.Now.ToString("d") + "";
        PMS.Common.NPOIHelper.ExportByWeb(dt, filename, filename + ".xls");
    }
}