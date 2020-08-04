using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

/// <summary>
/// 所有页面的基类，用于角色权限判断和其他公共操作
/// </summary>
public class A_BasePage : Page
{
    /// <summary>
    /// Session中的当前登录管理员ID
    /// </summary>
    public string hy_id1 { get; set; }

    /// <summary>
    /// Session中的当前登录管理员编号
    /// </summary>
    public string hy_bianhao1 { get; set; }

    public A_BasePage()
    {
        //
        //TODO: 在此处添加构造函数逻辑
        //
    }

    /// <summary>
    /// 登录后获取管理员    ID和权限列表
    /// </summary>
    /// <param name="e"></param>
    protected override void OnLoad(EventArgs e)
    {

        tbl_canshu cs=new tbl_canshu();
        cs.GetModel(1);
        if (cs.jiesuan_flag == 1)
        {
            Response.Write("<script language='javascript'>alert('系统正在结算中，请稍后访问！');</script>");
            return;
        
        
        }

        tbl_open bll_open = new tbl_open();
        bll_open.GetModel(1);
   
        if (bll_open.open_flag == 1)
        {

            Response.Write("<script language=javascript>alert('" + bll_open.tishi + "！');top.location.href='/index.aspx';</script>");
 
            return;

        }
        if (Session["hy_id1"] == null)
        {
            Response.Write("<script language=javascript>alert('您已经退出系统，请通过微信公众号重新登录！');top.location.href='/shop/index.aspx';</script>");
            Response.End();
            //Response.Redirect("~/shop/index.aspx");
        }
        else
        {
            hy_id1 = Session["hy_id1"].ToString();
            hy_bianhao1 = Session["hy_bianhao1"].ToString();
        }

        base.OnLoad(e);
    }

 
}