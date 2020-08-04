<%@ Page Language="C#" AutoEventWireup="true" CodeFile="shenhe1.aspx.cs" Inherits="manager_member_shenhe1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>修改资料</title>
    <script type="text/javascript" src="../../js/jquery/jquery-1.10.2.min.js"></script>
    <script type="text/javascript" src="../../js/lhgdialog/lhgdialog.js?skin=idialog"></script>
    <script type="text/javascript" src="../../js/jquery/Validform_v5.3.2_min.js"></script>
    <script type="text/javascript" src="../../js/swfupload/swfupload.js"></script>
    <script type="text/javascript" src="../../js/swfupload/swfupload.queue.js"></script>
    <script type="text/javascript" src="../../js/swfupload/swfupload.handlers.js"></script>
    <script type="text/javascript" src="../../js/layout.js"></script>
    <script type="text/javascript" src="../../js/pinyin.js"></script>
    <link href="../../css/style.css" rel="stylesheet" type="text/css" />
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
    <script type="text/javascript">
        $(function () {
            //初始化表单验证
            $("#form1").initValidform();

            //初始化上传控件
            $(".upload-img").each(function () {
                $(this).InitSWFUpload({ sendurl: "../../tools/upload_ajax.ashx", flashurl: "../../js/swfupload/swfupload.swf" });
            });

            //设置封面图片的样式
            $(".photo-list ul li .img-box img").each(function () {
                if ($(this).attr("src") == $("#hidFocusPhoto").val()) {
                    $(this).parent().addClass("selected");
                }
            });

            //设置封面图片的样式
            $(".photo-list ul li .img-box img").each(function () {
                if ($(this).attr("src") == $("#hidFocusPhoto").val()) {
                    $(this).parent().addClass("selected");
                }
            });


        });

    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div class="place">
        <span>位置：</span>
        <ul class="placeul">
            <li><a href="../index.aspx">首页</a></li>
            <li><a href="#">审核资料</a></li>
        </ul>
    </div>
    <div class="formbody">
        <div id="usual1" class="usual">
            <div class="itab">
                <ul>
                    <li><a href="#" class="selected">审核资料</a></li>
                </ul>
            </div>
            <!--修改信息-->
            <div class="tab-content">
