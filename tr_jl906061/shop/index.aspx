<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="shop_index" %>
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

		<title>首页</title>

		<link href="AmazeUI-2.4.2/assets/css/amazeui.css" rel="stylesheet" type="text/css" />
		<link href="AmazeUI-2.4.2/assets/css/admin.css" rel="stylesheet" type="text/css" />

		<link href="basic/css/demo.css" rel="stylesheet" type="text/css" />

		<link href="css/hmstyle.css" rel="stylesheet" type="text/css"/>
		<link href="css/skin.css" rel="stylesheet" type="text/css" />
		<script src="AmazeUI-2.4.2/assets/js/jquery.min.js"></script>
		<script src="AmazeUI-2.4.2/assets/js/amazeui.min.js"></script>
        <script type="text/javascript" src="../js/cart.js"></script>

	</head>

	<body>
 <form id="form1" runat="server">
		<div class="hmtop">
			<!--顶部导航条 -->
			   <uc1:index_top ID="index_top" runat="server" />

				<!--悬浮搜索框-->

				 <uc1:searcher ID="searcher" runat="server" />

				<div class="clear"></div>
   </div>
			<div class="banner">
                      <!--轮播 -->
						<div class="am-slider am-slider-default scoll" data-am-flexslider id="demo-slider-0">
							<ul class="am-slides">

                             <asp:Repeater ID="banner" runat="server"  >
                              <ItemTemplate>
								    <li class="<%#banner_id(Container.ItemIndex) %>"><a href="<%# Eval("p1_url")%>"><img src="<%# Eval("picture1")%>" /></a></li>
                              </ItemTemplate>
                             </asp:Repeater>

								 

							</ul>
						</div>
						<div class="clear"></div>	
			</div>
			<div class="shopNav">
				<div class="slideall">
					
					   <div class="long-title"><span class="all-goods">全部分类</span></div>
					         <uc1:Navigation ID="Navigation" runat="server" />		<!--导航栏-->
		        				
						<!--侧边导航 -->
						<div id="nav" class="navfull">
							<div class="area clearfix">
								<div class="category-content" id="guide_2">
									
									<div class="category">
										<ul class="category-list" id="js_climit_li">

                                           <asp:Repeater ID="Repeater1" runat="server"  OnItemDataBound="rptypelist_ItemDataBound">
                                        <ItemTemplate>
											<li class="appliance js_toggle relative first">
												<div class="category-info">
													<h3 class="category-name b-category-name"><i><img src="images/cake.png"></i><a class="ml-22" title="点心"><%# Eval("pro_class")%></a></h3>
													<em>&gt;</em></div>
												<div class="menu-item menu-in top">
													<div class="area-in">
														<div class="area-bg">
															<div class="menu-srot">
																<div class="sort-side">
																	<dl class="dl-sort">
																      <asp:Repeater ID="Repeater3" runat="server"   >
                                                                        <ItemTemplate> 
																		<dd><a title="蒸蛋糕" href="search.aspx?pro_pid=<%# Eval("id")%>"><span><%# Eval("pro_class")%></span></a></dd>
																	 

                                                                     </ItemTemplate>
 
                                                                    </asp:Repeater>  
																	</dl>
																	 

																</div>
																<%--<div class="brand-side">
																	<dl class="dl-sort"><dt><span>实力商家</span></dt>
																		<dd><a rel="nofollow" title="呵官方旗舰店" target="_blank" href="#" rel="nofollow"><span  class="red" >呵官方旗舰店</span></a></dd>
																		<dd><a rel="nofollow" title="格瑞旗舰店" target="_blank" href="#" rel="nofollow"><span >格瑞旗舰店</span></a></dd>
																		<dd><a rel="nofollow" title="飞彦大厂直供" target="_blank" href="#" rel="nofollow"><span  class="red" >飞彦大厂直供</span></a></dd>
																		<dd><a rel="nofollow" title="红e·艾菲妮" target="_blank" href="#" rel="nofollow"><span >红e·艾菲妮</span></a></dd>
																		<dd><a rel="nofollow" title="本真旗舰店" target="_blank" href="#" rel="nofollow"><span  class="red" >本真旗舰店</span></a></dd>
																		<dd><a rel="nofollow" title="杭派女装批发网" target="_blank" href="#" rel="nofollow"><span  class="red" >杭派女装批发网</span></a></dd>
																	</dl>
																</div>--%>
															</div>
														</div>
													</div>
												</div>
											<b class="arrow"></b>	
											</li>
									 

                                        </ItemTemplate>
                                        </asp:Repeater>
										</ul>
									</div>
								</div>

							</div>
						</div>
						
						
						<!--轮播-->
						
						<script type="text/javascript">
						    (function () {
						        $('.am-slider').flexslider();
						    });
						    $(document).ready(function () {
						        $("li").hover(function () {
						            $(".category-content .category-list li.first .menu-in").css("display", "none");
						            $(".category-content .category-list li.first").removeClass("hover");
						            $(this).addClass("hover");
						            $(this).children("div.menu-in").css("display", "block")
						        }, function () {
						            $(this).removeClass("hover")
						            $(this).children("div.menu-in").css("display", "none")
						        });
						    })
						</script>



					<!--小导航 -->
				   <uc1:mob_navi ID="mob_navi" runat="server" />

					<!--走马灯 -->

					<div class="marqueen">
						<span class="marqueen-title">商城头条</span>
						<div class="demo">

							<ul>

                              <asp:Repeater ID="news_bind" runat="server" >
                                        <ItemTemplate>


								<li class="title-first"><a target="_blank" href="blog.aspx?id=<%# Eval("id")%>	">
									<img src="images/TJ2.jpg"></img>
									 <%# Eval("title")%>							
								</a></li>
                                </ItemTemplate>
                              </asp:Repeater>
								 

							    
						<div class="mod-vip">
							<div class="m-baseinfo">
						 
								 
							</div>
							<div class="member-logout">
								<a class="am-btn-warning btn" href="login.aspx">登录</a>
								<a class="am-btn-warning btn" target=_blank  href=register.aspx>注册</a>
							</div>
							<div class="member-login">
								<a href="#"><strong>0</strong>待收货</a>
								<a href="#"><strong>0</strong>待发货</a>
								<a href="#"><strong>0</strong>待付款</a>
								<a href="#"><strong>0</strong>待评价</a>
							</div>
							<div class="clear"></div>	
						</div>																	    
							    
							 
								
							</ul>
                        <div class="advTip"><img src="images/advTip.jpg"/></div>
						</div>
					</div>
					<div class="clear"></div>
				</div>
				<script type="text/javascript">
				    if ($(window).width() < 640) {
				        function autoScroll(obj) {
				            $(obj).find("ul").animate({
				                marginTop: "-39px"
				            }, 500, function () {
				                $(this).css({
				                    marginTop: "0px"
				                }).find("li:first").appendTo(this);
				            })
				        }
				        $(function () {
				            setInterval('autoScroll(".demo")', 3000);
				        })
				    }
				</script>
			</div>
			<div class="shopMainbg">
				<div class="shopMain" id="shopmain">

					<!--今日推荐 -->

					<div class="am-g am-g-fixed recommendation">
						<div class="clock am-u-sm-3" ">
							<img src="images/2016.png "></img>
							<p>今日<br>推荐</p>
						</div>

                        <asp:Repeater ID="tuijian_bind" runat="server"   >
                                                                        <ItemTemplate> 
						<div class="am-u-sm-4 am-u-lg-3 ">
							<div class="info ">
								<h3><%# pro_str(Eval("pro_name").ToString())%> </h3>
								 
							</div>
							<div class="recommendationMain one">
								<a href="introduction.aspx?pro_id=<%# Eval("pro_id")%>"><img src="<%# Eval("pro_imgs")%>"></img></a>
							</div>
						</div>						
						  </ItemTemplate> 
                      </asp:Repeater>
					</div>
					<div class="clear "></div>
					<!--热门活动 -->

				<%--	<div class="am-container activity ">
						<div class="shopTitle ">
							<h4>盛情以待</h4>
							<h3>优惠享不停 </h3>
							<span class="more ">
                              <a href="# ">全部活动<i class="am-icon-angle-right" style="padding-left:10px ;" ></i></a>
                        </span>
						</div>
					  <div class="am-g am-g-fixed ">
                       <asp:Repeater ID="ad" runat="server"   >
                                        <ItemTemplate>
						<div class="am-u-sm-4 ">
							<div class="icon-sale one "></div>	
								<h4><%# Eval("advert_title")%></h4>							
							<div class="activityMain ">
								<a href="<%# Eval("p1_url")%>"><img src="<%# Eval("picture1")%>" "></a></img>
							</div>
						<%--	<div class="info ">
								<h3>	 <%# Eval("advert_title")%></h3>
							</div>														
						</div>
                              </ItemTemplate>
                        </asp:Repeater>
						
					 
					  </div>
                   </div>--%>
					<div class="clear "></div>

                     <asp:Repeater ID="top_class" runat="server"  OnItemDataBound="top_class_ItemDataBound">
