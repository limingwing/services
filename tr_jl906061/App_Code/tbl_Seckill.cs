using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// 类tbl_Seckill。
/// </summary>
[Serializable]
public partial class tbl_Seckill
{
    public tbl_Seckill()
    { }
    #region Model
    private int _id;
    private DateTime? _starttime;
    private DateTime? _endtime;
    private int? _status;
    private string _name;
    private int? _productid;
    private int? _limitqty;
    private int? _saleqty;
    private DateTime? _createtime;
    /// <summary>
    /// 
    /// </summary>
    public int ID
    {
        set { _id = value; }
        get { return _id; }
    }
    /// <summary>
    /// 
    /// </summary>
    public DateTime? StartTime
    {
        set { _starttime = value; }
        get { return _starttime; }
    }
    /// <summary>
    /// 
    /// </summary>
    public DateTime? EndTime
    {
        set { _endtime = value; }
        get { return _endtime; }
    }
    /// <summary>
    /// 0:未进行，1：正在进行，2：已结束
    /// </summary>
    public int? Status
    {
        set { _status = value; }
        get { return _status; }
    }
    /// <summary>
    /// 促销名称
    /// </summary>
    public string Name
    {
        set { _name = value; }
        get { return _name; }
    }
    /// <summary>
    /// 商品ID
    /// </summary>
    public int? ProductID
    {
        set { _productid = value; }
        get { return _productid; }
    }
    /// <summary>
    /// 限购数量
    /// </summary>
    public int? LimitQTY
    {
        set { _limitqty = value; }
        get { return _limitqty; }
    }
    /// <summary>
    /// 已经销售数量
    /// </summary>
    public int? SaleQTY
    {
        set { _saleqty = value; }
        get { return _saleqty; }
    }
    /// <summary>
    /// 创建时间
    /// </summary>
    public DateTime? CreateTime
    {
        set { _createtime = value; }
        get { return _createtime; }
    }
    #endregion Model


    #region  Method

    /// <summary>
    /// 得到一个对象实体
    /// </summary>
    public tbl_Seckill(int ID)
    {
        StringBuilder strSql = new StringBuilder();
        strSql.Append("select ID,StartTime,EndTime,Status,Name,ProductID,LimitQTY,SaleQTY,CreateTime ");
        strSql.Append(" FROM [tbl_Seckill] ");
        strSql.Append(" where ID=@ID ");
        SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
        parameters[0].Value = ID;

        DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
        if (ds.Tables[0].Rows.Count > 0)
        {
            if (ds.Tables[0].Rows[0]["ID"].ToString() != "")
            {
                this.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
            }
            if (ds.Tables[0].Rows[0]["StartTime"].ToString() != "")
            {
                this.StartTime = DateTime.Parse(ds.Tables[0].Rows[0]["StartTime"].ToString());
            }
            if (ds.Tables[0].Rows[0]["EndTime"].ToString() != "")
            {
                this.EndTime = DateTime.Parse(ds.Tables[0].Rows[0]["EndTime"].ToString());
            }
            if (ds.Tables[0].Rows[0]["Status"].ToString() != "")
            {
                this.Status = int.Parse(ds.Tables[0].Rows[0]["Status"].ToString());
            }
            if (ds.Tables[0].Rows[0]["Name"] != null)
            {
                this.Name = ds.Tables[0].Rows[0]["Name"].ToString();
            }
            if (ds.Tables[0].Rows[0]["ProductID"].ToString() != "")
            {
                this.ProductID = int.Parse(ds.Tables[0].Rows[0]["ProductID"].ToString());
            }
            if (ds.Tables[0].Rows[0]["LimitQTY"].ToString() != "")
            {
                this.LimitQTY = int.Parse(ds.Tables[0].Rows[0]["LimitQTY"].ToString());
            }
            if (ds.Tables[0].Rows[0]["SaleQTY"].ToString() != "")
            {
                this.SaleQTY = int.Parse(ds.Tables[0].Rows[0]["SaleQTY"].ToString());
            }
            if (ds.Tables[0].Rows[0]["CreateTime"].ToString() != "")
            {
                this.CreateTime = DateTime.Parse(ds.Tables[0].Rows[0]["CreateTime"].ToString());
            }
        }
    }
    /// <summary>
    /// 是否存在该记录
    /// </summary>
    public bool Exists(int ID)
    {
        StringBuilder strSql = new StringBuilder();
        strSql.Append("select count(1) from [tbl_Seckill]");
        strSql.Append(" where ID=@ID ");

        SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
        parameters[0].Value = ID;

        return DbHelperSQL.Exists(strSql.ToString(), parameters);
    }


