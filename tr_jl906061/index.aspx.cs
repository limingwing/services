using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class index : System.Web.UI.Page
{
    tbl_canshu model = new tbl_canshu();

    protected void Page_Load(object sender, EventArgs e)
    {
	Response.Redirect("shop/index.aspx");
        Response.End();

        //系统关闭提示
        tbl_open bll_open = new tbl_open();
        bll_open.GetModel(1);
        if (bll_open.open_flag == 1)
        {
            Response.Write(bll_open.tishi);
            Response.End();

        }
        ImageButton Button1 = (ImageButton)this.Master.FindControl("ibtnLogin");//Button1是用母版页上的一个button记住不在母版页上为它写任何的事件代码。
        Button1.Click += new ImageClickEventHandler(ibtnLogin_Click);
    }

    protected void Page_PreInit(object sender, EventArgs e)
    {
        tbl_muban bll = new tbl_muban();
        bll.GetModel_show(1);
        Page.MasterPageFile = bll.muban_src;
        //"~/Template/muban1/MasterPage.master";

    }

    protected void ibtnLogin_Click(object sender, EventArgs e)
    {
        TextBox txtname = (TextBox)((MasterPage)Master).FindControl("txtUserName");
        TextBox txtpwd = (TextBox)((MasterPage)Master).FindControl("txtPassword");
        TextBox Txtcode = (TextBox)((MasterPage)Master).FindControl("Txtcode");
        if (Txtcode.Text == "")
        {
            Page.ClientScript.RegisterStartupScript(Page.GetType(), "", "alert('您未输入验证码。');", true);
            //lblTip.Text = "您输入的验证码不正确，请重新输入。";
            return;
        }

        if (Session["serverCode"] == null)
        {

            Response.Write("<script language=javascript>alert('验证码失效,刷新页面！');location.href='index.aspx';</script>");
            Response.End();
        }
        string sVCode = Session["serverCode"].ToString();
        if (txtname.Text == "")
        {
            Page.ClientScript.RegisterStartupScript(Page.GetType(), "", "alert('请输入用户名。');", true);
            //lblTip.Text = "您输入的验证码不正确，请重新输入。";
            return;
        }
        if (txtpwd.Text == "")
        {
            Page.ClientScript.RegisterStartupScript(Page.GetType(), "", "alert('请输入密码。');", true);
            //lblTip.Text = "您输入的验证码不正确，请重新输入。";
            return;
        }
        if (Txtcode.Text != sVCode)
        {
            Page.ClientScript.RegisterStartupScript(Page.GetType(), "", "alert('您输入的验证码不正确，请重新输入。');", true);
            //lblTip.Text = "您输入的验证码不正确，请重新输入。";
            return;
        }

        string sUserName = Utils.Filter(txtname.Text.Trim());

        string sPassWord = Utils.Filter(txtpwd.Text.Trim());

        if (tbl_huiyuan.Existshui(sUserName, sPassWord) || tbl_huiyuan.Exists(sUserName, sPassWord))
        {


            if (tbl_huiyuan.Existshui(sUserName, sPassWord))
            {
                tbl_huiyuan model1 = new tbl_huiyuan();
                model1.GetModel_hui_mob(sUserName);
                Session["hy_id1"] = model1.huiyuan_id;
                Session["hy_bianhao1"] = model1.huiyuan_bianhao;
                Session["hy_name1"] = model1.huiyuan_name;
                Session["hy_zm1"] = model1.huiyuan_zhuanmai;
                Session["hy_jiebie1"] = model1.huiyuan_jiebie;
                //Session["zhongyao1"] = 1;

                //写入登录日志
                tbl_login login_log = new tbl_login();
                login_log.huiyuan_bianhao = sUserName;
                login_log.huiyuan_name = model1.huiyuan_name;
                login_log.login_date = DateTime.Now;
                login_log.login_flag = 2;
                login_log.huiyuan_ip = AXRequest.GetIP();
                login_log.Add();
            }

            if (tbl_huiyuan.Exists(sUserName, sPassWord))
            {
                tbl_huiyuan model1 = new tbl_huiyuan();
                model1.GetModel_hui_bianhao(sUserName);
                Session["hy_id1"] = model1.huiyuan_id;
                Session["hy_bianhao1"] = model1.huiyuan_bianhao;
                Session["hy_name1"] = model1.huiyuan_name;
                Session["hy_zm1"] = model1.huiyuan_zhuanmai;
                Session["hy_jiebie1"] = model1.huiyuan_jiebie;
                //Session["zhongyao1"] = 1;

                //写入登录日志
                tbl_login login_log = new tbl_login();
                login_log.huiyuan_bianhao = sUserName;
                login_log.huiyuan_name = model1.huiyuan_name;
                login_log.login_date = DateTime.Now;
                login_log.login_flag = 2;
                login_log.huiyuan_ip = AXRequest.GetIP();
                login_log.Add();
            }



            Utils.WriteCookie("ps_cookie_shopping_cart", "AoXiang", -14400);
            Response.Redirect("huiyuan/index.aspx");
            return;

        }
        else
        {
            Response.Write("<script language=javascript>alert('账号或密码有误或被冻结，请重试！');location.href='login.aspx';</script>");
            Response.End();

        }

    }
}