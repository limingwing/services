<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="shop_login" %>

<%@ Register Src="footer.ascx" TagName="footer" TagPrefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html>
<head lang="en">
    <meta charset="UTF-8">
    <title>登录</title>
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0, minimum-scale=1.0, maximum-scale=1.0, user-scalable=no">
    <meta name="format-detection" content="telephone=no">
    <meta name="renderer" content="webkit">
    <meta http-equiv="Cache-Control" content="no-siteapp" />
    <link rel="stylesheet" href="AmazeUI-2.4.2/assets/css/amazeui.css" />
    <link href="css/dlstyle.css" rel="stylesheet" type="text/css">
    <style type="text/css">
    .am-btn-group li {width:49%}
    </style>
</head>
<body>
    <div class="login-boxtitle">
        <h3 class="title" style="text-align: left;font-size:24px">
            登录商城</h3>
    </div>
    <div class="login-banner">
        <div class="login-main">
            <div class="login-banner-bg">
                <span></span>
                <img src="images/big.jpg" /></div>
            <div class="login-box">
                <div style="text-align: center;">
                    <img alt="logo" style="width: 50%;" src="<%=big_img%>" /></div>
                <div class="clear">
                </div>
                <div class="login-form">
                    <form id="form1" runat="server">
                    <div class="user-name">
                        <label for="user">
                            <i class="am-icon-user" style=" margin-top:15px;"></i>
                        </label>
                        <input type="text" name="username" id="username" placeholder="编号" runat="server">
                    </div>
                    <div class="user-pass">
                        <label for="password">
                            <i class="am-icon-lock" style=" margin-top:15px;"></i>
                        </label>
                        <input type="password" name="password" id="password" placeholder="请输入密码" runat="server">
                    </div>
                </div>
                <div class="login-links">
                    <%--<label for="remember-me">
                        没有账户去<a href="register.aspx" style="color: blue; text-decoration: underline">注册</a></label>--%>
                    <a href="#" class="am-fr">忘记密码</a>
                </div>
                <div class="am-cf">
                    <asp:Button ID="Button1" runat="server" Text="登 录" class="am-btn am-btn-primary am-btn-sm"
                        OnClick="Button1_Click" />
                </div>
                </form>
               <%-- <div class="partner">
                    	<h3>安装渠道</h3>
							<div class="am-btn-group">
								<li><a href="https://fir.im/jfkd"><img style="width:24%;" src="images/Android_72px_1094992_easyicon.net.png" />安卓版本</a></li>
								<li><a href="https://fir.im/9rkv"><img style="width:24%;" src="images/OS_Apple_60.170385395538px_1188753_easyicon.net.png"/>苹果版本</a></li>
							</div>
                </div>--%>
            </div>
        </div>
    </div>
    <uc1:footer ID="footer" runat="server" />
</body>
</html>
