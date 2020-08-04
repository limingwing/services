<%@ Page Language="C#" AutoEventWireup="true" CodeFile="register.aspx.cs" Inherits="shop_register" %>

<%@ Register Src="footer.ascx" TagName="footer" TagPrefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head lang="en">
    <meta charset="UTF-8">
    <title>注册</title>
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0, minimum-scale=1.0, maximum-scale=1.0, user-scalable=no">
    <meta name="format-detection" content="telephone=no">
    <meta name="renderer" content="webkit">
    <meta http-equiv="Cache-Control" content="no-siteapp" />
    <link rel="stylesheet" href="AmazeUI-2.4.2/assets/css/amazeui.min.css" />
    <link href="css/dlstyle.css" rel="stylesheet" type="text/css">
    <script src="AmazeUI-2.4.2/assets/js/jquery.min.js"></script>
    <script src="AmazeUI-2.4.2/assets/js/amazeui.min.js"></script>
    <script src="js/jquery.cookie.js" type="text/javascript"></script>
</head>
<body>
    <div class="login-boxtitle">
       <h3 class="title" style="text-align: left;font-size:24px">
            注册新会员</h3>
    </div>
    <div class="res-banner">
        <div class="res-main">
            <div class="login-banner-bg">
                <span></span>
                <img src="images/big.jpg" /></div>
            <div class="login-box">
            <div style="text-align: center;">
                    <img alt="logo" style="width: 50%;" src="<%=big_img%>" /></div>
                <div class="clear">
                </div>
                <form id="form1" runat="server">
                <div class="user-phone">
                    <label for="phone">
                        <i class="am-icon-mobile-phone am-icon-md"></i>
                    </label>
                    <input type="text" name="" id="phone" placeholder="请输入手机号" runat="server" />
                </div>
               <%-- <div class="verification">
                    <label for="code">
                        <i class="am-icon-code-fork" style=" margin-top:15px;"></i>
                    </label>
                    <input type="text" name="" id="code" placeholder="请输入验证码" runat="server" />
                     <a><input class="btn" type="button" id="dyMobileButton" value="获取" onclick="return dyMobileButton_onclick()" /></a>
                </div>--%>
                <div class="user-pass">
                    <label for="password" >
                        <i class="am-icon-lock"  style=" margin-top:15px;"></i>
                    </label>
                    <input type="password" name="" id="password" placeholder="设置密码" runat="server" />
                </div>
                <%-- <div class="user-pass">
                                <label for="passwordRepeat">
                                    <i class="am-icon-lock"></i>
                                </label>
                                <input type="password" name="" id="passwordRepeat" placeholder="确认密码" runat="server" />
                            </div>--%>
                <input type="hidden" name="" id="bas_id1" runat="server" />
                <br />
                <div class="am-cf">
                    <asp:Button class="am-btn am-btn-primary am-btn-sm am-fl" ID="btnSubmit" runat="server"
                        Text="新注册" OnClick="btnSubmit_Click" />
                </div>
                </form>
                <hr />
                <script>
                    $(function () {
                        $('#doc-my-tabs').tabs();
                    })
                </script>
            </div>
        </div>
         <!--底部-->
        <uc1:footer ID="footer" runat="server" />
    </div>
</body>
</html>
<%--<script>

       $(function () {
    /*仿刷新：检测是否存在cookie*/
    if ($.cookie("captcha")) {
        var count = $.cookie("captcha");
        var btn = $('#dyMobileButton');
        btn.val(count + '秒').attr('disabled', true).css('cursor', 'not-allowed');
        var resend = setInterval(function () {
            count--;
            if (count > 0) {
                btn.val(count + '秒').attr('disabled', true).css('cursor', 'not-allowed');
                $.cookie("captcha", count, { path: '/', expires: (1 / 86400) * count });
            } else {
                clearInterval(resend);
                btn.val("获取").removeClass('disabled').removeAttr('disabled style');
            }
        }, 1000);
    }
    /*点击改变按钮状态，已经简略掉ajax发送短信验证的代码*/
    $('#dyMobileButton').click(function () {
        var str = $("#phone").val();
        if (str == "") {
            alert("请先填写手机号码");
            return;
        }
        if (!(/^1[3|4|5|7|8][0-9]{9}$/.test(str))) {
            alert("手机号码格式不正确");
            return;
        }
        var btn = $(this);
        var count = 60;
        var resend = setInterval(function () {
            count--;
            if (count > 0) {
                btn.val(count + "秒");
                $.cookie("captcha", count, { path: '/', expires: (1 / 86400) * count });
            } else {
                clearInterval(resend);
                btn.val("获取").removeAttr('disabled style');
            }
        }, 1000);
        btn.attr('disabled', true).css('cursor', 'not-allowed');
        $.ajax({
            //要用post方式   
            type: "Post",
            //方法所在页面和方法名   
            url: "register.aspx/msgCode",
            data: "{'mobile':'" + $('#phone').val() + "'}",
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (data) {
                //返回的数据用data.d获取内容   
                alert(data.d);
            },
            error: function (err) {
                alert(err);
            }
        });     
    });
});

</script>--%>
