<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ApplySupply.aspx.cs" Inherits="shop_ApplySupply" %>

<%@ Register Src="Navigation.ascx" TagName="Navigation" TagPrefix="uc1" %>
<%@ Register Src="index_top.ascx" TagName="index_top" TagPrefix="uc1" %>
<%@ Register Src="footer.ascx" TagName="footer" TagPrefix="uc1" %>
<%@ Register Src="mob_sub.ascx" TagName="mob_sub" TagPrefix="uc1" %>
<%@ Register Src="left.ascx" TagName="left" TagPrefix="uc1" %>
<%@ Register Src="member_search.ascx" TagName="member_search" TagPrefix="uc1" %>
<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0,maximum-scale=1.0, user-scalable=0">
    <title>申请商家</title>
    <link href="AmazeUI-2.4.2/assets/css/admin.css" rel="stylesheet" type="text/css">
    <link href="AmazeUI-2.4.2/assets/css/amazeui.css" rel="stylesheet" type="text/css">
    <link href="css/personal.css" rel="stylesheet" type="text/css">
    <link href="css/stepstyle.css" rel="stylesheet" type="text/css">
    <script type="text/javascript" src="js/jquery-1.7.2.min.js"></script>
    <script src="AmazeUI-2.4.2/assets/js/amazeui.js"></script>
