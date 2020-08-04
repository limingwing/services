<%@ Page Language="C#" AutoEventWireup="true" CodeFile="gp_shezhi.aspx.cs" Inherits="manager_system_gp_shezhi" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
   <title>编辑分享积分</title>
   <link href="../../css/style.css" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="../../js/jquery/jquery-1.10.2.min.js"></script>
<script type="text/javascript" src="../../js/lhgdialog/lhgdialog.js?skin=idialog"></script>
<script type="text/javascript" src="../../js/jquery/Validform_v5.3.2_min.js"></script>
 
<script type="text/javascript" src="../../js/layout.js"></script>
<script type="text/javascript" src="../../js/pinyin.js"></script>

<script type="text/javascript">
    $(function () {
        //初始化表单验证
        $("#form1").initValidform();
    });
</script>
</head>
<body>
    <form id="form1" runat="server">
	<div class="place">
    <span>位置：</span>
    <ul class="placeul">
    <li><a href="../index.aspx">首页</a></li>
    <li><a href="Deve_options.aspx">分享积分管理</a></li>
   
    </ul>
    </div>

    <div class="formbody">   
    <div class="formtitle"><span>分享积分价格设置 </span></div>

     <div class="tab-content">
  <dl >
    <dt>分享积分价格设置</dt>
    <dd>
       <asp:TextBox ID="TextBox1" runat="server"  MaxLength="20" CssClass="input normal"   errormsg=""  Width="150"></asp:TextBox>￥/股
      
    </dd>
  </dl>
 
  
   
  <dl style="width:100%;margin:0;padding:0;text-align:center;}">

  <asp:Button ID="btnSubmit" runat="server" Text="提交保存" CssClass="btn" onclick="btnSubmit_Click"  />
    <input name="btnReturn" type="button" value="返回上一页" class="btn yellow" onclick="javascript:history.back(-1);" />
  </dl>
      <!--工具栏-->
<div class="page-footer">
  <div class="btn-list">
    
  </div>
  <div class="clear"></div>
</div>
 
</div>
<!--/商家信息-->    
    </div>


    <!--/工具栏-->
 <div class="rightinfo">    
    <div class="tools">  
    	<%--<ul class="toolbar">
        <a href="Deve_jiebie_edit.aspx?action=Add"><li><span><img src="../../images/t01.png" /></span>添加级别</li></a>
        </ul>--%>
        <ul class="toolbar1">
       <asp:LinkButton ID="btnSave" runat="server" CssClass="save" onclick="btnSave_Click"> <li><span><img src="../../images/t05.png" /></span>保存排序</li></asp:LinkButton>
        </ul>    
    </div>  
 
    <!--列表-->
<asp:Repeater ID="rptList" runat="server">
<HeaderTemplate>
    <table class="tablelist">
    	<thead>
    	<tr>
        <th width="10%">序号</th>
       
       
        <th width="10%">分享积分历史价格</th>  
        <th width="10%">添加时间</th>
        
        </tr>
        </thead>
   <tbody>
</HeaderTemplate>
<ItemTemplate> 
        <tr>
		<td><%# pageSize * page + Container.ItemIndex + 1 - pageSize%><asp:HiddenField ID="hidId" Value='<%#Eval("id")%>' runat="server" /></td>	
        <td><%# Eval("gp_price")%></td>
        <td><%# Eval("gp_add_date")%></td>
    
       
 
		 
        </tr> 
     </ItemTemplate>
<FooterTemplate>
  <%#rptList.Items.Count == 0 ? "<tr><td align=\"center\" colspan=\"11\"><font color=red>暂无记录</font></td></tr>" : ""%>
   </tbody>
    </table>
</FooterTemplate>
</asp:Repeater>  

<div class="pagelist">
  <div class="l-btns">
    <span>显示</span><asp:TextBox ID="txtPageNum" runat="server" CssClass="pagenum" onkeydown="return checkNumber(event);" ontextchanged="txtPageNum_TextChanged" AutoPostBack="True"></asp:TextBox><span>条/页</span>
  </div>
  <div id="PageContent" runat="server" class="default"></div>
</div>

    
    </div>
    <script type="text/javascript">
        $('.tablelist tbody tr:odd').addClass('odd');
	</script>


    </form>



</body>
</html>
