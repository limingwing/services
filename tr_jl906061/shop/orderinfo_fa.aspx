<%@ Page Language="C#" AutoEventWireup="true" CodeFile="orderinfo_fa.aspx.cs" Inherits="shop_orderinfo_fa" %>

<%@ Register Src="Navigation.ascx" TagName="Navigation" TagPrefix="uc1" %>
<%@ Register Src="index_top.ascx" TagName="index_top" TagPrefix="uc1" %>
<%@ Register Src="footer.ascx" TagName="footer" TagPrefix="uc1" %>
<%@ Register Src="mob_sub.ascx" TagName="mob_sub" TagPrefix="uc1" %>
<%@ Register Src="left.ascx" TagName="left" TagPrefix="uc1" %>
<%@ Register Src="member_search.ascx" TagName="member_search" TagPrefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html>
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0,maximum-scale=1.0, user-scalable=0">
    <title>订单详情</title>
    <link href="AmazeUI-2.4.2/assets/css/admin.css" rel="stylesheet" type="text/css">
    <link href="AmazeUI-2.4.2/assets/css/amazeui.css" rel="stylesheet" type="text/css">
    <link href="css/personal.css" rel="stylesheet" type="text/css">
    <link href="css/orstyle.css" rel="stylesheet" type="text/css">
    <script src="AmazeUI-2.4.2/assets/js/jquery.min.js"></script>
    <script src="AmazeUI-2.4.2/assets/js/amazeui.js"></script>
