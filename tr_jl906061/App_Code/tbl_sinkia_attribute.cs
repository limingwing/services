using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
 
    /// <summary>
    /// 类tbl_sinkia_attribute。
    /// </summary>
    [Serializable]
    public partial class tbl_sinkia_attribute
    {
        public tbl_sinkia_attribute()
        { }
        #region Model
        private int _id;
        private string _attribute_name;
        private string _attribute_value;
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
        public string attribute_name
        {
            set { _attribute_name = value; }
            get { return _attribute_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string attribute_value
        {
            set { _attribute_value = value; }
            get { return _attribute_value; }
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
        public tbl_sinkia_attribute(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,attribute_name,attribute_value,flag ");
            strSql.Append(" FROM [tbl_sinkia_attribute] ");
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
                if (ds.Tables[0].Rows[0]["attribute_name"] != null)
                {
                    this.attribute_name = ds.Tables[0].Rows[0]["attribute_name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["attribute_value"] != null)
                {
                    this.attribute_value = ds.Tables[0].Rows[0]["attribute_value"].ToString();
                }
                if (ds.Tables[0].Rows[0]["flag"] != null && ds.Tables[0].Rows[0]["flag"].ToString() != "")
                {
                    this.flag = int.Parse(ds.Tables[0].Rows[0]["flag"].ToString());
                }
            }
        }

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {

            return DbHelperSQL.GetMaxID("id", "tbl_sinkia_attribute");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from [tbl_sinkia_attribute]");
            strSql.Append(" where id=@id ");

            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = id;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into [tbl_sinkia_attribute] (");
            strSql.Append("attribute_name,attribute_value,flag)");
            strSql.Append(" values (");
            strSql.Append("@attribute_name,@attribute_value,@flag)");
            SqlParameter[] parameters = {
				
					new SqlParameter("@attribute_name", SqlDbType.VarChar,50),
					new SqlParameter("@attribute_value", SqlDbType.VarChar,100),
					new SqlParameter("@flag", SqlDbType.Int,4)};
      
            parameters[0].Value = attribute_name;
            parameters[1].Value = attribute_value;
            parameters[2].Value = flag;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update [tbl_sinkia_attribute] set ");
            strSql.Append("attribute_name=@attribute_name,");
            strSql.Append("attribute_value=@attribute_value,");
            strSql.Append("flag=@flag");
            strSql.Append(" where id=@id ");
            SqlParameter[] parameters = {
					new SqlParameter("@attribute_name", SqlDbType.VarChar,50),
					new SqlParameter("@attribute_value", SqlDbType.VarChar,100),
					new SqlParameter("@flag", SqlDbType.Int,4),
					new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = attribute_name;
            parameters[1].Value = attribute_value;
            parameters[2].Value = flag;
            parameters[3].Value = id;

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
            strSql.Append("delete from [tbl_sinkia_attribute] ");
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
            strSql.Append("select id,attribute_name,attribute_value,flag ");
            strSql.Append(" FROM [tbl_sinkia_attribute] ");
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
                if (ds.Tables[0].Rows[0]["attribute_name"] != null)
                {
                    this.attribute_name = ds.Tables[0].Rows[0]["attribute_name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["attribute_value"] != null)
                {
                    this.attribute_value = ds.Tables[0].Rows[0]["attribute_value"].ToString();
                }
                if (ds.Tables[0].Rows[0]["flag"] != null && ds.Tables[0].Rows[0]["flag"].ToString() != "")
                {
                    this.flag = int.Parse(ds.Tables[0].Rows[0]["flag"].ToString());
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
            strSql.Append(" FROM [tbl_sinkia_attribute] ");
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
            strSql.Append("select * FROM  tbl_sinkia_attribute");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            recordCount = Convert.ToInt32(DbHelperSQL.GetSingle(PagingHelper.CreateCountingSql(strSql.ToString())));
            return DbHelperSQL.Query(PagingHelper.CreatePagingSql(recordCount, pageSize, pageIndex, strSql.ToString(), filedOrder));
        }

        #endregion  Method
    }
 
