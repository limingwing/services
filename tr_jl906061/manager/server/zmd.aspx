<%@ Page Language="C#" AutoEventWireup="true" CodeFile="zmd.aspx.cs" Inherits="manager_server_zmd" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
   <title>编辑服务中心</title>
<script type="text/javascript" src="../../js/jquery/jquery-1.10.2.min.js"></script>
<script type="text/javascript" src="../../js/lhgdialog/lhgdialog.js?skin=idialog"></script>
<script type="text/javascript" src="../../js/jquery/Validform_v5.3.2_min.js"></script>
<script type="text/javascript" src="../../js/layout.js"></script>
<script type="text/javascript" src="../../js/pinyin.js"></script>
<link href="../../css/style.css" rel="stylesheet" type="text/css" />
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
    <li><a href="#">首页</a></li>
    <li><a href="Service_Centre_un.aspx">服务中心管理</a></li>
    <li><a href="#">编辑服务中心</a></li>
    </ul>
    </div>

    <div class="formbody">   
    <div class="formtitle"><span> 服务中心管理</span></div>
    <!--/ 服务中心管理-->
<div class="tab-content">

  <dl>
    <dt> 会员编号</dt>
    <dd><asp:TextBox ID="txttitle" runat="server" CssClass="input normal" datatype="*1-100" sucmsg=" " ajaxurl="../../tools/admin_ajax.ashx?action=jsr_validate"></asp:TextBox> <span class="Validform_checktip">*</span></dd>
  </dl> 
  <dl>
    <dt>服务中心级别</dt>
        <dd><span class="rule-single-select">
            <asp:DropDownList ID="jb" runat="server" datatype="*" errormsg="请选择区域" sucmsg=" ">
                <asp:ListItem Value=1 Selected="True">服务中心</asp:ListItem>
              <%--<asp:ListItem Value=2  >2级报单中心</asp:ListItem>
                   <asp:ListItem Value=3  >3级报单中心</asp:ListItem> 
                    <asp:ListItem Value=4  >4级报单中心</asp:ListItem> --%>
             </asp:DropDownList>
          </span>
          <span class="Validform_checktip">*</span>
          </dd>
  </dl>
   
    
    

</div>
<!--/ 商品类别信息-->
    
    </div>

    <!--工具栏-->
<div class="page-footer">
  <div class="btn-list">
    <asp:Button ID="btnSubmit" runat="server" Text="提交保存" CssClass="btn" onclick="btnSubmit_Click"  />
    <input name="btnReturn" type="button" value="返回上一页" class="btn yellow" onclick="javascript:history.back(-1);" />
  </div>
  <div class="clear"></div>
</div>
<!--/工具栏-->

    </form>
</body>
</html>
