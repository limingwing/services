﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="al_read.aspx.cs" Inherits="shop_al_read" %>

<%@ Register Src="Navigation.ascx" TagName="Navigation" TagPrefix="uc1" %>
<%@ Register Src="index_top.ascx" TagName="index_top" TagPrefix="uc1" %>
<%@ Register Src="footer.ascx" TagName="footer" TagPrefix="uc1" %>
<%@ Register Src="mob_sub.ascx" TagName="mob_sub" TagPrefix="uc1" %>
<%@ Register Src="left.ascx" TagName="left" TagPrefix="uc1" %>
<%@ Register Src="member_search.ascx" TagName="member_search" TagPrefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0,maximum-scale=1.0, user-scalable=0">
    <title>会员列表</title>
    <link href="AmazeUI-2.4.2/assets/css/admin.css" rel="stylesheet" type="text/css">
    <link href="AmazeUI-2.4.2/assets/css/amazeui.css" rel="stylesheet" type="text/css">
    <link href="css/personal.css" rel="stylesheet" type="text/css">
    <link href="css/newstyle.css" rel="stylesheet" type="text/css">
    <link type="text/css" href="css/style.css" rel="Stylesheet" />
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
		</article>
	</header>
    <div class="nav-table">
        <div class="long-title">
            <span class="all-goods">全部分类</span></div>
        <uc1:Navigation ID="Navigation" runat="server" />
        <!--导航栏-->
    </div>
    <b class="line"></b>
    <div class="center">
        <div class="col-main">
            <div class="main-wrap">
                <div class="am-cf am-padding">
                    <div class="am-fl am-cf">
                        <strong class="am-text-danger am-text-lg">开通会员</strong> / <small>Electronic&nbsp;bill</small></div>
                </div>
                <hr>
                <table width="100%">
                    <thead>
                        <tr>
                            <th>序号</th>
                            <th>
                                账户编号
                            </th>
                            <th>
                                姓名
                            </th>
                            <th>
                                注册时间
                            </th>
                            <th>
                                推荐人
                            </th>
                           <%-- <th>
                                位置
                            </th>--%>
                            
                            <th>
                                状态
                            </th>
                             <th>
                                操作
                            </th>
                        </tr>
                    </thead>
                    <tbody style=" text-align:center">
                        <asp:Repeater ID="rptList" runat="server">
                            <ItemTemplate>
                                <tr>
                                    <td>
                                        <%# pageSize * page + Container.ItemIndex + 1 - pageSize%>
                                    </td>
                                    <td>
                                        <%# Eval("huiyuan_bianhao")%>
                                    </td>
                                    <td>
                                        <%# Eval("huiyuan_name")%>
                                    </td>
                                    <td>
                                        <%#string.Format("{0:g}",Eval("huiyuan_add_time"))%>
                                    </td>
                                    <td>
                                        <%# Eval("tjr_bianhao")%>
                                    </td>
                                 <%--   <td>
                                        <%#getweizhi(Eval("zuoyou").ToString())%>
                                    </td>--%>
                                    <td>
                                        <%# Eval("net_hege").ToString().Trim() == "1" ? "<font color =green>已开通</font>" : "<font color =red>未开通</font>"%>
                                    </td>
                                    
                                    <td>
                                        <font id="Font1" runat="server" visible='<%#!new tbl_huiyuan().show_is(Convert.ToString(Eval("huiyuan_id")))%>'
                                            color="red">不能删除</font>
                                        <asp:LinkButton ID="LinkButton2" runat="server" OnClick="delete_Click1" OnClientClick="return confirm('是否真的要删除？')"
                                            Visible='<%#new tbl_huiyuan().show_is(Convert.ToString(Eval("huiyuan_id")))%>'
                                            CommandArgument='<%# Eval("huiyuan_id")%>'><font color=red>[删除]</font></asp:LinkButton>
                                        &nbsp;&nbsp;<%--<asp:LinkButton ID="LinkButton1" runat="server" OnClick="Open_Click"
                                            Visible='<%# !Convert.ToBoolean(Convert.ToInt16(Eval("net_hege"))) %>' CommandArgument='<%# Eval("huiyuan_id")%>'><font color=green>[购物积分开通]</font></asp:LinkButton>&nbsp;&nbsp;--%><asp:LinkButton ID="LinkButton3" runat="server" OnClick="Open_Click1"
                                            Visible='<%# !Convert.ToBoolean(Convert.ToInt16(Eval("net_hege"))) %>' CommandArgument='<%# Eval("huiyuan_id")%>'><font color=green>[开通]</font></asp:LinkButton>
                                    </td>
                                </tr>
                            </ItemTemplate>
                            <FooterTemplate>
                                <%#rptList.Items.Count == 0 ? "<tr><td align=\"center\" colspan=\"9\"><font color=red>暂无记录</font></td></tr>" : ""%>
                                </tbody> </table>
                            </FooterTemplate>
                        </asp:Repeater>
                    </tbody>
                </table>
                <div class="pagelist">
                    <div id="PageContent" runat="server" class="default">
                    </div>
                </div>
                <script type="text/javascript">
                    $('.tablelist tbody tr:odd').addClass('odd');
                </script>
                <script type="text/javascript">
                    $(document).ready(function () {
                        $(".date-trigger").click(function () {
                            $(".show-input").css("display", "none");
                        });

                    })
                </script>
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