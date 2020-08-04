<%@ WebHandler Language="C#" Class="wechat" %>

using System;
using System.Web;
using System.Net;
using Common;
using WechatService;

public class wechat : IHttpHandler
{
    public void ProcessRequest(HttpContext context)
    {
        //初始化公众号信息
        AccountInfoCollection.SetAccountInfo(new AccountInfo("微信号", "AppID(应用ID)", "AppSecret(应用密钥)", "Token(令牌)", "EncodingAESKey(消息加解密密钥)", "自在饭"));
        if (context.Request.HttpMethod == WebRequestMethods.Http.Get)
        {
            if (Validate(context))
            {
                context.Response.Write(HandleGet(context));
            }
            else
            {
                LogHelper.Log("校验消息失败。\r\n地址：" + context.Request.RawUrl);
            }
        }
        else if (context.Request.HttpMethod == WebRequestMethods.Http.Post)
        {
           context.Response.Write(HandlePost(context));
        }
    }

    public bool IsReusable
    {
        get
        {
            return false;
        }
    }

    /// <summary>
    /// 验证消息的有效性
    /// </summary>
    /// <param name="context"></param>
    /// <returns>如果消息有效，返回true；否则返回false。</returns>
    private bool Validate(HttpContext context)
    {
        string username = "zizaifan", echoStr = AppRequest.GetQueryString("echoStr"), signature = AppRequest.GetQueryString("signature"),
            timestamp = AppRequest.GetQueryString("timestamp"), nonce = AppRequest.GetQueryString("nonce");
        AccountInfo account = AccountInfoCollection.GetAccountInfo(username);
        if (account == null)
        {
            return false;
        }
        string token = account.Token;
        if (WechatService.Utility.CheckSignature(signature, token, timestamp, nonce))
        {
            if (!string.IsNullOrEmpty(echoStr))
            {
                return true;
            }
        }
        return false;
    }

    /// <summary>
    /// 处理微信的GET请求，校验签名
    /// </summary>
    /// <param name="context"></param>
    /// <returns>返回echostr</returns>
    private string HandleGet(HttpContext context)
    {
        return AppRequest.GetQueryString("echostr");
    }

    /// <summary>
    /// 处理微信的POST请求
    /// </summary>
    /// <param name="context"></param>
    /// <returns>返回xml响应</returns>
    private string HandlePost(HttpContext context)
    {
        RequestMessageHelper helper = new RequestMessageHelper(context.Request);
        if (helper.Message != null)
        {
            LogHelper.Log(helper.Message.ToString() + ":" + MessageType.Request);
            ResponseBaseMessage responseMessage = HandleRequestMessage(helper.Message);
            LogHelper.Log(responseMessage.ToString() + ":" + MessageType.Response);
            return responseMessage.ToXml(helper.EncryptType);
        }
        else
            return string.Empty;
    }

    /// <summary>
    /// 处理请求消息，返回响应消息
    /// </summary>
    /// <returns>返回响应消息</returns>
    private ResponseBaseMessage HandleRequestMessage(RequestBaseMessage requestMessage)
    {
        ResponseTextMessage response = new ResponseTextMessage(requestMessage.FromUserName, requestMessage.ToUserName,
            DateTime.Now, string.Format("自动回复，请求内容如下：\r\n{0}", requestMessage));
        response.Content += "\r\n<a href=\"http://www.ziniusoft.com\">紫牛软件</a>";
        ErrorMessage errorMessage = CustomerService.SendMessage(new ResponseTextMessage(requestMessage.FromUserName, requestMessage.ToUserName, DateTime.Now, string.Format("自动回复客服消息，请求内容如下：\r\n{0}", requestMessage.ToString())));
        if (!errorMessage.IsSuccess)
            LogHelper.Log(MessageType.Exception + ":" + errorMessage.ToString());
        return response;
    }

}