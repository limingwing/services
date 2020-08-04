using System;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Linq;
using System.Configuration;

//访问数据库命名空间
using System.Data;
using System.Data.SqlClient;

//访问web.config命名空间
using System.Web.Configuration;

//导入ScriptServiceAttribute类的命名空间
using System.Web.Script.Services;

//返回CascadingDropDownNameValue数组所需的命名空间
using AjaxControlToolkit;
using System.Collections.Generic;
using System.Collections.Specialized;

/// <summary>
///WebService 的摘要说明
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
//若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消对下行的注释。 
[System.Web.Script.Services.ScriptService]
public class WebService : System.Web.Services.WebService
{

    public WebService()
    {

        //如果使用设计的组件，请取消注释以下行 
        //InitializeComponent(); 
    }

    [WebMethod]
    public CascadingDropDownNameValue[] GetproviceNames(string knownCategoryValues, string category)
    {
        List<CascadingDropDownNameValue> values = new List<CascadingDropDownNameValue>();
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        SqlCommand comm = conn.CreateCommand();
        comm.CommandText = "select [ProID],[ProName] from [t_Province] order by 1";
        conn.Open();
        try
        {
            SqlDataReader dr = comm.ExecuteReader();
            while (dr.Read())
            {
                values.Add(new CascadingDropDownNameValue(dr[1].ToString(), dr[0].ToString()));
            }
            return values.ToArray();
        }
        finally
        {
            conn.Close();
        }
    }
    [WebMethod]
    public CascadingDropDownNameValue[] GetCityNames(string knownCategoryValues, string category)
    {
        StringDictionary kcv = CascadingDropDown.ParseKnownCategoryValuesString(knownCategoryValues);
        if (!kcv.ContainsKey("provice"))
        {
            return null;
        }
        List<CascadingDropDownNameValue> values = new List<CascadingDropDownNameValue>();
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        SqlCommand comm = conn.CreateCommand();
        comm.CommandText = "select [CityID],[CityName] from [t_City] where [ProID]=@ProvinceID order by 1";
        comm.Parameters.Add("@ProvinceID", SqlDbType.Int).Value = kcv["provice"];
        conn.Open();
        try
        {
            SqlDataReader dr = comm.ExecuteReader();
            while (dr.Read())
            {
                values.Add(new CascadingDropDownNameValue(dr[1].ToString(), dr[0].ToString()));
            }
            return values.ToArray();
        }
        finally
        {
            conn.Close();
        }
    }
    [WebMethod]
    public CascadingDropDownNameValue[] GetDistrictNames(string knownCategoryValues, string category)
    {
        StringDictionary kcv = CascadingDropDown.ParseKnownCategoryValuesString(knownCategoryValues);
        if (!kcv.ContainsKey("city"))
        {
            return null;
        }
        List<CascadingDropDownNameValue> values = new List<CascadingDropDownNameValue>();
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        SqlCommand comm = conn.CreateCommand();
        comm.CommandText = "select [Id],[DisName] from [T_District] where [CityID]=@CityID order by 1";
        comm.Parameters.Add("@CityID", SqlDbType.Int).Value = kcv["city"];
        conn.Open();
        try
        {
            SqlDataReader dr = comm.ExecuteReader();
            while (dr.Read())
            {
                values.Add(new CascadingDropDownNameValue(dr[1].ToString(), dr[0].ToString()));
            }
            return values.ToArray();
        }
        finally
        {
            conn.Close();
        }
    }
}