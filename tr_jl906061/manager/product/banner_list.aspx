<%@ Page Language="C#" AutoEventWireup="true" CodeFile="banner_list.aspx.cs" Inherits="manager_product_banner_list" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
   <title>首页轮播图管理</title>
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
    <li><a href="#">首页轮播图管理</a></li>
    </ul>
    </div>
    
    <div class="rightinfo">    
    <div class="tools">  
    	
        <ul class="toolbar1">
       <asp:LinkButton ID="btnSave" runat="server" CssClass="save" onclick="btnSave_Click"> <li><span><img src="../../images/t05.png" /></span>保存排序</li></asp:LinkButton>
        </ul>    
    </div>  
    
    <!--列表-->
<asp:Repeater ID="rptList" runat="server">
<HeaderTemplate>
    <table class="tablelist">
    	<thead>
    	<tr>
        <th width="50px;">序号</th>
        <th width="50px;">轮播图</th>
        <th width="50px;">图片跳转地址</th>
        <th width="50px;">排序</th>       
        <th width="100px;">操作</th>
        </tr>
        </thead>
   <tbody>
</HeaderTemplate>
<ItemTemplate> 
        <tr>
		<td><%# Eval("id")%><asp:HiddenField ID="hidId" Value='<%#Eval("id")%>' runat="server" /></td>	
         <td> <img src="<%# Eval("picture1")%>" width=80px height=80px></td>	
         <td><%# Eval("p1_url")%></td>
		<td><asp:TextBox ID="txtSortId" runat="server" Height="25"  Text='<%#Eval("sort_id")%>' CssClass="scinput" Width="40"  onkeydown="return checkNumber(event);" /></td>		
		<td><a href="banner_edit.aspx?action=Edit&id=<%#Eval("id")%>&page=<%=page%>" class="tablelink"><font color =green>[修改]</font></a> </td>
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
</html>
