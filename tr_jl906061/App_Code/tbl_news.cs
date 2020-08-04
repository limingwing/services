using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
 
 
    /// <summary>
    /// 类tbl_news。
    /// </summary>
    [Serializable]
    public partial class tbl_news
    {
        public tbl_news()
        { }
        #region Model
        private int _id;
        private string _title;
        private string _memo;
        private DateTime? _news_date;
        private int? _news_type;
        private string _news_bumen;
        private int? _read_count = 0;
        private int? _sort_id = 0;
        private int? _is_show = 0;
        /// <summary>
        /// 
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 标题
        /// </summary>
        public string title
        {
            set { _title = value; }
            get { return _title; }
        }
        /// <summary>
        /// 详细说明
        /// </summary>
        public string memo
        {
            set { _memo = value; }
            get { return _memo; }
        }
        /// <summary>
        /// 发布时间
        /// </summary>
        public DateTime? news_date
        {
            set { _news_date = value; }
            get { return _news_date; }
        }
        /// <summary>
        /// 新闻类型
        /// </summary>
        public int? news_type
        {
            set { _news_type = value; }
            get { return _news_type; }
        }
        /// <summary>
        /// 部门发布
        /// </summary>
        public string news_bumen
        {
            set { _news_bumen = value; }
            get { return _news_bumen; }
        }
        /// <summary>
        /// 阅读数
        /// </summary>
        public int? read_count
        {
            set { _read_count = value; }
            get { return _read_count; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? sort_id
        {
            set { _sort_id = value; }
            get { return _sort_id; }
        }

        public int? is_show
        {
            set { _is_show = value; }
            get { return _is_show; }
        }
        #endregion Model


        #region  Method

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public tbl_news(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,title,memo,news_date,news_type,news_bumen,read_count,sort_id ");
            strSql.Append(" FROM [tbl_news] ");
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
                if (ds.Tables[0].Rows[0]["title"] != null)
                {
                    this.title = ds.Tables[0].Rows[0]["title"].ToString();
                }
                if (ds.Tables[0].Rows[0]["memo"] != null)
                {
                    this.memo = ds.Tables[0].Rows[0]["memo"].ToString();
                }
                if (ds.Tables[0].Rows[0]["news_date"] != null && ds.Tables[0].Rows[0]["news_date"].ToString() != "")
                {
                    this.news_date = DateTime.Parse(ds.Tables[0].Rows[0]["news_date"].ToString());
                }
                if (ds.Tables[0].Rows[0]["news_type"] != null && ds.Tables[0].Rows[0]["news_type"].ToString() != "")
                {
                    this.news_type = int.Parse(ds.Tables[0].Rows[0]["news_type"].ToString());
                }
                if (ds.Tables[0].Rows[0]["news_bumen"] != null)
                {
                    this.news_bumen = ds.Tables[0].Rows[0]["news_bumen"].ToString();
                }
                if (ds.Tables[0].Rows[0]["read_count"] != null && ds.Tables[0].Rows[0]["read_count"].ToString() != "")
                {
                    this.read_count = int.Parse(ds.Tables[0].Rows[0]["read_count"].ToString());
                }
                if (ds.Tables[0].Rows[0]["sort_id"] != null && ds.Tables[0].Rows[0]["sort_id"].ToString() != "")
                {
                    this.sort_id = int.Parse(ds.Tables[0].Rows[0]["sort_id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["is_show"] != null && ds.Tables[0].Rows[0]["is_show"].ToString() != "")
                {
                    this.is_show = int.Parse(ds.Tables[0].Rows[0]["is_show"].ToString());
                }
            }
        }
        public DataSet CountNews()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(*) as news from tbl_news where datediff(dd,news_date,getdate())<=1");
            return DbHelperSQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from [tbl_news]");
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
            strSql.Append("insert into [tbl_news] (");
            strSql.Append("title,memo,news_date,news_type,news_bumen,read_count,sort_id,is_show)");
            strSql.Append(" values (");
            strSql.Append("@title,@memo,@news_date,@news_type,@news_bumen,@read_count,@sort_id,@is_show)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@title", SqlDbType.VarChar,50),
					new SqlParameter("@memo", SqlDbType.Text),
					new SqlParameter("@news_date", SqlDbType.DateTime),
					new SqlParameter("@news_type", SqlDbType.Int,4),
					new SqlParameter("@news_bumen", SqlDbType.VarChar,50),
					new SqlParameter("@read_count", SqlDbType.Int,4),
					new SqlParameter("@sort_id", SqlDbType.Int,4),
                    new SqlParameter("@is_show", SqlDbType.Int,4),
                    
                                        
                                        
                                        };
            parameters[0].Value = title;
            parameters[1].Value = memo;
            parameters[2].Value = news_date;
            parameters[3].Value = news_type;
            parameters[4].Value = news_bumen;
            parameters[5].Value = read_count;
            parameters[6].Value = sort_id;
            parameters[7].Value = is_show;

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
            strSql.Append("update [tbl_news] set ");
            strSql.Append("title=@title,");
            strSql.Append("memo=@memo,");
            strSql.Append("news_date=@news_date,");
            strSql.Append("news_type=@news_type,");
            strSql.Append("news_bumen=@news_bumen,");
            strSql.Append("read_count=@read_count,");
            strSql.Append("sort_id=@sort_id,");
            strSql.Append("is_show=@is_show");
            strSql.Append(" where id=@id ");
            SqlParameter[] parameters = {
					new SqlParameter("@title", SqlDbType.VarChar,50),
					new SqlParameter("@memo", SqlDbType.Text),
					new SqlParameter("@news_date", SqlDbType.DateTime),
					new SqlParameter("@news_type", SqlDbType.Int,4),
					new SqlParameter("@news_bumen", SqlDbType.VarChar,50),
					new SqlParameter("@read_count", SqlDbType.Int,4),
					new SqlParameter("@sort_id", SqlDbType.Int,4),
                    new SqlParameter("@is_show", SqlDbType.Int,4),
					new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = title;
            parameters[1].Value = memo;
            parameters[2].Value = news_date;
            parameters[3].Value = news_type;
            parameters[4].Value = news_bumen;
            parameters[5].Value = read_count;
            parameters[6].Value = sort_id;
            parameters[7].Value = is_show;
            parameters[8].Value = id;

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
            strSql.Append("update tbl_news set " + strValue);
            strSql.Append(" where id=" + id);
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from [tbl_news] ");
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
            strSql.Append("select id,title,memo,news_date,news_type,news_bumen,read_count,sort_id,is_show ");
            strSql.Append(" FROM [tbl_news] ");
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
                if (ds.Tables[0].Rows[0]["title"] != null)
                {
                    this.title = ds.Tables[0].Rows[0]["title"].ToString();
                }
                if (ds.Tables[0].Rows[0]["memo"] != null)
                {
                    this.memo = ds.Tables[0].Rows[0]["memo"].ToString();
                }
                if (ds.Tables[0].Rows[0]["news_date"] != null && ds.Tables[0].Rows[0]["news_date"].ToString() != "")
                {
                    this.news_date = DateTime.Parse(ds.Tables[0].Rows[0]["news_date"].ToString());
                }
                if (ds.Tables[0].Rows[0]["news_type"] != null && ds.Tables[0].Rows[0]["news_type"].ToString() != "")
                {
                    this.news_type = int.Parse(ds.Tables[0].Rows[0]["news_type"].ToString());
                }
                if (ds.Tables[0].Rows[0]["news_bumen"] != null)
                {
                    this.news_bumen = ds.Tables[0].Rows[0]["news_bumen"].ToString();
                }
                if (ds.Tables[0].Rows[0]["read_count"] != null && ds.Tables[0].Rows[0]["read_count"].ToString() != "")
                {
                    this.read_count = int.Parse(ds.Tables[0].Rows[0]["read_count"].ToString());
                }
                if (ds.Tables[0].Rows[0]["sort_id"] != null && ds.Tables[0].Rows[0]["sort_id"].ToString() != "")
                {
                    this.sort_id = int.Parse(ds.Tables[0].Rows[0]["sort_id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["is_show"] != null && ds.Tables[0].Rows[0]["is_show"].ToString() != "")
                {
                    this.is_show = int.Parse(ds.Tables[0].Rows[0]["is_show"].ToString());
                }
            }
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top 5 * ");
            strSql.Append(" FROM [tbl_news] ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }


        /// <summary>
        /// 获得查询分页数据
        /// </summary>
        public DataSet GetList(int pageSize, int pageIndex, string strWhere, string filedOrder, out int recordCount)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * FROM  tbl_news");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            recordCount = Convert.ToInt32(DbHelperSQL.GetSingle(PagingHelper.CreateCountingSql(strSql.ToString())));
            return DbHelperSQL.Query(PagingHelper.CreatePagingSql(recordCount, pageSize, pageIndex, strSql.ToString(), filedOrder));
        }
	

        #endregion  Method
    }
 

