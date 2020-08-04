using System;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.IO;

public partial class reg_reg : System.Web.UI.Page
{
    ManagePage mym = new ManagePage();

    protected void Page_Load(object sender, EventArgs e)
    {

        ////判断是否登录
        if (!mym.IsAdminLogin())
        {
            Response.Write("<script>parent.location.href='../login.aspx'</script>");
            Response.End();
        }


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
                //this.huiyuan_jiedian.Text = Request.QueryString["jd_bianhao"].ToString();
                //this.zuoyou.SelectedValue = Request.QueryString["zuoyou"].ToString();
            }
            //RptBind();
            BindProvince();//绑定省
            BindCity(bind_Province.SelectedValue);//绑定市区
            BindBorough(bind_City.SelectedValue);//绑定县区
        }
    }
    //#region 数据绑定=================================
    //private void RptBind()
    //{
    //    tbl_product bll = new tbl_product();
    //    this.rptList.DataSource = bll.GetList(" pro_isok=1 order by salse_price asc");//pro_type=0 and 
    //    this.rptList.DataBind();
    //}
    //#endregion
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
        string huiyuan_id = DbHelperSQL.GetDataRow("exec sp_shengcheng_id")["aa"].ToString();
        tbl_reg_jiebie jb = new tbl_reg_jiebie();
        if (!tbl_huiyuan.Exists_cunzai(bas_tuijian.Text.Trim()))
        {
            Response.Write("<script language=javascript>alert('推荐人不存在！');history.go(-1);</script>");
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
        if (!tbl_huiyuan.Exists_zmd(this.huiyuan_zm.Text.Trim()))
        {
            Response.Write("<script language=javascript>alert('服务中心不存在！');history.go(-1);</script>");
            return;

        }


        //if (tbl_huiyuan.Exists_zuoqu_jihuo(this.huiyuan_jiedian.Text.Trim()))
        //{
        //    Response.Write("<script language=javascript>alert('对不起，接点人左区没有激活！');history.go(-1);</script>");
        //    return;

        //}
        if (tbl_huiyuan.Exists_tiaojian_check(" huiyuan_bianhao='" + bas_id1 + "'"))
        {
            Response.Write("<script language=javascript>alert('编号已经被注册！请重新选择');history.go(-1);</script>");
            return;

        }
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
        //if (tbl_huiyuan.Exists_tiaojian_check(" huiyuan_mob='" + Utils.Filter(this.bas_mob.Text.ToString()) + "'"))
        //{
        //    Response.Write("<script language=javascript>alert('手机号码已经被注册！');history.go(-1);</script>");
        //    return;

        //}
        if (tbl_huiyuan.Exists_tiaojian_check(" huiyuan_id='" + huiyuan_id + "'"))
        {
            Response.Write("<script language=javascript>alert('页面失效！请刷新！');history.go(-1);</script>");
            return;

        }
        //int leixing =int.Parse(this.leixing.SelectedValue);
        string uploadname1 = null, uploadname2 = null;
        //if (shenfen_img.HasFile)
        //{
        //    string FileName = shenfen_img.FileName;


        //    string FileLastName = FileName.Substring(FileName.LastIndexOf(".") + 1).ToLower();    //获取后缀名

        //    if (FileLastName != "gif" && FileLastName != "jpg" && FileLastName != "png")
        //    {
        //        Response.Write("<script language=javascript>alert('请选择规定格式的图片！');history.go(-1);</script>");
        //        return;
        //    }

        //    int FileLength = shenfen_img.PostedFile.ContentLength;
        //    //判断是否已经选取文件
        //    if (FileLength > 524000)
        //    {
        //        Response.Write("<script language=javascript>alert('图片大小超标！');history.go(-1);</script>");
        //        return;
        //    }
        //    Random R = new Random();
        //    int val = 10 + R.Next(99);
        //    string sc = val.ToString();         //获取随机数
        //    string FileTime = DateTime.Now.ToString("yyyyMMddHHmmss") + sc;
        //    uploadname1 = FileTime + "." + FileLastName;

        //    FileExtension[] fe = { FileExtension.GIF, FileExtension.JPG, FileExtension.PNG };
        //    if (FileValidation.IsAllowedExtension(shenfen_img, fe))
        //    {

        //        string path = Server.MapPath("~/upload/pingju/");
        //        shenfen_img.PostedFile.SaveAs(path + uploadname1);


        //    }
        //    else
        //    {
        //        Response.Write("<script>alert('您只能上传jpg或者gif图片');history.go(-1);</script>");
        //        return;
        //    }

        //}
        //else
        //{
        //    Response.Write("<script language=javascript>alert('请上传身份证明图片！');history.go(-1);</script>");
        //    return;
        //}
        //if (zl_img.HasFile)
        //{
        //    string FileName = zl_img.FileName;


        //    string FileLastName = FileName.Substring(FileName.LastIndexOf(".") + 1).ToLower();    //获取后缀名

        //    if (FileLastName != "gif" && FileLastName != "jpg" && FileLastName != "png")
        //    {
        //        Response.Write("<script language=javascript>alert('请选择规定格式的图片！');history.go(-1);</script>");
        //        return;
        //    }

        //    int FileLength = zl_img.PostedFile.ContentLength;
        //    //判断是否已经选取文件
        //    if (FileLength > 524000)
        //    {
        //        Response.Write("<script language=javascript>alert('图片大小超标！');history.go(-1);</script>");
        //        return;
        //    }
        //    Random R = new Random();
        //    int val = 10 + R.Next(99);
        //    string sc = val.ToString();         //获取随机数
        //    string FileTime = DateTime.Now.ToString("yyyyMMddHHmmss") + sc;
        //    uploadname2 = FileTime + "." + FileLastName;

        //    FileExtension[] fe = { FileExtension.GIF, FileExtension.JPG, FileExtension.PNG };
        //    if (FileValidation.IsAllowedExtension(zl_img, fe))
        //    {

        //        string path = Server.MapPath("~/upload/pingju/");
        //        zl_img.PostedFile.SaveAs(path + uploadname2);


        //    }
        //    else
        //    {
        //        Response.Write("<script>alert('您只能上传jpg或者gif图片');history.go(-1);</script>");
        //        return;
        //    }

        //}
        //else
        //{
        //    Response.Write("<script language=javascript>alert('请上传本人银行正面图片！');history.go(-1);</script>");
        //    return;
        //}

        tbl_huiyuan model_th = new tbl_huiyuan();
        model_th.GetModel_hui_bianhao(this.bas_tuijian.Text.Trim().ToString());
        string huiyuan_shang_id = model_th.huiyuan_id;//推荐人huiyuan_id
        model_th.GetModel_hui_bianhao(this.huiyuan_jiedian.Text.Trim().ToString());
        string huiyuan_jiedian = model_th.huiyuan_id;//接点人huiyuan_id
        int tuijian_count = int.Parse(model_th.tuijian_count.ToString());
        model_th.GetModel_hui_bianhao(this.huiyuan_zm.Text.Trim().ToString());//this.huiyuan_zm.Text
        string huiyuan_zm = model_th.huiyuan_id;//接点人huiyuan_id

        model_th.huiyuan_id = huiyuan_id;
        if (tbl_huiyuan.Exists_jd_check(huiyuan_jiedian, int.Parse(this.zuoyou.SelectedValue)))
        {
            Response.Write("<script language=javascript>alert('该市场位置上已经有人，请重新选择市场位置！');history.go(-1);</script>");
            return;

        }

        if (!tbl_huiyuan.Exists_jd_zuocheck(huiyuan_shang_id, int.Parse(this.zuoyou.SelectedValue)))
        {
            Response.Write("<script language=javascript>alert('推荐的第一人必须放在A区，并且要激活！');history.go(-1);</script>");
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
        //if (sum_zong == 0)
        //{
        //    Response.Write("<script language=javascript>alert('您还没选择产品！');history.go(-1);</script>");
        //    return;
        //}


        decimal need_money = jb.Get_Need_money(int.Parse(huiyuan_jiebie.SelectedValue));
        //if (need_money != sum_zong)
        //{
        //    Response.Write("<script language=javascript>alert('您选择的产品和注册级别不符！');history.go(-1);</script>");
        //    return;
        //}
        if (need_money > 0)
        {
            //tbl_orders model = new tbl_orders();
            //model.order_no = Utils.GetOrderNumber(); //订单号B开头为商品订单
            //model.user_id = huiyuan_id;
            //model.user_bianhao = this.bas_id1.Text.Trim(); ;
            ////  model.depot_category_id = depot_category_id;
            ////  model.depot_id = depot_id;
            //model.user_name = this.bas_name.Text.Trim();
            //model.payment_id = 2;//支付方式
            ////model.message = message.Text;
            //model.payable_amount = sum_zong;
            //model.real_amount = 0;
            //model.phone = this.bas_mob.Text;
            //model.address = this.huiyuan_address.Text;

            ////订单总金额=实付商品金额
            //model.order_amount = sum_zong;//pv总值
            //model.add_time = DateTime.Now;
            //if (model.Add() == 0)
            //{
            //    Response.Write("<script language=javascript>alert('保存失败！');history.go(-1);</script>");
            //    return;
            //}
            //tbl_order_goods gls = new tbl_order_goods();
            //tbl_product my = new tbl_product();
            //for (int x = 0; x < rptList.Items.Count; x++)
            //{

            //    int id = Convert.ToInt32(((HiddenField)rptList.Items[x].FindControl("hidId")).Value);
            //    TextBox cbx = (TextBox)rptList.Items[x].FindControl("shuliang");//数量
            //    if (int.Parse(cbx.Text) > 0)
            //    {
            //        my.GetModel(id);
            //        gls.order_id = model.GetMaxId();
            //        gls.goods_id = id;
            //        gls.goods_title = my.pro_name;
            //        gls.goods_price = my.go_price;
            //        gls.real_price = my.go_price;
            //        gls.quantity = int.Parse(cbx.Text);
            //        gls.product_category_id = my.pro_pid;
            //        gls.dw = my.pro_danwei;
            //        gls.Add();

            //    }
            //    //TextBox cbx = (TextBox)rptList.Items[x].FindControl("shuliang");//数量
            //    Label textControl = (Label)rptList.Items[x].FindControl("Label2");//价格




            //}

            tbl_xiaofei model_xf = new tbl_xiaofei();
            model_xf.xiaofei_hui_id = huiyuan_id;
            model_xf.xiaofei_money = need_money;
            model_xf.xiaofei_money1 = sum_zong;
            model_xf.zhuce_flag = 1;
            model_xf.Add();

        }


        //-----执行存储过程开始
        model_th.huiyuan_shang_id = huiyuan_shang_id;
        model_th.huiyuan_jiedian = huiyuan_jiedian;
        model_th.huiyuan_name = this.bas_name.Text.Trim();
        model_th.huiyuan_bianhao = this.bas_id1.Text.Trim();
        model_th.zuoyou = int.Parse(zuoyou.SelectedValue.ToString());
        model_th.huiyuan_id = huiyuan_id;
        model_th.Add_huiyuan1();
        //------执行存储过程结束
        //------更新开始
        model_th.GetModel_hui_id(huiyuan_id);
        model_th.huiyuan_zm = huiyuan_zm;
        model_th.huiyuan_mob = this.bas_mob.Text;
        model_th.huiyuan_jiebie = int.Parse(huiyuan_jiebie.SelectedValue);
        model_th.huiyuan_pass = huiyuan_pass1.Text;
        model_th.pass_two = pass_two1.Text;
        model_th.huiyuan_yinhang = bas_bankaddress.SelectedItem.Text;
        model_th.huiyuan_yinhang_zh = bas_bankaddress1.Text;
        model_th.huiyuan_yinhang_name = zhanghuming.Text;
        model_th.bank_zhi = bank_zhi.Text;
        model_th.huiyuan_address = huiyuan_address.Text;
        model_th.bid = int.Parse(bind_Province.SelectedValue);
        model_th.mmid = int.Parse(bind_City.SelectedValue);
        model_th.sid = int.Parse(bind_Borough.SelectedValue);
        model_th.flag_4 = 0;//可以提现
        model_th.huiyuan_shenfen_id = this.huiyuan_idcard.Text.Trim().ToString();
        model_th.weixin = this.weixin.Text.Trim().ToString();
        model_th.born_date = this.born.Text.Trim();
        //model_th.sf_pinju_src = "/upload/pingju/" + uploadname1;
        //model_th.zl_pinju_src = "/upload/pingju/" + uploadname2;

        //model_th.net_hege = 1;
        if (model_th.Update())
        {
            //int i = DbHelperSQL.ExecuteSql("exec sp_kaitong_huiyuan '" + huiyuan_id + "','A00000000'");
            Page.ClientScript.RegisterClientScriptBlock(Page.GetType(), "", "alert('恭喜注册成功。');window.location='../reg/reg.aspx';", true);
            return;
        }
        //------更新结束

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
}