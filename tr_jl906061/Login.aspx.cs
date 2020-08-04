using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WechatService;
using Newtonsoft.Json.Linq;
using Common;

public partial class Login : System.Web.UI.Page
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
        tbl_huiyuan model1 = new tbl_huiyuan();
        model1.GetModel_hui_beizhu(openid);
        if (model1.huiyuan_id != null)
        {
            //填写逻辑过程登录会员系统
            Session["hy_id1"] = model1.huiyuan_id;
            Session["hy_bianhao1"] = model1.huiyuan_bianhao;
            Session["hy_name1"] = model1.huiyuan_name;
            Session["hy_zm1"] = model1.huiyuan_zhuanmai;
            Session["hy_jiebie1"] = model1.huiyuan_jiebie;
            Session["huiyuan_zhuanmai1"] = model1.huiyuan_zhuanmai;
            Session["flag4"] = model1.flag_4;
            Session["zhongyao1"] = 1;
            ShopCart.Clear("0");
            //填写逻辑过程登录会员系统结束

            Response.Redirect("/shop/index.aspx");
            //this.Label1.Text = openid;
            //this.Label2.Text = outputObj1["url"].ToString();
        }
    }
}