using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LitJson;
using System.Net;
using System.IO;
using System.Text;
using System.Xml;
using Newtonsoft.Json.Linq;
using Common;

/// <summary>
///WeixinServer 的摘要说明
/// </summary>
public class WeixinServer
{
    private static DateTime GetAccessToken_Time;
    private static string _access_token = "";
    private static int _datetime = 7200;
    private static string _subscribe = "";
    private static string _openid = "";
    private static string _nickname = "";
    private static string _sex = "";
    private static string _language = "";
    private static string _city = "";
    private static string _province = "";
    private static string _country = "";
    private static string _headimgurl = "";
    private static string _subscribe_time = "";
    private static string _remark = "";
    private static string _groupid = "";
    private static Array _tagid_list;
    private static string _subscribe_scene = "";
    /// <summary>
    /// 构造函数
    /// </summary>
	public WeixinServer()
	{
        //access_token = JsCode2Session();
	}
    /// <summary>
    /// 微信token
    /// </summary>
    public string access_token
    {
        set { _access_token = value; }
        get {
            //if (string.IsNullOrEmpty(_access_token) || HasExpired())
            //{//获取
            //    _access_token = JsCode2Session();
            //}
            return _access_token;
        }
    }
    public int datetime
    {
        set { _datetime = value; }
        get { return _datetime; }
    }
    public string subscribe
    {
        set { _subscribe = value; }
        get { return _subscribe; }
    }
    public string openid
    {
        set { _openid = value; }
        get { return _openid; }
    }
    public string nickname
    {
        set { _nickname = value; }
        get { return _nickname; }
    }
    public string sex
    {
        set { _sex = value; }
        get { return _sex; }
    }
    public string language
    {
        set { _language = value; }
        get { return _language; }
    }
    public string city
    {
        set { _city = value; }
        get { return _city; }
    }
    public string province
    {
        set { _province = value; }
        get { return _province; }
    }
    public string country
    {
        set { _country = value; }
        get { return _country; }
    }
    public string headimgurl
    {
        set { _headimgurl = value; }
        get { return _headimgurl; }
    }
    public string subscribe_time
    {
        set { _subscribe_time = value; }
        get { return _subscribe_time; }
    }
    public string remark
    {
        set { _remark = value; }
        get { return _remark; }
    }
    public string groupid
    {
        set { _groupid = value; }
        get { return _groupid; }
    }
    public Array tagid_list
    {
        set { _tagid_list = value; }
        get { return _tagid_list; }
    }
    public string subscribe_scene
    {
        set { _subscribe_scene = value; }
        get { return _subscribe_scene; }
    }
    /// <summary>
    /// 获取微信token
    /// </summary>
    /// <returns></returns>
    public string JsCode2Session()
    {
        
            
            string appid = "wxdcf5fba0c0a88064";
            string secret = "5a32d0d24faedfa9a6070639f3a59f03";
            string JsCode2SessionUrl = "https://api.weixin.qq.com/cgi-bin/token?grant_type=client_credential&appid={0}&secret={1}";
            var url = string.Format(JsCode2SessionUrl, appid, secret);
            var str = GetFunction(url);
            try
            {
                JsonData jo = JsonMapper.ToObject(str);
                _access_token = jo["access_token"].ToString();
                if (_access_token != null)
                {
                    GetAccessToken_Time = DateTime.Now;
                    if (jo["expires_in"] != null)
                    {
                        _datetime = int.Parse(jo["expires_in"].ToJson());
                    }
                    return _access_token;
                }
                else
                {
                    GetAccessToken_Time = DateTime.MinValue;
                }

                return null;
            }
            catch (Exception ex)
            {
                return "";
            }
        
    }

