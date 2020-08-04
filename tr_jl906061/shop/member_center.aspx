<%@ Page Language="C#" AutoEventWireup="true" CodeFile="member_center.aspx.cs" Inherits="shop_member_center" %>

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
    <title>会员首页</title>
    <link href="AmazeUI-2.4.2/assets/css/admin.css" rel="stylesheet" type="text/css">
    <link href="AmazeUI-2.4.2/assets/css/amazeui.css" rel="stylesheet" type="text/css">
    <link href="css/personal.css" rel="stylesheet" type="text/css">
    <link href="css/systyle.css" rel="stylesheet" type="text/css">
    <script src="../js/js_sdk20170302.js" type="text/javascript"></script>
    <script src="js/jquery-1.7.2.min.js" type="text/javascript"></script>
</head>
<style type="text/css">
    .mem1
    {
        background: rgb(255, 255, 255);
        margin: 0px auto;
        width: 100%;
        height: 50px;
        padding-right: 5%;
        padding-left: 0%;
        border-bottom-color: rgb(241, 241, 241);
        border-bottom-width: 1px;
        border-bottom-style: solid;
        cursor: pointer;
    }
    .mem1 .h1
    {
        height: 30px;
        float: left;
        width: 90%;
        padding-top: 10px;
        padding-right: 10px;
        padding-left: 30px;
        padding-bottom: 10px;
        text-decoration: none;
    }
    
    .mem1 .h3
    {
        height: 30px;
        width: 10%;
        text-align: right;
        line-height: 30px;
        padding-top: 10px;
        padding-bottom: 10px;
        float: right;
    }
    li
    {
        display: list-item;
        text-align: -webkit-match-parent;
    }
