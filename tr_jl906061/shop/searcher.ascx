<%@ Control Language="C#" AutoEventWireup="true" CodeFile="searcher.ascx.cs" Inherits="shop_searcher" %>
<div class="nav white">
					<div class="logo"><img src="<%=mob_img%>" /></div>
					<div class="logoBig">
						<li><img src="<%=big_img%>" /></li>
					</div>

					<div class="search-bar pr">
						<a name="index_none_header_sysc" href="#"></a>
						<li>
							<input id="searchInput" name="index_none_header_sysc" type="text" placeholder="搜索" autocomplete="off"  max-width:670px;">
 
							<input id="ai-topsearch" class="submit am-btn" value="搜索" index="1" type="button" onclick="sendMessage()"  >
						</li>
					</div>
				</div>

                <script type="text/javascript">
                    /*-------------------------------------------*/
                  
                    function sendMessage() {
                    
                        var searchInput = $("#searchInput").val(); //输入值  
                        
                        if (searchInput != "") {


                            window.location.href = "search.aspx?pro_name=" + searchInput; 
                        } else {
                            alert("请输入名称！");
                        }
                    }
                 
                    
</script>  