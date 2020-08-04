using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class shop_deposit : A_BasePage
{
    protected int totalCount;
    protected int page;
    protected int pageSize;
    ManagePage mym = new ManagePage();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["hy_id1"] == null)
        {
            Response.Write("<script language=javascript>alert('请重新登录！');top.location.href='login.aspx';</script>");
            Response.End();

        }
        if (!Page.IsPostBack)
        {
            RptBind(" 1=1 ", "id desc");
        }
    }
    #region 数据绑定=================================
    private void RptBind(string _strWhere, string _orderby)
    {
        this.page = AXRequest.GetQueryInt("page", 1);



        tbl_bank bll = new tbl_bank();
        this.rptList.DataSource = bll.GetList(this.pageSize, this.page, _strWhere, _orderby, out this.totalCount);
        this.rptList.DataBind();


        //绑定页码
        //txtPageNum.Text = this.pageSize.ToString();
        //string pageUrl = Utils.CombUrlTxt("tikuan_jl.aspx", "page={0}", "__id__");
        //PageContent.InnerHtml = Utils.OutPageList(this.pageSize, this.page, this.totalCount, pageUrl, 8);
    }
    #endregion
    protected void btnSubmit_Click1(object sender, EventArgs e)
    {
        tbl_huiyuan model1 = new tbl_huiyuan();
        model1.GetModel_hui_id(hy_id1);
        string sPassWord = this.pass_two.Value.Trim();
        if (!tbl_huiyuan.Exists_erji(hy_bianhao1, sPassWord))
        {
            Response.Write("<script language=javascript>alert('二级密码不正确！');location.href='deposit.aspx';</script>");
            return;

        }

        decimal money;

        try
        {
            money = Convert.ToDecimal(this.money.Value.Trim());
        }
        catch
        {
            Response.Write("<script language=javascript>alert('输入金额有误！');location.href='deposit.aspx';</script>");
            return;


        }

        if (money < 0)
        {
            Response.Write("<script language=javascript>alert('输入金额必须大于0！');location.href='deposit.aspx';</script>");
            return;

        }

        if (money < 100)
        {
            Response.Write("<script language=javascript>alert('输入金额必须大于100！');location.href='deposit.aspx';</script>");
            return;

        }
        if (this.accountbank.Value.Trim() == "" || this.accountname.Value.Trim() == "" || this.accountno.Value.Trim() == "")
        {
            Response.Write("<script language=javascript>alert('开户名、开户银行开户账户未填写，无法提交！');history.go(-1);</script>");
            return;
        }

        int zz_type = int.Parse(this.zz_type.SelectedValue);
        if (zz_type == 1)
        {
            tbl_huikuan model_hk = new tbl_huikuan();
            model_hk.accountbank = this.accountbank.Value.Trim();
            model_hk.accountno = this.accountno.Value.Trim();
            model_hk.accountname = this.accountname.Value.Trim();
            model_hk.accounttype = "1";
            model_hk.money = money.ToString();
            model_hk.memo = beizhu.Value.Trim();
            model_hk.huiyuan_id = hy_id1;
            model_hk.huiyuan_bianhao = hy_bianhao1;
            model_hk.huiyuan_name = model1.huiyuan_name;
            model_hk.huikuan_status = 0;
            model_hk.hk_sq_time = DateTime.Now;

            if (model_hk.Add() > 0)
            {
                Response.Write("<script language=javascript>alert('提交成功！');location.href='deposit.aspx';</script>");
                return;
            }
        }
    }
}