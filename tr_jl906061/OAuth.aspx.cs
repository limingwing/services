using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Common;
using WechatService;
using Newtonsoft.Json.Linq;

public partial class OAuth : System.Web.UI.Page
{
    public string openid = "";
    public string accesstoken;
    public string nickname;
    public string sex;
    public string headimgurl;
    public string province;
    public string country;
    public string language;
    public string city;
    public string privilege = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        LogHelper.Log(MessageType.Request.ToString() + "+" + Request.RawUrl.ToString());
        string code = RequestEx.TryGetQueryString("code");
        string state = RequestEx.TryGetQueryString("state");
        if (!string.IsNullOrWhiteSpace(code))
        {
            string url = string.Format("https://api.weixin.qq.com/sns/oauth2/access_token?appid={0}&secret={1}&code={2}&grant_type=authorization_code", "wxdcf5fba0c0a88064", "5a32d0d24faedfa9a6070639f3a59f03", code);
            string result = HttpClientHelper.GetResponse(url);
            JObject outputObj = JObject.Parse(result);

            //微信认证部分：第四步 获得更多信息
            string accesstoken = outputObj["access_token"].ToString();
            openid = outputObj["openid"].ToString();

            LogHelper.Log(accesstoken + "////////" + openid);

            url = string.Format("https://api.weixin.qq.com/sns/userinfo?access_token={0}&openid={1}&lang=zh_CN", accesstoken, openid);
            string result1 = HttpClientHelper.GetResponse(url);
            JObject outputObj1 = JObject.Parse(result1);//将json转为数组
            //以下是第四步获得的信息：  
            nickname = outputObj1["nickname"].ToString(); //昵称
            sex = outputObj1["sex"].ToString(); //性别
            headimgurl = outputObj1["headimgurl"].ToString(); //头像url
            province = outputObj1["province"].ToString(); ;
            country = outputObj1["country"].ToString(); ;
            language = outputObj1["language"].ToString(); ;
            city = outputObj1["city"].ToString(); ;

        }
    }
}