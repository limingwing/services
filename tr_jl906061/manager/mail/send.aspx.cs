using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class manager_mail_send : System.Web.UI.Page
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
            Response.Write("<script>parent.location.href='../login.aspx'</script>");
            Response.End();
        }
        //判断权限
        tbl_admin_role_value myrv = new tbl_admin_role_value();
        int role_id = Convert.ToInt32(Session["RoleID"]);
        int nav_id = 59;
        if (!myrv.QXExists(role_id, nav_id))
        {
            Response.Redirect("../error.html");
            Response.End();
        }
        string _action = AXRequest.GetQueryString("action");
        string _title = AXRequest.GetQueryString("title");
        string _liuyan_to = AXRequest.GetQueryString("liuyan_to");
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
                ShowInfo(this.id, _title, _liuyan_to);
                Focus myFocus = new Focus();
                myFocus.SetFocus(txt_bianhao.Page, "txt_bianhao");
            }
        }
    }

    #region 赋值操作=================================
    private void ShowInfo(int _id, string _title, string _liuyan_to)
    {

        
 
        txttitle.Text = "回复：" + _title;

        txt_bianhao.Text = _liuyan_to;
       

    }
    #endregion

    #region 增加操作=================================
    private bool DoAdd()
    {
        tbl_liuyan model = new tbl_liuyan();
        
        model.liuyan_title = txttitle.Text.Trim();
        model.liuyan_memo = txtContent.Value;
        model.liuyan_date = DateTime.Now;
        model.liuyan_bianhao = "A00000000";
        model.liuyan_name = "公司";
        model.liuyan_to = txt_bianhao.Text.Trim();
       
        tbl_huiyuan model_hui = new tbl_huiyuan();
        model_hui.GetModel_hui_bianhao(txt_bianhao.Text.Trim());
        model.liuyan_to_name = model_hui.huiyuan_name;
        if (model.Add() > 0)
        {

            return true;
        }

        return false;
    }
    #endregion

    #region 回复操作=================================
    private bool DoEdit(int _id)
    {
        bool result = false;

        tbl_liuyan model = new tbl_liuyan();
       

        model.liuyan_title = txttitle.Text.Trim();
        model.liuyan_memo = txtContent.Value;
        model.liuyan_date = DateTime.Now;
        model.liuyan_bianhao = "A00000000";
        model.liuyan_name = "公司";
        model.liuyan_to = txt_bianhao.Text.Trim();
        tbl_huiyuan model_hui = new tbl_huiyuan();
        model_hui.GetModel_hui_bianhao(txt_bianhao.Text.Trim());
        model.liuyan_to_name = model_hui.huiyuan_name;

        
        int click = 2;
        model.UpdateField(_id, "kan_flag=" + click);
        if (model.Add()>0)
        {
        
            result = true;
        }

        return result;
    }
    #endregion

    //保存
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (action == "Edit") //回复
        {
            if (!DoEdit(this.id))
            {
                mym.JscriptMsg(this.Page, "保存过程中发生错误！", "", "Error");
                return;
            }
            mym.JscriptMsg(this.Page, "回复邮件成功！", Utils.CombUrlTxt("in_box.aspx", "page={0}", this.page.ToString()), "Success");
        }
        else //添加
        {
            if (!DoAdd())
            {
                mym.JscriptMsg(this.Page, "保存过程中发生错误！", "", "Error");
                return;
            }
            mym.JscriptMsg(this.Page, "添加邮件成功！", "in_box.aspx", "Success");
        }
    }
}