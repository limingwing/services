<%@ Page Language="C#" AutoEventWireup="true" CodeFile="addTimeKill.aspx.cs" Inherits="manager_product_addTimeKill" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
   <title>编辑 限时秒杀</title>
        <script type="text/javascript" src="../../js/lhgcore.min.js"></script>
    <script type="text/javascript" src="../../js/lhgcalendar.min.js"></script>
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
 <script type="text/javascript">
     J(function () {
         J('#txtstart_time').calendar({ btnBar: true });
         J('#txt_time1').calendar({ format: 'yyyy-MM-d HH:mm:ss' });
         J('#txt_time2').calendar({ format: 'yyyy-MM-d HH:mm:ss' });

     });
    </script>
</head>
<body>
    <form id="form1" runat="server">
	<div class="place">
    <span>位置：</span>
    <ul class="placeul">
    <li><a href="#">首页</a></li>
    <li><a href="timelist.aspx"> 限时秒杀</a></li>
    <li><a href="#">编辑 限时秒杀</a></li>
    </ul>
    </div>

    <div class="formbody">   
    <div class="formtitle"><span> 限时秒杀</span></div>
    <!--/ 类别管理-->
<div class="tab-content">

<dl>
    <dt>开始时间</dt>
    <dd><input type="text" class="input normal" id="txt_time1" name="txt_time1" readonly="readonly" runat="server" style="width: 150px" /><span class="Validform_checktip">*</span></dd>
  </dl> 
  <dl>
    <dt>结束时间</dt>
    <dd><input type="text" class="input normal" id="txt_time2" name="txt_time2" readonly="readonly" runat="server" style="width: 150px" /><span class="Validform_checktip">*</span></dd>
  </dl> 
  <dl>
    <dt>促销名称</dt>
    <dd><asp:TextBox ID="txttitle" runat="server" CssClass="input normal" datatype="*"  sucmsg=" " ></asp:TextBox> <span class="Validform_checktip">*</span></dd>
  </dl> 
  <dl>
    <dt>限购数量</dt>
    <dd><input type="text" class="input normal" id="text_num" name="text_num" runat="server" style="width: 150px" /><span class="Validform_checktip">*</span></dd>
  </dl> 
    <dl>
    <dt>请选择商品</dt>
    <dd> <span class="rule-single-select">
             <asp:DropDownList id="pid" runat="server"></asp:DropDownList>  
          </span>
           
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
