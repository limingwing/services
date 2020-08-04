using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;

/// <summary>
/// 类tbl_machine。
/// </summary>
[Serializable]
public partial class tbl_machine
{
    public tbl_machine()
    { }
    #region Model
    private int _id;
    private decimal? _price;
    private string _name;
    private int? _date;
    private int? _flag = 0;
    private decimal? _amount;
    private decimal? _percent;
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
    public decimal? price
    {
        set { _price = value; }
        get { return _price; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string name
    {
        set { _name = value; }
        get { return _name; }
    }
    /// <summary>
    /// 生命周期
    /// </summary>
    public int? date
    {
        set { _date = value; }
        get { return _date; }
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
    /// 挖矿数量
    /// </summary>
    public decimal? amount
    {
        set { _amount = value; }
        get { return _amount; }
    }
    /// <summary>
    /// 打印量
    /// </summary>
    public decimal? percent
    {
        set { _percent = value; }
        get { return _percent; }
    }
    #endregion Model


    #region  Method

    /// <summary>
    /// 得到一个对象实体
    /// </summary>
    public tbl_machine(int id)
    {
        StringBuilder strSql = new StringBuilder();
        strSql.Append("select id,price,name,date,flag,amount,percent ");
        strSql.Append(" FROM [tbl_machine] ");
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
            if (ds.Tables[0].Rows[0]["price"].ToString() != "")
            {
                this.price = decimal.Parse(ds.Tables[0].Rows[0]["price"].ToString());
            }
            if (ds.Tables[0].Rows[0]["name"] != null)
            {
                this.name = ds.Tables[0].Rows[0]["name"].ToString();
            }
            if (ds.Tables[0].Rows[0]["date"].ToString() != "")
            {
                this.date = int.Parse(ds.Tables[0].Rows[0]["date"].ToString());
            }
            if (ds.Tables[0].Rows[0]["flag"].ToString() != "")
            {
                this.flag = int.Parse(ds.Tables[0].Rows[0]["flag"].ToString());
            }
            if (ds.Tables[0].Rows[0]["amount"].ToString() != "")
            {
                this.amount = decimal.Parse(ds.Tables[0].Rows[0]["amount"].ToString());
            }
            if (ds.Tables[0].Rows[0]["percent"].ToString() != "")
            {
                this.percent = decimal.Parse(ds.Tables[0].Rows[0]["percent"].ToString());
            }
        }
    }
    /// <summary>
    /// 是否存在该记录
    /// </summary>
    public bool Exists(int id)
    {
        StringBuilder strSql = new StringBuilder();
        strSql.Append("select count(1) from [tbl_machine]");
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
        strSql.Append("insert into [tbl_machine] (");
        strSql.Append("price,name,date,flag,amount,percent)");
        strSql.Append(" values (");
        strSql.Append("@price,@name,@date,@flag,@amount,@percent)");
        strSql.Append(";select @@IDENTITY");
        SqlParameter[] parameters = {
					new SqlParameter("@price", SqlDbType.Money,8),
					new SqlParameter("@name", SqlDbType.NVarChar,50),
					new SqlParameter("@date", SqlDbType.Int,4),
					new SqlParameter("@flag", SqlDbType.Int,4),
					new SqlParameter("@amount", SqlDbType.Money,8),
					new SqlParameter("@percent", SqlDbType.Money,8)};
        parameters[0].Value = price;
        parameters[1].Value = name;
        parameters[2].Value = date;
        parameters[3].Value = flag;
        parameters[4].Value = amount;
        parameters[5].Value = percent;

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
        strSql.Append("update [tbl_machine] set ");
        strSql.Append("price=@price,");
        strSql.Append("name=@name,");
        strSql.Append("date=@date,");
        strSql.Append("flag=@flag,");
        strSql.Append("amount=@amount,");
        strSql.Append("percent=@percent");
        strSql.Append(" where id=@id ");
        SqlParameter[] parameters = {
					new SqlParameter("@price", SqlDbType.Money,8),
					new SqlParameter("@name", SqlDbType.NVarChar,50),
					new SqlParameter("@date", SqlDbType.Int,4),
					new SqlParameter("@flag", SqlDbType.Int,4),
					new SqlParameter("@amount", SqlDbType.Money,8),
					new SqlParameter("@percent", SqlDbType.Money,8),
					new SqlParameter("@id", SqlDbType.Int,4)};
        parameters[0].Value = price;
        parameters[1].Value = name;
        parameters[2].Value = date;
        parameters[3].Value = flag;
        parameters[4].Value = amount;
        parameters[5].Value = percent;
        parameters[6].Value = id;

        DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
    }

    /// <summary>
    /// 删除一条数据
    /// </summary>
    public void Delete(int id)
    {
        StringBuilder strSql = new StringBuilder();
        strSql.Append("delete from [tbl_machine] ");
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
        strSql.Append("select  top 1 id,price,name,date,flag,amount,[percent] ");
        strSql.Append(" FROM [tbl_machine] ");
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
            if (ds.Tables[0].Rows[0]["price"].ToString() != "")
            {
                this.price = decimal.Parse(ds.Tables[0].Rows[0]["price"].ToString());
            }
            if (ds.Tables[0].Rows[0]["name"] != null)
            {
                this.name = ds.Tables[0].Rows[0]["name"].ToString();
            }
            if (ds.Tables[0].Rows[0]["date"].ToString() != "")
            {
                this.date = int.Parse(ds.Tables[0].Rows[0]["date"].ToString());
            }
            if (ds.Tables[0].Rows[0]["flag"].ToString() != "")
            {
                this.flag = int.Parse(ds.Tables[0].Rows[0]["flag"].ToString());
            }
            if (ds.Tables[0].Rows[0]["amount"].ToString() != "")
            {
                this.amount = decimal.Parse(ds.Tables[0].Rows[0]["amount"].ToString());
            }
            if (ds.Tables[0].Rows[0]["percent"].ToString() != "")
            {
                this.percent = decimal.Parse(ds.Tables[0].Rows[0]["percent"].ToString());
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
        strSql.Append(" FROM [tbl_machine] ");
        if (strWhere.Trim() != "")
        {
            strSql.Append(" where " + strWhere);
        }
        return DbHelperSQL.Query(strSql.ToString());
    }
    public DataSet GetList(int pageSize, int pageIndex, string strWhere, string filedOrder, out int recordCount)
    {
        StringBuilder strSql = new StringBuilder();
        strSql.Append("select * ");
        strSql.Append(" FROM [tbl_machine] ");
        if (strWhere.Trim() != "")
        {
            strSql.Append(" where " + strWhere);
        }
        recordCount = Convert.ToInt32(DbHelperSQL.GetSingle(PagingHelper.CreateCountingSql(strSql.ToString())));
        return DbHelperSQL.Query(PagingHelper.CreatePagingSql(recordCount, pageSize, pageIndex, strSql.ToString(), filedOrder));
    }

    #endregion  Method
}