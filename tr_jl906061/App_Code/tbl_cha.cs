using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
 
 
    /// <summary>
    /// 类tbl_cha。
    /// </summary>
    [Serializable]
    public partial class tbl_cha
    {
        public tbl_cha()
        { }
        #region Model
        private int _id;
        private decimal? _cha_001 = 0M;
        private decimal? _cha_002 = 0M;
        private decimal? _cha_003 = 0M;
        private decimal? _cha_004 = 0M;
        private decimal? _cha_005 = 0M;
        private decimal? _cha_006 = 0M;
        private decimal? _cha_007 = 0M;
        private decimal? _cha_008 = 0M;
        private decimal? _cha_009 = 0M;
        private decimal? _cha_010 = 0M;
        private decimal? _cha_011 = 0M;
        private decimal? _cha_012 = 0M;
        private decimal? _cha_013 = 0M;
        private decimal? _cha_014 = 0M;
        private decimal? _cha_015 = 0M;
        private decimal? _cha_016 = 0M;
        private decimal? _cha_017 = 0M;
        private decimal? _cha_018 = 0M;
        private decimal? _cha_019 = 0M;
        private decimal? _cha_020 = 0M;
        private int? _cha_ci;
        private string _cha_hui_id;
        private string _cha_hui_bianhao;
        private string _cha_name;
        private DateTime? _cha_date = DateTime.Now;
        private int? _cha_type;
        private decimal? _zong_money = 0M;
        private decimal? _zong = 0M;
        private int? _chanpin_count = 0;
        private decimal? _ri_money;
        private int? _fafang = 0;
        private int? _cs = 0;
        private int? _flag = 0;
        private decimal? _cha_021 = 0M;
        private decimal? _cha_022 = 0M;
        private decimal? _cha_023 = 0M;
        private decimal? _cha_024 = 0M;
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
        public decimal? cha_001
        {
            set { _cha_001 = value; }
            get { return _cha_001; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? cha_002
        {
            set { _cha_002 = value; }
            get { return _cha_002; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? cha_003
        {
            set { _cha_003 = value; }
            get { return _cha_003; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? cha_004
        {
            set { _cha_004 = value; }
            get { return _cha_004; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? cha_005
        {
            set { _cha_005 = value; }
            get { return _cha_005; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? cha_006
        {
            set { _cha_006 = value; }
            get { return _cha_006; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? cha_007
        {
            set { _cha_007 = value; }
            get { return _cha_007; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? cha_008
        {
            set { _cha_008 = value; }
            get { return _cha_008; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? cha_009
        {
            set { _cha_009 = value; }
            get { return _cha_009; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? cha_010
        {
            set { _cha_010 = value; }
            get { return _cha_010; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? cha_011
        {
            set { _cha_011 = value; }
            get { return _cha_011; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? cha_012
        {
            set { _cha_012 = value; }
            get { return _cha_012; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? cha_013
        {
            set { _cha_013 = value; }
            get { return _cha_013; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? cha_014
        {
            set { _cha_014 = value; }
            get { return _cha_014; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? cha_015
        {
            set { _cha_015 = value; }
            get { return _cha_015; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? cha_016
        {
            set { _cha_016 = value; }
            get { return _cha_016; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? cha_017
        {
            set { _cha_017 = value; }
            get { return _cha_017; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? cha_018
        {
            set { _cha_018 = value; }
            get { return _cha_018; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? cha_019
        {
            set { _cha_019 = value; }
            get { return _cha_019; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? cha_020
        {
            set { _cha_020 = value; }
            get { return _cha_020; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? cha_ci
        {
            set { _cha_ci = value; }
            get { return _cha_ci; }
        }
        /// <summary>
        /// 查询会员标识
        /// </summary>
        public string cha_hui_id
        {
            set { _cha_hui_id = value; }
            get { return _cha_hui_id; }
        }
        /// <summary>
        /// 查询会员编号
        /// </summary>
        public string cha_hui_bianhao
        {
            set { _cha_hui_bianhao = value; }
            get { return _cha_hui_bianhao; }
        }
        /// <summary>
        /// 查询会员姓名
        /// </summary>
        public string cha_name
        {
            set { _cha_name = value; }
            get { return _cha_name; }
        }
        /// <summary>
        /// 发放时间
        /// </summary>
        public DateTime? cha_date
        {
            set { _cha_date = value; }
            get { return _cha_date; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? cha_type
        {
            set { _cha_type = value; }
            get { return _cha_type; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? zong_money
        {
            set { _zong_money = value; }
            get { return _zong_money; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? zong
        {
            set { _zong = value; }
            get { return _zong; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? chanpin_count
        {
            set { _chanpin_count = value; }
            get { return _chanpin_count; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? ri_money
        {
            set { _ri_money = value; }
            get { return _ri_money; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? fafang
        {
            set { _fafang = value; }
            get { return _fafang; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? cs
        {
            set { _cs = value; }
            get { return _cs; }
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
        public decimal? cha_021
        {
            set { _cha_021 = value; }
            get { return _cha_021; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? cha_022
        {
            set { _cha_022 = value; }
            get { return _cha_022; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? cha_023
        {
            set { _cha_023 = value; }
            get { return _cha_023; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? cha_024
        {
            set { _cha_024 = value; }
            get { return _cha_024; }
        }
        #endregion Model


        #region  Method

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public tbl_cha(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,cha_001,cha_002,cha_003,cha_004,cha_005,cha_006,cha_007,cha_008,cha_009,cha_010,cha_011,cha_012,cha_013,cha_014,cha_015,cha_016,cha_017,cha_018,cha_019,cha_020,cha_ci,cha_hui_id,cha_hui_bianhao,cha_name,cha_date,cha_type,zong_money,zong,chanpin_count,ri_money,fafang,cs,flag,cha_021,cha_022,cha_023,cha_024 ");
            strSql.Append(" FROM [tbl_cha] ");
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
                if (ds.Tables[0].Rows[0]["cha_001"] != null && ds.Tables[0].Rows[0]["cha_001"].ToString() != "")
                {
                    this.cha_001 = decimal.Parse(ds.Tables[0].Rows[0]["cha_001"].ToString());
                }
                if (ds.Tables[0].Rows[0]["cha_002"] != null && ds.Tables[0].Rows[0]["cha_002"].ToString() != "")
                {
                    this.cha_002 = decimal.Parse(ds.Tables[0].Rows[0]["cha_002"].ToString());
                }
                if (ds.Tables[0].Rows[0]["cha_003"] != null && ds.Tables[0].Rows[0]["cha_003"].ToString() != "")
                {
                    this.cha_003 = decimal.Parse(ds.Tables[0].Rows[0]["cha_003"].ToString());
                }
                if (ds.Tables[0].Rows[0]["cha_004"] != null && ds.Tables[0].Rows[0]["cha_004"].ToString() != "")
                {
                    this.cha_004 = decimal.Parse(ds.Tables[0].Rows[0]["cha_004"].ToString());
                }
                if (ds.Tables[0].Rows[0]["cha_005"] != null && ds.Tables[0].Rows[0]["cha_005"].ToString() != "")
                {
                    this.cha_005 = decimal.Parse(ds.Tables[0].Rows[0]["cha_005"].ToString());
                }
                if (ds.Tables[0].Rows[0]["cha_006"] != null && ds.Tables[0].Rows[0]["cha_006"].ToString() != "")
                {
                    this.cha_006 = decimal.Parse(ds.Tables[0].Rows[0]["cha_006"].ToString());
                }
                if (ds.Tables[0].Rows[0]["cha_007"] != null && ds.Tables[0].Rows[0]["cha_007"].ToString() != "")
                {
                    this.cha_007 = decimal.Parse(ds.Tables[0].Rows[0]["cha_007"].ToString());
                }
                if (ds.Tables[0].Rows[0]["cha_008"] != null && ds.Tables[0].Rows[0]["cha_008"].ToString() != "")
                {
                    this.cha_008 = decimal.Parse(ds.Tables[0].Rows[0]["cha_008"].ToString());
                }
                if (ds.Tables[0].Rows[0]["cha_009"] != null && ds.Tables[0].Rows[0]["cha_009"].ToString() != "")
                {
                    this.cha_009 = decimal.Parse(ds.Tables[0].Rows[0]["cha_009"].ToString());
                }
                if (ds.Tables[0].Rows[0]["cha_010"] != null && ds.Tables[0].Rows[0]["cha_010"].ToString() != "")
                {
                    this.cha_010 = decimal.Parse(ds.Tables[0].Rows[0]["cha_010"].ToString());
                }
                if (ds.Tables[0].Rows[0]["cha_011"] != null && ds.Tables[0].Rows[0]["cha_011"].ToString() != "")
                {
                    this.cha_011 = decimal.Parse(ds.Tables[0].Rows[0]["cha_011"].ToString());
                }
                if (ds.Tables[0].Rows[0]["cha_012"] != null && ds.Tables[0].Rows[0]["cha_012"].ToString() != "")
                {
                    this.cha_012 = decimal.Parse(ds.Tables[0].Rows[0]["cha_012"].ToString());
                }
                if (ds.Tables[0].Rows[0]["cha_013"] != null && ds.Tables[0].Rows[0]["cha_013"].ToString() != "")
                {
                    this.cha_013 = decimal.Parse(ds.Tables[0].Rows[0]["cha_013"].ToString());
                }
                if (ds.Tables[0].Rows[0]["cha_014"] != null && ds.Tables[0].Rows[0]["cha_014"].ToString() != "")
                {
                    this.cha_014 = decimal.Parse(ds.Tables[0].Rows[0]["cha_014"].ToString());
                }
                if (ds.Tables[0].Rows[0]["cha_015"] != null && ds.Tables[0].Rows[0]["cha_015"].ToString() != "")
                {
                    this.cha_015 = decimal.Parse(ds.Tables[0].Rows[0]["cha_015"].ToString());
                }
                if (ds.Tables[0].Rows[0]["cha_016"] != null && ds.Tables[0].Rows[0]["cha_016"].ToString() != "")
                {
                    this.cha_016 = decimal.Parse(ds.Tables[0].Rows[0]["cha_016"].ToString());
                }
                if (ds.Tables[0].Rows[0]["cha_017"] != null && ds.Tables[0].Rows[0]["cha_017"].ToString() != "")
                {
                    this.cha_017 = decimal.Parse(ds.Tables[0].Rows[0]["cha_017"].ToString());
                }
                if (ds.Tables[0].Rows[0]["cha_018"] != null && ds.Tables[0].Rows[0]["cha_018"].ToString() != "")
                {
                    this.cha_018 = decimal.Parse(ds.Tables[0].Rows[0]["cha_018"].ToString());
                }
                if (ds.Tables[0].Rows[0]["cha_019"] != null && ds.Tables[0].Rows[0]["cha_019"].ToString() != "")
                {
                    this.cha_019 = decimal.Parse(ds.Tables[0].Rows[0]["cha_019"].ToString());
                }
                if (ds.Tables[0].Rows[0]["cha_020"] != null && ds.Tables[0].Rows[0]["cha_020"].ToString() != "")
                {
                    this.cha_020 = decimal.Parse(ds.Tables[0].Rows[0]["cha_020"].ToString());
                }
                if (ds.Tables[0].Rows[0]["cha_ci"] != null && ds.Tables[0].Rows[0]["cha_ci"].ToString() != "")
                {
                    this.cha_ci = int.Parse(ds.Tables[0].Rows[0]["cha_ci"].ToString());
                }
                if (ds.Tables[0].Rows[0]["cha_hui_id"] != null)
                {
                    this.cha_hui_id = ds.Tables[0].Rows[0]["cha_hui_id"].ToString();
                }
                if (ds.Tables[0].Rows[0]["cha_hui_bianhao"] != null)
                {
                    this.cha_hui_bianhao = ds.Tables[0].Rows[0]["cha_hui_bianhao"].ToString();
                }
                if (ds.Tables[0].Rows[0]["cha_name"] != null)
                {
                    this.cha_name = ds.Tables[0].Rows[0]["cha_name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["cha_date"] != null && ds.Tables[0].Rows[0]["cha_date"].ToString() != "")
                {
                    this.cha_date = DateTime.Parse(ds.Tables[0].Rows[0]["cha_date"].ToString());
                }
                if (ds.Tables[0].Rows[0]["cha_type"] != null && ds.Tables[0].Rows[0]["cha_type"].ToString() != "")
                {
                    this.cha_type = int.Parse(ds.Tables[0].Rows[0]["cha_type"].ToString());
                }
                if (ds.Tables[0].Rows[0]["zong_money"] != null && ds.Tables[0].Rows[0]["zong_money"].ToString() != "")
                {
                    this.zong_money = decimal.Parse(ds.Tables[0].Rows[0]["zong_money"].ToString());
                }
                if (ds.Tables[0].Rows[0]["zong"] != null && ds.Tables[0].Rows[0]["zong"].ToString() != "")
                {
                    this.zong = decimal.Parse(ds.Tables[0].Rows[0]["zong"].ToString());
                }
                if (ds.Tables[0].Rows[0]["chanpin_count"] != null && ds.Tables[0].Rows[0]["chanpin_count"].ToString() != "")
                {
                    this.chanpin_count = int.Parse(ds.Tables[0].Rows[0]["chanpin_count"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ri_money"] != null && ds.Tables[0].Rows[0]["ri_money"].ToString() != "")
                {
                    this.ri_money = decimal.Parse(ds.Tables[0].Rows[0]["ri_money"].ToString());
                }
                if (ds.Tables[0].Rows[0]["fafang"] != null && ds.Tables[0].Rows[0]["fafang"].ToString() != "")
                {
                    this.fafang = int.Parse(ds.Tables[0].Rows[0]["fafang"].ToString());
                }
                if (ds.Tables[0].Rows[0]["cs"] != null && ds.Tables[0].Rows[0]["cs"].ToString() != "")
                {
                    this.cs = int.Parse(ds.Tables[0].Rows[0]["cs"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag"] != null && ds.Tables[0].Rows[0]["flag"].ToString() != "")
                {
                    this.flag = int.Parse(ds.Tables[0].Rows[0]["flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["cha_021"] != null && ds.Tables[0].Rows[0]["cha_021"].ToString() != "")
                {
                    this.cha_021 = decimal.Parse(ds.Tables[0].Rows[0]["cha_021"].ToString());
                }
                if (ds.Tables[0].Rows[0]["cha_022"] != null && ds.Tables[0].Rows[0]["cha_022"].ToString() != "")
                {
                    this.cha_022 = decimal.Parse(ds.Tables[0].Rows[0]["cha_022"].ToString());
                }
                if (ds.Tables[0].Rows[0]["cha_023"] != null && ds.Tables[0].Rows[0]["cha_023"].ToString() != "")
                {
                    this.cha_023 = decimal.Parse(ds.Tables[0].Rows[0]["cha_023"].ToString());
                }
                if (ds.Tables[0].Rows[0]["cha_024"] != null && ds.Tables[0].Rows[0]["cha_024"].ToString() != "")
                {
                    this.cha_024 = decimal.Parse(ds.Tables[0].Rows[0]["cha_024"].ToString());
                }
            }
        }
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from [tbl_cha]");
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
            strSql.Append("insert into [tbl_cha] (");
            strSql.Append("cha_001,cha_002,cha_003,cha_004,cha_005,cha_006,cha_007,cha_008,cha_009,cha_010,cha_011,cha_012,cha_013,cha_014,cha_015,cha_016,cha_017,cha_018,cha_019,cha_020,cha_ci,cha_hui_id,cha_hui_bianhao,cha_name,cha_date,cha_type,zong_money,zong,chanpin_count,ri_money,fafang,cs,flag,cha_021,cha_022,cha_023,cha_024)");
            strSql.Append(" values (");
            strSql.Append("@cha_001,@cha_002,@cha_003,@cha_004,@cha_005,@cha_006,@cha_007,@cha_008,@cha_009,@cha_010,@cha_011,@cha_012,@cha_013,@cha_014,@cha_015,@cha_016,@cha_017,@cha_018,@cha_019,@cha_020,@cha_ci,@cha_hui_id,@cha_hui_bianhao,@cha_name,@cha_date,@cha_type,@zong_money,@zong,@chanpin_count,@ri_money,@fafang,@cs,@flag,@cha_021,@cha_022,@cha_023,@cha_024)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@cha_001", SqlDbType.Money,8),
					new SqlParameter("@cha_002", SqlDbType.Money,8),
					new SqlParameter("@cha_003", SqlDbType.Money,8),
					new SqlParameter("@cha_004", SqlDbType.Money,8),
					new SqlParameter("@cha_005", SqlDbType.Money,8),
					new SqlParameter("@cha_006", SqlDbType.Money,8),
					new SqlParameter("@cha_007", SqlDbType.Money,8),
					new SqlParameter("@cha_008", SqlDbType.Money,8),
					new SqlParameter("@cha_009", SqlDbType.Money,8),
					new SqlParameter("@cha_010", SqlDbType.Money,8),
					new SqlParameter("@cha_011", SqlDbType.Money,8),
					new SqlParameter("@cha_012", SqlDbType.Money,8),
					new SqlParameter("@cha_013", SqlDbType.Money,8),
					new SqlParameter("@cha_014", SqlDbType.Money,8),
					new SqlParameter("@cha_015", SqlDbType.Money,8),
					new SqlParameter("@cha_016", SqlDbType.Money,8),
					new SqlParameter("@cha_017", SqlDbType.Money,8),
					new SqlParameter("@cha_018", SqlDbType.Money,8),
					new SqlParameter("@cha_019", SqlDbType.Money,8),
					new SqlParameter("@cha_020", SqlDbType.Money,8),
					new SqlParameter("@cha_ci", SqlDbType.Int,4),
					new SqlParameter("@cha_hui_id", SqlDbType.Char,9),
					new SqlParameter("@cha_hui_bianhao", SqlDbType.VarChar,50),
					new SqlParameter("@cha_name", SqlDbType.VarChar,50),
					new SqlParameter("@cha_date", SqlDbType.DateTime),
					new SqlParameter("@cha_type", SqlDbType.Int,4),
					new SqlParameter("@zong_money", SqlDbType.Money,8),
					new SqlParameter("@zong", SqlDbType.Money,8),
					new SqlParameter("@chanpin_count", SqlDbType.Int,4),
					new SqlParameter("@ri_money", SqlDbType.Money,8),
					new SqlParameter("@fafang", SqlDbType.Int,4),
					new SqlParameter("@cs", SqlDbType.Int,4),
					new SqlParameter("@flag", SqlDbType.Int,4),
					new SqlParameter("@cha_021", SqlDbType.Money,8),
					new SqlParameter("@cha_022", SqlDbType.Money,8),
					new SqlParameter("@cha_023", SqlDbType.Money,8),
					new SqlParameter("@cha_024", SqlDbType.Money,8)};
            parameters[0].Value = cha_001;
            parameters[1].Value = cha_002;
            parameters[2].Value = cha_003;
            parameters[3].Value = cha_004;
            parameters[4].Value = cha_005;
            parameters[5].Value = cha_006;
            parameters[6].Value = cha_007;
            parameters[7].Value = cha_008;
            parameters[8].Value = cha_009;
            parameters[9].Value = cha_010;
            parameters[10].Value = cha_011;
            parameters[11].Value = cha_012;
            parameters[12].Value = cha_013;
            parameters[13].Value = cha_014;
            parameters[14].Value = cha_015;
            parameters[15].Value = cha_016;
            parameters[16].Value = cha_017;
            parameters[17].Value = cha_018;
            parameters[18].Value = cha_019;
            parameters[19].Value = cha_020;
            parameters[20].Value = cha_ci;
            parameters[21].Value = cha_hui_id;
            parameters[22].Value = cha_hui_bianhao;
            parameters[23].Value = cha_name;
            parameters[24].Value = cha_date;
            parameters[25].Value = cha_type;
            parameters[26].Value = zong_money;
            parameters[27].Value = zong;
            parameters[28].Value = chanpin_count;
            parameters[29].Value = ri_money;
            parameters[30].Value = fafang;
            parameters[31].Value = cs;
            parameters[32].Value = flag;
            parameters[33].Value = cha_021;
            parameters[34].Value = cha_022;
            parameters[35].Value = cha_023;
            parameters[36].Value = cha_024;

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
            strSql.Append("update [tbl_cha] set ");
            strSql.Append("cha_001=@cha_001,");
            strSql.Append("cha_002=@cha_002,");
            strSql.Append("cha_003=@cha_003,");
            strSql.Append("cha_004=@cha_004,");
            strSql.Append("cha_005=@cha_005,");
            strSql.Append("cha_006=@cha_006,");
            strSql.Append("cha_007=@cha_007,");
            strSql.Append("cha_008=@cha_008,");
            strSql.Append("cha_009=@cha_009,");
            strSql.Append("cha_010=@cha_010,");
            strSql.Append("cha_011=@cha_011,");
            strSql.Append("cha_012=@cha_012,");
            strSql.Append("cha_013=@cha_013,");
            strSql.Append("cha_014=@cha_014,");
            strSql.Append("cha_015=@cha_015,");
            strSql.Append("cha_016=@cha_016,");
            strSql.Append("cha_017=@cha_017,");
            strSql.Append("cha_018=@cha_018,");
            strSql.Append("cha_019=@cha_019,");
            strSql.Append("cha_020=@cha_020,");
            strSql.Append("cha_ci=@cha_ci,");
            strSql.Append("cha_hui_id=@cha_hui_id,");
            strSql.Append("cha_hui_bianhao=@cha_hui_bianhao,");
            strSql.Append("cha_name=@cha_name,");
            strSql.Append("cha_date=@cha_date,");
            strSql.Append("cha_type=@cha_type,");
            strSql.Append("zong_money=@zong_money,");
            strSql.Append("zong=@zong,");
            strSql.Append("chanpin_count=@chanpin_count,");
            strSql.Append("ri_money=@ri_money,");
            strSql.Append("fafang=@fafang,");
            strSql.Append("cs=@cs,");
            strSql.Append("flag=@flag,");
            strSql.Append("cha_021=@cha_021,");
            strSql.Append("cha_022=@cha_022,");
            strSql.Append("cha_023=@cha_023,");
            strSql.Append("cha_024=@cha_024");
            strSql.Append(" where id=@id ");
            SqlParameter[] parameters = {
					new SqlParameter("@cha_001", SqlDbType.Money,8),
					new SqlParameter("@cha_002", SqlDbType.Money,8),
					new SqlParameter("@cha_003", SqlDbType.Money,8),
					new SqlParameter("@cha_004", SqlDbType.Money,8),
					new SqlParameter("@cha_005", SqlDbType.Money,8),
					new SqlParameter("@cha_006", SqlDbType.Money,8),
					new SqlParameter("@cha_007", SqlDbType.Money,8),
					new SqlParameter("@cha_008", SqlDbType.Money,8),
					new SqlParameter("@cha_009", SqlDbType.Money,8),
					new SqlParameter("@cha_010", SqlDbType.Money,8),
					new SqlParameter("@cha_011", SqlDbType.Money,8),
					new SqlParameter("@cha_012", SqlDbType.Money,8),
					new SqlParameter("@cha_013", SqlDbType.Money,8),
					new SqlParameter("@cha_014", SqlDbType.Money,8),
					new SqlParameter("@cha_015", SqlDbType.Money,8),
					new SqlParameter("@cha_016", SqlDbType.Money,8),
					new SqlParameter("@cha_017", SqlDbType.Money,8),
					new SqlParameter("@cha_018", SqlDbType.Money,8),
					new SqlParameter("@cha_019", SqlDbType.Money,8),
					new SqlParameter("@cha_020", SqlDbType.Money,8),
					new SqlParameter("@cha_ci", SqlDbType.Int,4),
					new SqlParameter("@cha_hui_id", SqlDbType.Char,9),
					new SqlParameter("@cha_hui_bianhao", SqlDbType.VarChar,50),
					new SqlParameter("@cha_name", SqlDbType.VarChar,50),
					new SqlParameter("@cha_date", SqlDbType.DateTime),
					new SqlParameter("@cha_type", SqlDbType.Int,4),
					new SqlParameter("@zong_money", SqlDbType.Money,8),
					new SqlParameter("@zong", SqlDbType.Money,8),
					new SqlParameter("@chanpin_count", SqlDbType.Int,4),
					new SqlParameter("@ri_money", SqlDbType.Money,8),
					new SqlParameter("@fafang", SqlDbType.Int,4),
					new SqlParameter("@cs", SqlDbType.Int,4),
					new SqlParameter("@flag", SqlDbType.Int,4),
					new SqlParameter("@cha_021", SqlDbType.Money,8),
					new SqlParameter("@cha_022", SqlDbType.Money,8),
					new SqlParameter("@cha_023", SqlDbType.Money,8),
					new SqlParameter("@cha_024", SqlDbType.Money,8),
					new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = cha_001;
            parameters[1].Value = cha_002;
            parameters[2].Value = cha_003;
            parameters[3].Value = cha_004;
            parameters[4].Value = cha_005;
            parameters[5].Value = cha_006;
            parameters[6].Value = cha_007;
            parameters[7].Value = cha_008;
            parameters[8].Value = cha_009;
            parameters[9].Value = cha_010;
            parameters[10].Value = cha_011;
            parameters[11].Value = cha_012;
            parameters[12].Value = cha_013;
            parameters[13].Value = cha_014;
            parameters[14].Value = cha_015;
            parameters[15].Value = cha_016;
            parameters[16].Value = cha_017;
            parameters[17].Value = cha_018;
            parameters[18].Value = cha_019;
            parameters[19].Value = cha_020;
            parameters[20].Value = cha_ci;
            parameters[21].Value = cha_hui_id;
            parameters[22].Value = cha_hui_bianhao;
            parameters[23].Value = cha_name;
            parameters[24].Value = cha_date;
            parameters[25].Value = cha_type;
            parameters[26].Value = zong_money;
            parameters[27].Value = zong;
            parameters[28].Value = chanpin_count;
            parameters[29].Value = ri_money;
            parameters[30].Value = fafang;
            parameters[31].Value = cs;
            parameters[32].Value = flag;
            parameters[33].Value = cha_021;
            parameters[34].Value = cha_022;
            parameters[35].Value = cha_023;
            parameters[36].Value = cha_024;
            parameters[37].Value = id;

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
            strSql.Append("delete from [tbl_cha] ");
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
            strSql.Append("select id,cha_001,cha_002,cha_003,cha_004,cha_005,cha_006,cha_007,cha_008,cha_009,cha_010,cha_011,cha_012,cha_013,cha_014,cha_015,cha_016,cha_017,cha_018,cha_019,cha_020,cha_ci,cha_hui_id,cha_hui_bianhao,cha_name,cha_date,cha_type,zong_money,zong,chanpin_count,ri_money,fafang,cs,flag,cha_021,cha_022,cha_023,cha_024 ");
            strSql.Append(" FROM [tbl_cha] ");
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
                if (ds.Tables[0].Rows[0]["cha_001"] != null && ds.Tables[0].Rows[0]["cha_001"].ToString() != "")
                {
                    this.cha_001 = decimal.Parse(ds.Tables[0].Rows[0]["cha_001"].ToString());
                }
                if (ds.Tables[0].Rows[0]["cha_002"] != null && ds.Tables[0].Rows[0]["cha_002"].ToString() != "")
                {
                    this.cha_002 = decimal.Parse(ds.Tables[0].Rows[0]["cha_002"].ToString());
                }
                if (ds.Tables[0].Rows[0]["cha_003"] != null && ds.Tables[0].Rows[0]["cha_003"].ToString() != "")
                {
                    this.cha_003 = decimal.Parse(ds.Tables[0].Rows[0]["cha_003"].ToString());
                }
                if (ds.Tables[0].Rows[0]["cha_004"] != null && ds.Tables[0].Rows[0]["cha_004"].ToString() != "")
                {
                    this.cha_004 = decimal.Parse(ds.Tables[0].Rows[0]["cha_004"].ToString());
                }
                if (ds.Tables[0].Rows[0]["cha_005"] != null && ds.Tables[0].Rows[0]["cha_005"].ToString() != "")
                {
                    this.cha_005 = decimal.Parse(ds.Tables[0].Rows[0]["cha_005"].ToString());
                }
                if (ds.Tables[0].Rows[0]["cha_006"] != null && ds.Tables[0].Rows[0]["cha_006"].ToString() != "")
                {
                    this.cha_006 = decimal.Parse(ds.Tables[0].Rows[0]["cha_006"].ToString());
                }
                if (ds.Tables[0].Rows[0]["cha_007"] != null && ds.Tables[0].Rows[0]["cha_007"].ToString() != "")
                {
                    this.cha_007 = decimal.Parse(ds.Tables[0].Rows[0]["cha_007"].ToString());
                }
                if (ds.Tables[0].Rows[0]["cha_008"] != null && ds.Tables[0].Rows[0]["cha_008"].ToString() != "")
                {
                    this.cha_008 = decimal.Parse(ds.Tables[0].Rows[0]["cha_008"].ToString());
                }
                if (ds.Tables[0].Rows[0]["cha_009"] != null && ds.Tables[0].Rows[0]["cha_009"].ToString() != "")
                {
                    this.cha_009 = decimal.Parse(ds.Tables[0].Rows[0]["cha_009"].ToString());
                }
                if (ds.Tables[0].Rows[0]["cha_010"] != null && ds.Tables[0].Rows[0]["cha_010"].ToString() != "")
                {
                    this.cha_010 = decimal.Parse(ds.Tables[0].Rows[0]["cha_010"].ToString());
                }
                if (ds.Tables[0].Rows[0]["cha_011"] != null && ds.Tables[0].Rows[0]["cha_011"].ToString() != "")
                {
                    this.cha_011 = decimal.Parse(ds.Tables[0].Rows[0]["cha_011"].ToString());
                }
                if (ds.Tables[0].Rows[0]["cha_012"] != null && ds.Tables[0].Rows[0]["cha_012"].ToString() != "")
                {
                    this.cha_012 = decimal.Parse(ds.Tables[0].Rows[0]["cha_012"].ToString());
                }
                if (ds.Tables[0].Rows[0]["cha_013"] != null && ds.Tables[0].Rows[0]["cha_013"].ToString() != "")
                {
                    this.cha_013 = decimal.Parse(ds.Tables[0].Rows[0]["cha_013"].ToString());
                }
                if (ds.Tables[0].Rows[0]["cha_014"] != null && ds.Tables[0].Rows[0]["cha_014"].ToString() != "")
                {
                    this.cha_014 = decimal.Parse(ds.Tables[0].Rows[0]["cha_014"].ToString());
                }
                if (ds.Tables[0].Rows[0]["cha_015"] != null && ds.Tables[0].Rows[0]["cha_015"].ToString() != "")
                {
                    this.cha_015 = decimal.Parse(ds.Tables[0].Rows[0]["cha_015"].ToString());
                }
                if (ds.Tables[0].Rows[0]["cha_016"] != null && ds.Tables[0].Rows[0]["cha_016"].ToString() != "")
                {
                    this.cha_016 = decimal.Parse(ds.Tables[0].Rows[0]["cha_016"].ToString());
                }
                if (ds.Tables[0].Rows[0]["cha_017"] != null && ds.Tables[0].Rows[0]["cha_017"].ToString() != "")
                {
                    this.cha_017 = decimal.Parse(ds.Tables[0].Rows[0]["cha_017"].ToString());
                }
                if (ds.Tables[0].Rows[0]["cha_018"] != null && ds.Tables[0].Rows[0]["cha_018"].ToString() != "")
                {
                    this.cha_018 = decimal.Parse(ds.Tables[0].Rows[0]["cha_018"].ToString());
                }
                if (ds.Tables[0].Rows[0]["cha_019"] != null && ds.Tables[0].Rows[0]["cha_019"].ToString() != "")
                {
                    this.cha_019 = decimal.Parse(ds.Tables[0].Rows[0]["cha_019"].ToString());
                }
                if (ds.Tables[0].Rows[0]["cha_020"] != null && ds.Tables[0].Rows[0]["cha_020"].ToString() != "")
                {
                    this.cha_020 = decimal.Parse(ds.Tables[0].Rows[0]["cha_020"].ToString());
                }
                if (ds.Tables[0].Rows[0]["cha_ci"] != null && ds.Tables[0].Rows[0]["cha_ci"].ToString() != "")
                {
                    this.cha_ci = int.Parse(ds.Tables[0].Rows[0]["cha_ci"].ToString());
                }
                if (ds.Tables[0].Rows[0]["cha_hui_id"] != null)
                {
                    this.cha_hui_id = ds.Tables[0].Rows[0]["cha_hui_id"].ToString();
                }
                if (ds.Tables[0].Rows[0]["cha_hui_bianhao"] != null)
                {
                    this.cha_hui_bianhao = ds.Tables[0].Rows[0]["cha_hui_bianhao"].ToString();
                }
                if (ds.Tables[0].Rows[0]["cha_name"] != null)
                {
                    this.cha_name = ds.Tables[0].Rows[0]["cha_name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["cha_date"] != null && ds.Tables[0].Rows[0]["cha_date"].ToString() != "")
                {
                    this.cha_date = DateTime.Parse(ds.Tables[0].Rows[0]["cha_date"].ToString());
                }
                if (ds.Tables[0].Rows[0]["cha_type"] != null && ds.Tables[0].Rows[0]["cha_type"].ToString() != "")
                {
                    this.cha_type = int.Parse(ds.Tables[0].Rows[0]["cha_type"].ToString());
                }
                if (ds.Tables[0].Rows[0]["zong_money"] != null && ds.Tables[0].Rows[0]["zong_money"].ToString() != "")
                {
                    this.zong_money = decimal.Parse(ds.Tables[0].Rows[0]["zong_money"].ToString());
                }
                if (ds.Tables[0].Rows[0]["zong"] != null && ds.Tables[0].Rows[0]["zong"].ToString() != "")
                {
                    this.zong = decimal.Parse(ds.Tables[0].Rows[0]["zong"].ToString());
                }
                if (ds.Tables[0].Rows[0]["chanpin_count"] != null && ds.Tables[0].Rows[0]["chanpin_count"].ToString() != "")
                {
                    this.chanpin_count = int.Parse(ds.Tables[0].Rows[0]["chanpin_count"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ri_money"] != null && ds.Tables[0].Rows[0]["ri_money"].ToString() != "")
                {
                    this.ri_money = decimal.Parse(ds.Tables[0].Rows[0]["ri_money"].ToString());
                }
                if (ds.Tables[0].Rows[0]["fafang"] != null && ds.Tables[0].Rows[0]["fafang"].ToString() != "")
                {
                    this.fafang = int.Parse(ds.Tables[0].Rows[0]["fafang"].ToString());
                }
                if (ds.Tables[0].Rows[0]["cs"] != null && ds.Tables[0].Rows[0]["cs"].ToString() != "")
                {
                    this.cs = int.Parse(ds.Tables[0].Rows[0]["cs"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag"] != null && ds.Tables[0].Rows[0]["flag"].ToString() != "")
                {
                    this.flag = int.Parse(ds.Tables[0].Rows[0]["flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["cha_021"] != null && ds.Tables[0].Rows[0]["cha_021"].ToString() != "")
                {
                    this.cha_021 = decimal.Parse(ds.Tables[0].Rows[0]["cha_021"].ToString());
                }
                if (ds.Tables[0].Rows[0]["cha_022"] != null && ds.Tables[0].Rows[0]["cha_022"].ToString() != "")
                {
                    this.cha_022 = decimal.Parse(ds.Tables[0].Rows[0]["cha_022"].ToString());
                }
                if (ds.Tables[0].Rows[0]["cha_023"] != null && ds.Tables[0].Rows[0]["cha_023"].ToString() != "")
                {
                    this.cha_023 = decimal.Parse(ds.Tables[0].Rows[0]["cha_023"].ToString());
                }
                if (ds.Tables[0].Rows[0]["cha_024"] != null && ds.Tables[0].Rows[0]["cha_024"].ToString() != "")
                {
                    this.cha_024 = decimal.Parse(ds.Tables[0].Rows[0]["cha_024"].ToString());
                }
            }
        }
        /// <summary>
        /// 获得查询分页数据
        /// </summary>
        public DataSet GetList(int pageSize, int pageIndex, string strWhere, string filedOrder, out int recordCount)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * FROM  tbl_cha");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            recordCount = Convert.ToInt32(DbHelperSQL.GetSingle(PagingHelper.CreateCountingSql(strSql.ToString())));
            return DbHelperSQL.Query(PagingHelper.CreatePagingSql(recordCount, pageSize, pageIndex, strSql.ToString(), filedOrder));
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM [tbl_cha] ");
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
            strSql.Append("select top 1 " + Title + " as sumcode from [tbl_cha]");
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
 

