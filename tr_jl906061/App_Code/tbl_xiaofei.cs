using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
 
 
    /// <summary>
    /// 类tbl_xiaofei。
    /// </summary>
    [Serializable]
    public partial class tbl_xiaofei
    {
        public tbl_xiaofei()
        { }
        #region Model
        private int _xiaofei_id;
        private string _xiaofei_hui_id;
        private decimal? _xiaofei_money = 0M;
        private string _xiaofei_pro_id;
        private decimal? _xiaofei_pro_count = 0M;
        private int? _xiaofei_flag = 1;
        private int? _xiaofei_flag_jiezhang = 0;
        private string _xiaofei_memo;
        private string _xiaofei_zhuanmai;
        private DateTime? _xiaofei_date = DateTime.Now;
        private int? _xiaofei_flag_jiezhang_zhou = 0;
        private int? _xiaofei_flag_jiezhang_yue = 0;
        private int? _xiaofei_flag_jiezhang_nian = 0;
        private int? _xiaofei_flag_jiezhang_yue_fenhong1 = 0;
        private int? _xiaofei_chongfu_flag = 0;
        private int? _xiaofei_chongfu = 0;
        private int? _xiaofei_flag_10 = 0;
        private int? _zhuanmai_flag = 0;
        private string _zhuangmai_wang;
        private int? _wang_flag = 0;
        private int? _daozhang = 0;
        private int? _xiaofei_flag_jizhang_zm = 0;
        private string _zhuangmai_wang_name;
        private string _dingdan_hao;
        private int? _ding_flag = 0;
        private int? _flag_2 = 0;
        private DateTime? _xiaofei_qr_date;
        private int? _xiaofei_zuofei_flag = 0;
        private int? _xiaofei_qr_flag = 0;
        private int? _zhuce_flag = 0;
        private int? _flag_3 = 0;
        private int? _flag_a1 = 0;
        private int? _flag_11 = 0;
        private int? _flag_10 = 0;
        private int? _flag_jiesuan = 0;
        private int? _fahuo_flag = 0;
        private DateTime? _fahuo_date;
        private string _queren_man;
        private decimal? _xiaofei_money1 = 0M;
        private string _kdname;
        private string _wlno;
        private string _photo;
        private string _ren;
        private string _mob;
        private int? _xiaofei_zuoyou = 0;
        private int? _flag_15 = 0;
        private int? _flag_12 = 0;
        private int? _flag_13 = 0;
        private int? _flag_14 = 0;
        private int? _is_flag = 0;
        private int? _jiebie = 0;
        private string _address;
        private string _name;
        private string _phone;
        private string _post;
        private decimal? _pro_yunfei = 0M;
        private decimal? _xiaofei_money2 = 0M;
        private string _orders;
        private string _order_no;
        private decimal? _zhikou;
        private string _memo;
        private int? _flag_17 = 0;
        private decimal? _fh_money = 0M;
        /// <summary>
        /// 
        /// </summary>
        public int xiaofei_id
        {
            set { _xiaofei_id = value; }
            get { return _xiaofei_id; }
        }
        /// <summary>
        /// 消费会员id
        /// </summary>
        public string xiaofei_hui_id
        {
            set { _xiaofei_hui_id = value; }
            get { return _xiaofei_hui_id; }
        }
        /// <summary>
        /// 消费总金额
        /// </summary>
        public decimal? xiaofei_money
        {
            set { _xiaofei_money = value; }
            get { return _xiaofei_money; }
        }
        /// <summary>
        /// 消费 产品id
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
        public string xiaofei_memo
        {
            set { _xiaofei_memo = value; }
            get { return _xiaofei_memo; }
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
        /// 消费时间
        /// </summary>
        public DateTime? xiaofei_date
        {
            set { _xiaofei_date = value; }
            get { return _xiaofei_date; }
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
        public int? xiaofei_flag_jiezhang_yue
        {
            set { _xiaofei_flag_jiezhang_yue = value; }
            get { return _xiaofei_flag_jiezhang_yue; }
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
        public int? xiaofei_chongfu_flag
        {
            set { _xiaofei_chongfu_flag = value; }
            get { return _xiaofei_chongfu_flag; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? xiaofei_chongfu
        {
            set { _xiaofei_chongfu = value; }
            get { return _xiaofei_chongfu; }
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
        public int? daozhang
        {
            set { _daozhang = value; }
            get { return _daozhang; }
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
        public string dingdan_hao
        {
            set { _dingdan_hao = value; }
            get { return _dingdan_hao; }
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
        public int? flag_2
        {
            set { _flag_2 = value; }
            get { return _flag_2; }
        }
        /// <summary>
        /// 消费确认时间
        /// </summary>
        public DateTime? xiaofei_qr_date
        {
            set { _xiaofei_qr_date = value; }
            get { return _xiaofei_qr_date; }
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
        /// 是否生效
        /// </summary>
        public int? xiaofei_qr_flag
        {
            set { _xiaofei_qr_flag = value; }
            get { return _xiaofei_qr_flag; }
        }
        /// <summary>
        /// 注册单或零售单
        /// </summary>
        public int? zhuce_flag
        {
            set { _zhuce_flag = value; }
            get { return _zhuce_flag; }
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
        public int? flag_a1
        {
            set { _flag_a1 = value; }
            get { return _flag_a1; }
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
        public int? flag_10
        {
            set { _flag_10 = value; }
            get { return _flag_10; }
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
        public int? fahuo_flag
        {
            set { _fahuo_flag = value; }
            get { return _fahuo_flag; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? fahuo_date
        {
            set { _fahuo_date = value; }
            get { return _fahuo_date; }
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
        public decimal? xiaofei_money1
        {
            set { _xiaofei_money1 = value; }
            get { return _xiaofei_money1; }
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
        public string photo
        {
            set { _photo = value; }
            get { return _photo; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ren
        {
            set { _ren = value; }
            get { return _ren; }
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
        public int? is_flag
        {
            set { _is_flag = value; }
            get { return _is_flag; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? jiebie
        {
            set { _jiebie = value; }
            get { return _jiebie; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string address
        {
            set { _address = value; }
            get { return _address; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string name
        {
            set { _name = value; }
            get { return _name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string phone
        {
            set { _phone = value; }
            get { return _phone; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string post
        {
            set { _post = value; }
            get { return _post; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? pro_yunfei
        {
            set { _pro_yunfei = value; }
            get { return _pro_yunfei; }
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
        public string orders
        {
            set { _orders = value; }
            get { return _orders; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string order_no
        {
            set { _order_no = value; }
            get { return _order_no; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? zhikou
        {
            set { _zhikou = value; }
            get { return _zhikou; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string memo
        {
            set { _memo = value; }
            get { return _memo; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? flag_17
        {
            set { _flag_17 = value; }
            get { return _flag_17; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? fh_money
        {
            set { _fh_money = value; }
            get { return _fh_money; }
        }
        #endregion Model


        #region  Method

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public tbl_xiaofei(int xiaofei_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select xiaofei_id,xiaofei_hui_id,xiaofei_money,xiaofei_pro_id,xiaofei_pro_count,xiaofei_flag,xiaofei_flag_jiezhang,xiaofei_memo,xiaofei_zhuanmai,xiaofei_date,xiaofei_flag_jiezhang_zhou,xiaofei_flag_jiezhang_yue,xiaofei_flag_jiezhang_nian,xiaofei_flag_jiezhang_yue_fenhong1,xiaofei_chongfu_flag,xiaofei_chongfu,xiaofei_flag_10,zhuanmai_flag,zhuangmai_wang,wang_flag,daozhang,xiaofei_flag_jizhang_zm,zhuangmai_wang_name,dingdan_hao,ding_flag,flag_2,xiaofei_qr_date,xiaofei_zuofei_flag,xiaofei_qr_flag,zhuce_flag,flag_3,flag_a1,flag_11,flag_10,flag_jiesuan,fahuo_flag,fahuo_date,queren_man,xiaofei_money1,kdname,wlno,photo,ren,mob,xiaofei_zuoyou,flag_15,flag_12,flag_13,flag_14,is_flag,jiebie,address,name,phone,post,pro_yunfei,xiaofei_money2,orders,order_no,zhikou,memo,flag_17,fh_money ");
            strSql.Append(" FROM [tbl_xiaofei] ");
            strSql.Append(" where xiaofei_id=@xiaofei_id ");
            SqlParameter[] parameters = {
					new SqlParameter("@xiaofei_id", SqlDbType.Int,4)};
            parameters[0].Value = xiaofei_id;

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
                if (ds.Tables[0].Rows[0]["xiaofei_memo"] != null)
                {
                    this.xiaofei_memo = ds.Tables[0].Rows[0]["xiaofei_memo"].ToString();
                }
                if (ds.Tables[0].Rows[0]["xiaofei_zhuanmai"] != null)
                {
                    this.xiaofei_zhuanmai = ds.Tables[0].Rows[0]["xiaofei_zhuanmai"].ToString();
                }
                if (ds.Tables[0].Rows[0]["xiaofei_date"] != null && ds.Tables[0].Rows[0]["xiaofei_date"].ToString() != "")
                {
                    this.xiaofei_date = DateTime.Parse(ds.Tables[0].Rows[0]["xiaofei_date"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xiaofei_flag_jiezhang_zhou"] != null && ds.Tables[0].Rows[0]["xiaofei_flag_jiezhang_zhou"].ToString() != "")
                {
                    this.xiaofei_flag_jiezhang_zhou = int.Parse(ds.Tables[0].Rows[0]["xiaofei_flag_jiezhang_zhou"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xiaofei_flag_jiezhang_yue"] != null && ds.Tables[0].Rows[0]["xiaofei_flag_jiezhang_yue"].ToString() != "")
                {
                    this.xiaofei_flag_jiezhang_yue = int.Parse(ds.Tables[0].Rows[0]["xiaofei_flag_jiezhang_yue"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xiaofei_flag_jiezhang_nian"] != null && ds.Tables[0].Rows[0]["xiaofei_flag_jiezhang_nian"].ToString() != "")
                {
                    this.xiaofei_flag_jiezhang_nian = int.Parse(ds.Tables[0].Rows[0]["xiaofei_flag_jiezhang_nian"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xiaofei_flag_jiezhang_yue_fenhong1"] != null && ds.Tables[0].Rows[0]["xiaofei_flag_jiezhang_yue_fenhong1"].ToString() != "")
                {
                    this.xiaofei_flag_jiezhang_yue_fenhong1 = int.Parse(ds.Tables[0].Rows[0]["xiaofei_flag_jiezhang_yue_fenhong1"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xiaofei_chongfu_flag"] != null && ds.Tables[0].Rows[0]["xiaofei_chongfu_flag"].ToString() != "")
                {
                    this.xiaofei_chongfu_flag = int.Parse(ds.Tables[0].Rows[0]["xiaofei_chongfu_flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xiaofei_chongfu"] != null && ds.Tables[0].Rows[0]["xiaofei_chongfu"].ToString() != "")
                {
                    this.xiaofei_chongfu = int.Parse(ds.Tables[0].Rows[0]["xiaofei_chongfu"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xiaofei_flag_10"] != null && ds.Tables[0].Rows[0]["xiaofei_flag_10"].ToString() != "")
                {
                    this.xiaofei_flag_10 = int.Parse(ds.Tables[0].Rows[0]["xiaofei_flag_10"].ToString());
                }
                if (ds.Tables[0].Rows[0]["zhuanmai_flag"] != null && ds.Tables[0].Rows[0]["zhuanmai_flag"].ToString() != "")
                {
                    this.zhuanmai_flag = int.Parse(ds.Tables[0].Rows[0]["zhuanmai_flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["zhuangmai_wang"] != null)
                {
                    this.zhuangmai_wang = ds.Tables[0].Rows[0]["zhuangmai_wang"].ToString();
                }
                if (ds.Tables[0].Rows[0]["wang_flag"] != null && ds.Tables[0].Rows[0]["wang_flag"].ToString() != "")
                {
                    this.wang_flag = int.Parse(ds.Tables[0].Rows[0]["wang_flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["daozhang"] != null && ds.Tables[0].Rows[0]["daozhang"].ToString() != "")
                {
                    this.daozhang = int.Parse(ds.Tables[0].Rows[0]["daozhang"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xiaofei_flag_jizhang_zm"] != null && ds.Tables[0].Rows[0]["xiaofei_flag_jizhang_zm"].ToString() != "")
                {
                    this.xiaofei_flag_jizhang_zm = int.Parse(ds.Tables[0].Rows[0]["xiaofei_flag_jizhang_zm"].ToString());
                }
                if (ds.Tables[0].Rows[0]["zhuangmai_wang_name"] != null)
                {
                    this.zhuangmai_wang_name = ds.Tables[0].Rows[0]["zhuangmai_wang_name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["dingdan_hao"] != null)
                {
                    this.dingdan_hao = ds.Tables[0].Rows[0]["dingdan_hao"].ToString();
                }
                if (ds.Tables[0].Rows[0]["ding_flag"] != null && ds.Tables[0].Rows[0]["ding_flag"].ToString() != "")
                {
                    this.ding_flag = int.Parse(ds.Tables[0].Rows[0]["ding_flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_2"] != null && ds.Tables[0].Rows[0]["flag_2"].ToString() != "")
                {
                    this.flag_2 = int.Parse(ds.Tables[0].Rows[0]["flag_2"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xiaofei_qr_date"] != null && ds.Tables[0].Rows[0]["xiaofei_qr_date"].ToString() != "")
                {
                    this.xiaofei_qr_date = DateTime.Parse(ds.Tables[0].Rows[0]["xiaofei_qr_date"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xiaofei_zuofei_flag"] != null && ds.Tables[0].Rows[0]["xiaofei_zuofei_flag"].ToString() != "")
                {
                    this.xiaofei_zuofei_flag = int.Parse(ds.Tables[0].Rows[0]["xiaofei_zuofei_flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xiaofei_qr_flag"] != null && ds.Tables[0].Rows[0]["xiaofei_qr_flag"].ToString() != "")
                {
                    this.xiaofei_qr_flag = int.Parse(ds.Tables[0].Rows[0]["xiaofei_qr_flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["zhuce_flag"] != null && ds.Tables[0].Rows[0]["zhuce_flag"].ToString() != "")
                {
                    this.zhuce_flag = int.Parse(ds.Tables[0].Rows[0]["zhuce_flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_3"] != null && ds.Tables[0].Rows[0]["flag_3"].ToString() != "")
                {
                    this.flag_3 = int.Parse(ds.Tables[0].Rows[0]["flag_3"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_a1"] != null && ds.Tables[0].Rows[0]["flag_a1"].ToString() != "")
                {
                    this.flag_a1 = int.Parse(ds.Tables[0].Rows[0]["flag_a1"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_11"] != null && ds.Tables[0].Rows[0]["flag_11"].ToString() != "")
                {
                    this.flag_11 = int.Parse(ds.Tables[0].Rows[0]["flag_11"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_10"] != null && ds.Tables[0].Rows[0]["flag_10"].ToString() != "")
                {
                    this.flag_10 = int.Parse(ds.Tables[0].Rows[0]["flag_10"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_jiesuan"] != null && ds.Tables[0].Rows[0]["flag_jiesuan"].ToString() != "")
                {
                    this.flag_jiesuan = int.Parse(ds.Tables[0].Rows[0]["flag_jiesuan"].ToString());
                }
                if (ds.Tables[0].Rows[0]["fahuo_flag"] != null && ds.Tables[0].Rows[0]["fahuo_flag"].ToString() != "")
                {
                    this.fahuo_flag = int.Parse(ds.Tables[0].Rows[0]["fahuo_flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["fahuo_date"] != null && ds.Tables[0].Rows[0]["fahuo_date"].ToString() != "")
                {
                    this.fahuo_date = DateTime.Parse(ds.Tables[0].Rows[0]["fahuo_date"].ToString());
                }
                if (ds.Tables[0].Rows[0]["queren_man"] != null)
                {
                    this.queren_man = ds.Tables[0].Rows[0]["queren_man"].ToString();
                }
                if (ds.Tables[0].Rows[0]["xiaofei_money1"] != null && ds.Tables[0].Rows[0]["xiaofei_money1"].ToString() != "")
                {
                    this.xiaofei_money1 = decimal.Parse(ds.Tables[0].Rows[0]["xiaofei_money1"].ToString());
                }
                if (ds.Tables[0].Rows[0]["kdname"] != null)
                {
                    this.kdname = ds.Tables[0].Rows[0]["kdname"].ToString();
                }
                if (ds.Tables[0].Rows[0]["wlno"] != null)
                {
                    this.wlno = ds.Tables[0].Rows[0]["wlno"].ToString();
                }
                if (ds.Tables[0].Rows[0]["photo"] != null)
                {
                    this.photo = ds.Tables[0].Rows[0]["photo"].ToString();
                }
                if (ds.Tables[0].Rows[0]["ren"] != null)
                {
                    this.ren = ds.Tables[0].Rows[0]["ren"].ToString();
                }
                if (ds.Tables[0].Rows[0]["mob"] != null)
                {
                    this.mob = ds.Tables[0].Rows[0]["mob"].ToString();
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
                if (ds.Tables[0].Rows[0]["is_flag"] != null && ds.Tables[0].Rows[0]["is_flag"].ToString() != "")
                {
                    this.is_flag = int.Parse(ds.Tables[0].Rows[0]["is_flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["jiebie"] != null && ds.Tables[0].Rows[0]["jiebie"].ToString() != "")
                {
                    this.jiebie = int.Parse(ds.Tables[0].Rows[0]["jiebie"].ToString());
                }
                if (ds.Tables[0].Rows[0]["address"] != null)
                {
                    this.address = ds.Tables[0].Rows[0]["address"].ToString();
                }
                if (ds.Tables[0].Rows[0]["name"] != null)
                {
                    this.name = ds.Tables[0].Rows[0]["name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["phone"] != null)
                {
                    this.phone = ds.Tables[0].Rows[0]["phone"].ToString();
                }
                if (ds.Tables[0].Rows[0]["post"] != null)
                {
                    this.post = ds.Tables[0].Rows[0]["post"].ToString();
                }
                if (ds.Tables[0].Rows[0]["pro_yunfei"] != null && ds.Tables[0].Rows[0]["pro_yunfei"].ToString() != "")
                {
                    this.pro_yunfei = decimal.Parse(ds.Tables[0].Rows[0]["pro_yunfei"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xiaofei_money2"] != null && ds.Tables[0].Rows[0]["xiaofei_money2"].ToString() != "")
                {
                    this.xiaofei_money2 = decimal.Parse(ds.Tables[0].Rows[0]["xiaofei_money2"].ToString());
                }
                if (ds.Tables[0].Rows[0]["orders"] != null)
                {
                    this.orders = ds.Tables[0].Rows[0]["orders"].ToString();
                }
                if (ds.Tables[0].Rows[0]["order_no"] != null)
                {
                    this.order_no = ds.Tables[0].Rows[0]["order_no"].ToString();
                }
                if (ds.Tables[0].Rows[0]["zhikou"] != null && ds.Tables[0].Rows[0]["zhikou"].ToString() != "")
                {
                    this.zhikou = decimal.Parse(ds.Tables[0].Rows[0]["zhikou"].ToString());
                }
                if (ds.Tables[0].Rows[0]["memo"] != null)
                {
                    this.memo = ds.Tables[0].Rows[0]["memo"].ToString();
                }
                if (ds.Tables[0].Rows[0]["flag_17"] != null && ds.Tables[0].Rows[0]["flag_17"].ToString() != "")
                {
                    this.flag_17 = int.Parse(ds.Tables[0].Rows[0]["flag_17"].ToString());
                }
                if (ds.Tables[0].Rows[0]["fh_money"] != null && ds.Tables[0].Rows[0]["fh_money"].ToString() != "")
                {
                    this.fh_money = decimal.Parse(ds.Tables[0].Rows[0]["fh_money"].ToString());
                }
            }
        }
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int xiaofei_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from [tbl_xiaofei]");
            strSql.Append(" where xiaofei_id=@xiaofei_id ");

            SqlParameter[] parameters = {
					new SqlParameter("@xiaofei_id", SqlDbType.Int,4)};
            parameters[0].Value = xiaofei_id;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 获取总投资额
        /// </summary>
        public decimal zong_yeji(string xiaofei_hui_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select isnull(sum(xiaofei_money),0) as xiaofei_money from [tbl_xiaofei]");
            strSql.Append(" where xiaofei_hui_id=@xiaofei_hui_id and xiaofei_qr_flag=1");

            SqlParameter[] parameters = {
					new SqlParameter("@xiaofei_hui_id", SqlDbType.VarChar,50)};
            parameters[0].Value = xiaofei_hui_id;

             DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
           
            return decimal.Parse(ds.Tables[0].Rows[0]["xiaofei_money"].ToString());
         
        }
        /// <summary>
        /// 获取总投资额
        /// </summary>
        public decimal zong_yeji11(string xiaofei_hui_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select isnull(sum(xiaofei_money),0) as xiaofei_money from [tbl_xiaofei]");
            strSql.Append(" where xiaofei_hui_id=@xiaofei_hui_id and xiaofei_qr_flag=1 and zhuce_flag<>3");

            SqlParameter[] parameters = {
					new SqlParameter("@xiaofei_hui_id", SqlDbType.VarChar,50)};
            parameters[0].Value = xiaofei_hui_id;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);

            return decimal.Parse(ds.Tables[0].Rows[0]["xiaofei_money"].ToString());

        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into [tbl_xiaofei] (");
            strSql.Append("xiaofei_hui_id,xiaofei_money,xiaofei_pro_id,xiaofei_pro_count,xiaofei_flag,xiaofei_flag_jiezhang,xiaofei_memo,xiaofei_zhuanmai,xiaofei_date,xiaofei_flag_jiezhang_zhou,xiaofei_flag_jiezhang_yue,xiaofei_flag_jiezhang_nian,xiaofei_flag_jiezhang_yue_fenhong1,xiaofei_chongfu_flag,xiaofei_chongfu,xiaofei_flag_10,zhuanmai_flag,zhuangmai_wang,wang_flag,daozhang,xiaofei_flag_jizhang_zm,zhuangmai_wang_name,dingdan_hao,ding_flag,flag_2,xiaofei_qr_date,xiaofei_zuofei_flag,xiaofei_qr_flag,zhuce_flag,flag_3,flag_a1,flag_11,flag_10,flag_jiesuan,fahuo_flag,fahuo_date,queren_man,xiaofei_money1,kdname,wlno,photo,ren,mob,xiaofei_zuoyou,flag_15,flag_12,flag_13,flag_14,is_flag,jiebie,address,name,phone,post,pro_yunfei,xiaofei_money2,orders,order_no,zhikou,memo,flag_17,fh_money)");
            strSql.Append(" values (");
            strSql.Append("@xiaofei_hui_id,@xiaofei_money,@xiaofei_pro_id,@xiaofei_pro_count,@xiaofei_flag,@xiaofei_flag_jiezhang,@xiaofei_memo,@xiaofei_zhuanmai,@xiaofei_date,@xiaofei_flag_jiezhang_zhou,@xiaofei_flag_jiezhang_yue,@xiaofei_flag_jiezhang_nian,@xiaofei_flag_jiezhang_yue_fenhong1,@xiaofei_chongfu_flag,@xiaofei_chongfu,@xiaofei_flag_10,@zhuanmai_flag,@zhuangmai_wang,@wang_flag,@daozhang,@xiaofei_flag_jizhang_zm,@zhuangmai_wang_name,@dingdan_hao,@ding_flag,@flag_2,@xiaofei_qr_date,@xiaofei_zuofei_flag,@xiaofei_qr_flag,@zhuce_flag,@flag_3,@flag_a1,@flag_11,@flag_10,@flag_jiesuan,@fahuo_flag,@fahuo_date,@queren_man,@xiaofei_money1,@kdname,@wlno,@photo,@ren,@mob,@xiaofei_zuoyou,@flag_15,@flag_12,@flag_13,@flag_14,@is_flag,@jiebie,@address,@name,@phone,@post,@pro_yunfei,@xiaofei_money2,@orders,@order_no,@zhikou,@memo,@flag_17,@fh_money)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@xiaofei_hui_id", SqlDbType.NVarChar,255),
					new SqlParameter("@xiaofei_money", SqlDbType.Money,8),
					new SqlParameter("@xiaofei_pro_id", SqlDbType.NVarChar,255),
					new SqlParameter("@xiaofei_pro_count", SqlDbType.Money,8),
					new SqlParameter("@xiaofei_flag", SqlDbType.Int,4),
					new SqlParameter("@xiaofei_flag_jiezhang", SqlDbType.Int,4),
					new SqlParameter("@xiaofei_memo", SqlDbType.NVarChar,255),
					new SqlParameter("@xiaofei_zhuanmai", SqlDbType.VarChar,10),
					new SqlParameter("@xiaofei_date", SqlDbType.DateTime),
					new SqlParameter("@xiaofei_flag_jiezhang_zhou", SqlDbType.Int,4),
					new SqlParameter("@xiaofei_flag_jiezhang_yue", SqlDbType.Int,4),
					new SqlParameter("@xiaofei_flag_jiezhang_nian", SqlDbType.Int,4),
					new SqlParameter("@xiaofei_flag_jiezhang_yue_fenhong1", SqlDbType.Int,4),
					new SqlParameter("@xiaofei_chongfu_flag", SqlDbType.Int,4),
					new SqlParameter("@xiaofei_chongfu", SqlDbType.Int,4),
					new SqlParameter("@xiaofei_flag_10", SqlDbType.Int,4),
					new SqlParameter("@zhuanmai_flag", SqlDbType.Int,4),
					new SqlParameter("@zhuangmai_wang", SqlDbType.VarChar,9),
					new SqlParameter("@wang_flag", SqlDbType.Int,4),
					new SqlParameter("@daozhang", SqlDbType.Int,4),
					new SqlParameter("@xiaofei_flag_jizhang_zm", SqlDbType.Int,4),
					new SqlParameter("@zhuangmai_wang_name", SqlDbType.VarChar,50),
					new SqlParameter("@dingdan_hao", SqlDbType.VarChar,50),
					new SqlParameter("@ding_flag", SqlDbType.Int,4),
					new SqlParameter("@flag_2", SqlDbType.Int,4),
					new SqlParameter("@xiaofei_qr_date", SqlDbType.DateTime),
					new SqlParameter("@xiaofei_zuofei_flag", SqlDbType.Int,4),
					new SqlParameter("@xiaofei_qr_flag", SqlDbType.Int,4),
					new SqlParameter("@zhuce_flag", SqlDbType.Int,4),
					new SqlParameter("@flag_3", SqlDbType.Int,4),
					new SqlParameter("@flag_a1", SqlDbType.Int,4),
					new SqlParameter("@flag_11", SqlDbType.Int,4),
					new SqlParameter("@flag_10", SqlDbType.Int,4),
					new SqlParameter("@flag_jiesuan", SqlDbType.Int,4),
					new SqlParameter("@fahuo_flag", SqlDbType.Int,4),
					new SqlParameter("@fahuo_date", SqlDbType.DateTime),
					new SqlParameter("@queren_man", SqlDbType.VarChar,50),
					new SqlParameter("@xiaofei_money1", SqlDbType.Money,8),
					new SqlParameter("@kdname", SqlDbType.VarChar,50),
					new SqlParameter("@wlno", SqlDbType.VarChar,50),
					new SqlParameter("@photo", SqlDbType.VarChar,50),
					new SqlParameter("@ren", SqlDbType.VarChar,50),
					new SqlParameter("@mob", SqlDbType.VarChar,50),
					new SqlParameter("@xiaofei_zuoyou", SqlDbType.Int,4),
					new SqlParameter("@flag_15", SqlDbType.Int,4),
					new SqlParameter("@flag_12", SqlDbType.Int,4),
					new SqlParameter("@flag_13", SqlDbType.Int,4),
					new SqlParameter("@flag_14", SqlDbType.Int,4),
					new SqlParameter("@is_flag", SqlDbType.Int,4),
					new SqlParameter("@jiebie", SqlDbType.Int,4),
					new SqlParameter("@address", SqlDbType.VarChar,50),
					new SqlParameter("@name", SqlDbType.VarChar,50),
					new SqlParameter("@phone", SqlDbType.VarChar,50),
					new SqlParameter("@post", SqlDbType.VarChar,50),
					new SqlParameter("@pro_yunfei", SqlDbType.Money,8),
					new SqlParameter("@xiaofei_money2", SqlDbType.Money,8),
					new SqlParameter("@orders", SqlDbType.VarChar,200),
					new SqlParameter("@order_no", SqlDbType.VarChar,200),
					new SqlParameter("@zhikou", SqlDbType.Money,8),
					new SqlParameter("@memo", SqlDbType.Text),
					new SqlParameter("@flag_17", SqlDbType.Int,4),
					new SqlParameter("@fh_money", SqlDbType.Money,8)};
            parameters[0].Value = xiaofei_hui_id;
            parameters[1].Value = xiaofei_money;
            parameters[2].Value = xiaofei_pro_id;
            parameters[3].Value = xiaofei_pro_count;
            parameters[4].Value = xiaofei_flag;
            parameters[5].Value = xiaofei_flag_jiezhang;
            parameters[6].Value = xiaofei_memo;
            parameters[7].Value = xiaofei_zhuanmai;
            parameters[8].Value = xiaofei_date;
            parameters[9].Value = xiaofei_flag_jiezhang_zhou;
            parameters[10].Value = xiaofei_flag_jiezhang_yue;
            parameters[11].Value = xiaofei_flag_jiezhang_nian;
            parameters[12].Value = xiaofei_flag_jiezhang_yue_fenhong1;
            parameters[13].Value = xiaofei_chongfu_flag;
            parameters[14].Value = xiaofei_chongfu;
            parameters[15].Value = xiaofei_flag_10;
            parameters[16].Value = zhuanmai_flag;
            parameters[17].Value = zhuangmai_wang;
            parameters[18].Value = wang_flag;
            parameters[19].Value = daozhang;
            parameters[20].Value = xiaofei_flag_jizhang_zm;
            parameters[21].Value = zhuangmai_wang_name;
            parameters[22].Value = dingdan_hao;
            parameters[23].Value = ding_flag;
            parameters[24].Value = flag_2;
            parameters[25].Value = xiaofei_qr_date;
            parameters[26].Value = xiaofei_zuofei_flag;
            parameters[27].Value = xiaofei_qr_flag;
            parameters[28].Value = zhuce_flag;
            parameters[29].Value = flag_3;
            parameters[30].Value = flag_a1;
            parameters[31].Value = flag_11;
            parameters[32].Value = flag_10;
            parameters[33].Value = flag_jiesuan;
            parameters[34].Value = fahuo_flag;
            parameters[35].Value = fahuo_date;
            parameters[36].Value = queren_man;
            parameters[37].Value = xiaofei_money1;
            parameters[38].Value = kdname;
            parameters[39].Value = wlno;
            parameters[40].Value = photo;
            parameters[41].Value = ren;
            parameters[42].Value = mob;
            parameters[43].Value = xiaofei_zuoyou;
            parameters[44].Value = flag_15;
            parameters[45].Value = flag_12;
            parameters[46].Value = flag_13;
            parameters[47].Value = flag_14;
            parameters[48].Value = is_flag;
            parameters[49].Value = jiebie;
            parameters[50].Value = address;
            parameters[51].Value = name;
            parameters[52].Value = phone;
            parameters[53].Value = post;
            parameters[54].Value = pro_yunfei;
            parameters[55].Value = xiaofei_money2;
            parameters[56].Value = orders;
            parameters[57].Value = order_no;
            parameters[58].Value = zhikou;
            parameters[59].Value = memo;
            parameters[60].Value = flag_17;
            parameters[61].Value = fh_money;

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
            strSql.Append("update [tbl_xiaofei] set ");
            strSql.Append("xiaofei_hui_id=@xiaofei_hui_id,");
            strSql.Append("xiaofei_money=@xiaofei_money,");
            strSql.Append("xiaofei_pro_id=@xiaofei_pro_id,");
            strSql.Append("xiaofei_pro_count=@xiaofei_pro_count,");
            strSql.Append("xiaofei_flag=@xiaofei_flag,");
            strSql.Append("xiaofei_flag_jiezhang=@xiaofei_flag_jiezhang,");
            strSql.Append("xiaofei_memo=@xiaofei_memo,");
            strSql.Append("xiaofei_zhuanmai=@xiaofei_zhuanmai,");
            strSql.Append("xiaofei_date=@xiaofei_date,");
            strSql.Append("xiaofei_flag_jiezhang_zhou=@xiaofei_flag_jiezhang_zhou,");
            strSql.Append("xiaofei_flag_jiezhang_yue=@xiaofei_flag_jiezhang_yue,");
            strSql.Append("xiaofei_flag_jiezhang_nian=@xiaofei_flag_jiezhang_nian,");
            strSql.Append("xiaofei_flag_jiezhang_yue_fenhong1=@xiaofei_flag_jiezhang_yue_fenhong1,");
            strSql.Append("xiaofei_chongfu_flag=@xiaofei_chongfu_flag,");
            strSql.Append("xiaofei_chongfu=@xiaofei_chongfu,");
            strSql.Append("xiaofei_flag_10=@xiaofei_flag_10,");
            strSql.Append("zhuanmai_flag=@zhuanmai_flag,");
            strSql.Append("zhuangmai_wang=@zhuangmai_wang,");
            strSql.Append("wang_flag=@wang_flag,");
            strSql.Append("daozhang=@daozhang,");
            strSql.Append("xiaofei_flag_jizhang_zm=@xiaofei_flag_jizhang_zm,");
            strSql.Append("zhuangmai_wang_name=@zhuangmai_wang_name,");
            strSql.Append("dingdan_hao=@dingdan_hao,");
            strSql.Append("ding_flag=@ding_flag,");
            strSql.Append("flag_2=@flag_2,");
            strSql.Append("xiaofei_qr_date=@xiaofei_qr_date,");
            strSql.Append("xiaofei_zuofei_flag=@xiaofei_zuofei_flag,");
            strSql.Append("xiaofei_qr_flag=@xiaofei_qr_flag,");
            strSql.Append("zhuce_flag=@zhuce_flag,");
            strSql.Append("flag_3=@flag_3,");
            strSql.Append("flag_a1=@flag_a1,");
            strSql.Append("flag_11=@flag_11,");
            strSql.Append("flag_10=@flag_10,");
            strSql.Append("flag_jiesuan=@flag_jiesuan,");
            strSql.Append("fahuo_flag=@fahuo_flag,");
            strSql.Append("fahuo_date=@fahuo_date,");
            strSql.Append("queren_man=@queren_man,");
            strSql.Append("xiaofei_money1=@xiaofei_money1,");
            strSql.Append("kdname=@kdname,");
            strSql.Append("wlno=@wlno,");
            strSql.Append("photo=@photo,");
            strSql.Append("ren=@ren,");
            strSql.Append("mob=@mob,");
            strSql.Append("xiaofei_zuoyou=@xiaofei_zuoyou,");
            strSql.Append("flag_15=@flag_15,");
            strSql.Append("flag_12=@flag_12,");
            strSql.Append("flag_13=@flag_13,");
            strSql.Append("flag_14=@flag_14,");
            strSql.Append("is_flag=@is_flag,");
            strSql.Append("jiebie=@jiebie,");
            strSql.Append("address=@address,");
            strSql.Append("name=@name,");
            strSql.Append("phone=@phone,");
            strSql.Append("post=@post,");
            strSql.Append("pro_yunfei=@pro_yunfei,");
            strSql.Append("xiaofei_money2=@xiaofei_money2,");
            strSql.Append("orders=@orders,");
            strSql.Append("order_no=@order_no,");
            strSql.Append("zhikou=@zhikou,");
            strSql.Append("memo=@memo,");
            strSql.Append("flag_17=@flag_17,");
            strSql.Append("fh_money=@fh_money");
            strSql.Append(" where xiaofei_id=@xiaofei_id ");
            SqlParameter[] parameters = {
					new SqlParameter("@xiaofei_hui_id", SqlDbType.NVarChar,255),
					new SqlParameter("@xiaofei_money", SqlDbType.Money,8),
					new SqlParameter("@xiaofei_pro_id", SqlDbType.NVarChar,255),
					new SqlParameter("@xiaofei_pro_count", SqlDbType.Money,8),
					new SqlParameter("@xiaofei_flag", SqlDbType.Int,4),
					new SqlParameter("@xiaofei_flag_jiezhang", SqlDbType.Int,4),
					new SqlParameter("@xiaofei_memo", SqlDbType.NVarChar,255),
					new SqlParameter("@xiaofei_zhuanmai", SqlDbType.VarChar,10),
					new SqlParameter("@xiaofei_date", SqlDbType.DateTime),
					new SqlParameter("@xiaofei_flag_jiezhang_zhou", SqlDbType.Int,4),
					new SqlParameter("@xiaofei_flag_jiezhang_yue", SqlDbType.Int,4),
					new SqlParameter("@xiaofei_flag_jiezhang_nian", SqlDbType.Int,4),
					new SqlParameter("@xiaofei_flag_jiezhang_yue_fenhong1", SqlDbType.Int,4),
					new SqlParameter("@xiaofei_chongfu_flag", SqlDbType.Int,4),
					new SqlParameter("@xiaofei_chongfu", SqlDbType.Int,4),
					new SqlParameter("@xiaofei_flag_10", SqlDbType.Int,4),
					new SqlParameter("@zhuanmai_flag", SqlDbType.Int,4),
					new SqlParameter("@zhuangmai_wang", SqlDbType.VarChar,9),
					new SqlParameter("@wang_flag", SqlDbType.Int,4),
					new SqlParameter("@daozhang", SqlDbType.Int,4),
					new SqlParameter("@xiaofei_flag_jizhang_zm", SqlDbType.Int,4),
					new SqlParameter("@zhuangmai_wang_name", SqlDbType.VarChar,50),
					new SqlParameter("@dingdan_hao", SqlDbType.VarChar,50),
					new SqlParameter("@ding_flag", SqlDbType.Int,4),
					new SqlParameter("@flag_2", SqlDbType.Int,4),
					new SqlParameter("@xiaofei_qr_date", SqlDbType.DateTime),
					new SqlParameter("@xiaofei_zuofei_flag", SqlDbType.Int,4),
					new SqlParameter("@xiaofei_qr_flag", SqlDbType.Int,4),
					new SqlParameter("@zhuce_flag", SqlDbType.Int,4),
					new SqlParameter("@flag_3", SqlDbType.Int,4),
					new SqlParameter("@flag_a1", SqlDbType.Int,4),
					new SqlParameter("@flag_11", SqlDbType.Int,4),
					new SqlParameter("@flag_10", SqlDbType.Int,4),
					new SqlParameter("@flag_jiesuan", SqlDbType.Int,4),
					new SqlParameter("@fahuo_flag", SqlDbType.Int,4),
					new SqlParameter("@fahuo_date", SqlDbType.DateTime),
					new SqlParameter("@queren_man", SqlDbType.VarChar,50),
					new SqlParameter("@xiaofei_money1", SqlDbType.Money,8),
					new SqlParameter("@kdname", SqlDbType.VarChar,50),
					new SqlParameter("@wlno", SqlDbType.VarChar,50),
					new SqlParameter("@photo", SqlDbType.VarChar,50),
					new SqlParameter("@ren", SqlDbType.VarChar,50),
					new SqlParameter("@mob", SqlDbType.VarChar,50),
					new SqlParameter("@xiaofei_zuoyou", SqlDbType.Int,4),
					new SqlParameter("@flag_15", SqlDbType.Int,4),
					new SqlParameter("@flag_12", SqlDbType.Int,4),
					new SqlParameter("@flag_13", SqlDbType.Int,4),
					new SqlParameter("@flag_14", SqlDbType.Int,4),
					new SqlParameter("@is_flag", SqlDbType.Int,4),
					new SqlParameter("@jiebie", SqlDbType.Int,4),
					new SqlParameter("@address", SqlDbType.VarChar,50),
					new SqlParameter("@name", SqlDbType.VarChar,50),
					new SqlParameter("@phone", SqlDbType.VarChar,50),
					new SqlParameter("@post", SqlDbType.VarChar,50),
					new SqlParameter("@pro_yunfei", SqlDbType.Money,8),
					new SqlParameter("@xiaofei_money2", SqlDbType.Money,8),
					new SqlParameter("@orders", SqlDbType.VarChar,200),
					new SqlParameter("@order_no", SqlDbType.VarChar,200),
					new SqlParameter("@zhikou", SqlDbType.Money,8),
					new SqlParameter("@memo", SqlDbType.Text),
					new SqlParameter("@flag_17", SqlDbType.Int,4),
					new SqlParameter("@fh_money", SqlDbType.Money,8),
					new SqlParameter("@xiaofei_id", SqlDbType.Int,4)};
            parameters[0].Value = xiaofei_hui_id;
            parameters[1].Value = xiaofei_money;
            parameters[2].Value = xiaofei_pro_id;
            parameters[3].Value = xiaofei_pro_count;
            parameters[4].Value = xiaofei_flag;
            parameters[5].Value = xiaofei_flag_jiezhang;
            parameters[6].Value = xiaofei_memo;
            parameters[7].Value = xiaofei_zhuanmai;
            parameters[8].Value = xiaofei_date;
            parameters[9].Value = xiaofei_flag_jiezhang_zhou;
            parameters[10].Value = xiaofei_flag_jiezhang_yue;
            parameters[11].Value = xiaofei_flag_jiezhang_nian;
            parameters[12].Value = xiaofei_flag_jiezhang_yue_fenhong1;
            parameters[13].Value = xiaofei_chongfu_flag;
            parameters[14].Value = xiaofei_chongfu;
            parameters[15].Value = xiaofei_flag_10;
            parameters[16].Value = zhuanmai_flag;
            parameters[17].Value = zhuangmai_wang;
            parameters[18].Value = wang_flag;
            parameters[19].Value = daozhang;
            parameters[20].Value = xiaofei_flag_jizhang_zm;
            parameters[21].Value = zhuangmai_wang_name;
            parameters[22].Value = dingdan_hao;
            parameters[23].Value = ding_flag;
            parameters[24].Value = flag_2;
            parameters[25].Value = xiaofei_qr_date;
            parameters[26].Value = xiaofei_zuofei_flag;
            parameters[27].Value = xiaofei_qr_flag;
            parameters[28].Value = zhuce_flag;
            parameters[29].Value = flag_3;
            parameters[30].Value = flag_a1;
            parameters[31].Value = flag_11;
            parameters[32].Value = flag_10;
            parameters[33].Value = flag_jiesuan;
            parameters[34].Value = fahuo_flag;
            parameters[35].Value = fahuo_date;
            parameters[36].Value = queren_man;
            parameters[37].Value = xiaofei_money1;
            parameters[38].Value = kdname;
            parameters[39].Value = wlno;
            parameters[40].Value = photo;
            parameters[41].Value = ren;
            parameters[42].Value = mob;
            parameters[43].Value = xiaofei_zuoyou;
            parameters[44].Value = flag_15;
            parameters[45].Value = flag_12;
            parameters[46].Value = flag_13;
            parameters[47].Value = flag_14;
            parameters[48].Value = is_flag;
            parameters[49].Value = jiebie;
            parameters[50].Value = address;
            parameters[51].Value = name;
            parameters[52].Value = phone;
            parameters[53].Value = post;
            parameters[54].Value = pro_yunfei;
            parameters[55].Value = xiaofei_money2;
            parameters[56].Value = orders;
            parameters[57].Value = order_no;
            parameters[58].Value = zhikou;
            parameters[59].Value = memo;
            parameters[60].Value = flag_17;
            parameters[61].Value = fh_money;
            parameters[62].Value = xiaofei_id;

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
        public bool Delete(int xiaofei_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from [tbl_xiaofei] ");
            strSql.Append(" where xiaofei_id=@xiaofei_id ");
            SqlParameter[] parameters = {
					new SqlParameter("@xiaofei_id", SqlDbType.Int,4)};
            parameters[0].Value = xiaofei_id;

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
        /// 删除一条会员记录
        /// </summary>
        public bool Delete_xiaofei_hui_id(string xiaofei_hui_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from [tbl_xiaofei] ");
            strSql.Append(" where xiaofei_hui_id=@xiaofei_hui_id ");
            SqlParameter[] parameters = {
					new SqlParameter("@xiaofei_hui_id", SqlDbType.NVarChar,255)};
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
            strSql.Append("select xiaofei_id,xiaofei_hui_id,xiaofei_money,xiaofei_pro_id,xiaofei_pro_count,xiaofei_flag,xiaofei_flag_jiezhang,xiaofei_memo,xiaofei_zhuanmai,xiaofei_date,xiaofei_flag_jiezhang_zhou,xiaofei_flag_jiezhang_yue,xiaofei_flag_jiezhang_nian,xiaofei_flag_jiezhang_yue_fenhong1,xiaofei_chongfu_flag,xiaofei_chongfu,xiaofei_flag_10,zhuanmai_flag,zhuangmai_wang,wang_flag,daozhang,xiaofei_flag_jizhang_zm,zhuangmai_wang_name,dingdan_hao,ding_flag,flag_2,xiaofei_qr_date,xiaofei_zuofei_flag,xiaofei_qr_flag,zhuce_flag,flag_3,flag_a1,flag_11,flag_10,flag_jiesuan,fahuo_flag,fahuo_date,queren_man,xiaofei_money1,kdname,wlno,photo,ren,mob,xiaofei_zuoyou,flag_15,flag_12,flag_13,flag_14,is_flag,jiebie,address,name,phone,post,pro_yunfei,xiaofei_money2,orders,order_no,zhikou,memo,flag_17,fh_money ");
            strSql.Append(" FROM [tbl_xiaofei] ");
            strSql.Append(" where xiaofei_hui_id=@xiaofei_hui_id ");
            SqlParameter[] parameters = {
					new SqlParameter("@xiaofei_hui_id", SqlDbType.NVarChar,255)};
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
                if (ds.Tables[0].Rows[0]["xiaofei_memo"] != null)
                {
                    this.xiaofei_memo = ds.Tables[0].Rows[0]["xiaofei_memo"].ToString();
                }
                if (ds.Tables[0].Rows[0]["xiaofei_zhuanmai"] != null)
                {
                    this.xiaofei_zhuanmai = ds.Tables[0].Rows[0]["xiaofei_zhuanmai"].ToString();
                }
                if (ds.Tables[0].Rows[0]["xiaofei_date"] != null && ds.Tables[0].Rows[0]["xiaofei_date"].ToString() != "")
                {
                    this.xiaofei_date = DateTime.Parse(ds.Tables[0].Rows[0]["xiaofei_date"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xiaofei_flag_jiezhang_zhou"] != null && ds.Tables[0].Rows[0]["xiaofei_flag_jiezhang_zhou"].ToString() != "")
                {
                    this.xiaofei_flag_jiezhang_zhou = int.Parse(ds.Tables[0].Rows[0]["xiaofei_flag_jiezhang_zhou"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xiaofei_flag_jiezhang_yue"] != null && ds.Tables[0].Rows[0]["xiaofei_flag_jiezhang_yue"].ToString() != "")
                {
                    this.xiaofei_flag_jiezhang_yue = int.Parse(ds.Tables[0].Rows[0]["xiaofei_flag_jiezhang_yue"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xiaofei_flag_jiezhang_nian"] != null && ds.Tables[0].Rows[0]["xiaofei_flag_jiezhang_nian"].ToString() != "")
                {
                    this.xiaofei_flag_jiezhang_nian = int.Parse(ds.Tables[0].Rows[0]["xiaofei_flag_jiezhang_nian"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xiaofei_flag_jiezhang_yue_fenhong1"] != null && ds.Tables[0].Rows[0]["xiaofei_flag_jiezhang_yue_fenhong1"].ToString() != "")
                {
                    this.xiaofei_flag_jiezhang_yue_fenhong1 = int.Parse(ds.Tables[0].Rows[0]["xiaofei_flag_jiezhang_yue_fenhong1"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xiaofei_chongfu_flag"] != null && ds.Tables[0].Rows[0]["xiaofei_chongfu_flag"].ToString() != "")
                {
                    this.xiaofei_chongfu_flag = int.Parse(ds.Tables[0].Rows[0]["xiaofei_chongfu_flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xiaofei_chongfu"] != null && ds.Tables[0].Rows[0]["xiaofei_chongfu"].ToString() != "")
                {
                    this.xiaofei_chongfu = int.Parse(ds.Tables[0].Rows[0]["xiaofei_chongfu"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xiaofei_flag_10"] != null && ds.Tables[0].Rows[0]["xiaofei_flag_10"].ToString() != "")
                {
                    this.xiaofei_flag_10 = int.Parse(ds.Tables[0].Rows[0]["xiaofei_flag_10"].ToString());
                }
                if (ds.Tables[0].Rows[0]["zhuanmai_flag"] != null && ds.Tables[0].Rows[0]["zhuanmai_flag"].ToString() != "")
                {
                    this.zhuanmai_flag = int.Parse(ds.Tables[0].Rows[0]["zhuanmai_flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["zhuangmai_wang"] != null)
                {
                    this.zhuangmai_wang = ds.Tables[0].Rows[0]["zhuangmai_wang"].ToString();
                }
                if (ds.Tables[0].Rows[0]["wang_flag"] != null && ds.Tables[0].Rows[0]["wang_flag"].ToString() != "")
                {
                    this.wang_flag = int.Parse(ds.Tables[0].Rows[0]["wang_flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["daozhang"] != null && ds.Tables[0].Rows[0]["daozhang"].ToString() != "")
                {
                    this.daozhang = int.Parse(ds.Tables[0].Rows[0]["daozhang"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xiaofei_flag_jizhang_zm"] != null && ds.Tables[0].Rows[0]["xiaofei_flag_jizhang_zm"].ToString() != "")
                {
                    this.xiaofei_flag_jizhang_zm = int.Parse(ds.Tables[0].Rows[0]["xiaofei_flag_jizhang_zm"].ToString());
                }
                if (ds.Tables[0].Rows[0]["zhuangmai_wang_name"] != null)
                {
                    this.zhuangmai_wang_name = ds.Tables[0].Rows[0]["zhuangmai_wang_name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["dingdan_hao"] != null)
                {
                    this.dingdan_hao = ds.Tables[0].Rows[0]["dingdan_hao"].ToString();
                }
                if (ds.Tables[0].Rows[0]["ding_flag"] != null && ds.Tables[0].Rows[0]["ding_flag"].ToString() != "")
                {
                    this.ding_flag = int.Parse(ds.Tables[0].Rows[0]["ding_flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_2"] != null && ds.Tables[0].Rows[0]["flag_2"].ToString() != "")
                {
                    this.flag_2 = int.Parse(ds.Tables[0].Rows[0]["flag_2"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xiaofei_qr_date"] != null && ds.Tables[0].Rows[0]["xiaofei_qr_date"].ToString() != "")
                {
                    this.xiaofei_qr_date = DateTime.Parse(ds.Tables[0].Rows[0]["xiaofei_qr_date"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xiaofei_zuofei_flag"] != null && ds.Tables[0].Rows[0]["xiaofei_zuofei_flag"].ToString() != "")
                {
                    this.xiaofei_zuofei_flag = int.Parse(ds.Tables[0].Rows[0]["xiaofei_zuofei_flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xiaofei_qr_flag"] != null && ds.Tables[0].Rows[0]["xiaofei_qr_flag"].ToString() != "")
                {
                    this.xiaofei_qr_flag = int.Parse(ds.Tables[0].Rows[0]["xiaofei_qr_flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["zhuce_flag"] != null && ds.Tables[0].Rows[0]["zhuce_flag"].ToString() != "")
                {
                    this.zhuce_flag = int.Parse(ds.Tables[0].Rows[0]["zhuce_flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_3"] != null && ds.Tables[0].Rows[0]["flag_3"].ToString() != "")
                {
                    this.flag_3 = int.Parse(ds.Tables[0].Rows[0]["flag_3"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_a1"] != null && ds.Tables[0].Rows[0]["flag_a1"].ToString() != "")
                {
                    this.flag_a1 = int.Parse(ds.Tables[0].Rows[0]["flag_a1"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_11"] != null && ds.Tables[0].Rows[0]["flag_11"].ToString() != "")
                {
                    this.flag_11 = int.Parse(ds.Tables[0].Rows[0]["flag_11"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_10"] != null && ds.Tables[0].Rows[0]["flag_10"].ToString() != "")
                {
                    this.flag_10 = int.Parse(ds.Tables[0].Rows[0]["flag_10"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_jiesuan"] != null && ds.Tables[0].Rows[0]["flag_jiesuan"].ToString() != "")
                {
                    this.flag_jiesuan = int.Parse(ds.Tables[0].Rows[0]["flag_jiesuan"].ToString());
                }
                if (ds.Tables[0].Rows[0]["fahuo_flag"] != null && ds.Tables[0].Rows[0]["fahuo_flag"].ToString() != "")
                {
                    this.fahuo_flag = int.Parse(ds.Tables[0].Rows[0]["fahuo_flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["fahuo_date"] != null && ds.Tables[0].Rows[0]["fahuo_date"].ToString() != "")
                {
                    this.fahuo_date = DateTime.Parse(ds.Tables[0].Rows[0]["fahuo_date"].ToString());
                }
                if (ds.Tables[0].Rows[0]["queren_man"] != null)
                {
                    this.queren_man = ds.Tables[0].Rows[0]["queren_man"].ToString();
                }
                if (ds.Tables[0].Rows[0]["xiaofei_money1"] != null && ds.Tables[0].Rows[0]["xiaofei_money1"].ToString() != "")
                {
                    this.xiaofei_money1 = decimal.Parse(ds.Tables[0].Rows[0]["xiaofei_money1"].ToString());
                }
                if (ds.Tables[0].Rows[0]["kdname"] != null)
                {
                    this.kdname = ds.Tables[0].Rows[0]["kdname"].ToString();
                }
                if (ds.Tables[0].Rows[0]["wlno"] != null)
                {
                    this.wlno = ds.Tables[0].Rows[0]["wlno"].ToString();
                }
                if (ds.Tables[0].Rows[0]["photo"] != null)
                {
                    this.photo = ds.Tables[0].Rows[0]["photo"].ToString();
                }
                if (ds.Tables[0].Rows[0]["ren"] != null)
                {
                    this.ren = ds.Tables[0].Rows[0]["ren"].ToString();
                }
                if (ds.Tables[0].Rows[0]["mob"] != null)
                {
                    this.mob = ds.Tables[0].Rows[0]["mob"].ToString();
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
                if (ds.Tables[0].Rows[0]["is_flag"] != null && ds.Tables[0].Rows[0]["is_flag"].ToString() != "")
                {
                    this.is_flag = int.Parse(ds.Tables[0].Rows[0]["is_flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["jiebie"] != null && ds.Tables[0].Rows[0]["jiebie"].ToString() != "")
                {
                    this.jiebie = int.Parse(ds.Tables[0].Rows[0]["jiebie"].ToString());
                }
                if (ds.Tables[0].Rows[0]["address"] != null)
                {
                    this.address = ds.Tables[0].Rows[0]["address"].ToString();
                }
                if (ds.Tables[0].Rows[0]["name"] != null)
                {
                    this.name = ds.Tables[0].Rows[0]["name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["phone"] != null)
                {
                    this.phone = ds.Tables[0].Rows[0]["phone"].ToString();
                }
                if (ds.Tables[0].Rows[0]["post"] != null)
                {
                    this.post = ds.Tables[0].Rows[0]["post"].ToString();
                }
                if (ds.Tables[0].Rows[0]["pro_yunfei"] != null && ds.Tables[0].Rows[0]["pro_yunfei"].ToString() != "")
                {
                    this.pro_yunfei = decimal.Parse(ds.Tables[0].Rows[0]["pro_yunfei"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xiaofei_money2"] != null && ds.Tables[0].Rows[0]["xiaofei_money2"].ToString() != "")
                {
                    this.xiaofei_money2 = decimal.Parse(ds.Tables[0].Rows[0]["xiaofei_money2"].ToString());
                }
                if (ds.Tables[0].Rows[0]["orders"] != null)
                {
                    this.orders = ds.Tables[0].Rows[0]["orders"].ToString();
                }
                if (ds.Tables[0].Rows[0]["order_no"] != null)
                {
                    this.order_no = ds.Tables[0].Rows[0]["order_no"].ToString();
                }
                if (ds.Tables[0].Rows[0]["zhikou"] != null && ds.Tables[0].Rows[0]["zhikou"].ToString() != "")
                {
                    this.zhikou = decimal.Parse(ds.Tables[0].Rows[0]["zhikou"].ToString());
                }
                if (ds.Tables[0].Rows[0]["memo"] != null)
                {
                    this.memo = ds.Tables[0].Rows[0]["memo"].ToString();
                }
                if (ds.Tables[0].Rows[0]["flag_17"] != null && ds.Tables[0].Rows[0]["flag_17"].ToString() != "")
                {
                    this.flag_17 = int.Parse(ds.Tables[0].Rows[0]["flag_17"].ToString());
                }
                if (ds.Tables[0].Rows[0]["fh_money"] != null && ds.Tables[0].Rows[0]["fh_money"].ToString() != "")
                {
                    this.fh_money = decimal.Parse(ds.Tables[0].Rows[0]["fh_money"].ToString());
                }
            }
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public void GetModel_id(int xiaofei_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select xiaofei_id,xiaofei_hui_id,xiaofei_money,xiaofei_pro_id,xiaofei_pro_count,xiaofei_flag,xiaofei_flag_jiezhang,xiaofei_memo,xiaofei_zhuanmai,xiaofei_date,xiaofei_flag_jiezhang_zhou,xiaofei_flag_jiezhang_yue,xiaofei_flag_jiezhang_nian,xiaofei_flag_jiezhang_yue_fenhong1,xiaofei_chongfu_flag,xiaofei_chongfu,xiaofei_flag_10,zhuanmai_flag,zhuangmai_wang,wang_flag,daozhang,xiaofei_flag_jizhang_zm,zhuangmai_wang_name,dingdan_hao,ding_flag,flag_2,xiaofei_qr_date,xiaofei_zuofei_flag,xiaofei_qr_flag,zhuce_flag,flag_3,flag_a1,flag_11,flag_10,flag_jiesuan,fahuo_flag,fahuo_date,queren_man,xiaofei_money1,kdname,wlno,photo,ren,mob,xiaofei_zuoyou,flag_15,flag_12,flag_13,flag_14,is_flag,jiebie,address,name,phone,post,pro_yunfei,xiaofei_money2,orders,order_no,zhikou,memo,flag_17,fh_money ");
            strSql.Append(" FROM [tbl_xiaofei] ");
            strSql.Append(" where xiaofei_id=@xiaofei_id ");
            SqlParameter[] parameters = {
					new SqlParameter("@xiaofei_id", SqlDbType.Int,4)};
            parameters[0].Value = xiaofei_id;

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
                if (ds.Tables[0].Rows[0]["xiaofei_memo"] != null)
                {
                    this.xiaofei_memo = ds.Tables[0].Rows[0]["xiaofei_memo"].ToString();
                }
                if (ds.Tables[0].Rows[0]["xiaofei_zhuanmai"] != null)
                {
                    this.xiaofei_zhuanmai = ds.Tables[0].Rows[0]["xiaofei_zhuanmai"].ToString();
                }
                if (ds.Tables[0].Rows[0]["xiaofei_date"] != null && ds.Tables[0].Rows[0]["xiaofei_date"].ToString() != "")
                {
                    this.xiaofei_date = DateTime.Parse(ds.Tables[0].Rows[0]["xiaofei_date"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xiaofei_flag_jiezhang_zhou"] != null && ds.Tables[0].Rows[0]["xiaofei_flag_jiezhang_zhou"].ToString() != "")
                {
                    this.xiaofei_flag_jiezhang_zhou = int.Parse(ds.Tables[0].Rows[0]["xiaofei_flag_jiezhang_zhou"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xiaofei_flag_jiezhang_yue"] != null && ds.Tables[0].Rows[0]["xiaofei_flag_jiezhang_yue"].ToString() != "")
                {
                    this.xiaofei_flag_jiezhang_yue = int.Parse(ds.Tables[0].Rows[0]["xiaofei_flag_jiezhang_yue"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xiaofei_flag_jiezhang_nian"] != null && ds.Tables[0].Rows[0]["xiaofei_flag_jiezhang_nian"].ToString() != "")
                {
                    this.xiaofei_flag_jiezhang_nian = int.Parse(ds.Tables[0].Rows[0]["xiaofei_flag_jiezhang_nian"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xiaofei_flag_jiezhang_yue_fenhong1"] != null && ds.Tables[0].Rows[0]["xiaofei_flag_jiezhang_yue_fenhong1"].ToString() != "")
                {
                    this.xiaofei_flag_jiezhang_yue_fenhong1 = int.Parse(ds.Tables[0].Rows[0]["xiaofei_flag_jiezhang_yue_fenhong1"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xiaofei_chongfu_flag"] != null && ds.Tables[0].Rows[0]["xiaofei_chongfu_flag"].ToString() != "")
                {
                    this.xiaofei_chongfu_flag = int.Parse(ds.Tables[0].Rows[0]["xiaofei_chongfu_flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xiaofei_chongfu"] != null && ds.Tables[0].Rows[0]["xiaofei_chongfu"].ToString() != "")
                {
                    this.xiaofei_chongfu = int.Parse(ds.Tables[0].Rows[0]["xiaofei_chongfu"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xiaofei_flag_10"] != null && ds.Tables[0].Rows[0]["xiaofei_flag_10"].ToString() != "")
                {
                    this.xiaofei_flag_10 = int.Parse(ds.Tables[0].Rows[0]["xiaofei_flag_10"].ToString());
                }
                if (ds.Tables[0].Rows[0]["zhuanmai_flag"] != null && ds.Tables[0].Rows[0]["zhuanmai_flag"].ToString() != "")
                {
                    this.zhuanmai_flag = int.Parse(ds.Tables[0].Rows[0]["zhuanmai_flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["zhuangmai_wang"] != null)
                {
                    this.zhuangmai_wang = ds.Tables[0].Rows[0]["zhuangmai_wang"].ToString();
                }
                if (ds.Tables[0].Rows[0]["wang_flag"] != null && ds.Tables[0].Rows[0]["wang_flag"].ToString() != "")
                {
                    this.wang_flag = int.Parse(ds.Tables[0].Rows[0]["wang_flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["daozhang"] != null && ds.Tables[0].Rows[0]["daozhang"].ToString() != "")
                {
                    this.daozhang = int.Parse(ds.Tables[0].Rows[0]["daozhang"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xiaofei_flag_jizhang_zm"] != null && ds.Tables[0].Rows[0]["xiaofei_flag_jizhang_zm"].ToString() != "")
                {
                    this.xiaofei_flag_jizhang_zm = int.Parse(ds.Tables[0].Rows[0]["xiaofei_flag_jizhang_zm"].ToString());
                }
                if (ds.Tables[0].Rows[0]["zhuangmai_wang_name"] != null)
                {
                    this.zhuangmai_wang_name = ds.Tables[0].Rows[0]["zhuangmai_wang_name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["dingdan_hao"] != null)
                {
                    this.dingdan_hao = ds.Tables[0].Rows[0]["dingdan_hao"].ToString();
                }
                if (ds.Tables[0].Rows[0]["ding_flag"] != null && ds.Tables[0].Rows[0]["ding_flag"].ToString() != "")
                {
                    this.ding_flag = int.Parse(ds.Tables[0].Rows[0]["ding_flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_2"] != null && ds.Tables[0].Rows[0]["flag_2"].ToString() != "")
                {
                    this.flag_2 = int.Parse(ds.Tables[0].Rows[0]["flag_2"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xiaofei_qr_date"] != null && ds.Tables[0].Rows[0]["xiaofei_qr_date"].ToString() != "")
                {
                    this.xiaofei_qr_date = DateTime.Parse(ds.Tables[0].Rows[0]["xiaofei_qr_date"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xiaofei_zuofei_flag"] != null && ds.Tables[0].Rows[0]["xiaofei_zuofei_flag"].ToString() != "")
                {
                    this.xiaofei_zuofei_flag = int.Parse(ds.Tables[0].Rows[0]["xiaofei_zuofei_flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xiaofei_qr_flag"] != null && ds.Tables[0].Rows[0]["xiaofei_qr_flag"].ToString() != "")
                {
                    this.xiaofei_qr_flag = int.Parse(ds.Tables[0].Rows[0]["xiaofei_qr_flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["zhuce_flag"] != null && ds.Tables[0].Rows[0]["zhuce_flag"].ToString() != "")
                {
                    this.zhuce_flag = int.Parse(ds.Tables[0].Rows[0]["zhuce_flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_3"] != null && ds.Tables[0].Rows[0]["flag_3"].ToString() != "")
                {
                    this.flag_3 = int.Parse(ds.Tables[0].Rows[0]["flag_3"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_a1"] != null && ds.Tables[0].Rows[0]["flag_a1"].ToString() != "")
                {
                    this.flag_a1 = int.Parse(ds.Tables[0].Rows[0]["flag_a1"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_11"] != null && ds.Tables[0].Rows[0]["flag_11"].ToString() != "")
                {
                    this.flag_11 = int.Parse(ds.Tables[0].Rows[0]["flag_11"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_10"] != null && ds.Tables[0].Rows[0]["flag_10"].ToString() != "")
                {
                    this.flag_10 = int.Parse(ds.Tables[0].Rows[0]["flag_10"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_jiesuan"] != null && ds.Tables[0].Rows[0]["flag_jiesuan"].ToString() != "")
                {
                    this.flag_jiesuan = int.Parse(ds.Tables[0].Rows[0]["flag_jiesuan"].ToString());
                }
                if (ds.Tables[0].Rows[0]["fahuo_flag"] != null && ds.Tables[0].Rows[0]["fahuo_flag"].ToString() != "")
                {
                    this.fahuo_flag = int.Parse(ds.Tables[0].Rows[0]["fahuo_flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["fahuo_date"] != null && ds.Tables[0].Rows[0]["fahuo_date"].ToString() != "")
                {
                    this.fahuo_date = DateTime.Parse(ds.Tables[0].Rows[0]["fahuo_date"].ToString());
                }
                if (ds.Tables[0].Rows[0]["queren_man"] != null)
                {
                    this.queren_man = ds.Tables[0].Rows[0]["queren_man"].ToString();
                }
                if (ds.Tables[0].Rows[0]["xiaofei_money1"] != null && ds.Tables[0].Rows[0]["xiaofei_money1"].ToString() != "")
                {
                    this.xiaofei_money1 = decimal.Parse(ds.Tables[0].Rows[0]["xiaofei_money1"].ToString());
                }
                if (ds.Tables[0].Rows[0]["kdname"] != null)
                {
                    this.kdname = ds.Tables[0].Rows[0]["kdname"].ToString();
                }
                if (ds.Tables[0].Rows[0]["wlno"] != null)
                {
                    this.wlno = ds.Tables[0].Rows[0]["wlno"].ToString();
                }
                if (ds.Tables[0].Rows[0]["photo"] != null)
                {
                    this.photo = ds.Tables[0].Rows[0]["photo"].ToString();
                }
                if (ds.Tables[0].Rows[0]["ren"] != null)
                {
                    this.ren = ds.Tables[0].Rows[0]["ren"].ToString();
                }
                if (ds.Tables[0].Rows[0]["mob"] != null)
                {
                    this.mob = ds.Tables[0].Rows[0]["mob"].ToString();
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
                if (ds.Tables[0].Rows[0]["is_flag"] != null && ds.Tables[0].Rows[0]["is_flag"].ToString() != "")
                {
                    this.is_flag = int.Parse(ds.Tables[0].Rows[0]["is_flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["jiebie"] != null && ds.Tables[0].Rows[0]["jiebie"].ToString() != "")
                {
                    this.jiebie = int.Parse(ds.Tables[0].Rows[0]["jiebie"].ToString());
                }
                if (ds.Tables[0].Rows[0]["address"] != null)
                {
                    this.address = ds.Tables[0].Rows[0]["address"].ToString();
                }
                if (ds.Tables[0].Rows[0]["name"] != null)
                {
                    this.name = ds.Tables[0].Rows[0]["name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["phone"] != null)
                {
                    this.phone = ds.Tables[0].Rows[0]["phone"].ToString();
                }
                if (ds.Tables[0].Rows[0]["post"] != null)
                {
                    this.post = ds.Tables[0].Rows[0]["post"].ToString();
                }
                if (ds.Tables[0].Rows[0]["pro_yunfei"] != null && ds.Tables[0].Rows[0]["pro_yunfei"].ToString() != "")
                {
                    this.pro_yunfei = decimal.Parse(ds.Tables[0].Rows[0]["pro_yunfei"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xiaofei_money2"] != null && ds.Tables[0].Rows[0]["xiaofei_money2"].ToString() != "")
                {
                    this.xiaofei_money2 = decimal.Parse(ds.Tables[0].Rows[0]["xiaofei_money2"].ToString());
                }
                if (ds.Tables[0].Rows[0]["orders"] != null)
                {
                    this.orders = ds.Tables[0].Rows[0]["orders"].ToString();
                }
                if (ds.Tables[0].Rows[0]["order_no"] != null)
                {
                    this.order_no = ds.Tables[0].Rows[0]["order_no"].ToString();
                }
                if (ds.Tables[0].Rows[0]["zhikou"] != null && ds.Tables[0].Rows[0]["zhikou"].ToString() != "")
                {
                    this.zhikou = decimal.Parse(ds.Tables[0].Rows[0]["zhikou"].ToString());
                }
                if (ds.Tables[0].Rows[0]["memo"] != null)
                {
                    this.memo = ds.Tables[0].Rows[0]["memo"].ToString();
                }
                if (ds.Tables[0].Rows[0]["flag_17"] != null && ds.Tables[0].Rows[0]["flag_17"].ToString() != "")
                {
                    this.flag_17 = int.Parse(ds.Tables[0].Rows[0]["flag_17"].ToString());
                }
                if (ds.Tables[0].Rows[0]["fh_money"] != null && ds.Tables[0].Rows[0]["fh_money"].ToString() != "")
                {
                    this.fh_money = decimal.Parse(ds.Tables[0].Rows[0]["fh_money"].ToString());
                }
               
            }
        }
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public void GetModel_pid(int xiaofei_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select xiaofei_id,xiaofei_hui_id,xiaofei_money,xiaofei_pro_id,xiaofei_pro_count,xiaofei_flag,xiaofei_flag_jiezhang,xiaofei_memo,xiaofei_zhuanmai,xiaofei_date,xiaofei_flag_jiezhang_zhou,xiaofei_flag_jiezhang_yue,xiaofei_flag_jiezhang_nian,xiaofei_flag_jiezhang_yue_fenhong1,xiaofei_chongfu_flag,xiaofei_chongfu,xiaofei_flag_10,zhuanmai_flag,zhuangmai_wang,wang_flag,daozhang,xiaofei_flag_jizhang_zm,zhuangmai_wang_name,dingdan_hao,ding_flag,flag_2,xiaofei_qr_date,xiaofei_zuofei_flag,xiaofei_qr_flag,zhuce_flag,flag_3,flag_a1,flag_11,flag_10,flag_jiesuan,fahuo_flag,fahuo_date,queren_man,xiaofei_money1,kdname,wlno,photo,ren,mob,xiaofei_zuoyou,flag_15,flag_12,flag_13,flag_14,is_flag,jiebie,address,name,phone,post,pro_yunfei,xiaofei_money2,orders,order_no,zhikou,memo,flag_17,fh_money ");
            strSql.Append(" FROM [tbl_xiaofei] ");
            strSql.Append(" where xiaofei_flag_jiezhang=@xiaofei_id ");
            SqlParameter[] parameters = {
					new SqlParameter("@xiaofei_id", SqlDbType.Int,4)};
            parameters[0].Value = xiaofei_id;

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
                if (ds.Tables[0].Rows[0]["xiaofei_memo"] != null)
                {
                    this.xiaofei_memo = ds.Tables[0].Rows[0]["xiaofei_memo"].ToString();
                }
                if (ds.Tables[0].Rows[0]["xiaofei_zhuanmai"] != null)
                {
                    this.xiaofei_zhuanmai = ds.Tables[0].Rows[0]["xiaofei_zhuanmai"].ToString();
                }
                if (ds.Tables[0].Rows[0]["xiaofei_date"] != null && ds.Tables[0].Rows[0]["xiaofei_date"].ToString() != "")
                {
                    this.xiaofei_date = DateTime.Parse(ds.Tables[0].Rows[0]["xiaofei_date"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xiaofei_flag_jiezhang_zhou"] != null && ds.Tables[0].Rows[0]["xiaofei_flag_jiezhang_zhou"].ToString() != "")
                {
                    this.xiaofei_flag_jiezhang_zhou = int.Parse(ds.Tables[0].Rows[0]["xiaofei_flag_jiezhang_zhou"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xiaofei_flag_jiezhang_yue"] != null && ds.Tables[0].Rows[0]["xiaofei_flag_jiezhang_yue"].ToString() != "")
                {
                    this.xiaofei_flag_jiezhang_yue = int.Parse(ds.Tables[0].Rows[0]["xiaofei_flag_jiezhang_yue"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xiaofei_flag_jiezhang_nian"] != null && ds.Tables[0].Rows[0]["xiaofei_flag_jiezhang_nian"].ToString() != "")
                {
                    this.xiaofei_flag_jiezhang_nian = int.Parse(ds.Tables[0].Rows[0]["xiaofei_flag_jiezhang_nian"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xiaofei_flag_jiezhang_yue_fenhong1"] != null && ds.Tables[0].Rows[0]["xiaofei_flag_jiezhang_yue_fenhong1"].ToString() != "")
                {
                    this.xiaofei_flag_jiezhang_yue_fenhong1 = int.Parse(ds.Tables[0].Rows[0]["xiaofei_flag_jiezhang_yue_fenhong1"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xiaofei_chongfu_flag"] != null && ds.Tables[0].Rows[0]["xiaofei_chongfu_flag"].ToString() != "")
                {
                    this.xiaofei_chongfu_flag = int.Parse(ds.Tables[0].Rows[0]["xiaofei_chongfu_flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xiaofei_chongfu"] != null && ds.Tables[0].Rows[0]["xiaofei_chongfu"].ToString() != "")
                {
                    this.xiaofei_chongfu = int.Parse(ds.Tables[0].Rows[0]["xiaofei_chongfu"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xiaofei_flag_10"] != null && ds.Tables[0].Rows[0]["xiaofei_flag_10"].ToString() != "")
                {
                    this.xiaofei_flag_10 = int.Parse(ds.Tables[0].Rows[0]["xiaofei_flag_10"].ToString());
                }
                if (ds.Tables[0].Rows[0]["zhuanmai_flag"] != null && ds.Tables[0].Rows[0]["zhuanmai_flag"].ToString() != "")
                {
                    this.zhuanmai_flag = int.Parse(ds.Tables[0].Rows[0]["zhuanmai_flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["zhuangmai_wang"] != null)
                {
                    this.zhuangmai_wang = ds.Tables[0].Rows[0]["zhuangmai_wang"].ToString();
                }
                if (ds.Tables[0].Rows[0]["wang_flag"] != null && ds.Tables[0].Rows[0]["wang_flag"].ToString() != "")
                {
                    this.wang_flag = int.Parse(ds.Tables[0].Rows[0]["wang_flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["daozhang"] != null && ds.Tables[0].Rows[0]["daozhang"].ToString() != "")
                {
                    this.daozhang = int.Parse(ds.Tables[0].Rows[0]["daozhang"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xiaofei_flag_jizhang_zm"] != null && ds.Tables[0].Rows[0]["xiaofei_flag_jizhang_zm"].ToString() != "")
                {
                    this.xiaofei_flag_jizhang_zm = int.Parse(ds.Tables[0].Rows[0]["xiaofei_flag_jizhang_zm"].ToString());
                }
                if (ds.Tables[0].Rows[0]["zhuangmai_wang_name"] != null)
                {
                    this.zhuangmai_wang_name = ds.Tables[0].Rows[0]["zhuangmai_wang_name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["dingdan_hao"] != null)
                {
                    this.dingdan_hao = ds.Tables[0].Rows[0]["dingdan_hao"].ToString();
                }
                if (ds.Tables[0].Rows[0]["ding_flag"] != null && ds.Tables[0].Rows[0]["ding_flag"].ToString() != "")
                {
                    this.ding_flag = int.Parse(ds.Tables[0].Rows[0]["ding_flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_2"] != null && ds.Tables[0].Rows[0]["flag_2"].ToString() != "")
                {
                    this.flag_2 = int.Parse(ds.Tables[0].Rows[0]["flag_2"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xiaofei_qr_date"] != null && ds.Tables[0].Rows[0]["xiaofei_qr_date"].ToString() != "")
                {
                    this.xiaofei_qr_date = DateTime.Parse(ds.Tables[0].Rows[0]["xiaofei_qr_date"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xiaofei_zuofei_flag"] != null && ds.Tables[0].Rows[0]["xiaofei_zuofei_flag"].ToString() != "")
                {
                    this.xiaofei_zuofei_flag = int.Parse(ds.Tables[0].Rows[0]["xiaofei_zuofei_flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xiaofei_qr_flag"] != null && ds.Tables[0].Rows[0]["xiaofei_qr_flag"].ToString() != "")
                {
                    this.xiaofei_qr_flag = int.Parse(ds.Tables[0].Rows[0]["xiaofei_qr_flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["zhuce_flag"] != null && ds.Tables[0].Rows[0]["zhuce_flag"].ToString() != "")
                {
                    this.zhuce_flag = int.Parse(ds.Tables[0].Rows[0]["zhuce_flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_3"] != null && ds.Tables[0].Rows[0]["flag_3"].ToString() != "")
                {
                    this.flag_3 = int.Parse(ds.Tables[0].Rows[0]["flag_3"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_a1"] != null && ds.Tables[0].Rows[0]["flag_a1"].ToString() != "")
                {
                    this.flag_a1 = int.Parse(ds.Tables[0].Rows[0]["flag_a1"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_11"] != null && ds.Tables[0].Rows[0]["flag_11"].ToString() != "")
                {
                    this.flag_11 = int.Parse(ds.Tables[0].Rows[0]["flag_11"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_10"] != null && ds.Tables[0].Rows[0]["flag_10"].ToString() != "")
                {
                    this.flag_10 = int.Parse(ds.Tables[0].Rows[0]["flag_10"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_jiesuan"] != null && ds.Tables[0].Rows[0]["flag_jiesuan"].ToString() != "")
                {
                    this.flag_jiesuan = int.Parse(ds.Tables[0].Rows[0]["flag_jiesuan"].ToString());
                }
                if (ds.Tables[0].Rows[0]["fahuo_flag"] != null && ds.Tables[0].Rows[0]["fahuo_flag"].ToString() != "")
                {
                    this.fahuo_flag = int.Parse(ds.Tables[0].Rows[0]["fahuo_flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["fahuo_date"] != null && ds.Tables[0].Rows[0]["fahuo_date"].ToString() != "")
                {
                    this.fahuo_date = DateTime.Parse(ds.Tables[0].Rows[0]["fahuo_date"].ToString());
                }
                if (ds.Tables[0].Rows[0]["queren_man"] != null)
                {
                    this.queren_man = ds.Tables[0].Rows[0]["queren_man"].ToString();
                }
                if (ds.Tables[0].Rows[0]["xiaofei_money1"] != null && ds.Tables[0].Rows[0]["xiaofei_money1"].ToString() != "")
                {
                    this.xiaofei_money1 = decimal.Parse(ds.Tables[0].Rows[0]["xiaofei_money1"].ToString());
                }
                if (ds.Tables[0].Rows[0]["kdname"] != null)
                {
                    this.kdname = ds.Tables[0].Rows[0]["kdname"].ToString();
                }
                if (ds.Tables[0].Rows[0]["wlno"] != null)
                {
                    this.wlno = ds.Tables[0].Rows[0]["wlno"].ToString();
                }
                if (ds.Tables[0].Rows[0]["photo"] != null)
                {
                    this.photo = ds.Tables[0].Rows[0]["photo"].ToString();
                }
                if (ds.Tables[0].Rows[0]["ren"] != null)
                {
                    this.ren = ds.Tables[0].Rows[0]["ren"].ToString();
                }
                if (ds.Tables[0].Rows[0]["mob"] != null)
                {
                    this.mob = ds.Tables[0].Rows[0]["mob"].ToString();
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
                if (ds.Tables[0].Rows[0]["is_flag"] != null && ds.Tables[0].Rows[0]["is_flag"].ToString() != "")
                {
                    this.is_flag = int.Parse(ds.Tables[0].Rows[0]["is_flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["jiebie"] != null && ds.Tables[0].Rows[0]["jiebie"].ToString() != "")
                {
                    this.jiebie = int.Parse(ds.Tables[0].Rows[0]["jiebie"].ToString());
                }
                if (ds.Tables[0].Rows[0]["address"] != null)
                {
                    this.address = ds.Tables[0].Rows[0]["address"].ToString();
                }
                if (ds.Tables[0].Rows[0]["name"] != null)
                {
                    this.name = ds.Tables[0].Rows[0]["name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["phone"] != null)
                {
                    this.phone = ds.Tables[0].Rows[0]["phone"].ToString();
                }
                if (ds.Tables[0].Rows[0]["post"] != null)
                {
                    this.post = ds.Tables[0].Rows[0]["post"].ToString();
                }
                if (ds.Tables[0].Rows[0]["pro_yunfei"] != null && ds.Tables[0].Rows[0]["pro_yunfei"].ToString() != "")
                {
                    this.pro_yunfei = decimal.Parse(ds.Tables[0].Rows[0]["pro_yunfei"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xiaofei_money2"] != null && ds.Tables[0].Rows[0]["xiaofei_money2"].ToString() != "")
                {
                    this.xiaofei_money2 = decimal.Parse(ds.Tables[0].Rows[0]["xiaofei_money2"].ToString());
                }
                if (ds.Tables[0].Rows[0]["orders"] != null)
                {
                    this.orders = ds.Tables[0].Rows[0]["orders"].ToString();
                }
                if (ds.Tables[0].Rows[0]["order_no"] != null)
                {
                    this.order_no = ds.Tables[0].Rows[0]["order_no"].ToString();
                }
                if (ds.Tables[0].Rows[0]["zhikou"] != null && ds.Tables[0].Rows[0]["zhikou"].ToString() != "")
                {
                    this.zhikou = decimal.Parse(ds.Tables[0].Rows[0]["zhikou"].ToString());
                }
                if (ds.Tables[0].Rows[0]["memo"] != null)
                {
                    this.memo = ds.Tables[0].Rows[0]["memo"].ToString();
                }
                if (ds.Tables[0].Rows[0]["flag_17"] != null && ds.Tables[0].Rows[0]["flag_17"].ToString() != "")
                {
                    this.flag_17 = int.Parse(ds.Tables[0].Rows[0]["flag_17"].ToString());
                }
                if (ds.Tables[0].Rows[0]["fh_money"] != null && ds.Tables[0].Rows[0]["fh_money"].ToString() != "")
                {
                    this.fh_money = decimal.Parse(ds.Tables[0].Rows[0]["fh_money"].ToString());
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
            strSql.Append(" FROM [tbl_xiaofei] ");
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
            strSql.Append("select top 1 " + Title + " as sumcode from [view_xiaofei]");
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
 

