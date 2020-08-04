using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class shop_zhuanzhang1 : System.Web.UI.Page
{
    ManagePage mym = new ManagePage();
    tbl_xiaofei xiaofei = new tbl_xiaofei();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["hy_id1"] == null)
        {
            Response.Write("<script language=javascript>alert('请重新登录！');top.location.href='login.aspx';</script>");
            Response.End();

        }
        ShowInfo(Session["hy_id1"].ToString());
        tbl_huiyuan model1 = new tbl_huiyuan();
        model1.GetModel_hui_id(Session["hy_id1"].ToString());
        if (model1.cishu2 == 0)
        {
            this.Literal2.Text = "0.00";
        }
        else
        {
            this.Literal2.Text = money_Convert(xiaofei.GetTitleSum("xiaofei_hui_id='" + Session["hy_id1"].ToString() + "'", "sum(xiaofei_money)"));
        }
        this.Literal1.Text = money_Convert(model1.fh_money.ToString()).ToString();
    }
    private void ShowInfo(string _id)
    {
        tbl_huiyuan model = new tbl_huiyuan();
        model.GetModel_hui_id(_id);
        decimal money = Convert.ToDecimal(xiaofei.GetTitleSum("xiaofei_hui_id='" + Session["hy_id1"].ToString() + "'", "sum(xiaofei_money)"));
        string zhuan = null;
        if (model.flag_3 == 0)
        {
            if (money >= 1000 && money < 5000)
                zhuan = "100.00";
            else if (money >= 5000 && money < 10000)
                zhuan = "200.00";
            else if (money >= 10000 && money < 20000)
                zhuan = "400.00";
            else if (money >= 20000 && money < 30000)
                zhuan = "600.00";
            else if (money >= 30000 && money < 50000)
                zhuan = "800.00";
            else if (money >= 50000 && money < 100000)
                zhuan = "1000.00";
            else if (money >= 100000)
                zhuan = "2000.00";
            else
                zhuan = "0.00";
        }else
            zhuan = "0.00";
        this.zhuan_money.Value = zhuan;

    }
    protected void btnSubmit_Click1(object sender, EventArgs e)
    {
        string sPassWord = this.pass_two.Value.Trim();
        if (!tbl_huiyuan.Exists_erji(Session["hy_bianhao1"].ToString(), sPassWord))
        {
            Response.Write("<script language=javascript>alert('二级密码不正确！');location.href='zhuanzhang1.aspx';</script>");
            return;

        }

        decimal money;

        try
        {
            money = Convert.ToDecimal(this.zhuan_money.Value.Trim());
        }
        catch
        {
            Response.Write("<script language=javascript>alert('输入金额有误！');location.href='zhuanzhang1.aspx';</script>");
            return;

        }

        if (money < 0)
        {
            Response.Write("<script language=javascript>alert('输入金额必须大于0！');location.href='zhuanzhang1.aspx';</script>");
            return;

        }

        if (money < 100)
        {
            Response.Write("<script language=javascript>alert('输入金额必须大于100！');location.href='zhuanzhang1.aspx';</script>");
            return;

        }
        
            tbl_huiyuan model_hui = new tbl_huiyuan();
            model_hui.GetModel_hui_id(Session["hy_id1"].ToString());
            decimal nowMoney = decimal.Parse(model_hui.fh_money.ToString());//model_hui.jiangjin_zong - model_hui.jiangjin_yong
            if (nowMoney >= money)
            {
                model_hui.huiyuan_id = Session["hy_id1"].ToString();
                model_hui.fh_money -= money;
                model_hui.flag_3 = 1;
                model_hui.Update();
                decimal moneyafter1 = nowMoney - money;//改变后余额

                mym.queren_insert(Session["hy_id1"].ToString(), Session["hy_bianhao1"].ToString(), "购买", "分享积分购买福利积分", -money, moneyafter1);

                Response.Write("<script language=javascript>alert('购买成功！');location.href='zhuanzhang1.aspx';</script>");
                return;

            }
            else
            {
                Response.Write("<script language=javascript>alert('分享积分余额不足！');location.href='zhuanzhang1.aspx';</script>");
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