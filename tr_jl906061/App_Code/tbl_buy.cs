using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;

/// <summary>
/// 类tbl_buy。
/// </summary>
[Serializable]
public partial class tbl_buy
{
    public tbl_buy()
    { }
    #region Model
    private int _id;
    private string _dd_no;
    private DateTime? _cj_date;
    private decimal? _sq_money;
    private decimal? _sy_money;
    private decimal? _lixi = 0M;
    private int? _cishu = 0;
    private string _buy_id;
    private int? _sell_pid;
    private DateTime? _pipei_qr_date;
    private int? _flag = 0;
    private int? _flag_1 = 0;
    private int? _flag_2 = 0;
    private int? _zhifu_type = 0;
    private int? _pipei_renshu = 0;
    private decimal? _dj_money = 0M;
    private int? _flag_3 = 0;
    private int? _flag_4 = 0;
    private DateTime? _qr_date;
    private int? _tx_flag = 0;
    private DateTime? _tx_date;
    private int? _flag_qd = 0;
    private decimal? _guding_lixi = 0M;
    private int? _cishu1 = 0;
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
    /// 利息
    /// </summary>
    public decimal? lixi
    {
        set { _lixi = value; }
        get { return _lixi; }
    }
    /// <summary>
    /// 次数
    /// </summary>
    public int? cishu
    {
        set { _cishu = value; }
        get { return _cishu; }
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
    /// 
    /// </summary>
    public int? sell_pid
    {
        set { _sell_pid = value; }
        get { return _sell_pid; }
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
    /// <summary>
    /// 冻结金额
    /// </summary>
    public decimal? dj_money
    {
        set { _dj_money = value; }
        get { return _dj_money; }
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
    /// 完成时间
    /// </summary>
    public DateTime? qr_date
    {
        set { _qr_date = value; }
        get { return _qr_date; }
    }

    /// <summary>
    /// 
    /// </summary>
    public int? tx_flag
    {
        set { _tx_flag = value; }
        get { return _tx_flag; }
    }
    /// <summary>
    /// 提取时间
    /// </summary>
    public DateTime? tx_date
    {
        set { _tx_date = value; }
        get { return _tx_date; }
    }

    public int? flag_qd
    {
        set { _flag_qd = value; }
        get { return _flag_qd; }
    }

    /// <summary>
    /// 固定利息
    /// </summary>
    public decimal? guding_lixi
    {
        set { _guding_lixi = value; }
        get { return _guding_lixi; }
    }
    public int? cishu1
    {
        set { _cishu1 = value; }
        get { return _cishu1; }
    }

    
    #endregion Model

    #region  Method

    /// <summary>
    /// 得到一个对象实体
    /// </summary>
    public tbl_buy(int id)
    {
        StringBuilder strSql = new StringBuilder();
        strSql.Append("select id,dd_no,cj_date,sq_money,sy_money,lixi,cishu,buy_id,sell_pid,pipei_qr_date,flag,flag_1,flag_2,zhifu_type,pipei_renshu,dj_money,flag_3,flag_4,qr_date ");
        strSql.Append(" FROM [tbl_buy] ");
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
            if (ds.Tables[0].Rows[0]["lixi"] != null && ds.Tables[0].Rows[0]["lixi"].ToString() != "")
            {
                this.lixi = decimal.Parse(ds.Tables[0].Rows[0]["lixi"].ToString());
            }
            if (ds.Tables[0].Rows[0]["cishu"] != null && ds.Tables[0].Rows[0]["cishu"].ToString() != "")
            {
                this.cishu = int.Parse(ds.Tables[0].Rows[0]["cishu"].ToString());
            }
            if (ds.Tables[0].Rows[0]["buy_id"] != null)
            {
                this.buy_id = ds.Tables[0].Rows[0]["buy_id"].ToString();
            }
            if (ds.Tables[0].Rows[0]["sell_pid"] != null && ds.Tables[0].Rows[0]["sell_pid"].ToString() != "")
            {
                this.sell_pid = int.Parse(ds.Tables[0].Rows[0]["sell_pid"].ToString());
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
            if (ds.Tables[0].Rows[0]["dj_money"] != null && ds.Tables[0].Rows[0]["dj_money"].ToString() != "")
            {
                this.dj_money = decimal.Parse(ds.Tables[0].Rows[0]["dj_money"].ToString());
            }
            if (ds.Tables[0].Rows[0]["flag_3"] != null && ds.Tables[0].Rows[0]["flag_3"].ToString() != "")
            {
                this.flag_3 = int.Parse(ds.Tables[0].Rows[0]["flag_3"].ToString());
            }
            if (ds.Tables[0].Rows[0]["flag_4"] != null && ds.Tables[0].Rows[0]["flag_4"].ToString() != "")
            {
                this.flag_4 = int.Parse(ds.Tables[0].Rows[0]["flag_4"].ToString());
            }
            if (ds.Tables[0].Rows[0]["qr_date"] != null && ds.Tables[0].Rows[0]["qr_date"].ToString() != "")
            {
                this.qr_date = DateTime.Parse(ds.Tables[0].Rows[0]["qr_date"].ToString());
            }
        }
    }
    /// <summary>
    /// 是否存在该记录
    /// </summary>
    public bool Exists()
    {
        StringBuilder strSql = new StringBuilder();
        strSql.Append("select count(1) from [tbl_buy]");
        strSql.Append(" where id=@id ");

        SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)};
        parameters[0].Value = id;

        return DbHelperSQL.Exists(strSql.ToString(), parameters);
    }

    /// <summary>
    /// 是否存在该记录
    /// </summary>
    public bool Exists_tgbz()
    {
        StringBuilder strSql = new StringBuilder();
        strSql.Append("select count(1) from [tbl_buy]");
        strSql.Append(" where buy_id=@buy_id and flag<>4 ");

        SqlParameter[] parameters = {
					new SqlParameter("@buy_id", SqlDbType.Char,9)};
        parameters[0].Value = buy_id;

        return DbHelperSQL.Exists(strSql.ToString(), parameters);
    }

    /// <summary>
    /// buy表中是否存在提供帮助的记录
    /// </summary>
    public bool Exists_tgbz1()
    {
        StringBuilder strSql = new StringBuilder();
        strSql.Append("select count(1) from [tbl_buy]");
        strSql.Append(" where buy_id=@buy_id ");

        SqlParameter[] parameters = {
					new SqlParameter("@buy_id", SqlDbType.Char,9)};
        parameters[0].Value = buy_id;

        return DbHelperSQL.Exists(strSql.ToString(), parameters);
    }


    /// <summary>
    /// 是否存在该记录
    /// </summary>
    public bool Exists_tgbz_dd_no()
    {
        StringBuilder strSql = new StringBuilder();
        strSql.Append("select count(1) from [tbl_buy]");
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
        strSql.Append("insert into [tbl_buy] (");
        strSql.Append("dd_no,cj_date,sq_money,sy_money,lixi,cishu,buy_id,sell_pid,pipei_qr_date,flag,flag_1,flag_2,zhifu_type,pipei_renshu,dj_money,flag_3,flag_4,qr_date,flag_qd,guding_lixi,cishu1)");
        strSql.Append(" values (");
        strSql.Append("@dd_no,@cj_date,@sq_money,@sy_money,@lixi,@cishu,@buy_id,@sell_pid,@pipei_qr_date,@flag,@flag_1,@flag_2,@zhifu_type,@pipei_renshu,@dj_money,@flag_3,@flag_4,@qr_date,@flag_qd,@guding_lixi,@cishu1)");
        strSql.Append(";select @@IDENTITY");
        SqlParameter[] parameters = {
					new SqlParameter("@dd_no", SqlDbType.VarChar,200),
					new SqlParameter("@cj_date", SqlDbType.DateTime),
					new SqlParameter("@sq_money", SqlDbType.Money,8),
					new SqlParameter("@sy_money", SqlDbType.Money,8),
					new SqlParameter("@lixi", SqlDbType.Money,8),
					new SqlParameter("@cishu", SqlDbType.Int,4),
					new SqlParameter("@buy_id", SqlDbType.Char,9),
					new SqlParameter("@sell_pid", SqlDbType.Int,4),
					new SqlParameter("@pipei_qr_date", SqlDbType.DateTime),
					new SqlParameter("@flag", SqlDbType.Int,4),
					new SqlParameter("@flag_1", SqlDbType.Int,4),
					new SqlParameter("@flag_2", SqlDbType.Int,4),
					new SqlParameter("@zhifu_type", SqlDbType.Int,4),
					new SqlParameter("@pipei_renshu", SqlDbType.Int,4),
					new SqlParameter("@dj_money", SqlDbType.Money,8),
					new SqlParameter("@flag_3", SqlDbType.Int,4),
					new SqlParameter("@flag_4", SqlDbType.Int,4),
					new SqlParameter("@qr_date", SqlDbType.DateTime),
                    new SqlParameter("@flag_qd", SqlDbType.Int,4)  ,
                    new SqlParameter("@guding_lixi", SqlDbType.Money,8),
                    new SqlParameter("@cishu1", SqlDbType.Int,4) 
                                        };
        parameters[0].Value = dd_no;
        parameters[1].Value = cj_date;
        parameters[2].Value = sq_money;
        parameters[3].Value = sy_money;
        parameters[4].Value = lixi;
        parameters[5].Value = cishu;
        parameters[6].Value = buy_id;
        parameters[7].Value = sell_pid;
        parameters[8].Value = pipei_qr_date;
        parameters[9].Value = flag;
        parameters[10].Value = flag_1;
        parameters[11].Value = flag_2;
        parameters[12].Value = zhifu_type;
        parameters[13].Value = pipei_renshu;
        parameters[14].Value = dj_money;
        parameters[15].Value = flag_3;
        parameters[16].Value = flag_4;
        parameters[17].Value = qr_date;
        parameters[18].Value = flag_qd;
        parameters[19].Value = guding_lixi;
        parameters[20].Value = cishu1;
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
        strSql.Append("update [tbl_buy] set ");
        strSql.Append("dd_no=@dd_no,");
        strSql.Append("cj_date=@cj_date,");
        strSql.Append("sq_money=@sq_money,");
        strSql.Append("sy_money=@sy_money,");
        strSql.Append("lixi=@lixi,");
        strSql.Append("cishu=@cishu,");
        strSql.Append("buy_id=@buy_id,");
        strSql.Append("sell_pid=@sell_pid,");
        strSql.Append("pipei_qr_date=@pipei_qr_date,");
        strSql.Append("flag=@flag,");
        strSql.Append("flag_1=@flag_1,");
        strSql.Append("flag_2=@flag_2,");
        strSql.Append("zhifu_type=@zhifu_type,");
        strSql.Append("pipei_renshu=@pipei_renshu,");
        strSql.Append("dj_money=@dj_money,");
        strSql.Append("flag_3=@flag_3,");
        strSql.Append("flag_4=@flag_4,");
        strSql.Append("qr_date=@qr_date");
        strSql.Append(" where id=@id ");
        SqlParameter[] parameters = {
					new SqlParameter("@dd_no", SqlDbType.VarChar,200),
					new SqlParameter("@cj_date", SqlDbType.DateTime),
					new SqlParameter("@sq_money", SqlDbType.Money,8),
					new SqlParameter("@sy_money", SqlDbType.Money,8),
					new SqlParameter("@lixi", SqlDbType.Money,8),
					new SqlParameter("@cishu", SqlDbType.Int,4),
					new SqlParameter("@buy_id", SqlDbType.Char,9),
					new SqlParameter("@sell_pid", SqlDbType.Int,4),
					new SqlParameter("@pipei_qr_date", SqlDbType.DateTime),
					new SqlParameter("@flag", SqlDbType.Int,4),
					new SqlParameter("@flag_1", SqlDbType.Int,4),
					new SqlParameter("@flag_2", SqlDbType.Int,4),
					new SqlParameter("@zhifu_type", SqlDbType.Int,4),
					new SqlParameter("@pipei_renshu", SqlDbType.Int,4),
					new SqlParameter("@dj_money", SqlDbType.Money,8),
					new SqlParameter("@flag_3", SqlDbType.Int,4),
					new SqlParameter("@flag_4", SqlDbType.Int,4),
					new SqlParameter("@qr_date", SqlDbType.DateTime),
					new SqlParameter("@id", SqlDbType.Int,4)};
        parameters[0].Value = dd_no;
        parameters[1].Value = cj_date;
        parameters[2].Value = sq_money;
        parameters[3].Value = sy_money;
        parameters[4].Value = lixi;
        parameters[5].Value = cishu;
        parameters[6].Value = buy_id;
        parameters[7].Value = sell_pid;
        parameters[8].Value = pipei_qr_date;
        parameters[9].Value = flag;
        parameters[10].Value = flag_1;
        parameters[11].Value = flag_2;
        parameters[12].Value = zhifu_type;
        parameters[13].Value = pipei_renshu;
        parameters[14].Value = dj_money;
        parameters[15].Value = flag_3;
        parameters[16].Value = flag_4;
        parameters[17].Value = qr_date;
        parameters[18].Value = id;

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
        strSql.Append("delete from [tbl_buy] ");
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
        strSql.Append("select id,dd_no,cj_date,sq_money,sy_money,lixi,cishu,buy_id,sell_pid,pipei_qr_date,flag,flag_1,flag_2,zhifu_type,pipei_renshu,dj_money,flag_3,flag_4,qr_date ,tx_flag,tx_date,flag_qd");
        strSql.Append(" FROM [tbl_buy] ");
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
            if (ds.Tables[0].Rows[0]["lixi"] != null && ds.Tables[0].Rows[0]["lixi"].ToString() != "")
            {
                this.lixi = decimal.Parse(ds.Tables[0].Rows[0]["lixi"].ToString());
            }
            if (ds.Tables[0].Rows[0]["cishu"] != null && ds.Tables[0].Rows[0]["cishu"].ToString() != "")
            {
                this.cishu = int.Parse(ds.Tables[0].Rows[0]["cishu"].ToString());
            }
            if (ds.Tables[0].Rows[0]["buy_id"] != null)
            {
                this.buy_id = ds.Tables[0].Rows[0]["buy_id"].ToString();
            }
            if (ds.Tables[0].Rows[0]["sell_pid"] != null && ds.Tables[0].Rows[0]["sell_pid"].ToString() != "")
            {
                this.sell_pid = int.Parse(ds.Tables[0].Rows[0]["sell_pid"].ToString());
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
            if (ds.Tables[0].Rows[0]["dj_money"] != null && ds.Tables[0].Rows[0]["dj_money"].ToString() != "")
            {
                this.dj_money = decimal.Parse(ds.Tables[0].Rows[0]["dj_money"].ToString());
            }
            if (ds.Tables[0].Rows[0]["flag_3"] != null && ds.Tables[0].Rows[0]["flag_3"].ToString() != "")
            {
                this.flag_3 = int.Parse(ds.Tables[0].Rows[0]["flag_3"].ToString());
            }
            if (ds.Tables[0].Rows[0]["flag_4"] != null && ds.Tables[0].Rows[0]["flag_4"].ToString() != "")
            {
                this.flag_4 = int.Parse(ds.Tables[0].Rows[0]["flag_4"].ToString());
            }
            if (ds.Tables[0].Rows[0]["qr_date"] != null && ds.Tables[0].Rows[0]["qr_date"].ToString() != "")
            {
                this.qr_date = DateTime.Parse(ds.Tables[0].Rows[0]["qr_date"].ToString());
            }

            if (ds.Tables[0].Rows[0]["tx_flag"] != null && ds.Tables[0].Rows[0]["tx_flag"].ToString() != "")
            {
                this.tx_flag = int.Parse(ds.Tables[0].Rows[0]["tx_flag"].ToString());
            }
            if (ds.Tables[0].Rows[0]["tx_date"] != null && ds.Tables[0].Rows[0]["tx_date"].ToString() != "")
            {
                this.tx_date = DateTime.Parse(ds.Tables[0].Rows[0]["tx_date"].ToString());
            }
            if (ds.Tables[0].Rows[0]["flag_qd"] != null && ds.Tables[0].Rows[0]["flag_qd"].ToString() != "")
            {
                this.flag_qd = int.Parse(ds.Tables[0].Rows[0]["flag_qd"].ToString());
            }

        }
    }
    /// <summary>
    /// 得到一个对象实体
    /// </summary>
    public void GetModel_dd_no(string  dd_no)
    {
        StringBuilder strSql = new StringBuilder();
        strSql.Append("select id,dd_no,cj_date,sq_money,sy_money,lixi,cishu,buy_id,sell_pid,pipei_qr_date,flag,flag_1,flag_2,zhifu_type,pipei_renshu,dj_money,flag_3,flag_4,qr_date ,tx_flag,tx_date,flag_qd");
        strSql.Append(" FROM [tbl_buy] ");
        strSql.Append(" where dd_no=@dd_no ");
        SqlParameter[] parameters = {
					new SqlParameter("@dd_no", SqlDbType.VarChar,200)};
        parameters[0].Value = dd_no;

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
            if (ds.Tables[0].Rows[0]["lixi"] != null && ds.Tables[0].Rows[0]["lixi"].ToString() != "")
            {
                this.lixi = decimal.Parse(ds.Tables[0].Rows[0]["lixi"].ToString());
            }
            if (ds.Tables[0].Rows[0]["cishu"] != null && ds.Tables[0].Rows[0]["cishu"].ToString() != "")
            {
                this.cishu = int.Parse(ds.Tables[0].Rows[0]["cishu"].ToString());
            }
            if (ds.Tables[0].Rows[0]["buy_id"] != null)
            {
                this.buy_id = ds.Tables[0].Rows[0]["buy_id"].ToString();
            }
            if (ds.Tables[0].Rows[0]["sell_pid"] != null && ds.Tables[0].Rows[0]["sell_pid"].ToString() != "")
            {
                this.sell_pid = int.Parse(ds.Tables[0].Rows[0]["sell_pid"].ToString());
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
            if (ds.Tables[0].Rows[0]["dj_money"] != null && ds.Tables[0].Rows[0]["dj_money"].ToString() != "")
            {
                this.dj_money = decimal.Parse(ds.Tables[0].Rows[0]["dj_money"].ToString());
            }
            if (ds.Tables[0].Rows[0]["flag_3"] != null && ds.Tables[0].Rows[0]["flag_3"].ToString() != "")
            {
                this.flag_3 = int.Parse(ds.Tables[0].Rows[0]["flag_3"].ToString());
            }
            if (ds.Tables[0].Rows[0]["flag_4"] != null && ds.Tables[0].Rows[0]["flag_4"].ToString() != "")
            {
                this.flag_4 = int.Parse(ds.Tables[0].Rows[0]["flag_4"].ToString());
            }
            if (ds.Tables[0].Rows[0]["qr_date"] != null && ds.Tables[0].Rows[0]["qr_date"].ToString() != "")
            {
                this.qr_date = DateTime.Parse(ds.Tables[0].Rows[0]["qr_date"].ToString());
            }

            if (ds.Tables[0].Rows[0]["tx_flag"] != null && ds.Tables[0].Rows[0]["tx_flag"].ToString() != "")
            {
                this.tx_flag = int.Parse(ds.Tables[0].Rows[0]["tx_flag"].ToString());
            }
            if (ds.Tables[0].Rows[0]["tx_date"] != null && ds.Tables[0].Rows[0]["tx_date"].ToString() != "")
            {
                this.tx_date = DateTime.Parse(ds.Tables[0].Rows[0]["tx_date"].ToString());
            }
            if (ds.Tables[0].Rows[0]["flag_qd"] != null && ds.Tables[0].Rows[0]["flag_qd"].ToString() != "")
            {
                this.flag_qd = int.Parse(ds.Tables[0].Rows[0]["flag_qd"].ToString());
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
        strSql.Append(" FROM [tbl_buy] ");
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
        strSql.Append("select * FROM  view_buy");
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
        strSql.Append("select top 1 " + Title + " as sumcode from [tbl_buy]");
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


