using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;

public partial class shop_ApplySupply : System.Web.UI.Page
{
    tbl_huiyuan bll = new tbl_huiyuan();
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!Page.IsPostBack)
        {
            if (Session["hy_id1"] == null)
            {
                Response.Write("<script language=javascript>alert('请重新登录！');top.location.href='login.aspx';</script>");
                Response.End();

            }
            yhBind();

        }
    }

    #region 绑定银行=================================
    private void yhBind()
    {
        tbl_reg_bank bll = new tbl_reg_bank();
        DataTable dt = bll.GetList("1=1   order by sort_id").Tables[0];
        this.bankName.Items.Clear();
        this.bankName.Items.Add(new ListItem("请选择银行...", ""));
        foreach (DataRow dr in dt.Rows)
        {
            string Id = dr["bank_name"].ToString();
            string Title = dr["bank_name"].ToString().Trim();
            this.bankName.Items.Add(new ListItem(Title, Id));
        }
    }
    #endregion

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(this.bankName.SelectedValue.ToString()))
        {
            Response.Write("<script language=javascript>alert('开户银行没有选择！');history.go(-1);</script>");
            return;

        }
        string uploadname1 = "", uploadname2 = "";
        if (fileNo.HasFile)
        {
            string FileName = fileNo.FileName;


            string FileLastName = FileName.Substring(FileName.LastIndexOf(".") + 1).ToLower();    //获取后缀名

            if (FileLastName != "gif" && FileLastName != "jpg" && FileLastName != "png")
            {
                Response.Write("<script language=javascript>alert('请选择规定格式的图片！');</script>");
                return;
            }

            int FileLength = fileNo.PostedFile.ContentLength;
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
            if (FileValidation.IsAllowedExtension(fileNo, fe))
            {

                string path = Server.MapPath("~/upload/pingju/");
                fileNo.PostedFile.SaveAs(path + uploadname1);


            }
            else
            {
                Response.Write("<script>alert('您只能上传jpg或者gif图片');</script>");
                return;
            }

        }
        else
        {
            Response.Write("<script language=javascript>alert('请上传营业执照图片！');</script>");
            return;
        }
        if (fileImg.HasFile)
        {
            string FileName = fileImg.FileName;


            string FileLastName = FileName.Substring(FileName.LastIndexOf(".") + 1).ToLower();    //获取后缀名

            if (FileLastName != "gif" && FileLastName != "jpg" && FileLastName != "png")
            {
                Response.Write("<script language=javascript>alert('请选择规定格式的图片！');</script>");
                return;
            }

            int FileLength = fileImg.PostedFile.ContentLength;
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
            if (FileValidation.IsAllowedExtension(fileImg, fe))
            {

                string path = Server.MapPath("~/upload/pingju/");
                fileImg.PostedFile.SaveAs(path + uploadname2);


            }
            else
            {
                Response.Write("<script>alert('您只能上传jpg或者gif图片');</script>");
                return;
            }

        }
        else
        {
            Response.Write("<script language=javascript>alert('请上传店铺图片！');</script>");
            return;
        }

        tbl_supplier model_th = new tbl_supplier();
        model_th.supplyName = this.name.Value.Trim().ToString();
        model_th.huiyuan_id = Session["hy_id1"].ToString();
        model_th.legalName = this.legalname.Value.Trim().ToString();
        model_th.legalPhone = this.legalPhone.Value.Trim().ToString();
        //model_th.supplierProfile = this.content.Value.Trim().ToString();
        model_th.supplyAddress = this.address.Value.Trim().ToString();
        //model_th.idCard = this.idcard.Value.Trim().ToString();
        //model_th.email = this.email.Value.Trim().ToString();
        model_th.businessNO = "/upload/pingju/" + uploadname1;
        model_th.SupplyImg = "/upload/pingju/" + uploadname2;
        model_th.Category = this.category.Value.Trim().ToString();
        model_th.BankNo = this.bankno.Value.Trim().ToString();
        model_th.BankAddress = this.bankaddress.Value.Trim().ToString();
        model_th.BankName = this.bankName.SelectedItem.ToString();
        model_th.ApplyTime = DateTime.Now;
        if (model_th.Add() > 0)
        {
            tbl_huiyuan tbl = new tbl_huiyuan();
            tbl.GetModel_hui_id(Session["hy_id1"].ToString());
            tbl.supply = 1;
            tbl.Update();
            Response.Write("<script language=javascript>alert('商家申请成功等待审核！');location.href='member_center.aspx';</script>");
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