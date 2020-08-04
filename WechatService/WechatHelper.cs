using Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web.Security;

namespace WechatService
{
    /// <summary>
    /// 微信JS-SDK
    /// </summary>
    public class WechatHelper
    {
        /// <summary>
        /// 获取AccessToken
        /// </summary>
        /// <param name="appID"></param>
        /// <param name="appsecret"></param>
        /// <returns></returns>
        public static string GetAccessToken(string appID, string appsecret)
        {
            string str = "";
            string url = @"https://api.weixin.qq.com/cgi-bin/token?grant_type=client_credential&appid=" + appID + "&secret=" + appsecret;
            WebRequest req = WebRequest.Create(url);
            WebResponse rep = req.GetResponse();
            Stream webstream = rep.GetResponseStream();
            StreamReader strRead = new StreamReader(webstream);
            string JSON = strRead.ReadToEnd();
            if (JSON.Contains("access_token"))
            {
                Dictionary<string, object> dt = JsonHelper.DataRowFromJSON(JSON);
                str = dt["access_token"].ToString();
            }
            return str;
        }
        // <summary>
        /// 获取jsapi_ticket
        /// jsapi_ticket是公众号用于调用微信JS接口的临时票据。
        /// 正常情况下，jsapi_ticket的有效期为7200秒，通过access_token来获取。
        /// 由于获取jsapi_ticket的api调用次数非常有限，频繁刷新jsapi_ticket会导致api调用受限，影响自身业务，开发者必须在自己的服务全局缓存jsapi_ticket 。
        /// </summary>
        /// <param name="access_token">BasicAPI获取的access_token,也可以通过TokenHelper获取</param>
        /// <returns></returns>
        public static string GetTicket(string access_token)
        {
            string str = "";
            string url = @"https://api.weixin.qq.com/cgi-bin/ticket/getticket?access_token=" + access_token + "&type=jsapi";
            WebRequest req = WebRequest.Create(url);
            WebResponse rep = req.GetResponse();
            Stream webstream = rep.GetResponseStream();
            StreamReader strRead = new StreamReader(webstream);
            string JSON = strRead.ReadToEnd();
            if (JSON.Contains("ticket"))
            {
                Dictionary<string, object> dt = JsonHelper.DataRowFromJSON(JSON);
                str = dt["ticket"].ToString();
            }
            return str;
        }
        public static string[] strs = new string[]
                               {
                                "a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z",
                                "A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"
                               };
        /// <summary>
        /// 创建随机字符串
        /// </summary>
        /// <returns></returns>
        public static string CreatenNonceStr()
        {
            Random r = new Random();
            var sb = new StringBuilder();
            var length = strs.Length;
            for (int i = 0; i < 15; i++)
            {
                sb.Append(strs[r.Next(length - 1)]);
            }
            return sb.ToString();
        }

        /// <summary>
        /// 创建时间戳
        /// </summary>
        /// <returns></returns>
        public static long CreatenTimestamp()
        {
            return (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000) / 10000000;
        }
        /// <summary>
        /// 签名算法
        /// </summary>
        /// <param name="jsapi_ticket">jsapi_ticket</param>
        /// <param name="noncestr">随机字符串(必须与wx.config中的nonceStr相同)</param>
        /// <param name="timestamp">时间戳(必须与wx.config中的timestamp相同)</param>
        /// <param name="url">当前网页的URL，不包含#及其后面部分(必须是调用JS接口页面的完整URL)</param>
        /// <returns></returns>
        public static string GetSignature(string jsapi_ticket, string noncestr, string timestamp, string url)
        {
            string tmpStr = "jsapi_ticket=" + jsapi_ticket + "&noncestr=" + noncestr + "&timestamp=" + timestamp + "&url=" + url;
            return FormsAuthentication.HashPasswordForStoringInConfigFile(tmpStr, "SHA1");
        }
    }
}
