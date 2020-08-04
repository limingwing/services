using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class shop_password1 : System.Web.UI.Page
{
    tbl_huiyuan bll = new tbl_huiyuan();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (Session["hy_id1"] == null)
            {
                Response.Write("<script language=javascript>alert('请重新登录！');top.location.href='login.aspx';</script>");
                Response.End();

            }
            ShowInfo(Session["hy_id1"].ToString());
        }
    }

    private void ShowInfo(string _id)
    {
        tbl_huiyuan model = new tbl_huiyuan();
        model.GetModel_hui_id(_id);
        //user_phone.Value = model.huiyuan_mob;

    }

    protected void btnSubmit_Click2(object sender, EventArgs e)
    {

        //string code = this.checkCode.Value;

        //tbl_jhm jhm = new tbl_jhm();
        //if (!jhm.Exists_code1(Utils.Filter(this.user_phone.Value), code))
        //{
        //    Response.Write("<script language=javascript>alert('手机验证码不正确！');history.go(-1);</script>");
        //    return;
        //}
        //jhm.isused = 1;
        //jhm.jhm = code;
        //jhm.Updatejhm();
        string sPassWord2 = this.two.Value.Trim();
        if (two.Value.Trim() == "")
        {
            Response.Write("<script language=javascript>alert('请输入原始支付密码！');location.href='password.aspx';</script>");
            return;

        }
        if (two1.Value.Trim() == "")
        {
            Response.Write("<script language=javascript>alert('请输入新支付密码！');location.href='password.aspx';</script>");
            return;

        }
        if (two2.Value.Trim() == "")
        {
            Response.Write("<script language=javascript>alert('请确认新支付密码！');location.href='password.aspx';</script>");
            return;

        }
        if (two1.Value.Trim() != two2.Value.Trim())
        {
            Response.Write("<script language=javascript>alert('请输入相同的新密码验证！');location.href='password.aspx';</script>");
            return;

        }

        if (!tbl_huiyuan.Exists_erji(Session["hy_bianhao1"].ToString(), sPassWord2))
        {
            Response.Write("<script language=javascript>alert('原交易密码不正确！');location.href='password.aspx';</script>");
            return;

        }

        bll.GetModel_hui_id(Session["hy_id1"].ToString());

        bll.pass_two = this.two2.Value.Trim();

        if (bll.Update())
        {
            Response.Write("<script language=javascript>alert('交易密码修改成功！');location.href='password.aspx';</script>");
            return;

        }
    }
}