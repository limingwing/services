<%@ Page Language="C#" AutoEventWireup="true" CodeFile="xipu.aspx.cs" Inherits="manager_member_xipu" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<title>推荐图查询</title>
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
    <li><a href="#">分享图查询</a></li>
    </ul>
    </div>
    <div class="rightinfo">
    <dl class="seachform">  
    <dd>    <span class="rule-single-select">
      <asp:DropDownList ID="type" runat="server">
                <asp:ListItem Value=1 Selected="True">会员编号</asp:ListItem>
               
            </asp:DropDownList>
    </span><span class="single-select"><asp:TextBox ID="huiyuan_bianhao" runat="server" Width="120" CssClass="scinput"></asp:TextBox></span></dd>

   
    
    
      <dd class="cx"><asp:Button ID="lbtnSearch" runat="server" CssClass="scbtn" onclick="btnSearch_Click" Text="查询"></asp:Button>  
          <%--<asp:Button ID="Button1" runat="server" CssClass="scbtn"   Text="展开所有" 
              onclick="Button1_Click"></asp:Button>--%>   
	</dd>
     <dd class="toolbar1">
         
        </dd>
    </dl>
	        <!--列表-->
 
    <table class="tablelist">
     
        <tbody>
            
      <asp:TreeView ID="TreeView1" runat="server" ImageSet="Msdn" NodeIndent="8"  ShowLines="True"   CssClass="treeCss">
                            <HoverNodeStyle Font-Underline="True" ForeColor="Purple" />
                            <SelectedNodeStyle Font-Underline="True" HorizontalPadding="0px" VerticalPadding="0px" />
                            <NodeStyle Font-Names="Tahoma" Font-Size="9pt" ForeColor="DarkBlue" HorizontalPadding="8px"
                                NodeSpacing="0px" VerticalPadding="0px" />
                         
                        </asp:TreeView>
	  
   </tbody>
    </table>
 
   
 
    
    </div>
    
     <script type="text/javascript">
         $('.tablelist tbody tr:odd').addClass('odd');
	</script>
    </form>
</body>
</html>
