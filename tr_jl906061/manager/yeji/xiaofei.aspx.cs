using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;

public partial class manager_yeji_xiaofei : System.Web.UI.Page
{
    protected int totalCount;
    protected int page;
    protected int pageSize;


    protected int cha_type;
    protected string note_no = string.Empty;
    protected string start_time = string.Empty;
    protected string stop_time = string.Empty;
    protected int leixing;
    protected int status;
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
        int nav_id = 58;
        if (!myrv.QXExists(role_id, nav_id))
        {
            Response.Redirect("../error.html");
            Response.End();
        }


        this.leixing = AXRequest.GetQueryInt("leixing");

        this.status = AXRequest.GetQueryInt("status");
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

            RptBind(" 1=1 and zhuce_flag =1 and xiaofei_qr_flag=1 " + CombSqlTxt(this.note_no, this.start_time, this.stop_time, this.cha_type, this.leixing, this.status), "xiaofei_id desc");


        }
    }




    #region 数据绑定=================================
    private void RptBind(string _strWhere, string _orderby)
    {
        this.page = AXRequest.GetQueryInt("page", 1);
        if (this.leixing > 0)
        {
            this.ddlproduct_category_id.SelectedValue = this.leixing.ToString();
        }

        if (this.status > 0)
        {
            this.DropDownList1.SelectedValue = this.status.ToString();
        }

        txtNote_no.Text = this.note_no;
        txtstart_time.Value = this.start_time;
        txtstop_time.Value = this.stop_time;
        this.type.SelectedValue = this.cha_type.ToString();
        view_xiaofei bll = new view_xiaofei();
        this.rptList.DataSource = bll.GetList(this.pageSize, this.page, _strWhere, _orderby, out this.totalCount);
        this.rptList.DataBind();

        this.Literal_hj.Text = MyConvert(Convert.ToDecimal(bll.GetTitleSum(_strWhere, "sum(xiaofei_money)")));
        //this.Literal1.Text = MyConvert(Convert.ToDecimal(bll.GetTitleSum(_strWhere, "sum(jiangjin_zong-jiangjin_yong)")));
        //this.Literal2.Text = MyConvert(Convert.ToDecimal(bll.GetTitleSum(_strWhere, "sum(chongfu_money)")));
        //绑定页码
        txtPageNum.Text = this.pageSize.ToString();
        string pageUrl = Utils.CombUrlTxt("xiaofei.aspx", "start_time={0}&stop_time={1}&note_no={2}&page={3}&type={4}", this.start_time.ToString(), this.stop_time.ToString(), this.note_no, "__id__", this.cha_type.ToString());
        PageContent.InnerHtml = Utils.OutPageList(this.pageSize, this.page, this.totalCount, pageUrl, 8);
    }
    #endregion

    #region 组合SQL查询语句==========================
    protected string CombSqlTxt(string _note_no, string _start_time, string _stop_time, int cha_type, int _leixing, int _status)
    {
        StringBuilder strTemp = new StringBuilder();

        if (_leixing > 0)
        {
            strTemp.Append(" and zhuce_flag=" + _leixing);
        }

        if (_status > 0)
        {
            strTemp.Append(" and is_flag=" + (_status-1));
        }


        if (string.IsNullOrEmpty(_start_time))
        {
            _start_time = "1900-01-01";
        }
        if (string.IsNullOrEmpty(_stop_time))
        {
            _stop_time = "2099-01-01";
        }
        strTemp.Append(" and  xiaofei_date between  '" + DateTime.Parse(_start_time) + "' and '" + DateTime.Parse(_stop_time + " 23:59:59") + "'");

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

            if (cha_type == 3)
            {
                strTemp.Append(" and xiaofei_id =  '" + _note_no + "' ");
            }

            if (cha_type == 4)
            {
                tbl_huiyuan blx = new tbl_huiyuan();
                blx.GetModel_hui_bianhao(_note_no);

                strTemp.Append(" and huiyuan_shangshu2 like  '%" + blx.huiyuan_id + "%' and huiyuan_id<>'" + blx.huiyuan_id + "' ");
            }
        }
        return strTemp.ToString();
    }
    #endregion

    #region 返回每页数量=============================
    private int GetPageSize(int _default_size)
    {
        int _pagesize;
        if (int.TryParse(Utils.GetCookie("qianbao_page_size"), out _pagesize))
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
        Response.Redirect(Utils.CombUrlTxt("xiaofei.aspx", "start_time={0}&stop_time={1}&note_no={2}&type={3}&leixing={4}&leixing={5}", this.txtstart_time.Value, this.txtstop_time.Value, txtNote_no.Text, this.type.SelectedValue, this.ddlproduct_category_id.SelectedValue, this.DropDownList1.SelectedValue));
    }

    //筛选类型
    protected void ddlproduct_category_id_SelectedIndexChanged1(object sender, EventArgs e)
    {
        Response.Redirect(Utils.CombUrlTxt("xiaofei.aspx", "start_time={0}&stop_time={1}&note_no={2}&leixing={3}", this.txtstart_time.Value, this.txtstop_time.Value, txtNote_no.Text, this.ddlproduct_category_id.SelectedValue));

    }
    //筛选状态
    protected void ddlproduct_category_id_SelectedIndexChanged2(object sender, EventArgs e)
    {
        Response.Redirect(Utils.CombUrlTxt("xiaofei.aspx", "start_time={0}&stop_time={1}&note_no={2}&leixing={3}&status={4}", this.txtstart_time.Value, this.txtstop_time.Value, txtNote_no.Text, this.ddlproduct_category_id.SelectedValue, this.DropDownList1.SelectedValue));

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
                Utils.WriteCookie("qianbao_page_size", _pagesize.ToString(), 14400);
            }
        }
        Response.Redirect(Utils.CombUrlTxt("xiaofei.aspx", "start_time={0}&stop_time={1}&note_no={2}&type={3}", this.txtstart_time.Value, this.txtstop_time.Value, txtNote_no.Text, this.type.SelectedValue));
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

    protected void rptKindInfoList_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "save")
        {
            if (e.CommandArgument != null)
            {
                try
                {

                    string KindID = e.CommandArgument.ToString().Split(',')[0];
                    int itemIndex = Convert.ToInt32(e.CommandArgument.ToString().Split(',')[1]);
                    TextBox TextBox1 = this.rptList.Items[itemIndex].FindControl("TextBox2") as TextBox;
                    string money = TextBox1.Text.Trim();
                    Decimal dec;

                    if (!Decimal.TryParse(money, out dec))
                    {
                        mym.JscriptMsg(this.Page, "您输入的充值金额不正确，请重新输入！", "", "Error");
                        return;

                    }


                    tbl_huiyuan model = new tbl_huiyuan();
                    model.GetModel_hui_id(KindID);
                    model.huiyuan_id = KindID;

                    string huiyuan_bianhao = model.huiyuan_bianhao;//会员编号

                    decimal moneybefore = decimal.Parse((model.qianbao - model.fenhong_canshu1).ToString());//改变前余额

                    decimal moneyafter = moneybefore + decimal.Parse(money);//改变后余额
                    string memo = "管理员为会员" + huiyuan_bianhao + "充值" + Decimal.Parse(money) + "元积分币";
                    model.qianbao = Decimal.Parse(money);
                    model.Updateqianbao();



                    mym.queren_insert(KindID, huiyuan_bianhao, "充值积分币", memo, Decimal.Parse(money), moneyafter);


                    this.page = AXRequest.GetQueryInt("page");

                    mym.JscriptMsg(this.Page, " 充值成功！", Utils.CombUrlTxt("xiaofei.aspx", "start_time={0}&stop_time={1}&note_no={2}&type={3}&page={4}", this.txtstart_time.Value, this.txtstop_time.Value, txtNote_no.Text, this.type.SelectedValue, this.page.ToString()), "Success");
                }
                catch
                {
                    mym.JscriptMsg(this.Page, "很抱歉，遇到了一个技术问题，充值没有成功，请稍后重试，或与技术人员联系。", "", "Error");
                    return;
                }
            }
        }
        if (e.CommandName == "save1")
        {
            if (e.CommandArgument != null)
            {
                try
                {

                    string KindID = e.CommandArgument.ToString().Split(',')[0];
                    //Response.Write(KindID);
                   // Response.End();
                    int itemIndex = Convert.ToInt32(e.CommandArgument.ToString().Split(',')[1]);
                    TextBox TextBox1 = this.rptList.Items[itemIndex].FindControl("TextBox1") as TextBox;
                    string money = TextBox1.Text.Trim();
                    Decimal dec;

                    if (!Decimal.TryParse(money, out dec))
                    {
                        mym.JscriptMsg(this.Page, "您输入的充值金额不正确，请重新输入！", "", "Error");
                        return;
                    }



                    tbl_xiaofei model = new tbl_xiaofei();
                    model.GetModel_id(int.Parse(KindID));
                    model.fh_money =decimal.Parse(money);
                   
                    model.Update();
                    string huiyuan_id = model.xiaofei_hui_id;
                    tbl_huiyuan bll = new tbl_huiyuan();
                    bll.GetModel_hui_id(huiyuan_id);




                    string huiyuan_bianhao = bll.huiyuan_bianhao;//会员编号

                   

            
                    string memo = "管理员修改" + huiyuan_bianhao + "收益率为" + Decimal.Parse(money) + "";
                     
                    


                    mym.queren_insert(KindID, huiyuan_bianhao, "修改收益率", memo, Decimal.Parse(money), 0);

                    this.page = AXRequest.GetQueryInt("page");

                    mym.JscriptMsg(this.Page, " 修改成功！", Utils.CombUrlTxt("xiaofei.aspx", "start_time={0}&stop_time={1}&note_no={2}&type={3}&page={4}", this.txtstart_time.Value, this.txtstop_time.Value, txtNote_no.Text, this.type.SelectedValue, this.page.ToString()), "Success");
                }
                catch
                {

                    mym.JscriptMsg(this.Page, "很抱歉，遇到了一个技术问题，充值没有成功，请稍后重试，或与技术人员联系。", "", "Error");
                    return;

                }
            }
        }

        if (e.CommandName == "save2")
        {
            if (e.CommandArgument != null)
            {
                try
                {

                    string KindID = e.CommandArgument.ToString().Split(',')[0];
                    int itemIndex = Convert.ToInt32(e.CommandArgument.ToString().Split(',')[1]);
                    TextBox TextBox1 = this.rptList.Items[itemIndex].FindControl("TextBox2") as TextBox;
                    string money = TextBox1.Text.Trim();
                    Decimal dec;

                    if (!Decimal.TryParse(money, out dec))
                    {
                        mym.JscriptMsg(this.Page, "您输入的充值金额不正确，请重新输入！", "", "Error");
                        return;
                    }




                    tbl_xiaofei model = new tbl_xiaofei();
                    model.GetModel_id(int.Parse(KindID));

                    if ( model.xiaofei_money<decimal.Parse(money))
                    {
                        mym.JscriptMsg(this.Page, "您输入的充值金额不正确，不能超过本金！", "", "Error");
                        return;
                    
                    }
                    model.xiaofei_money1 = decimal.Parse(money);

                    model.Update();
                    string huiyuan_id = model.xiaofei_hui_id;
                    tbl_huiyuan bll = new tbl_huiyuan();
                    bll.GetModel_hui_id(huiyuan_id);




                    string huiyuan_bianhao = bll.huiyuan_bianhao;//会员编号




                    string memo = "管理员修改" + huiyuan_bianhao + "，订单号" + KindID + ",冻结金额为" + Decimal.Parse(money) + "";




                    mym.queren_insert(KindID, huiyuan_bianhao, "修改冻结资金", memo, Decimal.Parse(money), 0);

                    this.page = AXRequest.GetQueryInt("page");

                    mym.JscriptMsg(this.Page, " 修改成功！", Utils.CombUrlTxt("xiaofei.aspx", "start_time={0}&stop_time={1}&note_no={2}&type={3}&page={4}", this.txtstart_time.Value, this.txtstop_time.Value, txtNote_no.Text, this.type.SelectedValue, this.page.ToString()), "Success");
                }
                catch
                {

                    mym.JscriptMsg(this.Page, "很抱歉，遇到了一个技术问题，充值没有成功，请稍后重试，或与技术人员联系。", "", "Error");
                    return;

                }
            }
        }

        if (e.CommandName == "save3")
        {
            if (e.CommandArgument != null)
            {
                try
                {

                    string KindID = e.CommandArgument.ToString().Split(',')[0];
                    int itemIndex = Convert.ToInt32(e.CommandArgument.ToString().Split(',')[1]);
                    TextBox TextBox1 = this.rptList.Items[itemIndex].FindControl("TextBox4") as TextBox;
                    string money = TextBox1.Text.Trim();
                    Decimal dec;

                    if (!Decimal.TryParse(money, out dec))
                    {
                        mym.JscriptMsg(this.Page, "您输入的充值金额不正确，请重新输入！", "", "Error");
                        return;
                    }



                    tbl_huiyuan model = new tbl_huiyuan();
                    model.GetModel_hui_id(KindID);
                    model.huiyuan_id = KindID;

                    string huiyuan_bianhao = model.huiyuan_bianhao;//会员编号

                    decimal moneybefore = decimal.Parse((model.chongfu_zong.ToString()).ToString());//改变前余额

                    decimal moneyafter = moneybefore + decimal.Parse(money);//改变后余额
                    string memo = "管理员为会员" + huiyuan_bianhao + "充值" + Decimal.Parse(money) + "元重销币";
                    model.chongfu_zong = Decimal.Parse(money);
                    model.Update_chongfu_zong();


                    mym.queren_insert(KindID, huiyuan_bianhao, "充值重复消费币", memo, Decimal.Parse(money), moneyafter);

                    this.page = AXRequest.GetQueryInt("page");

                    mym.JscriptMsg(this.Page, " 充值成功！", Utils.CombUrlTxt("xiaofei.aspx", "start_time={0}&stop_time={1}&note_no={2}&type={3}&page={4}", this.txtstart_time.Value, this.txtstop_time.Value, txtNote_no.Text, this.type.SelectedValue, this.page.ToString()), "Success");
                }
                catch
                {

                    mym.JscriptMsg(this.Page, "很抱歉，遇到了一个技术问题，充值没有成功，请稍后重试，或与技术人员联系。", "", "Error");
                    return;

                }
            }
        }

        if (e.CommandName == "save4")
        {
            if (e.CommandArgument != null)
            {
                try
                {

                    string KindID = e.CommandArgument.ToString().Split(',')[0];
                    int itemIndex = Convert.ToInt32(e.CommandArgument.ToString().Split(',')[1]);
                    TextBox TextBox1 = this.rptList.Items[itemIndex].FindControl("TextBox4") as TextBox;
                    string money = TextBox1.Text.Trim();
                    Decimal dec;

                    if (!Decimal.TryParse(money, out dec))
                    {
                        mym.JscriptMsg(this.Page, "您输入的充值金额不正确，请重新输入！", "", "Error");
                        return;
                    }



                    tbl_huiyuan model = new tbl_huiyuan();
                    model.GetModel_hui_id(KindID);
                    model.huiyuan_id = KindID;

                    string huiyuan_bianhao = model.huiyuan_bianhao;//会员编号

                    decimal moneybefore = decimal.Parse((model.glf_money.ToString()).ToString());//改变前余额

                    decimal moneyafter = moneybefore + decimal.Parse(money);//改变后余额
                    string memo = "管理员为会员" + huiyuan_bianhao + "充值" + Decimal.Parse(money) + "元福利基金";
                    model.glf_money = model.glf_money + Decimal.Parse(money);
                    model.Update();


                    mym.queren_insert(KindID, huiyuan_bianhao, "充值重复福利基金", memo, Decimal.Parse(money), moneyafter);

                    this.page = AXRequest.GetQueryInt("page");

                    mym.JscriptMsg(this.Page, " 充值成功！", Utils.CombUrlTxt("xiaofei.aspx", "start_time={0}&stop_time={1}&note_no={2}&type={3}&page={4}", this.txtstart_time.Value, this.txtstop_time.Value, txtNote_no.Text, this.type.SelectedValue, this.page.ToString()), "Success");
                }
                catch
                {

                    mym.JscriptMsg(this.Page, "很抱歉，遇到了一个技术问题，充值没有成功，请稍后重试，或与技术人员联系。", "", "Error");
                    return;

                }
            }
        }


        if (e.CommandName == "save5")
        {
            if (e.CommandArgument != null)
            {
                try
                {

                    string KindID = e.CommandArgument.ToString().Split(',')[0];
                    int itemIndex = Convert.ToInt32(e.CommandArgument.ToString().Split(',')[1]);
                    TextBox TextBox1 = this.rptList.Items[itemIndex].FindControl("TextBox5") as TextBox;
                    string money = TextBox1.Text.Trim();
                    Decimal dec;

                    if (!Decimal.TryParse(money, out dec))
                    {
                        mym.JscriptMsg(this.Page, "您输入的充值金额不正确，请重新输入！", "", "Error");
                        return;
                    }



                    tbl_huiyuan model = new tbl_huiyuan();
                    model.GetModel_hui_id(KindID);
                    model.huiyuan_id = KindID;

                    string huiyuan_bianhao = model.huiyuan_bianhao;//会员编号

                    decimal moneybefore = decimal.Parse((model.glf_money.ToString()).ToString());//改变前余额

                    decimal moneyafter = moneybefore + decimal.Parse(money);//改变后余额
                    string memo = "管理员为会员" + huiyuan_bianhao + "充值" + Decimal.Parse(money) + "购物币";
                    model.fh_money = model.fh_money + Decimal.Parse(money);
                    model.Update();


                    mym.queren_insert(KindID, huiyuan_bianhao, "充值购物币", memo, Decimal.Parse(money), moneyafter);

                    this.page = AXRequest.GetQueryInt("page");

                    mym.JscriptMsg(this.Page, " 充值成功！", Utils.CombUrlTxt("xiaofei.aspx", "start_time={0}&stop_time={1}&note_no={2}&type={3}&page={4}", this.txtstart_time.Value, this.txtstop_time.Value, txtNote_no.Text, this.type.SelectedValue, this.page.ToString()), "Success");
                }
                catch
                {

                    mym.JscriptMsg(this.Page, "很抱歉，遇到了一个技术问题，充值没有成功，请稍后重试，或与技术人员联系。", "", "Error");
                    return;

                }
            }
        }


        if (e.CommandName == "save6")
        {
            if (e.CommandArgument != null)
            {
                try
                {

                    string KindID = e.CommandArgument.ToString().Split(',')[0];
                    int itemIndex = Convert.ToInt32(e.CommandArgument.ToString().Split(',')[1]);




                    tbl_xiaofei model = new tbl_xiaofei();
                    model.GetModel_id(int.Parse(KindID));
                    decimal yuan_money = decimal.Parse(model.xiaofei_money.ToString());
                
                    model.xiaofei_money = 0;
                    model.xiaofei_money1 = 0;
                    model.is_flag = 1;
                    model.Update();
                    string huiyuan_id = model.xiaofei_hui_id;
                    tbl_huiyuan bll = new tbl_huiyuan();
                    bll.GetModel_hui_id(huiyuan_id);




                    string huiyuan_bianhao = bll.huiyuan_bianhao;//会员编号




                    string memo = "管理员退出订单号" + KindID + "的计算";




                    mym.queren_insert(KindID, huiyuan_bianhao, "退出资金", memo, yuan_money, 0);

                    this.page = AXRequest.GetQueryInt("page");

                    mym.JscriptMsg(this.Page, " 修改成功！", Utils.CombUrlTxt("xiaofei.aspx", "start_time={0}&stop_time={1}&note_no={2}&type={3}&page={4}", this.txtstart_time.Value, this.txtstop_time.Value, txtNote_no.Text, this.type.SelectedValue, this.page.ToString()), "Success");
                }
                catch
                {

                    mym.JscriptMsg(this.Page, "很抱歉，遇到了一个技术问题，充值没有成功，请稍后重试，或与技术人员联系。", "", "Error");
                    return;

                }
            }
        }
    }


    #region 返回状态=============================
    protected string GetzhifuStatus(int _id)
    {
        string _title = string.Empty;

        switch (_id)
        {

            case 0:
                _title = "<font color=green>正常</font>";
                break;
            case 1:
                _title = "<font color=red>已赎回</font>";
                break;

        }

        return _title;
    }
    #endregion

    
    #region 返回状态=============================
    protected string GetzhifuStatus1(int _id)
    {
        string _title = string.Empty;

        switch (_id)
        {

            case 1:
                _title = "<font color=green>注册单</font>";
                break;
            case 2:
                _title = "<font color=red>升级单</font>";
                break;
            case 3:
                _title = "<font color=blue>打印机单</font>";
                break;
        }

        return _title;
    }
    #endregion


    

    #region 返回状态=============================
    protected string Getstatus(int _id,int tianshu)
    {
        string _title = string.Empty;

        switch (_id)
        {

            case 1:
                _title = "<font color=green>活期</font>";
                break;
            case 2:
                _title = "<font color=green>定投一年</font>";
                break;
            case 3:
                _title = "<font color=green>虚拟本金(赠送" + tianshu + "天)</font>";
                break;

        }

        return _title;
    }
    #endregion

    //导出报表
    protected void btnExport_Click(object sender, EventArgs e)
    {

        //  Response.Redirect(Utils.CombUrlTxt("al_read2.aspx", "start_time={0}&stop_time={1}&huiyuan_jiebie={2}&note_no={3}", this.txtstart_time.Value, this.txtstop_time.Value, this.jiebie.ToString(), txtNote_no.Text));
        StringBuilder strTemp = new StringBuilder();

       
        DataTable dt = null;
        string dc_sql = "select huiyuan_bianhao as 编号,huiyuan_name as 姓名,huiyuan_jiebie as 会员级别,xiaofei_money as 投资金额,CASE zhuce_flag WHEN 1 THEN '注册单' WHEN 2 THEN '升级单' ELSE '其他' END as 投资类型, xiaofei_date as 投资时间  from view_xiaofei where  1=1  " + CombSqlTxt(this.note_no, this.start_time, this.stop_time, this.cha_type, this.leixing, this.status) + " and huiyuan_id<>'A00000000' order by xiaofei_date desc";
        //Response.Write(dc_sql);
        //Response.End();
        dt = DbHelperSQL.Query(dc_sql).Tables[0];
        if (dt.Rows.Count == 0)
        {
            Response.Write("<script>alert('导出数据无效'); location.href='xiaofei.aspx';</script>");
            return;
        }
        string filename = "";
        filename += "业绩汇总表" + DateTime.Now.ToString("d") + "";
        PMS.Common.NPOIHelper.ExportByWeb(dt, filename, filename + ".xls");

    }
}