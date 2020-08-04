using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
 
	/// <summary>
	/// 类tbl_login。
	/// </summary>
	[Serializable]
	public partial class tbl_login
	{
		public tbl_login()
		{}
		#region Model
		private int _id;
		private string _huiyuan_ip;
		private string _huiyuan_bianhao;
		private string _huiyuan_name;
		private DateTime? _login_date;
		private int? _login_flag=0;
		/// <summary>
		/// 识别id
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 登录ip
		/// </summary>
		public string huiyuan_ip
		{
			set{ _huiyuan_ip=value;}
			get{return _huiyuan_ip;}
		}
		/// <summary>
		/// 登录编号
		/// </summary>
		public string huiyuan_bianhao
		{
			set{ _huiyuan_bianhao=value;}
			get{return _huiyuan_bianhao;}
		}
		/// <summary>
		/// 登录姓名
		/// </summary>
		public string huiyuan_name
		{
			set{ _huiyuan_name=value;}
			get{return _huiyuan_name;}
		}
		/// <summary>
		/// 登录时间
		/// </summary>
		public DateTime? login_date
		{
			set{ _login_date=value;}
			get{return _login_date;}
		}
		/// <summary>
		/// 是否管理员登录
		/// </summary>
		public int? login_flag
		{
			set{ _login_flag=value;}
			get{return _login_flag;}
		}
		#endregion Model


		#region  Method

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public tbl_login(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,huiyuan_ip,huiyuan_bianhao,huiyuan_name,login_date,login_flag ");
			strSql.Append(" FROM [tbl_login] ");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = id;

			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["id"]!=null && ds.Tables[0].Rows[0]["id"].ToString()!="")
				{
					this.id=int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["huiyuan_ip"]!=null)
				{
					this.huiyuan_ip=ds.Tables[0].Rows[0]["huiyuan_ip"].ToString();
				}
				if(ds.Tables[0].Rows[0]["huiyuan_bianhao"]!=null)
				{
					this.huiyuan_bianhao=ds.Tables[0].Rows[0]["huiyuan_bianhao"].ToString();
				}
				if(ds.Tables[0].Rows[0]["huiyuan_name"]!=null)
				{
					this.huiyuan_name=ds.Tables[0].Rows[0]["huiyuan_name"].ToString();
				}
				if(ds.Tables[0].Rows[0]["login_date"]!=null && ds.Tables[0].Rows[0]["login_date"].ToString()!="")
				{
					this.login_date=DateTime.Parse(ds.Tables[0].Rows[0]["login_date"].ToString());
				}
				if(ds.Tables[0].Rows[0]["login_flag"]!=null && ds.Tables[0].Rows[0]["login_flag"].ToString()!="")
				{
					this.login_flag=int.Parse(ds.Tables[0].Rows[0]["login_flag"].ToString());
				}
			}
		}
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from [tbl_login]");
			strSql.Append(" where id=@id ");

			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into [tbl_login] (");
			strSql.Append("huiyuan_ip,huiyuan_bianhao,huiyuan_name,login_date,login_flag)");
			strSql.Append(" values (");
			strSql.Append("@huiyuan_ip,@huiyuan_bianhao,@huiyuan_name,@login_date,@login_flag)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@huiyuan_ip", SqlDbType.VarChar,50),
					new SqlParameter("@huiyuan_bianhao", SqlDbType.VarChar,50),
					new SqlParameter("@huiyuan_name", SqlDbType.VarChar,50),
					new SqlParameter("@login_date", SqlDbType.DateTime),
					new SqlParameter("@login_flag", SqlDbType.Int,4)};
			parameters[0].Value = huiyuan_ip;
			parameters[1].Value = huiyuan_bianhao;
			parameters[2].Value = huiyuan_name;
			parameters[3].Value = login_date;
			parameters[4].Value = login_flag;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
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
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update [tbl_login] set ");
			strSql.Append("huiyuan_ip=@huiyuan_ip,");
			strSql.Append("huiyuan_bianhao=@huiyuan_bianhao,");
			strSql.Append("huiyuan_name=@huiyuan_name,");
			strSql.Append("login_date=@login_date,");
			strSql.Append("login_flag=@login_flag");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@huiyuan_ip", SqlDbType.VarChar,50),
					new SqlParameter("@huiyuan_bianhao", SqlDbType.VarChar,50),
					new SqlParameter("@huiyuan_name", SqlDbType.VarChar,50),
					new SqlParameter("@login_date", SqlDbType.DateTime),
					new SqlParameter("@login_flag", SqlDbType.Int,4),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = huiyuan_ip;
			parameters[1].Value = huiyuan_bianhao;
			parameters[2].Value = huiyuan_name;
			parameters[3].Value = login_date;
			parameters[4].Value = login_flag;
			parameters[5].Value = id;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from [tbl_login] ");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = id;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,huiyuan_ip,huiyuan_bianhao,huiyuan_name,login_date,login_flag ");
			strSql.Append(" FROM [tbl_login] ");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = id;

			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["id"]!=null && ds.Tables[0].Rows[0]["id"].ToString()!="")
				{
					this.id=int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["huiyuan_ip"]!=null )
				{
					this.huiyuan_ip=ds.Tables[0].Rows[0]["huiyuan_ip"].ToString();
				}
				if(ds.Tables[0].Rows[0]["huiyuan_bianhao"]!=null )
				{
					this.huiyuan_bianhao=ds.Tables[0].Rows[0]["huiyuan_bianhao"].ToString();
				}
				if(ds.Tables[0].Rows[0]["huiyuan_name"]!=null )
				{
					this.huiyuan_name=ds.Tables[0].Rows[0]["huiyuan_name"].ToString();
				}
				if(ds.Tables[0].Rows[0]["login_date"]!=null && ds.Tables[0].Rows[0]["login_date"].ToString()!="")
				{
					this.login_date=DateTime.Parse(ds.Tables[0].Rows[0]["login_date"].ToString());
				}
				if(ds.Tables[0].Rows[0]["login_flag"]!=null && ds.Tables[0].Rows[0]["login_flag"].ToString()!="")
				{
					this.login_flag=int.Parse(ds.Tables[0].Rows[0]["login_flag"].ToString());
				}
			}
		}
         
        /// <summary>
        /// 得到一个对象实体,ROW_NUMBER() 获取倒数第二条记录
        /// </summary>
        public void GetModel_last(string huiyuan_bianhao)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top 2 id,huiyuan_ip,huiyuan_bianhao,huiyuan_name,login_date,login_flag ");
            strSql.Append(" FROM (SELECT ROW_NUMBER() OVER(ORDER BY login_date DESC) AS rowNum, * FROM tbl_login) AS t ");
            strSql.Append(" where huiyuan_bianhao=@huiyuan_bianhao and rowNum=2   ");
            SqlParameter[] parameters = {
					new SqlParameter("@huiyuan_bianhao", SqlDbType.VarChar,50)};
            parameters[0].Value = huiyuan_bianhao;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["id"] != null && ds.Tables[0].Rows[0]["id"].ToString() != "")
                {
                    this.id = int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["huiyuan_ip"] != null)
                {
                    this.huiyuan_ip = ds.Tables[0].Rows[0]["huiyuan_ip"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_bianhao"] != null)
                {
                    this.huiyuan_bianhao = ds.Tables[0].Rows[0]["huiyuan_bianhao"].ToString();
                }
                if (ds.Tables[0].Rows[0]["huiyuan_name"] != null)
                {
                    this.huiyuan_name = ds.Tables[0].Rows[0]["huiyuan_name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["login_date"] != null && ds.Tables[0].Rows[0]["login_date"].ToString() != "")
                {
                    this.login_date = DateTime.Parse(ds.Tables[0].Rows[0]["login_date"].ToString());
                }
                if (ds.Tables[0].Rows[0]["login_flag"] != null && ds.Tables[0].Rows[0]["login_flag"].ToString() != "")
                {
                    this.login_flag = int.Parse(ds.Tables[0].Rows[0]["login_flag"].ToString());
                }
            }
        }
		 /// <summary>
        /// 获得查询分页数据
        /// </summary>
        public DataSet GetList(int pageSize, int pageIndex, string strWhere, string filedOrder, out int recordCount)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * FROM  tbl_login   ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            recordCount = Convert.ToInt32(DbHelperSQL.GetSingle(PagingHelper.CreateCountingSql(strSql.ToString())));
            return DbHelperSQL.Query(PagingHelper.CreatePagingSql(recordCount, pageSize, pageIndex, strSql.ToString(), filedOrder));
        }
	 

		#endregion  Method
	}
 

