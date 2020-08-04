using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
 
 
    /// <summary>
    /// 类tbl_huiyuan。
    /// </summary>
    [Serializable]
    public partial class tbl_huiyuan
    {
        public tbl_huiyuan()
        { }
        #region Model
        private string _huiyuan_id;
        private string _huiyuan_bianhao;
        private string _huiyuan_name;
        private decimal? _huiyuan_yu = 0M;
        private string _huiyuan_shenfen_id;
        private string _huiyuan_mob;
        private string _huiyuan_address;
        private DateTime? _huiyuan_add_time = DateTime.Now;
        private string _huiyuan_pass = "888888";
        private string _huiyuan_yinhang_zh;
        private string _huiyuan_yinhang_name;
        private string _huiyuan_yinhang;
        private string _huiyuan_shang_id;
        private int? _huiyuan_jiebie2 = 0;
        private int? _huiyuan_jiebie1 = 0;
        private int? _huiyuan_jiebie = 0;
        private int? _huiyuan_zhuanmai = 0;
        private int? _zuoyou = 0;
        private int? _huiyuan_pen_zuo = 0;
        private int? _huiyuan_pen_you = 0;
        private decimal? _zuo_shen = 0M;
        private decimal? _you_shen = 0M;
        private string _test;
        private int? _dongjie = 0;
        private decimal? _chongfu_money = 0M;
        private int? _net_hege = 0;
        private int? _net_flag = 0;
        private string _huiyuan_jiedian;
        private string _huiyuan_zm;
        private DateTime? _huiyuan_qr_date;
        private int? _huiyuan_zhuanmai_sq = 0;
        private int? _zhuanmai_jb = 0;
        private string _huiyuan_zm_memo;
        private string _huiyuan_zm_diqu;
        private string _huiyuan_zm_mingcheng;
        private DateTime? _huiyuan_zm_sq_time = DateTime.Now;
        private string _pass_two;
        private string _huiyuan_qq;
        private decimal? _qianbao = 0M;
        private string _leftnumber;
        private string _rightnumber;
        private decimal? _fenhong_canshu1 = 0M;
        private string _youzheng;
        private string _huiyuan_nc;
        private string _bank_zhi;
        private string _huiyuan_email;
        private string _queren_man;
        private int _bid;
        private int _mmid;
        private int _sid;
        private int? _huiyuan_suoding = 0;
        private decimal? _chongfu_zong = 0M;
        private decimal? _chongfu_kechu = 0M;
        private int? _hang = 0;
        private int? _lie = 0;
        private decimal? _jiangjing = 0M;
        private string _beizhu;
        private string _pass_three;
        private decimal? _jiangjin_yong = 0M;
        private decimal? _jiangjin_zong = 0M;
        private int? _flag_1 = 0;
        private int? _flag_2 = 0;
        private int? _flag_3 = 0;
        private int? _flag_4 = 0;
        private int? _flag_5 = 0;
        private string _huiyuan_shangshu;
        private string _huiyuan_shangshu2;
        private decimal? _zuo_zong = 0M;
        private decimal? _you_zong = 0M;
        private int? _flag_ce = 0;
        private decimal? _flag_money;
        private int? _js_flag = 0;
        private string _huiyuan_dp_name;
        private int? _kd_flag = 0;
        private int? _tuijian_count = 0;
        private int? _account_type = 0;
        private decimal? _fh_money = 0M;
        private decimal? _glf_money = 0M;
        private int? _temp_count = 0;
        private decimal? _zong_yeji = 0M;
        private int? _ly_count = 0;
        private int? _xuhao = 0;
        private int? _peng_cishu = 0;
        private int? _koushui_flag = 0;
        private string _question;
        private string _answer;
        private string _weixin;
        private string _zhifubao;
        private int? _xinxi_flag = 0;
        private DateTime? _huiyuan_sj_date;
        private int? _supply = 0;
        private int? _cishu1 = 0;
        private int? _cishu2 = 0;
        private string _city_address;
        private string _born_date;
        private string _sf_pinju_src;
        private string _zl_pinju_src;
        /// <summary>
        /// 会员标识符
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
        /// 会员注册积分+
        /// </summary>
        public decimal? huiyuan_yu
        {
            set { _huiyuan_yu = value; }
            get { return _huiyuan_yu; }
        }
        /// <summary>
        /// 会员身份证
        /// </summary>
        public string huiyuan_shenfen_id
        {
            set { _huiyuan_shenfen_id = value; }
            get { return _huiyuan_shenfen_id; }
        }
        /// <summary>
        /// 会员手机
        /// </summary>
        public string huiyuan_mob
        {
            set { _huiyuan_mob = value; }
            get { return _huiyuan_mob; }
        }
        /// <summary>
        /// 会员地址
        /// </summary>
        public string huiyuan_address
        {
            set { _huiyuan_address = value; }
            get { return _huiyuan_address; }
        }
        /// <summary>
        /// 会员加入时间
        /// </summary>
        public DateTime? huiyuan_add_time
        {
            set { _huiyuan_add_time = value; }
            get { return _huiyuan_add_time; }
        }
        /// <summary>
        /// 会员一级密码
        /// </summary>
        public string huiyuan_pass
        {
            set { _huiyuan_pass = value; }
            get { return _huiyuan_pass; }
        }
        /// <summary>
        /// 会员银行账号
        /// </summary>
        public string huiyuan_yinhang_zh
        {
            set { _huiyuan_yinhang_zh = value; }
            get { return _huiyuan_yinhang_zh; }
        }
        /// <summary>
        /// 会员银行开户名
        /// </summary>
        public string huiyuan_yinhang_name
        {
            set { _huiyuan_yinhang_name = value; }
            get { return _huiyuan_yinhang_name; }
        }
        /// <summary>
        /// 会员开户行
        /// </summary>
        public string huiyuan_yinhang
        {
            set { _huiyuan_yinhang = value; }
            get { return _huiyuan_yinhang; }
        }
        /// <summary>
        /// 推荐人
        /// </summary>
        public string huiyuan_shang_id
        {
            set { _huiyuan_shang_id = value; }
            get { return _huiyuan_shang_id; }
        }
        /// <summary>
        /// 级别2
        /// </summary>
        public int? huiyuan_jiebie2
        {
            set { _huiyuan_jiebie2 = value; }
            get { return _huiyuan_jiebie2; }
        }
        /// <summary>
        /// 级别1
        /// </summary>
        public int? huiyuan_jiebie1
        {
            set { _huiyuan_jiebie1 = value; }
            get { return _huiyuan_jiebie1; }
        }
        /// <summary>
        /// 级别
        /// </summary>
        public int? huiyuan_jiebie
        {
            set { _huiyuan_jiebie = value; }
            get { return _huiyuan_jiebie; }
        }
        /// <summary>
        /// 专卖店标识
        /// </summary>
        public int? huiyuan_zhuanmai
        {
            set { _huiyuan_zhuanmai = value; }
            get { return _huiyuan_zhuanmai; }
        }
        /// <summary>
        /// 左右区
        /// </summary>
        public int? zuoyou
        {
            set { _zuoyou = value; }
            get { return _zuoyou; }
        }
        /// <summary>
        /// 左边已碰数
        /// </summary>
        public int? huiyuan_pen_zuo
        {
            set { _huiyuan_pen_zuo = value; }
            get { return _huiyuan_pen_zuo; }
        }
        /// <summary>
        /// 右边已碰数
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
        /// 是否合格会员
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
        /// 接点人
        /// </summary>
        public string huiyuan_jiedian
        {
            set { _huiyuan_jiedian = value; }
            get { return _huiyuan_jiedian; }
        }
        /// <summary>
        /// 上级专卖店
        /// </summary>
        public string huiyuan_zm
        {
            set { _huiyuan_zm = value; }
            get { return _huiyuan_zm; }
        }
        /// <summary>
        /// 会员确认时间
        /// </summary>
        public DateTime? huiyuan_qr_date
        {
            set { _huiyuan_qr_date = value; }
            get { return _huiyuan_qr_date; }
        }
        /// <summary>
        /// 专卖店申请时间
        /// </summary>
        public int? huiyuan_zhuanmai_sq
        {
            set { _huiyuan_zhuanmai_sq = value; }
            get { return _huiyuan_zhuanmai_sq; }
        }
        /// <summary>
        /// 专卖店级别
        /// </summary>
        public int? zhuanmai_jb
        {
            set { _zhuanmai_jb = value; }
            get { return _zhuanmai_jb; }
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
        /// 二级密码
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
        /// 积分+
        /// </summary>
        public decimal? qianbao
        {
            set { _qianbao = value; }
            get { return _qianbao; }
        }
        /// <summary>
        /// 左边下属接点
        /// </summary>
        public string leftnumber
        {
            set { _leftnumber = value; }
            get { return _leftnumber; }
        }
        /// <summary>
        /// 右边下属接点
        /// </summary>
        public string rightnumber
        {
            set { _rightnumber = value; }
            get { return _rightnumber; }
        }
        /// <summary>
        /// 积分-
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
        /// 会员昵称
        /// </summary>
        public string huiyuan_nc
        {
            set { _huiyuan_nc = value; }
            get { return _huiyuan_nc; }
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
        /// 会员电子邮件地址
        /// </summary>
        public string huiyuan_email
        {
            set { _huiyuan_email = value; }
            get { return _huiyuan_email; }
        }
        /// <summary>
        /// 确认操作员
        /// </summary>
        public string queren_man
        {
            set { _queren_man = value; }
            get { return _queren_man; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int bid
        {
            set { _bid = value; }
            get { return _bid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int mmid
        {
            set { _mmid = value; }
            get { return _mmid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int sid
        {
            set { _sid = value; }
            get { return _sid; }
        }
        /// <summary>
        /// 是否冻结
        /// </summary>
        public int? huiyuan_suoding
        {
            set { _huiyuan_suoding = value; }
            get { return _huiyuan_suoding; }
        }
        /// <summary>
        /// 重复消费+
        /// </summary>
        public decimal? chongfu_zong
        {
            set { _chongfu_zong = value; }
            get { return _chongfu_zong; }
        }
        /// <summary>
        /// 重复消费-
        /// </summary>
        public decimal? chongfu_kechu
        {
            set { _chongfu_kechu = value; }
            get { return _chongfu_kechu; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? hang
        {
            set { _hang = value; }
            get { return _hang; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? lie
        {
            set { _lie = value; }
            get { return _lie; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? jiangjing
        {
            set { _jiangjing = value; }
            get { return _jiangjing; }
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
        public int? flag_3
        {
            set { _flag_3 = value; }
            get { return _flag_3; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? flag_4
        {
            set { _flag_4 = value; }
            get { return _flag_4; }
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
        /// 接点关系存储层
        /// </summary>
        public string huiyuan_shangshu
        {
            set { _huiyuan_shangshu = value; }
            get { return _huiyuan_shangshu; }
        }
        /// <summary>
        /// 推荐关系存储层
        /// </summary>
        public string huiyuan_shangshu2
        {
            set { _huiyuan_shangshu2 = value; }
            get { return _huiyuan_shangshu2; }
        }
        /// <summary>
        /// 对碰左边总业绩
        /// </summary>
        public decimal? zuo_zong
        {
            set { _zuo_zong = value; }
            get { return _zuo_zong; }
        }
        /// <summary>
        /// 对碰右边总业绩
        /// </summary>
        public decimal? you_zong
        {
            set { _you_zong = value; }
            get { return _you_zong; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? flag_ce
        {
            set { _flag_ce = value; }
            get { return _flag_ce; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? flag_money
        {
            set { _flag_money = value; }
            get { return _flag_money; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? js_flag
        {
            set { _js_flag = value; }
            get { return _js_flag; }
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
        /// 下面推荐总人数
        /// </summary>
        public int? tuijian_count
        {
            set { _tuijian_count = value; }
            get { return _tuijian_count; }
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
        public decimal? fh_money
        {
            set { _fh_money = value; }
            get { return _fh_money; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? glf_money
        {
            set { _glf_money = value; }
            get { return _glf_money; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? temp_count
        {
            set { _temp_count = value; }
            get { return _temp_count; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? zong_yeji
        {
            set { _zong_yeji = value; }
            get { return _zong_yeji; }
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
        public int? xuhao
        {
            set { _xuhao = value; }
            get { return _xuhao; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? peng_cishu
        {
            set { _peng_cishu = value; }
            get { return _peng_cishu; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? koushui_flag
        {
            set { _koushui_flag = value; }
            get { return _koushui_flag; }
        }
        /// <summary>
        /// 提问（找回密码）
        /// </summary>
        public string question
        {
            set { _question = value; }
            get { return _question; }
        }
        /// <summary>
        /// 回答（找回密码）
        /// </summary>
        public string answer
        {
            set { _answer = value; }
            get { return _answer; }
        }
        /// <summary>
        /// 微信号
        /// </summary>
        public string weixin
        {
            set { _weixin = value; }
            get { return _weixin; }
        }
        /// <summary>
        /// 支付宝
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
        /// 会员升级时间
        /// </summary>
        public DateTime? huiyuan_sj_date
        {
            set { _huiyuan_sj_date = value; }
            get { return _huiyuan_sj_date; }
        }

        /// <summary>
        /// 默认0    1    2
        /// </summary>
        public int? supply
        {
            set { _supply = value; }
            get { return _supply; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int? cishu1
        {
            set { _cishu1 = value; }
            get { return _cishu1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? cishu2
        {
            set { _cishu2 = value; }
            get { return _cishu2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string city_address
        {
            set { _city_address = value; }
            get { return _city_address; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string born_date
        {
            set { _born_date = value; }
            get { return _born_date; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sf_pinju_src
        {
            set { _sf_pinju_src = value; }
            get { return _sf_pinju_src; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string zl_pinju_src
        {
            set { _zl_pinju_src = value; }
            get { return _zl_pinju_src; }
        }
        #endregion Model


        #region  Method
        public static bool Exists(string UserName, string UserPassword)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from tbl_huiyuan");
            strSql.Append(" where huiyuan_bianhao=@UserName and huiyuan_pass=@UserPassword and huiyuan_suoding=0");// and net_hege=1
            SqlParameter[] parameters = {
					new SqlParameter("@UserName", SqlDbType.NVarChar,50),
					new SqlParameter("@UserPassword", SqlDbType.NVarChar,50)};
            parameters[0].Value = UserName;
            parameters[1].Value = UserPassword;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }
        public static bool Existshui(string UserName, string UserPassword)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from tbl_huiyuan");
            strSql.Append(" where huiyuan_mob=@UserName and huiyuan_pass=@UserPassword and huiyuan_suoding=0");// and net_hege=1
            SqlParameter[] parameters = {
					new SqlParameter("@UserName", SqlDbType.NVarChar,50),
					new SqlParameter("@UserPassword", SqlDbType.NVarChar,50)};
            parameters[0].Value = UserName;
            parameters[1].Value = UserPassword;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }
        public static bool Exists_zuoqu_jihuo(string huiyuan_jiedian)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from tbl_huiyuan");
            strSql.Append(" where huiyuan_jiedian=@huiyuan_jiedian and zuoyou=1 and net_hege=0");
            SqlParameter[] parameters = {
					new SqlParameter("@huiyuan_jiedian", SqlDbType.NVarChar,50) };
            parameters[0].Value = huiyuan_jiedian;
          

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        public static bool Exists_erji(string UserName, string pass_two)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from tbl_huiyuan");
            strSql.Append(" where huiyuan_bianhao=@UserName and pass_two=@pass_two ");
            SqlParameter[] parameters = {
					new SqlParameter("@UserName", SqlDbType.NVarChar,50),
					new SqlParameter("@pass_two", SqlDbType.NVarChar,50)};
            parameters[0].Value = UserName;
            parameters[1].Value = pass_two;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        public static bool Exists_yiji(string UserName, string huiyuan_pass)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from tbl_huiyuan");
            strSql.Append(" where huiyuan_bianhao=@UserName and huiyuan_pass=@huiyuan_pass ");
            SqlParameter[] parameters = {
					new SqlParameter("@UserName", SqlDbType.NVarChar,50),
					new SqlParameter("@huiyuan_pass", SqlDbType.NVarChar,50)};
            parameters[0].Value = UserName;
            parameters[1].Value = huiyuan_pass;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        public static bool Exists_cunzai(string UserName)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from tbl_huiyuan");
            strSql.Append(" where huiyuan_bianhao=@UserName and   net_hege=1 and huiyuan_suoding=0 ");
            SqlParameter[] parameters = {
					new SqlParameter("@UserName", SqlDbType.NVarChar,50)};
		 
            parameters[0].Value = UserName;
 

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        public static bool Exists_zmd(string UserName)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from tbl_huiyuan");
            strSql.Append(" where huiyuan_bianhao=@UserName and     huiyuan_zhuanmai=1 and net_hege=1");
            SqlParameter[] parameters = {
					new SqlParameter("@UserName", SqlDbType.NVarChar,50)};

            parameters[0].Value = UserName;


            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        public static bool Exists_jd_check(string UserName, int zuoyou)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from tbl_huiyuan");
            strSql.Append(" where huiyuan_jiedian=@UserName and zuoyou=@zuoyou ");
            SqlParameter[] parameters = {
					new SqlParameter("@UserName", SqlDbType.NVarChar,50),
					new SqlParameter("@zuoyou", SqlDbType.Int,4)};
            parameters[0].Value = UserName;
            parameters[1].Value = zuoyou;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }
        //判断左右区域
        public static bool Exists_jd_zuocheck(string tuijian, int zuoyou)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from tbl_huiyuan");
            strSql.Append(" where huiyuan_shang_id=@tuijian and net_hege=1 ");
            SqlParameter[] parameters = {
					new SqlParameter("@tuijian", SqlDbType.NVarChar,50),
					new SqlParameter("@zuoyou", SqlDbType.Int,4)};
            parameters[0].Value = tuijian;
            parameters[1].Value = zuoyou;
            if (DbHelperSQL.Exists(strSql.ToString(), parameters) == false && zuoyou !=1)
            {
                return false;

            }
            else
            {
                return true;
            
            }
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public tbl_huiyuan(string huiyuan_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select huiyuan_id,huiyuan_bianhao,huiyuan_name,huiyuan_yu,huiyuan_shenfen_id,huiyuan_mob,huiyuan_address,huiyuan_add_time,huiyuan_pass,huiyuan_yinhang_zh,huiyuan_yinhang_name,huiyuan_yinhang,huiyuan_shang_id,huiyuan_jiebie2,huiyuan_jiebie1,huiyuan_jiebie,huiyuan_zhuanmai,zuoyou,huiyuan_pen_zuo,huiyuan_pen_you,zuo_shen,you_shen,test,dongjie,chongfu_money,net_hege,net_flag,huiyuan_jiedian,huiyuan_zm,huiyuan_qr_date,huiyuan_zhuanmai_sq,zhuanmai_jb,huiyuan_zm_memo,huiyuan_zm_diqu,huiyuan_zm_mingcheng,huiyuan_zm_sq_time,pass_two,huiyuan_qq,qianbao,leftnumber,rightnumber,fenhong_canshu1,youzheng,huiyuan_nc,bank_zhi,huiyuan_email,queren_man,bid,mmid,sid,huiyuan_suoding,chongfu_zong,chongfu_kechu,hang,lie,jiangjing,beizhu,pass_three,jiangjin_yong,jiangjin_zong,flag_1,flag_2,flag_3,flag_4,flag_5,huiyuan_shangshu,huiyuan_shangshu2,zuo_zong,you_zong,flag_ce,flag_money,js_flag,huiyuan_dp_name,kd_flag,tuijian_count,account_type,fh_money,glf_money,temp_count,zong_yeji,ly_count,xuhao,peng_cishu,koushui_flag,question,answer,weixin,zhifubao,xinxi_flag,huiyuan_sj_date,supply,cishu1,cishu2,city_address,born_date,sf_pinju_src,zl_pinju_src ");
            strSql.Append(" FROM [tbl_huiyuan] ");
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
                if (ds.Tables[0].Rows[0]["huiyuan_jiebie2"] != null && ds.Tables[0].Rows[0]["huiyuan_jiebie2"].ToString() != "")
                {
                    this.huiyuan_jiebie2 = int.Parse(ds.Tables[0].Rows[0]["huiyuan_jiebie2"].ToString());
                }
                if (ds.Tables[0].Rows[0]["huiyuan_jiebie1"] != null && ds.Tables[0].Rows[0]["huiyuan_jiebie1"].ToString() != "")
                {
                    this.huiyuan_jiebie1 = int.Parse(ds.Tables[0].Rows[0]["huiyuan_jiebie1"].ToString());
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
                if (ds.Tables[0].Rows[0]["pass_two"] != null)
                {
                    this.pass_two = ds.Tables[0].Rows[0]["pass_two"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_qq"] != null)
                {
                    this.huiyuan_qq = ds.Tables[0].Rows[0]["huiyuan_qq"].ToString();
                }
                if (ds.Tables[0].Rows[0]["qianbao"] != null && ds.Tables[0].Rows[0]["qianbao"].ToString() != "")
                {
                    this.qianbao = decimal.Parse(ds.Tables[0].Rows[0]["qianbao"].ToString());
                }
                if (ds.Tables[0].Rows[0]["leftnumber"] != null)
                {
                    this.leftnumber = ds.Tables[0].Rows[0]["leftnumber"].ToString();
                }
                if (ds.Tables[0].Rows[0]["rightnumber"] != null)
                {
                    this.rightnumber = ds.Tables[0].Rows[0]["rightnumber"].ToString();
                }
                if (ds.Tables[0].Rows[0]["fenhong_canshu1"] != null && ds.Tables[0].Rows[0]["fenhong_canshu1"].ToString() != "")
                {
                    this.fenhong_canshu1 = decimal.Parse(ds.Tables[0].Rows[0]["fenhong_canshu1"].ToString());
                }
                if (ds.Tables[0].Rows[0]["youzheng"] != null)
                {
                    this.youzheng = ds.Tables[0].Rows[0]["youzheng"].ToString();
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
                if (ds.Tables[0].Rows[0]["hang"] != null && ds.Tables[0].Rows[0]["hang"].ToString() != "")
                {
                    this.hang = int.Parse(ds.Tables[0].Rows[0]["hang"].ToString());
                }
                if (ds.Tables[0].Rows[0]["lie"] != null && ds.Tables[0].Rows[0]["lie"].ToString() != "")
                {
                    this.lie = int.Parse(ds.Tables[0].Rows[0]["lie"].ToString());
                }
                if (ds.Tables[0].Rows[0]["jiangjing"] != null && ds.Tables[0].Rows[0]["jiangjing"].ToString() != "")
                {
                    this.jiangjing = decimal.Parse(ds.Tables[0].Rows[0]["jiangjing"].ToString());
                }
                if (ds.Tables[0].Rows[0]["beizhu"] != null)
                {
                    this.beizhu = ds.Tables[0].Rows[0]["beizhu"].ToString();
                }
                if (ds.Tables[0].Rows[0]["pass_three"] != null)
                {
                    this.pass_three = ds.Tables[0].Rows[0]["pass_three"].ToString();
                }
                if (ds.Tables[0].Rows[0]["jiangjin_yong"] != null && ds.Tables[0].Rows[0]["jiangjin_yong"].ToString() != "")
                {
                    this.jiangjin_yong = decimal.Parse(ds.Tables[0].Rows[0]["jiangjin_yong"].ToString());
                }
                if (ds.Tables[0].Rows[0]["jiangjin_zong"] != null && ds.Tables[0].Rows[0]["jiangjin_zong"].ToString() != "")
                {
                    this.jiangjin_zong = decimal.Parse(ds.Tables[0].Rows[0]["jiangjin_zong"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_1"] != null && ds.Tables[0].Rows[0]["flag_1"].ToString() != "")
                {
                    this.flag_1 = int.Parse(ds.Tables[0].Rows[0]["flag_1"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_2"] != null && ds.Tables[0].Rows[0]["flag_2"].ToString() != "")
                {
                    this.flag_2 = int.Parse(ds.Tables[0].Rows[0]["flag_2"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_3"] != null && ds.Tables[0].Rows[0]["flag_3"].ToString() != "")
                {
                    this.flag_3 = int.Parse(ds.Tables[0].Rows[0]["flag_3"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_4"] != null && ds.Tables[0].Rows[0]["flag_4"].ToString() != "")
                {
                    this.flag_4 = int.Parse(ds.Tables[0].Rows[0]["flag_4"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_5"] != null && ds.Tables[0].Rows[0]["flag_5"].ToString() != "")
                {
                    this.flag_5 = int.Parse(ds.Tables[0].Rows[0]["flag_5"].ToString());
                }
                if (ds.Tables[0].Rows[0]["huiyuan_shangshu"] != null)
                {
                    this.huiyuan_shangshu = ds.Tables[0].Rows[0]["huiyuan_shangshu"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_shangshu2"] != null)
                {
                    this.huiyuan_shangshu2 = ds.Tables[0].Rows[0]["huiyuan_shangshu2"].ToString();
                }
                if (ds.Tables[0].Rows[0]["zuo_zong"] != null && ds.Tables[0].Rows[0]["zuo_zong"].ToString() != "")
                {
                    this.zuo_zong = decimal.Parse(ds.Tables[0].Rows[0]["zuo_zong"].ToString());
                }
                if (ds.Tables[0].Rows[0]["you_zong"] != null && ds.Tables[0].Rows[0]["you_zong"].ToString() != "")
                {
                    this.you_zong = decimal.Parse(ds.Tables[0].Rows[0]["you_zong"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_ce"] != null && ds.Tables[0].Rows[0]["flag_ce"].ToString() != "")
                {
                    this.flag_ce = int.Parse(ds.Tables[0].Rows[0]["flag_ce"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_money"] != null && ds.Tables[0].Rows[0]["flag_money"].ToString() != "")
                {
                    this.flag_money = decimal.Parse(ds.Tables[0].Rows[0]["flag_money"].ToString());
                }
                if (ds.Tables[0].Rows[0]["js_flag"] != null && ds.Tables[0].Rows[0]["js_flag"].ToString() != "")
                {
                    this.js_flag = int.Parse(ds.Tables[0].Rows[0]["js_flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["huiyuan_dp_name"] != null)
                {
                    this.huiyuan_dp_name = ds.Tables[0].Rows[0]["huiyuan_dp_name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["kd_flag"] != null && ds.Tables[0].Rows[0]["kd_flag"].ToString() != "")
                {
                    this.kd_flag = int.Parse(ds.Tables[0].Rows[0]["kd_flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["tuijian_count"] != null && ds.Tables[0].Rows[0]["tuijian_count"].ToString() != "")
                {
                    this.tuijian_count = int.Parse(ds.Tables[0].Rows[0]["tuijian_count"].ToString());
                }
                if (ds.Tables[0].Rows[0]["account_type"] != null && ds.Tables[0].Rows[0]["account_type"].ToString() != "")
                {
                    this.account_type = int.Parse(ds.Tables[0].Rows[0]["account_type"].ToString());
                }
                if (ds.Tables[0].Rows[0]["fh_money"] != null && ds.Tables[0].Rows[0]["fh_money"].ToString() != "")
                {
                    this.fh_money = decimal.Parse(ds.Tables[0].Rows[0]["fh_money"].ToString());
                }
                if (ds.Tables[0].Rows[0]["glf_money"] != null && ds.Tables[0].Rows[0]["glf_money"].ToString() != "")
                {
                    this.glf_money = decimal.Parse(ds.Tables[0].Rows[0]["glf_money"].ToString());
                }
                if (ds.Tables[0].Rows[0]["temp_count"] != null && ds.Tables[0].Rows[0]["temp_count"].ToString() != "")
                {
                    this.temp_count = int.Parse(ds.Tables[0].Rows[0]["temp_count"].ToString());
                }
                if (ds.Tables[0].Rows[0]["zong_yeji"] != null && ds.Tables[0].Rows[0]["zong_yeji"].ToString() != "")
                {
                    this.zong_yeji = decimal.Parse(ds.Tables[0].Rows[0]["zong_yeji"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ly_count"] != null && ds.Tables[0].Rows[0]["ly_count"].ToString() != "")
                {
                    this.ly_count = int.Parse(ds.Tables[0].Rows[0]["ly_count"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xuhao"] != null && ds.Tables[0].Rows[0]["xuhao"].ToString() != "")
                {
                    this.xuhao = int.Parse(ds.Tables[0].Rows[0]["xuhao"].ToString());
                }
                if (ds.Tables[0].Rows[0]["peng_cishu"] != null && ds.Tables[0].Rows[0]["peng_cishu"].ToString() != "")
                {
                    this.peng_cishu = int.Parse(ds.Tables[0].Rows[0]["peng_cishu"].ToString());
                }
                if (ds.Tables[0].Rows[0]["koushui_flag"] != null && ds.Tables[0].Rows[0]["koushui_flag"].ToString() != "")
                {
                    this.koushui_flag = int.Parse(ds.Tables[0].Rows[0]["koushui_flag"].ToString());
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
                if (ds.Tables[0].Rows[0]["huiyuan_sj_date"] != null && ds.Tables[0].Rows[0]["huiyuan_sj_date"].ToString() != "")
                {
                    this.huiyuan_sj_date = DateTime.Parse(ds.Tables[0].Rows[0]["huiyuan_sj_date"].ToString());
                }
                if (ds.Tables[0].Rows[0]["supply"] != null && ds.Tables[0].Rows[0]["supply"].ToString() != "")
                {
                    this.supply = int.Parse(ds.Tables[0].Rows[0]["supply"].ToString());
                }
                if (ds.Tables[0].Rows[0]["cishu1"] != null && ds.Tables[0].Rows[0]["cishu1"].ToString() != "")
                {
                    this.cishu1 = int.Parse(ds.Tables[0].Rows[0]["cishu1"].ToString());
                }
                if (ds.Tables[0].Rows[0]["cishu2"] != null && ds.Tables[0].Rows[0]["cishu2"].ToString() != "")
                {
                    this.cishu2 = int.Parse(ds.Tables[0].Rows[0]["cishu2"].ToString());
                }
                if (ds.Tables[0].Rows[0]["city_address"] != null)
                {
                    this.city_address = ds.Tables[0].Rows[0]["city_address"].ToString();
                }
                if (ds.Tables[0].Rows[0]["born_date"] != null)
                {
                    this.born_date = ds.Tables[0].Rows[0]["born_date"].ToString();
                }
                if (ds.Tables[0].Rows[0]["sf_pinju_src"] != null)
                {
                    this.sf_pinju_src = ds.Tables[0].Rows[0]["sf_pinju_src"].ToString();
                }
                if (ds.Tables[0].Rows[0]["zl_pinju_src"] != null)
                {
                    this.zl_pinju_src = ds.Tables[0].Rows[0]["zl_pinju_src"].ToString();
                }
            }
        }

 	public static bool Exists_tiaojian_check(string str_where)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from tbl_huiyuan");
            strSql.Append(" where " + str_where);
            

            return DbHelperSQL.Exists(strSql.ToString());
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists_hui_id(string huiyuan_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from [tbl_huiyuan]");
            strSql.Append(" where huiyuan_id=@huiyuan_id ");

            SqlParameter[] parameters = {
					new SqlParameter("@huiyuan_id", SqlDbType.NVarChar,-1)};
            parameters[0].Value = huiyuan_id;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


  
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists_hui_bianhao(string bianhao)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from [tbl_huiyuan]");
            strSql.Append(" where huiyuan_bianhao=@huiyuan_bianhao ");

            SqlParameter[] parameters = {
					new SqlParameter("@huiyuan_bianhao", SqlDbType.NVarChar,-1)};
            parameters[0].Value = bianhao;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 是否存在该级别记录
        /// </summary>
        public bool ExistsBM()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from [tbl_huiyuan ]");
            strSql.Append(" where huiyuan_jiebie=@huiyuan_jiebie  ");

            SqlParameter[] parameters = {
					new SqlParameter("@huiyuan_jiebie", SqlDbType.Int,4)};
            parameters[0].Value = huiyuan_jiebie;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }
        /// <summary>

        /// 增加一条数据
        /// </summary>
        public bool Add()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into [tbl_huiyuan] (");
            strSql.Append("huiyuan_id,huiyuan_bianhao,huiyuan_name,huiyuan_yu,huiyuan_shenfen_id,huiyuan_mob,huiyuan_address,huiyuan_add_time,huiyuan_pass,huiyuan_yinhang_zh,huiyuan_yinhang_name,huiyuan_yinhang,huiyuan_shang_id,huiyuan_jiebie2,huiyuan_jiebie1,huiyuan_jiebie,huiyuan_zhuanmai,zuoyou,huiyuan_pen_zuo,huiyuan_pen_you,zuo_shen,you_shen,test,dongjie,chongfu_money,net_hege,net_flag,huiyuan_jiedian,huiyuan_zm,huiyuan_qr_date,huiyuan_zhuanmai_sq,zhuanmai_jb,huiyuan_zm_memo,huiyuan_zm_diqu,huiyuan_zm_mingcheng,huiyuan_zm_sq_time,pass_two,huiyuan_qq,qianbao,leftnumber,rightnumber,fenhong_canshu1,youzheng,huiyuan_nc,bank_zhi,huiyuan_email,queren_man,bid,mmid,sid,huiyuan_suoding,chongfu_zong,chongfu_kechu,hang,lie,jiangjing,beizhu,pass_three,jiangjin_yong,jiangjin_zong,flag_1,flag_2,flag_3,flag_4,flag_5,huiyuan_shangshu,huiyuan_shangshu2,zuo_zong,you_zong,flag_ce,flag_money,js_flag,huiyuan_dp_name,kd_flag,tuijian_count,account_type,fh_money,glf_money,temp_count,zong_yeji,ly_count,xuhao,peng_cishu,koushui_flag,question,answer,weixin,zhifubao,xinxi_flag,huiyuan_sj_date,supply,cishu1,cishu2,city_address,born_date,sf_pinju_src,zl_pinju_src)");
            strSql.Append(" values (");
            strSql.Append("@huiyuan_id,@huiyuan_bianhao,@huiyuan_name,@huiyuan_yu,@huiyuan_shenfen_id,@huiyuan_mob,@huiyuan_address,@huiyuan_add_time,@huiyuan_pass,@huiyuan_yinhang_zh,@huiyuan_yinhang_name,@huiyuan_yinhang,@huiyuan_shang_id,@huiyuan_jiebie2,@huiyuan_jiebie1,@huiyuan_jiebie,@huiyuan_zhuanmai,@zuoyou,@huiyuan_pen_zuo,@huiyuan_pen_you,@zuo_shen,@you_shen,@test,@dongjie,@chongfu_money,@net_hege,@net_flag,@huiyuan_jiedian,@huiyuan_zm,@huiyuan_qr_date,@huiyuan_zhuanmai_sq,@zhuanmai_jb,@huiyuan_zm_memo,@huiyuan_zm_diqu,@huiyuan_zm_mingcheng,@huiyuan_zm_sq_time,@pass_two,@huiyuan_qq,@qianbao,@leftnumber,@rightnumber,@fenhong_canshu1,@youzheng,@huiyuan_nc,@bank_zhi,@huiyuan_email,@queren_man,@bid,@mmid,@sid,@huiyuan_suoding,@chongfu_zong,@chongfu_kechu,@hang,@lie,@jiangjing,@beizhu,@pass_three,@jiangjin_yong,@jiangjin_zong,@flag_1,@flag_2,@flag_3,@flag_4,@flag_5,@huiyuan_shangshu,@huiyuan_shangshu2,@zuo_zong,@you_zong,@flag_ce,@flag_money,@js_flag,@huiyuan_dp_name,@kd_flag,@tuijian_count,@account_type,@fh_money,@glf_money,@temp_count,@zong_yeji,@ly_count,@xuhao,@peng_cishu,@koushui_flag,@question,@answer,@weixin,@zhifubao,@xinxi_flag,@huiyuan_sj_date,@supply,@cishu1,@cishu2,@city_address,@born_date,@sf_pinju_src,@zl_pinju_src)");
            SqlParameter[] parameters = {
					new SqlParameter("@huiyuan_id", SqlDbType.NVarChar,50),
					new SqlParameter("@huiyuan_bianhao", SqlDbType.NVarChar,50),
					new SqlParameter("@huiyuan_name", SqlDbType.NVarChar,50),
					new SqlParameter("@huiyuan_yu", SqlDbType.Money,8),
					new SqlParameter("@huiyuan_shenfen_id", SqlDbType.NVarChar,50),
					new SqlParameter("@huiyuan_mob", SqlDbType.NVarChar,50),
					new SqlParameter("@huiyuan_address", SqlDbType.NVarChar,100),
					new SqlParameter("@huiyuan_add_time", SqlDbType.DateTime),
					new SqlParameter("@huiyuan_pass", SqlDbType.NVarChar,50),
					new SqlParameter("@huiyuan_yinhang_zh", SqlDbType.NVarChar,50),
					new SqlParameter("@huiyuan_yinhang_name", SqlDbType.NVarChar,50),
					new SqlParameter("@huiyuan_yinhang", SqlDbType.NVarChar,50),
					new SqlParameter("@huiyuan_shang_id", SqlDbType.NVarChar,50),
					new SqlParameter("@huiyuan_jiebie2", SqlDbType.Int,4),
					new SqlParameter("@huiyuan_jiebie1", SqlDbType.Int,4),
					new SqlParameter("@huiyuan_jiebie", SqlDbType.Int,4),
					new SqlParameter("@huiyuan_zhuanmai", SqlDbType.Int,4),
					new SqlParameter("@zuoyou", SqlDbType.Int,4),
					new SqlParameter("@huiyuan_pen_zuo", SqlDbType.Int,4),
					new SqlParameter("@huiyuan_pen_you", SqlDbType.Int,4),
					new SqlParameter("@zuo_shen", SqlDbType.Money,8),
					new SqlParameter("@you_shen", SqlDbType.Money,8),
					new SqlParameter("@test", SqlDbType.NVarChar,50),
					new SqlParameter("@dongjie", SqlDbType.Int,4),
					new SqlParameter("@chongfu_money", SqlDbType.Money,8),
					new SqlParameter("@net_hege", SqlDbType.Int,4),
					new SqlParameter("@net_flag", SqlDbType.Int,4),
					new SqlParameter("@huiyuan_jiedian", SqlDbType.NVarChar,50),
					new SqlParameter("@huiyuan_zm", SqlDbType.NVarChar,50),
					new SqlParameter("@huiyuan_qr_date", SqlDbType.DateTime),
					new SqlParameter("@huiyuan_zhuanmai_sq", SqlDbType.Int,4),
					new SqlParameter("@zhuanmai_jb", SqlDbType.Int,4),
					new SqlParameter("@huiyuan_zm_memo", SqlDbType.Text),
					new SqlParameter("@huiyuan_zm_diqu", SqlDbType.NVarChar,50),
					new SqlParameter("@huiyuan_zm_mingcheng", SqlDbType.NVarChar,50),
					new SqlParameter("@huiyuan_zm_sq_time", SqlDbType.DateTime),
					new SqlParameter("@pass_two", SqlDbType.NVarChar,50),
					new SqlParameter("@huiyuan_qq", SqlDbType.NVarChar,50),
					new SqlParameter("@qianbao", SqlDbType.Money,8),
					new SqlParameter("@leftnumber", SqlDbType.Char,9),
					new SqlParameter("@rightnumber", SqlDbType.Char,9),
					new SqlParameter("@fenhong_canshu1", SqlDbType.Money,8),
					new SqlParameter("@youzheng", SqlDbType.NVarChar,50),
					new SqlParameter("@huiyuan_nc", SqlDbType.NVarChar,50),
					new SqlParameter("@bank_zhi", SqlDbType.NVarChar,50),
					new SqlParameter("@huiyuan_email", SqlDbType.NVarChar,50),
					new SqlParameter("@queren_man", SqlDbType.NVarChar,50),
					new SqlParameter("@bid", SqlDbType.Int,4),
					new SqlParameter("@mmid", SqlDbType.Int,4),
					new SqlParameter("@sid", SqlDbType.Int,4),
					new SqlParameter("@huiyuan_suoding", SqlDbType.Int,4),
					new SqlParameter("@chongfu_zong", SqlDbType.Money,8),
					new SqlParameter("@chongfu_kechu", SqlDbType.Money,8),
					new SqlParameter("@hang", SqlDbType.Int,4),
					new SqlParameter("@lie", SqlDbType.Int,4),
					new SqlParameter("@jiangjing", SqlDbType.Money,8),
					new SqlParameter("@beizhu", SqlDbType.NVarChar,50),
					new SqlParameter("@pass_three", SqlDbType.NVarChar,50),
					new SqlParameter("@jiangjin_yong", SqlDbType.Money,8),
					new SqlParameter("@jiangjin_zong", SqlDbType.Money,8),
					new SqlParameter("@flag_1", SqlDbType.Int,4),
					new SqlParameter("@flag_2", SqlDbType.Int,4),
					new SqlParameter("@flag_3", SqlDbType.Int,4),
					new SqlParameter("@flag_4", SqlDbType.Int,4),
					new SqlParameter("@flag_5", SqlDbType.Int,4),
					new SqlParameter("@huiyuan_shangshu", SqlDbType.VarChar,8000),
					new SqlParameter("@huiyuan_shangshu2", SqlDbType.VarChar,8000),
					new SqlParameter("@zuo_zong", SqlDbType.Money,8),
					new SqlParameter("@you_zong", SqlDbType.Money,8),
					new SqlParameter("@flag_ce", SqlDbType.Int,4),
					new SqlParameter("@flag_money", SqlDbType.Money,8),
					new SqlParameter("@js_flag", SqlDbType.Int,4),
					new SqlParameter("@huiyuan_dp_name", SqlDbType.VarChar,50),
					new SqlParameter("@kd_flag", SqlDbType.Int,4),
					new SqlParameter("@tuijian_count", SqlDbType.Int,4),
					new SqlParameter("@account_type", SqlDbType.Int,4),
					new SqlParameter("@fh_money", SqlDbType.Money,8),
					new SqlParameter("@glf_money", SqlDbType.Money,8),
					new SqlParameter("@temp_count", SqlDbType.Int,4),
					new SqlParameter("@zong_yeji", SqlDbType.Money,8),
					new SqlParameter("@ly_count", SqlDbType.Int,4),
					new SqlParameter("@xuhao", SqlDbType.Int,4),
					new SqlParameter("@peng_cishu", SqlDbType.Int,4),
					new SqlParameter("@koushui_flag", SqlDbType.Int,4),
					new SqlParameter("@question", SqlDbType.VarChar,110),
					new SqlParameter("@answer", SqlDbType.VarChar,110),
					new SqlParameter("@weixin", SqlDbType.VarChar,8000),
					new SqlParameter("@zhifubao", SqlDbType.VarChar,150),
					new SqlParameter("@xinxi_flag", SqlDbType.Int,4),
					new SqlParameter("@huiyuan_sj_date", SqlDbType.DateTime),
                                        new SqlParameter("@supply", SqlDbType.Int,4),
                                        new SqlParameter("@cishu1", SqlDbType.Int,4),
                                        new SqlParameter("@cishu2", SqlDbType.Int,4),
                                        new SqlParameter("@city_address", SqlDbType.NVarChar,200),
					new SqlParameter("@born_date", SqlDbType.VarChar,50),
					new SqlParameter("@sf_pinju_src", SqlDbType.NVarChar,200),
					new SqlParameter("@zl_pinju_src", SqlDbType.NVarChar,200)};
            parameters[0].Value = huiyuan_id;
            parameters[1].Value = huiyuan_bianhao;
            parameters[2].Value = huiyuan_name;
            parameters[3].Value = huiyuan_yu;
            parameters[4].Value = huiyuan_shenfen_id;
            parameters[5].Value = huiyuan_mob;
            parameters[6].Value = huiyuan_address;
            parameters[7].Value = huiyuan_add_time;
            parameters[8].Value = huiyuan_pass;
            parameters[9].Value = huiyuan_yinhang_zh;
            parameters[10].Value = huiyuan_yinhang_name;
            parameters[11].Value = huiyuan_yinhang;
            parameters[12].Value = huiyuan_shang_id;
            parameters[13].Value = huiyuan_jiebie2;
            parameters[14].Value = huiyuan_jiebie1;
            parameters[15].Value = huiyuan_jiebie;
            parameters[16].Value = huiyuan_zhuanmai;
            parameters[17].Value = zuoyou;
            parameters[18].Value = huiyuan_pen_zuo;
            parameters[19].Value = huiyuan_pen_you;
            parameters[20].Value = zuo_shen;
            parameters[21].Value = you_shen;
            parameters[22].Value = test;
            parameters[23].Value = dongjie;
            parameters[24].Value = chongfu_money;
            parameters[25].Value = net_hege;
            parameters[26].Value = net_flag;
            parameters[27].Value = huiyuan_jiedian;
            parameters[28].Value = huiyuan_zm;
            parameters[29].Value = huiyuan_qr_date;
            parameters[30].Value = huiyuan_zhuanmai_sq;
            parameters[31].Value = zhuanmai_jb;
            parameters[32].Value = huiyuan_zm_memo;
            parameters[33].Value = huiyuan_zm_diqu;
            parameters[34].Value = huiyuan_zm_mingcheng;
            parameters[35].Value = huiyuan_zm_sq_time;
            parameters[36].Value = pass_two;
            parameters[37].Value = huiyuan_qq;
            parameters[38].Value = qianbao;
            parameters[39].Value = leftnumber;
            parameters[40].Value = rightnumber;
            parameters[41].Value = fenhong_canshu1;
            parameters[42].Value = youzheng;
            parameters[43].Value = huiyuan_nc;
            parameters[44].Value = bank_zhi;
            parameters[45].Value = huiyuan_email;
            parameters[46].Value = queren_man;
            parameters[47].Value = bid;
            parameters[48].Value = mmid;
            parameters[49].Value = sid;
            parameters[50].Value = huiyuan_suoding;
            parameters[51].Value = chongfu_zong;
            parameters[52].Value = chongfu_kechu;
            parameters[53].Value = hang;
            parameters[54].Value = lie;
            parameters[55].Value = jiangjing;
            parameters[56].Value = beizhu;
            parameters[57].Value = pass_three;
            parameters[58].Value = jiangjin_yong;
            parameters[59].Value = jiangjin_zong;
            parameters[60].Value = flag_1;
            parameters[61].Value = flag_2;
            parameters[62].Value = flag_3;
            parameters[63].Value = flag_4;
            parameters[64].Value = flag_5;
            parameters[65].Value = huiyuan_shangshu;
            parameters[66].Value = huiyuan_shangshu2;
            parameters[67].Value = zuo_zong;
            parameters[68].Value = you_zong;
            parameters[69].Value = flag_ce;
            parameters[70].Value = flag_money;
            parameters[71].Value = js_flag;
            parameters[72].Value = huiyuan_dp_name;
            parameters[73].Value = kd_flag;
            parameters[74].Value = tuijian_count;
            parameters[75].Value = account_type;
            parameters[76].Value = fh_money;
            parameters[77].Value = glf_money;
            parameters[78].Value = temp_count;
            parameters[79].Value = zong_yeji;
            parameters[80].Value = ly_count;
            parameters[81].Value = xuhao;
            parameters[82].Value = peng_cishu;
            parameters[83].Value = koushui_flag;
            parameters[84].Value = question;
            parameters[85].Value = answer;
            parameters[86].Value = weixin;
            parameters[87].Value = zhifubao;
            parameters[88].Value = xinxi_flag;
            parameters[89].Value = huiyuan_sj_date;
            parameters[90].Value = supply;
            parameters[91].Value = cishu1;
            parameters[92].Value = cishu2;
            parameters[93].Value = city_address;
            parameters[94].Value = born_date;
            parameters[95].Value = sf_pinju_src;
            parameters[96].Value = zl_pinju_src;

            int rows=DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// 增加一条数据
        /// </summary>
        public void Add_huiyuan()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("exec   sp_add_huiyuan  " );
            strSql.Append("@huiyuan_id,@huiyuan_name,@huiyuan_shang_id,@zuoyou,@huiyuan_jiedian,@huiyuan_bianhao");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@huiyuan_id", SqlDbType.NVarChar,50),
					new SqlParameter("@huiyuan_name", SqlDbType.NVarChar,50),
					new SqlParameter("@huiyuan_shang_id", SqlDbType.NVarChar,50),
					new SqlParameter("@zuoyou", SqlDbType.Int,4),
					new SqlParameter("@huiyuan_jiedian", SqlDbType.NVarChar,50),
					new SqlParameter("@huiyuan_bianhao", SqlDbType.NVarChar,100)};
				 
				 
            parameters[0].Value = huiyuan_id;
            parameters[1].Value = huiyuan_name;
            parameters[2].Value = huiyuan_shang_id;
            parameters[3].Value = zuoyou;
            parameters[4].Value = huiyuan_jiedian;
            parameters[5].Value = huiyuan_bianhao;
            

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }
        public void Add_huiyuan1()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("exec   sp_add_huiyuan1  ");
            strSql.Append("@huiyuan_id,@huiyuan_name,@huiyuan_shang_id,@zuoyou,@huiyuan_jiedian,@huiyuan_bianhao");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@huiyuan_id", SqlDbType.NVarChar,50),
					new SqlParameter("@huiyuan_name", SqlDbType.NVarChar,50),
					new SqlParameter("@huiyuan_shang_id", SqlDbType.NVarChar,50),
					new SqlParameter("@zuoyou", SqlDbType.Int,4),
					new SqlParameter("@huiyuan_jiedian", SqlDbType.NVarChar,50),
					new SqlParameter("@huiyuan_bianhao", SqlDbType.NVarChar,100)};


            parameters[0].Value = huiyuan_id;
            parameters[1].Value = huiyuan_name;
            parameters[2].Value = huiyuan_shang_id;
            parameters[3].Value = zuoyou;
            parameters[4].Value = huiyuan_jiedian;
            parameters[5].Value = huiyuan_bianhao;


            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 更新是否冻结状态
        /// </summary>
        public bool UpdateStatus()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update [tbl_huiyuan] set ");
            strSql.Append("huiyuan_suoding=@huiyuan_suoding");
            strSql.Append(" where huiyuan_id=@huiyuan_id ");
            SqlParameter[] parameters = {
					new SqlParameter("@huiyuan_suoding", SqlDbType.TinyInt,1),
					new SqlParameter("@huiyuan_id", SqlDbType.NVarChar,50)};
            parameters[0].Value = huiyuan_suoding;
            parameters[1].Value = huiyuan_id;

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
        /// 更新是否封顶状态
        /// </summary>
        public bool Update_fending()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update [tbl_huiyuan] set ");
            strSql.Append("xinxi_flag=@xinxi_flag");
            strSql.Append(" where huiyuan_id=@huiyuan_id ");
            SqlParameter[] parameters = {
					new SqlParameter("@xinxi_flag", SqlDbType.TinyInt,1),
					new SqlParameter("@huiyuan_id", SqlDbType.NVarChar,50)};
            parameters[0].Value = xinxi_flag;
            parameters[1].Value = huiyuan_id;

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
        /// 更新qianbao
        /// </summary>
        public bool Updateqianbao()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update [tbl_huiyuan] set ");
            strSql.Append("qianbao=qianbao+@qianbao");
            strSql.Append(" where huiyuan_id=@huiyuan_id ");
            SqlParameter[] parameters = {
					new SqlParameter("@qianbao", SqlDbType.Money,8),
					new SqlParameter("@huiyuan_id", SqlDbType.NVarChar,50)};
            parameters[0].Value = @qianbao;
            parameters[1].Value = huiyuan_id;

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
        /// 更新qianbao
        /// </summary>
        public bool reducechongfu_money()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update [tbl_huiyuan] set ");
            strSql.Append("chongfu_money=chongfu_money-@chongfu_money");
            strSql.Append(" where huiyuan_id=@huiyuan_id ");
            SqlParameter[] parameters = {
					new SqlParameter("@chongfu_money", SqlDbType.Money,8),
					new SqlParameter("@huiyuan_id", SqlDbType.NVarChar,50)};
            parameters[0].Value = @chongfu_money;
            parameters[1].Value = huiyuan_id;

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
        /// 更新fh_money
        /// </summary>
        public bool Updatefh_money()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update [tbl_huiyuan] set ");
            strSql.Append("fh_money=fh_money+@fh_money");
            strSql.Append(" where huiyuan_id=@huiyuan_id ");
            SqlParameter[] parameters = {
					new SqlParameter("@fh_money", SqlDbType.Money,8),
					new SqlParameter("@huiyuan_id", SqlDbType.NVarChar,50)};
            parameters[0].Value = fh_money;
            parameters[1].Value = huiyuan_id;

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
        /// 更新fh_money
        /// </summary>
        public bool Rdeucefh_money()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update [tbl_huiyuan] set ");
            strSql.Append("fh_money=fh_money-@fh_money");
            strSql.Append(" where huiyuan_id=@huiyuan_id ");
            SqlParameter[] parameters = {
					new SqlParameter("@fh_money", SqlDbType.Money,8),
					new SqlParameter("@huiyuan_id", SqlDbType.NVarChar,50)};
            parameters[0].Value = fh_money;
            parameters[1].Value = huiyuan_id;

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
        /// 更新qianbao
        /// </summary>
        public bool Update_chongfu_money()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update [tbl_huiyuan] set ");
            strSql.Append("chongfu_money=chongfu_money+@chongfu_money");
            strSql.Append(" where huiyuan_id=@huiyuan_id ");
            SqlParameter[] parameters = {
					new SqlParameter("@chongfu_money", SqlDbType.Money,8),
					new SqlParameter("@huiyuan_id", SqlDbType.NVarChar,50)};
            parameters[0].Value = @chongfu_money;
            parameters[1].Value = huiyuan_id;

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
        /// 更新qianbao
        /// </summary>
        public bool Update_chongfu_zong()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update [tbl_huiyuan] set ");
            strSql.Append("chongfu_zong=chongfu_zong+@chongfu_zong");
            strSql.Append(" where huiyuan_id=@huiyuan_id ");
            SqlParameter[] parameters = {
					new SqlParameter("@chongfu_zong", SqlDbType.Money,8),
					new SqlParameter("@huiyuan_id", SqlDbType.NVarChar,50)};
            parameters[0].Value = chongfu_zong;
            parameters[1].Value = huiyuan_id;

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
        /// 更新qianbao
        /// </summary>
        public bool reduce_chongfu_zong()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update [tbl_huiyuan] set ");
            strSql.Append("chongfu_zong=chongfu_zong-@chongfu_zong");
            strSql.Append(" where huiyuan_id=@huiyuan_id ");
            SqlParameter[] parameters = {
					new SqlParameter("@chongfu_zong", SqlDbType.Money,8),
					new SqlParameter("@huiyuan_id", SqlDbType.NVarChar,50)};
            parameters[0].Value = chongfu_zong;
            parameters[1].Value = huiyuan_id;

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
        /// 更新qianbao
        /// </summary>
        public bool reduceqianbao()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update [tbl_huiyuan] set ");
            strSql.Append("fenhong_canshu1=fenhong_canshu1+@qianbao");
            strSql.Append(" where huiyuan_id=@huiyuan_id ");
            SqlParameter[] parameters = {
					new SqlParameter("@qianbao", SqlDbType.Money,8),
					new SqlParameter("@huiyuan_id", SqlDbType.NVarChar,50)};
            parameters[0].Value = @qianbao;
            parameters[1].Value = huiyuan_id;

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
        /// 更新glf_money
        /// </summary>
        public bool Update_glf_money()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update [tbl_huiyuan] set ");
            strSql.Append("glf_money=glf_money+@glf_money");
            strSql.Append(" where huiyuan_id=@huiyuan_id ");
            SqlParameter[] parameters = {
					new SqlParameter("@glf_money", SqlDbType.Money,8),
					new SqlParameter("@huiyuan_id", SqlDbType.NVarChar,50)};
            parameters[0].Value = @glf_money;
            parameters[1].Value = huiyuan_id;

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
        /// 更新jiangjin_zong(减少)
        /// </summary>
        public bool reduce_jiangjin_zong()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update [tbl_huiyuan] set ");
            strSql.Append("jiangjin_yong=jiangjin_yong+@jiangjin_yong");
            strSql.Append(" where huiyuan_id=@huiyuan_id ");
            SqlParameter[] parameters = {
					new SqlParameter("@jiangjin_yong", SqlDbType.Money,8),
					new SqlParameter("@huiyuan_id", SqlDbType.NVarChar,50)};
            parameters[0].Value = @jiangjin_yong;
            parameters[1].Value = huiyuan_id;

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
        /// 更新jiangjin_zong
        /// </summary>
        public bool Update_jiangjin_zong()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update [tbl_huiyuan] set ");
            strSql.Append("jiangjin_zong=jiangjin_zong+@jiangjin_zong");
            strSql.Append(" where huiyuan_id=@huiyuan_id ");
            SqlParameter[] parameters = {
					new SqlParameter("@jiangjin_zong", SqlDbType.Money,8),
					new SqlParameter("@huiyuan_id", SqlDbType.NVarChar,50)};
            parameters[0].Value = jiangjin_zong;
            parameters[1].Value = huiyuan_id;

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
        /// 更新flag
        /// </summary>
        /// <returns></returns>
        public bool Updateflag()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update [tbl_huiyuan] set ");
            strSql.Append("flag_1=@flag_1");
            strSql.Append(" where huiyuan_id=@huiyuan_id ");
            SqlParameter[] parameters = {
                                            new SqlParameter("@flag_1", SqlDbType.Int,4),
                                            new SqlParameter("@huiyuan_id", SqlDbType.NVarChar,50)};
            parameters[0].Value = flag_1;
            parameters[1].Value = huiyuan_id;
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
            strSql.Append("update [tbl_huiyuan] set ");
            strSql.Append("huiyuan_bianhao=@huiyuan_bianhao,");
            strSql.Append("huiyuan_name=@huiyuan_name,");
            strSql.Append("huiyuan_yu=@huiyuan_yu,");
            strSql.Append("huiyuan_shenfen_id=@huiyuan_shenfen_id,");
            strSql.Append("huiyuan_mob=@huiyuan_mob,");
            strSql.Append("huiyuan_address=@huiyuan_address,");
            strSql.Append("huiyuan_add_time=@huiyuan_add_time,");
            strSql.Append("huiyuan_pass=@huiyuan_pass,");
            strSql.Append("huiyuan_yinhang_zh=@huiyuan_yinhang_zh,");
            strSql.Append("huiyuan_yinhang_name=@huiyuan_yinhang_name,");
            strSql.Append("huiyuan_yinhang=@huiyuan_yinhang,");
            strSql.Append("huiyuan_shang_id=@huiyuan_shang_id,");
            strSql.Append("huiyuan_jiebie2=@huiyuan_jiebie2,");
            strSql.Append("huiyuan_jiebie1=@huiyuan_jiebie1,");
            strSql.Append("huiyuan_jiebie=@huiyuan_jiebie,");
            strSql.Append("huiyuan_zhuanmai=@huiyuan_zhuanmai,");
            strSql.Append("zuoyou=@zuoyou,");
            strSql.Append("huiyuan_pen_zuo=@huiyuan_pen_zuo,");
            strSql.Append("huiyuan_pen_you=@huiyuan_pen_you,");
            strSql.Append("zuo_shen=@zuo_shen,");
            strSql.Append("you_shen=@you_shen,");
            strSql.Append("test=@test,");
            strSql.Append("dongjie=@dongjie,");
            strSql.Append("chongfu_money=@chongfu_money,");
            strSql.Append("net_hege=@net_hege,");
            strSql.Append("net_flag=@net_flag,");
            strSql.Append("huiyuan_jiedian=@huiyuan_jiedian,");
            strSql.Append("huiyuan_zm=@huiyuan_zm,");
            strSql.Append("huiyuan_qr_date=@huiyuan_qr_date,");
            strSql.Append("huiyuan_zhuanmai_sq=@huiyuan_zhuanmai_sq,");
            strSql.Append("zhuanmai_jb=@zhuanmai_jb,");
            strSql.Append("huiyuan_zm_memo=@huiyuan_zm_memo,");
            strSql.Append("huiyuan_zm_diqu=@huiyuan_zm_diqu,");
            strSql.Append("huiyuan_zm_mingcheng=@huiyuan_zm_mingcheng,");
            strSql.Append("huiyuan_zm_sq_time=@huiyuan_zm_sq_time,");
            strSql.Append("pass_two=@pass_two,");
            strSql.Append("huiyuan_qq=@huiyuan_qq,");
            strSql.Append("qianbao=@qianbao,");
            strSql.Append("leftnumber=@leftnumber,");
            strSql.Append("rightnumber=@rightnumber,");
            strSql.Append("fenhong_canshu1=@fenhong_canshu1,");
            strSql.Append("youzheng=@youzheng,");
            strSql.Append("huiyuan_nc=@huiyuan_nc,");
            strSql.Append("bank_zhi=@bank_zhi,");
            strSql.Append("huiyuan_email=@huiyuan_email,");
            strSql.Append("queren_man=@queren_man,");
            strSql.Append("bid=@bid,");
            strSql.Append("mmid=@mmid,");
            strSql.Append("sid=@sid,");
            strSql.Append("huiyuan_suoding=@huiyuan_suoding,");
            strSql.Append("chongfu_zong=@chongfu_zong,");
            strSql.Append("chongfu_kechu=@chongfu_kechu,");
            strSql.Append("hang=@hang,");
            strSql.Append("lie=@lie,");
            strSql.Append("jiangjing=@jiangjing,");
            strSql.Append("beizhu=@beizhu,");
            strSql.Append("pass_three=@pass_three,");
            strSql.Append("jiangjin_yong=@jiangjin_yong,");
            strSql.Append("jiangjin_zong=@jiangjin_zong,");
            strSql.Append("flag_1=@flag_1,");
            strSql.Append("flag_2=@flag_2,");
            strSql.Append("flag_3=@flag_3,");
            strSql.Append("flag_4=@flag_4,");
            strSql.Append("flag_5=@flag_5,");
            strSql.Append("huiyuan_shangshu=@huiyuan_shangshu,");
            strSql.Append("huiyuan_shangshu2=@huiyuan_shangshu2,");
            strSql.Append("zuo_zong=@zuo_zong,");
            strSql.Append("you_zong=@you_zong,");
            strSql.Append("flag_ce=@flag_ce,");
            strSql.Append("flag_money=@flag_money,");
            strSql.Append("js_flag=@js_flag,");
            strSql.Append("huiyuan_dp_name=@huiyuan_dp_name,");
            strSql.Append("kd_flag=@kd_flag,");
            strSql.Append("tuijian_count=@tuijian_count,");
            strSql.Append("account_type=@account_type,");
            strSql.Append("fh_money=@fh_money,");
            strSql.Append("glf_money=@glf_money,");
            strSql.Append("temp_count=@temp_count,");
            strSql.Append("zong_yeji=@zong_yeji,");
            strSql.Append("ly_count=@ly_count,");
            strSql.Append("xuhao=@xuhao,");
            strSql.Append("peng_cishu=@peng_cishu,");
            strSql.Append("koushui_flag=@koushui_flag,");
            strSql.Append("question=@question,");
            strSql.Append("answer=@answer,");
            strSql.Append("weixin=@weixin,");
            strSql.Append("zhifubao=@zhifubao,");
            strSql.Append("xinxi_flag=@xinxi_flag,");
            strSql.Append("huiyuan_sj_date=@huiyuan_sj_date,");
            strSql.Append("cishu1=@cishu1,");
            strSql.Append("cishu2=@cishu2,");
            strSql.Append("supply=@supply,");
            strSql.Append("city_address=@city_address,");
            strSql.Append("born_date=@born_date,");
            strSql.Append("sf_pinju_src=@sf_pinju_src,");
            strSql.Append("zl_pinju_src=@zl_pinju_src");
            strSql.Append(" where huiyuan_id=@huiyuan_id ");
            SqlParameter[] parameters = {
					new SqlParameter("@huiyuan_bianhao", SqlDbType.NVarChar,50),
					new SqlParameter("@huiyuan_name", SqlDbType.NVarChar,50),
					new SqlParameter("@huiyuan_yu", SqlDbType.Money,8),
					new SqlParameter("@huiyuan_shenfen_id", SqlDbType.NVarChar,50),
					new SqlParameter("@huiyuan_mob", SqlDbType.NVarChar,50),
					new SqlParameter("@huiyuan_address", SqlDbType.NVarChar,1000),
					new SqlParameter("@huiyuan_add_time", SqlDbType.DateTime),
					new SqlParameter("@huiyuan_pass", SqlDbType.NVarChar,50),
					new SqlParameter("@huiyuan_yinhang_zh", SqlDbType.NVarChar,50),
					new SqlParameter("@huiyuan_yinhang_name", SqlDbType.NVarChar,50),
					new SqlParameter("@huiyuan_yinhang", SqlDbType.NVarChar,50),
					new SqlParameter("@huiyuan_shang_id", SqlDbType.NVarChar,50),
					new SqlParameter("@huiyuan_jiebie2", SqlDbType.Int,4),
					new SqlParameter("@huiyuan_jiebie1", SqlDbType.Int,4),
					new SqlParameter("@huiyuan_jiebie", SqlDbType.Int,4),
					new SqlParameter("@huiyuan_zhuanmai", SqlDbType.Int,4),
					new SqlParameter("@zuoyou", SqlDbType.Int,4),
					new SqlParameter("@huiyuan_pen_zuo", SqlDbType.Int,4),
					new SqlParameter("@huiyuan_pen_you", SqlDbType.Int,4),
					new SqlParameter("@zuo_shen", SqlDbType.Money,8),
					new SqlParameter("@you_shen", SqlDbType.Money,8),
					new SqlParameter("@test", SqlDbType.NVarChar,50),
					new SqlParameter("@dongjie", SqlDbType.Int,4),
					new SqlParameter("@chongfu_money", SqlDbType.Money,8),
					new SqlParameter("@net_hege", SqlDbType.Int,4),
					new SqlParameter("@net_flag", SqlDbType.Int,4),
					new SqlParameter("@huiyuan_jiedian", SqlDbType.NVarChar,50),
					new SqlParameter("@huiyuan_zm", SqlDbType.NVarChar,50),
					new SqlParameter("@huiyuan_qr_date", SqlDbType.DateTime),
					new SqlParameter("@huiyuan_zhuanmai_sq", SqlDbType.Int,4),
					new SqlParameter("@zhuanmai_jb", SqlDbType.Int,4),
					new SqlParameter("@huiyuan_zm_memo", SqlDbType.Text),
					new SqlParameter("@huiyuan_zm_diqu", SqlDbType.NVarChar,50),
					new SqlParameter("@huiyuan_zm_mingcheng", SqlDbType.NVarChar,50),
					new SqlParameter("@huiyuan_zm_sq_time", SqlDbType.DateTime),
					new SqlParameter("@pass_two", SqlDbType.NVarChar,50),
					new SqlParameter("@huiyuan_qq", SqlDbType.NVarChar,50),
					new SqlParameter("@qianbao", SqlDbType.Money,8),
					new SqlParameter("@leftnumber", SqlDbType.Char,9),
					new SqlParameter("@rightnumber", SqlDbType.Char,9),
					new SqlParameter("@fenhong_canshu1", SqlDbType.Money,8),
					new SqlParameter("@youzheng", SqlDbType.NVarChar,50),
					new SqlParameter("@huiyuan_nc", SqlDbType.NVarChar,50),
					new SqlParameter("@bank_zhi", SqlDbType.NVarChar,50),
					new SqlParameter("@huiyuan_email", SqlDbType.NVarChar,50),
					new SqlParameter("@queren_man", SqlDbType.NVarChar,50),
					new SqlParameter("@bid", SqlDbType.Int,4),
					new SqlParameter("@mmid", SqlDbType.Int,4),
					new SqlParameter("@sid", SqlDbType.Int,4),
					new SqlParameter("@huiyuan_suoding", SqlDbType.Int,4),
					new SqlParameter("@chongfu_zong", SqlDbType.Money,8),
					new SqlParameter("@chongfu_kechu", SqlDbType.Money,8),
					new SqlParameter("@hang", SqlDbType.Int,4),
					new SqlParameter("@lie", SqlDbType.Int,4),
					new SqlParameter("@jiangjing", SqlDbType.Money,8),
					new SqlParameter("@beizhu", SqlDbType.NVarChar,50),
					new SqlParameter("@pass_three", SqlDbType.NVarChar,50),
					new SqlParameter("@jiangjin_yong", SqlDbType.Money,8),
					new SqlParameter("@jiangjin_zong", SqlDbType.Money,8),
					new SqlParameter("@flag_1", SqlDbType.Int,4),
					new SqlParameter("@flag_2", SqlDbType.Int,4),
					new SqlParameter("@flag_3", SqlDbType.Int,4),
					new SqlParameter("@flag_4", SqlDbType.Int,4),
					new SqlParameter("@flag_5", SqlDbType.Int,4),
					new SqlParameter("@huiyuan_shangshu", SqlDbType.VarChar,8000),
					new SqlParameter("@huiyuan_shangshu2", SqlDbType.VarChar,8000),
					new SqlParameter("@zuo_zong", SqlDbType.Money,8),
					new SqlParameter("@you_zong", SqlDbType.Money,8),
					new SqlParameter("@flag_ce", SqlDbType.Int,4),
					new SqlParameter("@flag_money", SqlDbType.Money,8),
					new SqlParameter("@js_flag", SqlDbType.Int,4),
					new SqlParameter("@huiyuan_dp_name", SqlDbType.VarChar,50),
					new SqlParameter("@kd_flag", SqlDbType.Int,4),
					new SqlParameter("@tuijian_count", SqlDbType.Int,4),
					new SqlParameter("@account_type", SqlDbType.Int,4),
					new SqlParameter("@fh_money", SqlDbType.Money,8),
					new SqlParameter("@glf_money", SqlDbType.Money,8),
					new SqlParameter("@temp_count", SqlDbType.Int,4),
					new SqlParameter("@zong_yeji", SqlDbType.Money,8),
					new SqlParameter("@ly_count", SqlDbType.Int,4),
					new SqlParameter("@xuhao", SqlDbType.Int,4),
					new SqlParameter("@peng_cishu", SqlDbType.Int,4),
					new SqlParameter("@koushui_flag", SqlDbType.Int,4),
					new SqlParameter("@question", SqlDbType.VarChar,110),
					new SqlParameter("@answer", SqlDbType.VarChar,110),
					new SqlParameter("@weixin", SqlDbType.VarChar,110),
					new SqlParameter("@zhifubao", SqlDbType.VarChar,150),
					new SqlParameter("@xinxi_flag", SqlDbType.Int,4),
					new SqlParameter("@huiyuan_sj_date", SqlDbType.DateTime),
                     new SqlParameter("@cishu1",SqlDbType.Int,4),
                      new SqlParameter("@cishu2",SqlDbType.Int,4),
                    new SqlParameter("@supply",SqlDbType.Int,4),
                    	new SqlParameter("@city_address", SqlDbType.NVarChar,200),
					new SqlParameter("@born_date", SqlDbType.VarChar,50),
					new SqlParameter("@sf_pinju_src", SqlDbType.NVarChar,200),
					new SqlParameter("@zl_pinju_src", SqlDbType.NVarChar,200),
					new SqlParameter("@huiyuan_id", SqlDbType.NVarChar,50)};
            parameters[0].Value = huiyuan_bianhao;
            parameters[1].Value = huiyuan_name;
            parameters[2].Value = huiyuan_yu;
            parameters[3].Value = huiyuan_shenfen_id;
            parameters[4].Value = huiyuan_mob;
            parameters[5].Value = huiyuan_address;
            parameters[6].Value = huiyuan_add_time;
            parameters[7].Value = huiyuan_pass;
            parameters[8].Value = huiyuan_yinhang_zh;
            parameters[9].Value = huiyuan_yinhang_name;
            parameters[10].Value = huiyuan_yinhang;
            parameters[11].Value = huiyuan_shang_id;
            parameters[12].Value = huiyuan_jiebie2;
            parameters[13].Value = huiyuan_jiebie1;
            parameters[14].Value = huiyuan_jiebie;
            parameters[15].Value = huiyuan_zhuanmai;
            parameters[16].Value = zuoyou;
            parameters[17].Value = huiyuan_pen_zuo;
            parameters[18].Value = huiyuan_pen_you;
            parameters[19].Value = zuo_shen;
            parameters[20].Value = you_shen;
            parameters[21].Value = test;
            parameters[22].Value = dongjie;
            parameters[23].Value = chongfu_money;
            parameters[24].Value = net_hege;
            parameters[25].Value = net_flag;
            parameters[26].Value = huiyuan_jiedian;
            parameters[27].Value = huiyuan_zm;
            parameters[28].Value = huiyuan_qr_date;
            parameters[29].Value = huiyuan_zhuanmai_sq;
            parameters[30].Value = zhuanmai_jb;
            parameters[31].Value = huiyuan_zm_memo;
            parameters[32].Value = huiyuan_zm_diqu;
            parameters[33].Value = huiyuan_zm_mingcheng;
            parameters[34].Value = huiyuan_zm_sq_time;
            parameters[35].Value = pass_two;
            parameters[36].Value = huiyuan_qq;
            parameters[37].Value = qianbao;
            parameters[38].Value = leftnumber;
            parameters[39].Value = rightnumber;
            parameters[40].Value = fenhong_canshu1;
            parameters[41].Value = youzheng;
            parameters[42].Value = huiyuan_nc;
            parameters[43].Value = bank_zhi;
            parameters[44].Value = huiyuan_email;
            parameters[45].Value = queren_man;
            parameters[46].Value = bid;
            parameters[47].Value = mmid;
            parameters[48].Value = sid;
            parameters[49].Value = huiyuan_suoding;
            parameters[50].Value = chongfu_zong;
            parameters[51].Value = chongfu_kechu;
            parameters[52].Value = hang;
            parameters[53].Value = lie;
            parameters[54].Value = jiangjing;
            parameters[55].Value = beizhu;
            parameters[56].Value = pass_three;
            parameters[57].Value = jiangjin_yong;
            parameters[58].Value = jiangjin_zong;
            parameters[59].Value = flag_1;
            parameters[60].Value = flag_2;
            parameters[61].Value = flag_3;
            parameters[62].Value = flag_4;
            parameters[63].Value = flag_5;
            parameters[64].Value = huiyuan_shangshu;
            parameters[65].Value = huiyuan_shangshu2;
            parameters[66].Value = zuo_zong;
            parameters[67].Value = you_zong;
            parameters[68].Value = flag_ce;
            parameters[69].Value = flag_money;
            parameters[70].Value = js_flag;
            parameters[71].Value = huiyuan_dp_name;
            parameters[72].Value = kd_flag;
            parameters[73].Value = tuijian_count;
            parameters[74].Value = account_type;
            parameters[75].Value = fh_money;
            parameters[76].Value = glf_money;
            parameters[77].Value = temp_count;
            parameters[78].Value = zong_yeji;
            parameters[79].Value = ly_count;
            parameters[80].Value = xuhao;
            parameters[81].Value = peng_cishu;
            parameters[82].Value = koushui_flag;
            parameters[83].Value = question;
            parameters[84].Value = answer;
            parameters[85].Value = weixin;
            parameters[86].Value = zhifubao;
            parameters[87].Value = xinxi_flag;
            parameters[88].Value = huiyuan_sj_date;
            parameters[89].Value = cishu1;
            parameters[90].Value = cishu2;
            parameters[91].Value = supply;
            parameters[92].Value = city_address;
            parameters[93].Value = born_date;
            parameters[94].Value = sf_pinju_src;
            parameters[95].Value = zl_pinju_src;
            parameters[96].Value = huiyuan_id;

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
        public bool Delete(string huiyuan_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from [tbl_huiyuan] ");
            strSql.Append(" where huiyuan_id=@huiyuan_id ");
            SqlParameter[] parameters = {
					new SqlParameter("@huiyuan_id", SqlDbType.NVarChar,-1)};
            parameters[0].Value = huiyuan_id;

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
        /// 更新服务中心标志
        /// </summary>
        public bool Update_service_centre()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update [tbl_huiyuan] set ");
            strSql.Append("huiyuan_zhuanmai=@huiyuan_zhuanmai,");
            strSql.Append("huiyuan_zhuanmai_sq=@huiyuan_zhuanmai_sq");
            strSql.Append(" where huiyuan_id=@huiyuan_id ");
            SqlParameter[] parameters = {
					new SqlParameter("@huiyuan_zhuanmai", SqlDbType.TinyInt,1),
                    new SqlParameter("@huiyuan_zhuanmai_sq", SqlDbType.TinyInt,1),
					new SqlParameter("@huiyuan_id", SqlDbType.NVarChar,50)};
            parameters[0].Value = huiyuan_zhuanmai;
            parameters[1].Value = huiyuan_zhuanmai_sq;
            parameters[2].Value = huiyuan_id;

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
        /// 服务中心申请修改
        /// </summary>
        public bool  service_centre_apply()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update [tbl_huiyuan] set ");
            strSql.Append("huiyuan_zhuanmai=@huiyuan_zhuanmai,");
            strSql.Append("huiyuan_zhuanmai_sq=@huiyuan_zhuanmai_sq,");
            strSql.Append("huiyuan_zm_diqu=@huiyuan_zm_diqu, ");
            strSql.Append("huiyuan_zm_sq_time=@huiyuan_zm_sq_time ");
            strSql.Append(" where huiyuan_id=@huiyuan_id ");
            SqlParameter[] parameters = {
					new SqlParameter("@huiyuan_zhuanmai", SqlDbType.TinyInt,1),
                    new SqlParameter("@huiyuan_zhuanmai_sq", SqlDbType.TinyInt,1),
                    new SqlParameter("@huiyuan_zm_diqu", SqlDbType.NVarChar,50),
                    new SqlParameter("@huiyuan_zm_sq_time", SqlDbType.DateTime),
					new SqlParameter("@huiyuan_id", SqlDbType.NVarChar,50)};

            parameters[0].Value = huiyuan_zhuanmai;
            parameters[1].Value = huiyuan_zhuanmai_sq;
            parameters[2].Value = huiyuan_zm_diqu;
            parameters[3].Value = huiyuan_zm_sq_time;
            parameters[4].Value = huiyuan_id;

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
        public void GetModel_hui_beizhu(string huiyuan_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select huiyuan_id,huiyuan_bianhao,huiyuan_name,huiyuan_yu,huiyuan_shenfen_id,huiyuan_mob,huiyuan_address,huiyuan_add_time,huiyuan_pass,huiyuan_yinhang_zh,huiyuan_yinhang_name,huiyuan_yinhang,huiyuan_shang_id,huiyuan_jiebie2,huiyuan_jiebie1,huiyuan_jiebie,huiyuan_zhuanmai,zuoyou,huiyuan_pen_zuo,huiyuan_pen_you,zuo_shen,you_shen,test,dongjie,chongfu_money,net_hege,net_flag,huiyuan_jiedian,huiyuan_zm,huiyuan_qr_date,huiyuan_zhuanmai_sq,zhuanmai_jb,huiyuan_zm_memo,huiyuan_zm_diqu,huiyuan_zm_mingcheng,huiyuan_zm_sq_time,pass_two,huiyuan_qq,qianbao,leftnumber,rightnumber,fenhong_canshu1,youzheng,huiyuan_nc,bank_zhi,huiyuan_email,queren_man,bid,mmid,sid,huiyuan_suoding,chongfu_zong,chongfu_kechu,hang,lie,jiangjing,beizhu,pass_three,jiangjin_yong,jiangjin_zong,flag_1,flag_2,flag_3,flag_4,flag_5,huiyuan_shangshu,huiyuan_shangshu2,zuo_zong,you_zong,flag_ce,flag_money,js_flag,huiyuan_dp_name,kd_flag,tuijian_count,account_type,fh_money,glf_money,temp_count,zong_yeji,ly_count,xuhao,peng_cishu,koushui_flag,question,answer,weixin,zhifubao,xinxi_flag,huiyuan_sj_date,supply,cishu1,cishu2,city_address,born_date,sf_pinju_src,zl_pinju_src ");
            strSql.Append(" FROM [tbl_huiyuan] ");
            strSql.Append(" where beizhu=@huiyuan_id ");
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
                if (ds.Tables[0].Rows[0]["huiyuan_jiebie2"] != null && ds.Tables[0].Rows[0]["huiyuan_jiebie2"].ToString() != "")
                {
                    this.huiyuan_jiebie2 = int.Parse(ds.Tables[0].Rows[0]["huiyuan_jiebie2"].ToString());
                }
                if (ds.Tables[0].Rows[0]["huiyuan_jiebie1"] != null && ds.Tables[0].Rows[0]["huiyuan_jiebie1"].ToString() != "")
                {
                    this.huiyuan_jiebie1 = int.Parse(ds.Tables[0].Rows[0]["huiyuan_jiebie1"].ToString());
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
                if (ds.Tables[0].Rows[0]["pass_two"] != null)
                {
                    this.pass_two = ds.Tables[0].Rows[0]["pass_two"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_qq"] != null)
                {
                    this.huiyuan_qq = ds.Tables[0].Rows[0]["huiyuan_qq"].ToString();
                }
                if (ds.Tables[0].Rows[0]["qianbao"] != null && ds.Tables[0].Rows[0]["qianbao"].ToString() != "")
                {
                    this.qianbao = decimal.Parse(ds.Tables[0].Rows[0]["qianbao"].ToString());
                }
                if (ds.Tables[0].Rows[0]["leftnumber"] != null)
                {
                    this.leftnumber = ds.Tables[0].Rows[0]["leftnumber"].ToString();
                }
                if (ds.Tables[0].Rows[0]["rightnumber"] != null)
                {
                    this.rightnumber = ds.Tables[0].Rows[0]["rightnumber"].ToString();
                }
                if (ds.Tables[0].Rows[0]["fenhong_canshu1"] != null && ds.Tables[0].Rows[0]["fenhong_canshu1"].ToString() != "")
                {
                    this.fenhong_canshu1 = decimal.Parse(ds.Tables[0].Rows[0]["fenhong_canshu1"].ToString());
                }
                if (ds.Tables[0].Rows[0]["youzheng"] != null)
                {
                    this.youzheng = ds.Tables[0].Rows[0]["youzheng"].ToString();
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
                if (ds.Tables[0].Rows[0]["hang"] != null && ds.Tables[0].Rows[0]["hang"].ToString() != "")
                {
                    this.hang = int.Parse(ds.Tables[0].Rows[0]["hang"].ToString());
                }
                if (ds.Tables[0].Rows[0]["lie"] != null && ds.Tables[0].Rows[0]["lie"].ToString() != "")
                {
                    this.lie = int.Parse(ds.Tables[0].Rows[0]["lie"].ToString());
                }
                if (ds.Tables[0].Rows[0]["jiangjing"] != null && ds.Tables[0].Rows[0]["jiangjing"].ToString() != "")
                {
                    this.jiangjing = decimal.Parse(ds.Tables[0].Rows[0]["jiangjing"].ToString());
                }
                if (ds.Tables[0].Rows[0]["beizhu"] != null)
                {
                    this.beizhu = ds.Tables[0].Rows[0]["beizhu"].ToString();
                }
                if (ds.Tables[0].Rows[0]["pass_three"] != null)
                {
                    this.pass_three = ds.Tables[0].Rows[0]["pass_three"].ToString();
                }
                if (ds.Tables[0].Rows[0]["jiangjin_yong"] != null && ds.Tables[0].Rows[0]["jiangjin_yong"].ToString() != "")
                {
                    this.jiangjin_yong = decimal.Parse(ds.Tables[0].Rows[0]["jiangjin_yong"].ToString());
                }
                if (ds.Tables[0].Rows[0]["jiangjin_zong"] != null && ds.Tables[0].Rows[0]["jiangjin_zong"].ToString() != "")
                {
                    this.jiangjin_zong = decimal.Parse(ds.Tables[0].Rows[0]["jiangjin_zong"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_1"] != null && ds.Tables[0].Rows[0]["flag_1"].ToString() != "")
                {
                    this.flag_1 = int.Parse(ds.Tables[0].Rows[0]["flag_1"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_2"] != null && ds.Tables[0].Rows[0]["flag_2"].ToString() != "")
                {
                    this.flag_2 = int.Parse(ds.Tables[0].Rows[0]["flag_2"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_3"] != null && ds.Tables[0].Rows[0]["flag_3"].ToString() != "")
                {
                    this.flag_3 = int.Parse(ds.Tables[0].Rows[0]["flag_3"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_4"] != null && ds.Tables[0].Rows[0]["flag_4"].ToString() != "")
                {
                    this.flag_4 = int.Parse(ds.Tables[0].Rows[0]["flag_4"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_5"] != null && ds.Tables[0].Rows[0]["flag_5"].ToString() != "")
                {
                    this.flag_5 = int.Parse(ds.Tables[0].Rows[0]["flag_5"].ToString());
                }
                if (ds.Tables[0].Rows[0]["huiyuan_shangshu"] != null)
                {
                    this.huiyuan_shangshu = ds.Tables[0].Rows[0]["huiyuan_shangshu"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_shangshu2"] != null)
                {
                    this.huiyuan_shangshu2 = ds.Tables[0].Rows[0]["huiyuan_shangshu2"].ToString();
                }
                if (ds.Tables[0].Rows[0]["zuo_zong"] != null && ds.Tables[0].Rows[0]["zuo_zong"].ToString() != "")
                {
                    this.zuo_zong = decimal.Parse(ds.Tables[0].Rows[0]["zuo_zong"].ToString());
                }
                if (ds.Tables[0].Rows[0]["you_zong"] != null && ds.Tables[0].Rows[0]["you_zong"].ToString() != "")
                {
                    this.you_zong = decimal.Parse(ds.Tables[0].Rows[0]["you_zong"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_ce"] != null && ds.Tables[0].Rows[0]["flag_ce"].ToString() != "")
                {
                    this.flag_ce = int.Parse(ds.Tables[0].Rows[0]["flag_ce"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_money"] != null && ds.Tables[0].Rows[0]["flag_money"].ToString() != "")
                {
                    this.flag_money = decimal.Parse(ds.Tables[0].Rows[0]["flag_money"].ToString());
                }
                if (ds.Tables[0].Rows[0]["js_flag"] != null && ds.Tables[0].Rows[0]["js_flag"].ToString() != "")
                {
                    this.js_flag = int.Parse(ds.Tables[0].Rows[0]["js_flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["huiyuan_dp_name"] != null)
                {
                    this.huiyuan_dp_name = ds.Tables[0].Rows[0]["huiyuan_dp_name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["kd_flag"] != null && ds.Tables[0].Rows[0]["kd_flag"].ToString() != "")
                {
                    this.kd_flag = int.Parse(ds.Tables[0].Rows[0]["kd_flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["tuijian_count"] != null && ds.Tables[0].Rows[0]["tuijian_count"].ToString() != "")
                {
                    this.tuijian_count = int.Parse(ds.Tables[0].Rows[0]["tuijian_count"].ToString());
                }
                if (ds.Tables[0].Rows[0]["account_type"] != null && ds.Tables[0].Rows[0]["account_type"].ToString() != "")
                {
                    this.account_type = int.Parse(ds.Tables[0].Rows[0]["account_type"].ToString());
                }
                if (ds.Tables[0].Rows[0]["fh_money"] != null && ds.Tables[0].Rows[0]["fh_money"].ToString() != "")
                {
                    this.fh_money = decimal.Parse(ds.Tables[0].Rows[0]["fh_money"].ToString());
                }
                if (ds.Tables[0].Rows[0]["glf_money"] != null && ds.Tables[0].Rows[0]["glf_money"].ToString() != "")
                {
                    this.glf_money = decimal.Parse(ds.Tables[0].Rows[0]["glf_money"].ToString());
                }
                if (ds.Tables[0].Rows[0]["temp_count"] != null && ds.Tables[0].Rows[0]["temp_count"].ToString() != "")
                {
                    this.temp_count = int.Parse(ds.Tables[0].Rows[0]["temp_count"].ToString());
                }
                if (ds.Tables[0].Rows[0]["zong_yeji"] != null && ds.Tables[0].Rows[0]["zong_yeji"].ToString() != "")
                {
                    this.zong_yeji = decimal.Parse(ds.Tables[0].Rows[0]["zong_yeji"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ly_count"] != null && ds.Tables[0].Rows[0]["ly_count"].ToString() != "")
                {
                    this.ly_count = int.Parse(ds.Tables[0].Rows[0]["ly_count"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xuhao"] != null && ds.Tables[0].Rows[0]["xuhao"].ToString() != "")
                {
                    this.xuhao = int.Parse(ds.Tables[0].Rows[0]["xuhao"].ToString());
                }
                if (ds.Tables[0].Rows[0]["peng_cishu"] != null && ds.Tables[0].Rows[0]["peng_cishu"].ToString() != "")
                {
                    this.peng_cishu = int.Parse(ds.Tables[0].Rows[0]["peng_cishu"].ToString());
                }
                if (ds.Tables[0].Rows[0]["koushui_flag"] != null && ds.Tables[0].Rows[0]["koushui_flag"].ToString() != "")
                {
                    this.koushui_flag = int.Parse(ds.Tables[0].Rows[0]["koushui_flag"].ToString());
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
                if (ds.Tables[0].Rows[0]["huiyuan_sj_date"] != null && ds.Tables[0].Rows[0]["huiyuan_sj_date"].ToString() != "")
                {
                    this.huiyuan_sj_date = DateTime.Parse(ds.Tables[0].Rows[0]["huiyuan_sj_date"].ToString());
                }
                if (ds.Tables[0].Rows[0]["supply"] != null && ds.Tables[0].Rows[0]["supply"].ToString() != "")
                {
                    this.supply = int.Parse(ds.Tables[0].Rows[0]["supply"].ToString());
                }
                if (ds.Tables[0].Rows[0]["cishu1"] != null && ds.Tables[0].Rows[0]["cishu1"].ToString() != "")
                {
                    this.cishu1 = int.Parse(ds.Tables[0].Rows[0]["cishu1"].ToString());
                }
                if (ds.Tables[0].Rows[0]["cishu2"] != null && ds.Tables[0].Rows[0]["cishu2"].ToString() != "")
                {
                    this.cishu2 = int.Parse(ds.Tables[0].Rows[0]["cishu2"].ToString());
                }
                if (ds.Tables[0].Rows[0]["city_address"] != null)
                {
                    this.city_address = ds.Tables[0].Rows[0]["city_address"].ToString();
                }
                if (ds.Tables[0].Rows[0]["born_date"] != null)
                {
                    this.born_date = ds.Tables[0].Rows[0]["born_date"].ToString();
                }
                if (ds.Tables[0].Rows[0]["sf_pinju_src"] != null)
                {
                    this.sf_pinju_src = ds.Tables[0].Rows[0]["sf_pinju_src"].ToString();
                }
                if (ds.Tables[0].Rows[0]["zl_pinju_src"] != null)
                {
                    this.zl_pinju_src = ds.Tables[0].Rows[0]["zl_pinju_src"].ToString();
                }
            }
        }
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public void GetModel_hui_ticket(string huiyuan_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select huiyuan_id,huiyuan_bianhao,huiyuan_name,huiyuan_yu,huiyuan_shenfen_id,huiyuan_mob,huiyuan_address,huiyuan_add_time,huiyuan_pass,huiyuan_yinhang_zh,huiyuan_yinhang_name,huiyuan_yinhang,huiyuan_shang_id,huiyuan_jiebie2,huiyuan_jiebie1,huiyuan_jiebie,huiyuan_zhuanmai,zuoyou,huiyuan_pen_zuo,huiyuan_pen_you,zuo_shen,you_shen,test,dongjie,chongfu_money,net_hege,net_flag,huiyuan_jiedian,huiyuan_zm,huiyuan_qr_date,huiyuan_zhuanmai_sq,zhuanmai_jb,huiyuan_zm_memo,huiyuan_zm_diqu,huiyuan_zm_mingcheng,huiyuan_zm_sq_time,pass_two,huiyuan_qq,qianbao,leftnumber,rightnumber,fenhong_canshu1,youzheng,huiyuan_nc,bank_zhi,huiyuan_email,queren_man,bid,mmid,sid,huiyuan_suoding,chongfu_zong,chongfu_kechu,hang,lie,jiangjing,beizhu,pass_three,jiangjin_yong,jiangjin_zong,flag_1,flag_2,flag_3,flag_4,flag_5,huiyuan_shangshu,huiyuan_shangshu2,zuo_zong,you_zong,flag_ce,flag_money,js_flag,huiyuan_dp_name,kd_flag,tuijian_count,account_type,fh_money,glf_money,temp_count,zong_yeji,ly_count,xuhao,peng_cishu,koushui_flag,question,answer,weixin,zhifubao,xinxi_flag,huiyuan_sj_date,supply,cishu1,cishu2,city_address,born_date,sf_pinju_src,zl_pinju_src ");
            strSql.Append(" FROM [tbl_huiyuan] ");
            strSql.Append(" where zhifubao=@huiyuan_id ");
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
                if (ds.Tables[0].Rows[0]["huiyuan_jiebie2"] != null && ds.Tables[0].Rows[0]["huiyuan_jiebie2"].ToString() != "")
                {
                    this.huiyuan_jiebie2 = int.Parse(ds.Tables[0].Rows[0]["huiyuan_jiebie2"].ToString());
                }
                if (ds.Tables[0].Rows[0]["huiyuan_jiebie1"] != null && ds.Tables[0].Rows[0]["huiyuan_jiebie1"].ToString() != "")
                {
                    this.huiyuan_jiebie1 = int.Parse(ds.Tables[0].Rows[0]["huiyuan_jiebie1"].ToString());
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
                if (ds.Tables[0].Rows[0]["pass_two"] != null)
                {
                    this.pass_two = ds.Tables[0].Rows[0]["pass_two"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_qq"] != null)
                {
                    this.huiyuan_qq = ds.Tables[0].Rows[0]["huiyuan_qq"].ToString();
                }
                if (ds.Tables[0].Rows[0]["qianbao"] != null && ds.Tables[0].Rows[0]["qianbao"].ToString() != "")
                {
                    this.qianbao = decimal.Parse(ds.Tables[0].Rows[0]["qianbao"].ToString());
                }
                if (ds.Tables[0].Rows[0]["leftnumber"] != null)
                {
                    this.leftnumber = ds.Tables[0].Rows[0]["leftnumber"].ToString();
                }
                if (ds.Tables[0].Rows[0]["rightnumber"] != null)
                {
                    this.rightnumber = ds.Tables[0].Rows[0]["rightnumber"].ToString();
                }
                if (ds.Tables[0].Rows[0]["fenhong_canshu1"] != null && ds.Tables[0].Rows[0]["fenhong_canshu1"].ToString() != "")
                {
                    this.fenhong_canshu1 = decimal.Parse(ds.Tables[0].Rows[0]["fenhong_canshu1"].ToString());
                }
                if (ds.Tables[0].Rows[0]["youzheng"] != null)
                {
                    this.youzheng = ds.Tables[0].Rows[0]["youzheng"].ToString();
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
                if (ds.Tables[0].Rows[0]["hang"] != null && ds.Tables[0].Rows[0]["hang"].ToString() != "")
                {
                    this.hang = int.Parse(ds.Tables[0].Rows[0]["hang"].ToString());
                }
                if (ds.Tables[0].Rows[0]["lie"] != null && ds.Tables[0].Rows[0]["lie"].ToString() != "")
                {
                    this.lie = int.Parse(ds.Tables[0].Rows[0]["lie"].ToString());
                }
                if (ds.Tables[0].Rows[0]["jiangjing"] != null && ds.Tables[0].Rows[0]["jiangjing"].ToString() != "")
                {
                    this.jiangjing = decimal.Parse(ds.Tables[0].Rows[0]["jiangjing"].ToString());
                }
                if (ds.Tables[0].Rows[0]["beizhu"] != null)
                {
                    this.beizhu = ds.Tables[0].Rows[0]["beizhu"].ToString();
                }
                if (ds.Tables[0].Rows[0]["pass_three"] != null)
                {
                    this.pass_three = ds.Tables[0].Rows[0]["pass_three"].ToString();
                }
                if (ds.Tables[0].Rows[0]["jiangjin_yong"] != null && ds.Tables[0].Rows[0]["jiangjin_yong"].ToString() != "")
                {
                    this.jiangjin_yong = decimal.Parse(ds.Tables[0].Rows[0]["jiangjin_yong"].ToString());
                }
                if (ds.Tables[0].Rows[0]["jiangjin_zong"] != null && ds.Tables[0].Rows[0]["jiangjin_zong"].ToString() != "")
                {
                    this.jiangjin_zong = decimal.Parse(ds.Tables[0].Rows[0]["jiangjin_zong"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_1"] != null && ds.Tables[0].Rows[0]["flag_1"].ToString() != "")
                {
                    this.flag_1 = int.Parse(ds.Tables[0].Rows[0]["flag_1"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_2"] != null && ds.Tables[0].Rows[0]["flag_2"].ToString() != "")
                {
                    this.flag_2 = int.Parse(ds.Tables[0].Rows[0]["flag_2"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_3"] != null && ds.Tables[0].Rows[0]["flag_3"].ToString() != "")
                {
                    this.flag_3 = int.Parse(ds.Tables[0].Rows[0]["flag_3"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_4"] != null && ds.Tables[0].Rows[0]["flag_4"].ToString() != "")
                {
                    this.flag_4 = int.Parse(ds.Tables[0].Rows[0]["flag_4"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_5"] != null && ds.Tables[0].Rows[0]["flag_5"].ToString() != "")
                {
                    this.flag_5 = int.Parse(ds.Tables[0].Rows[0]["flag_5"].ToString());
                }
                if (ds.Tables[0].Rows[0]["huiyuan_shangshu"] != null)
                {
                    this.huiyuan_shangshu = ds.Tables[0].Rows[0]["huiyuan_shangshu"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_shangshu2"] != null)
                {
                    this.huiyuan_shangshu2 = ds.Tables[0].Rows[0]["huiyuan_shangshu2"].ToString();
                }
                if (ds.Tables[0].Rows[0]["zuo_zong"] != null && ds.Tables[0].Rows[0]["zuo_zong"].ToString() != "")
                {
                    this.zuo_zong = decimal.Parse(ds.Tables[0].Rows[0]["zuo_zong"].ToString());
                }
                if (ds.Tables[0].Rows[0]["you_zong"] != null && ds.Tables[0].Rows[0]["you_zong"].ToString() != "")
                {
                    this.you_zong = decimal.Parse(ds.Tables[0].Rows[0]["you_zong"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_ce"] != null && ds.Tables[0].Rows[0]["flag_ce"].ToString() != "")
                {
                    this.flag_ce = int.Parse(ds.Tables[0].Rows[0]["flag_ce"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_money"] != null && ds.Tables[0].Rows[0]["flag_money"].ToString() != "")
                {
                    this.flag_money = decimal.Parse(ds.Tables[0].Rows[0]["flag_money"].ToString());
                }
                if (ds.Tables[0].Rows[0]["js_flag"] != null && ds.Tables[0].Rows[0]["js_flag"].ToString() != "")
                {
                    this.js_flag = int.Parse(ds.Tables[0].Rows[0]["js_flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["huiyuan_dp_name"] != null)
                {
                    this.huiyuan_dp_name = ds.Tables[0].Rows[0]["huiyuan_dp_name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["kd_flag"] != null && ds.Tables[0].Rows[0]["kd_flag"].ToString() != "")
                {
                    this.kd_flag = int.Parse(ds.Tables[0].Rows[0]["kd_flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["tuijian_count"] != null && ds.Tables[0].Rows[0]["tuijian_count"].ToString() != "")
                {
                    this.tuijian_count = int.Parse(ds.Tables[0].Rows[0]["tuijian_count"].ToString());
                }
                if (ds.Tables[0].Rows[0]["account_type"] != null && ds.Tables[0].Rows[0]["account_type"].ToString() != "")
                {
                    this.account_type = int.Parse(ds.Tables[0].Rows[0]["account_type"].ToString());
                }
                if (ds.Tables[0].Rows[0]["fh_money"] != null && ds.Tables[0].Rows[0]["fh_money"].ToString() != "")
                {
                    this.fh_money = decimal.Parse(ds.Tables[0].Rows[0]["fh_money"].ToString());
                }
                if (ds.Tables[0].Rows[0]["glf_money"] != null && ds.Tables[0].Rows[0]["glf_money"].ToString() != "")
                {
                    this.glf_money = decimal.Parse(ds.Tables[0].Rows[0]["glf_money"].ToString());
                }
                if (ds.Tables[0].Rows[0]["temp_count"] != null && ds.Tables[0].Rows[0]["temp_count"].ToString() != "")
                {
                    this.temp_count = int.Parse(ds.Tables[0].Rows[0]["temp_count"].ToString());
                }
                if (ds.Tables[0].Rows[0]["zong_yeji"] != null && ds.Tables[0].Rows[0]["zong_yeji"].ToString() != "")
                {
                    this.zong_yeji = decimal.Parse(ds.Tables[0].Rows[0]["zong_yeji"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ly_count"] != null && ds.Tables[0].Rows[0]["ly_count"].ToString() != "")
                {
                    this.ly_count = int.Parse(ds.Tables[0].Rows[0]["ly_count"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xuhao"] != null && ds.Tables[0].Rows[0]["xuhao"].ToString() != "")
                {
                    this.xuhao = int.Parse(ds.Tables[0].Rows[0]["xuhao"].ToString());
                }
                if (ds.Tables[0].Rows[0]["peng_cishu"] != null && ds.Tables[0].Rows[0]["peng_cishu"].ToString() != "")
                {
                    this.peng_cishu = int.Parse(ds.Tables[0].Rows[0]["peng_cishu"].ToString());
                }
                if (ds.Tables[0].Rows[0]["koushui_flag"] != null && ds.Tables[0].Rows[0]["koushui_flag"].ToString() != "")
                {
                    this.koushui_flag = int.Parse(ds.Tables[0].Rows[0]["koushui_flag"].ToString());
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
                if (ds.Tables[0].Rows[0]["huiyuan_sj_date"] != null && ds.Tables[0].Rows[0]["huiyuan_sj_date"].ToString() != "")
                {
                    this.huiyuan_sj_date = DateTime.Parse(ds.Tables[0].Rows[0]["huiyuan_sj_date"].ToString());
                }
                if (ds.Tables[0].Rows[0]["supply"] != null && ds.Tables[0].Rows[0]["supply"].ToString() != "")
                {
                    this.supply = int.Parse(ds.Tables[0].Rows[0]["supply"].ToString());
                }
                if (ds.Tables[0].Rows[0]["cishu1"] != null && ds.Tables[0].Rows[0]["cishu1"].ToString() != "")
                {
                    this.cishu1 = int.Parse(ds.Tables[0].Rows[0]["cishu1"].ToString());
                }
                if (ds.Tables[0].Rows[0]["cishu2"] != null && ds.Tables[0].Rows[0]["cishu2"].ToString() != "")
                {
                    this.cishu2 = int.Parse(ds.Tables[0].Rows[0]["cishu2"].ToString());
                }
                if (ds.Tables[0].Rows[0]["city_address"] != null)
                {
                    this.city_address = ds.Tables[0].Rows[0]["city_address"].ToString();
                }
                if (ds.Tables[0].Rows[0]["born_date"] != null)
                {
                    this.born_date = ds.Tables[0].Rows[0]["born_date"].ToString();
                }
                if (ds.Tables[0].Rows[0]["sf_pinju_src"] != null)
                {
                    this.sf_pinju_src = ds.Tables[0].Rows[0]["sf_pinju_src"].ToString();
                }
                if (ds.Tables[0].Rows[0]["zl_pinju_src"] != null)
                {
                    this.zl_pinju_src = ds.Tables[0].Rows[0]["zl_pinju_src"].ToString();
                }
            }
        }
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public void GetModel_hui_id(string huiyuan_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select huiyuan_id,huiyuan_bianhao,huiyuan_name,huiyuan_yu,huiyuan_shenfen_id,huiyuan_mob,huiyuan_address,huiyuan_add_time,huiyuan_pass,huiyuan_yinhang_zh,huiyuan_yinhang_name,huiyuan_yinhang,huiyuan_shang_id,huiyuan_jiebie2,huiyuan_jiebie1,huiyuan_jiebie,huiyuan_zhuanmai,zuoyou,huiyuan_pen_zuo,huiyuan_pen_you,zuo_shen,you_shen,test,dongjie,chongfu_money,net_hege,net_flag,huiyuan_jiedian,huiyuan_zm,huiyuan_qr_date,huiyuan_zhuanmai_sq,zhuanmai_jb,huiyuan_zm_memo,huiyuan_zm_diqu,huiyuan_zm_mingcheng,huiyuan_zm_sq_time,pass_two,huiyuan_qq,qianbao,leftnumber,rightnumber,fenhong_canshu1,youzheng,huiyuan_nc,bank_zhi,huiyuan_email,queren_man,bid,mmid,sid,huiyuan_suoding,chongfu_zong,chongfu_kechu,hang,lie,jiangjing,beizhu,pass_three,jiangjin_yong,jiangjin_zong,flag_1,flag_2,flag_3,flag_4,flag_5,huiyuan_shangshu,huiyuan_shangshu2,zuo_zong,you_zong,flag_ce,flag_money,js_flag,huiyuan_dp_name,kd_flag,tuijian_count,account_type,fh_money,glf_money,temp_count,zong_yeji,ly_count,xuhao,peng_cishu,koushui_flag,question,answer,weixin,zhifubao,xinxi_flag,huiyuan_sj_date,supply,cishu1,cishu2,city_address,born_date,sf_pinju_src,zl_pinju_src ");
            strSql.Append(" FROM [tbl_huiyuan] ");
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
                if (ds.Tables[0].Rows[0]["huiyuan_jiebie2"] != null && ds.Tables[0].Rows[0]["huiyuan_jiebie2"].ToString() != "")
                {
                    this.huiyuan_jiebie2 = int.Parse(ds.Tables[0].Rows[0]["huiyuan_jiebie2"].ToString());
                }
                if (ds.Tables[0].Rows[0]["huiyuan_jiebie1"] != null && ds.Tables[0].Rows[0]["huiyuan_jiebie1"].ToString() != "")
                {
                    this.huiyuan_jiebie1 = int.Parse(ds.Tables[0].Rows[0]["huiyuan_jiebie1"].ToString());
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
                if (ds.Tables[0].Rows[0]["pass_two"] != null)
                {
                    this.pass_two = ds.Tables[0].Rows[0]["pass_two"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_qq"] != null)
                {
                    this.huiyuan_qq = ds.Tables[0].Rows[0]["huiyuan_qq"].ToString();
                }
                if (ds.Tables[0].Rows[0]["qianbao"] != null && ds.Tables[0].Rows[0]["qianbao"].ToString() != "")
                {
                    this.qianbao = decimal.Parse(ds.Tables[0].Rows[0]["qianbao"].ToString());
                }
                if (ds.Tables[0].Rows[0]["leftnumber"] != null)
                {
                    this.leftnumber = ds.Tables[0].Rows[0]["leftnumber"].ToString();
                }
                if (ds.Tables[0].Rows[0]["rightnumber"] != null)
                {
                    this.rightnumber = ds.Tables[0].Rows[0]["rightnumber"].ToString();
                }
                if (ds.Tables[0].Rows[0]["fenhong_canshu1"] != null && ds.Tables[0].Rows[0]["fenhong_canshu1"].ToString() != "")
                {
                    this.fenhong_canshu1 = decimal.Parse(ds.Tables[0].Rows[0]["fenhong_canshu1"].ToString());
                }
                if (ds.Tables[0].Rows[0]["youzheng"] != null)
                {
                    this.youzheng = ds.Tables[0].Rows[0]["youzheng"].ToString();
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
                if (ds.Tables[0].Rows[0]["hang"] != null && ds.Tables[0].Rows[0]["hang"].ToString() != "")
                {
                    this.hang = int.Parse(ds.Tables[0].Rows[0]["hang"].ToString());
                }
                if (ds.Tables[0].Rows[0]["lie"] != null && ds.Tables[0].Rows[0]["lie"].ToString() != "")
                {
                    this.lie = int.Parse(ds.Tables[0].Rows[0]["lie"].ToString());
                }
                if (ds.Tables[0].Rows[0]["jiangjing"] != null && ds.Tables[0].Rows[0]["jiangjing"].ToString() != "")
                {
                    this.jiangjing = decimal.Parse(ds.Tables[0].Rows[0]["jiangjing"].ToString());
                }
                if (ds.Tables[0].Rows[0]["beizhu"] != null)
                {
                    this.beizhu = ds.Tables[0].Rows[0]["beizhu"].ToString();
                }
                if (ds.Tables[0].Rows[0]["pass_three"] != null)
                {
                    this.pass_three = ds.Tables[0].Rows[0]["pass_three"].ToString();
                }
                if (ds.Tables[0].Rows[0]["jiangjin_yong"] != null && ds.Tables[0].Rows[0]["jiangjin_yong"].ToString() != "")
                {
                    this.jiangjin_yong = decimal.Parse(ds.Tables[0].Rows[0]["jiangjin_yong"].ToString());
                }
                if (ds.Tables[0].Rows[0]["jiangjin_zong"] != null && ds.Tables[0].Rows[0]["jiangjin_zong"].ToString() != "")
                {
                    this.jiangjin_zong = decimal.Parse(ds.Tables[0].Rows[0]["jiangjin_zong"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_1"] != null && ds.Tables[0].Rows[0]["flag_1"].ToString() != "")
                {
                    this.flag_1 = int.Parse(ds.Tables[0].Rows[0]["flag_1"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_2"] != null && ds.Tables[0].Rows[0]["flag_2"].ToString() != "")
                {
                    this.flag_2 = int.Parse(ds.Tables[0].Rows[0]["flag_2"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_3"] != null && ds.Tables[0].Rows[0]["flag_3"].ToString() != "")
                {
                    this.flag_3 = int.Parse(ds.Tables[0].Rows[0]["flag_3"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_4"] != null && ds.Tables[0].Rows[0]["flag_4"].ToString() != "")
                {
                    this.flag_4 = int.Parse(ds.Tables[0].Rows[0]["flag_4"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_5"] != null && ds.Tables[0].Rows[0]["flag_5"].ToString() != "")
                {
                    this.flag_5 = int.Parse(ds.Tables[0].Rows[0]["flag_5"].ToString());
                }
                if (ds.Tables[0].Rows[0]["huiyuan_shangshu"] != null)
                {
                    this.huiyuan_shangshu = ds.Tables[0].Rows[0]["huiyuan_shangshu"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_shangshu2"] != null)
                {
                    this.huiyuan_shangshu2 = ds.Tables[0].Rows[0]["huiyuan_shangshu2"].ToString();
                }
                if (ds.Tables[0].Rows[0]["zuo_zong"] != null && ds.Tables[0].Rows[0]["zuo_zong"].ToString() != "")
                {
                    this.zuo_zong = decimal.Parse(ds.Tables[0].Rows[0]["zuo_zong"].ToString());
                }
                if (ds.Tables[0].Rows[0]["you_zong"] != null && ds.Tables[0].Rows[0]["you_zong"].ToString() != "")
                {
                    this.you_zong = decimal.Parse(ds.Tables[0].Rows[0]["you_zong"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_ce"] != null && ds.Tables[0].Rows[0]["flag_ce"].ToString() != "")
                {
                    this.flag_ce = int.Parse(ds.Tables[0].Rows[0]["flag_ce"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_money"] != null && ds.Tables[0].Rows[0]["flag_money"].ToString() != "")
                {
                    this.flag_money = decimal.Parse(ds.Tables[0].Rows[0]["flag_money"].ToString());
                }
                if (ds.Tables[0].Rows[0]["js_flag"] != null && ds.Tables[0].Rows[0]["js_flag"].ToString() != "")
                {
                    this.js_flag = int.Parse(ds.Tables[0].Rows[0]["js_flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["huiyuan_dp_name"] != null)
                {
                    this.huiyuan_dp_name = ds.Tables[0].Rows[0]["huiyuan_dp_name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["kd_flag"] != null && ds.Tables[0].Rows[0]["kd_flag"].ToString() != "")
                {
                    this.kd_flag = int.Parse(ds.Tables[0].Rows[0]["kd_flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["tuijian_count"] != null && ds.Tables[0].Rows[0]["tuijian_count"].ToString() != "")
                {
                    this.tuijian_count = int.Parse(ds.Tables[0].Rows[0]["tuijian_count"].ToString());
                }
                if (ds.Tables[0].Rows[0]["account_type"] != null && ds.Tables[0].Rows[0]["account_type"].ToString() != "")
                {
                    this.account_type = int.Parse(ds.Tables[0].Rows[0]["account_type"].ToString());
                }
                if (ds.Tables[0].Rows[0]["fh_money"] != null && ds.Tables[0].Rows[0]["fh_money"].ToString() != "")
                {
                    this.fh_money = decimal.Parse(ds.Tables[0].Rows[0]["fh_money"].ToString());
                }
                if (ds.Tables[0].Rows[0]["glf_money"] != null && ds.Tables[0].Rows[0]["glf_money"].ToString() != "")
                {
                    this.glf_money = decimal.Parse(ds.Tables[0].Rows[0]["glf_money"].ToString());
                }
                if (ds.Tables[0].Rows[0]["temp_count"] != null && ds.Tables[0].Rows[0]["temp_count"].ToString() != "")
                {
                    this.temp_count = int.Parse(ds.Tables[0].Rows[0]["temp_count"].ToString());
                }
                if (ds.Tables[0].Rows[0]["zong_yeji"] != null && ds.Tables[0].Rows[0]["zong_yeji"].ToString() != "")
                {
                    this.zong_yeji = decimal.Parse(ds.Tables[0].Rows[0]["zong_yeji"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ly_count"] != null && ds.Tables[0].Rows[0]["ly_count"].ToString() != "")
                {
                    this.ly_count = int.Parse(ds.Tables[0].Rows[0]["ly_count"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xuhao"] != null && ds.Tables[0].Rows[0]["xuhao"].ToString() != "")
                {
                    this.xuhao = int.Parse(ds.Tables[0].Rows[0]["xuhao"].ToString());
                }
                if (ds.Tables[0].Rows[0]["peng_cishu"] != null && ds.Tables[0].Rows[0]["peng_cishu"].ToString() != "")
                {
                    this.peng_cishu = int.Parse(ds.Tables[0].Rows[0]["peng_cishu"].ToString());
                }
                if (ds.Tables[0].Rows[0]["koushui_flag"] != null && ds.Tables[0].Rows[0]["koushui_flag"].ToString() != "")
                {
                    this.koushui_flag = int.Parse(ds.Tables[0].Rows[0]["koushui_flag"].ToString());
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
                if (ds.Tables[0].Rows[0]["huiyuan_sj_date"] != null && ds.Tables[0].Rows[0]["huiyuan_sj_date"].ToString() != "")
                {
                    this.huiyuan_sj_date = DateTime.Parse(ds.Tables[0].Rows[0]["huiyuan_sj_date"].ToString());
                }
                if (ds.Tables[0].Rows[0]["supply"] != null && ds.Tables[0].Rows[0]["supply"].ToString() != "")
                {
                    this.supply = int.Parse(ds.Tables[0].Rows[0]["supply"].ToString());
                }
                if (ds.Tables[0].Rows[0]["cishu1"] != null && ds.Tables[0].Rows[0]["cishu1"].ToString() != "")
                {
                    this.cishu1 = int.Parse(ds.Tables[0].Rows[0]["cishu1"].ToString());
                }
                if (ds.Tables[0].Rows[0]["cishu2"] != null && ds.Tables[0].Rows[0]["cishu2"].ToString() != "")
                {
                    this.cishu2 = int.Parse(ds.Tables[0].Rows[0]["cishu2"].ToString());
                }
                if (ds.Tables[0].Rows[0]["city_address"] != null)
                {
                    this.city_address = ds.Tables[0].Rows[0]["city_address"].ToString();
                }
                if (ds.Tables[0].Rows[0]["born_date"] != null)
                {
                    this.born_date = ds.Tables[0].Rows[0]["born_date"].ToString();
                }
                if (ds.Tables[0].Rows[0]["sf_pinju_src"] != null)
                {
                    this.sf_pinju_src = ds.Tables[0].Rows[0]["sf_pinju_src"].ToString();
                }
                if (ds.Tables[0].Rows[0]["zl_pinju_src"] != null)
                {
                    this.zl_pinju_src = ds.Tables[0].Rows[0]["zl_pinju_src"].ToString();
                }
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public void GetModel_hui_bianhao(string huiyuan_bianhao)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select huiyuan_id,huiyuan_bianhao,huiyuan_name,huiyuan_yu,huiyuan_shenfen_id,huiyuan_mob,huiyuan_address,huiyuan_add_time,huiyuan_pass,huiyuan_yinhang_zh,huiyuan_yinhang_name,huiyuan_yinhang,huiyuan_shang_id,huiyuan_jiebie2,huiyuan_jiebie1,huiyuan_jiebie,huiyuan_zhuanmai,zuoyou,huiyuan_pen_zuo,huiyuan_pen_you,zuo_shen,you_shen,test,dongjie,chongfu_money,net_hege,net_flag,huiyuan_jiedian,huiyuan_zm,huiyuan_qr_date,huiyuan_zhuanmai_sq,zhuanmai_jb,huiyuan_zm_memo,huiyuan_zm_diqu,huiyuan_zm_mingcheng,huiyuan_zm_sq_time,pass_two,huiyuan_qq,qianbao,leftnumber,rightnumber,fenhong_canshu1,youzheng,huiyuan_nc,bank_zhi,huiyuan_email,queren_man,bid,mmid,sid,huiyuan_suoding,chongfu_zong,chongfu_kechu,hang,lie,jiangjing,beizhu,pass_three,jiangjin_yong,jiangjin_zong,flag_1,flag_2,flag_3,flag_4,flag_5,huiyuan_shangshu,huiyuan_shangshu2,zuo_zong,you_zong,flag_ce,flag_money,js_flag,huiyuan_dp_name,kd_flag,tuijian_count,account_type,fh_money,glf_money,temp_count,zong_yeji,ly_count,xuhao,peng_cishu,koushui_flag,question,answer,weixin,zhifubao,xinxi_flag,huiyuan_sj_date,supply,city_address,born_date,sf_pinju_src,zl_pinju_src ");
            strSql.Append(" FROM [tbl_huiyuan] ");
            strSql.Append(" where huiyuan_bianhao=@huiyuan_bianhao ");
            SqlParameter[] parameters = {
					new SqlParameter("@huiyuan_bianhao", SqlDbType.NVarChar,-1)};
            parameters[0].Value = huiyuan_bianhao;

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
                if (ds.Tables[0].Rows[0]["huiyuan_jiebie2"] != null && ds.Tables[0].Rows[0]["huiyuan_jiebie2"].ToString() != "")
                {
                    this.huiyuan_jiebie2 = int.Parse(ds.Tables[0].Rows[0]["huiyuan_jiebie2"].ToString());
                }
                if (ds.Tables[0].Rows[0]["huiyuan_jiebie1"] != null && ds.Tables[0].Rows[0]["huiyuan_jiebie1"].ToString() != "")
                {
                    this.huiyuan_jiebie1 = int.Parse(ds.Tables[0].Rows[0]["huiyuan_jiebie1"].ToString());
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
                if (ds.Tables[0].Rows[0]["pass_two"] != null)
                {
                    this.pass_two = ds.Tables[0].Rows[0]["pass_two"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_qq"] != null)
                {
                    this.huiyuan_qq = ds.Tables[0].Rows[0]["huiyuan_qq"].ToString();
                }
                if (ds.Tables[0].Rows[0]["qianbao"] != null && ds.Tables[0].Rows[0]["qianbao"].ToString() != "")
                {
                    this.qianbao = decimal.Parse(ds.Tables[0].Rows[0]["qianbao"].ToString());
                }
                if (ds.Tables[0].Rows[0]["leftnumber"] != null)
                {
                    this.leftnumber = ds.Tables[0].Rows[0]["leftnumber"].ToString();
                }
                if (ds.Tables[0].Rows[0]["rightnumber"] != null)
                {
                    this.rightnumber = ds.Tables[0].Rows[0]["rightnumber"].ToString();
                }
                if (ds.Tables[0].Rows[0]["fenhong_canshu1"] != null && ds.Tables[0].Rows[0]["fenhong_canshu1"].ToString() != "")
                {
                    this.fenhong_canshu1 = decimal.Parse(ds.Tables[0].Rows[0]["fenhong_canshu1"].ToString());
                }
                if (ds.Tables[0].Rows[0]["youzheng"] != null)
                {
                    this.youzheng = ds.Tables[0].Rows[0]["youzheng"].ToString();
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
                if (ds.Tables[0].Rows[0]["hang"] != null && ds.Tables[0].Rows[0]["hang"].ToString() != "")
                {
                    this.hang = int.Parse(ds.Tables[0].Rows[0]["hang"].ToString());
                }
                if (ds.Tables[0].Rows[0]["lie"] != null && ds.Tables[0].Rows[0]["lie"].ToString() != "")
                {
                    this.lie = int.Parse(ds.Tables[0].Rows[0]["lie"].ToString());
                }
                if (ds.Tables[0].Rows[0]["jiangjing"] != null && ds.Tables[0].Rows[0]["jiangjing"].ToString() != "")
                {
                    this.jiangjing = decimal.Parse(ds.Tables[0].Rows[0]["jiangjing"].ToString());
                }
                if (ds.Tables[0].Rows[0]["beizhu"] != null)
                {
                    this.beizhu = ds.Tables[0].Rows[0]["beizhu"].ToString();
                }
                if (ds.Tables[0].Rows[0]["pass_three"] != null)
                {
                    this.pass_three = ds.Tables[0].Rows[0]["pass_three"].ToString();
                }
                if (ds.Tables[0].Rows[0]["jiangjin_yong"] != null && ds.Tables[0].Rows[0]["jiangjin_yong"].ToString() != "")
                {
                    this.jiangjin_yong = decimal.Parse(ds.Tables[0].Rows[0]["jiangjin_yong"].ToString());
                }
                if (ds.Tables[0].Rows[0]["jiangjin_zong"] != null && ds.Tables[0].Rows[0]["jiangjin_zong"].ToString() != "")
                {
                    this.jiangjin_zong = decimal.Parse(ds.Tables[0].Rows[0]["jiangjin_zong"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_1"] != null && ds.Tables[0].Rows[0]["flag_1"].ToString() != "")
                {
                    this.flag_1 = int.Parse(ds.Tables[0].Rows[0]["flag_1"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_2"] != null && ds.Tables[0].Rows[0]["flag_2"].ToString() != "")
                {
                    this.flag_2 = int.Parse(ds.Tables[0].Rows[0]["flag_2"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_3"] != null && ds.Tables[0].Rows[0]["flag_3"].ToString() != "")
                {
                    this.flag_3 = int.Parse(ds.Tables[0].Rows[0]["flag_3"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_4"] != null && ds.Tables[0].Rows[0]["flag_4"].ToString() != "")
                {
                    this.flag_4 = int.Parse(ds.Tables[0].Rows[0]["flag_4"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_5"] != null && ds.Tables[0].Rows[0]["flag_5"].ToString() != "")
                {
                    this.flag_5 = int.Parse(ds.Tables[0].Rows[0]["flag_5"].ToString());
                }
                if (ds.Tables[0].Rows[0]["huiyuan_shangshu"] != null)
                {
                    this.huiyuan_shangshu = ds.Tables[0].Rows[0]["huiyuan_shangshu"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_shangshu2"] != null)
                {
                    this.huiyuan_shangshu2 = ds.Tables[0].Rows[0]["huiyuan_shangshu2"].ToString();
                }
                if (ds.Tables[0].Rows[0]["zuo_zong"] != null && ds.Tables[0].Rows[0]["zuo_zong"].ToString() != "")
                {
                    this.zuo_zong = decimal.Parse(ds.Tables[0].Rows[0]["zuo_zong"].ToString());
                }
                if (ds.Tables[0].Rows[0]["you_zong"] != null && ds.Tables[0].Rows[0]["you_zong"].ToString() != "")
                {
                    this.you_zong = decimal.Parse(ds.Tables[0].Rows[0]["you_zong"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_ce"] != null && ds.Tables[0].Rows[0]["flag_ce"].ToString() != "")
                {
                    this.flag_ce = int.Parse(ds.Tables[0].Rows[0]["flag_ce"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_money"] != null && ds.Tables[0].Rows[0]["flag_money"].ToString() != "")
                {
                    this.flag_money = decimal.Parse(ds.Tables[0].Rows[0]["flag_money"].ToString());
                }
                if (ds.Tables[0].Rows[0]["js_flag"] != null && ds.Tables[0].Rows[0]["js_flag"].ToString() != "")
                {
                    this.js_flag = int.Parse(ds.Tables[0].Rows[0]["js_flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["huiyuan_dp_name"] != null)
                {
                    this.huiyuan_dp_name = ds.Tables[0].Rows[0]["huiyuan_dp_name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["kd_flag"] != null && ds.Tables[0].Rows[0]["kd_flag"].ToString() != "")
                {
                    this.kd_flag = int.Parse(ds.Tables[0].Rows[0]["kd_flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["tuijian_count"] != null && ds.Tables[0].Rows[0]["tuijian_count"].ToString() != "")
                {
                    this.tuijian_count = int.Parse(ds.Tables[0].Rows[0]["tuijian_count"].ToString());
                }
                if (ds.Tables[0].Rows[0]["account_type"] != null && ds.Tables[0].Rows[0]["account_type"].ToString() != "")
                {
                    this.account_type = int.Parse(ds.Tables[0].Rows[0]["account_type"].ToString());
                }
                if (ds.Tables[0].Rows[0]["fh_money"] != null && ds.Tables[0].Rows[0]["fh_money"].ToString() != "")
                {
                    this.fh_money = decimal.Parse(ds.Tables[0].Rows[0]["fh_money"].ToString());
                }
                if (ds.Tables[0].Rows[0]["glf_money"] != null && ds.Tables[0].Rows[0]["glf_money"].ToString() != "")
                {
                    this.glf_money = decimal.Parse(ds.Tables[0].Rows[0]["glf_money"].ToString());
                }
                if (ds.Tables[0].Rows[0]["temp_count"] != null && ds.Tables[0].Rows[0]["temp_count"].ToString() != "")
                {
                    this.temp_count = int.Parse(ds.Tables[0].Rows[0]["temp_count"].ToString());
                }
                if (ds.Tables[0].Rows[0]["zong_yeji"] != null && ds.Tables[0].Rows[0]["zong_yeji"].ToString() != "")
                {
                    this.zong_yeji = decimal.Parse(ds.Tables[0].Rows[0]["zong_yeji"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ly_count"] != null && ds.Tables[0].Rows[0]["ly_count"].ToString() != "")
                {
                    this.ly_count = int.Parse(ds.Tables[0].Rows[0]["ly_count"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xuhao"] != null && ds.Tables[0].Rows[0]["xuhao"].ToString() != "")
                {
                    this.xuhao = int.Parse(ds.Tables[0].Rows[0]["xuhao"].ToString());
                }
                if (ds.Tables[0].Rows[0]["peng_cishu"] != null && ds.Tables[0].Rows[0]["peng_cishu"].ToString() != "")
                {
                    this.peng_cishu = int.Parse(ds.Tables[0].Rows[0]["peng_cishu"].ToString());
                }
                if (ds.Tables[0].Rows[0]["koushui_flag"] != null && ds.Tables[0].Rows[0]["koushui_flag"].ToString() != "")
                {
                    this.koushui_flag = int.Parse(ds.Tables[0].Rows[0]["koushui_flag"].ToString());
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
                if (ds.Tables[0].Rows[0]["huiyuan_sj_date"] != null && ds.Tables[0].Rows[0]["huiyuan_sj_date"].ToString() != "")
                {
                    this.huiyuan_sj_date = DateTime.Parse(ds.Tables[0].Rows[0]["huiyuan_sj_date"].ToString());
                }
                if (ds.Tables[0].Rows[0]["supply"] != null && ds.Tables[0].Rows[0]["supply"].ToString() != "")
                {
                    this.supply = int.Parse(ds.Tables[0].Rows[0]["supply"].ToString());
                }
                if (ds.Tables[0].Rows[0]["city_address"] != null)
                {
                    this.city_address = ds.Tables[0].Rows[0]["city_address"].ToString();
                }
                if (ds.Tables[0].Rows[0]["born_date"] != null)
                {
                    this.born_date = ds.Tables[0].Rows[0]["born_date"].ToString();
                }
                if (ds.Tables[0].Rows[0]["sf_pinju_src"] != null)
                {
                    this.sf_pinju_src = ds.Tables[0].Rows[0]["sf_pinju_src"].ToString();
                }
                if (ds.Tables[0].Rows[0]["zl_pinju_src"] != null)
                {
                    this.zl_pinju_src = ds.Tables[0].Rows[0]["zl_pinju_src"].ToString();
                }
            }
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public void GetModel_hui_mob(string huiyuan_bianhao)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select huiyuan_id,huiyuan_bianhao,huiyuan_name,huiyuan_yu,huiyuan_shenfen_id,huiyuan_mob,huiyuan_address,huiyuan_add_time,huiyuan_pass,huiyuan_yinhang_zh,huiyuan_yinhang_name,huiyuan_yinhang,huiyuan_shang_id,huiyuan_jiebie2,huiyuan_jiebie1,huiyuan_jiebie,huiyuan_zhuanmai,zuoyou,huiyuan_pen_zuo,huiyuan_pen_you,zuo_shen,you_shen,test,dongjie,chongfu_money,net_hege,net_flag,huiyuan_jiedian,huiyuan_zm,huiyuan_qr_date,huiyuan_zhuanmai_sq,zhuanmai_jb,huiyuan_zm_memo,huiyuan_zm_diqu,huiyuan_zm_mingcheng,huiyuan_zm_sq_time,pass_two,huiyuan_qq,qianbao,leftnumber,rightnumber,fenhong_canshu1,youzheng,huiyuan_nc,bank_zhi,huiyuan_email,queren_man,bid,mmid,sid,huiyuan_suoding,chongfu_zong,chongfu_kechu,hang,lie,jiangjing,beizhu,pass_three,jiangjin_yong,jiangjin_zong,flag_1,flag_2,flag_3,flag_4,flag_5,huiyuan_shangshu,huiyuan_shangshu2,zuo_zong,you_zong,flag_ce,flag_money,js_flag,huiyuan_dp_name,kd_flag,tuijian_count,account_type,fh_money,glf_money,temp_count,zong_yeji,ly_count,xuhao,peng_cishu,koushui_flag,question,answer,weixin,zhifubao,xinxi_flag,huiyuan_sj_date,supply ");
            strSql.Append(" FROM [tbl_huiyuan] ");
            strSql.Append(" where huiyuan_mob=@huiyuan_bianhao ");
            SqlParameter[] parameters = {
					new SqlParameter("@huiyuan_bianhao", SqlDbType.NVarChar,-1)};
            parameters[0].Value = huiyuan_bianhao;

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
                if (ds.Tables[0].Rows[0]["huiyuan_jiebie2"] != null && ds.Tables[0].Rows[0]["huiyuan_jiebie2"].ToString() != "")
                {
                    this.huiyuan_jiebie2 = int.Parse(ds.Tables[0].Rows[0]["huiyuan_jiebie2"].ToString());
                }
                if (ds.Tables[0].Rows[0]["huiyuan_jiebie1"] != null && ds.Tables[0].Rows[0]["huiyuan_jiebie1"].ToString() != "")
                {
                    this.huiyuan_jiebie1 = int.Parse(ds.Tables[0].Rows[0]["huiyuan_jiebie1"].ToString());
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
                if (ds.Tables[0].Rows[0]["pass_two"] != null)
                {
                    this.pass_two = ds.Tables[0].Rows[0]["pass_two"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_qq"] != null)
                {
                    this.huiyuan_qq = ds.Tables[0].Rows[0]["huiyuan_qq"].ToString();
                }
                if (ds.Tables[0].Rows[0]["qianbao"] != null && ds.Tables[0].Rows[0]["qianbao"].ToString() != "")
                {
                    this.qianbao = decimal.Parse(ds.Tables[0].Rows[0]["qianbao"].ToString());
                }
                if (ds.Tables[0].Rows[0]["leftnumber"] != null)
                {
                    this.leftnumber = ds.Tables[0].Rows[0]["leftnumber"].ToString();
                }
                if (ds.Tables[0].Rows[0]["rightnumber"] != null)
                {
                    this.rightnumber = ds.Tables[0].Rows[0]["rightnumber"].ToString();
                }
                if (ds.Tables[0].Rows[0]["fenhong_canshu1"] != null && ds.Tables[0].Rows[0]["fenhong_canshu1"].ToString() != "")
                {
                    this.fenhong_canshu1 = decimal.Parse(ds.Tables[0].Rows[0]["fenhong_canshu1"].ToString());
                }
                if (ds.Tables[0].Rows[0]["youzheng"] != null)
                {
                    this.youzheng = ds.Tables[0].Rows[0]["youzheng"].ToString();
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
                if (ds.Tables[0].Rows[0]["hang"] != null && ds.Tables[0].Rows[0]["hang"].ToString() != "")
                {
                    this.hang = int.Parse(ds.Tables[0].Rows[0]["hang"].ToString());
                }
                if (ds.Tables[0].Rows[0]["lie"] != null && ds.Tables[0].Rows[0]["lie"].ToString() != "")
                {
                    this.lie = int.Parse(ds.Tables[0].Rows[0]["lie"].ToString());
                }
                if (ds.Tables[0].Rows[0]["jiangjing"] != null && ds.Tables[0].Rows[0]["jiangjing"].ToString() != "")
                {
                    this.jiangjing = decimal.Parse(ds.Tables[0].Rows[0]["jiangjing"].ToString());
                }
                if (ds.Tables[0].Rows[0]["beizhu"] != null)
                {
                    this.beizhu = ds.Tables[0].Rows[0]["beizhu"].ToString();
                }
                if (ds.Tables[0].Rows[0]["pass_three"] != null)
                {
                    this.pass_three = ds.Tables[0].Rows[0]["pass_three"].ToString();
                }
                if (ds.Tables[0].Rows[0]["jiangjin_yong"] != null && ds.Tables[0].Rows[0]["jiangjin_yong"].ToString() != "")
                {
                    this.jiangjin_yong = decimal.Parse(ds.Tables[0].Rows[0]["jiangjin_yong"].ToString());
                }
                if (ds.Tables[0].Rows[0]["jiangjin_zong"] != null && ds.Tables[0].Rows[0]["jiangjin_zong"].ToString() != "")
                {
                    this.jiangjin_zong = decimal.Parse(ds.Tables[0].Rows[0]["jiangjin_zong"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_1"] != null && ds.Tables[0].Rows[0]["flag_1"].ToString() != "")
                {
                    this.flag_1 = int.Parse(ds.Tables[0].Rows[0]["flag_1"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_2"] != null && ds.Tables[0].Rows[0]["flag_2"].ToString() != "")
                {
                    this.flag_2 = int.Parse(ds.Tables[0].Rows[0]["flag_2"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_3"] != null && ds.Tables[0].Rows[0]["flag_3"].ToString() != "")
                {
                    this.flag_3 = int.Parse(ds.Tables[0].Rows[0]["flag_3"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_4"] != null && ds.Tables[0].Rows[0]["flag_4"].ToString() != "")
                {
                    this.flag_4 = int.Parse(ds.Tables[0].Rows[0]["flag_4"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_5"] != null && ds.Tables[0].Rows[0]["flag_5"].ToString() != "")
                {
                    this.flag_5 = int.Parse(ds.Tables[0].Rows[0]["flag_5"].ToString());
                }
                if (ds.Tables[0].Rows[0]["huiyuan_shangshu"] != null)
                {
                    this.huiyuan_shangshu = ds.Tables[0].Rows[0]["huiyuan_shangshu"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_shangshu2"] != null)
                {
                    this.huiyuan_shangshu2 = ds.Tables[0].Rows[0]["huiyuan_shangshu2"].ToString();
                }
                if (ds.Tables[0].Rows[0]["zuo_zong"] != null && ds.Tables[0].Rows[0]["zuo_zong"].ToString() != "")
                {
                    this.zuo_zong = decimal.Parse(ds.Tables[0].Rows[0]["zuo_zong"].ToString());
                }
                if (ds.Tables[0].Rows[0]["you_zong"] != null && ds.Tables[0].Rows[0]["you_zong"].ToString() != "")
                {
                    this.you_zong = decimal.Parse(ds.Tables[0].Rows[0]["you_zong"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_ce"] != null && ds.Tables[0].Rows[0]["flag_ce"].ToString() != "")
                {
                    this.flag_ce = int.Parse(ds.Tables[0].Rows[0]["flag_ce"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_money"] != null && ds.Tables[0].Rows[0]["flag_money"].ToString() != "")
                {
                    this.flag_money = decimal.Parse(ds.Tables[0].Rows[0]["flag_money"].ToString());
                }
                if (ds.Tables[0].Rows[0]["js_flag"] != null && ds.Tables[0].Rows[0]["js_flag"].ToString() != "")
                {
                    this.js_flag = int.Parse(ds.Tables[0].Rows[0]["js_flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["huiyuan_dp_name"] != null)
                {
                    this.huiyuan_dp_name = ds.Tables[0].Rows[0]["huiyuan_dp_name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["kd_flag"] != null && ds.Tables[0].Rows[0]["kd_flag"].ToString() != "")
                {
                    this.kd_flag = int.Parse(ds.Tables[0].Rows[0]["kd_flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["tuijian_count"] != null && ds.Tables[0].Rows[0]["tuijian_count"].ToString() != "")
                {
                    this.tuijian_count = int.Parse(ds.Tables[0].Rows[0]["tuijian_count"].ToString());
                }
                if (ds.Tables[0].Rows[0]["account_type"] != null && ds.Tables[0].Rows[0]["account_type"].ToString() != "")
                {
                    this.account_type = int.Parse(ds.Tables[0].Rows[0]["account_type"].ToString());
                }
                if (ds.Tables[0].Rows[0]["fh_money"] != null && ds.Tables[0].Rows[0]["fh_money"].ToString() != "")
                {
                    this.fh_money = decimal.Parse(ds.Tables[0].Rows[0]["fh_money"].ToString());
                }
                if (ds.Tables[0].Rows[0]["glf_money"] != null && ds.Tables[0].Rows[0]["glf_money"].ToString() != "")
                {
                    this.glf_money = decimal.Parse(ds.Tables[0].Rows[0]["glf_money"].ToString());
                }
                if (ds.Tables[0].Rows[0]["temp_count"] != null && ds.Tables[0].Rows[0]["temp_count"].ToString() != "")
                {
                    this.temp_count = int.Parse(ds.Tables[0].Rows[0]["temp_count"].ToString());
                }
                if (ds.Tables[0].Rows[0]["zong_yeji"] != null && ds.Tables[0].Rows[0]["zong_yeji"].ToString() != "")
                {
                    this.zong_yeji = decimal.Parse(ds.Tables[0].Rows[0]["zong_yeji"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ly_count"] != null && ds.Tables[0].Rows[0]["ly_count"].ToString() != "")
                {
                    this.ly_count = int.Parse(ds.Tables[0].Rows[0]["ly_count"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xuhao"] != null && ds.Tables[0].Rows[0]["xuhao"].ToString() != "")
                {
                    this.xuhao = int.Parse(ds.Tables[0].Rows[0]["xuhao"].ToString());
                }
                if (ds.Tables[0].Rows[0]["peng_cishu"] != null && ds.Tables[0].Rows[0]["peng_cishu"].ToString() != "")
                {
                    this.peng_cishu = int.Parse(ds.Tables[0].Rows[0]["peng_cishu"].ToString());
                }
                if (ds.Tables[0].Rows[0]["koushui_flag"] != null && ds.Tables[0].Rows[0]["koushui_flag"].ToString() != "")
                {
                    this.koushui_flag = int.Parse(ds.Tables[0].Rows[0]["koushui_flag"].ToString());
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
                if (ds.Tables[0].Rows[0]["huiyuan_sj_date"] != null && ds.Tables[0].Rows[0]["huiyuan_sj_date"].ToString() != "")
                {
                    this.huiyuan_sj_date = DateTime.Parse(ds.Tables[0].Rows[0]["huiyuan_sj_date"].ToString());
                }
                if (ds.Tables[0].Rows[0]["supply"] != null && ds.Tables[0].Rows[0]["supply"].ToString() != "")
                {
                    this.supply = int.Parse(ds.Tables[0].Rows[0]["supply"].ToString());
                }
            }
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public void GetModel_jiedian(string jiedian_id, int zuoyou)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select huiyuan_id,huiyuan_bianhao,huiyuan_name,huiyuan_yu,huiyuan_shenfen_id,huiyuan_mob,huiyuan_address,huiyuan_add_time,huiyuan_pass,huiyuan_yinhang_zh,huiyuan_yinhang_name,huiyuan_yinhang,huiyuan_shang_id,huiyuan_jiebie2,huiyuan_jiebie1,huiyuan_jiebie,huiyuan_zhuanmai,zuoyou,huiyuan_pen_zuo,huiyuan_pen_you,zuo_shen,you_shen,test,dongjie,chongfu_money,net_hege,net_flag,huiyuan_jiedian,huiyuan_zm,huiyuan_qr_date,huiyuan_zhuanmai_sq,zhuanmai_jb,huiyuan_zm_memo,huiyuan_zm_diqu,huiyuan_zm_mingcheng,huiyuan_zm_sq_time,pass_two,huiyuan_qq,qianbao,leftnumber,rightnumber,fenhong_canshu1,youzheng,huiyuan_nc,bank_zhi,huiyuan_email,queren_man,bid,mmid,sid,huiyuan_suoding,chongfu_zong,chongfu_kechu,hang,lie,jiangjing,beizhu,pass_three,jiangjin_yong,jiangjin_zong,flag_1,flag_2,flag_3,flag_4,flag_5,huiyuan_shangshu,huiyuan_shangshu2,zuo_zong,you_zong,flag_ce,flag_money,js_flag,huiyuan_dp_name,kd_flag,tuijian_count,account_type,fh_money,glf_money,temp_count,zong_yeji,ly_count,xuhao,peng_cishu,koushui_flag,question,answer,weixin,zhifubao,xinxi_flag,huiyuan_sj_date,supply ");
            strSql.Append(" FROM [tbl_huiyuan] ");
            strSql.Append(" where huiyuan_jiedian=@jiedian_id ");
            strSql.Append("  and zuoyou=@zuoyou ");
            SqlParameter[] parameters = {
					new SqlParameter("@jiedian_id", SqlDbType.NVarChar,-1),
                    new SqlParameter("@zuoyou", SqlDbType.Int,4)};
            parameters[0].Value = jiedian_id;
            parameters[1].Value = zuoyou;

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
                if (ds.Tables[0].Rows[0]["huiyuan_jiebie2"] != null && ds.Tables[0].Rows[0]["huiyuan_jiebie2"].ToString() != "")
                {
                    this.huiyuan_jiebie2 = int.Parse(ds.Tables[0].Rows[0]["huiyuan_jiebie2"].ToString());
                }
                if (ds.Tables[0].Rows[0]["huiyuan_jiebie1"] != null && ds.Tables[0].Rows[0]["huiyuan_jiebie1"].ToString() != "")
                {
                    this.huiyuan_jiebie1 = int.Parse(ds.Tables[0].Rows[0]["huiyuan_jiebie1"].ToString());
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
                if (ds.Tables[0].Rows[0]["pass_two"] != null)
                {
                    this.pass_two = ds.Tables[0].Rows[0]["pass_two"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_qq"] != null)
                {
                    this.huiyuan_qq = ds.Tables[0].Rows[0]["huiyuan_qq"].ToString();
                }
                if (ds.Tables[0].Rows[0]["qianbao"] != null && ds.Tables[0].Rows[0]["qianbao"].ToString() != "")
                {
                    this.qianbao = decimal.Parse(ds.Tables[0].Rows[0]["qianbao"].ToString());
                }
                if (ds.Tables[0].Rows[0]["leftnumber"] != null)
                {
                    this.leftnumber = ds.Tables[0].Rows[0]["leftnumber"].ToString();
                }
                if (ds.Tables[0].Rows[0]["rightnumber"] != null)
                {
                    this.rightnumber = ds.Tables[0].Rows[0]["rightnumber"].ToString();
                }
                if (ds.Tables[0].Rows[0]["fenhong_canshu1"] != null && ds.Tables[0].Rows[0]["fenhong_canshu1"].ToString() != "")
                {
                    this.fenhong_canshu1 = decimal.Parse(ds.Tables[0].Rows[0]["fenhong_canshu1"].ToString());
                }
                if (ds.Tables[0].Rows[0]["youzheng"] != null)
                {
                    this.youzheng = ds.Tables[0].Rows[0]["youzheng"].ToString();
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
                if (ds.Tables[0].Rows[0]["hang"] != null && ds.Tables[0].Rows[0]["hang"].ToString() != "")
                {
                    this.hang = int.Parse(ds.Tables[0].Rows[0]["hang"].ToString());
                }
                if (ds.Tables[0].Rows[0]["lie"] != null && ds.Tables[0].Rows[0]["lie"].ToString() != "")
                {
                    this.lie = int.Parse(ds.Tables[0].Rows[0]["lie"].ToString());
                }
                if (ds.Tables[0].Rows[0]["jiangjing"] != null && ds.Tables[0].Rows[0]["jiangjing"].ToString() != "")
                {
                    this.jiangjing = decimal.Parse(ds.Tables[0].Rows[0]["jiangjing"].ToString());
                }
                if (ds.Tables[0].Rows[0]["beizhu"] != null)
                {
                    this.beizhu = ds.Tables[0].Rows[0]["beizhu"].ToString();
                }
                if (ds.Tables[0].Rows[0]["pass_three"] != null)
                {
                    this.pass_three = ds.Tables[0].Rows[0]["pass_three"].ToString();
                }
                if (ds.Tables[0].Rows[0]["jiangjin_yong"] != null && ds.Tables[0].Rows[0]["jiangjin_yong"].ToString() != "")
                {
                    this.jiangjin_yong = decimal.Parse(ds.Tables[0].Rows[0]["jiangjin_yong"].ToString());
                }
                if (ds.Tables[0].Rows[0]["jiangjin_zong"] != null && ds.Tables[0].Rows[0]["jiangjin_zong"].ToString() != "")
                {
                    this.jiangjin_zong = decimal.Parse(ds.Tables[0].Rows[0]["jiangjin_zong"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_1"] != null && ds.Tables[0].Rows[0]["flag_1"].ToString() != "")
                {
                    this.flag_1 = int.Parse(ds.Tables[0].Rows[0]["flag_1"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_2"] != null && ds.Tables[0].Rows[0]["flag_2"].ToString() != "")
                {
                    this.flag_2 = int.Parse(ds.Tables[0].Rows[0]["flag_2"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_3"] != null && ds.Tables[0].Rows[0]["flag_3"].ToString() != "")
                {
                    this.flag_3 = int.Parse(ds.Tables[0].Rows[0]["flag_3"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_4"] != null && ds.Tables[0].Rows[0]["flag_4"].ToString() != "")
                {
                    this.flag_4 = int.Parse(ds.Tables[0].Rows[0]["flag_4"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_5"] != null && ds.Tables[0].Rows[0]["flag_5"].ToString() != "")
                {
                    this.flag_5 = int.Parse(ds.Tables[0].Rows[0]["flag_5"].ToString());
                }
                if (ds.Tables[0].Rows[0]["huiyuan_shangshu"] != null)
                {
                    this.huiyuan_shangshu = ds.Tables[0].Rows[0]["huiyuan_shangshu"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_shangshu2"] != null)
                {
                    this.huiyuan_shangshu2 = ds.Tables[0].Rows[0]["huiyuan_shangshu2"].ToString();
                }
                if (ds.Tables[0].Rows[0]["zuo_zong"] != null && ds.Tables[0].Rows[0]["zuo_zong"].ToString() != "")
                {
                    this.zuo_zong = decimal.Parse(ds.Tables[0].Rows[0]["zuo_zong"].ToString());
                }
                if (ds.Tables[0].Rows[0]["you_zong"] != null && ds.Tables[0].Rows[0]["you_zong"].ToString() != "")
                {
                    this.you_zong = decimal.Parse(ds.Tables[0].Rows[0]["you_zong"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_ce"] != null && ds.Tables[0].Rows[0]["flag_ce"].ToString() != "")
                {
                    this.flag_ce = int.Parse(ds.Tables[0].Rows[0]["flag_ce"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag_money"] != null && ds.Tables[0].Rows[0]["flag_money"].ToString() != "")
                {
                    this.flag_money = decimal.Parse(ds.Tables[0].Rows[0]["flag_money"].ToString());
                }
                if (ds.Tables[0].Rows[0]["js_flag"] != null && ds.Tables[0].Rows[0]["js_flag"].ToString() != "")
                {
                    this.js_flag = int.Parse(ds.Tables[0].Rows[0]["js_flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["huiyuan_dp_name"] != null)
                {
                    this.huiyuan_dp_name = ds.Tables[0].Rows[0]["huiyuan_dp_name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["kd_flag"] != null && ds.Tables[0].Rows[0]["kd_flag"].ToString() != "")
                {
                    this.kd_flag = int.Parse(ds.Tables[0].Rows[0]["kd_flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["tuijian_count"] != null && ds.Tables[0].Rows[0]["tuijian_count"].ToString() != "")
                {
                    this.tuijian_count = int.Parse(ds.Tables[0].Rows[0]["tuijian_count"].ToString());
                }
                if (ds.Tables[0].Rows[0]["account_type"] != null && ds.Tables[0].Rows[0]["account_type"].ToString() != "")
                {
                    this.account_type = int.Parse(ds.Tables[0].Rows[0]["account_type"].ToString());
                }
                if (ds.Tables[0].Rows[0]["fh_money"] != null && ds.Tables[0].Rows[0]["fh_money"].ToString() != "")
                {
                    this.fh_money = decimal.Parse(ds.Tables[0].Rows[0]["fh_money"].ToString());
                }
                if (ds.Tables[0].Rows[0]["glf_money"] != null && ds.Tables[0].Rows[0]["glf_money"].ToString() != "")
                {
                    this.glf_money = decimal.Parse(ds.Tables[0].Rows[0]["glf_money"].ToString());
                }
                if (ds.Tables[0].Rows[0]["temp_count"] != null && ds.Tables[0].Rows[0]["temp_count"].ToString() != "")
                {
                    this.temp_count = int.Parse(ds.Tables[0].Rows[0]["temp_count"].ToString());
                }
                if (ds.Tables[0].Rows[0]["zong_yeji"] != null && ds.Tables[0].Rows[0]["zong_yeji"].ToString() != "")
                {
                    this.zong_yeji = decimal.Parse(ds.Tables[0].Rows[0]["zong_yeji"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ly_count"] != null && ds.Tables[0].Rows[0]["ly_count"].ToString() != "")
                {
                    this.ly_count = int.Parse(ds.Tables[0].Rows[0]["ly_count"].ToString());
                }
                if (ds.Tables[0].Rows[0]["xuhao"] != null && ds.Tables[0].Rows[0]["xuhao"].ToString() != "")
                {
                    this.xuhao = int.Parse(ds.Tables[0].Rows[0]["xuhao"].ToString());
                }
                if (ds.Tables[0].Rows[0]["peng_cishu"] != null && ds.Tables[0].Rows[0]["peng_cishu"].ToString() != "")
                {
                    this.peng_cishu = int.Parse(ds.Tables[0].Rows[0]["peng_cishu"].ToString());
                }
                if (ds.Tables[0].Rows[0]["koushui_flag"] != null && ds.Tables[0].Rows[0]["koushui_flag"].ToString() != "")
                {
                    this.koushui_flag = int.Parse(ds.Tables[0].Rows[0]["koushui_flag"].ToString());
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
                if (ds.Tables[0].Rows[0]["huiyuan_sj_date"] != null && ds.Tables[0].Rows[0]["huiyuan_sj_date"].ToString() != "")
                {
                    this.huiyuan_sj_date = DateTime.Parse(ds.Tables[0].Rows[0]["huiyuan_sj_date"].ToString());
                }
                if (ds.Tables[0].Rows[0]["supply"] != null && ds.Tables[0].Rows[0]["supply"].ToString() != "")
                {
                    this.supply = int.Parse(ds.Tables[0].Rows[0]["supply"].ToString());
                }
            }
        }
        /// <summary>
        /// 返回是否显示
        /// </summary>
        public bool show_is(string  huiyuan_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select aa=count(*)   from [tbl_huiyuan]");
            strSql.Append(" where huiyuan_shang_id= '"+ huiyuan_id+"'");
            int  count_hui = Convert.ToInt32(DbHelperSQL.GetSingle(strSql.ToString()));

            StringBuilder strSql1 = new StringBuilder();
            strSql1.Append("select aa=count(*)   from [tbl_huiyuan]");
            strSql1.Append(" where huiyuan_jiedian= '" + huiyuan_id + "'");
            int count_hui1 = Convert.ToInt32(DbHelperSQL.GetSingle(strSql1.ToString()));


            StringBuilder strSql2 = new StringBuilder();
            strSql2.Append("select net_hege   from [tbl_huiyuan]");
            strSql2.Append(" where huiyuan_id= '" + huiyuan_id + "'");
            int net_hege = Convert.ToInt32(DbHelperSQL.GetSingle(strSql2.ToString()));
            if (count_hui == 0 && count_hui1 == 0 && net_hege==0)
            {
                return  true;
            }
            else
            {

                return false;
            }
        }


        /// <summary>
        /// 返回是否有人接在下面
        /// </summary>
        public bool show_is_jd(string huiyuan_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select aa=count(*)   from [tbl_huiyuan]");
            strSql.Append(" where huiyuan_jiedian= '" + huiyuan_id + "'");
            int count_hui = Convert.ToInt32(DbHelperSQL.GetSingle(strSql.ToString()));
            if (count_hui == 0)
            {
                return true;
            }
            else
            {

                return false;
            }
        }
        public string Getbianhao(string huiyuan_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top 1 huiyuan_bianhao as bianhao from [tbl_huiyuan]");
            strSql.Append(" where huiyuan_id='" + huiyuan_id + "'");
            string title = Convert.ToString(DbHelperSQL.GetSingle(strSql.ToString()));
            if (string.IsNullOrEmpty(title))
            {
                return "";
            }
            return title;
        }
        /// <summary>
        /// 返回是否有人推荐在下面
        /// </summary>
        public bool show_is_tj(string huiyuan_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select aa=count(*)   from [tbl_huiyuan]");
            strSql.Append(" where huiyuan_shang_id= '" + huiyuan_id + "'");
            int count_hui = Convert.ToInt32(DbHelperSQL.GetSingle(strSql.ToString()));
            if (count_hui == 0)
            {
                return true;
            }
            else
            {

                return false;
            }
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM [tbl_huiyuan] ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 省级
        /// </summary>
        public string Getshen(string strWhere, string Title)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top 1 " + Title + " as sumcode from [T_Province]");
            strSql.Append(" where " + strWhere);
            string title = Convert.ToString(DbHelperSQL.GetSingle(strSql.ToString()));
            if (string.IsNullOrEmpty(title))
            {
                return "";
            }
            return title;
        }

        /// <summary>
        /// 市级
        /// </summary>
        public string Getshi(string strWhere, string Title)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top 1 " + Title + " as sumcode from [T_City]");
            strSql.Append(" where " + strWhere);
            string title = Convert.ToString(DbHelperSQL.GetSingle(strSql.ToString()));
            if (string.IsNullOrEmpty(title))
            {
                return "";
            }
            return title;
        }

        /// <summary>
        /// 县级
        /// </summary>
        public string Getxian(string strWhere, string Title)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top 1 " + Title + " as sumcode from [T_District]");
            strSql.Append(" where " + strWhere);
            string title = Convert.ToString(DbHelperSQL.GetSingle(strSql.ToString()));
            if (string.IsNullOrEmpty(title))
            {
                return "";
            }
            return title;
        }

        /// <summary>
        /// 根据条件和字段汇总
        /// </summary>
        public string GetTitleSum(string strWhere, string Title)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top 1 " + Title + " as sumcode from [tbl_huiyuan]");
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
            strSql.Append("select * FROM  tbl_huiyuan");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            recordCount = Convert.ToInt32(DbHelperSQL.GetSingle(PagingHelper.CreateCountingSql(strSql.ToString())));
            return DbHelperSQL.Query(PagingHelper.CreatePagingSql(recordCount, pageSize, pageIndex, strSql.ToString(), filedOrder));
        }

       

        #endregion  Method
    }
 

