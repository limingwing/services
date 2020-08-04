using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
 
 
    /// <summary>
    /// 类tbl_gupiao。
    /// </summary>
    [Serializable]
    public partial class tbl_gupiao
    {
        public tbl_gupiao()
        { }
        #region Model
        private int _id;
        private decimal? _gp_price;
        private decimal? _gp_cha = 0M;
        private DateTime? _gp_add_date;
        private int? _flag = 0;
        private int? _num = 0;
        private int? _gp_type = 0;
        private decimal? _di = 0M;
        private decimal? _gao = 0M;
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
        public decimal? gp_price
        {
            set { _gp_price = value; }
            get { return _gp_price; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? gp_cha
        {
            set { _gp_cha = value; }
            get { return _gp_cha; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? gp_add_date
        {
            set { _gp_add_date = value; }
            get { return _gp_add_date; }
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
        public int? num
        {
            set { _num = value; }
            get { return _num; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? gp_type
        {
            set { _gp_type = value; }
            get { return _gp_type; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? di
        {
            set { _di = value; }
            get { return _di; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? gao
        {
            set { _gao = value; }
            get { return _gao; }
        }
        #endregion Model


        #region  Method

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public tbl_gupiao(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,gp_price,gp_cha,gp_add_date,flag,num,gp_type,di,gao ");
            strSql.Append(" FROM [tbl_gupiao] ");
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
                if (ds.Tables[0].Rows[0]["gp_price"] != null && ds.Tables[0].Rows[0]["gp_price"].ToString() != "")
                {
                    this.gp_price = decimal.Parse(ds.Tables[0].Rows[0]["gp_price"].ToString());
                }
                if (ds.Tables[0].Rows[0]["gp_cha"] != null && ds.Tables[0].Rows[0]["gp_cha"].ToString() != "")
                {
                    this.gp_cha = decimal.Parse(ds.Tables[0].Rows[0]["gp_cha"].ToString());
                }
                if (ds.Tables[0].Rows[0]["gp_add_date"] != null && ds.Tables[0].Rows[0]["gp_add_date"].ToString() != "")
                {
                    this.gp_add_date = DateTime.Parse(ds.Tables[0].Rows[0]["gp_add_date"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag"] != null && ds.Tables[0].Rows[0]["flag"].ToString() != "")
                {
                    this.flag = int.Parse(ds.Tables[0].Rows[0]["flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["num"] != null && ds.Tables[0].Rows[0]["num"].ToString() != "")
                {
                    this.num = int.Parse(ds.Tables[0].Rows[0]["num"].ToString());
                }
                if (ds.Tables[0].Rows[0]["gp_type"] != null && ds.Tables[0].Rows[0]["gp_type"].ToString() != "")
                {
                    this.gp_type = int.Parse(ds.Tables[0].Rows[0]["gp_type"].ToString());
                }
                if (ds.Tables[0].Rows[0]["di"] != null && ds.Tables[0].Rows[0]["di"].ToString() != "")
                {
                    this.di = decimal.Parse(ds.Tables[0].Rows[0]["di"].ToString());
                }
                if (ds.Tables[0].Rows[0]["gao"] != null && ds.Tables[0].Rows[0]["gao"].ToString() != "")
                {
                    this.gao = decimal.Parse(ds.Tables[0].Rows[0]["gao"].ToString());
                }
            }
        }
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from [tbl_gupiao]");
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
            strSql.Append("insert into [tbl_gupiao] (");
            strSql.Append("gp_price,gp_cha,gp_add_date,flag,num,gp_type,di,gao)");
            strSql.Append(" values (");
            strSql.Append("@gp_price,@gp_cha,@gp_add_date,@flag,@num,@gp_type,@di,@gao)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@gp_price", SqlDbType.Float,8),
					new SqlParameter("@gp_cha", SqlDbType.Float,8),
					new SqlParameter("@gp_add_date", SqlDbType.DateTime),
					new SqlParameter("@flag", SqlDbType.Int,4),
					new SqlParameter("@num", SqlDbType.Int,4),
					new SqlParameter("@gp_type", SqlDbType.Int,4),
					new SqlParameter("@di", SqlDbType.Float,8),
					new SqlParameter("@gao", SqlDbType.Float,8)};
            parameters[0].Value = gp_price;
            parameters[1].Value = gp_cha;
            parameters[2].Value = gp_add_date;
            parameters[3].Value = flag;
            parameters[4].Value = num;
            parameters[5].Value = gp_type;
            parameters[6].Value = di;
            parameters[7].Value = gao;

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
            strSql.Append("update [tbl_gupiao] set ");
            strSql.Append("gp_price=@gp_price,");
            strSql.Append("gp_cha=@gp_cha,");
            strSql.Append("gp_add_date=@gp_add_date,");
            strSql.Append("flag=@flag,");
            strSql.Append("num=@num,");
            strSql.Append("gp_type=@gp_type,");
            strSql.Append("di=@di,");
            strSql.Append("gao=@gao");
            strSql.Append(" where id=@id ");
            SqlParameter[] parameters = {
					new SqlParameter("@gp_price", SqlDbType.Float,8),
					new SqlParameter("@gp_cha", SqlDbType.Float,8),
					new SqlParameter("@gp_add_date", SqlDbType.DateTime),
					new SqlParameter("@flag", SqlDbType.Int,4),
					new SqlParameter("@num", SqlDbType.Int,4),
					new SqlParameter("@gp_type", SqlDbType.Int,4),
					new SqlParameter("@di", SqlDbType.Float,8),
					new SqlParameter("@gao", SqlDbType.Float,8),
					new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = gp_price;
            parameters[1].Value = gp_cha;
            parameters[2].Value = gp_add_date;
            parameters[3].Value = flag;
            parameters[4].Value = num;
            parameters[5].Value = gp_type;
            parameters[6].Value = di;
            parameters[7].Value = gao;
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
        /// 删除一条数据
        /// </summary>
        public bool Delete(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from [tbl_gupiao] ");
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
            strSql.Append("select id,gp_price,gp_cha,gp_add_date,flag,num,gp_type,di,gao ");
            strSql.Append(" FROM [tbl_gupiao] ");
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
                if (ds.Tables[0].Rows[0]["gp_price"] != null && ds.Tables[0].Rows[0]["gp_price"].ToString() != "")
                {
                    this.gp_price = decimal.Parse(ds.Tables[0].Rows[0]["gp_price"].ToString());
                }
                if (ds.Tables[0].Rows[0]["gp_cha"] != null && ds.Tables[0].Rows[0]["gp_cha"].ToString() != "")
                {
                    this.gp_cha = decimal.Parse(ds.Tables[0].Rows[0]["gp_cha"].ToString());
                }
                if (ds.Tables[0].Rows[0]["gp_add_date"] != null && ds.Tables[0].Rows[0]["gp_add_date"].ToString() != "")
                {
                    this.gp_add_date = DateTime.Parse(ds.Tables[0].Rows[0]["gp_add_date"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag"] != null && ds.Tables[0].Rows[0]["flag"].ToString() != "")
                {
                    this.flag = int.Parse(ds.Tables[0].Rows[0]["flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["num"] != null && ds.Tables[0].Rows[0]["num"].ToString() != "")
                {
                    this.num = int.Parse(ds.Tables[0].Rows[0]["num"].ToString());
                }
                if (ds.Tables[0].Rows[0]["gp_type"] != null && ds.Tables[0].Rows[0]["gp_type"].ToString() != "")
                {
                    this.gp_type = int.Parse(ds.Tables[0].Rows[0]["gp_type"].ToString());
                }
                if (ds.Tables[0].Rows[0]["di"] != null && ds.Tables[0].Rows[0]["di"].ToString() != "")
                {
                    this.di = decimal.Parse(ds.Tables[0].Rows[0]["di"].ToString());
                }
                if (ds.Tables[0].Rows[0]["gao"] != null && ds.Tables[0].Rows[0]["gao"].ToString() != "")
                {
                    this.gao = decimal.Parse(ds.Tables[0].Rows[0]["gao"].ToString());
                }
            }
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select CONVERT(CHAR(12), gp_add_date, 108) AS gp_add_date,gp_price from tbl_gupiao");
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
            strSql.Append("select * FROM  tbl_gupiao");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            recordCount = Convert.ToInt32(DbHelperSQL.GetSingle(PagingHelper.CreateCountingSql(strSql.ToString())));
            return DbHelperSQL.Query(PagingHelper.CreatePagingSql(recordCount, pageSize, pageIndex, strSql.ToString(), filedOrder));
        }


        public DataSet GetListReport(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT CONVERT(CHAR(12), gp_add_date, 111) AS gp_add_date, MAX(gp_price) AS gp_price FROM tbl_gupiao");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        public string Gettop1()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top 1 * FROM  tbl_gupiao order by id desc");
            DataSet ds= DbHelperSQL.Query(strSql.ToString());
            string gupiao = ds.Tables[0].Rows[0]["gp_price"].ToString();
            return gupiao;
        }
        #endregion  Method
    }
 

