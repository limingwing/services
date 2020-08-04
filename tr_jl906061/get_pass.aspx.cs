using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;

public partial class get_pass : System.Web.UI.Page
{
    tbl_huiyuan bll = new tbl_huiyuan();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //if (!tbl_huiyuan.Exists_cunzai(bianhao.Text.Trim()))
        //{
        //    Response.Write("<script language=javascript>alert('编号不存在！');history.go(-1);</script>");
        //    return;

        //}

        if (TextBox1.Text.Trim()=="")
        {
            Response.Write("<script language=javascript>alert('请输入手机号！');history.go(-1);</script>");
            return;

        }

        if (!tbl_huiyuan.Exists_tiaojian_check(" huiyuan_mob='" + Utils.Filter(this.TextBox1.Text.ToString()) + "'"))
        {
            Response.Write("<script language=javascript>alert('没有该手机号码会员！');history.go(-1);</script>");
            return;

        }

        //if (bianhao.Text.Trim() == "")
        //{
        //    Response.Write("<script language=javascript>alert('请输入会员编号！');history.go(-1);</script>");
        //    return;

        //}


        //int i = int.Parse(bll.GetTitleSum("huiyuan_mob='" + TextBox1.Text.Trim() + "' and huiyuan_bianhao='" + bianhao.Text.Trim() + "'", "count(1)"));
        //if (i == 0)
        //{

        //    Response.Write("<script language=javascript>alert('注册手机不符合！');history.go(-1);</script>");
        //    return;
        //}

        string r = SendNoteCode(TextBox1.Text.Trim());

