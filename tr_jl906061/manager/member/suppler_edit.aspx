<%@ Page Language="C#" AutoEventWireup="true" CodeFile="suppler_edit.aspx.cs" Inherits="manager_member_suppler_edit" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>修改玩家资料</title>
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
            <li><a href="#">修改玩家资料</a></li>
        </ul>
    </div>
    <div class="formbody">
        <div id="usual1" class="usual">
            <div class="itab">
                <ul>
                    <li><a href="#" class="selected">修改玩家资料</a></li>
                </ul>
            </div>
            <!--修改信息-->
            <div class="tab-content">
                <dl>
                    <dt>商家营业执照</dt>
                    <dd>
                        <asp:Image ID="Image1" runat="server" Width="300px" Height="180px" />*右击图片点击另存为——》
                    </dd>
                </dl>
                <dl>
                    <dt>商家店铺照片</dt>
                    <dd>
                        <asp:Image ID="Image2" runat="server" Width="300px" Height="180px" />*右击图片点击另存为——》
                    </dd>
                </dl>
                <dl>
                    <dt>公司名称</dt>
                    <dd>
                        <asp:TextBox ID="name" runat="server" MaxLength="200" CssClass="input normal" datatype="*"
                            errormsg="" Width="300"></asp:TextBox>
                        <span class="Validform_checktip">*</span>
                    </dd>
                </dl>
                 <dl>
                    <dt>行业类别</dt>
                    <dd>
                        <asp:TextBox ID="category" runat="server" MaxLength="200" CssClass="input normal" errormsg=""
                            Width="300"></asp:TextBox>
                    </dd>
                </dl>
                <dl>
                    <dt>注册地址</dt>
                    <dd>
                        <asp:TextBox ID="address" runat="server" MaxLength="200" CssClass="input normal"
                            datatype="*" errormsg="" Width="300"></asp:TextBox>
                        <span class="Validform_checktip">*</span>
                    </dd>
                </dl>
                <dl>
                    <dt>法定联系人</dt>
                    <dd>
                        <asp:TextBox ID="legelname" runat="server" MaxLength="200" CssClass="input normal"
                            datatype="*" errormsg="" Width="300"></asp:TextBox>
                        <span class="Validform_checktip">*</span>
                    </dd>
                </dl>
                <dl>
                    <dt>法人电话</dt>
                    <dd>
                        <asp:TextBox ID="phone" runat="server" MaxLength="200" CssClass="input normal" errormsg=""
                            Width="300"></asp:TextBox>
                    </dd>
                </dl>
                 <dl>
                    <dt>开户银行</dt>
                    <dd>
                        <asp:TextBox ID="bankName" runat="server" MaxLength="200" CssClass="input normal" errormsg=""
                            Width="300"></asp:TextBox>
                    </dd>
                </dl>
                 <dl>
                    <dt>银行账号</dt>
                    <dd>
                        <asp:TextBox ID="bankno" runat="server" MaxLength="200" CssClass="input normal" errormsg=""
                            Width="300"></asp:TextBox>
                    </dd>
                </dl>
                 <dl>
                    <dt>开户地址</dt>
                    <dd>
                        <asp:TextBox ID="bankaderess" runat="server" MaxLength="200" CssClass="input normal" errormsg=""
                            Width="300"></asp:TextBox>
                    </dd>
                </dl>
              <%--  <dl>
                    <dt>法人证件号</dt>
                    <dd>
                        <asp:TextBox ID="IDcard" runat="server" MaxLength="200" CssClass="input normal" datatype="*"
                            errormsg="" Width="300"></asp:TextBox>
                        <span class="Validform_checktip">*</span>
                    </dd>
                </dl>
                <dl>
                    <dt>公司简介</dt>
                    <dd>
                        <asp:TextBox ID="profile" runat="server" MaxLength="200" CssClass="input normal"
                            errormsg="" Width="300"></asp:TextBox>
                        <textarea id="content" runat="server" class="input normal"></textarea>
                    </dd>
                </dl>
                <dl>
                    <dt>电子邮箱</dt>
                    <dd>
                        <asp:TextBox ID="email" runat="server" MaxLength="200" CssClass="input normal" errormsg=""
                            Width="300"></asp:TextBox>
                    </dd>
                </dl>--%>
            </div>
            <!--/增加新品信息-->
        </div>
        <!--工具栏-->
        <div class="page-footer">
            <div class="btn-list">
                <asp:Button ID="btnSubmit" runat="server" Text="修改" CssClass="btn" OnClick="btnSubmit_Click" />
            </div>
            <div class="clear">
            </div>
        </div>
        <!--/工具栏-->
    </div>
    </form>
</body>
</html>

