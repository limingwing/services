using System;
using System.Data;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;


public partial class manager_system_my_info : System.Web.UI.Page
{
    ManagePage mym = new ManagePage();
    protected void Page_Load(object sender, EventArgs e)
    {
        //判断是否登录
        if (!mym.IsAdminLogin())
        {
            Response.Write("<script>parent.location.href='../login.aspx'</script>");
            Response.End();
        }
        if (!Page.IsPostBack)
        {
            ShowInfo(Session["hy_bianhao"].ToString());
        }
    }

    #region 赋值操作=================================
    private void ShowInfo(string _id)
    {

        string sqlGetUserID = "select  id  from [tbl_admin] where huiyuan_bianhao='" + _id + "'";
        int userid = Convert.ToInt16(DbHelperSQL.GetSingle(sqlGetUserID));
        tbl_admin model = new tbl_admin();
        model.GetModel(userid);
        Lituser_name.Text = model.huiyuan_bianhao;
        Litreal_name.Text = model.huiyuan_name;
 
      
    }
    #endregion

    //保存
    protected void btnSubmit_Click(object sender, EventArgs e)
    {

        string sqlGetUserID = "select  id  from [tbl_admin] where huiyuan_bianhao='" + Session["hy_bianhao"].ToString() + "'";
        int userid = Convert.ToInt16(DbHelperSQL.GetSingle(sqlGetUserID));
        tbl_admin model = new tbl_admin();
        model.GetModel(Convert.ToInt32(userid));

       // string userPwd = FormsAuthentication.HashPasswordForStoringInConfigFile(txtOldPassword.Text.Trim(), "MD5");
        string userPwd = txtOldPassword.Text.Trim();
        if (FormsAuthentication.HashPasswordForStoringInConfigFile(userPwd, "MD5") != model.huiyuan_pass)
        {
            mym.JscriptMsg(this.Page, "旧密码不正确！", "", "Warning");
            return;
        }
        if (txtPassword.Text.Trim() != txtPassword1.Text.Trim())
        {
            mym.JscriptMsg(this.Page, "两次密码不一致！", "", "Warning");
            return;
        }
        model.huiyuan_pass = FormsAuthentication.HashPasswordForStoringInConfigFile(txtPassword.Text.Trim(), "MD5");  
       


        model.id = userid;

        if (!model.UpdateMY())
        {
            
            mym.JscriptMsg(this.Page, "保存过程中发生错误！", "", "Error");
            return;
        }
        //mym.AddAdminLog("修改", "修改个人信息：用户名:" + Lituser_name.Text); //记录日志
        mym.JscriptMsg(this.Page, "个人信息修改成功！请下次用新密码登陆！", "", "Success");
    }
}