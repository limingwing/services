using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
 
 
    /// <summary>
    /// 类tbl_reg_bank。
    /// </summary>
    [Serializable]
    public partial class tbl_reg_bank
    {
        public tbl_reg_bank()
        { }
        #region Model
        private int _id;
        private string _bank_name;
        private int? _sort_id = 0;
        /// <summary>
        /// 标识id
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 银行名称
        /// </summary>
        public string bank_name
        {
            set { _bank_name = value; }
            get { return _bank_name; }
        }
        /// <summary>
        /// 排序号
        /// </summary>
        public int? sort_id
        {
            set { _sort_id = value; }
            get { return _sort_id; }
        }
        #endregion Model


        #region  Method

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public tbl_reg_bank(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,bank_name,sort_id ");
            strSql.Append(" FROM [tbl_reg_bank] ");
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
                if (ds.Tables[0].Rows[0]["bank_name"] != null)
                {
                    this.bank_name = ds.Tables[0].Rows[0]["bank_name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["sort_id"] != null && ds.Tables[0].Rows[0]["sort_id"].ToString() != "")
                {
                    this.sort_id = int.Parse(ds.Tables[0].Rows[0]["sort_id"].ToString());
                }
            }
        }
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from [tbl_reg_bank]");
            strSql.Append(" where id=@id ");

            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = id;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 查询名称是否存在
        /// </summary>
        public bool Exists(string bank_name)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from  tbl_reg_bank");
            strSql.Append(" where bank_name=@bank_name ");
            SqlParameter[] parameters = {
					new SqlParameter("@bank_name", SqlDbType.NVarChar,100)};
            parameters[0].Value = bank_name;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 查询排除自己名称是否存在
        /// </summary>
        public bool Exists(string bank_name, int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from  tbl_reg_bank");
            strSql.Append(" where  id<>@id and  bank_name=@bank_name ");
            SqlParameter[] parameters = {
                     new SqlParameter("@id", SqlDbType.Int,4),
					new SqlParameter("@bank_name", SqlDbType.NVarChar,100)};
            parameters[0].Value = id;
            parameters[1].Value = bank_name;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into [tbl_reg_bank] (");
            strSql.Append("bank_name,sort_id)");
            strSql.Append(" values (");
            strSql.Append("@bank_name,@sort_id)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@bank_name", SqlDbType.VarChar,200),
					new SqlParameter("@sort_id", SqlDbType.Int,4)};
            parameters[0].Value = bank_name;
            parameters[1].Value = sort_id;

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
        /// 更新一条数据
        /// </summary>
        public bool Update()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update [tbl_reg_bank] set ");
            strSql.Append("bank_name=@bank_name,");
            strSql.Append("sort_id=@sort_id");
            strSql.Append(" where id=@id ");
            SqlParameter[] parameters = {
					new SqlParameter("@bank_name", SqlDbType.VarChar,200),
					new SqlParameter("@sort_id", SqlDbType.Int,4),
					new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = bank_name;
            parameters[1].Value = sort_id;
            parameters[2].Value = id;

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
            strSql.Append("delete from [tbl_reg_bank] ");
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
            strSql.Append("select id,bank_name,sort_id ");
            strSql.Append(" FROM [tbl_reg_bank] ");
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
                if (ds.Tables[0].Rows[0]["bank_name"] != null)
                {
                    this.bank_name = ds.Tables[0].Rows[0]["bank_name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["sort_id"] != null && ds.Tables[0].Rows[0]["sort_id"].ToString() != "")
                {
                    this.sort_id = int.Parse(ds.Tables[0].Rows[0]["sort_id"].ToString());
                }
            }
        }

        /// <summary>
        /// 修改一列数据
        /// </summary>
        public void UpdateField(int id, string strValue)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tbl_reg_bank set " + strValue);
            strSql.Append(" where id=" + id);
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM [tbl_reg_bank] ");
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
            strSql.Append("select * FROM  tbl_reg_bank");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            recordCount = Convert.ToInt32(DbHelperSQL.GetSingle(PagingHelper.CreateCountingSql(strSql.ToString())));
            return DbHelperSQL.Query(PagingHelper.CreatePagingSql(recordCount, pageSize, pageIndex, strSql.ToString(), filedOrder));
        }

        #endregion  Method
    }
 

