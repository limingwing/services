using System;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class manager_system_role_edit : System.Web.UI.Page
{
    private string action = "Add"; //操作类型
    private int id = 0;
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
        int nav_id = 34;
        if (!myrv.QXExists(role_id, nav_id))
        {
            Response.Redirect("../error.html");
            Response.End();
        }
        string _action = AXRequest.GetQueryString("action");
        if (!string.IsNullOrEmpty(_action) && _action == "Edit")
        {
            this.action = "Edit";//修改类型
            if (!int.TryParse(Request.QueryString["id"] as string, out this.id))
            {
                mym.JscriptMsg(this.Page, "传输参数不正确！", "back", "Error");
                return;
            }

        }
        if (!Page.IsPostBack)
        {
            if (action == "Edit") //修改
            {
                ShowInfo(this.id);
            }
        }
    }

    #region 赋值操作=================================
    private void ShowInfo(int _id)
    {
        tbl_admin_role model = new tbl_admin_role();
        model.GetModel(_id);
        Litrole_name.Text = model.role_name;
        NavBind();

        for (int i = 0; i < rptList.Items.Count; i++)
        {
            CheckBox cb = (CheckBox)rptList.Items[i].FindControl("chkId");
            int nav_id = Convert.ToInt32(((HiddenField)rptList.Items[i].FindControl("hidId")).Value);
            tbl_admin_role_value bll = new tbl_admin_role_value();
            if (bll.QXExists(_id, nav_id))
            {
                cb.Checked = true;
            }
        }
    }
    #endregion

    #region 导航菜单=================================
    private void NavBind()
    {
        tbl_admin_navi bll = new tbl_admin_navi();
        DataTable dt = bll.GetList("1=1 and show_flag=0 order by sort_id").Tables[0];
        this.rptList.DataSource = dt;
        this.rptList.DataBind();
    }
    #endregion


    //美化列表
    protected void rptList_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if (e.Item.ItemType == ListItemType.AlternatingItem || e.Item.ItemType == ListItemType.Item)
        {
            //美化导航树结构
            Literal LitFirst = (Literal)e.Item.FindControl("LitFirst");
            HiddenField hidLayer = (HiddenField)e.Item.FindControl("hidLayer");
            string LitStyle = "<span style=\"display:inline-block;width:{0}px;\"></span>{1}{2}";
            string LitImg1 = "<span class=\"folder-open\"></span>";
            string LitImg2 = "<span class=\"folder-line\"></span>";

            int classLayer = Convert.ToInt32(hidLayer.Value);
            if (classLayer == 0)
            {
                LitFirst.Text = LitImg1;
            }
            else
            {
                LitFirst.Text = string.Format(LitStyle, 0, LitImg2, LitImg1);
            }

        }
    }
    #region 修改操作=================================
    private bool DoEdit(int _id)
    {
        bool result = false;
        tbl_admin_role_value model = new tbl_admin_role_value();
        model.Delete(_id);

        for (int i = 0; i < rptList.Items.Count; i++)
        {
            CheckBox cb = (CheckBox)rptList.Items[i].FindControl("chkId");
            int nav_id = Convert.ToInt32(((HiddenField)rptList.Items[i].FindControl("hidId")).Value);
            if (cb.Checked)
            {
                model.role_id = _id;
                model.nav_id = nav_id;
                model.Add();
            }
        }
        result = true;
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
            mym.JscriptMsg(this.Page, "角色权限设置成功！", "", "Success");
        }

    }
}