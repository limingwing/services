<%@ Control Language="C#" AutoEventWireup="true" CodeFile="index_top.ascx.cs" Inherits="shop_index_top" %>
<div class="am-container header">
<%if (Session["hy_id1"] == null)
  {      %>
				<ul class="message-l">
					<div class="topMessage">
						<div class="menu-hd">
							<a href="login.aspx" target="_top" class="h">亲，请登录</a>
							<%--<a target=_blank href="/reg/reg.aspx" target="_top">免费注册</a>--%>
						</div>
					</div>
				</ul>
                <%}
  else
  { %>
                <ul class="message-l">
					<div class="topMessage">
						<div class="menu-hd">
							<a href="#" target="_top" class="h">亲，<%=Session["hy_bianhao1"] %>，欢迎您的登陆</a>
                            <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click">退出</asp:LinkButton>
					 		 
						</div>
					</div>
				</ul>

  <%} %>
				<ul class="message-r">
					<div class="topMessage home">
						<div class="menu-hd"><a href="index.aspx" target="_top" class="h">商城首页</a></div>
					</div>
					<div class="topMessage my-shangcheng">
						<div class="menu-hd MyShangcheng"><a href="member_center.aspx" target="_top"><i class="am-icon-user am-icon-fw"></i>会员中心</a></div>
					</div>
					<div class="topMessage mini-cart">
						<div class="menu-hd"><a id="mc-menu-hd" href="shopcart.aspx" target="_top"><i class="am-icon-shopping-cart  am-icon-fw"></i><span>购物车</span><strong id="J_MiniCartNum" class="h"><script type="text/javascript" src="../../tools/submit_ajax.ashx?action=view_cart_count"></script></strong></a></div>
					</div>
			<%--		<div class="topMessage favorite">
						<div class="menu-hd"><a href="#" target="_top"><i class="am-icon-heart am-icon-fw"></i><span>收藏夹</span></a></div>--%>
				</ul>
				</div>
