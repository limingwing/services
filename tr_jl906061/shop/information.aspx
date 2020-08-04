<%@ Page Language="C#" AutoEventWireup="true" CodeFile="information.aspx.cs" Inherits="shop_information" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register Src="Navigation.ascx" TagName="Navigation" TagPrefix="uc1" %>
<%@ Register Src="index_top.ascx" TagName="index_top" TagPrefix="uc1" %>
<%@ Register Src="footer.ascx" TagName="footer" TagPrefix="uc1" %>
<%@ Register Src="mob_sub.ascx" TagName="mob_sub" TagPrefix="uc1" %>
<%@ Register Src="left.ascx" TagName="left" TagPrefix="uc1" %>
<%@ Register Src="member_search.ascx" TagName="member_search" TagPrefix="uc1" %>
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0,maximum-scale=1.0, user-scalable=0">
    <title>会员资料</title>
    <link href="AmazeUI-2.4.2/assets/css/admin.css" rel="stylesheet" type="text/css">
    <link href="AmazeUI-2.4.2/assets/css/amazeui.css" rel="stylesheet" type="text/css">
    <script type="text/javascript" src="../../js/jquery/jquery-1.10.2.min.js"></script>
    <script type="text/javascript" src="../../js/lhgdialog/lhgdialog.js?skin=idialog"></script>
    <script type="text/javascript" src="../../js/jquery/Validform_v5.3.2_min.js"></script>
    <script type="text/javascript" src="../../js/layout.js"></script>
    <script type="text/javascript" src="../../js/pinyin.js"></script>
    <link href="css/personal.css" rel="stylesheet" type="text/css">
    <link href="css/infstyle.css" rel="stylesheet" type="text/css">
    <script src="AmazeUI-2.4.2/assets/js/jquery.min.js" type="text/javascript"></script>
    <script src="AmazeUI-2.4.2/assets/js/amazeui.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(function () {
            //初始化表单验证
            $("#form1").initValidform();
        });
    </script>
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
                <div class="user-info">
                    <!--标题 -->
                    <div class="am-cf am-padding">
                        <div class="am-fl am-cf">
                            <strong class="am-text-danger am-text-lg">会员资料</strong> / <small>Partners&nbsp;information</small></div>
                    </div>
                    <hr />
                    <!--头像 -->
                    <div class="user-infoPic">
                        <div class="filePic">
                           <%-- <input type="text" class="inputPic" allowexts="gif,jpeg,jpg,png,bmp" accept="image/*">--%>
                            <img class="am-circle am-img-thumbnail" src="images/getAvatar.do.jpg" alt="" />
                        </div>
                        <p class="am-form-help">
                            头像</p>
                        <div class="info-m">
                            <div>
                                <b>用户名：<i><asp:Label runat="server" ID="username" Text=""></asp:Label></i></b></div>
                            <div class="u-level">
                                <span class="rank r2"><s class="vip1"></s>
                                    <asp:Label runat="server" ID="jibie" Text=""></asp:Label>
                                </span>
                            </div>
                            <div class="u-safety">
                                <%--<a href="safety.html">
									 账户安全
									<span class="u-profile"><i class="bc_ee0000" style="width: 60px;" width="0">60分</i></span>
									</a>--%>
                            </div>
                        </div>
                    </div>
                    <!--个人信息 -->
                    <div class="info-main">
                        <div class="am-form am-form-horizontal">
                            <div class="am-form-group">
                                <label for="user-name2" class="am-form-label">
                                    编号</label>
                                   
                                <div class="am-form-content">
                                    <input runat="server" type="text" name="user_bianhao" id="user_bianhao" placeholder="nickname" />
                                </div>
                            </div>
                            <div class="am-form-group">
                                <label for="user-name" class="am-form-label">
                                    姓名</label>
                                <div class="am-form-content">
                                    <input name="user_name" runat="server" type="text" id="user_name" placeholder="name" />
                                </div>
                            </div>
                            <%--<div class="am-form-group">
                                <label for="user-phone" class="am-form-label">
                                    电话</label>
                                <div class="am-form-content">
                                    <input name="user_phone" readonly runat="server" id="user_phone" placeholder="电话"
                                        type="text" />
                                </div>
                            </div>--%>
                        <%--    <div class="am-form-group">
                                <label for="user-email" class="am-form-label">
                                    电子邮件</label>
                                <div class="am-form-content">
                                    <input name="user_email" runat="server" id="user_email" placeholder="电子邮件" type="text" />
                                </div>
                            </div>
                            <div class="am-form-group">
                                <label for="user-safety" class="am-form-label">
                                    期权数量</label>
                                <div class="am-form-content">
                                    <input name="qiquan_txt" runat="server" id="qiquan_txt" placeholder="请填写期权数量" type="text" />
                                </div>
                            </div>--%>
                           <div class="am-form-group" id="div1" runat="server">
                                <label for="user-email" class="am-form-label">
                                    推荐人</label>
                                <div class="am-form-content">
                                    <input runat="server" type="text" name="" id="bas_tuijian" placeholder="推荐人编号" />
                                </div>
                            </div>
                               <%--<div class="am-form-group" id="div4" runat="server">
                                <label for="user-email" class="am-form-label">
                                    请选择</label>
                                <div class="am-form-content">
                                    <asp:DropDownList ID="zuoyou" runat="server">
                                        <asp:ListItem Value="1" Selected="True">左区</asp:ListItem>
                                        <asp:ListItem Value="2">右区</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                            </div>
                            <div class="am-form-group" id="div3" runat="server">
                                <label for="user-email" class="am-form-label">
                                    接点人</label>
                                <div class="am-form-content">
                                    <input runat="server" type="text" name="" id="huiyuan_jiedian" placeholder="接点人编号" />
                                </div>
                            </div>
                          <div class="am-form-group" id="div4" runat="server">
                                <label for="user-email" class="am-form-label">
                                    报单中心</label>
                                <div class="am-form-content">
                                    <input runat="server" type="text" name="" id="huiyuan_zm" placeholder="报单中心编号" />
                                </div>
                            </div>--%>
                           <%-- <div class="am-form-group">
                                <label for="user-email" class="am-form-label">
                                    微信号</label>
                                <div class="am-form-content">
                                    <input runat="server" type="text" name="" id="weixin" placeholder="请输入微信号" />
                                </div>
                            </div>
                            <div class="am-form-group">
                                <label for="user-email" class="am-form-label">
                                    身份证号</label>
                                <div class="am-form-content">
                                    <input runat="server" type="text" name="" id="shenfenidcard" placeholder="请输入身份证号" />
                                </div>
                            </div>--%>
                              <%--<div class="am-form-group" id="div2" runat="server">
                            <label for="user-email" class="am-form-label" >
                                会员级别</label>
                            <div class="am-form-content">
                                <span class="rule-single-select">
                                    <asp:DropDownList ID="huiyuan_jiebie" runat="server">
                                    </asp:DropDownList>
                                </span>
                            </div>
                        </div>--%>
                           <%-- <div class="am-form-group">
                                <label for="user-email" class="am-form-label">
                                    出生日期</label>
                                <div class="am-form-content">
                                    <input runat="server" type="text" name="" id="born" placeholder="请输入出生日期" />
                                </div>
                            </div>--%>
                            <%--<asp:ScriptManager ID="ProvinceContect" runat="server">
                            </asp:ScriptManager>
                            <asp:UpdatePanel ID="UpdatePanel" runat="server">
                                <ContentTemplate>
                                    <div class="am-form-group address" style="display: block!important">
                                        <label for="user-address" class="am-form-label">
                                            收货地址</label>
                                        <div class="am-form-content">
                                            <asp:DropDownList ID="bind_Province" runat="server" AutoPostBack="True" OnSelectedIndexChanged="bind_Province_SelectedIndexChanged">
                                            </asp:DropDownList>
                                        </div>
                                    </div>
                                    <div class="am-form-group address" style="display: block!important">
                                        <label for="user-address" class="am-form-label">
                                            选择市</label>
                                        <div class="am-form-content">
                                            <asp:DropDownList ID="bind_City" runat="server" AutoPostBack="True" OnSelectedIndexChanged="bind_City_SelectedIndexChanged">
                                            </asp:DropDownList>
                                        </div>
                                    </div>
                                    <div class="am-form-group address" style="display: block!important">
                                        <label for="user-address" class="am-form-label">
                                            选择县
                                        </label>
                                        <div class="am-form-content">
                                            <asp:DropDownList ID="bind_Borough" runat="server">
                                            </asp:DropDownList>
                                        </div>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </div>--%>
                        <div class="am-form-group address" style="display: block!important">
                            <label for="user-address" class="am-form-label">
                                详细地址</label>
                            <div class="am-form-content">
                                <input name="address" runat="server" id="address" placeholder="收货地址" type="text" />
                            </div>
                        </div>
                     <%--<div class="am-form-group">
                            <label for="user-email" class="am-form-label">
                                开户银行</label>
                            <div class="am-form-content">
                                <span class="rule-single-select">
                                    <asp:DropDownList ID="bas_bankaddress" runat="server">
                                    </asp:DropDownList>
                                </span>
                            </div>
                        </div>
                        <div class="am-form-group">
                            <label for="user-email" class="am-form-label">
                                银行账号</label>
                            <div class="am-form-content">
                                <input name="bas_bankaddress1" runat="server" id="bas_bankaddress1" placeholder="银行账号"
                                    type="text" />
                            </div>
                        </div>
                        <div class="am-form-group">
                            <label for="user-phone" class="am-form-label">
                                开户姓名</label>
                            <div class="am-form-content">
                                <input name="zhanghuming" runat="server" id="zhanghuming" placeholder="开户姓名" type="text" />
                            </div>
                        </div>
                        <div class="am-form-group">
                            <label for="user-phone" class="am-form-label">
                                银行支行</label>
                            <div class="am-form-content">
                                <input name="bank_zhi" runat="server" id="bank_zhi" placeholder="银行支行" type="text" />
                            </div>
                        </div>--%>
                        <%--<div class="am-form-group" id="div5" runat="server">
                            <label for="user-safety" class="am-form-label" style="color: orangered">
                                *身份证照</label>
                            <div class="am-form-content">
                                <asp:FileUpload ID="shenfen_img" runat="server" class="form-control" />
                            </div>
                        </div>
                        <div class="am-form-group" id="div6" runat="server">
                            <label for="user-safety" class="am-form-label" style="color: orangered">
                                *期权证照</label>
                            <div class="am-form-content">
                                <asp:FileUpload ID="zl_img" runat="server" class="form-control" />
                            </div>
                        </div>
                        <asp:Repeater ID="rptList" runat="server">
                            <HeaderTemplate>
                                <table class="tablelist">
                                    <thead>
                                        <tr>
                                            <th style="border: 1px solid #666;" width="25%">
                                                商品图片
                                            </th>
                                            <th style="border: 1px solid #666;" width="25%">
                                                商品名称
                                            </th>
                                            <th style="border: 1px solid #666;" width="25%">
                                                销售单价
                                            </th>
                                            <th style="border: 1px solid #666;" width="25%">
                                                选择数量
                                            </th>
                                        </tr>
                                    </thead>
                                    <tbody>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <tr>
                                    <td class="imgtd" style="border: 1px solid #666;">
                                        <img src="<%# Eval("pro_imgs")%>" width="80" height="80" />
                                    </td>
                                    <td style="border: 1px solid #666; vertical-align: middle;">
                                        <%# Eval("pro_name")%><asp:HiddenField ID="hidId" Value='<%#Eval("pro_id")%>' runat="server" />
                                    </td>
                                    <td style="border: 1px solid #666; vertical-align: middle;">
                                        <asp:Label ID="Label2" runat="server" Text='<%# Eval("salse_price")%>'></asp:Label>
                                    </td>
                                    <td class="imgtd" style="border: 1px solid #666; vertical-align: middle;">
                                        <asp:TextBox ID="shuliang" runat="server" CssClass="input small" MaxLength="15" sucmsg=""
                                            Text="0"></asp:TextBox>
                                    </td>
                                </tr>
                            </ItemTemplate>
                            <FooterTemplate>
                                <%#rptList.Items.Count == 0 ? "<tr><td align=\"center\" colspan=\"10\"><font color=red><font color=red>暂无记录</font></font></td></tr>" : ""%>
                                </tbody> </table>
                            </FooterTemplate>
                        </asp:Repeater>--%>
                        <br />
                        <div class="info-btn">
                            <div class="am-btn am-btn-danger">
                                <asp:Button ID="btnSubmit" runat="server" Text="保存修改" OnClick="btnSubmit_Click" class="am-btn am-btn-danger" /></div>
                                <div class="am-btn am-btn-danger"><a href="member_center.aspx"><input type="button" value="返回" class="am-btn am-btn-danger"  /></a>
                                   </div>
                        </div>
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
