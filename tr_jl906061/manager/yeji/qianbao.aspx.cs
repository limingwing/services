using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;

public partial class manager_yeji_qianbao : System.Web.UI.Page
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
        int nav_id = 58;
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

            RptBind(" 1=1 " + CombSqlTxt(this.note_no, this.start_time, this.stop_time, this.cha_type), "huiyuan_add_time desc");


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
        tbl_huiyuan bll = new tbl_huiyuan();
        this.rptList.DataSource = bll.GetList(this.pageSize, this.page, _strWhere, _orderby, out this.totalCount);
        this.rptList.DataBind();

        //this.Literal_hj.Text = MyConvert(Convert.ToDecimal(bll.GetTitleSum(_strWhere, "sum(qianbao-fenhong_canshu1)")));
        //this.Literal1.Text = MyConvert(Convert.ToDecimal(bll.GetTitleSum(_strWhere, "sum(jiangjin_zong-jiangjin_yong)")));
        //this.Literal2.Text = MyConvert(Convert.ToDecimal(bll.GetTitleSum(_strWhere, "sum(huiyuan_yu)")));
        //this.Literal3.Text = MyConvert(Convert.ToDecimal(bll.GetTitleSum(_strWhere, "sum(chongfu_zong)")));
        //this.Literal4.Text = MyConvert(Convert.ToDecimal(bll.GetTitleSum(_strWhere, "sum(glf_money)")));
        //this.Literal5.Text = MyConvert(Convert.ToDecimal(bll.GetTitleSum(_strWhere, "sum(fh_money)")));
        //this.Literal6.Text = MyConvert(Convert.ToDecimal(bll.GetTitleSum(_strWhere, "sum(jiangjing)")));
        //绑定页码
        txtPageNum.Text = this.pageSize.ToString();
        string pageUrl = Utils.CombUrlTxt("qianbao.aspx", "start_time={0}&stop_time={1}&note_no={2}&page={3}&type={4}", this.start_time.ToString(), this.stop_time.ToString(), this.note_no, "__id__", this.cha_type.ToString());
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
        strTemp.Append(" and  huiyuan_add_time between  '" + DateTime.Parse(_start_time) + "' and '" + DateTime.Parse(_stop_time + " 23:59:59") + "'");

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

    #region 返回状态=============================
    protected string Getzong(string _id)
    {
        double _title = 0;
        tbl_xiaofei bll = new tbl_xiaofei();

        _title = Convert.ToDouble(bll.GetTitleSum("xiaofei_hui_id='" + _id + "' and xiaofei_qr_flag=1 and zhuce_flag=3", "sum(xiaofei_money)"));


        return _title.ToString();
    }
    #endregion
    //查询
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        Response.Redirect(Utils.CombUrlTxt("qianbao.aspx", "start_time={0}&stop_time={1}&note_no={2}&type={3}", this.txtstart_time.Value, this.txtstop_time.Value, txtNote_no.Text, this.type.SelectedValue));
    }

    //筛选会员级别
    protected void ddlproduct_category_id_SelectedIndexChanged(object sender, EventArgs e)
    {
        Response.Redirect(Utils.CombUrlTxt("qianbao.aspx", "start_time={0}&stop_time={1}&note_no={2}", this.txtstart_time.Value, this.txtstop_time.Value, txtNote_no.Text));

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
        Response.Redirect(Utils.CombUrlTxt("qianbao.aspx", "start_time={0}&stop_time={1}&note_no={2}&type={3}", this.txtstart_time.Value, this.txtstop_time.Value, txtNote_no.Text, this.type.SelectedValue));
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
                    string memo = "管理员为会员" + huiyuan_bianhao + "充值" + Decimal.Parse(money) + "元购物积分";
                    model.qianbao = Decimal.Parse(money);
                    model.Updateqianbao();



                    mym.queren_insert(KindID, huiyuan_bianhao, "充值购物积分", memo, Decimal.Parse(money), moneyafter);


                    this.page = AXRequest.GetQueryInt("page");

                    mym.JscriptMsg(this.Page, " 充值成功！", Utils.CombUrlTxt("qianbao.aspx", "start_time={0}&stop_time={1}&note_no={2}&type={3}&page={4}", this.txtstart_time.Value, this.txtstop_time.Value, txtNote_no.Text, this.type.SelectedValue, this.page.ToString()), "Success");
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
                    int itemIndex = Convert.ToInt32(e.CommandArgument.ToString().Split(',')[1]);
                    TextBox TextBox1 = this.rptList.Items[itemIndex].FindControl("TextBox1") as TextBox;
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

                    decimal moneybefore = decimal.Parse((model.jiangjin_zong - model.jiangjin_yong).ToString());//改变前余额

                    decimal moneyafter = moneybefore + decimal.Parse(money);//改变后余额
                    string memo = "管理员为会员" + huiyuan_bianhao + "充值" + Decimal.Parse(money) + "元肽豆";
                    model.jiangjin_zong = Decimal.Parse(money);
                    model.Update_jiangjin_zong();


                    mym.queren_insert(KindID, huiyuan_bianhao, "充值肽豆", memo, Decimal.Parse(money), moneyafter);

                    this.page = AXRequest.GetQueryInt("page");

                    mym.JscriptMsg(this.Page, " 充值成功！", Utils.CombUrlTxt("qianbao.aspx", "start_time={0}&stop_time={1}&note_no={2}&type={3}&page={4}", this.txtstart_time.Value, this.txtstop_time.Value, txtNote_no.Text, this.type.SelectedValue, this.page.ToString()), "Success");
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
                    TextBox TextBox1 = this.rptList.Items[itemIndex].FindControl("TextBox3") as TextBox;
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

                    decimal moneybefore = decimal.Parse((model.fh_money.ToString()).ToString());//改变前余额

                    decimal moneyafter = moneybefore + decimal.Parse(money);//改变后余额
                    string memo = "管理员为会员" + huiyuan_bianhao + "充值" + Decimal.Parse(money) + "元分享积分";
                    model.fh_money = Decimal.Parse(money);
                    model.Updatefh_money();


                    mym.queren_insert(KindID, huiyuan_bianhao, "充值分享积分", memo, Decimal.Parse(money), moneyafter);

                    this.page = AXRequest.GetQueryInt("page");

                    mym.JscriptMsg(this.Page, " 充值成功！", Utils.CombUrlTxt("qianbao.aspx", "start_time={0}&stop_time={1}&note_no={2}&type={3}&page={4}", this.txtstart_time.Value, this.txtstop_time.Value, txtNote_no.Text, this.type.SelectedValue, this.page.ToString()), "Success");
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
                    string memo = "管理员为会员" + huiyuan_bianhao + "充值" + Decimal.Parse(money) + "元购物积分";
                    model.chongfu_zong = Decimal.Parse(money);
                    model.Update_chongfu_zong();


                    mym.queren_insert(KindID, huiyuan_bianhao, "充值奖励积分", memo, Decimal.Parse(money), moneyafter);

                    this.page = AXRequest.GetQueryInt("page");

                    mym.JscriptMsg(this.Page, " 充值成功！", Utils.CombUrlTxt("qianbao.aspx", "start_time={0}&stop_time={1}&note_no={2}&type={3}&page={4}", this.txtstart_time.Value, this.txtstop_time.Value, txtNote_no.Text, this.type.SelectedValue, this.page.ToString()), "Success");
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
                    string memo = "管理员为会员" + huiyuan_bianhao + "充值" + Decimal.Parse(money) + "元购物积分";
                    model.glf_money += Decimal.Parse(money);
                    model.Update();


                    mym.queren_insert(KindID, huiyuan_bianhao, "充值购物积分", memo, Decimal.Parse(money), moneyafter);

                    this.page = AXRequest.GetQueryInt("page");

                    mym.JscriptMsg(this.Page, " 充值成功！", Utils.CombUrlTxt("qianbao.aspx", "start_time={0}&stop_time={1}&note_no={2}&type={3}&page={4}", this.txtstart_time.Value, this.txtstop_time.Value, txtNote_no.Text, this.type.SelectedValue, this.page.ToString()), "Success");
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
                    TextBox TextBox1 = this.rptList.Items[itemIndex].FindControl("TextBox6") as TextBox;
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

                    decimal moneybefore = decimal.Parse((model.jiangjing.ToString()).ToString());//改变前余额

                    decimal moneyafter = moneybefore + decimal.Parse(money);//改变后余额
                    string memo = "管理员为会员" + huiyuan_bianhao + "充值" + Decimal.Parse(money) + "元消费佣金";
                    model.jiangjing += Decimal.Parse(money);
                    model.Update();


                    mym.queren_insert(KindID, huiyuan_bianhao, "充值消费佣金", memo, Decimal.Parse(money), moneyafter);

                    this.page = AXRequest.GetQueryInt("page");

                    mym.JscriptMsg(this.Page, " 充值成功！", Utils.CombUrlTxt("qianbao.aspx", "start_time={0}&stop_time={1}&note_no={2}&type={3}&page={4}", this.txtstart_time.Value, this.txtstop_time.Value, txtNote_no.Text, this.type.SelectedValue, this.page.ToString()), "Success");
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
                    TextBox TextBox1 = this.rptList.Items[itemIndex].FindControl("TextBox7") as TextBox;
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

                    decimal moneybefore = decimal.Parse((model.chongfu_kechu.ToString()).ToString());//改变前余额

                    decimal moneyafter = moneybefore + decimal.Parse(money);//改变后余额
                    string memo = "管理员为会员" + huiyuan_bianhao + "充值" + Decimal.Parse(money) + "元领养金";
                    model.chongfu_kechu += Decimal.Parse(money);
                    model.Update();


                    mym.queren_insert(KindID, huiyuan_bianhao, "充值领养金", memo, Decimal.Parse(money), moneyafter);

                    this.page = AXRequest.GetQueryInt("page");

                    mym.JscriptMsg(this.Page, " 充值成功！", Utils.CombUrlTxt("qianbao.aspx", "start_time={0}&stop_time={1}&note_no={2}&type={3}&page={4}", this.txtstart_time.Value, this.txtstop_time.Value, txtNote_no.Text, this.type.SelectedValue, this.page.ToString()), "Success");
                }
                catch
                {

                    mym.JscriptMsg(this.Page, "很抱歉，遇到了一个技术问题，充值没有成功，请稍后重试，或与技术人员联系。", "", "Error");
                    return;

                }
            }
        }

        if (e.CommandName == "save7")
        {
            if (e.CommandArgument != null)
            {
                try
                {

                    string KindID = e.CommandArgument.ToString().Split(',')[0];
                    int itemIndex = Convert.ToInt32(e.CommandArgument.ToString().Split(',')[1]);
                    TextBox TextBox1 = this.rptList.Items[itemIndex].FindControl("TextBox8") as TextBox;
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

                    decimal moneybefore = decimal.Parse((model.chongfu_money.ToString()).ToString());//改变前余额

                    decimal moneyafter = moneybefore + decimal.Parse(money);//改变后余额
                    string memo = "管理员为会员" + huiyuan_bianhao + "充值" + Decimal.Parse(money) + "元代金券";
                    model.chongfu_money += Decimal.Parse(money);
                    model.Update();


                    mym.queren_insert(KindID, huiyuan_bianhao, "充值代金券", memo, Decimal.Parse(money), moneyafter);

                    this.page = AXRequest.GetQueryInt("page");

                    mym.JscriptMsg(this.Page, " 充值成功！", Utils.CombUrlTxt("qianbao.aspx", "start_time={0}&stop_time={1}&note_no={2}&type={3}&page={4}", this.txtstart_time.Value, this.txtstop_time.Value, txtNote_no.Text, this.type.SelectedValue, this.page.ToString()), "Success");
                }
                catch
                {

                    mym.JscriptMsg(this.Page, "很抱歉，遇到了一个技术问题，充值没有成功，请稍后重试，或与技术人员联系。", "", "Error");
                    return;

                }
            }
        }
    }
    //导出报表
    protected void btnExport_Click(object sender, EventArgs e)
    {
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
        string dc_sql = "select huiyuan_bianhao as 编号,huiyuan_name as 姓名,huiyuan_jiebie as 会员级别,chongfu_zong as 奖励积分,glf_money as 购物积分 from view_huiyuan where  1=1  " + strTemp.ToString() + " and huiyuan_id<>'A00000000' order by huiyuan_add_time desc";
        //Response.Write(dc_sql);
        //Response.End();
        dt = DbHelperSQL.Query(dc_sql).Tables[0];
        if (dt.Rows.Count == 0)
        {
            Response.Write("<script>alert('导出数据无效'); location.href='al_Read2.aspx';</script>");
            return;
        }
        string filename = "";
        filename += "会员汇总表" + DateTime.Now.ToString("d") + "";
        PMS.Common.NPOIHelper.ExportByWeb(dt, filename, filename + ".xls");
    }
}