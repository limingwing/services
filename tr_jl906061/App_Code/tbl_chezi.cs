using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
 
 
    /// <summary>
    /// 类tbl_chezi。
    /// </summary>
    [Serializable]
    public partial class tbl_chezi
    {
        public tbl_chezi()
        { }
        #region Model
        private int _id;
        private string _xiaofei_hui_id;
        private string _xiaofei_bianhao;
        private int? _yuanshi_id;
        private decimal? _xiaofei_money = 0M;
        private DateTime? _xiaofei_qr_date;
        private DateTime? _quxiao_date;
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
        public string xiaofei_hui_id
        {
            set { _xiaofei_hui_id = value; }
            get { return _xiaofei_hui_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string xiaofei_bianhao
        {
            set { _xiaofei_bianhao = value; }
            get { return _xiaofei_bianhao; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? yuanshi_id
        {
            set { _yuanshi_id = value; }
            get { return _yuanshi_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? xiaofei_money
        {
            set { _xiaofei_money = value; }
            get { return _xiaofei_money; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? xiaofei_qr_date
        {
            set { _xiaofei_qr_date = value; }
            get { return _xiaofei_qr_date; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? quxiao_date
        {
            set { _quxiao_date = value; }
            get { return _quxiao_date; }
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
        public tbl_chezi(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,xiaofei_hui_id,xiaofei_bianhao,yuanshi_id,xiaofei_money,xiaofei_qr_date,quxiao_date,flag ");
            strSql.Append(" FROM [tbl_chezi] ");
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
                if (ds.Tables[0].Rows[0]["xiaofei_hui_id"] != null)
                {
                    this.xiaofei_hui_id = ds.Tables[0].Rows[0]["xiaofei_hui_id"].ToString();
                }
                if (ds.Tables[0].Rows[0]["xiaofei_bianhao"] != null)
                {
                    this.xiaofei_bianhao = ds.Tables[0].Rows[0]["xiaofei_bianhao"].ToString();
                }
                if (ds.Tables[0].Rows[0]["yuanshi_id"] != null && ds.Tables[0].Rows[0]["yuanshi_id"].ToString() != "")
                {
                    this.yuanshi_id = int.Parse(ds.Tables[0].Rows[0]["yuanshi_id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xiaofei_money"] != null && ds.Tables[0].Rows[0]["xiaofei_money"].ToString() != "")
                {
                    this.xiaofei_money = decimal.Parse(ds.Tables[0].Rows[0]["xiaofei_money"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xiaofei_qr_date"] != null && ds.Tables[0].Rows[0]["xiaofei_qr_date"].ToString() != "")
                {
                    this.xiaofei_qr_date = DateTime.Parse(ds.Tables[0].Rows[0]["xiaofei_qr_date"].ToString());
                }
                if (ds.Tables[0].Rows[0]["quxiao_date"] != null && ds.Tables[0].Rows[0]["quxiao_date"].ToString() != "")
                {
                    this.quxiao_date = DateTime.Parse(ds.Tables[0].Rows[0]["quxiao_date"].ToString());
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
        public bool Exists()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from [tbl_chezi]");
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
            strSql.Append("insert into [tbl_chezi] (");
            strSql.Append("xiaofei_hui_id,xiaofei_bianhao,yuanshi_id,xiaofei_money,xiaofei_qr_date,quxiao_date,flag)");
            strSql.Append(" values (");
            strSql.Append("@xiaofei_hui_id,@xiaofei_bianhao,@yuanshi_id,@xiaofei_money,@xiaofei_qr_date,@quxiao_date,@flag)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@xiaofei_hui_id", SqlDbType.Char,9),
					new SqlParameter("@xiaofei_bianhao", SqlDbType.VarChar,50),
					new SqlParameter("@yuanshi_id", SqlDbType.Int,4),
					new SqlParameter("@xiaofei_money", SqlDbType.Money,8),
					new SqlParameter("@xiaofei_qr_date", SqlDbType.DateTime),
					new SqlParameter("@quxiao_date", SqlDbType.DateTime),
					new SqlParameter("@flag", SqlDbType.Int,4)};
            parameters[0].Value = xiaofei_hui_id;
            parameters[1].Value = xiaofei_bianhao;
            parameters[2].Value = yuanshi_id;
            parameters[3].Value = xiaofei_money;
            parameters[4].Value = xiaofei_qr_date;
            parameters[5].Value = quxiao_date;
            parameters[6].Value = flag;

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
            strSql.Append("update [tbl_chezi] set ");
            strSql.Append("xiaofei_hui_id=@xiaofei_hui_id,");
            strSql.Append("xiaofei_bianhao=@xiaofei_bianhao,");
            strSql.Append("yuanshi_id=@yuanshi_id,");
            strSql.Append("xiaofei_money=@xiaofei_money,");
            strSql.Append("xiaofei_qr_date=@xiaofei_qr_date,");
            strSql.Append("quxiao_date=@quxiao_date,");
            strSql.Append("flag=@flag");
            strSql.Append(" where id=@id ");
            SqlParameter[] parameters = {
					new SqlParameter("@xiaofei_hui_id", SqlDbType.Char,9),
					new SqlParameter("@xiaofei_bianhao", SqlDbType.VarChar,50),
					new SqlParameter("@yuanshi_id", SqlDbType.Int,4),
					new SqlParameter("@xiaofei_money", SqlDbType.Money,8),
					new SqlParameter("@xiaofei_qr_date", SqlDbType.DateTime),
					new SqlParameter("@quxiao_date", SqlDbType.DateTime),
					new SqlParameter("@flag", SqlDbType.Int,4),
					new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = xiaofei_hui_id;
            parameters[1].Value = xiaofei_bianhao;
            parameters[2].Value = yuanshi_id;
            parameters[3].Value = xiaofei_money;
            parameters[4].Value = xiaofei_qr_date;
            parameters[5].Value = quxiao_date;
            parameters[6].Value = flag;
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
            strSql.Append("delete from [tbl_chezi] ");
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
            strSql.Append("select id,xiaofei_hui_id,xiaofei_bianhao,yuanshi_id,xiaofei_money,xiaofei_qr_date,quxiao_date,flag ");
            strSql.Append(" FROM [tbl_chezi] ");
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
                if (ds.Tables[0].Rows[0]["xiaofei_hui_id"] != null)
                {
                    this.xiaofei_hui_id = ds.Tables[0].Rows[0]["xiaofei_hui_id"].ToString();
                }
                if (ds.Tables[0].Rows[0]["xiaofei_bianhao"] != null)
                {
                    this.xiaofei_bianhao = ds.Tables[0].Rows[0]["xiaofei_bianhao"].ToString();
                }
                if (ds.Tables[0].Rows[0]["yuanshi_id"] != null && ds.Tables[0].Rows[0]["yuanshi_id"].ToString() != "")
                {
                    this.yuanshi_id = int.Parse(ds.Tables[0].Rows[0]["yuanshi_id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xiaofei_money"] != null && ds.Tables[0].Rows[0]["xiaofei_money"].ToString() != "")
                {
                    this.xiaofei_money = decimal.Parse(ds.Tables[0].Rows[0]["xiaofei_money"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xiaofei_qr_date"] != null && ds.Tables[0].Rows[0]["xiaofei_qr_date"].ToString() != "")
                {
                    this.xiaofei_qr_date = DateTime.Parse(ds.Tables[0].Rows[0]["xiaofei_qr_date"].ToString());
                }
                if (ds.Tables[0].Rows[0]["quxiao_date"] != null && ds.Tables[0].Rows[0]["quxiao_date"].ToString() != "")
                {
                    this.quxiao_date = DateTime.Parse(ds.Tables[0].Rows[0]["quxiao_date"].ToString());
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
            strSql.Append(" FROM [tbl_chezi] ");
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
            strSql.Append("select * FROM  tbl_chezi");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            recordCount = Convert.ToInt32(DbHelperSQL.GetSingle(PagingHelper.CreateCountingSql(strSql.ToString())));
            return DbHelperSQL.Query(PagingHelper.CreatePagingSql(recordCount, pageSize, pageIndex, strSql.ToString(), filedOrder));
        }


        /// <summary>
        /// 获得查询分页数据
        /// </summary>
        public DataSet GetList_view(int pageSize, int pageIndex, string strWhere, string filedOrder, out int recordCount)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * FROM  view_chezi");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            recordCount = Convert.ToInt32(DbHelperSQL.GetSingle(PagingHelper.CreateCountingSql(strSql.ToString())));
            return DbHelperSQL.Query(PagingHelper.CreatePagingSql(recordCount, pageSize, pageIndex, strSql.ToString(), filedOrder));
        }
        /// <summary>
        /// 根据条件和字段汇总
        /// </summary>
        public string GetTitleSum(string strWhere, string Title)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top 1 " + Title + " as sumcode from [tbl_chezi]");
            strSql.Append(" where " + strWhere);
            string title = Convert.ToString(DbHelperSQL.GetSingle(strSql.ToString()));
            if (string.IsNullOrEmpty(title))
            {
                return "0";
            }
            return title;
        }

        #endregion  Method
    }
 

