using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

/// <summary>
///ManagePage
/// </summary>
public class ManagePage : System.Web.UI.Page
{
    public ManagePage()
    {
    }
    /// <summary>
    /// 判断管理员是否已经登录(解决Session超时问题)
    /// </summary>
    public bool IsAdminLogin()
    {
        //如果Session为Null
        if (Session["hy_id"] != null)
        {
            return true;
        }
        //else
        //{
        //    //检查Cookies
        //    string adminname = Utils.GetCookie("hy_id");
        //    if (adminname != "")
        //    {
        //        Session["hy_id"] = Utils.GetCookie("hy_id");
        //        Session["hy_bianhao"] = Utils.GetCookie("hy_bianhao");
        //        Session["hy_name"] = Utils.GetCookie("hy_name");
        //        Session["RoleID"] = Utils.GetCookie("RoleID");
                
        //        return true;
        //    }
        //}
        return false;
    }

    /// <summary>
    /// 写入管理日志
    /// </summary>
    /// <param name="action_type"></param>
    /// <param name="remark"></param>
    /// <returns></returns>
    public bool AddAdminLog(string action_type, string remark)
    {
           //写入日志
        tbl_login mylog = new tbl_login();
            mylog.huiyuan_bianhao = Session["hy_bianhao"].ToString();
            mylog.huiyuan_name = Session["hy_name"].ToString();
            mylog.login_date = DateTime.Now;
            mylog.login_flag = 1;
            mylog.huiyuan_ip = AXRequest.GetIP();
            int newId = mylog.Add();
                   
            if (newId > 0)
            {
                return true;
            }
     
        return false;
    }
    /// <summary>
    /// 写入财务流水账
    /// </summary>
    /// <param name="huiyuan_id">会员标识</param>
    /// <param name="huiyuan_bianhao">会员编号</param>
    /// <param name="action_type">记录账户类型</param> 
    /// <param name="memo">详细说明</param> 
    /// <param name="queren_money">改动金额</param> 
    /// <param name="money_before">改动后金额</param> 
    /// <returns></returns>
    public bool queren_insert(string huiyuan_id, string huiyuan_bianhao, string action_type, string memo, decimal queren_money, decimal money_before)
    {
        //写入日志
        tbl_queren mylog = new tbl_queren();
        mylog.huiyuan_id = huiyuan_id;
        mylog.huiyuan_bianhao = huiyuan_bianhao;
        mylog.action_type = action_type;
        mylog.queren_date = DateTime.Now;
        mylog.memo = memo;
        mylog.queren_money = queren_money;
        mylog.money_before = money_before;
        int newId = mylog.Add();

        if (newId > 0)
        {
            return true;
        }

        return false;
    }


    #region JS提示============================================
    /// <summary>
    /// 添加编辑删除提示
    /// </summary>
    /// <param name="msgtitle">提示文字</param>
    /// <param name="url">返回地址</param>
    /// <param name="msgcss">CSS样式</param>
    public void JscriptMsg(System.Web.UI.Page page,string msgtitle, string url, string msgcss)
    {
        string msbox = "jsprint(\"" + msgtitle + "\", \"" + url + "\", \"" + msgcss + "\")";
        page.RegisterStartupScript("message", "<script language='javascript'>"+msbox+"</script>");
        //ClientScript.RegisterClientScriptBlock(Page.GetType(), "JsPrint", msbox, true);
    }
    /// <summary>
    /// 带回传函数的添加编辑删除提示
    /// </summary>
    /// <param name="msgtitle">提示文字</param>
    /// <param name="url">返回地址</param>
    /// <param name="msgcss">CSS样式</param>
    /// <param name="callback">JS回调函数</param>
    public void JscriptMsg(System.Web.UI.Page page, string msgtitle, string url, string msgcss, string callback)
    {
        string msbox = "jsprint(\"" + msgtitle + "\", \"" + url + "\", \"" + msgcss + "\", " + callback + ")";
        page.RegisterStartupScript("message", "<script language='javascript'>" + msbox + "</script>");
        //ClientScript.RegisterClientScriptBlock(Page.GetType(), "JsPrint", msbox, true);
    }
    #endregion

}