</head>
<body>
    <form id="form1" runat="server" onsubmit="return check()">
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
                    <div class="am-fl am-cf">
                        <strong class="am-text-danger am-text-lg">申请商家</strong>/<small>Apply For Business</small></div>
                </div>
                <hr />
                <br />
                <div class="am-form am-form-horizontal">
                    <div class="am-form-group">
                        <label for="user-old-password" class="am-form-label">
                            公司名称</label>
                        <div class="am-form-content">
                            <input name="name" runat="server" type="text" id="name" placeholder="请输入营业执照上面的名称" />
                        </div>
                    </div>
                    <%--<div class="am-form-group">
                        <label for="user-old-password" class="am-form-label">
                            身份证号</label>
                        <div class="am-form-content">
                            <input name="idcard" runat="server" type="text" id="idcard" placeholder="请输入法人证件号"
                                onblur="isidcard(this.value)" />
                            <label style="color: red; display: none" id="lbidcard">
                            </label>
                        </div>
                    </div>--%>
                     <div class="am-form-group">
                        <label for="user-old-password" class="am-form-label">
                            行业类别</label>
                        <div class="am-form-content">
                            <input name="name" runat="server" type="text" id="category" placeholder="请输入所属行业类别" />
                        </div>
                    </div>
                    <div class="am-form-group">
                        <label for="user-old-password" class="am-form-label">
                            联系人</label>
                        <div class="am-form-content">
                            <input name="legalname" runat="server" type="text" id="legalname" placeholder="请输入法定联系人" />
                        </div>
                    </div>
                    <div class="am-form-group">
                        <label for="user-old-password" class="am-form-label">
                            法人电话</label>
                        <div class="am-form-content">
                            <input name="legalPhone" runat="server" type="text" id="legalPhone" placeholder="请输入法人(固定电话区号-号码/13位手机号)"
                                onblur="isphone(this.value)" />
                            <label style="color: red; display: none" id="lbphone">
                            </label>
                        </div>
                    </div>
                    <div class="am-form-group">
                        <label for="user-old-password" class="am-form-label">
                            公司地址</label>
                        <div class="am-form-content">
                            <input name="address" runat="server" type="text" id="address" placeholder="请输入公司地址" />
                        </div>
                    </div>
                    <div class="am-form-group">
                        <label for="user-old-password" class="am-form-label">
                            银行名称</label>
                        <div class="am-form-content">
                            <asp:DropDownList ID="bankName" runat="server">
                                    </asp:DropDownList>
                        </div>
                    </div>
                    <div class="am-form-group">
                        <label for="user-old-password" class="am-form-label">
                            银行卡号</label>
                        <div class="am-form-content">
                            <input name="name" runat="server" type="text" id="bankno" placeholder="请输入开户银行卡号" />
                        </div>
                    </div>
                    <div class="am-form-group">
                        <label for="user-old-password" class="am-form-label">
                            开户地址</label>
                        <div class="am-form-content">
                            <input name="name" runat="server" type="text" id="bankaddress" placeholder="请输入银行开户地址" />
                        </div>
                    </div>
                 <%--   <div class="am-form-group">
                        <label for="user-old-password" class="am-form-label">
                            电子邮箱</label>
                        <div class="am-form-content">
                            <input name="email" runat="server" type="text" id="email" placeholder="请输入电子邮箱" onblur="isemail(this.value)" />
                            <label style="color: red; display: none" id="lbemail">
                            </label>
                        </div>
                    </div>
                    <div class="am-form-group">
                        <label for="user-old-password" class="am-form-label">
                            公司简介</label>
                        <div class="am-form-content">
                            <textarea id="content" runat="server" placeholder="请输入公司简介"></textarea>
                        </div>
                    </div>--%>
                    <div class="am-form-group">
                        <label for="user-old-password" class="am-form-label">
                            营业执照</label>
                        <div class="am-form-content">
                            <asp:FileUpload ID="fileNo" runat="server" />
                        </div>
                    </div>
                    <div class="am-form-group">
                        <label for="user-old-password" class="am-form-label">
                            店面照片</label>
                        <div class="am-form-content">
                            <asp:FileUpload ID="fileImg" runat="server" />
                        </div>
                    </div>
                    <div class="info-btn">
                        <div class="am-btn am-btn-danger">
                            <asp:Button ID="Button1" runat="server" Text="提交申请" class="am-btn am-btn-danger"
                                ValidationGroup="a" onclick="Button1_Click" /></div>
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
<script type="text/javascript">
    function isemail(str) {
        var result = str.match(/^\w+((-\w+)|(\.\w+))*\@[A-Za-z0-9]+((\.|-)[A-Za-z0-9]+)*\.[A-Za-z0-9]+$/);
        if (result == null) {
            $("#lbemail").attr("style", "color:red");
            $("#lbemail").html("请输入正确的邮件格式");
            return false;
        } else {
            $("#lbemail").attr("style", "color:red;display:none");
            $("#lbemail").html("");
        }
    }
    function isidcard(str) {
        var result = str.match(/^[1-9]\d{7}((0\d)|(1[0-2]))(([0|1|2]\d)|3[0-1])\d{3}$|^[1-9]\d{5}[1-9]\d{3}((0\d)|(1[0-2]))(([0|1|2]\d)|3[0-1])\d{3}([0-9]|X)$/);
        if (result == null) {
            $("#lbidcard").attr("style", "color:red");
            $("#lbidcard").html("请输入正确的身份证号");
            return false;
        } else {
            $("#lbidcard").attr("style", "color:red;display:none");
            $("#lbidcard").html("");
        }
    }
    function isphone(str) {
        var result = str.match(/^((0\d{2,3}-\d{7,8})|(1[35847]\d{9}))$/);
        if (result == null) {
            $("#lbphone").attr("style", "color:red");
            $("#lbphone").html("请输入正确的号码格式");
            return false;
        } else {
            $("#lbphone").attr("style", "color:red;display:none");
            $("#lbphone").html("");
        }
    }
    function check() {
        var name = $("#name").val();
        if (name == null || name == '') {
            alert("公司名称不能为空");
            return false;
        }
        var category = $("#category").val();
        if (category == null || category == '') {
            alert("行业类别不能为空");
            return false;
        }
//        var idcard = $("#idcard").val();
//        if (idcard == null || idcard == '') {
//            alert("法人证件号不能为空");
//            return false;
//        }
        var legalname = $("#legalname").val();
        if (legalname == null || legalname == '') {
            alert("法定联系人不能为空");
            return false;
        }
        var legalPhone = $("#legalPhone").val();
        if (legalPhone == null || legalPhone == '') {
            alert("法人电话不能为空");
            return false;
        }
        var address = $("#address").val();
        if (address == null || address == '') {
            alert("公司地址不能为空");
            return false;
        }
//        var email = $("#email").val();
//        if (email == null || email == '') {
//            alert("电子邮箱不能为空");
//            return false;
//        }
//        var content = $("#content").val();
//        if (content == null || content == '') {
//            alert("公司简介不能为空");
//            return false;
//        }
        var bankName = $("#bankName").val();
        if (bankName == null || bankName == '') {
            alert("开户银行不能为空");
            return false;
        }
        var bankno = $("#bankno").val();
        if (bankno == null || bankno == '') {
            alert("银行卡号不能为空");
            return false;
        }
        var bankaddress = $("#bankaddress").val();
        if (bankaddress == null || bankaddress == '') {
            alert("开户地址不能为空");
            return false;
        }

        var result1 = email.match(/^\w+((-\w+)|(\.\w+))*\@[A-Za-z0-9]+((\.|-)[A-Za-z0-9]+)*\.[A-Za-z0-9]+$/);
        if (result1 == null) {
            $("#lbemail").attr("style", "color:red");
            $("#lbemail").html("请输入正确的邮件格式");
            return false;
        } else {
            $("#lbemail").attr("style", "color:red;display:none");
            $("#lbemail").html("");
        }

        var result2 = idcard.match(/^[1-9]\d{7}((0\d)|(1[0-2]))(([0|1|2]\d)|3[0-1])\d{3}$|^[1-9]\d{5}[1-9]\d{3}((0\d)|(1[0-2]))(([0|1|2]\d)|3[0-1])\d{3}([0-9]|X)$/);
        if (result2 == null) {
            $("#lbidcard").attr("style", "color:red");
            $("#lbidcard").html("请输入正确的身份证号");
            return false;
        } else {
            $("#lbidcard").attr("style", "color:red;display:none");
            $("#lbidcard").html("");
        }
        var result3 = legalPhone.match(/^((0\d{2,3}-\d{7,8})|(1[35847]\d{9}))$/);
        if (result3 == null) {
            $("#lbphone").attr("style", "color:red");
            $("#lbphone").html("请输入正确的号码格式");
            return false;
        } else {
            $("#lbphone").attr("style", "color:red;display:none");
            $("#lbphone").html("");
        }
    }
</script>
