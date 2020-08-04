using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WechatService;
using Newtonsoft.Json.Linq;
using Common;

public partial class Erweima : System.Web.UI.Page
{
    public string openid = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        string code = RequestEx.TryGetQueryString("code");
        string state = RequestEx.TryGetQueryString("state");
        if (!string.IsNullOrWhiteSpace(code))
        {
            string url = string.Format("https://api.weixin.qq.com/sns/oauth2/access_token?appid={0}&secret={1}&code={2}&grant_type=authorization_code", "wxdcf5fba0c0a88064", "5a32d0d24faedfa9a6070639f3a59f03", code);
            string result = HttpClientHelper.GetResponse(url);
            JObject outputObj = JObject.Parse(result);

            //微信认证部分：第四步 获得更多信息
            //string accesstoken = outputObj["access_token"].ToString();
            openid = outputObj["openid"].ToString();
        }
        if (openid != "")
        {
            tbl_huiyuan huiyuan_1 = new tbl_huiyuan();
            huiyuan_1.GetModel_hui_beizhu(openid);
            string dizhi = getPerpetualQR(huiyuan_1.flag_1.ToString());
            JObject outputObj1 = JObject.Parse(dizhi);//将json转为数组
            this.imgQrCode.ImageUrl = QrCode.GetUrl(outputObj1["ticket"].ToString());
        }
        //this.Label1.Text = openid;
        //this.Label2.Text = outputObj1["url"].ToString();
    }
    public static String getPerpetualQR(String account)
    {
        WeixinServer wx = new WeixinServer();
        string token = wx.access_token;
        //获取数据的地址（微信提供）
        String url = "https://api.weixin.qq.com/cgi-bin/qrcode/create?access_token={0}";
        url = string.Format(url, token);
        //发送给微信服务器的数据
        String jsonStr = "{\"action_name\": \"QR_LIMIT_SCENE\", \"action_info\":{\"scene\": {\"scene_id\": " + account + "}}}";
        tbl_canshu casnhu = new tbl_canshu();
        casnhu.GetModel(1);
        casnhu.canshu_gonggao = jsonStr;
        //casnhu.sys_name = shangid;
        casnhu.Update();
        //post请求得到返回数据（这里是封装过的，就是普通的java post请求）
        String response = wx.GetPage(url, jsonStr);
        return response;
    }
}