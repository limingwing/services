using System;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data.SqlClient;
public partial class manager_server_zmd : System.Web.UI.Page
{
    protected int page;
    private string action = "Add"; //操作类型
    private string huiyuan_id = "";
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
        int nav_id = 16;
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

            this.huiyuan_id = AXRequest.GetQueryString("huiyuan_id");
          

        }
        if (!Page.IsPostBack)
        {
            
            if (action == "Edit") //修改
            {
                ShowInfo(this.huiyuan_id);
                Focus myFocus = new Focus();
                myFocus.SetFocus(txttitle.Page, "txttitle");
            }
        }
    }

    #region 赋值操作=================================
    private void ShowInfo(string _id)
    {
        tbl_huiyuan model = new tbl_huiyuan();
        model.GetModel_hui_id(_id);

        txttitle.Text = model.huiyuan_bianhao;
        txttitle.ReadOnly = true;
        

    }
    #endregion



    #region 增加操作=================================
    private bool DoAdd()
    {
       // Response.Write(District.SelectedValue);
       // Response.End();
        tbl_huiyuan model = new tbl_huiyuan();
         model.GetModel_hui_bianhao(this.txttitle.Text.Trim());
        model.huiyuan_zhuanmai_sq = 1;
        //model.huiyuan_zm_diqu = Province.Text.Trim();
        
        model.huiyuan_zm_sq_time = DateTime.Now;
        model.huiyuan_id = model.huiyuan_id;
        model.zhuanmai_jb = int.Parse(jb.SelectedValue);

        if (model.Update())
        {
             // mym.AddAdminLog("增加", "添加商品类别：" + txttitle.Text); //记录日志
            return true;
        }

        return false;
    }
    #endregion
    //更新
    #region 修改操作=================================
    private bool DoEdit(string _id)
    {
    
        bool result = false;

        tbl_huiyuan model = new tbl_huiyuan();

        model.GetModel_hui_id(_id);
        model.zhuanmai_jb = int.Parse(jb.SelectedValue);
       // model.huiyuan_zm_diqu = Province.Text.Trim();
     
      

        if (model.Update())
        {
            // mym.AddAdminLog("修改", "修改商品类别:" + txttitle.Text); //记录日志
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
            if (!DoEdit(this.huiyuan_id))
            {
                mym.JscriptMsg(this.Page, "保存过程中发生错误！", "", "Error");
                return;
            }
         




            mym.JscriptMsg(this.Page, "修改服务中心信息成功！", Utils.CombUrlTxt("Service_Centre_un.aspx", "page={0}", this.page.ToString()), "Success");
        }
        else //添加
        {
            if (!DoAdd())
            {
                mym.JscriptMsg(this.Page, "保存过程中发生错误！", "", "Error");
                return;
            }
            mym.JscriptMsg(this.Page, "添加服务中心成功！", "Service_Centre_un.aspx", "Success");
        }
        //写入

    }
 
}
