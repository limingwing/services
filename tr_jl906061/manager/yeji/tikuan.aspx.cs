using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;

public partial class manager_yeji_tikuan : System.Web.UI.Page
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
        int nav_id = 57;
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

            RptBind(" 1=1 " + CombSqlTxt(this.note_no, this.start_time, this.stop_time, this.cha_type), "tikuan_id desc");


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
        tbl_tikuan bll = new tbl_tikuan();
        this.rptList.DataSource = bll.GetList_t(this.pageSize, this.page, _strWhere, _orderby, out this.totalCount);
        this.rptList.DataBind();

        this.Literal2.Text = MyConvert(Convert.ToDecimal(bll.GetTitleSum_t(_strWhere, "sum(money)")));
        this.Literal3.Text = MyConvert(Convert.ToDecimal(bll.GetTitleSum_t(_strWhere, "sum(money_sj)")));

        //绑定页码
        txtPageNum.Text = this.pageSize.ToString();
        string pageUrl = Utils.CombUrlTxt("tikuan.aspx", "start_time={0}&stop_time={1}&note_no={2}&page={3}&type={4}", this.start_time.ToString(), this.stop_time.ToString(), this.note_no, "__id__", this.cha_type.ToString());
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
        strTemp.Append(" and  tikuan_date between  '" + DateTime.Parse(_start_time) + "' and '" + DateTime.Parse(_stop_time + " 23:59:59") + "'");

        _note_no = _note_no.Replace("'", "");


        if (!string.IsNullOrEmpty(_note_no))
        {
            if (cha_type == 1)
            {
                strTemp.Append(" and a.huiyuan_bianhao =  '" + _note_no + "' ");
            }

            if (cha_type == 2)
            {
                strTemp.Append(" and a.huiyuan_name =  '" + _note_no + "' ");
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
        Response.Redirect(Utils.CombUrlTxt("tikuan.aspx", "start_time={0}&stop_time={1}&note_no={2}&type={3}", this.txtstart_time.Value, this.txtstop_time.Value, txtNote_no.Text, this.type.SelectedValue));
    }

    //筛选会员级别
    protected void ddlproduct_category_id_SelectedIndexChanged(object sender, EventArgs e)
    {
        Response.Redirect(Utils.CombUrlTxt("tikuan.aspx", "start_time={0}&stop_time={1}&note_no={2}", this.txtstart_time.Value, this.txtstop_time.Value, txtNote_no.Text));

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
        Response.Redirect(Utils.CombUrlTxt("tikuan.aspx", "start_time={0}&stop_time={1}&note_no={2}&type={3}", this.txtstart_time.Value, this.txtstop_time.Value, txtNote_no.Text, this.type.SelectedValue));
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
                _title = "<font color=green>已处理</font>";
                break;
            case 2:
                _title = "<font color=orange>已退提</font>";
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
                _title = "<font color=green>积分</font>";
                break;
            case 2:
                _title = "<font color=green>分红</font>";
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



                    tbl_tikuan model = new tbl_tikuan();

                    model.tikuan_status = 1;
                    model.tikuan_id = KindID;
                    model.UpdateStatus(); //更新支付
 
 
                    this.page = AXRequest.GetQueryInt("page");

                    mym.JscriptMsg(this.Page, " 支付成功！", Utils.CombUrlTxt("tikuan.aspx", "start_time={0}&stop_time={1}&note_no={2}&type={3}&page={4}", this.txtstart_time.Value, this.txtstop_time.Value, txtNote_no.Text, this.type.SelectedValue, this.page.ToString()), "Success");
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
                    string huiyuan_id = e.CommandArgument.ToString().Split(',')[1];
                    string money = e.CommandArgument.ToString().Split(',')[2];
                    int zz_type = int.Parse(e.CommandArgument.ToString().Split(',')[3]);

                 
                   

                    tbl_huiyuan model1 = new tbl_huiyuan();
                    model1.GetModel_hui_id(huiyuan_id);
                    model1.huiyuan_id = huiyuan_id;

                    string huiyuan_bianhao = model1.huiyuan_bianhao;//会员编号
                    if (zz_type == 0)
                    {
                        decimal moneybefore = decimal.Parse((model1.jiangjing).ToString());//改变前余额

                        decimal moneyafter = moneybefore + decimal.Parse(money);//改变后余额
                        string memo = "管理员拒绝" + huiyuan_bianhao + "提现" + Decimal.Parse(money) + "元";
                        model1.jiangjing += Decimal.Parse(money);

                        if (model1.Update() == true)
                        {
                            tbl_tikuan model = new tbl_tikuan();
                            model.tikuan_status = 2;
                            model.tikuan_id = KindID;
                            model.UpdateStatus(); //更新支付

                            mym.queren_insert(huiyuan_id, huiyuan_bianhao, "拒绝支付", memo, Decimal.Parse(money), moneyafter);
                        }
                        else
                        {
                            mym.JscriptMsg(this.Page, "很抱歉，遇到了一个技术问题，操作没有成功，请稍后重试，或与技术人员联系。", "", "Error");
                            return;

                        }
                    }

                    if (zz_type == 2)
                    {
                        decimal moneybefore = decimal.Parse((model1.chongfu_money).ToString());//改变前余额

                        decimal moneyafter = moneybefore + decimal.Parse(money);//改变后余额
                        string memo = "管理员拒绝分红提现" + huiyuan_bianhao + "提现" + Decimal.Parse(money) + "元";
                        model1.chongfu_money = Decimal.Parse(money);

                        if (model1.Update_chongfu_money() == true)
                        {
                            tbl_tikuan model = new tbl_tikuan();
                            model.tikuan_status = 2;
                            model.tikuan_id = KindID;
                            model.UpdateStatus(); //更新支付

                            mym.queren_insert(huiyuan_id, huiyuan_bianhao, "拒绝支付", memo, Decimal.Parse(money), moneyafter);
                        }
                        else
                        {
                            mym.JscriptMsg(this.Page, "很抱歉，遇到了一个技术问题，操作没有成功，请稍后重试，或与技术人员联系。", "", "Error");
                            return;

                        }
                    }

                    this.page = AXRequest.GetQueryInt("page");

                    mym.JscriptMsg(this.Page, " 操作成功！", Utils.CombUrlTxt("tikuan.aspx", "start_time={0}&stop_time={1}&note_no={2}&type={3}&page={4}", this.txtstart_time.Value, this.txtstop_time.Value, txtNote_no.Text, this.type.SelectedValue, this.page.ToString()), "Success");
                }
                catch
                {

                    mym.JscriptMsg(this.Page, "很抱歉，遇到了一个技术问题，操作没有成功，请稍后重试，或与技术人员联系。", "", "Error");
                    return;

                }
            }
        }




    }

    //批量删除
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        int sucCount = 0; //成功数量
        int errorCount = 0; //失败数量
        tbl_liuyan bll = new tbl_liuyan();
        for (int i = 0; i < rptList.Items.Count; i++)
        {
            int id = Convert.ToInt32(((HiddenField)rptList.Items[i].FindControl("hidId")).Value);
            CheckBox cb = (CheckBox)rptList.Items[i].FindControl("chkId");
            if (cb.Checked)
            {
                tbl_tikuan model = new tbl_tikuan();
                model.GetModel(id);
                if (model.tikuan_status == 1 || model.tikuan_status == 2)
                {
                    mym.JscriptMsg(this.Page, "数据中有操作确认过，请检查去掉勾选！", "", "Error");
                    return;
                }
                model.tikuan_status = 1;
                model.tikuan_id = id;
                model.UpdateStatus(); //更新支付
 
            }
        }
        //mym.AddAdminLog("删除", "删除用户操作日志成功" + sucCount + "条，失败" + errorCount + "条"); //记录日志
        mym.JscriptMsg(this.Page, "操作成功", Utils.CombUrlTxt("tikuan.aspx", "start_time={0}&stop_time={1}&note_no={2}&type={3}&page={4}", this.txtstart_time.Value, this.txtstop_time.Value, txtNote_no.Text, this.type.SelectedValue, this.page.ToString()), "Success");
    }
    protected void btnExport_Click(object sender, EventArgs e)
    {
        StringBuilder strTemp = new StringBuilder();

        




       
        DataTable dt = null;
        string dc_sql = "select huiyuan_bianhao as 编号,bankname as 开户银行,accountno as 银行账号,accountname as 开户姓名,accountname as 开户姓名 ,money as 提奖励积分额,tikuan_date as 提款时间 from tbl_tikuan where tikuan_status=0   order by tikuan_date desc";
        //Response.Write(dc_sql);
        //Response.End();
        dt = DbHelperSQL.Query(dc_sql).Tables[0];
        if (dt.Rows.Count == 0)
        {
            Response.Write("<script>alert('导出数据无效'); location.href='al_Read2.aspx';</script>");
            return;
        }
        string filename = "";
        filename += "已开通会员汇总表" + DateTime.Now.ToString("d") + "";
        PMS.Common.NPOIHelper.ExportByWeb(dt, filename, filename + ".xls");
    }
    protected void btnExport_Click1(object sender, EventArgs e)
    {
        StringBuilder strTemp = new StringBuilder();







        DataTable dt = null;
        string dc_sql = "select huiyuan_bianhao as 编号,bankname as 开户银行,accountno as 银行账号,accountname as 开户姓名,accountname as 开户姓名 ,money as 提奖励积分额,tikuan_date as 提款时间 from tbl_tikuan where tikuan_status=1   order by tikuan_date desc";
        //Response.Write(dc_sql);
        //Response.End();
        dt = DbHelperSQL.Query(dc_sql).Tables[0];
        if (dt.Rows.Count == 0)
        {
            Response.Write("<script>alert('导出数据无效'); location.href='al_Read2.aspx';</script>");
            return;
        }
        string filename = "";
        filename += "已开通会员汇总表" + DateTime.Now.ToString("d") + "";
        PMS.Common.NPOIHelper.ExportByWeb(dt, filename, filename + ".xls");
    }
}