<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login_choose.aspx.cs" Inherits="manager_system_login_choose" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
   <title>登录页设置列表</title>
<link href="../../css/style.css" rel="stylesheet" type="text/css" />

<script type="text/javascript" src="../../js/jquery/jquery-1.10.2.min.js"></script>
<script type="text/javascript" src="../../js/lhgdialog/lhgdialog.js?skin=idialog"></script>

<script type="text/javascript" src="../../js/layout.js"></script>
</head>
<body>
    <form id="form1" runat="server">
	<div class="place">
    <span>位置：</span>
    <ul class="placeul">
    <li><a href="#">首页</a></li>
    <li><a href="#">登录页设置列表</a></li>
    </ul>
    </div>
    
    <div class="rightinfo">    
    <div class="tools">  
    	<ul class="toolbar">
       
        </ul>
        <ul class="toolbar1">
      
        </ul>    
    </div>  
   
    <!--列表-->
<asp:Repeater ID="rptList" runat="server">
<HeaderTemplate>
    <table class="tablelist">
    	<thead>
    	<tr>
        <th width="50px;">序号</th>
        <th>模板名称</th>
        <th>模板图片</th>
        <th width="50px;">状态</th>       
        <th width="100px;">操作</th>
        </tr>
        </thead>
   <tbody>
</HeaderTemplate>
<ItemTemplate> 
        <tr>
		<td><%# pageSize * page + Container.ItemIndex + 1 - pageSize%><asp:HiddenField ID="hidId" Value='<%#Eval("id")%>' runat="server" /></td>	
        <td><%# Eval("name")%></td>
        <td class="imgtd"><img src="<%# Eval("img_src")%>" width="200" height="80" onMouseOver="toolTip('<img src=<%# Eval("img_src")%>>')" onMouseOut="toolTip()" /></td>
		 <td><%#Eval("show_flag").ToString() == "0" ? "<font color=red>未启用</font>" : "<font color=green>已启用</font>"%></td>
		<td> <asp:LinkButton ID="lbtnDelCa" runat="server" CommandArgument='<%# Eval("id")%>' OnClientClick="return confirm('是否要真的启用该登录界面？')" onclick="lbtnqiyong_Click" Visible='<%# !Convert.ToBoolean(Convert.ToInt16(Eval("show_flag"))) %>' ><font color =green>[启用]</font></asp:LinkButton></td>
        </tr> 
     </ItemTemplate>
<FooterTemplate>
  <%#rptList.Items.Count == 0 ? "<tr><td align=\"center\" colspan=\"5\"><font color=red>暂无记录</font></td></tr>" : ""%>
   </tbody>
    </table>
</FooterTemplate>
</asp:Repeater>

<div class="pagelist">
  <div class="l-btns">
    <span>显示</span><asp:TextBox ID="txtPageNum" runat="server" CssClass="pagenum" onkeydown="return checkNumber(event);" ontextchanged="txtPageNum_TextChanged" AutoPostBack="True"></asp:TextBox><span>条/页</span>
  </div>
  <div id="PageContent" runat="server" class="default"></div>
</div>

    
    </div>
    <script type="text/javascript">
        $('.tablelist tbody tr:odd').addClass('odd');
	</script>
    </form>
</body>
<script type="text/javascript" src="../../js/ToolTip.js"></script>
</html>
