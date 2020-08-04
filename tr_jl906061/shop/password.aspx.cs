using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class shop_password : System.Web.UI.Page
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
        }
    }

    protected void btnSubmit_Click1(object sender, EventArgs e)
    {
       

        string sPassWord1 =pass.Value.Trim();
        if (pass.Value.Trim() == "" )
        {
            Response.Write("<script language=javascript>alert('请输入原始登录密码！');location.href='password.aspx';</script>");
            return;

        }
        if (new_password.Value.Trim() == "")
        {
            Response.Write("<script language=javascript>alert('请输入新密码！');location.href='password.aspx';</script>");
            return;

        }
        if (check_new_password.Value.Trim() == "")
        {
            Response.Write("<script language=javascript>alert('请输入新密码！');location.href='password.aspx';</script>");
            return;

        }
        if (new_password.Value.Trim() != check_new_password.Value.Trim())
        {
            Response.Write("<script language=javascript>alert('请输入相同的新密码验证！');location.href='password.aspx';</script>");
            return;

        }
 
        if (!tbl_huiyuan.Exists_yiji(Session["hy_bianhao1"].ToString(), sPassWord1))
        {
            Response.Write("<script language=javascript>alert('原始登录密码不正确！');location.href='password.aspx';</script>");
            return;

        }
        bll.GetModel_hui_id(Session["hy_id1"].ToString());

        bll.huiyuan_pass = check_new_password.Value.Trim();

        if (bll.Update())
        {

            Response.Write("<script language=javascript>alert('登录密码修改成功！');location.href='password.aspx';</script>");
            return;
        }


    }
}