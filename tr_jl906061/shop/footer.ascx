<%@ Control Language="C#" AutoEventWireup="true" CodeFile="footer.ascx.cs" Inherits="shop_footer" %>
	<div class="footer ">
						<div class="footer-hd ">
							<p>

                              <asp:Repeater ID="Repeater3" runat="server"   >
                                                                        <ItemTemplate>
								<a href="<%# Eval("help1_url")%>" target="_blank"><%# Eval("help1")%></a>
								<b>|</b>
                                  </ItemTemplate>
                                 </asp:Repeater>  


								 
							</p>
						</div>
						<div class="footer-bd ">
							<p>
						       <%-- <a href="# ">关于恒望</a>
								<a href="# ">合作伙伴</a>
								<a href="# ">联系我们</a>
								<a href="# ">网站地图</a>--%>
								<em><%=copy_right%></em>
							</p>
						</div>
					</div>