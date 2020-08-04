using System;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class manager_member_al_info : System.Web.UI.Page
{
    protected int page;
    private string action = ""; //操作类型
    protected string dw = ""; //计量单位
    private string id = "";
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
        int nav_id = 38;
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
            if (Utils.ProcessSqlStr(AXRequest.GetQueryString("id")))
            {
                this.id = Utils.Filter(AXRequest.GetQueryString("id"));
           
            }
            else
            {

                mym.JscriptMsg(this.Page, "传输参数不正确！", "back", "Error");
                return;
            }

          
           // Response.Write(this.id);

        }


 
        if (!string.IsNullOrEmpty(_action) && _action == "Login")
        {
            this.action = "Login";//修改类型
            if (Utils.ProcessSqlStr(AXRequest.GetQueryString("id")))
            {
                this.id = Utils.Filter(AXRequest.GetQueryString("id"));

            }
            else
            {

                mym.JscriptMsg(this.Page, "传输参数不正确！", "back", "Error");
                return;
            }


            // Response.Write(this.id);

        }
        if (!Page.IsPostBack)
        {
            if (action == "Edit") //修改
            {
                QDBind();
                yhBind();//绑定银行
                ShowInfo(this.id);
                //Focus myFocus = new Focus();
                //myFocus.SetEnterControl(this.txtsalse_price);
                //myFocus.SetFocus(txtsalse_price.Page, "txtsalse_price");
            }

            if (action == "Login") //修改
            {
                Login(this.id);
               
            }
        }
    }

    #region 绑定银行=================================
    private void yhBind()
    {
        tbl_reg_bank bll = new tbl_reg_bank();
        DataTable dt = bll.GetList("1=1   order by sort_id").Tables[0];
        this.huiyuan_yinhang.Items.Clear();
        this.huiyuan_yinhang.Items.Add(new ListItem("请选择银行...", ""));
        foreach (DataRow dr in dt.Rows)
        {
            string Id = dr["bank_name"].ToString();
            string Title = dr["bank_name"].ToString().Trim();
            this.huiyuan_yinhang.Items.Add(new ListItem(Title, Id));
        }
    }
    #endregion

    #region 绑定级别=================================
    private void QDBind()
    {
        tbl_reg_jiebie bll = new tbl_reg_jiebie();
        DataTable dt = bll.GetList("1=1   order by sort_id").Tables[0];
        this.huiyuan_jiebie.Items.Clear();
        this.huiyuan_jiebie.Items.Add(new ListItem("请选择会员级别...", ""));
        foreach (DataRow dr in dt.Rows)
        {
            string Id = dr["jiebie_value"].ToString();
            string Title = dr["jiebie_name"].ToString().Trim() + Math.Floor(double.Parse(dr["need_money"].ToString())) + "元";
            this.huiyuan_jiebie.Items.Add(new ListItem(Title, Id));
        }
    }
    #endregion

    #region 赋值操作=================================
    private void ShowInfo(string _id)
    {
        tbl_huiyuan model1 = new tbl_huiyuan();
        model1.GetModel_hui_id(_id);


        this.huiyuan_yinhang.SelectedValue = model1.huiyuan_yinhang;
        this.huiyuan_jiebie.SelectedValue =  model1.huiyuan_jiebie.ToString() ;
        this.DropDownList1.SelectedValue = model1.huiyuan_jiebie2.ToString();
        this.bianhao.Text = model1.huiyuan_bianhao;
        this.huiyuan_name.Text = model1.huiyuan_name;
        this.huiyuan_mob.Text = model1.huiyuan_mob;
        //this.tjr.Text = model1.tjr_bianhao;
        this.huiyuan_pass.Text = model1.huiyuan_pass;
        this.pass_two.Text = model1.pass_two;
        this.huiyuan_yinhang_name.Text = model1.huiyuan_yinhang_name;
        this.huiyuan_yinhang_zh.Text = model1.huiyuan_yinhang_zh;
        this.bank_zhi.Text = model1.bank_zhi;
        this.huiyuan_shenfen_id.Text = model1.huiyuan_shenfen_id;
        //this.huiyuan_qq.Text = model1.huiyuan_qq;
        //this.weixin.Text = model1.weixin;
        //this.zhifubao.Text = model1.zhifubao;
        //Image1.ImageUrl = model1.sf_pinju_src;
        //Image2.ImageUrl = model1.zl_pinju_src;
        this.born.Text = model1.born_date;
        this.address.Text = model1.huiyuan_address;

    }
    #endregion

    #region 登录系统=================================
    private void Login(string _id)
    {
        tbl_canshu canshu = new tbl_canshu();
        canshu.GetModel(1);
        Session["tikuan"] = canshu.reg_shoping.ToString();
        tbl_huiyuan model1 = new tbl_huiyuan();
        model1.GetModel_hui_id(_id);
        //填写逻辑过程登录会员系统
        Session["hy_id1"] = model1.huiyuan_id;
        Session["hy_bianhao1"] = model1.huiyuan_bianhao;
        Session["hy_name1"] = model1.huiyuan_name;
        Session["hy_zm1"] = model1.huiyuan_zhuanmai;
        Session["hy_jiebie1"] = model1.huiyuan_jiebie;
        Session["huiyuan_zhuanmai1"] = model1.huiyuan_zhuanmai;
        Session["flag4"] = model1.flag_4;
        Session["zhongyao1"] = 1;
        ShopCart.Clear("0");

        //填写逻辑过程登录会员系统结束

        Response.Redirect("../../shop/member_center.aspx");


    }
    #endregion

    #region 修改操作=================================
    private bool DoEdit(string _id)
    {
        bool result = false;
        tbl_huiyuan model = new tbl_huiyuan();
        model.GetModel_hui_id(_id);
        model.huiyuan_jiebie = int.Parse(huiyuan_jiebie.SelectedValue);
        if (int.Parse(DropDownList1.SelectedValue) == 0)
        {
            model.huiyuan_jiebie1 = 0;
            model.huiyuan_jiebie2 = int.Parse(DropDownList1.SelectedValue);
            model.koushui_flag = 0;
        }
        else
        {
            model.huiyuan_jiebie1 = 1;
            model.huiyuan_jiebie2 = int.Parse(DropDownList1.SelectedValue);
            model.koushui_flag = 1;
            //DbHelperSQL.ExecuteSql("update tbl_orders set flag_1=1 where payment_status=2 AND flag_1=0");
        }
        model.huiyuan_name = this.huiyuan_name.Text;
        model.huiyuan_pass = this.huiyuan_pass.Text;
        model.pass_two = this.pass_two.Text;
        model.huiyuan_yinhang = this.huiyuan_yinhang.SelectedItem.Text;
        model.huiyuan_yinhang_zh = this.huiyuan_yinhang_zh.Text;
        model.bank_zhi = this.bank_zhi.Text;
        model.huiyuan_shenfen_id = this.huiyuan_shenfen_id.Text;
        //model.huiyuan_qq = this.huiyuan_qq.Text;
        //model.weixin = this.weixin.Text;
        //model.zhifubao = this.zhifubao.Text;
        model.huiyuan_address = this.address.Text;
        model.huiyuan_yinhang_name = this.huiyuan_yinhang_name.Text;
        model.huiyuan_mob = this.huiyuan_mob.Text;
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
            mym.JscriptMsg(this.Page, "修改信息成功！", Utils.CombUrlTxt("al_read2.aspx", "page={0}", this.page.ToString()), "Success");
        }
        else //发生错误
        {
            mym.JscriptMsg(this.Page, "保存过程中发生错误！", "", "Error");
            return;
        }
    }

     
}