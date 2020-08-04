using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
 
 
    /// <summary>
    /// 类tbl_open。
    /// </summary>
    [Serializable]
    public partial class tbl_open
    {
        public tbl_open()
        { }
        #region Model
        private int _id;
        private int? _open_flag = 0;
        private string _tishi;
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
        public int? open_flag
        {
            set { _open_flag = value; }
            get { return _open_flag; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string tishi
        {
            set { _tishi = value; }
            get { return _tishi; }
        }
        #endregion Model


        #region  Method

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public tbl_open(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,open_flag,tishi ");
            strSql.Append(" FROM [tbl_open] ");
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
                if (ds.Tables[0].Rows[0]["open_flag"] != null && ds.Tables[0].Rows[0]["open_flag"].ToString() != "")
                {
                    this.open_flag = int.Parse(ds.Tables[0].Rows[0]["open_flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["tishi"] != null)
                {
                    this.tishi = ds.Tables[0].Rows[0]["tishi"].ToString();
                }
            }
        }
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from [tbl_open]");
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
            strSql.Append("insert into [tbl_open] (");
            strSql.Append("open_flag,tishi)");
            strSql.Append(" values (");
            strSql.Append("@open_flag,@tishi)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@open_flag", SqlDbType.Int,4),
					new SqlParameter("@tishi", SqlDbType.VarChar,100)};
            parameters[0].Value = open_flag;
            parameters[1].Value = tishi;

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
            strSql.Append("update [tbl_open] set ");
            strSql.Append("open_flag=@open_flag,");
            strSql.Append("tishi=@tishi");
            strSql.Append(" where id=@id ");
            SqlParameter[] parameters = {
					new SqlParameter("@open_flag", SqlDbType.Int,4),
					new SqlParameter("@tishi", SqlDbType.VarChar,100),
					new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = open_flag;
            parameters[1].Value = tishi;
            parameters[2].Value = id;

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
        public bool Delete(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from [tbl_open] ");
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
            strSql.Append("select id,open_flag,tishi ");
            strSql.Append(" FROM [tbl_open] ");
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
                if (ds.Tables[0].Rows[0]["open_flag"] != null && ds.Tables[0].Rows[0]["open_flag"].ToString() != "")
                {
                    this.open_flag = int.Parse(ds.Tables[0].Rows[0]["open_flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["tishi"] != null)
                {
                    this.tishi = ds.Tables[0].Rows[0]["tishi"].ToString();
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
            strSql.Append(" FROM [tbl_open] ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion  Method
    }
 

