using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class shop_sell : A_BasePage
{
    tbl_huiyuan blt = new tbl_huiyuan();
    ManagePage mym = new ManagePage();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["hy_id1"] == null)
        {
            Response.Write("<script language=javascript>alert('请重新登录！');top.location.href='login.aspx';</script>");
            Response.End();

        }
        tbl_huiyuan model = new tbl_huiyuan();
        model.GetModel_hui_id(Session["hy_id1"].ToString());
        this.Literal1.Text = double.Parse(model.fh_money.ToString()).ToString("0.00") + "（日交易5%）";
        //this.Literal2.Text = double.Parse((model.jiangjin_zong - model.jiangjin_yong).ToString()).ToString();
        if (!Page.IsPostBack)
        {
            //QDBind();
            //RptBind();
            tbl_canshu can = new tbl_canshu();
            can.GetModel(1);
            this.dangqian.Value = double.Parse(can.canshu_060.ToString()).ToString("0.00");
            if (model.flag_5 == 1)
            {
                this.buy_amount.Value = "0.00";
            }
            else
            {
                this.buy_amount.Value = (Convert.ToDecimal(model.fh_money.ToString()) * 0.05m).ToString("0.00");
            }
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {

        string sPassWord = this.pass_two.Value.Trim();
        if (!tbl_huiyuan.Exists_erji(hy_bianhao1, sPassWord))
        {
            Response.Write("<script language=javascript>alert('二级密码不正确！');location.href='sell.aspx';</script>");
            return;

        }

        decimal money;

        try
        {
            money = Convert.ToDecimal(this.buy_amount.Value.Trim());
        }
        catch
        {
            Response.Write("<script language=javascript>alert('输入数量有误！');location.href='sell.aspx';</script>");
            return;


        }

        if (money < 0)
        {
            Response.Write("<script language=javascript>alert('输入数量必须大于0！');location.href='sell.aspx';</script>");
            return;

        }

        blt.GetModel_hui_id(hy_id1);
        decimal nowMoney = decimal.Parse((blt.fh_money).ToString());

        int zz_type = 0;





        decimal jiage = decimal.Parse(this.buy_price.Value.ToString());
        string xiaofeimoney = DbHelperSQL.GetDataRow("select  'aa'=count(*) from tbl_gp_sell where sell_id='" + Session["hy_id1"].ToString() + "' and sell_danjia=" + jiage)["aa"].ToString();// and flag_1=" + blt.chaifen_cishu + "
        int shuliang = int.Parse(xiaofeimoney);
        if (shuliang > 0)
        {
            Response.Write("<script language=javascript>alert('当前价格已卖出，请等待涨价！');location.href='sell.aspx';</script>");
            return;
        }
        tbl_canshu tbl_c = new tbl_canshu();
        tbl_c.GetModel(1);
        if (jiage <= tbl_c.canshu_060)
        {
            Response.Write("<script language=javascript>alert('输入股价大于当前股价！');location.href='sell.aspx';</script>");
            return;
        }
        //if (jiage < tbl_c.canshu_031)
        //{
        //    Response.Write("<script language=javascript>alert('输入股价不再可卖出范围内！');location.href='sell.aspx';</script>");
        //    return;
        //}
        //if (jiage > tbl_c.canshu_032)
        //{
        //    Response.Write("<script language=javascript>alert('输入股价不再可卖出范围内！');location.href='sell.aspx';</script>");
        //    return;
        //}
        if (nowMoney * 1m >= money)
        {

            blt.huiyuan_id = hy_id1;
            blt.fh_money -= money;
            blt.flag_5 = 1;
            blt.Update();
        }
        //else
        //{
        //    Response.Write("<script language=javascript>alert('可卖出当前分享积分数量的8%！');location.href='sell.aspx';</script>");
        //    return;
        //}
        tbl_gp_sell gp_sell = new tbl_gp_sell();
        gp_sell.sell_id = hy_id1;
        gp_sell.sell_date = DateTime.Now;
        gp_sell.sell_danjia = jiage;
        gp_sell.sell_yu = money;
        gp_sell.sell_zong = money * jiage;
        gp_sell.sell_gu = money;
        //gp_sell.flag_1 = blt.chaifen_cishu;
        gp_sell.flag = 0;
        int id = gp_sell.Add();
        if (id > 0)
        {

            DbHelperSQL.ExecuteSql("exec gp_pipei '" + id + "',2");
            Response.Write("<script language=javascript>alert('提交成功！');location.href='sell.aspx';</script>");
            return;
        }


    }
}