using System;
using System.Text;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class manager_member_al_read1 : System.Web.UI.Page
{
    protected int totalCount;
    protected int page;
    protected int pageSize;

    protected int jiebie;
    protected int cha_type;
    protected string note_no = string.Empty;
    protected string start_time = string.Empty;
    protected string stop_time = string.Empty;


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
        int nav_id = 38;
        if (!myrv.QXExists(role_id, nav_id))
        {
            Response.Redirect("../error.html");
            Response.End();
        }

        this.jiebie = AXRequest.GetQueryInt("huiyuan_jiebie");

        this.note_no = AXRequest.GetQueryString("note_no");
        this.cha_type = AXRequest.GetQueryInt("type");

        if (AXRequest.GetQueryString("start_time") == "")
        {
            this.start_time = DateTime.Now.ToString("2015-01-01");
        }
        else
        {

            this.start_time = AXRequest.GetQueryString("start_time");
        }
        if (AXRequest.GetQueryString("stop_time") == "")
        {
            this.stop_time = DateTime.Now.ToString("yyyy-MM-dd");
        }
        else
        {
            this.stop_time = AXRequest.GetQueryString("stop_time");
        }
        this.pageSize = GetPageSize(10); //每页数量

        if (!Page.IsPostBack)
        {

            ZYBind();//绑定会员级别

            txtstart_time.Value = DateTime.Now.ToString("d");
            txtstop_time.Value = DateTime.Now.ToString("d");

            RptBind("huiyuan_id<>'A00000000' and net_hege=0 " + CombSqlTxt(this.jiebie, this.note_no, this.start_time, this.stop_time, this.cha_type), "huiyuan_add_time desc");


        }
    }

    #region 绑定会员级别=================================
    private void ZYBind()
    {
        tbl_reg_jiebie bll = new tbl_reg_jiebie();
        DataTable dt = bll.GetList("1=1").Tables[0];
        this.ddlproduct_category_id.Items.Clear();
        this.ddlproduct_category_id.Items.Add(new ListItem("==全部==", "0"));
        foreach (DataRow dr in dt.Rows)
        {
            string Id = dr["jiebie_value"].ToString();
            string Title = dr["jiebie_name"].ToString().Trim() + Math.Floor(double.Parse(dr["need_money"].ToString())) + "元";
            this.ddlproduct_category_id.Items.Add(new ListItem(Title, Id));
        }
    }
    #endregion


    #region 数据绑定=================================
    private void RptBind(string _strWhere, string _orderby)
    {
        this.page = AXRequest.GetQueryInt("page", 1);


        if (this.jiebie > 0)
        {
            this.ddlproduct_category_id.SelectedValue = this.jiebie.ToString();
        }

        txtNote_no.Text = this.note_no;
        txtstart_time.Value = this.start_time;
        txtstop_time.Value = this.stop_time;
        this.type.SelectedValue = this.cha_type.ToString();
        view_huiyuan bll = new view_huiyuan();
        this.rptList.DataSource = bll.GetList(this.pageSize, this.page, _strWhere, _orderby, out this.totalCount);
        this.rptList.DataBind();

        //绑定页码
        txtPageNum.Text = this.pageSize.ToString();
        string pageUrl = Utils.CombUrlTxt("al_read1.aspx", "start_time={0}&stop_time={1}&huiyuan_jiebie={2}&note_no={3}&page={4}&type={5}", this.start_time.ToString(), this.stop_time.ToString(), this.jiebie.ToString(), this.note_no, "__id__", this.cha_type.ToString());
        PageContent.InnerHtml = Utils.OutPageList(this.pageSize, this.page, this.totalCount, pageUrl, 8);
    }
    #endregion

    #region 组合SQL查询语句==========================
    protected string CombSqlTxt(int _product_category_id, string _note_no, string _start_time, string _stop_time, int cha_type)
    {
        StringBuilder strTemp = new StringBuilder();

        if (_product_category_id > 0)
        {
            strTemp.Append(" and huiyuan_jiebie=" + _product_category_id);
        }

        if (string.IsNullOrEmpty(_start_time))
        {
            _start_time = "1900-01-01";
        }
        if (string.IsNullOrEmpty(_stop_time))
        {
            _stop_time = "2099-01-01";
        }
        strTemp.Append(" and huiyuan_add_time between  '" + DateTime.Parse(_start_time) + "' and '" + DateTime.Parse(_stop_time + " 23:59:59") + "'");

        _note_no = _note_no.Replace("'", "");


        if (!string.IsNullOrEmpty(_note_no))
        {
            if (cha_type == 1)
            {
                strTemp.Append(" and huiyuan_bianhao like  '%" + _note_no + "%' ");
            }

            if (cha_type == 2)
            {
                strTemp.Append(" and huiyuan_name like  '%" + _note_no + "%' ");
            }
        }
        return strTemp.ToString();
    }
    #endregion

    #region 返回每页数量=============================
    private int GetPageSize(int _default_size)
    {
        int _pagesize;
        if (int.TryParse(Utils.GetCookie("al_read1_page_size"), out _pagesize))
        {

            if (_pagesize > 0)
            {
                return _pagesize;
            }
        }
        return _default_size;
    }
    #endregion


    //查询
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        Response.Redirect(Utils.CombUrlTxt("al_read1.aspx", "start_time={0}&stop_time={1}&huiyuan_jiebie={2}&note_no={3}&type={4}", this.txtstart_time.Value, this.txtstop_time.Value, this.ddlproduct_category_id.SelectedValue, txtNote_no.Text, this.type.SelectedValue));
    }

    //筛选会员级别
    protected void ddlproduct_category_id_SelectedIndexChanged(object sender, EventArgs e)
    {
        Response.Redirect(Utils.CombUrlTxt("al_read1.aspx", "start_time={0}&stop_time={1}&huiyuan_jiebie={2}&note_no={3}", this.txtstart_time.Value, this.txtstop_time.Value, this.ddlproduct_category_id.SelectedValue, txtNote_no.Text));

    }

    //设置分页数量
    protected void txtPageNum_TextChanged(object sender, EventArgs e)
    {
        int _pagesize;
        if (int.TryParse(txtPageNum.Text.Trim(), out _pagesize))
        {

            if (_pagesize > 300)
            {
                mym.JscriptMsg(this.Page, "页面设置最大分页数为300数据，请重新输入！", "", "Error");
                return;
            }
            if (_pagesize > 0)
            {
                Utils.WriteCookie("al_read1_page_size", _pagesize.ToString(), 14400);
            }
        }
        Response.Redirect(Utils.CombUrlTxt("al_read1.aspx", "start_time={0}&stop_time={1}&huiyuan_jiebie={2}&note_no={3}&type={4}", this.txtstart_time.Value, this.txtstop_time.Value, this.ddlproduct_category_id.SelectedValue, txtNote_no.Text, this.type.SelectedValue));
    }

  

    // 单个开通
    protected void Open_Click(object sender, EventArgs e)
    {
        // 当前点击的按钮

        this.page = AXRequest.GetQueryInt("page");

        LinkButton lb = (LinkButton)sender;
        string huiyuan_id = lb.CommandArgument.ToString();


        tbl_huiyuan bll = new tbl_huiyuan();
        bll.GetModel_hui_id(huiyuan_id);

        int net_hege = int.Parse(bll.net_hege.ToString());

        if (net_hege == 1)
        {
            mym.JscriptMsg(this.Page, "会员已经开通！请不要重复操作", "", "Error");
            return;
        }


        //bll.net_hege = 1;
        //bll.huiyuan_qr_date = DateTime.Now;

        //tbl_xiaofei xf_bll = new tbl_xiaofei();
        //xf_bll.xiaofei_hui_id = huiyuan_id;
        //xf_bll.xiaofei_qr_flag = 1;
        //xf_bll.xiaofei_qr_date = DateTime.Now;
        int i=DbHelperSQL.ExecuteSql("exec sp_kaitong_huiyuan '" + huiyuan_id + "','A00000000'");
        //tbl_reg_jiebie jb = new tbl_reg_jiebie();
        //jb.GetModeljibie(Convert.ToInt32(bll.huiyuan_jiebie));
        //bll.glf_money = jb.need_money * 5;
        //bll.Update();
        mym.JscriptMsg(this.Page, " 激活成功！", Utils.CombUrlTxt("al_read1.aspx", "start_time={0}&stop_time={1}&huiyuan_jiebie={2}&note_no={3}&type={4}&page={5}", this.txtstart_time.Value, this.txtstop_time.Value, this.ddlproduct_category_id.SelectedValue, txtNote_no.Text, this.type.SelectedValue, this.page.ToString()), "Success");

      




    }
    // 单个空单开通
    protected void kd_kaitong(object sender, EventArgs e)
    {
        // 当前点击的按钮

        this.page = AXRequest.GetQueryInt("page");

        LinkButton lb = (LinkButton)sender;
        string huiyuan_id = lb.CommandArgument.ToString();


        tbl_huiyuan bll = new tbl_huiyuan();
        bll.GetModel_hui_id(huiyuan_id);

        int net_hege = int.Parse(bll.net_hege.ToString());

        if (net_hege == 1)
        {
            mym.JscriptMsg(this.Page, "会员已经开通！请不要重复操作", "", "Error");
            return;
        }

        bll.net_hege = 1;
        bll.kd_flag = 1;
        bll.huiyuan_qr_date = DateTime.Now;
        bll.Update();
       

        //tbl_orders orders = new tbl_orders();
        //orders.user_id = huiyuan_id;
        //orders.Delete_orders(huiyuan_id);

        //tbl_xiaofei xf_bll = new tbl_xiaofei();
        //xf_bll.xiaofei_hui_id = huiyuan_id;
        //xf_bll.Delete_xiaofei_hui_id(huiyuan_id);
        int i = DbHelperSQL.ExecuteSql("exec sp_kongdan_huiyuan '" + huiyuan_id + "'");

       
        mym.JscriptMsg(this.Page, " 激活成功！", Utils.CombUrlTxt("al_read1.aspx", "start_time={0}&stop_time={1}&huiyuan_jiebie={2}&note_no={3}&type={4}&page={5}", this.txtstart_time.Value, this.txtstop_time.Value, this.ddlproduct_category_id.SelectedValue, txtNote_no.Text, this.type.SelectedValue, this.page.ToString()), "Success");

      




    }
    
    // 单个删除
    protected void delete_Click1(object sender, EventArgs e)
    {
        // 当前点击的按钮

        this.page = AXRequest.GetQueryInt("page");

        LinkButton lb = (LinkButton)sender;
        string huiyuan_id = lb.CommandArgument.ToString();

         
        tbl_huiyuan bll = new tbl_huiyuan();
        if (!bll.show_is_jd(huiyuan_id) || !bll.show_is_tj(huiyuan_id))
        {

            mym.JscriptMsg(this.Page, "不能删除！下面已有消费者注册", "", "Error");
            return;
        
        }
        bll.GetModel_hui_id(huiyuan_id);
        bll.huiyuan_id = huiyuan_id;

      


        bll.Delete(huiyuan_id);//触发器删除

        tbl_shangshu ssbll = new tbl_shangshu();
        ssbll.huiyuan_id = huiyuan_id;

        ssbll.Delete(huiyuan_id);


        tbl_shangshu2 ss2bll = new tbl_shangshu2();
        ss2bll.huiyuan_id = huiyuan_id;

        ss2bll.Delete(huiyuan_id);

        tbl_xiaofei xfbll = new tbl_xiaofei();

        xfbll.xiaofei_hui_id = huiyuan_id;

        xfbll.Delete_xiaofei_hui_id(huiyuan_id);
        tbl_orders  orders = new tbl_orders();
        orders.user_id = huiyuan_id;
        orders.Delete_orders(huiyuan_id);

        mym.JscriptMsg(this.Page, " 删除成功！", Utils.CombUrlTxt("al_read1.aspx", "start_time={0}&stop_time={1}&huiyuan_jiebie={2}&note_no={3}&type={4}&page={5}", this.txtstart_time.Value, this.txtstop_time.Value, this.ddlproduct_category_id.SelectedValue, txtNote_no.Text, this.type.SelectedValue, this.page.ToString()), "Success");


    }

    public string getweizhi(string zuoyou)
    {
        string str = "";
        if (int.Parse(zuoyou) == 1)
        {
            str = "左区";
        }
        if (int.Parse(zuoyou) == 2)
        {
            str = "右区";
        }
        //if (int.Parse(zuoyou) == 3)
        //{
        //    str = "C区";
        //}
        return str;
    }
}