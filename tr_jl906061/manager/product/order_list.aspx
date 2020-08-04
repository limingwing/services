<%@ Page Language="C#" AutoEventWireup="true" CodeFile="order_list.aspx.cs" Inherits="manager_product_order_list" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<title>未处理订单</title>
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
    <li><a href="#">未处理订单</a></li>
    </ul>
    </div>  
    <div class="rightinfo">
    <dl class="seachform"> 
    <dd>    <span class="rule-single-select">
      <asp:DropDownList ID="type" runat="server">
                <asp:ListItem Value=1 Selected="True">会员编号</asp:ListItem>
                 <asp:ListItem Value=2  >会员姓名</asp:ListItem>
                 <asp:ListItem Value=3 >订单号</asp:ListItem>
            </asp:DropDownList>
    </span><span class="single-select"><asp:TextBox ID="txtNote_no" runat="server" Width="120" CssClass="scinput"></asp:TextBox></span></dd>
	

     <dd><label>下单起始日期</label><span class="single-select"><input  type="text" class="timeinput" id="txtstart_time" name="txtstart_time" readonly="readonly" runat="server" /></span></dd>
	<dd><label>下单结束日期</label><span class="single-select"><input type="text" class="timeinput" id="txtstop_time" name="txtstop_time" readonly="readonly" runat="server"/></span></dd>
   <dd><label>订单状态</label>  
    <span class="rule-single-select">
<asp:DropDownList ID="ddlStatus" runat="server" AutoPostBack="True" onselectedindexchanged="ddlStatus_SelectedIndexChanged">
            <asp:ListItem Value="" Selected="True">==全部==</asp:ListItem>
      
            <asp:ListItem Value="1">已生成</asp:ListItem>
            <asp:ListItem Value="2">已发货</asp:ListItem>
            <asp:ListItem Value="3">已收货</asp:ListItem>
            <%--<asp:ListItem Value="4">已取消</asp:ListItem>--%>

          </asp:DropDownList>
    </span>
    </dd>
     <dd><label>付款状态</label>  
    <span class="rule-single-select">
<asp:DropDownList ID="zhifu" runat="server" AutoPostBack="True" onselectedindexchanged="zhifu_SelectedIndexChanged1">
            <asp:ListItem Value="" Selected="True">==全部==</asp:ListItem>
      
            <asp:ListItem Value="1">未付款</asp:ListItem>
            <asp:ListItem Value="2">已付款</asp:ListItem>
           
            <%--<asp:ListItem Value="4">已取消</asp:ListItem>--%>

          </asp:DropDownList>
    </span>
    </dd>

      <dd class="cx"><asp:Button ID="lbtnSearch" runat="server" CssClass="scbtn" onclick="btnSearch_Click" Text="查询"></asp:Button>   
 </dd>
 <%--<dd class="toolbar1">
        <asp:LinkButton ID="btnExport" runat="server" CssClass="save" onclick="btnExport_Click">   <li><span><img src="../../images/t04.png" /></span>导出Execl</li></asp:LinkButton>
        </dd>--%>
    </dl>
            <!--列表-->

 
	  <table class="tablelist">
    	<thead>
    	<tr>
        <th width="100px;">序号</th>
		<th  width="150px;">订单号</th>
		<th width="120px;">会员编号</th>
        <th width="120px;">会员姓名</th> 
        <%--<th width="80px;">会员级别</th> --%>
        <th width="8%">订单状态</th>
       <%-- <th width="8%">支付方式</th>--%>
         <th width="8%">支付状态</th>
		<%--<th width="80px;">订单原价金额 </th>--%>
        <th width="80px;">付款金额 </th>
        <!--<th width="80px;">总PV </th>-->
		<th width="130px;">下单时间</th>
         <th width="90px;">操作</th>     
        </tr>
        </thead>
        <tbody>
 <asp:Repeater ID="rptList" runat="server">
<ItemTemplate>
        <tr>
            <td><%# pageSize * page + Container.ItemIndex + 1 - pageSize%></td>
            <td><%# Eval("order_no")%></td>
            <td><%# Eval("user_bianhao")%></td>
            <td><%# Eval("user_name")%></td>
            <%--<td><%#new tbl_reg_jiebie().GetTitle(Convert.ToInt32(Eval("huiyuan_jiebie")))%></td>	--%>
             <td ><%#new tbl_orders().GetOrderStatus(Convert.ToInt32(Eval("status")))%></td>
               <%--<td ><%#zhifu_type(Convert.ToInt32(Eval("flag")))%></td>--%>
               <td ><%#new tbl_orders().pay_status(Convert.ToInt32(Eval("payment_status")))%></td>
            <td><%# MyConvert(Eval("payable_amount"))%></td>
            <%--<td><%# MyConvert(zhifu_type1(int.Parse(Eval("id").ToString())))%></td>--%>
              <!--<td><%# MyConvert(Eval("order_amount"))%></td>	-->			
            <td><%#string.Format("{0:g}",Eval("add_time"))%></td>
            <td><a href="../product/order_edit.aspx?action=Edit&id=<%#Eval("id")%>" class="tablelink"> 处理订单</a> </td>
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
