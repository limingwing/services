<%@ Page Language="C#" AutoEventWireup="true" CodeFile="wlt_Two_lines.aspx.cs" Inherits="manager_member_wlt_Two_lines" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<title>网络图</title>
<link href="../../css/style.css" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="../../js/jquery/jquery-1.10.2.min.js"></script>
<script type="text/javascript" src="../../js/lhgdialog/lhgdialog.js?skin=idialog"></script>
<script type="text/javascript" src="../../js/jquery/Validform_v5.3.2_min.js"></script>
<script type="text/javascript" src="../../js/datepicker/WdatePicker.js"></script>
<script type="text/javascript" src="../../js/layout.js"></script>
<script type="text/javascript" src="../../js/pinyin.js"></script>
<script type="text/javascript" charset="utf-8" src="../../editor/kindeditor-min.js"></script>
<script type="text/javascript" charset="utf-8" src="../../editor/lang/zh_CN.js"></script>
<script type="text/javascript">
    $(function () {
        //初始化表单验证
        $("#form1").initValidform();
        //初始化编辑器
        var editor = KindEditor.create('#txtContent', {
            width: '80%',
            height: '350px',
            resizeType: 1,
            uploadJson: '../../tools/upload_ajax.ashx?action=EditorFile&IsWater=1',
            fileManagerJson: '../../tools/upload_ajax.ashx?action=ManagerFile',
            allowFileManager: true
        });

    });
  
</script>
<script type="text/javascript" src="../../js/layout.js"></script>
    <style type="text/css">
        .style1
        {
            height: 31px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
	<div class="place">
    <span>位置：</span>
    <ul class="placeul">
    <li><a href="../index.aspx">首页</a></li>
    <li><a href="wlt_Two_lines.aspx">网络图</a></li>
    <li><a href="#">网络图</a></li>
    </ul>
    </div>
    
        <div class="formbody">   
    <div class="formtitle"><span>网络图</span></div>
    <!--/公告信息-->
    <dl class="seachform">
       <dd><label>会员编号</label><span class="single-select"><asp:TextBox ID="txtKeywords" runat="server" CssClass="scinput" Width="300"></asp:TextBox></span></dd>
       <dd class="cx"><asp:Button ID="imbnQuery" runat="server" CssClass="scbtn" onclick="imbnQuery_Click" Text="查询"></asp:Button></dd>
    </dl>
<div class="tab-content">
  
  <table style="text-align:center; width:100%;" cellpadding=0 cellspacing=0  >
            <!--level_1 statrt-->
            <tr>


            <td colspan=5 id="table_leval_1" runat="server">
            </td>
            </tr>
            <tr>
                <td colspan=5 align="center" class="style1">
                    <div style="border-bottom:1px #006600 solid; height:30px; width:50%; margin-right:5px;">
                        <table style="width:5px; border-left:1px #006600 solid; height:100%; margin-left:5px;">
                        <tr>
                        <td></td>
                        </tr>
                        </table>
                    </div>
                </td>
            </tr>
            <tr>
                <td colspan=2 align="center" height=15 valign=top>
                        <table style="width:5px; border-left:1px #006600 solid; height:100%   " cellpadding=0 cellspacing=0>
                        <tr>
                        <td></td>
                        </tr>
                        </table>
                </td>
                <td colspan=3 align="center" height=15>
                        <table style="width:8px; border-left:1px #006600 solid; height:100%" cellpadding=0 cellspacing=0>
                        <tr>
                        <td></td>
                        </tr>
                        </table>
                </td>
               <%-- <td colspan=3 align="center" height=15>
                        <table style="width:5px; border-left:1px #006600 solid; height:100%" cellpadding=0 cellspacing=0>
                        <tr>
                        <td></td>
                        </tr>
                        </table>
                
                </td>--%>
                
            </tr>
            
            <!--level_1 end -->
            <tr>
            <span id="table_leval_2" runat="server"></span>
            </tr>


            <tr>
                <td colspan=2 align="center" height=30 valign=top>
                    <div style="border-bottom:1px #006600 solid; height:30px; width:50%;">
                        <table style="width:5px; border-left:1px #006600 solid; height:100%" cellpadding=0 cellspacing=0>
                        <tr>
                        <td></td>
                        </tr>
                        </table>
                    </div>
                </td>
                <td colspan=3 align="center" height=30>
                    <div style="border-bottom:1px #006600 solid; height:30px; width:50%;">
                        <table style="width:8px; border-left:1px #006600 solid; height:100%" cellpadding=0 cellspacing=0>
                        <tr>
                        <td></td>
                        </tr>
                        </table>
                        </div>
                </td>
               <%-- <td colspan=3 align="center" height=30>
                    <div style="border-bottom:1px #006600 solid; height:30px; width:70%;">
                        <table style="width:5px; border-left:1px #006600 solid; height:100%" cellpadding=0 cellspacing=0>
                        <tr>
                        <td></td>
                        </tr>
                        </table>
                        </div>
                
                </td>--%>
                
            </tr>
            
            <tr>
                <td align="center" height=15 valign=top>
                        <table style="width:8px; border-left:1px #006600 solid; height:100%" cellpadding=0 cellspacing=0>
                        <tr>
                        <td></td>
                        </tr>
                        </table>
                </td>
                <td align="center" height=15>
                        <table style="width:5px; border-left:1px #006600 solid; height:100%" cellpadding=0 cellspacing=0>
                        <tr>
                        <td></td>
                        </tr>
                        </table>
                </td>
                <td align="center" height=15>
                        <table style="width:0px; border-left:1px #006600 solid; height:100%; margin-left:7px;" cellpadding=0 cellspacing=0>
                        <tr>
                        <td></td>
                        </tr>
                        </table>
                
                </td>
                
                <td align="center" height=15 valign=top>
                        <table style="width:7px; border-left:1px #006600 solid; height:100%" cellpadding=0 cellspacing=0>
                        <tr>
                        <td></td>
                        </tr>
                        </table>
                </td>
               
                
                
            </tr>
            
            <!--level_3 end -->
            <tr>
            <span id="table_leval_3" runat="server"></span>
            </tr>
            
            
            
            </table>

 
</div>
<!--/公告信息-->
    
    </div>

 


    </form>
</body>
</html>
