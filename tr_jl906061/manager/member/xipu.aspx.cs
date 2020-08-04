using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Web.UI.WebControls;

public partial class manager_member_xipu : System.Web.UI.Page
{
    protected string bianhao = string.Empty;
    protected string huiyuan_id = string.Empty;
    protected int cheng = 1;
    protected int Depth = 800;
    tbl_huiyuan bll = new tbl_huiyuan();
    ManagePage mym = new ManagePage();
    protected void Page_Load(object sender, EventArgs e)
    {
        this.bianhao = "A00000000";
        this.huiyuan_id = "A00000000";
        if (!IsPostBack)
        {
            LoadTreeData();
        }

    }

    protected void LoadTreeData()
    {
        TreeNode tn = new TreeNode();
        
        bll.GetModel_hui_id(huiyuan_id);
        int huiyuan_jb = int.Parse(bll.huiyuan_jiebie.ToString());
        string huiyuan_name = bll.huiyuan_name;
        string jb_name = new tbl_reg_jiebie().GetTitle(huiyuan_jb);
        tn.Text = "" + bianhao + "[" + huiyuan_name + "][" + jb_name + "]";
        tn.Value = huiyuan_id;
        this.TreeView1.Nodes.Add(tn);





        DataTable dt = bll.GetList(" huiyuan_id<>'A00000000'").Tables[0];

        ClassTrewViewZi(dt, tn);



    }

    public void ClassTrewViewZi(DataTable dts, TreeNode tn)
    {
        DataRow[] dsv = dts.Select("huiyuan_shang_id='" + tn.Value + "'", "huiyuan_add_time desc");
        //Response.Write(1);
        //Response.End();
        foreach (DataRow drv in dsv)
        {

            cheng++; //当前层数
            if (cheng > Depth)
                continue;
            TreeNode retn = new TreeNode();
            //retn.Text = "[第" + drv["dai"].ToString() + "层]";

            retn.Value = drv["huiyuan_id"].ToString();

            string style = "red";
            string jb_name = new tbl_reg_jiebie().GetTitle(int.Parse(drv["huiyuan_jiebie"].ToString()));
            string huiyuan_name = drv["huiyuan_name"].ToString();
            if (drv["net_hege"].ToString() != "1")
            {
                retn.Text = "<font color=" + style + ">" + drv["huiyuan_bianhao"].ToString() + "[" + huiyuan_name +"][" + jb_name + "]<font>";
            }
            else
            {
                retn.Text = "" + drv["huiyuan_bianhao"].ToString() + "[" + huiyuan_name +"][" + jb_name + "]";

            }
          
            retn.ToolTip += "加入时间：" + Convert.ToDateTime(drv["huiyuan_add_time"].ToString()).ToShortDateString() + "";
        
            retn.Expanded =false;
            

            tn.ChildNodes.Add(retn);
            ClassTrewViewZi(dts, retn);
        }
    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {

     
        if (!bll.Exists_hui_bianhao(this.huiyuan_bianhao.Text.Trim()))
        {

            mym.JscriptMsg(this.Page, "没有该编号！", "", "Error");
            return;


        }
        else
        {


            this.TreeView1.Nodes.Clear();
            this.bianhao = this.huiyuan_bianhao.Text.Trim();
            bll.GetModel_hui_bianhao(this.bianhao);
            this.huiyuan_id = bll.huiyuan_id;
            LoadTreeData();


        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //expd_all(TreeView1.Nodes[0], 1);

    }
}