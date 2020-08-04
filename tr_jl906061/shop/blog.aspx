<%@ Page Language="C#" AutoEventWireup="true" CodeFile="blog.aspx.cs" Inherits="shop_blog" %>
<%@ Register Src="Navigation.ascx" TagName="Navigation" TagPrefix="uc1" %>
<%@ Register Src="index_top.ascx" TagName="index_top" TagPrefix="uc1" %>  
<%@ Register Src="footer.ascx" TagName="footer" TagPrefix="uc1" %> 
<%@ Register Src="mob_sub.ascx" TagName="mob_sub" TagPrefix="uc1" %> 
<%@ Register Src="left.ascx" TagName="left" TagPrefix="uc1" %>
<%@ Register Src="member_search.ascx" TagName="member_search" TagPrefix="uc1" %> 

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8">
  <title>新闻页面</title>
  <meta http-equiv="X-UA-Compatible" content="IE=edge">
  <meta name="viewport" content="width=device-width, initial-scale=1.0, minimum-scale=1.0, maximum-scale=1.0, user-scalable=no">
  <meta name="format-detection" content="telephone=no">
  <meta name="renderer" content="webkit">
  <meta http-equiv="Cache-Control" content="no-siteapp"/>
  
   <link href="AmazeUI-2.4.2/assets/css/admin.css" rel="stylesheet" type="text/css">
   <link href="AmazeUI-2.4.2/assets/css/amazeui.css" rel="stylesheet" type="text/css">
   <link href="css/personal.css" rel="stylesheet" type="text/css">
</head>
<body>
<form id="Form1" runat="server">

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
					   <div class="long-title"><span class="all-goods">全部分类</span></div>
					   	  <uc1:Navigation ID="Navigation" runat="server" />		<!--导航栏-->
			</div>
            <b class="line"></b>
    <div class="am-g am-g-fixed blog-g-fixed bloglist">
  <div class="am-u-md-9">
    <article class="blog-main">
      <h3 class="am-article-title blog-title">
        <a href="#"><asp:Label ID="new_title" runat="server" Text=""></asp:Label></a>
      </h3>
      <h4 class="am-article-meta blog-meta"><asp:Label ID="news_date" runat="server" Text=""></asp:Label></h4>

      <div class="am-g blog-content">
        <div class="am-u-sm-12">
          <asp:Label ID="memo" runat="server" Text=""></asp:Label>
        </div>
  
      </div>

    </article>


    <hr class="am-article-divider blog-hr">
   <%-- <ul class="am-pagination blog-pagination">
      <li class="am-pagination-prev"><a href="">&laquo;上一页</a></li>
      <li class="am-pagination-next"><a href="">下一页 &raquo;</a></li>
    </ul>--%>
  </div>

  <div class="am-u-md-3 blog-sidebar">
    <div class="am-panel-group">

      <section class="am-panel am-panel-default">
      
       
        <div class="am-panel-hd">热门话题</div>
         <asp:Repeater ID="news" runat="server"   >
                                    <ItemTemplate>
        <ul class="am-list blog-list">
        	<li><a href="blog.aspx?id=<%# Eval("id")%>"><p><%# Eval("title")%></p></a></li>  
            
        </ul>
         </ItemTemplate>
          </asp:Repeater>  
      </section>

    </div>
  </div>

</div>
</form>
</body>
</html>
