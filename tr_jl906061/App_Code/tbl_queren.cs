using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
 
 
    /// <summary>
    /// 类tbl_queren。
    /// </summary>
    [Serializable]
    public partial class tbl_queren
    {
        public tbl_queren()
        { }
        #region Model
        private int _id;
        private string _huiyuan_id;
        private string _huiyuan_bianhao;
        private string _huiyuan_zhuanmai;
        private decimal? _queren_money;
        private DateTime? _queren_date = DateTime.Now;
        private string _action_type;
        private string _memo;
        private int? _queren_type;
        private decimal? _money_before;
        private string _queren_man;
        private DateTime? _data;
        /// <summary>
        /// 
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 会员标识
        /// </summary>
        public string huiyuan_id
        {
            set { _huiyuan_id = value; }
            get { return _huiyuan_id; }
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
        public string huiyuan_zhuanmai
        {
            set { _huiyuan_zhuanmai = value; }
            get { return _huiyuan_zhuanmai; }
        }
        /// <summary>
        /// 变化金额
        /// </summary>
        public decimal? queren_money
        {
            set { _queren_money = value; }
            get { return _queren_money; }
        }
        /// <summary>
        /// 执行时间
        /// </summary>
        public DateTime? queren_date
        {
            set { _queren_date = value; }
            get { return _queren_date; }
        }
        /// <summary>
        /// 执行类型
        /// </summary>
        public string action_type
        {
            set { _action_type = value; }
            get { return _action_type; }
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
        /// 
        /// </summary>
        public int? queren_type
        {
            set { _queren_type = value; }
            get { return _queren_type; }
        }
        /// <summary>
        /// 执行后金额
        /// </summary>
        public decimal? money_before
        {
            set { _money_before = value; }
            get { return _money_before; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string queren_man
        {
            set { _queren_man = value; }
            get { return _queren_man; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? data
        {
            set { _data = value; }
            get { return _data; }
        }
        #endregion Model


        #region  Method

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public tbl_queren(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,huiyuan_id,huiyuan_bianhao,huiyuan_zhuanmai,queren_money,queren_date,action_type,memo,queren_type,money_before,queren_man,data ");
            strSql.Append(" FROM [tbl_queren] ");
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
                if (ds.Tables[0].Rows[0]["huiyuan_bianhao"] != null)
                {
                    this.huiyuan_bianhao = ds.Tables[0].Rows[0]["huiyuan_bianhao"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_zhuanmai"] != null)
                {
                    this.huiyuan_zhuanmai = ds.Tables[0].Rows[0]["huiyuan_zhuanmai"].ToString();
                }
                if (ds.Tables[0].Rows[0]["queren_money"] != null && ds.Tables[0].Rows[0]["queren_money"].ToString() != "")
                {
                    this.queren_money = decimal.Parse(ds.Tables[0].Rows[0]["queren_money"].ToString());
                }
                if (ds.Tables[0].Rows[0]["queren_date"] != null && ds.Tables[0].Rows[0]["queren_date"].ToString() != "")
                {
                    this.queren_date = DateTime.Parse(ds.Tables[0].Rows[0]["queren_date"].ToString());
                }
                if (ds.Tables[0].Rows[0]["action_type"] != null)
                {
                    this.action_type = ds.Tables[0].Rows[0]["action_type"].ToString();
                }
                if (ds.Tables[0].Rows[0]["memo"] != null)
                {
                    this.memo = ds.Tables[0].Rows[0]["memo"].ToString();
                }
                if (ds.Tables[0].Rows[0]["queren_type"] != null && ds.Tables[0].Rows[0]["queren_type"].ToString() != "")
                {
                    this.queren_type = int.Parse(ds.Tables[0].Rows[0]["queren_type"].ToString());
                }
                if (ds.Tables[0].Rows[0]["money_before"] != null && ds.Tables[0].Rows[0]["money_before"].ToString() != "")
                {
                    this.money_before = decimal.Parse(ds.Tables[0].Rows[0]["money_before"].ToString());
                }
                if (ds.Tables[0].Rows[0]["queren_man"] != null)
                {
                    this.queren_man = ds.Tables[0].Rows[0]["queren_man"].ToString();
                }
                if (ds.Tables[0].Rows[0]["data"] != null && ds.Tables[0].Rows[0]["data"].ToString() != "")
                {
                    this.data = DateTime.Parse(ds.Tables[0].Rows[0]["data"].ToString());
                }
            }
        }
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from [tbl_queren]");
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
            strSql.Append("insert into [tbl_queren] (");
            strSql.Append("huiyuan_id,huiyuan_bianhao,huiyuan_zhuanmai,queren_money,queren_date,action_type,memo,queren_type,money_before,queren_man,data)");
            strSql.Append(" values (");
            strSql.Append("@huiyuan_id,@huiyuan_bianhao,@huiyuan_zhuanmai,@queren_money,@queren_date,@action_type,@memo,@queren_type,@money_before,@queren_man,@data)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@huiyuan_id", SqlDbType.VarChar,50),
					new SqlParameter("@huiyuan_bianhao", SqlDbType.VarChar,500),
					new SqlParameter("@huiyuan_zhuanmai", SqlDbType.VarChar,50),
					new SqlParameter("@queren_money", SqlDbType.Money,8),
					new SqlParameter("@queren_date", SqlDbType.DateTime),
					new SqlParameter("@action_type", SqlDbType.VarChar,500),
					new SqlParameter("@memo", SqlDbType.VarChar,5000),
					new SqlParameter("@queren_type", SqlDbType.Int,4),
					new SqlParameter("@money_before", SqlDbType.Money,8),
					new SqlParameter("@queren_man", SqlDbType.VarChar,50),
					new SqlParameter("@data", SqlDbType.DateTime)};
            parameters[0].Value = huiyuan_id;
            parameters[1].Value = huiyuan_bianhao;
            parameters[2].Value = huiyuan_zhuanmai;
            parameters[3].Value = queren_money;
            parameters[4].Value = queren_date;
            parameters[5].Value = action_type;
            parameters[6].Value = memo;
            parameters[7].Value = queren_type;
            parameters[8].Value = money_before;
            parameters[9].Value = queren_man;
            parameters[10].Value = data;

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
            strSql.Append("update [tbl_queren] set ");
            strSql.Append("huiyuan_id=@huiyuan_id,");
            strSql.Append("huiyuan_bianhao=@huiyuan_bianhao,");
            strSql.Append("huiyuan_zhuanmai=@huiyuan_zhuanmai,");
            strSql.Append("queren_money=@queren_money,");
            strSql.Append("queren_date=@queren_date,");
            strSql.Append("action_type=@action_type,");
            strSql.Append("memo=@memo,");
            strSql.Append("queren_type=@queren_type,");
            strSql.Append("money_before=@money_before,");
            strSql.Append("queren_man=@queren_man,");
            strSql.Append("data=@data");
            strSql.Append(" where id=@id ");
            SqlParameter[] parameters = {
					new SqlParameter("@huiyuan_id", SqlDbType.VarChar,50),
					new SqlParameter("@huiyuan_bianhao", SqlDbType.VarChar,500),
					new SqlParameter("@huiyuan_zhuanmai", SqlDbType.VarChar,50),
					new SqlParameter("@queren_money", SqlDbType.Money,8),
					new SqlParameter("@queren_date", SqlDbType.DateTime),
					new SqlParameter("@action_type", SqlDbType.VarChar,500),
					new SqlParameter("@memo", SqlDbType.VarChar,5000),
					new SqlParameter("@queren_type", SqlDbType.Int,4),
					new SqlParameter("@money_before", SqlDbType.Money,8),
					new SqlParameter("@queren_man", SqlDbType.VarChar,50),
					new SqlParameter("@data", SqlDbType.DateTime),
					new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = huiyuan_id;
            parameters[1].Value = huiyuan_bianhao;
            parameters[2].Value = huiyuan_zhuanmai;
            parameters[3].Value = queren_money;
            parameters[4].Value = queren_date;
            parameters[5].Value = action_type;
            parameters[6].Value = memo;
            parameters[7].Value = queren_type;
            parameters[8].Value = money_before;
            parameters[9].Value = queren_man;
            parameters[10].Value = data;
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
        /// 删除一条数据
        /// </summary>
        public bool Delete(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from [tbl_queren] ");
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
            strSql.Append("select id,huiyuan_id,huiyuan_bianhao,huiyuan_zhuanmai,queren_money,queren_date,action_type,memo,queren_type,money_before,queren_man,data ");
            strSql.Append(" FROM [tbl_queren] ");
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
                if (ds.Tables[0].Rows[0]["huiyuan_bianhao"] != null)
                {
                    this.huiyuan_bianhao = ds.Tables[0].Rows[0]["huiyuan_bianhao"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_zhuanmai"] != null)
                {
                    this.huiyuan_zhuanmai = ds.Tables[0].Rows[0]["huiyuan_zhuanmai"].ToString();
                }
                if (ds.Tables[0].Rows[0]["queren_money"] != null && ds.Tables[0].Rows[0]["queren_money"].ToString() != "")
                {
                    this.queren_money = decimal.Parse(ds.Tables[0].Rows[0]["queren_money"].ToString());
                }
                if (ds.Tables[0].Rows[0]["queren_date"] != null && ds.Tables[0].Rows[0]["queren_date"].ToString() != "")
                {
                    this.queren_date = DateTime.Parse(ds.Tables[0].Rows[0]["queren_date"].ToString());
                }
                if (ds.Tables[0].Rows[0]["action_type"] != null)
                {
                    this.action_type = ds.Tables[0].Rows[0]["action_type"].ToString();
                }
                if (ds.Tables[0].Rows[0]["memo"] != null)
                {
                    this.memo = ds.Tables[0].Rows[0]["memo"].ToString();
                }
                if (ds.Tables[0].Rows[0]["queren_type"] != null && ds.Tables[0].Rows[0]["queren_type"].ToString() != "")
                {
                    this.queren_type = int.Parse(ds.Tables[0].Rows[0]["queren_type"].ToString());
                }
                if (ds.Tables[0].Rows[0]["money_before"] != null && ds.Tables[0].Rows[0]["money_before"].ToString() != "")
                {
                    this.money_before = decimal.Parse(ds.Tables[0].Rows[0]["money_before"].ToString());
                }
                if (ds.Tables[0].Rows[0]["queren_man"] != null)
                {
                    this.queren_man = ds.Tables[0].Rows[0]["queren_man"].ToString();
                }
                if (ds.Tables[0].Rows[0]["data"] != null && ds.Tables[0].Rows[0]["data"].ToString() != "")
                {
                    this.data = DateTime.Parse(ds.Tables[0].Rows[0]["data"].ToString());
                }
            }
        }

        /// <summary>
        /// 获得查询分页数据
        /// </summary>
        public DataSet GetList(int pageSize, int pageIndex, string strWhere, string filedOrder, out int recordCount)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * FROM  view_queren   ");
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
            strSql.Append("select top 1 " + Title + " as sumcode from [tbl_queren]");
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
 
