using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
 
    /// <summary>
    /// 类tbl_jiaoyi_list。
    /// </summary>
    [Serializable]
    public partial class tbl_jiaoyi_list
    {
        public tbl_jiaoyi_list()
        { }
        #region Model
        private int _id;
        private string _buy_id;
        private string _buy_no;
        private string _sell_id;
        private string _sell_no;
        private DateTime? _pipei_date;
        private decimal? _pipei_money;
        private int? _flag = 0;
        private string _pinju_src;
        private DateTime? _qr_fukuan_date;
        private DateTime? _qr_shoukuan_date;
        private int? _flag_1 = 0;
        private int? _pingjia = 0;
        private int? _dx_mark = 1;
        /// <summary>
        /// 自增量id
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 购买会员id
        /// </summary>
        public string buy_id
        {
            set { _buy_id = value; }
            get { return _buy_id; }
        }
        /// <summary>
        /// 购买订单号
        /// </summary>
        public string buy_no
        {
            set { _buy_no = value; }
            get { return _buy_no; }
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
        /// 卖出订单编号
        /// </summary>
        public string sell_no
        {
            set { _sell_no = value; }
            get { return _sell_no; }
        }
        /// <summary>
        /// 匹配时间
        /// </summary>
        public DateTime? pipei_date
        {
            set { _pipei_date = value; }
            get { return _pipei_date; }
        }
        /// <summary>
        /// 匹配金额
        /// </summary>
        public decimal? pipei_money
        {
            set { _pipei_money = value; }
            get { return _pipei_money; }
        }
        /// <summary>
        /// 状态
        /// </summary>
        public int? flag
        {
            set { _flag = value; }
            get { return _flag; }
        }
        /// <summary>
        /// 图片凭据
        /// </summary>
        public string pinju_src
        {
            set { _pinju_src = value; }
            get { return _pinju_src; }
        }
        /// <summary>
        /// 确认付款时间
        /// </summary>
        public DateTime? qr_fukuan_date
        {
            set { _qr_fukuan_date = value; }
            get { return _qr_fukuan_date; }
        }
        /// <summary>
        /// 确认收款时间
        /// </summary>
        public DateTime? qr_shoukuan_date
        {
            set { _qr_shoukuan_date = value; }
            get { return _qr_shoukuan_date; }
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
        public int? pingjia
        {
            set { _pingjia = value; }
            get { return _pingjia; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? dx_mark
        {
            set { _dx_mark = value; }
            get { return _dx_mark; }
        }
        #endregion Model


        #region  Method

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public tbl_jiaoyi_list(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,buy_id,buy_no,sell_id,sell_no,pipei_date,pipei_money,flag,pinju_src,qr_fukuan_date,qr_shoukuan_date,flag_1,pingjia,dx_mark ");
            strSql.Append(" FROM [tbl_jiaoyi_list] ");
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
                if (ds.Tables[0].Rows[0]["buy_id"] != null)
                {
                    this.buy_id = ds.Tables[0].Rows[0]["buy_id"].ToString();
                }
                if (ds.Tables[0].Rows[0]["buy_no"] != null)
                {
                    this.buy_no = ds.Tables[0].Rows[0]["buy_no"].ToString();
                }
                if (ds.Tables[0].Rows[0]["sell_id"] != null)
                {
                    this.sell_id = ds.Tables[0].Rows[0]["sell_id"].ToString();
                }
                if (ds.Tables[0].Rows[0]["sell_no"] != null)
                {
                    this.sell_no = ds.Tables[0].Rows[0]["sell_no"].ToString();
                }
                if (ds.Tables[0].Rows[0]["pipei_date"] != null && ds.Tables[0].Rows[0]["pipei_date"].ToString() != "")
                {
                    this.pipei_date = DateTime.Parse(ds.Tables[0].Rows[0]["pipei_date"].ToString());
                }
                if (ds.Tables[0].Rows[0]["pipei_money"] != null && ds.Tables[0].Rows[0]["pipei_money"].ToString() != "")
                {
                    this.pipei_money = decimal.Parse(ds.Tables[0].Rows[0]["pipei_money"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag"] != null && ds.Tables[0].Rows[0]["flag"].ToString() != "")
                {
                    this.flag = int.Parse(ds.Tables[0].Rows[0]["flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["pinju_src"] != null)
                {
                    this.pinju_src = ds.Tables[0].Rows[0]["pinju_src"].ToString();
                }
                if (ds.Tables[0].Rows[0]["qr_fukuan_date"] != null && ds.Tables[0].Rows[0]["qr_fukuan_date"].ToString() != "")
                {
                    this.qr_fukuan_date = DateTime.Parse(ds.Tables[0].Rows[0]["qr_fukuan_date"].ToString());
                }
                if (ds.Tables[0].Rows[0]["qr_shoukuan_date"] != null && ds.Tables[0].Rows[0]["qr_shoukuan_date"].ToString() != "")
                {
                    this.qr_shoukuan_date = DateTime.Parse(ds.Tables[0].Rows[0]["qr_shoukuan_date"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_1"] != null && ds.Tables[0].Rows[0]["flag_1"].ToString() != "")
                {
                    this.flag_1 = int.Parse(ds.Tables[0].Rows[0]["flag_1"].ToString());
                }
                if (ds.Tables[0].Rows[0]["pingjia"] != null && ds.Tables[0].Rows[0]["pingjia"].ToString() != "")
                {
                    this.pingjia = int.Parse(ds.Tables[0].Rows[0]["pingjia"].ToString());
                }
                if (ds.Tables[0].Rows[0]["dx_mark"] != null && ds.Tables[0].Rows[0]["dx_mark"].ToString() != "")
                {
                    this.dx_mark = int.Parse(ds.Tables[0].Rows[0]["dx_mark"].ToString());
                }
            }
        }
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from [tbl_jiaoyi_list]");
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
            strSql.Append("insert into [tbl_jiaoyi_list] (");
            strSql.Append("buy_id,buy_no,sell_id,sell_no,pipei_date,pipei_money,flag,pinju_src,qr_fukuan_date,qr_shoukuan_date,flag_1,pingjia,dx_mark)");
            strSql.Append(" values (");
            strSql.Append("@buy_id,@buy_no,@sell_id,@sell_no,@pipei_date,@pipei_money,@flag,@pinju_src,@qr_fukuan_date,@qr_shoukuan_date,@flag_1,@pingjia,@dx_mark)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@buy_id", SqlDbType.Char,9),
					new SqlParameter("@buy_no", SqlDbType.VarChar,200),
					new SqlParameter("@sell_id", SqlDbType.Char,9),
					new SqlParameter("@sell_no", SqlDbType.VarChar,200),
					new SqlParameter("@pipei_date", SqlDbType.DateTime),
					new SqlParameter("@pipei_money", SqlDbType.Money,8),
					new SqlParameter("@flag", SqlDbType.Int,4),
					new SqlParameter("@pinju_src", SqlDbType.VarChar,100),
					new SqlParameter("@qr_fukuan_date", SqlDbType.DateTime),
					new SqlParameter("@qr_shoukuan_date", SqlDbType.DateTime),
					new SqlParameter("@flag_1", SqlDbType.Int,4),
					new SqlParameter("@pingjia", SqlDbType.Int,4),
					new SqlParameter("@dx_mark", SqlDbType.Int,4)};
            parameters[0].Value = buy_id;
            parameters[1].Value = buy_no;
            parameters[2].Value = sell_id;
            parameters[3].Value = sell_no;
            parameters[4].Value = pipei_date;
            parameters[5].Value = pipei_money;
            parameters[6].Value = flag;
            parameters[7].Value = pinju_src;
            parameters[8].Value = qr_fukuan_date;
            parameters[9].Value = qr_shoukuan_date;
            parameters[10].Value = flag_1;
            parameters[11].Value = pingjia;
            parameters[12].Value = dx_mark;

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
            strSql.Append("update [tbl_jiaoyi_list] set ");
            strSql.Append("buy_id=@buy_id,");
            strSql.Append("buy_no=@buy_no,");
            strSql.Append("sell_id=@sell_id,");
            strSql.Append("sell_no=@sell_no,");
            strSql.Append("pipei_date=@pipei_date,");
            strSql.Append("pipei_money=@pipei_money,");
            strSql.Append("flag=@flag,");
            strSql.Append("pinju_src=@pinju_src,");
            strSql.Append("qr_fukuan_date=@qr_fukuan_date,");
            strSql.Append("qr_shoukuan_date=@qr_shoukuan_date,");
            strSql.Append("flag_1=@flag_1,");
            strSql.Append("pingjia=@pingjia,");
            strSql.Append("dx_mark=@dx_mark");
            strSql.Append(" where id=@id ");
            SqlParameter[] parameters = {
					new SqlParameter("@buy_id", SqlDbType.Char,9),
					new SqlParameter("@buy_no", SqlDbType.VarChar,200),
					new SqlParameter("@sell_id", SqlDbType.Char,9),
					new SqlParameter("@sell_no", SqlDbType.VarChar,200),
					new SqlParameter("@pipei_date", SqlDbType.DateTime),
					new SqlParameter("@pipei_money", SqlDbType.Money,8),
					new SqlParameter("@flag", SqlDbType.Int,4),
					new SqlParameter("@pinju_src", SqlDbType.VarChar,100),
					new SqlParameter("@qr_fukuan_date", SqlDbType.DateTime),
					new SqlParameter("@qr_shoukuan_date", SqlDbType.DateTime),
					new SqlParameter("@flag_1", SqlDbType.Int,4),
					new SqlParameter("@pingjia", SqlDbType.Int,4),
					new SqlParameter("@dx_mark", SqlDbType.Int,4),
					new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = buy_id;
            parameters[1].Value = buy_no;
            parameters[2].Value = sell_id;
            parameters[3].Value = sell_no;
            parameters[4].Value = pipei_date;
            parameters[5].Value = pipei_money;
            parameters[6].Value = flag;
            parameters[7].Value = pinju_src;
            parameters[8].Value = qr_fukuan_date;
            parameters[9].Value = qr_shoukuan_date;
            parameters[10].Value = flag_1;
            parameters[11].Value = pingjia;
            parameters[12].Value = dx_mark;
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
            strSql.Append("delete from [tbl_jiaoyi_list] ");
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
            strSql.Append("select id,buy_id,buy_no,sell_id,sell_no,pipei_date,pipei_money,flag,pinju_src,qr_fukuan_date,qr_shoukuan_date,flag_1,pingjia,dx_mark ");
            strSql.Append(" FROM [tbl_jiaoyi_list] ");
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
                if (ds.Tables[0].Rows[0]["buy_id"] != null)
                {
                    this.buy_id = ds.Tables[0].Rows[0]["buy_id"].ToString();
                }
                if (ds.Tables[0].Rows[0]["buy_no"] != null)
                {
                    this.buy_no = ds.Tables[0].Rows[0]["buy_no"].ToString();
                }
                if (ds.Tables[0].Rows[0]["sell_id"] != null)
                {
                    this.sell_id = ds.Tables[0].Rows[0]["sell_id"].ToString();
                }
                if (ds.Tables[0].Rows[0]["sell_no"] != null)
                {
                    this.sell_no = ds.Tables[0].Rows[0]["sell_no"].ToString();
                }
                if (ds.Tables[0].Rows[0]["pipei_date"] != null && ds.Tables[0].Rows[0]["pipei_date"].ToString() != "")
                {
                    this.pipei_date = DateTime.Parse(ds.Tables[0].Rows[0]["pipei_date"].ToString());
                }
                if (ds.Tables[0].Rows[0]["pipei_money"] != null && ds.Tables[0].Rows[0]["pipei_money"].ToString() != "")
                {
                    this.pipei_money = decimal.Parse(ds.Tables[0].Rows[0]["pipei_money"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag"] != null && ds.Tables[0].Rows[0]["flag"].ToString() != "")
                {
                    this.flag = int.Parse(ds.Tables[0].Rows[0]["flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["pinju_src"] != null)
                {
                    this.pinju_src = ds.Tables[0].Rows[0]["pinju_src"].ToString();
                }
                if (ds.Tables[0].Rows[0]["qr_fukuan_date"] != null && ds.Tables[0].Rows[0]["qr_fukuan_date"].ToString() != "")
                {
                    this.qr_fukuan_date = DateTime.Parse(ds.Tables[0].Rows[0]["qr_fukuan_date"].ToString());
                }
                if (ds.Tables[0].Rows[0]["qr_shoukuan_date"] != null && ds.Tables[0].Rows[0]["qr_shoukuan_date"].ToString() != "")
                {
                    this.qr_shoukuan_date = DateTime.Parse(ds.Tables[0].Rows[0]["qr_shoukuan_date"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_1"] != null && ds.Tables[0].Rows[0]["flag_1"].ToString() != "")
                {
                    this.flag_1 = int.Parse(ds.Tables[0].Rows[0]["flag_1"].ToString());
                }
                if (ds.Tables[0].Rows[0]["pingjia"] != null && ds.Tables[0].Rows[0]["pingjia"].ToString() != "")
                {
                    this.pingjia = int.Parse(ds.Tables[0].Rows[0]["pingjia"].ToString());
                }
                if (ds.Tables[0].Rows[0]["dx_mark"] != null && ds.Tables[0].Rows[0]["dx_mark"].ToString() != "")
                {
                    this.dx_mark = int.Parse(ds.Tables[0].Rows[0]["dx_mark"].ToString());
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
            strSql.Append(" FROM [tbl_jiaoyi_list] ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 返回是否显示
        /// </summary>
        public bool show_is(string huiyuan_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select aa=flag   from [tbl_jiaoyi_list]");
            strSql.Append(" where buy_no= '" + huiyuan_id + "'");
            int count_hui = Convert.ToInt32(DbHelperSQL.GetSingle(strSql.ToString()));

            if (count_hui == 3 )
            {
                return true;
            }
            else
            {

                return false;
            }
        }
        /// <summary>
        /// 返回是否显示
        /// </summary>
        public bool show_is1(string huiyuan_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select aa=flag   from [tbl_jiaoyi_list]");
            strSql.Append(" where buy_no= '" + huiyuan_id + "'");
            int count_hui = Convert.ToInt32(DbHelperSQL.GetSingle(strSql.ToString()));

            if (count_hui == 4)
            {
                return true;
            }
            else
            {

                return false;
            }
        }
        #endregion  Method
    }
 

