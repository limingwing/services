using System.Text;
using System.Data;
using Common;
using System;
namespace WechatService
{
    /// <summary>
    /// 页面基类
    /// </summary>
    public partial class WechatBasePage : System.Web.UI.Page
    {
        /// <summary>
        /// 父类的构造函数
        /// </summary>
        public WechatBasePage()
        {
            this.Load += new EventHandler(BasePage_Load);
        }
        private void BasePage_Load(object sender, EventArgs e)
        {
            //初始化公众号信息
            AccountInfoCollection.SetAccountInfo(new AccountInfo("微信号", "AppID(应用ID)", "AppSecret(应用密钥)", "Token(令牌)", "EncodingAESKey(消息加解密密钥)", "自在饭"));
        }
    }
}
