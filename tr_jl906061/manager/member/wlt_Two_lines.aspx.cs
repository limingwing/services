using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class manager_member_wlt_Two_lines : System.Web.UI.Page
{
    public string bianhao = "";
    public decimal danshu_money = 1;
    ManagePage mym = new ManagePage();
    protected void Page_Load(object sender, EventArgs e)
    {
        //判断是否登录
        if (!mym.IsAdminLogin())
        {
            Response.Write("<script>parent.location.href='../login.aspx'</script>");//response.redirect("url")的作用是在服务器端重定向于另一个网页。
            Response.End();//用来终止脚本程序。
        }
        //判断权限
        tbl_admin_role_value myrv = new tbl_admin_role_value();
        int role_id = Convert.ToInt32(Session["RoleID"]);
        int nav_id = 11;
        if (!myrv.QXExists(role_id, nav_id))
        {
            Response.Redirect("../error.html");
            Response.End();
        }

        if (!IsPostBack)
        {


            if (Request.QueryString["bianhao"] != null)
            {

                ShowDataUser(Request.QueryString["bianhao"].ToString());
            }
            else
            {
                bianhao = "A00000000";
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
        templateStr += "  <tr><td style='background-color:#00ff00;'><a href='{Cyly:Url}'>{Cyly:zuo_zong}</a> </td><td style='background-color:#00ff00;'>总</td><td style='background-color:#00ff00;'><a href='{Cyly:Url}'>{Cyly:you_zong}</a> </td></tr>";
        templateStr += "  <tr><td style='background-color:#00ff00;'><a href='{Cyly:Url}'>{Cyly:zuo_yu}</a> </td><td style='background-color:#00ff00;'>余</td><td style='background-color:#00ff00;'><a href='{Cyly:Url}'>{Cyly:you_yu}</a> </td></tr>";
        templateStr += "  <tr><td colspan=3 style='background-color:#33b5e5;'><a href='{Cyly:Url1}'>返回上一级</a><br /></td></tr>";
        templateStr += "   </table>";

        

        //第一层
        string tempStr = templateStr;
        tempStr = tempStr.Replace("{Cyly:UserName}", UserName);

        tempStr = tempStr.Replace("{Cyly:zuo_zong}", double.Parse(bll.zuo_zong.ToString()).ToString());
        tempStr = tempStr.Replace("{Cyly:you_zong}", double.Parse(bll.you_zong.ToString()).ToString());
        tempStr = tempStr.Replace("{Cyly:zuo_yu}", double.Parse((bll.zuo_zong - bll.huiyuan_pen_zuo).ToString()).ToString());
        tempStr = tempStr.Replace("{Cyly:you_yu}", double.Parse((bll.you_zong - bll.huiyuan_pen_you).ToString()).ToString());
        tempStr = tempStr.Replace("{Cyly:true_name}", bll.huiyuan_name);
        tempStr = tempStr.Replace("{Cyly:jiebie}", new tbl_reg_jiebie().GetTitle(Convert.ToInt32(bll.huiyuan_jiebie)));
        tempStr = tempStr.Replace("{Cyly:Url}", "?bianhao=" + UserName);
        tempStr = tempStr.Replace("{Cyly:Url1}", "?bianhao=" + new tbl_huiyuan().Getbianhao(bll.huiyuan_jiedian));
        if (bll.net_hege == 0)
        {

            tempStr = tempStr.Replace("background-color:#00ff00;", "background-color:#eea0a1;");
        }
        if (bll.huiyuan_zhuanmai == 1)
        {

            tempStr = tempStr.Replace("background-color:#00ff00;", "background-color:#F9F900;");
        }
       

        this.table_leval_1.InnerHtml = tempStr;
        //第二层
        //DataRow[] dsv = dt.Select("jd_bianhao='" + UserName + "'", "zuoyou asc");
        
        string Listr1 = "";
        string Listr2 = "";
        for (int i = 0; i < 2; i++)
        {
            tempStr = templateStr;
            int mm = i + 1;

            tbl_huiyuan bll2 = new tbl_huiyuan();
            bll2.GetModel_jiedian(bll.huiyuan_id, mm);

            if (bll2.huiyuan_id != null)
            {

                tempStr = tempStr.Replace("{Cyly:UserName}", bll2.huiyuan_bianhao);

                tempStr = tempStr.Replace("{Cyly:zuo_zong}", double.Parse(bll2.zuo_zong.ToString()).ToString());
                tempStr = tempStr.Replace("{Cyly:you_zong}", double.Parse(bll2.you_zong.ToString()).ToString());
                tempStr = tempStr.Replace("{Cyly:zuo_yu}", double.Parse((bll2.zuo_zong - bll2.huiyuan_pen_zuo).ToString()).ToString());
                tempStr = tempStr.Replace("{Cyly:you_yu}", double.Parse((bll2.you_zong - bll2.huiyuan_pen_you).ToString()).ToString());
                tempStr = tempStr.Replace("{Cyly:true_name}", bll2.huiyuan_name);
                tempStr = tempStr.Replace("{Cyly:jiebie}", new tbl_reg_jiebie().GetTitle(Convert.ToInt32(bll2.huiyuan_jiebie)));
                tempStr = tempStr.Replace("{Cyly:Url}", "?bianhao=" + bll2.huiyuan_bianhao);
                tempStr = tempStr.Replace("{Cyly:Url1}", "?bianhao=" + new tbl_huiyuan().Getbianhao(bll2.huiyuan_shang_id));
                if (bll2.net_hege == 0)
                {

                    tempStr = tempStr.Replace("background-color:#00ff00;", "background-color:#eea0a1;");
                }
                if (bll2.huiyuan_zhuanmai == 1)
                {

                    tempStr = tempStr.Replace("background-color:#00ff00;", "background-color:#F9F900;");
                }

                Listr1 += "<td colspan=2>" + tempStr + "</td>";
                //DataRow[] dsz = dt.Select("jd_bianhao='" + dr["huiyuan_bianhao"].ToString() + "'");

                for (int j = 0; j < 2; j++)
                {
                    tempStr = templateStr;
                    int nn = j + 1;

                    tbl_huiyuan bll3 = new tbl_huiyuan();
                    bll3.GetModel_jiedian(bll2.huiyuan_id, nn);



                    if (bll3.huiyuan_id != null)
                    {
                        tempStr = tempStr.Replace("{Cyly:UserName}", bll3.huiyuan_bianhao);

                        tempStr = tempStr.Replace("{Cyly:zuo_zong}", double.Parse(bll3.zuo_zong.ToString()).ToString());
                        tempStr = tempStr.Replace("{Cyly:you_zong}", double.Parse(bll3.you_zong.ToString()).ToString());
                        tempStr = tempStr.Replace("{Cyly:zuo_yu}", double.Parse((bll3.zuo_zong - bll3.huiyuan_pen_zuo).ToString()).ToString());
                        tempStr = tempStr.Replace("{Cyly:you_yu}", double.Parse((bll3.you_zong - bll3.huiyuan_pen_you).ToString()).ToString());
                        tempStr = tempStr.Replace("{Cyly:true_name}", bll3.huiyuan_name);
                        tempStr = tempStr.Replace("{Cyly:jiebie}", new tbl_reg_jiebie().GetTitle(Convert.ToInt32(bll3.huiyuan_jiebie)));
                        tempStr = tempStr.Replace("{Cyly:Url}", "?bianhao=" + bll3.huiyuan_bianhao);
                        tempStr = tempStr.Replace("{Cyly:Url1}", "?bianhao=" + new tbl_huiyuan().Getbianhao(bll3.huiyuan_shang_id));
                        if (bll3.net_hege == 0)
                        {

                            tempStr = tempStr.Replace("background-color:#00ff00;", "background-color:#eea0a1;");
                        }
                        if (bll3.huiyuan_zhuanmai == 1)
                        {

                            tempStr = tempStr.Replace("background-color:#00ff00;", "background-color:#F9F900;");
                        }
                    }
                    else
                    {
                        tempStr = tempStr.Replace("{Cyly:UserName}", "注册");
                        tempStr = tempStr.Replace("{Cyly:true_name}", "");
                        tempStr = tempStr.Replace("{Cyly:zuo_zong}", "");
                        tempStr = tempStr.Replace("{Cyly:you_zong}", "");
                        tempStr = tempStr.Replace("{Cyly:zuo_yu}", "");
                        tempStr = tempStr.Replace("{Cyly:you_yu}", "");
                        tempStr = tempStr.Replace("{Cyly:jiebie}", "");
                        tempStr = tempStr.Replace("{Cyly:Url}", "../../reg/reg.aspx?jd_bianhao=" + bll2.huiyuan_bianhao.ToString().Trim() + "&zuoyou=" + nn + "");
                    }
                    Listr2 += "<td><div style='margin:2px;'>" + tempStr + "</div></td>";
                }
            }
            else
            {
                tempStr = tempStr.Replace("{Cyly:UserName}", "注册");
                tempStr = tempStr.Replace("{Cyly:true_name}", "");
                tempStr = tempStr.Replace("{Cyly:zuo_zong}", "");
                tempStr = tempStr.Replace("{Cyly:you_zong}", "");
                tempStr = tempStr.Replace("{Cyly:zuo_yu}", "");
                tempStr = tempStr.Replace("{Cyly:you_yu}", "");
                tempStr = tempStr.Replace("{Cyly:jiebie}", "");
                tempStr = tempStr.Replace("{Cyly:Url}", "../../reg/reg.aspx?jd_bianhao=" + UserName + "&zuoyou=" + mm + "");
                Listr1 += "<td colspan=2>" + tempStr + "</td>";

                for (int j = 0; j < 2; j++)
                {
                    tempStr = templateStr;
                    tempStr = tempStr.Replace("{Cyly:UserName}", "注册");
                    tempStr = tempStr.Replace("{Cyly:true_name}", "");
                    tempStr = tempStr.Replace("{Cyly:zuo_zong}", "");
                    tempStr = tempStr.Replace("{Cyly:you_zong}", "");
                    tempStr = tempStr.Replace("{Cyly:zuo_yu}", "");
                    tempStr = tempStr.Replace("{Cyly:you_yu}", "");
                    tempStr = tempStr.Replace("{Cyly:jiebie}", "");
                    tempStr = tempStr.Replace("{Cyly:Url}", "../../reg/reg.aspx?jd_bianhao=" + UserName + "&zuoyou=" + mm + "");
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