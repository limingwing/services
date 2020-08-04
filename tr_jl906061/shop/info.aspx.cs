using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class shop_info : A_BasePage
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
            RptBind(" 1=1 and buy_id='" + Session["hy_id1"] + "'", "id desc");

        }
    }
    #region 数据绑定=================================
    private void RptBind(string _strWhere, string _orderby)
    {
        this.page = AXRequest.GetQueryInt("page", 1);

        tbl_gp_list bll = new tbl_gp_list();
        this.rptList.DataSource = bll.GetList(this.pageSize, this.page, _strWhere, _orderby, out this.totalCount);
        this.rptList.DataBind();
        //绑定页码
        //txtPageNum.Text = this.pageSize.ToString();
        string pageUrl = Utils.CombUrlTxt("info.aspx", "page={0}", "__id__");
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

    protected string GetOrderStatus(int _id)
    {
        string _title = string.Empty;

        switch (_id)
        {
            case 1:
                _title = "卖出股币";
                break;
            case 2:
                _title = "买入股币";
                break;

        }

        return _title;
    }
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
    public string getname(string bianhao)
    {
        tbl_huiyuan model = new tbl_huiyuan();
        model.GetModel_hui_id(bianhao);
        return model.huiyuan_name;
    }
    public string getlei(string lei)
    {
        string leixin = "";
        switch (lei)
        {
            case "001":
                leixin = "分享积分收益";
                break;
            case "002":
                leixin = "动态推广奖";
                break;
            //case "003":
            //    leixin = "饲料收益";
            //    break;
            //case "014":
            //    leixin = "分享积分";
            //    break;
            //case "004":
            //    leixin = "消费佣金";
            //    break;
            default:
                leixin = "Unknown";
                break;
        }
        return leixin;
    }
}