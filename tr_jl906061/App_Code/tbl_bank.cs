using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;

/// <summary>
///tbl_bank 的摘要说明
/// </summary>
[Serializable]
public partial class tbl_bank
{
    public tbl_bank()
    { }
    #region Model
    private int _id;
    private string _accountbank;
    private string _accountname;
    private string _accountno;
    private string _accountadd;
    private string _beizhu;
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
    public string accountbank
    {
        set { _accountbank = value; }
        get { return _accountbank; }
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
    public string accountadd
    {
        set { _accountadd = value; }
        get { return _accountadd; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string beizhu
    {
        set { _beizhu = value; }
        get { return _beizhu; }
    }
    #endregion Model


    #region  Method

    /// <summary>
    /// 得到一个对象实体
    /// </summary>
    public tbl_bank(int id)
    {
        StringBuilder strSql = new StringBuilder();
        strSql.Append("select id,accountbank,accountname,accountno,accountadd,beizhu ");
        strSql.Append(" FROM [tbl_bank] ");
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
            if (ds.Tables[0].Rows[0]["accountbank"] != null)
            {
                this.accountbank = ds.Tables[0].Rows[0]["accountbank"].ToString();
            }
            if (ds.Tables[0].Rows[0]["accountname"] != null)
            {
                this.accountname = ds.Tables[0].Rows[0]["accountname"].ToString();
            }
            if (ds.Tables[0].Rows[0]["accountno"] != null)
            {
                this.accountno = ds.Tables[0].Rows[0]["accountno"].ToString();
            }
            if (ds.Tables[0].Rows[0]["accountadd"] != null)
            {
                this.accountadd = ds.Tables[0].Rows[0]["accountadd"].ToString();
            }
            if (ds.Tables[0].Rows[0]["beizhu"] != null)
            {
                this.beizhu = ds.Tables[0].Rows[0]["beizhu"].ToString();
            }
        }
    }
    /// <summary>
    /// 是否存在该记录
    /// </summary>
    public bool Exists(int id)
    {
        StringBuilder strSql = new StringBuilder();
        strSql.Append("select count(1) from [tbl_bank]");
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
        strSql.Append("insert into [tbl_bank] (");
        strSql.Append("accountbank,accountname,accountno,accountadd,beizhu)");
        strSql.Append(" values (");
        strSql.Append("@accountbank,@accountname,@accountno,@accountadd,@beizhu)");
        strSql.Append(";select @@IDENTITY");
        SqlParameter[] parameters = {
				new SqlParameter("@accountbank", SqlDbType.NVarChar,50),
				new SqlParameter("@accountname", SqlDbType.NVarChar,50),
				new SqlParameter("@accountno", SqlDbType.NVarChar,50),
				new SqlParameter("@accountadd", SqlDbType.NVarChar,50),
				new SqlParameter("@beizhu", SqlDbType.NVarChar,50)};
        parameters[0].Value = accountbank;
        parameters[1].Value = accountname;
        parameters[2].Value = accountno;
        parameters[3].Value = accountadd;
        parameters[4].Value = beizhu;

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
        strSql.Append("update [tbl_bank] set ");
        strSql.Append("accountbank=@accountbank,");
        strSql.Append("accountname=@accountname,");
        strSql.Append("accountno=@accountno,");
        strSql.Append("accountadd=@accountadd,");
        strSql.Append("beizhu=@beizhu");
        strSql.Append(" where id=@id ");
        SqlParameter[] parameters = {
				new SqlParameter("@accountbank", SqlDbType.NVarChar,50),
				new SqlParameter("@accountname", SqlDbType.NVarChar,50),
				new SqlParameter("@accountno", SqlDbType.NVarChar,50),
				new SqlParameter("@accountadd", SqlDbType.NVarChar,50),
				new SqlParameter("@beizhu", SqlDbType.NVarChar,50),
				new SqlParameter("@id", SqlDbType.Int,4)};
        parameters[0].Value = accountbank;
        parameters[1].Value = accountname;
        parameters[2].Value = accountno;
        parameters[3].Value = accountadd;
        parameters[4].Value = beizhu;
        parameters[5].Value = id;

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
        strSql.Append("delete from [tbl_bank] ");
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
        strSql.Append("select id,accountbank,accountname,accountno,accountadd,beizhu ");
        strSql.Append(" FROM [tbl_bank] ");
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
            if (ds.Tables[0].Rows[0]["accountbank"] != null)
            {
                this.accountbank = ds.Tables[0].Rows[0]["accountbank"].ToString();
            }
            if (ds.Tables[0].Rows[0]["accountname"] != null)
            {
                this.accountname = ds.Tables[0].Rows[0]["accountname"].ToString();
            }
            if (ds.Tables[0].Rows[0]["accountno"] != null)
            {
                this.accountno = ds.Tables[0].Rows[0]["accountno"].ToString();
            }
            if (ds.Tables[0].Rows[0]["accountadd"] != null)
            {
                this.accountadd = ds.Tables[0].Rows[0]["accountadd"].ToString();
            }
            if (ds.Tables[0].Rows[0]["beizhu"] != null)
            {
                this.beizhu = ds.Tables[0].Rows[0]["beizhu"].ToString();
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
        strSql.Append(" FROM [tbl_bank] ");
        if (strWhere.Trim() != "")
        {
            strSql.Append(" where " + strWhere);
        }
        return DbHelperSQL.Query(strSql.ToString());
    }

    #endregion  Method

    /// <summary>
    /// 获得查询分页数据
    /// </summary>
    public DataSet GetList(int pageSize, int pageIndex, string strWhere, string filedOrder, out int recordCount)
    {
        StringBuilder strSql = new StringBuilder();
        strSql.Append("select * FROM  tbl_bank");
        if (strWhere.Trim() != "")
        {
            strSql.Append(" where " + strWhere);
        }
        recordCount = Convert.ToInt32(DbHelperSQL.GetSingle(PagingHelper.CreateCountingSql(strSql.ToString())));
        return DbHelperSQL.Query(PagingHelper.CreatePagingSql(recordCount, pageSize, pageIndex, strSql.ToString(), filedOrder));
    }

    /// <summary>
    /// 排除自己查询用户名-账号是否存在
    /// </summary>
    public bool ExistsE(string huiyuan_bianhao, int id)
    {
        StringBuilder strSql = new StringBuilder();
        strSql.Append("select count(1) from  tbl_bank");
        strSql.Append(" where accountbank=@huiyuan_bianhao and  id<>@id");
        SqlParameter[] parameters = {
					new SqlParameter("@huiyuan_bianhao", SqlDbType.NVarChar,100),
                    new SqlParameter("@id", SqlDbType.Int,4)};
        parameters[0].Value = huiyuan_bianhao;
        parameters[1].Value = id;

        return DbHelperSQL.Exists(strSql.ToString(), parameters);
    }
}