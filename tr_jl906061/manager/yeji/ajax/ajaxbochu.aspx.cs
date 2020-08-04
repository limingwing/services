using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class manager_yeji_ajax_ajaxbochu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Write(ProcessContent());
        Response.End();
    }
    private string ProcessContent()
    {
        Random random = new Random(100);
        //DateTime dtBeginDate = DateTime.Parse("2013-09-10");
        System.Collections.ArrayList arrList = new System.Collections.ArrayList();
        IList<data> dataList = new List<data>();//存储第一条曲线数据
        IList<data> dataList2 = new List<data>();//存储第二条曲线数据
        // for (int i = 0; i < 135; i++)
        //{
        // dataList.Add(new data(dtBeginDate.ToString(), random.Next(100)));
        // dtBeginDate = dtBeginDate.AddMinutes(5);
        //}

        string sql = " SELECT ISNULL(SUM(jiesuan_jiangjin), 0) AS jiangjin, CONVERT(char(11), jiesuan_date, 120) AS date FROM tbl_bochu       GROUP BY CONVERT(char(11), jiesuan_date, 120) ORDER BY CONVERT(char(11), jiesuan_date, 120) DESC";
        DataSet ds = DbHelperSQL.Query(sql);
        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {

            dataList.Add(new data(ds.Tables[0].Rows[i]["date"].ToString(), Convert.ToDouble(ds.Tables[0].Rows[i]["jiangjin"].ToString())));


        }

        string sql2 = " SELECT ISNULL(SUM(jiesuan_yeji), 0) AS yeji, CONVERT(char(11), jiesuan_date, 120) AS date FROM tbl_bochu       GROUP BY CONVERT(char(11), jiesuan_date, 120) ORDER BY CONVERT(char(11), jiesuan_date, 120) DESC";
        DataSet ds2 = DbHelperSQL.Query(sql2);
        for (int i = 0; i < ds2.Tables[0].Rows.Count; i++)
        {

            dataList2.Add(new data(ds2.Tables[0].Rows[i]["date"].ToString(), Convert.ToDouble(ds2.Tables[0].Rows[i]["yeji"].ToString())));


        }


        ////第2条曲线数据
        //DateTime dtBeginDate1 = DateTime.Parse("2012-02-01");
        //for (int i = 0; i < 6; i++)
        //{
        //    dataList2.Add(new data(dtBeginDate1.ToString(), random.Next(100)));
        //    dtBeginDate1 = dtBeginDate1.AddMinutes(5);
        //}

        arrList.Add(dataList);
        arrList.Add(dataList2);

        System.Text.StringBuilder sb = new System.Text.StringBuilder();
        System.Web.Script.Serialization.JavaScriptSerializer jscriptSeri = new System.Web.Script.Serialization.JavaScriptSerializer();
        jscriptSeri.Serialize(arrList, sb);
        return sb.ToString();
    }
    class data
    {
        public data(string _dTime, Double _v)
        {
            this.dTime = _dTime;
            this.V = _v;
        }
        public string dTime { set; get; }
        public Double V { set; get; }
    }
}