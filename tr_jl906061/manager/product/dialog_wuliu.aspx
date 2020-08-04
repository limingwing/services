<%@ Page Language="C#" AutoEventWireup="true" CodeFile="dialog_wuliu.aspx.cs" Inherits="manager_product_dialog_wuliu" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<title>修改物流窗口</title>
<script type="text/javascript" src="../../js/jquery/jquery-1.10.2.min.js"></script>
<script type="text/javascript" src="../../js/lhgdialog/lhgdialog.js?skin=idialog"></script>
<script type="text/javascript" src="../../js/jquery/PCASClass.js"></script>
<script type="text/javascript" src="../../js/layout.js"></script>
<link href="../../css/style.css" rel="stylesheet" type="text/css" />
<script type="text/javascript">
    //窗口API
    var api = frameElement.api, W = api.opener;
    api.button({
        name: '确定',
        focus: true,
        callback: function () {
            submitForm();
            return false;
        }
    }, {
        name: '取消'
    });

    //页面加载完成执行
    $(function () {
        //初始化省市区
        //        var areaArr = $("#spanArea", W.document).text().split(",");
        //        if (areaArr.length == 3) {
        //            new PCAS("txtProvince", "txtCity", "txtArea", areaArr[0], areaArr[1], areaArr[2]);
        //        } else {
        //            new PCAS("txtProvince", "txtCity", "txtArea");
        //        }
        $("#wuliu_company1").val($("#wuliu_company1", W.document).text());
        $("#wuliu_no1").val($("#wuliu_no1", W.document).text());
        //        $("#txtPostCode").val($("#spanPostCode", W.document).text());
       

    });

    //提交表单处理
    function submitForm() {
        //验证表单
        if ($("#wuliu_company1").val() == "") {
            W.$.dialog.alert('请填写物流公司！', function () { $("#wuliu_company1").focus(); }, api);
            return false;
        }
        //        if ($("#txtArea").val() == "") {
        //            W.$.dialog.alert('请选择所在地区！', function () { $("#txtProvince").focus(); }, api);
        //            return false;
        //        }
        if ($("#wuliu_no1").val() == "") {
            W.$.dialog.alert('请填写快递单号！', function () { $("#wuliu_no1").focus(); }, api);
            return false;
        }
       
        //下一步，AJAX提交表单
        var postData = {
            "order_no": $("#spanOrderNo", W.document).text(), "edit_type": "edit_accept_wuliu",
            "wuliu_company1": $("#wuliu_company1").val(), "wuliu_no1": $("#wuliu_no1").val()
        };
        //发送AJAX请求

        W.sendAjaxUrl(api, postData, "../../tools/admin_ajax.ashx?action=edit_order_status");
        return false;
    }
</script>
</head>

<body>
<div class="div-content">
    <dl>
      <dt>配送物流公司</dt>
      <dd>
      
      
      <input type="text" id="wuliu_company1" class="input txt" runat=server /> <span class="Validform_checktip">*</span></dd>
    </dl>
  
    <dl>
      <dt>配送单号</dt>
      <dd><input type="text" id="wuliu_no1" class="input normal" runat=server/> <span class="Validform_checktip">*</span></dd>
    </dl>
    
    
   
    <%--<dl>
      <dt>联系电话</dt>
      <dd><input type="text" id="txtTelphone" class="input txt" /></dd>
    </dl>--%>
</div>
</body>
</html>
