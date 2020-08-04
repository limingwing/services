using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
 
 
    /// <summary>
    /// 类tbl_product。
    /// </summary>
    [Serializable]
    public partial class tbl_product
    {
        public tbl_product()
        { }
        #region Model
        private int _pro_id;
        private string _pro_name;
        private string _pro_memo;
        private decimal? _go_price;
        private decimal? _salse_price;
        private decimal? _pro_pv;
        private string _pro_bianhao;
        private string _bigclassname;
        private string _smallclassname;
        private string _pro_guige;
        private string _pro_danwei;
        private DateTime? _pro_date;
        private int? _pro_flag;
        private int? _pro_type;
        private int? _pro_pid;
        private string _pro_imgs;
        private int? _pro_h_width;
        private int? _pro_h_height;
        private string _pro_user;
        private string _pro_content;
        private int? _pro_hot;
        private int? _pro_isok;
        private int? _pro_special;
        private int? _pro_num;
        private int? _pro_sum;
        private string _pro_contact;
        private int? _pro_level;
        private decimal? _pro_ping;
        private int? _pro_home_show;//首页是否显示
        private int? _flag;
        private string _pro_imgs1;
        private string _pro_imgs2;
        private int? _province_id;
        private int? _city_id;
        private int? _dictrict_id;
        private string _huiyuan_id = "A00000000";
        private decimal? _shop_fen;
        private decimal? _cloud_fen;
        private decimal? _futou_fen;
        /// <summary>
        /// 产品id
        /// </summary>
        public int pro_id
        {
            set { _pro_id = value; }
            get { return _pro_id; }
        }
        /// <summary>
        /// 产品名称
        /// </summary>
        public string pro_name
        {
            set { _pro_name = value; }
            get { return _pro_name; }
        }
        /// <summary>
        /// 产品备注
        /// </summary>
        public string pro_memo
        {
            set { _pro_memo = value; }
            get { return _pro_memo; }
        }
        /// <summary>
        /// 产品进货价格
        /// </summary>
        public decimal? go_price
        {
            set { _go_price = value; }
            get { return _go_price; }
        }
        /// <summary>
        /// 卖出价格
        /// </summary>
        public decimal? salse_price
        {
            set { _salse_price = value; }
            get { return _salse_price; }
        }
        /// <summary>
        /// 产品pv值
        /// </summary>
        public decimal? pro_PV
        {
            set { _pro_pv = value; }
            get { return _pro_pv; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string pro_bianhao
        {
            set { _pro_bianhao = value; }
            get { return _pro_bianhao; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string bigclassname
        {
            set { _bigclassname = value; }
            get { return _bigclassname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string smallclassname
        {
            set { _smallclassname = value; }
            get { return _smallclassname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string pro_guige
        {
            set { _pro_guige = value; }
            get { return _pro_guige; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string pro_danwei
        {
            set { _pro_danwei = value; }
            get { return _pro_danwei; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? pro_date
        {
            set { _pro_date = value; }
            get { return _pro_date; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? pro_flag
        {
            set { _pro_flag = value; }
            get { return _pro_flag; }
        }
        /// <summary>
        /// 产品类型
        /// </summary>
        public int? pro_type
        {
            set { _pro_type = value; }
            get { return _pro_type; }
        }
        /// <summary>
        /// 产品上属类别
        /// </summary>
        public int? pro_pid
        {
            set { _pro_pid = value; }
            get { return _pro_pid; }
        }
        /// <summary>
        /// 产品图片
        /// </summary>
        public string pro_imgs
        {
            set { _pro_imgs = value; }
            get { return _pro_imgs; }
        }
        /// <summary>
        /// 产品副图片1
        /// </summary>
        public string pro_imgs1
        {
            set { _pro_imgs1 = value; }
            get { return _pro_imgs1; }
        }

        /// <summary>
        /// 产品副图片2
        /// </summary>
        public string pro_imgs2
        {
            set { _pro_imgs2 = value; }
            get { return _pro_imgs2; }
        }
        /// <summary>
        /// 图宽度
        /// </summary>
        public int? pro_h_width
        {
            set { _pro_h_width = value; }
            get { return _pro_h_width; }
        }
        /// <summary>
        /// 图长度
        /// </summary>
        public int? pro_h_height
        {
            set { _pro_h_height = value; }
            get { return _pro_h_height; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string pro_user
        {
            set { _pro_user = value; }
            get { return _pro_user; }
        }
        /// <summary>
        /// 产品介绍
        /// </summary>
        public string pro_content
        {
            set { _pro_content = value; }
            get { return _pro_content; }
        }
        /// <summary>
        /// 是否热卖
        /// </summary>
        public int? pro_Hot
        {
            set { _pro_hot = value; }
            get { return _pro_hot; }
        }
        /// <summary>
        /// 是否发布
        /// </summary>
        public int? pro_isok
        {
            set { _pro_isok = value; }
            get { return _pro_isok; }
        }
        /// <summary>
        /// 是否特别
        /// </summary>
        public int? pro_Special
        {
            set { _pro_special = value; }
            get { return _pro_special; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? pro_num
        {
            set { _pro_num = value; }
            get { return _pro_num; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? pro_sum
        {
            set { _pro_sum = value; }
            get { return _pro_sum; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string pro_contact
        {
            set { _pro_contact = value; }
            get { return _pro_contact; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? pro_level
        {
            set { _pro_level = value; }
            get { return _pro_level; }
        }
        /// <summary>
        /// 产品评价
        /// </summary>
        public decimal? pro_ping
        {
            set { _pro_ping = value; }
            get { return _pro_ping; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? pro_home_show
        {
            set { _pro_home_show = value; }
            get { return _pro_home_show; }
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
        public int? province_id
        {
            set { _province_id = value; }
            get { return _province_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? city_id
        {
            set { _city_id = value; }
            get { return _city_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? dictrict_id
        {
            set { _dictrict_id = value; }
            get { return _dictrict_id; }
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
        public decimal? shop_fen
        {
            set { _shop_fen = value; }
            get { return _shop_fen; }
        }
        /// <summary>
        /// 肽豆
        /// </summary>
        public decimal? cloud_fen
        {
            set { _cloud_fen = value; }
            get { return _cloud_fen; }
        }
        /// <summary>
        /// 复投积分
        /// </summary>
        public decimal? futou_fen
        {
            set { _futou_fen = value; }
            get { return _futou_fen; }
        }
        #endregion Model


        #region  Method

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public tbl_product(int pro_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select pro_id,pro_name,pro_memo,go_price,salse_price,pro_PV,pro_bianhao,bigclassname,smallclassname,pro_guige,pro_danwei,pro_date,pro_flag,pro_type,pro_pid,pro_imgs,pro_imgs1,pro_imgs2,pro_h_width,pro_h_height,pro_user,pro_content,pro_Hot,pro_isok,pro_Special,pro_num,pro_sum,pro_contact,pro_level,pro_ping,pro_home_show,flag,province_id,city_id,dictrict_id,huiyuan_id,shop_fen,cloud_fen,futou_fen ");
            strSql.Append(" FROM [tbl_product] ");
            strSql.Append(" where pro_id=@pro_id ");
            SqlParameter[] parameters = {
					new SqlParameter("@pro_id", SqlDbType.Int,4)};
            parameters[0].Value = pro_id;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["pro_id"].ToString() != "")
                {
                    this.pro_id = int.Parse(ds.Tables[0].Rows[0]["pro_id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["pro_name"] != null)
                {
                    this.pro_name = ds.Tables[0].Rows[0]["pro_name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["pro_memo"] != null)
                {
                    this.pro_memo = ds.Tables[0].Rows[0]["pro_memo"].ToString();
                }
                if (ds.Tables[0].Rows[0]["go_price"].ToString() != "")
                {
                    this.go_price = decimal.Parse(ds.Tables[0].Rows[0]["go_price"].ToString());
                }
                if (ds.Tables[0].Rows[0]["salse_price"].ToString() != "")
                {
                    this.salse_price = decimal.Parse(ds.Tables[0].Rows[0]["salse_price"].ToString());
                }
                if (ds.Tables[0].Rows[0]["pro_PV"].ToString() != "")
                {
                    this.pro_PV = decimal.Parse(ds.Tables[0].Rows[0]["pro_PV"].ToString());
                }
                if (ds.Tables[0].Rows[0]["pro_bianhao"] != null)
                {
                    this.pro_bianhao = ds.Tables[0].Rows[0]["pro_bianhao"].ToString();
                }
                if (ds.Tables[0].Rows[0]["bigclassname"] != null)
                {
                    this.bigclassname = ds.Tables[0].Rows[0]["bigclassname"].ToString();
                }
                if (ds.Tables[0].Rows[0]["smallclassname"] != null)
                {
                    this.smallclassname = ds.Tables[0].Rows[0]["smallclassname"].ToString();
                }
                if (ds.Tables[0].Rows[0]["pro_guige"] != null)
                {
                    this.pro_guige = ds.Tables[0].Rows[0]["pro_guige"].ToString();
                }
                if (ds.Tables[0].Rows[0]["pro_danwei"] != null)
                {
                    this.pro_danwei = ds.Tables[0].Rows[0]["pro_danwei"].ToString();
                }
                if (ds.Tables[0].Rows[0]["pro_date"].ToString() != "")
                {
                    this.pro_date = DateTime.Parse(ds.Tables[0].Rows[0]["pro_date"].ToString());
                }
                if (ds.Tables[0].Rows[0]["pro_flag"].ToString() != "")
                {
                    this.pro_flag = int.Parse(ds.Tables[0].Rows[0]["pro_flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["pro_type"].ToString() != "")
                {
                    this.pro_type = int.Parse(ds.Tables[0].Rows[0]["pro_type"].ToString());
                }
                if (ds.Tables[0].Rows[0]["pro_pid"].ToString() != "")
                {
                    this.pro_pid = int.Parse(ds.Tables[0].Rows[0]["pro_pid"].ToString());
                }
                if (ds.Tables[0].Rows[0]["pro_imgs"] != null)
                {
                    this.pro_imgs = ds.Tables[0].Rows[0]["pro_imgs"].ToString();
                }
                if (ds.Tables[0].Rows[0]["pro_imgs1"] != null)
                {
                    this.pro_imgs1 = ds.Tables[0].Rows[0]["pro_imgs1"].ToString();
                }
                if (ds.Tables[0].Rows[0]["pro_imgs2"] != null)
                {
                    this.pro_imgs2 = ds.Tables[0].Rows[0]["pro_imgs2"].ToString();
                }
                if (ds.Tables[0].Rows[0]["pro_h_width"].ToString() != "")
                {
                    this.pro_h_width = int.Parse(ds.Tables[0].Rows[0]["pro_h_width"].ToString());
                }
                if (ds.Tables[0].Rows[0]["pro_h_height"].ToString() != "")
                {
                    this.pro_h_height = int.Parse(ds.Tables[0].Rows[0]["pro_h_height"].ToString());
                }
                if (ds.Tables[0].Rows[0]["pro_user"] != null)
                {
                    this.pro_user = ds.Tables[0].Rows[0]["pro_user"].ToString();
                }
                if (ds.Tables[0].Rows[0]["pro_content"] != null)
                {
                    this.pro_content = ds.Tables[0].Rows[0]["pro_content"].ToString();
                }
                if (ds.Tables[0].Rows[0]["pro_Hot"].ToString() != "")
                {
                    this.pro_Hot = int.Parse(ds.Tables[0].Rows[0]["pro_Hot"].ToString());
                }
                if (ds.Tables[0].Rows[0]["pro_isok"].ToString() != "")
                {
                    this.pro_isok = int.Parse(ds.Tables[0].Rows[0]["pro_isok"].ToString());
                }
                if (ds.Tables[0].Rows[0]["pro_Special"].ToString() != "")
                {
                    this.pro_Special = int.Parse(ds.Tables[0].Rows[0]["pro_Special"].ToString());
                }
                if (ds.Tables[0].Rows[0]["pro_num"].ToString() != "")
                {
                    this.pro_num = int.Parse(ds.Tables[0].Rows[0]["pro_num"].ToString());
                }
                if (ds.Tables[0].Rows[0]["pro_sum"].ToString() != "")
                {
                    this.pro_sum = int.Parse(ds.Tables[0].Rows[0]["pro_sum"].ToString());
                }
                if (ds.Tables[0].Rows[0]["pro_contact"] != null)
                {
                    this.pro_contact = ds.Tables[0].Rows[0]["pro_contact"].ToString();
                }
                if (ds.Tables[0].Rows[0]["pro_level"].ToString() != "")
                {
                    this.pro_level = int.Parse(ds.Tables[0].Rows[0]["pro_level"].ToString());
                }
                if (ds.Tables[0].Rows[0]["pro_ping"].ToString() != "")
                {
                    this.pro_ping = decimal.Parse(ds.Tables[0].Rows[0]["pro_ping"].ToString());
                }
                if (ds.Tables[0].Rows[0]["pro_home_show"].ToString() != "")
                {
                    this.pro_home_show = int.Parse(ds.Tables[0].Rows[0]["pro_home_show"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag"].ToString() != "")
                {
                    this.flag = int.Parse(ds.Tables[0].Rows[0]["flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["province_id"].ToString() != "")
                {
                    this.province_id = int.Parse(ds.Tables[0].Rows[0]["province_id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["city_id"].ToString() != "")
                {
                    this.city_id = int.Parse(ds.Tables[0].Rows[0]["city_id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["dictrict_id"].ToString() != "")
                {
                    this.dictrict_id = int.Parse(ds.Tables[0].Rows[0]["dictrict_id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["huiyuan_id"] != null)
                {
                    this.huiyuan_id = ds.Tables[0].Rows[0]["huiyuan_id"].ToString();
                }
                if (ds.Tables[0].Rows[0]["shop_fen"].ToString() != "")
                {
                    this.shop_fen = decimal.Parse(ds.Tables[0].Rows[0]["shop_fen"].ToString());
                }
                if (ds.Tables[0].Rows[0]["cloud_fen"].ToString() != "")
                {
                    this.cloud_fen = decimal.Parse(ds.Tables[0].Rows[0]["cloud_fen"].ToString());
                }
                if (ds.Tables[0].Rows[0]["futou_fen"].ToString() != "")
                {
                    this.futou_fen = decimal.Parse(ds.Tables[0].Rows[0]["futou_fen"].ToString());
                }
            }
        }
       
        /// 查询产品名称是否存在
        /// </summary>
        public bool Exists(string pro_name)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from  [tbl_product]");
            strSql.Append(" where pro_name=@pro_name and pro_name<>'' ");
            SqlParameter[] parameters = {
					new SqlParameter("@pro_name", SqlDbType.NVarChar,100)};
            parameters[0].Value = pro_name;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 是否存在商品种类id记录
        /// </summary>
        public bool Existsshuxing()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from [tbl_product]");
            strSql.Append(" where pro_level=@pro_level ");

            SqlParameter[] parameters = {
					new SqlParameter("@pro_level", SqlDbType.Int,4)};
            parameters[0].Value = pro_level;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }
            /// <summary>
        /// 是否存在商品属性id记录
        /// </summary>
        public bool ExistsBM()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from [tbl_product]");
            strSql.Append(" where pro_level=@pro_level ");

            SqlParameter[] parameters = {
					new SqlParameter("@pro_level", SqlDbType.Int,4)};
            parameters[0].Value = pro_level;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }
        

        /// <summary>
        /// 更新是否显示
        /// </summary>
        public bool UpdateXS()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update [tbl_product] set ");
            strSql.Append("pro_isok=@pro_isok");
            strSql.Append(" where pro_id=@pro_id ");
            SqlParameter[] parameters = {
					new SqlParameter("@pro_isok", SqlDbType.TinyInt,1),
					new SqlParameter("@pro_id", SqlDbType.BigInt,8)};
            parameters[0].Value = pro_isok;
            parameters[1].Value = pro_id;

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
        /// 更新入库价格和销售价格
        /// </summary>
        public bool Update_money()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update [tbl_product] set ");
            strSql.Append("go_price=@go_price,");
            strSql.Append("salse_price=@salse_price");
            strSql.Append(" where pro_id=@pro_id ");
            SqlParameter[] parameters = {
					new SqlParameter("@go_price", SqlDbType.Decimal,9),
					new SqlParameter("@salse_price", SqlDbType.Decimal,9),
					new SqlParameter("@pro_id", SqlDbType.BigInt,8)};

            parameters[0].Value = go_price;
            parameters[1].Value = salse_price;
            parameters[2].Value = pro_id;

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
        /// 增加一条数据
        /// </summary>
        public int Add()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into [tbl_product] (");
            strSql.Append("pro_name,pro_memo,go_price,salse_price,pro_PV,pro_bianhao,bigclassname,smallclassname,pro_guige,pro_danwei,pro_date,pro_flag,pro_type,pro_pid,pro_imgs,pro_imgs1,pro_imgs2,pro_h_width,pro_h_height,pro_user,pro_content,pro_Hot,pro_isok,pro_Special,pro_num,pro_sum,pro_contact,pro_level,pro_ping,pro_home_show,flag,province_id,city_id,dictrict_id,huiyuan_id,shop_fen,cloud_fen,futou_fen)");
            strSql.Append(" values (");
            strSql.Append("@pro_name,@pro_memo,@go_price,@salse_price,@pro_PV,@pro_bianhao,@bigclassname,@smallclassname,@pro_guige,@pro_danwei,@pro_date,@pro_flag,@pro_type,@pro_pid,@pro_imgs,@pro_imgs1,@pro_imgs2,@pro_h_width,@pro_h_height,@pro_user,@pro_content,@pro_Hot,@pro_isok,@pro_Special,@pro_num,@pro_sum,@pro_contact,@pro_level,@pro_ping,@pro_home_show,@flag,@province_id,@city_id,@dictrict_id,@huiyuan_id,@shop_fen,@cloud_fen,@futou_fen)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@pro_name", SqlDbType.VarChar,50),
					new SqlParameter("@pro_memo", SqlDbType.Text),
					new SqlParameter("@go_price", SqlDbType.Decimal,9),
					new SqlParameter("@salse_price", SqlDbType.Decimal,9),
					new SqlParameter("@pro_PV", SqlDbType.Decimal,9),
					new SqlParameter("@pro_bianhao", SqlDbType.VarChar,50),
					new SqlParameter("@bigclassname", SqlDbType.VarChar,50),
					new SqlParameter("@smallclassname", SqlDbType.VarChar,50),
					new SqlParameter("@pro_guige", SqlDbType.VarChar,50),
					new SqlParameter("@pro_danwei", SqlDbType.VarChar,50),
					new SqlParameter("@pro_date", SqlDbType.DateTime),
					new SqlParameter("@pro_flag", SqlDbType.Int,4),
					new SqlParameter("@pro_type", SqlDbType.Int,4),
					new SqlParameter("@pro_pid", SqlDbType.Int,4),
					new SqlParameter("@pro_imgs", SqlDbType.VarChar,200),
					new SqlParameter("@pro_imgs1", SqlDbType.VarChar,200),
					new SqlParameter("@pro_imgs2", SqlDbType.VarChar,200),
					new SqlParameter("@pro_h_width", SqlDbType.Int,4),
					new SqlParameter("@pro_h_height", SqlDbType.Int,4),
					new SqlParameter("@pro_user", SqlDbType.VarChar,50),
					new SqlParameter("@pro_content", SqlDbType.Text),
					new SqlParameter("@pro_Hot", SqlDbType.Int,4),
					new SqlParameter("@pro_isok", SqlDbType.Int,4),
					new SqlParameter("@pro_Special", SqlDbType.Int,4),
					new SqlParameter("@pro_num", SqlDbType.Int,4),
					new SqlParameter("@pro_sum", SqlDbType.Int,4),
					new SqlParameter("@pro_contact", SqlDbType.VarChar,50),
					new SqlParameter("@pro_level", SqlDbType.Int,4),
					new SqlParameter("@pro_ping", SqlDbType.Float,8),
					new SqlParameter("@pro_home_show", SqlDbType.Int,4),
					new SqlParameter("@flag", SqlDbType.Int,4),
					new SqlParameter("@province_id", SqlDbType.Int,4),
					new SqlParameter("@city_id", SqlDbType.Int,4),
					new SqlParameter("@dictrict_id", SqlDbType.Int,4),
					new SqlParameter("@huiyuan_id", SqlDbType.NVarChar,50),
					new SqlParameter("@shop_fen", SqlDbType.Decimal,9),
					new SqlParameter("@cloud_fen", SqlDbType.Decimal,9),
					new SqlParameter("@futou_fen", SqlDbType.Decimal,9)};
            parameters[0].Value = pro_name;
            parameters[1].Value = pro_memo;
            parameters[2].Value = go_price;
            parameters[3].Value = salse_price;
            parameters[4].Value = pro_PV;
            parameters[5].Value = pro_bianhao;
            parameters[6].Value = bigclassname;
            parameters[7].Value = smallclassname;
            parameters[8].Value = pro_guige;
            parameters[9].Value = pro_danwei;
            parameters[10].Value = pro_date;
            parameters[11].Value = pro_flag;
            parameters[12].Value = pro_type;
            parameters[13].Value = pro_pid;
            parameters[14].Value = pro_imgs;
            parameters[15].Value = pro_imgs1;
            parameters[16].Value = pro_imgs2;
            parameters[17].Value = pro_h_width;
            parameters[18].Value = pro_h_height;
            parameters[19].Value = pro_user;
            parameters[20].Value = pro_content;
            parameters[21].Value = pro_Hot;
            parameters[22].Value = pro_isok;
            parameters[23].Value = pro_Special;
            parameters[24].Value = pro_num;
            parameters[25].Value = pro_sum;
            parameters[26].Value = pro_contact;
            parameters[27].Value = pro_level;
            parameters[28].Value = pro_ping;
            parameters[29].Value = pro_home_show;
            parameters[30].Value = flag;
            parameters[31].Value = province_id;
            parameters[32].Value = city_id;
            parameters[33].Value = dictrict_id;
            parameters[34].Value = huiyuan_id;
            parameters[35].Value = shop_fen;
            parameters[36].Value = cloud_fen;
            parameters[37].Value = futou_fen;

            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
            if (obj == null)
            {
                return 1;
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
            strSql.Append("update [tbl_product] set ");
            strSql.Append("pro_name=@pro_name,");
            strSql.Append("pro_memo=@pro_memo,");
            strSql.Append("go_price=@go_price,");
            strSql.Append("salse_price=@salse_price,");
            strSql.Append("pro_PV=@pro_PV,");
            strSql.Append("pro_bianhao=@pro_bianhao,");
            strSql.Append("bigclassname=@bigclassname,");
            strSql.Append("smallclassname=@smallclassname,");
            strSql.Append("pro_guige=@pro_guige,");
            strSql.Append("pro_danwei=@pro_danwei,");
            strSql.Append("pro_date=@pro_date,");
            strSql.Append("pro_flag=@pro_flag,");
            strSql.Append("pro_type=@pro_type,");
            strSql.Append("pro_pid=@pro_pid,");
            strSql.Append("pro_imgs=@pro_imgs,");
            strSql.Append("pro_imgs1=@pro_imgs1,");
            strSql.Append("pro_imgs2=@pro_imgs2,");
            strSql.Append("pro_h_width=@pro_h_width,");
            strSql.Append("pro_h_height=@pro_h_height,");
            strSql.Append("pro_user=@pro_user,");
            strSql.Append("pro_content=@pro_content,");
            strSql.Append("pro_Hot=@pro_Hot,");
            strSql.Append("pro_isok=@pro_isok,");
            strSql.Append("pro_Special=@pro_Special,");
            strSql.Append("pro_num=@pro_num,");
            strSql.Append("pro_sum=@pro_sum,");
            strSql.Append("pro_contact=@pro_contact,");
            strSql.Append("pro_level=@pro_level,");
            strSql.Append("pro_ping=@pro_ping,");
            strSql.Append("pro_home_show=@pro_home_show,");
            strSql.Append("flag=@flag,");
            strSql.Append("province_id=@province_id,");
            strSql.Append("city_id=@city_id,");
            strSql.Append("dictrict_id=@dictrict_id,");
            strSql.Append("huiyuan_id=@huiyuan_id,");
            strSql.Append("shop_fen=@shop_fen,");
            strSql.Append("cloud_fen=@cloud_fen,");
            strSql.Append("futou_fen=@futou_fen");
            strSql.Append(" where pro_id=@pro_id ");
            SqlParameter[] parameters = {
					new SqlParameter("@pro_name", SqlDbType.VarChar,50),
					new SqlParameter("@pro_memo", SqlDbType.Text),
					new SqlParameter("@go_price", SqlDbType.Decimal,9),
					new SqlParameter("@salse_price", SqlDbType.Decimal,9),
					new SqlParameter("@pro_PV", SqlDbType.Decimal,9),
					new SqlParameter("@pro_bianhao", SqlDbType.VarChar,50),
					new SqlParameter("@bigclassname", SqlDbType.VarChar,50),
					new SqlParameter("@smallclassname", SqlDbType.VarChar,50),
					new SqlParameter("@pro_guige", SqlDbType.VarChar,50),
					new SqlParameter("@pro_danwei", SqlDbType.VarChar,50),
					new SqlParameter("@pro_date", SqlDbType.DateTime),
					new SqlParameter("@pro_flag", SqlDbType.Int,4),
					new SqlParameter("@pro_type", SqlDbType.Int,4),
					new SqlParameter("@pro_pid", SqlDbType.Int,4),
					new SqlParameter("@pro_imgs", SqlDbType.VarChar,200),
					new SqlParameter("@pro_imgs1", SqlDbType.VarChar,200),
					new SqlParameter("@pro_imgs2", SqlDbType.VarChar,200),
					new SqlParameter("@pro_h_width", SqlDbType.Int,4),
					new SqlParameter("@pro_h_height", SqlDbType.Int,4),
					new SqlParameter("@pro_user", SqlDbType.VarChar,50),
					new SqlParameter("@pro_content", SqlDbType.Text),
					new SqlParameter("@pro_Hot", SqlDbType.Int,4),
					new SqlParameter("@pro_isok", SqlDbType.Int,4),
					new SqlParameter("@pro_Special", SqlDbType.Int,4),
					new SqlParameter("@pro_num", SqlDbType.Int,4),
					new SqlParameter("@pro_sum", SqlDbType.Int,4),
					new SqlParameter("@pro_contact", SqlDbType.VarChar,50),
					new SqlParameter("@pro_level", SqlDbType.Int,4),
					new SqlParameter("@pro_ping", SqlDbType.Float,8),
					new SqlParameter("@pro_home_show", SqlDbType.Int,4),
					new SqlParameter("@flag", SqlDbType.Int,4),
					new SqlParameter("@province_id", SqlDbType.Int,4),
					new SqlParameter("@city_id", SqlDbType.Int,4),
					new SqlParameter("@dictrict_id", SqlDbType.Int,4),
					new SqlParameter("@huiyuan_id", SqlDbType.NVarChar,50),
					new SqlParameter("@shop_fen", SqlDbType.Decimal,9),
					new SqlParameter("@cloud_fen", SqlDbType.Decimal,9),
					new SqlParameter("@futou_fen", SqlDbType.Decimal,9),
					new SqlParameter("@pro_id", SqlDbType.Int,4)};
            parameters[0].Value = pro_name;
            parameters[1].Value = pro_memo;
            parameters[2].Value = go_price;
            parameters[3].Value = salse_price;
            parameters[4].Value = pro_PV;
            parameters[5].Value = pro_bianhao;
            parameters[6].Value = bigclassname;
            parameters[7].Value = smallclassname;
            parameters[8].Value = pro_guige;
            parameters[9].Value = pro_danwei;
            parameters[10].Value = pro_date;
            parameters[11].Value = pro_flag;
            parameters[12].Value = pro_type;
            parameters[13].Value = pro_pid;
            parameters[14].Value = pro_imgs;
            parameters[15].Value = pro_imgs1;
            parameters[16].Value = pro_imgs2;
            parameters[17].Value = pro_h_width;
            parameters[18].Value = pro_h_height;
            parameters[19].Value = pro_user;
            parameters[20].Value = pro_content;
            parameters[21].Value = pro_Hot;
            parameters[22].Value = pro_isok;
            parameters[23].Value = pro_Special;
            parameters[24].Value = pro_num;
            parameters[25].Value = pro_sum;
            parameters[26].Value = pro_contact;
            parameters[27].Value = pro_level;
            parameters[28].Value = pro_ping;
            parameters[29].Value = pro_home_show;
            parameters[30].Value = flag;
            parameters[31].Value = province_id;
            parameters[32].Value = city_id;
            parameters[33].Value = dictrict_id;
            parameters[34].Value = huiyuan_id;
            parameters[35].Value = shop_fen;
            parameters[36].Value = cloud_fen;
            parameters[37].Value = futou_fen;
            parameters[38].Value = pro_id;

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
        public bool Delete(int pro_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from [tbl_product] ");
            strSql.Append(" where pro_id=@pro_id ");
            SqlParameter[] parameters = {
					new SqlParameter("@pro_id", SqlDbType.Int,4)};
            parameters[0].Value = pro_id;

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
        public void GetModel(long pro_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 pro_id,pro_name,pro_memo,go_price,salse_price,pro_PV,pro_bianhao,bigclassname,smallclassname,pro_guige,pro_danwei,pro_date,pro_flag,pro_type,pro_pid,pro_imgs,pro_imgs1,pro_imgs2,pro_h_width,pro_h_height,pro_user,pro_content,pro_Hot,pro_isok,pro_Special,pro_num,pro_sum,pro_contact,pro_level,pro_ping,pro_home_show,flag,province_id,city_id,dictrict_id,huiyuan_id,shop_fen,cloud_fen,futou_fen ");
            strSql.Append(" FROM [tbl_product] ");
            strSql.Append(" where pro_id=@pro_id ");
            SqlParameter[] parameters = {
					new SqlParameter("@pro_id", SqlDbType.Int,4)};
            parameters[0].Value = pro_id;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["pro_id"].ToString() != "")
                {
                    this.pro_id = int.Parse(ds.Tables[0].Rows[0]["pro_id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["pro_name"] != null)
                {
                    this.pro_name = ds.Tables[0].Rows[0]["pro_name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["pro_memo"] != null)
                {
                    this.pro_memo = ds.Tables[0].Rows[0]["pro_memo"].ToString();
                }
                if (ds.Tables[0].Rows[0]["go_price"].ToString() != "")
                {
                    this.go_price = decimal.Parse(ds.Tables[0].Rows[0]["go_price"].ToString());
                }
                if (ds.Tables[0].Rows[0]["salse_price"].ToString() != "")
                {
                    this.salse_price = decimal.Parse(ds.Tables[0].Rows[0]["salse_price"].ToString());
                }
                if (ds.Tables[0].Rows[0]["pro_PV"].ToString() != "")
                {
                    this.pro_PV = decimal.Parse(ds.Tables[0].Rows[0]["pro_PV"].ToString());
                }
                if (ds.Tables[0].Rows[0]["pro_bianhao"] != null)
                {
                    this.pro_bianhao = ds.Tables[0].Rows[0]["pro_bianhao"].ToString();
                }
                if (ds.Tables[0].Rows[0]["bigclassname"] != null)
                {
                    this.bigclassname = ds.Tables[0].Rows[0]["bigclassname"].ToString();
                }
                if (ds.Tables[0].Rows[0]["smallclassname"] != null)
                {
                    this.smallclassname = ds.Tables[0].Rows[0]["smallclassname"].ToString();
                }
                if (ds.Tables[0].Rows[0]["pro_guige"] != null)
                {
                    this.pro_guige = ds.Tables[0].Rows[0]["pro_guige"].ToString();
                }
                if (ds.Tables[0].Rows[0]["pro_danwei"] != null)
                {
                    this.pro_danwei = ds.Tables[0].Rows[0]["pro_danwei"].ToString();
                }
                if (ds.Tables[0].Rows[0]["pro_date"].ToString() != "")
                {
                    this.pro_date = DateTime.Parse(ds.Tables[0].Rows[0]["pro_date"].ToString());
                }
                if (ds.Tables[0].Rows[0]["pro_flag"].ToString() != "")
                {
                    this.pro_flag = int.Parse(ds.Tables[0].Rows[0]["pro_flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["pro_type"].ToString() != "")
                {
                    this.pro_type = int.Parse(ds.Tables[0].Rows[0]["pro_type"].ToString());
                }
                if (ds.Tables[0].Rows[0]["pro_pid"].ToString() != "")
                {
                    this.pro_pid = int.Parse(ds.Tables[0].Rows[0]["pro_pid"].ToString());
                }
                if (ds.Tables[0].Rows[0]["pro_imgs"] != null)
                {
                    this.pro_imgs = ds.Tables[0].Rows[0]["pro_imgs"].ToString();
                }
                if (ds.Tables[0].Rows[0]["pro_imgs1"] != null)
                {
                    this.pro_imgs1 = ds.Tables[0].Rows[0]["pro_imgs1"].ToString();
                }
                if (ds.Tables[0].Rows[0]["pro_imgs2"] != null)
                {
                    this.pro_imgs2 = ds.Tables[0].Rows[0]["pro_imgs2"].ToString();
                }
                if (ds.Tables[0].Rows[0]["pro_h_width"].ToString() != "")
                {
                    this.pro_h_width = int.Parse(ds.Tables[0].Rows[0]["pro_h_width"].ToString());
                }
                if (ds.Tables[0].Rows[0]["pro_h_height"].ToString() != "")
                {
                    this.pro_h_height = int.Parse(ds.Tables[0].Rows[0]["pro_h_height"].ToString());
                }
                if (ds.Tables[0].Rows[0]["pro_user"] != null)
                {
                    this.pro_user = ds.Tables[0].Rows[0]["pro_user"].ToString();
                }
                if (ds.Tables[0].Rows[0]["pro_content"] != null)
                {
                    this.pro_content = ds.Tables[0].Rows[0]["pro_content"].ToString();
                }
                if (ds.Tables[0].Rows[0]["pro_Hot"].ToString() != "")
                {
                    this.pro_Hot = int.Parse(ds.Tables[0].Rows[0]["pro_Hot"].ToString());
                }
                if (ds.Tables[0].Rows[0]["pro_isok"].ToString() != "")
                {
                    this.pro_isok = int.Parse(ds.Tables[0].Rows[0]["pro_isok"].ToString());
                }
                if (ds.Tables[0].Rows[0]["pro_Special"].ToString() != "")
                {
                    this.pro_Special = int.Parse(ds.Tables[0].Rows[0]["pro_Special"].ToString());
                }
                if (ds.Tables[0].Rows[0]["pro_num"].ToString() != "")
                {
                    this.pro_num = int.Parse(ds.Tables[0].Rows[0]["pro_num"].ToString());
                }
                if (ds.Tables[0].Rows[0]["pro_sum"].ToString() != "")
                {
                    this.pro_sum = int.Parse(ds.Tables[0].Rows[0]["pro_sum"].ToString());
                }
                if (ds.Tables[0].Rows[0]["pro_contact"] != null)
                {
                    this.pro_contact = ds.Tables[0].Rows[0]["pro_contact"].ToString();
                }
                if (ds.Tables[0].Rows[0]["pro_level"].ToString() != "")
                {
                    this.pro_level = int.Parse(ds.Tables[0].Rows[0]["pro_level"].ToString());
                }
                if (ds.Tables[0].Rows[0]["pro_ping"].ToString() != "")
                {
                    this.pro_ping = decimal.Parse(ds.Tables[0].Rows[0]["pro_ping"].ToString());
                }
                if (ds.Tables[0].Rows[0]["pro_home_show"].ToString() != "")
                {
                    this.pro_home_show = int.Parse(ds.Tables[0].Rows[0]["pro_home_show"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag"].ToString() != "")
                {
                    this.flag = int.Parse(ds.Tables[0].Rows[0]["flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["province_id"].ToString() != "")
                {
                    this.province_id = int.Parse(ds.Tables[0].Rows[0]["province_id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["city_id"].ToString() != "")
                {
                    this.city_id = int.Parse(ds.Tables[0].Rows[0]["city_id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["dictrict_id"].ToString() != "")
                {
                    this.dictrict_id = int.Parse(ds.Tables[0].Rows[0]["dictrict_id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["huiyuan_id"] != null)
                {
                    this.huiyuan_id = ds.Tables[0].Rows[0]["huiyuan_id"].ToString();
                }
                if (ds.Tables[0].Rows[0]["shop_fen"].ToString() != "")
                {
                    this.shop_fen = decimal.Parse(ds.Tables[0].Rows[0]["shop_fen"].ToString());
                }
                if (ds.Tables[0].Rows[0]["cloud_fen"].ToString() != "")
                {
                    this.cloud_fen = decimal.Parse(ds.Tables[0].Rows[0]["cloud_fen"].ToString());
                }
                if (ds.Tables[0].Rows[0]["futou_fen"].ToString() != "")
                {
                    this.futou_fen = decimal.Parse(ds.Tables[0].Rows[0]["futou_fen"].ToString());
                }
            }
        }

        /// <summary>
        /// 获得查询分页数据
        /// </summary>
        public DataSet GetList(int pageSize, int pageIndex, string strWhere, string filedOrder, out int recordCount)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(@"SELECT a.*,b.id as supplyId,b.supplyAddress, b.supplyName,p.ProName,c.CityName,d.DisName
                            FROM dbo.tbl_product AS a
                            left JOIN dbo.tbl_supplier AS b ON a.huiyuan_id = b.huiyuan_id
                            LEFT JOIN T_Province AS p ON p.ProID=a.province_id
                            LEFT JOIN T_City AS c ON c.CityID=a.city_id
                            LEFT JOIN T_District AS d ON d.Id=a.dictrict_id");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            recordCount = Convert.ToInt32(DbHelperSQL.GetSingle(PagingHelper.CreateCountingSql(strSql.ToString())));
            return DbHelperSQL.Query(PagingHelper.CreatePagingSql(recordCount, pageSize, pageIndex, strSql.ToString(), filedOrder));
        }

        /// <summary>
        /// 获得查询分页数据
        /// </summary>
        public DataSet GetList_top(int top ,int pageSize, int pageIndex, string strWhere, string filedOrder, out int recordCount)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top " + top + " * FROM  tbl_product");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            recordCount = Convert.ToInt32(DbHelperSQL.GetSingle(PagingHelper.CreateCountingSql(strSql.ToString())));
            return DbHelperSQL.Query(PagingHelper.CreatePagingSql(recordCount, pageSize, pageIndex, strSql.ToString(), filedOrder));
        }

        /// <summary>
        /// 通过id返回商品类别id
        /// </summary>
        public string GetTPid(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top 1 pro_pid from [tbl_product]");
            strSql.Append(" where pro_id=" + id);
            string title = Convert.ToString(DbHelperSQL.GetSingle(strSql.ToString()));
            if (string.IsNullOrEmpty(title))
            {
                return "";
            }
            return title;
        }


        /// <summary>
        /// 获得查询分页数据
        /// </summary>
        public DataSet GetList1(int pageSize, int pageIndex, string strWhere, string filedOrder, out int recordCount)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * FROM  tbl_product");
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
            strSql.Append("select  * ");
            strSql.Append(" FROM [tbl_product] ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表GetList_top_1(查询条件,查询top几条)
        /// </summary>
        public DataSet GetList_top_1(string strWhere,int top)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top " + top + " * ");
            strSql.Append(" FROM [tbl_product] ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList_top(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top 6 * ");
            strSql.Append(" FROM [tbl_product] ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }
        #endregion  Method

        /// <summary>
        /// 返回商品图片
        /// </summary>
        public string Getimg(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top 1 pro_imgs from [tbl_product]");
            strSql.Append(" where pro_id=" + id);
            string title = Convert.ToString(DbHelperSQL.GetSingle(strSql.ToString()));
            if (string.IsNullOrEmpty(title))
            {
                return "";
            }
            return title;
        }
    }
 

