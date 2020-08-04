<%@ Page Language="C#" AutoEventWireup="true" CodeFile="tikuan.aspx.cs" Inherits="manager_yeji_tikuan" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<title>提款查询</title>
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
    <li><a href="#">提款查询</a></li>
    </ul>
    </div>
    <div class="rightinfo">
    <div class="tools">
    
    	<ul class="toolbar">
    <li><span><img src="../../images/t02.png" /></span><a href="javascript:;" onclick="checkAll(this);">全选</a></li>
        <li class="click"><asp:LinkButton ID="btnDelete" runat="server" CssClass="del" OnClientClick="return ExePostBack1('btnDelete');" onclick="btnDelete_Click"><span><img src="../../images/t01.png" /></span>一键批准</asp:LinkButton></li>
       
        
        </ul>         
    </div>
    <dl class="seachform">  
    <dd>    <span class="rule-single-select">
      <asp:DropDownList ID="type" runat="server">
                <asp:ListItem Value=1 Selected="True">会员编号</asp:ListItem>
                 <asp:ListItem Value=2  >会员姓名</asp:ListItem>
            </asp:DropDownList>
    </span><span class="single-select"><asp:TextBox ID="txtNote_no" runat="server" Width="120" CssClass="scinput"></asp:TextBox></span></dd>

    <dd><label>开始日期</label><span class="single-select"><input  type="text" class="timeinput" id="txtstart_time" name="txtstart_time" readonly="readonly" runat="server" /></span></dd>
	<dd><label>截止日期</label><span class="single-select"><input type="text" class="timeinput" id="txtstop_time" name="txtstop_time" readonly="readonly" runat="server"/></span></dd> 
   
    
      <dd class="cx"><asp:Button ID="lbtnSearch" runat="server" CssClass="scbtn" onclick="btnSearch_Click" Text="查询"></asp:Button>   
	</dd>
      <dd class="toolbar1">
        <asp:LinkButton ID="btnExport" runat="server" CssClass="save" onclick="btnExport_Click">   <li><span><img src="../../images/t04.png" /></span>导出未处理提款Execl</li></asp:LinkButton>
       
        </dd>
         <dd class="toolbar1">
         <asp:LinkButton ID="LinkButton2" runat="server" CssClass="save" onclick="btnExport_Click1">   <li><span><img src="../../images/t04.png" /></span>导出已处理提款Execl</li></asp:LinkButton> 
       
        </dd>
       
    </dl>
	        <!--列表-->

 
    <table class="tablelist">
    	<thead>
    	<tr>
         <th width="5%">选择</th>
        <th width="5%">序号</th>
		<th  width="5%">会员编号</th>	
        <th  width="5%">开户银行</th>
        <th  width="5%">银行帐号</th>
        <th  width="5%">开户姓名</th>
        <th  width="10%">兑换金额<font color="red">(总累计:<asp:Literal ID="Literal2" runat="server"></asp:Literal>)</font></th>
         <th  width="5%">手续费</th>
        <th  width="10%">实发金额<font color="red">(总累计:<asp:Literal ID="Literal3" runat="server"></asp:Literal>)</font></th>
       
        <th  width="8%">兑换时间</th>
       <%--  <th  width="5%">账户类型</th>--%>
        <th  width="5%">状态</th>
        <th  width="8%">操作方法</th>
      
       
		 
	 
        </tr>
        </thead>
        <tbody>
        <asp:Repeater ID="rptList" runat="server"  >
<ItemTemplate> 
        <tr>
         <td><asp:CheckBox ID="chkId" CssClass="checkall" runat="server" />
     <asp:HiddenField ID="hidId" Value='<%#Eval("tikuan_id")%>' runat="server" /></td>
            <td><%# pageSize * page + Container.ItemIndex + 1 - pageSize%></td>
            <td><%# Eval("huiyuan_bianhao")%></td>
   
            <td><%# Eval("bankname")%></td>
            <td><%# Eval("accountno")%></td>
            <td><%# Eval("ysp_name")%></td>
            <td> <%#Eval("money", "{0:f}")%></td>
             <td> <%#Eval("money_sx", "{0:f}")%></td>
            <td> <%#Eval("money_sj", "{0:f}")%></td>
           	
            <td><%#string.Format("{0:g}", Eval("tikuan_date"))%></td>
           <%-- <td><%#GetzhifuStatus(Convert.ToInt32(Eval("zz_type")))%>	</td>--%>
            <td><%#GetOrderStatus(Convert.ToInt32(Eval("tikuan_status")))%>	</td>
            <td>
     <asp:LinkButton ID="lbtnModify" CommandName="zhifu" OnCommand="GetWhichCommand"  CommandArgument='<%# Eval("tikuan_id") %>'
                                    runat="server" OnClientClick='<%# String.Format("return confirm(\"您确定用户{0}提款{1:f}元信息吗？\")",Eval("huiyuan_bianhao"),Eval("money")) %>'
                                      Visible='<%# !Convert.ToBoolean(Convert.ToInt16(Eval("tikuan_status"))) %>'  ><font color =green>[支付]</font></asp:LinkButton>
                                    
                                    <asp:LinkButton ID="LinkButton1" CommandName="zhifu_no" OnCommand="GetWhichCommand"   CommandArgument='<%# Eval("tikuan_id")+","+Eval("huiyuan_id")+","+Eval("money")+","+Eval("zz_type")%>' 

                                    runat="server" OnClientClick='<%# String.Format("return confirm(\"您确定拒绝支付用户{0}提款{1:f}元信息吗？\")",Eval("huiyuan_bianhao"),Eval("money")) %>'
                                     Visible='<%# !Convert.ToBoolean(Convert.ToInt16(Eval("tikuan_status"))) %>'  ><font color =red>[拒绝支付]</font></asp:LinkButton>
                                    </td>
            
           
           
            
            
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
