using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class manager_yeji_add_benjin : System.Web.UI.Page
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

        fh_money =decimal.Parse(this.TextBox1.Text.Trim())/100;
       

         
        zhuce_flag = 3;
        dj_money = sum_pv;

         

        tbl_xiaofei xbll = new tbl_xiaofei();

        xbll.xiaofei_hui_id = huiyuan_id;
        xbll.xiaofei_money = sum_pv;
        xbll.xiaofei_money1 = dj_money;
        xbll.ding_flag = 1;
        xbll.xiaofei_qr_date = DateTime.Now;
        xbll.xiaofei_qr_flag = 1;
        xbll.zhuce_flag = zhuce_flag;
        xbll.fh_money = fh_money;
        xbll.wang_flag =int.Parse( TextBox2.Text.Trim());
        xbll.xiaofei_memo = beizhu.Text.ToString();
        

        if (xbll.Add() > 0)
        {
            
            mym.JscriptMsg(this.Page, "添加成功！", "", "Success");
        }





    }
}