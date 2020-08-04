using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class shop_wlt1 : A_BasePage
{
    public string bianhao = "";
    public decimal danshu_money = 1;
    ManagePage mym = new ManagePage();
    protected void Page_Load(object sender, EventArgs e)
    {


        if (!IsPostBack)
        {

            if (Session["hy_id1"] == null)
            {
                Response.Write("<script language=javascript>alert('请重新登录！');top.location.href='login.aspx';</script>");
                Response.End();
            }
            if (Request.QueryString["bianhao"] != null)
            {

                ShowDataUser(Request.QueryString["bianhao"].ToString());
            }
            else
            {

                //bianhao = Session["hy_bianhao1"].ToString();
                bianhao = hy_bianhao1;
                ShowDataUser(bianhao);
            }



        }
    }
    protected void ShowDataUser(string UserName)
    {
        tbl_huiyuan bll = new tbl_huiyuan();
        bll.GetModel_hui_bianhao(UserName);
        // string templateStr = "<table class='DataUser_liTable'><tr><td><a href='{Cyly:Url}' style='color:;'>{Cyly:UserName}</a></td></tr></table>";



        string templateStr = "<table cellspacing='0' cellpadding='0' border='1'  align='center' style=' margin:0 auto; width:100px;background-color:#c0dbf3;border:1px solid #295594;'>";
        templateStr += "  <tr><td colspan=3 style='background-color:#00ff00;'><a href='{Cyly:Url}'>{Cyly:UserName}</a><br /></td></tr>";
        templateStr += "  <tr><td colspan=3 style='background-color:#00ff00;'><a href='{Cyly:Url}'>{Cyly:true_name}</a><br /></td></tr>";
        templateStr += "  <tr><td colspan=3 style='background-color:#00ff00;'><a href='{Cyly:Url}'>{Cyly:jiebie}</a><br /></td></tr>";
        templateStr += "  <tr><td colspan=3 style='background-color:#00ff00;'>业绩：{Cyly:Azong}<br /></td></tr>";
        templateStr += "  <tr><td colspan=3 style='background-color:#00ff00;'>人数：{Cyly:Bzong}<br /></td></tr>";
        //templateStr += "  <tr><td colspan=3 style='background-color:#00ff00;'>C区：{Cyly:Czong}<br /></td></tr>";
        templateStr += "   </table>";



        //第一层
        string tempStr = templateStr;
        tempStr = tempStr.Replace("{Cyly:UserName}", UserName);

        //tempStr = tempStr.Replace("{Cyly:penshuzuo}", "1");
        //tempStr = tempStr.Replace("{Cyly:penshuzhong}", "1");
        //tempStr = tempStr.Replace("{Cyly:penshuyou}", "1");
        tempStr = tempStr.Replace("{Cyly:true_name}", bll.huiyuan_name);
        tempStr = tempStr.Replace("{Cyly:jiebie}", new tbl_reg_jiebie().GetTitle(Convert.ToInt32(bll.huiyuan_jiebie)));
        tempStr = tempStr.Replace("{Cyly:Url}", "?bianhao=" + UserName);
        tempStr = tempStr.Replace("{Cyly:Azong}", decimal.Parse(bll.you_zong.ToString()).ToString("0"));
        tempStr = tempStr.Replace("{Cyly:Bzong}", decimal.Parse(bll.flag_1.ToString()).ToString("0"));
        tempStr = tempStr.Replace("{Cyly:Czong}", decimal.Parse(bll.you_shen.ToString()).ToString("0"));
        //if (!UserData.hege_check(UserName))

        //    tempStr = tempStr.Replace("color:;", "color:red;");

        this.table_leval_1.InnerHtml = tempStr;
        //第二层
        //DataRow[] dsv = dt.Select("jd_bianhao='" + UserName + "'", "zuoyou asc");
        string Listr1 = "";
        string Listr2 = "";
        for (int i = 0; i < 3; i++)
        {
            tempStr = templateStr;
            int mm = i + 1;

            tbl_huiyuan bll2 = new tbl_huiyuan();
            bll2.GetModel_jiedian(bll.huiyuan_id, mm);

            if (bll2.huiyuan_id != null)
            {

                tempStr = tempStr.Replace("{Cyly:UserName}", bll2.huiyuan_bianhao);

                //tempStr = tempStr.Replace("{Cyly:penshuzuo}", "1");
                //tempStr = tempStr.Replace("{Cyly:penshuzhong}","1");
                //tempStr = tempStr.Replace("{Cyly:penshuyou}", "1");
                tempStr = tempStr.Replace("{Cyly:true_name}", bll2.huiyuan_name);
                tempStr = tempStr.Replace("{Cyly:jiebie}", new tbl_reg_jiebie().GetTitle(Convert.ToInt32(bll2.huiyuan_jiebie)));
                tempStr = tempStr.Replace("{Cyly:Url}", "?bianhao=" + bll2.huiyuan_bianhao);
                tempStr = tempStr.Replace("{Cyly:Azong}", decimal.Parse(bll2.you_zong.ToString()).ToString("0"));
                tempStr = tempStr.Replace("{Cyly:Bzong}", decimal.Parse(bll2.flag_1.ToString()).ToString("0"));
                tempStr = tempStr.Replace("{Cyly:Czong}", decimal.Parse(bll2.you_shen.ToString()).ToString("0"));
                //if (dr["net_hege"].ToString() != "1")
                //    tempStr = tempStr.Replace("color:;", "color:red;");
                Listr1 += "<td colspan=3>" + tempStr + "</td>";
                //DataRow[] dsz = dt.Select("jd_bianhao='" + dr["huiyuan_bianhao"].ToString() + "'");

                for (int j = 0; j < 3; j++)
                {
                    tempStr = templateStr;
                    int nn = j + 1;

                    tbl_huiyuan bll3 = new tbl_huiyuan();
                    bll3.GetModel_jiedian(bll2.huiyuan_id, nn);



                    if (bll3.huiyuan_id != null)
                    {
                        tempStr = tempStr.Replace("{Cyly:UserName}", bll3.huiyuan_bianhao);

                        //tempStr = tempStr.Replace("{Cyly:penshuzuo}", "1");
                        //tempStr = tempStr.Replace("{Cyly:penshuzhong}", "1");
                        //tempStr = tempStr.Replace("{Cyly:penshuyou}", "1");
                        tempStr = tempStr.Replace("{Cyly:true_name}", bll3.huiyuan_name);
                        tempStr = tempStr.Replace("{Cyly:jiebie}", new tbl_reg_jiebie().GetTitle(Convert.ToInt32(bll3.huiyuan_jiebie)));
                        tempStr = tempStr.Replace("{Cyly:Url}", "?bianhao=" + bll3.huiyuan_bianhao);
                        tempStr = tempStr.Replace("{Cyly:Azong}", decimal.Parse(bll3.you_zong.ToString()).ToString("0"));
                        tempStr = tempStr.Replace("{Cyly:Bzong}", decimal.Parse(bll3.flag_1.ToString()).ToString("0"));
                        tempStr = tempStr.Replace("{Cyly:Czong}", decimal.Parse(bll3.you_shen.ToString()).ToString("0"));
                        //if (dr1["net_hege"].ToString() != "1")
                        //    tempStr = tempStr.Replace("color:;", "color:red;");
                    }
                    else
                    {
                        tempStr = tempStr.Replace("{Cyly:UserName}", "注册");
                        tempStr = tempStr.Replace("{Cyly:true_name}", "");
                        //tempStr = tempStr.Replace("{Cyly:penshuzuo}", "");
                        //tempStr = tempStr.Replace("{Cyly:penshuzhong}", "");
                        //tempStr = tempStr.Replace("{Cyly:penshuyou}", "");
                        tempStr = tempStr.Replace("{Cyly:jiebie}", "");
                        tempStr = tempStr.Replace("{Cyly:Url}", "../../reg/reg1.aspx?jd_bianhao=" + bll3.huiyuan_bianhao + "&zuoyou=" + nn + "");
                        tempStr = tempStr.Replace("{Cyly:Azong}", "");
                        tempStr = tempStr.Replace("{Cyly:Bzong}", "");
                        tempStr = tempStr.Replace("{Cyly:Czong}", "");
                    }
                    Listr2 += "<td><div style='margin:2px;'>" + tempStr + "</div></td>";
                }
            }
            else
            {
                tempStr = tempStr.Replace("{Cyly:UserName}", "注册");
                tempStr = tempStr.Replace("{Cyly:true_name}", "");
                //tempStr = tempStr.Replace("{Cyly:penshuzuo}", "");
                //tempStr = tempStr.Replace("{Cyly:penshuzhong}", "");
                //tempStr = tempStr.Replace("{Cyly:penshuyou}", "");
                tempStr = tempStr.Replace("{Cyly:jiebie}", "");
                tempStr = tempStr.Replace("{Cyly:Url}", "../../reg/reg1.aspx?jd_bianhao=" + UserName + "&zuoyou=" + mm + "");
                tempStr = tempStr.Replace("{Cyly:Azong}", "");
                tempStr = tempStr.Replace("{Cyly:Bzong}", "");
                tempStr = tempStr.Replace("{Cyly:Czong}", "");
                Listr1 += "<td colspan=3>" + tempStr + "</td>";

                for (int j = 0; j < 3; j++)
                {
                    tempStr = templateStr;
                    tempStr = tempStr.Replace("{Cyly:UserName}", "注册");
                    tempStr = tempStr.Replace("{Cyly:true_name}", "");
                    //tempStr = tempStr.Replace("{Cyly:penshuzuo}", "");
                    //tempStr = tempStr.Replace("{Cyly:penshuzhong}", "");
                    //tempStr = tempStr.Replace("{Cyly:penshuyou}", "");
                    tempStr = tempStr.Replace("{Cyly:jiebie}", "");
                    tempStr = tempStr.Replace("{Cyly:Url}", "../../reg/reg1.aspx?jd_bianhao=" + UserName + "&zuoyou=" + mm + "");
                    tempStr = tempStr.Replace("{Cyly:Azong}", "");
                    tempStr = tempStr.Replace("{Cyly:Bzong}", "");
                    tempStr = tempStr.Replace("{Cyly:Czong}", "");
                    Listr2 += "<td><div style='margin:2px;'>" + tempStr + "</div></td>";
                }
            }

        }
        this.table_leval_2.InnerHtml = Listr1;
        this.table_leval_3.InnerHtml = Listr2;



    }
    protected void imbnQuery_Click(object sender, EventArgs e)
    {
        tbl_huiyuan bll = new tbl_huiyuan();
        if (!bll.Exists_hui_bianhao(this.txtKeywords.Text.Trim()))
        {

            Page.ClientScript.RegisterStartupScript(Page.GetType(), "", "alert('无此会员编号，请重新输入！');", true);
            return;


        }
        else
        {

            bianhao = this.txtKeywords.Text.Trim();

            ShowDataUser(bianhao);


        }
    }
}