<ItemTemplate> 


                    <div id="<%#style_id(Container.ItemIndex) %>">
					<!--甜点-->
					
					<div class="am-container ">
						<div class="shopTitle ">
							<h4><%# Eval("pro_class")%></h4>
							<h3>每一道甜品都有一个故事</h3>
							<div class="today-brands ">
                                <asp:Repeater ID="sub_class" runat="server"   >
<ItemTemplate> 
								<%--<a href="# "><%# Eval("pro_class")%></a>--%>

                                  </ItemTemplate>
 
</asp:Repeater>  
								 

							</div>
							<span class="more ">
                    <a class="more-link" href="# ">更多商品<i class="am-icon-angle-right" style="padding-left:10px ;" ></i></a>
                        </span>
						</div>
					</div>
					
					<div class="am-g am-g-fixed flood method3 ">
					<ul class="am-thumbnails ">
						<asp:Repeater ID="product_list" runat="server"   >
                        <ItemTemplate>
                        
                         
                          
                <li>
                        <div class="list " style=" background:none">
                            <a href="introduction.aspx?pro_id=<%# Eval("pro_id")%>">
                               <img src="<%# Eval("pro_imgs")%>" width="188px" height="188px" />
                                <div class="pro-title "><%# pro_str(Eval("pro_name").ToString())%></div>
                                <span class="e-price ">¥<%# discout(Eval("go_price"))%></span>
                            </a>
                        </div>
                    </li>


           


					  
                          </ItemTemplate>
 
                      </asp:Repeater>  
                       </ul>
					</div>
                 <div class="clear "></div>  
                 </div>
                 
  
    </ItemTemplate>
 
</asp:Repeater>   
                     

        
               
   
   
								   <uc1:footer ID="footer" runat="server" />

		</div>
		</div>
		<!--手机引导底部菜单 -->
		  <uc1:mob_sub ID="mob_sub" runat="server" />


		<!--菜单 -->
		<uc1:sidebar ID="sidebar" runat="server" />
		<script>
		    window.jQuery || document.write('<script src="basic/js/jquery.min.js "><\/script>');
		</script>
		<script type="text/javascript " src="basic/js/quick_links.js "></script>
    </form>
	</body>
    <script type="text/javascript">
        $(function () {
            $("#home").attr("class", "active");
        });
</script>
</html>