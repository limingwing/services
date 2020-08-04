using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
 
    /// <summary>
    /// 类view_huiyuan。
    /// </summary>
    [Serializable]
    public partial class view_huiyuan
    {
        public view_huiyuan()
        { }
        #region Model
        private string _huiyuan_id;
        private string _huiyuan_bianhao;
        private string _huiyuan_name;
        private decimal? _huiyuan_yu;
        private string _huiyuan_shenfen_id;
        private string _huiyuan_mob;
        private string _huiyuan_address;
        private DateTime? _huiyuan_add_time;
        private string _huiyuan_pass;
        private string _huiyuan_yinhang_zh;
        private string _huiyuan_yinhang_name;
        private string _huiyuan_yinhang;
        private string _huiyuan_shang_id;
        private int? _huiyuan_jiebie;
        private int? _huiyuan_zhuanmai;
        private int? _zuoyou;
        private int? _huiyuan_pen_zuo;
        private int? _huiyuan_pen_you;
        private decimal? _zuo_shen;
        private decimal? _you_shen;
        private decimal? _fh_money;
        private string _test;
        private int? _dongjie;
        private decimal? _chongfu_money;
        private int? _net_hege;
        private int? _net_flag;
        private string _huiyuan_jiedian;
        private string _huiyuan_zm;
        private DateTime? _huiyuan_qr_date;
        private int? _huiyuan_zhuanmai_sq;
        private int? _zhuanmai_jb;
        private int? _flag_1;
        private int? _flag_5;
        private string _zmd_id;
        private string _zmd_bianhao;
        private string _tjr_id;
        private string _tjr_bianhao;
        private string _tjr_name;
        private string _zmd_name;
        private string _huiyuan_zm_memo;
        private string _huiyuan_zm_diqu;
        private string _huiyuan_zm_mingcheng;
        private DateTime? _huiyuan_zm_sq_time;
        private decimal? _qianbao;
        private decimal? _fenhong_canshu1;
        private string _youzheng;
        private string _pass_two;
        private string _huiyuan_qq;
        private string _huiyuan_nc;
        private string _bank_zhi;
        private string _huiyuan_email;
        private string _queren_man;
        private int? _bid;
        private int? _mmid;
        private int? _sid;
        private int? _huiyuan_suoding;
        private decimal? _chongfu_zong;
        private decimal? _chongfu_kechu;
        private int? _huiyuan_jiebie2;
        private string _beizhu;
        private string _pass_three;
        private string _jdr_bianhao;
        private string _huiyuan_dp_name;
        private int? _kd_flag;
        private int? _account_type;
        private int? _huiyuan_jiebie1;
        private int? _ly_count;
        private int? _tuijian_count;
        private decimal? _jiangjin_yong;
        private decimal? _jiangjin_zong;
        private string _question;
        private string _answer;
        private string _weixin;
        private string _zhifubao;
        private int? _xinxi_flag;
        private int? _jiebie_pid;
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
        public decimal? huiyuan_yu
        {
            set { _huiyuan_yu = value; }
            get { return _huiyuan_yu; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string huiyuan_shenfen_id
        {
            set { _huiyuan_shenfen_id = value; }
            get { return _huiyuan_shenfen_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string huiyuan_mob
        {
            set { _huiyuan_mob = value; }
            get { return _huiyuan_mob; }
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
        public DateTime? huiyuan_add_time
        {
            set { _huiyuan_add_time = value; }
            get { return _huiyuan_add_time; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string huiyuan_pass
        {
            set { _huiyuan_pass = value; }
            get { return _huiyuan_pass; }
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
        public string huiyuan_shang_id
        {
            set { _huiyuan_shang_id = value; }
            get { return _huiyuan_shang_id; }
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
        public int? huiyuan_zhuanmai
        {
            set { _huiyuan_zhuanmai = value; }
            get { return _huiyuan_zhuanmai; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? zuoyou
        {
            set { _zuoyou = value; }
            get { return _zuoyou; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? huiyuan_pen_zuo
        {
            set { _huiyuan_pen_zuo = value; }
            get { return _huiyuan_pen_zuo; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? huiyuan_pen_you
        {
            set { _huiyuan_pen_you = value; }
            get { return _huiyuan_pen_you; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? zuo_shen
        {
            set { _zuo_shen = value; }
            get { return _zuo_shen; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? you_shen
        {
            set { _you_shen = value; }
            get { return _you_shen; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string test
        {
            set { _test = value; }
            get { return _test; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? dongjie
        {
            set { _dongjie = value; }
            get { return _dongjie; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? chongfu_money
        {
            set { _chongfu_money = value; }
            get { return _chongfu_money; }
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
        public int? net_flag
        {
            set { _net_flag = value; }
            get { return _net_flag; }
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
        public string huiyuan_zm
        {
            set { _huiyuan_zm = value; }
            get { return _huiyuan_zm; }
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
        public int? huiyuan_zhuanmai_sq
        {
            set { _huiyuan_zhuanmai_sq = value; }
            get { return _huiyuan_zhuanmai_sq; }
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
        public int? flag_1
        {
            set { _flag_1 = value; }
            get { return _flag_1; }
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
        public string zmd_id
        {
            set { _zmd_id = value; }
            get { return _zmd_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string zmd_bianhao
        {
            set { _zmd_bianhao = value; }
            get { return _zmd_bianhao; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string tjr_id
        {
            set { _tjr_id = value; }
            get { return _tjr_id; }
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
        public string zmd_name
        {
            set { _zmd_name = value; }
            get { return _zmd_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string huiyuan_zm_memo
        {
            set { _huiyuan_zm_memo = value; }
            get { return _huiyuan_zm_memo; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string huiyuan_zm_diqu
        {
            set { _huiyuan_zm_diqu = value; }
            get { return _huiyuan_zm_diqu; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string huiyuan_zm_mingcheng
        {
            set { _huiyuan_zm_mingcheng = value; }
            get { return _huiyuan_zm_mingcheng; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? huiyuan_zm_sq_time
        {
            set { _huiyuan_zm_sq_time = value; }
            get { return _huiyuan_zm_sq_time; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? qianbao
        {
            set { _qianbao = value; }
            get { return _qianbao; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? fenhong_canshu1
        {
            set { _fenhong_canshu1 = value; }
            get { return _fenhong_canshu1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string youzheng
        {
            set { _youzheng = value; }
            get { return _youzheng; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string pass_two
        {
            set { _pass_two = value; }
            get { return _pass_two; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string huiyuan_qq
        {
            set { _huiyuan_qq = value; }
            get { return _huiyuan_qq; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string huiyuan_nc
        {
            set { _huiyuan_nc = value; }
            get { return _huiyuan_nc; }
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
        public string huiyuan_email
        {
            set { _huiyuan_email = value; }
            get { return _huiyuan_email; }
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
        public int? huiyuan_suoding
        {
            set { _huiyuan_suoding = value; }
            get { return _huiyuan_suoding; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? chongfu_zong
        {
            set { _chongfu_zong = value; }
            get { return _chongfu_zong; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? chongfu_kechu
        {
            set { _chongfu_kechu = value; }
            get { return _chongfu_kechu; }
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
        public string beizhu
        {
            set { _beizhu = value; }
            get { return _beizhu; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string pass_three
        {
            set { _pass_three = value; }
            get { return _pass_three; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string jdr_bianhao
        {
            set { _jdr_bianhao = value; }
            get { return _jdr_bianhao; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string huiyuan_dp_name
        {
            set { _huiyuan_dp_name = value; }
            get { return _huiyuan_dp_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? kd_flag
        {
            set { _kd_flag = value; }
            get { return _kd_flag; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? account_type
        {
            set { _account_type = value; }
            get { return _account_type; }
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
        public int? ly_count
        {
            set { _ly_count = value; }
            get { return _ly_count; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? tuijian_count
        {
            set { _tuijian_count = value; }
            get { return _tuijian_count; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? jiangjin_yong
        {
            set { _jiangjin_yong = value; }
            get { return _jiangjin_yong; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? jiangjin_zong
        {
            set { _jiangjin_zong = value; }
            get { return _jiangjin_zong; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string question
        {
            set { _question = value; }
            get { return _question; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string answer
        {
            set { _answer = value; }
            get { return _answer; }
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
        public int? xinxi_flag
        {
            set { _xinxi_flag = value; }
            get { return _xinxi_flag; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? jiebie_pid
        {
            set { _jiebie_pid = value; }
            get { return _jiebie_pid; }
        }
        #endregion Model


        #region  Method

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public view_huiyuan(string huiyuan_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select huiyuan_id,huiyuan_bianhao,huiyuan_name,huiyuan_yu,huiyuan_shenfen_id,huiyuan_mob,huiyuan_address,huiyuan_add_time,huiyuan_pass,huiyuan_yinhang_zh,huiyuan_yinhang_name,huiyuan_yinhang,huiyuan_shang_id,huiyuan_jiebie,huiyuan_zhuanmai,zuoyou,huiyuan_pen_zuo,huiyuan_pen_you,zuo_shen,you_shen,test,dongjie,chongfu_money,net_hege,net_flag,huiyuan_jiedian,huiyuan_zm,huiyuan_qr_date,huiyuan_zhuanmai_sq,zhuanmai_jb,flag_1,flag_5,zmd_id,zmd_bianhao,tjr_id,tjr_bianhao,tjr_name,zmd_name,huiyuan_zm_memo,huiyuan_zm_diqu,huiyuan_zm_mingcheng,huiyuan_zm_sq_time,qianbao,fenhong_canshu1,youzheng,pass_two,huiyuan_qq,huiyuan_nc,bank_zhi,huiyuan_email,queren_man,bid,mmid,sid,huiyuan_suoding,chongfu_zong,chongfu_kechu,huiyuan_jiebie2,beizhu,pass_three,jdr_bianhao,huiyuan_dp_name,kd_flag,account_type,huiyuan_jiebie1,ly_count,tuijian_count,jiangjin_yong,jiangjin_zong,question,answer,weixin,zhifubao,xinxi_flag ");
            strSql.Append(" FROM [view_huiyuan] ");
            strSql.Append(" where huiyuan_id=@huiyuan_id ");
            SqlParameter[] parameters = {
					new SqlParameter("@huiyuan_id", SqlDbType.NVarChar,-1)};
            parameters[0].Value = huiyuan_id;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
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
                if (ds.Tables[0].Rows[0]["huiyuan_yu"] != null && ds.Tables[0].Rows[0]["huiyuan_yu"].ToString() != "")
                {
                    this.huiyuan_yu = decimal.Parse(ds.Tables[0].Rows[0]["huiyuan_yu"].ToString());
                }
                if (ds.Tables[0].Rows[0]["huiyuan_shenfen_id"] != null)
                {
                    this.huiyuan_shenfen_id = ds.Tables[0].Rows[0]["huiyuan_shenfen_id"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_mob"] != null)
                {
                    this.huiyuan_mob = ds.Tables[0].Rows[0]["huiyuan_mob"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_address"] != null)
                {
                    this.huiyuan_address = ds.Tables[0].Rows[0]["huiyuan_address"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_add_time"] != null && ds.Tables[0].Rows[0]["huiyuan_add_time"].ToString() != "")
                {
                    this.huiyuan_add_time = DateTime.Parse(ds.Tables[0].Rows[0]["huiyuan_add_time"].ToString());
                }
                if (ds.Tables[0].Rows[0]["huiyuan_pass"] != null)
                {
                    this.huiyuan_pass = ds.Tables[0].Rows[0]["huiyuan_pass"].ToString();
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
                if (ds.Tables[0].Rows[0]["huiyuan_shang_id"] != null)
                {
                    this.huiyuan_shang_id = ds.Tables[0].Rows[0]["huiyuan_shang_id"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_jiebie"] != null && ds.Tables[0].Rows[0]["huiyuan_jiebie"].ToString() != "")
                {
                    this.huiyuan_jiebie = int.Parse(ds.Tables[0].Rows[0]["huiyuan_jiebie"].ToString());
                }
                if (ds.Tables[0].Rows[0]["huiyuan_zhuanmai"] != null && ds.Tables[0].Rows[0]["huiyuan_zhuanmai"].ToString() != "")
                {
                    this.huiyuan_zhuanmai = int.Parse(ds.Tables[0].Rows[0]["huiyuan_zhuanmai"].ToString());
                }
                if (ds.Tables[0].Rows[0]["zuoyou"] != null && ds.Tables[0].Rows[0]["zuoyou"].ToString() != "")
                {
                    this.zuoyou = int.Parse(ds.Tables[0].Rows[0]["zuoyou"].ToString());
                }
                if (ds.Tables[0].Rows[0]["huiyuan_pen_zuo"] != null && ds.Tables[0].Rows[0]["huiyuan_pen_zuo"].ToString() != "")
                {
                    this.huiyuan_pen_zuo = int.Parse(ds.Tables[0].Rows[0]["huiyuan_pen_zuo"].ToString());
                }
                if (ds.Tables[0].Rows[0]["huiyuan_pen_you"] != null && ds.Tables[0].Rows[0]["huiyuan_pen_you"].ToString() != "")
                {
                    this.huiyuan_pen_you = int.Parse(ds.Tables[0].Rows[0]["huiyuan_pen_you"].ToString());
                }
                if (ds.Tables[0].Rows[0]["zuo_shen"] != null && ds.Tables[0].Rows[0]["zuo_shen"].ToString() != "")
                {
                    this.zuo_shen = decimal.Parse(ds.Tables[0].Rows[0]["zuo_shen"].ToString());
                }
                if (ds.Tables[0].Rows[0]["you_shen"] != null && ds.Tables[0].Rows[0]["you_shen"].ToString() != "")
                {
                    this.you_shen = decimal.Parse(ds.Tables[0].Rows[0]["you_shen"].ToString());
                }
                if (ds.Tables[0].Rows[0]["test"] != null)
                {
                    this.test = ds.Tables[0].Rows[0]["test"].ToString();
                }
                if (ds.Tables[0].Rows[0]["dongjie"] != null && ds.Tables[0].Rows[0]["dongjie"].ToString() != "")
                {
                    this.dongjie = int.Parse(ds.Tables[0].Rows[0]["dongjie"].ToString());
                }
                if (ds.Tables[0].Rows[0]["chongfu_money"] != null && ds.Tables[0].Rows[0]["chongfu_money"].ToString() != "")
                {
                    this.chongfu_money = decimal.Parse(ds.Tables[0].Rows[0]["chongfu_money"].ToString());
                }
                if (ds.Tables[0].Rows[0]["net_hege"] != null && ds.Tables[0].Rows[0]["net_hege"].ToString() != "")
                {
                    this.net_hege = int.Parse(ds.Tables[0].Rows[0]["net_hege"].ToString());
                }
                if (ds.Tables[0].Rows[0]["net_flag"] != null && ds.Tables[0].Rows[0]["net_flag"].ToString() != "")
                {
                    this.net_flag = int.Parse(ds.Tables[0].Rows[0]["net_flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["huiyuan_jiedian"] != null)
                {
                    this.huiyuan_jiedian = ds.Tables[0].Rows[0]["huiyuan_jiedian"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_zm"] != null)
                {
                    this.huiyuan_zm = ds.Tables[0].Rows[0]["huiyuan_zm"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_qr_date"] != null && ds.Tables[0].Rows[0]["huiyuan_qr_date"].ToString() != "")
                {
                    this.huiyuan_qr_date = DateTime.Parse(ds.Tables[0].Rows[0]["huiyuan_qr_date"].ToString());
                }
                if (ds.Tables[0].Rows[0]["huiyuan_zhuanmai_sq"] != null && ds.Tables[0].Rows[0]["huiyuan_zhuanmai_sq"].ToString() != "")
                {
                    this.huiyuan_zhuanmai_sq = int.Parse(ds.Tables[0].Rows[0]["huiyuan_zhuanmai_sq"].ToString());
                }
                if (ds.Tables[0].Rows[0]["zhuanmai_jb"] != null && ds.Tables[0].Rows[0]["zhuanmai_jb"].ToString() != "")
                {
                    this.zhuanmai_jb = int.Parse(ds.Tables[0].Rows[0]["zhuanmai_jb"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_1"] != null && ds.Tables[0].Rows[0]["flag_1"].ToString() != "")
                {
                    this.flag_1 = int.Parse(ds.Tables[0].Rows[0]["flag_1"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_5"] != null && ds.Tables[0].Rows[0]["flag_5"].ToString() != "")
                {
                    this.flag_5 = int.Parse(ds.Tables[0].Rows[0]["flag_5"].ToString());
                }
                if (ds.Tables[0].Rows[0]["zmd_id"] != null)
                {
                    this.zmd_id = ds.Tables[0].Rows[0]["zmd_id"].ToString();
                }
                if (ds.Tables[0].Rows[0]["zmd_bianhao"] != null)
                {
                    this.zmd_bianhao = ds.Tables[0].Rows[0]["zmd_bianhao"].ToString();
                }
                if (ds.Tables[0].Rows[0]["tjr_id"] != null)
                {
                    this.tjr_id = ds.Tables[0].Rows[0]["tjr_id"].ToString();
                }
                if (ds.Tables[0].Rows[0]["tjr_bianhao"] != null)
                {
                    this.tjr_bianhao = ds.Tables[0].Rows[0]["tjr_bianhao"].ToString();
                }
                if (ds.Tables[0].Rows[0]["tjr_name"] != null)
                {
                    this.tjr_name = ds.Tables[0].Rows[0]["tjr_name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["zmd_name"] != null)
                {
                    this.zmd_name = ds.Tables[0].Rows[0]["zmd_name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_zm_memo"] != null)
                {
                    this.huiyuan_zm_memo = ds.Tables[0].Rows[0]["huiyuan_zm_memo"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_zm_diqu"] != null)
                {
                    this.huiyuan_zm_diqu = ds.Tables[0].Rows[0]["huiyuan_zm_diqu"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_zm_mingcheng"] != null)
                {
                    this.huiyuan_zm_mingcheng = ds.Tables[0].Rows[0]["huiyuan_zm_mingcheng"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_zm_sq_time"] != null && ds.Tables[0].Rows[0]["huiyuan_zm_sq_time"].ToString() != "")
                {
                    this.huiyuan_zm_sq_time = DateTime.Parse(ds.Tables[0].Rows[0]["huiyuan_zm_sq_time"].ToString());
                }
                if (ds.Tables[0].Rows[0]["qianbao"] != null && ds.Tables[0].Rows[0]["qianbao"].ToString() != "")
                {
                    this.qianbao = decimal.Parse(ds.Tables[0].Rows[0]["qianbao"].ToString());
                }
                if (ds.Tables[0].Rows[0]["fenhong_canshu1"] != null && ds.Tables[0].Rows[0]["fenhong_canshu1"].ToString() != "")
                {
                    this.fenhong_canshu1 = decimal.Parse(ds.Tables[0].Rows[0]["fenhong_canshu1"].ToString());
                }
                if (ds.Tables[0].Rows[0]["youzheng"] != null)
                {
                    this.youzheng = ds.Tables[0].Rows[0]["youzheng"].ToString();
                }
                if (ds.Tables[0].Rows[0]["pass_two"] != null)
                {
                    this.pass_two = ds.Tables[0].Rows[0]["pass_two"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_qq"] != null)
                {
                    this.huiyuan_qq = ds.Tables[0].Rows[0]["huiyuan_qq"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_nc"] != null)
                {
                    this.huiyuan_nc = ds.Tables[0].Rows[0]["huiyuan_nc"].ToString();
                }
                if (ds.Tables[0].Rows[0]["bank_zhi"] != null)
                {
                    this.bank_zhi = ds.Tables[0].Rows[0]["bank_zhi"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_email"] != null)
                {
                    this.huiyuan_email = ds.Tables[0].Rows[0]["huiyuan_email"].ToString();
                }
                if (ds.Tables[0].Rows[0]["queren_man"] != null)
                {
                    this.queren_man = ds.Tables[0].Rows[0]["queren_man"].ToString();
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
                if (ds.Tables[0].Rows[0]["huiyuan_suoding"] != null && ds.Tables[0].Rows[0]["huiyuan_suoding"].ToString() != "")
                {
                    this.huiyuan_suoding = int.Parse(ds.Tables[0].Rows[0]["huiyuan_suoding"].ToString());
                }
                if (ds.Tables[0].Rows[0]["chongfu_zong"] != null && ds.Tables[0].Rows[0]["chongfu_zong"].ToString() != "")
                {
                    this.chongfu_zong = decimal.Parse(ds.Tables[0].Rows[0]["chongfu_zong"].ToString());
                }
                if (ds.Tables[0].Rows[0]["chongfu_kechu"] != null && ds.Tables[0].Rows[0]["chongfu_kechu"].ToString() != "")
                {
                    this.chongfu_kechu = decimal.Parse(ds.Tables[0].Rows[0]["chongfu_kechu"].ToString());
                }
                if (ds.Tables[0].Rows[0]["huiyuan_jiebie2"] != null && ds.Tables[0].Rows[0]["huiyuan_jiebie2"].ToString() != "")
                {
                    this.huiyuan_jiebie2 = int.Parse(ds.Tables[0].Rows[0]["huiyuan_jiebie2"].ToString());
                }
                if (ds.Tables[0].Rows[0]["beizhu"] != null)
                {
                    this.beizhu = ds.Tables[0].Rows[0]["beizhu"].ToString();
                }
                if (ds.Tables[0].Rows[0]["pass_three"] != null)
                {
                    this.pass_three = ds.Tables[0].Rows[0]["pass_three"].ToString();
                }
                if (ds.Tables[0].Rows[0]["jdr_bianhao"] != null)
                {
                    this.jdr_bianhao = ds.Tables[0].Rows[0]["jdr_bianhao"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_dp_name"] != null)
                {
                    this.huiyuan_dp_name = ds.Tables[0].Rows[0]["huiyuan_dp_name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["kd_flag"] != null && ds.Tables[0].Rows[0]["kd_flag"].ToString() != "")
                {
                    this.kd_flag = int.Parse(ds.Tables[0].Rows[0]["kd_flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["account_type"] != null && ds.Tables[0].Rows[0]["account_type"].ToString() != "")
                {
                    this.account_type = int.Parse(ds.Tables[0].Rows[0]["account_type"].ToString());
                }
                if (ds.Tables[0].Rows[0]["huiyuan_jiebie1"] != null && ds.Tables[0].Rows[0]["huiyuan_jiebie1"].ToString() != "")
                {
                    this.huiyuan_jiebie1 = int.Parse(ds.Tables[0].Rows[0]["huiyuan_jiebie1"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ly_count"] != null && ds.Tables[0].Rows[0]["ly_count"].ToString() != "")
                {
                    this.ly_count = int.Parse(ds.Tables[0].Rows[0]["ly_count"].ToString());
                }
                if (ds.Tables[0].Rows[0]["tuijian_count"] != null && ds.Tables[0].Rows[0]["tuijian_count"].ToString() != "")
                {
                    this.tuijian_count = int.Parse(ds.Tables[0].Rows[0]["tuijian_count"].ToString());
                }
                if (ds.Tables[0].Rows[0]["jiangjin_yong"] != null && ds.Tables[0].Rows[0]["jiangjin_yong"].ToString() != "")
                {
                    this.jiangjin_yong = decimal.Parse(ds.Tables[0].Rows[0]["jiangjin_yong"].ToString());
                }
                if (ds.Tables[0].Rows[0]["jiangjin_zong"] != null && ds.Tables[0].Rows[0]["jiangjin_zong"].ToString() != "")
                {
                    this.jiangjin_zong = decimal.Parse(ds.Tables[0].Rows[0]["jiangjin_zong"].ToString());
                }
                if (ds.Tables[0].Rows[0]["question"] != null)
                {
                    this.question = ds.Tables[0].Rows[0]["question"].ToString();
                }
                if (ds.Tables[0].Rows[0]["answer"] != null)
                {
                    this.answer = ds.Tables[0].Rows[0]["answer"].ToString();
                }
                if (ds.Tables[0].Rows[0]["weixin"] != null)
                {
                    this.weixin = ds.Tables[0].Rows[0]["weixin"].ToString();
                }
                if (ds.Tables[0].Rows[0]["zhifubao"] != null)
                {
                    this.zhifubao = ds.Tables[0].Rows[0]["zhifubao"].ToString();
                }
                if (ds.Tables[0].Rows[0]["xinxi_flag"] != null && ds.Tables[0].Rows[0]["xinxi_flag"].ToString() != "")
                {
                    this.xinxi_flag = int.Parse(ds.Tables[0].Rows[0]["xinxi_flag"].ToString());
                }
              
            }
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string huiyuan_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from [view_huiyuan]");
            strSql.Append(" where huiyuan_id=@huiyuan_id ");

            SqlParameter[] parameters = {
					new SqlParameter("@huiyuan_id", SqlDbType.NVarChar,-1)};
            parameters[0].Value = huiyuan_id;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public void GetModel(string huiyuan_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select huiyuan_id,huiyuan_bianhao,huiyuan_name,huiyuan_yu,huiyuan_shenfen_id,huiyuan_mob,huiyuan_address,huiyuan_add_time,huiyuan_pass,huiyuan_yinhang_zh,huiyuan_yinhang_name,huiyuan_yinhang,huiyuan_shang_id,huiyuan_jiebie,huiyuan_zhuanmai,zuoyou,huiyuan_pen_zuo,huiyuan_pen_you,zuo_shen,you_shen,test,dongjie,chongfu_money,net_hege,net_flag,huiyuan_jiedian,huiyuan_zm,huiyuan_qr_date,huiyuan_zhuanmai_sq,zhuanmai_jb,flag_1,flag_5,zmd_id,zmd_bianhao,tjr_id,tjr_bianhao,tjr_name,zmd_name,huiyuan_zm_memo,huiyuan_zm_diqu,huiyuan_zm_mingcheng,huiyuan_zm_sq_time,qianbao,fenhong_canshu1,youzheng,pass_two,huiyuan_qq,huiyuan_nc,bank_zhi,huiyuan_email,queren_man,bid,mmid,sid,huiyuan_suoding,chongfu_zong,chongfu_kechu,huiyuan_jiebie2,beizhu,pass_three,jdr_bianhao,huiyuan_dp_name,kd_flag,account_type,huiyuan_jiebie1,ly_count,tuijian_count,jiangjin_yong,jiangjin_zong,question,answer,weixin,zhifubao,xinxi_flag   ");
            strSql.Append(" FROM [view_huiyuan] ");
            strSql.Append(" where huiyuan_id=@huiyuan_id ");
            SqlParameter[] parameters = {
					new SqlParameter("@huiyuan_id", SqlDbType.NVarChar,-1)};
            parameters[0].Value = huiyuan_id;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
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
                if (ds.Tables[0].Rows[0]["huiyuan_yu"] != null && ds.Tables[0].Rows[0]["huiyuan_yu"].ToString() != "")
                {
                    this.huiyuan_yu = decimal.Parse(ds.Tables[0].Rows[0]["huiyuan_yu"].ToString());
                }
                if (ds.Tables[0].Rows[0]["huiyuan_shenfen_id"] != null)
                {
                    this.huiyuan_shenfen_id = ds.Tables[0].Rows[0]["huiyuan_shenfen_id"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_mob"] != null)
                {
                    this.huiyuan_mob = ds.Tables[0].Rows[0]["huiyuan_mob"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_address"] != null)
                {
                    this.huiyuan_address = ds.Tables[0].Rows[0]["huiyuan_address"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_add_time"] != null && ds.Tables[0].Rows[0]["huiyuan_add_time"].ToString() != "")
                {
                    this.huiyuan_add_time = DateTime.Parse(ds.Tables[0].Rows[0]["huiyuan_add_time"].ToString());
                }
                if (ds.Tables[0].Rows[0]["huiyuan_pass"] != null)
                {
                    this.huiyuan_pass = ds.Tables[0].Rows[0]["huiyuan_pass"].ToString();
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
                if (ds.Tables[0].Rows[0]["huiyuan_shang_id"] != null)
                {
                    this.huiyuan_shang_id = ds.Tables[0].Rows[0]["huiyuan_shang_id"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_jiebie"] != null && ds.Tables[0].Rows[0]["huiyuan_jiebie"].ToString() != "")
                {
                    this.huiyuan_jiebie = int.Parse(ds.Tables[0].Rows[0]["huiyuan_jiebie"].ToString());
                }
                if (ds.Tables[0].Rows[0]["huiyuan_zhuanmai"] != null && ds.Tables[0].Rows[0]["huiyuan_zhuanmai"].ToString() != "")
                {
                    this.huiyuan_zhuanmai = int.Parse(ds.Tables[0].Rows[0]["huiyuan_zhuanmai"].ToString());
                }
                if (ds.Tables[0].Rows[0]["zuoyou"] != null && ds.Tables[0].Rows[0]["zuoyou"].ToString() != "")
                {
                    this.zuoyou = int.Parse(ds.Tables[0].Rows[0]["zuoyou"].ToString());
                }
                if (ds.Tables[0].Rows[0]["huiyuan_pen_zuo"] != null && ds.Tables[0].Rows[0]["huiyuan_pen_zuo"].ToString() != "")
                {
                    this.huiyuan_pen_zuo = int.Parse(ds.Tables[0].Rows[0]["huiyuan_pen_zuo"].ToString());
                }
                if (ds.Tables[0].Rows[0]["huiyuan_pen_you"] != null && ds.Tables[0].Rows[0]["huiyuan_pen_you"].ToString() != "")
                {
                    this.huiyuan_pen_you = int.Parse(ds.Tables[0].Rows[0]["huiyuan_pen_you"].ToString());
                }
                if (ds.Tables[0].Rows[0]["zuo_shen"] != null && ds.Tables[0].Rows[0]["zuo_shen"].ToString() != "")
                {
                    this.zuo_shen = decimal.Parse(ds.Tables[0].Rows[0]["zuo_shen"].ToString());
                }
                if (ds.Tables[0].Rows[0]["you_shen"] != null && ds.Tables[0].Rows[0]["you_shen"].ToString() != "")
                {
                    this.you_shen = decimal.Parse(ds.Tables[0].Rows[0]["you_shen"].ToString());
                }
                if (ds.Tables[0].Rows[0]["test"] != null)
                {
                    this.test = ds.Tables[0].Rows[0]["test"].ToString();
                }
                if (ds.Tables[0].Rows[0]["dongjie"] != null && ds.Tables[0].Rows[0]["dongjie"].ToString() != "")
                {
                    this.dongjie = int.Parse(ds.Tables[0].Rows[0]["dongjie"].ToString());
                }
                if (ds.Tables[0].Rows[0]["chongfu_money"] != null && ds.Tables[0].Rows[0]["chongfu_money"].ToString() != "")
                {
                    this.chongfu_money = decimal.Parse(ds.Tables[0].Rows[0]["chongfu_money"].ToString());
                }
                if (ds.Tables[0].Rows[0]["net_hege"] != null && ds.Tables[0].Rows[0]["net_hege"].ToString() != "")
                {
                    this.net_hege = int.Parse(ds.Tables[0].Rows[0]["net_hege"].ToString());
                }
                if (ds.Tables[0].Rows[0]["net_flag"] != null && ds.Tables[0].Rows[0]["net_flag"].ToString() != "")
                {
                    this.net_flag = int.Parse(ds.Tables[0].Rows[0]["net_flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["huiyuan_jiedian"] != null)
                {
                    this.huiyuan_jiedian = ds.Tables[0].Rows[0]["huiyuan_jiedian"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_zm"] != null)
                {
                    this.huiyuan_zm = ds.Tables[0].Rows[0]["huiyuan_zm"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_qr_date"] != null && ds.Tables[0].Rows[0]["huiyuan_qr_date"].ToString() != "")
                {
                    this.huiyuan_qr_date = DateTime.Parse(ds.Tables[0].Rows[0]["huiyuan_qr_date"].ToString());
                }
                if (ds.Tables[0].Rows[0]["huiyuan_zhuanmai_sq"] != null && ds.Tables[0].Rows[0]["huiyuan_zhuanmai_sq"].ToString() != "")
                {
                    this.huiyuan_zhuanmai_sq = int.Parse(ds.Tables[0].Rows[0]["huiyuan_zhuanmai_sq"].ToString());
                }
                if (ds.Tables[0].Rows[0]["zhuanmai_jb"] != null && ds.Tables[0].Rows[0]["zhuanmai_jb"].ToString() != "")
                {
                    this.zhuanmai_jb = int.Parse(ds.Tables[0].Rows[0]["zhuanmai_jb"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_1"] != null && ds.Tables[0].Rows[0]["flag_1"].ToString() != "")
                {
                    this.flag_1 = int.Parse(ds.Tables[0].Rows[0]["flag_1"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_5"] != null && ds.Tables[0].Rows[0]["flag_5"].ToString() != "")
                {
                    this.flag_5 = int.Parse(ds.Tables[0].Rows[0]["flag_5"].ToString());
                }
                if (ds.Tables[0].Rows[0]["zmd_id"] != null)
                {
                    this.zmd_id = ds.Tables[0].Rows[0]["zmd_id"].ToString();
                }
                if (ds.Tables[0].Rows[0]["zmd_bianhao"] != null)
                {
                    this.zmd_bianhao = ds.Tables[0].Rows[0]["zmd_bianhao"].ToString();
                }
                if (ds.Tables[0].Rows[0]["tjr_id"] != null)
                {
                    this.tjr_id = ds.Tables[0].Rows[0]["tjr_id"].ToString();
                }
                if (ds.Tables[0].Rows[0]["tjr_bianhao"] != null)
                {
                    this.tjr_bianhao = ds.Tables[0].Rows[0]["tjr_bianhao"].ToString();
                }
                if (ds.Tables[0].Rows[0]["tjr_name"] != null)
                {
                    this.tjr_name = ds.Tables[0].Rows[0]["tjr_name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["zmd_name"] != null)
                {
                    this.zmd_name = ds.Tables[0].Rows[0]["zmd_name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_zm_memo"] != null)
                {
                    this.huiyuan_zm_memo = ds.Tables[0].Rows[0]["huiyuan_zm_memo"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_zm_diqu"] != null)
                {
                    this.huiyuan_zm_diqu = ds.Tables[0].Rows[0]["huiyuan_zm_diqu"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_zm_mingcheng"] != null)
                {
                    this.huiyuan_zm_mingcheng = ds.Tables[0].Rows[0]["huiyuan_zm_mingcheng"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_zm_sq_time"] != null && ds.Tables[0].Rows[0]["huiyuan_zm_sq_time"].ToString() != "")
                {
                    this.huiyuan_zm_sq_time = DateTime.Parse(ds.Tables[0].Rows[0]["huiyuan_zm_sq_time"].ToString());
                }
                if (ds.Tables[0].Rows[0]["qianbao"] != null && ds.Tables[0].Rows[0]["qianbao"].ToString() != "")
                {
                    this.qianbao = decimal.Parse(ds.Tables[0].Rows[0]["qianbao"].ToString());
                }
                if (ds.Tables[0].Rows[0]["fenhong_canshu1"] != null && ds.Tables[0].Rows[0]["fenhong_canshu1"].ToString() != "")
                {
                    this.fenhong_canshu1 = decimal.Parse(ds.Tables[0].Rows[0]["fenhong_canshu1"].ToString());
                }
                if (ds.Tables[0].Rows[0]["youzheng"] != null)
                {
                    this.youzheng = ds.Tables[0].Rows[0]["youzheng"].ToString();
                }
                if (ds.Tables[0].Rows[0]["pass_two"] != null)
                {
                    this.pass_two = ds.Tables[0].Rows[0]["pass_two"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_qq"] != null)
                {
                    this.huiyuan_qq = ds.Tables[0].Rows[0]["huiyuan_qq"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_nc"] != null)
                {
                    this.huiyuan_nc = ds.Tables[0].Rows[0]["huiyuan_nc"].ToString();
                }
                if (ds.Tables[0].Rows[0]["bank_zhi"] != null)
                {
                    this.bank_zhi = ds.Tables[0].Rows[0]["bank_zhi"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_email"] != null)
                {
                    this.huiyuan_email = ds.Tables[0].Rows[0]["huiyuan_email"].ToString();
                }
                if (ds.Tables[0].Rows[0]["queren_man"] != null)
                {
                    this.queren_man = ds.Tables[0].Rows[0]["queren_man"].ToString();
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
                if (ds.Tables[0].Rows[0]["huiyuan_suoding"] != null && ds.Tables[0].Rows[0]["huiyuan_suoding"].ToString() != "")
                {
                    this.huiyuan_suoding = int.Parse(ds.Tables[0].Rows[0]["huiyuan_suoding"].ToString());
                }
                if (ds.Tables[0].Rows[0]["chongfu_zong"] != null && ds.Tables[0].Rows[0]["chongfu_zong"].ToString() != "")
                {
                    this.chongfu_zong = decimal.Parse(ds.Tables[0].Rows[0]["chongfu_zong"].ToString());
                }
                if (ds.Tables[0].Rows[0]["chongfu_kechu"] != null && ds.Tables[0].Rows[0]["chongfu_kechu"].ToString() != "")
                {
                    this.chongfu_kechu = decimal.Parse(ds.Tables[0].Rows[0]["chongfu_kechu"].ToString());
                }
                if (ds.Tables[0].Rows[0]["huiyuan_jiebie2"] != null && ds.Tables[0].Rows[0]["huiyuan_jiebie2"].ToString() != "")
                {
                    this.huiyuan_jiebie2 = int.Parse(ds.Tables[0].Rows[0]["huiyuan_jiebie2"].ToString());
                }
                if (ds.Tables[0].Rows[0]["beizhu"] != null)
                {
                    this.beizhu = ds.Tables[0].Rows[0]["beizhu"].ToString();
                }
                if (ds.Tables[0].Rows[0]["pass_three"] != null)
                {
                    this.pass_three = ds.Tables[0].Rows[0]["pass_three"].ToString();
                }
                if (ds.Tables[0].Rows[0]["jdr_bianhao"] != null)
                {
                    this.jdr_bianhao = ds.Tables[0].Rows[0]["jdr_bianhao"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_dp_name"] != null)
                {
                    this.huiyuan_dp_name = ds.Tables[0].Rows[0]["huiyuan_dp_name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["kd_flag"] != null && ds.Tables[0].Rows[0]["kd_flag"].ToString() != "")
                {
                    this.kd_flag = int.Parse(ds.Tables[0].Rows[0]["kd_flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["account_type"] != null && ds.Tables[0].Rows[0]["account_type"].ToString() != "")
                {
                    this.account_type = int.Parse(ds.Tables[0].Rows[0]["account_type"].ToString());
                }
                if (ds.Tables[0].Rows[0]["huiyuan_jiebie1"] != null && ds.Tables[0].Rows[0]["huiyuan_jiebie1"].ToString() != "")
                {
                    this.huiyuan_jiebie1 = int.Parse(ds.Tables[0].Rows[0]["huiyuan_jiebie1"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ly_count"] != null && ds.Tables[0].Rows[0]["ly_count"].ToString() != "")
                {
                    this.ly_count = int.Parse(ds.Tables[0].Rows[0]["ly_count"].ToString());
                }
                if (ds.Tables[0].Rows[0]["tuijian_count"] != null && ds.Tables[0].Rows[0]["tuijian_count"].ToString() != "")
                {
                    this.tuijian_count = int.Parse(ds.Tables[0].Rows[0]["tuijian_count"].ToString());
                }
                if (ds.Tables[0].Rows[0]["jiangjin_yong"] != null && ds.Tables[0].Rows[0]["jiangjin_yong"].ToString() != "")
                {
                    this.jiangjin_yong = decimal.Parse(ds.Tables[0].Rows[0]["jiangjin_yong"].ToString());
                }
                if (ds.Tables[0].Rows[0]["jiangjin_zong"] != null && ds.Tables[0].Rows[0]["jiangjin_zong"].ToString() != "")
                {
                    this.jiangjin_zong = decimal.Parse(ds.Tables[0].Rows[0]["jiangjin_zong"].ToString());
                }
                if (ds.Tables[0].Rows[0]["question"] != null)
                {
                    this.question = ds.Tables[0].Rows[0]["question"].ToString();
                }
                if (ds.Tables[0].Rows[0]["answer"] != null)
                {
                    this.answer = ds.Tables[0].Rows[0]["answer"].ToString();
                }
                if (ds.Tables[0].Rows[0]["weixin"] != null)
                {
                    this.weixin = ds.Tables[0].Rows[0]["weixin"].ToString();
                }
                if (ds.Tables[0].Rows[0]["zhifubao"] != null)
                {
                    this.zhifubao = ds.Tables[0].Rows[0]["zhifubao"].ToString();
                }
                if (ds.Tables[0].Rows[0]["xinxi_flag"] != null && ds.Tables[0].Rows[0]["xinxi_flag"].ToString() != "")
                {
                    this.xinxi_flag = int.Parse(ds.Tables[0].Rows[0]["xinxi_flag"].ToString());
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
            strSql.Append(" FROM [view_huiyuan] ");
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
            strSql.Append("select * FROM  view_huiyuan");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            recordCount = Convert.ToInt32(DbHelperSQL.GetSingle(PagingHelper.CreateCountingSql(strSql.ToString())));
            return DbHelperSQL.Query(PagingHelper.CreatePagingSql(recordCount, pageSize, pageIndex, strSql.ToString(), filedOrder));
        }


        #endregion  Method
    }
 

