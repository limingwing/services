using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;

[Serializable]
public partial class tbl_xiaofei_rec
{
    public tbl_xiaofei_rec()
    { }
    #region Model
    private int _xiaofei_id;
    private string _xiaofei_hui_id;
    private int? _xiaofei_ci = 0;
    private string _xiaofei_type;
    private string _xiaofei_ju = "0";
    private string _jiezhang_type;
    private DateTime? _xiaofei_date = DateTime.Now;
    private decimal? _xiaofei_money = 0M;
    private int? _xiaofei_2_flag = 0;
    private int? _nian_flag = 0;
    private int? _jiesuan_10 = 0;
    private int? _flag_3 = 0;
    private int? _flag_4 = 0;
    private int? _flag_6 = 0;
    private int? _flag_7 = 0;
    private int? _flag_cha = 0;
    private int? _flag_10 = 0;
    private int? _flag_9 = 0;
    private int? _flag_shui = 0;
    private int? _flag_cha1 = 0;
    private int? _flag_13 = 0;
    private int? _flag_cha_1 = 0;
    private int? _flag_11 = 0;
    private int? _flag_12 = 0;
    private int? _cs = 0;
    private int? _flag_15 = 0;
    private int? _flag_16 = 0;
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
    public int? xiaofei_ci
    {
        set { _xiaofei_ci = value; }
        get { return _xiaofei_ci; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string xiaofei_type
    {
        set { _xiaofei_type = value; }
        get { return _xiaofei_type; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string xiaofei_ju
    {
        set { _xiaofei_ju = value; }
        get { return _xiaofei_ju; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string jiezhang_type
    {
        set { _jiezhang_type = value; }
        get { return _jiezhang_type; }
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
    public decimal? xiaofei_money
    {
        set { _xiaofei_money = value; }
        get { return _xiaofei_money; }
    }
    /// <summary>
    /// 
    /// </summary>
    public int? xiaofei_2_flag
    {
        set { _xiaofei_2_flag = value; }
        get { return _xiaofei_2_flag; }
    }
    /// <summary>
    /// 
    /// </summary>
    public int? nian_flag
    {
        set { _nian_flag = value; }
        get { return _nian_flag; }
    }
    /// <summary>
    /// 
    /// </summary>
    public int? jiesuan_10
    {
        set { _jiesuan_10 = value; }
        get { return _jiesuan_10; }
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
    public int? flag_6
    {
        set { _flag_6 = value; }
        get { return _flag_6; }
    }
    /// <summary>
    /// 
    /// </summary>
    public int? flag_7
    {
        set { _flag_7 = value; }
        get { return _flag_7; }
    }
    /// <summary>
    /// 
    /// </summary>
    public int? flag_cha
    {
        set { _flag_cha = value; }
        get { return _flag_cha; }
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
    public int? flag_9
    {
        set { _flag_9 = value; }
        get { return _flag_9; }
    }
    /// <summary>
    /// 
    /// </summary>
    public int? flag_shui
    {
        set { _flag_shui = value; }
        get { return _flag_shui; }
    }
    /// <summary>
    /// 
    /// </summary>
    public int? flag_cha1
    {
        set { _flag_cha1 = value; }
        get { return _flag_cha1; }
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
    public int? flag_cha_1
    {
        set { _flag_cha_1 = value; }
        get { return _flag_cha_1; }
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
    public int? flag_12
    {
        set { _flag_12 = value; }
        get { return _flag_12; }
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
    public int? flag_15
    {
        set { _flag_15 = value; }
        get { return _flag_15; }
    }
    /// <summary>
    /// 
    /// </summary>
    public int? flag_16
    {
        set { _flag_16 = value; }
        get { return _flag_16; }
    }
    #endregion Model


    #region  Method

    /// <summary>
    /// 得到一个对象实体
    /// </summary>
    public tbl_xiaofei_rec(int xiaofei_id)
    {
        StringBuilder strSql = new StringBuilder();
        strSql.Append("select xiaofei_id,xiaofei_hui_id,xiaofei_ci,xiaofei_type,xiaofei_ju,jiezhang_type,xiaofei_date,xiaofei_money,xiaofei_2_flag,nian_flag,jiesuan_10,flag_3,flag_4,flag_6,flag_7,flag_cha,flag_10,flag_9,flag_shui,flag_cha1,flag_13,flag_cha_1,flag_11,flag_12,cs,flag_15,flag_16 ");
        strSql.Append(" FROM [tbl_xiaofei_rec] ");
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
            if (ds.Tables[0].Rows[0]["xiaofei_ci"] != null && ds.Tables[0].Rows[0]["xiaofei_ci"].ToString() != "")
            {
                this.xiaofei_ci = int.Parse(ds.Tables[0].Rows[0]["xiaofei_ci"].ToString());
            }
            if (ds.Tables[0].Rows[0]["xiaofei_type"] != null)
            {
                this.xiaofei_type = ds.Tables[0].Rows[0]["xiaofei_type"].ToString();
            }
            if (ds.Tables[0].Rows[0]["xiaofei_ju"] != null)
            {
                this.xiaofei_ju = ds.Tables[0].Rows[0]["xiaofei_ju"].ToString();
            }
            if (ds.Tables[0].Rows[0]["jiezhang_type"] != null)
            {
                this.jiezhang_type = ds.Tables[0].Rows[0]["jiezhang_type"].ToString();
            }
            if (ds.Tables[0].Rows[0]["xiaofei_date"] != null && ds.Tables[0].Rows[0]["xiaofei_date"].ToString() != "")
            {
                this.xiaofei_date = DateTime.Parse(ds.Tables[0].Rows[0]["xiaofei_date"].ToString());
            }
            if (ds.Tables[0].Rows[0]["xiaofei_money"] != null && ds.Tables[0].Rows[0]["xiaofei_money"].ToString() != "")
            {
                this.xiaofei_money = decimal.Parse(ds.Tables[0].Rows[0]["xiaofei_money"].ToString());
            }
            if (ds.Tables[0].Rows[0]["xiaofei_2_flag"] != null && ds.Tables[0].Rows[0]["xiaofei_2_flag"].ToString() != "")
            {
                this.xiaofei_2_flag = int.Parse(ds.Tables[0].Rows[0]["xiaofei_2_flag"].ToString());
            }
            if (ds.Tables[0].Rows[0]["nian_flag"] != null && ds.Tables[0].Rows[0]["nian_flag"].ToString() != "")
            {
                this.nian_flag = int.Parse(ds.Tables[0].Rows[0]["nian_flag"].ToString());
            }
            if (ds.Tables[0].Rows[0]["jiesuan_10"] != null && ds.Tables[0].Rows[0]["jiesuan_10"].ToString() != "")
            {
                this.jiesuan_10 = int.Parse(ds.Tables[0].Rows[0]["jiesuan_10"].ToString());
            }
            if (ds.Tables[0].Rows[0]["flag_3"] != null && ds.Tables[0].Rows[0]["flag_3"].ToString() != "")
            {
                this.flag_3 = int.Parse(ds.Tables[0].Rows[0]["flag_3"].ToString());
            }
            if (ds.Tables[0].Rows[0]["flag_4"] != null && ds.Tables[0].Rows[0]["flag_4"].ToString() != "")
            {
                this.flag_4 = int.Parse(ds.Tables[0].Rows[0]["flag_4"].ToString());
            }
            if (ds.Tables[0].Rows[0]["flag_6"] != null && ds.Tables[0].Rows[0]["flag_6"].ToString() != "")
            {
                this.flag_6 = int.Parse(ds.Tables[0].Rows[0]["flag_6"].ToString());
            }
            if (ds.Tables[0].Rows[0]["flag_7"] != null && ds.Tables[0].Rows[0]["flag_7"].ToString() != "")
            {
                this.flag_7 = int.Parse(ds.Tables[0].Rows[0]["flag_7"].ToString());
            }
            if (ds.Tables[0].Rows[0]["flag_cha"] != null && ds.Tables[0].Rows[0]["flag_cha"].ToString() != "")
            {
                this.flag_cha = int.Parse(ds.Tables[0].Rows[0]["flag_cha"].ToString());
            }
            if (ds.Tables[0].Rows[0]["flag_10"] != null && ds.Tables[0].Rows[0]["flag_10"].ToString() != "")
            {
                this.flag_10 = int.Parse(ds.Tables[0].Rows[0]["flag_10"].ToString());
            }
            if (ds.Tables[0].Rows[0]["flag_9"] != null && ds.Tables[0].Rows[0]["flag_9"].ToString() != "")
            {
                this.flag_9 = int.Parse(ds.Tables[0].Rows[0]["flag_9"].ToString());
            }
            if (ds.Tables[0].Rows[0]["flag_shui"] != null && ds.Tables[0].Rows[0]["flag_shui"].ToString() != "")
            {
                this.flag_shui = int.Parse(ds.Tables[0].Rows[0]["flag_shui"].ToString());
            }
            if (ds.Tables[0].Rows[0]["flag_cha1"] != null && ds.Tables[0].Rows[0]["flag_cha1"].ToString() != "")
            {
                this.flag_cha1 = int.Parse(ds.Tables[0].Rows[0]["flag_cha1"].ToString());
            }
            if (ds.Tables[0].Rows[0]["flag_13"] != null && ds.Tables[0].Rows[0]["flag_13"].ToString() != "")
            {
                this.flag_13 = int.Parse(ds.Tables[0].Rows[0]["flag_13"].ToString());
            }
            if (ds.Tables[0].Rows[0]["flag_cha_1"] != null && ds.Tables[0].Rows[0]["flag_cha_1"].ToString() != "")
            {
                this.flag_cha_1 = int.Parse(ds.Tables[0].Rows[0]["flag_cha_1"].ToString());
            }
            if (ds.Tables[0].Rows[0]["flag_11"] != null && ds.Tables[0].Rows[0]["flag_11"].ToString() != "")
            {
                this.flag_11 = int.Parse(ds.Tables[0].Rows[0]["flag_11"].ToString());
            }
            if (ds.Tables[0].Rows[0]["flag_12"] != null && ds.Tables[0].Rows[0]["flag_12"].ToString() != "")
            {
                this.flag_12 = int.Parse(ds.Tables[0].Rows[0]["flag_12"].ToString());
            }
            if (ds.Tables[0].Rows[0]["cs"] != null && ds.Tables[0].Rows[0]["cs"].ToString() != "")
            {
                this.cs = int.Parse(ds.Tables[0].Rows[0]["cs"].ToString());
            }
            if (ds.Tables[0].Rows[0]["flag_15"] != null && ds.Tables[0].Rows[0]["flag_15"].ToString() != "")
            {
                this.flag_15 = int.Parse(ds.Tables[0].Rows[0]["flag_15"].ToString());
            }
            if (ds.Tables[0].Rows[0]["flag_16"] != null && ds.Tables[0].Rows[0]["flag_16"].ToString() != "")
            {
                this.flag_16 = int.Parse(ds.Tables[0].Rows[0]["flag_16"].ToString());
            }
        }
    }
    /// <summary>
    /// 是否存在该记录
    /// </summary>
    public bool Exists(int xiaofei_id)
    {
        StringBuilder strSql = new StringBuilder();
        strSql.Append("select count(1) from [tbl_xiaofei_rec]");
        strSql.Append(" where xiaofei_id=@xiaofei_id ");

        SqlParameter[] parameters = {
					new SqlParameter("@xiaofei_id", SqlDbType.Int,4)};
        parameters[0].Value = xiaofei_id;

        return DbHelperSQL.Exists(strSql.ToString(), parameters);
    }


    /// <summary>
    /// 增加一条数据
    /// </summary>
    public int Add()
    {
        StringBuilder strSql = new StringBuilder();
        strSql.Append("insert into [tbl_xiaofei_rec] (");
        strSql.Append("xiaofei_hui_id,xiaofei_ci,xiaofei_type,xiaofei_ju,jiezhang_type,xiaofei_date,xiaofei_money,xiaofei_2_flag,nian_flag,jiesuan_10,flag_3,flag_4,flag_6,flag_7,flag_cha,flag_10,flag_9,flag_shui,flag_cha1,flag_13,flag_cha_1,flag_11,flag_12,cs,flag_15,flag_16)");
        strSql.Append(" values (");
        strSql.Append("@xiaofei_hui_id,@xiaofei_ci,@xiaofei_type,@xiaofei_ju,@jiezhang_type,@xiaofei_date,@xiaofei_money,@xiaofei_2_flag,@nian_flag,@jiesuan_10,@flag_3,@flag_4,@flag_6,@flag_7,@flag_cha,@flag_10,@flag_9,@flag_shui,@flag_cha1,@flag_13,@flag_cha_1,@flag_11,@flag_12,@cs,@flag_15,@flag_16)");
        strSql.Append(";select @@IDENTITY");
        SqlParameter[] parameters = {
					new SqlParameter("@xiaofei_hui_id", SqlDbType.VarChar,9),
					new SqlParameter("@xiaofei_ci", SqlDbType.Int,4),
					new SqlParameter("@xiaofei_type", SqlDbType.VarChar,50),
					new SqlParameter("@xiaofei_ju", SqlDbType.Char,10),
					new SqlParameter("@jiezhang_type", SqlDbType.VarChar,50),
					new SqlParameter("@xiaofei_date", SqlDbType.DateTime),
					new SqlParameter("@xiaofei_money", SqlDbType.Money,8),
					new SqlParameter("@xiaofei_2_flag", SqlDbType.Int,4),
					new SqlParameter("@nian_flag", SqlDbType.Int,4),
					new SqlParameter("@jiesuan_10", SqlDbType.Int,4),
					new SqlParameter("@flag_3", SqlDbType.Int,4),
					new SqlParameter("@flag_4", SqlDbType.Int,4),
					new SqlParameter("@flag_6", SqlDbType.Int,4),
					new SqlParameter("@flag_7", SqlDbType.Int,4),
					new SqlParameter("@flag_cha", SqlDbType.Int,4),
					new SqlParameter("@flag_10", SqlDbType.Int,4),
					new SqlParameter("@flag_9", SqlDbType.Int,4),
					new SqlParameter("@flag_shui", SqlDbType.Int,4),
					new SqlParameter("@flag_cha1", SqlDbType.Int,4),
					new SqlParameter("@flag_13", SqlDbType.Int,4),
					new SqlParameter("@flag_cha_1", SqlDbType.Int,4),
					new SqlParameter("@flag_11", SqlDbType.Int,4),
					new SqlParameter("@flag_12", SqlDbType.Int,4),
					new SqlParameter("@cs", SqlDbType.Int,4),
					new SqlParameter("@flag_15", SqlDbType.Int,4),
					new SqlParameter("@flag_16", SqlDbType.Int,4)};
        parameters[0].Value = xiaofei_hui_id;
        parameters[1].Value = xiaofei_ci;
        parameters[2].Value = xiaofei_type;
        parameters[3].Value = xiaofei_ju;
        parameters[4].Value = jiezhang_type;
        parameters[5].Value = xiaofei_date;
        parameters[6].Value = xiaofei_money;
        parameters[7].Value = xiaofei_2_flag;
        parameters[8].Value = nian_flag;
        parameters[9].Value = jiesuan_10;
        parameters[10].Value = flag_3;
        parameters[11].Value = flag_4;
        parameters[12].Value = flag_6;
        parameters[13].Value = flag_7;
        parameters[14].Value = flag_cha;
        parameters[15].Value = flag_10;
        parameters[16].Value = flag_9;
        parameters[17].Value = flag_shui;
        parameters[18].Value = flag_cha1;
        parameters[19].Value = flag_13;
        parameters[20].Value = flag_cha_1;
        parameters[21].Value = flag_11;
        parameters[22].Value = flag_12;
        parameters[23].Value = cs;
        parameters[24].Value = flag_15;
        parameters[25].Value = flag_16;

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
        strSql.Append("update [tbl_xiaofei_rec] set ");
        strSql.Append("xiaofei_hui_id=@xiaofei_hui_id,");
        strSql.Append("xiaofei_ci=@xiaofei_ci,");
        strSql.Append("xiaofei_type=@xiaofei_type,");
        strSql.Append("xiaofei_ju=@xiaofei_ju,");
        strSql.Append("jiezhang_type=@jiezhang_type,");
        strSql.Append("xiaofei_date=@xiaofei_date,");
        strSql.Append("xiaofei_money=@xiaofei_money,");
        strSql.Append("xiaofei_2_flag=@xiaofei_2_flag,");
        strSql.Append("nian_flag=@nian_flag,");
        strSql.Append("jiesuan_10=@jiesuan_10,");
        strSql.Append("flag_3=@flag_3,");
        strSql.Append("flag_4=@flag_4,");
        strSql.Append("flag_6=@flag_6,");
        strSql.Append("flag_7=@flag_7,");
        strSql.Append("flag_cha=@flag_cha,");
        strSql.Append("flag_10=@flag_10,");
        strSql.Append("flag_9=@flag_9,");
        strSql.Append("flag_shui=@flag_shui,");
        strSql.Append("flag_cha1=@flag_cha1,");
        strSql.Append("flag_13=@flag_13,");
        strSql.Append("flag_cha_1=@flag_cha_1,");
        strSql.Append("flag_11=@flag_11,");
        strSql.Append("flag_12=@flag_12,");
        strSql.Append("cs=@cs,");
        strSql.Append("flag_15=@flag_15,");
        strSql.Append("flag_16=@flag_16");
        strSql.Append(" where xiaofei_id=@xiaofei_id ");
        SqlParameter[] parameters = {
					new SqlParameter("@xiaofei_hui_id", SqlDbType.VarChar,9),
					new SqlParameter("@xiaofei_ci", SqlDbType.Int,4),
					new SqlParameter("@xiaofei_type", SqlDbType.VarChar,50),
					new SqlParameter("@xiaofei_ju", SqlDbType.Char,10),
					new SqlParameter("@jiezhang_type", SqlDbType.VarChar,50),
					new SqlParameter("@xiaofei_date", SqlDbType.DateTime),
					new SqlParameter("@xiaofei_money", SqlDbType.Money,8),
					new SqlParameter("@xiaofei_2_flag", SqlDbType.Int,4),
					new SqlParameter("@nian_flag", SqlDbType.Int,4),
					new SqlParameter("@jiesuan_10", SqlDbType.Int,4),
					new SqlParameter("@flag_3", SqlDbType.Int,4),
					new SqlParameter("@flag_4", SqlDbType.Int,4),
					new SqlParameter("@flag_6", SqlDbType.Int,4),
					new SqlParameter("@flag_7", SqlDbType.Int,4),
					new SqlParameter("@flag_cha", SqlDbType.Int,4),
					new SqlParameter("@flag_10", SqlDbType.Int,4),
					new SqlParameter("@flag_9", SqlDbType.Int,4),
					new SqlParameter("@flag_shui", SqlDbType.Int,4),
					new SqlParameter("@flag_cha1", SqlDbType.Int,4),
					new SqlParameter("@flag_13", SqlDbType.Int,4),
					new SqlParameter("@flag_cha_1", SqlDbType.Int,4),
					new SqlParameter("@flag_11", SqlDbType.Int,4),
					new SqlParameter("@flag_12", SqlDbType.Int,4),
					new SqlParameter("@cs", SqlDbType.Int,4),
					new SqlParameter("@flag_15", SqlDbType.Int,4),
					new SqlParameter("@flag_16", SqlDbType.Int,4),
					new SqlParameter("@xiaofei_id", SqlDbType.Int,4)};
        parameters[0].Value = xiaofei_hui_id;
        parameters[1].Value = xiaofei_ci;
        parameters[2].Value = xiaofei_type;
        parameters[3].Value = xiaofei_ju;
        parameters[4].Value = jiezhang_type;
        parameters[5].Value = xiaofei_date;
        parameters[6].Value = xiaofei_money;
        parameters[7].Value = xiaofei_2_flag;
        parameters[8].Value = nian_flag;
        parameters[9].Value = jiesuan_10;
        parameters[10].Value = flag_3;
        parameters[11].Value = flag_4;
        parameters[12].Value = flag_6;
        parameters[13].Value = flag_7;
        parameters[14].Value = flag_cha;
        parameters[15].Value = flag_10;
        parameters[16].Value = flag_9;
        parameters[17].Value = flag_shui;
        parameters[18].Value = flag_cha1;
        parameters[19].Value = flag_13;
        parameters[20].Value = flag_cha_1;
        parameters[21].Value = flag_11;
        parameters[22].Value = flag_12;
        parameters[23].Value = cs;
        parameters[24].Value = flag_15;
        parameters[25].Value = flag_16;
        parameters[26].Value = xiaofei_id;

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
        strSql.Append("delete from [tbl_xiaofei_rec] ");
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
    /// 得到一个对象实体
    /// </summary>
    public void GetModel(int xiaofei_id)
    {
        StringBuilder strSql = new StringBuilder();
        strSql.Append("select xiaofei_id,xiaofei_hui_id,xiaofei_ci,xiaofei_type,xiaofei_ju,jiezhang_type,xiaofei_date,xiaofei_money,xiaofei_2_flag,nian_flag,jiesuan_10,flag_3,flag_4,flag_6,flag_7,flag_cha,flag_10,flag_9,flag_shui,flag_cha1,flag_13,flag_cha_1,flag_11,flag_12,cs,flag_15,flag_16 ");
        strSql.Append(" FROM [tbl_xiaofei_rec] ");
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
            if (ds.Tables[0].Rows[0]["xiaofei_ci"] != null && ds.Tables[0].Rows[0]["xiaofei_ci"].ToString() != "")
            {
                this.xiaofei_ci = int.Parse(ds.Tables[0].Rows[0]["xiaofei_ci"].ToString());
            }
            if (ds.Tables[0].Rows[0]["xiaofei_type"] != null)
            {
                this.xiaofei_type = ds.Tables[0].Rows[0]["xiaofei_type"].ToString();
            }
            if (ds.Tables[0].Rows[0]["xiaofei_ju"] != null)
            {
                this.xiaofei_ju = ds.Tables[0].Rows[0]["xiaofei_ju"].ToString();
            }
            if (ds.Tables[0].Rows[0]["jiezhang_type"] != null)
            {
                this.jiezhang_type = ds.Tables[0].Rows[0]["jiezhang_type"].ToString();
            }
            if (ds.Tables[0].Rows[0]["xiaofei_date"] != null && ds.Tables[0].Rows[0]["xiaofei_date"].ToString() != "")
            {
                this.xiaofei_date = DateTime.Parse(ds.Tables[0].Rows[0]["xiaofei_date"].ToString());
            }
            if (ds.Tables[0].Rows[0]["xiaofei_money"] != null && ds.Tables[0].Rows[0]["xiaofei_money"].ToString() != "")
            {
                this.xiaofei_money = decimal.Parse(ds.Tables[0].Rows[0]["xiaofei_money"].ToString());
            }
            if (ds.Tables[0].Rows[0]["xiaofei_2_flag"] != null && ds.Tables[0].Rows[0]["xiaofei_2_flag"].ToString() != "")
            {
                this.xiaofei_2_flag = int.Parse(ds.Tables[0].Rows[0]["xiaofei_2_flag"].ToString());
            }
            if (ds.Tables[0].Rows[0]["nian_flag"] != null && ds.Tables[0].Rows[0]["nian_flag"].ToString() != "")
            {
                this.nian_flag = int.Parse(ds.Tables[0].Rows[0]["nian_flag"].ToString());
            }
            if (ds.Tables[0].Rows[0]["jiesuan_10"] != null && ds.Tables[0].Rows[0]["jiesuan_10"].ToString() != "")
            {
                this.jiesuan_10 = int.Parse(ds.Tables[0].Rows[0]["jiesuan_10"].ToString());
            }
            if (ds.Tables[0].Rows[0]["flag_3"] != null && ds.Tables[0].Rows[0]["flag_3"].ToString() != "")
            {
                this.flag_3 = int.Parse(ds.Tables[0].Rows[0]["flag_3"].ToString());
            }
            if (ds.Tables[0].Rows[0]["flag_4"] != null && ds.Tables[0].Rows[0]["flag_4"].ToString() != "")
            {
                this.flag_4 = int.Parse(ds.Tables[0].Rows[0]["flag_4"].ToString());
            }
            if (ds.Tables[0].Rows[0]["flag_6"] != null && ds.Tables[0].Rows[0]["flag_6"].ToString() != "")
            {
                this.flag_6 = int.Parse(ds.Tables[0].Rows[0]["flag_6"].ToString());
            }
            if (ds.Tables[0].Rows[0]["flag_7"] != null && ds.Tables[0].Rows[0]["flag_7"].ToString() != "")
            {
                this.flag_7 = int.Parse(ds.Tables[0].Rows[0]["flag_7"].ToString());
            }
            if (ds.Tables[0].Rows[0]["flag_cha"] != null && ds.Tables[0].Rows[0]["flag_cha"].ToString() != "")
            {
                this.flag_cha = int.Parse(ds.Tables[0].Rows[0]["flag_cha"].ToString());
            }
            if (ds.Tables[0].Rows[0]["flag_10"] != null && ds.Tables[0].Rows[0]["flag_10"].ToString() != "")
            {
                this.flag_10 = int.Parse(ds.Tables[0].Rows[0]["flag_10"].ToString());
            }
            if (ds.Tables[0].Rows[0]["flag_9"] != null && ds.Tables[0].Rows[0]["flag_9"].ToString() != "")
            {
                this.flag_9 = int.Parse(ds.Tables[0].Rows[0]["flag_9"].ToString());
            }
            if (ds.Tables[0].Rows[0]["flag_shui"] != null && ds.Tables[0].Rows[0]["flag_shui"].ToString() != "")
            {
                this.flag_shui = int.Parse(ds.Tables[0].Rows[0]["flag_shui"].ToString());
            }
            if (ds.Tables[0].Rows[0]["flag_cha1"] != null && ds.Tables[0].Rows[0]["flag_cha1"].ToString() != "")
            {
                this.flag_cha1 = int.Parse(ds.Tables[0].Rows[0]["flag_cha1"].ToString());
            }
            if (ds.Tables[0].Rows[0]["flag_13"] != null && ds.Tables[0].Rows[0]["flag_13"].ToString() != "")
            {
                this.flag_13 = int.Parse(ds.Tables[0].Rows[0]["flag_13"].ToString());
            }
            if (ds.Tables[0].Rows[0]["flag_cha_1"] != null && ds.Tables[0].Rows[0]["flag_cha_1"].ToString() != "")
            {
                this.flag_cha_1 = int.Parse(ds.Tables[0].Rows[0]["flag_cha_1"].ToString());
            }
            if (ds.Tables[0].Rows[0]["flag_11"] != null && ds.Tables[0].Rows[0]["flag_11"].ToString() != "")
            {
                this.flag_11 = int.Parse(ds.Tables[0].Rows[0]["flag_11"].ToString());
            }
            if (ds.Tables[0].Rows[0]["flag_12"] != null && ds.Tables[0].Rows[0]["flag_12"].ToString() != "")
            {
                this.flag_12 = int.Parse(ds.Tables[0].Rows[0]["flag_12"].ToString());
            }
            if (ds.Tables[0].Rows[0]["cs"] != null && ds.Tables[0].Rows[0]["cs"].ToString() != "")
            {
                this.cs = int.Parse(ds.Tables[0].Rows[0]["cs"].ToString());
            }
            if (ds.Tables[0].Rows[0]["flag_15"] != null && ds.Tables[0].Rows[0]["flag_15"].ToString() != "")
            {
                this.flag_15 = int.Parse(ds.Tables[0].Rows[0]["flag_15"].ToString());
            }
            if (ds.Tables[0].Rows[0]["flag_16"] != null && ds.Tables[0].Rows[0]["flag_16"].ToString() != "")
            {
                this.flag_16 = int.Parse(ds.Tables[0].Rows[0]["flag_16"].ToString());
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
        strSql.Append(" FROM [tbl_xiaofei_rec] ");
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
        strSql.Append("select * FROM  tbl_xiaofei_rec");
        if (strWhere.Trim() != "")
        {
            strSql.Append(" where " + strWhere);
        }
        recordCount = Convert.ToInt32(DbHelperSQL.GetSingle(PagingHelper.CreateCountingSql(strSql.ToString())));
        return DbHelperSQL.Query(PagingHelper.CreatePagingSql(recordCount, pageSize, pageIndex, strSql.ToString(), filedOrder));
    }
    #endregion  Method
}