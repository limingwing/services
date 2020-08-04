using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class manager_system_gp_shezhi : System.Web.UI.Page
{
    protected int totalCount;
    protected int page;
    protected int pageSize;
    protected string keywords = string.Empty;

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
        int nav_id = 100;
        if (!myrv.QXExists(role_id, nav_id))
        {
            Response.Redirect("../error.html");
            Response.End();
        }
        this.keywords = AXRequest.GetQueryString("keywords");
        this.pageSize = GetPageSize(10); //每页数量
        this.page = AXRequest.GetQueryInt("page", 1);
        if (!Page.IsPostBack)
        {
            RptBind("", "id desc ");

            ShowInfo(1);
        }
    }

    #region 数据绑定=================================
    private void RptBind(string _strWhere, string _orderby)
    {
        this.page = AXRequest.GetQueryInt("page", 1);

        tbl_gupiao bll = new tbl_gupiao();
        this.rptList.DataSource = bll.GetList(this.pageSize, this.page, _strWhere, _orderby, out this.totalCount);
        this.rptList.DataBind();

        //绑定页码
        txtPageNum.Text = this.pageSize.ToString();
        string pageUrl = Utils.CombUrlTxt("gp_shezhi.aspx", "keywords={0}&page={1}", this.keywords, "__id__");
        PageContent.InnerHtml = Utils.OutPageList(this.pageSize, this.page, this.totalCount, pageUrl, 8);
    }
    #endregion



    #region 返回每页数量=============================
    private int GetPageSize(int _default_size)
    {
        int _pagesize;
        if (int.TryParse(Utils.GetCookie("Deve_options_page_size1"), out _pagesize))
        {
            if (_pagesize > 0)
            {
                return _pagesize;
            }
        }
        return _default_size;
    }
    #endregion




    //设置分页数量
    protected void txtPageNum_TextChanged(object sender, EventArgs e)
    {
        int _pagesize;
        if (int.TryParse(txtPageNum.Text.Trim(), out _pagesize))
        {
            if (_pagesize > 0)
            {
                Utils.WriteCookie("Deve_options_page_size1", _pagesize.ToString(), 14400);
            }
        }
        Response.Redirect(Utils.CombUrlTxt("gp_shezhi.aspx", "keywords={0}", this.keywords));
    }

    // 单个删除
    protected void lbtnDelCa_Click(object sender, EventArgs e)
    {
        // 当前点击的按钮
        LinkButton lb = (LinkButton)sender;
        int caId = int.Parse(lb.CommandArgument);
        tbl_reg_jiebie bll = new tbl_reg_jiebie();
        bll.GetModel(caId);
        string title = bll.jiebie_name;
        tbl_huiyuan bllpp = new tbl_huiyuan();
        bllpp.huiyuan_jiebie = caId;
        if (!bllpp.ExistsBM())//查找是否存在下级玩家级别
        {
            bll.Delete(caId);

            mym.JscriptMsg(this.Page, " 成功删除该玩家级别：" + title + "", Utils.CombUrlTxt("gp_shezhi.aspx", "keywords={0}&page={1}", this.keywords, this.page.ToString()), "Success");
        }
        else
        {
            mym.JscriptMsg(this.Page, "有玩家拥有该级别，不能删除！", "", "Error");
            return;
        }

    }



    //保存排序
    protected void btnSave_Click(object sender, EventArgs e)
    {
        tbl_reg_jiebie bll = new tbl_reg_jiebie();
        Repeater rptList = new Repeater();
        rptList = this.rptList;

        for (int i = 0; i < rptList.Items.Count; i++)
        {
            int id = Convert.ToInt32(((HiddenField)rptList.Items[i].FindControl("hidId")).Value);
            int sortId;
            if (!int.TryParse(((TextBox)rptList.Items[i].FindControl("txtSortId")).Text.Trim(), out sortId))
            {
                sortId = 99;
            }
            bll.UpdateField(id, "sort_id=" + sortId.ToString());
        }

        mym.JscriptMsg(this.Page, " 排序保存成功", Utils.CombUrlTxt("gp_shezhi.aspx", "keywords={0}&page={1}", this.keywords, this.page.ToString()), "Success");
    }

    #region 赋值操作=================================
    private void ShowInfo(int _id)
    {
        tbl_canshu model = new tbl_canshu();
        model.GetModel(_id);

       
        TextBox1.Text = model.canshu_060.ToString();
       
       
        
    }
    #endregion

    #region 修改操作=================================
    private bool DoEdit(int _id)
    {
        bool result = false;

        tbl_canshu model = new tbl_canshu();

        model.GetModel(_id);
 
        
        model.canshu_060 = decimal.Parse(TextBox1.Text);
      
       
        if (model.Update())
        {
            //DbHelperSQL.ExecuteSql("TRUNCATE TABLE tbl_gupiao  ");
            tbl_gupiao tbl_gp = new tbl_gupiao();
            tbl_gp.gp_price = decimal.Parse(TextBox1.Text);
            tbl_gp.gp_add_date = DateTime.Now;
            tbl_gp.Add();


            result = true;
        }

        return result;
    }
    #endregion


    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (!DoEdit(1))
        {
            mym.JscriptMsg(this.Page, "保存过程中发生错误！", "", "Error");
            return;
        }
        mym.JscriptMsg(this.Page, "修改信息成功！", Utils.CombUrlTxt("gp_shezhi.aspx", "page={0}", this.page.ToString()), "Success");
    }
}