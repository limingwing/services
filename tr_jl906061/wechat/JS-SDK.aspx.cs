using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WechatService;

public partial class wechat_JS_SDK : WechatBasePage
{
    protected string appId = "", signature = "", access_token = "", ticket = "", nonceStr = "", url = "", timestamp = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            #region 获取单个公众号，多个的情况只取最后一个
            foreach (AccountInfo account in AccountInfoCollection.AccountInfos)
            {
                appId = account.AppId;
                access_token = WechatHelper.GetAccessToken(appId, account.AppSecret);
                ticket = WechatHelper.GetTicket(access_token);
                url = HttpContext.Current.Request.Url.ToString();//获得当前完整Url地址
                nonceStr = WechatHelper.CreatenNonceStr();
                timestamp = WechatHelper.CreatenTimestamp().ToString();
                signature = WechatHelper.GetSignature(ticket, nonceStr, timestamp, url);
            }
            #endregion
        }
    }
}