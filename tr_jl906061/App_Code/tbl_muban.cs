using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
 
 
    /// <summary>
    /// 类tbl_muban。
    /// </summary>
    [Serializable]
    public partial class tbl_muban
    {
        public tbl_muban()
        { }
        #region Model
        private int _id;
        private string _name;
        private string _img_src;
        private int? _show_flag = 0;
        private string _muban_src;
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
        public string name
        {
            set { _name = value; }
            get { return _name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string img_src
        {
            set { _img_src = value; }
            get { return _img_src; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? show_flag
        {
            set { _show_flag = value; }
            get { return _show_flag; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string muban_src
        {
            set { _muban_src = value; }
            get { return _muban_src; }
        }
        #endregion Model


        #region  Method

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public tbl_muban(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,name,img_src,show_flag,muban_src ");
            strSql.Append(" FROM [tbl_muban] ");
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
                if (ds.Tables[0].Rows[0]["name"] != null)
                {
                    this.name = ds.Tables[0].Rows[0]["name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["img_src"] != null)
                {
                    this.img_src = ds.Tables[0].Rows[0]["img_src"].ToString();
                }
                if (ds.Tables[0].Rows[0]["show_flag"] != null && ds.Tables[0].Rows[0]["show_flag"].ToString() != "")
                {
                    this.show_flag = int.Parse(ds.Tables[0].Rows[0]["show_flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["muban_src"] != null)
                {
                    this.muban_src = ds.Tables[0].Rows[0]["muban_src"].ToString();
                }
            }
        }
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from [tbl_muban]");
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
            strSql.Append("insert into [tbl_muban] (");
            strSql.Append("name,img_src,show_flag,muban_src)");
            strSql.Append(" values (");
            strSql.Append("@name,@img_src,@show_flag,@muban_src)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@name", SqlDbType.VarChar,50),
					new SqlParameter("@img_src", SqlDbType.VarChar,50),
					new SqlParameter("@show_flag", SqlDbType.Int,4),
					new SqlParameter("@muban_src", SqlDbType.VarChar,50)};
            parameters[0].Value = name;
            parameters[1].Value = img_src;
            parameters[2].Value = show_flag;
            parameters[3].Value = muban_src;

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
            strSql.Append("update [tbl_muban] set ");
            strSql.Append("name=@name,");
            strSql.Append("img_src=@img_src,");
            strSql.Append("show_flag=@show_flag,");
            strSql.Append("muban_src=@muban_src");
            strSql.Append(" where id=@id ");
            SqlParameter[] parameters = {
					new SqlParameter("@name", SqlDbType.VarChar,50),
					new SqlParameter("@img_src", SqlDbType.VarChar,50),
					new SqlParameter("@show_flag", SqlDbType.Int,4),
					new SqlParameter("@muban_src", SqlDbType.VarChar,50),
					new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = name;
            parameters[1].Value = img_src;
            parameters[2].Value = show_flag;
            parameters[3].Value = muban_src;
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
            strSql.Append("delete from [tbl_muban] ");
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
            strSql.Append("select id,name,img_src,show_flag,muban_src ");
            strSql.Append(" FROM [tbl_muban] ");
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
                if (ds.Tables[0].Rows[0]["name"] != null)
                {
                    this.name = ds.Tables[0].Rows[0]["name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["img_src"] != null)
                {
                    this.img_src = ds.Tables[0].Rows[0]["img_src"].ToString();
                }
                if (ds.Tables[0].Rows[0]["show_flag"] != null && ds.Tables[0].Rows[0]["show_flag"].ToString() != "")
                {
                    this.show_flag = int.Parse(ds.Tables[0].Rows[0]["show_flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["muban_src"] != null)
                {
                    this.muban_src = ds.Tables[0].Rows[0]["muban_src"].ToString();
                }
            }
        }


        /// <summary>
        /// 得到一个启用的模板
        /// </summary>
        public void GetModel_show(int show_flag)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,name,img_src,show_flag,muban_src ");
            strSql.Append(" FROM [tbl_muban] ");
            strSql.Append(" where show_flag=@show_flag ");
            SqlParameter[] parameters = {
					new SqlParameter("@show_flag", SqlDbType.Int,4)};
            parameters[0].Value = show_flag;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["id"] != null && ds.Tables[0].Rows[0]["id"].ToString() != "")
                {
                    this.id = int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["name"] != null)
                {
                    this.name = ds.Tables[0].Rows[0]["name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["img_src"] != null)
                {
                    this.img_src = ds.Tables[0].Rows[0]["img_src"].ToString();
                }
                if (ds.Tables[0].Rows[0]["show_flag"] != null && ds.Tables[0].Rows[0]["show_flag"].ToString() != "")
                {
                    this.show_flag = int.Parse(ds.Tables[0].Rows[0]["show_flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["muban_src"] != null)
                {
                    this.muban_src = ds.Tables[0].Rows[0]["muban_src"].ToString();
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
            strSql.Append(" FROM [tbl_muban] ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// 获得查询分页数据
        /// </summary>
        public DataSet GetList(int pageSize, int pageIndex, string strWhere, string filedOrder, out int recordCount)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * FROM  tbl_muban");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            recordCount = Convert.ToInt32(DbHelperSQL.GetSingle(PagingHelper.CreateCountingSql(strSql.ToString())));
            return DbHelperSQL.Query(PagingHelper.CreatePagingSql(recordCount, pageSize, pageIndex, strSql.ToString(), filedOrder));
        }


        #endregion  Method
    }
 

