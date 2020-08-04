<%@ Page Language="C#" AutoEventWireup="true" CodeFile="erweima.aspx.cs" Inherits="shop_erweima" %>

<%@ Register Src="index_top.ascx" TagName="index_top" TagPrefix="uc1" %>
<%@ Register Src="Navigation.ascx" TagName="Navigation" TagPrefix="uc1" %>
<%@ Register Src="sidebar.ascx" TagName="sidebar" TagPrefix="uc1" %>
<%@ Register Src="mob_navi.ascx" TagName="mob_navi" TagPrefix="uc1" %>
<%@ Register Src="footer.ascx" TagName="footer" TagPrefix="uc1" %>
<%@ Register Src="mob_sub.ascx" TagName="mob_sub" TagPrefix="uc1" %>
<%@ Register Src="searcher.ascx" TagName="searcher" TagPrefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0, minimum-scale=1.0, maximum-scale=1.0, user-scalable=no">
    <title>搜索页面</title>
    <link href="AmazeUI-2.4.2/assets/css/amazeui.css" rel="stylesheet" type="text/css" />
    <link href="AmazeUI-2.4.2/assets/css/admin.css" rel="stylesheet" type="text/css" />
    <link href="basic/css/demo.css" rel="stylesheet" type="text/css" />
    <link type="text/css" href="css/style.css" rel="stylesheet" />
    <link href="css/seastyle.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="basic/js/jquery-1.7.min.js"></script>
    <script type="text/javascript" src="js/script.js"></script>
    <script type="text/javascript">
        function Clearc() {
            window.location.href = '/shop/search.aspx';
        };
    </script>
	<style type="text/css">
    img{max-width:100%}
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <!--顶部导航条 -->
    <uc1:index_top ID="index_top" runat="server" />
    <!--悬浮搜索框-->
    <uc1:searcher ID="searcher" runat="server" />
  
  
		<div style=" width:200px; height:200px;  margin:80px auto;">
		 
		<p style=" text-align:center; font-size:24px; font-weight:600; color:#FF6600;">分&nbsp;&nbsp;享&nbsp;&nbsp;推&nbsp;&nbsp;荐</p>
    <img src="http://qr.liantu.com/api.php?text=http://sh90511.lgwsh.net/reg/reg1.aspx?jd_bianhao=<%=Session["hy_bianhao1"].ToString() %>" width:200px; height:200px; />
<p style=" text-align:center; color:#FF6600;">长按二维码保存图片</p>
	</div>
		

    <!--引导 -->
    <!--手机引导底部菜单 -->
    <uc1:mob_sub ID="mob_sub" runat="server" />
    <!--菜单 -->
    <uc1:sidebar ID="sidebar" runat="server" />
    <script>
        window.jQuery || document.write('<script src="basic/js/jquery-1.9.min.js"><\/script>');
    </script>
    <script type="text/javascript" src="basic/js/quick_links.js"></script>
    <div class="theme-popover-mask">
    </div>
    </form>
</body>
</html>