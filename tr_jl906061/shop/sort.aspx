<%@ Page Language="C#" AutoEventWireup="true" CodeFile="sort.aspx.cs" Inherits="shop_sort" %>
<%@ Register Src="index_top.ascx" TagName="index_top" TagPrefix="uc1" %> 
<%@ Register Src="Navigation.ascx" TagName="Navigation" TagPrefix="uc1" %> 
<%@ Register Src="sidebar.ascx" TagName="sidebar" TagPrefix="uc1" %> 
<%@ Register Src="mob_navi.ascx" TagName="mob_navi" TagPrefix="uc1" %> 
<%@ Register Src="footer.ascx" TagName="footer" TagPrefix="uc1" %> 
<%@ Register Src="mob_sub.ascx" TagName="mob_sub" TagPrefix="uc1" %> 
<%@ Register Src="searcher.ascx" TagName="searcher" TagPrefix="uc1" %> 
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html>

	<head>
		<meta charset="UTF-8">
		<meta name="viewport" content="width=device-width, initial-scale=1.0, minimum-scale=1.0, maximum-scale=1.0, user-scalable=no">			
		<title>全部分类</title>
		<link href="AmazeUI-2.4.2/assets/css/amazeui.css" rel="stylesheet" type="text/css" />
		<link href="basic/css/demo.css" rel="stylesheet" type="text/css" />		
		<link href="css/sortstyle.css" rel="stylesheet" type="text/css" />
		<script src="AmazeUI-2.4.2/assets/js/jquery.min.js"></script>
	</head>

	<body>
		 <form id="form1" runat="server">
			<!--顶部导航条 -->
						   <uc1:index_top ID="index_top" runat="server" />

				<!--悬浮搜索框-->

				 <uc1:searcher ID="searcher" runat="server" />

				<div class="clear"></div>
			</div>		
		
		
		
		<!--主体-->
		
		<div id="nav" class="navfull">
			<div class="area clearfix">
				<div class="category-content" id="guide_2">
					<div class="long-title"><span class="all-goods">全部分类</span><span id="meauBack"><a href="index.aspx">返回</a></span></div>
					<div class="category">
										<ul class="category-list" id="js_climit_li">

                                        <asp:Repeater ID="Repeater1" runat="server"  OnItemDataBound="rptypelist_ItemDataBound">
                                        <ItemTemplate>
											<li class="appliance js_toggle relative   <%#(Container.ItemIndex+1)==1?"first selected":"" %> ">
												<div class="category-info">
													<h3 class="category-name b-category-name"><i><img src="images/cake.png"></i><a class="ml-22" title="点心"><%# Eval("pro_class")%></a></h3>
													<em>&gt;</em></div>
												<div class="menu-item menu-in top">
													<div class="area-in">
														<div class="area-bg">
															<div class="menu-srot">
																
																<div class="brand-side">
													              <dl class="dl-sort"><dt><span>为您推荐</span></dt>
													                <%--<img src="images/TJ.jpg">--%>
													              </dl>
												                </div>																
																
																<div class="sort-side">
																	<dl class="dl-sort">
																	  <asp:Repeater ID="Repeater3" runat="server"   >
                                                                        <ItemTemplate> 
																		<dd><a title="蒸蛋糕" href="search.aspx?pro_pid=<%# Eval("id")%>"><span><%# Eval("pro_class")%></span></a></dd>
                                                                         </ItemTemplate>
 
                                                                    </asp:Repeater>  
																		 
																	</dl>
																	 

																</div>

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
		<script type="text/javascript">
		    $(document).ready(function () {
		        $("li").click(function () {
		            $(this).addClass("selected").siblings().removeClass("selected");
		        })
		    })
		</script>
		<div class="clear"></div>
		<!--引导 -->
		  <uc1:mob_sub ID="mob_sub" runat="server" />
          </form>
	</body>
    <script type="text/javascript">
        $(function () {
            $("#categroy").attr("class", "active");
        });
</script>
</html>
