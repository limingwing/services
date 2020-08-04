using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
 
    /// <summary>
    /// 类tbl_sell。
    /// </summary>
    [Serializable]
    public partial class tbl_sell
    {
        public tbl_sell()
        { }
        #region Model
        private int _id;
        private string _dd_no;
        private DateTime? _cj_date;
        private decimal? _sq_money;
        private decimal? _sy_money;
        private int? _cishu = 0;
        private string _sell_id;
        private int? _buy_pid;
        private DateTime? _pipei_qr_date;
        private int? _flag = 0;
        private int? _flag_1 = 0;
        private int? _flag_2;
        private int? _zhifu_type = 0;
        private int? _pipei_renshu = 0;
        /// <summary>
        /// 
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 订单号
        /// </summary>
        public string dd_no
        {
            set { _dd_no = value; }
            get { return _dd_no; }
        }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? cj_date
        {
            set { _cj_date = value; }
            get { return _cj_date; }
        }
        /// <summary>
        /// 申请金额
        /// </summary>
        public decimal? sq_money
        {
            set { _sq_money = value; }
            get { return _sq_money; }
        }
        /// <summary>
        /// 剩余金额
        /// </summary>
        public decimal? sy_money
        {
            set { _sy_money = value; }
            get { return _sy_money; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? cishu
        {
            set { _cishu = value; }
            get { return _cishu; }
        }
        /// <summary>
        /// 卖出会员id
        /// </summary>
        public string sell_id
        {
            set { _sell_id = value; }
            get { return _sell_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? buy_pid
        {
            set { _buy_pid = value; }
            get { return _buy_pid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? pipei_qr_date
        {
            set { _pipei_qr_date = value; }
            get { return _pipei_qr_date; }
        }
        /// <summary>
        /// 完成标记
        /// </summary>
        public int? flag
        {
            set { _flag = value; }
            get { return _flag; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? flag_1
        {
            set { _flag_1 = value; }
            get { return _flag_1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? flag_2
        {
            set { _flag_2 = value; }
            get { return _flag_2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? zhifu_type
        {
            set { _zhifu_type = value; }
            get { return _zhifu_type; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? pipei_renshu
        {
            set { _pipei_renshu = value; }
            get { return _pipei_renshu; }
        }
        #endregion Model


        #region  Method

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public tbl_sell(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,dd_no,cj_date,sq_money,sy_money,cishu,sell_id,buy_pid,pipei_qr_date,flag,flag_1,flag_2,zhifu_type,pipei_renshu ");
            strSql.Append(" FROM [tbl_sell] ");
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
                if (ds.Tables[0].Rows[0]["dd_no"] != null)
                {
                    this.dd_no = ds.Tables[0].Rows[0]["dd_no"].ToString();
                }
                if (ds.Tables[0].Rows[0]["cj_date"] != null && ds.Tables[0].Rows[0]["cj_date"].ToString() != "")
                {
                    this.cj_date = DateTime.Parse(ds.Tables[0].Rows[0]["cj_date"].ToString());
                }
                if (ds.Tables[0].Rows[0]["sq_money"] != null && ds.Tables[0].Rows[0]["sq_money"].ToString() != "")
                {
                    this.sq_money = decimal.Parse(ds.Tables[0].Rows[0]["sq_money"].ToString());
                }
                if (ds.Tables[0].Rows[0]["sy_money"] != null && ds.Tables[0].Rows[0]["sy_money"].ToString() != "")
                {
                    this.sy_money = decimal.Parse(ds.Tables[0].Rows[0]["sy_money"].ToString());
                }
                if (ds.Tables[0].Rows[0]["cishu"] != null && ds.Tables[0].Rows[0]["cishu"].ToString() != "")
                {
                    this.cishu = int.Parse(ds.Tables[0].Rows[0]["cishu"].ToString());
                }
                if (ds.Tables[0].Rows[0]["sell_id"] != null)
                {
                    this.sell_id = ds.Tables[0].Rows[0]["sell_id"].ToString();
                }
                if (ds.Tables[0].Rows[0]["buy_pid"] != null && ds.Tables[0].Rows[0]["buy_pid"].ToString() != "")
                {
                    this.buy_pid = int.Parse(ds.Tables[0].Rows[0]["buy_pid"].ToString());
                }
                if (ds.Tables[0].Rows[0]["pipei_qr_date"] != null && ds.Tables[0].Rows[0]["pipei_qr_date"].ToString() != "")
                {
                    this.pipei_qr_date = DateTime.Parse(ds.Tables[0].Rows[0]["pipei_qr_date"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag"] != null && ds.Tables[0].Rows[0]["flag"].ToString() != "")
                {
                    this.flag = int.Parse(ds.Tables[0].Rows[0]["flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_1"] != null && ds.Tables[0].Rows[0]["flag_1"].ToString() != "")
                {
                    this.flag_1 = int.Parse(ds.Tables[0].Rows[0]["flag_1"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_2"] != null && ds.Tables[0].Rows[0]["flag_2"].ToString() != "")
                {
                    this.flag_2 = int.Parse(ds.Tables[0].Rows[0]["flag_2"].ToString());
                }
                if (ds.Tables[0].Rows[0]["zhifu_type"] != null && ds.Tables[0].Rows[0]["zhifu_type"].ToString() != "")
                {
                    this.zhifu_type = int.Parse(ds.Tables[0].Rows[0]["zhifu_type"].ToString());
                }
                if (ds.Tables[0].Rows[0]["pipei_renshu"] != null && ds.Tables[0].Rows[0]["pipei_renshu"].ToString() != "")
                {
                    this.pipei_renshu = int.Parse(ds.Tables[0].Rows[0]["pipei_renshu"].ToString());
                }
            }
        }
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from [tbl_sell]");
            strSql.Append(" where id=@id ");

            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = id;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists_jsbz()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from [tbl_sell]");
            strSql.Append(" where sell_id=@sell_id and flag<>3 ");

            SqlParameter[] parameters = {
					new SqlParameter("@sell_id", SqlDbType.Char,9)};
            parameters[0].Value = sell_id;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 是否存在该记录（支付方式1,3）
        /// </summary>
        public bool Exists_jsbz1()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from [tbl_sell]");
            strSql.Append(" where sell_id=@sell_id and flag<>3 and (zhifu_type=1 or zhifu_type=3)");

            SqlParameter[] parameters = {
					new SqlParameter("@sell_id", SqlDbType.Char,9)};
            parameters[0].Value = sell_id;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 是否存在该记录（支付方式2）
        /// </summary>
        public bool Exists_jsbz2()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from [tbl_sell]");
            strSql.Append(" where sell_id=@sell_id and flag<>3 and zhifu_type=2");

            SqlParameter[] parameters = {
					new SqlParameter("@sell_id", SqlDbType.Char,9)};
            parameters[0].Value = sell_id;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists_jsbz_dd_no()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from [tbl_sell]");
            strSql.Append(" where dd_no=@dd_no and (flag=0 or flag=1)");

            SqlParameter[] parameters = {
					new SqlParameter("@dd_no", SqlDbType.VarChar,200)};
            parameters[0].Value = dd_no;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into [tbl_sell] (");
            strSql.Append("dd_no,cj_date,sq_money,sy_money,cishu,sell_id,buy_pid,pipei_qr_date,flag,flag_1,flag_2,zhifu_type,pipei_renshu)");
            strSql.Append(" values (");
            strSql.Append("@dd_no,@cj_date,@sq_money,@sy_money,@cishu,@sell_id,@buy_pid,@pipei_qr_date,@flag,@flag_1,@flag_2,@zhifu_type,@pipei_renshu)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@dd_no", SqlDbType.VarChar,200),
					new SqlParameter("@cj_date", SqlDbType.DateTime),
					new SqlParameter("@sq_money", SqlDbType.Money,8),
					new SqlParameter("@sy_money", SqlDbType.Money,8),
					new SqlParameter("@cishu", SqlDbType.Int,4),
					new SqlParameter("@sell_id", SqlDbType.Char,9),
					new SqlParameter("@buy_pid", SqlDbType.Int,4),
					new SqlParameter("@pipei_qr_date", SqlDbType.DateTime),
					new SqlParameter("@flag", SqlDbType.Int,4),
					new SqlParameter("@flag_1", SqlDbType.Int,4),
					new SqlParameter("@flag_2", SqlDbType.Int,4),
					new SqlParameter("@zhifu_type", SqlDbType.Int,4),
					new SqlParameter("@pipei_renshu", SqlDbType.Int,4)};
            parameters[0].Value = dd_no;
            parameters[1].Value = cj_date;
            parameters[2].Value = sq_money;
            parameters[3].Value = sy_money;
            parameters[4].Value = cishu;
            parameters[5].Value = sell_id;
            parameters[6].Value = buy_pid;
            parameters[7].Value = pipei_qr_date;
            parameters[8].Value = flag;
            parameters[9].Value = flag_1;
            parameters[10].Value = flag_2;
            parameters[11].Value = zhifu_type;
            parameters[12].Value = pipei_renshu;

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
            strSql.Append("update [tbl_sell] set ");
            strSql.Append("dd_no=@dd_no,");
            strSql.Append("cj_date=@cj_date,");
            strSql.Append("sq_money=@sq_money,");
            strSql.Append("sy_money=@sy_money,");
            strSql.Append("cishu=@cishu,");
            strSql.Append("sell_id=@sell_id,");
            strSql.Append("buy_pid=@buy_pid,");
            strSql.Append("pipei_qr_date=@pipei_qr_date,");
            strSql.Append("flag=@flag,");
            strSql.Append("flag_1=@flag_1,");
            strSql.Append("flag_2=@flag_2,");
            strSql.Append("zhifu_type=@zhifu_type,");
            strSql.Append("pipei_renshu=@pipei_renshu");
            strSql.Append(" where id=@id ");
            SqlParameter[] parameters = {
					new SqlParameter("@dd_no", SqlDbType.VarChar,200),
					new SqlParameter("@cj_date", SqlDbType.DateTime),
					new SqlParameter("@sq_money", SqlDbType.Money,8),
					new SqlParameter("@sy_money", SqlDbType.Money,8),
					new SqlParameter("@cishu", SqlDbType.Int,4),
					new SqlParameter("@sell_id", SqlDbType.Char,9),
					new SqlParameter("@buy_pid", SqlDbType.Int,4),
					new SqlParameter("@pipei_qr_date", SqlDbType.DateTime),
					new SqlParameter("@flag", SqlDbType.Int,4),
					new SqlParameter("@flag_1", SqlDbType.Int,4),
					new SqlParameter("@flag_2", SqlDbType.Int,4),
					new SqlParameter("@zhifu_type", SqlDbType.Int,4),
					new SqlParameter("@pipei_renshu", SqlDbType.Int,4),
					new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = dd_no;
            parameters[1].Value = cj_date;
            parameters[2].Value = sq_money;
            parameters[3].Value = sy_money;
            parameters[4].Value = cishu;
            parameters[5].Value = sell_id;
            parameters[6].Value = buy_pid;
            parameters[7].Value = pipei_qr_date;
            parameters[8].Value = flag;
            parameters[9].Value = flag_1;
            parameters[10].Value = flag_2;
            parameters[11].Value = zhifu_type;
            parameters[12].Value = pipei_renshu;
            parameters[13].Value = id;

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
            strSql.Append("delete from [tbl_sell] ");
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
            strSql.Append("select id,dd_no,cj_date,sq_money,sy_money,cishu,sell_id,buy_pid,pipei_qr_date,flag,flag_1,flag_2,zhifu_type,pipei_renshu ");
            strSql.Append(" FROM [tbl_sell] ");
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
                if (ds.Tables[0].Rows[0]["dd_no"] != null)
                {
                    this.dd_no = ds.Tables[0].Rows[0]["dd_no"].ToString();
                }
                if (ds.Tables[0].Rows[0]["cj_date"] != null && ds.Tables[0].Rows[0]["cj_date"].ToString() != "")
                {
                    this.cj_date = DateTime.Parse(ds.Tables[0].Rows[0]["cj_date"].ToString());
                }
                if (ds.Tables[0].Rows[0]["sq_money"] != null && ds.Tables[0].Rows[0]["sq_money"].ToString() != "")
                {
                    this.sq_money = decimal.Parse(ds.Tables[0].Rows[0]["sq_money"].ToString());
                }
                if (ds.Tables[0].Rows[0]["sy_money"] != null && ds.Tables[0].Rows[0]["sy_money"].ToString() != "")
                {
                    this.sy_money = decimal.Parse(ds.Tables[0].Rows[0]["sy_money"].ToString());
                }
                if (ds.Tables[0].Rows[0]["cishu"] != null && ds.Tables[0].Rows[0]["cishu"].ToString() != "")
                {
                    this.cishu = int.Parse(ds.Tables[0].Rows[0]["cishu"].ToString());
                }
                if (ds.Tables[0].Rows[0]["sell_id"] != null)
                {
                    this.sell_id = ds.Tables[0].Rows[0]["sell_id"].ToString();
                }
                if (ds.Tables[0].Rows[0]["buy_pid"] != null && ds.Tables[0].Rows[0]["buy_pid"].ToString() != "")
                {
                    this.buy_pid = int.Parse(ds.Tables[0].Rows[0]["buy_pid"].ToString());
                }
                if (ds.Tables[0].Rows[0]["pipei_qr_date"] != null && ds.Tables[0].Rows[0]["pipei_qr_date"].ToString() != "")
                {
                    this.pipei_qr_date = DateTime.Parse(ds.Tables[0].Rows[0]["pipei_qr_date"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag"] != null && ds.Tables[0].Rows[0]["flag"].ToString() != "")
                {
                    this.flag = int.Parse(ds.Tables[0].Rows[0]["flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_1"] != null && ds.Tables[0].Rows[0]["flag_1"].ToString() != "")
                {
                    this.flag_1 = int.Parse(ds.Tables[0].Rows[0]["flag_1"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_2"] != null && ds.Tables[0].Rows[0]["flag_2"].ToString() != "")
                {
                    this.flag_2 = int.Parse(ds.Tables[0].Rows[0]["flag_2"].ToString());
                }
                if (ds.Tables[0].Rows[0]["zhifu_type"] != null && ds.Tables[0].Rows[0]["zhifu_type"].ToString() != "")
                {
                    this.zhifu_type = int.Parse(ds.Tables[0].Rows[0]["zhifu_type"].ToString());
                }
                if (ds.Tables[0].Rows[0]["pipei_renshu"] != null && ds.Tables[0].Rows[0]["pipei_renshu"].ToString() != "")
                {
                    this.pipei_renshu = int.Parse(ds.Tables[0].Rows[0]["pipei_renshu"].ToString());
                }
            }
        }
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public void GetModel_dd_no(string id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,dd_no,cj_date,sq_money,sy_money,cishu,sell_id,buy_pid,pipei_qr_date,flag,flag_1,flag_2,zhifu_type,pipei_renshu ");
            strSql.Append(" FROM [tbl_sell] ");
            strSql.Append(" where dd_no=@id ");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.VarChar,200)};
            parameters[0].Value = id;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["id"] != null && ds.Tables[0].Rows[0]["id"].ToString() != "")
                {
                    this.id = int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["dd_no"] != null)
                {
                    this.dd_no = ds.Tables[0].Rows[0]["dd_no"].ToString();
                }
                if (ds.Tables[0].Rows[0]["cj_date"] != null && ds.Tables[0].Rows[0]["cj_date"].ToString() != "")
                {
                    this.cj_date = DateTime.Parse(ds.Tables[0].Rows[0]["cj_date"].ToString());
                }
                if (ds.Tables[0].Rows[0]["sq_money"] != null && ds.Tables[0].Rows[0]["sq_money"].ToString() != "")
                {
                    this.sq_money = decimal.Parse(ds.Tables[0].Rows[0]["sq_money"].ToString());
                }
                if (ds.Tables[0].Rows[0]["sy_money"] != null && ds.Tables[0].Rows[0]["sy_money"].ToString() != "")
                {
                    this.sy_money = decimal.Parse(ds.Tables[0].Rows[0]["sy_money"].ToString());
                }
                if (ds.Tables[0].Rows[0]["cishu"] != null && ds.Tables[0].Rows[0]["cishu"].ToString() != "")
                {
                    this.cishu = int.Parse(ds.Tables[0].Rows[0]["cishu"].ToString());
                }
                if (ds.Tables[0].Rows[0]["sell_id"] != null)
                {
                    this.sell_id = ds.Tables[0].Rows[0]["sell_id"].ToString();
                }
                if (ds.Tables[0].Rows[0]["buy_pid"] != null && ds.Tables[0].Rows[0]["buy_pid"].ToString() != "")
                {
                    this.buy_pid = int.Parse(ds.Tables[0].Rows[0]["buy_pid"].ToString());
                }
                if (ds.Tables[0].Rows[0]["pipei_qr_date"] != null && ds.Tables[0].Rows[0]["pipei_qr_date"].ToString() != "")
                {
                    this.pipei_qr_date = DateTime.Parse(ds.Tables[0].Rows[0]["pipei_qr_date"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag"] != null && ds.Tables[0].Rows[0]["flag"].ToString() != "")
                {
                    this.flag = int.Parse(ds.Tables[0].Rows[0]["flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_1"] != null && ds.Tables[0].Rows[0]["flag_1"].ToString() != "")
                {
                    this.flag_1 = int.Parse(ds.Tables[0].Rows[0]["flag_1"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_2"] != null && ds.Tables[0].Rows[0]["flag_2"].ToString() != "")
                {
                    this.flag_2 = int.Parse(ds.Tables[0].Rows[0]["flag_2"].ToString());
                }
                if (ds.Tables[0].Rows[0]["zhifu_type"] != null && ds.Tables[0].Rows[0]["zhifu_type"].ToString() != "")
                {
                    this.zhifu_type = int.Parse(ds.Tables[0].Rows[0]["zhifu_type"].ToString());
                }
                if (ds.Tables[0].Rows[0]["pipei_renshu"] != null && ds.Tables[0].Rows[0]["pipei_renshu"].ToString() != "")
                {
                    this.pipei_renshu = int.Parse(ds.Tables[0].Rows[0]["pipei_renshu"].ToString());
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
            strSql.Append(" FROM [tbl_sell] ");
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
            strSql.Append("select * FROM  view_sell");
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
            strSql.Append("select top 1 " + Title + " as sumcode from [tbl_sell]");
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
 

