using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;

/// <summary>
///tbl_huikuan 的摘要说明
/// </summary>
[Serializable]
public partial class tbl_huikuan
{
    public tbl_huikuan()
    { }
    #region Model
    private int _huikuan_id;
    private string _accountname;
    private string _accountno;
    private DateTime? _hk_time;
    private string _money;
    private string _memo;
    private string _huiyuan_id;
    private int? _huikuan_status = 0;
    private DateTime? _hk_qr_time;
    private string _accountbank;
    private string _queren_man;
    private string _accounttype;
    private string _huiyuan_bianhao;
    private string _huiyuan_name;
    private DateTime? _hk_sq_time;
    private int? _bank_id;
    /// <summary>
    /// 
    /// </summary>
    public int huikuan_id
    {
        set { _huikuan_id = value; }
        get { return _huikuan_id; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string accountname
    {
        set { _accountname = value; }
        get { return _accountname; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string accountno
    {
        set { _accountno = value; }
        get { return _accountno; }
    }
    /// <summary>
    /// 
    /// </summary>
    public DateTime? hk_time
    {
        set { _hk_time = value; }
        get { return _hk_time; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string money
    {
        set { _money = value; }
        get { return _money; }
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
    public string huiyuan_id
    {
        set { _huiyuan_id = value; }
        get { return _huiyuan_id; }
    }
    /// <summary>
    /// 
    /// </summary>
    public int? huikuan_status
    {
        set { _huikuan_status = value; }
        get { return _huikuan_status; }
    }
    /// <summary>
    /// 
    /// </summary>
    public DateTime? hk_qr_time
    {
        set { _hk_qr_time = value; }
        get { return _hk_qr_time; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string accountbank
    {
        set { _accountbank = value; }
        get { return _accountbank; }
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
    public string accounttype
    {
        set { _accounttype = value; }
        get { return _accounttype; }
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
    public DateTime? hk_sq_time
    {
        set { _hk_sq_time = value; }
        get { return _hk_sq_time; }
    }
    /// <summary>
    /// 
    /// </summary>
    public int? bank_id
    {
        set { _bank_id = value; }
        get { return _bank_id; }
    }
    #endregion Model


    #region  Method

    /// <summary>
    /// 得到一个对象实体
    /// </summary>
    public tbl_huikuan(int huikuan_id)
    {
        StringBuilder strSql = new StringBuilder();
        strSql.Append("select huikuan_id,accountname,accountno,hk_time,money,memo,huiyuan_id,huikuan_status,hk_qr_time,accountbank,queren_man,accounttype,huiyuan_bianhao,huiyuan_name,hk_sq_time,bank_id ");
        strSql.Append(" FROM [tbl_huikuan] ");
        strSql.Append(" where huikuan_id=@huikuan_id ");
        SqlParameter[] parameters = {
					new SqlParameter("@huikuan_id", SqlDbType.Int,4)};
        parameters[0].Value = huikuan_id;

        DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
        if (ds.Tables[0].Rows.Count > 0)
        {
            if (ds.Tables[0].Rows[0]["huikuan_id"] != null && ds.Tables[0].Rows[0]["huikuan_id"].ToString() != "")
            {
                this.huikuan_id = int.Parse(ds.Tables[0].Rows[0]["huikuan_id"].ToString());
            }
            if (ds.Tables[0].Rows[0]["accountname"] != null)
            {
                this.accountname = ds.Tables[0].Rows[0]["accountname"].ToString();
            }
            if (ds.Tables[0].Rows[0]["accountno"] != null)
            {
                this.accountno = ds.Tables[0].Rows[0]["accountno"].ToString();
            }
            if (ds.Tables[0].Rows[0]["hk_time"] != null && ds.Tables[0].Rows[0]["hk_time"].ToString() != "")
            {
                this.hk_time = DateTime.Parse(ds.Tables[0].Rows[0]["hk_time"].ToString());
            }
            if (ds.Tables[0].Rows[0]["money"] != null)
            {
                this.money = ds.Tables[0].Rows[0]["money"].ToString();
            }
            if (ds.Tables[0].Rows[0]["memo"] != null)
            {
                this.memo = ds.Tables[0].Rows[0]["memo"].ToString();
            }
            if (ds.Tables[0].Rows[0]["huiyuan_id"] != null)
            {
                this.huiyuan_id = ds.Tables[0].Rows[0]["huiyuan_id"].ToString();
            }
            if (ds.Tables[0].Rows[0]["huikuan_status"] != null && ds.Tables[0].Rows[0]["huikuan_status"].ToString() != "")
            {
                this.huikuan_status = int.Parse(ds.Tables[0].Rows[0]["huikuan_status"].ToString());
            }
            if (ds.Tables[0].Rows[0]["hk_qr_time"] != null && ds.Tables[0].Rows[0]["hk_qr_time"].ToString() != "")
            {
                this.hk_qr_time = DateTime.Parse(ds.Tables[0].Rows[0]["hk_qr_time"].ToString());
            }
            if (ds.Tables[0].Rows[0]["accountbank"] != null)
            {
                this.accountbank = ds.Tables[0].Rows[0]["accountbank"].ToString();
            }
            if (ds.Tables[0].Rows[0]["queren_man"] != null)
            {
                this.queren_man = ds.Tables[0].Rows[0]["queren_man"].ToString();
            }
            if (ds.Tables[0].Rows[0]["accounttype"] != null)
            {
                this.accounttype = ds.Tables[0].Rows[0]["accounttype"].ToString();
            }
            if (ds.Tables[0].Rows[0]["huiyuan_bianhao"] != null)
            {
                this.huiyuan_bianhao = ds.Tables[0].Rows[0]["huiyuan_bianhao"].ToString();
            }
            if (ds.Tables[0].Rows[0]["huiyuan_name"] != null)
            {
                this.huiyuan_name = ds.Tables[0].Rows[0]["huiyuan_name"].ToString();
            }
            if (ds.Tables[0].Rows[0]["hk_sq_time"] != null && ds.Tables[0].Rows[0]["hk_sq_time"].ToString() != "")
            {
                this.hk_sq_time = DateTime.Parse(ds.Tables[0].Rows[0]["hk_sq_time"].ToString());
            }
            if (ds.Tables[0].Rows[0]["bank_id"] != null && ds.Tables[0].Rows[0]["bank_id"].ToString() != "")
            {
                this.bank_id = int.Parse(ds.Tables[0].Rows[0]["bank_id"].ToString());
            }
        }
    }
    /// <summary>
    /// 是否存在该记录
    /// </summary>
    public bool Exists(int huikuan_id)
    {
        StringBuilder strSql = new StringBuilder();
        strSql.Append("select count(1) from [tbl_huikuan]");
        strSql.Append(" where huikuan_id=@huikuan_id ");

        SqlParameter[] parameters = {
					new SqlParameter("@huikuan_id", SqlDbType.Int,4)};
        parameters[0].Value = huikuan_id;

        return DbHelperSQL.Exists(strSql.ToString(), parameters);
    }


    /// <summary>
    /// 增加一条数据
    /// </summary>
    public int Add()
    {
        StringBuilder strSql = new StringBuilder();
        strSql.Append("insert into [tbl_huikuan] (");
        strSql.Append("accountname,accountno,hk_time,money,memo,huiyuan_id,huikuan_status,hk_qr_time,accountbank,queren_man,accounttype,huiyuan_bianhao,huiyuan_name,hk_sq_time,bank_id)");
        strSql.Append(" values (");
        strSql.Append("@accountname,@accountno,@hk_time,@money,@memo,@huiyuan_id,@huikuan_status,@hk_qr_time,@accountbank,@queren_man,@accounttype,@huiyuan_bianhao,@huiyuan_name,@hk_sq_time,@bank_id)");
        strSql.Append(";select @@IDENTITY");
        SqlParameter[] parameters = {
					new SqlParameter("@accountname", SqlDbType.NVarChar,50),
					new SqlParameter("@accountno", SqlDbType.NVarChar,50),
					new SqlParameter("@hk_time", SqlDbType.DateTime),
					new SqlParameter("@money", SqlDbType.NVarChar,50),
					new SqlParameter("@memo", SqlDbType.NVarChar,50),
					new SqlParameter("@huiyuan_id", SqlDbType.Char,9),
					new SqlParameter("@huikuan_status", SqlDbType.Int,4),
					new SqlParameter("@hk_qr_time", SqlDbType.DateTime),
					new SqlParameter("@accountbank", SqlDbType.NVarChar,50),
					new SqlParameter("@queren_man", SqlDbType.NVarChar,50),
					new SqlParameter("@accounttype", SqlDbType.NVarChar,50),
					new SqlParameter("@huiyuan_bianhao", SqlDbType.NVarChar,50),
					new SqlParameter("@huiyuan_name", SqlDbType.NVarChar,50),
					new SqlParameter("@hk_sq_time", SqlDbType.DateTime),
					new SqlParameter("@bank_id", SqlDbType.Int,4)};
        parameters[0].Value = accountname;
        parameters[1].Value = accountno;
        parameters[2].Value = hk_time;
        parameters[3].Value = money;
        parameters[4].Value = memo;
        parameters[5].Value = huiyuan_id;
        parameters[6].Value = huikuan_status;
        parameters[7].Value = hk_qr_time;
        parameters[8].Value = accountbank;
        parameters[9].Value = queren_man;
        parameters[10].Value = accounttype;
        parameters[11].Value = huiyuan_bianhao;
        parameters[12].Value = huiyuan_name;
        parameters[13].Value = hk_sq_time;
        parameters[14].Value = bank_id;

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
        strSql.Append("update [tbl_huikuan] set ");
        strSql.Append("accountname=@accountname,");
        strSql.Append("accountno=@accountno,");
        strSql.Append("hk_time=@hk_time,");
        strSql.Append("money=@money,");
        strSql.Append("memo=@memo,");
        strSql.Append("huiyuan_id=@huiyuan_id,");
        strSql.Append("huikuan_status=@huikuan_status,");
        strSql.Append("hk_qr_time=@hk_qr_time,");
        strSql.Append("accountbank=@accountbank,");
        strSql.Append("queren_man=@queren_man,");
        strSql.Append("accounttype=@accounttype,");
        strSql.Append("huiyuan_bianhao=@huiyuan_bianhao,");
        strSql.Append("huiyuan_name=@huiyuan_name,");
        strSql.Append("hk_sq_time=@hk_sq_time,");
        strSql.Append("bank_id=@bank_id");
        strSql.Append(" where huikuan_id=@huikuan_id ");
        SqlParameter[] parameters = {
					new SqlParameter("@accountname", SqlDbType.NVarChar,50),
					new SqlParameter("@accountno", SqlDbType.NVarChar,50),
					new SqlParameter("@hk_time", SqlDbType.DateTime),
					new SqlParameter("@money", SqlDbType.NVarChar,50),
					new SqlParameter("@memo", SqlDbType.NVarChar,50),
					new SqlParameter("@huiyuan_id", SqlDbType.Char,9),
					new SqlParameter("@huikuan_status", SqlDbType.Int,4),
					new SqlParameter("@hk_qr_time", SqlDbType.DateTime),
					new SqlParameter("@accountbank", SqlDbType.NVarChar,50),
					new SqlParameter("@queren_man", SqlDbType.NVarChar,50),
					new SqlParameter("@accounttype", SqlDbType.NVarChar,50),
					new SqlParameter("@huiyuan_bianhao", SqlDbType.NVarChar,50),
					new SqlParameter("@huiyuan_name", SqlDbType.NVarChar,50),
					new SqlParameter("@hk_sq_time", SqlDbType.DateTime),
					new SqlParameter("@bank_id", SqlDbType.Int,4),
					new SqlParameter("@huikuan_id", SqlDbType.Int,4)};
        parameters[0].Value = accountname;
        parameters[1].Value = accountno;
        parameters[2].Value = hk_time;
        parameters[3].Value = money;
        parameters[4].Value = memo;
        parameters[5].Value = huiyuan_id;
        parameters[6].Value = huikuan_status;
        parameters[7].Value = hk_qr_time;
        parameters[8].Value = accountbank;
        parameters[9].Value = queren_man;
        parameters[10].Value = accounttype;
        parameters[11].Value = huiyuan_bianhao;
        parameters[12].Value = huiyuan_name;
        parameters[13].Value = hk_sq_time;
        parameters[14].Value = bank_id;
        parameters[15].Value = huikuan_id;

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
    public bool Delete(int huikuan_id)
    {
        StringBuilder strSql = new StringBuilder();
        strSql.Append("delete from [tbl_huikuan] ");
        strSql.Append(" where huikuan_id=@huikuan_id ");
        SqlParameter[] parameters = {
					new SqlParameter("@huikuan_id", SqlDbType.Int,4)};
        parameters[0].Value = huikuan_id;

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
    public void GetModel(int huikuan_id)
    {
        StringBuilder strSql = new StringBuilder();
        strSql.Append("select huikuan_id,accountname,accountno,hk_time,money,memo,huiyuan_id,huikuan_status,hk_qr_time,accountbank,queren_man,accounttype,huiyuan_bianhao,huiyuan_name,hk_sq_time,bank_id ");
        strSql.Append(" FROM [tbl_huikuan] ");
        strSql.Append(" where huikuan_id=@huikuan_id ");
        SqlParameter[] parameters = {
					new SqlParameter("@huikuan_id", SqlDbType.Int,4)};
        parameters[0].Value = huikuan_id;

        DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
        if (ds.Tables[0].Rows.Count > 0)
        {
            if (ds.Tables[0].Rows[0]["huikuan_id"] != null && ds.Tables[0].Rows[0]["huikuan_id"].ToString() != "")
            {
                this.huikuan_id = int.Parse(ds.Tables[0].Rows[0]["huikuan_id"].ToString());
            }
            if (ds.Tables[0].Rows[0]["accountname"] != null)
            {
                this.accountname = ds.Tables[0].Rows[0]["accountname"].ToString();
            }
            if (ds.Tables[0].Rows[0]["accountno"] != null)
            {
                this.accountno = ds.Tables[0].Rows[0]["accountno"].ToString();
            }
            if (ds.Tables[0].Rows[0]["hk_time"] != null && ds.Tables[0].Rows[0]["hk_time"].ToString() != "")
            {
                this.hk_time = DateTime.Parse(ds.Tables[0].Rows[0]["hk_time"].ToString());
            }
            if (ds.Tables[0].Rows[0]["money"] != null)
            {
                this.money = ds.Tables[0].Rows[0]["money"].ToString();
            }
            if (ds.Tables[0].Rows[0]["memo"] != null)
            {
                this.memo = ds.Tables[0].Rows[0]["memo"].ToString();
            }
            if (ds.Tables[0].Rows[0]["huiyuan_id"] != null)
            {
                this.huiyuan_id = ds.Tables[0].Rows[0]["huiyuan_id"].ToString();
            }
            if (ds.Tables[0].Rows[0]["huikuan_status"] != null && ds.Tables[0].Rows[0]["huikuan_status"].ToString() != "")
            {
                this.huikuan_status = int.Parse(ds.Tables[0].Rows[0]["huikuan_status"].ToString());
            }
            if (ds.Tables[0].Rows[0]["hk_qr_time"] != null && ds.Tables[0].Rows[0]["hk_qr_time"].ToString() != "")
            {
                this.hk_qr_time = DateTime.Parse(ds.Tables[0].Rows[0]["hk_qr_time"].ToString());
            }
            if (ds.Tables[0].Rows[0]["accountbank"] != null)
            {
                this.accountbank = ds.Tables[0].Rows[0]["accountbank"].ToString();
            }
            if (ds.Tables[0].Rows[0]["queren_man"] != null)
            {
                this.queren_man = ds.Tables[0].Rows[0]["queren_man"].ToString();
            }
            if (ds.Tables[0].Rows[0]["accounttype"] != null)
            {
                this.accounttype = ds.Tables[0].Rows[0]["accounttype"].ToString();
            }
            if (ds.Tables[0].Rows[0]["huiyuan_bianhao"] != null)
            {
                this.huiyuan_bianhao = ds.Tables[0].Rows[0]["huiyuan_bianhao"].ToString();
            }
            if (ds.Tables[0].Rows[0]["huiyuan_name"] != null)
            {
                this.huiyuan_name = ds.Tables[0].Rows[0]["huiyuan_name"].ToString();
            }
            if (ds.Tables[0].Rows[0]["hk_sq_time"] != null && ds.Tables[0].Rows[0]["hk_sq_time"].ToString() != "")
            {
                this.hk_sq_time = DateTime.Parse(ds.Tables[0].Rows[0]["hk_sq_time"].ToString());
            }
            if (ds.Tables[0].Rows[0]["bank_id"] != null && ds.Tables[0].Rows[0]["bank_id"].ToString() != "")
            {
                this.bank_id = int.Parse(ds.Tables[0].Rows[0]["bank_id"].ToString());
            }
        }
    }
    /// <summary>
    /// 更新是否支付状态
    /// </summary>
    public bool UpdateStatus()
    {
        StringBuilder strSql = new StringBuilder();
        strSql.Append("update [tbl_huikuan] set ");
        strSql.Append("huikuan_status=@huikuan_status");
        strSql.Append(" where huikuan_id=@huikuan_id ");
        SqlParameter[] parameters = {
					new SqlParameter("@huikuan_status", SqlDbType.Int,4),
					new SqlParameter("@huikuan_id", SqlDbType.Int,4)};
        parameters[0].Value = huikuan_status;
        parameters[1].Value = huikuan_id;

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
    /// 获得数据列表
    /// </summary>
    public DataSet GetList(string strWhere)
    {
        StringBuilder strSql = new StringBuilder();
        strSql.Append("select * ");
        strSql.Append(" FROM [tbl_huikuan] ");
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
        strSql.Append("select top 1 " + Title + " as sumcode from [tbl_huikuan]");
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
        strSql.Append("select * FROM  tbl_huikuan");
        if (strWhere.Trim() != "")
        {
            strSql.Append(" where " + strWhere);
        }
        recordCount = Convert.ToInt32(DbHelperSQL.GetSingle(PagingHelper.CreateCountingSql(strSql.ToString())));
        return DbHelperSQL.Query(PagingHelper.CreatePagingSql(recordCount, pageSize, pageIndex, strSql.ToString(), filedOrder));
    }
    #endregion  Method
}