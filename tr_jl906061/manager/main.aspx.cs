using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class manager_main : System.Web.UI.Page
{
    public string count = string.Empty;
    public string shouru_z = string.Empty;
    ManagePage mym = new ManagePage();
    protected void Page_Load(object sender, EventArgs e)
    {
        //判断是否登录
        if (!mym.IsAdminLogin())
        {
            Response.Write("<script>parent.location.href='../login.aspx'</script>");
            Response.End();
        }

        if (!Page.IsPostBack)
        {
            ShowInfo();
        }

    }

    #region 赋值操作=================================
    private void ShowInfo()
    {


        count = DbHelperSQL.GetDataRow("select aa=count(*) from tbl_huiyuan where huiyuan_id<>'A00000000' and net_hege=1 and datediff(day,huiyuan_add_time,getdate())=0")["aa"].ToString();
        shouru_z = DbHelperSQL.GetDataRow("select aa=isnull(sum(xiaofei_money),0) from tbl_xiaofei where zhuce_flag=1 and datediff(day,xiaofei_qr_date,getdate())=0")["aa"].ToString();
        Litreal_name.Text = Session["hy_bianhao"].ToString();
        tbl_login model=new tbl_login();
        model.GetModel_last(Session["hy_bianhao"].ToString());
        Literal_time.Text = model.login_date.ToString();
        tbl_liuyan liuyan = new tbl_liuyan();

        Literal1.Text = "<font color=red>"+liuyan.GetTitleSum(" kan_flag=0 and liuyan_to='A00000000'")+"</font>";

        string sql = " SELECT ISNULL(SUM(jiesuan_jiangjin), 0) AS jiangjin FROM tbl_bochu";
        DataSet ds = DbHelperSQL.Query(sql);
        double sa =double.Parse( ds.Tables[0].Rows[0]["jiangjin"].ToString());
        string sql2 = " SELECT ISNULL(SUM(jiesuan_yeji), 0) AS yeji FROM tbl_bochu";
        DataSet ds2 = DbHelperSQL.Query(sql2);
        double sb =double.Parse( ds2.Tables[0].Rows[0]["yeji"].ToString());
        double c = sa / sb;
        if (c > 0)
        {
            //Literal2.Text = (decimal.Parse(c.ToString()) * 100m).ToString("0.00");
        }
        string jsql = "SELECT ISNULL(SUM(jiesuan_jiangjin), 0) AS jiangjin, CONVERT(char(11), jiesuan_date, 120) AS date FROM tbl_bochu       GROUP BY CONVERT(char(11), jiesuan_date, 120) ORDER BY CONVERT(char(11), jiesuan_date, 120) DESC";
        DataSet jds = DbHelperSQL.Query(jsql);
        double jsa = double.Parse(ds.Tables[0].Rows[0]["jiangjin"].ToString());
        string jsql2 = " SELECT ISNULL(SUM(jiesuan_yeji), 0) AS yeji, CONVERT(char(11), jiesuan_date, 120) AS date FROM tbl_bochu       GROUP BY CONVERT(char(11), jiesuan_date, 120) ORDER BY CONVERT(char(11), jiesuan_date, 120) DESC";
        DataSet jds2 = DbHelperSQL.Query(jsql2);
        double jsb = double.Parse(ds2.Tables[0].Rows[0]["yeji"].ToString());
        double d = jsa / jsb;
        if (d > 0)
        {
            //Literal3.Text = (decimal.Parse(d.ToString()) * 100m).ToString("0.00");
        }
    }
    #endregion
}