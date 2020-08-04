using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.IO;

public partial class shop_information1 : System.Web.UI.Page
{
    protected int page;
    tbl_shangshu2 shangshu2 = new tbl_shangshu2();
    protected void Page_Load(object sender, EventArgs e)
    {


        if (!Page.IsPostBack)
        {
            if (Session["hy_id1"] == null)
            {
                Response.Write("<script language=javascript>alert('请重新登录！');top.location.href='login.aspx';</script>");
                Response.End();

            }
            //yhBind();
            BindProvince();//绑定省
            BindCity(bind_Province.SelectedValue);//绑定市区
            BindBorough(bind_City.SelectedValue);//绑定县区

            ShowInfo(Session["hy_id1"].ToString());
            tbl_product bll = new tbl_product();
            //this.rptList.DataSource = bll.GetList(" pro_type=0 and pro_isok=1 order by salse_price asc");
            //this.rptList.DataBind();
            DataTable dt = shangshu2.GetList("1=1 and huiyuan_id='" + Session["hy_id1"].ToString() + "'").Tables[0];
            int counts = dt.Rows.Count;
            if (counts > 0)
            {
                //this.rptList.Visible = false;
                //this.div1.Visible = false;
                //this.div2.Visible = false;
                //this.div3.Visible = false;
                ////this.div4.Visible = false;
                this.div5.Visible = false;
                this.div6.Visible = false;
                this.user_bianhao.Attributes.Add("readonly", "readonly");
                this.shenfenidcard.Attributes.Add("readonly", "readonly");
                this.qiquan_txt.Attributes.Add("readonly", "readonly");
            }
        }
    }

    #region 绑定银行=================================
    //private void yhBind()
    //{
    //    tbl_reg_bank bll = new tbl_reg_bank();
    //    DataTable dt = bll.GetList("1=1   order by sort_id").Tables[0];
    //    this.bas_bankaddress.Items.Clear();
    //    this.bas_bankaddress.Items.Add(new ListItem("请选择银行...", ""));
    //    foreach (DataRow dr in dt.Rows)
    //    {
    //        string Id = dr["bank_name"].ToString();
    //        string Title = dr["bank_name"].ToString().Trim();
    //        this.bas_bankaddress.Items.Add(new ListItem(Title, Id));
    //    }
    //}
    #endregion

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
        user_name.Value = model.huiyuan_name;
        user_phone.Value = model.huiyuan_mob;
        //user_email.Value = model.huiyuan_email;
        address.Value = model.huiyuan_address;
        this.user_bianhao.Value = model.huiyuan_bianhao;
        this.weixin.Value = model.weixin;
        //this.born.Value = model.born_date;
        this.shenfenidcard.Value = model.huiyuan_shenfen_id;
        this.qiquan_txt.Value = decimal.Parse(model.chongfu_kechu.ToString()).ToString("n2");
        //===========修改操作赋值三级联动开始========
        bind_Province.SelectedValue = model.bid.ToString();


        BindCity(bind_Province.SelectedValue);//绑定市区
        bind_City.SelectedValue = model.mmid.ToString();

        BindBorough(bind_City.SelectedValue);//绑定县区
        bind_Borough.SelectedValue = model.sid.ToString();

