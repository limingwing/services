<%@ Control Language="C#" AutoEventWireup="true" CodeFile="left.ascx.cs" Inherits="shop_left" %>
<ul>
					<li class="person active">
						<a href="member_center.aspx">会员首页</a>
					</li>
					<li class="person" >
						<a href="#"><p style=" color:#d2364c ; font-weight:bold;">会员信息</p></a>
						<ul>
                        <li id="info" runat="server"> <a href="information.aspx">会员资料</a></li>
							<%--<li id="info1" runat="server"> <a href="information1.aspx">股东合伙人资料</a></li>--%>
							<li> <a href="password.aspx">安全设置</a></li>
                            <%--<li id="li3" runat="server"> <a href="/reg/reg1.aspx?jd_bianhao=<%=(Session["hy_bianhao1"])%>">注册会员</a></li>--%>
		                    
                            <%-- <li id="li4" runat="server"> <a href="shengji.aspx">会员升级</a></li>
                             
                              <li id="li5" runat="server"> <a href="al_read.aspx">开通会员</a></li>--%>
                             <%-- <%if (flag_4 == 1)
                           {%>
                               <li> <a href="wlt1.aspx">网络图谱</a></li>
                               <%} %>--%>
                               <%--<li> <a href="erweima.aspx">二维码</a></li>--%>
                        <%--<li> <a href="chongxiao.aspx">分享积分产品</a></li>--%>
                            <li> <a href="fa.aspx">会员留言</a></li>
                           <%--<li id="liSupply" runat="server"><a href="ApplySupply.aspx">申请商家</a></li>
                            <li id="lis" runat="server"><a href="AddProduct.aspx">我的商家</a></li>--%>
                              <%--<li id="li6" runat="server"><a href="informationsj.aspx">股东升级</a></li>--%>
						</ul>
					</li>
					<li class="person" id="li1" runat="server">
						<a href="#"><p style=" color:#d2364c ; font-weight:bold;">我的交易</p></a>
						<ul>
							<li><a href="order.aspx">订单管理</a></li>
                            <%--<li><a href="orderSend.aspx">发货</a></li>--%>
					<%--	<li> <a href="change.html">退款售后</a></li>--%>
						</ul>
					</li>
                   <%-- <li class="person" id="li3" runat="server">
						<a href="#"><p style=" color:#d2364c ; font-weight:bold;">分享积分中心</p></a>
						<ul>
							<li><a href="buy.aspx">买入分享积分</a></li>
						<li> <a href="sell.aspx">卖出分享积分</a></li>
                        <li> <a href="info.aspx">交易记录</a></li>
						</ul>
					</li>--%>
					<li class="person" id="li2" runat="server">
						<a href="#"><p style=" color:#d2364c ; font-weight:bold;">我的资产</p></a>
						<ul>
							<li> <a href="rewardlist.aspx">积分统计 </a></li>
                            <%--<li> <a href="rewardlist1.aspx">积分明细 </a></li>--%>
						<%-- <li> <a href="chongzhi.aspx">积分充值</a></li>--%>
                         
							<%--<li> <a href="rewardcash.aspx">我要提现</a></li>
                            <li> <a href="rewardcashlist.aspx">提现列表</a></li>--%>
                            
                            <li> <a href="zhuanzhang.aspx">会员转账</a></li>
                          <li> <a href="zhuanzhang2.aspx">积分转换</a></li>
                             <%--<li> <a href="zhuanzhang1.aspx">福利积分</a></li>--%>
                            <li> <a href="zhuanzhanglist.aspx">财务列表</a></li>
                          <%--  <li> <a href="mechileShop.aspx">打印机商城 </a></li>
                        <li> <a href="mymechile.aspx">我的打印机 </a></li>--%>
						</ul>
					</li>

					 

				</ul>
