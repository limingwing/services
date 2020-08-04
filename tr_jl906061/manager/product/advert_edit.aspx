<%@ Page Language="C#" AutoEventWireup="true" CodeFile="advert_edit.aspx.cs" Inherits="manager_product_advert_edit" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
   <title>编辑 首页展位管理</title>
<script type="text/javascript" src="../../js/jquery/jquery-1.10.2.min.js"></script>
<script type="text/javascript" src="../../js/lhgdialog/lhgdialog.js?skin=idialog"></script>
<script type="text/javascript" src="../../js/jquery/Validform_v5.3.2_min.js"></script>
<script type="text/javascript" src="../../js/layout.js"></script>
<script type="text/javascript" src="../../js/pinyin.js"></script>
<script type="text/javascript" src="../../js/swfupload/swfupload.js"></script>
<script type="text/javascript" src="../../js/swfupload/swfupload.queue.js"></script>
<script type="text/javascript" src="../../js/swfupload/swfupload.handlers.js"></script>
<link href="../../css/style.css" rel="stylesheet" type="text/css" />

<script type="text/javascript" charset="utf-8" src="../../editor/kindeditor-min.js"></script>
<script type="text/javascript" charset="utf-8" src="../../editor/lang/zh_CN.js"></script>
<script type="text/javascript">
    $(function () {
        //初始化表单验证
        $("#form1").initValidform();
        //初始化编辑器
        var editor = KindEditor.create('#txtContent', {
            width: '80%',
            height: '350px',
            resizeType: 1,
            uploadJson: '../../tools/upload_ajax.ashx?action=EditorFile&IsWater=1',
            fileManagerJson: '../../tools/upload_ajax.ashx?action=ManagerFile',
            allowFileManager: true
        });

    });
  
</script>
<script type="text/javascript">
    $(function () {
        //初始化表单验证
        $("#form1").initValidform();

        //初始化上传控件
        $(".upload-img").each(function () {
            $(this).InitSWFUpload({ sendurl: "../../tools/upload_ajax.ashx", flashurl: "../../js/swfupload/swfupload.swf" });
        });

        //设置封面图片的样式
        $(".photo-list ul li .img-box img").each(function () {
            if ($(this).attr("src") == $("#hidFocusPhoto").val()) {
                $(this).parent().addClass("selected");
            }
        });

        //设置封面图片的样式
        $(".photo-list ul li .img-box img").each(function () {
            if ($(this).attr("src") == $("#hidFocusPhoto").val()) {
                $(this).parent().addClass("selected");
            }
        });


    });

</script>

 
</head>
<body>
    <form id="form1" runat="server">
	<div class="place">
    <span>位置：</span>
    <ul class="placeul">
    <li><a href="#">首页</a></li>
    <li><a href="#"> 管理</a></li>
    <li><a href="#">编辑 首页展位管理</a></li>
    </ul>
    </div>

    <div class="formbody">   
    <div class="formtitle"><span> 首页展位管理</span></div>
    <!--/ 类别管理-->
<div class="tab-content">
<dl>
    <dt>广告标题</dt>
 
    <dd><asp:TextBox ID="title" runat="server" CssClass="input normal" datatype="*"  sucmsg=" " ></asp:TextBox> <span class="Validform_checktip">*</span>
        
    </dd>
  </dl>

  <dl>
    <dt>广告图</dt>
    <dd>

         <asp:TextBox ID="txtImgUrl_mob" runat="server" CssClass="input normal upload-path" />
      <div class="upload-box upload-img"></div>  <span class="Validform_checktip">*请上传广告图</span> <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtImgUrl_mob"
                ErrorMessage="请选择您要上传的图片！"></asp:RequiredFieldValidator>
    </dd>
  </dl>

<%--    <dl>
    <dt>广告图1</dt>
    <dd>

         <asp:TextBox ID="txtImgUrl_mob1" runat="server" CssClass="input normal upload-path" />
      <div class="upload-box upload-img"></div>  <span class="Validform_checktip">*请上传广告图1</span> <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtImgUrl_mob1"
                ErrorMessage="请选择您要上传的图片！"></asp:RequiredFieldValidator>
    </dd>
  </dl>  <dl>
    <dt>广告图2</dt>
    <dd>

         <asp:TextBox ID="txtImgUrl_mob2" runat="server" CssClass="input normal upload-path" />
      <div class="upload-box upload-img"></div>  <span class="Validform_checktip">*请上传广告图2</span> <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtImgUrl_mob2"
                ErrorMessage="请选择您要上传的图片！"></asp:RequiredFieldValidator>
    </dd>
  </dl>--%>
 <dl>
    <dt>图片跳转地址</dt>
 
    <dd><asp:TextBox ID="pid" runat="server" CssClass="input normal" datatype="*"  sucmsg=" " ></asp:TextBox> <span class="Validform_checktip">*</span>
        
    </dd>
  </dl>

  
  <dl>
    <dt>排序数字</dt>
    <dd>
      <asp:TextBox ID="txtSortId" runat="server"  CssClass="input small" datatype="n" sucmsg=" ">1</asp:TextBox>
      <span class="Validform_checktip">*数字，越小越向前</span>
    </dd>
  </dl>

</div>
<!--/ 商品类别信息-->
    
    </div>

    <!--工具栏-->
<div class="page-footer">
  <div class="btn-list">
    <asp:Button ID="btnSubmit" runat="server" Text="提交保存" CssClass="btn" onclick="btnSubmit_Click"  />
    <input name="btnReturn" type="button" value="返回上一页" class="btn yellow" onclick="javascript:history.back(-1);" />
  </div>
  <div class="clear"></div>
</div>
<!--/工具栏-->

    </form>
</body>
</html>
