using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// 类tbl_gp_list。
/// </summary>
[Serializable]
public partial class tbl_gp_list
{
    public tbl_gp_list()
    { }
    #region Model
    private int _id;
    private decimal? _buy_money = 0M;
    private DateTime? _buy_date;
    private DateTime? _buy_free_date;
    private int? _zz_type = 0;
    private int? _flag = 0;
    private string _buy_id;
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
    public decimal? buy_money
    {
        set { _buy_money = value; }
        get { return _buy_money; }
    }
    /// <summary>
    /// 
    /// </summary>
    public DateTime? buy_date
    {
        set { _buy_date = value; }
        get { return _buy_date; }
    }
    /// <summary>
    /// 
    /// </summary>
    public DateTime? buy_free_date
    {
        set { _buy_free_date = value; }
        get { return _buy_free_date; }
    }
    /// <summary>
    /// 
    /// </summary>
    public int? zz_type
    {
        set { _zz_type = value; }
        get { return _zz_type; }
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
    public string buy_id
    {
        set { _buy_id = value; }
        get { return _buy_id; }
    }
    #endregion Model


    #region  Method

    /// <summary>
    /// 得到一个对象实体
    /// </summary>
    public tbl_gp_list(int id)
    {
        StringBuilder strSql = new StringBuilder();
        strSql.Append("select id,buy_money,buy_date,buy_free_date,zz_type,flag,buy_id ");
        strSql.Append(" FROM [tbl_gp_list] ");
        strSql.Append(" where id=@id ");
        SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)};
        parameters[0].Value = id;

        DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
        if (ds.Tables[0].Rows.Count > 0)
        {
            if (ds.Tables[0].Rows[0]["id"].ToString() != "")
            {
                this.id = int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
            }
            if (ds.Tables[0].Rows[0]["buy_money"].ToString() != "")
            {
                this.buy_money = decimal.Parse(ds.Tables[0].Rows[0]["buy_money"].ToString());
            }
            if (ds.Tables[0].Rows[0]["buy_date"].ToString() != "")
            {
                this.buy_date = DateTime.Parse(ds.Tables[0].Rows[0]["buy_date"].ToString());
            }
            if (ds.Tables[0].Rows[0]["buy_free_date"].ToString() != "")
            {
                this.buy_free_date = DateTime.Parse(ds.Tables[0].Rows[0]["buy_free_date"].ToString());
            }
            if (ds.Tables[0].Rows[0]["zz_type"].ToString() != "")
            {
                this.zz_type = int.Parse(ds.Tables[0].Rows[0]["zz_type"].ToString());
            }
            if (ds.Tables[0].Rows[0]["flag"].ToString() != "")
            {
                this.flag = int.Parse(ds.Tables[0].Rows[0]["flag"].ToString());
            }
            if (ds.Tables[0].Rows[0]["buy_id"] != null)
            {
                this.buy_id = ds.Tables[0].Rows[0]["buy_id"].ToString();
            }
        }
    }
    /// <summary>
    /// 是否存在该记录
    /// </summary>
    public bool Exists(int id)
    {
        StringBuilder strSql = new StringBuilder();
        strSql.Append("select count(1) from [tbl_gp_list]");
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
        strSql.Append("insert into [tbl_gp_list] (");
        strSql.Append("buy_money,buy_date,buy_free_date,zz_type,flag,buy_id)");
        strSql.Append(" values (");
        strSql.Append("@buy_money,@buy_date,@buy_free_date,@zz_type,@flag,@buy_id)");
        strSql.Append(";select @@IDENTITY");
        SqlParameter[] parameters = {
					new SqlParameter("@buy_money", SqlDbType.Money,8),
					new SqlParameter("@buy_date", SqlDbType.DateTime),
					new SqlParameter("@buy_free_date", SqlDbType.DateTime),
					new SqlParameter("@zz_type", SqlDbType.Int,4),
					new SqlParameter("@flag", SqlDbType.Int,4),
					new SqlParameter("@buy_id", SqlDbType.Char,9)};
        parameters[0].Value = buy_money;
        parameters[1].Value = buy_date;
        parameters[2].Value = buy_free_date;
        parameters[3].Value = zz_type;
        parameters[4].Value = flag;
        parameters[5].Value = buy_id;

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
    public void Update()
    {
        StringBuilder strSql = new StringBuilder();
        strSql.Append("update [tbl_gp_list] set ");
        strSql.Append("buy_money=@buy_money,");
        strSql.Append("buy_date=@buy_date,");
        strSql.Append("buy_free_date=@buy_free_date,");
        strSql.Append("zz_type=@zz_type,");
        strSql.Append("flag=@flag,");
        strSql.Append("buy_id=@buy_id");
        strSql.Append(" where id=@id ");
        SqlParameter[] parameters = {
					new SqlParameter("@buy_money", SqlDbType.Money,8),
					new SqlParameter("@buy_date", SqlDbType.DateTime),
					new SqlParameter("@buy_free_date", SqlDbType.DateTime),
					new SqlParameter("@zz_type", SqlDbType.Int,4),
					new SqlParameter("@flag", SqlDbType.Int,4),
					new SqlParameter("@buy_id", SqlDbType.Char,9),
					new SqlParameter("@id", SqlDbType.Int,4)};
        parameters[0].Value = buy_money;
        parameters[1].Value = buy_date;
        parameters[2].Value = buy_free_date;
        parameters[3].Value = zz_type;
        parameters[4].Value = flag;
        parameters[5].Value = buy_id;
        parameters[6].Value = id;

        DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
    }

    /// <summary>
    /// 删除一条数据
    /// </summary>
    public void Delete(int id)
    {
        StringBuilder strSql = new StringBuilder();
        strSql.Append("delete from [tbl_gp_list] ");
        strSql.Append(" where id=@id ");
        SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)};
        parameters[0].Value = id;

        DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
    }


    /// <summary>
    /// 得到一个对象实体
    /// </summary>
    public void GetModel(int id)
    {
        StringBuilder strSql = new StringBuilder();
        strSql.Append("select  top 1 id,buy_money,buy_date,buy_free_date,zz_type,flag,buy_id ");
        strSql.Append(" FROM [tbl_gp_list] ");
        strSql.Append(" where id=@id ");
        SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)};
        parameters[0].Value = id;

        DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
        if (ds.Tables[0].Rows.Count > 0)
        {
            if (ds.Tables[0].Rows[0]["id"].ToString() != "")
            {
                this.id = int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
            }
            if (ds.Tables[0].Rows[0]["buy_money"].ToString() != "")
            {
                this.buy_money = decimal.Parse(ds.Tables[0].Rows[0]["buy_money"].ToString());
            }
            if (ds.Tables[0].Rows[0]["buy_date"].ToString() != "")
            {
                this.buy_date = DateTime.Parse(ds.Tables[0].Rows[0]["buy_date"].ToString());
            }
            if (ds.Tables[0].Rows[0]["buy_free_date"].ToString() != "")
            {
                this.buy_free_date = DateTime.Parse(ds.Tables[0].Rows[0]["buy_free_date"].ToString());
            }
            if (ds.Tables[0].Rows[0]["zz_type"].ToString() != "")
            {
                this.zz_type = int.Parse(ds.Tables[0].Rows[0]["zz_type"].ToString());
            }
            if (ds.Tables[0].Rows[0]["flag"].ToString() != "")
            {
                this.flag = int.Parse(ds.Tables[0].Rows[0]["flag"].ToString());
            }
            if (ds.Tables[0].Rows[0]["buy_id"] != null)
            {
                this.buy_id = ds.Tables[0].Rows[0]["buy_id"].ToString();
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
        strSql.Append(" FROM [tbl_gp_list] ");
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
        strSql.Append("select * ");
        strSql.Append(" FROM [tbl_gp_list] ");
        if (strWhere.Trim() != "")
        {
            strSql.Append(" where " + strWhere);
        }
        recordCount = Convert.ToInt32(DbHelperSQL.GetSingle(PagingHelper.CreateCountingSql(strSql.ToString())));
        return DbHelperSQL.Query(PagingHelper.CreatePagingSql(recordCount, pageSize, pageIndex, strSql.ToString(), filedOrder));
    }
    #endregion  Method
}