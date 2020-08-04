using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;

public partial class shop_al_read : System.Web.UI.Page
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
        this.jiebie = AXRequest.GetQueryInt("huiyuan_jiebie");
        this.pageSize = GetPageSize(3); //每页数量
        if (!Page.IsPostBack)
        {
            if (Session["hy_id1"] == null)
            {
                Response.Write("<script language=javascript>alert('请重新登录！');top.location.href='login.aspx';</script>");
                Response.End();

            }
            RptBind("huiyuan_shang_id='" + Session["hy_id1"] + "'   " + CombSqlTxt(this.jiebie, this.note_no, this.start_time, this.stop_time, this.cha_type), "huiyuan_add_time desc");


        }
    }

    #region 数据绑定=================================
    private void RptBind(string _strWhere, string _orderby)
    {
        this.page = AXRequest.GetQueryInt("page", 1);

        view_huiyuan bll = new view_huiyuan();
        this.rptList.DataSource = bll.GetList(this.pageSize, this.page, _strWhere, _orderby, out this.totalCount);
        this.rptList.DataBind();

        //绑定页码
        //txtPageNum.Text = this.pageSize.ToString();
        string pageUrl = Utils.CombUrlTxt("al_read.aspx", "page={0}", "__id__");
        PageContent.InnerHtml = Utils.OutPageList(this.pageSize, this.page, this.totalCount, pageUrl, 8);
    }
    #endregion

    #region 组合SQL查询语句==========================
    protected string CombSqlTxt(int _product_category_id, string _note_no, string _start_time, string _stop_time, int cha_type)
    {
        StringBuilder strTemp = new StringBuilder();

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
        if (int.TryParse(Utils.GetCookie("al_readxxx_page_size"), out _pagesize))
        {

            if (_pagesize > 0)
            {
                return _pagesize;
            }
        }
        return _default_size;
    }
    #endregion


    ////查询
    //protected void btnSubmit_Click(object sender, EventArgs e)
    //{
    //    Response.Redirect(Utils.CombUrlTxt("al_read.aspx", ""));
    //}



    //设置分页数量
    protected void txtPageNum_TextChanged(object sender, EventArgs e)
    {
        int _pagesize;
        if (int.TryParse("3", out _pagesize))
        {

            if (_pagesize > 300)
            {
                mym.JscriptMsg(this.Page, "页面设置最大分页数为300数据，请重新输入！", "", "Error");
                return;
            }
            if (_pagesize > 0)
            {
                Utils.WriteCookie("al_readxxx_page_size", _pagesize.ToString(), 14400);
            }
        }
        Response.Redirect(Utils.CombUrlTxt("al_read.aspx", ""));
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
            Response.Write("<script language=javascript>alert('此会员已确认，请不要重复确认！');location.href='al_read.aspx';</script>");
            return;
        }
        tbl_xiaofei xf_bll = new tbl_xiaofei();

        xf_bll.GetModel(huiyuan_id);


        decimal xiaofei_money = decimal.Parse(xf_bll.xiaofei_money.ToString());

        bll.GetModel_hui_id(Session["hy_id1"].ToString());

        decimal now_zm_jiangjin = decimal.Parse((bll.fh_money).ToString());


        if (xiaofei_money > now_zm_jiangjin)
        {
            Response.Write("<script language=javascript>alert('分享积分不足！');location.href='al_read.aspx';</script>");
            return;


        }
        bll.fh_money -= xiaofei_money;
        bll.Update();
        int i = DbHelperSQL.ExecuteSql("exec sp_kaitong_huiyuan '" + huiyuan_id + "','A00000000'");


        Response.Write("<script language=javascript>alert('激活成功！');location.href='al_read.aspx';</script>");
        return;






    }
    // 单个开通
    protected void Open_Click1(object sender, EventArgs e)
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
            Response.Write("<script language=javascript>alert('此会员已确认，请不要重复确认！');location.href='al_read.aspx';</script>");
            return;
        }
        tbl_xiaofei xf_bll = new tbl_xiaofei();

        xf_bll.GetModel(huiyuan_id);


        decimal xiaofei_money = decimal.Parse(xf_bll.xiaofei_money.ToString());

        tbl_huiyuan bll_h = new tbl_huiyuan();
        bll_h.GetModel_hui_id(Session["hy_id1"].ToString());

        decimal now_zm_jiangjin = decimal.Parse((bll_h.glf_money).ToString());


        if (xiaofei_money > now_zm_jiangjin)
        {
            Response.Write("<script language=javascript>alert('积分不足！');location.href='al_read.aspx';</script>");
            return;


        }
        bll_h.glf_money -= xiaofei_money;
        bll_h.Update();
        //bll.net_hege = 1;
        //bll.huiyuan_qr_date = DateTime.Now;

        //tbl_xiaofei xf_bll = new tbl_xiaofei();
        //xf_bll.xiaofei_hui_id = huiyuan_id;
        //xf_bll.xiaofei_qr_flag = 1;
        //xf_bll.xiaofei_qr_date=DateTime.Now;
        int i = DbHelperSQL.ExecuteSql("exec sp_kaitong_huiyuan '" + huiyuan_id + "','A00000000'");

        decimal moneyafter = now_zm_jiangjin - xiaofei_money;//改变后余额
        string memo = "推荐人开通会员" + bll.huiyuan_bianhao + "扣费" + xiaofei_money + "元积分";
        mym.queren_insert(Session["hy_id1"].ToString(), Session["hy_bianhao1"].ToString(), "积分", memo, -xiaofei_money, moneyafter);

        Response.Write("<script language=javascript>alert('激活成功！');location.href='al_read.aspx';</script>");

        return;






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

            Response.Write("<script language=javascript>alert('不能删除！');location.href='al_read.aspx';</script>");
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

        Response.Write("<script language=javascript>alert('删除成功！');location.href='al_read.aspx';</script>");
        return;


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