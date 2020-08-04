using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
 
 
    /// <summary>
    /// 类tbl_reg_jiebie。
    /// </summary>
    [Serializable]
    public partial class tbl_reg_jiebie
    {
        public tbl_reg_jiebie()
        { }
        #region Model
        private int _id;
        private string _jiebie_name;
        private int? _jiebie_value = 0;
        private decimal? _need_money = 0M;
        private int? _sort_id = 0;
        private int? _show_flag = 0;
        /// <summary>
        /// 
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 级别名称
        /// </summary>
        public string jiebie_name
        {
            set { _jiebie_name = value; }
            get { return _jiebie_name; }
        }
        /// <summary>
        /// 级别赋值
        /// </summary>
        public int? jiebie_value
        {
            set { _jiebie_value = value; }
            get { return _jiebie_value; }
        }
        /// <summary>
        /// 级别所需金额
        /// </summary>
        public decimal? need_money
        {
            set { _need_money = value; }
            get { return _need_money; }
        }
        /// <summary>
        /// 排序号
        /// </summary>
        public int? sort_id
        {
            set { _sort_id = value; }
            get { return _sort_id; }
        }


        /// <summary>
        /// 是否显示
        /// </summary>
        public int? show_flag
        {
            set { _show_flag = value; }
            get { return _show_flag; }
        }
        #endregion Model


        #region  Method

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public tbl_reg_jiebie(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,jiebie_name,jiebie_value,need_money,sort_id ");
            strSql.Append(" FROM [tbl_reg_jiebie] ");
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
                if (ds.Tables[0].Rows[0]["jiebie_name"] != null)
                {
                    this.jiebie_name = ds.Tables[0].Rows[0]["jiebie_name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["jiebie_value"] != null && ds.Tables[0].Rows[0]["jiebie_value"].ToString() != "")
                {
                    this.jiebie_value = int.Parse(ds.Tables[0].Rows[0]["jiebie_value"].ToString());
                }
                if (ds.Tables[0].Rows[0]["need_money"] != null && ds.Tables[0].Rows[0]["need_money"].ToString() != "")
                {
                    this.need_money = decimal.Parse(ds.Tables[0].Rows[0]["need_money"].ToString());
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
        public bool Exists()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from [tbl_reg_jiebie]");
            strSql.Append(" where id=@id ");

            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = id;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 查询级别名称是否存在
        /// </summary>
        public bool Exists(string jiebie_name)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from  tbl_reg_jiebie");
            strSql.Append(" where jiebie_name=@jiebie_name ");
            SqlParameter[] parameters = {
					new SqlParameter("@jiebie_name", SqlDbType.NVarChar,100)};
            parameters[0].Value = jiebie_name;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 查询级别赋值是否存在
        /// </summary>
        public bool Exists_jb_value(int jiebie_value)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from  tbl_reg_jiebie");
            strSql.Append(" where jiebie_value=@jiebie_value ");
            SqlParameter[] parameters = {
					new SqlParameter("@jiebie_value", SqlDbType.NVarChar,100)};
            parameters[0].Value = jiebie_value;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 查询排除级别名称是否存在
        /// </summary>
        public bool Exists(string jiebie_name, int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from  tbl_reg_jiebie");
            strSql.Append(" where  id<>@id and  jiebie_name=@jiebie_name ");
            SqlParameter[] parameters = {
                     new SqlParameter("@id", SqlDbType.Int,4),
					new SqlParameter("@jiebie_name", SqlDbType.NVarChar,100)};
            parameters[0].Value = id;
            parameters[1].Value = jiebie_name;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 查询排除级别赋值是否存在
        /// </summary>
        public bool Exists_jb_value(int jiebie_value, int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from  tbl_reg_jiebie");
            strSql.Append(" where  id<>@id and  jiebie_value=@jiebie_value ");
            SqlParameter[] parameters = {
                     new SqlParameter("@id", SqlDbType.Int,4),
					new SqlParameter("@jiebie_value", SqlDbType.Int,4)};
            parameters[0].Value = id;
            parameters[1].Value = jiebie_value;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 返回会员级别名称
        /// </summary>
        public string GetTitle(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top 1 jiebie_name from [tbl_reg_jiebie]");
            strSql.Append(" where jiebie_value=" + id);
            string title = Convert.ToString(DbHelperSQL.GetSingle(strSql.ToString()));
            if (string.IsNullOrEmpty(title))
            {
                return "";
            }
            return title;
        }

        /// <summary>
        /// 返回会员级别名称
        /// </summary>
        public string color(int id)
        {
            //StringBuilder strSql = new StringBuilder();
            //strSql.Append("select top 1 jiebie_name from [tbl_reg_jiebie]");
            //strSql.Append(" where jiebie_value=" + id);
             string title ="";
                 switch (id)
                {
　                  case 1 :
                        title = "background-color:rgba(76,212,66,1);";
　　                break;
　                  case 2 :
                  title = "background-color:rgba(76,212,66,1);";
　　                break;
　                  case 3 :
                  title = "background-color:rgba(76,212,66,1);";
　　                break;
                    case 4 :
                  title = "background-color:rgba(76,212,66,1);";
                    break;
　                  default :
                        title = "";
　　                break;
                }

           
            if (string.IsNullOrEmpty(title))
            {
                return "";
            }
            return title;
        }

        /// <summary>
        /// 返回会员级别所需金额
        /// </summary>
        public decimal Get_Need_money(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top 1 need_money from [tbl_reg_jiebie]");
            strSql.Append(" where jiebie_value=" + id);
            decimal Need_money = Convert.ToDecimal(DbHelperSQL.GetSingle(strSql.ToString()));
           
            return Need_money;
        }
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into [tbl_reg_jiebie] (");
            strSql.Append("jiebie_name,jiebie_value,need_money,sort_id,show_flag)");
            strSql.Append(" values (");
            strSql.Append("@jiebie_name,@jiebie_value,@need_money,@sort_id,@show_flag)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@jiebie_name", SqlDbType.VarChar,50),
					new SqlParameter("@jiebie_value", SqlDbType.Int,4),
					new SqlParameter("@need_money", SqlDbType.Money,8),
					new SqlParameter("@sort_id", SqlDbType.Int,4),
                    new SqlParameter("@show_flag", SqlDbType.Int,4)};
            parameters[0].Value = jiebie_name;
            parameters[1].Value = jiebie_value;
            parameters[2].Value = need_money;
            parameters[3].Value = sort_id;
            parameters[4].Value = show_flag;

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
            strSql.Append("update [tbl_reg_jiebie] set ");
            strSql.Append("jiebie_name=@jiebie_name,");
            strSql.Append("jiebie_value=@jiebie_value,");
            strSql.Append("need_money=@need_money,");
            strSql.Append("sort_id=@sort_id,");
            strSql.Append("show_flag=@show_flag");
            strSql.Append(" where id=@id ");
            SqlParameter[] parameters = {
					new SqlParameter("@jiebie_name", SqlDbType.VarChar,50),
					new SqlParameter("@jiebie_value", SqlDbType.Int,4),
					new SqlParameter("@need_money", SqlDbType.Money,8),
					new SqlParameter("@sort_id", SqlDbType.Int,4),
                    new SqlParameter("@show_flag", SqlDbType.Int,4),
					new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = jiebie_name;
            parameters[1].Value = jiebie_value;
            parameters[2].Value = need_money;
            parameters[3].Value = sort_id;
            parameters[4].Value = show_flag;
            parameters[5].Value = id;

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
        /// 修改一列数据
        /// </summary>
        public void UpdateField(int id, string strValue)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tbl_reg_jiebie set " + strValue);
            strSql.Append(" where id=" + id);
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from [tbl_reg_jiebie] ");
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
            strSql.Append("select id,jiebie_name,jiebie_value,need_money,sort_id,show_flag ");
            strSql.Append(" FROM [tbl_reg_jiebie] ");
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
                if (ds.Tables[0].Rows[0]["jiebie_name"] != null)
                {
                    this.jiebie_name = ds.Tables[0].Rows[0]["jiebie_name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["jiebie_value"] != null && ds.Tables[0].Rows[0]["jiebie_value"].ToString() != "")
                {
                    this.jiebie_value = int.Parse(ds.Tables[0].Rows[0]["jiebie_value"].ToString());
                }
                if (ds.Tables[0].Rows[0]["need_money"] != null && ds.Tables[0].Rows[0]["need_money"].ToString() != "")
                {
                    this.need_money = decimal.Parse(ds.Tables[0].Rows[0]["need_money"].ToString());
                }
                if (ds.Tables[0].Rows[0]["sort_id"] != null && ds.Tables[0].Rows[0]["sort_id"].ToString() != "")
                {
                    this.sort_id = int.Parse(ds.Tables[0].Rows[0]["sort_id"].ToString());
                }

                if (ds.Tables[0].Rows[0]["show_flag"] != null && ds.Tables[0].Rows[0]["show_flag"].ToString() != "")
                {
                    this.show_flag = int.Parse(ds.Tables[0].Rows[0]["show_flag"].ToString());
                }
            }
        }
        public void GetModeljibie(int jibie)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,jiebie_name,jiebie_value,need_money,sort_id,show_flag ");
            strSql.Append(" FROM [tbl_reg_jiebie] ");
            strSql.Append(" where jiebie_value=@jiebie_value ");
            SqlParameter[] parameters = {
					new SqlParameter("@jiebie_value", SqlDbType.Int,4)};
            parameters[0].Value = jibie;
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["id"] != null && ds.Tables[0].Rows[0]["id"].ToString() != "")
                {
                    this.id = int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["jiebie_name"] != null)
                {
                    this.jiebie_name = ds.Tables[0].Rows[0]["jiebie_name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["jiebie_value"] != null && ds.Tables[0].Rows[0]["jiebie_value"].ToString() != "")
                {
                    this.jiebie_value = int.Parse(ds.Tables[0].Rows[0]["jiebie_value"].ToString());
                }
                if (ds.Tables[0].Rows[0]["need_money"] != null && ds.Tables[0].Rows[0]["need_money"].ToString() != "")
                {
                    this.need_money = decimal.Parse(ds.Tables[0].Rows[0]["need_money"].ToString());
                }
                if (ds.Tables[0].Rows[0]["sort_id"] != null && ds.Tables[0].Rows[0]["sort_id"].ToString() != "")
                {
                    this.sort_id = int.Parse(ds.Tables[0].Rows[0]["sort_id"].ToString());
                }

                if (ds.Tables[0].Rows[0]["show_flag"] != null && ds.Tables[0].Rows[0]["show_flag"].ToString() != "")
                {
                    this.show_flag = int.Parse(ds.Tables[0].Rows[0]["show_flag"].ToString());
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
            strSql.Append(" FROM [tbl_reg_jiebie] ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// <summary>
        /// 获得查询分页数据
        /// </summary>
        public DataSet GetList(int pageSize, int pageIndex, string strWhere, string filedOrder, out int recordCount)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * FROM  tbl_reg_jiebie");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            recordCount = Convert.ToInt32(DbHelperSQL.GetSingle(PagingHelper.CreateCountingSql(strSql.ToString())));
            return DbHelperSQL.Query(PagingHelper.CreatePagingSql(recordCount, pageSize, pageIndex, strSql.ToString(), filedOrder));
        }
        #endregion  Method
    }
 

