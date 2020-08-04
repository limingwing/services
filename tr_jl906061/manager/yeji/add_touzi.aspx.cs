using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class manager_yeji_add_touzi : System.Web.UI.Page
{
    ManagePage mym = new ManagePage();
    protected void Page_Load(object sender, EventArgs e)
    {
        //判断是否登录
        if (!mym.IsAdminLogin())
        {
            Response.Write("<script>parent.location.href='../login.aspx'</script>");
            Response.End();
        }
        //判断权限
        tbl_admin_role_value myrv = new tbl_admin_role_value();
        int role_id = Convert.ToInt32(Session["RoleID"]);
        int nav_id = 77;
        if (!myrv.QXExists(role_id, nav_id))
        {
            Response.Redirect("../error.html");
            Response.End();
        }


    }


    protected void btnSubmit_Click(object sender, EventArgs e)
    {

        if (huiyuan_bianhao.Text.Trim() == "A00000000")
        {
            mym.JscriptMsg(this.Page, "编号不能为公司！", "", "Error");
            return;

        }



        decimal sum_pv = decimal.Parse(this.jine.Text.Trim());
        if (sum_pv == 0)
        {
            Response.Write("<script language=javascript>alert('您还没输入金额！');history.go(-1);</script>");
            return;
        }
        if (sum_pv < 200)
        {
            Response.Write("<script language=javascript>alert('您输入金额小于200元！');history.go(-1);</script>");
            return;
        }
        int leixing = int.Parse(this.leixing.SelectedValue);


        tbl_huiyuan model = new tbl_huiyuan();

        model.GetModel_hui_bianhao(huiyuan_bianhao.Text.Trim());
        string huiyuan_id = model.huiyuan_id;


        decimal fh_money = 0, dj_money = 0;
        int zhuce_flag = 0;
        DateTime now_date = DateTime.Parse("1900-01-01 00:00:00");
        DateTime yy_date = DateTime.Parse("1900-01-01 00:00:00");

        if (leixing == 1)
        {
            fh_money = 0.096m;
            zhuce_flag = 1;
            dj_money = 0;

        }
        else
        {

            fh_money = 0.18m;
            zhuce_flag = 2;
            dj_money = sum_pv;

            now_date = DateTime.Now;

            yy_date = now_date.AddDays(7);
        }

        tbl_xiaofei xbll = new tbl_xiaofei();

        xbll.xiaofei_hui_id=huiyuan_id;
        xbll.xiaofei_money = sum_pv;
        xbll.xiaofei_money1 = dj_money;
        xbll.ding_flag = 1;
        xbll.xiaofei_qr_date = DateTime.Now;
        xbll.xiaofei_qr_flag = 1;
        xbll.zhuce_flag = zhuce_flag;
        xbll.fh_money = fh_money;
        xbll.xiaofei_memo = beizhu.Text.ToString();
        if (yy_date.ToString() != "1900/1/1 0:00:00" && leixing==2)
        {
            xbll.fahuo_date = yy_date;
        }
    
        if (xbll.Add() > 0)
        {
            DbHelperSQL.ExecuteSql("exec sp_kt001 '" + huiyuan_id + "'");//更新投资级别
            mym.JscriptMsg(this.Page, "添加成功！", "", "Success");
        }

        
         
       

    }
}