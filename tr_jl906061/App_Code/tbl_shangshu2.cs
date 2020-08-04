using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
 
 
    /// <summary>
    /// 类tbl_shangshu2。
    /// </summary>
    [Serializable]
    public partial class tbl_shangshu2
    {
        public tbl_shangshu2()
        { }
        #region Model
        private int _temp_id;
        private string _huiyuan_id;
        private string _huiyuan_shang_id;
        private int? _huiyuan_xuhao;
        private int? _net_hege = 0;
        /// <summary>
        /// 
        /// </summary>
        public int temp_id
        {
            set { _temp_id = value; }
            get { return _temp_id; }
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
        public string huiyuan_shang_id
        {
            set { _huiyuan_shang_id = value; }
            get { return _huiyuan_shang_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? huiyuan_xuhao
        {
            set { _huiyuan_xuhao = value; }
            get { return _huiyuan_xuhao; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? net_hege
        {
            set { _net_hege = value; }
            get { return _net_hege; }
        }
        #endregion Model


        #region  Method

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public tbl_shangshu2(string huiyuan_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select temp_id,huiyuan_id,huiyuan_shang_id,huiyuan_xuhao,net_hege ");
            strSql.Append(" FROM [tbl_shangshu2] ");
            strSql.Append(" where huiyuan_id=@huiyuan_id ");
            SqlParameter[] parameters = {
					new SqlParameter("@huiyuan_id", SqlDbType.Char,10)};
            parameters[0].Value = huiyuan_id;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["temp_id"] != null && ds.Tables[0].Rows[0]["temp_id"].ToString() != "")
                {
                    this.temp_id = int.Parse(ds.Tables[0].Rows[0]["temp_id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["huiyuan_id"] != null)
                {
                    this.huiyuan_id = ds.Tables[0].Rows[0]["huiyuan_id"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_shang_id"] != null)
                {
                    this.huiyuan_shang_id = ds.Tables[0].Rows[0]["huiyuan_shang_id"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_xuhao"] != null && ds.Tables[0].Rows[0]["huiyuan_xuhao"].ToString() != "")
                {
                    this.huiyuan_xuhao = int.Parse(ds.Tables[0].Rows[0]["huiyuan_xuhao"].ToString());
                }
                if (ds.Tables[0].Rows[0]["net_hege"] != null && ds.Tables[0].Rows[0]["net_hege"].ToString() != "")
                {
                    this.net_hege = int.Parse(ds.Tables[0].Rows[0]["net_hege"].ToString());
                }
            }
        }
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string huiyuan_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from [tbl_shangshu2]");
            strSql.Append(" where huiyuan_id=@huiyuan_id ");

            SqlParameter[] parameters = {
					new SqlParameter("@huiyuan_id", SqlDbType.Char,10)};
            parameters[0].Value = huiyuan_id;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into [tbl_shangshu2] (");
            strSql.Append("huiyuan_id,huiyuan_shang_id,huiyuan_xuhao,net_hege)");
            strSql.Append(" values (");
            strSql.Append("@huiyuan_id,@huiyuan_shang_id,@huiyuan_xuhao,@net_hege)");
            SqlParameter[] parameters = {
					new SqlParameter("@huiyuan_id", SqlDbType.Char,9),
					new SqlParameter("@huiyuan_shang_id", SqlDbType.Char,9),
					new SqlParameter("@huiyuan_xuhao", SqlDbType.Int,4),
					new SqlParameter("@net_hege", SqlDbType.Int,4)};
            parameters[0].Value = huiyuan_id;
            parameters[1].Value = huiyuan_shang_id;
            parameters[2].Value = huiyuan_xuhao;
            parameters[3].Value = net_hege;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update [tbl_shangshu2] set ");
            strSql.Append("huiyuan_id=@huiyuan_id,");
            strSql.Append("huiyuan_shang_id=@huiyuan_shang_id,");
            strSql.Append("huiyuan_xuhao=@huiyuan_xuhao,");
            strSql.Append("net_hege=@net_hege");
            strSql.Append(" where huiyuan_id=@huiyuan_id ");
            SqlParameter[] parameters = {
					new SqlParameter("@huiyuan_id", SqlDbType.Char,9),
					new SqlParameter("@huiyuan_shang_id", SqlDbType.Char,9),
					new SqlParameter("@huiyuan_xuhao", SqlDbType.Int,4),
					new SqlParameter("@net_hege", SqlDbType.Int,4),
					new SqlParameter("@temp_id", SqlDbType.Int,4)};
            parameters[0].Value = huiyuan_id;
            parameters[1].Value = huiyuan_shang_id;
            parameters[2].Value = huiyuan_xuhao;
            parameters[3].Value = net_hege;
            parameters[4].Value = temp_id;

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
            strSql.Append("delete from [tbl_shangshu2] ");
            strSql.Append(" where huiyuan_id=@huiyuan_id ");
            SqlParameter[] parameters = {
					new SqlParameter("@huiyuan_id", SqlDbType.Char,10)};
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
            strSql.Append("select temp_id,huiyuan_id,huiyuan_shang_id,huiyuan_xuhao,net_hege ");
            strSql.Append(" FROM [tbl_shangshu2] ");
            strSql.Append(" where huiyuan_id=@huiyuan_id ");
            SqlParameter[] parameters = {
					new SqlParameter("@huiyuan_id", SqlDbType.Char,10)};
            parameters[0].Value = huiyuan_id;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["temp_id"] != null && ds.Tables[0].Rows[0]["temp_id"].ToString() != "")
                {
                    this.temp_id = int.Parse(ds.Tables[0].Rows[0]["temp_id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["huiyuan_id"] != null)
                {
                    this.huiyuan_id = ds.Tables[0].Rows[0]["huiyuan_id"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_shang_id"] != null)
                {
                    this.huiyuan_shang_id = ds.Tables[0].Rows[0]["huiyuan_shang_id"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_xuhao"] != null && ds.Tables[0].Rows[0]["huiyuan_xuhao"].ToString() != "")
                {
                    this.huiyuan_xuhao = int.Parse(ds.Tables[0].Rows[0]["huiyuan_xuhao"].ToString());
                }
                if (ds.Tables[0].Rows[0]["net_hege"] != null && ds.Tables[0].Rows[0]["net_hege"].ToString() != "")
                {
                    this.net_hege = int.Parse(ds.Tables[0].Rows[0]["net_hege"].ToString());
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
            strSql.Append(" FROM [tbl_shangshu2] ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion  Method
    }
 

