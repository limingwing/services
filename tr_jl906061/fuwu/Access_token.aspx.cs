using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LitJson;
using System.Net;
using System.IO;
using System.Text;

public partial class fuwu_Access_token : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void button_get_Click(object sender, EventArgs e)
    {
        WeixinServer wx = new WeixinServer();
        //string a = wx.JsCode2Session();
        tbl_canshu canshu = new tbl_canshu();
        canshu.GetModel(1);
        canshu.id = 1;
        canshu.sys_name = wx.access_token;
        canshu.Update();
        
    }




    protected void button1_Click(object sender, EventArgs e)
    {
        tbl_canshu canshu = new tbl_canshu();
        canshu.GetModel(1);
        WeixinServer wx = new WeixinServer();
        wx.GetUserInfo(canshu.sys_name, "oNxcK0j0c2vIH0pgwdeVuhHNzNRs");
        Response.Write("<script language=javascript>alert('" + wx.nickname + "');history.go(-1);</script>");
        //GetUserInfo(canshu.sys_name, "oNxcK0j0c2vIH0pgwdeVuhHNzNRs");
        
    }

    //public void GetUserInfo(string token, string openid)
    //{
    //    string JsCode2SessionUrl = "https://api.weixin.qq.com/cgi-bin/user/info?access_token={0}&openid={1}";
    //    var url = string.Format(JsCode2SessionUrl, token, openid);
    //    var str = GetFunction(url);
    //    Response.Write("<script language=javascript>alert('" + str + "');history.go(-1);</script>");
    //    try
    //    {
    //        JsonData jo = JsonMapper.ToObject(str);
    //        string subscribe = jo["subscribe"].ToString();
    //        string openid1 = jo["openid"].ToString();
    //        string nickname = jo["nickname"].ToString();
    //        string sex = jo["sex"].ToString();
    //        string language = jo["language"].ToString();
    //        string city = jo["city"].ToString();
    //        string province = jo["province"].ToString();
    //        string country = jo["country"].ToString();
    //        string headimgurl = jo["headimgurl"].ToString();
    //        string subscribe_time = jo["subscribe_time"].ToString();
    //        string remark = jo["remark"].ToString();
    //        string groupid = jo["groupid"].ToString();
    //        string subscribe_scene = jo["subscribe_scene"].ToString();
    //        Response.Write("<script language=javascript>alert('" + nickname + "');history.go(-1);</script>");
    //    }
    //    catch (Exception ex)
    //    {
    //        Response.Write("<script language=javascript>alert('cuowu');history.go(-1);</script>");
    //    }
    //}
    ///// <summary>
    ///// URL提交GET
    ///// </summary>
    ///// <param name="url"></param>
    ///// <returns></returns>
    //public string GetFunction(string url)
    //{
    //    string serviceAddress = url;
    //    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(serviceAddress);
    //    request.Method = "GET";
    //    request.ContentType = "textml;charset=UTF-8";
    //    HttpWebResponse response = (HttpWebResponse)request.GetResponse();
    //    Stream myResponseStream = response.GetResponseStream();
    //    StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.UTF8);
    //    string retString = myStreamReader.ReadToEnd();
    //    myStreamReader.Close();
    //    myResponseStream.Close();
    //    return retString;
    //}

}