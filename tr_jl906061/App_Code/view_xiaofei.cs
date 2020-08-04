using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
 
 
    /// <summary>
    /// 类view_xiaofei。
    /// </summary>
    [Serializable]
    public partial class view_xiaofei
    {
        public view_xiaofei()
        { }
        #region Model
        private int _xiaofei_id;
        private string _xiaofei_hui_id;
        private decimal? _xiaofei_money;
        private string _xiaofei_pro_id;
        private decimal? _xiaofei_pro_count;
        private int? _xiaofei_flag;
        private int? _xiaofei_flag_jiezhang;
        private string _xiaofei_zhuanmai;
        private DateTime? _xiaofei_date;
        private string _xiaofei_memo;
        private int? _xiaofei_flag_jiezhang_yue;
        private int? _xiaofei_flag_jiezhang_zhou;
        private int? _xiaofei_flag_jiezhang_nian;
        private int? _xiaofei_flag_jiezhang_yue_fenhong1;
        private int? _xiaofei_flag_10;
        private int? _zhuanmai_flag;
        private int? _daozhang;
        private string _zhuangmai_wang;
        private int? _wang_flag;
        private int? _xiaofei_flag_jizhang_zm;
        private string _zhuangmai_wang_name;
        private int? _ding_flag;
        private string _pro_name;
        private int? _flag_2;
        private int? _xiaofei_zuofei_flag;
        private DateTime? _xiaofei_qr_date;
        private int? _xiaofei_qr_flag;
        private string _huiyuan_id;
        private string _huiyuan_bianhao;
        private string _huiyuan_name;
        private int? _flag_5;
        private int? _flag_1;
        private int? _zhuanmai_jb;
        private int? _huiyuan_zhuanmai_sq;
        private DateTime? _huiyuan_qr_date;
        private int? _net_flag;
        private int? _net_hege;
        private int? _huiyuan_jiebie;
        private DateTime? _huiyuan_add_time;
        private int? _zhuce_flag;
        private int? _flag_11;
        private int? _flag_a1;
        private string _huiyuan_zm;
        private int? _flag_10;
        private int? _flag_3;
        private int? _flag_jiesuan;
        private string _huiyuan_shang_id;
        private int? _xiaofei_chongfu_flag;
        private decimal? _xiaofei_money1;
        private int? _huiyuan_jiebie1;
        private int? _huiyuan_jiebie2;
        private int? _bid;
        private int? _mmid;
        private int? _sid;
        private int? _xiaofei_zuoyou;
        private int? _flag_15;
        private int? _flag_12;
        private int? _flag_13;
        private int? _flag_14;
        private decimal? _xiaofei_money2;
        private int? _fahuo_flag;
        private string _huiyuan_shangshu;
        private string _huiyuan_shangshu2;
        private string _huiyuan_address;
        private string _kdname;
        private string _wlno;
        private string _mob;
        private string _huiyuan_jiedian;
        private int? _flag_18;
        /// <summary>
        /// 
        /// </summary>
        public int xiaofei_id
        {
            set { _xiaofei_id = value; }
            get { return _xiaofei_id; }
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
        public decimal? xiaofei_money
        {
            set { _xiaofei_money = value; }
            get { return _xiaofei_money; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string xiaofei_pro_id
        {
            set { _xiaofei_pro_id = value; }
            get { return _xiaofei_pro_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? xiaofei_pro_count
        {
            set { _xiaofei_pro_count = value; }
            get { return _xiaofei_pro_count; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? xiaofei_flag
        {
            set { _xiaofei_flag = value; }
            get { return _xiaofei_flag; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? xiaofei_flag_jiezhang
        {
            set { _xiaofei_flag_jiezhang = value; }
            get { return _xiaofei_flag_jiezhang; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string xiaofei_zhuanmai
        {
            set { _xiaofei_zhuanmai = value; }
            get { return _xiaofei_zhuanmai; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? xiaofei_date
        {
            set { _xiaofei_date = value; }
            get { return _xiaofei_date; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string xiaofei_memo
        {
            set { _xiaofei_memo = value; }
            get { return _xiaofei_memo; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? xiaofei_flag_jiezhang_yue
        {
            set { _xiaofei_flag_jiezhang_yue = value; }
            get { return _xiaofei_flag_jiezhang_yue; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? xiaofei_flag_jiezhang_zhou
        {
            set { _xiaofei_flag_jiezhang_zhou = value; }
            get { return _xiaofei_flag_jiezhang_zhou; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? xiaofei_flag_jiezhang_nian
        {
            set { _xiaofei_flag_jiezhang_nian = value; }
            get { return _xiaofei_flag_jiezhang_nian; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? xiaofei_flag_jiezhang_yue_fenhong1
        {
            set { _xiaofei_flag_jiezhang_yue_fenhong1 = value; }
            get { return _xiaofei_flag_jiezhang_yue_fenhong1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? xiaofei_flag_10
        {
            set { _xiaofei_flag_10 = value; }
            get { return _xiaofei_flag_10; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? zhuanmai_flag
        {
            set { _zhuanmai_flag = value; }
            get { return _zhuanmai_flag; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? daozhang
        {
            set { _daozhang = value; }
            get { return _daozhang; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string zhuangmai_wang
        {
            set { _zhuangmai_wang = value; }
            get { return _zhuangmai_wang; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? wang_flag
        {
            set { _wang_flag = value; }
            get { return _wang_flag; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? xiaofei_flag_jizhang_zm
        {
            set { _xiaofei_flag_jizhang_zm = value; }
            get { return _xiaofei_flag_jizhang_zm; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string zhuangmai_wang_name
        {
            set { _zhuangmai_wang_name = value; }
            get { return _zhuangmai_wang_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? ding_flag
        {
            set { _ding_flag = value; }
            get { return _ding_flag; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string pro_name
        {
            set { _pro_name = value; }
            get { return _pro_name; }
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
        public int? xiaofei_zuofei_flag
        {
            set { _xiaofei_zuofei_flag = value; }
            get { return _xiaofei_zuofei_flag; }
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
        public int? xiaofei_qr_flag
        {
            set { _xiaofei_qr_flag = value; }
            get { return _xiaofei_qr_flag; }
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
        public string huiyuan_bianhao
        {
            set { _huiyuan_bianhao = value; }
            get { return _huiyuan_bianhao; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string huiyuan_name
        {
            set { _huiyuan_name = value; }
            get { return _huiyuan_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? flag_5
        {
            set { _flag_5 = value; }
            get { return _flag_5; }
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
        public int? zhuanmai_jb
        {
            set { _zhuanmai_jb = value; }
            get { return _zhuanmai_jb; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? huiyuan_zhuanmai_sq
        {
            set { _huiyuan_zhuanmai_sq = value; }
            get { return _huiyuan_zhuanmai_sq; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? huiyuan_qr_date
        {
            set { _huiyuan_qr_date = value; }
            get { return _huiyuan_qr_date; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? net_flag
        {
            set { _net_flag = value; }
            get { return _net_flag; }
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
        public int? huiyuan_jiebie
        {
            set { _huiyuan_jiebie = value; }
            get { return _huiyuan_jiebie; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? huiyuan_add_time
        {
            set { _huiyuan_add_time = value; }
            get { return _huiyuan_add_time; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? zhuce_flag
        {
            set { _zhuce_flag = value; }
            get { return _zhuce_flag; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? flag_11
        {
            set { _flag_11 = value; }
            get { return _flag_11; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? flag_a1
        {
            set { _flag_a1 = value; }
            get { return _flag_a1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string huiyuan_zm
        {
            set { _huiyuan_zm = value; }
            get { return _huiyuan_zm; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? flag_10
        {
            set { _flag_10 = value; }
            get { return _flag_10; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? flag_3
        {
            set { _flag_3 = value; }
            get { return _flag_3; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? flag_jiesuan
        {
            set { _flag_jiesuan = value; }
            get { return _flag_jiesuan; }
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
        public int? xiaofei_chongfu_flag
        {
            set { _xiaofei_chongfu_flag = value; }
            get { return _xiaofei_chongfu_flag; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? xiaofei_money1
        {
            set { _xiaofei_money1 = value; }
            get { return _xiaofei_money1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? huiyuan_jiebie1
        {
            set { _huiyuan_jiebie1 = value; }
            get { return _huiyuan_jiebie1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? huiyuan_jiebie2
        {
            set { _huiyuan_jiebie2 = value; }
            get { return _huiyuan_jiebie2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? bid
        {
            set { _bid = value; }
            get { return _bid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? mmid
        {
            set { _mmid = value; }
            get { return _mmid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? sid
        {
            set { _sid = value; }
            get { return _sid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? xiaofei_zuoyou
        {
            set { _xiaofei_zuoyou = value; }
            get { return _xiaofei_zuoyou; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? flag_15
        {
            set { _flag_15 = value; }
            get { return _flag_15; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? flag_12
        {
            set { _flag_12 = value; }
            get { return _flag_12; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? flag_13
        {
            set { _flag_13 = value; }
            get { return _flag_13; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? flag_14
        {
            set { _flag_14 = value; }
            get { return _flag_14; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? xiaofei_money2
        {
            set { _xiaofei_money2 = value; }
            get { return _xiaofei_money2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? fahuo_flag
        {
            set { _fahuo_flag = value; }
            get { return _fahuo_flag; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string huiyuan_shangshu
        {
            set { _huiyuan_shangshu = value; }
            get { return _huiyuan_shangshu; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string huiyuan_shangshu2
        {
            set { _huiyuan_shangshu2 = value; }
            get { return _huiyuan_shangshu2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string huiyuan_address
        {
            set { _huiyuan_address = value; }
            get { return _huiyuan_address; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string kdname
        {
            set { _kdname = value; }
            get { return _kdname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string wlno
        {
            set { _wlno = value; }
            get { return _wlno; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string mob
        {
            set { _mob = value; }
            get { return _mob; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string huiyuan_jiedian
        {
            set { _huiyuan_jiedian = value; }
            get { return _huiyuan_jiedian; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? flag_18
        {
            set { _flag_18 = value; }
            get { return _flag_18; }
        }
        #endregion Model


        #region  Method

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public view_xiaofei(string xiaofei_hui_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select xiaofei_id,xiaofei_hui_id,xiaofei_money,xiaofei_pro_id,xiaofei_pro_count,xiaofei_flag,xiaofei_flag_jiezhang,xiaofei_zhuanmai,xiaofei_date,xiaofei_memo,xiaofei_flag_jiezhang_yue,xiaofei_flag_jiezhang_zhou,xiaofei_flag_jiezhang_nian,xiaofei_flag_jiezhang_yue_fenhong1,xiaofei_flag_10,zhuanmai_flag,daozhang,zhuangmai_wang,wang_flag,xiaofei_flag_jizhang_zm,zhuangmai_wang_name,ding_flag,pro_name,flag_2,xiaofei_zuofei_flag,xiaofei_qr_date,xiaofei_qr_flag,huiyuan_id,huiyuan_bianhao,huiyuan_name,flag_5,flag_1,zhuanmai_jb,huiyuan_zhuanmai_sq,huiyuan_qr_date,net_flag,net_hege,huiyuan_jiebie,huiyuan_add_time,zhuce_flag,flag_11,flag_a1,huiyuan_zm,flag_10,flag_3,flag_jiesuan,huiyuan_shang_id,xiaofei_chongfu_flag,xiaofei_money1,huiyuan_jiebie1,huiyuan_jiebie2,bid,mmid,sid,xiaofei_zuoyou,flag_15,flag_12,flag_13,flag_14,xiaofei_money2,fahuo_flag,huiyuan_shangshu,huiyuan_shangshu2,huiyuan_address,kdname,wlno,mob,huiyuan_jiedian,flag_18 ");
            strSql.Append(" FROM [view_xiaofei] ");
            strSql.Append(" where xiaofei_hui_id=@xiaofei_hui_id ");
            SqlParameter[] parameters = {
					new SqlParameter("@xiaofei_hui_id", SqlDbType.NVarChar,-1)};
            parameters[0].Value = xiaofei_hui_id;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["xiaofei_id"] != null && ds.Tables[0].Rows[0]["xiaofei_id"].ToString() != "")
                {
                    this.xiaofei_id = int.Parse(ds.Tables[0].Rows[0]["xiaofei_id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xiaofei_hui_id"] != null)
                {
                    this.xiaofei_hui_id = ds.Tables[0].Rows[0]["xiaofei_hui_id"].ToString();
                }
                if (ds.Tables[0].Rows[0]["xiaofei_money"] != null && ds.Tables[0].Rows[0]["xiaofei_money"].ToString() != "")
                {
                    this.xiaofei_money = decimal.Parse(ds.Tables[0].Rows[0]["xiaofei_money"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xiaofei_pro_id"] != null)
                {
                    this.xiaofei_pro_id = ds.Tables[0].Rows[0]["xiaofei_pro_id"].ToString();
                }
                if (ds.Tables[0].Rows[0]["xiaofei_pro_count"] != null && ds.Tables[0].Rows[0]["xiaofei_pro_count"].ToString() != "")
                {
                    this.xiaofei_pro_count = decimal.Parse(ds.Tables[0].Rows[0]["xiaofei_pro_count"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xiaofei_flag"] != null && ds.Tables[0].Rows[0]["xiaofei_flag"].ToString() != "")
                {
                    this.xiaofei_flag = int.Parse(ds.Tables[0].Rows[0]["xiaofei_flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xiaofei_flag_jiezhang"] != null && ds.Tables[0].Rows[0]["xiaofei_flag_jiezhang"].ToString() != "")
                {
                    this.xiaofei_flag_jiezhang = int.Parse(ds.Tables[0].Rows[0]["xiaofei_flag_jiezhang"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xiaofei_zhuanmai"] != null)
                {
                    this.xiaofei_zhuanmai = ds.Tables[0].Rows[0]["xiaofei_zhuanmai"].ToString();
                }
                if (ds.Tables[0].Rows[0]["xiaofei_date"] != null && ds.Tables[0].Rows[0]["xiaofei_date"].ToString() != "")
                {
                    this.xiaofei_date = DateTime.Parse(ds.Tables[0].Rows[0]["xiaofei_date"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xiaofei_memo"] != null)
                {
                    this.xiaofei_memo = ds.Tables[0].Rows[0]["xiaofei_memo"].ToString();
                }
                if (ds.Tables[0].Rows[0]["xiaofei_flag_jiezhang_yue"] != null && ds.Tables[0].Rows[0]["xiaofei_flag_jiezhang_yue"].ToString() != "")
                {
                    this.xiaofei_flag_jiezhang_yue = int.Parse(ds.Tables[0].Rows[0]["xiaofei_flag_jiezhang_yue"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xiaofei_flag_jiezhang_zhou"] != null && ds.Tables[0].Rows[0]["xiaofei_flag_jiezhang_zhou"].ToString() != "")
                {
                    this.xiaofei_flag_jiezhang_zhou = int.Parse(ds.Tables[0].Rows[0]["xiaofei_flag_jiezhang_zhou"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xiaofei_flag_jiezhang_nian"] != null && ds.Tables[0].Rows[0]["xiaofei_flag_jiezhang_nian"].ToString() != "")
                {
                    this.xiaofei_flag_jiezhang_nian = int.Parse(ds.Tables[0].Rows[0]["xiaofei_flag_jiezhang_nian"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xiaofei_flag_jiezhang_yue_fenhong1"] != null && ds.Tables[0].Rows[0]["xiaofei_flag_jiezhang_yue_fenhong1"].ToString() != "")
                {
                    this.xiaofei_flag_jiezhang_yue_fenhong1 = int.Parse(ds.Tables[0].Rows[0]["xiaofei_flag_jiezhang_yue_fenhong1"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xiaofei_flag_10"] != null && ds.Tables[0].Rows[0]["xiaofei_flag_10"].ToString() != "")
                {
                    this.xiaofei_flag_10 = int.Parse(ds.Tables[0].Rows[0]["xiaofei_flag_10"].ToString());
                }
                if (ds.Tables[0].Rows[0]["zhuanmai_flag"] != null && ds.Tables[0].Rows[0]["zhuanmai_flag"].ToString() != "")
                {
                    this.zhuanmai_flag = int.Parse(ds.Tables[0].Rows[0]["zhuanmai_flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["daozhang"] != null && ds.Tables[0].Rows[0]["daozhang"].ToString() != "")
                {
                    this.daozhang = int.Parse(ds.Tables[0].Rows[0]["daozhang"].ToString());
                }
                if (ds.Tables[0].Rows[0]["zhuangmai_wang"] != null)
                {
                    this.zhuangmai_wang = ds.Tables[0].Rows[0]["zhuangmai_wang"].ToString();
                }
                if (ds.Tables[0].Rows[0]["wang_flag"] != null && ds.Tables[0].Rows[0]["wang_flag"].ToString() != "")
                {
                    this.wang_flag = int.Parse(ds.Tables[0].Rows[0]["wang_flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xiaofei_flag_jizhang_zm"] != null && ds.Tables[0].Rows[0]["xiaofei_flag_jizhang_zm"].ToString() != "")
                {
                    this.xiaofei_flag_jizhang_zm = int.Parse(ds.Tables[0].Rows[0]["xiaofei_flag_jizhang_zm"].ToString());
                }
                if (ds.Tables[0].Rows[0]["zhuangmai_wang_name"] != null)
                {
                    this.zhuangmai_wang_name = ds.Tables[0].Rows[0]["zhuangmai_wang_name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["ding_flag"] != null && ds.Tables[0].Rows[0]["ding_flag"].ToString() != "")
                {
                    this.ding_flag = int.Parse(ds.Tables[0].Rows[0]["ding_flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["pro_name"] != null)
                {
                    this.pro_name = ds.Tables[0].Rows[0]["pro_name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["flag_2"] != null && ds.Tables[0].Rows[0]["flag_2"].ToString() != "")
                {
                    this.flag_2 = int.Parse(ds.Tables[0].Rows[0]["flag_2"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xiaofei_zuofei_flag"] != null && ds.Tables[0].Rows[0]["xiaofei_zuofei_flag"].ToString() != "")
                {
                    this.xiaofei_zuofei_flag = int.Parse(ds.Tables[0].Rows[0]["xiaofei_zuofei_flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xiaofei_qr_date"] != null && ds.Tables[0].Rows[0]["xiaofei_qr_date"].ToString() != "")
                {
                    this.xiaofei_qr_date = DateTime.Parse(ds.Tables[0].Rows[0]["xiaofei_qr_date"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xiaofei_qr_flag"] != null && ds.Tables[0].Rows[0]["xiaofei_qr_flag"].ToString() != "")
                {
                    this.xiaofei_qr_flag = int.Parse(ds.Tables[0].Rows[0]["xiaofei_qr_flag"].ToString());
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
                if (ds.Tables[0].Rows[0]["flag_5"] != null && ds.Tables[0].Rows[0]["flag_5"].ToString() != "")
                {
                    this.flag_5 = int.Parse(ds.Tables[0].Rows[0]["flag_5"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_1"] != null && ds.Tables[0].Rows[0]["flag_1"].ToString() != "")
                {
                    this.flag_1 = int.Parse(ds.Tables[0].Rows[0]["flag_1"].ToString());
                }
                if (ds.Tables[0].Rows[0]["zhuanmai_jb"] != null && ds.Tables[0].Rows[0]["zhuanmai_jb"].ToString() != "")
                {
                    this.zhuanmai_jb = int.Parse(ds.Tables[0].Rows[0]["zhuanmai_jb"].ToString());
                }
                if (ds.Tables[0].Rows[0]["huiyuan_zhuanmai_sq"] != null && ds.Tables[0].Rows[0]["huiyuan_zhuanmai_sq"].ToString() != "")
                {
                    this.huiyuan_zhuanmai_sq = int.Parse(ds.Tables[0].Rows[0]["huiyuan_zhuanmai_sq"].ToString());
                }
                if (ds.Tables[0].Rows[0]["huiyuan_qr_date"] != null && ds.Tables[0].Rows[0]["huiyuan_qr_date"].ToString() != "")
                {
                    this.huiyuan_qr_date = DateTime.Parse(ds.Tables[0].Rows[0]["huiyuan_qr_date"].ToString());
                }
                if (ds.Tables[0].Rows[0]["net_flag"] != null && ds.Tables[0].Rows[0]["net_flag"].ToString() != "")
                {
                    this.net_flag = int.Parse(ds.Tables[0].Rows[0]["net_flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["net_hege"] != null && ds.Tables[0].Rows[0]["net_hege"].ToString() != "")
                {
                    this.net_hege = int.Parse(ds.Tables[0].Rows[0]["net_hege"].ToString());
                }
                if (ds.Tables[0].Rows[0]["huiyuan_jiebie"] != null && ds.Tables[0].Rows[0]["huiyuan_jiebie"].ToString() != "")
                {
                    this.huiyuan_jiebie = int.Parse(ds.Tables[0].Rows[0]["huiyuan_jiebie"].ToString());
                }
                if (ds.Tables[0].Rows[0]["huiyuan_add_time"] != null && ds.Tables[0].Rows[0]["huiyuan_add_time"].ToString() != "")
                {
                    this.huiyuan_add_time = DateTime.Parse(ds.Tables[0].Rows[0]["huiyuan_add_time"].ToString());
                }
                if (ds.Tables[0].Rows[0]["zhuce_flag"] != null && ds.Tables[0].Rows[0]["zhuce_flag"].ToString() != "")
                {
                    this.zhuce_flag = int.Parse(ds.Tables[0].Rows[0]["zhuce_flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_11"] != null && ds.Tables[0].Rows[0]["flag_11"].ToString() != "")
                {
                    this.flag_11 = int.Parse(ds.Tables[0].Rows[0]["flag_11"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_a1"] != null && ds.Tables[0].Rows[0]["flag_a1"].ToString() != "")
                {
                    this.flag_a1 = int.Parse(ds.Tables[0].Rows[0]["flag_a1"].ToString());
                }
                if (ds.Tables[0].Rows[0]["huiyuan_zm"] != null)
                {
                    this.huiyuan_zm = ds.Tables[0].Rows[0]["huiyuan_zm"].ToString();
                }
                if (ds.Tables[0].Rows[0]["flag_10"] != null && ds.Tables[0].Rows[0]["flag_10"].ToString() != "")
                {
                    this.flag_10 = int.Parse(ds.Tables[0].Rows[0]["flag_10"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_3"] != null && ds.Tables[0].Rows[0]["flag_3"].ToString() != "")
                {
                    this.flag_3 = int.Parse(ds.Tables[0].Rows[0]["flag_3"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_jiesuan"] != null && ds.Tables[0].Rows[0]["flag_jiesuan"].ToString() != "")
                {
                    this.flag_jiesuan = int.Parse(ds.Tables[0].Rows[0]["flag_jiesuan"].ToString());
                }
                if (ds.Tables[0].Rows[0]["huiyuan_shang_id"] != null)
                {
                    this.huiyuan_shang_id = ds.Tables[0].Rows[0]["huiyuan_shang_id"].ToString();
                }
                if (ds.Tables[0].Rows[0]["xiaofei_chongfu_flag"] != null && ds.Tables[0].Rows[0]["xiaofei_chongfu_flag"].ToString() != "")
                {
                    this.xiaofei_chongfu_flag = int.Parse(ds.Tables[0].Rows[0]["xiaofei_chongfu_flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xiaofei_money1"] != null && ds.Tables[0].Rows[0]["xiaofei_money1"].ToString() != "")
                {
                    this.xiaofei_money1 = decimal.Parse(ds.Tables[0].Rows[0]["xiaofei_money1"].ToString());
                }
                if (ds.Tables[0].Rows[0]["huiyuan_jiebie1"] != null && ds.Tables[0].Rows[0]["huiyuan_jiebie1"].ToString() != "")
                {
                    this.huiyuan_jiebie1 = int.Parse(ds.Tables[0].Rows[0]["huiyuan_jiebie1"].ToString());
                }
                if (ds.Tables[0].Rows[0]["huiyuan_jiebie2"] != null && ds.Tables[0].Rows[0]["huiyuan_jiebie2"].ToString() != "")
                {
                    this.huiyuan_jiebie2 = int.Parse(ds.Tables[0].Rows[0]["huiyuan_jiebie2"].ToString());
                }
                if (ds.Tables[0].Rows[0]["bid"] != null && ds.Tables[0].Rows[0]["bid"].ToString() != "")
                {
                    this.bid = int.Parse(ds.Tables[0].Rows[0]["bid"].ToString());
                }
                if (ds.Tables[0].Rows[0]["mmid"] != null && ds.Tables[0].Rows[0]["mmid"].ToString() != "")
                {
                    this.mmid = int.Parse(ds.Tables[0].Rows[0]["mmid"].ToString());
                }
                if (ds.Tables[0].Rows[0]["sid"] != null && ds.Tables[0].Rows[0]["sid"].ToString() != "")
                {
                    this.sid = int.Parse(ds.Tables[0].Rows[0]["sid"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xiaofei_zuoyou"] != null && ds.Tables[0].Rows[0]["xiaofei_zuoyou"].ToString() != "")
                {
                    this.xiaofei_zuoyou = int.Parse(ds.Tables[0].Rows[0]["xiaofei_zuoyou"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_15"] != null && ds.Tables[0].Rows[0]["flag_15"].ToString() != "")
                {
                    this.flag_15 = int.Parse(ds.Tables[0].Rows[0]["flag_15"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_12"] != null && ds.Tables[0].Rows[0]["flag_12"].ToString() != "")
                {
                    this.flag_12 = int.Parse(ds.Tables[0].Rows[0]["flag_12"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_13"] != null && ds.Tables[0].Rows[0]["flag_13"].ToString() != "")
                {
                    this.flag_13 = int.Parse(ds.Tables[0].Rows[0]["flag_13"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_14"] != null && ds.Tables[0].Rows[0]["flag_14"].ToString() != "")
                {
                    this.flag_14 = int.Parse(ds.Tables[0].Rows[0]["flag_14"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xiaofei_money2"] != null && ds.Tables[0].Rows[0]["xiaofei_money2"].ToString() != "")
                {
                    this.xiaofei_money2 = decimal.Parse(ds.Tables[0].Rows[0]["xiaofei_money2"].ToString());
                }
                if (ds.Tables[0].Rows[0]["fahuo_flag"] != null && ds.Tables[0].Rows[0]["fahuo_flag"].ToString() != "")
                {
                    this.fahuo_flag = int.Parse(ds.Tables[0].Rows[0]["fahuo_flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["huiyuan_shangshu"] != null)
                {
                    this.huiyuan_shangshu = ds.Tables[0].Rows[0]["huiyuan_shangshu"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_shangshu2"] != null)
                {
                    this.huiyuan_shangshu2 = ds.Tables[0].Rows[0]["huiyuan_shangshu2"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_address"] != null)
                {
                    this.huiyuan_address = ds.Tables[0].Rows[0]["huiyuan_address"].ToString();
                }
                if (ds.Tables[0].Rows[0]["kdname"] != null)
                {
                    this.kdname = ds.Tables[0].Rows[0]["kdname"].ToString();
                }
                if (ds.Tables[0].Rows[0]["wlno"] != null)
                {
                    this.wlno = ds.Tables[0].Rows[0]["wlno"].ToString();
                }
                if (ds.Tables[0].Rows[0]["mob"] != null)
                {
                    this.mob = ds.Tables[0].Rows[0]["mob"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_jiedian"] != null)
                {
                    this.huiyuan_jiedian = ds.Tables[0].Rows[0]["huiyuan_jiedian"].ToString();
                }
                if (ds.Tables[0].Rows[0]["flag_18"] != null && ds.Tables[0].Rows[0]["flag_18"].ToString() != "")
                {
                    this.flag_18 = int.Parse(ds.Tables[0].Rows[0]["flag_18"].ToString());
                }
            }
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string xiaofei_hui_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from [view_xiaofei]");
            strSql.Append(" where xiaofei_hui_id=@xiaofei_hui_id ");

            SqlParameter[] parameters = {
					new SqlParameter("@xiaofei_hui_id", SqlDbType.NVarChar,-1)};
            parameters[0].Value = xiaofei_hui_id;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into [view_xiaofei] (");
            strSql.Append("xiaofei_id,xiaofei_hui_id,xiaofei_money,xiaofei_pro_id,xiaofei_pro_count,xiaofei_flag,xiaofei_flag_jiezhang,xiaofei_zhuanmai,xiaofei_date,xiaofei_memo,xiaofei_flag_jiezhang_yue,xiaofei_flag_jiezhang_zhou,xiaofei_flag_jiezhang_nian,xiaofei_flag_jiezhang_yue_fenhong1,xiaofei_flag_10,zhuanmai_flag,daozhang,zhuangmai_wang,wang_flag,xiaofei_flag_jizhang_zm,zhuangmai_wang_name,ding_flag,pro_name,flag_2,xiaofei_zuofei_flag,xiaofei_qr_date,xiaofei_qr_flag,huiyuan_id,huiyuan_bianhao,huiyuan_name,flag_5,flag_1,zhuanmai_jb,huiyuan_zhuanmai_sq,huiyuan_qr_date,net_flag,net_hege,huiyuan_jiebie,huiyuan_add_time,zhuce_flag,flag_11,flag_a1,huiyuan_zm,flag_10,flag_3,flag_jiesuan,huiyuan_shang_id,xiaofei_chongfu_flag,xiaofei_money1,huiyuan_jiebie1,huiyuan_jiebie2,bid,mmid,sid,xiaofei_zuoyou,flag_15,flag_12,flag_13,flag_14,xiaofei_money2,fahuo_flag,huiyuan_shangshu,huiyuan_shangshu2,huiyuan_address,kdname,wlno,mob,huiyuan_jiedian,flag_18)");
            strSql.Append(" values (");
            strSql.Append("@xiaofei_id,@xiaofei_hui_id,@xiaofei_money,@xiaofei_pro_id,@xiaofei_pro_count,@xiaofei_flag,@xiaofei_flag_jiezhang,@xiaofei_zhuanmai,@xiaofei_date,@xiaofei_memo,@xiaofei_flag_jiezhang_yue,@xiaofei_flag_jiezhang_zhou,@xiaofei_flag_jiezhang_nian,@xiaofei_flag_jiezhang_yue_fenhong1,@xiaofei_flag_10,@zhuanmai_flag,@daozhang,@zhuangmai_wang,@wang_flag,@xiaofei_flag_jizhang_zm,@zhuangmai_wang_name,@ding_flag,@pro_name,@flag_2,@xiaofei_zuofei_flag,@xiaofei_qr_date,@xiaofei_qr_flag,@huiyuan_id,@huiyuan_bianhao,@huiyuan_name,@flag_5,@flag_1,@zhuanmai_jb,@huiyuan_zhuanmai_sq,@huiyuan_qr_date,@net_flag,@net_hege,@huiyuan_jiebie,@huiyuan_add_time,@zhuce_flag,@flag_11,@flag_a1,@huiyuan_zm,@flag_10,@flag_3,@flag_jiesuan,@huiyuan_shang_id,@xiaofei_chongfu_flag,@xiaofei_money1,@huiyuan_jiebie1,@huiyuan_jiebie2,@bid,@mmid,@sid,@xiaofei_zuoyou,@flag_15,@flag_12,@flag_13,@flag_14,@xiaofei_money2,@fahuo_flag,@huiyuan_shangshu,@huiyuan_shangshu2,@huiyuan_address,@kdname,@wlno,@mob,@huiyuan_jiedian,@flag_18)");
            SqlParameter[] parameters = {
					new SqlParameter("@xiaofei_id", SqlDbType.Int,4),
					new SqlParameter("@xiaofei_hui_id", SqlDbType.NVarChar,255),
					new SqlParameter("@xiaofei_money", SqlDbType.Money,8),
					new SqlParameter("@xiaofei_pro_id", SqlDbType.NVarChar,255),
					new SqlParameter("@xiaofei_pro_count", SqlDbType.Money,8),
					new SqlParameter("@xiaofei_flag", SqlDbType.Int,4),
					new SqlParameter("@xiaofei_flag_jiezhang", SqlDbType.Int,4),
					new SqlParameter("@xiaofei_zhuanmai", SqlDbType.VarChar,10),
					new SqlParameter("@xiaofei_date", SqlDbType.DateTime),
					new SqlParameter("@xiaofei_memo", SqlDbType.NVarChar,255),
					new SqlParameter("@xiaofei_flag_jiezhang_yue", SqlDbType.Int,4),
					new SqlParameter("@xiaofei_flag_jiezhang_zhou", SqlDbType.Int,4),
					new SqlParameter("@xiaofei_flag_jiezhang_nian", SqlDbType.Int,4),
					new SqlParameter("@xiaofei_flag_jiezhang_yue_fenhong1", SqlDbType.Int,4),
					new SqlParameter("@xiaofei_flag_10", SqlDbType.Int,4),
					new SqlParameter("@zhuanmai_flag", SqlDbType.Int,4),
					new SqlParameter("@daozhang", SqlDbType.Int,4),
					new SqlParameter("@zhuangmai_wang", SqlDbType.VarChar,9),
					new SqlParameter("@wang_flag", SqlDbType.Int,4),
					new SqlParameter("@xiaofei_flag_jizhang_zm", SqlDbType.Int,4),
					new SqlParameter("@zhuangmai_wang_name", SqlDbType.VarChar,50),
					new SqlParameter("@ding_flag", SqlDbType.Int,4),
					new SqlParameter("@pro_name", SqlDbType.VarChar,50),
					new SqlParameter("@flag_2", SqlDbType.Int,4),
					new SqlParameter("@xiaofei_zuofei_flag", SqlDbType.Int,4),
					new SqlParameter("@xiaofei_qr_date", SqlDbType.DateTime),
					new SqlParameter("@xiaofei_qr_flag", SqlDbType.Int,4),
					new SqlParameter("@huiyuan_id", SqlDbType.NVarChar,50),
					new SqlParameter("@huiyuan_bianhao", SqlDbType.NVarChar,50),
					new SqlParameter("@huiyuan_name", SqlDbType.NVarChar,50),
					new SqlParameter("@flag_5", SqlDbType.Int,4),
					new SqlParameter("@flag_1", SqlDbType.Int,4),
					new SqlParameter("@zhuanmai_jb", SqlDbType.Int,4),
					new SqlParameter("@huiyuan_zhuanmai_sq", SqlDbType.Int,4),
					new SqlParameter("@huiyuan_qr_date", SqlDbType.DateTime),
					new SqlParameter("@net_flag", SqlDbType.Int,4),
					new SqlParameter("@net_hege", SqlDbType.Int,4),
					new SqlParameter("@huiyuan_jiebie", SqlDbType.Int,4),
					new SqlParameter("@huiyuan_add_time", SqlDbType.DateTime),
					new SqlParameter("@zhuce_flag", SqlDbType.Int,4),
					new SqlParameter("@flag_11", SqlDbType.Int,4),
					new SqlParameter("@flag_a1", SqlDbType.Int,4),
					new SqlParameter("@huiyuan_zm", SqlDbType.NVarChar,50),
					new SqlParameter("@flag_10", SqlDbType.Int,4),
					new SqlParameter("@flag_3", SqlDbType.Int,4),
					new SqlParameter("@flag_jiesuan", SqlDbType.Int,4),
					new SqlParameter("@huiyuan_shang_id", SqlDbType.NVarChar,50),
					new SqlParameter("@xiaofei_chongfu_flag", SqlDbType.Int,4),
					new SqlParameter("@xiaofei_money1", SqlDbType.Money,8),
					new SqlParameter("@huiyuan_jiebie1", SqlDbType.Int,4),
					new SqlParameter("@huiyuan_jiebie2", SqlDbType.Int,4),
					new SqlParameter("@bid", SqlDbType.Int,4),
					new SqlParameter("@mmid", SqlDbType.Int,4),
					new SqlParameter("@sid", SqlDbType.Int,4),
					new SqlParameter("@xiaofei_zuoyou", SqlDbType.Int,4),
					new SqlParameter("@flag_15", SqlDbType.Int,4),
					new SqlParameter("@flag_12", SqlDbType.Int,4),
					new SqlParameter("@flag_13", SqlDbType.Int,4),
					new SqlParameter("@flag_14", SqlDbType.Int,4),
					new SqlParameter("@xiaofei_money2", SqlDbType.Money,8),
					new SqlParameter("@fahuo_flag", SqlDbType.Int,4),
					new SqlParameter("@huiyuan_shangshu", SqlDbType.VarChar,8000),
					new SqlParameter("@huiyuan_shangshu2", SqlDbType.VarChar,8000),
					new SqlParameter("@huiyuan_address", SqlDbType.NVarChar,100),
					new SqlParameter("@kdname", SqlDbType.VarChar,50),
					new SqlParameter("@wlno", SqlDbType.VarChar,50),
					new SqlParameter("@mob", SqlDbType.VarChar,50),
					new SqlParameter("@huiyuan_jiedian", SqlDbType.NVarChar,50),
					new SqlParameter("@flag_18", SqlDbType.Int,4)};
            parameters[0].Value = xiaofei_id;
            parameters[1].Value = xiaofei_hui_id;
            parameters[2].Value = xiaofei_money;
            parameters[3].Value = xiaofei_pro_id;
            parameters[4].Value = xiaofei_pro_count;
            parameters[5].Value = xiaofei_flag;
            parameters[6].Value = xiaofei_flag_jiezhang;
            parameters[7].Value = xiaofei_zhuanmai;
            parameters[8].Value = xiaofei_date;
            parameters[9].Value = xiaofei_memo;
            parameters[10].Value = xiaofei_flag_jiezhang_yue;
            parameters[11].Value = xiaofei_flag_jiezhang_zhou;
            parameters[12].Value = xiaofei_flag_jiezhang_nian;
            parameters[13].Value = xiaofei_flag_jiezhang_yue_fenhong1;
            parameters[14].Value = xiaofei_flag_10;
            parameters[15].Value = zhuanmai_flag;
            parameters[16].Value = daozhang;
            parameters[17].Value = zhuangmai_wang;
            parameters[18].Value = wang_flag;
            parameters[19].Value = xiaofei_flag_jizhang_zm;
            parameters[20].Value = zhuangmai_wang_name;
            parameters[21].Value = ding_flag;
            parameters[22].Value = pro_name;
            parameters[23].Value = flag_2;
            parameters[24].Value = xiaofei_zuofei_flag;
            parameters[25].Value = xiaofei_qr_date;
            parameters[26].Value = xiaofei_qr_flag;
            parameters[27].Value = huiyuan_id;
            parameters[28].Value = huiyuan_bianhao;
            parameters[29].Value = huiyuan_name;
            parameters[30].Value = flag_5;
            parameters[31].Value = flag_1;
            parameters[32].Value = zhuanmai_jb;
            parameters[33].Value = huiyuan_zhuanmai_sq;
            parameters[34].Value = huiyuan_qr_date;
            parameters[35].Value = net_flag;
            parameters[36].Value = net_hege;
            parameters[37].Value = huiyuan_jiebie;
            parameters[38].Value = huiyuan_add_time;
            parameters[39].Value = zhuce_flag;
            parameters[40].Value = flag_11;
            parameters[41].Value = flag_a1;
            parameters[42].Value = huiyuan_zm;
            parameters[43].Value = flag_10;
            parameters[44].Value = flag_3;
            parameters[45].Value = flag_jiesuan;
            parameters[46].Value = huiyuan_shang_id;
            parameters[47].Value = xiaofei_chongfu_flag;
            parameters[48].Value = xiaofei_money1;
            parameters[49].Value = huiyuan_jiebie1;
            parameters[50].Value = huiyuan_jiebie2;
            parameters[51].Value = bid;
            parameters[52].Value = mmid;
            parameters[53].Value = sid;
            parameters[54].Value = xiaofei_zuoyou;
            parameters[55].Value = flag_15;
            parameters[56].Value = flag_12;
            parameters[57].Value = flag_13;
            parameters[58].Value = flag_14;
            parameters[59].Value = xiaofei_money2;
            parameters[60].Value = fahuo_flag;
            parameters[61].Value = huiyuan_shangshu;
            parameters[62].Value = huiyuan_shangshu2;
            parameters[63].Value = huiyuan_address;
            parameters[64].Value = kdname;
            parameters[65].Value = wlno;
            parameters[66].Value = mob;
            parameters[67].Value = huiyuan_jiedian;
            parameters[68].Value = flag_18;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update [view_xiaofei] set ");
            strSql.Append("xiaofei_id=@xiaofei_id,");
            strSql.Append("xiaofei_hui_id=@xiaofei_hui_id,");
            strSql.Append("xiaofei_money=@xiaofei_money,");
            strSql.Append("xiaofei_pro_id=@xiaofei_pro_id,");
            strSql.Append("xiaofei_pro_count=@xiaofei_pro_count,");
            strSql.Append("xiaofei_flag=@xiaofei_flag,");
            strSql.Append("xiaofei_flag_jiezhang=@xiaofei_flag_jiezhang,");
            strSql.Append("xiaofei_zhuanmai=@xiaofei_zhuanmai,");
            strSql.Append("xiaofei_date=@xiaofei_date,");
            strSql.Append("xiaofei_memo=@xiaofei_memo,");
            strSql.Append("xiaofei_flag_jiezhang_yue=@xiaofei_flag_jiezhang_yue,");
            strSql.Append("xiaofei_flag_jiezhang_zhou=@xiaofei_flag_jiezhang_zhou,");
            strSql.Append("xiaofei_flag_jiezhang_nian=@xiaofei_flag_jiezhang_nian,");
            strSql.Append("xiaofei_flag_jiezhang_yue_fenhong1=@xiaofei_flag_jiezhang_yue_fenhong1,");
            strSql.Append("xiaofei_flag_10=@xiaofei_flag_10,");
            strSql.Append("zhuanmai_flag=@zhuanmai_flag,");
            strSql.Append("daozhang=@daozhang,");
            strSql.Append("zhuangmai_wang=@zhuangmai_wang,");
            strSql.Append("wang_flag=@wang_flag,");
            strSql.Append("xiaofei_flag_jizhang_zm=@xiaofei_flag_jizhang_zm,");
            strSql.Append("zhuangmai_wang_name=@zhuangmai_wang_name,");
            strSql.Append("ding_flag=@ding_flag,");
            strSql.Append("pro_name=@pro_name,");
            strSql.Append("flag_2=@flag_2,");
            strSql.Append("xiaofei_zuofei_flag=@xiaofei_zuofei_flag,");
            strSql.Append("xiaofei_qr_date=@xiaofei_qr_date,");
            strSql.Append("xiaofei_qr_flag=@xiaofei_qr_flag,");
            strSql.Append("huiyuan_id=@huiyuan_id,");
            strSql.Append("huiyuan_bianhao=@huiyuan_bianhao,");
            strSql.Append("huiyuan_name=@huiyuan_name,");
            strSql.Append("flag_5=@flag_5,");
            strSql.Append("flag_1=@flag_1,");
            strSql.Append("zhuanmai_jb=@zhuanmai_jb,");
            strSql.Append("huiyuan_zhuanmai_sq=@huiyuan_zhuanmai_sq,");
            strSql.Append("huiyuan_qr_date=@huiyuan_qr_date,");
            strSql.Append("net_flag=@net_flag,");
            strSql.Append("net_hege=@net_hege,");
            strSql.Append("huiyuan_jiebie=@huiyuan_jiebie,");
            strSql.Append("huiyuan_add_time=@huiyuan_add_time,");
            strSql.Append("zhuce_flag=@zhuce_flag,");
            strSql.Append("flag_11=@flag_11,");
            strSql.Append("flag_a1=@flag_a1,");
            strSql.Append("huiyuan_zm=@huiyuan_zm,");
            strSql.Append("flag_10=@flag_10,");
            strSql.Append("flag_3=@flag_3,");
            strSql.Append("flag_jiesuan=@flag_jiesuan,");
            strSql.Append("huiyuan_shang_id=@huiyuan_shang_id,");
            strSql.Append("xiaofei_chongfu_flag=@xiaofei_chongfu_flag,");
            strSql.Append("xiaofei_money1=@xiaofei_money1,");
            strSql.Append("huiyuan_jiebie1=@huiyuan_jiebie1,");
            strSql.Append("huiyuan_jiebie2=@huiyuan_jiebie2,");
            strSql.Append("bid=@bid,");
            strSql.Append("mmid=@mmid,");
            strSql.Append("sid=@sid,");
            strSql.Append("xiaofei_zuoyou=@xiaofei_zuoyou,");
            strSql.Append("flag_15=@flag_15,");
            strSql.Append("flag_12=@flag_12,");
            strSql.Append("flag_13=@flag_13,");
            strSql.Append("flag_14=@flag_14,");
            strSql.Append("xiaofei_money2=@xiaofei_money2,");
            strSql.Append("fahuo_flag=@fahuo_flag,");
            strSql.Append("huiyuan_shangshu=@huiyuan_shangshu,");
            strSql.Append("huiyuan_shangshu2=@huiyuan_shangshu2,");
            strSql.Append("huiyuan_address=@huiyuan_address,");
            strSql.Append("kdname=@kdname,");
            strSql.Append("wlno=@wlno,");
            strSql.Append("mob=@mob,");
            strSql.Append("huiyuan_jiedian=@huiyuan_jiedian,");
            strSql.Append("flag_18=@flag_18");
            strSql.Append(" where xiaofei_hui_id=@xiaofei_hui_id ");
            SqlParameter[] parameters = {
					new SqlParameter("@xiaofei_id", SqlDbType.Int,4),
					new SqlParameter("@xiaofei_hui_id", SqlDbType.NVarChar,255),
					new SqlParameter("@xiaofei_money", SqlDbType.Money,8),
					new SqlParameter("@xiaofei_pro_id", SqlDbType.NVarChar,255),
					new SqlParameter("@xiaofei_pro_count", SqlDbType.Money,8),
					new SqlParameter("@xiaofei_flag", SqlDbType.Int,4),
					new SqlParameter("@xiaofei_flag_jiezhang", SqlDbType.Int,4),
					new SqlParameter("@xiaofei_zhuanmai", SqlDbType.VarChar,10),
					new SqlParameter("@xiaofei_date", SqlDbType.DateTime),
					new SqlParameter("@xiaofei_memo", SqlDbType.NVarChar,255),
					new SqlParameter("@xiaofei_flag_jiezhang_yue", SqlDbType.Int,4),
					new SqlParameter("@xiaofei_flag_jiezhang_zhou", SqlDbType.Int,4),
					new SqlParameter("@xiaofei_flag_jiezhang_nian", SqlDbType.Int,4),
					new SqlParameter("@xiaofei_flag_jiezhang_yue_fenhong1", SqlDbType.Int,4),
					new SqlParameter("@xiaofei_flag_10", SqlDbType.Int,4),
					new SqlParameter("@zhuanmai_flag", SqlDbType.Int,4),
					new SqlParameter("@daozhang", SqlDbType.Int,4),
					new SqlParameter("@zhuangmai_wang", SqlDbType.VarChar,9),
					new SqlParameter("@wang_flag", SqlDbType.Int,4),
					new SqlParameter("@xiaofei_flag_jizhang_zm", SqlDbType.Int,4),
					new SqlParameter("@zhuangmai_wang_name", SqlDbType.VarChar,50),
					new SqlParameter("@ding_flag", SqlDbType.Int,4),
					new SqlParameter("@pro_name", SqlDbType.VarChar,50),
					new SqlParameter("@flag_2", SqlDbType.Int,4),
					new SqlParameter("@xiaofei_zuofei_flag", SqlDbType.Int,4),
					new SqlParameter("@xiaofei_qr_date", SqlDbType.DateTime),
					new SqlParameter("@xiaofei_qr_flag", SqlDbType.Int,4),
					new SqlParameter("@huiyuan_id", SqlDbType.NVarChar,50),
					new SqlParameter("@huiyuan_bianhao", SqlDbType.NVarChar,50),
					new SqlParameter("@huiyuan_name", SqlDbType.NVarChar,50),
					new SqlParameter("@flag_5", SqlDbType.Int,4),
					new SqlParameter("@flag_1", SqlDbType.Int,4),
					new SqlParameter("@zhuanmai_jb", SqlDbType.Int,4),
					new SqlParameter("@huiyuan_zhuanmai_sq", SqlDbType.Int,4),
					new SqlParameter("@huiyuan_qr_date", SqlDbType.DateTime),
					new SqlParameter("@net_flag", SqlDbType.Int,4),
					new SqlParameter("@net_hege", SqlDbType.Int,4),
					new SqlParameter("@huiyuan_jiebie", SqlDbType.Int,4),
					new SqlParameter("@huiyuan_add_time", SqlDbType.DateTime),
					new SqlParameter("@zhuce_flag", SqlDbType.Int,4),
					new SqlParameter("@flag_11", SqlDbType.Int,4),
					new SqlParameter("@flag_a1", SqlDbType.Int,4),
					new SqlParameter("@huiyuan_zm", SqlDbType.NVarChar,50),
					new SqlParameter("@flag_10", SqlDbType.Int,4),
					new SqlParameter("@flag_3", SqlDbType.Int,4),
					new SqlParameter("@flag_jiesuan", SqlDbType.Int,4),
					new SqlParameter("@huiyuan_shang_id", SqlDbType.NVarChar,50),
					new SqlParameter("@xiaofei_chongfu_flag", SqlDbType.Int,4),
					new SqlParameter("@xiaofei_money1", SqlDbType.Money,8),
					new SqlParameter("@huiyuan_jiebie1", SqlDbType.Int,4),
					new SqlParameter("@huiyuan_jiebie2", SqlDbType.Int,4),
					new SqlParameter("@bid", SqlDbType.Int,4),
					new SqlParameter("@mmid", SqlDbType.Int,4),
					new SqlParameter("@sid", SqlDbType.Int,4),
					new SqlParameter("@xiaofei_zuoyou", SqlDbType.Int,4),
					new SqlParameter("@flag_15", SqlDbType.Int,4),
					new SqlParameter("@flag_12", SqlDbType.Int,4),
					new SqlParameter("@flag_13", SqlDbType.Int,4),
					new SqlParameter("@flag_14", SqlDbType.Int,4),
					new SqlParameter("@xiaofei_money2", SqlDbType.Money,8),
					new SqlParameter("@fahuo_flag", SqlDbType.Int,4),
					new SqlParameter("@huiyuan_shangshu", SqlDbType.VarChar,8000),
					new SqlParameter("@huiyuan_shangshu2", SqlDbType.VarChar,8000),
					new SqlParameter("@huiyuan_address", SqlDbType.NVarChar,100),
					new SqlParameter("@kdname", SqlDbType.VarChar,50),
					new SqlParameter("@wlno", SqlDbType.VarChar,50),
					new SqlParameter("@mob", SqlDbType.VarChar,50),
					new SqlParameter("@huiyuan_jiedian", SqlDbType.NVarChar,50),
					new SqlParameter("@flag_18", SqlDbType.Int,4)};
            parameters[0].Value = xiaofei_id;
            parameters[1].Value = xiaofei_hui_id;
            parameters[2].Value = xiaofei_money;
            parameters[3].Value = xiaofei_pro_id;
            parameters[4].Value = xiaofei_pro_count;
            parameters[5].Value = xiaofei_flag;
            parameters[6].Value = xiaofei_flag_jiezhang;
            parameters[7].Value = xiaofei_zhuanmai;
            parameters[8].Value = xiaofei_date;
            parameters[9].Value = xiaofei_memo;
            parameters[10].Value = xiaofei_flag_jiezhang_yue;
            parameters[11].Value = xiaofei_flag_jiezhang_zhou;
            parameters[12].Value = xiaofei_flag_jiezhang_nian;
            parameters[13].Value = xiaofei_flag_jiezhang_yue_fenhong1;
            parameters[14].Value = xiaofei_flag_10;
            parameters[15].Value = zhuanmai_flag;
            parameters[16].Value = daozhang;
            parameters[17].Value = zhuangmai_wang;
            parameters[18].Value = wang_flag;
            parameters[19].Value = xiaofei_flag_jizhang_zm;
            parameters[20].Value = zhuangmai_wang_name;
            parameters[21].Value = ding_flag;
            parameters[22].Value = pro_name;
            parameters[23].Value = flag_2;
            parameters[24].Value = xiaofei_zuofei_flag;
            parameters[25].Value = xiaofei_qr_date;
            parameters[26].Value = xiaofei_qr_flag;
            parameters[27].Value = huiyuan_id;
            parameters[28].Value = huiyuan_bianhao;
            parameters[29].Value = huiyuan_name;
            parameters[30].Value = flag_5;
            parameters[31].Value = flag_1;
            parameters[32].Value = zhuanmai_jb;
            parameters[33].Value = huiyuan_zhuanmai_sq;
            parameters[34].Value = huiyuan_qr_date;
            parameters[35].Value = net_flag;
            parameters[36].Value = net_hege;
            parameters[37].Value = huiyuan_jiebie;
            parameters[38].Value = huiyuan_add_time;
            parameters[39].Value = zhuce_flag;
            parameters[40].Value = flag_11;
            parameters[41].Value = flag_a1;
            parameters[42].Value = huiyuan_zm;
            parameters[43].Value = flag_10;
            parameters[44].Value = flag_3;
            parameters[45].Value = flag_jiesuan;
            parameters[46].Value = huiyuan_shang_id;
            parameters[47].Value = xiaofei_chongfu_flag;
            parameters[48].Value = xiaofei_money1;
            parameters[49].Value = huiyuan_jiebie1;
            parameters[50].Value = huiyuan_jiebie2;
            parameters[51].Value = bid;
            parameters[52].Value = mmid;
            parameters[53].Value = sid;
            parameters[54].Value = xiaofei_zuoyou;
            parameters[55].Value = flag_15;
            parameters[56].Value = flag_12;
            parameters[57].Value = flag_13;
            parameters[58].Value = flag_14;
            parameters[59].Value = xiaofei_money2;
            parameters[60].Value = fahuo_flag;
            parameters[61].Value = huiyuan_shangshu;
            parameters[62].Value = huiyuan_shangshu2;
            parameters[63].Value = huiyuan_address;
            parameters[64].Value = kdname;
            parameters[65].Value = wlno;
            parameters[66].Value = mob;
            parameters[67].Value = huiyuan_jiedian;
            parameters[68].Value = flag_18;

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
        public bool Delete(string xiaofei_hui_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from [view_xiaofei] ");
            strSql.Append(" where xiaofei_hui_id=@xiaofei_hui_id ");
            SqlParameter[] parameters = {
					new SqlParameter("@xiaofei_hui_id", SqlDbType.NVarChar,-1)};
            parameters[0].Value = xiaofei_hui_id;

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
        public void GetModel(string xiaofei_hui_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select xiaofei_id,xiaofei_hui_id,xiaofei_money,xiaofei_pro_id,xiaofei_pro_count,xiaofei_flag,xiaofei_flag_jiezhang,xiaofei_zhuanmai,xiaofei_date,xiaofei_memo,xiaofei_flag_jiezhang_yue,xiaofei_flag_jiezhang_zhou,xiaofei_flag_jiezhang_nian,xiaofei_flag_jiezhang_yue_fenhong1,xiaofei_flag_10,zhuanmai_flag,daozhang,zhuangmai_wang,wang_flag,xiaofei_flag_jizhang_zm,zhuangmai_wang_name,ding_flag,pro_name,flag_2,xiaofei_zuofei_flag,xiaofei_qr_date,xiaofei_qr_flag,huiyuan_id,huiyuan_bianhao,huiyuan_name,flag_5,flag_1,zhuanmai_jb,huiyuan_zhuanmai_sq,huiyuan_qr_date,net_flag,net_hege,huiyuan_jiebie,huiyuan_add_time,zhuce_flag,flag_11,flag_a1,huiyuan_zm,flag_10,flag_3,flag_jiesuan,huiyuan_shang_id,xiaofei_chongfu_flag,xiaofei_money1,huiyuan_jiebie1,huiyuan_jiebie2,bid,mmid,sid,xiaofei_zuoyou,flag_15,flag_12,flag_13,flag_14,xiaofei_money2,fahuo_flag,huiyuan_shangshu,huiyuan_shangshu2,huiyuan_address,kdname,wlno,mob,huiyuan_jiedian,flag_18 ");
            strSql.Append(" FROM [view_xiaofei] ");
            strSql.Append(" where xiaofei_hui_id=@xiaofei_hui_id ");
            SqlParameter[] parameters = {
					new SqlParameter("@xiaofei_hui_id", SqlDbType.NVarChar,-1)};
            parameters[0].Value = xiaofei_hui_id;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["xiaofei_id"] != null && ds.Tables[0].Rows[0]["xiaofei_id"].ToString() != "")
                {
                    this.xiaofei_id = int.Parse(ds.Tables[0].Rows[0]["xiaofei_id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xiaofei_hui_id"] != null)
                {
                    this.xiaofei_hui_id = ds.Tables[0].Rows[0]["xiaofei_hui_id"].ToString();
                }
                if (ds.Tables[0].Rows[0]["xiaofei_money"] != null && ds.Tables[0].Rows[0]["xiaofei_money"].ToString() != "")
                {
                    this.xiaofei_money = decimal.Parse(ds.Tables[0].Rows[0]["xiaofei_money"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xiaofei_pro_id"] != null)
                {
                    this.xiaofei_pro_id = ds.Tables[0].Rows[0]["xiaofei_pro_id"].ToString();
                }
                if (ds.Tables[0].Rows[0]["xiaofei_pro_count"] != null && ds.Tables[0].Rows[0]["xiaofei_pro_count"].ToString() != "")
                {
                    this.xiaofei_pro_count = decimal.Parse(ds.Tables[0].Rows[0]["xiaofei_pro_count"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xiaofei_flag"] != null && ds.Tables[0].Rows[0]["xiaofei_flag"].ToString() != "")
                {
                    this.xiaofei_flag = int.Parse(ds.Tables[0].Rows[0]["xiaofei_flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xiaofei_flag_jiezhang"] != null && ds.Tables[0].Rows[0]["xiaofei_flag_jiezhang"].ToString() != "")
                {
                    this.xiaofei_flag_jiezhang = int.Parse(ds.Tables[0].Rows[0]["xiaofei_flag_jiezhang"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xiaofei_zhuanmai"] != null)
                {
                    this.xiaofei_zhuanmai = ds.Tables[0].Rows[0]["xiaofei_zhuanmai"].ToString();
                }
                if (ds.Tables[0].Rows[0]["xiaofei_date"] != null && ds.Tables[0].Rows[0]["xiaofei_date"].ToString() != "")
                {
                    this.xiaofei_date = DateTime.Parse(ds.Tables[0].Rows[0]["xiaofei_date"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xiaofei_memo"] != null)
                {
                    this.xiaofei_memo = ds.Tables[0].Rows[0]["xiaofei_memo"].ToString();
                }
                if (ds.Tables[0].Rows[0]["xiaofei_flag_jiezhang_yue"] != null && ds.Tables[0].Rows[0]["xiaofei_flag_jiezhang_yue"].ToString() != "")
                {
                    this.xiaofei_flag_jiezhang_yue = int.Parse(ds.Tables[0].Rows[0]["xiaofei_flag_jiezhang_yue"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xiaofei_flag_jiezhang_zhou"] != null && ds.Tables[0].Rows[0]["xiaofei_flag_jiezhang_zhou"].ToString() != "")
                {
                    this.xiaofei_flag_jiezhang_zhou = int.Parse(ds.Tables[0].Rows[0]["xiaofei_flag_jiezhang_zhou"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xiaofei_flag_jiezhang_nian"] != null && ds.Tables[0].Rows[0]["xiaofei_flag_jiezhang_nian"].ToString() != "")
                {
                    this.xiaofei_flag_jiezhang_nian = int.Parse(ds.Tables[0].Rows[0]["xiaofei_flag_jiezhang_nian"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xiaofei_flag_jiezhang_yue_fenhong1"] != null && ds.Tables[0].Rows[0]["xiaofei_flag_jiezhang_yue_fenhong1"].ToString() != "")
                {
                    this.xiaofei_flag_jiezhang_yue_fenhong1 = int.Parse(ds.Tables[0].Rows[0]["xiaofei_flag_jiezhang_yue_fenhong1"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xiaofei_flag_10"] != null && ds.Tables[0].Rows[0]["xiaofei_flag_10"].ToString() != "")
                {
                    this.xiaofei_flag_10 = int.Parse(ds.Tables[0].Rows[0]["xiaofei_flag_10"].ToString());
                }
                if (ds.Tables[0].Rows[0]["zhuanmai_flag"] != null && ds.Tables[0].Rows[0]["zhuanmai_flag"].ToString() != "")
                {
                    this.zhuanmai_flag = int.Parse(ds.Tables[0].Rows[0]["zhuanmai_flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["daozhang"] != null && ds.Tables[0].Rows[0]["daozhang"].ToString() != "")
                {
                    this.daozhang = int.Parse(ds.Tables[0].Rows[0]["daozhang"].ToString());
                }
                if (ds.Tables[0].Rows[0]["zhuangmai_wang"] != null)
                {
                    this.zhuangmai_wang = ds.Tables[0].Rows[0]["zhuangmai_wang"].ToString();
                }
                if (ds.Tables[0].Rows[0]["wang_flag"] != null && ds.Tables[0].Rows[0]["wang_flag"].ToString() != "")
                {
                    this.wang_flag = int.Parse(ds.Tables[0].Rows[0]["wang_flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xiaofei_flag_jizhang_zm"] != null && ds.Tables[0].Rows[0]["xiaofei_flag_jizhang_zm"].ToString() != "")
                {
                    this.xiaofei_flag_jizhang_zm = int.Parse(ds.Tables[0].Rows[0]["xiaofei_flag_jizhang_zm"].ToString());
                }
                if (ds.Tables[0].Rows[0]["zhuangmai_wang_name"] != null)
                {
                    this.zhuangmai_wang_name = ds.Tables[0].Rows[0]["zhuangmai_wang_name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["ding_flag"] != null && ds.Tables[0].Rows[0]["ding_flag"].ToString() != "")
                {
                    this.ding_flag = int.Parse(ds.Tables[0].Rows[0]["ding_flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["pro_name"] != null)
                {
                    this.pro_name = ds.Tables[0].Rows[0]["pro_name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["flag_2"] != null && ds.Tables[0].Rows[0]["flag_2"].ToString() != "")
                {
                    this.flag_2 = int.Parse(ds.Tables[0].Rows[0]["flag_2"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xiaofei_zuofei_flag"] != null && ds.Tables[0].Rows[0]["xiaofei_zuofei_flag"].ToString() != "")
                {
                    this.xiaofei_zuofei_flag = int.Parse(ds.Tables[0].Rows[0]["xiaofei_zuofei_flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xiaofei_qr_date"] != null && ds.Tables[0].Rows[0]["xiaofei_qr_date"].ToString() != "")
                {
                    this.xiaofei_qr_date = DateTime.Parse(ds.Tables[0].Rows[0]["xiaofei_qr_date"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xiaofei_qr_flag"] != null && ds.Tables[0].Rows[0]["xiaofei_qr_flag"].ToString() != "")
                {
                    this.xiaofei_qr_flag = int.Parse(ds.Tables[0].Rows[0]["xiaofei_qr_flag"].ToString());
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
                if (ds.Tables[0].Rows[0]["flag_5"] != null && ds.Tables[0].Rows[0]["flag_5"].ToString() != "")
                {
                    this.flag_5 = int.Parse(ds.Tables[0].Rows[0]["flag_5"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_1"] != null && ds.Tables[0].Rows[0]["flag_1"].ToString() != "")
                {
                    this.flag_1 = int.Parse(ds.Tables[0].Rows[0]["flag_1"].ToString());
                }
                if (ds.Tables[0].Rows[0]["zhuanmai_jb"] != null && ds.Tables[0].Rows[0]["zhuanmai_jb"].ToString() != "")
                {
                    this.zhuanmai_jb = int.Parse(ds.Tables[0].Rows[0]["zhuanmai_jb"].ToString());
                }
                if (ds.Tables[0].Rows[0]["huiyuan_zhuanmai_sq"] != null && ds.Tables[0].Rows[0]["huiyuan_zhuanmai_sq"].ToString() != "")
                {
                    this.huiyuan_zhuanmai_sq = int.Parse(ds.Tables[0].Rows[0]["huiyuan_zhuanmai_sq"].ToString());
                }
                if (ds.Tables[0].Rows[0]["huiyuan_qr_date"] != null && ds.Tables[0].Rows[0]["huiyuan_qr_date"].ToString() != "")
                {
                    this.huiyuan_qr_date = DateTime.Parse(ds.Tables[0].Rows[0]["huiyuan_qr_date"].ToString());
                }
                if (ds.Tables[0].Rows[0]["net_flag"] != null && ds.Tables[0].Rows[0]["net_flag"].ToString() != "")
                {
                    this.net_flag = int.Parse(ds.Tables[0].Rows[0]["net_flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["net_hege"] != null && ds.Tables[0].Rows[0]["net_hege"].ToString() != "")
                {
                    this.net_hege = int.Parse(ds.Tables[0].Rows[0]["net_hege"].ToString());
                }
                if (ds.Tables[0].Rows[0]["huiyuan_jiebie"] != null && ds.Tables[0].Rows[0]["huiyuan_jiebie"].ToString() != "")
                {
                    this.huiyuan_jiebie = int.Parse(ds.Tables[0].Rows[0]["huiyuan_jiebie"].ToString());
                }
                if (ds.Tables[0].Rows[0]["huiyuan_add_time"] != null && ds.Tables[0].Rows[0]["huiyuan_add_time"].ToString() != "")
                {
                    this.huiyuan_add_time = DateTime.Parse(ds.Tables[0].Rows[0]["huiyuan_add_time"].ToString());
                }
                if (ds.Tables[0].Rows[0]["zhuce_flag"] != null && ds.Tables[0].Rows[0]["zhuce_flag"].ToString() != "")
                {
                    this.zhuce_flag = int.Parse(ds.Tables[0].Rows[0]["zhuce_flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_11"] != null && ds.Tables[0].Rows[0]["flag_11"].ToString() != "")
                {
                    this.flag_11 = int.Parse(ds.Tables[0].Rows[0]["flag_11"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_a1"] != null && ds.Tables[0].Rows[0]["flag_a1"].ToString() != "")
                {
                    this.flag_a1 = int.Parse(ds.Tables[0].Rows[0]["flag_a1"].ToString());
                }
                if (ds.Tables[0].Rows[0]["huiyuan_zm"] != null)
                {
                    this.huiyuan_zm = ds.Tables[0].Rows[0]["huiyuan_zm"].ToString();
                }
                if (ds.Tables[0].Rows[0]["flag_10"] != null && ds.Tables[0].Rows[0]["flag_10"].ToString() != "")
                {
                    this.flag_10 = int.Parse(ds.Tables[0].Rows[0]["flag_10"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_3"] != null && ds.Tables[0].Rows[0]["flag_3"].ToString() != "")
                {
                    this.flag_3 = int.Parse(ds.Tables[0].Rows[0]["flag_3"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_jiesuan"] != null && ds.Tables[0].Rows[0]["flag_jiesuan"].ToString() != "")
                {
                    this.flag_jiesuan = int.Parse(ds.Tables[0].Rows[0]["flag_jiesuan"].ToString());
                }
                if (ds.Tables[0].Rows[0]["huiyuan_shang_id"] != null)
                {
                    this.huiyuan_shang_id = ds.Tables[0].Rows[0]["huiyuan_shang_id"].ToString();
                }
                if (ds.Tables[0].Rows[0]["xiaofei_chongfu_flag"] != null && ds.Tables[0].Rows[0]["xiaofei_chongfu_flag"].ToString() != "")
                {
                    this.xiaofei_chongfu_flag = int.Parse(ds.Tables[0].Rows[0]["xiaofei_chongfu_flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xiaofei_money1"] != null && ds.Tables[0].Rows[0]["xiaofei_money1"].ToString() != "")
                {
                    this.xiaofei_money1 = decimal.Parse(ds.Tables[0].Rows[0]["xiaofei_money1"].ToString());
                }
                if (ds.Tables[0].Rows[0]["huiyuan_jiebie1"] != null && ds.Tables[0].Rows[0]["huiyuan_jiebie1"].ToString() != "")
                {
                    this.huiyuan_jiebie1 = int.Parse(ds.Tables[0].Rows[0]["huiyuan_jiebie1"].ToString());
                }
                if (ds.Tables[0].Rows[0]["huiyuan_jiebie2"] != null && ds.Tables[0].Rows[0]["huiyuan_jiebie2"].ToString() != "")
                {
                    this.huiyuan_jiebie2 = int.Parse(ds.Tables[0].Rows[0]["huiyuan_jiebie2"].ToString());
                }
                if (ds.Tables[0].Rows[0]["bid"] != null && ds.Tables[0].Rows[0]["bid"].ToString() != "")
                {
                    this.bid = int.Parse(ds.Tables[0].Rows[0]["bid"].ToString());
                }
                if (ds.Tables[0].Rows[0]["mmid"] != null && ds.Tables[0].Rows[0]["mmid"].ToString() != "")
                {
                    this.mmid = int.Parse(ds.Tables[0].Rows[0]["mmid"].ToString());
                }
                if (ds.Tables[0].Rows[0]["sid"] != null && ds.Tables[0].Rows[0]["sid"].ToString() != "")
                {
                    this.sid = int.Parse(ds.Tables[0].Rows[0]["sid"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xiaofei_zuoyou"] != null && ds.Tables[0].Rows[0]["xiaofei_zuoyou"].ToString() != "")
                {
                    this.xiaofei_zuoyou = int.Parse(ds.Tables[0].Rows[0]["xiaofei_zuoyou"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_15"] != null && ds.Tables[0].Rows[0]["flag_15"].ToString() != "")
                {
                    this.flag_15 = int.Parse(ds.Tables[0].Rows[0]["flag_15"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_12"] != null && ds.Tables[0].Rows[0]["flag_12"].ToString() != "")
                {
                    this.flag_12 = int.Parse(ds.Tables[0].Rows[0]["flag_12"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_13"] != null && ds.Tables[0].Rows[0]["flag_13"].ToString() != "")
                {
                    this.flag_13 = int.Parse(ds.Tables[0].Rows[0]["flag_13"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_14"] != null && ds.Tables[0].Rows[0]["flag_14"].ToString() != "")
                {
                    this.flag_14 = int.Parse(ds.Tables[0].Rows[0]["flag_14"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xiaofei_money2"] != null && ds.Tables[0].Rows[0]["xiaofei_money2"].ToString() != "")
                {
                    this.xiaofei_money2 = decimal.Parse(ds.Tables[0].Rows[0]["xiaofei_money2"].ToString());
                }
                if (ds.Tables[0].Rows[0]["fahuo_flag"] != null && ds.Tables[0].Rows[0]["fahuo_flag"].ToString() != "")
                {
                    this.fahuo_flag = int.Parse(ds.Tables[0].Rows[0]["fahuo_flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["huiyuan_shangshu"] != null)
                {
                    this.huiyuan_shangshu = ds.Tables[0].Rows[0]["huiyuan_shangshu"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_shangshu2"] != null)
                {
                    this.huiyuan_shangshu2 = ds.Tables[0].Rows[0]["huiyuan_shangshu2"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_address"] != null)
                {
                    this.huiyuan_address = ds.Tables[0].Rows[0]["huiyuan_address"].ToString();
                }
                if (ds.Tables[0].Rows[0]["kdname"] != null)
                {
                    this.kdname = ds.Tables[0].Rows[0]["kdname"].ToString();
                }
                if (ds.Tables[0].Rows[0]["wlno"] != null)
                {
                    this.wlno = ds.Tables[0].Rows[0]["wlno"].ToString();
                }
                if (ds.Tables[0].Rows[0]["mob"] != null)
                {
                    this.mob = ds.Tables[0].Rows[0]["mob"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_jiedian"] != null)
                {
                    this.huiyuan_jiedian = ds.Tables[0].Rows[0]["huiyuan_jiedian"].ToString();
                }
                if (ds.Tables[0].Rows[0]["flag_18"] != null && ds.Tables[0].Rows[0]["flag_18"].ToString() != "")
                {
                    this.flag_18 = int.Parse(ds.Tables[0].Rows[0]["flag_18"].ToString());
                }
            }
        }

        /// <summary>
        /// 获得查询分页数据
        /// </summary>
        public DataSet GetList(int pageSize, int pageIndex, string strWhere, string filedOrder, out int recordCount)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * FROM  view_xiaofei");
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
            strSql.Append("select top 1 " + Title + " as sumcode from [view_xiaofei]");
            strSql.Append(" where " + strWhere);
            string title = Convert.ToString(DbHelperSQL.GetSingle(strSql.ToString()));
            if (string.IsNullOrEmpty(title))
            {
                return "0";
            }
            return title;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM [view_xiaofei] ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion  Method
    }
 

