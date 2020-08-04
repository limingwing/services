using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;
public partial class shop_search : System.Web.UI.Page
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
        this.province = AXRequest.GetQueryInt("province");
        this.city = AXRequest.GetQueryInt("city");
        this.district = AXRequest.GetQueryInt("district");
        if (!Page.IsPostBack)
        {
            hot_pro_bind();
            RptBind("1=1 and pro_isok=1" + CombSqlTxt(this.pro_pid, this.pro_name.ToString(), this.province, this.city, this.district), "pro_id desc,pro_date desc");//绑定喜欢产品

            string liclearstr = null;

            string provincestr = null;
            T_Province bll = new T_Province();
            DataTable dt = bll.GetList("1=1 order by ProSort").Tables[0];
            
            T_District blld = new T_District();
            blld.GetModel(this.district);

            if (this.district > 0)
                this.city = blld.CityID;

            T_City bllc = new T_City();
            bllc.GetModel(this.city);

            
            if (this.province > 0 || bllc.ProID > 0)
                provincestr += "<dd class='select-all'><a href='/shop/search.aspx?province=0'>全部</a></dd>";
            else
                provincestr += "<dd class='select-all selected'><a href='/shop/search.aspx?province=0'>全部</a></dd>";
            foreach (DataRow item in dt.Rows)
            {
                if (this.province == int.Parse(item["ProID"].ToString()) || bllc.ProID == int.Parse(item["ProID"].ToString()))
                {
                    provincestr += "<dd class='selected'><a href='/shop/search.aspx?province=" + item["ProID"] + "'>" + item["ProName"] + "</a></dd>";
                    liclearstr += "<dd class='selected' id='selectA'><a href='#'>" + item["ProName"] + "</a></dd>";
                }
                else
                    provincestr += "<dd><a href='/shop/search.aspx?province=" + item["ProID"] + "'>" + item["ProName"] + "</a></dd>";
            }


            string citystr = null;
            DataTable dtc = bllc.GetList("1=1 and ProID='" + this.province + "' order by CitySort").Tables[0];
            if (bllc.ProID > 0)
                dtc = bllc.GetList("1=1 and ProID='" + bllc.ProID + "' order by CitySort").Tables[0];
            if (this.city > 0 || blld.CityID>0)
                citystr += "<dd class='select-all'><a href='/shop/search.aspx?city=0'>全部</a></dd>";
            else
                citystr += "<dd class='select-all selected'><a href='/shop/search.aspx?city=0'>全部</a></dd>";
            foreach (DataRow item in dtc.Rows)
            {
                if (this.city == int.Parse(item["CityID"].ToString()) || blld.CityID == int.Parse(item["CityID"].ToString()))
                {
                    citystr += "<dd class='selected'><a href='/shop/search.aspx?city=" + item["CityID"] + "'>" + item["CityName"] + "</a></dd>";
                    liclearstr += "<dd class='selected' id='selectB'><a href='#'>" + item["CityName"] + "</a></dd>";
                }
                else
                    citystr += "<dd><a href='/shop/search.aspx?city=" + item["CityID"] + "'>" + item["CityName"] + "</a></dd>";
            }

            string areastr = null;
            DataTable dtd = blld.GetList("1=1 and CityID='" + this.city + "' order by DisSort").Tables[0];
            if (blld.CityID > 0)
                dtd = blld.GetList("1=1 and CityID='" + blld.CityID + "' order by DisSort").Tables[0];
             if (this.district>0)
                 areastr = "<dd class='select-all'><a href='/shop/search.aspx?district=0'>全部</a></dd>";
             else
                 areastr = "<dd class='select-all selected'><a href='/shop/search.aspx?district=0'>全部</a></dd>";
             foreach (DataRow item in dtd.Rows)
             {
                 if (this.district == int.Parse(item["Id"].ToString()))
                 {
                     areastr += "<dd class='selected'><a href='/shop/search.aspx?district=" + item["Id"] + "'>" + item["DisName"] + "</a></dd>";
                     liclearstr += "<dd class='selected' id='selectC'><a href='#'>" + item["DisName"] + "</a></dd>";
                 }
                 else
                     areastr += "<dd><a href='/shop/search.aspx?district=" + item["Id"] + "'>" + item["DisName"] + "</a></dd>";
             }

            this.divProvince.InnerHtml = provincestr;
            this.divCity.InnerHtml = citystr;
            this.divArea.InnerHtml = areastr;
            if (!string.IsNullOrEmpty(liclearstr))
            {
                this.liclear.InnerHtml = "<dl><dt>已选</dt><dd class='select-no' style='display: none;'></dd><p class='eliminateCriteria' style='display: block;' onclick='Clearc()'>清除</p>" + liclearstr + "</dl>";
                this.liclear.Style.Add("display", "list-item;");
            }
        }


    }

    #region 数据绑定=================================
    private void RptBind(string _strWhere, string _orderby)
    {
        this.page = AXRequest.GetQueryInt("page", 1);



        tbl_product bll = new tbl_product();
        this.rptList.DataSource = bll.GetList(this.pageSize, this.page, _strWhere, _orderby, out this.totalCount);
        this.rptList.DataBind();

        this.searchName.InnerText = this.pro_name;
        this.searchNum.InnerText = this.totalCount.ToString();
        //绑定页码
        //txtPageNum.Text = this.pageSize.ToString();
        string pageUrl = Utils.CombUrlTxt("search.aspx", "page={0}&pro_pid={1}&pro_name={2}", "__id__", this.pro_pid.ToString(), this.pro_name.ToString());
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
    protected string CombSqlTxt(int _pro_pid, string _pro_name, int _province, int _city, int _district)
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

        if (_province > 0)
        {
            strTemp.Append(" and province_id=" + _province);
        }
        if (_city > 0)
        {
            strTemp.Append(" and city_id=" + _city);
        }

        if (_district > 0)
        {
            strTemp.Append(" and dictrict_id=" + _district);
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