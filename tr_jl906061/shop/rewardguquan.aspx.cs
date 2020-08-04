using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class shop_rewardguquan : System.Web.UI.Page
{
    ManagePage mym = new ManagePage();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["hy_id1"] == null)
        {
            Response.Write("<script language=javascript>alert('请重新登录！');top.location.href='login.aspx';</script>");
            Response.End();

        }
        view_huiyuan model1 = new view_huiyuan();
        model1.GetModel(Session["hy_id1"].ToString());

        this.Literal1.Text = money_Convert((model1.qianbao - model1.fenhong_canshu1).ToString()).ToString();
    }

    protected void btnSubmit_Click1(object sender, EventArgs e)
    {
        
        string sPassWord = this.pass_two.Value.Trim();
        if (!tbl_huiyuan.Exists_erji(Session["hy_bianhao1"].ToString(), sPassWord))
        {
            Response.Write("<script language=javascript>alert('二级密码不正确！');location.href='rewardguquan.aspx';</script>");
            return;

        }

        decimal money;

        try
        {
            money = Convert.ToDecimal(this.money.Value.Trim());
        }
        catch
        {
            Response.Write("<script language=javascript>alert('输入金额有误！');location.href='rewardguquan.aspx';</script>");
            return;

        }

        if (money < 0)
        {
            Response.Write("<script language=javascript>alert('输入金额必须大于0！');location.href='rewardguquan.aspx';</script>");
            return;

        }

        
        tbl_huiyuan model_hui = new tbl_huiyuan();
        model_hui.GetModel_hui_id(Session["hy_id1"].ToString());
        decimal nowMoney = decimal.Parse((model_hui.qianbao - model_hui.fenhong_canshu1).ToString());
        decimal nowchongfu_money = decimal.Parse((model_hui.jiangjin_zong - model_hui.jiangjin_yong).ToString());

        if (nowMoney*10/100 >= money)
        {

            model_hui.huiyuan_id = Session["hy_id1"].ToString();
            model_hui.fh_money = model_hui.fh_money - money;
            model_hui.Update();
        }
        else
        {
            Response.Write("<script language=javascript>alert('最多肽豆的10%购买！');location.href='rewardguquan.aspx';</script>");
            return;
        }
       
            decimal moneyafter1 = nowMoney - money;//改变后余额
            string memo = "会员" + Session["hy_bianhao1"].ToString() + "购买期权" + money + "元";
            mym.queren_insert(Session["hy_id1"].ToString(), Session["hy_bianhao1"].ToString(), "购买期权", memo, -money, moneyafter1);

            Response.Write("<script language=javascript>alert('提交成功！');location.href='rewardguquan.aspx';</script>");
            return;
        
    }
    protected void btnSubmit_Click2(object sender, EventArgs e)
    {
        tbl_huiyuan model_hui = new tbl_huiyuan();
        model_hui.huiyuan_id = Session["hy_id1"].ToString();
        model_hui.flag_1 = 1;
        model_hui.Updateflag();
        Response.Write("<script language=javascript>alert('操作成功！');location.href='rewardguquan.aspx';</script>");
        return;
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