using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class manager_system_guanxi : System.Web.UI.Page
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
        int nav_id = 75;
        if (!myrv.QXExists(role_id, nav_id))
        {
            Response.Redirect("../error.html");
            Response.End();
        }

        
    }

    
    protected void btnSubmit_Click(object sender, EventArgs e)
    {

        if (huiyuan_bianhao.Text.Trim() == "A00000000")
        {
            mym.JscriptMsg(this.Page, "编号不能为公司！", "", "Error");
            return;
        
        }

        if (huiyuan_bianhao_to.Text.Trim() == "A00000000")
        {
            mym.JscriptMsg(this.Page, "编号不能为公司！", "", "Error");
            return;

        }

        if (huiyuan_bianhao.Text.Trim() == huiyuan_bianhao_to.Text.Trim())
        {
            mym.JscriptMsg(this.Page, "不能为用一人！", "", "Error");
            return;

        }


        tbl_huiyuan model = new tbl_huiyuan();

        model.GetModel_hui_bianhao(huiyuan_bianhao.Text.Trim());
        string huiyuan_id = model.huiyuan_id;

        model.GetModel_hui_bianhao(huiyuan_bianhao_to.Text.Trim());
        string huiyuan_id_to = model.huiyuan_id;

        DbHelperSQL.ExecuteSql("exec huhuan '" + huiyuan_id + "','" + huiyuan_id_to + "'");

        string memo = "管理员互换" + huiyuan_bianhao.Text.Trim() + "和" + huiyuan_bianhao_to.Text.Trim() + "推荐位置";
        mym.queren_insert(Session["hy_bianhao"].ToString(), Session["hy_bianhao"].ToString(), "位置互换", memo, 0, 0);
        mym.JscriptMsg(this.Page, "修改成功！", "", "Success");
       
    }
}