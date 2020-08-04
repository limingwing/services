﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="al_read2.aspx.cs" Inherits="manager_member_al_read2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<title>已开通会员查询</title>
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
    <li><a href="#">已开通会员查询</a></li>
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

    <dd><label>注册开始日期</label><span class="single-select"><input  type="text" class="timeinput" id="txtstart_time" name="txtstart_time" readonly="readonly" runat="server" /></span></dd>
	<dd><label>注册结束日期</label><span class="single-select"><input type="text" class="timeinput" id="txtstop_time" name="txtstop_time" readonly="readonly" runat="server"/></span></dd> 
     <dd><label>会员级别</label>  
    <span class="rule-single-select">
      <asp:DropDownList ID="ddlproduct_category_id"  runat="server" AutoPostBack="True" onselectedindexchanged="ddlproduct_category_id_SelectedIndexChanged">
          </asp:DropDownList>
    </span>
    </dd>
    
      <dd class="cx"><asp:Button ID="lbtnSearch" runat="server" CssClass="scbtn" onclick="btnSearch_Click" Text="查询"></asp:Button>   
	</dd>
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
        <th width="40px;">序号</th>
		<th  width="100px;">会员编号</th>
        <%--<th  width="80px;">空单</th>
        <th  width="80px;">直推</th>--%>
       <%-- <th  width="100px;">会员手机</th>--%>	
        <th  width="100px;">会员姓名</th>
		<th width="80px;">会员级别</th>
    <%--    <th width="80px;">业绩级别</th>
            <th width="80px;">提成级别</th>--%>
        <th width="100px;">注册时间</th>
        <th width="80px;">分享人</th>
 
        <%--<th width="80px;">接点人</th>--%>
        <!--<th width="80px;">服务中心</th>-->
        <%--<th width="40px;">序号</th>--%>
      <%--  <th width="40px;">服务费</th>
        <th width="40px;">服务费设置</th>--%>
        <%--<th width="80px;">投资金额</th>--%>
        <%--<th width="40px;">奖励积分</th>
        <th width="40px;">购物积分</th>
        <th width="80px;">已提现</th>
        <th width="80px;">已转帐</th>--%>
		<th width="200px;">操作</th>
	 
        </tr>
        </thead>
        <tbody>
            </HeaderTemplate>
<ItemTemplate> 
        <tr>
            <td><%#pageSize * page + Container.ItemIndex+1 - pageSize%></td>
            <td><%# Eval("huiyuan_bianhao")%><%--(直推：<%# Eval("tuijian_count")%>人)--%></td>
            <%--<td><%#GetHuiJiebie1(int.Parse(Eval("kd_flag").ToString()))%> </td>
            <td><%# Eval("tuijian_count")%></td>--%>
            <%--<td><%# Eval("huiyuan_mob")%></td>--%>
             <td><%# Eval("huiyuan_name")%></td>
             <td><%#new tbl_reg_jiebie().GetTitle(Convert.ToInt32(Eval("huiyuan_jiebie")))%></td>	
        <%--    <td><%#GetHuiJiebie(Convert.ToInt32(Eval("huiyuan_jiebie1")))%></td>	
             <td><%#GetHuiJiebie(Convert.ToInt32(Eval("huiyuan_jiebie2")))%></td>	--%>
            <td><%#string.Format("{0:g}",Eval("huiyuan_add_time"))%></td>
           <td><%# Eval("tjr_bianhao")%></td>
 
          <%--<td><%#Eval("jdr_bianhao")%>	</td>--%>
         <%--   <td><%# Eval("zmd_bianhao")%></td>--%>
 	<%-- <td><%# Eval("xuhao")%></td>	--%>
        <%--<td><%# Eval("glf_money")%>%</td>	
         	<td>
            
            <asp:TextBox ID="TextBox2" runat="server" CssClass="input small"    MaxLength="15"   sucmsg="" ></asp:TextBox><asp:LinkButton ID="lbtnSave" runat="server" onclick="lbtnAcceptCaDG_Click2"   OnClientClick="return confirm('确定要修改吗？');" CommandArgument='<%# Eval("huiyuan_id")+","+(Container as RepeaterItem).ItemIndex%>'  CommandName="save"><font color =green>[确认]</font></asp:LinkButton></td>--%>
            <%--<td><%#Getzong(Eval("huiyuan_id").ToString())%>	</td>
            <td><%#Eval("chongfu_zong")%>	</td>
            <td><%#Eval("glf_money")%>	</td>
            <td><%#Getti(Eval("huiyuan_id").ToString())%>	</td>
            <td><%#Getzhuan(Eval("huiyuan_id").ToString())%>	</td>--%>
            <td> &nbsp;&nbsp;<a href="al_info.aspx?action=Edit&id=<%#Eval("huiyuan_id")%>&page=<%=page%>" class="tablelink"><font color =green>[修改]</font></a> <%-- &nbsp;&nbsp;  <asp:LinkButton ID="LinkButton1" runat="server" onclick="lbtnAcceptCaDG_Click"    CommandArgument='<%# Eval("huiyuan_id")+","+Eval("huiyuan_suoding") %>' ><%#Eval("huiyuan_suoding").ToString() == "0" ? "<font color =4B6A11>[冻结]</font>" : "<font color =red>[解冻]</font>"%></asp:LinkButton>--%>&nbsp;&nbsp;<a href="al_info.aspx?action=Login&id=<%#Eval("huiyuan_id")%>" class="tablelink"  target='_blank'><font color =green>[登录]</font></a> <%--&nbsp;<asp:LinkButton ID="LinkButton2" runat="server" onclick="lbtnAcceptCaDG_Click1"    CommandArgument='<%# Eval("huiyuan_id")+","+Eval("flag_4") %>' ><%#Eval("flag_4").ToString() == "1" ? "<font color =4B6A11>[关闭]</font>" : "<font color =red>[开启]</font>"%></asp:LinkButton>--%> </td>
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
