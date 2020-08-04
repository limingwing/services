<%@ Page Language="C#" AutoEventWireup="true" CodeFile="password1.aspx.cs" Inherits="shop_password1" %>
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

		<title>修改支付密码</title>

		<link href="AmazeUI-2.4.2/assets/css/admin.css" rel="stylesheet" type="text/css">
		<link href="AmazeUI-2.4.2/assets/css/amazeui.css" rel="stylesheet" type="text/css">

		<link href="css/personal.css" rel="stylesheet" type="text/css">
		<link href="css/stepstyle.css" rel="stylesheet" type="text/css">

		<script type="text/javascript" src="js/jquery-1.7.2.min.js"></script>
		<script src="AmazeUI-2.4.2/assets/js/amazeui.js"></script>
        <script src="js/jquery-1.4.1.min.js" type="text/javascript"></script>
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

					<div class="am-cf am-padding">
						<div class="am-fl am-cf"><strong class="am-text-danger am-text-lg">修改支付密码</strong> / <small>Password</small></div>
					</div>
					<hr/>
					<!--进度条-->
					<div class="m-progress">
						<div class="m-progress-list">
							<span class="step-1 step">
                                <em class="u-progress-stage-bg"></em>
                                <i class="u-stage-icon-inner">1<em class="bg"></em></i>
                                <p class="stage-name">重置密码</p>
                            </span>
							<span class="step-2 step">
                                <em class="u-progress-stage-bg"></em>
                                <i class="u-stage-icon-inner">2<em class="bg"></em></i>
                                <p class="stage-name">完成</p>
                            </span>
							<span class="u-progress-placeholder"></span>
						</div>
						<div class="u-progress-bar total-steps-2">
							<div class="u-progress-bar-inner"></div>
						</div>
					</div>
 <div class="am-form am-form-horizontal">
						  <div class="am-form-group">
							<label for="user-old-password" class="am-form-label">原支付密码</label>
							<div class="am-form-content">
								<input name="two" runat="server" type="password" id="two" placeholder="请输入原支付密码" />
							</div>
						</div>
						<div class="am-form-group">
							<label for="user-new-password" class="am-form-label">新支付密码</label>
							<div class="am-form-content">
								<input name="two1" runat="server" type="password" id="two1" placeholder="由数字、字母组合" />
							</div>
						</div>
						<div class="am-form-group">
							<label for="user-confirm-password" class="am-form-label">确认密码</label>
							<div class="am-form-content">
								<input name="two2" runat="server" type="password" id="two2" placeholder="请再次输入上面的密码" />
							</div>
						</div>
                     <%-- <div class="am-form-group">
							<label for="user-confirm-password" class="am-form-label">注册手机</label>
							<div class="am-form-content">
								<input runat="server" readonly type="text" id="user_phone" /><div class="am-btn am-btn-danger"><input id="btnSendCode" type="button" value="发送验证码" onclick="sendMessage()" style="border-style :none;background-color:#dd514c" /></div>
							</div>
                            <div class="am-form-content">
								<input name="checkCode" runat="server" id="checkCode" placeholder="短信验证码" type="text" />
							</div>
						</div>--%>
						<div class="info-btn">
							<div class="am-btn am-btn-danger"><asp:Button ID="btnSubmit" runat="server" Text="修改密码"  class="am-btn am-btn-danger"  onclick="btnSubmit_Click2"    /></div>
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
<%--<script type="text/javascript">
    /*-------------------------------------------*/
    var InterValObj; //timer变量，控制时间  
    var count = 120; //间隔函数，1秒执行  
    var curCount; //当前剩余秒数  
    var code = ""; //验证码  
    var codeLength = 6; //验证码长度  
    function sendMessage() {
        curCount = count;
        var phone = $("#user_phone").val(); //手机号码  

        if (phone != "") {


            //设置button效果，开始计时  
            $("#btnSendCode").attr("disabled", "true");
            $("#btnSendCode").val("请在" + curCount + "秒内输入验证码");
            InterValObj = window.setInterval(SetRemainTime, 1000); //启动计时器，1秒执行一次  
            //向后台发送处理数据  

            $.ajax({
                type: "POST", //用POST方式传输  
                dataType: "text", //数据格式:JSON  
                url: 'regmsg2.aspx', //目标地址  
                data: "phone=" + phone,
                error: function (XMLHttpRequest, textStatus, errorThrown) { },
                success: function (msg) { }
            });
        } else {
            alert("手机号码不能为空！");
        }
    }
    //timer处理函数  
    function SetRemainTime() {
        if (curCount == 0) {
            window.clearInterval(InterValObj); //停止计时器  
            $("#btnSendCode").removeAttr("disabled"); //启用按钮  
            $("#btnSendCode").val("重新发送验证码");
            code = ""; //清除验证码。如果不清除，过时间后，输入收到的验证码依然有效      
        }
        else {
            curCount--;
            $("#btnSendCode").val("请在" + curCount + "秒内输入验证码");
        }
    }  
</script>--%>