        //===========修改操作赋值三级联动结束========
        address.Value = model.huiyuan_address;
        //bas_bankaddress.SelectedValue = model.huiyuan_yinhang;
        //bas_bankaddress1.Value = model.huiyuan_yinhang_zh;
        //zhanghuming.Value = model.huiyuan_yinhang_name;
        //bank_zhi.Value = model.bank_zhi;
    }
    #endregion

    #region 修改操作=================================
    private bool DoEdit(string _id, string _upload1, string _upload2)
    {

        bool result = false;

        tbl_huiyuan model = new tbl_huiyuan();
        DataTable dt = shangshu2.GetList("1=1 and huiyuan_id='" + Session["hy_id1"].ToString() + "'").Tables[0];
        int counts = dt.Rows.Count;
        if (counts == 0)
        {
            model.GetModel_hui_bianhao("A00000000");
            string huiyuan_shang_id = model.huiyuan_id;//推荐人huiyuan_id
            model.GetModel_hui_bianhao("A00000000");
            string huiyuan_jiedian = model.huiyuan_id;//接点人huiyuan_id
            int tuijian_count = int.Parse(model.tuijian_count.ToString());
            model.GetModel_hui_bianhao("A00000000");
            string huiyuan_zm = model.huiyuan_id;//接点人huiyuan_id

            model.GetModel_hui_id(_id);
            model.huiyuan_shang_id = huiyuan_shang_id;
            model.huiyuan_jiedian = huiyuan_jiedian;
            //model.zuoyou = int.Parse(this.zuoyou.SelectedValue);
            model.huiyuan_bianhao = user_bianhao.Value.Trim();
            model.huiyuan_name = user_name.Value.Trim();
            model.Add_huiyuan();
            model.huiyuan_zm = huiyuan_zm;
        }else
            model.GetModel_hui_id(_id);
        model.huiyuan_mob = user_phone.Value.Trim();
        //model.huiyuan_email = user_email.Value.Trim();
        model.huiyuan_address = address.Value.Trim();
        model.bid = int.Parse(bind_Province.SelectedValue);
        model.mmid = int.Parse(bind_City.SelectedValue);
        model.sid = int.Parse(bind_Borough.SelectedValue);
        //model.huiyuan_yinhang = bas_bankaddress.SelectedValue;
        //model.huiyuan_yinhang_zh = bas_bankaddress1.Value.Trim();
        //model.huiyuan_yinhang_name = zhanghuming.Value.Trim();
        //model.bank_zhi = bank_zhi.Value.Trim();
        model.huiyuan_shenfen_id = this.shenfenidcard.Value.Trim();
        model.weixin = this.weixin.Value.Trim();
        //model.born_date = this.born.Value.Trim();
        if (!string.IsNullOrEmpty(_upload1) && !string.IsNullOrEmpty(_upload2))
        {
            model.sf_pinju_src = "/upload/pingju/" + _upload1;
            model.zl_pinju_src = "/upload/pingju/" + _upload2;
        }
        model.chongfu_kechu = decimal.Parse(this.qiquan_txt.Value.Trim());
        model.flag_4 = 0;//bukeyi
        model.huiyuan_jiebie = 0;


        if (model.Update())
        {

            result = true;
        }

        return result;
    }
    #endregion

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        DataTable dt = shangshu2.GetList("1=1 and huiyuan_id='" + Session["hy_id1"].ToString() + "'").Tables[0];
        int counts = dt.Rows.Count;
        if (counts == 0)
        {
            //if (!tbl_huiyuan.Exists_cunzai(bas_tuijian.Value.Trim()))
            //{
            //    Response.Write("<script language=javascript>alert('推荐人不存在！');history.go(-1);</script>");
            //    return;

            //}

            //if (!tbl_huiyuan.Exists_cunzai(this.huiyuan_jiedian.Value.Trim()))
            //{
            //    Response.Write("<script language=javascript>alert('接点人不存在！');history.go(-1);</script>");
            //    return;

            //}
            //if (this.huiyuan_jiedian.Value.Trim() == "")
            //{
            //    Response.Write("<script language=javascript>alert('接点人未填写！');history.go(-1);</script>");
            //    return;

            //}
            //if (!tbl_huiyuan.Exists_zmd(this.huiyuan_zm.Value.Trim()))
            //{
            //    Response.Write("<script language=javascript>alert('服务中心不存在！');history.go(-1);</script>");
            //    return;

            //}


            //if (tbl_huiyuan.Exists_zuoqu_jihuo(this.huiyuan_jiedian.Value.Trim()))
            //{
            //    Response.Write("<script language=javascript>alert('对不起，接点人左区没有激活！');history.go(-1);</script>");
            //    return;

            //}

            //tbl_huiyuan model_th = new tbl_huiyuan();
            //model_th.GetModel_hui_bianhao("A00000000");
            //string huiyuan_shang_id = model_th.huiyuan_id;//推荐人huiyuan_id
            //model_th.GetModel_hui_bianhao("A00000000");
            //string huiyuan_jiedian = model_th.huiyuan_id;//接点人huiyuan_id
            //int tuijian_count = int.Parse(model_th.tuijian_count.ToString());
            //model_th.GetModel_hui_bianhao("A00000000");
            //string huiyuan_zm = model_th.huiyuan_id;//接点人huiyuan_id

            //if (tbl_huiyuan.Exists_jd_check(huiyuan_jiedian, int.Parse(this.zuoyou.SelectedValue)))
            //{
            //    Response.Write("<script language=javascript>alert('该市场位置上已经有人，请重新选择市场位置！');history.go(-1);</script>");
            //    return;

            //}

            //if (!tbl_huiyuan.Exists_jd_zuocheck(huiyuan_shang_id, int.Parse(this.zuoyou.SelectedValue)))
            //{
            //    Response.Write("<script language=javascript>alert('推荐的第一人必须放在左区，并且要激活！');history.go(-1);</script>");
            //    return;

            //}
            string uploadname1 = null, uploadname2 = null;
            if (shenfen_img.HasFile)
            {
                string FileName = shenfen_img.FileName;


                string FileLastName = FileName.Substring(FileName.LastIndexOf(".") + 1).ToLower();    //获取后缀名

                if (FileLastName != "gif" && FileLastName != "jpg" && FileLastName != "png")
                {
                    Response.Write("<script language=javascript>alert('请选择规定格式的图片！');history.go(-1);</script>");
                    return;
                }

                int FileLength = shenfen_img.PostedFile.ContentLength;
                //判断是否已经选取文件
                if (FileLength > 524000)
                {
                    Response.Write("<script language=javascript>alert('图片大小超标！');history.go(-1);</script>");
                    return;
                }
                Random R = new Random();
                int val = 10 + R.Next(99);
                string sc = val.ToString();         //获取随机数
                string FileTime = DateTime.Now.ToString("yyyyMMddHHmmss") + sc;
                uploadname1 = FileTime + "." + FileLastName;

                FileExtension[] fe = { FileExtension.GIF, FileExtension.JPG, FileExtension.PNG };
                if (FileValidation.IsAllowedExtension(shenfen_img, fe))
                {

                    string path = Server.MapPath("~/upload/pingju/");
                    shenfen_img.PostedFile.SaveAs(path + uploadname1);


                }
                else
                {
                    Response.Write("<script>alert('您只能上传jpg或者gif图片');history.go(-1);</script>");
                    return;
                }

            }
            else
            {
                Response.Write("<script language=javascript>alert('请上传身份证明图片！');history.go(-1);</script>");
                return;
            }
            if (zl_img.HasFile)
            {
                string FileName = zl_img.FileName;


                string FileLastName = FileName.Substring(FileName.LastIndexOf(".") + 1).ToLower();    //获取后缀名

                if (FileLastName != "gif" && FileLastName != "jpg" && FileLastName != "png")
                {
                    Response.Write("<script language=javascript>alert('请选择规定格式的图片！');history.go(-1);</script>");
                    return;
                }

                int FileLength = zl_img.PostedFile.ContentLength;
                //判断是否已经选取文件
                if (FileLength > 524000)
                {
                    Response.Write("<script language=javascript>alert('图片大小超标！');history.go(-1);</script>");
                    return;
                }
                Random R = new Random();
                int val = 10 + R.Next(99);
                string sc = val.ToString();         //获取随机数
                string FileTime = DateTime.Now.ToString("yyyyMMddHHmmss") + sc;
                uploadname2 = FileTime + "." + FileLastName;

                FileExtension[] fe = { FileExtension.GIF, FileExtension.JPG, FileExtension.PNG };
                if (FileValidation.IsAllowedExtension(zl_img, fe))
                {

                    string path = Server.MapPath("~/upload/pingju/");
                    zl_img.PostedFile.SaveAs(path + uploadname2);


                }
                else
                {
                    Response.Write("<script>alert('您只能上传jpg或者gif图片');history.go(-1);</script>");
                    return;
                }

            }
            else
            {
                Response.Write("<script language=javascript>alert('请上传本人期权证正面图片！');history.go(-1);</script>");
                return;
            }
            //decimal sum_zong = 0, sum_pv = 0;
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
            //if (sum_zong == 0)
            //{
            //    Response.Write("<script language=javascript>alert('您还没选择产品！');history.go(-1);</script>");
            //    return;
            //}

            //tbl_reg_jiebie jb = new tbl_reg_jiebie();
            //tbl_huiyuan hui_id = new tbl_huiyuan();
            //hui_id.GetModel_hui_id(Session["hy_id1"].ToString());
            //decimal need_money = jb.Get_Need_money(Convert.ToInt32(hui_id.huiyuan_jiebie));
            //if (need_money != sum_zong)
            //{
            //    Response.Write("<script language=javascript>alert('您选择的产品和注册级别不符！');history.go(-1);</script>");
            //    return;
            //}
            //if (sum_zong > 0)
            //{
            //    tbl_orders model = new tbl_orders();
            //    model.order_no = Utils.GetOrderNumber(); //订单号B开头为商品订单
            //    model.user_id = hui_id.huiyuan_id;
            //    model.user_bianhao = this.user_bianhao.Value.Trim(); ;
            //    //  model.depot_category_id = depot_category_id;
            //    //  model.depot_id = depot_id;
            //    model.user_name = this.username.Text.Trim();
            //    model.payment_id = 2;//支付方式
            //    //model.message = message.Text;
            //    model.payable_amount = sum_zong;
            //    model.real_amount = 0;
            //    model.phone = this.user_phone.Value.Trim();
            //    model.address = this.address.Value.Trim();

            //    //订单总金额=实付商品金额
            //    model.order_amount = sum_zong;//pv总值
            //    model.add_time = DateTime.Now;
            //    if (model.Add() == 0)
            //    {
            //        Response.Write("<script language=javascript>alert('保存失败！');history.go(-1);</script>");
            //        return;
            //    }
            //    tbl_order_goods gls = new tbl_order_goods();
            //    tbl_product my = new tbl_product();
            //    for (int x = 0; x < rptList.Items.Count; x++)
            //    {

            //        int id = Convert.ToInt32(((HiddenField)rptList.Items[x].FindControl("hidId")).Value);
            //        TextBox cbx = (TextBox)rptList.Items[x].FindControl("shuliang");//数量
            //        if (int.Parse(cbx.Text) > 0)
            //        {
            //            my.GetModel(id);
            //            gls.order_id = model.GetMaxId();
            //            gls.goods_id = id;
            //            gls.goods_title = my.pro_name;
            //            gls.goods_price = my.go_price;
            //            gls.real_price = my.go_price;
            //            gls.quantity = int.Parse(cbx.Text);
            //            gls.product_category_id = my.pro_pid;
            //            gls.dw = my.pro_danwei;
            //            gls.Add();

            //        }
            //        //TextBox cbx = (TextBox)rptList.Items[x].FindControl("shuliang");//数量
            //        Label textControl = (Label)rptList.Items[x].FindControl("Label2");//价格




            //    }

            //    tbl_xiaofei model_xf = new tbl_xiaofei();
            //    model_xf.xiaofei_hui_id = hui_id.huiyuan_id;
            //    model_xf.xiaofei_money = need_money;
            //    model_xf.xiaofei_money1 = sum_zong;
            //    model_xf.zhuce_flag = 1;
            //    model_xf.Add();

            //}

            if (DoEdit(Session["hy_id1"].ToString(), uploadname1, uploadname2))
            {
                Response.Write("<script language=javascript>alert('修改成功！');top.location.href='information.aspx';</script>");
                Response.End();

            }
        }
        else
        {
            if (DoEdit(Session["hy_id1"].ToString(), "", ""))
            {
                Response.Write("<script language=javascript>alert('修改成功！');top.location.href='information.aspx';</script>");
                Response.End();

            }
        }




        //写入

    }

    private void BindProvince()
    {

        string sql = "select ProID,ProName from T_Province";




        bind_Province.DataSource = DbHelperSQL.Query(sql);
        bind_Province.DataValueField = "ProID";
        bind_Province.DataTextField = "ProName";
        bind_Province.DataBind();

    }

    private void BindCity(string code)
    {
        string provinceCode = code;
        string sql = "select CityID,CityName from T_City where ProID='" + provinceCode + "'";
        //省份和城市进行关联

        bind_City.DataSource = DbHelperSQL.Query(sql);
        bind_City.DataValueField = "CityID";
        bind_City.DataTextField = "CityName";
        bind_City.DataBind();

    }

    private void BindBorough(string code)
    {
        string cityCode = code;
        //城市和地区进行关联
        string sql = "select Id,DisName from T_District where CityID='" + cityCode + "'";

        bind_Borough.DataSource = DbHelperSQL.Query(sql);
        bind_Borough.DataValueField = "Id";
        bind_Borough.DataTextField = "DisName";
        bind_Borough.DataBind();
    }

    protected void bind_City_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindBorough(bind_City.SelectedValue);

    }

    protected void bind_Province_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindCity(bind_Province.SelectedValue);
        BindBorough(bind_City.SelectedValue);
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