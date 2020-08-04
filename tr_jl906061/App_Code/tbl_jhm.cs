using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
 
 
    /// <summary>
    /// 类tbl_jhm。
    /// </summary>
    [Serializable]
    public partial class tbl_jhm
    {
        public tbl_jhm()
        { }
        #region Model
        private int _id;
        private string _jhm;
        private string _byuser;
        private string _huiyuan_id;
        private DateTime? _createtime = DateTime.Now;
        private DateTime? _userdtime;
        private int? _isused = 0;
        private string _huiyuan_mob;
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
        public string jhm
        {
            set { _jhm = value; }
            get { return _jhm; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string byuser
        {
            set { _byuser = value; }
            get { return _byuser; }
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
        public DateTime? createtime
        {
            set { _createtime = value; }
            get { return _createtime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? userdtime
        {
            set { _userdtime = value; }
            get { return _userdtime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? isused
        {
            set { _isused = value; }
            get { return _isused; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string huiyuan_mob
        {
            set { _huiyuan_mob = value; }
            get { return _huiyuan_mob; }
        }
        #endregion Model


        #region  Method

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public tbl_jhm(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,jhm,byuser,huiyuan_id,createtime,userdtime,isused,huiyuan_mob ");
            strSql.Append(" FROM [tbl_jhm] ");
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
                if (ds.Tables[0].Rows[0]["jhm"] != null)
                {
                    this.jhm = ds.Tables[0].Rows[0]["jhm"].ToString();
                }
                if (ds.Tables[0].Rows[0]["byuser"] != null)
                {
                    this.byuser = ds.Tables[0].Rows[0]["byuser"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_id"] != null)
                {
                    this.huiyuan_id = ds.Tables[0].Rows[0]["huiyuan_id"].ToString();
                }
                if (ds.Tables[0].Rows[0]["createtime"] != null && ds.Tables[0].Rows[0]["createtime"].ToString() != "")
                {
                    this.createtime = DateTime.Parse(ds.Tables[0].Rows[0]["createtime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["userdtime"] != null && ds.Tables[0].Rows[0]["userdtime"].ToString() != "")
                {
                    this.userdtime = DateTime.Parse(ds.Tables[0].Rows[0]["userdtime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["isused"] != null && ds.Tables[0].Rows[0]["isused"].ToString() != "")
                {
                    this.isused = int.Parse(ds.Tables[0].Rows[0]["isused"].ToString());
                }
                if (ds.Tables[0].Rows[0]["huiyuan_mob"] != null)
                {
                    this.huiyuan_mob = ds.Tables[0].Rows[0]["huiyuan_mob"].ToString();
                }
            }
        }
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from [tbl_jhm]");
            strSql.Append(" where id=@id ");

            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = id;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists_code(string mob,string jhm)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from [tbl_jhm]");
            strSql.Append(" where huiyuan_mob=@mob and jhm=@jhm ");

            SqlParameter[] parameters = {
					new SqlParameter("@mob", SqlDbType.NVarChar,50),
                    new SqlParameter("@jhm", SqlDbType.NVarChar,50)                   
                                        
                                        
                                        };
            parameters[0].Value = mob;
            parameters[1].Value = jhm;
            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into [tbl_jhm] (");
            strSql.Append("jhm,byuser,huiyuan_id,createtime,userdtime,isused,huiyuan_mob)");
            strSql.Append(" values (");
            strSql.Append("@jhm,@byuser,@huiyuan_id,@createtime,@userdtime,@isused,@huiyuan_mob)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@jhm", SqlDbType.NVarChar,50),
					new SqlParameter("@byuser", SqlDbType.Char,9),
					new SqlParameter("@huiyuan_id", SqlDbType.NVarChar,50),
					new SqlParameter("@createtime", SqlDbType.DateTime),
					new SqlParameter("@userdtime", SqlDbType.DateTime),
					new SqlParameter("@isused", SqlDbType.Int,4),
					new SqlParameter("@huiyuan_mob", SqlDbType.NVarChar,50)};
            parameters[0].Value = jhm;
            parameters[1].Value = byuser;
            parameters[2].Value = huiyuan_id;
            parameters[3].Value = createtime;
            parameters[4].Value = userdtime;
            parameters[5].Value = isused;
            parameters[6].Value = huiyuan_mob;

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
            strSql.Append("update [tbl_jhm] set ");
            strSql.Append("jhm=@jhm,");
            strSql.Append("byuser=@byuser,");
            strSql.Append("huiyuan_id=@huiyuan_id,");
            strSql.Append("createtime=@createtime,");
            strSql.Append("userdtime=@userdtime,");
            strSql.Append("isused=@isused,");
            strSql.Append("huiyuan_mob=@huiyuan_mob");
            strSql.Append(" where id=@id ");
            SqlParameter[] parameters = {
					new SqlParameter("@jhm", SqlDbType.NVarChar,50),
					new SqlParameter("@byuser", SqlDbType.Char,9),
					new SqlParameter("@huiyuan_id", SqlDbType.NVarChar,50),
					new SqlParameter("@createtime", SqlDbType.DateTime),
					new SqlParameter("@userdtime", SqlDbType.DateTime),
					new SqlParameter("@isused", SqlDbType.Int,4),
					new SqlParameter("@huiyuan_mob", SqlDbType.NVarChar,50),
					new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = jhm;
            parameters[1].Value = byuser;
            parameters[2].Value = huiyuan_id;
            parameters[3].Value = createtime;
            parameters[4].Value = userdtime;
            parameters[5].Value = isused;
            parameters[6].Value = huiyuan_mob;
            parameters[7].Value = id;

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
            strSql.Append("delete from [tbl_jhm] ");
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
            strSql.Append("select id,jhm,byuser,huiyuan_id,createtime,userdtime,isused,huiyuan_mob ");
            strSql.Append(" FROM [tbl_jhm] ");
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
                if (ds.Tables[0].Rows[0]["jhm"] != null)
                {
                    this.jhm = ds.Tables[0].Rows[0]["jhm"].ToString();
                }
                if (ds.Tables[0].Rows[0]["byuser"] != null)
                {
                    this.byuser = ds.Tables[0].Rows[0]["byuser"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_id"] != null)
                {
                    this.huiyuan_id = ds.Tables[0].Rows[0]["huiyuan_id"].ToString();
                }
                if (ds.Tables[0].Rows[0]["createtime"] != null && ds.Tables[0].Rows[0]["createtime"].ToString() != "")
                {
                    this.createtime = DateTime.Parse(ds.Tables[0].Rows[0]["createtime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["userdtime"] != null && ds.Tables[0].Rows[0]["userdtime"].ToString() != "")
                {
                    this.userdtime = DateTime.Parse(ds.Tables[0].Rows[0]["userdtime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["isused"] != null && ds.Tables[0].Rows[0]["isused"].ToString() != "")
                {
                    this.isused = int.Parse(ds.Tables[0].Rows[0]["isused"].ToString());
                }
                if (ds.Tables[0].Rows[0]["huiyuan_mob"] != null)
                {
                    this.huiyuan_mob = ds.Tables[0].Rows[0]["huiyuan_mob"].ToString();
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
            strSql.Append(" FROM [tbl_jhm] ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion  Method
    }
 

