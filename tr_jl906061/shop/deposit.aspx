<%@ Page Language="C#" AutoEventWireup="true" CodeFile="deposit.aspx.cs" Inherits="shop_deposit" %>

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
    <title>充值</title>
    <link href="AmazeUI-2.4.2/assets/css/admin.css" rel="stylesheet" type="text/css">
    <link href="AmazeUI-2.4.2/assets/css/amazeui.css" rel="stylesheet" type="text/css">
    <link href="css/personal.css" rel="stylesheet" type="text/css">
    <link href="css/stepstyle.css" rel="stylesheet" type="text/css">
    <script type="text/javascript" src="js/jquery-1.7.2.min.js"></script>
    <script src="AmazeUI-2.4.2/assets/js/amazeui.js"></script>
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
                        <strong class="am-text-danger am-text-lg">银行卡充值</strong> / <small>Debit card</small></div>
                </div>
                <hr />
                <div class="am-form am-form-horizontal">
                <TABLE width="100%" id="sample_2">
				<thead>
					<tr>
                        
						<th style="border:1px solid #666;">汇款开户行</th>
                        <th style="border:1px solid #666;">汇款开户名</th>
                        <th style="border:1px solid #666;" >汇款银行账号</th>
                        <th style="border:1px solid #666;">备注</th>
						
						
						
					 
						 
					</tr>
				</thead>

				<tbody style="border:1px solid #666; text-align:center;">
                <asp:Repeater ID="rptList" runat="server">
                <ItemTemplate> 
				    <tr>
                      <td style="border:1px solid #666;"><%# Eval("accountbank")%></td>
                      <td style="border:1px solid #666;"><%# Eval("accountname")%></td>
					  <td style="border:1px solid #666;"><%# Eval("accountno")%></td>
					  <td style="border:1px solid #666;"><%# Eval("beizhu")%></td>
					</tr>
	  </ItemTemplate>
<FooterTemplate>
  <%#rptList.Items.Count == 0 ? "<tr><td align=\"center\" colspan=\"9\"><font color=red>暂无记录</font></td></tr>" : ""%>				

					
			 
								</tbody>
     
			</table>
</FooterTemplate>
</asp:Repeater>
		

                </div>
                <div class="am-form am-form-horizontal">
                    <div class="am-form-group">
                        <label for="user-old-password" class="am-form-label">
                            充值类型</label>
                        <div class="am-form-content">
                           <asp:DropDownList ID="zz_type" runat="server" class="form-control"  >
                                                           <asp:ListItem Value=1 Selected="True">奖励积分</asp:ListItem> 
                                        
                                                           </asp:DropDownList>
                        </div>
                    </div>
                    <div class="am-form-group">
                        <label for="user-old-password" class="am-form-label">
                            充值金额</label>
                        <div class="am-form-content">
                            <input name="money" runat="server" type="text" id="money" placeholder="请输入充值金额" />
                        </div>
                    </div>
                    <div class="am-form-group">
                        <label for="user-old-password" class="am-form-label">
                            汇款银行</label>
                        <div class="am-form-content">
                            <input name="accountbank" runat="server" type="text" id="accountbank" placeholder="请输入银行" />
                        </div>
                    </div>
                    <div class="am-form-group">
                        <label for="user-old-password" class="am-form-label">
                            汇款银行账号</label>
                        <div class="am-form-content">
                            <input name="accountno" runat="server" type="text" id="accountno" placeholder="请输入银行账号" />
                        </div>
                    </div>
                    <div class="am-form-group">
                        <label for="user-old-password" class="am-form-label">
                            汇款人姓名</label>
                        <div class="am-form-content">
                            <input name="accountname" runat="server" type="text" id="accountname" placeholder="请输入姓名" />
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
                    <div class="am-form-group">
                        <label for="user-old-password" class="am-form-label">
                            备注</label>
                        <div class="am-form-content">
                            <input name="beizhu" runat="server" type="text" id="beizhu" placeholder="请输入充值金额" />
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