using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// 类tbl_gp_buy。
/// </summary>
[Serializable]
public partial class tbl_gp_buy
{
    public tbl_gp_buy()
    { }
    #region Model
    private int _id;
    private string _buy_id;
    private DateTime? _buy_date;
    private decimal? _buy_gu;
    private decimal? _buy_yu;
    private decimal? _buy_zong = 0M;
    private int? _flag_1 = 0;
    private int? _flag_2 = 0;
    private int? _flag = 0;
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
    public string buy_id
    {
        set { _buy_id = value; }
        get { return _buy_id; }
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
    public decimal? buy_gu
    {
        set { _buy_gu = value; }
        get { return _buy_gu; }
    }
    /// <summary>
    /// 
    /// </summary>
    public decimal? buy_yu
    {
        set { _buy_yu = value; }
        get { return _buy_yu; }
    }
    /// <summary>
    /// 
    /// </summary>
    public decimal? buy_zong
    {
        set { _buy_zong = value; }
        get { return _buy_zong; }
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
    public int? flag
    {
        set { _flag = value; }
        get { return _flag; }
    }
    #endregion Model


    #region  Method

    /// <summary>
    /// 得到一个对象实体
    /// </summary>
    public tbl_gp_buy(int id)
    {
        StringBuilder strSql = new StringBuilder();
        strSql.Append("select id,buy_id,buy_date,buy_gu,buy_yu,buy_zong,flag_1,flag_2,flag ");
        strSql.Append(" FROM [tbl_gp_buy] ");
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
            if (ds.Tables[0].Rows[0]["buy_id"] != null)
            {
                this.buy_id = ds.Tables[0].Rows[0]["buy_id"].ToString();
            }
            if (ds.Tables[0].Rows[0]["buy_date"].ToString() != "")
            {
                this.buy_date = DateTime.Parse(ds.Tables[0].Rows[0]["buy_date"].ToString());
            }
            if (ds.Tables[0].Rows[0]["buy_gu"].ToString() != "")
            {
                this.buy_gu = decimal.Parse(ds.Tables[0].Rows[0]["buy_gu"].ToString());
            }
            if (ds.Tables[0].Rows[0]["buy_yu"].ToString() != "")
            {
                this.buy_yu = decimal.Parse(ds.Tables[0].Rows[0]["buy_yu"].ToString());
            }
            if (ds.Tables[0].Rows[0]["buy_zong"].ToString() != "")
            {
                this.buy_zong = decimal.Parse(ds.Tables[0].Rows[0]["buy_zong"].ToString());
            }
            if (ds.Tables[0].Rows[0]["flag_1"].ToString() != "")
            {
                this.flag_1 = int.Parse(ds.Tables[0].Rows[0]["flag_1"].ToString());
            }
            if (ds.Tables[0].Rows[0]["flag_2"].ToString() != "")
            {
                this.flag_2 = int.Parse(ds.Tables[0].Rows[0]["flag_2"].ToString());
            }
            if (ds.Tables[0].Rows[0]["flag"].ToString() != "")
            {
                this.flag = int.Parse(ds.Tables[0].Rows[0]["flag"].ToString());
            }
        }
    }
    /// <summary>
    /// 是否存在该记录
    /// </summary>
    public bool Exists()
    {
        StringBuilder strSql = new StringBuilder();
        strSql.Append("select count(1) from [tbl_gp_buy]");
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
        strSql.Append("insert into [tbl_gp_buy] (");
        strSql.Append("buy_id,buy_date,buy_gu,buy_yu,buy_zong,flag_1,flag_2,flag)");
        strSql.Append(" values (");
        strSql.Append("@buy_id,@buy_date,@buy_gu,@buy_yu,@buy_zong,@flag_1,@flag_2,@flag)");
        strSql.Append(";select @@IDENTITY");
        SqlParameter[] parameters = {
					new SqlParameter("@buy_id", SqlDbType.Char,9),
					new SqlParameter("@buy_date", SqlDbType.DateTime),
					new SqlParameter("@buy_gu", SqlDbType.Money,8),
					new SqlParameter("@buy_yu", SqlDbType.Money,8),
					new SqlParameter("@buy_zong", SqlDbType.Money,8),
					new SqlParameter("@flag_1", SqlDbType.Int,4),
					new SqlParameter("@flag_2", SqlDbType.Int,4),
					new SqlParameter("@flag", SqlDbType.Int,4)};
        parameters[0].Value = buy_id;
        parameters[1].Value = buy_date;
        parameters[2].Value = buy_gu;
        parameters[3].Value = buy_yu;
        parameters[4].Value = buy_zong;
        parameters[5].Value = flag_1;
        parameters[6].Value = flag_2;
        parameters[7].Value = flag;

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
        strSql.Append("update [tbl_gp_buy] set ");
        strSql.Append("buy_id=@buy_id,");
        strSql.Append("buy_date=@buy_date,");
        strSql.Append("buy_gu=@buy_gu,");
        strSql.Append("buy_yu=@buy_yu,");
        strSql.Append("buy_zong=@buy_zong,");
        strSql.Append("flag_1=@flag_1,");
        strSql.Append("flag_2=@flag_2,");
        strSql.Append("flag=@flag");
        strSql.Append(" where id=@id ");
        SqlParameter[] parameters = {
					new SqlParameter("@buy_id", SqlDbType.Char,9),
					new SqlParameter("@buy_date", SqlDbType.DateTime),
					new SqlParameter("@buy_gu", SqlDbType.Money,8),
					new SqlParameter("@buy_yu", SqlDbType.Money,8),
					new SqlParameter("@buy_zong", SqlDbType.Money,8),
					new SqlParameter("@flag_1", SqlDbType.Int,4),
					new SqlParameter("@flag_2", SqlDbType.Int,4),
					new SqlParameter("@flag", SqlDbType.Int,4),
					new SqlParameter("@id", SqlDbType.Int,4)};
        parameters[0].Value = buy_id;
        parameters[1].Value = buy_date;
        parameters[2].Value = buy_gu;
        parameters[3].Value = buy_yu;
        parameters[4].Value = buy_zong;
        parameters[5].Value = flag_1;
        parameters[6].Value = flag_2;
        parameters[7].Value = flag;
        parameters[8].Value = id;

        DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
    }

    /// <summary>
    /// 删除一条数据
    /// </summary>
    public void Delete(int id)
    {
        StringBuilder strSql = new StringBuilder();
        strSql.Append("delete from [tbl_gp_buy] ");
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
        strSql.Append("select  top 1 id,buy_id,buy_date,buy_gu,buy_yu,buy_zong,flag_1,flag_2,flag ");
        strSql.Append(" FROM [tbl_gp_buy] ");
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
            if (ds.Tables[0].Rows[0]["buy_id"] != null)
            {
                this.buy_id = ds.Tables[0].Rows[0]["buy_id"].ToString();
            }
            if (ds.Tables[0].Rows[0]["buy_date"].ToString() != "")
            {
                this.buy_date = DateTime.Parse(ds.Tables[0].Rows[0]["buy_date"].ToString());
            }
            if (ds.Tables[0].Rows[0]["buy_gu"].ToString() != "")
            {
                this.buy_gu = decimal.Parse(ds.Tables[0].Rows[0]["buy_gu"].ToString());
            }
            if (ds.Tables[0].Rows[0]["buy_yu"].ToString() != "")
            {
                this.buy_yu = decimal.Parse(ds.Tables[0].Rows[0]["buy_yu"].ToString());
            }
            if (ds.Tables[0].Rows[0]["buy_zong"].ToString() != "")
            {
                this.buy_zong = decimal.Parse(ds.Tables[0].Rows[0]["buy_zong"].ToString());
            }
            if (ds.Tables[0].Rows[0]["flag_1"].ToString() != "")
            {
                this.flag_1 = int.Parse(ds.Tables[0].Rows[0]["flag_1"].ToString());
            }
            if (ds.Tables[0].Rows[0]["flag_2"].ToString() != "")
            {
                this.flag_2 = int.Parse(ds.Tables[0].Rows[0]["flag_2"].ToString());
            }
            if (ds.Tables[0].Rows[0]["flag"].ToString() != "")
            {
                this.flag = int.Parse(ds.Tables[0].Rows[0]["flag"].ToString());
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
        strSql.Append(" FROM [tbl_gp_buy] ");
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
        strSql.Append("select * FROM  view_buy_gp");
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
        strSql.Append("select top 1 " + Title + " as sumcode from [view_buy_gp]");
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