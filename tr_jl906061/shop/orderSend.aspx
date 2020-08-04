<%@ Page Language="C#" AutoEventWireup="true" CodeFile="orderSend.aspx.cs" Inherits="shop_orderSend" %>
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

		<title>发货管理</title>

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
					   <div class="long-title"><span class="all-goods">全部分类</span></div>
					    <uc1:Navigation ID="Navigation" runat="server" />		<!--导航栏-->
			</div>
			<b class="line"></b>
		<div class="center">
			<div class="col-main">
				<div class="main-wrap">

					<div class="user-order">

						<!--标题 -->
						<div class="am-cf am-padding">
							<div class="am-fl am-cf"><strong class="am-text-danger am-text-lg">发货管理</strong> / <small>Order</small></div>
						</div>
						<hr/>

						<div class="am-tabs am-tabs-d2 am-margin" data-am-tabs>

							<ul class="am-avg-sm-5 am-tabs-nav am-nav am-nav-tabs">
								<li class="am-active"><a href="#tab1">所有订单</a></li>
							<%--	<li><a href="#tab2">待付款</a></li>--%>
								<li><a href="#tab3">待发货</a></li>
								<%--<li><a href="#tab4">待收货</a></li>--%>
								 
							</ul>

							<div class="am-tabs-bd">

                            

								<div class="am-tab-panel am-fade am-in am-active" id="tab1">
							 <iframe height="100%" width="100%" frameborder="0" name="center" src="fa_all.aspx" id="mainFrame" onLoad="iFrameHeight()" >
                              </iframe>
                               <script type="text/javascript" language="javascript">
                                   function iFrameHeight() {
                                       var ifm = document.getElementById("mainFrame");
                                       ifm.height = 0;
                                       var subWeb = document.frames ? document.frames["mainFrame"].document : ifm.contentDocument;
                                       if (ifm != null && subWeb != null) {
                                           ifm.height = subWeb.body.scrollHeight + 20;

                                       }

                                       if (ifm.height < 400) {
                                           ifm.height = 400;
                                       }


                                   } 
</script>
    

								</div>
								<%--<div class="am-tab-panel am-fade" id="tab2">
                                 <iframe height="100%" width="100%" frameborder="0" name="center" src="order_pay.aspx" id="mainFrame1" onLoad="iFrameHeight1()" >
                              </iframe>
                               <script type="text/javascript" language="javascript">
                                   function iFrameHeight1() {
                                       var ifm = document.getElementById("mainFrame1");
                                       ifm.height = 0;
                                       var subWeb = document.frames ? document.frames["mainFrame1"].document : ifm.contentDocument;
                                       if (ifm != null && subWeb != null) {
                                           ifm.height = subWeb.body.scrollHeight + 20;

                                       }

                                       if (ifm.height < 400) {
                                           ifm.height = 400;
                                       }


                                   } 
</script>
								 
								</div>--%>
								<div class="am-tab-panel am-fade" id="tab3">


                                <iframe height="100%" width="100%" frameborder="0" name="center" src="fa_send.aspx" id="mainFrame2" onLoad="iFrameHeight2()" >
                              </iframe>
                               <script type="text/javascript" language="javascript">
                                   function iFrameHeight2() {
                                       var ifm = document.getElementById("mainFrame2");
                                       ifm.height = 0;
                                       var subWeb = document.frames ? document.frames["mainFrame2"].document : ifm.contentDocument;
                                       if (ifm != null && subWeb != null) {
                                           ifm.height = subWeb.body.scrollHeight + 20;

                                       }

                                       if (ifm.height < 400) {
                                           ifm.height = 400;
                                       }


                                   } 
</script>
									 
								</div>
								<%--<div class="am-tab-panel am-fade" id="tab4">
									  <iframe height="100%" width="100%" frameborder="0" name="center" src="order_shou.aspx" id="mainFrame3" onLoad="iFrameHeight3()" >
                              </iframe>
                               <script type="text/javascript" language="javascript">
                                   function iFrameHeight3() {
                                       var ifm = document.getElementById("mainFrame3");
                                       ifm.height = 0;
                                       var subWeb = document.frames ? document.frames["mainFrame3"].document : ifm.contentDocument;
                                       if (ifm != null && subWeb != null) {
                                           ifm.height = subWeb.body.scrollHeight + 20;

                                       }

                                       if (ifm.height < 400) {
                                           ifm.height = 400;
                                       }


                                   } 
</script>
                                    
                         
								</div>--%>

								 
							</div>

						</div>

                         <div class="info-btn" style=" text-align:center">
                    <div class="am-btn am-btn-danger">
                        <a href="member_center.aspx">
                            <input type="button" value="返回" class="am-btn am-btn-danger" /></a>
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
