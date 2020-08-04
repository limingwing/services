using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;

/// <summary>
/// 类view_shangshu2。
/// </summary>
[Serializable]
public partial class view_shangshu2
{
    public view_shangshu2()
    { }
    #region Model
    private string _huiyuan_shang_id;
    private int? _huiyuan_xuhao;
    private string _huiyuan_id;
    private int? _huiyuan_jiebie;
    private int? _net_hege;
    private int? _shang_jiebie;
    private int? _shang_hege;
    private int? _shang_flag;
    private int? _net_flag;
    private int? _shang_tuijian_count;
    private int? _account_type;
    private int? _huiyuan_jiebie1;
    private int? _shang_jiebie1;
    private int? _tuijian_count;
    private int? _huiyuan_zhuanmai;
    private int? _zhuanmai_jb;
    private int? _xia_zm_jb;
    private int? _flag_3;
    private string _huiyuan_bianhao;
    private string _huiyuan_name;
    private DateTime? _huiyuan_add_time;
    /// <summary>
    /// 
    /// </summary>
    public string huiyuan_shang_id
    {
        set { _huiyuan_shang_id = value; }
        get { return _huiyuan_shang_id; }
    }
    /// <summary>
    /// 
    /// </summary>
    public int? huiyuan_xuhao
    {
        set { _huiyuan_xuhao = value; }
        get { return _huiyuan_xuhao; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string huiyuan_id
    {
        set { _huiyuan_id = value; }
        get { return _huiyuan_id; }
    }
    /// <summary>
    /// 
    /// </summary>
    public int? huiyuan_jiebie
    {
        set { _huiyuan_jiebie = value; }
        get { return _huiyuan_jiebie; }
    }
    /// <summary>
    /// 
    /// </summary>
    public int? net_hege
    {
        set { _net_hege = value; }
        get { return _net_hege; }
    }
    /// <summary>
    /// 
    /// </summary>
    public int? shang_jiebie
    {
        set { _shang_jiebie = value; }
        get { return _shang_jiebie; }
    }
    /// <summary>
    /// 
    /// </summary>
    public int? shang_hege
    {
        set { _shang_hege = value; }
        get { return _shang_hege; }
    }
    /// <summary>
    /// 
    /// </summary>
    public int? shang_flag
    {
        set { _shang_flag = value; }
        get { return _shang_flag; }
    }
    /// <summary>
    /// 
    /// </summary>
    public int? net_flag
    {
        set { _net_flag = value; }
        get { return _net_flag; }
    }
    /// <summary>
    /// 
    /// </summary>
    public int? shang_tuijian_count
    {
        set { _shang_tuijian_count = value; }
        get { return _shang_tuijian_count; }
    }
    /// <summary>
    /// 
    /// </summary>
    public int? account_type
    {
        set { _account_type = value; }
        get { return _account_type; }
    }
    /// <summary>
    /// 
    /// </summary>
    public int? huiyuan_jiebie1
    {
        set { _huiyuan_jiebie1 = value; }
        get { return _huiyuan_jiebie1; }
    }
    /// <summary>
    /// 
    /// </summary>
    public int? shang_jiebie1
    {
        set { _shang_jiebie1 = value; }
        get { return _shang_jiebie1; }
    }
    /// <summary>
    /// 
    /// </summary>
    public int? tuijian_count
    {
        set { _tuijian_count = value; }
        get { return _tuijian_count; }
    }
    /// <summary>
    /// 
    /// </summary>
    public int? huiyuan_zhuanmai
    {
        set { _huiyuan_zhuanmai = value; }
        get { return _huiyuan_zhuanmai; }
    }
    /// <summary>
    /// 
    /// </summary>
    public int? zhuanmai_jb
    {
        set { _zhuanmai_jb = value; }
        get { return _zhuanmai_jb; }
    }
    /// <summary>
    /// 
    /// </summary>
    public int? xia_zm_jb
    {
        set { _xia_zm_jb = value; }
        get { return _xia_zm_jb; }
    }
    /// <summary>
    /// 
    /// </summary>
    public int? flag_3
    {
        set { _flag_3 = value; }
        get { return _flag_3; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string huiyuan_bianhao
    {
        set { _huiyuan_bianhao = value; }
        get { return _huiyuan_bianhao; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string huiyuan_name
    {
        set { _huiyuan_name = value; }
        get { return _huiyuan_name; }
    }
    /// <summary>
    /// 
    /// </summary>
    public DateTime? huiyuan_add_time
    {
        set { _huiyuan_add_time = value; }
        get { return _huiyuan_add_time; }
    }
    #endregion Model


    #region  Method

    /// <summary>
    /// 得到一个对象实体
    /// </summary>
    public view_shangshu2(string huiyuan_shang_id, int huiyuan_xuhao, string huiyuan_id, int huiyuan_jiebie, int net_hege, int shang_jiebie, int shang_hege, int shang_flag, int net_flag, int shang_tuijian_count, int account_type, int huiyuan_jiebie1, int shang_jiebie1, int tuijian_count, int huiyuan_zhuanmai, int zhuanmai_jb, int xia_zm_jb, int flag_3, string huiyuan_bianhao, string huiyuan_name, DateTime huiyuan_add_time)
    {
        StringBuilder strSql = new StringBuilder();
        strSql.Append("select huiyuan_shang_id,huiyuan_xuhao,huiyuan_id,huiyuan_jiebie,net_hege,shang_jiebie,shang_hege,shang_flag,net_flag,shang_tuijian_count,account_type,huiyuan_jiebie1,shang_jiebie1,tuijian_count,huiyuan_zhuanmai,zhuanmai_jb,xia_zm_jb,flag_3,huiyuan_bianhao,huiyuan_name,huiyuan_add_time ");
        strSql.Append(" FROM [view_shangshu2] ");
        strSql.Append(" where huiyuan_shang_id=@huiyuan_shang_id and huiyuan_xuhao=@huiyuan_xuhao and huiyuan_id=@huiyuan_id and huiyuan_jiebie=@huiyuan_jiebie and net_hege=@net_hege and shang_jiebie=@shang_jiebie and shang_hege=@shang_hege and shang_flag=@shang_flag and net_flag=@net_flag and shang_tuijian_count=@shang_tuijian_count and account_type=@account_type and huiyuan_jiebie1=@huiyuan_jiebie1 and shang_jiebie1=@shang_jiebie1 and tuijian_count=@tuijian_count and huiyuan_zhuanmai=@huiyuan_zhuanmai and zhuanmai_jb=@zhuanmai_jb and xia_zm_jb=@xia_zm_jb and flag_3=@flag_3 and huiyuan_bianhao=@huiyuan_bianhao and huiyuan_name=@huiyuan_name and huiyuan_add_time=@huiyuan_add_time ");
        SqlParameter[] parameters = {
					new SqlParameter("@huiyuan_shang_id", SqlDbType.Char,10),
					new SqlParameter("@huiyuan_xuhao", SqlDbType.Int,4),
					new SqlParameter("@huiyuan_id", SqlDbType.Char,10),
					new SqlParameter("@huiyuan_jiebie", SqlDbType.Int,4),
					new SqlParameter("@net_hege", SqlDbType.Int,4),
					new SqlParameter("@shang_jiebie", SqlDbType.Int,4),
					new SqlParameter("@shang_hege", SqlDbType.Int,4),
					new SqlParameter("@shang_flag", SqlDbType.Int,4),
					new SqlParameter("@net_flag", SqlDbType.Int,4),
					new SqlParameter("@shang_tuijian_count", SqlDbType.Int,4),
					new SqlParameter("@account_type", SqlDbType.Int,4),
					new SqlParameter("@huiyuan_jiebie1", SqlDbType.Int,4),
					new SqlParameter("@shang_jiebie1", SqlDbType.Int,4),
					new SqlParameter("@tuijian_count", SqlDbType.Int,4),
					new SqlParameter("@huiyuan_zhuanmai", SqlDbType.Int,4),
					new SqlParameter("@zhuanmai_jb", SqlDbType.Int,4),
					new SqlParameter("@xia_zm_jb", SqlDbType.Int,4),
					new SqlParameter("@flag_3", SqlDbType.Int,4),
					new SqlParameter("@huiyuan_bianhao", SqlDbType.NVarChar,-1),
					new SqlParameter("@huiyuan_name", SqlDbType.NVarChar,-1),
					new SqlParameter("@huiyuan_add_time", SqlDbType.DateTime)};
        parameters[0].Value = huiyuan_shang_id;
        parameters[1].Value = huiyuan_xuhao;
        parameters[2].Value = huiyuan_id;
        parameters[3].Value = huiyuan_jiebie;
        parameters[4].Value = net_hege;
        parameters[5].Value = shang_jiebie;
        parameters[6].Value = shang_hege;
        parameters[7].Value = shang_flag;
        parameters[8].Value = net_flag;
        parameters[9].Value = shang_tuijian_count;
        parameters[10].Value = account_type;
        parameters[11].Value = huiyuan_jiebie1;
        parameters[12].Value = shang_jiebie1;
        parameters[13].Value = tuijian_count;
        parameters[14].Value = huiyuan_zhuanmai;
        parameters[15].Value = zhuanmai_jb;
        parameters[16].Value = xia_zm_jb;
        parameters[17].Value = flag_3;
        parameters[18].Value = huiyuan_bianhao;
        parameters[19].Value = huiyuan_name;
        parameters[20].Value = huiyuan_add_time;

        DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
        if (ds.Tables[0].Rows.Count > 0)
        {
            if (ds.Tables[0].Rows[0]["huiyuan_shang_id"] != null)
            {
                this.huiyuan_shang_id = ds.Tables[0].Rows[0]["huiyuan_shang_id"].ToString();
            }
            if (ds.Tables[0].Rows[0]["huiyuan_xuhao"] != null && ds.Tables[0].Rows[0]["huiyuan_xuhao"].ToString() != "")
            {
                this.huiyuan_xuhao = int.Parse(ds.Tables[0].Rows[0]["huiyuan_xuhao"].ToString());
            }
            if (ds.Tables[0].Rows[0]["huiyuan_id"] != null)
            {
                this.huiyuan_id = ds.Tables[0].Rows[0]["huiyuan_id"].ToString();
            }
            if (ds.Tables[0].Rows[0]["huiyuan_jiebie"] != null && ds.Tables[0].Rows[0]["huiyuan_jiebie"].ToString() != "")
            {
                this.huiyuan_jiebie = int.Parse(ds.Tables[0].Rows[0]["huiyuan_jiebie"].ToString());
            }
            if (ds.Tables[0].Rows[0]["net_hege"] != null && ds.Tables[0].Rows[0]["net_hege"].ToString() != "")
            {
                this.net_hege = int.Parse(ds.Tables[0].Rows[0]["net_hege"].ToString());
            }
            if (ds.Tables[0].Rows[0]["shang_jiebie"] != null && ds.Tables[0].Rows[0]["shang_jiebie"].ToString() != "")
            {
                this.shang_jiebie = int.Parse(ds.Tables[0].Rows[0]["shang_jiebie"].ToString());
            }
            if (ds.Tables[0].Rows[0]["shang_hege"] != null && ds.Tables[0].Rows[0]["shang_hege"].ToString() != "")
            {
                this.shang_hege = int.Parse(ds.Tables[0].Rows[0]["shang_hege"].ToString());
            }
            if (ds.Tables[0].Rows[0]["shang_flag"] != null && ds.Tables[0].Rows[0]["shang_flag"].ToString() != "")
            {
                this.shang_flag = int.Parse(ds.Tables[0].Rows[0]["shang_flag"].ToString());
            }
            if (ds.Tables[0].Rows[0]["net_flag"] != null && ds.Tables[0].Rows[0]["net_flag"].ToString() != "")
            {
                this.net_flag = int.Parse(ds.Tables[0].Rows[0]["net_flag"].ToString());
            }
            if (ds.Tables[0].Rows[0]["shang_tuijian_count"] != null && ds.Tables[0].Rows[0]["shang_tuijian_count"].ToString() != "")
            {
                this.shang_tuijian_count = int.Parse(ds.Tables[0].Rows[0]["shang_tuijian_count"].ToString());
            }
            if (ds.Tables[0].Rows[0]["account_type"] != null && ds.Tables[0].Rows[0]["account_type"].ToString() != "")
            {
                this.account_type = int.Parse(ds.Tables[0].Rows[0]["account_type"].ToString());
            }
            if (ds.Tables[0].Rows[0]["huiyuan_jiebie1"] != null && ds.Tables[0].Rows[0]["huiyuan_jiebie1"].ToString() != "")
            {
                this.huiyuan_jiebie1 = int.Parse(ds.Tables[0].Rows[0]["huiyuan_jiebie1"].ToString());
            }
            if (ds.Tables[0].Rows[0]["shang_jiebie1"] != null && ds.Tables[0].Rows[0]["shang_jiebie1"].ToString() != "")
            {
                this.shang_jiebie1 = int.Parse(ds.Tables[0].Rows[0]["shang_jiebie1"].ToString());
            }
            if (ds.Tables[0].Rows[0]["tuijian_count"] != null && ds.Tables[0].Rows[0]["tuijian_count"].ToString() != "")
            {
                this.tuijian_count = int.Parse(ds.Tables[0].Rows[0]["tuijian_count"].ToString());
            }
            if (ds.Tables[0].Rows[0]["huiyuan_zhuanmai"] != null && ds.Tables[0].Rows[0]["huiyuan_zhuanmai"].ToString() != "")
            {
                this.huiyuan_zhuanmai = int.Parse(ds.Tables[0].Rows[0]["huiyuan_zhuanmai"].ToString());
            }
            if (ds.Tables[0].Rows[0]["zhuanmai_jb"] != null && ds.Tables[0].Rows[0]["zhuanmai_jb"].ToString() != "")
            {
                this.zhuanmai_jb = int.Parse(ds.Tables[0].Rows[0]["zhuanmai_jb"].ToString());
            }
            if (ds.Tables[0].Rows[0]["xia_zm_jb"] != null && ds.Tables[0].Rows[0]["xia_zm_jb"].ToString() != "")
            {
                this.xia_zm_jb = int.Parse(ds.Tables[0].Rows[0]["xia_zm_jb"].ToString());
            }
            if (ds.Tables[0].Rows[0]["flag_3"] != null && ds.Tables[0].Rows[0]["flag_3"].ToString() != "")
            {
                this.flag_3 = int.Parse(ds.Tables[0].Rows[0]["flag_3"].ToString());
            }
            if (ds.Tables[0].Rows[0]["huiyuan_bianhao"] != null)
            {
                this.huiyuan_bianhao = ds.Tables[0].Rows[0]["huiyuan_bianhao"].ToString();
            }
            if (ds.Tables[0].Rows[0]["huiyuan_name"] != null)
            {
                this.huiyuan_name = ds.Tables[0].Rows[0]["huiyuan_name"].ToString();
            }
            if (ds.Tables[0].Rows[0]["huiyuan_add_time"] != null && ds.Tables[0].Rows[0]["huiyuan_add_time"].ToString() != "")
            {
                this.huiyuan_add_time = DateTime.Parse(ds.Tables[0].Rows[0]["huiyuan_add_time"].ToString());
            }
        }
    }

    /// <summary>
    /// 是否存在该记录
    /// </summary>
    public bool Exists(string huiyuan_shang_id, int huiyuan_xuhao, string huiyuan_id, int huiyuan_jiebie, int net_hege, int shang_jiebie, int shang_hege, int shang_flag, int net_flag, int shang_tuijian_count, int account_type, int huiyuan_jiebie1, int shang_jiebie1, int tuijian_count, int huiyuan_zhuanmai, int zhuanmai_jb, int xia_zm_jb, int flag_3, string huiyuan_bianhao, string huiyuan_name, DateTime huiyuan_add_time)
    {
        StringBuilder strSql = new StringBuilder();
        strSql.Append("select count(1) from [view_shangshu2]");
        strSql.Append(" where huiyuan_shang_id=@huiyuan_shang_id and huiyuan_xuhao=@huiyuan_xuhao and huiyuan_id=@huiyuan_id and huiyuan_jiebie=@huiyuan_jiebie and net_hege=@net_hege and shang_jiebie=@shang_jiebie and shang_hege=@shang_hege and shang_flag=@shang_flag and net_flag=@net_flag and shang_tuijian_count=@shang_tuijian_count and account_type=@account_type and huiyuan_jiebie1=@huiyuan_jiebie1 and shang_jiebie1=@shang_jiebie1 and tuijian_count=@tuijian_count and huiyuan_zhuanmai=@huiyuan_zhuanmai and zhuanmai_jb=@zhuanmai_jb and xia_zm_jb=@xia_zm_jb and flag_3=@flag_3 and huiyuan_bianhao=@huiyuan_bianhao and huiyuan_name=@huiyuan_name and huiyuan_add_time=@huiyuan_add_time ");

        SqlParameter[] parameters = {
					new SqlParameter("@huiyuan_shang_id", SqlDbType.Char,10),
					new SqlParameter("@huiyuan_xuhao", SqlDbType.Int,4),
					new SqlParameter("@huiyuan_id", SqlDbType.Char,10),
					new SqlParameter("@huiyuan_jiebie", SqlDbType.Int,4),
					new SqlParameter("@net_hege", SqlDbType.Int,4),
					new SqlParameter("@shang_jiebie", SqlDbType.Int,4),
					new SqlParameter("@shang_hege", SqlDbType.Int,4),
					new SqlParameter("@shang_flag", SqlDbType.Int,4),
					new SqlParameter("@net_flag", SqlDbType.Int,4),
					new SqlParameter("@shang_tuijian_count", SqlDbType.Int,4),
					new SqlParameter("@account_type", SqlDbType.Int,4),
					new SqlParameter("@huiyuan_jiebie1", SqlDbType.Int,4),
					new SqlParameter("@shang_jiebie1", SqlDbType.Int,4),
					new SqlParameter("@tuijian_count", SqlDbType.Int,4),
					new SqlParameter("@huiyuan_zhuanmai", SqlDbType.Int,4),
					new SqlParameter("@zhuanmai_jb", SqlDbType.Int,4),
					new SqlParameter("@xia_zm_jb", SqlDbType.Int,4),
					new SqlParameter("@flag_3", SqlDbType.Int,4),
					new SqlParameter("@huiyuan_bianhao", SqlDbType.NVarChar,-1),
					new SqlParameter("@huiyuan_name", SqlDbType.NVarChar,-1),
					new SqlParameter("@huiyuan_add_time", SqlDbType.DateTime)};
        parameters[0].Value = huiyuan_shang_id;
        parameters[1].Value = huiyuan_xuhao;
        parameters[2].Value = huiyuan_id;
        parameters[3].Value = huiyuan_jiebie;
        parameters[4].Value = net_hege;
        parameters[5].Value = shang_jiebie;
        parameters[6].Value = shang_hege;
        parameters[7].Value = shang_flag;
        parameters[8].Value = net_flag;
        parameters[9].Value = shang_tuijian_count;
        parameters[10].Value = account_type;
        parameters[11].Value = huiyuan_jiebie1;
        parameters[12].Value = shang_jiebie1;
        parameters[13].Value = tuijian_count;
        parameters[14].Value = huiyuan_zhuanmai;
        parameters[15].Value = zhuanmai_jb;
        parameters[16].Value = xia_zm_jb;
        parameters[17].Value = flag_3;
        parameters[18].Value = huiyuan_bianhao;
        parameters[19].Value = huiyuan_name;
        parameters[20].Value = huiyuan_add_time;

        return DbHelperSQL.Exists(strSql.ToString(), parameters);
    }


    /// <summary>
    /// 增加一条数据
    /// </summary>
    public void Add()
    {
        StringBuilder strSql = new StringBuilder();
        strSql.Append("insert into [view_shangshu2] (");
        strSql.Append("huiyuan_shang_id,huiyuan_xuhao,huiyuan_id,huiyuan_jiebie,net_hege,shang_jiebie,shang_hege,shang_flag,net_flag,shang_tuijian_count,account_type,huiyuan_jiebie1,shang_jiebie1,tuijian_count,huiyuan_zhuanmai,zhuanmai_jb,xia_zm_jb,flag_3,huiyuan_bianhao,huiyuan_name,huiyuan_add_time)");
        strSql.Append(" values (");
        strSql.Append("@huiyuan_shang_id,@huiyuan_xuhao,@huiyuan_id,@huiyuan_jiebie,@net_hege,@shang_jiebie,@shang_hege,@shang_flag,@net_flag,@shang_tuijian_count,@account_type,@huiyuan_jiebie1,@shang_jiebie1,@tuijian_count,@huiyuan_zhuanmai,@zhuanmai_jb,@xia_zm_jb,@flag_3,@huiyuan_bianhao,@huiyuan_name,@huiyuan_add_time)");
        SqlParameter[] parameters = {
					new SqlParameter("@huiyuan_shang_id", SqlDbType.Char,9),
					new SqlParameter("@huiyuan_xuhao", SqlDbType.Int,4),
					new SqlParameter("@huiyuan_id", SqlDbType.Char,9),
					new SqlParameter("@huiyuan_jiebie", SqlDbType.Int,4),
					new SqlParameter("@net_hege", SqlDbType.Int,4),
					new SqlParameter("@shang_jiebie", SqlDbType.Int,4),
					new SqlParameter("@shang_hege", SqlDbType.Int,4),
					new SqlParameter("@shang_flag", SqlDbType.Int,4),
					new SqlParameter("@net_flag", SqlDbType.Int,4),
					new SqlParameter("@shang_tuijian_count", SqlDbType.Int,4),
					new SqlParameter("@account_type", SqlDbType.Int,4),
					new SqlParameter("@huiyuan_jiebie1", SqlDbType.Int,4),
					new SqlParameter("@shang_jiebie1", SqlDbType.Int,4),
					new SqlParameter("@tuijian_count", SqlDbType.Int,4),
					new SqlParameter("@huiyuan_zhuanmai", SqlDbType.Int,4),
					new SqlParameter("@zhuanmai_jb", SqlDbType.Int,4),
					new SqlParameter("@xia_zm_jb", SqlDbType.Int,4),
					new SqlParameter("@flag_3", SqlDbType.Int,4),
					new SqlParameter("@huiyuan_bianhao", SqlDbType.NVarChar,50),
					new SqlParameter("@huiyuan_name", SqlDbType.NVarChar,50),
					new SqlParameter("@huiyuan_add_time", SqlDbType.DateTime)};
        parameters[0].Value = huiyuan_shang_id;
        parameters[1].Value = huiyuan_xuhao;
        parameters[2].Value = huiyuan_id;
        parameters[3].Value = huiyuan_jiebie;
        parameters[4].Value = net_hege;
        parameters[5].Value = shang_jiebie;
        parameters[6].Value = shang_hege;
        parameters[7].Value = shang_flag;
        parameters[8].Value = net_flag;
        parameters[9].Value = shang_tuijian_count;
        parameters[10].Value = account_type;
        parameters[11].Value = huiyuan_jiebie1;
        parameters[12].Value = shang_jiebie1;
        parameters[13].Value = tuijian_count;
        parameters[14].Value = huiyuan_zhuanmai;
        parameters[15].Value = zhuanmai_jb;
        parameters[16].Value = xia_zm_jb;
        parameters[17].Value = flag_3;
        parameters[18].Value = huiyuan_bianhao;
        parameters[19].Value = huiyuan_name;
        parameters[20].Value = huiyuan_add_time;

        DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
    }
    /// <summary>
    /// 更新一条数据
    /// </summary>
    public bool Update()
    {
        StringBuilder strSql = new StringBuilder();
        strSql.Append("update [view_shangshu2] set ");
        strSql.Append("huiyuan_shang_id=@huiyuan_shang_id,");
        strSql.Append("huiyuan_xuhao=@huiyuan_xuhao,");
        strSql.Append("huiyuan_id=@huiyuan_id,");
        strSql.Append("huiyuan_jiebie=@huiyuan_jiebie,");
        strSql.Append("net_hege=@net_hege,");
        strSql.Append("shang_jiebie=@shang_jiebie,");
        strSql.Append("shang_hege=@shang_hege,");
        strSql.Append("shang_flag=@shang_flag,");
        strSql.Append("net_flag=@net_flag,");
        strSql.Append("shang_tuijian_count=@shang_tuijian_count,");
        strSql.Append("account_type=@account_type,");
        strSql.Append("huiyuan_jiebie1=@huiyuan_jiebie1,");
        strSql.Append("shang_jiebie1=@shang_jiebie1,");
        strSql.Append("tuijian_count=@tuijian_count,");
        strSql.Append("huiyuan_zhuanmai=@huiyuan_zhuanmai,");
        strSql.Append("zhuanmai_jb=@zhuanmai_jb,");
        strSql.Append("xia_zm_jb=@xia_zm_jb,");
        strSql.Append("flag_3=@flag_3,");
        strSql.Append("huiyuan_bianhao=@huiyuan_bianhao,");
        strSql.Append("huiyuan_name=@huiyuan_name,");
        strSql.Append("huiyuan_add_time=@huiyuan_add_time");
        strSql.Append(" where huiyuan_shang_id=@huiyuan_shang_id and huiyuan_xuhao=@huiyuan_xuhao and huiyuan_id=@huiyuan_id and huiyuan_jiebie=@huiyuan_jiebie and net_hege=@net_hege and shang_jiebie=@shang_jiebie and shang_hege=@shang_hege and shang_flag=@shang_flag and net_flag=@net_flag and shang_tuijian_count=@shang_tuijian_count and account_type=@account_type and huiyuan_jiebie1=@huiyuan_jiebie1 and shang_jiebie1=@shang_jiebie1 and tuijian_count=@tuijian_count and huiyuan_zhuanmai=@huiyuan_zhuanmai and zhuanmai_jb=@zhuanmai_jb and xia_zm_jb=@xia_zm_jb and flag_3=@flag_3 and huiyuan_bianhao=@huiyuan_bianhao and huiyuan_name=@huiyuan_name and huiyuan_add_time=@huiyuan_add_time ");
        SqlParameter[] parameters = {
					new SqlParameter("@huiyuan_shang_id", SqlDbType.Char,9),
					new SqlParameter("@huiyuan_xuhao", SqlDbType.Int,4),
					new SqlParameter("@huiyuan_id", SqlDbType.Char,9),
					new SqlParameter("@huiyuan_jiebie", SqlDbType.Int,4),
					new SqlParameter("@net_hege", SqlDbType.Int,4),
					new SqlParameter("@shang_jiebie", SqlDbType.Int,4),
					new SqlParameter("@shang_hege", SqlDbType.Int,4),
					new SqlParameter("@shang_flag", SqlDbType.Int,4),
					new SqlParameter("@net_flag", SqlDbType.Int,4),
					new SqlParameter("@shang_tuijian_count", SqlDbType.Int,4),
					new SqlParameter("@account_type", SqlDbType.Int,4),
					new SqlParameter("@huiyuan_jiebie1", SqlDbType.Int,4),
					new SqlParameter("@shang_jiebie1", SqlDbType.Int,4),
					new SqlParameter("@tuijian_count", SqlDbType.Int,4),
					new SqlParameter("@huiyuan_zhuanmai", SqlDbType.Int,4),
					new SqlParameter("@zhuanmai_jb", SqlDbType.Int,4),
					new SqlParameter("@xia_zm_jb", SqlDbType.Int,4),
					new SqlParameter("@flag_3", SqlDbType.Int,4),
					new SqlParameter("@huiyuan_bianhao", SqlDbType.NVarChar,50),
					new SqlParameter("@huiyuan_name", SqlDbType.NVarChar,50),
					new SqlParameter("@huiyuan_add_time", SqlDbType.DateTime)};
        parameters[0].Value = huiyuan_shang_id;
        parameters[1].Value = huiyuan_xuhao;
        parameters[2].Value = huiyuan_id;
        parameters[3].Value = huiyuan_jiebie;
        parameters[4].Value = net_hege;
        parameters[5].Value = shang_jiebie;
        parameters[6].Value = shang_hege;
        parameters[7].Value = shang_flag;
        parameters[8].Value = net_flag;
        parameters[9].Value = shang_tuijian_count;
        parameters[10].Value = account_type;
        parameters[11].Value = huiyuan_jiebie1;
        parameters[12].Value = shang_jiebie1;
        parameters[13].Value = tuijian_count;
        parameters[14].Value = huiyuan_zhuanmai;
        parameters[15].Value = zhuanmai_jb;
        parameters[16].Value = xia_zm_jb;
        parameters[17].Value = flag_3;
        parameters[18].Value = huiyuan_bianhao;
        parameters[19].Value = huiyuan_name;
        parameters[20].Value = huiyuan_add_time;

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
    public bool Delete(string huiyuan_shang_id, int huiyuan_xuhao, string huiyuan_id, int huiyuan_jiebie, int net_hege, int shang_jiebie, int shang_hege, int shang_flag, int net_flag, int shang_tuijian_count, int account_type, int huiyuan_jiebie1, int shang_jiebie1, int tuijian_count, int huiyuan_zhuanmai, int zhuanmai_jb, int xia_zm_jb, int flag_3, string huiyuan_bianhao, string huiyuan_name, DateTime huiyuan_add_time)
    {
        StringBuilder strSql = new StringBuilder();
        strSql.Append("delete from [view_shangshu2] ");
        strSql.Append(" where huiyuan_shang_id=@huiyuan_shang_id and huiyuan_xuhao=@huiyuan_xuhao and huiyuan_id=@huiyuan_id and huiyuan_jiebie=@huiyuan_jiebie and net_hege=@net_hege and shang_jiebie=@shang_jiebie and shang_hege=@shang_hege and shang_flag=@shang_flag and net_flag=@net_flag and shang_tuijian_count=@shang_tuijian_count and account_type=@account_type and huiyuan_jiebie1=@huiyuan_jiebie1 and shang_jiebie1=@shang_jiebie1 and tuijian_count=@tuijian_count and huiyuan_zhuanmai=@huiyuan_zhuanmai and zhuanmai_jb=@zhuanmai_jb and xia_zm_jb=@xia_zm_jb and flag_3=@flag_3 and huiyuan_bianhao=@huiyuan_bianhao and huiyuan_name=@huiyuan_name and huiyuan_add_time=@huiyuan_add_time ");
        SqlParameter[] parameters = {
					new SqlParameter("@huiyuan_shang_id", SqlDbType.Char,10),
					new SqlParameter("@huiyuan_xuhao", SqlDbType.Int,4),
					new SqlParameter("@huiyuan_id", SqlDbType.Char,10),
					new SqlParameter("@huiyuan_jiebie", SqlDbType.Int,4),
					new SqlParameter("@net_hege", SqlDbType.Int,4),
					new SqlParameter("@shang_jiebie", SqlDbType.Int,4),
					new SqlParameter("@shang_hege", SqlDbType.Int,4),
					new SqlParameter("@shang_flag", SqlDbType.Int,4),
					new SqlParameter("@net_flag", SqlDbType.Int,4),
					new SqlParameter("@shang_tuijian_count", SqlDbType.Int,4),
					new SqlParameter("@account_type", SqlDbType.Int,4),
					new SqlParameter("@huiyuan_jiebie1", SqlDbType.Int,4),
					new SqlParameter("@shang_jiebie1", SqlDbType.Int,4),
					new SqlParameter("@tuijian_count", SqlDbType.Int,4),
					new SqlParameter("@huiyuan_zhuanmai", SqlDbType.Int,4),
					new SqlParameter("@zhuanmai_jb", SqlDbType.Int,4),
					new SqlParameter("@xia_zm_jb", SqlDbType.Int,4),
					new SqlParameter("@flag_3", SqlDbType.Int,4),
					new SqlParameter("@huiyuan_bianhao", SqlDbType.NVarChar,-1),
					new SqlParameter("@huiyuan_name", SqlDbType.NVarChar,-1),
					new SqlParameter("@huiyuan_add_time", SqlDbType.DateTime)};
        parameters[0].Value = huiyuan_shang_id;
        parameters[1].Value = huiyuan_xuhao;
        parameters[2].Value = huiyuan_id;
        parameters[3].Value = huiyuan_jiebie;
        parameters[4].Value = net_hege;
        parameters[5].Value = shang_jiebie;
        parameters[6].Value = shang_hege;
        parameters[7].Value = shang_flag;
        parameters[8].Value = net_flag;
        parameters[9].Value = shang_tuijian_count;
        parameters[10].Value = account_type;
        parameters[11].Value = huiyuan_jiebie1;
        parameters[12].Value = shang_jiebie1;
        parameters[13].Value = tuijian_count;
        parameters[14].Value = huiyuan_zhuanmai;
        parameters[15].Value = zhuanmai_jb;
        parameters[16].Value = xia_zm_jb;
        parameters[17].Value = flag_3;
        parameters[18].Value = huiyuan_bianhao;
        parameters[19].Value = huiyuan_name;
        parameters[20].Value = huiyuan_add_time;

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
    public void GetModel(string huiyuan_shang_id, int huiyuan_xuhao, string huiyuan_id, int huiyuan_jiebie, int net_hege, int shang_jiebie, int shang_hege, int shang_flag, int net_flag, int shang_tuijian_count, int account_type, int huiyuan_jiebie1, int shang_jiebie1, int tuijian_count, int huiyuan_zhuanmai, int zhuanmai_jb, int xia_zm_jb, int flag_3, string huiyuan_bianhao, string huiyuan_name, DateTime huiyuan_add_time)
    {
        StringBuilder strSql = new StringBuilder();
        strSql.Append("select huiyuan_shang_id,huiyuan_xuhao,huiyuan_id,huiyuan_jiebie,net_hege,shang_jiebie,shang_hege,shang_flag,net_flag,shang_tuijian_count,account_type,huiyuan_jiebie1,shang_jiebie1,tuijian_count,huiyuan_zhuanmai,zhuanmai_jb,xia_zm_jb,flag_3,huiyuan_bianhao,huiyuan_name,huiyuan_add_time ");
        strSql.Append(" FROM [view_shangshu2] ");
        strSql.Append(" where huiyuan_shang_id=@huiyuan_shang_id and huiyuan_xuhao=@huiyuan_xuhao and huiyuan_id=@huiyuan_id and huiyuan_jiebie=@huiyuan_jiebie and net_hege=@net_hege and shang_jiebie=@shang_jiebie and shang_hege=@shang_hege and shang_flag=@shang_flag and net_flag=@net_flag and shang_tuijian_count=@shang_tuijian_count and account_type=@account_type and huiyuan_jiebie1=@huiyuan_jiebie1 and shang_jiebie1=@shang_jiebie1 and tuijian_count=@tuijian_count and huiyuan_zhuanmai=@huiyuan_zhuanmai and zhuanmai_jb=@zhuanmai_jb and xia_zm_jb=@xia_zm_jb and flag_3=@flag_3 and huiyuan_bianhao=@huiyuan_bianhao and huiyuan_name=@huiyuan_name and huiyuan_add_time=@huiyuan_add_time ");
        SqlParameter[] parameters = {
					new SqlParameter("@huiyuan_shang_id", SqlDbType.Char,10),
					new SqlParameter("@huiyuan_xuhao", SqlDbType.Int,4),
					new SqlParameter("@huiyuan_id", SqlDbType.Char,10),
					new SqlParameter("@huiyuan_jiebie", SqlDbType.Int,4),
					new SqlParameter("@net_hege", SqlDbType.Int,4),
					new SqlParameter("@shang_jiebie", SqlDbType.Int,4),
					new SqlParameter("@shang_hege", SqlDbType.Int,4),
					new SqlParameter("@shang_flag", SqlDbType.Int,4),
					new SqlParameter("@net_flag", SqlDbType.Int,4),
					new SqlParameter("@shang_tuijian_count", SqlDbType.Int,4),
					new SqlParameter("@account_type", SqlDbType.Int,4),
					new SqlParameter("@huiyuan_jiebie1", SqlDbType.Int,4),
					new SqlParameter("@shang_jiebie1", SqlDbType.Int,4),
					new SqlParameter("@tuijian_count", SqlDbType.Int,4),
					new SqlParameter("@huiyuan_zhuanmai", SqlDbType.Int,4),
					new SqlParameter("@zhuanmai_jb", SqlDbType.Int,4),
					new SqlParameter("@xia_zm_jb", SqlDbType.Int,4),
					new SqlParameter("@flag_3", SqlDbType.Int,4),
					new SqlParameter("@huiyuan_bianhao", SqlDbType.NVarChar,-1),
					new SqlParameter("@huiyuan_name", SqlDbType.NVarChar,-1),
					new SqlParameter("@huiyuan_add_time", SqlDbType.DateTime)};
        parameters[0].Value = huiyuan_shang_id;
        parameters[1].Value = huiyuan_xuhao;
        parameters[2].Value = huiyuan_id;
        parameters[3].Value = huiyuan_jiebie;
        parameters[4].Value = net_hege;
        parameters[5].Value = shang_jiebie;
        parameters[6].Value = shang_hege;
        parameters[7].Value = shang_flag;
        parameters[8].Value = net_flag;
        parameters[9].Value = shang_tuijian_count;
        parameters[10].Value = account_type;
        parameters[11].Value = huiyuan_jiebie1;
        parameters[12].Value = shang_jiebie1;
        parameters[13].Value = tuijian_count;
        parameters[14].Value = huiyuan_zhuanmai;
        parameters[15].Value = zhuanmai_jb;
        parameters[16].Value = xia_zm_jb;
        parameters[17].Value = flag_3;
        parameters[18].Value = huiyuan_bianhao;
        parameters[19].Value = huiyuan_name;
        parameters[20].Value = huiyuan_add_time;

        DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
        if (ds.Tables[0].Rows.Count > 0)
        {
            if (ds.Tables[0].Rows[0]["huiyuan_shang_id"] != null)
            {
                this.huiyuan_shang_id = ds.Tables[0].Rows[0]["huiyuan_shang_id"].ToString();
            }
            if (ds.Tables[0].Rows[0]["huiyuan_xuhao"] != null && ds.Tables[0].Rows[0]["huiyuan_xuhao"].ToString() != "")
            {
                this.huiyuan_xuhao = int.Parse(ds.Tables[0].Rows[0]["huiyuan_xuhao"].ToString());
            }
            if (ds.Tables[0].Rows[0]["huiyuan_id"] != null)
            {
                this.huiyuan_id = ds.Tables[0].Rows[0]["huiyuan_id"].ToString();
            }
            if (ds.Tables[0].Rows[0]["huiyuan_jiebie"] != null && ds.Tables[0].Rows[0]["huiyuan_jiebie"].ToString() != "")
            {
                this.huiyuan_jiebie = int.Parse(ds.Tables[0].Rows[0]["huiyuan_jiebie"].ToString());
            }
            if (ds.Tables[0].Rows[0]["net_hege"] != null && ds.Tables[0].Rows[0]["net_hege"].ToString() != "")
            {
                this.net_hege = int.Parse(ds.Tables[0].Rows[0]["net_hege"].ToString());
            }
            if (ds.Tables[0].Rows[0]["shang_jiebie"] != null && ds.Tables[0].Rows[0]["shang_jiebie"].ToString() != "")
            {
                this.shang_jiebie = int.Parse(ds.Tables[0].Rows[0]["shang_jiebie"].ToString());
            }
            if (ds.Tables[0].Rows[0]["shang_hege"] != null && ds.Tables[0].Rows[0]["shang_hege"].ToString() != "")
            {
                this.shang_hege = int.Parse(ds.Tables[0].Rows[0]["shang_hege"].ToString());
            }
            if (ds.Tables[0].Rows[0]["shang_flag"] != null && ds.Tables[0].Rows[0]["shang_flag"].ToString() != "")
            {
                this.shang_flag = int.Parse(ds.Tables[0].Rows[0]["shang_flag"].ToString());
            }
            if (ds.Tables[0].Rows[0]["net_flag"] != null && ds.Tables[0].Rows[0]["net_flag"].ToString() != "")
            {
                this.net_flag = int.Parse(ds.Tables[0].Rows[0]["net_flag"].ToString());
            }
            if (ds.Tables[0].Rows[0]["shang_tuijian_count"] != null && ds.Tables[0].Rows[0]["shang_tuijian_count"].ToString() != "")
            {
                this.shang_tuijian_count = int.Parse(ds.Tables[0].Rows[0]["shang_tuijian_count"].ToString());
            }
            if (ds.Tables[0].Rows[0]["account_type"] != null && ds.Tables[0].Rows[0]["account_type"].ToString() != "")
            {
                this.account_type = int.Parse(ds.Tables[0].Rows[0]["account_type"].ToString());
            }
            if (ds.Tables[0].Rows[0]["huiyuan_jiebie1"] != null && ds.Tables[0].Rows[0]["huiyuan_jiebie1"].ToString() != "")
            {
                this.huiyuan_jiebie1 = int.Parse(ds.Tables[0].Rows[0]["huiyuan_jiebie1"].ToString());
            }
            if (ds.Tables[0].Rows[0]["shang_jiebie1"] != null && ds.Tables[0].Rows[0]["shang_jiebie1"].ToString() != "")
            {
                this.shang_jiebie1 = int.Parse(ds.Tables[0].Rows[0]["shang_jiebie1"].ToString());
            }
            if (ds.Tables[0].Rows[0]["tuijian_count"] != null && ds.Tables[0].Rows[0]["tuijian_count"].ToString() != "")
            {
                this.tuijian_count = int.Parse(ds.Tables[0].Rows[0]["tuijian_count"].ToString());
            }
            if (ds.Tables[0].Rows[0]["huiyuan_zhuanmai"] != null && ds.Tables[0].Rows[0]["huiyuan_zhuanmai"].ToString() != "")
            {
                this.huiyuan_zhuanmai = int.Parse(ds.Tables[0].Rows[0]["huiyuan_zhuanmai"].ToString());
            }
            if (ds.Tables[0].Rows[0]["zhuanmai_jb"] != null && ds.Tables[0].Rows[0]["zhuanmai_jb"].ToString() != "")
            {
                this.zhuanmai_jb = int.Parse(ds.Tables[0].Rows[0]["zhuanmai_jb"].ToString());
            }
            if (ds.Tables[0].Rows[0]["xia_zm_jb"] != null && ds.Tables[0].Rows[0]["xia_zm_jb"].ToString() != "")
            {
                this.xia_zm_jb = int.Parse(ds.Tables[0].Rows[0]["xia_zm_jb"].ToString());
            }
            if (ds.Tables[0].Rows[0]["flag_3"] != null && ds.Tables[0].Rows[0]["flag_3"].ToString() != "")
            {
                this.flag_3 = int.Parse(ds.Tables[0].Rows[0]["flag_3"].ToString());
            }
            if (ds.Tables[0].Rows[0]["huiyuan_bianhao"] != null)
            {
                this.huiyuan_bianhao = ds.Tables[0].Rows[0]["huiyuan_bianhao"].ToString();
            }
            if (ds.Tables[0].Rows[0]["huiyuan_name"] != null)
            {
                this.huiyuan_name = ds.Tables[0].Rows[0]["huiyuan_name"].ToString();
            }
            if (ds.Tables[0].Rows[0]["huiyuan_add_time"] != null && ds.Tables[0].Rows[0]["huiyuan_add_time"].ToString() != "")
            {
                this.huiyuan_add_time = DateTime.Parse(ds.Tables[0].Rows[0]["huiyuan_add_time"].ToString());
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
        strSql.Append(" FROM [view_shangshu2] ");
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
        strSql.Append("select * FROM  view_shangshu2");
        if (strWhere.Trim() != "")
        {
            strSql.Append(" where " + strWhere);
        }
        recordCount = Convert.ToInt32(DbHelperSQL.GetSingle(PagingHelper.CreateCountingSql(strSql.ToString())));
        return DbHelperSQL.Query(PagingHelper.CreatePagingSql(recordCount, pageSize, pageIndex, strSql.ToString(), filedOrder));
    }
    #endregion  Method
}