</head>
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
                <div class="user-orderinfo">
                    <!--标题 -->
                    <div class="am-cf am-padding">
                        <div class="am-fl am-cf">
                            <strong class="am-text-danger am-text-lg">订单详情</strong> / <small>Order&nbsp;details</small></div>
                    </div>
                    <hr />
                    <!--进度条-->
                    <div class="m-progress">
                        <div class="m-progress-list">
                            <%if (model.status == 1)
                              { %>
                            <span class="step-1 step"><em class="u-progress-stage-bg"></em><i class="u-stage-icon-inner">
                                1<em class="bg"></em></i>
                                <p class="stage-name">
                                    拍下商品</p>
                            </span>
                            <%}%>
                            <%if (model.status == 2)
                              { %>
                            <span class="step-1 step"><em class="u-progress-stage-bg"></em><i class="u-stage-icon-inner">
                                2<em class="bg"></em></i>
                                <p class="stage-name">
                                    卖家发货</p>
                            </span>
                            <%} %>
                            <%if (model.status == 3)
                              { %>
                            <span class="step-1 step"><em class="u-progress-stage-bg"></em><i class="u-stage-icon-inner">
                                2<em class="bg"></em></i>
                                <p class="stage-name">
                                    确认收货</p>
                            </span>
                            <%} %>
                            <%if (model.status == 4)
                              { %>
                            <span class="step-1 step"><em class="u-progress-stage-bg"></em><i class="u-stage-icon-inner">
                                2<em class="bg"></em></i>
                                <p class="stage-name">
                                    订单取消</p>
                            </span>
                            <%} %>
                            <span class="u-progress-placeholder"></span>
                        </div>
                        <div class="u-progress-bar total-steps-2">
                            <div class="u-progress-bar-inner">
                            </div>
                        </div>
                    </div>
                    <div class="order-infoaside">
                        <%--<div class="order-logistics">
								<a href="logistics.html">
									<div class="icon-log">
										<i><img src="images/receive.png"></i>
									</div>
									<div class="latest-logistics">
										<p class="text">已签收,签收人是青年城签收，感谢使用天天快递，期待再次为您服务</p>
										<div class="time-list">
											<span class="date">2015-12-19</span><span class="week">周六</span><span class="time">15:35:42</span>
										</div>
										<div class="inquire">
											<span class="package-detail">物流：天天快递</span>
											<span class="package-detail">快递单号: </span>
											<span class="package-number">373269427868</span>
											<a target="_blank" href="http://m.kuaidi100.com/result.jsp?nu=1">点击查询物流</a>
										</div>
									</div>
									<span class="am-icon-angle-right icon"></span>
								</a>
								<div class="clear"></div>
							</div>--%>
                        <div class="order-addresslist">
                            <div class="order-address">
                                <div class="icon-add">
                                </div>
                                <p class="new-tit new-p-re">
                                    <span class="new-txt">
                                        <asp:Literal ID="shouhuo_name" runat="server"></asp:Literal></span> <span class="new-txt-rd2">
                                            <asp:Literal ID="mob" runat="server"></asp:Literal></span>
                                </p>
                                <div class="new-mu_l2a new-p-re">
                                    <p class="new-mu_l2cw">
                                        <span class="title">收货地址：</span> <span class="province">
                                            <%=shen %>
                                        </span><span class="city">
                                            <%=shi %></span> <span class="dist">
                                                <%=xian %></span> <span class="street">
                                                    <%=address %>
                                                </span>
                                    </p>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="order-infomain">
                        <div class="order-top">
                            <div class="th th-item">
                                <td class="td-inner">
                                    商品
                                </td>
                            </div>
                            <div class="th th-price">
                                <td class="td-inner">
                                    单价
                                </td>
                            </div>
                            <div class="th th-number">
                                <td class="td-inner">
                                    数量
                                </td>
                            </div>
                            <div class="th th-operation">
                                <td class="td-inner">
                                    商品类别
                                </td>
                            </div>
                            <div class="th th-amount">
                                <td class="td-inner">
                                    合计
                                </td>
                            </div>
                            <div class="th th-status">
                                <td class="td-inner">
                                    交易状态
                                </td>
                            </div>
                            <div class="th th-change">
                                <td class="td-inner">
                                    交易操作
                                </td>
                            </div>
                        </div>
                        <div class="order-main">
                            <div class="order-status3">
                                <div class="order-title">
                                    <div class="dd-num">
                                        订单编号：<a href="javascript:;"><asp:Literal ID="dd_no" runat="server"></asp:Literal></a></div>
                                    <span>成交时间：<asp:Literal ID="add_time" runat="server"></asp:Literal></span>
                                    <!--    <em>店铺：小桔灯</em>-->
                                </div>
                                <div class="order-content">
                                    <div class="order-left">
                                        <asp:Repeater ID="Repeater3" runat="server">
                                            <ItemTemplate>
                                                <ul class="item-list">
                                                    <li class="td td-item">
                                                        <div class="item-pic">
                                                            <a href="#" class="J_MakePoint">
                                                                <img src="<%#new tbl_product().Getimg(Convert.ToInt32(Eval("goods_id")))%>" class="itempic J_ItemImg">
                                                            </a>&nbsp;</div>
                                                        <div class="item-info">
                                                            <div class="item-basic-info">
                                                                <a href="#">
                                                                    <p>
                                                                        <%# Eval("goods_title")%></p>
                                                                    <p class="info-little">
                                                                        规格：<%# Eval("shuxing")%></p>
                                                                </a>
                                                            </div>
                                                        </div>
                                                    </li>
                                                    <li class="td td-price">
                                                        <div class="item-price">
                                                            <%# Eval("real_price")%>
                                                        </div>
                                                    </li>
                                                    <li class="td td-number">
                                                        <div class="item-number">
                                                            <span>×</span><%# Eval("quantity")%>
                                                        </div>
                                                    </li>
                                                    <li class="td td-operation">
                                                        <div class="item-operation">
                                                            <%#new tbl_sinkia_sub().GetTitle_sub(Convert.ToInt32(Eval("product_category_id")))%>
                                                        </div>
                                                    </li>
                                                </ul>
                                            </ItemTemplate>
                                        </asp:Repeater>
                                    </div>
                                    <div class="order-right">
                                        <li class="td td-amount">
                                            <div class="item-amount">
                                                合计：<asp:Literal ID="zong_price" runat="server"></asp:Literal>
                                                <%--<p>含运费：<span>10.00</span></p>--%>
                                            </div>
                                        </li>
                                        <div class="move-right">
                                            <li class="td td-status">
                                                <div class="item-status">
                                                    <p class="order-info">
                                                        <asp:Literal ID="status" runat="server"></asp:Literal></p>
                                                </div>
                                            </li>
                                            <%if (model.payment_status == 1)
                                              { %>
                                            <li class="td td-change">
                                                等待付款
                                            </li>
                                            <%}%>
                                            <%if (model.payment_status == 2)
                                              { %>
                                            <li class="td td-change">
                                                付款完成
                                            </li>
                                            <%}%>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div id="msg" runat="server">
                    <br /> 
                     <div class="am-form-group">
                        <label for="user-old-password" class="am-form-label">
                            物流公司名称</label>
                        <div class="am-form-content">
                            <input type="text" id="txtName" runat="server" class="input small" maxlength="10" datatype="*"
                                sucmsg="" placeholder="必填公司名称" />
                        </div>
                    </div>
                     <div class="am-form-group">
                        <label for="user-old-password" class="am-form-label">
                            填写物流单号</label>
                        <div class="am-form-content">
                            <input type="text" id="txtSn" runat="server" class="input small" maxlength="10" datatype="*"
                                sucmsg="" placeholder="必填物流单号" />
                        </div>
                    </div>
                      <div class="info-btn">
                        <div class="am-btn am-btn-danger">
                            <asp:Button ID="Button1" runat="server" Text="确认发货" class="am-btn am-btn-danger"
                                ValidationGroup="a" onclick="Button1_Click" /></div>
                                 <%--<div class="am-btn am-btn-danger"><a href="member_center.aspx"><input type="button" value="返回" class="am-btn am-btn-danger"  /></a>
                                   </div>--%>
                    </div>
                    </div>
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
