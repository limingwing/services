using System;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class manager_product_pro_add : System.Web.UI.Page
{
    ManagePage mym = new ManagePage();
    protected void Page_Load(object sender, EventArgs e)
    {

        //判断是否登录
        if (!mym.IsAdminLogin())
        {
            Response.Write("<script>parent.location.href='../index.aspx'</script>");
            Response.End();
        }
        //判断权限
        tbl_admin_role_value myrv = new tbl_admin_role_value();
        int role_id = Convert.ToInt32(Session["RoleID"]);
        int nav_id = 66;
        if (!myrv.QXExists(role_id, nav_id))
        {
            Response.Redirect("../error.html");
            Response.End();
        }

        if (!Page.IsPostBack)
        {
            QDBind();
            attributebind();
            procityareabind();
            Focus myFocus = new Focus();
            myFocus.SetEnterControl(this.txtproduct_name);
            myFocus.SetFocus(txtproduct_name.Page, "txtproduct_name");
        }
    }

    #region 绑定商品类别=================================
    private void QDBind()
    {
        tbl_sinkia_sub bll = new tbl_sinkia_sub();
        DataTable dt = bll.GetList("1=1 order by sort_id").Tables[0];
        this.ddlproduct_category_id.Items.Clear();
        this.ddlproduct_category_id.Items.Add(new ListItem("请选择商品类别...", ""));
        foreach (DataRow dr in dt.Rows)
        {
            string Id = dr["id"].ToString();
            string Title = dr["pro_class"].ToString().Trim();
            this.ddlproduct_category_id.Items.Add(new ListItem(Title, Id));
        }
    }
    #endregion
    #region 绑定商品属性=================================
    private void attributebind()
    {
        tbl_sinkia_attribute bll = new tbl_sinkia_attribute();
        DataTable dt = bll.GetList("1=1 order by id").Tables[0];
        this.attribute.Items.Clear();
        this.attribute.Items.Add(new ListItem("默认...", "0"));
        foreach (DataRow dr in dt.Rows)
        {
            string Id = dr["id"].ToString();
            string Title = "(" + dr["attribute_name"].ToString().Trim() + ")" + dr["attribute_value"].ToString().Trim();
            this.attribute.Items.Add(new ListItem(Title, Id));
        }
    }
    #endregion

    #region 绑定商品产地=================================
    private void procityareabind()
    {
        T_Province bll = new T_Province();
        DataTable dt = bll.GetList("1=1 order by ProSort").Tables[0];
        this.ddlprov.Items.Clear();
        this.ddlprov.Items.Add(new ListItem("请选择...", ""));
        foreach (DataRow dr in dt.Rows)
        {
            string Id = dr["ProID"].ToString();
            string Title = dr["ProName"].ToString().Trim();
            this.ddlprov.Items.Add(new ListItem(Title, Id));
        }

        T_City bllc = new T_City();
        DataTable dtc = bllc.GetList("1=1 order by CitySort").Tables[0];
        this.ddlcity.Items.Clear();
        this.ddlcity.Items.Add(new ListItem("请选择...", ""));
        //foreach (DataRow dr in dtc.Rows)
        //{
        //    string Id = dr["CityID"].ToString();
        //    string Title = dr["CityName"].ToString().Trim();
        //    this.ddlcity.Items.Add(new ListItem(Title, Id));
        //}

        T_District blld = new T_District();
        DataTable dtd = blld.GetList("1=1 order by DisSort").Tables[0];
        this.ddlarea.Items.Clear();
        this.ddlarea.Items.Add(new ListItem("请选择...", ""));
        //foreach (DataRow dr in dtd.Rows)
        //{
        //    string Id = dr["Id"].ToString();
        //    string Title = dr["DisName"].ToString().Trim();
        //    this.ddlarea.Items.Add(new ListItem(Title, Id));
        //}
    }
    #endregion

    #region 增加操作=================================
    private bool DoAdd()
    {
       // DateTime now = DateTime.Now;
        //string note_no = now.ToString("yy") + now.ToString("MM") + now.ToString("dd") + now.ToString("HH") + now.ToString("mm") + now.ToString("ss");

        tbl_product model1 = new tbl_product();
        model1.pro_imgs = txtImgUrl.Text;
        model1.pro_imgs1 = txtImgUrl1.Text;
        model1.pro_imgs2 = txtImgUrl2.Text;
        model1.pro_pid = int.Parse(ddlproduct_category_id.SelectedValue);
        model1.pro_date = DateTime.Now;
        model1.pro_name = txtproduct_name.Text;
        model1.pro_danwei = txtdw.Text;
        model1.go_price = Convert.ToDecimal(txtgo_price.Text);
        model1.salse_price = Convert.ToDecimal(txtsalse_price.Text);
        //model1.pro_PV = Convert.ToDecimal(PV.Text);
        model1.province_id = int.Parse(this.ddlprov.SelectedValue);
        model1.city_id = int.Parse(this.ddlcity.SelectedValue);
        model1.dictrict_id = int.Parse(this.ddlarea.SelectedValue);
        //model1.futou_fen = Convert.ToDecimal(chongxiao.Text.Trim());
        //model1.shop_fen = Convert.ToDecimal(shop.Text.Trim());
        //model1.cloud_fen = Convert.ToDecimal(yun.Text.Trim());
        model1.pro_num = int.Parse(txtproduct_num.Text.Trim());
        //if (cbIsLock.Checked == true)
        //{
        //    model1.pro_type = 0;
        //}
        //else
        //{
            model1.pro_type = 1;
        //}
        //if (shengji.Checked == true)
        //{
        //    model1.flag = 0;
        //}
        //else
        //{
            model1.flag = 1;
        //}

        if (pro_isok.Checked == true)
        {
            model1.pro_isok = 1;
        }
        else
        {
            model1.pro_isok = 0;
        }
        
        model1.pro_danwei = txtdw.Text;
        model1.pro_memo = txtContent.Value;
        model1.pro_level = int.Parse(attribute.SelectedValue);
        
     
      if (pro_home_show.Checked == true)
        {
            model1.pro_home_show = 1;
        }
        else
        {
            model1.pro_home_show = 0;
        }

      if (pro_Hot.Checked == true)
      {
          model1.pro_Hot = 1;
      }
      else
      {
          model1.pro_Hot = 0;
      }

        if (model1.Add() > 0)
        {
            return true;
        
        }

        return false;
    }
    #endregion

    //保存
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
   
        if (!DoAdd())
        {
            mym.JscriptMsg(this.Page, "保存过程中发生错误！", "", "Error");
            return;
        }
        mym.JscriptMsg(this.Page, "增加新品成功！", "", "Success");
        txtproduct_name.Text = "";
        txtImgUrl.Text = "";
        txtgo_price.Text = "";
        txtsalse_price.Text = "";
        txtproduct_num.Text = "";
        txtdw.Text = "";
        txtContent.Value = "";
    }

    protected void ddlprov_SelectedIndexChanged(object sender, EventArgs e)
    {
        string proid = this.ddlprov.SelectedValue;
        T_City bllc = new T_City();
        DataTable dtc = bllc.GetList("1=1 and ProID='" + proid + "' order by CitySort").Tables[0];
        this.ddlcity.Items.Clear();
        this.ddlcity.Items.Add(new ListItem("请选择...", ""));
        foreach (DataRow dr in dtc.Rows)
        {
            string Id = dr["CityID"].ToString();
            string Title = dr["CityName"].ToString().Trim();
            this.ddlcity.Items.Add(new ListItem(Title, Id));
        }
        T_District blld = new T_District();
        DataTable dtd = blld.GetList("1=1 order by DisSort").Tables[0];
        this.ddlarea.Items.Clear();
        this.ddlarea.Items.Add(new ListItem("请选择...", ""));
    }
    protected void ddlcity_SelectedIndexChanged(object sender, EventArgs e)
    {
        string cityid = this.ddlcity.SelectedValue;
        T_District blld = new T_District();
        DataTable dtd = blld.GetList("1=1 and CityID='"+cityid+"' order by DisSort").Tables[0];
        this.ddlarea.Items.Clear();
        this.ddlarea.Items.Add(new ListItem("请选择...", ""));
        foreach (DataRow dr in dtd.Rows)
        {
            string Id = dr["Id"].ToString();
            string Title = dr["DisName"].ToString().Trim();
            this.ddlarea.Items.Add(new ListItem(Title, Id));
        }
    }
}