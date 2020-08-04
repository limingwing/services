<%@ Page Language="C#" AutoEventWireup="true" CodeFile="in_box.aspx.cs" Inherits="manager_mail_in_box" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<title>收件箱</title>
<link href="../../css/style.css" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="../../js/jquery/jquery-1.10.2.min.js"></script>
<script type="text/javascript" src="../../js/lhgdialog/lhgdialog.js?skin=idialog"></script>
<script type="text/javascript" src="../../js/layout.js"></script>
<script type="text/javascript">
    function opdg(s_type, s_url) {
        var t_width, t_height, t_title, t_url, t_id;
        t_id = 'w_1';
        switch (s_type) {
            case 'info':
                t_width = 980;
                t_height = 500;
                t_title = '查看留言';
                t_url = s_url;
                break;
        }
        $.dialog({
            width: t_width,
            height: t_height,
            title: t_title,
            max: false,
            content: 'url:' + t_url
        });
    } 

</script>
</head>
<body>
    <form id="form1" runat="server">
	<div class="place">
    <span>位置：</span>
    <ul class="placeul">
    <li><a href="#">首页</a></li>
    <li><a href="#">收件箱</a></li>
    </ul>
    </div>
    
    <div class="rightinfo">
    
    <div class="tools">
    
    	<ul class="toolbar">
    <li><span><img src="../../images/t02.png" /></span><a href="javascript:;" onclick="checkAll(this);">全选</a></li>
        <li class="click"><asp:LinkButton ID="btnDelete" runat="server" CssClass="del" OnClientClick="return ExePostBack('btnDelete');" onclick="btnDelete_Click"><span><img src="../../images/t03.png" /></span>删除</asp:LinkButton></li>
        <a href="send.aspx?action=Add"><li><span><img src="../../images/t01.png" /></span>添加留言</li></a>
        
        </ul>         
    </div>    
    <dl class="seachform">
       <dd><label>关键字</label><span class="single-select"><asp:TextBox ID="txtKeywords" runat="server" CssClass="scinput"></asp:TextBox></span><span class="rule-single-select">
      <asp:DropDownList ID="huifu_type" runat="server" AutoPostBack="True" onselectedindexchanged="ddlproduct_category_id_SelectedIndexChanged">

                <asp:ListItem Value=0 Selected="True">==全部==</asp:ListItem>
                <asp:ListItem Value=1 >未读</asp:ListItem>
                 <asp:ListItem Value=2  >已读</asp:ListItem>
                  <asp:ListItem Value=3  >已回复</asp:ListItem>
            </asp:DropDownList>
    </span></dd>
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
        <th>标题</th>
        <th>发件人帐号</th>
        <th>发件人姓名</th>
        <th>发送时间</th>
        <th>状态</th>
<%--        <th>留言类型</th>--%>
		<th>操作</th>
          
        </tr>
        </thead>
        <tbody>
        </HeaderTemplate>
<ItemTemplate> 
        <tr>
		<td><asp:CheckBox ID="chkId" CssClass="checkall" runat="server" />
      <asp:HiddenField ID="hidId" Value='<%#Eval("id")%>' runat="server" /></td>
		<td><%# pageSize * page + Container.ItemIndex + 1 - pageSize%></td>	
        <td><%# Eval("liuyan_title")%></td>
        <td><a href="in_box.aspx?keywords=<%# Eval("liuyan_bianhao") %>"><%# Eval("liuyan_bianhao")%></a></td>
        <td><a href="in_box.aspx?keywords=<%# Eval("liuyan_name") %>"><%# Eval("liuyan_name")%></a></td>
        <td><%#string.Format("{0:g}",Eval("liuyan_date"))%></td>
        <td><%#GetOrderStatus(Convert.ToInt32(Eval("kan_flag")))%></td>
     <%--   <td><%# Eval("liuyan_type").ToString().Trim() == "1" ? "<font color =green>注册问题</font>" : "<font color =green>积分问题</font>"%></td>--%>
     
        <td><a href="javascript:opdg('info','show.aspx?id=<%#Eval("id")%>');" class="tablelink">[查看]</a><a href="send.aspx?action=Edit&liuyan_to=<%#Eval("liuyan_bianhao")%>&id=<%#Eval("id")%>&page=<%=page%>&title=<%#Eval("liuyan_title")%>" class="tablelink"><font color ="green">[回复]</font></a></td>
	   
		 
 
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