    /// <summary>
    /// 获取关注者列表openid
    /// </summary>
    /// <param name="token"></param>
    /// <returns></returns>
    public string GetUseropenid(string token)
    {
        string JsCode2SessionUrl = "https://api.weixin.qq.com/cgi-bin/user/get?access_token={0}&next_openid={1}";
        var url = string.Format(JsCode2SessionUrl, token, "");
        var str = GetFunction(url);
        try
        {
            JsonData jo = JsonMapper.ToObject(str);
            string next_openid = jo["next_openid"].ToString();
            return next_openid;
        }
        catch (Exception ex)
        {
            return "";
        }
    }

    public void GetUserInfo(string token, string openid)
    {
        string JsCode2SessionUrl = "https://api.weixin.qq.com/cgi-bin/user/info?access_token={0}&openid={1}";
        var url = string.Format(JsCode2SessionUrl, token, openid);
        var str = GetFunction(url);
        try
        {
            JsonData jo = JsonMapper.ToObject(str);
            this.subscribe = jo["subscribe"].ToString();
            this.openid = jo["openid"].ToString();
            this.nickname = jo["nickname"].ToString();
            this.sex = jo["sex"].ToString();
            this.language = jo["language"].ToString();
            this.city = jo["city"].ToString();
            this.province = jo["province"].ToString();
            this.country = jo["country"].ToString();
            this.headimgurl = jo["headimgurl"].ToString();
            this.subscribe_time = jo["subscribe_time"].ToString();
            this.remark = jo["remark"].ToString();
            this.groupid = jo["groupid"].ToString();
            this.subscribe_scene = jo["subscribe_scene"].ToString();
        }
        catch (Exception ex)
        {
            
        }
    }
    /// <summary>
    /// URL提交GET
    /// </summary>
    /// <param name="url"></param>
    /// <returns></returns>
    public string GetFunction(string url)
    {
        string serviceAddress = url;
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(serviceAddress);
        request.Method = "GET";
        request.ContentType = "textml;charset=UTF-8";
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        Stream myResponseStream = response.GetResponseStream();
        StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.UTF8);
        string retString = myStreamReader.ReadToEnd();
        myStreamReader.Close();
        myResponseStream.Close();
        return retString;
    }
    public void ProcessRequest(string jsonXML)
    {
        //context.Response.ContentType = "text/plain";
        string openid1=string.Empty;
        string postString = string.Empty;
        string shangid = "A00000000";
        if (HttpContext.Current.Request.HttpMethod.ToUpper() == "POST")
        {
            //using (Stream stream = HttpContext.Current.Request.InputStream)
            //{
                
            //    Byte[] postBytes = new Byte[stream.Length];
            //    stream.Read(postBytes, 0, (Int32)stream.Length);
            //    postString = Encoding.UTF8.GetString(postBytes);
            //}
            postString = jsonXML;
            //自定义菜单token的获取 是用 下面的两个参数 获取的 不能直接用 公众平台的token
            //WeixinServer wx1 = new WeixinServer();
            access_token = GetAccessToken();
            //本人不喜欢 后台 json的操作 直接截取就可以了 得到的就是 token 或者 自己 获取 json的token
            access_token = access_token.Substring(17, access_token.Length - 37);
            if (!string.IsNullOrEmpty(postString))
            {
                //openid1 = PutXML(postString);
                shangid = "1";// PutXML1(postString);
                ResponseXML(postString);//返回给微信用户信息
                
            }
            
            ///加载自定义菜单
            StringBuilder sb = new StringBuilder();
            sb.Append("{");
            sb.Append("\"button\":[ ");
            sb.Append("{ ");
            sb.Append("\"name\":\"微信商城\",");
            sb.Append("\"sub_button\":[");
            sb.Append("{ ");
            sb.Append("\"type\":\"view\",");
            sb.Append("\"name\":\"进入商城\", ");
            sb.Append("\"url\":\"https://open.weixin.qq.com/connect/oauth2/authorize?appid=wxdcf5fba0c0a88064&redirect_uri=http://jl90606.jsqe100.com/Login.aspx&response_type=code&scope=snsapi_userinfo&state=1#wechat_redirect" + "" + "\"");
            sb.Append("}");
            sb.Append("]");
            sb.Append("},");
            //sb.Append("{");
            //sb.Append("\"name\":\"微信推广\", ");
            //sb.Append("\"sub_button\":[");
            //sb.Append("{ ");
            //sb.Append("\"type\":\"view\",");
            //sb.Append("\"name\":\"二维码\", ");
            //sb.Append("\"url\":\"https://open.weixin.qq.com/connect/oauth2/authorize?appid=wxdcf5fba0c0a88064&redirect_uri=http://jl90606.jsqe100.com/Erweima.aspx&response_type=code&scope=snsapi_userinfo&state=1#wechat_redirect" + "" + "\"");
            //sb.Append("}");
            //sb.Append("]");
            //sb.Append("},");
            //sb.Append("{");
            //sb.Append("\"name\":\"员工自助\",");
            //sb.Append("\"sub_button\":[");
            //sb.Append("{ ");
            //sb.Append("\"type\":\"click\",");
            //sb.Append("\"name\":\"我的薪资\", ");
            //sb.Append("\"key\":\"mysalary\"");
            //sb.Append("},");
            //sb.Append("{ ");
            //sb.Append("\"type\":\"view\",");
            //sb.Append("\"name\":\"个人中心\", ");
            //sb.Append("\"url\":\"https://open.weixin.qq.com/connect/oauth2/authorize?appid=wxdcf5fba0c0a88064&redirect_uri=" + HttpUtility.UrlEncode("/UserLogin.aspx") + "&response_type=code&scope=snsapi_base&state=" + new Random().Next(1000, 200000).ToString() + "#wechat_redirect\"");
            //sb.Append("},");
            //sb.Append("{ ");
            //sb.Append("\"type\":\"view\",");
            //sb.Append("\"name\":\"在线提问\", ");
            //sb.Append("\"url\":\"https://open.weixin.qq.com/connect/oauth2/authorize?appid=wxdcf5fba0c0a88064&redirect_uri=" + HttpUtility.UrlEncode("/UserCenter/question/MyQuestion.aspx") + "&response_type=code&scope=snsapi_base&state=" + new Random().Next(1000, 200000).ToString() + "#wechat_redirect\"");
            //sb.Append("}]");
            sb.Append("}]");
            sb.Append("}");

            
            //加载菜单
            string i = GetPage("https://api.weixin.qq.com/cgi-bin/menu/create?access_token=" + access_token, sb.ToString());
            
            
            //tbl_canshu casnhu = new tbl_canshu();
            //casnhu.GetModel(1);
            //casnhu.canshu_gonggao = openid;
            //casnhu.sys_name = shangid;
            //casnhu.Update();
        }
        else
        {
            //checkSignature(); //微信接入的测试
        }

    }
    /// <summary>
    /// 获取通行证
    /// </summary>
    /// <returns></returns>
    public string GetAccessToken()
    {
        string url_token = "https://api.weixin.qq.com/cgi-bin/token?grant_type=client_credential&appid=wxdcf5fba0c0a88064&secret=5a32d0d24faedfa9a6070639f3a59f03";
        HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(url_token);
        myRequest.Method = "GET";
        HttpWebResponse myResponse = (HttpWebResponse)myRequest.GetResponse();
        StreamReader reader = new StreamReader(myResponse.GetResponseStream(), Encoding.UTF8);
        string content = reader.ReadToEnd();
        reader.Close();
        return content;
    }
    /// <summary>
    /// 判断Access_token是否过期
    /// </summary>
    /// <returns>bool</returns>
    private static bool HasExpired()
    {
        if (GetAccessToken_Time != null)
        {
            //过期时间，允许有一定的误差，一分钟。获取时间消耗
            if (DateTime.Now > GetAccessToken_Time.AddSeconds(_datetime).AddSeconds(-60))
            {
                return true;
            }
        }
        return false;
    }
    // <summary>
    // 加载菜单项
    // </summary>
    // <param name="p"></param>
    // <param name="postData"></param>
    // <returns></returns>
    public string GetPage(string p, string postData)
    {
        Stream outstream = null;
        Stream instream = null;
        StreamReader sr = null;
        HttpWebResponse response = null;
        HttpWebRequest request = null;
        Encoding encoding = Encoding.UTF8;
        byte[] data = encoding.GetBytes(postData);
        // 准备请求...
        try
        {
            // 设置参数
            request = WebRequest.Create(p) as HttpWebRequest;
            CookieContainer cookieContainer = new CookieContainer();
            request.CookieContainer = cookieContainer;
            request.AllowAutoRedirect = true;
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = data.Length;
            outstream = request.GetRequestStream();
            outstream.Write(data, 0, data.Length);
            outstream.Close();
            //发送请求并获取相应回应数据
            response = request.GetResponse() as HttpWebResponse;
            //直到request.GetResponse()程序才开始向目标网页发送Post请求
            instream = response.GetResponseStream();
            sr = new StreamReader(instream, encoding);
            //返回结果网页（html）代码
            string content = sr.ReadToEnd();
            string err = string.Empty;
            return content;
        }
        catch (Exception ex)
        {
            string err = ex.Message;
            return string.Empty;
        }
    }
    public string PutXML1(string postString)
    {
        //使用XMLDocument加载信息结构                     
        XmlDocument xmlDoc1 = new XmlDocument();
        xmlDoc1.LoadXml(postString);
        
        XmlElement rootElement1 = xmlDoc1.DocumentElement;//获取文档的根

        RequestXML requestXML1 = new RequestXML();//声明实例，获取各个属性并赋值
        requestXML1.EventKey = rootElement1.SelectSingleNode("Ticket").InnerText;//scene_id
        string s1 = requestXML1.EventKey;
        return s1;
    }
    public string PutXML(string postString)
    {
        XmlDocument xmlDoc2 = new XmlDocument();
        xmlDoc2.LoadXml(postString);
        
        XmlElement rootElement2 = xmlDoc2.DocumentElement;//获取文档的根

        XmlNode MsgType = rootElement2.SelectSingleNode("MsgType"); //获取消息的文本类型

        RequestXML requestXML2 = new RequestXML();//声明实例，获取各个属性并赋值
        requestXML2.ToUserName = rootElement2.SelectSingleNode("ToUserName").InnerText;//公众号
        requestXML2.FromUserName = rootElement2.SelectSingleNode("FromUserName").InnerText;//用户
        requestXML2.CreateTime = rootElement2.SelectSingleNode("CreateTime").InnerText;//创建时间
        requestXML2.MsgType = MsgType.InnerText;//消息类型
        string s2 = requestXML2.FromUserName;
        return s2;
    }
    private void ResponseXML(string postString)
    {
        //使用XMLDocument加载信息结构                     
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.LoadXml(postString);
        
        XmlElement rootElement = xmlDoc.DocumentElement;//获取文档的根

        XmlNode MsgType = rootElement.SelectSingleNode("MsgType"); //获取消息的文本类型

        RequestXML requestXML = new RequestXML();//声明实例，获取各个属性并赋值
        requestXML.ToUserName = rootElement.SelectSingleNode("ToUserName").InnerText;//公众号
        requestXML.FromUserName = rootElement.SelectSingleNode("FromUserName").InnerText;//用户
        requestXML.CreateTime = rootElement.SelectSingleNode("CreateTime").InnerText;//创建时间
        requestXML.MsgType = MsgType.InnerText;//消息类型

        ///对消息的不同类型进行赋值
        if (requestXML.MsgType == "text")
        {
            //赋值文本信息内容
            requestXML.Content = rootElement.SelectSingleNode("Content").InnerText;

        }
        if (requestXML.MsgType.Trim() == "location")
        {
            ///赋值地理位置纬度，经度，地图缩放比例，地理位置说明
            requestXML.Location_X = rootElement.SelectSingleNode("Location_X").InnerText;
            requestXML.Location_Y = rootElement.SelectSingleNode("Location_Y").InnerText;
            requestXML.Scale = rootElement.SelectSingleNode("Scale").InnerText;
            requestXML.Label = rootElement.SelectSingleNode("Label").InnerText;
        }
        if (requestXML.MsgType.Trim().ToLower() == "event")
        {
            ///赋值事件名称和事件key值
            requestXML.EventName = rootElement.SelectSingleNode("Event").InnerText;
            requestXML.EventKey = rootElement.SelectSingleNode("EventKey").InnerText;

        }

        if (requestXML.MsgType.Trim().ToLower() == "voice")
        {
            ///赋值语音识别结果，赋值之前一定要记得在开发者模式下，把语音识别功能开启，否则获取不到
            requestXML.Recognition = rootElement.SelectSingleNode("Recognition").InnerText;

        }
        ResponseMsg(requestXML);

    }
    private void ResponseMsg(RequestXML requestXML)
    {
        string MsgType = requestXML.MsgType;

        try
        {
            //根据消息类型判断发送何种类型消息
            switch (MsgType)
            {
                case "text":
                    SendTextCase(requestXML);//发送文本消息
                    break;
                case "event"://发送事件消息
                    if (!string.IsNullOrWhiteSpace(requestXML.EventName) && requestXML.EventName.ToString().Trim().Equals("subscribe"))
                    {
                        GetUserInfo(access_token, requestXML.FromUserName);
                        tbl_huiyuan huiyuan_model = new tbl_huiyuan();
                        huiyuan_model.GetModel_hui_beizhu(requestXML.FromUserName);
                        if (huiyuan_model.huiyuan_id == null)
                        {
                            tbl_huiyuan shang_huiyuan = new tbl_huiyuan();
                            shang_huiyuan.GetModel_hui_ticket(requestXML.EventKey);
                            tbl_huiyuan model_th = new tbl_huiyuan();
                            string huiyuan_id = DbHelperSQL.GetDataRow("exec sp_shengcheng_id")["aa"].ToString();
                            string bas_id1 = DbHelperSQL.GetDataRow("exec sp_shengcheng_bianhao")["aa"].ToString();
                            string huiyuan_shang_id = "A00000000";
                            string huiyuan_jiedian = "A00000000";
                            string huiyuan_zm = "A00000000";
                            if (shang_huiyuan.huiyuan_id != null)
                            {
                                huiyuan_shang_id = shang_huiyuan.huiyuan_id;
                            }
                            if (tbl_huiyuan.Exists_tiaojian_check(" huiyuan_id='" + huiyuan_id + "'"))
                            {
                                huiyuan_id = DbHelperSQL.GetDataRow("exec sp_shengcheng_id")["aa"].ToString();

                            }
                            if (tbl_huiyuan.Exists_tiaojian_check(" huiyuan_bianhao='" + bas_id1 + "'"))
                            {
                                bas_id1 = DbHelperSQL.GetDataRow("exec sp_shengcheng_bianhao")["aa"].ToString();

                            }
                            model_th.huiyuan_id = huiyuan_id;
                            model_th.huiyuan_shang_id = huiyuan_shang_id;
                            model_th.huiyuan_jiedian = huiyuan_jiedian;
                            model_th.huiyuan_name = nickname;
                            model_th.huiyuan_bianhao = bas_id1;
                            model_th.zuoyou = 1;// int.Parse(zuoyou.SelectedValue.ToString());
                            model_th.huiyuan_id = huiyuan_id;
                            model_th.Add_huiyuan1();
                            int dr = int.Parse(DbHelperSQL.GetDataRow("select top 1 aa=flag_1 from tbl_huiyuan order by flag_1 desc")["aa"].ToString());
                            
                            model_th.GetModel_hui_id(huiyuan_id);
                            model_th.huiyuan_zm = huiyuan_zm;
                            //model_th.huiyuan_mob = this.bas_mob.Text;
                            model_th.huiyuan_jiebie = 0;
                            model_th.huiyuan_pass = "111111";
                            model_th.pass_two = "222222";
                            model_th.beizhu = openid;
                            //model_th.huiyuan_yinhang = bas_bankaddress.SelectedItem.Text;
                            //model_th.huiyuan_yinhang_zh = bas_bankaddress1.Text;
                            //model_th.huiyuan_yinhang_name = zhanghuming.Text;
                            //model_th.bank_zhi = bank_zhi.Text;
                            //model_th.huiyuan_address = huiyuan_address.Text;
                            //model_th.bid = province;
                            //model_th.mmid = city;
                            //model_th.sid = int.Parse(bind_Borough.SelectedValue);
                            model_th.flag_1 = dr+1;//可以提现
                            //model_th.huiyuan_shenfen_id = this.huiyuan_idcard.Text.Trim().ToString();
                            //model_th.weixin = this.weixin.Text.Trim().ToString();
                            model_th.born_date = DateTime.Now.ToString();
                            model_th.huiyuan_shangshu = headimgurl;
                            model_th.zhifubao = "qrscene_" + model_th.flag_1;
                            model_th.net_hege = 1;
                            model_th.Update();

                        }
                        SendWelComeMsg(requestXML);//关注时返回的图文消息
                    }
                    else if (!string.IsNullOrWhiteSpace(requestXML.EventName) && requestXML.EventName.ToString().Trim().Equals("CLICK"))
                    {
                        SendEventMsg(requestXML);//发送事件消息
                    }
                    break;

                case "voice":
                    SendVoiceMsg(requestXML);//发送语音消息
                    break;
                //case "location"://发送位置消息
                //    SendMapMsg(requestXML);
                //    break;
                default:
                    break;

            }
        }
        catch (Exception ex)
        {
            HttpContext.Current.Response.Write(ex.ToString());
        }
    }
    /// <summary>
    /// 发送文本
    /// </summary>
    /// <param name="requestXML"></param>
    private void SendTextCase(RequestXML requestXML)
    {
        string responseContent = FormatTextXML(requestXML.FromUserName, requestXML.ToUserName, requestXML.Content);

        HttpContext.Current.Response.ContentType = "text/xml";
        HttpContext.Current.Response.ContentEncoding = Encoding.UTF8;
        HttpContext.Current.Response.Write(responseContent);
        HttpContext.Current.Response.End();
    }
    /// <summary>
    /// 返回格式化的Xml格式内容
    /// </summary>
    /// <param name="p1">公众号</param>
    /// <param name="p2">用户号</param>
    /// <param name="p3">回复内容</param>
    /// <returns></returns>
    private string FormatTextXML(string p1, string p2, string p3)
    {
        return "<xml><ToUserName><![CDATA[" + p1 + "]]></ToUserName><FromUserName><![CDATA[" + p2 + "]]></FromUserName><CreateTime>" + DateTime.Now.Subtract(new DateTime(1970, 1, 1, 8, 0, 0)).TotalSeconds.ToString() + "</CreateTime><MsgType><![CDATA[text]]></MsgType><Content><![CDATA[" + p3 + "]]></Content><FuncFlag>1</FuncFlag></xml>";
    }
    /// <summary>
    /// 发送响应事件消息
    /// </summary>
    /// <param name="requestXML"></param>
    private void SendEventMsg(RequestXML requestXML)
    {
        string keyStr = requestXML.EventKey.ToString();

        switch (keyStr)
        {
            //case "mypay":
            //    SendPayDetails(requestXML);//发送薪资账单
            //    break;
            //case "tianqiyubao":
            //    SendWeaterMessage(requestXML);//发送天气预报
            //    break;
            //case "kaixinyixiao":
            //    SendKaiXinMessage(requestXML);//发送开心一笑结果集
            //    break;
            //case "updateMessage":
            //    SendUpdateMessage(requestXML);//发送修改信息链接
            //    break;
            //case "yuangonghuodong":
            //    SendYuanGongHuoDong(requestXML);//发送学生活动
            //    break;
            //case "yuangongtongzhi":
            //    SendYuanGongTongZhi(requestXML);//发送员工通知
            //    break;
            //case "youwenbida":
            //    SendWenti(requestXML);//发送员工提交问题链接
            //    break;
            //case "mywen":
            //    SendWentiList(requestXML);//发送问题列表链接
            //    break;
            //case "PhoneSerices":
            //    SendKeFuMessage(requestXML);//接入客服
            //    break;
            default:
                String responseContent = String.Empty;
                responseContent = FormatTextXML(requestXML.FromUserName, requestXML.ToUserName, "此功能暂未开放！敬请期待！");
                HttpContext.Current.Response.ContentType = "text/xml";
                HttpContext.Current.Response.ContentEncoding = Encoding.UTF8;
                HttpContext.Current.Response.Write(responseContent);
                HttpContext.Current.Response.End();
                break;
        }
    }
    /// <summary>
    /// 发送关注时的图文消息
    /// </summary>
    /// <param name="requestXML"></param>
    private void SendWelComeMsg(RequestXML requestXML)
    {
        String responseContent = String.Empty;

        string newdate = DateTime.Now.Subtract(new DateTime(1970, 1, 1, 8, 0, 0)).TotalSeconds.ToString();


        string PUrlfileName = ""; //"http://www.deqiaohr.com.cn/weixin/welcome.jpg";

        responseContent = string.Format(Message_News_Main, requestXML.FromUserName, requestXML.ToUserName, newdate, "1",
            string.Format(Message_News_Item, "欢迎关注", "犇这来", PUrlfileName, ""));//"http://www.deqiaohr.com.cn/weixin/WxGsjianjie.aspx"));


        HttpContext.Current.Response.ContentType = "text/xml";
        HttpContext.Current.Response.ContentEncoding = Encoding.UTF8;
        HttpContext.Current.Response.Write(responseContent);
        HttpContext.Current.Response.End();
    }
    /// <summary>
    /// 返回图文消息主体
    /// </summary>
    public static string Message_News_Main
    {
        get
        {
            return @"<xml>
                                <ToUserName><![CDATA[{0}]]></ToUserName>
                                <FromUserName><![CDATA[{1}]]></FromUserName>
                                <CreateTime>{2}</CreateTime>
                                 <MsgType><![CDATA[news]]></MsgType>
                                 <ArticleCount>{3}</ArticleCount>
                                 <Articles>
                                 {4}
                               </Articles>
                               </xml> ";
        }
    }
    /// <summary>
    /// 返回图文消息项
    /// </summary>
    public static string Message_News_Item
    {
        get
        {
            return @"<item>
                                <Title><![CDATA[{0}]]></Title> 
                                <Description><![CDATA[{1}]]></Description>
                                <PicUrl><![CDATA[{2}]]></PicUrl>
                                <Url><![CDATA[{3}]]></Url>
                                </item>";
        }
    }
    /// <summary>
    /// 发送响应语音识别结果
    /// </summary>
    /// <param name="requestXML"></param>
    private void SendVoiceMsg(RequestXML requestXML)
    {
        string responseContent = FormatTextXML(requestXML.FromUserName, requestXML.ToUserName, "您刚才说的语音消息识别结果为：" + requestXML.Recognition.ToString());
        HttpContext.Current.Response.ContentType = "text/xml";
        HttpContext.Current.Response.ContentEncoding = Encoding.UTF8;
        HttpContext.Current.Response.Write(responseContent);
        HttpContext.Current.Response.End();
    }
}