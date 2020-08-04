<%@ Page Language="C#" AutoEventWireup="true" CodeFile="chongxiao.aspx.cs" Inherits="shop_chongxiao" %>

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
    <title>分享积分产品</title>
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
                        <strong class="am-text-danger am-text-lg">分享积分产品</strong> / <small></small></div>
                </div>
                <hr />
                <div class="am-form am-form-horizontal">
                    <div class="am-form-group">
                        <label for="user-old-password" class="am-form-label">
                            分享积分</label>
                        <div class="am-form-content">
                            <asp:Literal ID="Literal1" runat="server"></asp:Literal>
                        </div>
                    </div>
                     <%--<div class="am-form-group">
                        <label for="user-old-password" class="am-form-label">
                            购物积分</label>
                        <div class="am-form-content">
                            <asp:Literal ID="Literal2" runat="server"></asp:Literal>
                        </div>
                    </div>
                   <div class="am-form-group">
                        <label for="user-old-password" class="am-form-label">
                            级别</label>
                        <div class="am-form-content">
                            <asp:DropDownList id="huiyuan_jiebie" runat="server" datatype="*" errormsg="请选择会员级别" sucmsg=" " ></asp:DropDownList>  
                        </div>
                    </div>
                    <div class="am-form-group">
                        <label for="user-old-password" class="am-form-label" >
                            输入消费积分</label>
                        <div class="am-form-content">
                             <input name="xiaofei" runat="server" type="text" id="xiaofei" placeholder="数量" />
                        </div>
                    </div>--%>
                    <div class="am-form-group">
                        <label for="user-old-password" class="am-form-label">
                            二级密码</label>
                        <div class="am-form-content">
                            <input name="pass_two" runat="server" type="password" id="pass_two" placeholder="支付密码" /><asp:RequiredFieldValidator
                                ID="RequiredFieldValidator1" runat="server" Display="Dynamic" ControlToValidate="pass_two"
                                ErrorMessage="支付密码不能为空"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <asp:Repeater ID="rptList" runat="server">
<HeaderTemplate>
     <table class="tablelist">
    	<thead>
    	<tr>
       
		<th style="border:1px solid #666;" width="150px">商品图片</th>
		<th style="border:1px solid #666;" width="150px">商品名称</th>
    
		<%-- <th style="border:1px solid #666;" width="150px">商品积分</th>--%>
         
		<th style="border:1px solid #666;"width="150px" >销售单价</th>
 
 
         <th style="border:1px solid #666;" width="150px">选择数量</th>
        </tr>
        </thead>
        <tbody style="border:1px solid #f1f1f1; text-align:center;">
	 </HeaderTemplate>
<ItemTemplate> 
        <tr >
        
              <td class="imgtd" style="border:1px solid #666;"><img src="<%# Eval("pro_imgs")%>" width="80" height="80"   /></td>
             <td style="border:1px solid #666; vertical-align: middle;"><%# Eval("pro_name")%><asp:HiddenField ID="hidId" Value='<%#Eval("pro_id")%>' runat="server" /></td>	
           
            <%-- <td style="border:1px solid #666; vertical-align: middle;">购物积分<asp:Label ID="Label1" runat="server" Text=<%# Eval("futou_fen")%>></asp:Label><br />购物积分<asp:Label ID="Label3" runat="server" Text=<%# Eval("shop_fen")%>></asp:Label></asp:Label></td>	      --%>
    
            <td style="border:1px solid #666;  vertical-align: middle;"> <asp:Label ID="Label2" runat="server" Text=<%# Eval("salse_price")%>></asp:Label> </td>		
      
         
            <td class="imgtd" style="border:1px solid #666; vertical-align: middle; ">  <asp:TextBox ID="shuliang" runat="server" CssClass="input small"    MaxLength="15"   sucmsg="" Text=0   ></asp:TextBox></td>
        </tr>      
	   </ItemTemplate>
<FooterTemplate>
  <%#rptList.Items.Count == 0 ? "<tr><td align=\"center\" colspan=\"10\"><font color=red><font color=red>暂无记录</font></font></td></tr>" : ""%>
   </tbody>
    </table>
</FooterTemplate>
</asp:Repeater>
<br />
                    <div class="info-btn">
                        <div class="am-btn am-btn-danger">
                            <asp:Button ID="btnSubmit" runat="server" Text="确认消费" class="am-btn am-btn-danger"
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