</style>
<body>
    <form id="form1" runat="server">
    <!--头 -->
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
        <div class="long-title">
            <span class="all-goods">全部分类</span></div>
        <uc1:Navigation ID="Navigation" runat="server" />
        <!--导航栏-->
    </div>
    <b class="line"></b>
    <div class="center">
        <div class="col-main">
            <div class="main-wrap">
                <div class="wrap-left">
                    <div class="wrap-list">
                        <div class="m-user">
                            <!--会员信息 -->
                            <%--<div class="m-bg">
                            </div>--%>
                            <div class="m-userinfo">
                                <div class="m-baseinfo">
                                    <a >
                                        <%--<img  src="images/getAvatar.do.jpg">--%>
                                        <asp:Image ID="Image1" runat="server" />
                                    </a><em class="s-name">
                                        <asp:Label ID="username" runat="server"></asp:Label><%--<span class="vip1">--%><%--<asp:Label
                                            runat="server" ID="jibie1" Text=""></asp:Label>--%></em>
                                    <div class="s-prestige am-btn am-round">
                                        <%--</span>--%><asp:Label runat="server" ID="jibie" Text=""></asp:Label></div>
                                </div>
                                <div class="m-right">
                                    <div class="m-new">
                                        <a href="news.aspx"><i class="am-icon-bell-o"></i>新闻</a><asp:Label runat="server"
                                            ID="news" Text="" Style="font-size: 2px; color: white"></asp:Label>
                                    </div>
                                    <div class="m-address">
                                        <a class="i-trigger" id="timeUrl" runat="server"><p id="timeShow" runat="server"></p></a>
                                    </div>
                                </div>
                            </div>
      
                            <!--会员资产-->
                            <div class="m-userproperty">
                                <div class="s-bar">
                                    <i class="s-icon"></i>会员资产
                                </div>
                                  <p class="m-bill">
                                    <a href="#"><i>
                                        <img src="images/wallet1.png" /></i> <span class="m-title">消费积分</span> <em class="m-num">
                                            <asp:Literal ID="Literal1" runat="server"></asp:Literal></em> </a>
                                </p>
                               
                                <%--<p class="m-bill">
                                    <a href="chongxiao.aspx"><i>
                                        <img src="images/bonus1.png" /></i> <span class="m-title">分享积分</span> <em class="m-num">
                                            <asp:Literal ID="Literal3" runat="server"></asp:Literal></em> </a>
                                </p>--%>
                               <%--  <p class="m-bonus">
                                    <a href="#"><i>
                                        <img src="images/bonus.png" /></i> <span class="m-title">消费佣金</span> <em class="m-num">
                                            <asp:Literal ID="Literal4" runat="server"></asp:Literal></em> </a>
                                </p>--%>
                                 <%--<p class="m-coupon">
                                    <a href="#"><i>
                                        <img src="images/coupon.png" /></i> <span class="m-title">购物积分</span> <em class="m-num">
                                            <asp:Literal ID="Literal2" runat="server"></asp:Literal></em> </a>
                                </p>--%>
                                                                <%--<p class="m-bonus">
                                    <a href="#"><i>
                                        <img src="images/bouns3.png" /></i> <span class="m-title">首单团队累积</span> <em class="m-num">
                                            <asp:Literal ID="Literal5" runat="server"></asp:Literal></em> </a>
                                </p>
                                                                <p class="m-bonus">
                                    <a href="#"><i>
                                        <img src="images/bouns2.png" /></i> <span class="m-title">后期团队进货</span> <em class="m-num">
                                            <asp:Literal ID="Literal6" runat="server"></asp:Literal></em> </a>
                                </p>--%>
                                   <%--<p class="m-bonus">
                                    <a href="#"><i>
                                        <img src="images/jubao.png" /></i> <span class="m-title">肽豆</span> <em class="m-num">
                                            <asp:Literal ID="dianzi" runat="server"></asp:Literal></em> </a>
                                </p>--%>
                                <p class=""><%--m-big--%>
                                    <a href="#"><i>
                                        <img src="images/72h.png" /></i> <span class="m-title">72小时发货</span> </a>
                                </p>
                            </div>
                        </div>
                        <div class="box-container-bottom">
                        </div>
                        <!--订单 -->
                        <div class="m-order">
                            <div class="s-bar">
                                <i class="s-icon"></i>我的订单 <a class="i-load-more-item-shadow" href="order.aspx">全部订单</a>
                            </div>
                            <ul>
                                <li><a href="order.aspx"><i>
                                    <img src="images/pay.png" /></i><span>待付款<em class="m-num"><asp:Literal ID="is_pay"
                                        runat="server"></asp:Literal></em></span></a></li>
                                <li><a href="order.aspx"><i>
                                    <img src="images/send.png" /></i><span>待发货<em class="m-num"><asp:Literal ID="is_fa"
                                        runat="server"></asp:Literal></em></span></a></li>
                                <li><a href="order.aspx"><i>
                                    <img src="images/receive.png" /></i><span>待收货<em class="m-num"><asp:Literal ID="is_shou"
                                        runat="server"></asp:Literal></em></span></a></li>
                                <li>
                                    <%--<a href="order.html"><i><img src="images/comment.png"/></i><span>待评价<em class="m-num">3</em></span></a>--%></li>
                                <li>
                                    <%--<a href="change.html"><i><img src="images/refund.png"/></i><span>退换货</span></a>--%></li>
                            </ul>
                        </div>
                        <div class="m-order">
                            <div class="s-bar">
                                <i class="s-icon"></i>常用设置
                            </div>
                            <ul>
									<li id="info" runat="server"><a href="information.aspx"><i><img src="images/zc.png"/></i><span>会员信息</span></a></li>
									<li><a href="password.aspx"><i><img src="images/open.png"/></i><span>修改密码 </span></a></li>
                                    <li><a href="password1.aspx"><i><img src="images/erjimima.png"/></i><span>二级密码 </span></a></li>
                                    
                                    <%--<li><a href="al_read1.aspx"><i><img src="images/m31.png"/></i><span>会员列表</span></a></li>--%>
                                    <%--<li><a href="al_read.aspx"><i><img src="images/m31.png"/></i><span>开通会员</span></a></li>--%>
                                    <%--<%if (flag_4 == 1)
                                      {%>
                                    <li><a href="wlt1.aspx"><i><img src="images/m31.png"/></i><span>网络图谱</span></a></li>
                                    <%} %>--%>
                                    <%--<li><a href="erweima.aspx"><i><img src="images/m31.png"/></i><span>二维码</span></a></li>--%>
                                    <div id="ul1" runat="server">
                                    <li><a href="https://open.weixin.qq.com/connect/oauth2/authorize?appid=wxdcf5fba0c0a88064&redirect_uri=http://jl90606.jsqe100.com/Erweima.aspx&response_type=code&scope=snsapi_userinfo&state=1#wechat_redirect"><i><img src="images/m31.png"/></i><span>二维码</span></a></li>
									</div>
                                    <li><a href="zhuanzhang.aspx"><i><img src="images/zz.png"/></i><span>会员转账</span></a></li>
                                    <%--<li><a href="shengji.aspx"><i><img src="images/sj.png"/></i><span>会员升级</span></a></li>--%>
                                    <li><a href="fa.aspx"><i><img src="images/liuyan.png"/></i><span>会员留言</span></a></li>
                                    <li><a href="fa1.aspx"><i><img src="images/liuyan.png"/></i><span>留言回复</span></a></li>
                                    <%--<li id="liSupply" runat="server"><a href="ApplySupply.aspx"><i><img src="images/ls.png"/></i><span>申请商家</span></a></li>
                                     <li id="li1" runat="server"><a href="AddProduct.aspx"><i><img src="images/ls.png"/></i><span>我的商家</span></a></li>--%>
                                     <%--<li><a href="orderSend.aspx"><i><img src="images/ls.png"/></i><span>发货</span></a></li>--%>
                                    
                                      <div id="ul2" runat="server">
                                    <%--<li><a href="/reg/reg1.aspx?jd_bianhao=<%=(Session["hy_bianhao1"])%>"><i><img src="images/ls.png"/></i><span>注册会员</span></a></li>--%>
                                     <%--<li><a href="rewardcash.aspx"><i><img src="images/tx.png"/></i><span>我要提现</span></a></li>
                                     <li><a href="rewardcashlist.aspx"><i><img src="images/tx.png"/></i><span>提现列表</span></a></li>--%>
                                     <%--<li><a href="zhuanzhang2.aspx"><i><img src="images/zzz.png"/></i><span>积分转换</span></a></li>--%>
                                 <%--    <li><a href="mechileShop.aspx"><i><img src="images/zzz.png"/></i><span>打印机商城</span></a></li>
                                     <li><a href="mymechile.aspx"><i><img src="images/m31.png"/></i><span>我的打印机</span></a></li>--%>
                                    <li><a href="rewardlist.aspx"><i><img src="images/m1.png"/></i><span>积分统计</span></a></li>
                                    <%--<li><a href="rewardlist1.aspx" ><i><img src="images/mingxi.png"/></i><span>积分明细</span></a></li>--%>
                                        <li><a href="zhuanzhanglist.aspx" ><i><img src="images/wallet3.png"/></i><span>财务列表</span></a></li>
                                   <%--     <li><a href="buy.aspx" ><i><img src="images/wallet3.png"/></i><span>买入分享积分</span></a></li>
                                        <li><a href="sell.aspx" ><i><img src="images/wallet3.png"/></i><span>卖出分享积分</span></a></li>
                                        <li><a href="info.aspx" ><i><img src="images/wallet3.png"/></i><span>交易记录</span></a></li>--%>
                                        <%--<li>
                                        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click"><i><img src="images/8e.png"/></i><span>退出系统</span></asp:LinkButton></li>--%>
                                    </div>
								</ul>
                            
                        </div>
                        <!--九宫格-->
                        
                        <!--物流 -->
                        <%--<div class="m-logistics">

								<div class="s-bar">
									<i class="s-icon"></i>我的物流
								</div>
								<div class="s-content">
									<ul class="lg-list">

										<li class="lg-item">
											<div class="item-info">
												<a href="#">
													<img src="images/65.jpg_120x120xz.jpg" alt="抗严寒冬天保暖隔凉羊毛毡底鞋垫超薄0.35厘米厚吸汗排湿气舒适">
												</a>

											</div>
											<div class="lg-info">

												<p>快件已从 义乌 发出</p>
												<time>2015-12-20 17:58:05</time>

												<div class="lg-detail-wrap">
													<a class="lg-detail i-tip-trigger" href="logistics.html">查看物流明细</a>
													<div class="J_TipsCon hide">
														<div class="s-tip-bar">中通快递&nbsp;&nbsp;&nbsp;&nbsp;运单号：373269427686</div>
														<div class="s-tip-content">
															<ul>
																<li>快件已从 义乌 发出2015-12-20 17:58:05</li>
																<li>义乌 的 义乌总部直发车 已揽件2015-12-20 17:54:49</li>
																<li class="s-omit"><a data-spm-anchor-id="a1z02.1.1998049142.3" target="_blank" href="#">··· 查看全部</a></li>
																<li>您的订单开始处理2015-12-20 08:13:48</li>

															</ul>
														</div>
													</div>
												</div>

											</div>
											<div class="lg-confirm">
												<a class="i-btn-typical" href="#">确认收货</a>
											</div>
										</li>
										<div class="clear"></div>

										<li class="lg-item">
											<div class="item-info">
												<a href="#">
													<img src="images/88.jpg_120x120xz.jpg" alt="礼盒袜子女秋冬 纯棉袜加厚 女式中筒袜子 韩国可爱 女袜 女棉袜">
												</a>

											</div>
											<div class="lg-info">

												<p>已签收,签收人是青年城签收</p>
												<time>2015-12-19 15:35:42</time>

												<div class="lg-detail-wrap">
													<a class="lg-detail i-tip-trigger" href="logistics.html">查看物流明细</a>
													<div class="J_TipsCon hide">
														<div class="s-tip-bar">天天快递&nbsp;&nbsp;&nbsp;&nbsp;运单号：666287461069</div>
														<div class="s-tip-content">
															<ul>

																<li>已签收,签收人是青年城签收2015-12-19 15:35:42</li>
																<li>【光谷关山分部】的派件员【关山代派】正在派件 电话:*2015-12-19 14:27:28</li>
																<li class="s-omit"><a data-spm-anchor-id="a1z02.1.1998049142.7" target="_blank" href="//wuliu.taobao.com/user/order_detail_new.htm?spm=a1z02.1.1998049142.7.8BJBiJ&amp;trade_id=1479374251166800&amp;seller_id=1651462988&amp;tracelog=yimaidaologistics">··· 查看全部</a></li>
																<li>您的订单开始处理2015-12-17 14:27:50</li>

															</ul>
														</div>
													</div>
												</div>

											</div>
											<div class="lg-confirm">
												<a class="i-btn-typical" href="#">确认收货</a>
											</div>
										</li>

									</ul>

								</div>

							</div>--%>
                        <!--收藏夹 -->
                        <%--<div class="you-like">
								<div class="s-bar">热卖单品
									<a class="am-badge am-badge-danger am-round">降价</a>
									<a class="am-badge am-badge-danger am-round">下架</a>
									<a class="i-load-more-item-shadow" href="#"><i class="am-icon-refresh am-icon-fw"></i>换一组</a>
								</div>
								<div class="s-content">

                                 <asp:Repeater ID="hot_pro" runat="server" >
                                        <ItemTemplate>
									<div class="s-item-wrap">
										<div class="s-item">

											<div class="s-pic">
												<a href="introduction.aspx?id=<%# Eval("pro_id")%>" class="s-pic-link">
													<img src="<%# Eval("pro_imgs")%>" alt="<%# Eval("pro_name")%>" title="<%# Eval("pro_name")%>" class="s-pic-img s-guess-item-img">
												</a>
											</div>
											<div class="s-price-box">
												<span class="s-price"><em class="s-price-sign">¥</em><em class="s-value"><%# Eval("salse_price")%></em></span>
												<span class="s-history-price"><em class="s-price-sign">¥</em><em class="s-value"><%# Eval("go_price")%></em></span>

											</div>
											<div class="s-title"><a href="introduction.aspx?id=<%# Eval("pro_id")%>" title="<%# Eval("pro_name")%>"> <%# Eval("pro_name")%>		</a></div>
										 
										</div>
									</div>
                                     </ItemTemplate>
                                </asp:Repeater>

									 

								</div>

								<div class="s-more-btn i-load-more-item" data-screen="0"><i class="am-icon-refresh am-icon-fw"></i>更多</div>

							</div>--%>
                    </div>
                </div>
                <div class="wrap-right">
                    <!-- 日历-->
                    <%--<div class="day-list">
							<div class="s-bar">
								<a class="i-history-trigger s-icon" href="#"></a>我的日历
								<a class="i-setting-trigger s-icon" href="#"></a>
							</div>
							<div class="s-care s-care-noweather">
								<div class="s-date">
									<em>
                                        <asp:Literal ID="hao" runat="server"></asp:Literal></em>
									<span>
                                        <asp:Literal ID="week" runat="server"></asp:Literal></span>
									<span><asp:Literal ID="rili" runat="server"></asp:Literal></span>
								</div>
							</div>
						</div>--%>
                    <!--新品 -->
                    <%--
						<div class="new-goods">
							<div class="s-bar">
								<i class="s-icon"></i>新品上市
								<a class="i-load-more-item-shadow"> </a>
							</div>
                             <asp:Repeater ID="new_product" runat="server"   >
                        <ItemTemplate>
							<div class="new-goods-info">
								<a class="shop-info" href="introduction.aspx?pro_id=<%# Eval("pro_id")%>" target="_blank">
									<div class="face-img-panel">
										<img src="<%# Eval("pro_imgs")%>" alt="">
									</div>
									<span class="new-goods-num ">4</span>
									<span class="shop-title"><%# Eval("pro_name")%></span>
								</a>
								<a class="follow " href="introduction.aspx?pro_id=<%# Eval("pro_id")%>" target="_blank">关注</a>
							</div>
                                   </ItemTemplate>
 
                            </asp:Repeater>  
						</div>--%>
                </div>
            </div>
            <!--底部-->
            <uc1:footer ID="footer" runat="server" />
        </div>
        <aside class="menu"><!--会员中心菜单-->
				 <uc1:left ID="left" runat="server" />		<!--导航栏-->

			</aside>
    </div>
    <!--手机引导 -->
    <uc1:mob_sub ID="mob_sub" runat="server" />
    </form>
</body>
<script type="text/javascript">
                   function shareCallback(res) {
        setTimeout(function () { alert((res)); }, 2000);
        if (res == '1') {
            alert('分享成功');
        } else {
            slert('分享失败');
        }
    }
</script>
<script type="text/javascript">
    $(function () {
        $("#myCenter").attr("class", "active");
    });
</script>
</html>
