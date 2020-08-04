using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class shop_sort : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {

            class_bind();//左侧菜单大类绑定
        }
    }
    #region 产品大类绑定=================================
    private void class_bind()
    {




        tbl_sinkia_class bll = new tbl_sinkia_class();
        this.Repeater1.DataSource = bll.GetList1(" 1=1   order by sort_id asc");
        this.Repeater1.DataBind();



    }
    #endregion

    #region 产品小类绑定=================================
    protected void rptypelist_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {

        //判断里层repeater处于外层repeater的哪个位置（ AlternatingItemTemplate，FooterTemplate，

        //HeaderTemplate，，ItemTemplate，SeparatorTemplate）
        if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
        {
            Repeater rep = e.Item.FindControl("Repeater3") as Repeater;//找到里层的repeater对象
            DataRowView rowv = (DataRowView)e.Item.DataItem;//找到分类Repeater关联的数据项 
            string typeid = rowv["id"].ToString(); //获取填充子类的id 
            tbl_sinkia_sub bll = new tbl_sinkia_sub();
            DataSet result2 = bll.GetList("   pid='" + typeid + "' and is_show=1 order by sort_id asc");

            rep.DataSource = result2;
            rep.DataBind();
        }
    }
    #endregion
}