using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class shop_zhifubao : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["hy_id1"] == null)
        {
            Response.Write("<script language=javascript>alert('请重新登录！');top.location.href='login.aspx';</script>");
            Response.End();

        }
        tbl_erweima erweia = new tbl_erweima();
        erweia.GetModel(0);
        this.Image1.ImageUrl = erweia.home_code;
    }
    protected void btnSubmit_Click1(object sender, EventArgs e)
    {
        tbl_huiyuan model1 = new tbl_huiyuan();
        model1.GetModel_hui_id(Session["hy_id1"].ToString());
        string sPassWord = this.pass_two.Value.Trim();
        if (!tbl_huiyuan.Exists_erji(Session["hy_bianhao1"].ToString(), sPassWord))
        {
            Response.Write("<script language=javascript>alert('二级密码不正确！');location.href='zhifubao.aspx';</script>");
            return;

        }

        decimal money;

        try
        {
            money = Convert.ToDecimal(this.money.Value.Trim());
        }
        catch
        {
            Response.Write("<script language=javascript>alert('输入金额有误！');location.href='zhifubao.aspx';</script>");
            return;


        }

        if (money < 0)
        {
            Response.Write("<script language=javascript>alert('输入金额必须大于0！');location.href='zhifubao.aspx';</script>");
            return;

        }

        if (money < 100)
        {
            Response.Write("<script language=javascript>alert('输入金额必须大于100！');location.href='zhifubao.aspx';</script>");
            return;

        }


        tbl_huikuan model_hk = new tbl_huikuan();
        model_hk.accountbank = "支付宝";
        model_hk.accounttype = "1";
        model_hk.money = money.ToString();

        model_hk.huiyuan_id = Session["hy_id1"].ToString();
        model_hk.huiyuan_bianhao = Session["hy_bianhao1"].ToString();
        model_hk.huiyuan_name = model1.huiyuan_name;
        model_hk.huikuan_status = 0;
        model_hk.hk_sq_time = DateTime.Now;
        model_hk.memo = beizhu.Value.Trim();
        if (model_hk.Add() > 0)
        {
            Response.Write("<script language=javascript>alert('提交成功！');location.href='zhifubao.aspx';</script>");
            return;
        }

    }
}