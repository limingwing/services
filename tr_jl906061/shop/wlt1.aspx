<%@ Page Language="C#" AutoEventWireup="true" CodeFile="wlt1.aspx.cs" Inherits="shop_wlt1" %>

<%@ Register Src="Navigation.ascx" TagName="Navigation" TagPrefix="uc1" %>
<%@ Register Src="index_top.ascx" TagName="index_top" TagPrefix="uc1" %>  
<%@ Register Src="footer.ascx" TagName="footer" TagPrefix="uc1" %> 
<%@ Register Src="mob_sub.ascx" TagName="mob_sub" TagPrefix="uc1" %> 
<%@ Register Src="left.ascx" TagName="left" TagPrefix="uc1" %>
<%@ Register Src="member_search.ascx" TagName="member_search" TagPrefix="uc1" %> 
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<!DOCTYPE html>
<html>

	<head>
		<meta charset="utf-8">
		<meta name="viewport" content="width=device-width, initial-scale=1.0,maximum-scale=1.0, user-scalable=0">

		<title>网络图</title>
        <%--<link href="../css/style.css" rel="stylesheet" type="text/css" />--%>
		<link href="AmazeUI-2.4.2/assets/css/admin.css" rel="stylesheet" type="text/css">
		<link href="AmazeUI-2.4.2/assets/css/amazeui.css" rel="stylesheet" type="text/css">

		<link href="css/personal.css" rel="stylesheet" type="text/css">
		<link href="css/newstyle.css" rel="stylesheet" type="text/css">

		<script src="AmazeUI-2.4.2/assets/js/jquery.min.js"></script>
		<script src="AmazeUI-2.4.2/assets/js/amazeui.js"></script>

	</head>
<body>
    <form id="form1" runat="server">
    <header>
			<article>
				<div class="mt-logo">
					<!--顶部导航条 -->
					 <uc1:index_top ID="index_top" runat="server" />

						<!--悬浮搜索框-->

						 <uc1:member_search ID="member_search" runat="server" />

						<div class="clear"></div>
					</div>
				</div>
			</article>
		</header>
        <div class="nav-table">
					   <div class="long-title"><span class="all-goods">全部分类</span></div>
					      <uc1:Navigation ID="Navigation" runat="server" />		<!--导航栏-->
			</div>
			<b class="line"></b>
	
    <div class="center">
        <div class="col-main">
				<div class="main-wrap">

					<div class="am-cf am-padding">
						<div class="am-fl am-cf"><strong class="am-text-danger am-text-lg">网络图</strong> / <small></small></div>
					</div>
					<hr/>
        <div class="formbody">   
        <div class="am-form-group">
    <dl class="seachform">
       <dd><label>会员编号</label><span class="single-select"><asp:TextBox ID="txtKeywords" runat="server" CssClass="scinput" Width="300"></asp:TextBox></span></dd>
       <dd class="cx"><asp:Button ID="imbnQuery" runat="server" class="am-btn am-btn-danger" onclick="imbnQuery_Click" Text="查询"></asp:Button></dd>
    </dl>
    </div>
