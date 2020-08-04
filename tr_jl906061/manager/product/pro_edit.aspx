<%@ Page Language="C#" AutoEventWireup="true" CodeFile="pro_edit.aspx.cs" Inherits="manager_product_pro_edit" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>增加新品</title>
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
            <li><a href="../home.aspx">首页</a></li>
            <li><a href="#">增加新品</a></li>
        </ul>
    </div>
    <div class="formbody">
        <div id="usual1" class="usual">
            <div class="itab">
                <ul>
                    <li><a href="product_add.aspx" class="selected">增加新品</a></li>
                </ul>
            </div>
            <!--增加新品信息-->
            <div class="tab-content">
                <dl>
                    <dt>商品类别</dt>
                    <dd>
                        <span class="rule-single-select">
                            <asp:DropDownList ID="ddlproduct_category_id" runat="server" datatype="*" errormsg="请选择商品类别"
                                sucmsg=" ">
                            </asp:DropDownList>
                        </span><span class="Validform_checktip">*</span>
                    </dd>
                </dl>
                <dl>
                    <dt>商品名称</dt>
                    <dd>
                        <asp:TextBox ID="txtproduct_name" runat="server" MaxLength="200" CssClass="input normal"
                            datatype="*" errormsg="" Width="300"></asp:TextBox>
                        <span class="Validform_checktip">*</span>
                    </dd>
                </dl>
                <dl>
                    <dt>商品属性</dt>
                    <dd>
                        <span class="rule-single-select">
                            <asp:DropDownList ID="attribute" runat="server" datatype="*" errormsg="请选择商品属性" sucmsg=" ">
                            </asp:DropDownList>
                        </span><span class="Validform_checktip">*</span>
                    </dd>
                </dl>
                  <asp:ScriptManager ID="ProvinceContect" runat="server">
                            </asp:ScriptManager>
                            <asp:UpdatePanel ID="UpdatePanel" runat="server">
                                <ContentTemplate>
                <dl>
                    <dt>商品产地</dt>
                    <dd>
                        <span class="rule-single-select">
                            <asp:DropDownList ID="ddlprov" runat="server" datatype="*" errormsg="请选择商品产地" sucmsg=" "
                                OnSelectedIndexChanged="ddlprov_SelectedIndexChanged" AutoPostBack="true">
                            </asp:DropDownList>
                        </span><span class="rule-single-select">
                            <asp:DropDownList ID="ddlcity" runat="server" datatype="*" errormsg="请选择商品产地" sucmsg=" "
                                OnSelectedIndexChanged="ddlcity_SelectedIndexChanged" AutoPostBack="true">
                            </asp:DropDownList>
                        </span><span class="rule-single-select">
                            <asp:DropDownList ID="ddlarea" runat="server" datatype="*" errormsg="请选择商品产地" sucmsg=" ">
                            </asp:DropDownList>
                        </span><span class="Validform_checktip">*</span>
                    </dd>
                </dl>
                   </ContentTemplate>
                            </asp:UpdatePanel>
                <dl>
                    <dt>上传商品图片</dt>
                    <dd>
                        <asp:TextBox ID="txtImgUrl" runat="server" CssClass="input normal upload-path" />
                        <div class="upload-box upload-img">
                        </div>
                        <span class="Validform_checktip">*请上传商品图片800*800px像素</span>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtImgUrl"
                            ErrorMessage="请选择您要上传的图片！"></asp:RequiredFieldValidator>
                    </dd>
                </dl>
                <dl>
                    <dt>上传副商品图片1</dt>
                    <dd>
                        <asp:TextBox ID="txtImgUrl1" runat="server" CssClass="input normal upload-path" />
                        <div class="upload-box upload-img">
                        </div>
                        <span class="Validform_checktip">*上传副商品图片800*800px像素</span>
                    </dd>
                </dl>
                <dl>
                    <dt>上传副商品图片2</dt>
                    <dd>
                        <asp:TextBox ID="txtImgUrl2" runat="server" CssClass="input normal upload-path" />
                        <div class="upload-box upload-img">
                        </div>
                        <span class="Validform_checktip">*上传副商品图片800*800px像素</span>
                    </dd>
                </dl>
                <dl>
                    <dt>计量单位</dt>
                    <dd>
                        <asp:TextBox ID="txtdw" runat="server" CssClass="input small" MaxLength="10" datatype="*"
                            sucmsg=""></asp:TextBox>
                        <span class="Validform_checktip">*</span></dd>
                </dl>
                <dl>
                    <dt>进货单价</dt>
                    <dd>
                        <asp:TextBox ID="txtgo_price" runat="server" CssClass="input small" onkeyup="clearNoNum(this)"
                            MaxLength="8" datatype="*" sucmsg="" errormsg="请输入正确的金额"></asp:TextBox>&nbsp;&nbsp;元
                        <span class="Validform_checktip">*</span></dd>
                </dl>
                <dl>
                    <dt>销售单价</dt>
                    <dd>
                        <asp:TextBox ID="txtsalse_price" runat="server" CssClass="input small" onkeyup="clearNoNum(this)"
                            MaxLength="8" datatype="*" sucmsg="" errormsg="请输入正确的金额"></asp:TextBox>&nbsp;&nbsp;元
                        <span class="Validform_checktip">*</span></dd>
                </dl>
                <%--<dl>
    <dt>秒杀单价</dt>
     <dd>   <asp:TextBox ID="shop" runat="server" CssClass="input small" onkeyup="clearNoNum(this)"  MaxLength="8" datatype="*" sucmsg="" errormsg="请输入正确的积分"></asp:TextBox>&nbsp;&nbsp;
      <span class="Validform_checktip">*</span></dd>
  </dl>--%>
                <%--<dl>
    <dt>肽豆</dt>
     <dd>   <asp:TextBox ID="yun" runat="server" CssClass="input small" onkeyup="clearNoNum(this)"  MaxLength="8" datatype="*" sucmsg="" errormsg="请输入正确的积分"></asp:TextBox>&nbsp;&nbsp;
      <span class="Validform_checktip">*</span></dd>
  </dl>
  
  <dl>
    <dt>购物积分</dt>
     <dd>   <asp:TextBox ID="chongxiao" runat="server" CssClass="input small" onkeyup="clearNoNum(this)"  MaxLength="8" datatype="*" sucmsg="" errormsg="请输入正确的积分"></asp:TextBox>&nbsp;&nbsp;
      <span class="Validform_checktip">*</span></dd>
  </dl>
                 <dl>
    <dt> PV</dt>
     <dd>   <asp:TextBox ID="pv" runat="server" CssClass="input small" onkeyup="clearNoNum(this)"  MaxLength="8" datatype="*" sucmsg="" errormsg="请输入正确的金额"></asp:TextBox>&nbsp;&nbsp;元
      <span class="Validform_checktip">*</span></dd>
  </dl>--%>
  <dl>
  <dt>入库数量</dt>
     <dd>   <asp:TextBox ID="txtproduct_num" runat="server" CssClass="input small" datatype="n" sucmsg=" "></asp:TextBox>
      <span class="Validform_checktip">*</span></dd>
  </dl>
                <%--<dl>
                    <dt>是否为分享积分产品 </dt>
                    <dd>
                        <div class="rule-single-checkbox">
                            <asp:CheckBox ID="cbIsLock" runat="server" />
                        </div>
                        <span class="Validform_checktip">*启用时即为在会员选购的分享积分产品</span>
                    </dd>
                </dl>
                 <dl>
                    <dt>是否为5折产品 </dt>
                    <dd>
                        <div class="rule-single-checkbox">
                            <asp:CheckBox ID="shengji" runat="server" />
                        </div>
                        <span class="Validform_checktip">*启用时即为在会员选购的5折产品</span>
                    </dd>
                </dl>--%>
                <dl>
                    <dt>是否上架 </dt>
                    <dd>
                        <div class="rule-single-checkbox">
                            <asp:CheckBox ID="pro_isok" runat="server" Checked="True" />
                        </div>
                        <span class="Validform_checktip">*启用时会员可以看见该产品</span>
                    </dd>
                </dl>
                <dl>
                    <dt>是否推荐首页 </dt>
                    <dd>
                        <div class="rule-single-checkbox">
                            <asp:CheckBox ID="pro_home_show" runat="server" Checked="True" />
                        </div>
                        <span class="Validform_checktip">*启用时首页可以看见该产品</span>
                    </dd>
                </dl>
                <dl>
                    <dt>是否热销产品 </dt>
                    <dd>
                        <div class="rule-single-checkbox">
                            <asp:CheckBox ID="pro_Hot" runat="server" Checked="True" />
                        </div>
                        <span class="Validform_checktip">*启用时首页热销看见该产品</span>
                    </dd>
                </dl>
                <dl>
                    <dt>产品说明</dt>
                    <dd>
                        <textarea id="txtContent" class="editor" style="visibility: hidden;" runat="server"></textarea></dd>
                </dl>
            </div>
            <!--/增加新品信息-->
        </div>
        <!--工具栏-->
        <div class="page-footer">
            <div class="btn-list">
                <asp:Button ID="btnSubmit" runat="server" Text="提交保存 " CssClass="btn" OnClick="btnSubmit_Click" />
            </div>
            <div class="clear">
            </div>
        </div>
        <!--/工具栏-->
    </div>
    </form>
</body>
</html>
