using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;
public partial class shop_search2 : System.Web.UI.Page
{
    protected int pro_pid;//产品分类
    protected int totalCount;//分页
    protected int page;     //分页
    protected int pageSize;     //分页
    protected int pro_id;
    protected string pro_name;
    protected int province;
    protected int city;
    protected int district;
    protected void Page_Load(object sender, EventArgs e)
    {
        this.pageSize = GetPageSize(12); //每页数量
        this.pro_pid = AXRequest.GetQueryInt("pro_pid");
        this.pro_name = AXRequest.GetQueryString("pro_name");
        if (!Page.IsPostBack)
        {
            hot_pro_bind();
            RptBind("1=1 and pro_isok=1 and pro_type=0" + CombSqlTxt(this.pro_pid, this.pro_name.ToString()), "pro_id desc,pro_date desc");//绑定喜欢产品
        }


    }

    #region 数据绑定=================================
    private void RptBind(string _strWhere, string _orderby)
    {
        this.page = AXRequest.GetQueryInt("page", 1);



        tbl_product bll = new tbl_product();
        this.rptList.DataSource = bll.GetList(this.pageSize, this.page, _strWhere, _orderby, out this.totalCount);
        this.rptList.DataBind();

        //绑定页码
        //txtPageNum.Text = this.pageSize.ToString();
        string pageUrl = Utils.CombUrlTxt("search2.aspx", "page={0}&pro_pid={1}&pro_name={2}", "__id__", this.pro_pid.ToString(), this.pro_name.ToString());
        PageContent.InnerHtml = Utils.OutPageList(this.pageSize, this.page, this.totalCount, pageUrl, 8);
    }
    #endregion
    #region 返回每页数量=============================
    private int GetPageSize(int _default_size)
    {
        int _pagesize;
        if (int.TryParse(Utils.GetCookie("jiangjin_page_size"), out _pagesize))
        {

            if (_pagesize > 0)
            {
                return _pagesize;
            }
        }
        return _default_size;
    }
    #endregion

    #region 组合SQL查询语句==========================
    protected string CombSqlTxt(int _pro_pid, string _pro_name)
    {
        StringBuilder strTemp = new StringBuilder();

        if (_pro_pid > 0)
        {
            strTemp.Append(" and pro_pid=" + _pro_pid);
        }
        if (_pro_name != "")
        {
            strTemp.Append(" and pro_name like '%" + _pro_name + "%' or ProName like '%" + _pro_name + "%' or CityName like '%" + _pro_name + "%' or DisName like '%" + _pro_name + "%'");
        }


        return strTemp.ToString();
    }
    #endregion

    #region 绑定新品上市=================================
    private void hot_pro_bind()
    {





        tbl_product bll = new tbl_product();
        this.hot_pro.DataSource = bll.GetList_top_1(" pro_isok=1 and pro_hot=1   order by NEWID()", 3);
        this.hot_pro.DataBind();



    }
    #endregion


}