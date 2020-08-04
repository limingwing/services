using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class manager_system_jiesuan : System.Web.UI.Page
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
        int nav_id = 67;
        if (!myrv.QXExists(role_id, nav_id))
        {
            Response.Redirect("../error.html");
            Response.End();
        }
    }
    protected void btnSubmit_Click_ri(object sender, EventArgs e)
    {
        DbHelperSQL.ExecuteSql("exec sp_zhixing_ri");
        Page.ClientScript.RegisterClientScriptBlock(Page.GetType(), "", "alert('结算成功。');window.location='jiesuan.aspx';", true);
    }
    protected void btnSubmit_Click_zhou(object sender, EventArgs e)
    {
        DbHelperSQL.ExecuteSql("exec sp_zhixing_zhou");
        Page.ClientScript.RegisterClientScriptBlock(Page.GetType(), "", "alert('结算成功。');window.location='jiesuan.aspx';", true);
    }
    protected void btnSubmit_Click_yue(object sender, EventArgs e)
    {
        DbHelperSQL.ExecuteSql("exec sp_zhixing_zhou");
        Page.ClientScript.RegisterClientScriptBlock(Page.GetType(), "", "alert('结算成功。');window.location='jiesuan.aspx';", true);
    }
    protected void btnSubmit_Click_back(object sender, EventArgs e)
    {

        string dbcode = "";
        string Strcon = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
        System.Data.Common.DbConnectionStringBuilder ss = new System.Data.Common.DbConnectionStringBuilder(false);
        ss.ConnectionString = Strcon;
        object aa = "";
        if (ss.TryGetValue("database", out aa))
        {
            dbcode = aa.ToString();
        }       

        string newname = Utils.GetOrderNumber() + ".bak";
        string nepath = Server.MapPath("databack/") + newname;
       
        DbHelperSQL.ExecuteSql("BACKUP DATABASE " + dbcode + " to DISK ='" + nepath + "'");


        HyperLink1.Text = "已成功备份文件" + newname + "请点击下载到本地！";

        HyperLink1.NavigateUrl = "DataBack/" + newname;

        HyperLink1.Visible = true; 




    }
    protected void btnSubmit_Click_qingkong(object sender, EventArgs e)
    {
        DbHelperSQL.ExecuteSql("exec sp_del");
        Page.ClientScript.RegisterClientScriptBlock(Page.GetType(), "", "alert('清空数据成功。');window.location='jiesuan.aspx';", true);
    }
}