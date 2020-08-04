using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class shop_buy : A_BasePage
{
    protected int totalCount;
    protected int page;
    protected int pageSize;
    tbl_huiyuan blt = new tbl_huiyuan();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (Session["hy_id1"] == null)
            {
                Response.Write("<script language=javascript>alert('请重新登录！');top.location.href='login.aspx';</script>");
                Response.End();

            }
            tbl_huiyuan model = new tbl_huiyuan();
            model.GetModel_hui_id(Session["hy_id1"].ToString());
            this.Literal1.Text = double.Parse(model.chongfu_zong.ToString()).ToString();

        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        tbl_canshu model = new tbl_canshu();

        model.GetModel(1);

        decimal gupiao = decimal.Parse(model.canshu_060.ToString());
        string sPassWord = this.pass_two.Value.Trim();
        if (!tbl_huiyuan.Exists_erji(hy_bianhao1, sPassWord))
        {
            Response.Write("<script language=javascript>alert('二级密码不正确！');location.href='buy.aspx';</script>");
            return;

        }

        decimal money;

        try
        {
            money = Convert.ToDecimal(this.buy_amount.Value.Trim());
        }
        catch
        {
            Response.Write("<script language=javascript>alert('输入金额有误！');location.href='buy.aspx';</script>");
            return;


        }

        if (money < 0)
        {
            Response.Write("<script language=javascript>alert('输入金额必须大于0！');location.href='buy.aspx';</script>");
            return;

        }

        //if (money < 100)
        //{
        //    Response.Write("<script language=javascript>alert('输入金额必须大于100！');location.href='withdraw.aspx';</script>");
        //    return;

        //}

        //if (money % 100 != 0)
        //{
        //    Response.Write("<script language=javascript>alert('输入金额必须100的整数倍！');location.href='withdraw.aspx';</script>");
        //    return;

        //}

        blt.GetModel_hui_id(hy_id1);
        decimal nowMoney = decimal.Parse((blt.chongfu_zong).ToString());

        int zz_type = 0;


        if (nowMoney < money)
        {
            Response.Write("<script language=javascript>alert('奖励积分余额不足！');location.href='buy.aspx';</script>");
            return;
        }

        tbl_gp_buy gp_buy = new tbl_gp_buy();
        gp_buy.buy_id = hy_id1;
        gp_buy.buy_date = DateTime.Now;
        gp_buy.buy_yu = money;
        gp_buy.buy_zong = money;
        gp_buy.buy_gu = 0;
        gp_buy.flag = 0;

        int id = gp_buy.Add();
        if (id > 0)
        {

            //decimal moneyafter1 = nowMoney - money;//改变后余额

            //string memo = "玩家" + hy_bianhao1 + "提现" + money + "元";
            //mym.queren_insert(hy_id1, hy_bianhao1, "奖励积分积分提现", memo, -money, moneyafter1, 1);
            blt.huiyuan_id = hy_id1;
            blt.chongfu_zong -= money;
            //blt.chongfu_kechu +=decimal.Round( money / gupiao,0);
            blt.Update();
            DbHelperSQL.ExecuteSql("exec gp_pipei '" + id + "',1");
            //DbHelperSQL.ExecuteSql("exec sp_gp_price '" + decimal.Round(money / gupiao, 0) + "'");
            Response.Write("<script language=javascript>alert('提交成功！');location.href='buy.aspx';</script>");
            return;
        }


    }
}