<%--<dl >
    <dt>身份证明</dt>
    <dd>
        <asp:Image ID="Image1" runat="server" Width="300px" Height="180px" />
  
  
    </dd>
  </dl>

   <dl >
    <dt>期权证明</dt>
    <dd>
        <asp:Image ID="Image2" runat="server" Width="300px" Height="180px"/>
  
  
    </dd>
  </dl>
  <dl >
  
    <dt>期权数量</dt>
    <dd>
        <asp:TextBox ID="qiquan_txt" runat="server"  MaxLength="200" CssClass="input normal"    errormsg=""   Width="300"></asp:TextBox>
  
    </dd>
  </dl>--%>
 <dl >
  
    <dt>会员编号</dt>
    <dd>
        <asp:Literal ID="bianhao" runat="server"></asp:Literal>
  
    </dd>
  </dl>
   <dl >
    <dt>会员姓名</dt>
    <dd>
       <asp:TextBox ID="huiyuan_name" runat="server"  MaxLength="200" CssClass="input normal" datatype="*"  errormsg=""   Width="300"></asp:TextBox>
    <span class="Validform_checktip">*</span>
  
    </dd>
  </dl>

   <dl >
    <dt>会员手机</dt>
    <dd>
       <asp:TextBox ID="huiyuan_mob" runat="server"  MaxLength="200" CssClass="input normal"    errormsg=""   Width="300"></asp:TextBox>
     
  
    </dd>
  </dl>

  <dl>
    <dt>会员级别</dt>
    <dd> 
    <span class="rule-single-select">
   <asp:DropDownList id="huiyuan_jiebie" runat="server" datatype="*" errormsg="请选择级别" sucmsg=" " ></asp:DropDownList>  
    </span>
    <span class="Validform_checktip">*</span>
     </dd>
  </dl>
   <%--<dl >
    <dt>推荐人</dt>
    <dd>
        <asp:Literal ID="tjr" runat="server"></asp:Literal>
     
  
    </dd>
  </dl>--%>


   <dl >
    <dt>一级密码</dt>
    <dd>
       <asp:TextBox ID="huiyuan_pass" runat="server"  MaxLength="200" CssClass="input normal"    datatype="*"  errormsg=""  Width="300"></asp:TextBox>
     <span class="Validform_checktip">*</span>
  
    </dd>
  </dl>

   <dl >
    <dt>二级密码</dt>
    <dd>
       <asp:TextBox ID="pass_two" runat="server"  MaxLength="200" CssClass="input normal"    datatype="*"  errormsg=""  Width="300"></asp:TextBox>
     <span class="Validform_checktip">*</span>
  
    </dd>
  </dl>

   

    <dl>
    <dt>会员银行</dt>
    <dd> 
    <span class="rule-single-select">
   <asp:DropDownList id="huiyuan_yinhang" runat="server" datatype="*" errormsg="请选择银行" sucmsg=" " ></asp:DropDownList>  
    </span>
    <span class="Validform_checktip">*</span>
     </dd>
  </dl>

    <dl >
    <dt>开户姓名</dt>
    <dd><asp:TextBox ID="huiyuan_yinhang_name" runat="server"  MaxLength="200" CssClass="input normal"    errormsg=""   Width="300"></asp:TextBox>
    
    </dd>
  </dl>

   <dl >
    <dt>银行账号</dt>
    <dd><asp:TextBox ID="huiyuan_yinhang_zh" runat="server"  MaxLength="200" CssClass="input normal"    errormsg=""   Width="300"></asp:TextBox>
    
    </dd>
  </dl>


  <dl >
    <dt>开户支行</dt>
    <dd><asp:TextBox ID="bank_zhi" runat="server"  MaxLength="200" CssClass="input normal"    errormsg=""   Width="300"></asp:TextBox>
    
    </dd>
  </dl>
   <dl >
    <dt>身份证号</dt>
    <dd><asp:TextBox ID="huiyuan_shenfen_id" runat="server"  MaxLength="200" CssClass="input normal"    errormsg=""   Width="300"></asp:TextBox>
    
    </dd>
  </dl>
  <dl >
    <dt>出生日期</dt>
    <dd><asp:TextBox ID="born" runat="server"  MaxLength="200" CssClass="input normal"    errormsg=""   Width="300"></asp:TextBox>
    
    </dd>
  </dl>
  <dl >
    <dt>QQ</dt>
    <dd><asp:TextBox ID="huiyuan_qq" runat="server"  MaxLength="200" CssClass="input normal"    errormsg=""   Width="300"></asp:TextBox>
    
    </dd>
  </dl>

  
  <dl >
    <dt>微信号</dt>
    <dd><asp:TextBox ID="weixin" runat="server"  MaxLength="200" CssClass="input normal"    errormsg=""   Width="300"></asp:TextBox>
    
    </dd>
  </dl>

   <dl >
    <dt>支付宝</dt>
    <dd><asp:TextBox ID="zhifubao" runat="server"  MaxLength="200" CssClass="input normal"    errormsg=""   Width="300"></asp:TextBox>
    
    </dd>
  </dl>
  <dl >
    <dt>住址</dt>
    <dd><asp:TextBox ID="address" runat="server"  MaxLength="200" CssClass="input normal"    errormsg=""   Width="300"></asp:TextBox>
    
    </dd>
  </dl>
  
</div>
            <!--/增加新品信息-->
        </div>
        <!--工具栏-->
        <div class="page-footer">
            <div class="btn-list">
                <asp:Button ID="btnSubmit" runat="server" Text="开通 " CssClass="btn" OnClick="btnSubmit_Click"
                    />
            </div>
            <div class="clear">
            </div>
        </div>
        <!--/工具栏-->
    </div>
    </form>
</body>
</html>