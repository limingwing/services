<%@ Page Language="C#" AutoEventWireup="true" CodeFile="open.aspx.cs" Inherits="manager_system_open" %>

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
    <li><a href="open.aspx">系统开关</a></li>
   
    </ul>
    </div>

    <div class="formbody">   
    <div class="formtitle"><span>系统开关<font color=red >(备注：“系统关闭后”会员将会无法登陆系统。)</font></span></div>

     <div class="tab-content">
  
  <dl >
    <dt>是否关闭</dt>
    <dd>
      <div class="rule-single-checkbox">
          <asp:CheckBox ID="cbIsLock" runat="server" Checked="True" />
      </div>
      <span class="Validform_checktip">*</span>
    </dd>
  </dl>

   <dl >
    <dt>关闭提示</dt>
    <dd>
      
        <asp:TextBox ID="message" class="input" runat="server" Height="84px" 
              TextMode="MultiLine" Width="307px"></asp:TextBox>
       
      <span class="Validform_checktip">*</span>
    </dd>
  </dl>
  <dl style="width:100%;margin:0;padding:0;text-align:center;}">

  <asp:Button ID="btnSubmit" runat="server" Text="提交保存" CssClass="btn" onclick="btnSubmit_Click"  />
    <input name="btnReturn" type="button" value="返回上一页" class="btn yellow" onclick="javascript:history.back(-1);" />
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
