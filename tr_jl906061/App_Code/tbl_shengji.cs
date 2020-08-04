using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
 
    /// <summary>
    /// 类tbl_shengji。
    /// </summary>
    [Serializable]
    public partial class tbl_shengji
    {
        public tbl_shengji()
        { }
        #region Model
        private int _id;
        private string _huiyuan_bianhao;
        private string _huiyuan_id;
        private int? _huiyuan_jiebie;
        private int? _sj_jiebie;
        private string _huiyuan_jiebie_name;
        private string _sj_jiebie_name;
        private decimal? _sj_money = 0M;
        private DateTime? _sj_date;
        private int? _flag = 0;
        /// <summary>
        /// 
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string huiyuan_bianhao
        {
            set { _huiyuan_bianhao = value; }
            get { return _huiyuan_bianhao; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string huiyuan_id
        {
            set { _huiyuan_id = value; }
            get { return _huiyuan_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? huiyuan_jiebie
        {
            set { _huiyuan_jiebie = value; }
            get { return _huiyuan_jiebie; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? sj_jiebie
        {
            set { _sj_jiebie = value; }
            get { return _sj_jiebie; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string huiyuan_jiebie_name
        {
            set { _huiyuan_jiebie_name = value; }
            get { return _huiyuan_jiebie_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sj_jiebie_name
        {
            set { _sj_jiebie_name = value; }
            get { return _sj_jiebie_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? sj_money
        {
            set { _sj_money = value; }
            get { return _sj_money; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? sj_date
        {
            set { _sj_date = value; }
            get { return _sj_date; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? flag
        {
            set { _flag = value; }
            get { return _flag; }
        }
        #endregion Model


        #region  Method

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public tbl_shengji(string huiyuan_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,huiyuan_bianhao,huiyuan_id,huiyuan_jiebie,sj_jiebie,huiyuan_jiebie_name,sj_jiebie_name,sj_money,sj_date,flag ");
            strSql.Append(" FROM [tbl_shengji] ");
            strSql.Append(" where huiyuan_id=@huiyuan_id ");
            SqlParameter[] parameters = {
					new SqlParameter("@huiyuan_id", SqlDbType.VarChar,-1)};
            parameters[0].Value = huiyuan_id;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["id"] != null && ds.Tables[0].Rows[0]["id"].ToString() != "")
                {
                    this.id = int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["huiyuan_bianhao"] != null)
                {
                    this.huiyuan_bianhao = ds.Tables[0].Rows[0]["huiyuan_bianhao"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_id"] != null)
                {
                    this.huiyuan_id = ds.Tables[0].Rows[0]["huiyuan_id"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_jiebie"] != null && ds.Tables[0].Rows[0]["huiyuan_jiebie"].ToString() != "")
                {
                    this.huiyuan_jiebie = int.Parse(ds.Tables[0].Rows[0]["huiyuan_jiebie"].ToString());
                }
                if (ds.Tables[0].Rows[0]["sj_jiebie"] != null && ds.Tables[0].Rows[0]["sj_jiebie"].ToString() != "")
                {
                    this.sj_jiebie = int.Parse(ds.Tables[0].Rows[0]["sj_jiebie"].ToString());
                }
                if (ds.Tables[0].Rows[0]["huiyuan_jiebie_name"] != null)
                {
                    this.huiyuan_jiebie_name = ds.Tables[0].Rows[0]["huiyuan_jiebie_name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["sj_jiebie_name"] != null)
                {
                    this.sj_jiebie_name = ds.Tables[0].Rows[0]["sj_jiebie_name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["sj_money"] != null && ds.Tables[0].Rows[0]["sj_money"].ToString() != "")
                {
                    this.sj_money = decimal.Parse(ds.Tables[0].Rows[0]["sj_money"].ToString());
                }
                if (ds.Tables[0].Rows[0]["sj_date"] != null && ds.Tables[0].Rows[0]["sj_date"].ToString() != "")
                {
                    this.sj_date = DateTime.Parse(ds.Tables[0].Rows[0]["sj_date"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag"] != null && ds.Tables[0].Rows[0]["flag"].ToString() != "")
                {
                    this.flag = int.Parse(ds.Tables[0].Rows[0]["flag"].ToString());
                }
            }
        }
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string huiyuan_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from [tbl_shengji]");
            strSql.Append(" where huiyuan_id=@huiyuan_id ");

            SqlParameter[] parameters = {
					new SqlParameter("@huiyuan_id", SqlDbType.VarChar,-1)};
            parameters[0].Value = huiyuan_id;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into [tbl_shengji] (");
            strSql.Append("huiyuan_bianhao,huiyuan_id,huiyuan_jiebie,sj_jiebie,huiyuan_jiebie_name,sj_jiebie_name,sj_money,sj_date,flag)");
            strSql.Append(" values (");
            strSql.Append("@huiyuan_bianhao,@huiyuan_id,@huiyuan_jiebie,@sj_jiebie,@huiyuan_jiebie_name,@sj_jiebie_name,@sj_money,@sj_date,@flag)");
            SqlParameter[] parameters = {
					new SqlParameter("@huiyuan_bianhao", SqlDbType.VarChar,500),
					new SqlParameter("@huiyuan_id", SqlDbType.VarChar,9),
					new SqlParameter("@huiyuan_jiebie", SqlDbType.Int,4),
					new SqlParameter("@sj_jiebie", SqlDbType.Int,4),
					new SqlParameter("@huiyuan_jiebie_name", SqlDbType.VarChar,500),
					new SqlParameter("@sj_jiebie_name", SqlDbType.VarChar,500),
					new SqlParameter("@sj_money", SqlDbType.Money,8),
					new SqlParameter("@sj_date", SqlDbType.DateTime),
					new SqlParameter("@flag", SqlDbType.Int,4)};
            parameters[0].Value = huiyuan_bianhao;
            parameters[1].Value = huiyuan_id;
            parameters[2].Value = huiyuan_jiebie;
            parameters[3].Value = sj_jiebie;
            parameters[4].Value = huiyuan_jiebie_name;
            parameters[5].Value = sj_jiebie_name;
            parameters[6].Value = sj_money;
            parameters[7].Value = sj_date;
            parameters[8].Value = flag;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update [tbl_shengji] set ");
            strSql.Append("huiyuan_bianhao=@huiyuan_bianhao,");
            strSql.Append("huiyuan_id=@huiyuan_id,");
            strSql.Append("huiyuan_jiebie=@huiyuan_jiebie,");
            strSql.Append("sj_jiebie=@sj_jiebie,");
            strSql.Append("huiyuan_jiebie_name=@huiyuan_jiebie_name,");
            strSql.Append("sj_jiebie_name=@sj_jiebie_name,");
            strSql.Append("sj_money=@sj_money,");
            strSql.Append("sj_date=@sj_date,");
            strSql.Append("flag=@flag");
            strSql.Append(" where huiyuan_id=@huiyuan_id ");
            SqlParameter[] parameters = {
					new SqlParameter("@huiyuan_bianhao", SqlDbType.VarChar,500),
					new SqlParameter("@huiyuan_id", SqlDbType.VarChar,9),
					new SqlParameter("@huiyuan_jiebie", SqlDbType.Int,4),
					new SqlParameter("@sj_jiebie", SqlDbType.Int,4),
					new SqlParameter("@huiyuan_jiebie_name", SqlDbType.VarChar,500),
					new SqlParameter("@sj_jiebie_name", SqlDbType.VarChar,500),
					new SqlParameter("@sj_money", SqlDbType.Money,8),
					new SqlParameter("@sj_date", SqlDbType.DateTime),
					new SqlParameter("@flag", SqlDbType.Int,4),
					new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = huiyuan_bianhao;
            parameters[1].Value = huiyuan_id;
            parameters[2].Value = huiyuan_jiebie;
            parameters[3].Value = sj_jiebie;
            parameters[4].Value = huiyuan_jiebie_name;
            parameters[5].Value = sj_jiebie_name;
            parameters[6].Value = sj_money;
            parameters[7].Value = sj_date;
            parameters[8].Value = flag;
            parameters[9].Value = id;

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
        /// 删除一条数据
        /// </summary>
        public bool Delete(string huiyuan_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from [tbl_shengji] ");
            strSql.Append(" where huiyuan_id=@huiyuan_id ");
            SqlParameter[] parameters = {
					new SqlParameter("@huiyuan_id", SqlDbType.VarChar,-1)};
            parameters[0].Value = huiyuan_id;

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
        public void GetModel(string huiyuan_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,huiyuan_bianhao,huiyuan_id,huiyuan_jiebie,sj_jiebie,huiyuan_jiebie_name,sj_jiebie_name,sj_money,sj_date,flag ");
            strSql.Append(" FROM [tbl_shengji] ");
            strSql.Append(" where huiyuan_id=@huiyuan_id ");
            SqlParameter[] parameters = {
					new SqlParameter("@huiyuan_id", SqlDbType.VarChar,-1)};
            parameters[0].Value = huiyuan_id;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["id"] != null && ds.Tables[0].Rows[0]["id"].ToString() != "")
                {
                    this.id = int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["huiyuan_bianhao"] != null)
                {
                    this.huiyuan_bianhao = ds.Tables[0].Rows[0]["huiyuan_bianhao"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_id"] != null)
                {
                    this.huiyuan_id = ds.Tables[0].Rows[0]["huiyuan_id"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_jiebie"] != null && ds.Tables[0].Rows[0]["huiyuan_jiebie"].ToString() != "")
                {
                    this.huiyuan_jiebie = int.Parse(ds.Tables[0].Rows[0]["huiyuan_jiebie"].ToString());
                }
                if (ds.Tables[0].Rows[0]["sj_jiebie"] != null && ds.Tables[0].Rows[0]["sj_jiebie"].ToString() != "")
                {
                    this.sj_jiebie = int.Parse(ds.Tables[0].Rows[0]["sj_jiebie"].ToString());
                }
                if (ds.Tables[0].Rows[0]["huiyuan_jiebie_name"] != null)
                {
                    this.huiyuan_jiebie_name = ds.Tables[0].Rows[0]["huiyuan_jiebie_name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["sj_jiebie_name"] != null)
                {
                    this.sj_jiebie_name = ds.Tables[0].Rows[0]["sj_jiebie_name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["sj_money"] != null && ds.Tables[0].Rows[0]["sj_money"].ToString() != "")
                {
                    this.sj_money = decimal.Parse(ds.Tables[0].Rows[0]["sj_money"].ToString());
                }
                if (ds.Tables[0].Rows[0]["sj_date"] != null && ds.Tables[0].Rows[0]["sj_date"].ToString() != "")
                {
                    this.sj_date = DateTime.Parse(ds.Tables[0].Rows[0]["sj_date"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag"] != null && ds.Tables[0].Rows[0]["flag"].ToString() != "")
                {
                    this.flag = int.Parse(ds.Tables[0].Rows[0]["flag"].ToString());
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
            strSql.Append(" FROM [tbl_shengji] ");
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
            strSql.Append("select * FROM  tbl_shengji   ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            recordCount = Convert.ToInt32(DbHelperSQL.GetSingle(PagingHelper.CreateCountingSql(strSql.ToString())));
            return DbHelperSQL.Query(PagingHelper.CreatePagingSql(recordCount, pageSize, pageIndex, strSql.ToString(), filedOrder));
        }
	 
        #endregion  Method
    }
 

