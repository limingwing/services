using System;
using System.Text;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// 类T_City。
/// </summary>
[Serializable]
public partial class T_City
{
    public T_City()
    { }
    #region Model
    private int _cityid;
    private string _cityname;
    private int? _proid;
    private int? _citysort;
    /// <summary>
    /// 
    /// </summary>
    public int CityID
    {
        set { _cityid = value; }
        get { return _cityid; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string CityName
    {
        set { _cityname = value; }
        get { return _cityname; }
    }
    /// <summary>
    /// 
    /// </summary>
    public int? ProID
    {
        set { _proid = value; }
        get { return _proid; }
    }
    /// <summary>
    /// 
    /// </summary>
    public int? CitySort
    {
        set { _citysort = value; }
        get { return _citysort; }
    }
    #endregion Model


    #region  Method

    /// <summary>
    /// 得到一个对象实体
    /// </summary>
    public T_City(int CityID)
    {
        StringBuilder strSql = new StringBuilder();
        strSql.Append("select CityID ");
        strSql.Append(" FROM [T_City] ");
        strSql.Append(" where CityID=@CityID ");
        SqlParameter[] parameters = {
					new SqlParameter("@CityID", SqlDbType.Int,4)};
        parameters[0].Value = CityID;

        DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
        if (ds.Tables[0].Rows.Count > 0)
        {
            if (ds.Tables[0].Rows[0]["CityID"].ToString() != "")
            {
                this.CityID = int.Parse(ds.Tables[0].Rows[0]["CityID"].ToString());
            }
        }
    }

    /// <summary>
    /// 是否存在该记录
    /// </summary>
    public bool Exists(int CityID)
    {
        StringBuilder strSql = new StringBuilder();
        strSql.Append("select count(1) from [T_City]");
        strSql.Append(" where CityID=@CityID ");

        SqlParameter[] parameters = {
					new SqlParameter("@CityID", SqlDbType.Int,4)};
        parameters[0].Value = CityID;

        return DbHelperSQL.Exists(strSql.ToString(), parameters);
    }


    /// <summary>
    /// 增加一条数据
    /// </summary>
    public void Add()
    {
        StringBuilder strSql = new StringBuilder();
        strSql.Append("insert into [T_City] (");
        strSql.Append("CityID)");
        strSql.Append(" values (");
        strSql.Append("@CityID)");
        SqlParameter[] parameters = {
					new SqlParameter("@CityID", SqlDbType.Int,4)};
        parameters[0].Value = CityID;

        DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
    }
    /// <summary>
    /// 更新一条数据
    /// </summary>
    public void Update()
    {
        StringBuilder strSql = new StringBuilder();
        strSql.Append("update [T_City] set ");
        strSql.Append("CityID=@CityID");
        strSql.Append(" where CityID=@CityID ");
        SqlParameter[] parameters = {
					new SqlParameter("@CityID", SqlDbType.Int,4)};
        parameters[0].Value = CityID;

        DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
    }

    /// <summary>
    /// 删除一条数据
    /// </summary>
    public void Delete(int CityID)
    {
        StringBuilder strSql = new StringBuilder();
        strSql.Append("delete from [T_City] ");
        strSql.Append(" where CityID=@CityID ");
        SqlParameter[] parameters = {
					new SqlParameter("@CityID", SqlDbType.Int,4)};
        parameters[0].Value = CityID;

        DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
    }


    /// <summary>
    /// 得到一个对象实体
    /// </summary>
    public void GetModel(int CityID)
    {
        StringBuilder strSql = new StringBuilder();
        strSql.Append("select  top 1 CityID,ProID ");
        strSql.Append(" FROM [T_City] ");
        strSql.Append(" where CityID=@CityID ");
        SqlParameter[] parameters = {
					new SqlParameter("@CityID", SqlDbType.Int,4)};
        parameters[0].Value = CityID;

        DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
        if (ds.Tables[0].Rows.Count > 0)
        {
            if (ds.Tables[0].Rows[0]["CityID"].ToString() != "")
            {
                this.CityID = int.Parse(ds.Tables[0].Rows[0]["CityID"].ToString());
            }
            if (ds.Tables[0].Rows[0]["ProID"].ToString() != "")
            {
                this.ProID = int.Parse(ds.Tables[0].Rows[0]["ProID"].ToString());
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
        strSql.Append(" FROM [T_City] ");
        if (strWhere.Trim() != "")
        {
            strSql.Append(" where " + strWhere);
        }
        return DbHelperSQL.Query(strSql.ToString());
    }

    #endregion  Method
}