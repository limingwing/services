﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="bank_edit.aspx.cs" Inherits="manager_system_bank_edit" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<title>编辑银行信息</title>
<script type="text/javascript" src="../../js/jquery/jquery-1.10.2.min.js"></script>
<script type="text/javascript" src="../../js/lhgdialog/lhgdialog.js?skin=idialog"></script>
<script type="text/javascript" src="../../js/jquery/Validform_v5.3.2_min.js"></script>
<script type="text/javascript" src="../../js/layout.js"></script>
<script type="text/javascript" src="../../js/pinyin.js"></script>
<link href="../../css/style.css" rel="stylesheet" type="text/css" />
<script type="text/javascript">
    $(function () {
        //初始化表单验证
        $("#form1").initValidform();
    });
</script>
</head>
<body>
    <form id="form1" runat="server">

	<div class="place">
    <span>位置：</span>
    <ul class="placeul">
    <li><a href="../index.aspx">首页</a></li>
    <li><a href="manage.aspx">银行信息管理</a></li>
    <li><a href="#">编辑银行信息</a></li>
    </ul>
    </div>
    
    <div class="formbody">
    <div class="formtitle"><span>银行信息</span></div>
    <!--用户信息-->
<div class="tab-content">



<dl>
    <dt>开户银行</dt>
    <dd><asp:TextBox ID="txtBank" runat="server" CssClass="input normal" sucmsg=" " ></asp:TextBox> <span class="Validform_checktip"></span></dd>
  </dl>
<dl>
    <dt>开户姓名</dt>
    <dd><asp:TextBox ID="txtName" runat="server" CssClass="input normal" sucmsg=" " ></asp:TextBox> <span class="Validform_checktip"></span></dd>
  </dl>
  <dl>
    <dt>银行账号</dt>
    <dd><asp:TextBox ID="txtNumber" runat="server" CssClass="input normal" sucmsg=" "></asp:TextBox> <span class="Validform_checktip"></span></dd>
  </dl>
  
  <dl>
    <dt>备份</dt>
    <dd><asp:TextBox ID="txtBeifen" runat="server" CssClass="input normal" sucmsg=" "></asp:TextBox><span class="Validform_checktip"></span></dd>
  </dl>
   



  
</div>
<!--/用户信息-->    
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