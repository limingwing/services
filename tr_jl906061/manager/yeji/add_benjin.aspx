<%@ Page Language="C#" AutoEventWireup="true" CodeFile="add_benjin.aspx.cs" Inherits="manager_yeji_add_benjin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
   <title>编辑商家</title>
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
    <li><a href="guanxi.aspx">追加虚拟本金</a></li>
   
    </ul>
    </div>

    <div class="formbody">   
    <div class="formtitle"><span>追加虚拟本金</span></div>

    <div class="tab-content">
  
<dl>
    <dt>会员编号</dt>
    <dd>  <asp:TextBox ID="huiyuan_bianhao" runat="server"   MaxLength="20" CssClass="input normal" datatype="*" ajaxurl="../../tools/admin_ajax.ashx?action=bianhao_name" errormsg=""  Width="100"  ></asp:TextBox>
    <span class="Validform_checktip">*</span>
    </dd>
  </dl> 

  <dl>
    <dt>投资金额</dt>
    <dd>  <asp:TextBox ID="jine" runat="server"   MaxLength="20" CssClass="input normal" datatype="*" errormsg=""  Width="100"  ></asp:TextBox>
    <span class="Validform_checktip">*</span>
    </dd>
  </dl> 

  <dl>
    <dt>投资利息</dt>
    <dd>  <asp:TextBox ID="TextBox1" runat="server"   MaxLength="20" CssClass="input normal" datatype="*" errormsg=""  Width="100"  ></asp:TextBox>%
    <span class="Validform_checktip">*</span>
    </dd>
  </dl> 
  <dl>
    <dt>赠送天数</dt>
    <dd>  <asp:TextBox ID="TextBox2" runat="server"   MaxLength="20" CssClass="input normal" datatype="*" errormsg=""  Width="100"  ></asp:TextBox>
    <span class="Validform_checktip">*</span>
    </dd>
  </dl> 

   <dl>
    <dt>投资类型</dt>
        <dd><span class="rule-single-select">
            <asp:DropDownList ID="leixing" runat="server" datatype="*" errormsg="请选择类型" sucmsg=" ">
               
                  <asp:ListItem Value=3  >虚拟本金</asp:ListItem>
                 
             </asp:DropDownList>
          </span>
          <span class="Validform_checktip">*</span>
          </dd>
  </dl>

   <dl>
    <dt>备注</dt>
    <dd>  <asp:TextBox ID="beizhu" runat="server"   MaxLength="400" CssClass="input normal" datatype="*" errormsg=""  Width="400"  ></asp:TextBox>
    <span class="Validform_checktip">*</span>
    </dd>
  </dl> 
   
  <dl style="width:100%;margin:0;padding:0;text-align:center;}">

  <asp:Button ID="Button1" runat="server" Text="提交保存" CssClass="btn" onclick="btnSubmit_Click"   OnClientClick="javascript:if(!confirm('\n特别提示！？\n\n提交后无法退回'))  return  false; "/>
    
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
  
    <script type="text/javascript">
        $('.tablelist tbody tr:odd').addClass('odd');
	</script>


    </form>



</body>
</html>
