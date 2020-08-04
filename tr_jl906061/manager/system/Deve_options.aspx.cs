using System;
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class manager_system_Deve_options : System.Web.UI.Page
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
        int nav_id = 53;
        if (!myrv.QXExists(role_id, nav_id))
        {
            Response.Redirect("../error.html");
            Response.End();
        }
        this.keywords = AXRequest.GetQueryString("keywords");
        //this.pageSize = GetPageSize(10); //每页数量
        this.page = AXRequest.GetQueryInt("page", 1);
        if (!Page.IsPostBack)
        {
            RptBind("", "sort_id asc,id desc");
            //this.TextBox8.Items.Clear();
            //this.TextBox8.Items.Add(new ListItem("请选择天数...", "0"));
            //this.TextBox8.Items.Add(new ListItem("8天", "7"));
            //this.TextBox8.Items.Add(new ListItem("11天", "10"));
            //this.TextBox8.Items.Add(new ListItem("13天", "12"));
            //this.TextBox8.Items.Add(new ListItem("16天", "15"));
            ShowInfo(1);
        }

       
    }

    #region 数据绑定=================================
    private void RptBind(string _strWhere, string _orderby)
    {
        this.page = AXRequest.GetQueryInt("page", 1);

        tbl_reg_jiebie bll = new tbl_reg_jiebie();
        this.rptList.DataSource = bll.GetList(this.pageSize, this.page, _strWhere, _orderby, out this.totalCount);
        this.rptList.DataBind();

        //绑定页码
        txtPageNum.Text = this.pageSize.ToString();
        string pageUrl = Utils.CombUrlTxt("Deve_options.aspx", "keywords={0}&page={1}", this.keywords, "__id__");
        PageContent.InnerHtml = Utils.OutPageList(this.pageSize, this.page, this.totalCount, pageUrl, 8);
    }
    #endregion



    #region 返回每页数量=============================
    private int GetPageSize(int _default_size)
    {
        int _pagesize;
        if (int.TryParse(Utils.GetCookie("Deve_options_page_size"), out _pagesize))
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
                Utils.WriteCookie("Deve_options_page_size", _pagesize.ToString(), 14400);
            }
        }
        Response.Redirect(Utils.CombUrlTxt("Deve_options.aspx", "keywords={0}", this.keywords));
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
        if (!bllpp.ExistsBM())//查找是否存在下级会员级别
        {
            bll.Delete(caId);

            mym.JscriptMsg(this.Page, " 成功删除该会员级别：" + title + "", Utils.CombUrlTxt("Deve_options.aspx", "keywords={0}&page={1}", this.keywords, this.page.ToString()), "Success");
        }
        else
        {
            mym.JscriptMsg(this.Page, "有会员拥有该级别，不能删除！", "", "Error");
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

        mym.JscriptMsg(this.Page, " 排序保存成功", Utils.CombUrlTxt("Deve_options.aspx", "keywords={0}&page={1}", this.keywords, this.page.ToString()), "Success");
    }

    #region 赋值操作=================================
    private void ShowInfo(int _id)
    {
        tbl_canshu model = new tbl_canshu();
        model.GetModel(_id);
        
        //if (model.reg_shoping == 1)
        //{
        //    cbIsLock.Checked = true;
        //}
        //else
        //{
        //    cbIsLock.Checked = false;
        //}
        //TextBox1.Text = model.canshu_001.ToString();
        //TextBox2.Text = model.canshu_002.ToString();
        //TextBox3.Text = model.canshu_003.ToString();
        //TextBox4.Text = model.canshu_004.ToString();
        //TextBox5.Text = model.canshu_005.ToString();
        //TextBox6.Text = model.canshu_006.ToString();
        //TextBox7.Text = model.canshu_007.ToString();
        //TextBox8.Text = model.canshu_008.ToString();
        //TextBox9.Text = model.canshu_009.ToString();
        //TextBox10.Text = model.canshu_010.ToString();
        //TextBox11.Text = model.canshu_011.ToString();
        //TextBox12.Text = model.canshu_012.ToString();
        //TextBox13.Text = model.canshu_013.ToString();
        //TextBox14.Text = model.canshu_014.ToString();
        //TextBox15.Text = model.canshu_015.ToString();
        //TextBox16.Text = model.canshu_016.ToString();
        //TextBox17.Text = model.canshu_017.ToString();
        //TextBox18.Text = model.canshu_018.ToString();
        //TextBox19.Text = model.canshu_019.ToString();
        //TextBox20.Text = model.canshu_020.ToString();
        //TextBox21.Text = model.canshu_021.ToString();
        //TextBox22.Text = model.canshu_022.ToString();
        //TextBox23.Text = model.canshu_023.ToString();
        //TextBox24.Text = model.canshu_024.ToString();
        //TextBox25.Text = model.canshu_025.ToString();
        //TextBox26.Text = model.canshu_026.ToString();
        //TextBox27.Text = model.canshu_027.ToString();
        //TextBox28.Text = model.canshu_028.ToString();
        //TextBox29.Text = model.canshu_029.ToString();
        //TextBox30.Text = model.canshu_030.ToString();
        //TextBox31.Text = model.canshu_031.ToString();
        //TextBox32.Text = model.canshu_032.ToString();
        //TextBox33.Text = model.canshu_033.ToString();
        //TextBox34.Text = model.canshu_034.ToString();
        //TextBox35.Text = model.canshu_035.ToString();
        //TextBox36.Text = model.canshu_036.ToString();
        //TextBox37.Text = model.canshu_037.ToString();
        //TextBox38.Text = model.canshu_038.ToString();
        //TextBox39.Text = model.canshu_039.ToString();
        //TextBox40.Text = model.canshu_040.ToString();
        //TextBox41.Text = model.canshu_041.ToString();
        //TextBox42.Text = model.canshu_042.ToString();
        //TextBox43.Text = model.canshu_043.ToString();
        //TextBox44.Text = model.canshu_044.ToString();
        //TextBox45.Text = model.canshu_045.ToString();
        //TextBox46.Text = model.canshu_046.ToString();
        //TextBox47.Text = model.canshu_047.ToString();
        //TextBox48.Text = model.canshu_048.ToString();
        //TextBox49.Text = model.canshu_049.ToString();
        //TextBox50.Text = model.canshu_050.ToString();
        //TextBox51.Text = model.canshu_051.ToString();
        //TextBox52.Text = model.canshu_052.ToString();
        //TextBox53.Text = model.canshu_053.ToString();
        //TextBox54.Text = model.canshu_054.ToString();
        //TextBox55.Text = model.canshu_055.ToString();
        //TextBox56.Text = model.canshu_056.ToString();
        //TextBox57.Text = model.canshu_057.ToString();
        //TextBox58.Text = model.canshu_058.ToString();
        //TextBox59.Text = model.canshu_059.ToString();
        //TextBox60.Text = model.canshu_060.ToString();
        //TextBox61.Text = model.canshu_061.ToString();
        //TextBox62.Text = model.canshu_062.ToString();
        //TextBox63.Text = model.canshu_063.ToString();
        //TextBox64.Text = model.canshu_064.ToString();
        //TextBox65.Text = model.canshu_065.ToString();
        //TextBox66.Text = model.canshu_066.ToString();
        //TextBox67.Text = model.canshu_067.ToString();
        //txtstart_time.Value = model.dispose_time.Value.ToShortDateString();
        //TextBox94.Text = model.canshu_094.ToString();
        //TextBox95.Text = model.canshu_095.ToString();
        //TextBox96.Text = model.canshu_096.ToString();
        //TextBox97.Text = model.canshu_097.ToString();
        //TextBox98.Text = model.canshu_098.ToString();
        sys_name.Text = model.sys_name;
    }
    #endregion

    #region 修改操作=================================
    private bool DoEdit(int _id)
    {
        bool result = false;

        tbl_canshu model = new tbl_canshu();

        model.GetModel(_id);
        //if (cbIsLock.Checked == true)
        //{
        //    model.reg_shoping = 1;
        //}
        //else
        //{
        //    model.reg_shoping = 0;
        //}
        model.sys_name = sys_name.Text;
        //model.canshu_001 = decimal.Parse(TextBox1.Text);
        //model.canshu_002 = decimal.Parse(TextBox2.Text);
        //model.canshu_003 = decimal.Parse(TextBox3.Text);
        //model.canshu_004 = decimal.Parse(TextBox4.Text);
        //model.canshu_005 = decimal.Parse(TextBox5.Text);
        //model.canshu_006 = decimal.Parse(TextBox6.Text);
        //model.canshu_007 = decimal.Parse(TextBox7.Text);
        //model.canshu_008 = decimal.Parse(TextBox8.Text);
        //model.canshu_009 = decimal.Parse(TextBox9.Text);
        //model.canshu_010 = decimal.Parse(TextBox10.Text);
        //model.canshu_011 = decimal.Parse(TextBox11.Text);
        //model.canshu_012 = decimal.Parse(TextBox12.Text);
        //model.canshu_013 = decimal.Parse(TextBox13.Text);
        //model.canshu_014 = decimal.Parse(TextBox14.Text);
        //model.canshu_015 = decimal.Parse(TextBox15.Text);
        //model.canshu_016 = decimal.Parse(TextBox16.Text);
        //model.canshu_017 = decimal.Parse(TextBox17.Text);
        //model.canshu_018 = decimal.Parse(TextBox18.Text);
        //model.canshu_019 = decimal.Parse(TextBox19.Text);
        //model.canshu_020 = decimal.Parse(TextBox20.Text);
        //model.canshu_021 = decimal.Parse(TextBox21.Text);
        //model.canshu_022 = decimal.Parse(TextBox22.Text);
        //model.canshu_023 = decimal.Parse(TextBox23.Text);
        //model.canshu_024 = decimal.Parse(TextBox24.Text);
        //model.canshu_025 = decimal.Parse(TextBox25.Text);
        //model.canshu_026 = decimal.Parse(TextBox26.Text);
        //model.canshu_027 = decimal.Parse(TextBox27.Text);
        //model.canshu_028 = decimal.Parse(TextBox28.Text);
        //model.canshu_029 = decimal.Parse(TextBox29.Text);
        //model.canshu_030 = decimal.Parse(TextBox30.Text);
        //model.canshu_031 = decimal.Parse(TextBox31.Text);
        //model.canshu_032 = decimal.Parse(TextBox32.Text);
        //model.canshu_033 = decimal.Parse(TextBox33.Text);
        //model.canshu_034 = decimal.Parse(TextBox34.Text);
        //model.canshu_035 = decimal.Parse(TextBox35.Text);
        //model.canshu_036 = decimal.Parse(TextBox36.Text);
        //model.canshu_037 = decimal.Parse(TextBox37.Text);
        //model.canshu_038 = decimal.Parse(TextBox38.Text);
        //model.canshu_039 = decimal.Parse(TextBox39.Text);
        //model.canshu_040 = decimal.Parse(TextBox40.Text);
        //model.canshu_041 = decimal.Parse(TextBox41.Text);
        //model.canshu_042 = decimal.Parse(TextBox42.Text);
        //model.canshu_043 = decimal.Parse(TextBox43.Text);
        //model.canshu_044 = decimal.Parse(TextBox44.Text);
        //model.canshu_045 = decimal.Parse(TextBox45.Text);
        //model.canshu_046 = decimal.Parse(TextBox46.Text);
        //model.canshu_047 = decimal.Parse(TextBox47.Text);
        //model.canshu_048 = decimal.Parse(TextBox48.Text);
        //model.canshu_049 = decimal.Parse(TextBox49.Text);
        //model.canshu_050 = decimal.Parse(TextBox50.Text);
        //model.canshu_051 = decimal.Parse(TextBox51.Text);
        //model.canshu_052 = decimal.Parse(TextBox52.Text);
        //model.canshu_053 = decimal.Parse(TextBox53.Text);
        //model.canshu_054 = decimal.Parse(TextBox54.Text);
        //model.canshu_055 = decimal.Parse(TextBox55.Text);
        //model.canshu_056 = decimal.Parse(TextBox56.Text);
        //model.canshu_057 = decimal.Parse(TextBox57.Text);
        //model.canshu_058 = decimal.Parse(TextBox58.Text);
        //model.canshu_059 = decimal.Parse(TextBox59.Text);
        //model.canshu_060 = decimal.Parse(TextBox60.Text);
        //model.canshu_061 = decimal.Parse(TextBox61.Text);
        //model.canshu_062 = decimal.Parse(TextBox62.Text);
        //model.canshu_063 = decimal.Parse(TextBox63.Text);
        //model.canshu_064 = decimal.Parse(TextBox64.Text);
        //model.canshu_065 = decimal.Parse(TextBox65.Text);
        //model.canshu_066 = decimal.Parse(TextBox66.Text);
        //model.canshu_067 = decimal.Parse(TextBox67.Text);
        //model.dispose_time = Convert.ToDateTime(txtstart_time.Value.Trim().ToString());
        //model.canshu_094 = decimal.Parse(TextBox94.Text);
        //model.canshu_095 = decimal.Parse(TextBox95.Text);
        //model.canshu_096 = decimal.Parse(TextBox96.Text);
        //model.canshu_097 = decimal.Parse(TextBox97.Text);
        //model.canshu_098 = decimal.Parse(TextBox98.Text);
        if (model.Update())
        {

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
        mym.JscriptMsg(this.Page, "修改信息成功！", Utils.CombUrlTxt("Deve_options.aspx", "page={0}", this.page.ToString()), "Success");
    }
}