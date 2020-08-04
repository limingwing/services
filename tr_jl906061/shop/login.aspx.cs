using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class shop_login : System.Web.UI.Page
{
    public static string big_img;
    protected void Page_Load(object sender, EventArgs e)
    {
        logobind();//logo绑定
        //系统关闭提示
        tbl_open bll_open = new tbl_open();
        bll_open.GetModel(1);
        if (bll_open.open_flag == 1)
        {
            Response.Write(bll_open.tishi);
            Response.End();

        }
    }
    #region logo绑定=================================
    private void logobind()
    {




        tbl_sinkia_config bll = new tbl_sinkia_config();
        bll.GetModel(1);


        big_img = bll.logo_web_img;


    }
    #endregion
    protected void Button1_Click(object sender, EventArgs e)
    {
        tbl_canshu canshu = new tbl_canshu();
        canshu.GetModel(1);
        Session["tikuan"] = canshu.reg_shoping.ToString();
        if (username.Value == "")
        {
            Page.ClientScript.RegisterStartupScript(Page.GetType(), "", "alert('请输入用户名。');", true);
            //lblTip.Text = "您输入的验证码不正确，请重新输入。";
            return;
        }
        if (password.Value == "")
        {
            Page.ClientScript.RegisterStartupScript(Page.GetType(), "", "alert('请输入密码。');", true);
            //lblTip.Text = "您输入的验证码不正确，请重新输入。";
            return;
        }

        string sUserName = Utils.Filter(username.Value.Trim());

        string sPassWord = Utils.Filter(password.Value.Trim());

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
                Session["huiyuan_zhuanmai1"] = model1.huiyuan_zhuanmai;
                Session["flag4"] = model1.flag_4;
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
                Session["huiyuan_zhuanmai1"] = model1.huiyuan_zhuanmai;
                Session["flag4"] = model1.flag_4;
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
            Response.Redirect("member_center.aspx");
            return;

        }
        else
        {
            Response.Write("<script language=javascript>alert('账号或密码有误或被冻结，请重试！');location.href='login.aspx';</script>");
            Response.End();
        
        }
    }
}