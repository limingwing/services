using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
 
    /// <summary>
    /// 类tbl_tikuan。
    /// </summary>
    [Serializable]
    public partial class tbl_tikuan
    {
        public tbl_tikuan()
        { }
        #region Model
        private int _tikuan_id;
        private string _bankname;
        private string _bank_zhi;
        private string _accountno;
        private string _accountname;
        private DateTime? _tikuan_date;
        private decimal? _money;
        private string _memo;
        private string _huiyuan_id;
        private string _huiyuan_bianhao;
        private string _huiyuan_name;
        private int? _tikuan_status;
        private DateTime? _tikuan_qr_date;
        private decimal? _money_sx;
        private decimal? _money_sj;
        private int? _zz_type;
        /// <summary>
        /// 
        /// </summary>
        public int tikuan_id
        {
            set { _tikuan_id = value; }
            get { return _tikuan_id; }
        }
        /// <summary>
        /// 银行名称
        /// </summary>
        public string bankname
        {
            set { _bankname = value; }
            get { return _bankname; }
        }
        /// <summary>
        /// 银行支行
        /// </summary>
        public string bank_zhi
        {
            set { _bank_zhi = value; }
            get { return _bank_zhi; }
        }
        /// <summary>
        /// 银行账号
        /// </summary>
        public string accountno
        {
            set { _accountno = value; }
            get { return _accountno; }
        }
        /// <summary>
        /// 账号开户名
        /// </summary>
        public string accountname
        {
            set { _accountname = value; }
            get { return _accountname; }
        }
        /// <summary>
        /// 兑换时间
        /// </summary>
        public DateTime? tikuan_date
        {
            set { _tikuan_date = value; }
            get { return _tikuan_date; }
        }
        /// <summary>
        /// 提款金额
        /// </summary>
        public decimal? money
        {
            set { _money = value; }
            get { return _money; }
        }
        /// <summary>
        /// 说明
        /// </summary>
        public string memo
        {
            set { _memo = value; }
            get { return _memo; }
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
        /// 会员编号
        /// </summary>
        public string huiyuan_bianhao
        {
            set { _huiyuan_bianhao = value; }
            get { return _huiyuan_bianhao; }
        }
        /// <summary>
        /// 会员姓名
        /// </summary>
        public string huiyuan_name
        {
            set { _huiyuan_name = value; }
            get { return _huiyuan_name; }
        }
        /// <summary>
        /// 状态
        /// </summary>
        public int? tikuan_status
        {
            set { _tikuan_status = value; }
            get { return _tikuan_status; }
        }
        /// <summary>
        /// 提款确认时间
        /// </summary>
        public DateTime? tikuan_qr_date
        {
            set { _tikuan_qr_date = value; }
            get { return _tikuan_qr_date; }
        }
        /// <summary>
        /// 手续费
        /// </summary>
        public decimal? money_sx
        {
            set { _money_sx = value; }
            get { return _money_sx; }
        }
        /// <summary>
        /// 实际提款金额
        /// </summary>
        public decimal? money_sj
        {
            set { _money_sj = value; }
            get { return _money_sj; }
        }
        #endregion Model
        /// <summary>
        /// 状态
        /// </summary>
        public int? zz_type
        {
            set { _zz_type = value; }
            get { return _zz_type; }
        }

        #region  Method

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public tbl_tikuan(int tikuan_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select tikuan_id,bankname,bank_zhi,accountno,accountname,tikuan_date,money,memo,huiyuan_id,huiyuan_bianhao,huiyuan_name,tikuan_status,tikuan_qr_date,money_sx,money_sj ");
            strSql.Append(" FROM [tbl_tikuan] ");
            strSql.Append(" where tikuan_id=@tikuan_id ");
            SqlParameter[] parameters = {
					new SqlParameter("@tikuan_id", SqlDbType.Int,4)};
            parameters[0].Value = tikuan_id;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["tikuan_id"] != null && ds.Tables[0].Rows[0]["tikuan_id"].ToString() != "")
                {
                    this.tikuan_id = int.Parse(ds.Tables[0].Rows[0]["tikuan_id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["bankname"] != null)
                {
                    this.bankname = ds.Tables[0].Rows[0]["bankname"].ToString();
                }
                if (ds.Tables[0].Rows[0]["bank_zhi"] != null)
                {
                    this.bank_zhi = ds.Tables[0].Rows[0]["bank_zhi"].ToString();
                }
                if (ds.Tables[0].Rows[0]["accountno"] != null)
                {
                    this.accountno = ds.Tables[0].Rows[0]["accountno"].ToString();
                }
                if (ds.Tables[0].Rows[0]["accountname"] != null)
                {
                    this.accountname = ds.Tables[0].Rows[0]["accountname"].ToString();
                }
                if (ds.Tables[0].Rows[0]["tikuan_date"] != null && ds.Tables[0].Rows[0]["tikuan_date"].ToString() != "")
                {
                    this.tikuan_date = DateTime.Parse(ds.Tables[0].Rows[0]["tikuan_date"].ToString());
                }
                if (ds.Tables[0].Rows[0]["money"] != null && ds.Tables[0].Rows[0]["money"].ToString() != "")
                {
                    this.money = decimal.Parse(ds.Tables[0].Rows[0]["money"].ToString());
                }
                if (ds.Tables[0].Rows[0]["memo"] != null)
                {
                    this.memo = ds.Tables[0].Rows[0]["memo"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_id"] != null)
                {
                    this.huiyuan_id = ds.Tables[0].Rows[0]["huiyuan_id"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_bianhao"] != null)
                {
                    this.huiyuan_bianhao = ds.Tables[0].Rows[0]["huiyuan_bianhao"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_name"] != null)
                {
                    this.huiyuan_name = ds.Tables[0].Rows[0]["huiyuan_name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["tikuan_status"] != null && ds.Tables[0].Rows[0]["tikuan_status"].ToString() != "")
                {
                    this.tikuan_status = int.Parse(ds.Tables[0].Rows[0]["tikuan_status"].ToString());
                }
                if (ds.Tables[0].Rows[0]["tikuan_qr_date"] != null && ds.Tables[0].Rows[0]["tikuan_qr_date"].ToString() != "")
                {
                    this.tikuan_qr_date = DateTime.Parse(ds.Tables[0].Rows[0]["tikuan_qr_date"].ToString());
                }
                if (ds.Tables[0].Rows[0]["money_sx"] != null && ds.Tables[0].Rows[0]["money_sx"].ToString() != "")
                {
                    this.money_sx = decimal.Parse(ds.Tables[0].Rows[0]["money_sx"].ToString());
                }
                if (ds.Tables[0].Rows[0]["money_sj"] != null && ds.Tables[0].Rows[0]["money_sj"].ToString() != "")
                {
                    this.money_sj = decimal.Parse(ds.Tables[0].Rows[0]["money_sj"].ToString());
                }
            }
        }
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int tikuan_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from [tbl_tikuan]");
            strSql.Append(" where tikuan_id=@tikuan_id ");

            SqlParameter[] parameters = {
					new SqlParameter("@tikuan_id", SqlDbType.Int,4)};
            parameters[0].Value = tikuan_id;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into [tbl_tikuan] (");
            strSql.Append("bankname,bank_zhi,accountno,accountname,tikuan_date,money,memo,huiyuan_id,huiyuan_bianhao,huiyuan_name,tikuan_status,tikuan_qr_date,money_sx,money_sj,zz_type)");
            strSql.Append(" values (");
            strSql.Append("@bankname,@bank_zhi,@accountno,@accountname,@tikuan_date,@money,@memo,@huiyuan_id,@huiyuan_bianhao,@huiyuan_name,@tikuan_status,@tikuan_qr_date,@money_sx,@money_sj,@zz_type)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@bankname", SqlDbType.NVarChar,50),
					new SqlParameter("@bank_zhi", SqlDbType.NVarChar,50),
					new SqlParameter("@accountno", SqlDbType.NVarChar,50),
					new SqlParameter("@accountname", SqlDbType.NVarChar,50),
					new SqlParameter("@tikuan_date", SqlDbType.DateTime),
					new SqlParameter("@money", SqlDbType.Money,8),
					new SqlParameter("@memo", SqlDbType.NVarChar,50),
					new SqlParameter("@huiyuan_id", SqlDbType.Char,9),
					new SqlParameter("@huiyuan_bianhao", SqlDbType.NVarChar,50),
					new SqlParameter("@huiyuan_name", SqlDbType.NVarChar,50),
					new SqlParameter("@tikuan_status", SqlDbType.Int,4),
					new SqlParameter("@tikuan_qr_date", SqlDbType.DateTime),
					new SqlParameter("@money_sx", SqlDbType.Money,8),
					new SqlParameter("@money_sj", SqlDbType.Money,8) ,
                    new SqlParameter("@zz_type", SqlDbType.Int,4)};
            parameters[0].Value = bankname;
            parameters[1].Value = bank_zhi;
            parameters[2].Value = accountno;
            parameters[3].Value = accountname;
            parameters[4].Value = tikuan_date;
            parameters[5].Value = money;
            parameters[6].Value = memo;
            parameters[7].Value = huiyuan_id;
            parameters[8].Value = huiyuan_bianhao;
            parameters[9].Value = huiyuan_name;
            parameters[10].Value = tikuan_status;
            parameters[11].Value = tikuan_qr_date;
            parameters[12].Value = money_sx;
            parameters[13].Value = money_sj;
            parameters[14].Value = zz_type;

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
        /// 更新是否支付状态
        /// </summary>
        public bool UpdateStatus()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update [tbl_tikuan] set ");
            strSql.Append("tikuan_status=@tikuan_status");
            strSql.Append(" where tikuan_id=@tikuan_id ");
            SqlParameter[] parameters = {
					new SqlParameter("@tikuan_status", SqlDbType.Int,4),
					new SqlParameter("@tikuan_id", SqlDbType.Int,4)};
            parameters[0].Value = tikuan_status;
            parameters[1].Value = tikuan_id;

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
        /// 更新一条数据
        /// </summary>
        public bool Update()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update [tbl_tikuan] set ");
            strSql.Append("bankname=@bankname,");
            strSql.Append("bank_zhi=@bank_zhi,");
            strSql.Append("accountno=@accountno,");
            strSql.Append("accountname=@accountname,");
            strSql.Append("tikuan_date=@tikuan_date,");
            strSql.Append("money=@money,");
            strSql.Append("memo=@memo,");
            strSql.Append("huiyuan_id=@huiyuan_id,");
            strSql.Append("huiyuan_bianhao=@huiyuan_bianhao,");
            strSql.Append("huiyuan_name=@huiyuan_name,");
            strSql.Append("tikuan_status=@tikuan_status,");
            strSql.Append("tikuan_qr_date=@tikuan_qr_date,");
            strSql.Append("money_sx=@money_sx,");
            strSql.Append("money_sj=@money_sj");
            strSql.Append(" where tikuan_id=@tikuan_id ");
            SqlParameter[] parameters = {
					new SqlParameter("@bankname", SqlDbType.NVarChar,50),
					new SqlParameter("@bank_zhi", SqlDbType.NVarChar,50),
					new SqlParameter("@accountno", SqlDbType.NVarChar,50),
					new SqlParameter("@accountname", SqlDbType.NVarChar,50),
					new SqlParameter("@tikuan_date", SqlDbType.DateTime),
					new SqlParameter("@money", SqlDbType.Money,8),
					new SqlParameter("@memo", SqlDbType.NVarChar,50),
					new SqlParameter("@huiyuan_id", SqlDbType.Char,9),
					new SqlParameter("@huiyuan_bianhao", SqlDbType.NVarChar,50),
					new SqlParameter("@huiyuan_name", SqlDbType.NVarChar,50),
					new SqlParameter("@tikuan_status", SqlDbType.Int,4),
					new SqlParameter("@tikuan_qr_date", SqlDbType.DateTime),
					new SqlParameter("@money_sx", SqlDbType.Money,8),
					new SqlParameter("@money_sj", SqlDbType.Money,8),
					new SqlParameter("@tikuan_id", SqlDbType.Int,4)};
            parameters[0].Value = bankname;
            parameters[1].Value = bank_zhi;
            parameters[2].Value = accountno;
            parameters[3].Value = accountname;
            parameters[4].Value = tikuan_date;
            parameters[5].Value = money;
            parameters[6].Value = memo;
            parameters[7].Value = huiyuan_id;
            parameters[8].Value = huiyuan_bianhao;
            parameters[9].Value = huiyuan_name;
            parameters[10].Value = tikuan_status;
            parameters[11].Value = tikuan_qr_date;
            parameters[12].Value = money_sx;
            parameters[13].Value = money_sj;
            parameters[14].Value = tikuan_id;

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
        public bool Delete(int tikuan_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from [tbl_tikuan] ");
            strSql.Append(" where tikuan_id=@tikuan_id ");
            SqlParameter[] parameters = {
					new SqlParameter("@tikuan_id", SqlDbType.Int,4)};
            parameters[0].Value = tikuan_id;

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
        public void GetModel(int tikuan_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select tikuan_id,bankname,bank_zhi,accountno,accountname,tikuan_date,money,memo,huiyuan_id,huiyuan_bianhao,huiyuan_name,tikuan_status,tikuan_qr_date,money_sx,money_sj ");
            strSql.Append(" FROM [tbl_tikuan] ");
            strSql.Append(" where tikuan_id=@tikuan_id ");
            SqlParameter[] parameters = {
					new SqlParameter("@tikuan_id", SqlDbType.Int,4)};
            parameters[0].Value = tikuan_id;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["tikuan_id"] != null && ds.Tables[0].Rows[0]["tikuan_id"].ToString() != "")
                {
                    this.tikuan_id = int.Parse(ds.Tables[0].Rows[0]["tikuan_id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["bankname"] != null)
                {
                    this.bankname = ds.Tables[0].Rows[0]["bankname"].ToString();
                }
                if (ds.Tables[0].Rows[0]["bank_zhi"] != null)
                {
                    this.bank_zhi = ds.Tables[0].Rows[0]["bank_zhi"].ToString();
                }
                if (ds.Tables[0].Rows[0]["accountno"] != null)
                {
                    this.accountno = ds.Tables[0].Rows[0]["accountno"].ToString();
                }
                if (ds.Tables[0].Rows[0]["accountname"] != null)
                {
                    this.accountname = ds.Tables[0].Rows[0]["accountname"].ToString();
                }
                if (ds.Tables[0].Rows[0]["tikuan_date"] != null && ds.Tables[0].Rows[0]["tikuan_date"].ToString() != "")
                {
                    this.tikuan_date = DateTime.Parse(ds.Tables[0].Rows[0]["tikuan_date"].ToString());
                }
                if (ds.Tables[0].Rows[0]["money"] != null && ds.Tables[0].Rows[0]["money"].ToString() != "")
                {
                    this.money = decimal.Parse(ds.Tables[0].Rows[0]["money"].ToString());
                }
                if (ds.Tables[0].Rows[0]["memo"] != null)
                {
                    this.memo = ds.Tables[0].Rows[0]["memo"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_id"] != null)
                {
                    this.huiyuan_id = ds.Tables[0].Rows[0]["huiyuan_id"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_bianhao"] != null)
                {
                    this.huiyuan_bianhao = ds.Tables[0].Rows[0]["huiyuan_bianhao"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_name"] != null)
                {
                    this.huiyuan_name = ds.Tables[0].Rows[0]["huiyuan_name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["tikuan_status"] != null && ds.Tables[0].Rows[0]["tikuan_status"].ToString() != "")
                {
                    this.tikuan_status = int.Parse(ds.Tables[0].Rows[0]["tikuan_status"].ToString());
                }
                if (ds.Tables[0].Rows[0]["tikuan_qr_date"] != null && ds.Tables[0].Rows[0]["tikuan_qr_date"].ToString() != "")
                {
                    this.tikuan_qr_date = DateTime.Parse(ds.Tables[0].Rows[0]["tikuan_qr_date"].ToString());
                }
                if (ds.Tables[0].Rows[0]["money_sx"] != null && ds.Tables[0].Rows[0]["money_sx"].ToString() != "")
                {
                    this.money_sx = decimal.Parse(ds.Tables[0].Rows[0]["money_sx"].ToString());
                }
                if (ds.Tables[0].Rows[0]["money_sj"] != null && ds.Tables[0].Rows[0]["money_sj"].ToString() != "")
                {
                    this.money_sj = decimal.Parse(ds.Tables[0].Rows[0]["money_sj"].ToString());
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
            strSql.Append(" FROM [tbl_tikuan] ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 根据条件和字段汇总
        /// </summary>
        public string GetTitleSum(string strWhere, string Title)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top 1 " + Title + " as sumcode from [tbl_tikuan]");
            strSql.Append(" where " + strWhere);
            string title = Convert.ToString(DbHelperSQL.GetSingle(strSql.ToString()));
            if (string.IsNullOrEmpty(title))
            {
                return "0";
            }
            return title;
        }
        /// <summary>
        /// 获得查询分页数据
        /// </summary>
        public DataSet GetList(int pageSize, int pageIndex, string strWhere, string filedOrder, out int recordCount)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * FROM  tbl_tikuan");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            recordCount = Convert.ToInt32(DbHelperSQL.GetSingle(PagingHelper.CreateCountingSql(strSql.ToString())));
            return DbHelperSQL.Query(PagingHelper.CreatePagingSql(recordCount, pageSize, pageIndex, strSql.ToString(), filedOrder));
        }

        public DataSet GetList_t(int pageSize, int pageIndex, string strWhere, string filedOrder, out int recordCount)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(@"select b.*,a.huiyuan_name as ysp_name from dbo.tbl_tikuan as b
inner join tbl_huiyuan as a on a.huiyuan_id =b.huiyuan_id");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            recordCount = Convert.ToInt32(DbHelperSQL.GetSingle(PagingHelper.CreateCountingSql(strSql.ToString())));
            return DbHelperSQL.Query(PagingHelper.CreatePagingSql(recordCount, pageSize, pageIndex, strSql.ToString(), filedOrder));
        }


        public string GetTitleSum_t(string strWhere, string Title)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top 1 " + Title + " as sumcode from dbo.tbl_tikuan as b inner join tbl_huiyuan as a on a.huiyuan_id =b.huiyuan_id");
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
 

