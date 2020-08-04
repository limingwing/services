using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;

[Serializable]
public partial class tbl_erweima
{
    public tbl_erweima()
    { }
    #region Model
    private int _id;
    private string _home_title;
    private string _home_code;
    private int? _beiyong7;
    private int? _beiyong8;
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
    public string home_title
    {
        set { _home_title = value; }
        get { return _home_title; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string home_code
    {
        set { _home_code = value; }
        get { return _home_code; }
    }
    /// <summary>
    /// 
    /// </summary>
    public int? beiyong7
    {
        set { _beiyong7 = value; }
        get { return _beiyong7; }
    }
    /// <summary>
    /// 
    /// </summary>
    public int? beiyong8
    {
        set { _beiyong8 = value; }
        get { return _beiyong8; }
    }
    #endregion Model


    #region  Method

    /// <summary>
    /// 得到一个对象实体
    /// </summary>
    public tbl_erweima(int id)
    {
        StringBuilder strSql = new StringBuilder();
        strSql.Append("select id,home_title,home_code,beiyong7,beiyong8 ");
        strSql.Append(" FROM [tbl_erweima] ");
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
            if (ds.Tables[0].Rows[0]["home_title"] != null)
            {
                this.home_title = ds.Tables[0].Rows[0]["home_title"].ToString();
            }
            if (ds.Tables[0].Rows[0]["home_code"] != null)
            {
                this.home_code = ds.Tables[0].Rows[0]["home_code"].ToString();
            }
            if (ds.Tables[0].Rows[0]["beiyong7"] != null && ds.Tables[0].Rows[0]["beiyong7"].ToString() != "")
            {
                this.beiyong7 = int.Parse(ds.Tables[0].Rows[0]["beiyong7"].ToString());
            }
            if (ds.Tables[0].Rows[0]["beiyong8"] != null && ds.Tables[0].Rows[0]["beiyong8"].ToString() != "")
            {
                this.beiyong8 = int.Parse(ds.Tables[0].Rows[0]["beiyong8"].ToString());
            }
        }
    }

    /// <summary>
    /// 得到最大ID
    /// </summary>
    public int GetMaxId()
    {

        return DbHelperSQL.GetMaxID("id", "tbl_erweima");
    }

    /// <summary>
    /// 是否存在该记录
    /// </summary>
    public bool Exists(int id)
    {
        StringBuilder strSql = new StringBuilder();
        strSql.Append("select count(1) from [tbl_erweima]");
        strSql.Append(" where id=@id ");

        SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)};
        parameters[0].Value = id;

        return DbHelperSQL.Exists(strSql.ToString(), parameters);
    }

    /// <summary>
    /// 查询排除自己名称是否存在
    /// </summary>
    public bool Exists(string pro_class, int id)
    {
        StringBuilder strSql = new StringBuilder();
        strSql.Append("select count(1) from  tbl_erweima");
        strSql.Append(" where  id<>@id and  home_title=@pro_class ");
        SqlParameter[] parameters = {
                     new SqlParameter("@id", SqlDbType.Int,4),
					new SqlParameter("@pro_class", SqlDbType.NVarChar,100)};
        parameters[0].Value = id;
        parameters[1].Value = pro_class;

        return DbHelperSQL.Exists(strSql.ToString(), parameters);
    }
    /// <summary>
    /// 增加一条数据
    /// </summary>
    public void Add()
    {
        StringBuilder strSql = new StringBuilder();
        strSql.Append("insert into [tbl_erweima] (");
        strSql.Append("id,home_title,home_code,beiyong7,beiyong8)");
        strSql.Append(" values (");
        strSql.Append("@id,@home_title,@home_code,@beiyong7,@beiyong8)");
        SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4),
					new SqlParameter("@home_title", SqlDbType.VarChar,200),
					new SqlParameter("@home_code", SqlDbType.VarChar,200),
					new SqlParameter("@beiyong7", SqlDbType.Int,4),
					new SqlParameter("@beiyong8", SqlDbType.Int,4)};
        parameters[0].Value = id;
        parameters[1].Value = home_title;
        parameters[2].Value = home_code;
        parameters[3].Value = beiyong7;
        parameters[4].Value = beiyong8;

        DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
    }
    /// <summary>
    /// 更新一条数据
    /// </summary>
    public bool Update()
    {
        StringBuilder strSql = new StringBuilder();
        strSql.Append("update [tbl_erweima] set ");
        strSql.Append("home_title=@home_title,");
        strSql.Append("home_code=@home_code,");
        strSql.Append("beiyong7=@beiyong7,");
        strSql.Append("beiyong8=@beiyong8");
        strSql.Append(" where id=@id ");
        SqlParameter[] parameters = {
					new SqlParameter("@home_title", SqlDbType.VarChar,200),
					new SqlParameter("@home_code", SqlDbType.VarChar,200),
					new SqlParameter("@beiyong7", SqlDbType.Int,4),
					new SqlParameter("@beiyong8", SqlDbType.Int,4),
					new SqlParameter("@id", SqlDbType.Int,4)};
        parameters[0].Value = home_title;
        parameters[1].Value = home_code;
        parameters[2].Value = beiyong7;
        parameters[3].Value = beiyong8;
        parameters[4].Value = id;

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
        strSql.Append("delete from [tbl_erweima] ");
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
        strSql.Append("select id,home_title,home_code,beiyong7,beiyong8 ");
        strSql.Append(" FROM [tbl_erweima] ");
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
            if (ds.Tables[0].Rows[0]["home_title"] != null)
            {
                this.home_title = ds.Tables[0].Rows[0]["home_title"].ToString();
            }
            if (ds.Tables[0].Rows[0]["home_code"] != null)
            {
                this.home_code = ds.Tables[0].Rows[0]["home_code"].ToString();
            }
            if (ds.Tables[0].Rows[0]["beiyong7"] != null && ds.Tables[0].Rows[0]["beiyong7"].ToString() != "")
            {
                this.beiyong7 = int.Parse(ds.Tables[0].Rows[0]["beiyong7"].ToString());
            }
            if (ds.Tables[0].Rows[0]["beiyong8"] != null && ds.Tables[0].Rows[0]["beiyong8"].ToString() != "")
            {
                this.beiyong8 = int.Parse(ds.Tables[0].Rows[0]["beiyong8"].ToString());
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
        strSql.Append(" FROM [tbl_erweima] ");
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
        strSql.Append("select * FROM  tbl_erweima");
        if (strWhere.Trim() != "")
        {
            strSql.Append(" where " + strWhere);
        }
        recordCount = Convert.ToInt32(DbHelperSQL.GetSingle(PagingHelper.CreateCountingSql(strSql.ToString())));
        return DbHelperSQL.Query(PagingHelper.CreatePagingSql(recordCount, pageSize, pageIndex, strSql.ToString(), filedOrder));
    }
    #endregion  Method
}