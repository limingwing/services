<%@ Page Language="C#" AutoEventWireup="true" CodeFile="rec.aspx.cs" Inherits="manager_yeji_rec" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<title>用户操作日志</title>
<link href="../../css/style.css" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="../../js/lhgcore.min.js"></script>
<script type="text/javascript" src="../../js/jquery/jquery-1.10.2.min.js"></script>
<script type="text/javascript" src="../../js/lhgdialog/lhgdialog.js?skin=idialog"></script>
<script type="text/javascript" src="../../js/lhgcalendar.min.js"></script>

<script type="text/javascript" src="../../js/layout.js"></script>
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
    <span>位置：</span>
    <ul class="placeul">
    <li><a href="../index.aspx">首页</a></li>
    <li><a href="#">财务明细</a></li>
    </ul>
    </div>
    
    <div class="rightinfo">
    
    <div class="tools">
    
    	<ul class="toolbar">
    <li><span><img src="../../images/t02.png" /></span><a href="javascript:;" onclick="checkAll(this);">全选</a></li>
        <li class="click"><asp:LinkButton ID="btnDelete" runat="server" CssClass="del" OnClientClick="return ExePostBack('btnDelete');" onclick="btnDelete_Click" Visible=false ><span><img src="../../images/t03.png" /></span>删除</asp:LinkButton></li>
        </ul>         
    </div>    
    <dl class="seachform">
       <dd><label>关键字</label><span class="single-select"><asp:TextBox ID="txtKeywords" runat="server" CssClass="scinput"></asp:TextBox></span></dd>
        <dd><label>开始日期</label><span class="single-select"><input  type="text" class="timeinput" id="txtstart_time" name="txtstart_time" readonly="readonly" runat="server" /></span></dd>
	<dd><label>结束日期</label><span class="single-select"><input type="text" class="timeinput" id="txtstop_time" name="txtstop_time" readonly="readonly" runat="server"/></span></dd> 
      <dd class="cx"> <asp:Button ID="lbtnSearch" runat="server" CssClass="scbtn" onclick="btnSearch_Click" Text="查询"></asp:Button></dd>
      <dd class="toolbar1">
        <asp:LinkButton ID="btnExport" runat="server" CssClass="save" onclick="btnExport_Click">   <li><span><img src="../../images/t04.png" /></span>导出Execl</li></asp:LinkButton>
        </dd>
    </dl>
        <!--列表-->
<asp:Repeater ID="rptList" runat="server">
<HeaderTemplate>
    <table class="tablelist">
    	<thead>
    	<tr>
        <th>选择</th>
        <th>序号</th>
         <th>会员编号</th>
         <th>会员级别</th>
         <th>时间</th>
         <th>改变量</th>
		<th>改变后余额</th>
        <th>改变原因</th>
        <th>备注</th>    
        </tr>
        </thead>
        <tbody>
        </HeaderTemplate>
<ItemTemplate> 
        <tr>
		<td><asp:CheckBox ID="chkId" CssClass="checkall" runat="server" />
      <asp:HiddenField ID="hidId" Value='<%#Eval("id")%>' runat="server" /></td>
		<td><%# pageSize * page + Container.ItemIndex + 1 - pageSize%></td>	
        <td><a href="rec.aspx?keywords=<%# Eval("huiyuan_bianhao") %>"><%# Eval("huiyuan_bianhao")%></a></td>
        <td><%#new tbl_reg_jiebie().GetTitle(Convert.ToInt32(Eval("huiyuan_jiebie")))%></td>
	    <td><%#string.Format("{0:g}",Eval("queren_date"))%></td>
		 <td><%# MyZF(MyConvert(Eval("queren_money")))%></td>
        <td><%# MyConvert(Eval("money_before"))%></td>
        <td><a href="rec.aspx?keywords=<%# Eval("action_type") %>"><%# Eval("action_type")%></a></td>
        <td><%# Eval("memo")%></td>
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
