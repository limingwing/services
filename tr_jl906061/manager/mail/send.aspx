<%@ Page Language="C#" AutoEventWireup="true" CodeFile="send.aspx.cs" Inherits="manager_mail_send" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<title>编辑公告</title>
<link href="../../css/style.css" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="../../js/jquery/jquery-1.10.2.min.js"></script>
<script type="text/javascript" src="../../js/lhgdialog/lhgdialog.js?skin=idialog"></script>
<script type="text/javascript" src="../../js/jquery/Validform_v5.3.2_min.js"></script>
<script type="text/javascript" src="../../js/datepicker/WdatePicker.js"></script>
<script type="text/javascript" src="../../js/layout.js"></script>
<script type="text/javascript" src="../../js/pinyin.js"></script>
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
<script type="text/javascript" src="../js/layout.js"></script>
</head>
<body>
    <form id="form1" runat="server">
	<div class="place">
    <span>位置：</span>
    <ul class="placeul">
    <li><a href="../home.aspx">首页</a></li>
    <li><a href="article_list.aspx">留言管理</a></li>
    <li><a href="#">编辑留言</a></li>
    </ul>
    </div>
    
        <div class="formbody">   
    <div class="formtitle"><span>留言管理</span></div>
    <!--/公告信息-->
<div class="tab-content">
  
 <dl>
    <dt>留言标题</dt>
    <dd><asp:TextBox ID="txttitle" runat="server" Width="600" CssClass="input normal" datatype="*1-100" sucmsg=" " />
      <span class="Validform_checktip">* 标题最多100个字符</span>
      </dd>
  </dl> 

  <dl>
    <dt>接收编号</dt>
    <dd><asp:TextBox ID="txt_bianhao" runat="server" Width="300" CssClass="input normal" datatype="*1-100" sucmsg=" " ajaxurl="../../tools/admin_ajax.ashx?action=jsr_validate" />
      <span class="Validform_checktip">*</span>
      </dd>
  </dl> 
    <dl>
    <dt>留言内容</dt>
    <dd>
      <textarea id="txtContent" class="editor" style="visibility:hidden;" runat="server" ></textarea>
    </dd>
  </dl>
    
   
 

 
</div>
<!--/公告信息-->
    
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
