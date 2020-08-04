<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login_gl.aspx.cs" Inherits="manager_system_login_gl" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<title>用户操作日志</title>
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
    <li><a href="#">用户登录日志</a></li>
    </ul>
    </div>
    
    <div class="rightinfo">
    
    <%--<div class="tools">
    
    	<ul class="toolbar">
    <li><span><img src="../../images/t02.png" /></span><a href="javascript:;" onclick="checkAll(this);">全选</a></li>
        <li class="click"><asp:LinkButton ID="btnDelete" runat="server" CssClass="del" OnClientClick="return ExePostBack('btnDelete');" onclick="btnDelete_Click"><span><img src="../../images/t03.png" /></span>删除</asp:LinkButton></li>
        </ul>         
    </div>   --%> 
    <dl class="seachform">
       <dd><label>关键字</label><span class="single-select"><asp:TextBox ID="txtKeywords" runat="server" CssClass="scinput"></asp:TextBox></span></dd>
      <dd class="cx"> <asp:Button ID="lbtnSearch" runat="server" CssClass="scbtn" onclick="btnSearch_Click" Text="查询"></asp:Button></dd>
    </dl>
        <!--列表-->
<asp:Repeater ID="rptList" runat="server">
<HeaderTemplate>
    <table class="tablelist">
    	<thead>
    	<tr>
        <th>选择</th>
        <th>序号</th>
         <th>操作人账号</th>
         <th>操作人姓名</th>
      
		<th>用户IP</th>
        <th>登录时间</th>    
        </tr>
        </thead>
        <tbody>
        </HeaderTemplate>
<ItemTemplate> 
        <tr>
		<td><asp:CheckBox ID="chkId" CssClass="checkall" runat="server" />
      <asp:HiddenField ID="hidId" Value='<%#Eval("id")%>' runat="server" /></td>
		<td><%# pageSize * page + Container.ItemIndex + 1 - pageSize%></td>	
        <td><a href="login_gl.aspx?keywords=<%# Eval("huiyuan_bianhao") %>"><%# Eval("huiyuan_bianhao")%></a></td>
	   <td><a href="login_gl.aspx?keywords=<%# Eval("huiyuan_name") %>"><%# Eval("huiyuan_name")%></a></td>
		 
        <td> <%# Eval("huiyuan_ip") %></td>
        <td><%#string.Format("{0:g}",Eval("login_date"))%></td>
        </tr> 
  </ItemTemplate>
<FooterTemplate>
  <%#rptList.Items.Count == 0 ? "<tr><td align=\"center\" colspan=\"7\"><font color=red>暂无记录</font></td></tr>" : ""%>
   </tbody>
    </table>
</FooterTemplate>
</asp:Repeater>  
   

<div class="pagelist">
  <div class="l-btns">
    <span>显示</span><asp:TextBox ID="txtPageNum" runat="server" MaxLength=3  CssClass="pagenum" onkeydown="return checkNumber(event);" ontextchanged="txtPageNum_TextChanged" AutoPostBack="True"></asp:TextBox><span>条/页</span>
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
