using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
 
 /// <summary>
    /// 类tbl_orders。
    /// </summary>
    [Serializable]
    public partial class tbl_orders
    {
        public tbl_orders()
        { }
        #region Model
        private int _id;
        private string _order_no = "";
        private string _user_id;
        private string _user_name = "";
        private string _user_bianhao;
        private int? _payment_id = 0;
        private int? _payment_status = 1;
        private DateTime? _payment_time;
        private string _message = "";
        private string _remark = "";
        private decimal? _payable_amount = 0M;
        private decimal? _real_amount = 0M;
        private decimal? _order_amount = 0M;
        private int? _status = 1;
        private DateTime? _add_time = DateTime.Now;
        private DateTime? _confirm_time;
        private DateTime? _complete_time;
        private string _address;
        private string _phone;
        private string _shouhuo_name;
        private string _wuliu_company;
        private string _wuliu_no;
        private int? _flag = 0;
        private DateTime? _fahuo_date;
        /// <summary>
        /// 自增ID
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 订单号
        /// </summary>
        public string order_no
        {
            set { _order_no = value; }
            get { return _order_no; }
        }
        /// <summary>
        /// 用户ID
        /// </summary>
        public string user_id
        {
            set { _user_id = value; }
            get { return _user_id; }
        }
        /// <summary>
        /// 用户名
        /// </summary>
        public string user_name
        {
            set { _user_name = value; }
            get { return _user_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string user_bianhao
        {
            set { _user_bianhao = value; }
            get { return _user_bianhao; }
        }
        /// <summary>
        /// 支付方式
        /// </summary>
        public int? payment_id
        {
            set { _payment_id = value; }
            get { return _payment_id; }
        }
        /// <summary>
        /// 支付状态1未支付2已支付
        /// </summary>
        public int? payment_status
        {
            set { _payment_status = value; }
            get { return _payment_status; }
        }
        /// <summary>
        /// 支付时间
        /// </summary>
        public DateTime? payment_time
        {
            set { _payment_time = value; }
            get { return _payment_time; }
        }
        /// <summary>
        /// 订单留言
        /// </summary>
        public string message
        {
            set { _message = value; }
            get { return _message; }
        }
        /// <summary>
        /// 订单备注
        /// </summary>
        public string remark
        {
            set { _remark = value; }
            get { return _remark; }
        }
        /// <summary>
        /// 订单商品总金额
        /// </summary>
        public decimal? payable_amount
        {
            set { _payable_amount = value; }
            get { return _payable_amount; }
        }
        /// <summary>
        /// 调价金额
        /// </summary>
        public decimal? real_amount
        {
            set { _real_amount = value; }
            get { return _real_amount; }
        }
        /// <summary>
        /// 订单实际总金额
        /// </summary>
        public decimal? order_amount
        {
            set { _order_amount = value; }
            get { return _order_amount; }
        }
        /// <summary>
        /// 订单状态1生成订单,2确认发货,3已经收货,4取消订单
        /// </summary>
        public int? status
        {
            set { _status = value; }
            get { return _status; }
        }
        /// <summary>
        /// 下单时间
        /// </summary>
        public DateTime? add_time
        {
            set { _add_time = value; }
            get { return _add_time; }
        }
        /// <summary>
        /// 确认时间
        /// </summary>
        public DateTime? confirm_time
        {
            set { _confirm_time = value; }
            get { return _confirm_time; }
        }
        /// <summary>
        /// 订单完成时间
        /// </summary>
        public DateTime? complete_time
        {
            set { _complete_time = value; }
            get { return _complete_time; }
        }
        /// <summary>
        /// 收货人地址
        /// </summary>
        public string address
        {
            set { _address = value; }
            get { return _address; }
        }
        /// <summary>
        /// 收货人手机
        /// </summary>
        public string phone
        {
            set { _phone = value; }
            get { return _phone; }
        }
        /// <summary>
        /// 收货人姓名
        /// </summary>
        public string shouhuo_name
        {
            set { _shouhuo_name = value; }
            get { return _shouhuo_name; }
        }
        /// <summary>
        /// 物流公司名称
        /// </summary>
        public string wuliu_company
        {
            set { _wuliu_company = value; }
            get { return _wuliu_company; }
        }
        /// <summary>
        /// 物流单号
        /// </summary>
        public string wuliu_no
        {
            set { _wuliu_no = value; }
            get { return _wuliu_no; }
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
        /// 发货时间
        /// </summary>
        public DateTime? fahuo_Date
        {
            set { _fahuo_date = value; }
            get { return _fahuo_date; }
        }
        #endregion Model


        #region  Method


        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {

            return DbHelperSQL.GetMaxID("id", "tbl_orders");
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public tbl_orders(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,order_no,user_id,user_name,user_bianhao,payment_id,payment_status,payment_time,message,remark,payable_amount,real_amount,order_amount,status,add_time,confirm_time,complete_time,address,phone,shouhuo_name,wuliu_company,wuliu_no,flag,fahuo_Date ");
            strSql.Append(" FROM [tbl_orders] ");
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
                if (ds.Tables[0].Rows[0]["order_no"] != null)
                {
                    this.order_no = ds.Tables[0].Rows[0]["order_no"].ToString();
                }
                if (ds.Tables[0].Rows[0]["user_id"] != null)
                {
                    this.user_id = ds.Tables[0].Rows[0]["user_id"].ToString();
                }
                if (ds.Tables[0].Rows[0]["user_name"] != null)
                {
                    this.user_name = ds.Tables[0].Rows[0]["user_name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["user_bianhao"] != null)
                {
                    this.user_bianhao = ds.Tables[0].Rows[0]["user_bianhao"].ToString();
                }
                if (ds.Tables[0].Rows[0]["payment_id"] != null && ds.Tables[0].Rows[0]["payment_id"].ToString() != "")
                {
                    this.payment_id = int.Parse(ds.Tables[0].Rows[0]["payment_id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["payment_status"] != null && ds.Tables[0].Rows[0]["payment_status"].ToString() != "")
                {
                    this.payment_status = int.Parse(ds.Tables[0].Rows[0]["payment_status"].ToString());
                }
                if (ds.Tables[0].Rows[0]["payment_time"] != null && ds.Tables[0].Rows[0]["payment_time"].ToString() != "")
                {
                    this.payment_time = DateTime.Parse(ds.Tables[0].Rows[0]["payment_time"].ToString());
                }
                if (ds.Tables[0].Rows[0]["message"] != null)
                {
                    this.message = ds.Tables[0].Rows[0]["message"].ToString();
                }
                if (ds.Tables[0].Rows[0]["remark"] != null)
                {
                    this.remark = ds.Tables[0].Rows[0]["remark"].ToString();
                }
                if (ds.Tables[0].Rows[0]["payable_amount"] != null && ds.Tables[0].Rows[0]["payable_amount"].ToString() != "")
                {
                    this.payable_amount = decimal.Parse(ds.Tables[0].Rows[0]["payable_amount"].ToString());
                }
                if (ds.Tables[0].Rows[0]["real_amount"] != null && ds.Tables[0].Rows[0]["real_amount"].ToString() != "")
                {
                    this.real_amount = decimal.Parse(ds.Tables[0].Rows[0]["real_amount"].ToString());
                }
                if (ds.Tables[0].Rows[0]["order_amount"] != null && ds.Tables[0].Rows[0]["order_amount"].ToString() != "")
                {
                    this.order_amount = decimal.Parse(ds.Tables[0].Rows[0]["order_amount"].ToString());
                }
                if (ds.Tables[0].Rows[0]["status"] != null && ds.Tables[0].Rows[0]["status"].ToString() != "")
                {
                    this.status = int.Parse(ds.Tables[0].Rows[0]["status"].ToString());
                }
                if (ds.Tables[0].Rows[0]["add_time"] != null && ds.Tables[0].Rows[0]["add_time"].ToString() != "")
                {
                    this.add_time = DateTime.Parse(ds.Tables[0].Rows[0]["add_time"].ToString());
                }
                if (ds.Tables[0].Rows[0]["confirm_time"] != null && ds.Tables[0].Rows[0]["confirm_time"].ToString() != "")
                {
                    this.confirm_time = DateTime.Parse(ds.Tables[0].Rows[0]["confirm_time"].ToString());
                }
                if (ds.Tables[0].Rows[0]["complete_time"] != null && ds.Tables[0].Rows[0]["complete_time"].ToString() != "")
                {
                    this.complete_time = DateTime.Parse(ds.Tables[0].Rows[0]["complete_time"].ToString());
                }
                if (ds.Tables[0].Rows[0]["address"] != null)
                {
                    this.address = ds.Tables[0].Rows[0]["address"].ToString();
                }
                if (ds.Tables[0].Rows[0]["phone"] != null)
                {
                    this.phone = ds.Tables[0].Rows[0]["phone"].ToString();
                }
                if (ds.Tables[0].Rows[0]["shouhuo_name"] != null)
                {
                    this.shouhuo_name = ds.Tables[0].Rows[0]["shouhuo_name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["wuliu_company"] != null)
                {
                    this.wuliu_company = ds.Tables[0].Rows[0]["wuliu_company"].ToString();
                }
                if (ds.Tables[0].Rows[0]["wuliu_no"] != null)
                {
                    this.wuliu_no = ds.Tables[0].Rows[0]["wuliu_no"].ToString();
                }
                if (ds.Tables[0].Rows[0]["flag"] != null && ds.Tables[0].Rows[0]["flag"].ToString() != "")
                {
                    this.flag = int.Parse(ds.Tables[0].Rows[0]["flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["fahuo_Date"] != null && ds.Tables[0].Rows[0]["fahuo_Date"].ToString() != "")
                {
                    this.fahuo_Date = DateTime.Parse(ds.Tables[0].Rows[0]["fahuo_Date"].ToString());
                }
            }
        }
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from [tbl_orders]");
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
            strSql.Append("insert into [tbl_orders] (");
            strSql.Append("order_no,user_id,user_name,user_bianhao,payment_id,payment_status,payment_time,message,remark,payable_amount,real_amount,order_amount,status,add_time,confirm_time,complete_time,address,phone,shouhuo_name,wuliu_company,wuliu_no,flag,fahuo_Date)");
            strSql.Append(" values (");
            strSql.Append("@order_no,@user_id,@user_name,@user_bianhao,@payment_id,@payment_status,@payment_time,@message,@remark,@payable_amount,@real_amount,@order_amount,@status,@add_time,@confirm_time,@complete_time,@address,@phone,@shouhuo_name,@wuliu_company,@wuliu_no,@flag,@fahuo_Date)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@order_no", SqlDbType.NVarChar,100),
					new SqlParameter("@user_id", SqlDbType.Char,9),
					new SqlParameter("@user_name", SqlDbType.NVarChar,100),
					new SqlParameter("@user_bianhao", SqlDbType.NVarChar,100),
					new SqlParameter("@payment_id", SqlDbType.Int,4),
					new SqlParameter("@payment_status", SqlDbType.TinyInt,1),
					new SqlParameter("@payment_time", SqlDbType.DateTime),
					new SqlParameter("@message", SqlDbType.NVarChar,500),
					new SqlParameter("@remark", SqlDbType.NVarChar,500),
					new SqlParameter("@payable_amount", SqlDbType.Decimal,5),
					new SqlParameter("@real_amount", SqlDbType.Decimal,5),
					new SqlParameter("@order_amount", SqlDbType.Decimal,5),
					new SqlParameter("@status", SqlDbType.TinyInt,1),
					new SqlParameter("@add_time", SqlDbType.DateTime),
					new SqlParameter("@confirm_time", SqlDbType.DateTime),
					new SqlParameter("@complete_time", SqlDbType.DateTime),
					new SqlParameter("@address", SqlDbType.VarChar,5000),
					new SqlParameter("@phone", SqlDbType.VarChar,50),
					new SqlParameter("@shouhuo_name", SqlDbType.VarChar,50),
					new SqlParameter("@wuliu_company", SqlDbType.VarChar,500),
					new SqlParameter("@wuliu_no", SqlDbType.VarChar,500),
					new SqlParameter("@flag", SqlDbType.Int,4),
					new SqlParameter("@fahuo_Date", SqlDbType.DateTime)};
            parameters[0].Value = order_no;
            parameters[1].Value = user_id;
            parameters[2].Value = user_name;
            parameters[3].Value = user_bianhao;
            parameters[4].Value = payment_id;
            parameters[5].Value = payment_status;
            parameters[6].Value = payment_time;
            parameters[7].Value = message;
            parameters[8].Value = remark;
            parameters[9].Value = payable_amount;
            parameters[10].Value = real_amount;
            parameters[11].Value = order_amount;
            parameters[12].Value = status;
            parameters[13].Value = add_time;
            parameters[14].Value = confirm_time;
            parameters[15].Value = complete_time;
            parameters[16].Value = address;
            parameters[17].Value = phone;
            parameters[18].Value = shouhuo_name;
            parameters[19].Value = wuliu_company;
            parameters[20].Value = wuliu_no;
            parameters[21].Value = flag;
            parameters[22].Value = fahuo_Date;

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
            strSql.Append("update [tbl_orders] set ");
            strSql.Append("order_no=@order_no,");
            strSql.Append("user_id=@user_id,");
            strSql.Append("user_name=@user_name,");
            strSql.Append("user_bianhao=@user_bianhao,");
            strSql.Append("payment_id=@payment_id,");
            strSql.Append("payment_status=@payment_status,");
            strSql.Append("payment_time=@payment_time,");
            strSql.Append("message=@message,");
            strSql.Append("remark=@remark,");
            strSql.Append("payable_amount=@payable_amount,");
            strSql.Append("real_amount=@real_amount,");
            strSql.Append("order_amount=@order_amount,");
            strSql.Append("status=@status,");
            strSql.Append("add_time=@add_time,");
            strSql.Append("confirm_time=@confirm_time,");
            strSql.Append("complete_time=@complete_time,");
            strSql.Append("address=@address,");
            strSql.Append("phone=@phone,");
            strSql.Append("shouhuo_name=@shouhuo_name,");
            strSql.Append("wuliu_company=@wuliu_company,");
            strSql.Append("wuliu_no=@wuliu_no,");
            strSql.Append("flag=@flag,");
            strSql.Append("fahuo_Date=@fahuo_Date");
            strSql.Append(" where id=@id ");
            SqlParameter[] parameters = {
					new SqlParameter("@order_no", SqlDbType.NVarChar,100),
					new SqlParameter("@user_id", SqlDbType.Char,9),
					new SqlParameter("@user_name", SqlDbType.NVarChar,100),
					new SqlParameter("@user_bianhao", SqlDbType.NVarChar,100),
					new SqlParameter("@payment_id", SqlDbType.Int,4),
					new SqlParameter("@payment_status", SqlDbType.TinyInt,1),
					new SqlParameter("@payment_time", SqlDbType.DateTime),
					new SqlParameter("@message", SqlDbType.NVarChar,500),
					new SqlParameter("@remark", SqlDbType.NVarChar,500),
					new SqlParameter("@payable_amount", SqlDbType.Decimal,5),
					new SqlParameter("@real_amount", SqlDbType.Decimal,5),
					new SqlParameter("@order_amount", SqlDbType.Decimal,5),
					new SqlParameter("@status", SqlDbType.TinyInt,1),
					new SqlParameter("@add_time", SqlDbType.DateTime),
					new SqlParameter("@confirm_time", SqlDbType.DateTime),
					new SqlParameter("@complete_time", SqlDbType.DateTime),
					new SqlParameter("@address", SqlDbType.VarChar,5000),
					new SqlParameter("@phone", SqlDbType.VarChar,50),
					new SqlParameter("@shouhuo_name", SqlDbType.VarChar,50),
					new SqlParameter("@wuliu_company", SqlDbType.VarChar,500),
					new SqlParameter("@wuliu_no", SqlDbType.VarChar,500),
					new SqlParameter("@flag", SqlDbType.Int,4),
					new SqlParameter("@fahuo_Date", SqlDbType.DateTime),
					new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = order_no;
            parameters[1].Value = user_id;
            parameters[2].Value = user_name;
            parameters[3].Value = user_bianhao;
            parameters[4].Value = payment_id;
            parameters[5].Value = payment_status;
            parameters[6].Value = payment_time;
            parameters[7].Value = message;
            parameters[8].Value = remark;
            parameters[9].Value = payable_amount;
            parameters[10].Value = real_amount;
            parameters[11].Value = order_amount;
            parameters[12].Value = status;
            parameters[13].Value = add_time;
            parameters[14].Value = confirm_time;
            parameters[15].Value = complete_time;
            parameters[16].Value = address;
            parameters[17].Value = phone;
            parameters[18].Value = shouhuo_name;
            parameters[19].Value = wuliu_company;
            parameters[20].Value = wuliu_no;
            parameters[21].Value = flag;
            parameters[22].Value = fahuo_Date;
            parameters[23].Value = id;

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
            strSql.Append("delete from [tbl_orders] ");
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
        /// 删除一条数据
        /// </summary>
        public bool Delete_orders(string user_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from [tbl_orders] ");
            strSql.Append(" where user_id=@user_id ");
            SqlParameter[] parameters = {
					new SqlParameter("@user_id", SqlDbType.Char,9)};
            parameters[0].Value = user_id;

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
        /// 根据上级订单id得到一个对象实体注意int类型
        /// </summary>
        public void GetModel(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,order_no,user_id,user_name,user_bianhao,payment_id,payment_status,payment_time,message,remark,payable_amount,real_amount,order_amount,status,add_time,confirm_time,complete_time,address,phone,shouhuo_name,wuliu_company,wuliu_no,flag,fahuo_Date ");
            strSql.Append(" FROM [tbl_orders] ");
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
                if (ds.Tables[0].Rows[0]["order_no"] != null)
                {
                    this.order_no = ds.Tables[0].Rows[0]["order_no"].ToString();
                }
                if (ds.Tables[0].Rows[0]["user_id"] != null)
                {
                    this.user_id = ds.Tables[0].Rows[0]["user_id"].ToString();
                }
                if (ds.Tables[0].Rows[0]["user_name"] != null)
                {
                    this.user_name = ds.Tables[0].Rows[0]["user_name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["user_bianhao"] != null)
                {
                    this.user_bianhao = ds.Tables[0].Rows[0]["user_bianhao"].ToString();
                }
                if (ds.Tables[0].Rows[0]["payment_id"] != null && ds.Tables[0].Rows[0]["payment_id"].ToString() != "")
                {
                    this.payment_id = int.Parse(ds.Tables[0].Rows[0]["payment_id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["payment_status"] != null && ds.Tables[0].Rows[0]["payment_status"].ToString() != "")
                {
                    this.payment_status = int.Parse(ds.Tables[0].Rows[0]["payment_status"].ToString());
                }
                if (ds.Tables[0].Rows[0]["payment_time"] != null && ds.Tables[0].Rows[0]["payment_time"].ToString() != "")
                {
                    this.payment_time = DateTime.Parse(ds.Tables[0].Rows[0]["payment_time"].ToString());
                }
                if (ds.Tables[0].Rows[0]["message"] != null)
                {
                    this.message = ds.Tables[0].Rows[0]["message"].ToString();
                }
                if (ds.Tables[0].Rows[0]["remark"] != null)
                {
                    this.remark = ds.Tables[0].Rows[0]["remark"].ToString();
                }
                if (ds.Tables[0].Rows[0]["payable_amount"] != null && ds.Tables[0].Rows[0]["payable_amount"].ToString() != "")
                {
                    this.payable_amount = decimal.Parse(ds.Tables[0].Rows[0]["payable_amount"].ToString());
                }
                if (ds.Tables[0].Rows[0]["real_amount"] != null && ds.Tables[0].Rows[0]["real_amount"].ToString() != "")
                {
                    this.real_amount = decimal.Parse(ds.Tables[0].Rows[0]["real_amount"].ToString());
                }
                if (ds.Tables[0].Rows[0]["order_amount"] != null && ds.Tables[0].Rows[0]["order_amount"].ToString() != "")
                {
                    this.order_amount = decimal.Parse(ds.Tables[0].Rows[0]["order_amount"].ToString());
                }
                if (ds.Tables[0].Rows[0]["status"] != null && ds.Tables[0].Rows[0]["status"].ToString() != "")
                {
                    this.status = int.Parse(ds.Tables[0].Rows[0]["status"].ToString());
                }
                if (ds.Tables[0].Rows[0]["add_time"] != null && ds.Tables[0].Rows[0]["add_time"].ToString() != "")
                {
                    this.add_time = DateTime.Parse(ds.Tables[0].Rows[0]["add_time"].ToString());
                }
                if (ds.Tables[0].Rows[0]["confirm_time"] != null && ds.Tables[0].Rows[0]["confirm_time"].ToString() != "")
                {
                    this.confirm_time = DateTime.Parse(ds.Tables[0].Rows[0]["confirm_time"].ToString());
                }
                if (ds.Tables[0].Rows[0]["complete_time"] != null && ds.Tables[0].Rows[0]["complete_time"].ToString() != "")
                {
                    this.complete_time = DateTime.Parse(ds.Tables[0].Rows[0]["complete_time"].ToString());
                }
                if (ds.Tables[0].Rows[0]["address"] != null)
                {
                    this.address = ds.Tables[0].Rows[0]["address"].ToString();
                }
                if (ds.Tables[0].Rows[0]["phone"] != null)
                {
                    this.phone = ds.Tables[0].Rows[0]["phone"].ToString();
                }
                if (ds.Tables[0].Rows[0]["shouhuo_name"] != null)
                {
                    this.shouhuo_name = ds.Tables[0].Rows[0]["shouhuo_name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["wuliu_company"] != null)
                {
                    this.wuliu_company = ds.Tables[0].Rows[0]["wuliu_company"].ToString();
                }
                if (ds.Tables[0].Rows[0]["wuliu_no"] != null)
                {
                    this.wuliu_no = ds.Tables[0].Rows[0]["wuliu_no"].ToString();
                }
                if (ds.Tables[0].Rows[0]["flag"] != null && ds.Tables[0].Rows[0]["flag"].ToString() != "")
                {
                    this.flag = int.Parse(ds.Tables[0].Rows[0]["flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["fahuo_Date"] != null && ds.Tables[0].Rows[0]["fahuo_Date"].ToString() != "")
                {
                    this.fahuo_Date = DateTime.Parse(ds.Tables[0].Rows[0]["fahuo_Date"].ToString());
                }
            }
        }
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public void GetModel(string order_no)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,order_no,user_id,user_name,user_bianhao,payment_id,payment_status,payment_time,message,remark,payable_amount,real_amount,order_amount,status,add_time,confirm_time,complete_time,address,phone,shouhuo_name,wuliu_company,wuliu_no,flag,fahuo_Date ");
            strSql.Append(" FROM [tbl_orders] ");
            strSql.Append(" where order_no=@order_no ");
            SqlParameter[] parameters = {
					new SqlParameter("@order_no", SqlDbType.NVarChar,-1)};
            parameters[0].Value = order_no;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["id"] != null && ds.Tables[0].Rows[0]["id"].ToString() != "")
                {
                    this.id = int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["order_no"] != null)
                {
                    this.order_no = ds.Tables[0].Rows[0]["order_no"].ToString();
                }
                if (ds.Tables[0].Rows[0]["user_id"] != null)
                {
                    this.user_id = ds.Tables[0].Rows[0]["user_id"].ToString();
                }
                if (ds.Tables[0].Rows[0]["user_name"] != null)
                {
                    this.user_name = ds.Tables[0].Rows[0]["user_name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["user_bianhao"] != null)
                {
                    this.user_bianhao = ds.Tables[0].Rows[0]["user_bianhao"].ToString();
                }
                if (ds.Tables[0].Rows[0]["payment_id"] != null && ds.Tables[0].Rows[0]["payment_id"].ToString() != "")
                {
                    this.payment_id = int.Parse(ds.Tables[0].Rows[0]["payment_id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["payment_status"] != null && ds.Tables[0].Rows[0]["payment_status"].ToString() != "")
                {
                    this.payment_status = int.Parse(ds.Tables[0].Rows[0]["payment_status"].ToString());
                }
                if (ds.Tables[0].Rows[0]["payment_time"] != null && ds.Tables[0].Rows[0]["payment_time"].ToString() != "")
                {
                    this.payment_time = DateTime.Parse(ds.Tables[0].Rows[0]["payment_time"].ToString());
                }
                if (ds.Tables[0].Rows[0]["message"] != null)
                {
                    this.message = ds.Tables[0].Rows[0]["message"].ToString();
                }
                if (ds.Tables[0].Rows[0]["remark"] != null)
                {
                    this.remark = ds.Tables[0].Rows[0]["remark"].ToString();
                }
                if (ds.Tables[0].Rows[0]["payable_amount"] != null && ds.Tables[0].Rows[0]["payable_amount"].ToString() != "")
                {
                    this.payable_amount = decimal.Parse(ds.Tables[0].Rows[0]["payable_amount"].ToString());
                }
                if (ds.Tables[0].Rows[0]["real_amount"] != null && ds.Tables[0].Rows[0]["real_amount"].ToString() != "")
                {
                    this.real_amount = decimal.Parse(ds.Tables[0].Rows[0]["real_amount"].ToString());
                }
                if (ds.Tables[0].Rows[0]["order_amount"] != null && ds.Tables[0].Rows[0]["order_amount"].ToString() != "")
                {
                    this.order_amount = decimal.Parse(ds.Tables[0].Rows[0]["order_amount"].ToString());
                }
                if (ds.Tables[0].Rows[0]["status"] != null && ds.Tables[0].Rows[0]["status"].ToString() != "")
                {
                    this.status = int.Parse(ds.Tables[0].Rows[0]["status"].ToString());
                }
                if (ds.Tables[0].Rows[0]["add_time"] != null && ds.Tables[0].Rows[0]["add_time"].ToString() != "")
                {
                    this.add_time = DateTime.Parse(ds.Tables[0].Rows[0]["add_time"].ToString());
                }
                if (ds.Tables[0].Rows[0]["confirm_time"] != null && ds.Tables[0].Rows[0]["confirm_time"].ToString() != "")
                {
                    this.confirm_time = DateTime.Parse(ds.Tables[0].Rows[0]["confirm_time"].ToString());
                }
                if (ds.Tables[0].Rows[0]["complete_time"] != null && ds.Tables[0].Rows[0]["complete_time"].ToString() != "")
                {
                    this.complete_time = DateTime.Parse(ds.Tables[0].Rows[0]["complete_time"].ToString());
                }
                if (ds.Tables[0].Rows[0]["address"] != null)
                {
                    this.address = ds.Tables[0].Rows[0]["address"].ToString();
                }
                if (ds.Tables[0].Rows[0]["phone"] != null)
                {
                    this.phone = ds.Tables[0].Rows[0]["phone"].ToString();
                }
                if (ds.Tables[0].Rows[0]["shouhuo_name"] != null)
                {
                    this.shouhuo_name = ds.Tables[0].Rows[0]["shouhuo_name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["wuliu_company"] != null)
                {
                    this.wuliu_company = ds.Tables[0].Rows[0]["wuliu_company"].ToString();
                }
                if (ds.Tables[0].Rows[0]["wuliu_no"] != null)
                {
                    this.wuliu_no = ds.Tables[0].Rows[0]["wuliu_no"].ToString();
                }
                if (ds.Tables[0].Rows[0]["flag"] != null && ds.Tables[0].Rows[0]["flag"].ToString() != "")
                {
                    this.flag = int.Parse(ds.Tables[0].Rows[0]["flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["fahuo_Date"] != null && ds.Tables[0].Rows[0]["fahuo_Date"].ToString() != "")
                {
                    this.fahuo_Date = DateTime.Parse(ds.Tables[0].Rows[0]["fahuo_Date"].ToString());
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
            strSql.Append(" FROM [tbl_orders] ");
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
            strSql.Append("select top 1 " + Title + " as sumcode from [tbl_orders]");
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
            strSql.Append("select * FROM  view_orders   ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            recordCount = Convert.ToInt32(DbHelperSQL.GetSingle(PagingHelper.CreateCountingSql(strSql.ToString())));
            return DbHelperSQL.Query(PagingHelper.CreatePagingSql(recordCount, pageSize, pageIndex, strSql.ToString(), filedOrder));
        }
        public DataSet GetList1(int pageSize, int pageIndex, string strWhere, string filedOrder, out int recordCount)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(@"SELECT a.* FROM view_orders AS a
                            INNER JOIN tbl_order_goods AS b ON b.order_id=a.id
                            INNER JOIN tbl_product AS c ON c.pro_id=b.goods_id
                            INNER JOIN tbl_huiyuan AS d ON d.huiyuan_id=c.huiyuan_id");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            recordCount = Convert.ToInt32(DbHelperSQL.GetSingle(PagingHelper.CreateCountingSql(strSql.ToString())));
            return DbHelperSQL.Query(PagingHelper.CreatePagingSql(recordCount, pageSize, pageIndex, strSql.ToString(), filedOrder));
        }
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string order_no)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from [tbl_orders]");
            strSql.Append(" where order_no=@order_no ");
            SqlParameter[] parameters = {
					new SqlParameter("@order_no", SqlDbType.NVarChar,100)};
            parameters[0].Value = order_no;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

       	#endregion  Method

        /// <summary>
        /// 返回订单状态
        /// </summary>
        public string GetOrderStatus(int _id)
        {
            string _title = string.Empty;

            switch (_id)
            {
                
                case 1:
                    _title = "已生成";
                    break;
                case 2:
                    _title = "已发货";
                    break;
                case 3:
                    _title = "已收货";
                    break;
                case 4:
                    _title = "已取消";
                    break;
                case 5:
                    _title = "已作废";
                    break;
            }

            return _title;
        }

        /// <summary>
        /// 返回是否支付状态
        /// </summary>
        public string pay_status(int _id)
        {
            string _title = string.Empty;

            switch (_id)
            {

                case 1:
                    _title = "未付款";
                    break;
                case 2:
                    _title = "已付款";
                    break;
              
            }

            return _title;
        }
        public bool delectid(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from [tbl_orders] ");
            strSql.Append(" where id=" + id);
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
 

