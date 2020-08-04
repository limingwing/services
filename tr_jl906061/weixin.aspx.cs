using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.IO;
using System.Text;
using Common;
using Newtonsoft.Json.Linq;

public partial class weixin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string postString = string.Empty;
        using (Stream stream = HttpContext.Current.Request.InputStream)
        {

            Byte[] postBytes = new Byte[stream.Length];
            stream.Read(postBytes, 0, (Int32)stream.Length);
            postString = Encoding.UTF8.GetString(postBytes);
        }
        tbl_canshu casnhu = new tbl_canshu();
        casnhu.GetModel(1);
        //casnhu.canshu_gonggao = jsonStr;
        casnhu.sys_name = postString;
        casnhu.Update();
        WeixinServer wx = new WeixinServer();
        wx.ProcessRequest(postString);
        
        
        
        //if (!string.IsNullOrEmpty(Request["echoStr"]))
        //{
        //    var echostr = Request["echoStr"];
        //    if (checkSignature() && !string.IsNullOrEmpty(echostr))
        //    {
        //        Response.Write(echostr);//推送  

        //        Response.End();
        //    }
        //}
    }
    //public bool checkSignature()
    //{
    //    var signature = Request["signature"];
    //    var timestamp = Request["timestamp"];
    //    var nonce = Request["nonce"];
    //    var token = "hellojl90606";
    //    string[] ArrTmp = { token, timestamp, nonce };
    //    Array.Sort(ArrTmp);     //字典排序  
    //    string tmpStr = string.Join("", ArrTmp);
    //    tmpStr = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(tmpStr, "SHA1");
    //    tmpStr = tmpStr.ToLower();
    //    if (tmpStr == signature)
    //    {
    //        //WeixinServer wx = new WeixinServer();
    //        //wx.JsCode2Session();
    //        //string token1 = wx.access_token;
    //        //Response.Write("<script language=javascript>alert('" + token1 + "！');history.go(-1);</script>");
    //        //wx.ProcessRequest();
    //        return true;
    //    }
    //    else
    //    {
    //        return false;
    //    }
    //}  
}