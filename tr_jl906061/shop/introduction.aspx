<%@ Page Language="C#" AutoEventWireup="true" CodeFile="introduction.aspx.cs" Inherits="shop_introduction" %>

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
    <title>商品页面</title>
    <link href="AmazeUI-2.4.2/assets/css/admin.css" rel="stylesheet" type="text/css" />
    <link href="AmazeUI-2.4.2/assets/css/amazeui.css" rel="stylesheet" type="text/css" />
    <link href="basic/css/demo.css" rel="stylesheet" type="text/css" />
    <link type="text/css" href="css/optstyle.css" rel="stylesheet" />
    <link type="text/css" href="css/style.css" rel="stylesheet" />
    <script type="text/javascript" src="basic/js/jquery-1.7.min.js"></script>
    <script type="text/javascript" src="basic/js/quick_links.js"></script>
    <script type="text/javascript" src="AmazeUI-2.4.2/assets/js/amazeui.js"></script>
    <script type="text/javascript" src="js/jquery.imagezoom.min.js"></script>
    <script type="text/javascript" src="js/jquery.flexslider.js"></script>
    <script type="text/javascript" src="js/list.js"></script>
    <script type="text/javascript" src="../../js/cart.js"></script>
    <script type="text/javascript" src="../../js/layout.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <!--顶部导航条 -->
    <uc1:index_top ID="index_top" runat="server" />
    <!--悬浮搜索框-->
    <uc1:searcher ID="searcher" runat="server" />
    <div class="clear">
    </div>
    <b class="line"></b>
    <div class="listMain">
        <!--分类-->
        <div class="nav-table">
            <div class="long-title">
                <span class="all-goods">全部分类</span></div>
            <uc1:Navigation ID="Navigation" runat="server" />
            <!--导航栏-->
        </div>
        <ol class="am-breadcrumb am-breadcrumb-slash">
            <li><a href="index.aspx">首页</a></li>
            <li><a href="#">分类</a></li>
            <li class="am-active">内容</li>
        </ol>
        <script type="text/javascript">
            $(function () { });
            $(window).load(function () {
                $('.flexslider').flexslider({
                    animation: "slide",
                    start: function (slider) {
                        $('body').removeClass('loading');
                    }
                });
            });
        </script>
        <div class="scoll">
            <section class="slider">
						<div class="flexslider">
							<ul class="slides">
								<li>
									<img src="<%=pro_imgs%>" mid="<%=pro_imgs%>" big="<%=pro_imgs%>">
								</li>
								<li>
									<img src="<%=pro_imgs1%>" mid="<%=pro_imgs1%>" big="<%=pro_imgs1%>">
								</li>
								<li>
									<img src="<%=pro_imgs2%>" mid="<%=pro_imgs2%>" big="<%=pro_imgs2%>">
								</li>
							</ul>
						</div>
					</section>
        </div>
        <!--放大镜-->
        <div class="item-inform">
            <div class="clearfixLeft" id="clearcontent">
                <div class="box">
                    <script type="text/javascript">
                        $(document).ready(function () {
                            $(".jqzoom").imagezoom();
                            $("#thumblist li a").click(function () {
                                $(this).parents("li").addClass("tb-selected").siblings().removeClass("tb-selected");
                                $(".jqzoom").attr('src', $(this).find("img").attr("mid"));
                                $(".jqzoom").attr('rel', $(this).find("img").attr("big"));
                            });
                        });
                    </script>
                    <div class="tb-booth tb-pic tb-s310">
                        <a href="<%=pro_imgs%>">
                            <img src="<%=pro_imgs%>" alt="细节展示放大镜特效" rel="<%=pro_imgs%>" class="jqzoom" /></a>
                    </div>
                    <ul class="tb-thumb" id="thumblist">
                        <li class="tb-selected">
                            <div class="tb-pic tb-s40">
                                <a href="#">
                                    <img src="<%=pro_imgs%>" mid="<%=pro_imgs%>" big="<%=pro_imgs%>"></a>
                            </div>
                        </li>
                        <li>
                            <div class="tb-pic tb-s40">
                                <a href="#">
                                    <img src="<%=pro_imgs1%>" mid="<%=pro_imgs1%>" big="<%=pro_imgs1%>"></a>
                            </div>
                        </li>
                        <li>
                            <div class="tb-pic tb-s40">
                                <a href="#">
                                    <img src="<%=pro_imgs2%>" mid="<%=pro_imgs2%>" big="<%=pro_imgs2%>"></a>
                            </div>
                        </li>
                    </ul>
                </div>
                <div class="clear">
                </div>
            </div>
            <div class="clearfixRight">
                <!--规格属性-->
                <!--名称-->
                <div class="tb-detail-hd">
                    <h1>
                        <asp:Literal ID="pro_title" runat="server"></asp:Literal>
                    </h1>
                </div>
                <div class="tb-detail-list">
                    <!--价格-->
                    <div class="tb-detail-price">
                        <li class="price iteminfo_price">
                            <dt>促销价</dt>
                            <dd>
                                <em>¥</em><b class="sys_item_price" id="sale_prices"><asp:Literal ID="sale_price"
                                    runat="server"></asp:Literal></b>
                            </dd>
                        </li>
                        <li class="price iteminfo_mktprice">
                            <dt>原价</dt>
                            <dd>
                                <em>¥</em><b class="sys_item_mktprice"><asp:Literal ID="go_price" runat="server"></asp:Literal>
                                </b>
                            </dd>
                        </li>
                        <div class="clear">
                        </div>
                    </div>
                    <!--地址-->
                    <%--   <dl class="iteminfo_parameter freight">
								<dt>原产地</dt>
								<div class="iteminfo_freprice">
									<div class="am-form-content address">
										<select data-am-selected>
											<option value="a">浙江省</option>
											<option value="b">湖北省</option>
										</select>
										<select data-am-selected>
											<option value="a">温州市</option>
											<option value="b">武汉市</option>
										</select>
										<select data-am-selected>
											<option value="a">瑞安区</option>
											<option value="b">洪山区</option>
										</select>
									</div>
									<%--<div class="pay-logis">
										快递<b class="sys_item_freprice">10</b>元
									</div>
								</div>
							</dl>--%>
                    <div class="clear">
                    </div>
                    <!--销量-->
                     <%--<ul class="tm-ind-panel">
                        <li class="tm-ind-item tm-ind-sellCount canClick">
                            <div class="tm-indcon">
                                <span class="tm-label">月销量</span><span class="tm-count">1015</span></div>
                        </li>
                        <li class="tm-ind-item tm-ind-sumCount canClick">
                            <div class="tm-indcon">
                                <span class="tm-label">累计销量</span><span class="tm-count">6015</span></div>
                        </li>
                       	<li class="tm-ind-item tm-ind-reviewCount canClick tm-line3">
									<div class="tm-indcon"><span class="tm-label">累计评价</span><span class="tm-count">640</span></div>
								</li>
                    </ul>--%>
                    <div class="clear">
                    </div>
                    <!--各种规格-->
                    <dl class="iteminfo_parameter sys_item_specpara">
                        <dt class="theme-login" onclick="quren(2)">
                            <div class="cart-title" style="font-size: 16px; color: #000000;">
                                可选规格(点击选择产品数量)<span class="am-icon-angle-right"></span></div>
                        </dt>
                        <dd>
                            <!--操作页面-->
                            <div class="theme-popover-mask">
                            </div>
                            <div class="theme-popover">
                                <div class="theme-span">
                                </div>
                                <div class="theme-poptit">
                                    <a href="javascript:;" title="关闭" class="close">×</a>
                                </div>
                                <div class="theme-popbod dform">
                                    <li class="theme-signin" name="loginform">
                                        <div class="theme-signin-left" id="guige">
                                           <%-- <div class="theme-options">
                                                <div class="cart-title">
                                                    价格</div>
                                                <ul>
                                                    <asp:Repeater ID="Repeater2" runat="server">
                                                        <ItemTemplate>
                                                            <li class="sku-line">
                                                                <label id="<%#Eval("AttrPrice")%>">
                                                                    <%#Eval("AttrStr")%></label><i></i></li>
                                                        </ItemTemplate>
                                                    </asp:Repeater>
                                                </ul>
                                            </div>--%>
                                            <div class="theme-options">
                                                <div class="cart-title">
                                                    规格</div>
                                                <ul>
                                                    <asp:Repeater ID="Repeater1" runat="server">
                                                        <ItemTemplate>
                                                            <li class="sku-line
                                                            <%--  <%#(Container.ItemIndex+1)==1?"selected":"" %>--%>
                                                                "><a href="#" style="border: 0">
                                                                    <%# GetDataItem() %></a> <i></i></li>
                                                        </ItemTemplate>
                                                    </asp:Repeater>
                                                </ul>
                                            </div>
                                            <input type="hidden" runat="server" id="hidLI" />
                                            <%--<input type="hidden" runat="server" id="hidLP" />--%>
                                            <script type="text/javascript">
                                                $('.theme-options').hover(function () {
                                                    var $that = $(this).children('ul');
                                                    $(this).children('ul').show().find('a').click(function () {


                                                        var txt = $(this).text();
                                                        $("#hidLI").val(trimLeft(txt));
                                                        $('#guige').removeAttr("style");
                                                        $('#LikBuy').attr('style', 'display: none')
                                                        $('#LikCart').attr('style', 'display: none')
                                                        $('#LinkButton1').removeAttr("style");
                                                        $('#LinkButton2').removeAttr("style");
                                                    });
                                                });
                                                //                                                $('.theme-options').hover(function () {
                                                //                                                    var $that = $(this).children('ul');
                                                //                                                    $(this).children('ul').show().find('label').click(function () {


                                                //                                                        var txt = $(this).text();
                                                //                                                        $("#sale_prices").text("");
                                                //                                                        $("#sale_prices").text($(this).attr("id"));
                                                //                                                        $("#hidLP").val($(this).attr("id"));
                                                //                                                        $('#guige').removeAttr("style");
                                                //                                                        $('#LikBuy').attr('style', 'display: none')
                                                //                                                        $('#LikCart').attr('style', 'display: none')
                                                //                                                        $('#LinkButton1').removeAttr("style");
                                                //                                                        $('#LinkButton2').removeAttr("style");
                                                //                                                    });
                                                //                                                });
                                                function trimLeft(s) {
                                                    if (s == null) {
                                                        return "";
                                                    }
                                                    var whitespace = new String(" \t\n\r");
                                                    var str = new String(s);
                                                    if (whitespace.indexOf(str.charAt(0)) != -1) {
                                                        var j = 0, i = str.length;
                                                        while (j < i && whitespace.indexOf(str.charAt(j)) != -1) {
                                                            j++;
                                                        }
                                                        str = str.substring(j, i);
                                                    }
                                                    return str;
                                                }  
                                            </script>
                                            <div class="theme-options">
                                                <div class="cart-title number">
                                                    数量</div>
                                                <dd>
                                                    <input id="min" class="am-btn am-btn-default" name="" type="button" value="-" />
                                                    <input id="text_box" type="text" value="1" style="width: 30px;" runat="server" />
                                                    <input id="add" class="am-btn am-btn-default" name="" type="button" value="+" />
                                                    <span id="Stock" class="tb-hidden">库存<span class="stock">1000</span>件</span>
                                                </dd>
                                            </div>
                                            <div class="clear">
                                            </div>
                                            <div class="btn-op">
                                                <a onclick="ClickChoose()">
                                                    <div class="btn am-btn am-btn-warning">
                                                        确认</div>
                                                </a>
                                                <div class="btn close am-btn am-btn-warning">
                                                    取消</div>
                                            </div>
                                        </div>
                                        <div class="theme-signin-right">
                                            <div class="img-info">
                                                <img src="<%=pro_imgs%>" />
                                            </div>
                                            <div class="text-info">
                                                <span class="J_Price price-now" id="p_attrprice">&nbsp;¥&nbsp;<asp:Literal ID="Literal1"
                                                    runat="server"></asp:Literal></span> <span id="Stock" class="tb-hidden">库存<span class="stock">1000</span>件</span>
                                            </div>
                                        </div>
                                    </li>
                                </div>
                            </div>
                        </dd>
                    </dl>
                    <div class="clear">
                    </div>
                    <input type="hidden" runat="server" id="HidChoose" />
                    <!--活动	-->
                    <%--<div class="shopPromotion gold">
								<div class="hot">
									<dt class="tb-metatit">店铺优惠</dt>
									<div class="gold-list">
										<p>购物满2件打8折，满3件7折<span>点击领券<i class="am-icon-sort-down"></i></span></p>
									</div>
								</div>
								<div class="clear"></div>
								<div class="coupon">
									<dt class="tb-metatit">优惠券</dt>
									<div class="gold-list">
										<ul>
											<li>125减5</li>
											<li>198减10</li>
											<li>298减20</li>
										</ul>
									</div>
								</div>
							</div>--%>
                </div>
                <div class="pay">
                    <div class="pay-opt">
                        <a href="index.aspx"><span class="am-icon-home am-icon-fw">首页</span></a> <a>
                            <%--<span class="am-icon-heart am-icon-fw">收藏</span>--%></a>
                    </div>
                    <li>
                        <div class="clearfix tb-btn tb-btn-buy theme-login">
                            <a id="LikBuy" class="theme-login" title="点此按钮到下一步确认购买信息" href="#" onclick="quren(1)">
                                立即购买</a>
                            <asp:Button ID="LinkButton1" runat="server" CssClass="theme-login" Text="立即购买" OnClick="LinkButton1_Click" Style="display: none"></asp:Button>
                        </div>
                    </li>
                    <li>
                        <div class="clearfix tb-btn tb-btn-basket theme-login">
                            <a id="LikCart" class="theme-login" href="#" onclick="quren(2)">加入购物车</a>
                            <asp:Button ID="LinkButton2" runat="server" CssClass="theme-login" Text="加入购物车" OnClick="LinkButton2_Click" Style="display: none"></asp:Button>
                        </div>
                    </li>
                </div>
            </div>
            <div class="clear">
            </div>
        </div>
        <div class="clear">
        </div>
        <!-- introduce-->
        <div class="introduce">
            <div class="browse">
                <div class="mc">
                    <ul>
                        <div class="mt">
                            <h2>
                                热卖单品</h2>
                        </div>
                        <asp:Repeater ID="hot" runat="server">
                            <ItemTemplate>
                                <li class="first">
                                    <div class="p-img">
                                        <a href="introduction.aspx?pro_id=<%# Eval("pro_id")%>">
                                            <img class="" src="<%# Eval("pro_imgs")%>">
                                        </a>
                                    </div>
                                    <div class="p-name">
                                        <a href="#">
                                            <%# Eval("pro_name")%>
                                        </a>
                                    </div>
                                    <div class="p-price">
                                        <strong>￥
                                            <%# (Convert.ToDecimal(Eval("salse_price"))*1m).ToString("n2")%></strong></div>
                                </li>
                            </ItemTemplate>
                        </asp:Repeater>
                    </ul>
                </div>
            </div>
            <div class="introduceMain">
                <div class="am-tabs" data-am-tabs>
                    <ul class="am-avg-sm-3 am-tabs-nav am-nav am-nav-tabs">
                        <li class="am-active"><a href="#"><span class="index-needs-dt-txt">宝贝详情</span></a>
                        </li>
                        <%--<li>
									<a href="#">

										<span class="index-needs-dt-txt">全部评价</span></a>

								</li>--%>
                        <li><a href="#"><span class="index-needs-dt-txt">猜你喜欢</span></a> </li>
                    </ul>
                    <div class="am-tabs-bd">
                        <div class="twlistNews">
                            <asp:Literal ID="pro_content" runat="server"></asp:Literal>
                            <div class="clear">
                            </div>
                        </div>
                        <div class="am-tab-panel am-fade">
                            <div class="like">
                                <ul class="am-avg-sm-2 am-avg-md-3 am-avg-lg-4 boxes">
                                    <asp:Repeater ID="rptList" runat="server">
                                        <ItemTemplate>
                                            <li>
                                                <div class="i-pic limit">
                                                    <img src="<%# Eval("pro_imgs")%>"></img>
                                                    <p>
                                                        <%# Eval("pro_name")%>
                                                    </p>
                                                    <p class="price fl">
                                                        <b>¥</b> <strong>
                                                            <%# Eval("go_price")%></strong>
                                                    </p>
                                                </div>
                                            </li>
                                        </ItemTemplate>
                                        <FooterTemplate>
                                            <%#rptList.Items.Count == 0 ? "<tr><td align=\"center\" colspan=\"9\"><font color=red>暂无记录</font></td></tr>" : ""%>
                                            </tbody> </table>
                                        </FooterTemplate>
                                    </asp:Repeater>
                                </ul>
                            </div>
                            <div class="clear">
                            </div>
                            <!--分页 -->
                            <div class="pagelist">
                                <div id="PageContent" runat="server" class="default">
                                </div>
                            </div>
                            <div class="clear">
                            </div>
                        </div>
                    </div>
                </div>
                <div class="clear">
                </div>
                <uc1:footer ID="footer" runat="server" />
            </div>
        </div>
    </div>
    <!--菜单 -->
    <uc1:sidebar ID="sidebar" runat="server" />
    </form>
