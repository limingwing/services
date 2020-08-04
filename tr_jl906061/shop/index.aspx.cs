using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class shop_index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!Page.IsPostBack)
        {

            class_bind();//左侧菜单大类绑定
            top_class_bind();//中间产品大类绑定
            banner_bind();//轮滚绑定
            tuijian();//推荐绑定
            news();//新闻绑定
            //AD();//广告展位绑定
        }




    }


    protected void GetWhichCommand(object sender, CommandEventArgs e)
    {
        if (e.CommandName == "gouwuche")
        {
            if (e.CommandArgument != null)
            {
                if (Session["hy_id1"] == null)
                {
                    Response.Write("<script language=javascript>alert('请重新登录！');top.location.href='login.aspx';</script>");
                    Response.End();

                }
                string KindID = e.CommandArgument.ToString();
                int goods_quantity = 1;
                if (KindID == "")
                {
                    Response.Write("<script language=javascript>alert('参数不正确！');top.location.href='index.aspx';</script>");
                    Response.End();
                }
                ShopCart.Add(KindID + '|' + "暂无",1);
                cart_total cartModel = ShopCart.GetTotal();
                Response.Write("<script language=javascript>alert('加入购物车成功！');top.location.href='index.aspx';</script>");
                Response.End();
            }
        }
 




    }

    #region 广告展位绑定=================================
    //private void AD()
    //{




    //    tbl_sinkia_advert bll = new tbl_sinkia_advert();
    //    this.ad.DataSource = bll.GetList(" 1=1   order by sort_id asc");
    //    this.ad.DataBind();



    //}
    #endregion
    #region 新闻绑定=================================
    private void news()
    {




        tbl_news bll = new tbl_news();
        this.news_bind.DataSource = bll.GetList(" is_show=1   order by sort_id asc");
        this.news_bind.DataBind();



    }
    #endregion
    #region 推荐绑定=================================
    private void tuijian()
    {




        tbl_product bll = new tbl_product();
        this.tuijian_bind.DataSource = bll.GetList_top_1(" pro_home_show=1   order by pro_id desc", 3);
        this.tuijian_bind.DataBind();



    }
    #endregion
    #region 轮滚绑定=================================
    private void banner_bind()
    {




        tbl_sinkia_banner bll = new tbl_sinkia_banner();
        this.banner.DataSource = bll.GetList(" 1=1   order by sort_id asc");
        this.banner.DataBind();



    }
    #endregion

    #region 中间产品大类绑定=================================
    private void top_class_bind()
    {




        tbl_sinkia_class bll = new tbl_sinkia_class();
        this.top_class.DataSource = bll.GetList1(" is_show=1   order by sort_id asc");
        this.top_class.DataBind();



    }
    #endregion



    #region 中间产品小类类绑定=================================
    protected void top_class_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {

        //判断里层repeater处于外层repeater的哪个位置（ AlternatingItemTemplate，FooterTemplate，

        //HeaderTemplate，，ItemTemplate，SeparatorTemplate）
        if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
        {
            Repeater rep = e.Item.FindControl("sub_class") as Repeater;//找到里层的repeater对象
            DataRowView rowv = (DataRowView)e.Item.DataItem;//找到分类Repeater关联的数据项 
            string typeid = rowv["id"].ToString(); //获取填充子类的id 
            tbl_sinkia_sub bll = new tbl_sinkia_sub();
            DataSet result2 = bll.GetList_top("   pid='" + typeid + "' and is_show=1 order by sort_id asc");

            rep.DataSource = result2;
            rep.DataBind();

            //Repeater rep2 = e.Item.FindControl("class_lei") as Repeater;//找到里层的repeater对象
            //DataRowView rowv2 = (DataRowView)e.Item.DataItem;//找到分类Repeater关联的数据项 
            //string typeid2 = rowv["id"].ToString(); //获取填充子类的id 
            //tbl_sinkia_sub bll2 = new tbl_sinkia_sub();
            //DataSet result4 = bll.GetList_top("   pid='" + typeid + "' and is_show=1 order by sort_id asc");

            //rep2.DataSource = result4;
            //rep2.DataBind();
            
            //绑定产品
            Repeater product_list1 = e.Item.FindControl("product_list") as Repeater;//找到里层的repeater对象
            DataRowView rowv1 = (DataRowView)e.Item.DataItem;//找到分类Repeater关联的数据项 
            string typeid1 = rowv["id"].ToString(); //获取填充子类的id 
      
            tbl_product bll1 = new tbl_product();
            DataSet result3 = bll1.GetList_top("  pro_pid IN (SELECT id FROM tbl_sinkia_sub WHERE pid=" + int.Parse(typeid1) + " )  and pro_isok=1 order by pro_id asc");

            product_list1.DataSource = result3;
            product_list1.DataBind();
            


        }
    }
    #endregion

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

    public string style(int i)
    {


        switch (i)
        {
            case 0:  
                return "am-u-sm-7 am-u-md-4 text-two sug";
                break;
            case 1:  
                return " am-u-sm-7 am-u-md-4 text-two";
                break;
            case 2:  
                return "am-u-sm-3 am-u-md-2 text-three big";
                break;
            case 3:
                return "am-u-sm-3 am-u-md-2 text-three sug";
                break;
            case 4:
                return "am-u-sm-3 am-u-md-2 text-three";
                break;
            case 5:
                return " am-u-sm-3 am-u-md-2 text-three last big";
                break;
            default:
                return "am-u-sm-7 am-u-md-4 text-two sug";
                break;
        }
      
    }
    public string style_id(int i)//绑定商品楼层样式
    {


        
       return "f"+Convert.ToInt16(i+1);
           
        

    }
    public string banner_id(int i)//绑定banner样式
    {



        return "banner" + Convert.ToInt16(i + 1);



    }

    public string pro_str(string str)
    {
        if (!string.IsNullOrEmpty(str))
        {
            if (str.Length>11)
                str = str.Substring(0, 11)+"…";
        }
        return str;
    }


    public string discout(object b)
    {
        string str=null;
        if (!string.IsNullOrEmpty(b.ToString()))
        {
            str = (Convert.ToDecimal(b) * 1m).ToString("n2");
        }
        return str;
    }
}