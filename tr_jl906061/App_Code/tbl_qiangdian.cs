using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
 
 
    /// <summary>
    /// 类tbl_qiangdian。
    /// </summary>
    [Serializable]
    public partial class tbl_qiangdian
    {
        public tbl_qiangdian()
        { }
        #region Model
        private int _id;
        private string _huiyuan_id;
        private string _huiyuan_bianhao;
        private string _huiyuan_name;
        private string _huiyuan_mob;
        private decimal? _dongjie_money;
        private string _huiyuan_yinhang;
        private string _huiyuan_yinhang_zh;
        private string _qiang_bianhao;
        private string _qiangdian_date;
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
        public string huiyuan_id
        {
            set { _huiyuan_id = value; }
            get { return _huiyuan_id; }
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
        public string huiyuan_mob
        {
            set { _huiyuan_mob = value; }
            get { return _huiyuan_mob; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? dongjie_money
        {
            set { _dongjie_money = value; }
            get { return _dongjie_money; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string huiyuan_yinhang
        {
            set { _huiyuan_yinhang = value; }
            get { return _huiyuan_yinhang; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string huiyuan_yinhang_zh
        {
            set { _huiyuan_yinhang_zh = value; }
            get { return _huiyuan_yinhang_zh; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string qiang_bianhao
        {
            set { _qiang_bianhao = value; }
            get { return _qiang_bianhao; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string qiangdian_date
        {
            set { _qiangdian_date = value; }
            get { return _qiangdian_date; }
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
        public tbl_qiangdian(string huiyuan_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,huiyuan_id,huiyuan_bianhao,huiyuan_name,huiyuan_mob,dongjie_money,huiyuan_yinhang,huiyuan_yinhang_zh,qiang_bianhao,qiangdian_date,flag ");
            strSql.Append(" FROM [tbl_qiangdian] ");
            strSql.Append(" where huiyuan_id=@huiyuan_id ");
            SqlParameter[] parameters = {
					new SqlParameter("@huiyuan_id", SqlDbType.Char,10)};
            parameters[0].Value = huiyuan_id;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["id"] != null && ds.Tables[0].Rows[0]["id"].ToString() != "")
                {
                    this.id = int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["huiyuan_id"] != null)
                {
                    this.huiyuan_id = ds.Tables[0].Rows[0]["huiyuan_id"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_bianhao"] != null)
                {
                    this.huiyuan_bianhao = ds.Tables[0].Rows[0]["huiyuan_bianhao"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_name"] != null)
                {
                    this.huiyuan_name = ds.Tables[0].Rows[0]["huiyuan_name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_mob"] != null)
                {
                    this.huiyuan_mob = ds.Tables[0].Rows[0]["huiyuan_mob"].ToString();
                }
                if (ds.Tables[0].Rows[0]["dongjie_money"] != null && ds.Tables[0].Rows[0]["dongjie_money"].ToString() != "")
                {
                    this.dongjie_money = decimal.Parse(ds.Tables[0].Rows[0]["dongjie_money"].ToString());
                }
                if (ds.Tables[0].Rows[0]["huiyuan_yinhang"] != null)
                {
                    this.huiyuan_yinhang = ds.Tables[0].Rows[0]["huiyuan_yinhang"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_yinhang_zh"] != null)
                {
                    this.huiyuan_yinhang_zh = ds.Tables[0].Rows[0]["huiyuan_yinhang_zh"].ToString();
                }
                if (ds.Tables[0].Rows[0]["qiang_bianhao"] != null)
                {
                    this.qiang_bianhao = ds.Tables[0].Rows[0]["qiang_bianhao"].ToString();
                }
                if (ds.Tables[0].Rows[0]["qiangdian_date"] != null)
                {
                    this.qiangdian_date = ds.Tables[0].Rows[0]["qiangdian_date"].ToString();
                }
                if (ds.Tables[0].Rows[0]["flag"] != null && ds.Tables[0].Rows[0]["flag"].ToString() != "")
                {
                    this.flag = int.Parse(ds.Tables[0].Rows[0]["flag"].ToString());
                }
            }
        }
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string huiyuan_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from [tbl_qiangdian]");
            strSql.Append(" where huiyuan_id=@huiyuan_id ");

            SqlParameter[] parameters = {
					new SqlParameter("@huiyuan_id", SqlDbType.Char,10)};
            parameters[0].Value = huiyuan_id;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into [tbl_qiangdian] (");
            strSql.Append("huiyuan_id,huiyuan_bianhao,huiyuan_name,huiyuan_mob,dongjie_money,huiyuan_yinhang,huiyuan_yinhang_zh,qiang_bianhao,qiangdian_date,flag)");
            strSql.Append(" values (");
            strSql.Append("@huiyuan_id,@huiyuan_bianhao,@huiyuan_name,@huiyuan_mob,@dongjie_money,@huiyuan_yinhang,@huiyuan_yinhang_zh,@qiang_bianhao,@qiangdian_date,@flag)");
            SqlParameter[] parameters = {
					new SqlParameter("@huiyuan_id", SqlDbType.Char,10),
					new SqlParameter("@huiyuan_bianhao", SqlDbType.VarChar,50),
					new SqlParameter("@huiyuan_name", SqlDbType.VarChar,50),
					new SqlParameter("@huiyuan_mob", SqlDbType.VarChar,50),
					new SqlParameter("@dongjie_money", SqlDbType.Money,8),
					new SqlParameter("@huiyuan_yinhang", SqlDbType.VarChar,50),
					new SqlParameter("@huiyuan_yinhang_zh", SqlDbType.VarChar,50),
					new SqlParameter("@qiang_bianhao", SqlDbType.VarChar,50),
					new SqlParameter("@qiangdian_date", SqlDbType.VarChar,50),
					new SqlParameter("@flag", SqlDbType.Int,4)};
            parameters[0].Value = huiyuan_id;
            parameters[1].Value = huiyuan_bianhao;
            parameters[2].Value = huiyuan_name;
            parameters[3].Value = huiyuan_mob;
            parameters[4].Value = dongjie_money;
            parameters[5].Value = huiyuan_yinhang;
            parameters[6].Value = huiyuan_yinhang_zh;
            parameters[7].Value = qiang_bianhao;
            parameters[8].Value = qiangdian_date;
            parameters[9].Value = flag;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update [tbl_qiangdian] set ");
            strSql.Append("huiyuan_id=@huiyuan_id,");
            strSql.Append("huiyuan_bianhao=@huiyuan_bianhao,");
            strSql.Append("huiyuan_name=@huiyuan_name,");
            strSql.Append("huiyuan_mob=@huiyuan_mob,");
            strSql.Append("dongjie_money=@dongjie_money,");
            strSql.Append("huiyuan_yinhang=@huiyuan_yinhang,");
            strSql.Append("huiyuan_yinhang_zh=@huiyuan_yinhang_zh,");
            strSql.Append("qiang_bianhao=@qiang_bianhao,");
            strSql.Append("qiangdian_date=@qiangdian_date,");
            strSql.Append("flag=@flag");
            strSql.Append(" where huiyuan_id=@huiyuan_id ");
            SqlParameter[] parameters = {
					new SqlParameter("@huiyuan_id", SqlDbType.Char,10),
					new SqlParameter("@huiyuan_bianhao", SqlDbType.VarChar,50),
					new SqlParameter("@huiyuan_name", SqlDbType.VarChar,50),
					new SqlParameter("@huiyuan_mob", SqlDbType.VarChar,50),
					new SqlParameter("@dongjie_money", SqlDbType.Money,8),
					new SqlParameter("@huiyuan_yinhang", SqlDbType.VarChar,50),
					new SqlParameter("@huiyuan_yinhang_zh", SqlDbType.VarChar,50),
					new SqlParameter("@qiang_bianhao", SqlDbType.VarChar,50),
					new SqlParameter("@qiangdian_date", SqlDbType.VarChar,50),
					new SqlParameter("@flag", SqlDbType.Int,4),
					new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = huiyuan_id;
            parameters[1].Value = huiyuan_bianhao;
            parameters[2].Value = huiyuan_name;
            parameters[3].Value = huiyuan_mob;
            parameters[4].Value = dongjie_money;
            parameters[5].Value = huiyuan_yinhang;
            parameters[6].Value = huiyuan_yinhang_zh;
            parameters[7].Value = qiang_bianhao;
            parameters[8].Value = qiangdian_date;
            parameters[9].Value = flag;
            parameters[10].Value = id;

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
        public bool Delete(string huiyuan_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from [tbl_qiangdian] ");
            strSql.Append(" where huiyuan_id=@huiyuan_id ");
            SqlParameter[] parameters = {
					new SqlParameter("@huiyuan_id", SqlDbType.Char,10)};
            parameters[0].Value = huiyuan_id;

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
        public void GetModel(string huiyuan_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,huiyuan_id,huiyuan_bianhao,huiyuan_name,huiyuan_mob,dongjie_money,huiyuan_yinhang,huiyuan_yinhang_zh,qiang_bianhao,qiangdian_date,flag ");
            strSql.Append(" FROM [tbl_qiangdian] ");
            strSql.Append(" where huiyuan_id=@huiyuan_id ");
            SqlParameter[] parameters = {
					new SqlParameter("@huiyuan_id", SqlDbType.Char,10)};
            parameters[0].Value = huiyuan_id;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["id"] != null && ds.Tables[0].Rows[0]["id"].ToString() != "")
                {
                    this.id = int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["huiyuan_id"] != null)
                {
                    this.huiyuan_id = ds.Tables[0].Rows[0]["huiyuan_id"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_bianhao"] != null)
                {
                    this.huiyuan_bianhao = ds.Tables[0].Rows[0]["huiyuan_bianhao"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_name"] != null)
                {
                    this.huiyuan_name = ds.Tables[0].Rows[0]["huiyuan_name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_mob"] != null)
                {
                    this.huiyuan_mob = ds.Tables[0].Rows[0]["huiyuan_mob"].ToString();
                }
                if (ds.Tables[0].Rows[0]["dongjie_money"] != null && ds.Tables[0].Rows[0]["dongjie_money"].ToString() != "")
                {
                    this.dongjie_money = decimal.Parse(ds.Tables[0].Rows[0]["dongjie_money"].ToString());
                }
                if (ds.Tables[0].Rows[0]["huiyuan_yinhang"] != null)
                {
                    this.huiyuan_yinhang = ds.Tables[0].Rows[0]["huiyuan_yinhang"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_yinhang_zh"] != null)
                {
                    this.huiyuan_yinhang_zh = ds.Tables[0].Rows[0]["huiyuan_yinhang_zh"].ToString();
                }
                if (ds.Tables[0].Rows[0]["qiang_bianhao"] != null)
                {
                    this.qiang_bianhao = ds.Tables[0].Rows[0]["qiang_bianhao"].ToString();
                }
                if (ds.Tables[0].Rows[0]["qiangdian_date"] != null)
                {
                    this.qiangdian_date = ds.Tables[0].Rows[0]["qiangdian_date"].ToString();
                }
                if (ds.Tables[0].Rows[0]["flag"] != null && ds.Tables[0].Rows[0]["flag"].ToString() != "")
                {
                    this.flag = int.Parse(ds.Tables[0].Rows[0]["flag"].ToString());
                }
            }
        }

        /// <summary>
        /// 获得查询分页数据
        /// </summary>
        public DataSet GetList(int pageSize, int pageIndex, string strWhere, string filedOrder, out int recordCount)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * FROM  tbl_qiangdian   ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            recordCount = Convert.ToInt32(DbHelperSQL.GetSingle(PagingHelper.CreateCountingSql(strSql.ToString())));
            return DbHelperSQL.Query(PagingHelper.CreatePagingSql(recordCount, pageSize, pageIndex, strSql.ToString(), filedOrder));
        }
        #endregion  Method
    }
 

