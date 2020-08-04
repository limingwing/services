<%@ Page Language="C#" AutoEventWireup="true" CodeFile="searchKill.aspx.cs" Inherits="shop_searchKill" %>

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
    <title>限时秒杀</title>
    <link href="AmazeUI-2.4.2/assets/css/amazeui.css" rel="stylesheet" type="text/css" />
    <link href="AmazeUI-2.4.2/assets/css/admin.css" rel="stylesheet" type="text/css" />
    <link href="basic/css/demo.css" rel="stylesheet" type="text/css" />
    <link type="text/css" href="css/style.css" rel="stylesheet" />
    <link href="css/seastyle.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="basic/js/jquery-1.7.min.js"></script>
    <script type="text/javascript" src="js/script.js"></script>
    <script type="text/javascript">
        function Clearc() {
            window.location.href = '/shop/searchKill.aspx';
        };
        function linkClick(linkObject) {

            var formObject = document.createElement('form');
            document.body.appendChild(formObject);
            formObject.setAttribute('method', 'post');
            var url = linkObject.href;
            var uri = '';
            var i = url.indexOf('?');

            if (i == -1) {
                formObject.action = url;
            } else {
                formObject.action = url.substring(0, i);
            }

            if (i >= 0 && url.length >= i + 1) {
                uri = url.substring(i + 1, url.length);
            }

            var sa = uri.split('&');

            for (var i = 0; i < sa.length; i++) {
                var isa = sa[i].split('=');
                var inputObject = document.createElement('input');
                inputObject.setAttribute('type', 'hidden');
                inputObject.setAttribute('name', isa[0]);
                inputObject.setAttribute('value', isa[1]);
                formObject.appendChild(inputObject);
            }

            formObject.submit();

            return false;
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <!--顶部导航条 -->
    <uc1:index_top ID="index_top" runat="server" />
    <!--悬浮搜索框-->
    <uc1:searcher ID="searcher" runat="server" />
    <div class="clear">
    </div>
    <b class="line"></b>
    <div class="search">
        <div class="search-list">
            <div class="nav-table">
                <div class="long-title">
                    <span class="all-goods">全部分类</span></div>
                <uc1:Navigation ID="Navigation" runat="server" />
                <!--导航栏-->
            </div>
            <div class="am-g am-g-fixed">
                <div class="am-u-sm-12 am-u-md-12">
                    <div class="search-content">
                        <div class="sort">
                            <li class="first"><a title="综合">综合排序</a></li>
                         <%--   <li><a title="销量">销量排序</a></li>
                            <li><a title="价格">价格优先</a></li>--%>
                        </div>
                        <div class="clear">
                        </div>
                        <ul class="am-avg-sm-2 am-avg-md-3 am-avg-lg-4 boxes">
                            <asp:Repeater ID="rptList" runat="server">
                                <ItemTemplate>
                                    <li>
                                        <div class="i-pic limit">
                                            <a href="introduction1.aspx?pro_id=<%# Eval("pro_id")%>&id=<%# Eval("kid")%>">
                                                <img src="<%# Eval("pro_imgs")%>" />
                                            </a>
                                            <p class="title fl">
                                                <%# Eval("pro_name")%>&nbsp;&nbsp;<%--<a style="color:Red" href='map.aspx?ak=<%# Eval("supplyId")%>'><%# Eval("supplyName")%></a>--%></p>
                                            <p class="price fl">
                                                <b>¥</b> <strong>
                                                    <%# (Convert.ToDecimal(Eval("shop_fen"))*1m).ToString("n2")%></strong>
                                            </p>
                                            <p class="number fl">
                                                已售<span><%# Eval("SaleQTY")%></span>
                                            </p>
                                        </div>
                                    </li>
                                </ItemTemplate>
                                <FooterTemplate>
                                    <%#rptList.Items.Count == 0 ? "<tr><td align=\"center\" colspan=\"9\"><font color=red>暂无记录</font></td></tr>" : ""%>
                                    </tbody> </table>
                                </FooterTemplate>
                            </asp:Repeater>
                        </ul>
                    </div>
                    <div class="search-side">
                        <div class="side-title">
                            热卖单品
                        </div>
                        <asp:Repeater ID="hot_pro" runat="server">
                            <ItemTemplate>
                                <li>
                                    <div class="i-pic check">
                                        <a href="introduction1.aspx?pro_id=<%# Eval("pro_id")%>">
                                            <img src="<%# Eval("pro_imgs")%>" /></a>
                                        <p class="check-title">
                                            <%# Eval("pro_name")%></p>
                                        <p class="price fl">
                                            <b>¥</b> <strong>
                                                <%# Eval("go_price")%></strong>
                                        </p>
                                        <%--<p class="number fl">
											销量<span>1110</span>
										</p>--%>
                                    </div>
                                </li>
                            </ItemTemplate>
                        </asp:Repeater>
                    </div>
                    <div class="clear">
                    </div>
                    <!--分页 -->
                    <!--分页 -->
                    <div class="pagelist">
                        <div id="PageContent" runat="server" class="default">
                        </div>
                    </div>
                </div>
            </div>
            <uc1:footer ID="footer" runat="server" />
        </div>
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
