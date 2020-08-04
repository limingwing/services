using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class shop_fa_add : System.Web.UI.Page
{
    ManagePage mym = new ManagePage();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["hy_id1"] == null)
        {
            Response.Write("<script language=javascript>alert('请重新登录！');top.location.href='login.aspx';</script>");
            Response.End();

        }
    }
    #region 增加操作=================================
    private bool DoAdd()
    {
        tbl_liuyan model = new tbl_liuyan();

        model.liuyan_title = liuyan_title.Value.Trim();
        model.liuyan_memo = liuyan_memo.Value.Trim();
        model.liuyan_date = DateTime.Now;
        model.liuyan_bianhao = Session["hy_bianhao1"].ToString();
        model.liuyan_to_name = "公司";
        model.liuyan_to = "A00000000";

        tbl_huiyuan model_hui = new tbl_huiyuan();
        model_hui.GetModel_hui_bianhao(Session["hy_bianhao1"].ToString());

        model.liuyan_name = model_hui.huiyuan_name;
        if (model.Add() > 0)
        {

            return true;
        }

        return false;
    }
    #endregion
    protected void btnSubmit_Click1(object sender, EventArgs e)
    {
       string sPassWord = this.pass_two.Value.Trim();
       if (!tbl_huiyuan.Exists_erji(Session["hy_bianhao1"].ToString(), sPassWord))
        {
            Response.Write("<script language=javascript>alert('二级密码不正确！');location.href='fa.aspx';</script>");
            return;

        }

        if (!DoAdd())
        {
            Response.Write("<script language=javascript>alert('发送失败！');location.href='fa.aspx';</script>");
            return;
        }
        Response.Write("<script language=javascript>alert('发送成功！');location.href='fa.aspx';</script>");
        return;

    
    }
}