        Response.Write("<script language=javascript>alert('发送成功，请关注手机短信！');location.href='get_pass.aspx';</script>");
        return;
 
    }

    public string SendNoteCode(string _tel)
    {
        //官方网站：http://www.56dxw.com 
        //  string scode = Request["txt_code"].ToString().Trim();

        string r = "no1";
        if (IsTel(_tel) == true)
        {
            bll.GetModel_hui_mob(TextBox1.Text.Trim());
            string huiyuan_pass = bll.huiyuan_pass;
            string pass_two = bll.pass_two;

            //string twcode = Session["GoogleCode"].ToString();


            //if (twcode == scode)
            //{
            string cid = "tianrui";

            string userpwd = "b167d0f2f913b8843a491ce9d02bfaf5";
            string s_snumber = Number(6, false);

            //由于语音传过去的只是数字即可，文字验证码可以写上内容
            // string msg = "您的验证码是：" + s_snumber + "【56短信网】";//【56短信网】 可以换成自己的签名，签名一般用公司或网站的简称

            string msg = Server.UrlEncode("【双诚行动】尊敬的会员，您的编号为" + bll.huiyuan_bianhao.Trim() + "，您的一级密码" + huiyuan_pass + "，二级密码" + pass_two + "，请勿告诉他人！");
        
            //msg = HttpUtility.UrlEncode(msg, System.Text.Encoding.GetEncoding("gbk"));//由于网站是utf-8编码，要进行一下转码，不然会是乱码,调用webs的不用转码
            string tel = _tel;
            tbl_jhm jhm = new tbl_jhm();
            jhm.createtime = DateTime.Now;
            jhm.jhm = s_snumber;
            jhm.huiyuan_mob = _tel;
            jhm.Add();


            //发送语音短信用这个接口，只是修改一下文件名称，用户名和密码,企业ID都不用修改的，还是很方便的
            //string url = "http://api.sms.cn/mt/?uid=" + cid + "&pwd=" + userpwd + "&mobile=" + _tel + "&content=" + msg + "";
            string url = "http://apis.haoservice.com/sms/sendv2?mobile=" + _tel + "&tpl_id=2152&content=" + msg + "&key=14e72eaef77b4c67b6869e64069ad8b9";
           // Response.Write(url);
           // Response.End();
            r = GetHttpPost(url, "gb2312");


            //}
            //else
            //{
            //    r = "no1";
            //}
        }
        else
        {
            r = "notel";
        }
        return r;
    }


    #region 生成随机数

    /// <summary>
    /// 生成随机数字
    /// </summary>
    /// <param name="length">生成长度</param>
    /// <returns></returns>
    public static string Number(int Length)
    {
        return Number(Length, false);
    }

    /// <summary>
    /// 生成随机数字
    /// </summary>
    /// <param name="Length">生成长度</param>
    /// <param name="Sleep">是否要在生成前将当前线程阻止以避免重复</param>
    /// <returns></returns>
    public static string Number(int Length, bool Sleep)
    {
        if (Sleep)
            System.Threading.Thread.Sleep(3);
        string result = "";
        System.Random random = new Random();
        for (int i = 0; i < Length; i++)
        {
            result += random.Next(10).ToString();
        }
        return result;
    }

    /// <summary>
    /// 生成随机字母与数字
    /// </summary>
    /// <param name="IntStr">生成长度</param>
    /// <returns></returns>
    public static string Str(int Length)
    {
        return Str(Length, false);
    }
    /// <summary>
    /// 生成随机字母与数字
    /// </summary>
    /// <param name="Length">生成长度</param>
    /// <param name="Sleep">是否要在生成前将当前线程阻止以避免重复</param>
    /// <returns></returns>
    public static string Str(int Length, bool Sleep)
    {
        if (Sleep)
            System.Threading.Thread.Sleep(3);
        char[] Pattern = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        string result = "";
        int n = Pattern.Length;
        System.Random random = new Random(~unchecked((int)DateTime.Now.Ticks));
        for (int i = 0; i < Length; i++)
        {
            int rnd = random.Next(0, n);
            result += Pattern[rnd];
        }
        return result;
    }


    /// <summary>
    /// 验证手机号
    /// </summary>
    /// <param name="tel"></param>
    /// <returns></returns>
    public static bool IsTel(string tel)
    {

        if (string.IsNullOrEmpty(tel))
        {
            return false;
        }
        else
        {
            string pattern = "^1[3|4|5|7|8]\\d{9}$";
            if (Regex.Match(tel, pattern, RegexOptions.Compiled).Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }



    /// <summary>
    /// 生成随机纯字母随机数
    /// </summary>
    /// <param name="IntStr">生成长度</param>
    /// <returns></returns>
    public static string Str_char(int Length)
    {
        return Str_char(Length, false);
    }

    /// <summary>
    /// 生成随机纯字母随机数
    /// </summary>
    /// <param name="Length">生成长度</param>
    /// <param name="Sleep">是否要在生成前将当前线程阻止以避免重复</param>
    /// <returns></returns>
    public static string Str_char(int Length, bool Sleep)
    {
        if (Sleep)
            System.Threading.Thread.Sleep(3);
        char[] Pattern = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        string result = "";
        int n = Pattern.Length;
        System.Random random = new Random(~unchecked((int)DateTime.Now.Ticks));
        for (int i = 0; i < Length; i++)
        {
            int rnd = random.Next(0, n);
            result += Pattern[rnd];
        }
        return result;
    }


    /// <summary>
    /// 生成随机纯字母随机数
    /// </summary>
    /// <param name="Length">生成长度</param>
    /// <param name="Sleep">是否要在生成前将当前线程阻止以避免重复</param>
    /// <returns></returns>
    public static string Str_charSamll(int Length, bool Sleep)
    {
        if (Sleep)
            System.Threading.Thread.Sleep(3);
        char[] Pattern = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        string result = "";
        int n = Pattern.Length;
        System.Random random = new Random(~unchecked((int)DateTime.Now.Ticks));
        for (int i = 0; i < Length; i++)
        {
            int rnd = random.Next(0, n);
            result += Pattern[rnd];
        }
        return result;
    }

    #endregion


    #region  get方式提交
    public string GetHttpPost(string url, string sEncoding)
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


    #endregion

}