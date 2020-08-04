<%@ Page Language="C#" AutoEventWireup="true" CodeFile="shopcart.aspx.cs" Inherits="shop_shopcart" %>
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

		<title>购物车页面</title>

		<link href="AmazeUI-2.4.2/assets/css/amazeui.css" rel="stylesheet" type="text/css" />
		<link href="basic/css/demo.css" rel="stylesheet" type="text/css" />
		<link href="css/cartstyle.css" rel="stylesheet" type="text/css" />
		<link href="css/optstyle.css" rel="stylesheet" type="text/css" />


		<script type="text/javascript" src="js/jquery.js"></script>
         <script type="text/javascript" src="../js/cart.js"></script>
       <script type="text/javascript" src="../js/layout.js"></script>

	</head>

	<body>
     <form id="form1" runat="server">
		<!--顶部导航条 -->
		 <uc1:index_top ID="index_top" runat="server" />

			<!--悬浮搜索框-->

			 <uc1:searcher ID="searcher" runat="server" />

			<div class="clear"></div>

			<!--购物车 -->
			<div class="concent">
				<div id="cartTable">
					<div class="cart-table-th">
						<div class="wp">
							<div class="th th-chk">
								<div id="J_SelectAll1" class="select-all J_SelectAll">

								</div>
							</div>
							<div class="th th-item">
								<div class="td-inner">商品信息</div>
							</div>
							<div class="th th-price">
								<div class="td-inner">单价</div>
							</div>
							<div class="th th-amount">
								<div class="td-inner">数量</div>
							</div>
							<div class="th th-sum">
								<div class="td-inner">金额</div>
							</div>
							<div class="th th-op">
								<div class="td-inner">操作</div>
							</div>
						</div>
					</div>

                   
					<div class="clear"></div>

					<tr class="item-list">
						<div class="bundle  bundle-last ">
							<%--<div class="bundle-hd">
								<div class="bd-promos">
									<div class="bd-has-promo">已享优惠:<span class="bd-has-promo-content">省￥19.50</span>&nbsp;&nbsp;</div>
									<div class="act-promo">
										<a href="#" target="_blank">第二支半价，第三支免费<span class="gt">&gt;&gt;</span></a>
									</div>
									<span class="list-change theme-login">编辑</span>
								</div>
							</div>--%>
							<div class="clear"></div>
							<div class="bundle-main">
                                 <asp:Repeater ID="rptList" runat="server">
