using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class shop_rewardcash : System.Web.UI.Page
{
    protected int page;
    public string canshu1;
    ManagePage mym = new ManagePage();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["hy_id1"] == null)
        {
            Response.Write("<script language=javascript>alert('请重新登录！');top.location.href='login.aspx';</script>");
            Response.End();

        }
        tbl_canshu canshu = new tbl_canshu();
        canshu.GetModel(1);
        //this.Label1.Text = canshu.canshu_059.ToString();
        canshu1 = Convert.ToDecimal(canshu.canshu_059).ToString("0.00");
        tbl_huiyuan model1 = new tbl_huiyuan();
        model1.GetModel_hui_id(Session["hy_id1"].ToString());

        this.Literal1.Text = money_Convert((model1.chongfu_zong).ToString()).ToString();
    }
    
    #region 数据绑定=================================
    private void RptBind(string _strWhere, string _orderby)
    {
        //this.page = AXRequest.GetQueryInt("page", 1);



        //tbl_tikuan bll = new tbl_tikuan();
        //this.rptList.DataSource = bll.GetList(this.pageSize, this.page, _strWhere, _orderby, out this.totalCount);
        //this.rptList.DataBind();


        ////绑定页码
        //txtPageNum.Text = this.pageSize.ToString();
        //string pageUrl = Utils.CombUrlTxt("tikuan_jl.aspx", "page={0}", "__id__");
        //PageContent.InnerHtml = Utils.OutPageList(this.pageSize, this.page, this.totalCount, pageUrl, 8);
    }
    #endregion

    protected void btnSubmit_Click1(object sender, EventArgs e)
    {
        tbl_canshu canshu = new tbl_canshu();
        canshu.GetModel(1);
        decimal tixian =decimal.Parse(canshu.canshu_059.ToString());
        //decimal da = decimal.Parse(canshu.canshu_051.ToString());
        string _huiyuan_yinhang;
        string _huiyuan_yinhang_name;
        string _huiyuan_yinhang_zh;
        string _bank_zhi;
        view_huiyuan model1 = new view_huiyuan();
        model1.GetModel(Session["hy_id1"].ToString());
        _huiyuan_yinhang = model1.huiyuan_yinhang;

        _huiyuan_yinhang_name = model1.huiyuan_yinhang_name;
        _huiyuan_yinhang_zh = model1.huiyuan_yinhang_zh;
        _bank_zhi = model1.bank_zhi;
        string sPassWord = this.pass_two.Value.Trim();
        if (!tbl_huiyuan.Exists_erji(Session["hy_bianhao1"].ToString(), sPassWord))
        {
            Response.Write("<script language=javascript>alert('二级密码不正确！');location.href='rewardcash.aspx';</script>");
            return;

        }

        decimal money;

        try
        {
            money = Convert.ToDecimal(this.money.Value.Trim());
        }
        catch
        {
            Response.Write("<script language=javascript>alert('输入金额有误！');location.href='rewardcash.aspx';</script>");
            return;

        }

        if (money < 0)
        {
            Response.Write("<script language=javascript>alert('输入金额必须大于0！');location.href='rewardcash.aspx';</script>");
            return;

        }

        if (_huiyuan_yinhang_zh == "" || _huiyuan_yinhang_name == "")
        {
            Response.Write("<script language=javascript>alert('开户名和开户账户未填写，无法提现！');history.go(-1);</script>");
            return;
        }

        if (money < 100)
        {
            Response.Write("<script language=javascript>alert('输入金额必须大于100！');location.href='rewardcash.aspx';</script>");
            return;

        }
        if (money % 100 != 0)
        {
            Response.Write("<script language=javascript>alert('100的倍数！');location.href='rewardcash.aspx';</script>");
            return;
        } 
        tbl_huiyuan model_hui = new tbl_huiyuan();
        model_hui.GetModel_hui_id(Session["hy_id1"].ToString());
        tbl_reg_jiebie jb1 = new tbl_reg_jiebie();
        decimal need_money=jb1.Get_Need_money(int.Parse(model_hui.huiyuan_jiebie.ToString()));

        //tbl_tikuan tk = new tbl_tikuan();
        //decimal all=Convert.ToDecimal(tk.GetTitleSum(" huiyuan_id='" + Session["hy_id1"].ToString() + "'", "SUM(money)"));
        //if (all > need_money * 2)
        //{
        //    Response.Write("<script language=javascript>alert('今日提现额度已满！');location.href='rewardcash.aspx';</script>");
        //    return;
        //}
             
        //if (money > need_money * 2)
        //{
        //    Response.Write("<script language=javascript>alert('每日提现额度为" + need_money * 2 + "！');location.href='rewardcash.aspx';</script>");
        //    return;
        //}
       
        //decimal nowMoney = decimal.Parse(model_hui.fh_money.ToString());
        decimal nowchongfu_money = decimal.Parse((model_hui.chongfu_zong).ToString());

        int zz_type = 0;
        if (nowchongfu_money >= money)
        {

            model_hui.huiyuan_id = Session["hy_id1"].ToString();
            model_hui.chongfu_zong -= money;
            model_hui.Update();
        }
        else
        {
            Response.Write("<script language=javascript>alert('消费佣金余额不足！');location.href='rewardcash.aspx';</script>");
            return;
        }
        tbl_tikuan model = new tbl_tikuan();
        model.bankname = _huiyuan_yinhang;
        model.accountno = _huiyuan_yinhang_zh;
        model.accountname = _huiyuan_yinhang_name;
        model.money = money;
        model.zz_type = zz_type;
        model.huiyuan_id = Session["hy_id1"].ToString();
        model.huiyuan_bianhao = Session["hy_bianhao1"].ToString();
        model.huiyuan_name = model_hui.huiyuan_name;
        model.tikuan_status = 0;
        decimal money_sx = money * tixian*0.01m;
        model.money_sx = money_sx;
        model.money_sj = money - money_sx;
        model.tikuan_date = DateTime.Now;

        if (model.Add() > 0)
        {
            decimal moneyafter1 = nowchongfu_money - money;//改变后余额
                string memo = "会员" + Session["hy_bianhao1"].ToString() + "提现" + money + "元";
                mym.queren_insert(Session["hy_id1"].ToString(), Session["hy_bianhao1"].ToString(), "奖金提现", memo, -money, moneyafter1);

                Response.Write("<script language=javascript>alert('提交成功！');location.href='rewardcash.aspx';</script>");
            return;
        }
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