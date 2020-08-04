using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class manager_system_open : System.Web.UI.Page
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
        //判断权限
        tbl_admin_role_value myrv = new tbl_admin_role_value();
        int role_id = Convert.ToInt32(Session["RoleID"]);
        int nav_id = 68;
        if (!myrv.QXExists(role_id, nav_id))
        {
            Response.Redirect("../error.html");
            Response.End();
        }

        if (!Page.IsPostBack)
        {
           

            ShowInfo(1);
        }
    }

    #region 赋值操作=================================
    private void ShowInfo(int _id)
    {
        tbl_open model = new tbl_open();
        model.GetModel(_id);

        if (model.open_flag == 1)
        {
            cbIsLock.Checked = true;
        }
        else
        {
            cbIsLock.Checked = false;
        }
        message.Text = model.tishi;
    }
    #endregion
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        tbl_open model = new tbl_open();

        model.GetModel(1);
        if (cbIsLock.Checked == true)
        {
            model.open_flag = 1;
        }
        else
        {
            model.open_flag = 0;
        }

        model.tishi = this.message.Text.Trim();
        if (model.Update())
        {

            mym.JscriptMsg(this.Page, "修改成功！", "", "Success");
        }
    }
}