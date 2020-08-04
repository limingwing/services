using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Text;
using System.Data.SqlClient;

/// <summary>
/// 类tbl_gp_sell。
/// </summary>
[Serializable]
public partial class tbl_gp_sell
{
    public tbl_gp_sell()
    { }
    #region Model
    private int _id;
    private string _sell_id;
    private DateTime? _sell_date;
    private decimal? _sell_zong = 0M;
    private decimal? _sell_yu = 0M;
    private decimal? _sell_gu;
    private int? _flag_1 = 0;
    private int? _flag_2 = 0;
    private decimal? _sell_danjia = 0M;
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
    public string sell_id
    {
        set { _sell_id = value; }
        get { return _sell_id; }
    }
    /// <summary>
    /// 
    /// </summary>
    public DateTime? sell_date
    {
        set { _sell_date = value; }
        get { return _sell_date; }
    }
    /// <summary>
    /// 
    /// </summary>
    public decimal? sell_zong
    {
        set { _sell_zong = value; }
        get { return _sell_zong; }
    }
    /// <summary>
    /// 
    /// </summary>
    public decimal? sell_yu
    {
        set { _sell_yu = value; }
        get { return _sell_yu; }
    }
    /// <summary>
    /// 
    /// </summary>
    public decimal? sell_gu
    {
        set { _sell_gu = value; }
        get { return _sell_gu; }
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
    public decimal? sell_danjia
    {
        set { _sell_danjia = value; }
        get { return _sell_danjia; }
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
    public tbl_gp_sell(int id)
    {
        StringBuilder strSql = new StringBuilder();
        strSql.Append("select id,sell_id,sell_date,sell_zong,sell_yu,sell_gu,flag_1,flag_2,sell_danjia,flag ");
        strSql.Append(" FROM [tbl_gp_sell] ");
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
            if (ds.Tables[0].Rows[0]["sell_id"] != null)
            {
                this.sell_id = ds.Tables[0].Rows[0]["sell_id"].ToString();
            }
            if (ds.Tables[0].Rows[0]["sell_date"].ToString() != "")
            {
                this.sell_date = DateTime.Parse(ds.Tables[0].Rows[0]["sell_date"].ToString());
            }
            if (ds.Tables[0].Rows[0]["sell_zong"].ToString() != "")
            {
                this.sell_zong = decimal.Parse(ds.Tables[0].Rows[0]["sell_zong"].ToString());
            }
            if (ds.Tables[0].Rows[0]["sell_yu"].ToString() != "")
            {
                this.sell_yu = decimal.Parse(ds.Tables[0].Rows[0]["sell_yu"].ToString());
            }
            if (ds.Tables[0].Rows[0]["sell_gu"].ToString() != "")
            {
                this.sell_gu = decimal.Parse(ds.Tables[0].Rows[0]["sell_gu"].ToString());
            }
            if (ds.Tables[0].Rows[0]["flag_1"].ToString() != "")
            {
                this.flag_1 = int.Parse(ds.Tables[0].Rows[0]["flag_1"].ToString());
            }
            if (ds.Tables[0].Rows[0]["flag_2"].ToString() != "")
            {
                this.flag_2 = int.Parse(ds.Tables[0].Rows[0]["flag_2"].ToString());
            }
            if (ds.Tables[0].Rows[0]["sell_danjia"].ToString() != "")
            {
                this.sell_danjia = decimal.Parse(ds.Tables[0].Rows[0]["sell_danjia"].ToString());
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
        strSql.Append("select count(1) from [tbl_gp_sell]");
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
        strSql.Append("insert into [tbl_gp_sell] (");
        strSql.Append("sell_id,sell_date,sell_zong,sell_yu,sell_gu,flag_1,flag_2,sell_danjia,flag)");
        strSql.Append(" values (");
        strSql.Append("@sell_id,@sell_date,@sell_zong,@sell_yu,@sell_gu,@flag_1,@flag_2,@sell_danjia,@flag)");
        strSql.Append(";select @@IDENTITY");
        SqlParameter[] parameters = {
					new SqlParameter("@sell_id", SqlDbType.Char,9),
					new SqlParameter("@sell_date", SqlDbType.DateTime),
					new SqlParameter("@sell_zong", SqlDbType.Money,8),
					new SqlParameter("@sell_yu", SqlDbType.Money,8),
					new SqlParameter("@sell_gu", SqlDbType.Money,8),
					new SqlParameter("@flag_1", SqlDbType.Int,4),
					new SqlParameter("@flag_2", SqlDbType.Int,4),
					new SqlParameter("@sell_danjia", SqlDbType.Money,8),
					new SqlParameter("@flag", SqlDbType.Int,4)};
        parameters[0].Value = sell_id;
        parameters[1].Value = sell_date;
        parameters[2].Value = sell_zong;
        parameters[3].Value = sell_yu;
        parameters[4].Value = sell_gu;
        parameters[5].Value = flag_1;
        parameters[6].Value = flag_2;
        parameters[7].Value = sell_danjia;
        parameters[8].Value = flag;

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
        strSql.Append("update [tbl_gp_sell] set ");
        strSql.Append("sell_id=@sell_id,");
        strSql.Append("sell_date=@sell_date,");
        strSql.Append("sell_zong=@sell_zong,");
        strSql.Append("sell_yu=@sell_yu,");
        strSql.Append("sell_gu=@sell_gu,");
        strSql.Append("flag_1=@flag_1,");
        strSql.Append("flag_2=@flag_2,");
        strSql.Append("sell_danjia=@sell_danjia,");
        strSql.Append("flag=@flag");
        strSql.Append(" where id=@id ");
        SqlParameter[] parameters = {
					new SqlParameter("@sell_id", SqlDbType.Char,9),
					new SqlParameter("@sell_date", SqlDbType.DateTime),
					new SqlParameter("@sell_zong", SqlDbType.Money,8),
					new SqlParameter("@sell_yu", SqlDbType.Money,8),
					new SqlParameter("@sell_gu", SqlDbType.Money,8),
					new SqlParameter("@flag_1", SqlDbType.Int,4),
					new SqlParameter("@flag_2", SqlDbType.Int,4),
					new SqlParameter("@sell_danjia", SqlDbType.Money,8),
					new SqlParameter("@flag", SqlDbType.Int,4),
					new SqlParameter("@id", SqlDbType.Int,4)};
        parameters[0].Value = sell_id;
        parameters[1].Value = sell_date;
        parameters[2].Value = sell_zong;
        parameters[3].Value = sell_yu;
        parameters[4].Value = sell_gu;
        parameters[5].Value = flag_1;
        parameters[6].Value = flag_2;
        parameters[7].Value = sell_danjia;
        parameters[8].Value = flag;
        parameters[9].Value = id;

        DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
    }

    /// <summary>
    /// 删除一条数据
    /// </summary>
    public void Delete(int id)
    {
        StringBuilder strSql = new StringBuilder();
        strSql.Append("delete from [tbl_gp_sell] ");
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
        strSql.Append("select  top 1 id,sell_id,sell_date,sell_zong,sell_yu,sell_gu,flag_1,flag_2,sell_danjia,flag ");
        strSql.Append(" FROM [tbl_gp_sell] ");
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
            if (ds.Tables[0].Rows[0]["sell_id"] != null)
            {
                this.sell_id = ds.Tables[0].Rows[0]["sell_id"].ToString();
            }
            if (ds.Tables[0].Rows[0]["sell_date"].ToString() != "")
            {
                this.sell_date = DateTime.Parse(ds.Tables[0].Rows[0]["sell_date"].ToString());
            }
            if (ds.Tables[0].Rows[0]["sell_zong"].ToString() != "")
            {
                this.sell_zong = decimal.Parse(ds.Tables[0].Rows[0]["sell_zong"].ToString());
            }
            if (ds.Tables[0].Rows[0]["sell_yu"].ToString() != "")
            {
                this.sell_yu = decimal.Parse(ds.Tables[0].Rows[0]["sell_yu"].ToString());
            }
            if (ds.Tables[0].Rows[0]["sell_gu"].ToString() != "")
            {
                this.sell_gu = decimal.Parse(ds.Tables[0].Rows[0]["sell_gu"].ToString());
            }
            if (ds.Tables[0].Rows[0]["flag_1"].ToString() != "")
            {
                this.flag_1 = int.Parse(ds.Tables[0].Rows[0]["flag_1"].ToString());
            }
            if (ds.Tables[0].Rows[0]["flag_2"].ToString() != "")
            {
                this.flag_2 = int.Parse(ds.Tables[0].Rows[0]["flag_2"].ToString());
            }
            if (ds.Tables[0].Rows[0]["sell_danjia"].ToString() != "")
            {
                this.sell_danjia = decimal.Parse(ds.Tables[0].Rows[0]["sell_danjia"].ToString());
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
        strSql.Append(" FROM [tbl_gp_sell] ");
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
        strSql.Append("select * FROM  view_sell_gp");
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
        strSql.Append("select top 1 " + Title + " as sumcode from [tbl_gp_sell]");
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