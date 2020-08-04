using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;

/// <summary>
///tbl_sinkia_config
/// </summary>
    [Serializable]
    public partial class tbl_sinkia_config
    {
        public tbl_sinkia_config()
        { }
        #region Model
        private int _id;
        private string _logo_web_img;
        private string _logo_mobel_img;
        private string _home_title;
        private string _home_code;
        private string _home_qq;
        private string _home_copyright;
        private string _beiyong1;
        private string _beiyong2;
        private string _beiyong3;
        private string _beiyong4;
        private string _beiyong5;
        private string _beiyong6;
        private int? _beiyong7;
        private int? _beiyong8;
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
        public string logo_web_img
        {
            set { _logo_web_img = value; }
            get { return _logo_web_img; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string logo_mobel_img
        {
            set { _logo_mobel_img = value; }
            get { return _logo_mobel_img; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string home_title
        {
            set { _home_title = value; }
            get { return _home_title; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string home_code
        {
            set { _home_code = value; }
            get { return _home_code; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string home_qq
        {
            set { _home_qq = value; }
            get { return _home_qq; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string home_copyright
        {
            set { _home_copyright = value; }
            get { return _home_copyright; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string beiyong1
        {
            set { _beiyong1 = value; }
            get { return _beiyong1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string beiyong2
        {
            set { _beiyong2 = value; }
            get { return _beiyong2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string beiyong3
        {
            set { _beiyong3 = value; }
            get { return _beiyong3; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string beiyong4
        {
            set { _beiyong4 = value; }
            get { return _beiyong4; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string beiyong5
        {
            set { _beiyong5 = value; }
            get { return _beiyong5; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string beiyong6
        {
            set { _beiyong6 = value; }
            get { return _beiyong6; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? beiyong7
        {
            set { _beiyong7 = value; }
            get { return _beiyong7; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? beiyong8
        {
            set { _beiyong8 = value; }
            get { return _beiyong8; }
        }
        #endregion Model


        #region  Method

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public tbl_sinkia_config(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,logo_web_img,logo_mobel_img,home_title,home_code,home_qq,home_copyright,beiyong1,beiyong2,beiyong3,beiyong4,beiyong5,beiyong6,beiyong7,beiyong8 ");
            strSql.Append(" FROM [tbl_sinkia_config] ");
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
                if (ds.Tables[0].Rows[0]["logo_web_img"] != null)
                {
                    this.logo_web_img = ds.Tables[0].Rows[0]["logo_web_img"].ToString();
                }
                if (ds.Tables[0].Rows[0]["logo_mobel_img"] != null)
                {
                    this.logo_mobel_img = ds.Tables[0].Rows[0]["logo_mobel_img"].ToString();
                }
                if (ds.Tables[0].Rows[0]["home_title"] != null)
                {
                    this.home_title = ds.Tables[0].Rows[0]["home_title"].ToString();
                }
                if (ds.Tables[0].Rows[0]["home_code"] != null)
                {
                    this.home_code = ds.Tables[0].Rows[0]["home_code"].ToString();
                }
                if (ds.Tables[0].Rows[0]["home_qq"] != null)
                {
                    this.home_qq = ds.Tables[0].Rows[0]["home_qq"].ToString();
                }
                if (ds.Tables[0].Rows[0]["home_copyright"] != null)
                {
                    this.home_copyright = ds.Tables[0].Rows[0]["home_copyright"].ToString();
                }
                if (ds.Tables[0].Rows[0]["beiyong1"] != null)
                {
                    this.beiyong1 = ds.Tables[0].Rows[0]["beiyong1"].ToString();
                }
                if (ds.Tables[0].Rows[0]["beiyong2"] != null)
                {
                    this.beiyong2 = ds.Tables[0].Rows[0]["beiyong2"].ToString();
                }
                if (ds.Tables[0].Rows[0]["beiyong3"] != null)
                {
                    this.beiyong3 = ds.Tables[0].Rows[0]["beiyong3"].ToString();
                }
                if (ds.Tables[0].Rows[0]["beiyong4"] != null)
                {
                    this.beiyong4 = ds.Tables[0].Rows[0]["beiyong4"].ToString();
                }
                if (ds.Tables[0].Rows[0]["beiyong5"] != null)
                {
                    this.beiyong5 = ds.Tables[0].Rows[0]["beiyong5"].ToString();
                }
                if (ds.Tables[0].Rows[0]["beiyong6"] != null)
                {
                    this.beiyong6 = ds.Tables[0].Rows[0]["beiyong6"].ToString();
                }
                if (ds.Tables[0].Rows[0]["beiyong7"] != null && ds.Tables[0].Rows[0]["beiyong7"].ToString() != "")
                {
                    this.beiyong7 = int.Parse(ds.Tables[0].Rows[0]["beiyong7"].ToString());
                }
                if (ds.Tables[0].Rows[0]["beiyong8"] != null && ds.Tables[0].Rows[0]["beiyong8"].ToString() != "")
                {
                    this.beiyong8 = int.Parse(ds.Tables[0].Rows[0]["beiyong8"].ToString());
                }
            }
        }
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from [tbl_sinkia_config]");
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
            strSql.Append("insert into [tbl_sinkia_config] (");
            strSql.Append("logo_web_img,logo_mobel_img,home_title,home_code,home_qq,home_copyright,beiyong1,beiyong2,beiyong3,beiyong4,beiyong5,beiyong6,beiyong7,beiyong8)");
            strSql.Append(" values (");
            strSql.Append("@logo_web_img,@logo_mobel_img,@home_title,@home_code,@home_qq,@home_copyright,@beiyong1,@beiyong2,@beiyong3,@beiyong4,@beiyong5,@beiyong6,@beiyong7,@beiyong8)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@logo_web_img", SqlDbType.VarChar,200),
					new SqlParameter("@logo_mobel_img", SqlDbType.VarChar,200),
					new SqlParameter("@home_title", SqlDbType.VarChar,200),
					new SqlParameter("@home_code", SqlDbType.VarChar,200),
					new SqlParameter("@home_qq", SqlDbType.VarChar,200),
					new SqlParameter("@home_copyright", SqlDbType.VarChar,200),
					new SqlParameter("@beiyong1", SqlDbType.VarChar,200),
					new SqlParameter("@beiyong2", SqlDbType.VarChar,200),
					new SqlParameter("@beiyong3", SqlDbType.VarChar,200),
					new SqlParameter("@beiyong4", SqlDbType.VarChar,200),
					new SqlParameter("@beiyong5", SqlDbType.VarChar,200),
					new SqlParameter("@beiyong6", SqlDbType.VarChar,200),
					new SqlParameter("@beiyong7", SqlDbType.Int,4),
					new SqlParameter("@beiyong8", SqlDbType.Int,4)};
            parameters[0].Value = logo_web_img;
            parameters[1].Value = logo_mobel_img;
            parameters[2].Value = home_title;
            parameters[3].Value = home_code;
            parameters[4].Value = home_qq;
            parameters[5].Value = home_copyright;
            parameters[6].Value = beiyong1;
            parameters[7].Value = beiyong2;
            parameters[8].Value = beiyong3;
            parameters[9].Value = beiyong4;
            parameters[10].Value = beiyong5;
            parameters[11].Value = beiyong6;
            parameters[12].Value = beiyong7;
            parameters[13].Value = beiyong8;

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
            strSql.Append("update [tbl_sinkia_config] set ");
            strSql.Append("logo_web_img=@logo_web_img,");
            strSql.Append("logo_mobel_img=@logo_mobel_img,");
            strSql.Append("home_title=@home_title,");
            strSql.Append("home_code=@home_code,");
            strSql.Append("home_qq=@home_qq,");
            strSql.Append("home_copyright=@home_copyright,");
            strSql.Append("beiyong1=@beiyong1,");
            strSql.Append("beiyong2=@beiyong2,");
            strSql.Append("beiyong3=@beiyong3,");
            strSql.Append("beiyong4=@beiyong4,");
            strSql.Append("beiyong5=@beiyong5,");
            strSql.Append("beiyong6=@beiyong6,");
            strSql.Append("beiyong7=@beiyong7,");
            strSql.Append("beiyong8=@beiyong8");
            strSql.Append(" where id=@id ");
            SqlParameter[] parameters = {
					new SqlParameter("@logo_web_img", SqlDbType.VarChar,200),
					new SqlParameter("@logo_mobel_img", SqlDbType.VarChar,200),
					new SqlParameter("@home_title", SqlDbType.VarChar,200),
					new SqlParameter("@home_code", SqlDbType.VarChar,200),
					new SqlParameter("@home_qq", SqlDbType.VarChar,200),
					new SqlParameter("@home_copyright", SqlDbType.VarChar,200),
					new SqlParameter("@beiyong1", SqlDbType.VarChar,200),
					new SqlParameter("@beiyong2", SqlDbType.VarChar,200),
					new SqlParameter("@beiyong3", SqlDbType.VarChar,200),
					new SqlParameter("@beiyong4", SqlDbType.VarChar,200),
					new SqlParameter("@beiyong5", SqlDbType.VarChar,200),
					new SqlParameter("@beiyong6", SqlDbType.VarChar,200),
					new SqlParameter("@beiyong7", SqlDbType.Int,4),
					new SqlParameter("@beiyong8", SqlDbType.Int,4),
					new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = logo_web_img;
            parameters[1].Value = logo_mobel_img;
            parameters[2].Value = home_title;
            parameters[3].Value = home_code;
            parameters[4].Value = home_qq;
            parameters[5].Value = home_copyright;
            parameters[6].Value = beiyong1;
            parameters[7].Value = beiyong2;
            parameters[8].Value = beiyong3;
            parameters[9].Value = beiyong4;
            parameters[10].Value = beiyong5;
            parameters[11].Value = beiyong6;
            parameters[12].Value = beiyong7;
            parameters[13].Value = beiyong8;
            parameters[14].Value = id;

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
            strSql.Append("delete from [tbl_sinkia_config] ");
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
            strSql.Append("select id,logo_web_img,logo_mobel_img,home_title,home_code,home_qq,home_copyright,beiyong1,beiyong2,beiyong3,beiyong4,beiyong5,beiyong6,beiyong7,beiyong8 ");
            strSql.Append(" FROM [tbl_sinkia_config] ");
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
                if (ds.Tables[0].Rows[0]["logo_web_img"] != null)
                {
                    this.logo_web_img = ds.Tables[0].Rows[0]["logo_web_img"].ToString();
                }
                if (ds.Tables[0].Rows[0]["logo_mobel_img"] != null)
                {
                    this.logo_mobel_img = ds.Tables[0].Rows[0]["logo_mobel_img"].ToString();
                }
                if (ds.Tables[0].Rows[0]["home_title"] != null)
                {
                    this.home_title = ds.Tables[0].Rows[0]["home_title"].ToString();
                }
                if (ds.Tables[0].Rows[0]["home_code"] != null)
                {
                    this.home_code = ds.Tables[0].Rows[0]["home_code"].ToString();
                }
                if (ds.Tables[0].Rows[0]["home_qq"] != null)
                {
                    this.home_qq = ds.Tables[0].Rows[0]["home_qq"].ToString();
                }
                if (ds.Tables[0].Rows[0]["home_copyright"] != null)
                {
                    this.home_copyright = ds.Tables[0].Rows[0]["home_copyright"].ToString();
                }
                if (ds.Tables[0].Rows[0]["beiyong1"] != null)
                {
                    this.beiyong1 = ds.Tables[0].Rows[0]["beiyong1"].ToString();
                }
                if (ds.Tables[0].Rows[0]["beiyong2"] != null)
                {
                    this.beiyong2 = ds.Tables[0].Rows[0]["beiyong2"].ToString();
                }
                if (ds.Tables[0].Rows[0]["beiyong3"] != null)
                {
                    this.beiyong3 = ds.Tables[0].Rows[0]["beiyong3"].ToString();
                }
                if (ds.Tables[0].Rows[0]["beiyong4"] != null)
                {
                    this.beiyong4 = ds.Tables[0].Rows[0]["beiyong4"].ToString();
                }
                if (ds.Tables[0].Rows[0]["beiyong5"] != null)
                {
                    this.beiyong5 = ds.Tables[0].Rows[0]["beiyong5"].ToString();
                }
                if (ds.Tables[0].Rows[0]["beiyong6"] != null)
                {
                    this.beiyong6 = ds.Tables[0].Rows[0]["beiyong6"].ToString();
                }
                if (ds.Tables[0].Rows[0]["beiyong7"] != null && ds.Tables[0].Rows[0]["beiyong7"].ToString() != "")
                {
                    this.beiyong7 = int.Parse(ds.Tables[0].Rows[0]["beiyong7"].ToString());
                }
                if (ds.Tables[0].Rows[0]["beiyong8"] != null && ds.Tables[0].Rows[0]["beiyong8"].ToString() != "")
                {
                    this.beiyong8 = int.Parse(ds.Tables[0].Rows[0]["beiyong8"].ToString());
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
            strSql.Append(" FROM [tbl_sinkia_config] ");
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
            strSql.Append("select * FROM  tbl_sinkia_config");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            recordCount = Convert.ToInt32(DbHelperSQL.GetSingle(PagingHelper.CreateCountingSql(strSql.ToString())));
            return DbHelperSQL.Query(PagingHelper.CreatePagingSql(recordCount, pageSize, pageIndex, strSql.ToString(), filedOrder));
        }
        #endregion  Method
    }
