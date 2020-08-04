using System;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.IO;
using System.Net;
using System.Web;
using System.Web.Services;

public partial class shop_register : System.Web.UI.Page
{
    public static string big_img;
    public static string hui_shang_bianhao;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            logobind();
            Focus myFocus = new Focus();
            myFocus.SetEnterControl(this.bas_id1);
            myFocus.SetFocus(bas_id1.Page, "bas_id1");
            if (Request.QueryString["tj_id"] != null)
            {
                hui_shang_bianhao = Request.QueryString["tj_id"].ToString();
            }

        }
    }

    #region logo绑定=================================
    private void logobind()
    {




        tbl_sinkia_config bll = new tbl_sinkia_config();
        bll.GetModel(1);


        big_img = bll.logo_web_img;


    }
    #endregion

    #region 绑定银行=================================
    private void yhBind()
    {
        //tbl_reg_bank bll = new tbl_reg_bank();
        //DataTable dt = bll.GetList("1=1   order by sort_id").Tables[0];
        //this.bas_bankaddress.Items.Clear();
        //this.bas_bankaddress.Items.Add(new ListItem("请选择银行...", ""));
        //foreach (DataRow dr in dt.Rows)
        //{
        //    string Id = dr["bank_name"].ToString();
        //    string Title = dr["bank_name"].ToString().Trim();
        //    this.bas_bankaddress.Items.Add(new ListItem(Title, Id));
        //}
    }
    #endregion


    #region 绑定级别=================================
    private void QDBind()
    {
        //tbl_reg_jiebie bll = new tbl_reg_jiebie();
        //DataTable dt = bll.GetList("1=1 and show_flag=1 order by sort_id").Tables[0];
        //this.huiyuan_jiebie.Items.Clear();
        //this.huiyuan_jiebie.Items.Add(new ListItem("请选择会员级别...", ""));
        //foreach (DataRow dr in dt.Rows)
        //{
        //    string Id = dr["jiebie_value"].ToString();
        //    string Title = dr["jiebie_name"].ToString().Trim() + Math.Floor(double.Parse(dr["need_money"].ToString())) + "元";
        //    this.huiyuan_jiebie.Items.Add(new ListItem(Title, Id));
        //}
    }
    #endregion
    #region 数据绑定=================================
    private void RptBind()
    {
        //tbl_product bll = new tbl_product();
        //this.rptList.DataSource = bll.GetList(" pro_type=0 and pro_isok=1 order by salse_price asc");
        //this.rptList.DataBind();
    }
    #endregion
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        string huiyuan_id = DbHelperSQL.GetDataRow("exec sp_shengcheng_id")["aa"].ToString();
        tbl_reg_jiebie jb = new tbl_reg_jiebie();
        //if (!tbl_huiyuan.Exists_cunzai(bas_tuijian.Value.Trim()))
        //{
        //    Response.Write("<script language=javascript>alert('推荐人不存在！');history.go(-1);</script>");
        //    return;

        //}

        //if (this.bas_tuijian.Value == "")
        //{
        //    Response.Write("<script language=javascript>alert('推荐人必须填写！');history.go(-1);</script>");
        //    return;
        //}
        if (this.phone.Value == "")
        {
            Response.Write("<script language=javascript>alert('手机号码必须填写！');history.go(-1);</script>");
            return;
        }

        if (this.password.Value == "")
        {
            Response.Write("<script language=javascript>alert('设置密码必须填写！');history.go(-1);</script>");
            return;
        }
       
        //if (HttpContext.Current.Session["msgCode"] != null)
        //{
        //    if (HttpContext.Current.Session["msgCode"].ToString() != this.code.Value.Trim())
        //    {
        //        Response.Write("<script language=javascript>alert('验证码不正确！');history.go(-1);</script>");
        //        return;
        //    }
        //}
        //else
        //{
        //    Response.Write("<script language=javascript>alert('验证码必须获取！');history.go(-1);</script>");
        //    return;
        //}
        //if (this.zhanghuming.Value == "")
        //{
        //    Response.Write("<script language=javascript>alert('开户名必须填写！');history.go(-1);</script>");
        //    return;
        //}

        if (tbl_huiyuan.Exists_tiaojian_check(" huiyuan_mob='" + Utils.Filter(this.phone.Value) + "'"))
        {
            Response.Write("<script language=javascript>alert('手机号码已经被注册！');history.go(-1);</script>");
            return;

        }

        if (tbl_huiyuan.Exists_tiaojian_check(" huiyuan_bianhao='" + Utils.Filter(this.phone.Value) + "'"))
        {
            Response.Write("<script language=javascript>alert('编号已经被注册！请重新选择');history.go(-1);</script>");
            return;

        }
        if (tbl_huiyuan.Exists_tiaojian_check(" huiyuan_id='" + huiyuan_id + "'"))
        {
            Response.Write("<script language=javascript>alert('页面失效！请刷新！');history.go(-1);</script>");
            return;

        }
        //string uploadname1 = "", uploadname2 = "";
        //if (shenfen_img.HasFile)
        //{
        //    string FileName = shenfen_img.FileName;


        //    string FileLastName = FileName.Substring(FileName.LastIndexOf(".") + 1).ToLower();    //获取后缀名

        //    if (FileLastName != "gif" && FileLastName != "jpg" && FileLastName != "png")
        //    {
        //        Response.Write("<script language=javascript>alert('请选择规定格式的图片！');</script>");
        //        return;
        //    }

        //    int FileLength = shenfen_img.PostedFile.ContentLength;
        //    //判断是否已经选取文件
        //    if (FileLength > 524000)
        //    {
        //        Response.Write("<script language=javascript>alert('图片大小超标！');</script>");
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
        //        Response.Write("<script>alert('您只能上传jpg或者gif图片');</script>");
        //        return;
        //    }

        //}
        //else
        //{
        //    Response.Write("<script language=javascript>alert('请上传图片！');</script>");
        //    return;
        //}
        //if (zl_img.HasFile)
        //{
        //    string FileName = zl_img.FileName;


        //    string FileLastName = FileName.Substring(FileName.LastIndexOf(".") + 1).ToLower();    //获取后缀名

        //    if (FileLastName != "gif" && FileLastName != "jpg" && FileLastName != "png")
        //    {
        //        Response.Write("<script language=javascript>alert('请选择规定格式的图片！');</script>");
        //        return;
        //    }

        //    int FileLength = zl_img.PostedFile.ContentLength;
        //    //判断是否已经选取文件
        //    if (FileLength > 524000)
        //    {
        //        Response.Write("<script language=javascript>alert('图片大小超标！');</script>");
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
        //        Response.Write("<script>alert('您只能上传jpg或者gif图片');</script>");
        //        return;
        //    }

        //}
        //else
        //{
        //    Response.Write("<script language=javascript>alert('请上传图片！');</script>");
        //    return;
        //}
        tbl_huiyuan model_th = new tbl_huiyuan();
        //model_th.GetModel_hui_bianhao(bas_tuijian.Value.ToString());
        //string huiyuan_shang_id = model_th.huiyuan_id;//推荐人huiyuan_id
        //model_th.GetModel_hui_bianhao(this.huiyuan_jiedian.Value.Trim());
        //string huiyuan_jiedian = model_th.huiyuan_id;//接点人huiyuan_id
        //int tuijian_count = int.Parse(model_th.tuijian_count.ToString());
        //model_th.GetModel_hui_bianhao(this.huiyuan_zm.Value.Trim());
        //string huiyuan_zm = model_th.huiyuan_id;//接点人huiyuan_id

        model_th.huiyuan_id = huiyuan_id;

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


        //decimal need_money = jb.Get_Need_money(int.Parse(huiyuan_jiebie.SelectedValue));
        //if (need_money != sum_zong)
        //{
        //    Response.Write("<script language=javascript>alert('您选择的产品和注册级别不符！');history.go(-1);</script>");
        //    return;
        //}
        //if (sum_zong > 0)
        //{
        //    tbl_orders model = new tbl_orders();
        //    model.order_no = Utils.GetOrderNumber(); //订单号B开头为商品订单
        //    model.user_id = huiyuan_id;
        //    model.user_bianhao = this.bas_id1.Value.Trim(); ;
        //    //  model.depot_category_id = depot_category_id;
        //    //  model.depot_id = depot_id;
        //    model.user_name = this.name.Value.Trim();
        //    model.payment_id = 2;//支付方式
        //    //model.message = message.Text;
        //    model.payable_amount = sum_zong;
        //    model.real_amount = 0;
        //    model.phone = this.phone.Value.Trim();
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
        //    model_xf.xiaofei_hui_id = huiyuan_id;
        //    model_xf.xiaofei_money = need_money;
        //    model_xf.xiaofei_money1 = sum_zong;
        //    model_xf.zhuce_flag = 1;
        //    model_xf.Add();

        //}
        ////-----执行存储过程开始
        //model_th.huiyuan_shang_id = huiyuan_shang_id;
        //model_th.huiyuan_jiedian = huiyuan_jiedian;
        //model_th.huiyuan_name = this.zhanghuming.Value.ToString();
        model_th.huiyuan_name = model_th.huiyuan_bianhao = this.phone.Value.ToString();
        //model_th.zuoyou = int.Parse(this.zuoyou.SelectedValue);
        //model_th.Add_huiyuan();
        ////------执行存储过程结束
        ////------更新开始
        model_th.GetModel_hui_id(huiyuan_id);
        //model_th.huiyuan_zm = huiyuan_zm;
        model_th.huiyuan_mob = this.phone.Value.ToString();
        model_th.huiyuan_jiebie = 0;
        model_th.huiyuan_pass = this.password.Value.ToString();
        model_th.pass_two = password.Value.ToString();
        tbl_huiyuan huiyuan_model = new tbl_huiyuan();
        huiyuan_model.GetModel_hui_bianhao(hui_shang_bianhao);
        model_th.huiyuan_shang_id = huiyuan_model.huiyuan_id;
        model_th.net_hege = 0;
        if (model_th.Add())
        {
            HttpContext.Current.Session["msgCode"] = null;
            Page.ClientScript.RegisterClientScriptBlock(Page.GetType(), "", "alert('恭喜注册成功。');window.location='login.aspx';", true);
            return;
        }
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

    //[WebMethod]
    //public static string msgCode(string mobile)
    //{
    //    if (mobile.Length == 11)
    //    {
    //        string uid = "tianrui";
    //        string password = "b167d0f2f913b8843a491ce9d02bfaf5";
    //        Random rad = new Random();//实例化随机数产生器rad；

    //        int value = rad.Next(1000, 10000);//用rad生成大于等于1000，小于等于9999的随机数；

    //        string msg = "【电商】您好，本次注册验证码：" + value + "，5分钟内有效！";
    //        string s = GetHttpPost("http://api.sms.cn/mt/?uid=" + uid + "&pwd=" + password + "&mobile=" + mobile + "&content=" + msg + "", "gb2312");
    //        if (s.IndexOf("发送成功")>-1)
    //        {
    //            HttpContext.Current.Session.Add("msgCode", value);
    //            HttpContext.Current.Session.Timeout = 5;
    //            return "发送成功";
    //        }
    //        else
    //            return "发送失败";
    //    }
    //    else
    //    {
    //        return "发送失败";
    //    }
    //}

    public static string GetHttpPost(string url, string sEncoding)
    {


        try
        {
            WebClient WC = new WebClient();
            WC.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
            int p = url.IndexOf("?");
            string sData = url.Substring(p + 1);
            url = url.Substring(0, p);
            byte[] postData = Encoding.GetEncoding(sEncoding).GetBytes(sData);
            byte[] responseData = WC.UploadData(url, "POST", postData);
            string ct = Encoding.GetEncoding(sEncoding).GetString(responseData);
            return ct;

        }
        catch (Exception Ex)
        {
            return Ex.Message;

        }

    }
    protected void dyMobileButton_Click(object sender, EventArgs e)
    {

    }
}