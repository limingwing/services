using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;

[Serializable]
public partial class tbl_sinkia_help
{
    public tbl_sinkia_help()
    { }
    #region Model
    private int _id;
    private string _help1;
    private string _help1_url;
    private int? _sort_id;
    private string _beiyong1;
    private string _beiyong2;
    private string _beiyong3;
    private int? _beiyong4;
    private int? _beiyong5;
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
    public string help1
    {
        set { _help1 = value; }
        get { return _help1; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string help1_url
    {
        set { _help1_url = value; }
        get { return _help1_url; }
    }
    /// <summary>
    /// 
    /// </summary>
    public int? sort_id
    {
        set { _sort_id = value; }
        get { return _sort_id; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string beiyong1
    {
        set { _beiyong1 = value; }
        get { return _beiyong1; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string beiyong2
    {
        set { _beiyong2 = value; }
        get { return _beiyong2; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string beiyong3
    {
        set { _beiyong3 = value; }
        get { return _beiyong3; }
    }
    /// <summary>
    /// 
    /// </summary>
    public int? beiyong4
    {
        set { _beiyong4 = value; }
        get { return _beiyong4; }
    }
    /// <summary>
    /// 
    /// </summary>
    public int? beiyong5
    {
        set { _beiyong5 = value; }
        get { return _beiyong5; }
    }
    #endregion Model


    #region  Method

    /// <summary>
    /// 得到一个对象实体
    /// </summary>
    public tbl_sinkia_help(int id)
    {
        StringBuilder strSql = new StringBuilder();
        strSql.Append("select id,help1,help1_url,sort_id,beiyong1,beiyong2,beiyong3,beiyong4,beiyong5 ");
        strSql.Append(" FROM [tbl_sinkia_help] ");
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
            if (ds.Tables[0].Rows[0]["help1"] != null)
            {
                this.help1 = ds.Tables[0].Rows[0]["help1"].ToString();
            }
            if (ds.Tables[0].Rows[0]["help1_url"] != null)
            {
                this.help1_url = ds.Tables[0].Rows[0]["help1_url"].ToString();
            }
            if (ds.Tables[0].Rows[0]["sort_id"] != null && ds.Tables[0].Rows[0]["sort_id"].ToString() != "")
            {
                this.sort_id = int.Parse(ds.Tables[0].Rows[0]["sort_id"].ToString());
            }
            if (ds.Tables[0].Rows[0]["beiyong1"] != null)
            {
                this.beiyong1 = ds.Tables[0].Rows[0]["beiyong1"].ToString();
            }
            if (ds.Tables[0].Rows[0]["beiyong2"] != null)
            {
                this.beiyong2 = ds.Tables[0].Rows[0]["beiyong2"].ToString();
            }
            if (ds.Tables[0].Rows[0]["beiyong3"] != null)
            {
                this.beiyong3 = ds.Tables[0].Rows[0]["beiyong3"].ToString();
            }
            if (ds.Tables[0].Rows[0]["beiyong4"] != null && ds.Tables[0].Rows[0]["beiyong4"].ToString() != "")
            {
                this.beiyong4 = int.Parse(ds.Tables[0].Rows[0]["beiyong4"].ToString());
            }
            if (ds.Tables[0].Rows[0]["beiyong5"] != null && ds.Tables[0].Rows[0]["beiyong5"].ToString() != "")
            {
                this.beiyong5 = int.Parse(ds.Tables[0].Rows[0]["beiyong5"].ToString());
            }
        }
    }
    /// <summary>
    /// 是否存在该记录
    /// </summary>
    public bool Exists()
    {
        StringBuilder strSql = new StringBuilder();
        strSql.Append("select count(1) from [tbl_sinkia_help]");
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
        strSql.Append("insert into [tbl_sinkia_help] (");
        strSql.Append("help1,help1_url,sort_id,beiyong1,beiyong2,beiyong3,beiyong4,beiyong5)");
        strSql.Append(" values (");
        strSql.Append("@help1,@help1_url,@sort_id,@beiyong1,@beiyong2,@beiyong3,@beiyong4,@beiyong5)");
        strSql.Append(";select @@IDENTITY");
        SqlParameter[] parameters = {
					new SqlParameter("@help1", SqlDbType.VarChar,200),
					new SqlParameter("@help1_url", SqlDbType.VarChar,200),
					new SqlParameter("@sort_id", SqlDbType.Int,4),
					new SqlParameter("@beiyong1", SqlDbType.VarChar,200),
					new SqlParameter("@beiyong2", SqlDbType.VarChar,200),
					new SqlParameter("@beiyong3", SqlDbType.VarChar,200),
					new SqlParameter("@beiyong4", SqlDbType.Int,4),
					new SqlParameter("@beiyong5", SqlDbType.Int,4)};
        parameters[0].Value = help1;
        parameters[1].Value = help1_url;
        parameters[2].Value = sort_id;
        parameters[3].Value = beiyong1;
        parameters[4].Value = beiyong2;
        parameters[5].Value = beiyong3;
        parameters[6].Value = beiyong4;
        parameters[7].Value = beiyong5;

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
    /// 修改一列数据
    /// </summary>
    public void UpdateField(int id, string strValue)
    {
        StringBuilder strSql = new StringBuilder();
        strSql.Append("update tbl_sinkia_help set " + strValue);
        strSql.Append(" where id=" + id);
        DbHelperSQL.ExecuteSql(strSql.ToString());
    }
    /// <summary>
    /// 更新一条数据
    /// </summary>
    public bool Update()
    {
        StringBuilder strSql = new StringBuilder();
        strSql.Append("update [tbl_sinkia_help] set ");
        strSql.Append("help1=@help1,");
        strSql.Append("help1_url=@help1_url,");
        strSql.Append("sort_id=@sort_id,");
        strSql.Append("beiyong1=@beiyong1,");
        strSql.Append("beiyong2=@beiyong2,");
        strSql.Append("beiyong3=@beiyong3,");
        strSql.Append("beiyong4=@beiyong4,");
        strSql.Append("beiyong5=@beiyong5");
        strSql.Append(" where id=@id ");
        SqlParameter[] parameters = {
					new SqlParameter("@help1", SqlDbType.VarChar,200),
					new SqlParameter("@help1_url", SqlDbType.VarChar,200),
					new SqlParameter("@sort_id", SqlDbType.Int,4),
					new SqlParameter("@beiyong1", SqlDbType.VarChar,200),
					new SqlParameter("@beiyong2", SqlDbType.VarChar,200),
					new SqlParameter("@beiyong3", SqlDbType.VarChar,200),
					new SqlParameter("@beiyong4", SqlDbType.Int,4),
					new SqlParameter("@beiyong5", SqlDbType.Int,4),
					new SqlParameter("@id", SqlDbType.Int,4)};
        parameters[0].Value = help1;
        parameters[1].Value = help1_url;
        parameters[2].Value = sort_id;
        parameters[3].Value = beiyong1;
        parameters[4].Value = beiyong2;
        parameters[5].Value = beiyong3;
        parameters[6].Value = beiyong4;
        parameters[7].Value = beiyong5;
        parameters[8].Value = id;

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
        strSql.Append("delete from [tbl_sinkia_help] ");
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
        strSql.Append("select id,help1,help1_url,sort_id,beiyong1,beiyong2,beiyong3,beiyong4,beiyong5 ");
        strSql.Append(" FROM [tbl_sinkia_help] ");
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
            if (ds.Tables[0].Rows[0]["help1"] != null)
            {
                this.help1 = ds.Tables[0].Rows[0]["help1"].ToString();
            }
            if (ds.Tables[0].Rows[0]["help1_url"] != null)
            {
                this.help1_url = ds.Tables[0].Rows[0]["help1_url"].ToString();
            }
            if (ds.Tables[0].Rows[0]["sort_id"] != null && ds.Tables[0].Rows[0]["sort_id"].ToString() != "")
            {
                this.sort_id = int.Parse(ds.Tables[0].Rows[0]["sort_id"].ToString());
            }
            if (ds.Tables[0].Rows[0]["beiyong1"] != null)
            {
                this.beiyong1 = ds.Tables[0].Rows[0]["beiyong1"].ToString();
            }
            if (ds.Tables[0].Rows[0]["beiyong2"] != null)
            {
                this.beiyong2 = ds.Tables[0].Rows[0]["beiyong2"].ToString();
            }
            if (ds.Tables[0].Rows[0]["beiyong3"] != null)
            {
                this.beiyong3 = ds.Tables[0].Rows[0]["beiyong3"].ToString();
            }
            if (ds.Tables[0].Rows[0]["beiyong4"] != null && ds.Tables[0].Rows[0]["beiyong4"].ToString() != "")
            {
                this.beiyong4 = int.Parse(ds.Tables[0].Rows[0]["beiyong4"].ToString());
            }
            if (ds.Tables[0].Rows[0]["beiyong5"] != null && ds.Tables[0].Rows[0]["beiyong5"].ToString() != "")
            {
                this.beiyong5 = int.Parse(ds.Tables[0].Rows[0]["beiyong5"].ToString());
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
        strSql.Append(" FROM [tbl_sinkia_help] ");
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
        strSql.Append("select * FROM  tbl_sinkia_help");
        if (strWhere.Trim() != "")
        {
            strSql.Append(" where " + strWhere);
        }
        recordCount = Convert.ToInt32(DbHelperSQL.GetSingle(PagingHelper.CreateCountingSql(strSql.ToString())));
        return DbHelperSQL.Query(PagingHelper.CreatePagingSql(recordCount, pageSize, pageIndex, strSql.ToString(), filedOrder));
    }
    #endregion  Method
}