<div class="tab-content">
  
  <div style="overflow:auto;">
  <table style="text-align:center; width:100%;" cellpadding=0 cellspacing=0>
            <!--level_1 statrt-->
            <tr>


            <td colspan=12 id="table_leval_1" runat="server">
            </td>
            </tr>
            <tr>
                <td colspan=12 align="center" class="style1">
                    <div style="border-bottom:1px #006600 solid; height:30px; width:70%; margin-right:5px;">
                        <table style="width:5px; border-left:1px #006600 solid; height:100%; margin-left:5px;">
                        <tr>
                        <td></td>
                        </tr>
                        </table>
                    </div>
                </td>
            </tr>
            <tr>
                <td colspan=3 align="center" height=15 valign=top>
                        <table style="width:5px; border-left:1px #006600 solid; height:100%" cellpadding=0 cellspacing=0>
                        <tr>
                        <td></td>
                        </tr>
                        </table>
                </td>
                <td colspan=3 align="center" height=15>
                        <table style="width:8px; border-left:1px #006600 solid; height:100%" cellpadding=0 cellspacing=0>
                        <tr>
                        <td></td>
                        </tr>
                        </table>
                </td>
                <td colspan=3 align="center" height=15>
                        <table style="width:5px; border-left:1px #006600 solid; height:100%" cellpadding=0 cellspacing=0>
                        <tr>
                        <td></td>
                        </tr>
                        </table>
                
                </td>
                
            </tr>
            
            <!--level_1 end -->
            <tr>
            <span id="table_leval_2" runat="server"></span>
            </tr>


            <tr>
                <td colspan=3 align="center" height=30 valign=top>
                    <div style="border-bottom:1px #006600 solid; height:30px; width:70%;">
                        <table style="width:5px; border-left:1px #006600 solid; height:100%" cellpadding=0 cellspacing=0>
                        <tr>
                        <td></td>
                        </tr>
                        </table>
                    </div>
                </td>
                <td colspan=3 align="center" height=30>
                    <div style="border-bottom:1px #006600 solid; height:30px; width:70%;">
                        <table style="width:8px; border-left:1px #006600 solid; height:100%" cellpadding=0 cellspacing=0>
                        <tr>
                        <td></td>
                        </tr>
                        </table>
                        </div>
                </td>
                <td colspan=3 align="center" height=30>
                    <div style="border-bottom:1px #006600 solid; height:30px; width:70%;">
                        <table style="width:5px; border-left:1px #006600 solid; height:100%" cellpadding=0 cellspacing=0>
                        <tr>
                        <td></td>
                        </tr>
                        </table>
                        </div>
                
                </td>
                
            </tr>
            
            <tr>
                <td align="center" height=15 valign=top>
                        <table style="width:8px; border-left:1px #006600 solid; height:100%" cellpadding=0 cellspacing=0>
                        <tr>
                        <td></td>
                        </tr>
                        </table>
                </td>
                <td align="center" height=15>
                        <table style="width:5px; border-left:1px #006600 solid; height:100%" cellpadding=0 cellspacing=0>
                        <tr>
                        <td></td>
                        </tr>
                        </table>
                </td>
                <td align="center" height=15>
                        <table style="width:0px; border-left:1px #006600 solid; height:100%; margin-left:7px;" cellpadding=0 cellspacing=0>
                        <tr>
                        <td></td>
                        </tr>
                        </table>
                
                </td>
                
                <td align="center" height=15 valign=top>
                        <table style="width:7px; border-left:1px #006600 solid; height:100%" cellpadding=0 cellspacing=0>
                        <tr>
                        <td></td>
                        </tr>
                        </table>
                </td>
                <td align="center" height=15>
                        <table style="width:8px; border-left:1px #006600 solid; height:100%" cellpadding=0 cellspacing=0>
                        <tr>
                        <td></td>
                        </tr>
                        </table>
                </td>
                <td align="center" height=15>
                        <table style="width:5px; border-left:1px #006600 solid; height:100%; margin-left:12px;" cellpadding=0 cellspacing=0>
                        <tr>
                        <td></td>
                        </tr>
                        </table>
                
                </td>
                <td align="center" height=15 valign=top>
                        <table style="width:8px; border-left:1px #006600 solid; height:100%" cellpadding=0 cellspacing=0>
                        <tr>
                        <td></td>
                        </tr>
                        </table>
                </td>
                <td align="center" height=15>
                        <table style="width:6px; border-left:1px #006600 solid; height:100%" cellpadding=0 cellspacing=0>
                        <tr>
                        <td></td>
                        </tr>
                        </table>
                </td>
                <td align="center" height=15>
                        <table style="width:0px; border-left:1px #006600 solid; height:100%; margin-left:7px;" cellpadding=0 cellspacing=0>
                        <tr>
                        <td></td>
                        </tr>
                        </table>
                
                </td>
                
                
            </tr>
            
            <!--level_3 end -->
            <tr>
            <span id="table_leval_3" runat="server"></span>
            </tr>
            
            
            
            </table>

 </div>
</div>
<!--/公告信息-->
    
    </div>
        </div>
				<!--底部-->
				<uc1:footer ID="footer" runat="server" />
			</div>
 
 <aside class="menu">
				 <uc1:left ID="left" runat="server" />		<!--导航栏-->

			</aside>
		</div>

    </form>
</body>
</html>
