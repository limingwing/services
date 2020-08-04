using System;
using System.Data;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;


public partial class manager_system_manage_edit : System.Web.UI.Page
{
    protected int page;
    string defaultpassword = "0|0|0|0"; //默认显示密码
    private string action = "Add"; //操作类型
    private int id = 0;
    ManagePage mym = new ManagePage();
    protected void Page_Load(object sender, EventArgs e)
    {
        //判断是否登录
        if (!mym.IsAdminLogin())
        {
            Response.Write("<script>parent.location.href='../index.aspx'</script>");
            Response.End();
        }
        //判断权限
        tbl_admin_role_value myrv = new tbl_admin_role_value();
        int role_id = Convert.ToInt32(Session["RoleID"]);
        int nav_id = 29;
        if (!myrv.QXExists(role_id, nav_id))
        {
            Response.Redirect("../error.html");
            Response.End();
        }
        string _action = AXRequest.GetQueryString("action");
        this.page = AXRequest.GetQueryInt("page", 1);
        if (!string.IsNullOrEmpty(_action) && _action == "Edit")
        {
            this.action = "Edit";//修改类型
            if (!int.TryParse(Request.QueryString["id"] as string, out this.id))
            {
                mym.JscriptMsg(this.Page, "传输参数不正确！", "back", "Error");
                return;
            }

        }
        if (action == "Edit") //修改
        {
            txtUserName.Attributes.Remove("ajaxurl");
        }
        if (!Page.IsPostBack)
        {
            RoleBind(ddlRoleId, Convert.ToInt32(Session["RoleID"]));//绑定角色

           
            if (action == "Edit") //修改
            {
                ShowInfo(this.id);
            }
        }
    }

  

   

    #region 角色类型=================================
    private void RoleBind(DropDownList ddl, int role_type)
    {
        tbl_admin_role bll = new tbl_admin_role();
        DataTable dt = bll.GetList("1=1 order by id desc").Tables[0];
        ddl.Items.Clear();
        ddl.Items.Add(new ListItem("请选择角色...", ""));
        foreach (DataRow dr in dt.Rows)
        {
            //if (Convert.ToInt32(dr["role_type"]) > role_type)
            //{
                ddl.Items.Add(new ListItem(dr["role_name"].ToString(), dr["id"].ToString()));
            //}
        }
    }
    #endregion

    #region 赋值操作=================================
    private void ShowInfo(int _id)
    {
        tbl_admin model = new tbl_admin();
        model.GetModel(_id);
        ddlRoleId.SelectedValue = model.role_id.ToString();

       

        txtUserName.Text = model.huiyuan_bianhao;
        if (_id == 1)//admin账号不能修改
        {
            txtUserName.ReadOnly = true;
        }

        if (!string.IsNullOrEmpty(model.huiyuan_pass))
        {
            txtPassword.Attributes["value"] = txtPassword1.Attributes["value"] = defaultpassword;
        }
        txtRealName.Text = model.huiyuan_name;
       
        if (model.is_lock == 0)
        {
            cbIsLock.Checked = true;
        }
        else
        {
            cbIsLock.Checked = false;
        }
    }
    #endregion

    #region 增加操作=================================
    private bool DoAdd()
    {
        tbl_admin model = new tbl_admin();

        model.role_id = int.Parse(ddlRoleId.SelectedValue);
        

        //检测用户名是否重复
        if (model.Exists(txtUserName.Text.Trim()))
        {
            mym.JscriptMsg(this.Page, "用户名已经存在，请更换！", "", "Error");
            return false;
        }
        model.huiyuan_bianhao = txtUserName.Text.Trim();

        model.huiyuan_pass = FormsAuthentication.HashPasswordForStoringInConfigFile(txtPassword.Text.Trim(), "MD5");  
        model.huiyuan_name = txtRealName.Text.Trim();
        model.add_time = DateTime.Now;
       


        if (cbIsLock.Checked == true)
        {
            model.is_lock = 0;
        }
        else
        {
            model.is_lock = 1;
        }
        if (model.Add() > 0)
        {
            
            return true;
        }

        return false;
    }
    #endregion

    #region 修改操作=================================
    private bool DoEdit(int _id)
    {
        bool result = false;

        tbl_admin model = new tbl_admin();
        model.GetModel(_id);

        model.role_id = int.Parse(ddlRoleId.SelectedValue);
       

        //检测用户名是否重复
        if (model.ExistsE(txtUserName.Text.Trim(), _id))
        {
            mym.JscriptMsg(this.Page, "用户名已经存在，请更换！", "", "Error");
            return false;
        }
        model.huiyuan_bianhao = txtUserName.Text.Trim();

        //判断密码是否更改
        if (txtPassword.Text.Trim() != defaultpassword)
        {
            model.huiyuan_pass = FormsAuthentication.HashPasswordForStoringInConfigFile(txtPassword.Text.Trim(), "MD5");  
        }
        model.huiyuan_name = txtRealName.Text.Trim();
        model.add_time = DateTime.Now;
  


        if (cbIsLock.Checked == true)
        {
            model.is_lock = 0;
        }
        else
        {
            model.is_lock = 1;
        }

        if (model.Update())
        {
            
            result = true;
        }

        return result;
    }
    #endregion


   

    //保存
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (action == "Edit") //修改
        {
            if (!DoEdit(this.id))
            {
                mym.JscriptMsg(this.Page, "保存过程中发生错误！", "", "Error");
                return;
            }
            mym.JscriptMsg(this.Page, "修改用户信息成功！", Utils.CombUrlTxt("manage.aspx", "page={0}", this.page.ToString()), "Success");
        }
        else //添加
        {
            if (!DoAdd())
            {
                mym.JscriptMsg(this.Page, "保存过程中发生错误！", "", "Error");
                return;
            }
            mym.JscriptMsg(this.Page, "添加用户信息成功！", "manage.aspx", "Success");
        }
    }
}