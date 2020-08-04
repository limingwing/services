using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
 
 
    /// <summary>
    /// 类tbl_liuyan。
    /// </summary>
    [Serializable]
    public partial class tbl_liuyan
    {
        public tbl_liuyan()
        { }
        #region Model
        private int _id;
        private string _liuyan_title;
        private string _liuyan_memo;
        private string _liuyan_bianhao;
        private string _liuyan_name;
        private string _liuyan_to;
        private string _liuyan_to_name;
        private DateTime? _liuyan_date;
        private int? _kan_flag = 0;
        private int? _liuyan_type = 0;
        private string _liuyan_shuxing;
        /// <summary>
        /// 
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 留言标题
        /// </summary>
        public string liuyan_title
        {
            set { _liuyan_title = value; }
            get { return _liuyan_title; }
        }
        /// <summary>
        /// 留言内容
        /// </summary>
        public string liuyan_memo
        {
            set { _liuyan_memo = value; }
            get { return _liuyan_memo; }
        }
        /// <summary>
        /// 留言编号
        /// </summary>
        public string liuyan_bianhao
        {
            set { _liuyan_bianhao = value; }
            get { return _liuyan_bianhao; }
        }
        /// <summary>
        /// 发送留言姓名
        /// </summary>
        public string liuyan_name
        {
            set { _liuyan_name = value; }
            get { return _liuyan_name; }
        }
        /// <summary>
        /// 接受编号
        /// </summary>
        public string liuyan_to
        {
            set { _liuyan_to = value; }
            get { return _liuyan_to; }
        }
        /// <summary>
        /// 接受留言会员姓名
        /// </summary>
        public string liuyan_to_name
        {
            set { _liuyan_to_name = value; }
            get { return _liuyan_to_name; }
        }
        /// <summary>
        /// 留言时间
        /// </summary>
        public DateTime? liuyan_date
        {
            set { _liuyan_date = value; }
            get { return _liuyan_date; }
        }
        /// <summary>
        /// 是否查看
        /// </summary>
        public int? kan_flag
        {
            set { _kan_flag = value; }
            get { return _kan_flag; }
        }
        /// <summary>
        /// 留言类型
        /// </summary>
        public int? liuyan_type
        {
            set { _liuyan_type = value; }
            get { return _liuyan_type; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string liuyan_shuxing
        {
            set { _liuyan_shuxing = value; }
            get { return _liuyan_shuxing; }
        }
        #endregion Model


        #region  Method

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public tbl_liuyan(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,liuyan_title,liuyan_memo,liuyan_bianhao,liuyan_name,liuyan_to,liuyan_to_name,liuyan_date,kan_flag,liuyan_type,liuyan_shuxing ");
            strSql.Append(" FROM [tbl_liuyan] ");
            strSql.Append(" where id=@id ");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = id;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["id"] != null && ds.Tables[0].Rows[0]["id"].ToString() != "")
                {
                    this.id = int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["liuyan_title"] != null)
                {
                    this.liuyan_title = ds.Tables[0].Rows[0]["liuyan_title"].ToString();
                }
                if (ds.Tables[0].Rows[0]["liuyan_memo"] != null)
                {
                    this.liuyan_memo = ds.Tables[0].Rows[0]["liuyan_memo"].ToString();
                }
                if (ds.Tables[0].Rows[0]["liuyan_bianhao"] != null)
                {
                    this.liuyan_bianhao = ds.Tables[0].Rows[0]["liuyan_bianhao"].ToString();
                }
                if (ds.Tables[0].Rows[0]["liuyan_name"] != null)
                {
                    this.liuyan_name = ds.Tables[0].Rows[0]["liuyan_name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["liuyan_to"] != null)
                {
                    this.liuyan_to = ds.Tables[0].Rows[0]["liuyan_to"].ToString();
                }
                if (ds.Tables[0].Rows[0]["liuyan_to_name"] != null)
                {
                    this.liuyan_to_name = ds.Tables[0].Rows[0]["liuyan_to_name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["liuyan_date"] != null && ds.Tables[0].Rows[0]["liuyan_date"].ToString() != "")
                {
                    this.liuyan_date = DateTime.Parse(ds.Tables[0].Rows[0]["liuyan_date"].ToString());
                }
                if (ds.Tables[0].Rows[0]["kan_flag"] != null && ds.Tables[0].Rows[0]["kan_flag"].ToString() != "")
                {
                    this.kan_flag = int.Parse(ds.Tables[0].Rows[0]["kan_flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["liuyan_type"] != null && ds.Tables[0].Rows[0]["liuyan_type"].ToString() != "")
                {
                    this.liuyan_type = int.Parse(ds.Tables[0].Rows[0]["liuyan_type"].ToString());
                }
                if (ds.Tables[0].Rows[0]["liuyan_shuxing"] != null)
                {
                    this.liuyan_shuxing = ds.Tables[0].Rows[0]["liuyan_shuxing"].ToString();
                }
            }
        }
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from [tbl_liuyan]");
            strSql.Append(" where id=@id ");

            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = id;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into [tbl_liuyan] (");
            strSql.Append("liuyan_title,liuyan_memo,liuyan_bianhao,liuyan_name,liuyan_to,liuyan_to_name,liuyan_date,kan_flag,liuyan_type,liuyan_shuxing)");
            strSql.Append(" values (");
            strSql.Append("@liuyan_title,@liuyan_memo,@liuyan_bianhao,@liuyan_name,@liuyan_to,@liuyan_to_name,@liuyan_date,@kan_flag,@liuyan_type,@liuyan_shuxing)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@liuyan_title", SqlDbType.VarChar,50),
					new SqlParameter("@liuyan_memo", SqlDbType.Text),
					new SqlParameter("@liuyan_bianhao", SqlDbType.VarChar,50),
					new SqlParameter("@liuyan_name", SqlDbType.VarChar,500),
					new SqlParameter("@liuyan_to", SqlDbType.VarChar,50),
					new SqlParameter("@liuyan_to_name", SqlDbType.VarChar,500),
					new SqlParameter("@liuyan_date", SqlDbType.DateTime),
					new SqlParameter("@kan_flag", SqlDbType.Int,4),
					new SqlParameter("@liuyan_type", SqlDbType.Int,4),
					new SqlParameter("@liuyan_shuxing", SqlDbType.VarChar,50)};
            parameters[0].Value = liuyan_title;
            parameters[1].Value = liuyan_memo;
            parameters[2].Value = liuyan_bianhao;
            parameters[3].Value = liuyan_name;
            parameters[4].Value = liuyan_to;
            parameters[5].Value = liuyan_to_name;
            parameters[6].Value = liuyan_date;
            parameters[7].Value = kan_flag;
            parameters[8].Value = liuyan_type;
            parameters[9].Value = liuyan_shuxing;

            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update [tbl_liuyan] set ");
            strSql.Append("liuyan_title=@liuyan_title,");
            strSql.Append("liuyan_memo=@liuyan_memo,");
            strSql.Append("liuyan_bianhao=@liuyan_bianhao,");
            strSql.Append("liuyan_name=@liuyan_name,");
            strSql.Append("liuyan_to=@liuyan_to,");
            strSql.Append("liuyan_to_name=@liuyan_to_name,");
            strSql.Append("liuyan_date=@liuyan_date,");
            strSql.Append("kan_flag=@kan_flag,");
            strSql.Append("liuyan_type=@liuyan_type,");
            strSql.Append("liuyan_shuxing=@liuyan_shuxing");
            strSql.Append(" where id=@id ");
            SqlParameter[] parameters = {
					new SqlParameter("@liuyan_title", SqlDbType.VarChar,50),
					new SqlParameter("@liuyan_memo", SqlDbType.Text),
					new SqlParameter("@liuyan_bianhao", SqlDbType.VarChar,50),
					new SqlParameter("@liuyan_name", SqlDbType.VarChar,500),
					new SqlParameter("@liuyan_to", SqlDbType.VarChar,50),
					new SqlParameter("@liuyan_to_name", SqlDbType.VarChar,500),
					new SqlParameter("@liuyan_date", SqlDbType.DateTime),
					new SqlParameter("@kan_flag", SqlDbType.Int,4),
					new SqlParameter("@liuyan_type", SqlDbType.Int,4),
					new SqlParameter("@liuyan_shuxing", SqlDbType.VarChar,50),
					new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = liuyan_title;
            parameters[1].Value = liuyan_memo;
            parameters[2].Value = liuyan_bianhao;
            parameters[3].Value = liuyan_name;
            parameters[4].Value = liuyan_to;
            parameters[5].Value = liuyan_to_name;
            parameters[6].Value = liuyan_date;
            parameters[7].Value = kan_flag;
            parameters[8].Value = liuyan_type;
            parameters[9].Value = liuyan_shuxing;
            parameters[10].Value = id;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 修改一列数据
        /// </summary>
        public void UpdateField(int id, string strValue)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tbl_liuyan set " + strValue);
            strSql.Append(" where id=" + id);
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from [tbl_liuyan] ");
            strSql.Append(" where id=@id ");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = id;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public void GetModel(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,liuyan_title,liuyan_memo,liuyan_bianhao,liuyan_name,liuyan_to,liuyan_to_name,liuyan_date,kan_flag,liuyan_type,liuyan_shuxing ");
            strSql.Append(" FROM [tbl_liuyan] ");
            strSql.Append(" where id=@id ");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = id;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["id"] != null && ds.Tables[0].Rows[0]["id"].ToString() != "")
                {
                    this.id = int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["liuyan_title"] != null)
                {
                    this.liuyan_title = ds.Tables[0].Rows[0]["liuyan_title"].ToString();
                }
                if (ds.Tables[0].Rows[0]["liuyan_memo"] != null)
                {
                    this.liuyan_memo = ds.Tables[0].Rows[0]["liuyan_memo"].ToString();
                }
                if (ds.Tables[0].Rows[0]["liuyan_bianhao"] != null)
                {
                    this.liuyan_bianhao = ds.Tables[0].Rows[0]["liuyan_bianhao"].ToString();
                }
                if (ds.Tables[0].Rows[0]["liuyan_name"] != null)
                {
                    this.liuyan_name = ds.Tables[0].Rows[0]["liuyan_name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["liuyan_to"] != null)
                {
                    this.liuyan_to = ds.Tables[0].Rows[0]["liuyan_to"].ToString();
                }
                if (ds.Tables[0].Rows[0]["liuyan_to_name"] != null)
                {
                    this.liuyan_to_name = ds.Tables[0].Rows[0]["liuyan_to_name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["liuyan_date"] != null && ds.Tables[0].Rows[0]["liuyan_date"].ToString() != "")
                {
                    this.liuyan_date = DateTime.Parse(ds.Tables[0].Rows[0]["liuyan_date"].ToString());
                }
                if (ds.Tables[0].Rows[0]["kan_flag"] != null && ds.Tables[0].Rows[0]["kan_flag"].ToString() != "")
                {
                    this.kan_flag = int.Parse(ds.Tables[0].Rows[0]["kan_flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["liuyan_type"] != null && ds.Tables[0].Rows[0]["liuyan_type"].ToString() != "")
                {
                    this.liuyan_type = int.Parse(ds.Tables[0].Rows[0]["liuyan_type"].ToString());
                }
                if (ds.Tables[0].Rows[0]["liuyan_shuxing"] != null)
                {
                    this.liuyan_shuxing = ds.Tables[0].Rows[0]["liuyan_shuxing"].ToString();
                }
            }
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM [tbl_liuyan] ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 根据条件和字段汇总
        /// </summary>
        public string GetTitleSum(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(*) as aa from [tbl_liuyan]");
            strSql.Append(" where " + strWhere);
            string title = Convert.ToString(DbHelperSQL.GetSingle(strSql.ToString()));
            if (string.IsNullOrEmpty(title))
            {
                return "0";
            }
            return title;
        }

        /// <summary>
        /// 获得查询分页数据
        /// </summary>
        public DataSet GetList(int pageSize, int pageIndex, string strWhere, string filedOrder, out int recordCount)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * FROM  tbl_liuyan   ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            recordCount = Convert.ToInt32(DbHelperSQL.GetSingle(PagingHelper.CreateCountingSql(strSql.ToString())));
            return DbHelperSQL.Query(PagingHelper.CreatePagingSql(recordCount, pageSize, pageIndex, strSql.ToString(), filedOrder));
        }

        #endregion  Method
    }
 

