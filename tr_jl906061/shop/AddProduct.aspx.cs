using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;

public partial class shop_AddProduct : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (Session["hy_id1"] == null)
            {
                Response.Write("<script language=javascript>alert('请重新登录！');top.location.href='login.aspx';</script>");
                Response.End();

            }
            QDBind();
            attributebind();
            procityareabind();
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
        this.ddlprov.Items.Add(new ListItem("请选择省份...", ""));
        foreach (DataRow dr in dt.Rows)
        {
            string Id = dr["ProID"].ToString();
            string Title = dr["ProName"].ToString().Trim();
            this.ddlprov.Items.Add(new ListItem(Title, Id));
        }

        T_City bllc = new T_City();
        DataTable dtc = bllc.GetList("1=1 order by CitySort").Tables[0];
        this.ddlcity.Items.Clear();
        this.ddlcity.Items.Add(new ListItem("请选择城市...", ""));
        //foreach (DataRow dr in dtc.Rows)
        //{
        //    string Id = dr["CityID"].ToString();
        //    string Title = dr["CityName"].ToString().Trim();
        //    this.ddlcity.Items.Add(new ListItem(Title, Id));
        //}

        T_District blld = new T_District();
        DataTable dtd = blld.GetList("1=1 order by DisSort").Tables[0];
        this.ddlarea.Items.Clear();
        this.ddlarea.Items.Add(new ListItem("请选择区县...", ""));
        //foreach (DataRow dr in dtd.Rows)
        //{
        //    string Id = dr["Id"].ToString();
        //    string Title = dr["DisName"].ToString().Trim();
        //    this.ddlarea.Items.Add(new ListItem(Title, Id));
        //}
    }
    #endregion
    protected void ddlprov_SelectedIndexChanged(object sender, EventArgs e)
    {
        string proid = this.ddlprov.SelectedValue;
        T_City bllc = new T_City();
        DataTable dtc = bllc.GetList("1=1 and ProID='" + proid + "' order by CitySort").Tables[0];
        this.ddlcity.Items.Clear();
        this.ddlcity.Items.Add(new ListItem("请选择城市...", ""));
        foreach (DataRow dr in dtc.Rows)
        {
            string Id = dr["CityID"].ToString();
            string Title = dr["CityName"].ToString().Trim();
            this.ddlcity.Items.Add(new ListItem(Title, Id));
        }
        T_District blld = new T_District();
        DataTable dtd = blld.GetList("1=1 order by DisSort").Tables[0];
        this.ddlarea.Items.Clear();
        this.ddlarea.Items.Add(new ListItem("请选择区县...", ""));
    }
    protected void ddlcity_SelectedIndexChanged(object sender, EventArgs e)
    {
        string cityid = this.ddlcity.SelectedValue;
        T_District blld = new T_District();
        DataTable dtd = blld.GetList("1=1 and CityID='" + cityid + "' order by DisSort").Tables[0];
        this.ddlarea.Items.Clear();
        this.ddlarea.Items.Add(new ListItem("请选择区县...", ""));
        foreach (DataRow dr in dtd.Rows)
        {
            string Id = dr["Id"].ToString();
            string Title = dr["DisName"].ToString().Trim();
            this.ddlarea.Items.Add(new ListItem(Title, Id));
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        string uploadname1 = "";
        string uploadname2 = "";
        string uploadname3 = "";
        if (fileimg.HasFile)
        {
            string FileName = fileimg.FileName;


            string FileLastName = FileName.Substring(FileName.LastIndexOf(".") + 1).ToLower();    //获取后缀名

            if (FileLastName != "gif" && FileLastName != "jpg" && FileLastName != "png")
            {
                Response.Write("<script language=javascript>alert('请选择规定格式的图片！');</script>");
                return;
            }

            int FileLength = fileimg.PostedFile.ContentLength;
            //判断是否已经选取文件
            if (FileLength > 524000)
            {
                Response.Write("<script language=javascript>alert('图片大小超标！');</script>");
                return;
            }
            Random R = new Random();
            int val = 10 + R.Next(99);
            string sc = val.ToString();         //获取随机数
            string FileTime = DateTime.Now.ToString("yyyyMMddHHmmss") + sc;
            uploadname1 = FileTime + "." + FileLastName;

            FileExtension[] fe = { FileExtension.GIF, FileExtension.JPG, FileExtension.PNG };
            if (FileValidation.IsAllowedExtension(fileimg, fe))
            {

                string path = Server.MapPath("~/upload/pingju/");
                fileimg.PostedFile.SaveAs(path + uploadname1);


            }
            else
            {
                Response.Write("<script>alert('您只能上传jpg或者gif图片');</script>");
                return;
            }

        }
        else
        {
            Response.Write("<script language=javascript>alert('请上传图片！');</script>");
            return;
        }
        if (fileimg1.HasFile)
        {
            string FileName = fileimg1.FileName;


            string FileLastName = FileName.Substring(FileName.LastIndexOf(".") + 1).ToLower();    //获取后缀名

            if (FileLastName != "gif" && FileLastName != "jpg" && FileLastName != "png")
            {
                Response.Write("<script language=javascript>alert('请选择规定格式的图片！');</script>");
                return;
            }

            int FileLength = fileimg1.PostedFile.ContentLength;
            //判断是否已经选取文件
            if (FileLength > 524000)
            {
                Response.Write("<script language=javascript>alert('图片大小超标！');</script>");
                return;
            }
            Random R = new Random();
            int val = 10 + R.Next(99);
            string sc = val.ToString();         //获取随机数
            string FileTime = DateTime.Now.ToString("yyyyMMddHHmmss") + sc;
            uploadname2 = FileTime + "." + FileLastName;

            FileExtension[] fe = { FileExtension.GIF, FileExtension.JPG, FileExtension.PNG };
            if (FileValidation.IsAllowedExtension(fileimg1, fe))
            {

                string path = Server.MapPath("~/upload/pingju/");
                fileimg1.PostedFile.SaveAs(path + uploadname2);


            }
            else
            {
                Response.Write("<script>alert('您只能上传jpg或者gif图片');</script>");
                return;
            }

        }
        else
        {
            Response.Write("<script language=javascript>alert('请上传图片！');</script>");
            return;
        }
        if (fileimg2.HasFile)
        {
            string FileName = fileimg2.FileName;


            string FileLastName = FileName.Substring(FileName.LastIndexOf(".") + 1).ToLower();    //获取后缀名

            if (FileLastName != "gif" && FileLastName != "jpg" && FileLastName != "png")
            {
                Response.Write("<script language=javascript>alert('请选择规定格式的图片！');</script>");
                return;
            }

            int FileLength = fileimg2.PostedFile.ContentLength;
            //判断是否已经选取文件
            if (FileLength > 524000)
            {
                Response.Write("<script language=javascript>alert('图片大小超标！');</script>");
                return;
            }
            Random R = new Random();
            int val = 10 + R.Next(99);
            string sc = val.ToString();         //获取随机数
            string FileTime = DateTime.Now.ToString("yyyyMMddHHmmss") + sc;
            uploadname3 = FileTime + "." + FileLastName;

            FileExtension[] fe = { FileExtension.GIF, FileExtension.JPG, FileExtension.PNG };
            if (FileValidation.IsAllowedExtension(fileimg2, fe))
            {

                string path = Server.MapPath("~/upload/pingju/");
                fileimg2.PostedFile.SaveAs(path + uploadname3);


            }
            else
            {
                Response.Write("<script>alert('您只能上传jpg或者gif图片');</script>");
                return;
            }

        }
        else
        {
            Response.Write("<script language=javascript>alert('请上传图片！');</script>");
            return;
        }

        tbl_product model1 = new tbl_product();
        model1.pro_imgs = "/upload/pingju/" + uploadname1;
        model1.pro_imgs1 = "/upload/pingju/" + uploadname2;
        model1.pro_imgs2 = "/upload/pingju/" + uploadname3;
        model1.pro_pid = int.Parse(ddlproduct_category_id.SelectedValue);
        model1.pro_date = DateTime.Now;
        model1.pro_name = txtproduct_name.Value.Trim();
        model1.pro_danwei = txtdw.Value.Trim(); ;
        model1.go_price = Convert.ToDecimal(txtgo_price.Value.Trim());
        model1.salse_price = Convert.ToDecimal(txtsalse_price.Value.Trim());
        model1.pro_level = int.Parse(attribute.SelectedValue);
        model1.pro_isok = 0;
        model1.pro_home_show = 0;
        model1.pro_Hot = 0;
        model1.huiyuan_id = Session["hy_id1"].ToString().Trim();
        model1.pro_type = 1;
        model1.province_id = int.Parse(this.ddlprov.SelectedValue);
        model1.city_id = int.Parse(this.ddlcity.SelectedValue);
        model1.dictrict_id = int.Parse(this.ddlarea.SelectedValue);
        if (model1.Add() > 0)
        {
            Response.Write("<script language=javascript>alert('产品新增成功等待审核！');location.href='AddProduct.aspx';</script>");
            return;
        }
    }
    //上传验证数组
    public enum FileExtension
    {
        JPG = 255216,
        GIF = 7173,
        PNG = 13780,
        SWF = 6787,
        RAR = 8297,
        ZIP = 8075,
        _7Z = 55122

        // 255216 jpg;   

        // 7173 gif;   

        // 6677 bmp,   

        // 13780 png;   

        // 6787 swf   

        // 7790 exe dll,   

        // 8297 rar   

        // 8075 zip   

        // 55122 7z   

        // 6063 xml   

        // 6033 html   

        // 239187 aspx   

        // 117115 cs   

        // 119105 js   

        // 102100 txt   

        // 255254 sql    

    }
    //上传验证类
    public class FileValidation
    {
        public static bool IsAllowedExtension(FileUpload fu, FileExtension[] fileEx)
        {
            int fileLen = fu.PostedFile.ContentLength;
            byte[] imgArray = new byte[fileLen];
            fu.PostedFile.InputStream.Read(imgArray, 0, fileLen);
            MemoryStream ms = new MemoryStream(imgArray);
            System.IO.BinaryReader br = new System.IO.BinaryReader(ms);
            string fileclass = "";
            byte buffer;
            try
            {
                buffer = br.ReadByte();
                fileclass = buffer.ToString();
                buffer = br.ReadByte();
                fileclass += buffer.ToString();
            }
            catch
            {
            }
            br.Close();
            ms.Close();
            foreach (FileExtension fe in fileEx)
            {
                if (Int32.Parse(fileclass) == (int)fe)
                    return true;
            }
            return false;
        }
    }
}