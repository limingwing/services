<%@ Page Language="C#" AutoEventWireup="true" CodeFile="timeList.aspx.cs" Inherits="manager_product_timeList" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<title>限时秒杀</title>
<link href="../../css/style.css" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="../../js/jquery/jquery-1.10.2.min.js"></script>
<script type="text/javascript" src="../../js/lhgdialog/lhgdialog.js?skin=idialog"></script>
<script type="text/javascript" src="../../js/layout.js"></script>
<script type="text/javascript" src="../../js/lhgcore.min.js"></script>
<script type="text/javascript" src="../../js/lhgcalendar.min.js"></script>
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
    <li><a href="../index.aspx">首页</a></li>
    <li><a href="#">限时秒杀</a></li>
    </ul>
    </div>  
    <div class="rightinfo">
      <div class="tools">  
    	<ul class="toolbar">
        <a href="addTimeKill.aspx?action=Add"><li><span><img src="../../images/t01.png" /></span>添加</li></a>
        </ul>
        
    </div>  
    <dl class="seachform"> 
    <%--<dd>    <span class="rule-single-select">
      <asp:DropDownList ID="type" runat="server">
                <asp:ListItem Value=1 Selected="True">会员编号</asp:ListItem>
                 <asp:ListItem Value=2  >会员姓名</asp:ListItem>
                 <asp:ListItem Value=3 >订单号</asp:ListItem>
            </asp:DropDownList>
    </span><span class="single-select"><asp:TextBox ID="txtNote_no" runat="server" Width="120" CssClass="scinput"></asp:TextBox></span></dd>--%>
	

     <dd><label>起始日期</label><span class="single-select"><input  type="text" class="timeinput" id="txtstart_time" name="txtstart_time" readonly="readonly" runat="server" /></span></dd>
	<dd><label>结束日期</label><span class="single-select"><input type="text" class="timeinput" id="txtstop_time" name="txtstop_time" readonly="readonly" runat="server"/></span></dd>
   <dd><label>状态</label>  
    <span class="rule-single-select">
<asp:DropDownList ID="ddlStatus" runat="server" AutoPostBack="True" onselectedindexchanged="ddlStatus_SelectedIndexChanged">
            <asp:ListItem Value="" Selected="True">==全部==</asp:ListItem>
      
            <asp:ListItem Value="0">未开始</asp:ListItem>
            <asp:ListItem Value="2">已结束</asp:ListItem>

          </asp:DropDownList>
    </span>
    </dd>
<%--     <dd><label>付款状态</label>  
    <span class="rule-single-select">
<asp:DropDownList ID="zhifu" runat="server" AutoPostBack="True" onselectedindexchanged="zhifu_SelectedIndexChanged1">
            <asp:ListItem Value="" Selected="True">==全部==</asp:ListItem>
      
            <asp:ListItem Value="1">未付款</asp:ListItem>
            <asp:ListItem Value="2">已付款</asp:ListItem>
           
            <%--<asp:ListItem Value="4">已取消</asp:ListItem>

          </asp:DropDownList>
    </span>
    </dd>--%>

      <dd class="cx"><asp:Button ID="lbtnSearch" runat="server" CssClass="scbtn" onclick="btnSearch_Click" Text="查询"></asp:Button>   
 </dd>
 
    </dl>
            <!--列表-->

 
	  <table class="tablelist">
    	<thead>
    	<tr>
        <th>序号</th>
        <th>限时名称</th>
        <th>活动状态</th>
        <th>开始时间</th>
        <th>结束时间</th>
		<th>创建时间</th>
         <th>操作</th>     
        </tr>
        </thead>
        <tbody>
 <asp:Repeater ID="rptList" runat="server">
<ItemTemplate>
        <tr>
            <td><%# pageSize * page + Container.ItemIndex + 1 - pageSize%></td>
            <td><%#Eval("name")%></td>
            <td ><%#zhifu_type(Convert.ToInt32(Eval("status")))%></td>
            <td><%#string.Format("{0:g}", Eval("StartTime"))%></td>
            <td><%#string.Format("{0:g}", Eval("EndTime"))%></td>
            <td><%#string.Format("{0:g}", Eval("CreateTime"))%></td>
            <td><a href="../product/addTimeKill.aspx?action=Edit&id=<%#Eval("kid")%>" class="tablelink">编辑</a> </td>
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
    <span>显示</span><asp:TextBox ID="txtPageNum" runat="server" CssClass="pagenum" onkeydown="return checkNumber(event);" ontextchanged="txtPageNum_TextChanged" AutoPostBack="True"></asp:TextBox><span>条/页</span>
  </div>
  <div id="PageContent" runat="server" class="default"></div>
</div>
      
    </div>
    </form>
</body>
</html>
