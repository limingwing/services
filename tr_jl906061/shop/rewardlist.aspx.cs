using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class shop_rewardlist : System.Web.UI.Page
{
    protected int totalCount;
    protected int page;
    protected int pageSize;

    protected void Page_Load(object sender, EventArgs e)
    {
        this.pageSize = GetPageSize(10); //每页数量
        if (!Page.IsPostBack)
        {
            if (Session["hy_id1"] == null)
            {
                Response.Write("<script language=javascript>alert('请重新登录！');top.location.href='login.aspx';</script>");
                Response.End();

            }
            RptBind("cha_hui_id='" + Session["hy_id1"]+"'", "cha_date desc");

        }
    }
         #region 数据绑定=================================
    private void RptBind(string _strWhere, string _orderby)
    {
        this.page = AXRequest.GetQueryInt("page", 1);

        tbl_cha bll = new tbl_cha();
        this.rptList.DataSource = bll.GetList(this.pageSize, this.page, _strWhere, _orderby, out this.totalCount);
        this.rptList.DataBind();
        //this.Literal1.Text = MyConvert(Convert.ToDecimal(bll.GetTitleSum(_strWhere, "sum(cha_002)")));
        //this.Literal2.Text = MyConvert(Convert.ToDecimal(bll.GetTitleSum(_strWhere, "sum(cha_003)")));
        //this.Literal3.Text = MyConvert(Convert.ToDecimal(bll.GetTitleSum(_strWhere, "sum(cha_014)")));
        //绑定页码
        //txtPageNum.Text = this.pageSize.ToString();
        string pageUrl = Utils.CombUrlTxt("rewardlist.aspx","page={0}", "__id__");
        PageContent.InnerHtml = Utils.OutPageList(this.pageSize, this.page, this.totalCount, pageUrl, 8);
    }
    #endregion

    #region 返回每页数量=============================
    private int GetPageSize(int _default_size)
    {
        int _pagesize;
        if (int.TryParse("10", out _pagesize))
        {

            if (_pagesize > 0)
            {
                return _pagesize;
            }
        }
        return _default_size;
    }
    #endregion

    ////设置分页数量
    //protected void txtPageNum_TextChanged(object sender, EventArgs e)
    //{
    //    int _pagesize;
    //    if (int.TryParse("10", out _pagesize))
    //    {

    //        if (_pagesize > 300)
    //        {
    //            Response.Write("<script language=javascript>alert('页面设置最大分页数为300数据，请重新输入！');top.location.href='rewardlist.aspx';</script>");
    //            Response.End();
    //        }
    //        if (_pagesize > 0)
    //        {
    //            Utils.WriteCookie("jiangjin_page_size", _pagesize.ToString(), 14400);
    //        }
    //    }
    //    Response.Redirect(Utils.CombUrlTxt("rewardlist.aspx", ""));
    //}

    //负数红色显示
    public string MyZF(object d)
    {
        string myNum = d.ToString();
        if (Convert.ToInt32(d.ToString()) <= 0)
        {
            myNum = "<font color=red> " + d.ToString() + "</font>";
        }
        return myNum;
    }

    //小数位是0的不显示
    public string MyConvert(object d)
    {
        string myNum = d.ToString();
        string[] strs = d.ToString().Split('.');
        if (strs.Length > 1)
        {
            if (Convert.ToInt32(strs[1]) == 0)
            {
                myNum = strs[0];
            }
        }
        return myNum;
    }

    //小数位是0的不显示
    public string money_Convert(string money)
    {
        decimal num = decimal.Parse(money);
        string s4 = "";
        s4 = num.ToString().Substring(0, num.ToString().IndexOf('.') + 3);
        decimal num1 = Convert.ToDecimal(s4);
        return num1.ToString();
    }
}
