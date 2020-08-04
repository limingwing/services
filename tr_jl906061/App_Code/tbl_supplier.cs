using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// 类tbl_supplier。
/// </summary>
[Serializable]
public partial class tbl_supplier
{
    public tbl_supplier()
    { }
    #region Model
    private int _id;
    private string _huiyuan_id;
    private string _supplyname;
    private string _supplyaddress;
    private string _supplierprofile;
    private string _businessno;
    private string _idcard;
    private string _legalname;
    private string _legalphone;
    private string _email;
    private DateTime? _applytime;
    private string _category;
    private string _bankname;
    private string _bankno;
    private string _bankaddress;
    private string _supplyimg;
    /// <summary>
    /// 主键
    /// </summary>
    public int Id
    {
        set { _id = value; }
        get { return _id; }
    }
    /// <summary>
    /// 会员id
    /// </summary>
    public string huiyuan_id
    {
        set { _huiyuan_id = value; }
        get { return _huiyuan_id; }
    }
    /// <summary>
    /// 公司名称
    /// </summary>
    public string supplyName
    {
        set { _supplyname = value; }
        get { return _supplyname; }
    }
    /// <summary>
    /// 公司地址
    /// </summary>
    public string supplyAddress
    {
        set { _supplyaddress = value; }
        get { return _supplyaddress; }
    }
    /// <summary>
    /// 公司简介
    /// </summary>
    public string supplierProfile
    {
        set { _supplierprofile = value; }
        get { return _supplierprofile; }
    }
    /// <summary>
    /// 营业执照注册号
    /// </summary>
    public string businessNO
    {
        set { _businessno = value; }
        get { return _businessno; }
    }
    /// <summary>
    /// 法人身份证
    /// </summary>
    public string idCard
    {
        set { _idcard = value; }
        get { return _idcard; }
    }
    /// <summary>
    /// 法人名称
    /// </summary>
    public string legalName
    {
        set { _legalname = value; }
        get { return _legalname; }
    }
    /// <summary>
    /// 法人联系号码
    /// </summary>
    public string legalPhone
    {
        set { _legalphone = value; }
        get { return _legalphone; }
    }
    /// <summary>
    /// 邮箱
    /// </summary>
    public string email
    {
        set { _email = value; }
        get { return _email; }
    }
    /// <summary>
    /// 申请时间
    /// </summary>
    public DateTime? ApplyTime
    {
        set { _applytime = value; }
        get { return _applytime; }
    }
    /// <summary>
    /// 行业类别
    /// </summary>
    public string Category
    {
        set { _category = value; }
        get { return _category; }
    }
    /// <summary>
    /// 银行名称
    /// </summary>
    public string BankName
    {
        set { _bankname = value; }
        get { return _bankname; }
    }
    /// <summary>
    /// 银行卡号
    /// </summary>
    public string BankNo
    {
        set { _bankno = value; }
        get { return _bankno; }
    }
    /// <summary>
    /// 开户银行地址
    /// </summary>
    public string BankAddress
    {
        set { _bankaddress = value; }
        get { return _bankaddress; }
    }
    /// <summary>
    /// 店面照片
    /// </summary>
    public string SupplyImg
    {
        set { _supplyimg = value; }
        get { return _supplyimg; }
    }
    #endregion Model


    #region  Method

