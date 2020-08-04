using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;

 
    /// <summary>
    /// 类tbl_admin。
    /// </summary>
    [Serializable]
    public partial class tbl_admin
    {
        public tbl_admin()
        { }
        #region Model
        private int _id;
        private string _huiyuan_id;
        private string _huiyuan_name;
        private string _huiyuan_quanxian;
        private string _huiyuan_bianhao;
        private string _huiyuan_pass;
        private string _huiyuan_chu_jifen;
        private int? _yong_flag;
        private string _pass_two;
        private int? _role_id;
        private int? _is_lock = 0;
        private DateTime? _add_time;
        /// <summary>
        /// 标识id
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 管理员唯一标识
        /// </summary>
        public string huiyuan_id
        {
            set { _huiyuan_id = value; }
            get { return _huiyuan_id; }
        }
        /// <summary>
        /// 管理员姓名
        /// </summary>
        public string huiyuan_name
        {
            set { _huiyuan_name = value; }
            get { return _huiyuan_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string huiyuan_quanxian
        {
            set { _huiyuan_quanxian = value; }
            get { return _huiyuan_quanxian; }
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
        /// 管理员密码
        /// </summary>
        public string huiyuan_pass
        {
            set { _huiyuan_pass = value; }
            get { return _huiyuan_pass; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string huiyuan_chu_jifen
        {
            set { _huiyuan_chu_jifen = value; }
            get { return _huiyuan_chu_jifen; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? yong_flag
        {
            set { _yong_flag = value; }
            get { return _yong_flag; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string pass_two
        {
            set { _pass_two = value; }
            get { return _pass_two; }
        }
        /// <summary>
        /// 管理员角色
        /// </summary>
        public int? role_id
        {
            set { _role_id = value; }
            get { return _role_id; }
        }
        /// <summary>
        /// 是否锁定
        /// </summary>
        public int? is_lock
        {
            set { _is_lock = value; }
            get { return _is_lock; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? add_time
        {
            set { _add_time = value; }
            get { return _add_time; }
        }
        #endregion Model


        #region  Method

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public tbl_admin(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,huiyuan_id,huiyuan_name,huiyuan_quanxian,huiyuan_bianhao,huiyuan_pass,huiyuan_chu_jifen,yong_flag,pass_two,role_id,is_lock,add_time ");
            strSql.Append(" FROM [tbl_admin] ");
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
                if (ds.Tables[0].Rows[0]["huiyuan_id"] != null)
                {
                    this.huiyuan_id = ds.Tables[0].Rows[0]["huiyuan_id"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_name"] != null)
                {
                    this.huiyuan_name = ds.Tables[0].Rows[0]["huiyuan_name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_quanxian"] != null)
                {
                    this.huiyuan_quanxian = ds.Tables[0].Rows[0]["huiyuan_quanxian"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_bianhao"] != null)
                {
                    this.huiyuan_bianhao = ds.Tables[0].Rows[0]["huiyuan_bianhao"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_pass"] != null)
                {
                    this.huiyuan_pass = ds.Tables[0].Rows[0]["huiyuan_pass"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_chu_jifen"] != null)
                {
                    this.huiyuan_chu_jifen = ds.Tables[0].Rows[0]["huiyuan_chu_jifen"].ToString();
                }
                if (ds.Tables[0].Rows[0]["yong_flag"] != null && ds.Tables[0].Rows[0]["yong_flag"].ToString() != "")
                {
                    this.yong_flag = int.Parse(ds.Tables[0].Rows[0]["yong_flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["pass_two"] != null)
                {
                    this.pass_two = ds.Tables[0].Rows[0]["pass_two"].ToString();
                }
                if (ds.Tables[0].Rows[0]["role_id"] != null && ds.Tables[0].Rows[0]["role_id"].ToString() != "")
                {
                    this.role_id = int.Parse(ds.Tables[0].Rows[0]["role_id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["is_lock"] != null && ds.Tables[0].Rows[0]["is_lock"].ToString() != "")
                {
                    this.is_lock = int.Parse(ds.Tables[0].Rows[0]["is_lock"].ToString());
                }
                if (ds.Tables[0].Rows[0]["add_time"] != null && ds.Tables[0].Rows[0]["add_time"].ToString() != "")
                {
                    this.add_time = DateTime.Parse(ds.Tables[0].Rows[0]["add_time"].ToString());
                }
            }
        }
        /// <summary>
        /// 是否存在该管理员记录
        /// </summary>
        public bool Exists(string huiyuan_bianhao)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from [tbl_admin]");
            strSql.Append(" where huiyuan_bianhao=@huiyuan_bianhao ");

            SqlParameter[] parameters = {
					new SqlParameter("@huiyuan_bianhao", SqlDbType.VarChar,100)};
            parameters[0].Value = huiyuan_bianhao;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 排除自己查询用户名-账号是否存在
        /// </summary>
        public bool ExistsE(string huiyuan_bianhao, int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from  tbl_admin");
            strSql.Append(" where huiyuan_bianhao=@huiyuan_bianhao and  id<>@id");
            SqlParameter[] parameters = {
					new SqlParameter("@huiyuan_bianhao", SqlDbType.NVarChar,100),
                    new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = huiyuan_bianhao;
            parameters[1].Value = id;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into [tbl_admin] (");
            strSql.Append("huiyuan_id,huiyuan_name,huiyuan_quanxian,huiyuan_bianhao,huiyuan_pass,huiyuan_chu_jifen,yong_flag,pass_two,role_id,is_lock,add_time)");
            strSql.Append(" values (");
            strSql.Append("@huiyuan_id,@huiyuan_name,@huiyuan_quanxian,@huiyuan_bianhao,@huiyuan_pass,@huiyuan_chu_jifen,@yong_flag,@pass_two,@role_id,@is_lock,@add_time)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@huiyuan_id", SqlDbType.VarChar,50),
					new SqlParameter("@huiyuan_name", SqlDbType.VarChar,50),
					new SqlParameter("@huiyuan_quanxian", SqlDbType.VarChar,500),
					new SqlParameter("@huiyuan_bianhao", SqlDbType.VarChar,50),
					new SqlParameter("@huiyuan_pass", SqlDbType.VarChar,50),
					new SqlParameter("@huiyuan_chu_jifen", SqlDbType.VarChar,50),
					new SqlParameter("@yong_flag", SqlDbType.Int,4),
					new SqlParameter("@pass_two", SqlDbType.VarChar,50),
					new SqlParameter("@role_id", SqlDbType.Int,4),
					new SqlParameter("@is_lock", SqlDbType.Int,4),
					new SqlParameter("@add_time", SqlDbType.DateTime)};
            parameters[0].Value = huiyuan_id;
            parameters[1].Value = huiyuan_name;
            parameters[2].Value = huiyuan_quanxian;
            parameters[3].Value = huiyuan_bianhao;
            parameters[4].Value = huiyuan_pass;
            parameters[5].Value = huiyuan_chu_jifen;
            parameters[6].Value = yong_flag;
            parameters[7].Value = pass_two;
            parameters[8].Value = role_id;
            parameters[9].Value = is_lock;
            parameters[10].Value = add_time;

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
            strSql.Append("update [tbl_admin] set ");
            strSql.Append("huiyuan_id=@huiyuan_id,");
            strSql.Append("huiyuan_name=@huiyuan_name,");
            strSql.Append("huiyuan_quanxian=@huiyuan_quanxian,");
            strSql.Append("huiyuan_bianhao=@huiyuan_bianhao,");
            strSql.Append("huiyuan_pass=@huiyuan_pass,");
            strSql.Append("huiyuan_chu_jifen=@huiyuan_chu_jifen,");
            strSql.Append("yong_flag=@yong_flag,");
            strSql.Append("pass_two=@pass_two,");
            strSql.Append("role_id=@role_id,");
            strSql.Append("is_lock=@is_lock,");
            strSql.Append("add_time=@add_time");
            strSql.Append(" where id=@id ");
            SqlParameter[] parameters = {
					new SqlParameter("@huiyuan_id", SqlDbType.VarChar,50),
					new SqlParameter("@huiyuan_name", SqlDbType.VarChar,50),
					new SqlParameter("@huiyuan_quanxian", SqlDbType.VarChar,500),
					new SqlParameter("@huiyuan_bianhao", SqlDbType.VarChar,50),
					new SqlParameter("@huiyuan_pass", SqlDbType.VarChar,50),
					new SqlParameter("@huiyuan_chu_jifen", SqlDbType.VarChar,50),
					new SqlParameter("@yong_flag", SqlDbType.Int,4),
					new SqlParameter("@pass_two", SqlDbType.VarChar,50),
					new SqlParameter("@role_id", SqlDbType.Int,4),
					new SqlParameter("@is_lock", SqlDbType.Int,4),
					new SqlParameter("@add_time", SqlDbType.DateTime),
					new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = huiyuan_id;
            parameters[1].Value = huiyuan_name;
            parameters[2].Value = huiyuan_quanxian;
            parameters[3].Value = huiyuan_bianhao;
            parameters[4].Value = huiyuan_pass;
            parameters[5].Value = huiyuan_chu_jifen;
            parameters[6].Value = yong_flag;
            parameters[7].Value = pass_two;
            parameters[8].Value = role_id;
            parameters[9].Value = is_lock;
            parameters[10].Value = add_time;
            parameters[11].Value = id;

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
        /// 修改个人信息
        /// </summary>
        public bool UpdateMY()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update [tbl_admin] set ");
            strSql.Append("huiyuan_pass=@huiyuan_pass");
          
            strSql.Append(" where id=@id ");
            SqlParameter[] parameters = {

					new SqlParameter("@huiyuan_pass", SqlDbType.NVarChar,100),
					new SqlParameter("@id", SqlDbType.Int,4)};

            parameters[0].Value = huiyuan_pass;
            parameters[1].Value = id;

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
            strSql.Append("delete from [tbl_admin] ");
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
            strSql.Append("select id,huiyuan_id,huiyuan_name,huiyuan_quanxian,huiyuan_bianhao,huiyuan_pass,huiyuan_chu_jifen,yong_flag,pass_two,role_id,is_lock,add_time ");
            strSql.Append(" FROM [tbl_admin] ");
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
                if (ds.Tables[0].Rows[0]["huiyuan_id"] != null)
                {
                    this.huiyuan_id = ds.Tables[0].Rows[0]["huiyuan_id"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_name"] != null)
                {
                    this.huiyuan_name = ds.Tables[0].Rows[0]["huiyuan_name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_quanxian"] != null)
                {
                    this.huiyuan_quanxian = ds.Tables[0].Rows[0]["huiyuan_quanxian"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_bianhao"] != null)
                {
                    this.huiyuan_bianhao = ds.Tables[0].Rows[0]["huiyuan_bianhao"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_pass"] != null)
                {
                    this.huiyuan_pass = ds.Tables[0].Rows[0]["huiyuan_pass"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_chu_jifen"] != null)
                {
                    this.huiyuan_chu_jifen = ds.Tables[0].Rows[0]["huiyuan_chu_jifen"].ToString();
                }
                if (ds.Tables[0].Rows[0]["yong_flag"] != null && ds.Tables[0].Rows[0]["yong_flag"].ToString() != "")
                {
                    this.yong_flag = int.Parse(ds.Tables[0].Rows[0]["yong_flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["pass_two"] != null)
                {
                    this.pass_two = ds.Tables[0].Rows[0]["pass_two"].ToString();
                }
                if (ds.Tables[0].Rows[0]["role_id"] != null && ds.Tables[0].Rows[0]["role_id"].ToString() != "")
                {
                    this.role_id = int.Parse(ds.Tables[0].Rows[0]["role_id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["is_lock"] != null && ds.Tables[0].Rows[0]["is_lock"].ToString() != "")
                {
                    this.is_lock = int.Parse(ds.Tables[0].Rows[0]["is_lock"].ToString());
                }
                if (ds.Tables[0].Rows[0]["add_time"] != null && ds.Tables[0].Rows[0]["add_time"].ToString() != "")
                {
                    this.add_time = DateTime.Parse(ds.Tables[0].Rows[0]["add_time"].ToString());
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
            strSql.Append(" FROM [tbl_admin] ");
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
            strSql.Append("select * FROM  tbl_admin");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            recordCount = Convert.ToInt32(DbHelperSQL.GetSingle(PagingHelper.CreateCountingSql(strSql.ToString())));
            return DbHelperSQL.Query(PagingHelper.CreatePagingSql(recordCount, pageSize, pageIndex, strSql.ToString(), filedOrder));
        }


        public static bool Exists(string UserName, string UserPassword)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from tbl_admin");
            strSql.Append(" where huiyuan_bianhao=@UserName and huiyuan_pass=@UserPassword ");
            SqlParameter[] parameters = {
					new SqlParameter("@UserName", SqlDbType.NVarChar,50),
					new SqlParameter("@UserPassword", SqlDbType.NVarChar,50)};
            parameters[0].Value = UserName;
            parameters[1].Value = UserPassword;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        #endregion  Method
    }
 

