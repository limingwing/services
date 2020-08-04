﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Service_Centre_un.aspx.cs" Inherits="manager_server_Service_Centre_un" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<title>服务中心</title>
<link href="../../css/style.css" rel="stylesheet" type="text/css" />
 
 
<script type="text/javascript" src="../../js/lhgcore.min.js"></script>
<script type="text/javascript" src="../../js/lhgcalendar.min.js"></script>
<script type="text/javascript" src="../../js/jquery/jquery-1.10.2.min.js"></script>
<script type="text/javascript" src="../../js/lhgdialog/lhgdialog.js?skin=idialog"></script>
<script type="text/javascript" src="../../js/jquery/Validform_v5.3.2_min.js"></script>
<script type="text/javascript" src="../../js/lhgdialog/lhgdialog.js?skin=idialog"></script>
<script type="text/javascript" src="../../js/layout.js"></script>
<script type="text/javascript" src="../../js/pinyin.js"></script>

<script type="text/javascript">
    J(function () {
        J('#txtstart_time').calendar({ btnBar: true });
        J('#txtstop_time').calendar({ btnBar: true });
    }); 
</script> 
</head>
<body>
    <form id="form1" runat="server">
	<div class="place">
    <span>位置:</span>
    <ul class="placeul">
    <li><a href="#">首页</a></li>
    <li><a href="#">服务中心</a></li>
    </ul>
    </div>
    <div class="rightinfo">
    <dl class="seachform">  
    <dd>    <span class="rule-single-select">
      <asp:DropDownList ID="type" runat="server">
                <asp:ListItem Value=1 Selected="True">会员编号</asp:ListItem>
                 <asp:ListItem Value=2  >会员姓名</asp:ListItem>
            </asp:DropDownList>
    </span><span class="single-select"><asp:TextBox ID="txtNote_no" runat="server" Width="120" CssClass="scinput"></asp:TextBox></span></dd>

    
     <dd><label>会员级别</label>  
    <span class="rule-single-select">
      <asp:DropDownList ID="ddlproduct_category_id"  runat="server" AutoPostBack="True" onselectedindexchanged="ddlproduct_category_id_SelectedIndexChanged">
          </asp:DropDownList>
    </span>
    </dd>
    
      <dd class="cx"><asp:Button ID="lbtnSearch" runat="server" CssClass="scbtn" onclick="btnSearch_Click" Text="查询"></asp:Button>   
	</dd>
      <dd class="toolbar1">
          <a href="zmd.aspx?action=Add"><li><span><img src="../../images/t01.png" /></span>申请添加</li></a>
        </dd>
    </dl>
	        <!--列表-->
<asp:Repeater ID="rptList" runat="server">
<HeaderTemplate>
    <table class="tablelist">
    	<thead>
    	<tr>
        <th width="40px;">序号</th>
		<th  width="100px;">会员编号</th>	
        <th  width="100px;">会员姓名</th>
		<th width="160px;">会员级别</th>
        <th width="160px;">注册时间</th>
         <th width="160px;">申请时间</th>
        <th width="160px;">推荐人</th>
   
       <%--<th width="120px;">专卖店级别</th>--%>
		<th width="100px;">操作</th>
	 
        </tr>
        </thead>
        <tbody>
            </HeaderTemplate>
<ItemTemplate> 
        <tr>
            <td><%# pageSize * page + Container.ItemIndex + 1 - pageSize%></td>
            <td><%# Eval("huiyuan_bianhao")%></td>
             <td><%# Eval("huiyuan_name")%></td>
             <td><%#new tbl_reg_jiebie().GetTitle(Convert.ToInt32(Eval("huiyuan_jiebie")))%></td>	
            <td><%#string.Format("{0:g}",Eval("huiyuan_add_time"))%></td>
            <td><%#string.Format("{0:g}", Eval("huiyuan_zm_sq_time"))%></td>
           <td><%# Eval("tjr_bianhao")%></td>
      
                 <%--<td><%# Eval("zhuanmai_jb")%>级</td>--%>
         	
           
            
            <td> <asp:LinkButton ID="lbtnDelCa" runat="server" CommandArgument='<%# Eval("huiyuan_id")%>' OnClientClick="return confirm('是否真的要删除申请？')" onclick="lbtnDelCa_Click"><font color =red>[删除申请]</font></asp:LinkButton>&nbsp;<a href="zmd.aspx?action=Edit&huiyuan_id=<%#Eval("huiyuan_id")%>" class="tablelink"><font color ="green">[修改]</font></a>&nbsp; <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%# Eval("huiyuan_id")%>'  onclick="queren_click"><font color =green>[确认]</font></asp:LinkButton></td>
        </tr> 
       
	   </ItemTemplate>
<FooterTemplate>
  <%#rptList.Items.Count == 0 ? "<tr><td align=\"center\" colspan=\"9\"><font color=red>暂无记录</font></td></tr>" : ""%>
   </tbody>
    </table>
</FooterTemplate>
</asp:Repeater> 
   
<div class="pagelist">
  <div class="l-btns">
    <span>显示</span><asp:TextBox ID="txtPageNum" runat="server" MaxLength=3 CssClass="pagenum" onkeydown="return checkNumber(event);" ontextchanged="txtPageNum_TextChanged" AutoPostBack="True"></asp:TextBox><span>条/页</span>
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