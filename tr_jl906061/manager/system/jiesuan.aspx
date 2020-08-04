<%@ Page Language="C#" AutoEventWireup="true" CodeFile="jiesuan.aspx.cs" Inherits="manager_system_jiesuan" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
   <title>数据结算</title>
<script type="text/javascript" src="../../js/jquery/jquery-1.10.2.min.js"></script>
<script type="text/javascript" src="../../js/lhgdialog/lhgdialog.js?skin=idialog"></script>
<script type="text/javascript" src="../../js/jquery/Validform_v5.3.2_min.js"></script>
<script type="text/javascript" src="../../js/layout.js"></script>
<script type="text/javascript" src="../../js/pinyin.js"></script>
<link href="../../css/style.css" rel="stylesheet" type="text/css" />
 
</head>
<body>
    <form id="form1" runat="server">
	<div class="place">
    <span>位置：</span>
    <ul class="placeul">
    <li><a href="#">首页</a></li>
    <li><a href="jiesuan.aspx"> 数据结算</a></li>
    <li><a href="#"> 数据结算</a></li>
    </ul>
    </div>

    <div class="formbody">   
    <div class="formtitle"><span> 数据结算</span></div>
 
    
    </div>

    <!--工具栏-->
<div class="tab-content" >
  <div class="btn-list" style="margin:0 auto; text-align:center">
    <%--<asp:Button ID="btnSubmit" runat="server" Text="日结算" CssClass="btn"  OnClientClick="return confirm('你确定要发放全部会员的日积分吗？');" onclick="btnSubmit_Click_ri"   />--%>
    <%--<asp:Button ID="Button3" runat="server" Text="周结算" CssClass="btn"  OnClientClick="return confirm('你确定要发放全部会员的全球分红吗？');" onclick="btnSubmit_Click_zhou"   />--%>
    <asp:Button ID="Button4" runat="server" Text="月结算" CssClass="btn"  OnClientClick="return confirm('你确定要发放全部会员的全球分红吗？');" onclick="btnSubmit_Click_yue"   />
    <asp:Button ID="Button1" runat="server" Text="备份数据" CssClass="btn" onclick="btnSubmit_Click_back"  />
     <asp:Button ID="Button2" runat="server" Text="清空数据" CssClass="btn" OnClientClick="return confirm('清空数据仅在测试数据时使用，你确认清空全部数据吗？');" onclick="btnSubmit_Click_qingkong"  />
     <br>
      <br>
      <asp:HyperLink ID="HyperLink1" runat="server" Visible=false> </asp:HyperLink>
  </div>
  <div class="clear"></div>
</div>
<!--/工具栏-->

    </form>
</body>
</html>
