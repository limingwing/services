using System;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class manager_product_pro_edit : System.Web.UI.Page
{
    protected int page;
    private string action = ""; //操作类型
    protected string dw = ""; //计量单位
    private int id = 0;
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
        int nav_id = 65;
        if (!myrv.QXExists(role_id, nav_id))
        {
            Response.Redirect("../error.html");
            Response.End();
        }
        string _action = AXRequest.GetQueryString("action");
        this.page = AXRequest.GetQueryInt("page", 1);
        if (!string.IsNullOrEmpty(_action) && _action == "Edit")
        {
            this.action = "Edit";//修改类型
            if (!int.TryParse(Request.QueryString["id"] as string, out this.id))
            {
                mym.JscriptMsg(this.Page, "传输参数不正确！", "back", "Error");
                return;
            }

        }
        if (!Page.IsPostBack)
        {
            if (action == "Edit") //修改
            {
                QDBind();
                attributebind();
                procityareabind(this.id);
                ShowInfo(this.id);
                
                Focus myFocus = new Focus();
                myFocus.SetEnterControl(this.txtsalse_price);
                myFocus.SetFocus(txtsalse_price.Page, "txtsalse_price");
            }
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
    private void procityareabind(int _id)
    {
        tbl_product model1 = new tbl_product();
        model1.GetModel(_id);

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

        string proid = model1.province_id.ToString();
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

        string cityid = model1.city_id.ToString();
        T_District blld = new T_District();
        DataTable dtd = blld.GetList("1=1 and CityID='" + cityid + "' order by DisSort").Tables[0];
        this.ddlarea.Items.Clear();
        this.ddlarea.Items.Add(new ListItem("请选择...", ""));
        foreach (DataRow dr in dtd.Rows)
        {
            string Id = dr["Id"].ToString();
            string Title = dr["DisName"].ToString().Trim();
            this.ddlarea.Items.Add(new ListItem(Title, Id));
        }
    }
    #endregion

    #region 赋值操作=================================
    private void ShowInfo(int _id)
    {
        tbl_product model1 = new tbl_product();
        model1.GetModel(_id);

        
        this.ddlproduct_category_id.SelectedValue = model1.pro_pid.ToString();
        this.txtdw.Text = model1.pro_danwei;
        this.txtImgUrl.Text = model1.pro_imgs;
        this.txtImgUrl1.Text = model1.pro_imgs1;
        this.txtImgUrl2.Text = model1.pro_imgs2;
        this.txtproduct_name.Text = model1.pro_name;
        this.txtgo_price.Text = MyConvert(model1.go_price.ToString());
        this.txtsalse_price.Text = MyConvert(model1.salse_price.ToString());
        //this.pv.Text = MyConvert(model1.pro_PV.ToString());
        this.txtContent.Value = model1.pro_memo.ToString();
        this.attribute.SelectedValue = model1.pro_level.ToString();//属性绑定
        this.txtproduct_num.Text = model1.pro_num.ToString();
        //if (model1.pro_type == 0)
        //{
        //    this.cbIsLock.Checked = true;
        //}
        //if (model1.flag == 0)
        //{
        //    this.shengji.Checked = true;
        //}
        if (model1.pro_isok == 1)
        {
            this.pro_isok.Checked = true;
        }
        else
        {
            this.pro_isok.Checked = false;

        }

        if (model1.pro_home_show == 1)
        {
            this.pro_home_show.Checked = true;
        }
        else
        {
            this.pro_home_show.Checked = false;

        }

        if (model1.pro_Hot == 1)
        {
            this.pro_Hot.Checked = true;
        }
        else
        {
            this.pro_Hot.Checked = false;

        }
        this.ddlprov.SelectedValue = model1.province_id.ToString();
        this.ddlcity.SelectedValue = model1.city_id.ToString();
        this.ddlarea.SelectedValue = model1.dictrict_id.ToString();
        //this.shop.Text = MyConvert(model1.shop_fen.ToString());
        //this.yun.Text = MyConvert(model1.cloud_fen.ToString());
        //this.chongxiao.Text = MyConvert(model1.futou_fen.ToString());
        
    }
    #endregion

    #region 修改操作=================================
    private bool DoEdit(int _id)
    {
        bool result = false;
        tbl_product model = new tbl_product();
        model.GetModel(_id);

        model.pro_imgs = this.txtImgUrl.Text;
        model.pro_imgs1 = txtImgUrl1.Text;
        model.pro_imgs2 = txtImgUrl2.Text;
        model.pro_pid = int.Parse(ddlproduct_category_id.SelectedValue);
        model.pro_name = txtproduct_name.Text;
        model.pro_danwei = txtdw.Text;
        model.go_price = Convert.ToDecimal(this.txtgo_price.Text);
        model.salse_price = Convert.ToDecimal(this.txtsalse_price.Text);
        //model.pro_PV = Convert.ToDecimal(this.pv.Text);
        model.province_id = int.Parse(this.ddlprov.SelectedValue);
        model.city_id = int.Parse(this.ddlcity.SelectedValue);
        model.dictrict_id = int.Parse(this.ddlarea.SelectedValue);
        model.pro_memo = txtContent.Value;
        //model.futou_fen = Convert.ToDecimal(chongxiao.Text.Trim());
        //model.shop_fen = Convert.ToDecimal(shop.Text.Trim());
        //model.cloud_fen = Convert.ToDecimal(yun.Text.Trim());
        model.pro_num = int.Parse(txtproduct_num.Text.Trim());
        //if (this.cbIsLock.Checked == true)
        //{
        //    model.pro_type = 0;
        //}
        //else
        //{
            model.pro_type = 1;

        //}
        //if (this.shengji.Checked == true)
        //{
        //    model.flag = 0;
        //}
        //else
        //{
            model.flag = 1;

        //}
        if (this.pro_isok.Checked == true)
        {
            model.pro_isok = 1;
        }
        else
        {
            model.pro_isok = 0;
        
        }

        if (pro_home_show.Checked == true)//首页是否显示
        {
            model.pro_home_show = 1;
        }
        else
        {
            model.pro_home_show = 0;
        }

        if (pro_Hot.Checked == true)//首页是否热销产品
        {
            model.pro_Hot = 1;
        }
        else
        {
            model.pro_Hot = 0;
        }
        model.pro_level = int.Parse(attribute.SelectedValue);//商品属性添加
        if (model.Update())
        {
            
            result = true;
        }
       
        return result;
    }
    #endregion


    

    //保存
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
       
        if (action == "Edit") //修改
        {
            if (!DoEdit(this.id))
            {
                mym.JscriptMsg(this.Page, "保存过程中发生错误！", "", "Error");
                return;
            }
            mym.JscriptMsg(this.Page, "修改商品信息成功！", Utils.CombUrlTxt("pro_list.aspx", "page={0}", this.page.ToString()), "Success");
        }
        else //发生错误
        {
            mym.JscriptMsg(this.Page, "保存过程中发生错误！", "", "Error");
            return;
        }
    }

    //小数位是0的不显示
    public string MyConvert(object d)
    {
        string myNum = d.ToString();
        string[] strs = d.ToString().Split('.');
        if (strs.Length > 1)
        {
            if (Convert.ToInt32(strs[1]) == 0)
            {
                myNum = strs[0];
            }
        }
        return myNum;
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
        DataTable dtd = blld.GetList("1=1 and CityID='" + cityid + "' order by DisSort").Tables[0];
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