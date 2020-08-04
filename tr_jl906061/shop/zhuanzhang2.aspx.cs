using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class shop_zhuanzhang2 : System.Web.UI.Page
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
        this.Literal1.Text = money_Convert(model1.chongfu_zong.ToString()).ToString();
        //this.Literal2.Text = money_Convert(model1.fh_money.ToString()).ToString();
        this.Literal4.Text = money_Convert((model1.glf_money).ToString()).ToString();
    }
    private void ShowInfo(string _id)
    {
        tbl_huiyuan model = new tbl_huiyuan();
        model.GetModel_hui_id(_id);

    }
    protected void btnSubmit_Click1(object sender, EventArgs e)
    {
        tbl_canshu canshu = new tbl_canshu();
        canshu.GetModel(1);
        string sPassWord = this.pass_two.Value.Trim();
        if (!tbl_huiyuan.Exists_erji(Session["hy_bianhao1"].ToString(), sPassWord))
        {
            Response.Write("<script language=javascript>alert('二级密码不正确！');location.href='zhuanzhang2.aspx';</script>");
            return;

        }

        decimal money;

        try
        {
            money = Convert.ToDecimal(this.zhuan_money.Value.Trim());
        }
        catch
        {
            Response.Write("<script language=javascript>alert('输入金额有误！');location.href='zhuanzhang2.aspx';</script>");
            return;

        }

        if (money < 0)
        {
            Response.Write("<script language=javascript>alert('输入金额必须大于0！');location.href='zhuanzhang2.aspx';</script>");
            return;

        }

        if (money < 100)
        {
            Response.Write("<script language=javascript>alert('输入金额必须大于100！');location.href='zhuanzhang2.aspx';</script>");
            return;

        }
        if (money % 100 != 0)
        {
            Response.Write("<script language=javascript>alert('100的倍数！');location.href='zhuanzhang2.aspx';</script>");
            return;
        }


        int zz_type = int.Parse(this.zz_type.SelectedValue);
        if (zz_type == 1)
        {
            tbl_huiyuan model_hui = new tbl_huiyuan();
            model_hui.GetModel_hui_id(Session["hy_id1"].ToString());
            decimal nowMoney = decimal.Parse(model_hui.glf_money.ToString());//model_hui.jiangjin_zong - model_hui.jiangjin_yong
            if (nowMoney >= money)
            {
                model_hui.huiyuan_id = Session["hy_id1"].ToString();
                model_hui.chongfu_zong += money;
                model_hui.glf_money -= money;
                model_hui.Update();
                decimal moneyafter1 = nowMoney - money;//改变后余额

                mym.queren_insert(Session["hy_id1"].ToString(), Session["hy_bianhao1"].ToString(), "积分互转", "购物积分转奖励积分", -money, moneyafter1);

                Response.Write("<script language=javascript>alert('转换成功！');location.href='zhuanzhang2.aspx';</script>");
                return;

            }
            else
            {
                Response.Write("<script language=javascript>alert('购物积分不足！');location.href='zhuanzhang2.aspx';</script>");
                return;
            }
        }

        if (zz_type == 2)
        {
            tbl_huiyuan model_hui = new tbl_huiyuan();
            model_hui.GetModel_hui_id(Session["hy_id1"].ToString());
            decimal nowMoney = decimal.Parse(model_hui.chongfu_zong.ToString());//model_hui.jiangjin_zong - model_hui.jiangjin_yong
            if (nowMoney >= money)
            {
                model_hui.huiyuan_id = Session["hy_id1"].ToString();
                model_hui.chongfu_zong -= money;
                model_hui.glf_money += money;
                model_hui.Update();
                decimal moneyafter1 = nowMoney - money;//改变后余额

                mym.queren_insert(Session["hy_id1"].ToString(), Session["hy_bianhao1"].ToString(), "积分互转", "奖励积分转购物积分", -money, moneyafter1);

                Response.Write("<script language=javascript>alert('转换成功！');location.href='zhuanzhang2.aspx';</script>");
                return;

            }
            else
            {
                Response.Write("<script language=javascript>alert('奖励积分不足！');location.href='zhuanzhang2.aspx';</script>");
                return;
            }
        }

        if (zz_type == 3)
        {
            tbl_huiyuan model_hui = new tbl_huiyuan();
            model_hui.GetModel_hui_id(Session["hy_id1"].ToString());
            decimal nowMoney = decimal.Parse(model_hui.jiangjing.ToString());//model_hui.jiangjin_zong - model_hui.jiangjin_yong
            if (nowMoney >= money)
            {
                model_hui.huiyuan_id = Session["hy_id1"].ToString();
                model_hui.jiangjing -= money;
                model_hui.jiangjin_zong += money;
                model_hui.Update();
                decimal moneyafter1 = nowMoney - money;//改变后余额

                mym.queren_insert(Session["hy_id1"].ToString(), Session["hy_bianhao1"].ToString(), "积分互转", "消费佣金转换肽豆", -money, moneyafter1);

                Response.Write("<script language=javascript>alert('转换成功！');location.href='zhuanzhang2.aspx';</script>");
                return;

            }
            else
            {
                Response.Write("<script language=javascript>alert('消费佣金余额不足！');location.href='zhuanzhang2.aspx';</script>");
                return;
            }
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