<%@ Page Language="C#" AutoEventWireup="true" CodeFile="zhuanzhanglist.aspx.cs" Inherits="shop_zhuanzhanglist" %>

<%@ Register Src="Navigation.ascx" TagName="Navigation" TagPrefix="uc1" %>
<%@ Register Src="index_top.ascx" TagName="index_top" TagPrefix="uc1" %>
<%@ Register Src="footer.ascx" TagName="footer" TagPrefix="uc1" %>
<%@ Register Src="mob_sub.ascx" TagName="mob_sub" TagPrefix="uc1" %>
<%@ Register Src="left.ascx" TagName="left" TagPrefix="uc1" %>
<%@ Register Src="member_search.ascx" TagName="member_search" TagPrefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0,maximum-scale=1.0, user-scalable=0">
    <title>财务列表</title>
    <link href="AmazeUI-2.4.2/assets/css/admin.css" rel="stylesheet" type="text/css">
    <link href="AmazeUI-2.4.2/assets/css/amazeui.css" rel="stylesheet" type="text/css">
    <link type="text/css" href="css/style.css" rel="Stylesheet"" />
    <link href="css/personal.css" rel="stylesheet" type="text/css">
    <link href="css/stepstyle.css" rel="stylesheet" type="text/css">
    <script type="text/javascript" src="js/jquery-1.7.2.min.js"></script>
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
						<div class="am-fl am-cf"><strong class="am-text-danger am-text-lg">财务列表</strong> / <small>Electronic&nbsp;bill</small></div>
					</div>
					<hr>
<div style="overflow:auto;">
					<table width="100%">

						<thead>
							<tr>
								<th style="border:1px solid #666;" >序号</th>
	                        	
                                <th style="border:1px solid #666;" >时间</th>
                                <th style="border:1px solid #666;" >改变量</th> 
                                <th style="border:1px solid #666;" >类型</th>
                                <th style="border:1px solid #666;" >备注</th>  
                              
							</tr>
						</thead>

						<tbody style="border:1px solid #f1f1f1; text-align:center;">
							<asp:Repeater ID="rptList" runat="server">
                    <ItemTemplate> 
                     <tr>
                      <td style="border:1px solid #666;"><%# pageSize * page + Container.ItemIndex + 1 - pageSize%></td>
            <td style="border:1px solid #666;"><%#string.Format("{0:g}", Eval("queren_date"))%></td>
            <td style="border:1px solid #666;"><%# MyZF(MyConvert(Eval("queren_money")))%></td>
            <td style="border:1px solid #666;"><%# Eval("action_type")%></td>
            <td style="border:1px solid #666;"><%# Eval("memo")%></td>
            
                    </tr> 
	                </ItemTemplate>
                    <FooterTemplate>
                            <%#rptList.Items.Count == 0 ? "<tr><td align=\"center\" colspan=\"9\"><font color=red>暂无记录</font></td></tr>" : ""%>
						</tbody>
					</table>
	</div>				
				    </FooterTemplate>
                    </asp:Repeater> 
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

