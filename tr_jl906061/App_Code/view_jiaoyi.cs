using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
 
 
    /// <summary>
    /// 类view_jiaoyi。
    /// </summary>
    [Serializable]
    public partial class view_jiaoyi
    {
        public view_jiaoyi()
        { }
        #region Model
        private int _id;
        private string _buy_no;
        private string _sell_id;
        private string _sell_no;
        private DateTime? _pipei_date;
        private decimal? _pipei_money;
        private int? _flag;
        private string _buy_id;
        private string _buy_bianhao;
        private string _sell_bianhao;
        private string _buy_name;
        private string _sell_name;
        private string _pinju_src;
        private string _huiyuan_yinhang_zh;
        private string _huiyuan_yinhang_name;
        private string _huiyuan_yinhang;
        private string _bank_zhi;
        private string _weixin;
        private string _zhifubao;
        private string _tjr_bianhao;
        private string _tjr_name;
        private string _tjr_mob;
        private string _sell_mob;
        private string _buy_mob;
        private string _buy_tjr_bianhao;
        private string _buy_tjr_name;
        private string _buy_tjr_mob;
        private DateTime? _qr_fukuan_date;
        private DateTime? _qr_shoukuan_date;
        private int? _pingjia;
        private int? _flag_1;
        private int? _dx_mark;
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
        public string buy_no
        {
            set { _buy_no = value; }
            get { return _buy_no; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sell_id
        {
            set { _sell_id = value; }
            get { return _sell_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sell_no
        {
            set { _sell_no = value; }
            get { return _sell_no; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? pipei_date
        {
            set { _pipei_date = value; }
            get { return _pipei_date; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? pipei_money
        {
            set { _pipei_money = value; }
            get { return _pipei_money; }
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
        public string buy_id
        {
            set { _buy_id = value; }
            get { return _buy_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string buy_bianhao
        {
            set { _buy_bianhao = value; }
            get { return _buy_bianhao; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sell_bianhao
        {
            set { _sell_bianhao = value; }
            get { return _sell_bianhao; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string buy_name
        {
            set { _buy_name = value; }
            get { return _buy_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sell_name
        {
            set { _sell_name = value; }
            get { return _sell_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string pinju_src
        {
            set { _pinju_src = value; }
            get { return _pinju_src; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string huiyuan_yinhang_zh
        {
            set { _huiyuan_yinhang_zh = value; }
            get { return _huiyuan_yinhang_zh; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string huiyuan_yinhang_name
        {
            set { _huiyuan_yinhang_name = value; }
            get { return _huiyuan_yinhang_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string huiyuan_yinhang
        {
            set { _huiyuan_yinhang = value; }
            get { return _huiyuan_yinhang; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string bank_zhi
        {
            set { _bank_zhi = value; }
            get { return _bank_zhi; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string weixin
        {
            set { _weixin = value; }
            get { return _weixin; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string zhifubao
        {
            set { _zhifubao = value; }
            get { return _zhifubao; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string tjr_bianhao
        {
            set { _tjr_bianhao = value; }
            get { return _tjr_bianhao; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string tjr_name
        {
            set { _tjr_name = value; }
            get { return _tjr_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string tjr_mob
        {
            set { _tjr_mob = value; }
            get { return _tjr_mob; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sell_mob
        {
            set { _sell_mob = value; }
            get { return _sell_mob; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string buy_mob
        {
            set { _buy_mob = value; }
            get { return _buy_mob; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string buy_tjr_bianhao
        {
            set { _buy_tjr_bianhao = value; }
            get { return _buy_tjr_bianhao; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string buy_tjr_name
        {
            set { _buy_tjr_name = value; }
            get { return _buy_tjr_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string buy_tjr_mob
        {
            set { _buy_tjr_mob = value; }
            get { return _buy_tjr_mob; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? qr_fukuan_date
        {
            set { _qr_fukuan_date = value; }
            get { return _qr_fukuan_date; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? qr_shoukuan_date
        {
            set { _qr_shoukuan_date = value; }
            get { return _qr_shoukuan_date; }
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
        public int? flag_1
        {
            set { _flag_1 = value; }
            get { return _flag_1; }
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
        public view_jiaoyi(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,buy_no,sell_id,sell_no,pipei_date,pipei_money,flag,buy_id,buy_bianhao,sell_bianhao,buy_name,sell_name,pinju_src,huiyuan_yinhang_zh,huiyuan_yinhang_name,huiyuan_yinhang,bank_zhi,weixin,zhifubao,tjr_bianhao,tjr_name,tjr_mob,sell_mob,buy_mob,buy_tjr_bianhao,buy_tjr_name,buy_tjr_mob,qr_fukuan_date,qr_shoukuan_date,pingjia,flag_1,dx_mark ");
            strSql.Append(" FROM [view_jiaoyi] ");
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
                if (ds.Tables[0].Rows[0]["buy_id"] != null)
                {
                    this.buy_id = ds.Tables[0].Rows[0]["buy_id"].ToString();
                }
                if (ds.Tables[0].Rows[0]["buy_bianhao"] != null)
                {
                    this.buy_bianhao = ds.Tables[0].Rows[0]["buy_bianhao"].ToString();
                }
                if (ds.Tables[0].Rows[0]["sell_bianhao"] != null)
                {
                    this.sell_bianhao = ds.Tables[0].Rows[0]["sell_bianhao"].ToString();
                }
                if (ds.Tables[0].Rows[0]["buy_name"] != null)
                {
                    this.buy_name = ds.Tables[0].Rows[0]["buy_name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["sell_name"] != null)
                {
                    this.sell_name = ds.Tables[0].Rows[0]["sell_name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["pinju_src"] != null)
                {
                    this.pinju_src = ds.Tables[0].Rows[0]["pinju_src"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_yinhang_zh"] != null)
                {
                    this.huiyuan_yinhang_zh = ds.Tables[0].Rows[0]["huiyuan_yinhang_zh"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_yinhang_name"] != null)
                {
                    this.huiyuan_yinhang_name = ds.Tables[0].Rows[0]["huiyuan_yinhang_name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_yinhang"] != null)
                {
                    this.huiyuan_yinhang = ds.Tables[0].Rows[0]["huiyuan_yinhang"].ToString();
                }
                if (ds.Tables[0].Rows[0]["bank_zhi"] != null)
                {
                    this.bank_zhi = ds.Tables[0].Rows[0]["bank_zhi"].ToString();
                }
                if (ds.Tables[0].Rows[0]["weixin"] != null)
                {
                    this.weixin = ds.Tables[0].Rows[0]["weixin"].ToString();
                }
                if (ds.Tables[0].Rows[0]["zhifubao"] != null)
                {
                    this.zhifubao = ds.Tables[0].Rows[0]["zhifubao"].ToString();
                }
                if (ds.Tables[0].Rows[0]["tjr_bianhao"] != null)
                {
                    this.tjr_bianhao = ds.Tables[0].Rows[0]["tjr_bianhao"].ToString();
                }
                if (ds.Tables[0].Rows[0]["tjr_name"] != null)
                {
                    this.tjr_name = ds.Tables[0].Rows[0]["tjr_name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["tjr_mob"] != null)
                {
                    this.tjr_mob = ds.Tables[0].Rows[0]["tjr_mob"].ToString();
                }
                if (ds.Tables[0].Rows[0]["sell_mob"] != null)
                {
                    this.sell_mob = ds.Tables[0].Rows[0]["sell_mob"].ToString();
                }
                if (ds.Tables[0].Rows[0]["buy_mob"] != null)
                {
                    this.buy_mob = ds.Tables[0].Rows[0]["buy_mob"].ToString();
                }
                if (ds.Tables[0].Rows[0]["buy_tjr_bianhao"] != null)
                {
                    this.buy_tjr_bianhao = ds.Tables[0].Rows[0]["buy_tjr_bianhao"].ToString();
                }
                if (ds.Tables[0].Rows[0]["buy_tjr_name"] != null)
                {
                    this.buy_tjr_name = ds.Tables[0].Rows[0]["buy_tjr_name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["buy_tjr_mob"] != null)
                {
                    this.buy_tjr_mob = ds.Tables[0].Rows[0]["buy_tjr_mob"].ToString();
                }
                if (ds.Tables[0].Rows[0]["qr_fukuan_date"] != null && ds.Tables[0].Rows[0]["qr_fukuan_date"].ToString() != "")
                {
                    this.qr_fukuan_date = DateTime.Parse(ds.Tables[0].Rows[0]["qr_fukuan_date"].ToString());
                }
                if (ds.Tables[0].Rows[0]["qr_shoukuan_date"] != null && ds.Tables[0].Rows[0]["qr_shoukuan_date"].ToString() != "")
                {
                    this.qr_shoukuan_date = DateTime.Parse(ds.Tables[0].Rows[0]["qr_shoukuan_date"].ToString());
                }
                if (ds.Tables[0].Rows[0]["pingjia"] != null && ds.Tables[0].Rows[0]["pingjia"].ToString() != "")
                {
                    this.pingjia = int.Parse(ds.Tables[0].Rows[0]["pingjia"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_1"] != null && ds.Tables[0].Rows[0]["flag_1"].ToString() != "")
                {
                    this.flag_1 = int.Parse(ds.Tables[0].Rows[0]["flag_1"].ToString());
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
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from [view_jiaoyi]");
            strSql.Append(" where id=@id ");

            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = id;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into [view_jiaoyi] (");
            strSql.Append("id,buy_no,sell_id,sell_no,pipei_date,pipei_money,flag,buy_id,buy_bianhao,sell_bianhao,buy_name,sell_name,pinju_src,huiyuan_yinhang_zh,huiyuan_yinhang_name,huiyuan_yinhang,bank_zhi,weixin,zhifubao,tjr_bianhao,tjr_name,tjr_mob,sell_mob,buy_mob,buy_tjr_bianhao,buy_tjr_name,buy_tjr_mob,qr_fukuan_date,qr_shoukuan_date,pingjia,flag_1,dx_mark)");
            strSql.Append(" values (");
            strSql.Append("@id,@buy_no,@sell_id,@sell_no,@pipei_date,@pipei_money,@flag,@buy_id,@buy_bianhao,@sell_bianhao,@buy_name,@sell_name,@pinju_src,@huiyuan_yinhang_zh,@huiyuan_yinhang_name,@huiyuan_yinhang,@bank_zhi,@weixin,@zhifubao,@tjr_bianhao,@tjr_name,@tjr_mob,@sell_mob,@buy_mob,@buy_tjr_bianhao,@buy_tjr_name,@buy_tjr_mob,@qr_fukuan_date,@qr_shoukuan_date,@pingjia,@flag_1,@dx_mark)");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4),
					new SqlParameter("@buy_no", SqlDbType.VarChar,200),
					new SqlParameter("@sell_id", SqlDbType.Char,9),
					new SqlParameter("@sell_no", SqlDbType.VarChar,200),
					new SqlParameter("@pipei_date", SqlDbType.DateTime),
					new SqlParameter("@pipei_money", SqlDbType.Money,8),
					new SqlParameter("@flag", SqlDbType.Int,4),
					new SqlParameter("@buy_id", SqlDbType.Char,9),
					new SqlParameter("@buy_bianhao", SqlDbType.NVarChar,50),
					new SqlParameter("@sell_bianhao", SqlDbType.NVarChar,50),
					new SqlParameter("@buy_name", SqlDbType.NVarChar,50),
					new SqlParameter("@sell_name", SqlDbType.NVarChar,50),
					new SqlParameter("@pinju_src", SqlDbType.VarChar,100),
					new SqlParameter("@huiyuan_yinhang_zh", SqlDbType.NVarChar,50),
					new SqlParameter("@huiyuan_yinhang_name", SqlDbType.NVarChar,50),
					new SqlParameter("@huiyuan_yinhang", SqlDbType.NVarChar,50),
					new SqlParameter("@bank_zhi", SqlDbType.NVarChar,50),
					new SqlParameter("@weixin", SqlDbType.VarChar,110),
					new SqlParameter("@zhifubao", SqlDbType.VarChar,150),
					new SqlParameter("@tjr_bianhao", SqlDbType.NVarChar,50),
					new SqlParameter("@tjr_name", SqlDbType.NVarChar,50),
					new SqlParameter("@tjr_mob", SqlDbType.NVarChar,50),
					new SqlParameter("@sell_mob", SqlDbType.NVarChar,50),
					new SqlParameter("@buy_mob", SqlDbType.NVarChar,50),
					new SqlParameter("@buy_tjr_bianhao", SqlDbType.NVarChar,50),
					new SqlParameter("@buy_tjr_name", SqlDbType.NVarChar,50),
					new SqlParameter("@buy_tjr_mob", SqlDbType.NVarChar,50),
					new SqlParameter("@qr_fukuan_date", SqlDbType.DateTime),
					new SqlParameter("@qr_shoukuan_date", SqlDbType.DateTime),
					new SqlParameter("@pingjia", SqlDbType.Int,4),
					new SqlParameter("@flag_1", SqlDbType.Int,4),
					new SqlParameter("@dx_mark", SqlDbType.Int,4)};
            parameters[0].Value = id;
            parameters[1].Value = buy_no;
            parameters[2].Value = sell_id;
            parameters[3].Value = sell_no;
            parameters[4].Value = pipei_date;
            parameters[5].Value = pipei_money;
            parameters[6].Value = flag;
            parameters[7].Value = buy_id;
            parameters[8].Value = buy_bianhao;
            parameters[9].Value = sell_bianhao;
            parameters[10].Value = buy_name;
            parameters[11].Value = sell_name;
            parameters[12].Value = pinju_src;
            parameters[13].Value = huiyuan_yinhang_zh;
            parameters[14].Value = huiyuan_yinhang_name;
            parameters[15].Value = huiyuan_yinhang;
            parameters[16].Value = bank_zhi;
            parameters[17].Value = weixin;
            parameters[18].Value = zhifubao;
            parameters[19].Value = tjr_bianhao;
            parameters[20].Value = tjr_name;
            parameters[21].Value = tjr_mob;
            parameters[22].Value = sell_mob;
            parameters[23].Value = buy_mob;
            parameters[24].Value = buy_tjr_bianhao;
            parameters[25].Value = buy_tjr_name;
            parameters[26].Value = buy_tjr_mob;
            parameters[27].Value = qr_fukuan_date;
            parameters[28].Value = qr_shoukuan_date;
            parameters[29].Value = pingjia;
            parameters[30].Value = flag_1;
            parameters[31].Value = dx_mark;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update [view_jiaoyi] set ");
            strSql.Append("id=@id,");
            strSql.Append("buy_no=@buy_no,");
            strSql.Append("sell_id=@sell_id,");
            strSql.Append("sell_no=@sell_no,");
            strSql.Append("pipei_date=@pipei_date,");
            strSql.Append("pipei_money=@pipei_money,");
            strSql.Append("flag=@flag,");
            strSql.Append("buy_id=@buy_id,");
            strSql.Append("buy_bianhao=@buy_bianhao,");
            strSql.Append("sell_bianhao=@sell_bianhao,");
            strSql.Append("buy_name=@buy_name,");
            strSql.Append("sell_name=@sell_name,");
            strSql.Append("pinju_src=@pinju_src,");
            strSql.Append("huiyuan_yinhang_zh=@huiyuan_yinhang_zh,");
            strSql.Append("huiyuan_yinhang_name=@huiyuan_yinhang_name,");
            strSql.Append("huiyuan_yinhang=@huiyuan_yinhang,");
            strSql.Append("bank_zhi=@bank_zhi,");
            strSql.Append("weixin=@weixin,");
            strSql.Append("zhifubao=@zhifubao,");
            strSql.Append("tjr_bianhao=@tjr_bianhao,");
            strSql.Append("tjr_name=@tjr_name,");
            strSql.Append("tjr_mob=@tjr_mob,");
            strSql.Append("sell_mob=@sell_mob,");
            strSql.Append("buy_mob=@buy_mob,");
            strSql.Append("buy_tjr_bianhao=@buy_tjr_bianhao,");
            strSql.Append("buy_tjr_name=@buy_tjr_name,");
            strSql.Append("buy_tjr_mob=@buy_tjr_mob,");
            strSql.Append("qr_fukuan_date=@qr_fukuan_date,");
            strSql.Append("qr_shoukuan_date=@qr_shoukuan_date,");
            strSql.Append("pingjia=@pingjia,");
            strSql.Append("flag_1=@flag_1,");
            strSql.Append("dx_mark=@dx_mark");
            strSql.Append(" where id=@id ");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4),
					new SqlParameter("@buy_no", SqlDbType.VarChar,200),
					new SqlParameter("@sell_id", SqlDbType.Char,9),
					new SqlParameter("@sell_no", SqlDbType.VarChar,200),
					new SqlParameter("@pipei_date", SqlDbType.DateTime),
					new SqlParameter("@pipei_money", SqlDbType.Money,8),
					new SqlParameter("@flag", SqlDbType.Int,4),
					new SqlParameter("@buy_id", SqlDbType.Char,9),
					new SqlParameter("@buy_bianhao", SqlDbType.NVarChar,50),
					new SqlParameter("@sell_bianhao", SqlDbType.NVarChar,50),
					new SqlParameter("@buy_name", SqlDbType.NVarChar,50),
					new SqlParameter("@sell_name", SqlDbType.NVarChar,50),
					new SqlParameter("@pinju_src", SqlDbType.VarChar,100),
					new SqlParameter("@huiyuan_yinhang_zh", SqlDbType.NVarChar,50),
					new SqlParameter("@huiyuan_yinhang_name", SqlDbType.NVarChar,50),
					new SqlParameter("@huiyuan_yinhang", SqlDbType.NVarChar,50),
					new SqlParameter("@bank_zhi", SqlDbType.NVarChar,50),
					new SqlParameter("@weixin", SqlDbType.VarChar,110),
					new SqlParameter("@zhifubao", SqlDbType.VarChar,150),
					new SqlParameter("@tjr_bianhao", SqlDbType.NVarChar,50),
					new SqlParameter("@tjr_name", SqlDbType.NVarChar,50),
					new SqlParameter("@tjr_mob", SqlDbType.NVarChar,50),
					new SqlParameter("@sell_mob", SqlDbType.NVarChar,50),
					new SqlParameter("@buy_mob", SqlDbType.NVarChar,50),
					new SqlParameter("@buy_tjr_bianhao", SqlDbType.NVarChar,50),
					new SqlParameter("@buy_tjr_name", SqlDbType.NVarChar,50),
					new SqlParameter("@buy_tjr_mob", SqlDbType.NVarChar,50),
					new SqlParameter("@qr_fukuan_date", SqlDbType.DateTime),
					new SqlParameter("@qr_shoukuan_date", SqlDbType.DateTime),
					new SqlParameter("@pingjia", SqlDbType.Int,4),
					new SqlParameter("@flag_1", SqlDbType.Int,4),
					new SqlParameter("@dx_mark", SqlDbType.Int,4)};
            parameters[0].Value = id;
            parameters[1].Value = buy_no;
            parameters[2].Value = sell_id;
            parameters[3].Value = sell_no;
            parameters[4].Value = pipei_date;
            parameters[5].Value = pipei_money;
            parameters[6].Value = flag;
            parameters[7].Value = buy_id;
            parameters[8].Value = buy_bianhao;
            parameters[9].Value = sell_bianhao;
            parameters[10].Value = buy_name;
            parameters[11].Value = sell_name;
            parameters[12].Value = pinju_src;
            parameters[13].Value = huiyuan_yinhang_zh;
            parameters[14].Value = huiyuan_yinhang_name;
            parameters[15].Value = huiyuan_yinhang;
            parameters[16].Value = bank_zhi;
            parameters[17].Value = weixin;
            parameters[18].Value = zhifubao;
            parameters[19].Value = tjr_bianhao;
            parameters[20].Value = tjr_name;
            parameters[21].Value = tjr_mob;
            parameters[22].Value = sell_mob;
            parameters[23].Value = buy_mob;
            parameters[24].Value = buy_tjr_bianhao;
            parameters[25].Value = buy_tjr_name;
            parameters[26].Value = buy_tjr_mob;
            parameters[27].Value = qr_fukuan_date;
            parameters[28].Value = qr_shoukuan_date;
            parameters[29].Value = pingjia;
            parameters[30].Value = flag_1;
            parameters[31].Value = dx_mark;

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
            strSql.Append("delete from [view_jiaoyi] ");
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
            strSql.Append("select id,buy_no,sell_id,sell_no,pipei_date,pipei_money,flag,buy_id,buy_bianhao,sell_bianhao,buy_name,sell_name,pinju_src,huiyuan_yinhang_zh,huiyuan_yinhang_name,huiyuan_yinhang,bank_zhi,weixin,zhifubao,tjr_bianhao,tjr_name,tjr_mob,sell_mob,buy_mob,buy_tjr_bianhao,buy_tjr_name,buy_tjr_mob,qr_fukuan_date,qr_shoukuan_date,pingjia,flag_1,dx_mark ");
            strSql.Append(" FROM [view_jiaoyi] ");
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
                if (ds.Tables[0].Rows[0]["buy_id"] != null)
                {
                    this.buy_id = ds.Tables[0].Rows[0]["buy_id"].ToString();
                }
                if (ds.Tables[0].Rows[0]["buy_bianhao"] != null)
                {
                    this.buy_bianhao = ds.Tables[0].Rows[0]["buy_bianhao"].ToString();
                }
                if (ds.Tables[0].Rows[0]["sell_bianhao"] != null)
                {
                    this.sell_bianhao = ds.Tables[0].Rows[0]["sell_bianhao"].ToString();
                }
                if (ds.Tables[0].Rows[0]["buy_name"] != null)
                {
                    this.buy_name = ds.Tables[0].Rows[0]["buy_name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["sell_name"] != null)
                {
                    this.sell_name = ds.Tables[0].Rows[0]["sell_name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["pinju_src"] != null)
                {
                    this.pinju_src = ds.Tables[0].Rows[0]["pinju_src"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_yinhang_zh"] != null)
                {
                    this.huiyuan_yinhang_zh = ds.Tables[0].Rows[0]["huiyuan_yinhang_zh"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_yinhang_name"] != null)
                {
                    this.huiyuan_yinhang_name = ds.Tables[0].Rows[0]["huiyuan_yinhang_name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_yinhang"] != null)
                {
                    this.huiyuan_yinhang = ds.Tables[0].Rows[0]["huiyuan_yinhang"].ToString();
                }
                if (ds.Tables[0].Rows[0]["bank_zhi"] != null)
                {
                    this.bank_zhi = ds.Tables[0].Rows[0]["bank_zhi"].ToString();
                }
                if (ds.Tables[0].Rows[0]["weixin"] != null)
                {
                    this.weixin = ds.Tables[0].Rows[0]["weixin"].ToString();
                }
                if (ds.Tables[0].Rows[0]["zhifubao"] != null)
                {
                    this.zhifubao = ds.Tables[0].Rows[0]["zhifubao"].ToString();
                }
                if (ds.Tables[0].Rows[0]["tjr_bianhao"] != null)
                {
                    this.tjr_bianhao = ds.Tables[0].Rows[0]["tjr_bianhao"].ToString();
                }
                if (ds.Tables[0].Rows[0]["tjr_name"] != null)
                {
                    this.tjr_name = ds.Tables[0].Rows[0]["tjr_name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["tjr_mob"] != null)
                {
                    this.tjr_mob = ds.Tables[0].Rows[0]["tjr_mob"].ToString();
                }
                if (ds.Tables[0].Rows[0]["sell_mob"] != null)
                {
                    this.sell_mob = ds.Tables[0].Rows[0]["sell_mob"].ToString();
                }
                if (ds.Tables[0].Rows[0]["buy_mob"] != null)
                {
                    this.buy_mob = ds.Tables[0].Rows[0]["buy_mob"].ToString();
                }
                if (ds.Tables[0].Rows[0]["buy_tjr_bianhao"] != null)
                {
                    this.buy_tjr_bianhao = ds.Tables[0].Rows[0]["buy_tjr_bianhao"].ToString();
                }
                if (ds.Tables[0].Rows[0]["buy_tjr_name"] != null)
                {
                    this.buy_tjr_name = ds.Tables[0].Rows[0]["buy_tjr_name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["buy_tjr_mob"] != null)
                {
                    this.buy_tjr_mob = ds.Tables[0].Rows[0]["buy_tjr_mob"].ToString();
                }
                if (ds.Tables[0].Rows[0]["qr_fukuan_date"] != null && ds.Tables[0].Rows[0]["qr_fukuan_date"].ToString() != "")
                {
                    this.qr_fukuan_date = DateTime.Parse(ds.Tables[0].Rows[0]["qr_fukuan_date"].ToString());
                }
                if (ds.Tables[0].Rows[0]["qr_shoukuan_date"] != null && ds.Tables[0].Rows[0]["qr_shoukuan_date"].ToString() != "")
                {
                    this.qr_shoukuan_date = DateTime.Parse(ds.Tables[0].Rows[0]["qr_shoukuan_date"].ToString());
                }
                if (ds.Tables[0].Rows[0]["pingjia"] != null && ds.Tables[0].Rows[0]["pingjia"].ToString() != "")
                {
                    this.pingjia = int.Parse(ds.Tables[0].Rows[0]["pingjia"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_1"] != null && ds.Tables[0].Rows[0]["flag_1"].ToString() != "")
                {
                    this.flag_1 = int.Parse(ds.Tables[0].Rows[0]["flag_1"].ToString());
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
            strSql.Append(" FROM [view_jiaoyi] ");
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
            strSql.Append("select * FROM  view_jiaoyi");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            recordCount = Convert.ToInt32(DbHelperSQL.GetSingle(PagingHelper.CreateCountingSql(strSql.ToString())));
            return DbHelperSQL.Query(PagingHelper.CreatePagingSql(recordCount, pageSize, pageIndex, strSql.ToString(), filedOrder));
        }


 

        #endregion  Method
    }
 

