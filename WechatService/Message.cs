using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Common;

/*todo:该文件仅用于调试，正式部署请删除。*/
namespace WechatService
{
    /// <summary>
    /// 消息类型
    /// </summary>
    internal enum MessageType
    {
        /// <summary>
        /// 请求
        /// </summary>
        Request,
        /// <summary>
        /// 响应
        /// </summary>
        Response,
        /// <summary>
        /// 异常
        /// </summary>
        Exception
    }

    /// <summary>
    /// Message：消息
    /// </summary>
    internal class Message
    {
        /// <summary>
        /// ID
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// 类型
        /// </summary>
        public MessageType Type { get; set; }
        /// <summary>
        /// 内容
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// 时间
        /// </summary>
        public DateTime Time { get; set; }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="id"></param>
        /// <param name="type"></param>
        /// <param name="content"></param>
        /// <param name="time"></param>
        public Message(Guid id, MessageType type, string content, DateTime time)
        {
            Id = id;
            Type = type;
            Content = content;
            Time = time;
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="type"></param>
        /// <param name="content"></param>
        public Message(MessageType type, string content)
            : this(Guid.NewGuid(), type, content, DateTime.Now)
        {
        }
    }
}