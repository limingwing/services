using System;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

public partial class reg_reg1 : System.Web.UI.Page
{
    ManagePage mym = new ManagePage();

    protected void Page_Load(object sender, EventArgs e)
    {
        //if (Session["hy_id1"] == null)
        //{
        //    Response.Write("<script language=javascript>alert('请重新登录！');top.location.href='../shop/login.aspx';</script>");
        //    Response.End();

        //}


        if (!Page.IsPostBack)
        {
            yhBind();//绑定银行
            QDBind();
            Focus myFocus = new Focus();
            myFocus.SetEnterControl(this.bas_id1);
            myFocus.SetFocus(bas_id1.Page, "bas_id1");
            this.bas_id1.Text = DbHelperSQL.GetDataRow("exec sp_shengcheng_bianhao")["aa"].ToString();
            if (Request.QueryString["jd_bianhao"] != null)
            {
                this.bas_tuijian.Text = Request.QueryString["jd_bianhao"].ToString();
                string bianhao = Request.QueryString["jd_bianhao"].ToString();
                tbl_huiyuan m_huiyuan = new tbl_huiyuan();
                m_huiyuan.GetModel_hui_bianhao(bianhao);
                string jiedian = DbHelperSQL.GetDataRow("exec sp_zhaoA '" + m_huiyuan.huiyuan_id + "'")["aa"].ToString();
                m_huiyuan.GetModel_hui_id(jiedian);
                this.huiyuan_jiedian.Text = m_huiyuan.huiyuan_bianhao;
                //this.huiyuan_jiedian.Text = Request.QueryString["jd_bianhao"].ToString();
                //this.zuoyou.SelectedValue = Request.QueryString["zuoyou"].ToString();
            }
            //RptBind();

        }
    }
    #region 数据绑定=================================
    //private void RptBind()
    //{
    //    tbl_product bll = new tbl_product();
    //    this.rptList.DataSource = bll.GetList(" pro_type=0 and pro_isok=1 order by salse_price asc");
    //    this.rptList.DataBind();
    //}
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
            string Title = dr["jiebie_name"].ToString().Trim();// + Math.Floor(double.Parse(dr["need_money"].ToString())) + "元"
            this.huiyuan_jiebie.Items.Add(new ListItem(Title, Id));
        }
    }
    #endregion


    #region 绑定银行=================================
    private void yhBind()
    {
        tbl_reg_bank bll = new tbl_reg_bank();
        DataTable dt = bll.GetList("1=1   order by sort_id").Tables[0];
        this.bas_bankaddress.Items.Clear();
        this.bas_bankaddress.Items.Add(new ListItem("请选择银行...", ""));
        foreach (DataRow dr in dt.Rows)
        {
            string Id = dr["id"].ToString();
            string Title = dr["bank_name"].ToString().Trim();
            this.bas_bankaddress.Items.Add(new ListItem(Title, Id));
        }
    }
    #endregion
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        tbl_canshu canshu = new tbl_canshu();
        canshu.GetModel(1);
        decimal can = decimal.Parse(canshu.canshu_035.ToString())*0.01m;
        decimal xiaofei;
        //string sPassWord = this.passwords.Text;
        //if (!tbl_huiyuan.Exists_erji(Request.QueryString["jd_bianhao"].ToString(), sPassWord))
        //{
        //    Response.Write("<script language=javascript>alert('二级密码不正确！');history.go(-1);;</script>");
        //    return;
        //}
        tbl_huiyuan huiyuanmodel = new tbl_huiyuan();

        huiyuanmodel.GetModel_hui_bianhao(Session["hy_bianhao1"].ToString());
        string jd_id = huiyuanmodel.huiyuan_id;
        string huiyuan_id = DbHelperSQL.GetDataRow("exec sp_shengcheng_id")["aa"].ToString();
        tbl_reg_jiebie jb = new tbl_reg_jiebie();
        if (!tbl_huiyuan.Exists_cunzai(bas_tuijian.Text.Trim()))
        {
            Response.Write("<script language=javascript>alert('推荐人不存在！');history.go(-1);</script>");
            return;

        }
        if (this.huiyuan_address.Text.Trim() == "")
        {
            Response.Write("<script language=javascript>alert('收货地址必须填写！');history.go(-1);</script>");
            return;
        }
        if (this.huiyuan_idcard.Text.Trim() == "")
        {
            Response.Write("<script language=javascript>alert('身份证号必须填写！');history.go(-1);</script>");
            return;
        }
        if (!tbl_huiyuan.Exists_cunzai(this.huiyuan_jiedian.Text.Trim()))
        {
            Response.Write("<script language=javascript>alert('接点人不存在！');history.go(-1);</script>");
            return;

        }
        if (this.huiyuan_jiedian.Text.Trim() == "")
        {
            Response.Write("<script language=javascript>alert('接点人未填写！');history.go(-1);</script>");
            return;

        }
        if (this.huiyuan_zm.Text.Trim() != "")
        {
            if (!tbl_huiyuan.Exists_zmd(this.huiyuan_zm.Text.Trim()))
            {
                Response.Write("<script language=javascript>alert('服务中心不存在！');history.go(-1);</script>");
                return;

            }
        }

        //if (tbl_huiyuan.Exists_zuoqu_jihuo(this.huiyuan_jiedian.Text.Trim()))
        //{
        //    Response.Write("<script language=javascript>alert('对不起，接点人左区没有激活！');history.go(-1);</script>");
        //    return;

        //}
        //if (tbl_huiyuan.Exists_tiaojian_check(" huiyuan_bianhao='" + bas_id1 + "'"))
        //{
        //    Response.Write("<script language=javascript>alert('编号已经被注册！请重新选择');history.go(-1);</script>");
        //    return;

        //}

        int count_cishu;
        DataRow dr = DbHelperSQL.GetDataRow("select aa=isnull(count(*),0) from tbl_huiyuan where huiyuan_shenfen_id='" + this.huiyuan_idcard.Text.Trim().ToString() + "'");
        if (dr != null)
        {
            count_cishu = int.Parse(dr["aa"].ToString());//放置人huiyuan_id
        }
        else
        {
            count_cishu = 0;
        }
        if (count_cishu >= 3)
        {
            Response.Write("<script language=javascript>alert('一个身份证能注册3次！');history.go(-1);</script>");
            return;
        }
        if (tbl_huiyuan.Exists_tiaojian_check(" huiyuan_mob='" + Utils.Filter(this.bas_mob.Text.ToString()) + "'"))
        {
            Response.Write("<script language=javascript>alert('手机号码已经被注册！');history.go(-1);</script>");
            return;

        }
        if (tbl_huiyuan.Exists_tiaojian_check(" huiyuan_id='" + huiyuan_id + "'"))
        {
            Response.Write("<script language=javascript>alert('页面失效！请刷新！');history.go(-1);</script>");
            return;

        }
        //if (this.xiaofei.Text.Trim() == "")
        //{
        //    xiaofei = 0;
        //}
        //else
        //{
        //    xiaofei = decimal.Parse(this.xiaofei.Text.ToString());
        //}
        //int leixing =int.Parse(this.leixing.SelectedValue);

        tbl_huiyuan model_th = new tbl_huiyuan();
        model_th.GetModel_hui_bianhao(bas_tuijian.Text.Trim().ToString());
        string huiyuan_shang_id = model_th.huiyuan_id;//推荐人huiyuan_id
        model_th.GetModel_hui_bianhao(this.huiyuan_jiedian.Text.Trim().ToString());
        string huiyuan_jiedian = model_th.huiyuan_id;//接点人huiyuan_id
        int tuijian_count = int.Parse(model_th.tuijian_count.ToString());
        if (this.huiyuan_zm.Text != "")
        {
            model_th.GetModel_hui_bianhao(this.huiyuan_zm.Text);
        }
        else
        {
            model_th.GetModel_hui_bianhao("A00000000");
        }
        string huiyuan_zm = model_th.huiyuan_id;//接点人huiyuan_id

        model_th.huiyuan_id = huiyuan_id;
        if (tbl_huiyuan.Exists_jd_check(huiyuan_jiedian, int.Parse(this.zuoyou.SelectedValue)))
        {
            Response.Write("<script language=javascript>alert('该市场位置上已经有人，请重新选择市场位置！');history.go(-1);</script>");
            return;

        }

        if (!tbl_huiyuan.Exists_jd_zuocheck(huiyuan_shang_id, int.Parse(this.zuoyou.SelectedValue)))
        {
            Response.Write("<script language=javascript>alert('推荐的第一人必须放在左区，并且要激活！');history.go(-1);</script>");
            return;

        }
        //if (int.Parse(this.zuoyou.SelectedValue) == 3)
        //{
        //    if (!tbl_huiyuan.Exists_jd_check(huiyuan_shang_id, 2))
        //    {
        //        Response.Write("<script language=javascript>alert('B区必需有人C区才能使用！');history.go(-1);</script>");
        //        return;
        //    }
        //}
        //if (int.Parse(this.zuoyou.SelectedValue) == 2 || int.Parse(this.zuoyou.SelectedValue) == 3)
        //{
        //    if (huiyuan_shang_id != huiyuan_jiedian)
        //    {
        //        Response.Write("<script language=javascript>alert('B区C区必需是自己直推！');history.go(-1);</script>");
        //        return;
        //    }
        //}

        decimal sum_zong = 0, sum_pv = 0;
        //for (int x = 0; x < rptList.Items.Count; x++)
        //{
        //    TextBox cbx = (TextBox)rptList.Items[x].FindControl("shuliang");//数量
        //    Label textControl = (Label)rptList.Items[x].FindControl("Label2");//价格
        //    //Label Label1 = (Label)rptList.Items[x].FindControl("Label1");//PV
        //    if (int.Parse(cbx.Text) > 0)
        //    {
        //        sum_zong = sum_zong + decimal.Parse(textControl.Text) * decimal.Parse(cbx.Text);
        //        // sum_pv = sum_pv + decimal.Parse(Label1.Text) * decimal.Parse(cbx.Text);
        //    }



        //}
    //    if (sum_zong == 0)
    //    {
    //        Response.Write("<script language=javascript>alert('您还没选择产品！');history.go(-1);</script>");
    //        return;
    //    }


        decimal need_money = jb.Get_Need_money(int.Parse(huiyuan_jiebie.SelectedValue));
    //    decimal a=need_money-xiaofei;
    //    decimal xiaofeineed = need_money * can;
    //    if (xiaofei > xiaofeineed)
    //    {
    //        Response.Write("<script language=javascript>alert('可使用肽豆不超过" + xiaofeineed.ToString("0.00") + "！');history.go(-1);</script>");
    //        return;
    //    }
    //    tbl_huiyuan bll = new tbl_huiyuan();
    //    string bianhao = Session["hy_bianhao1"].ToString();
    //    bll.GetModel_hui_bianhao(bianhao);
    //    decimal now_zm_jiangjin = decimal.Parse((bll.qianbao - bll.fenhong_canshu1).ToString());
    //    decimal now_zm_zong = decimal.Parse((bll.jiangjin_zong - bll.jiangjin_yong).ToString());

    //if (need_money != sum_zong)
    //    {
    //        Response.Write("<script language=javascript>alert('您选择的产品和注册级别不符！');history.go(-1);</script>");
    //        return;
    //    }

    //    if (now_zm_jiangjin< (need_money - xiaofei)    )
    //    {
    //        Response.Write("<script language=javascript>alert('购物积分不足！');history.go(-1);</script>");
    //        return;
    //    }

    //if ( now_zm_zong< xiaofei  )
    //    {
    //        Response.Write("<script language=javascript>alert('肽豆不足！');history.go(-1);</script>");
    //        return;
    //    }

        
       
    //    if (sum_zong > 0)
    //    {
    //        tbl_orders model = new tbl_orders();
    //        model.order_no = Utils.GetOrderNumber(); //订单号B开头为商品订单
    //        model.user_id = huiyuan_id;
    //        model.user_bianhao = this.bas_id1.Text.Trim();
    //        //  model.depot_category_id = depot_category_id;
    //        //  model.depot_id = depot_id;
    //        model.user_name = this.bas_name.Text.Trim();
    //        model.payment_id = 2;//支付方式
    //        //model.message = message.Text;
    //        model.payable_amount = sum_zong;
    //        model.real_amount = 0;
    //        model.phone = this.bas_mob.Text;
    //        model.address = this.huiyuan_address.Text;

    //        //订单总金额=实付商品金额
    //        model.order_amount = sum_zong;//pv总值
    //        model.add_time = DateTime.Now;
    //        if (model.Add() == 0)
    //        {
    //            Response.Write("<script language=javascript>alert('保存失败！');history.go(-1);</script>");
    //            return;
    //        }
    //        tbl_order_goods gls = new tbl_order_goods();
    //        tbl_product my = new tbl_product();
    //        for (int x = 0; x < rptList.Items.Count; x++)
    //        {

    //            int id = Convert.ToInt32(((HiddenField)rptList.Items[x].FindControl("hidId")).Value);
    //            TextBox cbx = (TextBox)rptList.Items[x].FindControl("shuliang");//数量
    //            if (int.Parse(cbx.Text) > 0)
    //            {
    //                my.GetModel(id);
    //                gls.order_id = model.GetMaxId();
    //                gls.goods_id = id;
    //                gls.goods_title = my.pro_name;
    //                gls.goods_price = my.go_price;
    //                gls.real_price = my.go_price;
    //                gls.quantity = int.Parse(cbx.Text);
    //                gls.product_category_id = my.pro_pid;
    //                gls.dw = my.pro_danwei;
    //                gls.Add();

    //            }
    //            //TextBox cbx = (TextBox)rptList.Items[x].FindControl("shuliang");//数量
    //            //Label textControl = (Label)rptList.Items[x].FindControl("Label2");//价格




    //        }

        tbl_xiaofei model_xf = new tbl_xiaofei();
        model_xf.xiaofei_hui_id = huiyuan_id;
        model_xf.xiaofei_money = need_money;
        model_xf.xiaofei_money1 = sum_zong;
        model_xf.zhuce_flag = 1;
        model_xf.Add();

    //    }


        //-----执行存储过程开始
        model_th.huiyuan_shang_id = huiyuan_shang_id;
        model_th.huiyuan_jiedian = huiyuan_jiedian;
        model_th.huiyuan_name = this.bas_name.Text.Trim();
        model_th.huiyuan_bianhao = this.bas_id1.Text.Trim();
        model_th.zuoyou = int.Parse(this.zuoyou.SelectedValue);
        model_th.huiyuan_id = huiyuan_id;
        model_th.Add_huiyuan1();
        //------执行存储过程结束
        //------更新开始
        model_th.GetModel_hui_id(huiyuan_id);
        model_th.huiyuan_zm = huiyuan_zm;
        model_th.huiyuan_mob = this.bas_mob.Text;
        model_th.huiyuan_jiebie = int.Parse(huiyuan_jiebie.SelectedValue);
        model_th.huiyuan_jiebie2 = int.Parse(huiyuan_jiebie.SelectedValue);
        model_th.huiyuan_pass = huiyuan_pass1.Text;
        model_th.pass_two = pass_two1.Text;
        model_th.huiyuan_yinhang = bas_bankaddress.SelectedItem.Text;
        model_th.huiyuan_yinhang_zh = bas_bankaddress1.Text;
        model_th.huiyuan_yinhang_name = zhanghuming.Text;
        model_th.bank_zhi = bank_zhi.Text;
        model_th.huiyuan_address = huiyuan_address.Text;
        //model_th.flag_4 = 1;//可以提现


        //model_th.net_hege = 1;

        if (model_th.Update())
        {
            //int i = DbHelperSQL.ExecuteSql("exec sp_kaitong_huiyuan '" + huiyuan_id + "','A00000000'");
            //mym.queren_insert(jd_id, Session["hy_bianhao1"].ToString(), "注册会员", "注册会员" + model_th.huiyuan_name + "消耗购物积分" + a.ToString("0.0") + "消耗肽豆" + xiaofei.ToString("0.0") + "", need_money, need_money);
            //bll.fenhong_canshu1 = bll.fenhong_canshu1 + (need_money - xiaofei);

            //bll.jiangjin_yong = bll.jiangjin_yong + xiaofei;
            //bll.Update();

            Response.Write("<script language=javascript>alert('注册成功！');history.go(-1);</script>");
            return;
        }
        //------更新结束

    }

   
}