﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.IO;

public partial class shop_informationsj : System.Web.UI.Page
{
    protected int page;
    tbl_shangshu2 shangshu2 = new tbl_shangshu2();
    ManagePage mym = new ManagePage();
    protected void Page_Load(object sender, EventArgs e)
    {


        if (!Page.IsPostBack)
        {
            if (Session["hy_id1"] == null)
            {
                Response.Write("<script language=javascript>alert('请重新登录！');top.location.href='login.aspx';</script>");
                Response.End();

            }

            ShowInfo(Session["hy_id1"].ToString());
            tbl_product bll = new tbl_product();
            this.rptList.DataSource = bll.GetList(" pro_type=0 and pro_isok=1 order by salse_price asc");
            this.rptList.DataBind();
        }
    }

    #region 赋值操作=================================
    private void ShowInfo(string _id)
    {
        tbl_huiyuan model = new tbl_huiyuan();
        model.GetModel_hui_id(_id);
        username.Text = model.huiyuan_name;
        int jibie1 = int.Parse(model.huiyuan_jiebie.ToString());
        tbl_reg_jiebie bll = new tbl_reg_jiebie();
        bll.GetModeljibie(jibie1);
        jibie.Text = bll.jiebie_name;
    }
    #endregion

    #region 修改操作=================================
    private bool DoEdit(string _id)
    {

        bool result = false;

        tbl_huiyuan model = new tbl_huiyuan();

        model.GetModel_hui_bianhao(this.bas_tuijian.Value.Trim().ToString());
        string huiyuan_shang_id = model.huiyuan_id;//推荐人huiyuan_id
        model.GetModel_hui_bianhao(this.huiyuan_jiedian.Value.Trim().ToString());
        string huiyuan_jiedian = model.huiyuan_id;//接点人huiyuan_id
        int tuijian_count = int.Parse(model.tuijian_count.ToString());
        model.GetModel_hui_bianhao("A00000000");
        string huiyuan_zm = model.huiyuan_id;//接点人huiyuan_id

        model.GetModel_hui_id(_id);
        model.huiyuan_shang_id = huiyuan_shang_id;
        model.huiyuan_jiedian = huiyuan_jiedian;
        model.zuoyou = int.Parse(this.zuoyou.SelectedValue);
        model.Add_huiyuan();
        model.huiyuan_zm = huiyuan_zm;


        model.huiyuan_jiebie = 2;
        model.net_hege = 0;

        tbl_huiyuan bll = new tbl_huiyuan();
        bll.GetModel_hui_id(_id);

        tbl_xiaofei xf_bll = new tbl_xiaofei();

        xf_bll.GetModel(_id);


        decimal xiaofei_money = decimal.Parse(xf_bll.xiaofei_money.ToString());

        tbl_huiyuan bll_h = new tbl_huiyuan();
        bll_h.GetModel_hui_id(Session["hy_id1"].ToString());

        decimal now_zm_jiangjin = decimal.Parse((bll_h.jiangjin_zong - bll_h.jiangjin_yong).ToString());


        if (xiaofei_money > now_zm_jiangjin)
        {
            Response.Write("<script language=javascript>alert('肽豆不足！');location.href='informationsj.aspx';</script>");
            return false;


        }
       
        if (model.Update())
        {
            bll_h.jiangjin_yong = xiaofei_money;
            bll_h.reduce_jiangjin_zong();
            int i = DbHelperSQL.ExecuteSql("exec sp_kaitong_huiyuan '" + _id + "','A00000000'");

            decimal moneyafter = now_zm_jiangjin - xiaofei_money;//改变后余额
            string memo = "股东升级" + bll.huiyuan_bianhao + "扣费" + xiaofei_money + "元肽豆";
            mym.queren_insert(Session["hy_id1"].ToString(), Session["hy_bianhao1"].ToString(), "肽豆", memo, -xiaofei_money, moneyafter);

            result = true;
        }

        return result;
    }
    #endregion

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (!tbl_huiyuan.Exists_cunzai(bas_tuijian.Value.Trim()))
        {
            Response.Write("<script language=javascript>alert('推荐人不存在！');history.go(-1);</script>");
            return;

        }

        if (!tbl_huiyuan.Exists_cunzai(this.huiyuan_jiedian.Value.Trim()))
        {
            Response.Write("<script language=javascript>alert('接点人不存在！');history.go(-1);</script>");
            return;

        }
        if (this.huiyuan_jiedian.Value.Trim() == "")
        {
            Response.Write("<script language=javascript>alert('接点人未填写！');history.go(-1);</script>");
            return;

        }


        if (tbl_huiyuan.Exists_zuoqu_jihuo(this.huiyuan_jiedian.Value.Trim()))
        {
            Response.Write("<script language=javascript>alert('对不起，接点人左区没有激活！');history.go(-1);</script>");
            return;

        }

        tbl_huiyuan model_th = new tbl_huiyuan();
        model_th.GetModel_hui_bianhao(this.bas_tuijian.Value.Trim().ToString());
        string huiyuan_shang_id = model_th.huiyuan_id;//推荐人huiyuan_id
        model_th.GetModel_hui_bianhao(this.huiyuan_jiedian.Value.Trim().ToString());
        string huiyuan_jiedian = model_th.huiyuan_id;//接点人huiyuan_id
        int tuijian_count = int.Parse(model_th.tuijian_count.ToString());
        model_th.GetModel_hui_bianhao("A00000000");
        string huiyuan_zm = model_th.huiyuan_id;//接点人huiyuan_id

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

