using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class manager_member_suppler_edit : System.Web.UI.Page
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
        int nav_id = 95;
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
                // QDBind();
                //cnBind();
                //yhBind();//绑定银行
                ShowInfo(this.id);
                //Focus myFocus = new Focus();
                //myFocus.SetEnterControl(this.txtsalse_price);
                //myFocus.SetFocus(txtsalse_price.Page, "txtsalse_price");
            }


        }
    }
    //#region 绑定国家=================================
    //private void cnBind()
    //{
    //    tbl_huilv bll = new tbl_huilv();
    //    DataTable dt = bll.GetList("1=1   order by sort_id").Tables[0];
    //    this.country.Items.Clear();
    //    this.country.Items.Add(new ListItem("请选择国家...", "0"));
    //    foreach (DataRow dr in dt.Rows)
    //    {
    //        string Id = dr["id"].ToString();
    //        string Title = dr["country"].ToString().Trim();
    //        this.country.Items.Add(new ListItem(Title, Id));
    //    }

    //}
    //#endregion
    //#region 绑定银行=================================
    //private void yhBind()
    //{
    //    tbl_reg_bank bll = new tbl_reg_bank();
    //    DataTable dt = bll.GetList("1=1   order by sort_id").Tables[0];
    //    this.huiyuan_yinhang.Items.Clear();
    //    this.huiyuan_yinhang.Items.Add(new ListItem("请选择银行...", ""));
    //    foreach (DataRow dr in dt.Rows)
    //    {
    //        string Id = dr["bank_name"].ToString();
    //        string Title = dr["bank_name"].ToString().Trim();
    //        this.huiyuan_yinhang.Items.Add(new ListItem(Title, Id));
    //    }
    //}
    //#endregion



    #region 赋值操作=================================
    private void ShowInfo(string _id)
    {
        tbl_supplier model1 = new tbl_supplier();
        model1.GetModel(int.Parse(_id));
        this.name.Text = model1.supplyName;
        this.legelname.Text = model1.legalName;
        this.phone.Text = model1.legalPhone;
        this.address.Text = model1.supplyAddress;
        //this.content.Value = model1.supplierProfile;
        //this.email.Text = model1.email;
        //this.IDcard.Text = model1.idCard;
        Image1.ImageUrl = model1.businessNO;
        Image2.ImageUrl = model1.SupplyImg;
        this.category.Text = model1.Category;
        this.bankName.Text = model1.BankName;
        this.bankaderess.Text = model1.BankAddress;
        this.bankno.Text = model1.BankNo;
    }
    #endregion



    #region 修改操作=================================
    private bool DoEdit(string _id)
    {
        bool result = false;
        tbl_supplier model1 = new tbl_supplier();
        model1.GetModel(int.Parse(_id));
        model1.supplyName = this.name.Text;
        model1.legalName = this.legelname.Text;
        model1.legalPhone = this.phone.Text;
        model1.supplyAddress = this.address.Text;
        //model1.supplierProfile = this.content.Value;
        //model1.email = this.email.Text;
        //model1.idCard = this.IDcard.Text;
        model1.Category = this.category.Text;
        model1.BankName = this.bankName.Text;
        model1.BankAddress = this.bankaderess.Text;
        model1.BankNo = this.bankno.Text;

        if (model1.Update())
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
            mym.JscriptMsg(this.Page, "修改信息成功！", Utils.CombUrlTxt("all_supplier.aspx", "page={0}", this.page.ToString()), "Success");
            return;
        }
        else //发生错误
        {
            mym.JscriptMsg(this.Page, "保存过程中发生错误！", "", "Error");
            return;
        }
    }
}