using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
 
    /// <summary>
    /// 类tbl_sinkia_sub。
    /// </summary>
    [Serializable]
    public partial class tbl_sinkia_sub
    {
        public tbl_sinkia_sub()
        { }
        #region Model
        private int _id;
        private string _pro_class;
        private int? _pid;
        private int? _type;
        private int? _flag;
        private int? _sort_id = 0;
        private string _class_mob_img;
        private string _class_shop_img;
        private int? _is_show = 0;
        /// <summary>
        /// 
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 产品类别名称
        /// </summary>
        public string pro_class
        {
            set { _pro_class = value; }
            get { return _pro_class; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? pid
        {
            set { _pid = value; }
            get { return _pid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? type
        {
            set { _type = value; }
            get { return _type; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? flag
        {
            set { _flag = value; }
            get { return _flag; }
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
        /// 
        /// </summary>
        public string class_mob_img
        {
            set { _class_mob_img = value; }
            get { return _class_mob_img; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string class_shop_img
        {
            set { _class_shop_img = value; }
            get { return _class_shop_img; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? is_show
        {
            set { _is_show = value; }
            get { return _is_show; }
        }
        #endregion Model


        #region  Method

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public tbl_sinkia_sub(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,pro_class,pid,type,flag,sort_id,class_mob_img,class_shop_img,is_show ");
            strSql.Append(" FROM [tbl_sinkia_sub] ");
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
                if (ds.Tables[0].Rows[0]["pro_class"] != null)
                {
                    this.pro_class = ds.Tables[0].Rows[0]["pro_class"].ToString();
                }
                if (ds.Tables[0].Rows[0]["pid"] != null && ds.Tables[0].Rows[0]["pid"].ToString() != "")
                {
                    this.pid = int.Parse(ds.Tables[0].Rows[0]["pid"].ToString());
                }
                if (ds.Tables[0].Rows[0]["type"] != null && ds.Tables[0].Rows[0]["type"].ToString() != "")
                {
                    this.type = int.Parse(ds.Tables[0].Rows[0]["type"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag"] != null && ds.Tables[0].Rows[0]["flag"].ToString() != "")
                {
                    this.flag = int.Parse(ds.Tables[0].Rows[0]["flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["sort_id"] != null && ds.Tables[0].Rows[0]["sort_id"].ToString() != "")
                {
                    this.sort_id = int.Parse(ds.Tables[0].Rows[0]["sort_id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["class_mob_img"] != null)
                {
                    this.class_mob_img = ds.Tables[0].Rows[0]["class_mob_img"].ToString();
                }
                if (ds.Tables[0].Rows[0]["class_shop_img"] != null)
                {
                    this.class_shop_img = ds.Tables[0].Rows[0]["class_shop_img"].ToString();
                }
                if (ds.Tables[0].Rows[0]["is_show"] != null && ds.Tables[0].Rows[0]["is_show"].ToString() != "")
                {
                    this.is_show = int.Parse(ds.Tables[0].Rows[0]["is_show"].ToString());
                }
            }
        }
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from [tbl_sinkia_sub]");
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
            strSql.Append("insert into [tbl_sinkia_sub] (");
            strSql.Append("pro_class,pid,type,flag,sort_id,class_mob_img,class_shop_img,is_show)");
            strSql.Append(" values (");
            strSql.Append("@pro_class,@pid,@type,@flag,@sort_id,@class_mob_img,@class_shop_img,@is_show)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@pro_class", SqlDbType.VarChar,200),
					new SqlParameter("@pid", SqlDbType.Int,4),
					new SqlParameter("@type", SqlDbType.Int,4),
					new SqlParameter("@flag", SqlDbType.Int,4),
					new SqlParameter("@sort_id", SqlDbType.Int,4),
					new SqlParameter("@class_mob_img", SqlDbType.VarChar,500),
					new SqlParameter("@class_shop_img", SqlDbType.VarChar,500),
					new SqlParameter("@is_show", SqlDbType.Int,4)};
            parameters[0].Value = pro_class;
            parameters[1].Value = pid;
            parameters[2].Value = type;
            parameters[3].Value = flag;
            parameters[4].Value = sort_id;
            parameters[5].Value = class_mob_img;
            parameters[6].Value = class_shop_img;
            parameters[7].Value = is_show;

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
            strSql.Append("update tbl_sinkia_sub set " + strValue);
            strSql.Append(" where id=" + id);
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update [tbl_sinkia_sub] set ");
            strSql.Append("pro_class=@pro_class,");
            strSql.Append("pid=@pid,");
            strSql.Append("type=@type,");
            strSql.Append("flag=@flag,");
            strSql.Append("sort_id=@sort_id,");
            strSql.Append("class_mob_img=@class_mob_img,");
            strSql.Append("class_shop_img=@class_shop_img,");
            strSql.Append("is_show=@is_show");
            strSql.Append(" where id=@id ");
            SqlParameter[] parameters = {
					new SqlParameter("@pro_class", SqlDbType.VarChar,200),
					new SqlParameter("@pid", SqlDbType.Int,4),
					new SqlParameter("@type", SqlDbType.Int,4),
					new SqlParameter("@flag", SqlDbType.Int,4),
					new SqlParameter("@sort_id", SqlDbType.Int,4),
					new SqlParameter("@class_mob_img", SqlDbType.VarChar,500),
					new SqlParameter("@class_shop_img", SqlDbType.VarChar,500),
					new SqlParameter("@is_show", SqlDbType.Int,4),
					new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = pro_class;
            parameters[1].Value = pid;
            parameters[2].Value = type;
            parameters[3].Value = flag;
            parameters[4].Value = sort_id;
            parameters[5].Value = class_mob_img;
            parameters[6].Value = class_shop_img;
            parameters[7].Value = is_show;
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
            strSql.Append("delete from [tbl_sinkia_sub] ");
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
        /// 返回主类名称
        /// </summary>
        public string GetTitle(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top 1 pro_class from [tbl_sinkia_class]");
            strSql.Append(" where id=" + id);
            string title = Convert.ToString(DbHelperSQL.GetSingle(strSql.ToString()));
            if (string.IsNullOrEmpty(title))
            {
                return "";
            }
            return title;
        }

        /// <summary>
        /// 返回主类名称
        /// </summary>
        public string GetTitle_sub(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top 1 pro_class from [tbl_sinkia_sub]");
            strSql.Append(" where id=" + id);
            string title = Convert.ToString(DbHelperSQL.GetSingle(strSql.ToString()));
            if (string.IsNullOrEmpty(title))
            {
                return "";
            }
            return title;
        }
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public void GetModel(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,pro_class,pid,type,flag,sort_id,class_mob_img,class_shop_img,is_show ");
            strSql.Append(" FROM [tbl_sinkia_sub] ");
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
                if (ds.Tables[0].Rows[0]["pro_class"] != null)
                {
                    this.pro_class = ds.Tables[0].Rows[0]["pro_class"].ToString();
                }
                if (ds.Tables[0].Rows[0]["pid"] != null && ds.Tables[0].Rows[0]["pid"].ToString() != "")
                {
                    this.pid = int.Parse(ds.Tables[0].Rows[0]["pid"].ToString());
                }
                if (ds.Tables[0].Rows[0]["type"] != null && ds.Tables[0].Rows[0]["type"].ToString() != "")
                {
                    this.type = int.Parse(ds.Tables[0].Rows[0]["type"].ToString());
                }
                if (ds.Tables[0].Rows[0]["flag"] != null && ds.Tables[0].Rows[0]["flag"].ToString() != "")
                {
                    this.flag = int.Parse(ds.Tables[0].Rows[0]["flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["sort_id"] != null && ds.Tables[0].Rows[0]["sort_id"].ToString() != "")
                {
                    this.sort_id = int.Parse(ds.Tables[0].Rows[0]["sort_id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["class_mob_img"] != null)
                {
                    this.class_mob_img = ds.Tables[0].Rows[0]["class_mob_img"].ToString();
                }
                if (ds.Tables[0].Rows[0]["class_shop_img"] != null)
                {
                    this.class_shop_img = ds.Tables[0].Rows[0]["class_shop_img"].ToString();
                }
                if (ds.Tables[0].Rows[0]["is_show"] != null && ds.Tables[0].Rows[0]["is_show"].ToString() != "")
                {
                    this.is_show = int.Parse(ds.Tables[0].Rows[0]["is_show"].ToString());
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
            strSql.Append(" FROM [tbl_sinkia_sub] ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList_top(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top 6 * ");
            strSql.Append(" FROM [tbl_sinkia_sub] ");
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
            strSql.Append("select * FROM  tbl_sinkia_sub");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            recordCount = Convert.ToInt32(DbHelperSQL.GetSingle(PagingHelper.CreateCountingSql(strSql.ToString())));
            return DbHelperSQL.Query(PagingHelper.CreatePagingSql(recordCount, pageSize, pageIndex, strSql.ToString(), filedOrder));
        }
        #endregion  Method
    }
 

