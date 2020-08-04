<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddProduct.aspx.cs" Inherits="shop_AddProduct" %>

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
    <title>我的商家</title>
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
                        <strong class="am-text-danger am-text-lg">我的商家</strong>/<small>New Merchant Products</small></div>
                </div>
                <hr />
                <br />
                <div class="am-form am-form-horizontal">
                    <div class="am-form-group">
                        <label for="user-old-password" class="am-form-label">
                            商品类别</label>
                        <div class="am-form-content">
                            <asp:DropDownList ID="ddlproduct_category_id" runat="server" datatype="*" errormsg="请选择商品类别"
                                sucmsg=" ">
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="am-form-group">
                        <label for="user-old-password" class="am-form-label">
                            商品名称</label>
                        <div class="am-form-content">
                            <input type="text" id="txtproduct_name" runat="server" maxlength="200" class="input small"
                                datatype="*" errormsg="" ajaxurl="../../tools/admin_ajax.ashx?action=code_validate"
                                placeholder="必填商品名称" />
                        </div>
                    </div>
                    <div class="am-form-group">
                        <label for="user-old-password" class="am-form-label">
                            计量单位</label>
                        <div class="am-form-content">
                            <input type="text" id="txtdw" runat="server" class="input small" maxlength="10" datatype="*"
                                sucmsg="" placeholder="必填计量单位" />
                        </div>
                    </div>
                    <div class="am-form-group">
                        <label for="user-old-password" class="am-form-label">
                            进货单价</label>
                        <div class="am-form-content">
                            <input type="text" id="txtgo_price" runat="server" class="input small" onblur="isprice(this.value,1)"
                                maxlength="8" datatype="*" sucmsg="" errormsg="请输入正确的金额" placeholder="必填进货单价" />
                            <label style="color: red; display: none" id="lbgoprice">
                            </label>
                        </div>
                    </div>
                    <div class="am-form-group">
                        <label for="user-old-password" class="am-form-label">
                            销售单价</label>
                        <div class="am-form-content">
                            <input type="text" id="txtsalse_price" runat="server" class="input small" onblur="isprice(this.value,2)"
                                maxlength="8" datatype="*" sucmsg="" errormsg="请输入正确的金额" placeholder="必填销售单价" />
                            <label style="color: red; display: none" id="lbsaleprice">
                            </label>
                        </div>
                    </div>
                    <div class="am-form-group">
                        <label for="user-old-password" class="am-form-label">
                            商品属性</label>
                        <div class="am-form-content">
                            <asp:DropDownList ID="attribute" runat="server" datatype="*" errormsg="请选择商品属性" sucmsg=" ">
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="am-form-group">
                        <label for="user-address" class="am-form-label">
                            商品产地</label>
                        <div class="am-form-content address">
                            <asp:DropDownList ID="ddlprov" runat="server" datatype="*" errormsg="请选择商品产地" sucmsg=" "
                                OnSelectedIndexChanged="ddlprov_SelectedIndexChanged" AutoPostBack="true">
                            </asp:DropDownList>
                            <br />
                            <asp:DropDownList ID="ddlcity" runat="server" datatype="*" errormsg="请选择商品产地" sucmsg=" "
                                OnSelectedIndexChanged="ddlcity_SelectedIndexChanged" AutoPostBack="true">
                            </asp:DropDownList>
                            <br />
                            <asp:DropDownList ID="ddlarea" runat="server" datatype="*" errormsg="请选择商品产地" sucmsg=" ">
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="am-form-group">
                        <label for="user-old-password" class="am-form-label">
                            主商品图片</label>
                        <div class="am-form-content">
                            <asp:FileUpload ID="fileimg" runat="server" />
                        </div>
                    </div>
                    <div class="am-form-group">
                        <label for="user-old-password" class="am-form-label">
                            副商品图片</label>
                        <div class="am-form-content">
                            <asp:FileUpload ID="fileimg1" runat="server" />
                        </div>
                    </div>
                    <div class="am-form-group">
                        <label for="user-old-password" class="am-form-label">
                            副商品图片</label>
                        <div class="am-form-content">
                            <asp:FileUpload ID="fileimg2" runat="server" />
                        </div>
                    </div>
                    <div class="info-btn">
                        <div class="am-btn am-btn-danger">
                            <asp:Button ID="Button1" runat="server" Text="提交新增" class="am-btn am-btn-danger"
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
    function isprice(str, obj) {
        var result = str.match(/(^[1-9]\d*(\.\d{1,2})?$)|(^0(\.\d{1,2})?$)/);
        if (obj == 1) {
            if (result == null) {
                $("#lbgoprice").attr("style", "color:red");
                $("#lbgoprice").html("请输入正确的进货价格式");
                return false;
            } else {
                $("#lbgoprice").attr("style", "color:red;display:none");
                $("#lbgoprice").html("");
            }
        } else {
            if (result == null) {
                $("#lbsaleprice").attr("style", "color:red");
                $("#lbsaleprice").html("请输入正确的销售价格式");
                return false;
            } else {
                $("#lbsaleprice").attr("style", "color:red;display:none");
                $("#lbsaleprice").html("");
            }
        }
    }

    function check() {
        var categ_id = $("#ddlproduct_category_id").val();
        if (categ_id == null || categ_id == '') {
            alert("商品类别不能为空");
            return false;
        }
        var pro_name = $("#txtproduct_name").val();
        if (pro_name == null || pro_name == '') {
            alert("商品名称不能为空");
            return false;
        }
        var sale_price = $("#txtsalse_price").val();
        if (sale_price == null || sale_price == '') {
            alert("销售价不能为空");
            return false;
        }
        var txtdw = $("#txtdw").val();
        if (txtdw == null || txtdw == '') {
            alert("进货单位不能为空");
            return false;
        }

        var go_price = $("#txtgo_price").val();
        if (go_price == null || go_price == '') {
            alert("进价不能为空");
            return false;
        }
        var ddlprov = $("#ddlprov").val();
        if (ddlprov == null || ddlprov == '') {
            alert("商品产地不能为空");
            return false;
        }
        //        var ddlcity = $("#ddlcity").val();
        //        if (ddlcity == null || ddlcity == '') {
        //            alert("城市不能为空");
        //            return false;
        //        }
        //        var ddlarea = $("#ddlarea").val();
        //        if (ddlarea == null || ddlarea == '') {
        //            alert("区县不能为空");
        //            return false;
        //        }
        var result = go_price.match(/(^[1-9]\d*(\.\d{1,2})?$)|(^0(\.\d{1,2})?$)/);

        if (result == null) {
            $("#lbgoprice").attr("style", "color:red");
            $("#lbgoprice").html("请输入正确的进货价格式");
            return false;
        } else {
            $("#lbgoprice").attr("style", "color:red;display:none");
            $("#lbgoprice").html("");
        }
        var result1 = sale_price.match(/(^[1-9]\d*(\.\d{1,2})?$)|(^0(\.\d{1,2})?$)/);
        if (result1 == null) {
            $("#lbsaleprice").attr("style", "color:red");
            $("#lbsaleprice").html("请输入正确的销售价格式");
            return false;
        } else {
            $("#lbsaleprice").attr("style", "color:red;display:none");
            $("#lbsaleprice").html("");
        }

    }
</script>