<ItemTemplate> 
								<ul class="item-content clearfix">
									<%--<li class="td td-chk">
										<div class="cart-checkbox ">
											<input class="check" id="J_CheckBox_170037950254" name="items[]" value="170037950254" type="checkbox">
											<label for="J_CheckBox_170037950254"></label>
										</div>
									</li>--%>
									<li class="td td-item">
										<div class="item-pic">
											<a href="#" target="_blank" data-title="美康粉黛醉美东方唇膏口红正品 持久保湿滋润防水不掉色护唇彩妆" class="J_MakePoint" data-point="tbcart.8.12">
												
                                                
                                                
                                                <img src="<%# Eval("img_url")%>" class="itempic J_ItemImg" width="80" height="80"></a>
										</div>
										<div class="item-info">
											<div class="item-basic-info">
												<a href="introduction.aspx?pro_id=<%# Eval("id")%>" target="_blank" title="美康粉黛醉美唇膏 持久保湿滋润防水不掉色" class="item-title J_MakePoint" data-point="tbcart.8.11"><%# Eval("title")%></a>
											</div>
										</div>
									</li>
									<li class="td td-info">
										<div class="item-props item-props-can">
											<span class="sku-line">属性：<%# Eval("shuxing")%></span><%--<span class="sku-line">包装：裸装</span>
											<span tabindex="0" class="btn-edit-sku theme-login">修改</span>--%><i class="theme-login am-icon-sort-desc"></i></div>
									</li>
									<li class="td td-price">
										<div class="item-price price-promo-promo">
											<div class="price-content">
												<%--<div class="price-line">
													<em class="price-original"><%# MyConvert(Eval("goprice"))%></em>
												</div>--%>
												<div class="price-line">
													<em class="J_Price price-now" tabindex="0"><%# MyConvert(Eval("price"))%></em>
												</div>
											</div>
										</div>
									</li>
									<li class="td td-amount">
										<div class="amount-wrapper ">
											<div class="item-amount ">
												<div class="sl">
													<input class="min am-btn" name="" type="button" value="-"  onclick="CartComputNum(this, '/', '<%# Eval("key_shuxing")%>', -1);"/>
													<input class="text_box" name="goods_quantity" type="text" value="<%# Eval("quantity")%>" style="width:30px;"  onblur="CartAmountTotal(this, '/', '<%# Eval("key_shuxing")%>');" onkeypress="return (/[\d]/.test(String.fromCharCode(event.keyCode)))"/>
												 
                                                    
                                                    
                                                    <input class="add am-btn" name="" type="button" value="+"  onclick="CartComputNum(this,'/', '<%# Eval("key_shuxing")%>', 1);"/>
												</div>
											</div>
										</div>
									</li>
									<li class="td td-sum">
										<div class="td-inner">
											<em tabindex="0" class="J_ItemSum number"><%# (Convert.ToDecimal(Eval("price")) * Convert.ToDecimal(Eval("quantity"))).ToString("n2")%></em>
										</div>
									</li>
									<li class="td td-op">
										<div class="td-inner">
											<%--<a title="移入收藏夹" class="btn-fav" href="#">
                  移入收藏夹</a>--%>

											<a href="javascript:;" data-point-url="#" class="delete" onclick="DeleteCart(this,'/','<%# Eval("key_shuxing")%>');"  >
                  删除</a>
										</div>
									</li>
								</ul>
								</ItemTemplate>
<FooterTemplate>
  <%#rptList.Items.Count == 0 ? " <tr><td colspan=\"6\"><div class=\"msg_tips\"><div class=\"ico warning\"></div><div class=\"msg\"><strong>购物车没有商品！</strong><p>您的购物车为空，<a href=\"index.aspx\">马上去选购</a>吧！</p></div></div></td></tr>" : ""%>

</FooterTemplate>
</asp:Repeater> 
								
								
								
								 
													
								
								
								
							</div>
						</div>
					</tr>

                    
				 
				</div>
				<div class="clear"></div>

				<div class="float-bar-wrapper">
					  
					<div class="operations">
						<a href="#" hidefocus="true" class="deleteAll"> </a>
						<a href="#" hidefocus="true" class="J_BatchFav"> </a>
					</div> 
					<div class="float-bar-right">
						<div class="amount-sum">
							<span class="txt">已选商品</span>
							<em id="J_SelectedItemsCount"><asp:Literal ID="total_quantity" runat="server"></asp:Literal></em><span class="txt">件</span>
							<div class="arrow-box">
								<span class="selected-items-arrow"></span>
								<span class="arrow"></span>
							</div>
						</div>
						<div class="price-sum">
							<span class="txt">合计:</span>
							<strong class="price">¥<em id="J_Total"><asp:Literal ID="payable_amount" runat="server"></asp:Literal></em></strong>
						</div>
						<div class="btn-area">
                               <asp:Button ID="LinkButton1" runat="server" CssClass="theme-login" Text="结算" OnClick="LinkButton1_Click" Style="display: none"></asp:Button>
                    <a class="submit-btn submit-btn-disabled" id="ordergoods" onclick="ClickChoose()">结&nbsp;算</a>
							 
						</div>
					</div>

				</div>

				  <uc1:footer ID="footer" runat="server" />

			</div>

			<!--操作页面-->
 
		<!--引导 -->
				  <uc1:mob_sub ID="mob_sub" runat="server" />
                  </form>
	</body>
    <script type="text/javascript">
        $(function () {
            $("#shopcart").attr("class", "active");
        });
        function ClickChoose() {
            
                document.getElementById('LinkButton1').click();
            
            
        }
</script>

</html>
