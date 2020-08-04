<%@ Page Language="C#" AutoEventWireup="true" CodeFile="guanxi.aspx.cs" Inherits="manager_system_guanxi" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
   <title>编辑商家</title>
   <link href="../../css/style.css" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="../../js/jquery/jquery-1.10.2.min.js"></script>
<script type="text/javascript" src="../../js/lhgdialog/lhgdialog.js?skin=idialog"></script>
<script type="text/javascript" src="../../js/jquery/Validform_v5.3.2_min.js"></script>
 
<script type="text/javascript" src="../../js/layout.js"></script>
<script type="text/javascript" src="../../js/pinyin.js"></script>

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
    <li><a href="guanxi.aspx">会员关系操作</a></li>
   
    </ul>
    </div>

    <div class="formbody">   
    <div class="formtitle"><span>会员关系操作<font color=red >(备注：会员关系会涉及到积分。所以请谨慎操作)</font></span></div>

    <div class="tab-content">
  
<dl>
    <dt>互换编号</dt>
    <dd>  <asp:TextBox ID="huiyuan_bianhao" runat="server"   MaxLength="20" CssClass="input normal" datatype="*" ajaxurl="../../tools/admin_ajax.ashx?action=bianhao_name" errormsg=""  Width="100"  ></asp:TextBox>
    <span class="Validform_checktip" >*</span>
    </dd>
  </dl> 

  <dl>
    <dt>被互换编号</dt>
    <dd>  <asp:TextBox ID="huiyuan_bianhao_to" runat="server"   MaxLength="20" CssClass="input normal" datatype="*" ajaxurl="../../tools/admin_ajax.ashx?action=bianhao_name" errormsg=""  Width="100"  ></asp:TextBox>
    <span class="Validform_checktip">*</span>
    </dd>
  </dl> 

   
  <dl style="width:100%;margin:0;padding:0;text-align:center;}">
   
  <asp:Button ID="btnSubmit" runat="server" Text="提交修改" CssClass="btn" onclick="btnSubmit_Click"   OnClientClick="javascript:if(!confirm('\n特别提示！？\n\n点击后请不要有其他任何操作！\n修改时请耐心等待关系重新建立。'))  return  false; "/>
    
  </dl>
      <!--工具栏-->
<div class="page-footer">
  <div class="btn-list">
    
  </div>
  <div class="clear"></div>
</div>
 
</div>
<!--/商家信息-->    
    </div>


     


    <!--/工具栏-->
  
    <script type="text/javascript">
        $('.tablelist tbody tr:odd').addClass('odd');
	</script>


    </form>



</body>
</html>