    /// <summary>
    /// 得到一个对象实体
    /// </summary>
    public tbl_supplier(int Id)
    {
        StringBuilder strSql = new StringBuilder();
        strSql.Append("select Id,huiyuan_id,supplyName,supplyAddress,supplierProfile,businessNO,idCard,legalName,legalPhone,email,ApplyTime,Category,BankName,BankNo,BankAddress,SupplyImg ");
        strSql.Append(" FROM [tbl_supplier] ");
        strSql.Append(" where Id=@Id ");
        SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)};
        parameters[0].Value = Id;

        DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
        if (ds.Tables[0].Rows.Count > 0)
        {
            if (ds.Tables[0].Rows[0]["Id"].ToString() != "")
            {
                this.Id = int.Parse(ds.Tables[0].Rows[0]["Id"].ToString());
            }
            if (ds.Tables[0].Rows[0]["huiyuan_id"] != null)
            {
                this.huiyuan_id = ds.Tables[0].Rows[0]["huiyuan_id"].ToString();
            }
            if (ds.Tables[0].Rows[0]["supplyName"] != null)
            {
                this.supplyName = ds.Tables[0].Rows[0]["supplyName"].ToString();
            }
            if (ds.Tables[0].Rows[0]["supplyAddress"] != null)
            {
                this.supplyAddress = ds.Tables[0].Rows[0]["supplyAddress"].ToString();
            }
            if (ds.Tables[0].Rows[0]["supplierProfile"] != null)
            {
                this.supplierProfile = ds.Tables[0].Rows[0]["supplierProfile"].ToString();
            }
            if (ds.Tables[0].Rows[0]["businessNO"] != null)
            {
                this.businessNO = ds.Tables[0].Rows[0]["businessNO"].ToString();
            }
            if (ds.Tables[0].Rows[0]["idCard"] != null)
            {
                this.idCard = ds.Tables[0].Rows[0]["idCard"].ToString();
            }
            if (ds.Tables[0].Rows[0]["legalName"] != null)
            {
                this.legalName = ds.Tables[0].Rows[0]["legalName"].ToString();
            }
            if (ds.Tables[0].Rows[0]["legalPhone"] != null)
            {
                this.legalPhone = ds.Tables[0].Rows[0]["legalPhone"].ToString();
            }
            if (ds.Tables[0].Rows[0]["email"] != null)
            {
                this.email = ds.Tables[0].Rows[0]["email"].ToString();
            }
            if (ds.Tables[0].Rows[0]["ApplyTime"].ToString() != "")
            {
                this.ApplyTime = DateTime.Parse(ds.Tables[0].Rows[0]["ApplyTime"].ToString());
            }
            if (ds.Tables[0].Rows[0]["Category"] != null)
            {
                this.Category = ds.Tables[0].Rows[0]["Category"].ToString();
            }
            if (ds.Tables[0].Rows[0]["BankName"] != null)
            {
                this.BankName = ds.Tables[0].Rows[0]["BankName"].ToString();
            }
            if (ds.Tables[0].Rows[0]["BankNo"] != null)
            {
                this.BankNo = ds.Tables[0].Rows[0]["BankNo"].ToString();
            }
            if (ds.Tables[0].Rows[0]["BankAddress"] != null)
            {
                this.BankAddress = ds.Tables[0].Rows[0]["BankAddress"].ToString();
            }
            if (ds.Tables[0].Rows[0]["SupplyImg"] != null)
            {
                this.SupplyImg = ds.Tables[0].Rows[0]["SupplyImg"].ToString();
            }
        }
    }
    /// <summary>
    /// 是否存在该记录
    /// </summary>
    public bool Exists(int Id)
    {
        StringBuilder strSql = new StringBuilder();
        strSql.Append("select count(1) from [tbl_supplier]");
        strSql.Append(" where Id=@Id ");

        SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)};
        parameters[0].Value = Id;

        return DbHelperSQL.Exists(strSql.ToString(), parameters);
    }


    /// <summary>
    /// 增加一条数据
    /// </summary>
    public int Add()
    {
        StringBuilder strSql = new StringBuilder();
        strSql.Append("insert into [tbl_supplier] (");
        strSql.Append("huiyuan_id,supplyName,supplyAddress,supplierProfile,businessNO,idCard,legalName,legalPhone,email,ApplyTime,Category,BankName,BankNo,BankAddress,SupplyImg)");
        strSql.Append(" values (");
        strSql.Append("@huiyuan_id,@supplyName,@supplyAddress,@supplierProfile,@businessNO,@idCard,@legalName,@legalPhone,@email,@ApplyTime,@Category,@BankName,@BankNo,@BankAddress,@SupplyImg)");
        strSql.Append(";select @@IDENTITY");
        SqlParameter[] parameters = {
					new SqlParameter("@huiyuan_id", SqlDbType.NVarChar,50),
					new SqlParameter("@supplyName", SqlDbType.NVarChar,50),
					new SqlParameter("@supplyAddress", SqlDbType.NVarChar,200),
					new SqlParameter("@supplierProfile", SqlDbType.NVarChar,2000),
					new SqlParameter("@businessNO", SqlDbType.VarChar,50),
					new SqlParameter("@idCard", SqlDbType.VarChar,20),
					new SqlParameter("@legalName", SqlDbType.NVarChar,50),
					new SqlParameter("@legalPhone", SqlDbType.VarChar,13),
					new SqlParameter("@email", SqlDbType.VarChar,50),
					new SqlParameter("@ApplyTime", SqlDbType.DateTime),
					new SqlParameter("@Category", SqlDbType.NVarChar,50),
					new SqlParameter("@BankName", SqlDbType.NVarChar,50),
					new SqlParameter("@BankNo", SqlDbType.VarChar,50),
					new SqlParameter("@BankAddress", SqlDbType.NVarChar,200),
					new SqlParameter("@SupplyImg", SqlDbType.VarChar,50)};
        parameters[0].Value = huiyuan_id;
        parameters[1].Value = supplyName;
        parameters[2].Value = supplyAddress;
        parameters[3].Value = supplierProfile;
        parameters[4].Value = businessNO;
        parameters[5].Value = idCard;
        parameters[6].Value = legalName;
        parameters[7].Value = legalPhone;
        parameters[8].Value = email;
        parameters[9].Value = ApplyTime;
        parameters[10].Value = Category;
        parameters[11].Value = BankName;
        parameters[12].Value = BankNo;
        parameters[13].Value = BankAddress;
        parameters[14].Value = SupplyImg;

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
        strSql.Append("update [tbl_supplier] set ");
        strSql.Append("huiyuan_id=@huiyuan_id,");
        strSql.Append("supplyName=@supplyName,");
        strSql.Append("supplyAddress=@supplyAddress,");
        strSql.Append("supplierProfile=@supplierProfile,");
        strSql.Append("businessNO=@businessNO,");
        strSql.Append("idCard=@idCard,");
        strSql.Append("legalName=@legalName,");
        strSql.Append("legalPhone=@legalPhone,");
        strSql.Append("email=@email,");
        strSql.Append("ApplyTime=@ApplyTime,");
        strSql.Append("Category=@Category,");
        strSql.Append("BankName=@BankName,");
        strSql.Append("BankNo=@BankNo,");
        strSql.Append("BankAddress=@BankAddress,");
        strSql.Append("SupplyImg=@SupplyImg");
        strSql.Append(" where Id=@Id ");
        SqlParameter[] parameters = {
					new SqlParameter("@huiyuan_id", SqlDbType.NVarChar,50),
					new SqlParameter("@supplyName", SqlDbType.NVarChar,50),
					new SqlParameter("@supplyAddress", SqlDbType.NVarChar,200),
					new SqlParameter("@supplierProfile", SqlDbType.NVarChar,2000),
					new SqlParameter("@businessNO", SqlDbType.VarChar,50),
					new SqlParameter("@idCard", SqlDbType.VarChar,20),
					new SqlParameter("@legalName", SqlDbType.NVarChar,50),
					new SqlParameter("@legalPhone", SqlDbType.VarChar,13),
					new SqlParameter("@email", SqlDbType.VarChar,50),
					new SqlParameter("@ApplyTime", SqlDbType.DateTime),
					new SqlParameter("@Category", SqlDbType.NVarChar,50),
					new SqlParameter("@BankName", SqlDbType.NVarChar,50),
					new SqlParameter("@BankNo", SqlDbType.VarChar,50),
					new SqlParameter("@BankAddress", SqlDbType.NVarChar,200),
					new SqlParameter("@SupplyImg", SqlDbType.VarChar,50),
					new SqlParameter("@Id", SqlDbType.Int,4)};
        parameters[0].Value = huiyuan_id;
        parameters[1].Value = supplyName;
        parameters[2].Value = supplyAddress;
        parameters[3].Value = supplierProfile;
        parameters[4].Value = businessNO;
        parameters[5].Value = idCard;
        parameters[6].Value = legalName;
        parameters[7].Value = legalPhone;
        parameters[8].Value = email;
        parameters[9].Value = ApplyTime;
        parameters[10].Value = Category;
        parameters[11].Value = BankName;
        parameters[12].Value = BankNo;
        parameters[13].Value = BankAddress;
        parameters[14].Value = SupplyImg;
        parameters[15].Value = Id;

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
    public bool Delete(int Id)
    {
        StringBuilder strSql = new StringBuilder();
        strSql.Append("delete from [tbl_supplier] ");
        strSql.Append(" where Id=@Id ");
        SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)};
        parameters[0].Value = Id;

        int rows=DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
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
    public void GetModel(int Id)
    {
        StringBuilder strSql = new StringBuilder();
        strSql.Append("select  top 1 Id,huiyuan_id,supplyName,supplyAddress,supplierProfile,businessNO,idCard,legalName,legalPhone,email,ApplyTime,Category,BankName,BankNo,BankAddress,SupplyImg ");
        strSql.Append(" FROM [tbl_supplier] ");
        strSql.Append(" where Id=@Id ");
        SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)};
        parameters[0].Value = Id;

        DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
        if (ds.Tables[0].Rows.Count > 0)
        {
            if (ds.Tables[0].Rows[0]["Id"].ToString() != "")
            {
                this.Id = int.Parse(ds.Tables[0].Rows[0]["Id"].ToString());
            }
            if (ds.Tables[0].Rows[0]["huiyuan_id"] != null)
            {
                this.huiyuan_id = ds.Tables[0].Rows[0]["huiyuan_id"].ToString();
            }
            if (ds.Tables[0].Rows[0]["supplyName"] != null)
            {
                this.supplyName = ds.Tables[0].Rows[0]["supplyName"].ToString();
            }
            if (ds.Tables[0].Rows[0]["supplyAddress"] != null)
            {
                this.supplyAddress = ds.Tables[0].Rows[0]["supplyAddress"].ToString();
            }
            if (ds.Tables[0].Rows[0]["supplierProfile"] != null)
            {
                this.supplierProfile = ds.Tables[0].Rows[0]["supplierProfile"].ToString();
            }
            if (ds.Tables[0].Rows[0]["businessNO"] != null)
            {
                this.businessNO = ds.Tables[0].Rows[0]["businessNO"].ToString();
            }
            if (ds.Tables[0].Rows[0]["idCard"] != null)
            {
                this.idCard = ds.Tables[0].Rows[0]["idCard"].ToString();
            }
            if (ds.Tables[0].Rows[0]["legalName"] != null)
            {
                this.legalName = ds.Tables[0].Rows[0]["legalName"].ToString();
            }
            if (ds.Tables[0].Rows[0]["legalPhone"] != null)
            {
                this.legalPhone = ds.Tables[0].Rows[0]["legalPhone"].ToString();
            }
            if (ds.Tables[0].Rows[0]["email"] != null)
            {
                this.email = ds.Tables[0].Rows[0]["email"].ToString();
            }
            if (ds.Tables[0].Rows[0]["ApplyTime"].ToString() != "")
            {
                this.ApplyTime = DateTime.Parse(ds.Tables[0].Rows[0]["ApplyTime"].ToString());
            }
            if (ds.Tables[0].Rows[0]["Category"] != null)
            {
                this.Category = ds.Tables[0].Rows[0]["Category"].ToString();
            }
            if (ds.Tables[0].Rows[0]["BankName"] != null)
            {
                this.BankName = ds.Tables[0].Rows[0]["BankName"].ToString();
            }
            if (ds.Tables[0].Rows[0]["BankNo"] != null)
            {
                this.BankNo = ds.Tables[0].Rows[0]["BankNo"].ToString();
            }
            if (ds.Tables[0].Rows[0]["BankAddress"] != null)
            {
                this.BankAddress = ds.Tables[0].Rows[0]["BankAddress"].ToString();
            }
            if (ds.Tables[0].Rows[0]["SupplyImg"] != null)
            {
                this.SupplyImg = ds.Tables[0].Rows[0]["SupplyImg"].ToString();
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
        strSql.Append(" FROM [tbl_supplier] ");
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
        strSql.Append("select * FROM View_supplier");
        if (strWhere.Trim() != "")
        {
            strSql.Append(" where " + strWhere);
        }
        recordCount = Convert.ToInt32(DbHelperSQL.GetSingle(PagingHelper.CreateCountingSql(strSql.ToString())));
        return DbHelperSQL.Query(PagingHelper.CreatePagingSql(recordCount, pageSize, pageIndex, strSql.ToString(), filedOrder));
    }

    #endregion  Method
}