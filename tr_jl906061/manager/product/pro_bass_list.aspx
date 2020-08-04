<%@ Page Language="C#" AutoEventWireup="true" CodeFile="pro_bass_list.aspx.cs" Inherits="manager_product_pro_bass_list" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
   <title>基础设置</title>
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
    <li><a href="#">基础设置</a></li>
    </ul>
    </div>
    
    <div class="rightinfo">    
    
    <!--列表-->
<asp:Repeater ID="rptList" runat="server">
<HeaderTemplate>
    <table class="tablelist">
    	<thead>
    	<tr>
        <th width="50px;">序号</th>
        <th width="50px;">商城标题</th>
        <%--<th width="50px;">二维码</th>--%>
        <th width="50px;">手机商城logo</th>
        <th width="50px;">电脑商城logo</th>
        <th width="50px;">开发QQ号</th>
        <th width="50px;">版权所有</th>       
        <th width="100px;">操作</th>
        </tr>
        </thead>
   <tbody>
</HeaderTemplate>
<ItemTemplate> 
        <tr>
		<td><%# pageSize * page + Container.ItemIndex + 1 - pageSize%><asp:HiddenField ID="hidId" Value='<%#Eval("id")%>' runat="server" /></td>	
        <td><%# Eval("home_title")%></td>
         <%--<td><img src="<%# Eval("home_code")%>" width=80px height=80px /></td>	--%>
         <td>
         <img src="<%# Eval("logo_mobel_img")%>" width=80px height=80px>
         </td>
          <td> <img src="<%# Eval("logo_web_img")%>" width=80px height=80px> </td>
           <td> <%# Eval("home_qq")%></td>	
		<td><%#Eval("home_copyright")%></td>		
		<td><a href="pro_bass_edit.aspx?action=Edit&id=<%#Eval("id")%>&page=<%=page%>" class="tablelink"><font color =green>[修改]</font></a>  </td>
        </tr> 
     </ItemTemplate>
<FooterTemplate>
  <%#rptList.Items.Count == 0 ? "<tr><td align=\"center\" colspan=\"5\"><font color=red>暂无记录</font></td></tr>" : ""%>
   </tbody>
    </table>
</FooterTemplate>
</asp:Repeater>  
    
    </div>
    <script type="text/javascript">
        $('.tablelist tbody tr:odd').addClass('odd');
	</script>
    </form>
</body>
</html>
