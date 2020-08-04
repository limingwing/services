using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
 
 
    /// <summary>
    /// 类tbl_shangshu。
    /// </summary>
    [Serializable]
    public partial class tbl_shangshu
    {
        public tbl_shangshu()
        { }
        #region Model
        private int _temp_id;
        private string _huiyuan_id;
        private string _huiyuan_shang_id;
        private int? _huiyuan_xuhao;
        private DateTime? _add_date = DateTime.Now;
        private int? _type = 1;
        private int? _xianhao = 0;
        private int? _flag = 0;
        private int? _net_hege = 0;
        private DateTime? _qr_date;
        private int? _kd_flag = 0;
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
        public DateTime? add_date
        {
            set { _add_date = value; }
            get { return _add_date; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? type
        {
            set { _type = value; }
            get { return _type; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? xianhao
        {
            set { _xianhao = value; }
            get { return _xianhao; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? flag
        {
            set { _flag = value; }
            get { return _flag; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? net_hege
        {
            set { _net_hege = value; }
            get { return _net_hege; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? qr_date
        {
            set { _qr_date = value; }
            get { return _qr_date; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? kd_flag
        {
            set { _kd_flag = value; }
            get { return _kd_flag; }
        }
        #endregion Model


        #region  Method

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public tbl_shangshu(string huiyuan_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select temp_id,huiyuan_id,huiyuan_shang_id,huiyuan_xuhao,add_date,type,xianhao,flag,net_hege,qr_date,kd_flag ");
            strSql.Append(" FROM [tbl_shangshu] ");
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
                if (ds.Tables[0].Rows[0]["add_date"] != null && ds.Tables[0].Rows[0]["add_date"].ToString() != "")
                {
                    this.add_date = DateTime.Parse(ds.Tables[0].Rows[0]["add_date"].ToString());
                }
                if (ds.Tables[0].Rows[0]["type"] != null && ds.Tables[0].Rows[0]["type"].ToString() != "")
                {
                    this.type = int.Parse(ds.Tables[0].Rows[0]["type"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xianhao"] != null && ds.Tables[0].Rows[0]["xianhao"].ToString() != "")
                {
                    this.xianhao = int.Parse(ds.Tables[0].Rows[0]["xianhao"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag"] != null && ds.Tables[0].Rows[0]["flag"].ToString() != "")
                {
                    this.flag = int.Parse(ds.Tables[0].Rows[0]["flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["net_hege"] != null && ds.Tables[0].Rows[0]["net_hege"].ToString() != "")
                {
                    this.net_hege = int.Parse(ds.Tables[0].Rows[0]["net_hege"].ToString());
                }
                if (ds.Tables[0].Rows[0]["qr_date"] != null && ds.Tables[0].Rows[0]["qr_date"].ToString() != "")
                {
                    this.qr_date = DateTime.Parse(ds.Tables[0].Rows[0]["qr_date"].ToString());
                }
                if (ds.Tables[0].Rows[0]["kd_flag"] != null && ds.Tables[0].Rows[0]["kd_flag"].ToString() != "")
                {
                    this.kd_flag = int.Parse(ds.Tables[0].Rows[0]["kd_flag"].ToString());
                }
            }
        }
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string huiyuan_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from [tbl_shangshu]");
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
            strSql.Append("insert into [tbl_shangshu] (");
            strSql.Append("huiyuan_id,huiyuan_shang_id,huiyuan_xuhao,add_date,type,xianhao,flag,net_hege,qr_date,kd_flag)");
            strSql.Append(" values (");
            strSql.Append("@huiyuan_id,@huiyuan_shang_id,@huiyuan_xuhao,@add_date,@type,@xianhao,@flag,@net_hege,@qr_date,@kd_flag)");
            SqlParameter[] parameters = {
					new SqlParameter("@huiyuan_id", SqlDbType.Char,9),
					new SqlParameter("@huiyuan_shang_id", SqlDbType.Char,9),
					new SqlParameter("@huiyuan_xuhao", SqlDbType.Int,4),
					new SqlParameter("@add_date", SqlDbType.DateTime),
					new SqlParameter("@type", SqlDbType.Int,4),
					new SqlParameter("@xianhao", SqlDbType.Int,4),
					new SqlParameter("@flag", SqlDbType.Int,4),
					new SqlParameter("@net_hege", SqlDbType.Int,4),
					new SqlParameter("@qr_date", SqlDbType.DateTime),
					new SqlParameter("@kd_flag", SqlDbType.Int,4)};
            parameters[0].Value = huiyuan_id;
            parameters[1].Value = huiyuan_shang_id;
            parameters[2].Value = huiyuan_xuhao;
            parameters[3].Value = add_date;
            parameters[4].Value = type;
            parameters[5].Value = xianhao;
            parameters[6].Value = flag;
            parameters[7].Value = net_hege;
            parameters[8].Value = qr_date;
            parameters[9].Value = kd_flag;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update [tbl_shangshu] set ");
            strSql.Append("huiyuan_id=@huiyuan_id,");
            strSql.Append("huiyuan_shang_id=@huiyuan_shang_id,");
            strSql.Append("huiyuan_xuhao=@huiyuan_xuhao,");
            strSql.Append("add_date=@add_date,");
            strSql.Append("type=@type,");
            strSql.Append("xianhao=@xianhao,");
            strSql.Append("flag=@flag,");
            strSql.Append("net_hege=@net_hege,");
            strSql.Append("qr_date=@qr_date,");
            strSql.Append("kd_flag=@kd_flag");
            strSql.Append(" where huiyuan_id=@huiyuan_id ");
            SqlParameter[] parameters = {
					new SqlParameter("@huiyuan_id", SqlDbType.Char,9),
					new SqlParameter("@huiyuan_shang_id", SqlDbType.Char,9),
					new SqlParameter("@huiyuan_xuhao", SqlDbType.Int,4),
					new SqlParameter("@add_date", SqlDbType.DateTime),
					new SqlParameter("@type", SqlDbType.Int,4),
					new SqlParameter("@xianhao", SqlDbType.Int,4),
					new SqlParameter("@flag", SqlDbType.Int,4),
					new SqlParameter("@net_hege", SqlDbType.Int,4),
					new SqlParameter("@qr_date", SqlDbType.DateTime),
					new SqlParameter("@kd_flag", SqlDbType.Int,4),
					new SqlParameter("@temp_id", SqlDbType.Int,4)};
            parameters[0].Value = huiyuan_id;
            parameters[1].Value = huiyuan_shang_id;
            parameters[2].Value = huiyuan_xuhao;
            parameters[3].Value = add_date;
            parameters[4].Value = type;
            parameters[5].Value = xianhao;
            parameters[6].Value = flag;
            parameters[7].Value = net_hege;
            parameters[8].Value = qr_date;
            parameters[9].Value = kd_flag;
            parameters[10].Value = temp_id;

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
            strSql.Append("delete from [tbl_shangshu] ");
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
            strSql.Append("select temp_id,huiyuan_id,huiyuan_shang_id,huiyuan_xuhao,add_date,type,xianhao,flag,net_hege,qr_date,kd_flag ");
            strSql.Append(" FROM [tbl_shangshu] ");
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
                if (ds.Tables[0].Rows[0]["add_date"] != null && ds.Tables[0].Rows[0]["add_date"].ToString() != "")
                {
                    this.add_date = DateTime.Parse(ds.Tables[0].Rows[0]["add_date"].ToString());
                }
                if (ds.Tables[0].Rows[0]["type"] != null && ds.Tables[0].Rows[0]["type"].ToString() != "")
                {
                    this.type = int.Parse(ds.Tables[0].Rows[0]["type"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xianhao"] != null && ds.Tables[0].Rows[0]["xianhao"].ToString() != "")
                {
                    this.xianhao = int.Parse(ds.Tables[0].Rows[0]["xianhao"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag"] != null && ds.Tables[0].Rows[0]["flag"].ToString() != "")
                {
                    this.flag = int.Parse(ds.Tables[0].Rows[0]["flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["net_hege"] != null && ds.Tables[0].Rows[0]["net_hege"].ToString() != "")
                {
                    this.net_hege = int.Parse(ds.Tables[0].Rows[0]["net_hege"].ToString());
                }
                if (ds.Tables[0].Rows[0]["qr_date"] != null && ds.Tables[0].Rows[0]["qr_date"].ToString() != "")
                {
                    this.qr_date = DateTime.Parse(ds.Tables[0].Rows[0]["qr_date"].ToString());
                }
                if (ds.Tables[0].Rows[0]["kd_flag"] != null && ds.Tables[0].Rows[0]["kd_flag"].ToString() != "")
                {
                    this.kd_flag = int.Parse(ds.Tables[0].Rows[0]["kd_flag"].ToString());
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
            strSql.Append(" FROM [tbl_shangshu] ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion  Method
    }
 

