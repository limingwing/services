using System;
using System.Data;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

public partial class manager_system_bank_edit : System.Web.UI.Page
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
        int nav_id = 90;
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
            txtBank.Attributes.Remove("ajaxurl");
        }
        if (!Page.IsPostBack)
        {



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
        tbl_bank model = new tbl_bank();
        model.GetModel(_id);




        txtBank.Text = model.accountbank;
        txtName.Text = model.accountno;

        txtNumber.Text = model.accountno;
        txtBeifen.Text = model.beizhu;

    }
    #endregion

    #region 增加操作=================================
    private bool DoAdd()
    {
        tbl_bank model = new tbl_bank();


        model.accountbank = txtBank.Text.Trim();

        model.accountname = txtName.Text.Trim();
        model.accountno = txtNumber.Text.Trim();
        model.beizhu = txtBeifen.Text.Trim();


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

        tbl_bank model = new tbl_bank();
        model.GetModel(_id);

        //检测用户名是否重复
        if (model.ExistsE(txtBank.Text.Trim(), _id))
        {
            mym.JscriptMsg(this.Page, "银行已经存在，请更换！", "", "Error");
            return false;
        }
        model.accountbank = txtBank.Text.Trim();


        model.accountname = txtName.Text.Trim();
        model.accountno = txtNumber.Text.Trim();
        model.beizhu = txtBeifen.Text.Trim();

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
            mym.JscriptMsg(this.Page, "修改用户信息成功！", Utils.CombUrlTxt("bank.aspx", "page={0}", this.page.ToString()), "Success");
        }
        else //添加
        {
            if (!DoAdd())
            {
                mym.JscriptMsg(this.Page, "保存过程中发生错误！", "", "Error");
                return;
            }
            mym.JscriptMsg(this.Page, "添加用户信息成功！", "bank.aspx", "Success");
        }
    }
}