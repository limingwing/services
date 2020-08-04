using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class manager_product_addTimeKill : System.Web.UI.Page
{
    protected int page;
    private string action = "Add"; //操作类型
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
        int nav_id = 82;
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
            tbl_product bll = new tbl_product();
            DataTable dt = bll.GetList("pro_isok=1 order by salse_price asc").Tables[0];
            this.pid.Items.Clear();
            this.pid.Items.Add(new ListItem("请选择秒杀商品...", ""));
            foreach (DataRow dr in dt.Rows)
            {
                string Id = dr["pro_id"].ToString();
                string Title = dr["pro_name"].ToString().Trim();
                this.pid.Items.Add(new ListItem(Title, Id));
            }
            if (action == "Edit") //修改
            {
                ShowInfo(this.id);
            }
        }
    }

    #region 赋值操作=================================
    private void ShowInfo(int _id)
    {
        tbl_Seckill bll=new tbl_Seckill();
        bll.GetModel(_id);
        this.txt_time1.Value = bll.StartTime.ToString();
        this.txt_time2.Value = bll.EndTime.ToString();
        this.txttitle.Text = bll.Name;
        this.pid.SelectedValue = bll.ProductID.ToString();
        this.text_num.Value = bll.LimitQTY.ToString();
    }
    #endregion



    #region 增加操作=================================
    private bool DoAdd()
    {
        tbl_Seckill bll = new tbl_Seckill();
        //if (bll.Exists(txttitle.Text.Trim()))
        //{
        //    mym.JscriptMsg(this.Page, "您输入的名称已经存在，请检查！", "", "Error");
        //    return false;
        //}

        bll.StartTime = Convert.ToDateTime(txt_time1.Value.Trim());
        bll.EndTime = Convert.ToDateTime(txt_time2.Value.Trim());
        bll.Name = this.txttitle.Text.Trim();
        bll.Status = 0;
        bll.CreateTime = DateTime.Now;
        bll.LimitQTY = Convert.ToInt32(this.text_num.Value.Trim());
        bll.ProductID = Convert.ToInt32(this.pid.SelectedValue.ToString());
        bll.Add();

        return true;

    }
    #endregion

    #region 修改操作=================================
    private bool DoEdit(int _id)
    {
        bool result = false;

        tbl_Seckill bll = new tbl_Seckill();
        bll.GetModel(_id);

        bll.StartTime = Convert.ToDateTime(txt_time1.Value.Trim());
        bll.EndTime = Convert.ToDateTime(txt_time2.Value.Trim());
        bll.Name = this.txttitle.Text.Trim();
        bll.LimitQTY = Convert.ToInt32(this.text_num.Value.Trim());
        bll.ProductID = Convert.ToInt32(this.pid.SelectedValue.ToString());

        if (bll.Update())
        {
            // mym.AddAdminLog("修改", "修改商品类别:" + txttitle.Text); //记录日志
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

            mym.JscriptMsg(this.Page, "修改属性信息成功！", Utils.CombUrlTxt("addTimeKill.aspx", "page={0}", this.page.ToString()), "Success");
        }
        else //添加
        {
            if (!DoAdd())
            {
                mym.JscriptMsg(this.Page, "保存过程中发生错误！", "", "Error");
                return;
            }
            mym.JscriptMsg(this.Page, "添加属性信息成功！", "addTimeKill.aspx", "Success");
        }
    }
}