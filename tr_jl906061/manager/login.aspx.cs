using System;
using System.Web.UI;
using System.Web.Security;

public partial class manager_login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            txtUserName.Value = Utils.GetCookie("hy_bianhao");
        }
    }

    #region 登录系统=========================
    protected void btnSubmit_Click(object sender, EventArgs e)
    {

        string userName = txtUserName.Value.Trim();
        string userPwd = txtPassword.Value.Trim();

        //判断登录信息
        userPwd = FormsAuthentication.HashPasswordForStoringInConfigFile(userPwd, "MD5");
        //Response.Write(userPwd);
        //Response.End();
        if (tbl_admin.Exists(userName, userPwd))
        {
            tbl_admin myuser = new tbl_admin();
            string sqlGetUserID = "select  id  from [tbl_admin] where huiyuan_bianhao='" + userName + "'";
            int userid = Convert.ToInt16(DbHelperSQL.GetSingle(sqlGetUserID));
            myuser.GetModel(userid);

            //判断账号是否被禁用
            if (Convert.ToInt32(myuser.is_lock) == 1)
            {
                MessageBox.errorShow(this.Page, "您的账号被禁用，请联系客服！");
                return;
            }
          
            //写入登录日志
            tbl_login login_log = new tbl_login();
            login_log.huiyuan_bianhao = userName;
            login_log.huiyuan_name = myuser.huiyuan_name;
            login_log.login_date = DateTime.Now;
            login_log.login_flag = 1;
            login_log.huiyuan_ip = AXRequest.GetIP();
            login_log.Add();


            //写入Cookies
            Utils.WriteCookie("hy_id", myuser.huiyuan_id, 14400);
            Utils.WriteCookie("hy_bianhao", userName, 14400);
            Utils.WriteCookie("hy_name", myuser.huiyuan_name, 14400);
            Utils.WriteCookie("RoleID", myuser.role_id.ToString(), 14400);
       
 
            //写入Session
            Session["hy_id"] = myuser.huiyuan_id;
            Session["hy_bianhao"] = userName;
            Session["hy_name"] = myuser.huiyuan_name;
            Session["RoleID"] = myuser.role_id.ToString();
           
           
            Session.Timeout = 45;

            Response.Redirect("index.aspx");
            return;
        }
        else
        {
            MessageBox.errorShow(this.Page, "账号或密码有误，请重试！");
            return;
        }
    }
    #endregion
}