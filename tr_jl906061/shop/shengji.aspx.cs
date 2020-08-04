using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class shop_shengji : A_BasePage
{
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
        this.Literal1.Text = double.Parse(model.chongfu_zong.ToString()).ToString();
        //this.Literal2.Text = double.Parse((model.jiangjin_zong - model.jiangjin_yong).ToString()).ToString();
        if (!Page.IsPostBack)
        {
            QDBind();
            RptBind();
        }
    }
    #region 数据绑定=================================
    private void RptBind()
    {
        //tbl_product bll = new tbl_product();
        //this.rptList.DataSource = bll.GetList(" flag=0 and pro_isok=1 order by salse_price asc");
        //this.rptList.DataBind();
    }
    #endregion
    #region 绑定级别=================================
    private void QDBind()
    {
        tbl_reg_jiebie bll = new tbl_reg_jiebie();
        DataTable dt = bll.GetList("1=1 and show_flag=1 order by sort_id").Tables[0];
        this.huiyuan_jiebie.Items.Clear();
        this.huiyuan_jiebie.Items.Add(new ListItem("请选择会员级别...", ""));
        foreach (DataRow dr in dt.Rows)
        {
            string Id = dr["jiebie_value"].ToString();
            string Title = dr["jiebie_name"].ToString().Trim() + Math.Floor(double.Parse(dr["need_money"].ToString())) + "元";
            this.huiyuan_jiebie.Items.Add(new ListItem(Title, Id));
        }
    }
    #endregion
    protected void btnSubmit_Click1(object sender, EventArgs e)
    {
        string huiyuan_id = Session["hy_id1"].ToString();
        string sPassWord = this.pass_two.Value.Trim();
        if (!tbl_huiyuan.Exists_erji(hy_bianhao1, sPassWord))
        {
            Response.Write("<script language=javascript>alert('二级密码不正确！');location.href='shengji.aspx';</script>");
            return;

        }
        tbl_huiyuan huiyuanmodel = new tbl_huiyuan();
        huiyuanmodel.GetModel_hui_id(huiyuan_id);
        int type = int.Parse(this.zz_type.SelectedValue.ToString());
        DateTime time = Convert.ToDateTime(huiyuanmodel.huiyuan_qr_date.ToString());
        TimeSpan ts = time - DateTime.Now;
        if(type==1)
        {
            if (ts.Days <= 60)
            {
                tbl_reg_jiebie jb = new tbl_reg_jiebie();
                decimal yuan_money = jb.Get_Need_money(int.Parse(huiyuanmodel.huiyuan_jiebie.ToString()));
                decimal need_money = jb.Get_Need_money(int.Parse(this.huiyuan_jiebie.SelectedValue));
                decimal bu_money = need_money - yuan_money;

                decimal sum_zong = 0, sum_pv = 0;

                int yuan_jb = int.Parse(huiyuanmodel.huiyuan_jiebie.ToString());
                int new_jb = int.Parse(this.huiyuan_jiebie.SelectedValue);
                if (new_jb <= yuan_jb)
                {
                    Response.Write("<script language=javascript>alert('不能小于原有级别！');location.href='shengji.aspx';</script>");
                    return;
                }
                decimal nowMoney = decimal.Parse(huiyuanmodel.chongfu_zong.ToString());
                if (nowMoney >= bu_money)
                {

                    huiyuanmodel.huiyuan_id = hy_id1;
                    huiyuanmodel.huiyuan_jiebie = int.Parse(this.huiyuan_jiebie.SelectedValue);
                    huiyuanmodel.chongfu_zong -= bu_money;
                    huiyuanmodel.Update();
                }
                else
                {
                    Response.Write("<script language=javascript>alert('奖励积分不足！');location.href='shengji.aspx';</script>");
                    return;
                }

                tbl_xiaofei model_xf = new tbl_xiaofei();
                model_xf.xiaofei_hui_id = huiyuan_id;
                model_xf.xiaofei_money = bu_money;
                model_xf.xiaofei_money1 = sum_zong;
                model_xf.zhuce_flag = 2;
                model_xf.xiaofei_qr_date = DateTime.Now;
                model_xf.xiaofei_qr_flag = 1;
                model_xf.flag_12 = 1;
                if (model_xf.Add() > 0)
                {
                    tbl_shengji tsj = new tbl_shengji();
                    tsj.huiyuan_bianhao = hy_bianhao1;
                    tsj.huiyuan_id = hy_id1;
                    tsj.huiyuan_jiebie = yuan_jb;
                    tsj.huiyuan_jiebie_name = new tbl_reg_jiebie().GetTitle(Convert.ToInt32(yuan_jb));
                    tsj.sj_date = DateTime.Now;
                    tsj.sj_jiebie = int.Parse(this.huiyuan_jiebie.SelectedValue);
                    tsj.sj_jiebie_name = new tbl_reg_jiebie().GetTitle(Convert.ToInt32(this.huiyuan_jiebie.SelectedValue));
                    tsj.sj_money = bu_money;

                    tsj.Add();

                    decimal moneyafter2 = nowMoney - bu_money;//改变后余额

                    string memo = "会员" + hy_bianhao1 + "升级" + bu_money + "元";

                    mym.queren_insert(hy_id1, hy_bianhao1, "升级补单", memo, -bu_money, moneyafter2);

                    Response.Write("<script language=javascript>alert('升级成功！');location.href='shengji.aspx';</script>");
                    return;
                }
            }
            else
            {
                tbl_reg_jiebie jb = new tbl_reg_jiebie();
                decimal yuan_money = jb.Get_Need_money(int.Parse(huiyuanmodel.huiyuan_jiebie.ToString()));
                decimal need_money = jb.Get_Need_money(int.Parse(this.huiyuan_jiebie.SelectedValue));
                decimal bu_money = need_money;

                decimal sum_zong = 0, sum_pv = 0;

                int yuan_jb = int.Parse(huiyuanmodel.huiyuan_jiebie.ToString());
                int new_jb = int.Parse(this.huiyuan_jiebie.SelectedValue);
                if (new_jb <= yuan_jb)
                {
                    Response.Write("<script language=javascript>alert('不能小于原有级别！');location.href='shengji.aspx';</script>");
                    return;
                }
                decimal nowMoney = decimal.Parse(huiyuanmodel.chongfu_zong.ToString());
                if (nowMoney >= bu_money)
                {

                    huiyuanmodel.huiyuan_id = hy_id1;
                    huiyuanmodel.huiyuan_jiebie = int.Parse(this.huiyuan_jiebie.SelectedValue);
                    huiyuanmodel.chongfu_zong -= bu_money;
                    huiyuanmodel.Update();
                }
                else
                {
                    Response.Write("<script language=javascript>alert('奖励积分不足！');location.href='shengji.aspx';</script>");
                    return;
                }

                tbl_xiaofei model_xf = new tbl_xiaofei();
                model_xf.xiaofei_hui_id = huiyuan_id;
                model_xf.xiaofei_money = bu_money;
                model_xf.xiaofei_money1 = sum_zong;
                model_xf.zhuce_flag = 2;
                model_xf.xiaofei_qr_date = DateTime.Now;
                model_xf.xiaofei_qr_flag = 1;
                model_xf.flag_12 = 1;
                if (model_xf.Add() > 0)
                {
                    tbl_shengji tsj = new tbl_shengji();
                    tsj.huiyuan_bianhao = hy_bianhao1;
                    tsj.huiyuan_id = hy_id1;
                    tsj.huiyuan_jiebie = yuan_jb;
                    tsj.huiyuan_jiebie_name = new tbl_reg_jiebie().GetTitle(Convert.ToInt32(yuan_jb));
                    tsj.sj_date = DateTime.Now;
                    tsj.sj_jiebie = int.Parse(this.huiyuan_jiebie.SelectedValue);
                    tsj.sj_jiebie_name = new tbl_reg_jiebie().GetTitle(Convert.ToInt32(this.huiyuan_jiebie.SelectedValue));
                    tsj.sj_money = bu_money;
                    tsj.Add();

                    decimal moneyafter2 = nowMoney - bu_money;//改变后余额

                    string memo = "会员" + hy_bianhao1 + "升级" + bu_money + "元";

                    mym.queren_insert(hy_id1, hy_bianhao1, "升级补单", memo, -bu_money, moneyafter2);

                    Response.Write("<script language=javascript>alert('升级成功！');location.href='shengji.aspx';</script>");
                    return;
                }
            }

        }
        if (type == 2)
        {
            if (ts.Days <= 60)
            {
                tbl_reg_jiebie jb = new tbl_reg_jiebie();
                decimal yuan_money = jb.Get_Need_money(int.Parse(huiyuanmodel.huiyuan_jiebie.ToString()));
                decimal need_money = jb.Get_Need_money(int.Parse(this.huiyuan_jiebie.SelectedValue));
                decimal bu_money = need_money - yuan_money;

                decimal sum_zong = 0, sum_pv = 0;

                int yuan_jb = int.Parse(huiyuanmodel.huiyuan_jiebie.ToString());
                int new_jb = int.Parse(this.huiyuan_jiebie.SelectedValue);
                if (new_jb <= yuan_jb)
                {
                    Response.Write("<script language=javascript>alert('不能小于原有级别！');location.href='shengji.aspx';</script>");
                    return;
                }
                decimal nowMoney = decimal.Parse(huiyuanmodel.glf_money.ToString());
                if (nowMoney >= bu_money)
                {

                    huiyuanmodel.huiyuan_id = hy_id1;
                    huiyuanmodel.huiyuan_jiebie = int.Parse(this.huiyuan_jiebie.SelectedValue);
                    huiyuanmodel.glf_money -= bu_money;
                    huiyuanmodel.Update();
                }
                else
                {
                    Response.Write("<script language=javascript>alert('奖励积分不足！');location.href='shengji.aspx';</script>");
                    return;
                }

                tbl_xiaofei model_xf = new tbl_xiaofei();
                model_xf.xiaofei_hui_id = huiyuan_id;
                model_xf.xiaofei_money = bu_money;
                model_xf.xiaofei_money1 = sum_zong;
                model_xf.zhuce_flag = 2;
                model_xf.xiaofei_qr_date = DateTime.Now;
                model_xf.xiaofei_qr_flag = 1;
                model_xf.flag_12 = 1;
                if (model_xf.Add() > 0)
                {
                    tbl_shengji tsj = new tbl_shengji();
                    tsj.huiyuan_bianhao = hy_bianhao1;
                    tsj.huiyuan_id = hy_id1;
                    tsj.huiyuan_jiebie = yuan_jb;
                    tsj.huiyuan_jiebie_name = new tbl_reg_jiebie().GetTitle(Convert.ToInt32(yuan_jb));
                    tsj.sj_date = DateTime.Now;
                    tsj.sj_jiebie = int.Parse(this.huiyuan_jiebie.SelectedValue);
                    tsj.sj_jiebie_name = new tbl_reg_jiebie().GetTitle(Convert.ToInt32(this.huiyuan_jiebie.SelectedValue));
                    tsj.sj_money = bu_money;

                    tsj.Add();

                    decimal moneyafter2 = nowMoney - bu_money;//改变后余额

                    string memo = "会员" + hy_bianhao1 + "升级" + bu_money + "元";

                    mym.queren_insert(hy_id1, hy_bianhao1, "升级补单", memo, -bu_money, moneyafter2);

                    Response.Write("<script language=javascript>alert('升级成功！');location.href='shengji.aspx';</script>");
                    return;
                }
            }
            else
            {
                tbl_reg_jiebie jb = new tbl_reg_jiebie();
                decimal yuan_money = jb.Get_Need_money(int.Parse(huiyuanmodel.huiyuan_jiebie.ToString()));
                decimal need_money = jb.Get_Need_money(int.Parse(this.huiyuan_jiebie.SelectedValue));
                decimal bu_money = need_money;

                decimal sum_zong = 0, sum_pv = 0;

                int yuan_jb = int.Parse(huiyuanmodel.huiyuan_jiebie.ToString());
                int new_jb = int.Parse(this.huiyuan_jiebie.SelectedValue);
                if (new_jb <= yuan_jb)
                {
                    Response.Write("<script language=javascript>alert('不能小于原有级别！');location.href='shengji.aspx';</script>");
                    return;
                }
                decimal nowMoney = decimal.Parse(huiyuanmodel.glf_money.ToString());
                if (nowMoney >= bu_money)
                {

                    huiyuanmodel.huiyuan_id = hy_id1;
                    huiyuanmodel.huiyuan_jiebie = int.Parse(this.huiyuan_jiebie.SelectedValue);
                    huiyuanmodel.glf_money -= bu_money;
                    huiyuanmodel.Update();
                }
                else
                {
                    Response.Write("<script language=javascript>alert('奖励积分不足！');location.href='shengji.aspx';</script>");
                    return;
                }

                tbl_xiaofei model_xf = new tbl_xiaofei();
                model_xf.xiaofei_hui_id = huiyuan_id;
                model_xf.xiaofei_money = bu_money;
                model_xf.xiaofei_money1 = sum_zong;
                model_xf.zhuce_flag = 2;
                model_xf.xiaofei_qr_date = DateTime.Now;
                model_xf.xiaofei_qr_flag = 1;
                model_xf.flag_12 = 1;
                if (model_xf.Add() > 0)
                {
                    tbl_shengji tsj = new tbl_shengji();
                    tsj.huiyuan_bianhao = hy_bianhao1;
                    tsj.huiyuan_id = hy_id1;
                    tsj.huiyuan_jiebie = yuan_jb;
                    tsj.huiyuan_jiebie_name = new tbl_reg_jiebie().GetTitle(Convert.ToInt32(yuan_jb));
                    tsj.sj_date = DateTime.Now;
                    tsj.sj_jiebie = int.Parse(this.huiyuan_jiebie.SelectedValue);
                    tsj.sj_jiebie_name = new tbl_reg_jiebie().GetTitle(Convert.ToInt32(this.huiyuan_jiebie.SelectedValue));
                    tsj.sj_money = bu_money;
                    tsj.Add();

                    decimal moneyafter2 = nowMoney - bu_money;//改变后余额

                    string memo = "会员" + hy_bianhao1 + "升级" + bu_money + "元";

                    mym.queren_insert(hy_id1, hy_bianhao1, "升级补单", memo, -bu_money, moneyafter2);

                    Response.Write("<script language=javascript>alert('升级成功！');location.href='shengji.aspx';</script>");
                    return;
                }
            }

        }
    }
    //protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    //{
    //    tbl_huiyuan tbll = new tbl_huiyuan();
    //    tbll.GetModel_hui_id(hy_id1);

    //    tbl_reg_jiebie jb = new tbl_reg_jiebie();
    //    decimal yuan_money = jb.Get_Need_money(int.Parse(tbll.huiyuan_jiebie.ToString()));
    //    decimal need_money = jb.Get_Need_money(int.Parse(this.huiyuan_jiebie.SelectedValue));
    //    decimal bu_money = need_money - yuan_money;
    //    if (bu_money <= 0)
    //    {
    //        Response.Write("<script language=javascript>alert('不能低于原有级别！');history.go(-1);</script>");
    //        return;
    //    }
    //    //this.Label2.Text = (need_money - yuan_money).ToString();
    //}
}