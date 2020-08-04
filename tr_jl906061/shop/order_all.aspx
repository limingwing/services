<%@ Page Language="C#" AutoEventWireup="true" CodeFile="order_all.aspx.cs" Inherits="shop_order_all" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
		<meta charset="utf-8">
		<meta name="viewport" content="width=device-width, initial-scale=1.0,maximum-scale=1.0, user-scalable=0">

		<title>订单管理</title>

		<link href="AmazeUI-2.4.2/assets/css/admin.css" rel="stylesheet" type="text/css">
		<link href="AmazeUI-2.4.2/assets/css/amazeui.css" rel="stylesheet" type="text/css">
        		<link type="text/css" href="css/style.css" rel="stylesheet" />
		<link href="css/personal.css" rel="stylesheet" type="text/css">
		<link href="css/orstyle.css" rel="stylesheet" type="text/css">

		<script src="AmazeUI-2.4.2/assets/js/jquery.min.js"></script>
		<script src="AmazeUI-2.4.2/assets/js/amazeui.js"></script>

	</head>
<body>
    <form id="form1" runat="server">
    	<div class="order-top">
										<div class="th th-item">
											<td class="td-inner">商品</td>
										</div>
										<div class="th th-price">
											<td class="td-inner">单价</td>
										</div>
										<div class="th th-number">
											<td class="td-inner">数量</td>
										</div>
										<div class="th th-operation">
											<td class="td-inner">商品操作</td>
										</div>
										<div class="th th-amount">
											<td class="td-inner">合计</td>
										</div>
										<div class="th th-status">
											<td class="td-inner">交易状态</td>
										</div>
										<div class="th th-change">
											<td class="td-inner">交易操作</td>
										</div>
									</div>

	   <div class="order-main">
										<div class="order-list">
											
											<!--交易成功-->
 <asp:Repeater ID="rptList" runat="server" OnItemDataBound="rptypelist_ItemDataBound">
<ItemTemplate> 
											<div class="order-status5">
												<div class="order-title">
													<div class="dd-num">订单编号：<a href=# onclick="javascript:top.location.href='orderinfo.aspx?order_id=<%# Eval("id")%>';" ><%# Eval("order_no")%></a></div>
													<span>下单时间：<%# Eval("add_time")%></span>
													<!--    <em>店铺：小桔灯</em>-->
												</div>
												<div class="order-content">
													<div class="order-left">

                                                      <asp:Repeater ID="Repeater3" runat="server"   >
                                                                        <ItemTemplate> 
														<ul class="item-list">
															<li class="td td-item">
																<div class="item-pic">
																	<a href="#" class="J_MakePoint">
																		<img src="<%#new tbl_product().Getimg(Convert.ToInt32(Eval("goods_id")))%>" class="itempic J_ItemImg">
																	</a>
																</div>
																<div class="item-info">
																	<div class="item-basic-info">
																		<a href="#">
																			<p><%# Eval("goods_title")%></p>
																			<p class="info-little">规格：<%# Eval("shuxing")%>
																			  </p>
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
																	
																</div>
															</li>
														</ul>

                                                         </ItemTemplate>
                                        </asp:Repeater>

													 
													</div>
													<div class="order-right">
														<li class="td td-amount">
															<div class="item-amount">
																合计：<%# Eval("payable_amount")%>
																<%--<p>含运费：<span>10.00</span></p>--%>
															</div>
														</li>
														<div class="move-right">
															<li class="td td-status">
																<div class="item-status">
																	<p class="Mystatus"><%#new tbl_orders().pay_status(Convert.ToInt32(Eval("payment_status")))%> </p>
																	<p class="order-info"><a href=# onclick="javascript:top.location.href='orderinfo.aspx?order_id=<%# Eval("id")%>';" >订单详情</a></p>
																	<p class="order-info"><a href=# onclick="javascript:window.open('http://m.kuaidi100.com/result.jsp?nu=<%# Eval("wuliu_no")%>');" >查看物流</a></p>
																</div>
															</li>
															<li class="td td-change">
																<%--<div class="am-btn am-btn-danger anniu">
																	删除订单</div>--%>
															</li>
														</div>
													</div>
												</div>
											</div>
											
									</ItemTemplate>
                                            <FooterTemplate>
  <%#rptList.Items.Count == 0 ? "<tr><td align=\"center\" colspan=\"9\"><font color=red>暂无记录</font></td></tr>" : ""%>
   </tbody>
    </table>
</FooterTemplate>
</asp:Repeater>  

<div class="pagelist">
 


  <div id="PageContent" runat="server" class="default"></div>
</div>		
											
										

										</div>

									</div>
    </form>
</body>
</html>
