using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
///RequestXML 的摘要说明
/// </summary>
public class RequestXML
{
    private String toUserName = String.Empty;

    /// <summary>
    /// 本公众号
    /// </summary>
    public String ToUserName { get; set; }

    /// <summary>
    /// 用户微信号
    /// </summary>
    public String FromUserName { get; set; }

    /// <summary>
    /// 创建时间
    /// </summary>
    public String CreateTime { get; set; }

    /// <summary>
    /// 信息类型 
    /// </summary>
    public String MsgType { get; set; }

    /// <summary>
    /// 信息内容
    /// </summary>
    public String Content { get; set; }



    /*以下为事件类型的消息特有的属性*/
    /// <summary>
    /// 事件名称
    /// </summary>
    public String EventName { get; set; }
    /// <summary>
    /// 事件值
    /// </summary>
    public string EventKey { get; set; }




    /*以下为图文类型的消息特有的属性*/
    /// <summary>
    /// 图文消息的个数
    /// </summary>
    public int ArticleCount { get; set; }
    /// <summary>
    /// 图文消息的标题
    /// </summary>
    public string Title { get; set; }
    /// <summary>
    /// 图文消息的简介
    /// </summary>
    public string Description { get; set; }
    /// <summary>
    /// 图文消息图片的链接地址
    /// </summary>
    public string PicUrl { get; set; }
    /// <summary>
    /// 图文消息详情链接地址
    /// </summary>
    public string Url { get; set; }
    /// <summary>
    /// 图文消息集合
    /// </summary>
    public List<RequestXML> Articles { get; set; }



    /*以下为地理位置类型的消息特有的属性*/
    /// <summary>
    /// 地理位置纬度
    /// </summary>
    public String Location_X { get; set; }

    /// <summary>
    /// 地理位置经度
    /// </summary>
    public String Location_Y { get; set; }

    /// <summary>
    /// 地图缩放比例
    /// </summary>
    public String Scale { get; set; }

    /// <summary>
    /// 地图位置说明
    /// </summary>
    public String Label { get; set; }





    /// <summary>
    /// 语音消息特有字段
    /// </summary>
    public String Recognition { get; set; }
}