        decimal sum_zong = 0, sum_pv = 0;
        for (int x = 0; x < rptList.Items.Count; x++)
        {
            TextBox cbx = (TextBox)rptList.Items[x].FindControl("shuliang");//数量
            Label textControl = (Label)rptList.Items[x].FindControl("Label2");//价格
            //Label Label1 = (Label)rptList.Items[x].FindControl("Label1");//PV
            if (int.Parse(cbx.Text) > 0)
            {
                sum_zong = sum_zong + decimal.Parse(textControl.Text) * decimal.Parse(cbx.Text);
                // sum_pv = sum_pv + decimal.Parse(Label1.Text) * decimal.Parse(cbx.Text);
            }



        }
        if (sum_zong == 0)
        {
            Response.Write("<script language=javascript>alert('您还没选择产品！');history.go(-1);</script>");
            return;
        }

        tbl_reg_jiebie jb = new tbl_reg_jiebie();
        tbl_huiyuan hui_id = new tbl_huiyuan();
        hui_id.GetModel_hui_id(Session["hy_id1"].ToString());
        decimal need_money = jb.Get_Need_money(2);
        if (need_money != sum_zong)
        {
            Response.Write("<script language=javascript>alert('您选择的产品和注册级别不符！');history.go(-1);</script>");
            return;
        }
        if (sum_zong > 0)
        {
            tbl_orders model = new tbl_orders();
            model.order_no = Utils.GetOrderNumber(); //订单号B开头为商品订单
            model.user_id = hui_id.huiyuan_id;
            model.user_bianhao = hui_id.huiyuan_bianhao;
            //  model.depot_category_id = depot_category_id;
            //  model.depot_id = depot_id;
            model.user_name = this.username.Text.Trim();
            model.payment_id = 2;//支付方式
            //model.message = message.Text;
            model.payable_amount = sum_zong;
            model.real_amount = 0;
            model.phone = hui_id.huiyuan_mob;
            model.address = hui_id.huiyuan_address;

            //订单总金额=实付商品金额
            model.order_amount = sum_zong;//pv总值
            model.add_time = DateTime.Now;
            if (model.Add() == 0)
            {
                Response.Write("<script language=javascript>alert('保存失败！');history.go(-1);</script>");
                return;
            }
            tbl_order_goods gls = new tbl_order_goods();
            tbl_product my = new tbl_product();
            for (int x = 0; x < rptList.Items.Count; x++)
            {

                int id = Convert.ToInt32(((HiddenField)rptList.Items[x].FindControl("hidId")).Value);
                TextBox cbx = (TextBox)rptList.Items[x].FindControl("shuliang");//数量
                if (int.Parse(cbx.Text) > 0)
                {
                    my.GetModel(id);
                    gls.order_id = model.GetMaxId();
                    gls.goods_id = id;
                    gls.goods_title = my.pro_name;
                    gls.goods_price = my.go_price;
                    gls.real_price = my.go_price;
                    gls.quantity = int.Parse(cbx.Text);
                    gls.product_category_id = my.pro_pid;
                    gls.dw = my.pro_danwei;
                    gls.Add();

                }
                //TextBox cbx = (TextBox)rptList.Items[x].FindControl("shuliang");//数量
                Label textControl = (Label)rptList.Items[x].FindControl("Label2");//价格




            }

            tbl_xiaofei model_xf = new tbl_xiaofei();
            model_xf.xiaofei_hui_id = hui_id.huiyuan_id;
            model_xf.xiaofei_money = need_money;
            model_xf.xiaofei_money1 = sum_zong;
            model_xf.zhuce_flag = 1;
            model_xf.Add();

        }

        if (DoEdit(Session["hy_id1"].ToString()))
        {
            Response.Write("<script language=javascript>alert('升级成功！');top.location.href='member_center.aspx';</script>");
            Response.End();

        }





        //写入

    }
    //上传验证数组
    public enum FileExtension
    {
        JPG = 255216,
        GIF = 7173,
        PNG = 13780,
        SWF = 6787,
        RAR = 8297,
        ZIP = 8075,
        _7Z = 55122

        // 255216 jpg;   

        // 7173 gif;   

        // 6677 bmp,   

        // 13780 png;   

        // 6787 swf   

        // 7790 exe dll,   

        // 8297 rar   

        // 8075 zip   

        // 55122 7z   

        // 6063 xml   

        // 6033 html   

        // 239187 aspx   

        // 117115 cs   

        // 119105 js   

        // 102100 txt   

        // 255254 sql    

    }
    //上传验证类
    public class FileValidation
    {
        public static bool IsAllowedExtension(FileUpload fu, FileExtension[] fileEx)
        {
            int fileLen = fu.PostedFile.ContentLength;
            byte[] imgArray = new byte[fileLen];
            fu.PostedFile.InputStream.Read(imgArray, 0, fileLen);
            MemoryStream ms = new MemoryStream(imgArray);
            System.IO.BinaryReader br = new System.IO.BinaryReader(ms);
            string fileclass = "";
            byte buffer;
            try
            {
                buffer = br.ReadByte();
                fileclass = buffer.ToString();
                buffer = br.ReadByte();
                fileclass += buffer.ToString();
            }
            catch
            {
            }
            br.Close();
            ms.Close();
            foreach (FileExtension fe in fileEx)
            {
                if (Int32.Parse(fileclass) == (int)fe)
                    return true;
            }
            return false;
        }
    }


}