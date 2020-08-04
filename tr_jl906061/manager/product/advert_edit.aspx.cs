using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class manager_product_advert_edit : System.Web.UI.Page
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
        int nav_id = 86;
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
            class_bind();//绑定银行
            if (action == "Edit") //修改
            {
                ShowInfo(this.id);
            }
        }
    }
    #region 绑定银行=================================
    private void class_bind()
    {
        //tbl_sinkia_class bll = new tbl_sinkia_class();
        //DataTable dt = bll.GetList("1=1   order by sort_id").Tables[0];
        //this.pid.Items.Clear();
        //this.pid.Items.Add(new ListItem("请选择商品大类...", ""));
        //foreach (DataRow dr in dt.Rows)
        //{
        //    string Id = dr["id"].ToString();
        //    string Title = dr["pro_class"].ToString().Trim();
        //    this.pid.Items.Add(new ListItem(Title, Id));
        //}
    }
    #endregion

    #region 赋值操作=================================
    private void ShowInfo(int _id)
    {
        tbl_sinkia_advert model = new tbl_sinkia_advert();
        model.GetModel(_id);
        title.Text = model.advert_title;
        txtSortId.Text = model.sort_id.ToString();
        txtImgUrl_mob.Text = model.picture1;
        //txtImgUrl_mob1.Text = model.beiyong4;
        //txtImgUrl_mob2.Text = model.beiyong5;
        pid.Text = model.p1_url.ToString();

    }
    #endregion



    #region 增加操作=================================
    private bool DoAdd()
    {
        tbl_sinkia_banner model = new tbl_sinkia_banner();


        model.picture1 = txtImgUrl_mob.Text;
        model.sort_id = int.Parse(txtSortId.Text.Trim());
        model.p1_url = pid.Text;

        if (model.Add() > 0)
        {
            // mym.AddAdminLog("增加", "添加商品类别：" + txttitle.Text); //记录日志
            return true;
        }

        return false;
    }
    #endregion

    #region 修改操作=================================
    private bool DoEdit(int _id)
    {
        bool result = false;

        tbl_sinkia_advert model = new tbl_sinkia_advert();
        //if (model.Exists(txttitle.Text.Trim(), _id))
        //{
        //    mym.JscriptMsg(this.Page, "您输入的类别名称已经存在，请检查！", "", "Error");
        //    return false;
        //}
        model.GetModel(_id);
        model.advert_title=title.Text;
        model.picture1 = txtImgUrl_mob.Text;
        model.sort_id = int.Parse(txtSortId.Text.Trim());
        model.p1_url = pid.Text;
        //model.beiyong4 = txtImgUrl_mob1.Text;
        //model.beiyong5 = txtImgUrl_mob2.Text;
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
            if (!DoEdit(this.id))
            {
                mym.JscriptMsg(this.Page, "保存过程中发生错误！", "", "Error");
                return;
            }

            mym.JscriptMsg(this.Page, "修改信息成功！", Utils.CombUrlTxt("advert_list.aspx", "page={0}", this.page.ToString()), "Success");
        }
        else //添加
        {
            if (!DoAdd())
            {
                mym.JscriptMsg(this.Page, "保存过程中发生错误！", "", "Error");
                return;
            }
            mym.JscriptMsg(this.Page, "添加产品类别信息成功！", "advert_list.aspx", "Success");
        }
    }
}