</body>
<script type="text/javascript">
    function quren(obj) {
        $("#HidChoose").val(obj);
        $('#guige').attr('style', 'border: 2px solid #BE0106');
        var sUserAgent = navigator.userAgent.toLowerCase();

        var bIsIpad = sUserAgent.match(/ipad/i) == "ipad";

        var bIsIphoneOs = sUserAgent.match(/iphone os/i) == "iphone os";

        var bIsMidp = sUserAgent.match(/midp/i) == "midp";

        var bIsUc7 = sUserAgent.match(/rv:1.2.3.4/i) == "rv:1.2.3.4";

        var bIsUc = sUserAgent.match(/ucweb/i) == "ucweb";

        var bIsAndroid = sUserAgent.match(/android/i) == "android";

        var bIsCE = sUserAgent.match(/windows ce/i) == "windows ce";

        var bIsWM = sUserAgent.match(/windows mobile/i) == "windows mobile";



        if (bIsIpad || bIsIphoneOs || bIsMidp || bIsUc7 || bIsUc || bIsAndroid || bIsCE || bIsWM) {
            $('#guige').removeAttr("style");
            //window.location.href = '手机站链接';

        }
        //         else {

        //            window.location = 'PC站链接';

        //        }

    }
    function ClickChoose() {
        var hid = $("#HidChoose").val();
        if (hid == '1') {
            document.getElementById('LinkButton1').click();
        }
        if (hid == '2') {
            document.getElementById('LinkButton2').click();
        }
    }
</script>
</html>
