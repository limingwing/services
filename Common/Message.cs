﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    /// <summary>
    /// 消息类型
    /// </summary>
    public enum MessageType
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
    public class Message
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

        /// <summary>
        /// 返回参数列表
        /// </summary>
        /// <returns></returns>
        private List<SqlParameter> ToParameters()
        {
            List<SqlParameter> parameters = new List<SqlParameter>(4);
            SqlParameter p = new SqlParameter("@Id", SqlDbType.UniqueIdentifier, 16);
            p.Value = Id;
            parameters.Add(p);
            p = new SqlParameter("@Type", SqlDbType.Int, 4);
            p.Value = (int)Type;
            parameters.Add(p);
            p = new SqlParameter("@Content", SqlDbType.NVarChar);
            p.Value = Content;
            parameters.Add(p);
            p = new SqlParameter("@Time", SqlDbType.DateTime, 8);
            p.Value = Time;
            parameters.Add(p);
            return parameters;
        }
    }
}
