using System;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class manager_system_Deve_kuangji1 : System.Web.UI.Page
{
    protected int page;
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
        int nav_id = 53;
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
        //tbl_reg_jiebie model = new tbl_reg_jiebie();
        //model.GetModel(_id);
        tbl_machine model = new tbl_machine();
        model.GetModel(_id);
        txt_percent.Text = model.percent.ToString();

        txt_money.Text = model.price.ToString();
        txt_date.Text = model.date.ToString();
        //txtSortId.Text = model.sort_id.ToString();
        //if (model.show_flag == 0)
        //{
        //    cbIsLock.Checked = false;
        //}
        //else
        //{
        //    cbIsLock.Checked = true;
        //}

    }
    #endregion



    //#region 增加操作=================================
    //private bool DoAdd()
    //{
    //    tbl_reg_jiebie model = new tbl_reg_jiebie();
    //    if (model.Exists(txttitle.Text.Trim()))
    //    {
    //        mym.JscriptMsg(this.Page, "您输入的级别名称已经存在，请检查！", "", "Error");
    //        return false;
    //    }

    //    if (model.Exists_jb_value(int.Parse(txt_fuzhi.Text.Trim())))
    //    {
    //        mym.JscriptMsg(this.Page, "您输入的级别赋值已经存在，请检查！", "", "Error");
    //        return false;
    //    }

    //    model.jiebie_name = txttitle.Text.Trim();
    //    model.jiebie_value =int.Parse(txt_fuzhi.Text.Trim());
    //    model.need_money =decimal.Parse(txt_money.Text.Trim());
    //    model.sort_id = int.Parse(txtSortId.Text.Trim());
    //    if (cbIsLock.Checked == true)
    //    {
    //        model.show_flag = 1;
    //    }
    //    else
    //    {
    //        model.show_flag = 0;
    //    }
    

    //    if (model.Add() > 0)
    //    {
    //        // mym.AddAdminLog("增加", "添加商品类别：" + txttitle.Text); //记录日志
    //        return true;
    //    }

    //    return false;
    //}
    //#endregion

    #region 修改操作=================================
    private bool DoEdit(int _id)
    {
        bool result = false;
        tbl_machine model1 = new tbl_machine();
        //tbl_reg_jiebie model = new tbl_reg_jiebie();
        //if (model.Exists(txttitle.Text.Trim(), _id))
        //{
        //    mym.JscriptMsg(this.Page, "您输入的级别名称已经存在，请检查！", "", "Error");
        //    return false;
        //}

        //if (model.Exists_jb_value(int.Parse(txt_fuzhi.Text.Trim()), _id))
        //{
        //    mym.JscriptMsg(this.Page, "您输入的级别赋值已经存在，请检查！", "", "Error");
        //    return false;
        //}
        model1.GetModel(_id);


        model1.percent = decimal.Parse(txt_percent.Text.Trim());
        model1.price =decimal.Parse(txt_money.Text.Trim());
        model1.date = Convert.ToInt32(txt_date.Text.Trim());
        //model.need_money =txt_money.Text.Trim();
        //model.sort_id = int.Parse(txtSortId.Text.Trim());
        //if (cbIsLock.Checked == true)
        //{
        //    model.show_flag = 1;
        //}
        //else
        //{
        //    model.show_flag = 0;
        //}

        //if (model.Update())
        //{
        //    // mym.AddAdminLog("修改", "修改商品类别:" + txttitle.Text); //记录日志
        //    result = true;
        //}
        model1.Update();
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
                mym.JscriptMsg(this.Page, "保存修改成功！", "", "Error");
                return;
            }


            mym.JscriptMsg(this.Page, "修改银行名称信息成功！", Utils.CombUrlTxt("Deve_kuangji.aspx", "page={0}", this.page.ToString()), "Success");
        }
        //else //添加
        //{
        //    if (!DoAdd())
        //    {
        //        mym.JscriptMsg(this.Page, "保存过程中发生错误！", "", "Error");
        //        return;
        //    }
        //    mym.JscriptMsg(this.Page, "添加银行名称信息成功！", "Deve_options.aspx", "Success");
        //}
    }
}