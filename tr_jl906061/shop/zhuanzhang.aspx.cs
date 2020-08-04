using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class shop_zhuanzhang : System.Web.UI.Page
{
    ManagePage mym = new ManagePage();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["hy_id1"] == null)
        {
            Response.Write("<script language=javascript>alert('请重新登录！');top.location.href='login.aspx';</script>");
            Response.End();

        }
        ShowInfo(Session["hy_id1"].ToString());
        tbl_huiyuan model1 =new tbl_huiyuan();
        //view_huiyuan model1 = new view_huiyuan();
        model1.GetModel_hui_id(Session["hy_id1"].ToString());

        this.Literal1.Text = money_Convert((model1.chongfu_zong).ToString()).ToString();
        //this.Literal3.Text = money_Convert((model1.glf_money).ToString()).ToString();
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
            Response.Write("<script language=javascript>alert('二级密码不正确！');location.href='zhuanzhang.aspx';</script>");
            return;

        }

        decimal money;

        try
        {
            money = Convert.ToDecimal(this.zhuan_money.Value.Trim());
        }
        catch
        {
            Response.Write("<script language=javascript>alert('输入金额有误！');location.href='zhuanzhang.aspx';</script>");
            return;


        }

        if (money < 0)
        {
            Response.Write("<script language=javascript>alert('输入金额必须大于0！');location.href='zhuanzhang.aspx';</script>");
            return;

        }

        //if (money < 100)
        //{
        //    Response.Write("<script language=javascript>alert('输入金额必须大于" + 100 + "！');location.href='zhuanzhang.aspx';</script>");
        //    return;

        //}
        //if (money % 100 != 0)
        //{
        //    Response.Write("<script language=javascript>alert('" + 100 + "的倍数！');location.href='zhuanzhang.aspx';</script>");
        //    return;
        //}

        if (!tbl_huiyuan.Exists_cunzai(zhuan_bianhao.Value.Trim()))
        {
            Response.Write("<script language=javascript>alert('该会员不存在！');history.go(-1);</script>");
            return;

        }
        int zz_type = int.Parse(this.zz_type.SelectedValue);
        if (zz_type == 1)
        {
            tbl_huiyuan model_hui = new tbl_huiyuan();
            model_hui.GetModel_hui_id(Session["hy_id1"].ToString());
            decimal nowMoney = decimal.Parse((model_hui.chongfu_zong).ToString());
            if (nowMoney >= money)
            {
                model_hui.huiyuan_id = Session["hy_id1"].ToString();
                model_hui.chongfu_zong -= money;
                model_hui.Update();
                decimal moneyafter1 = nowMoney - money;//改变后余额
                string memo = "转出钱包至会员" + zhuan_bianhao.Value.Trim() + "";
                mym.queren_insert(Session["hy_id1"].ToString(), Session["hy_bianhao1"].ToString(), "奖励积分转账", memo, -money, moneyafter1);
                //对方收钱
                tbl_huiyuan model_to_hui = new tbl_huiyuan();
                model_to_hui.GetModel_hui_bianhao(zhuan_bianhao.Value.Trim());
                decimal to_hui_money = decimal.Parse((model_to_hui.chongfu_zong).ToString());
                model_to_hui.huiyuan_id = model_to_hui.huiyuan_id;
                model_to_hui.chongfu_zong += money;
                model_to_hui.Update();
                decimal moneyafter2 = to_hui_money + money;//改变后余额

                string memo1 = "从会员" + Session["hy_bianhao1"].ToString() + "转入钱包";
                mym.queren_insert(model_to_hui.huiyuan_id, zhuan_bianhao.Value.Trim(), "奖励积分转入", memo1, money, moneyafter2);

                Response.Write("<script language=javascript>alert('转账成功！');location.href='zhuanzhang.aspx';</script>");
                return;

            }
            else
            {
                Response.Write("<script language=javascript>alert('奖励积分不足！');location.href='zhuanzhang.aspx';</script>");
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