    /// <summary>
    /// 增加一条数据
    /// </summary>
    public int Add()
    {
        StringBuilder strSql = new StringBuilder();
        strSql.Append("insert into [tbl_Seckill] (");
        strSql.Append("StartTime,EndTime,Status,Name,ProductID,LimitQTY,SaleQTY,CreateTime)");
        strSql.Append(" values (");
        strSql.Append("@StartTime,@EndTime,@Status,@Name,@ProductID,@LimitQTY,@SaleQTY,@CreateTime)");
        strSql.Append(";select @@IDENTITY");
        SqlParameter[] parameters = {
					new SqlParameter("@StartTime", SqlDbType.DateTime),
					new SqlParameter("@EndTime", SqlDbType.DateTime),
					new SqlParameter("@Status", SqlDbType.Int,4),
					new SqlParameter("@Name", SqlDbType.NVarChar,50),
					new SqlParameter("@ProductID", SqlDbType.Int,4),
					new SqlParameter("@LimitQTY", SqlDbType.Int,4),
					new SqlParameter("@SaleQTY", SqlDbType.Int,4),
					new SqlParameter("@CreateTime", SqlDbType.DateTime)};
        parameters[0].Value = StartTime;
        parameters[1].Value = EndTime;
        parameters[2].Value = Status;
        parameters[3].Value = Name;
        parameters[4].Value = ProductID;
        parameters[5].Value = LimitQTY;
        parameters[6].Value = SaleQTY;
        parameters[7].Value = CreateTime;

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
    public bool Update()
    {
        StringBuilder strSql = new StringBuilder();
        strSql.Append("update [tbl_Seckill] set ");
        strSql.Append("StartTime=@StartTime,");
        strSql.Append("EndTime=@EndTime,");
        strSql.Append("Status=@Status,");
        strSql.Append("Name=@Name,");
        strSql.Append("ProductID=@ProductID,");
        strSql.Append("LimitQTY=@LimitQTY,");
        strSql.Append("SaleQTY=@SaleQTY,");
        strSql.Append("CreateTime=@CreateTime");
        strSql.Append(" where ID=@ID ");
        SqlParameter[] parameters = {
					new SqlParameter("@StartTime", SqlDbType.DateTime),
					new SqlParameter("@EndTime", SqlDbType.DateTime),
					new SqlParameter("@Status", SqlDbType.Int,4),
					new SqlParameter("@Name", SqlDbType.NVarChar,50),
					new SqlParameter("@ProductID", SqlDbType.Int,4),
					new SqlParameter("@LimitQTY", SqlDbType.Int,4),
					new SqlParameter("@SaleQTY", SqlDbType.Int,4),
					new SqlParameter("@CreateTime", SqlDbType.DateTime),
					new SqlParameter("@ID", SqlDbType.Int,4)};
        parameters[0].Value = StartTime;
        parameters[1].Value = EndTime;
        parameters[2].Value = Status;
        parameters[3].Value = Name;
        parameters[4].Value = ProductID;
        parameters[5].Value = LimitQTY;
        parameters[6].Value = SaleQTY;
        parameters[7].Value = CreateTime;
        parameters[8].Value = ID;

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
    public void Delete(int ID)
    {
        StringBuilder strSql = new StringBuilder();
        strSql.Append("delete from [tbl_Seckill] ");
        strSql.Append(" where ID=@ID ");
        SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
        parameters[0].Value = ID;

        DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
    }


    /// <summary>
    /// 得到一个对象实体
    /// </summary>
    public void GetModel(int ID)
    {
        StringBuilder strSql = new StringBuilder();
        strSql.Append("select  top 1 ID,StartTime,EndTime,Status,Name,ProductID,LimitQTY,SaleQTY,CreateTime ");
        strSql.Append(" FROM [tbl_Seckill] ");
        strSql.Append(" where ID=@ID ");
        SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
        parameters[0].Value = ID;

        DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
        if (ds.Tables[0].Rows.Count > 0)
        {
            if (ds.Tables[0].Rows[0]["ID"].ToString() != "")
            {
                this.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
            }
            if (ds.Tables[0].Rows[0]["StartTime"].ToString() != "")
            {
                this.StartTime = DateTime.Parse(ds.Tables[0].Rows[0]["StartTime"].ToString());
            }
            if (ds.Tables[0].Rows[0]["EndTime"].ToString() != "")
            {
                this.EndTime = DateTime.Parse(ds.Tables[0].Rows[0]["EndTime"].ToString());
            }
            if (ds.Tables[0].Rows[0]["Status"].ToString() != "")
            {
                this.Status = int.Parse(ds.Tables[0].Rows[0]["Status"].ToString());
            }
            if (ds.Tables[0].Rows[0]["Name"] != null)
            {
                this.Name = ds.Tables[0].Rows[0]["Name"].ToString();
            }
            if (ds.Tables[0].Rows[0]["ProductID"].ToString() != "")
            {
                this.ProductID = int.Parse(ds.Tables[0].Rows[0]["ProductID"].ToString());
            }
            if (ds.Tables[0].Rows[0]["LimitQTY"].ToString() != "")
            {
                this.LimitQTY = int.Parse(ds.Tables[0].Rows[0]["LimitQTY"].ToString());
            }
            if (ds.Tables[0].Rows[0]["SaleQTY"].ToString() != "")
            {
                this.SaleQTY = int.Parse(ds.Tables[0].Rows[0]["SaleQTY"].ToString());
            }
            if (ds.Tables[0].Rows[0]["CreateTime"].ToString() != "")
            {
                this.CreateTime = DateTime.Parse(ds.Tables[0].Rows[0]["CreateTime"].ToString());
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
        strSql.Append(" FROM [tbl_Seckill] ");
        if (strWhere.Trim() != "")
        {
            strSql.Append(" where " + strWhere);
        }
        return DbHelperSQL.Query(strSql.ToString());
    }

    public DataSet GetList(int pageSize, int pageIndex, string strWhere, string filedOrder, out int recordCount)
    {
        StringBuilder strSql = new StringBuilder();
        strSql.Append("SELECT * from View_KillProduct");
        if (strWhere.Trim() != "")
        {
            strSql.Append(" where " + strWhere);
        }
        recordCount = Convert.ToInt32(DbHelperSQL.GetSingle(PagingHelper.CreateCountingSql(strSql.ToString())));
        return DbHelperSQL.Query(PagingHelper.CreatePagingSql(recordCount, pageSize, pageIndex, strSql.ToString(), filedOrder));
    }

    #endregion  Method
}