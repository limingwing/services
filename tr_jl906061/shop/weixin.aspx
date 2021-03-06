﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="weixin.aspx.cs" Inherits="shop_weixin" %>

<%@ Register Src="Navigation.ascx" TagName="Navigation" TagPrefix="uc1" %>
<%@ Register Src="index_top.ascx" TagName="index_top" TagPrefix="uc1" %>
<%@ Register Src="footer.ascx" TagName="footer" TagPrefix="uc1" %>
<%@ Register Src="mob_sub.ascx" TagName="mob_sub" TagPrefix="uc1" %>
<%@ Register Src="left.ascx" TagName="left" TagPrefix="uc1" %>
<%@ Register Src="member_search.ascx" TagName="member_search" TagPrefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0,maximum-scale=1.0, user-scalable=0">
    <title>微信充值</title>
    <link href="AmazeUI-2.4.2/assets/css/admin.css" rel="stylesheet" type="text/css">
    <link href="AmazeUI-2.4.2/assets/css/amazeui.css" rel="stylesheet" type="text/css">
    <link type="text/css" href="css/style.css" rel="Stylesheet"" />
    <link href="css/personal.css" rel="stylesheet" type="text/css">
    <link href="css/stepstyle.css" rel="stylesheet" type="text/css">
    <script type="text/javascript" src="js/jquery-1.7.2.min.js"></script>
    <script src="AmazeUI-2.4.2/assets/js/amazeui.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <header>
			<article>
				<div class="mt-logo">
					<!--顶部导航条 -->
					 <uc1:index_top ID="index_top" runat="server" />

						<!--悬浮搜索框-->

						 <uc1:member_search ID="member_search" runat="server" />

						<div class="clear"></div>
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
					<div class="am-cf am-padding">
						<div class="am-fl am-cf"><strong class="am-text-danger am-text-lg">微信充值</strong> / <small>WeChat recharge</small></div>
					</div>
					<hr>
					 <div class="am-form" >
                    <asp:Image ID="Image1" runat="server" />
                    </div>
					<div style=" height:20px;"></div>
                    <div class="am-form am-form-horizontal">
                    <div class="am-form-group">
                        <label for="user-old-password" class="am-form-label">
                            充值金额</label>
                        <div class="am-form-content">
                            <input name="money" runat="server" type="text" id="money" placeholder="请输入充值金额" />
                        </div>
                    </div>
                    <div class="am-form-group">
                        <label for="user-old-password" class="am-form-label">
                            备注</label>
                        <div class="am-form-content">
                            <input name="beizhu" runat="server" type="text" id="beizhu" placeholder="请输入充值金额" />
                        </div>
                    </div>
                    <div class="am-form-group">
                        <label for="user-old-password" class="am-form-label">
                            二级密码</label>
                        <div class="am-form-content">
                            <input name="pass_two" runat="server" type="password" id="pass_two" placeholder="支付密码" /><asp:RequiredFieldValidator
                                ID="RequiredFieldValidator1" runat="server" Display="Dynamic" ControlToValidate="pass_two"
                                ErrorMessage="支付密码不能为空"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <div class="info-btn">
                        <div class="am-btn am-btn-danger">
                            <asp:Button ID="btnSubmit" runat="server" Text="确认充值" class="am-btn am-btn-danger"
                                OnClick="btnSubmit_Click1" ValidationGroup="a" /></div>
                                <div class="am-btn am-btn-danger"><a href="member_center.aspx"><input type="button" value="返回" class="am-btn am-btn-danger"  /></a>
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