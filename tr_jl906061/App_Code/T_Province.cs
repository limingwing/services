using System;
using System.Text;
using System.Data.SqlClient;
using System.Data;


/// <summary>
/// 类T_Province。
/// </summary>
[Serializable]
public partial class T_Province
{
    public T_Province()
    { }
    #region Model
    private int _proid;
    private string _proname;
    private int? _prosort;
    private string _proremark;
    /// <summary>
    /// 
    /// </summary>
    public int ProID
    {
        set { _proid = value; }
        get { return _proid; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string ProName
    {
        set { _proname = value; }
        get { return _proname; }
    }
    /// <summary>
    /// 
    /// </summary>
    public int? ProSort
    {
        set { _prosort = value; }
        get { return _prosort; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string ProRemark
    {
        set { _proremark = value; }
        get { return _proremark; }
    }
    #endregion Model


    #region  Method

    /// <summary>
    /// 得到一个对象实体
    /// </summary>
    public T_Province(int ProID)
    {
        StringBuilder strSql = new StringBuilder();
        strSql.Append("select ProID ");
        strSql.Append(" FROM [T_Province] ");
        strSql.Append(" where ProID=@ProID ");
        SqlParameter[] parameters = {
					new SqlParameter("@ProID", SqlDbType.Int,4)};
        parameters[0].Value = ProID;

        DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
        if (ds.Tables[0].Rows.Count > 0)
        {
            if (ds.Tables[0].Rows[0]["ProID"].ToString() != "")
            {
                this.ProID = int.Parse(ds.Tables[0].Rows[0]["ProID"].ToString());
            }
        }
    }

    /// <summary>
    /// 是否存在该记录
    /// </summary>
    public bool Exists(int ProID)
    {
        StringBuilder strSql = new StringBuilder();
        strSql.Append("select count(1) from [T_Province]");
        strSql.Append(" where ProID=@ProID ");

        SqlParameter[] parameters = {
					new SqlParameter("@ProID", SqlDbType.Int,4)};
        parameters[0].Value = ProID;

        return DbHelperSQL.Exists(strSql.ToString(), parameters);
    }


    /// <summary>
    /// 增加一条数据
    /// </summary>
    public void Add()
    {
        StringBuilder strSql = new StringBuilder();
        strSql.Append("insert into [T_Province] (");
        strSql.Append("ProID)");
        strSql.Append(" values (");
        strSql.Append("@ProID)");
        SqlParameter[] parameters = {
					new SqlParameter("@ProID", SqlDbType.Int,4)};
        parameters[0].Value = ProID;

        DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
    }
    /// <summary>
    /// 更新一条数据
    /// </summary>
    public void Update()
    {
        StringBuilder strSql = new StringBuilder();
        strSql.Append("update [T_Province] set ");
        strSql.Append("ProID=@ProID");
        strSql.Append(" where ProID=@ProID ");
        SqlParameter[] parameters = {
					new SqlParameter("@ProID", SqlDbType.Int,4)};
        parameters[0].Value = ProID;

        DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
    }

    /// <summary>
    /// 删除一条数据
    /// </summary>
    public void Delete(int ProID)
    {
        StringBuilder strSql = new StringBuilder();
        strSql.Append("delete from [T_Province] ");
        strSql.Append(" where ProID=@ProID ");
        SqlParameter[] parameters = {
					new SqlParameter("@ProID", SqlDbType.Int,4)};
        parameters[0].Value = ProID;

        DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
    }


    /// <summary>
    /// 得到一个对象实体
    /// </summary>
    public void GetModel(int ProID)
    {
        StringBuilder strSql = new StringBuilder();
        strSql.Append("select  top 1 ProID ");
        strSql.Append(" FROM [T_Province] ");
        strSql.Append(" where ProID=@ProID ");
        SqlParameter[] parameters = {
					new SqlParameter("@ProID", SqlDbType.Int,4)};
        parameters[0].Value = ProID;

        DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
        if (ds.Tables[0].Rows.Count > 0)
        {
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
        strSql.Append(" FROM [T_Province] ");
        if (strWhere.Trim() != "")
        {
            strSql.Append(" where " + strWhere);
        }
        return DbHelperSQL.Query(strSql.ToString());
    }

    #endregion  Method
}