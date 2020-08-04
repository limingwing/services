using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class shop_order_shou : System.Web.UI.Page
{
    protected int totalCount;//分页
    protected int page;     //分页
    protected int pageSize;     //分页
    protected void Page_Load(object sender, EventArgs e)
    {
        this.pageSize = GetPageSize(8); //每页数量
        if (!Page.IsPostBack)
        {
            if (Session["hy_id1"] == null)
            {
                Response.Write("<script language=javascript>alert('请重新登录！');top.location.href='login.aspx';</script>");
                Response.End();

            }

            RptBind("  user_id='" + Session["hy_id1"].ToString() + "' and  status=2", "add_time desc");//绑定订单


        }
    }

    #region 数据绑定=================================
    private void RptBind(string _strWhere, string _orderby)
    {
        this.page = AXRequest.GetQueryInt("page", 1);



        tbl_orders bll = new tbl_orders();
        this.rptList.DataSource = bll.GetList(this.pageSize, this.page, _strWhere, _orderby, out this.totalCount);
        this.rptList.DataBind();


        //绑定页码
        //txtPageNum.Text = this.pageSize.ToString();
        string pageUrl = Utils.CombUrlTxt("order_pay.aspx", "page={0}", "__id__");
        PageContent.InnerHtml = Utils.OutPageList(this.pageSize, this.page, this.totalCount, pageUrl, 8);
    }
    #endregion

    #region 返回每页数量=============================
    private int GetPageSize(int _default_size)
    {
        int _pagesize;
        if (int.TryParse(Utils.GetCookie("jiangjin_page_size"), out _pagesize))
        {

            if (_pagesize > 0)
            {
                return _pagesize;
            }
        }
        return _default_size;
    }
    #endregion

    #region 订单产品绑定=================================
    protected void rptypelist_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {

        //判断里层repeater处于外层repeater的哪个位置（ AlternatingItemTemplate，FooterTemplate，

        //HeaderTemplate，，ItemTemplate，SeparatorTemplate）
        if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
        {
            Repeater rep = e.Item.FindControl("Repeater3") as Repeater;//找到里层的repeater对象
            DataRowView rowv = (DataRowView)e.Item.DataItem;//找到分类Repeater关联的数据项 
            string typeid = rowv["id"].ToString(); //获取填充子类的id 
            tbl_order_goods bll = new tbl_order_goods();
            DataSet result2 = bll.GetList("   order_id='" + typeid + "'   order by id asc");

            rep.DataSource = result2;
            rep.DataBind();
        }
    }
    #endregion
    #region 确认收货=================================
    public void shouhuo(object sender, EventArgs e)
    {
       
        tbl_orders model1=new tbl_orders();
        int id = int.Parse((((LinkButton)sender).CommandArgument.ToString()));

        model1.GetModel(id);
      
        if (model1.status == 3)
        {
            Response.Write("<script language=javascript>alert('已经确认收货，请不要重复操作！');history.go(-1);</script>");
            return;
        }



        model1.status = 3;



        if (model1.Update())
        {
          
            Response.Write("<script language=javascript>alert('收货成功！');top.location.href='order.aspx';</script>");
            return;
        }

    }
    #endregion

    #region 返回订单状态=============================
    protected bool isshow(int _id)
    {
        bool status = false;

        switch (_id)
        {
            case 1:
                status = false;
                break;
            case 2:
                status = true;
                break;
            case 3:
                status = false;
                break;

        }

        return status;
    }
    #endregion
}