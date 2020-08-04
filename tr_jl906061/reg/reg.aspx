<%@ Page Language="C#" AutoEventWireup="true" CodeFile="reg.aspx.cs" Inherits="reg_reg" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
   <title>注册会员</title>
<script type="text/javascript" src="../js/jquery/jquery-1.10.2.min.js"></script>
<script type="text/javascript" src="../js/lhgdialog/lhgdialog.js?skin=idialog"></script>
<script type="text/javascript" src="../js/jquery/Validform_v5.3.2_min.js"></script>
 
<script type="text/javascript" src="../js/layout.js"></script>
<script type="text/javascript" src="../js/pinyin.js"></script>
<link href="../css/style.css" rel="stylesheet" type="text/css" />
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
    
    <li><a href="#">注册会员</a></li>
    </ul>
    </div> 
    <div class="formbody">  
    <div id="usual1" class="usual">   
    <div class="itab">
  	<ul> 
    <li><a href="reg.aspx" class="selected">注册会员</a></li> 
  	</ul>
    </div>  
 <!--注册会员-->
 
<div class="tab-content">

     <dl >
    <dt>会员编号</dt>
    <dd><asp:TextBox ID="bas_id1" runat="server"  MaxLength="20" CssClass="input normal" datatype="*"  errormsg="" ajaxurl="../tools/admin_ajax.ashx?action=huiyuan_validate" Width="100"></asp:TextBox>
    <span class="Validform_checktip">*</span>
    </dd>
  </dl>

     
  <dl>
    <dt>会员姓名</dt>
    <dd>
         <asp:TextBox ID="bas_name" runat="server"  MaxLength="20" CssClass="input normal" datatype="*"  errormsg=""  Width="100"></asp:TextBox>
    <span class="Validform_checktip">请填写真实姓名</span>
    </dd>

  </dl>

   <%--<dl>
    <dt>投资金额</dt>
    <dd>
         <asp:TextBox ID="jine" runat="server"  MaxLength="20" CssClass="input normal" datatype="*"  errormsg=""  Width="100" value=200></asp:TextBox>
    <span class="Validform_checktip">*200以上</span>
    </dd>

  </dl>

  <dl>
    <dt>投资类型</dt>
        <dd><span class="rule-single-select">
            <asp:DropDownList ID="leixing" runat="server" datatype="*" errormsg="请选择类型" sucmsg=" ">
                <asp:ListItem Value=1 Selected="True">活期</asp:ListItem>
                 <asp:ListItem Value=2  >定投一年</asp:ListItem>
                 
                 
             </asp:DropDownList>
          </span>
          <span class="Validform_checktip">*</span>
          </dd>
  </dl>--%>
    <dl>
    <dt>联系手机</dt>
    <dd>   <asp:TextBox ID="bas_mob" runat="server" CssClass="input small"  MaxLength="11" datatype="*"  sucmsg="" Width="150" ></asp:TextBox>
      <span class="Validform_checktip">请填写正确的手机号</span></dd>
  </dl> 
 <dl>
    <dt>推荐人编号</dt>
    <dd>  <asp:TextBox ID="bas_tuijian" runat="server" datatype="*"  errormsg=""  MaxLength="20" CssClass="input normal" Width="100" ajaxurl="../tools/admin_ajax.ashx?action=tjr_validate"></asp:TextBox>
    <span class="Validform_checktip">*</span>
    </dd>
  </dl> 
   <dl>
    <dt>接点人编号</dt>
    <dd>  <asp:TextBox ID="huiyuan_jiedian" runat="server" datatype="*"  errormsg=""  MaxLength="20" CssClass="input normal" Width="100" ajaxurl="../tools/admin_ajax.ashx?action=jdr_validate"></asp:TextBox>
    <span class="Validform_checktip">*</span>
    </dd>
  </dl>
  <dl>
    <dt>区域选择</dt>
        <dd><span class="rule-single-select">
            <asp:DropDownList ID="zuoyou" runat="server" datatype="*" errormsg="请选择区域" sucmsg=" ">
                <asp:ListItem Value=1 Selected="True">A区</asp:ListItem>
                 <asp:ListItem Value=2  >B区</asp:ListItem>
                 <asp:ListItem Value=3  >C区</asp:ListItem>
             </asp:DropDownList>
          </span>
          <span class="Validform_checktip">*</span>
          </dd>
  </dl>

 <dl>
    <dt>会员级别</dt>
    <dd> <span class="rule-single-select">
             <asp:DropDownList id="huiyuan_jiebie" runat="server" datatype="*" errormsg="请选择会员级别" sucmsg=" " ></asp:DropDownList>  
          </span>
          <span class="Validform_checktip">*</span>
    </dd>
  </dl>
   

   <dl  >
    <dt>服务中心编号</dt>
     <dd>   <asp:TextBox ID="huiyuan_zm" runat="server"  MaxLength="20" CssClass="input normal" datatype="*"   errormsg=""  Width="100"></asp:TextBox>
    <span class="Validform_checktip">*</span>
    </dd>
  </dl> 
     

    <dl>
    <dt>输入一级密码</dt>
     <dd>    <asp:TextBox ID="huiyuan_pass" runat="server" value=111111 CssClass="input normal" TextMode="Password" datatype="*6-20" nullmsg="请输入一级密码" errormsg="密码范围在6-20位之间" sucmsg=" "></asp:TextBox> <span class="Validform_checktip">*</span>默认111111

    </dd>
  </dl>


   <dl>
    <dt>一级密码确认</dt>
     <dd>  <asp:TextBox ID="huiyuan_pass1" runat="server" value=111111 CssClass="input normal" TextMode="Password" datatype="*" recheck="huiyuan_pass" nullmsg="请再输入一级密码" errormsg="两次输入的密码不一致" sucmsg=" "></asp:TextBox> <span class="Validform_checktip">*</span>默认111111
    </dd>
  </dl>


   <dl>
    <dt>输入二级密码</dt>
     <dd>    <asp:TextBox ID="pass_two" runat="server" value=222222 CssClass="input normal" TextMode="Password" datatype="*6-20" nullmsg="请输入二级密码" errormsg="密码范围在6-20位之间" sucmsg=" "></asp:TextBox> <span class="Validform_checktip">*</span>默认222222

    </dd>
  </dl>


   <dl>
    <dt>二级密码确认</dt>
     <dd>   <asp:TextBox ID="pass_two1" runat="server" value=222222 CssClass="input normal" TextMode="Password" datatype="*" recheck="pass_two" nullmsg="请再输入二级密码" errormsg="两次输入的密码不一致" sucmsg=" "></asp:TextBox> <span class="Validform_checktip">*</span>默认222222

    </dd>
  </dl>


  <dl>
    <dt>开户银行</dt>
    <dd> <span class="rule-single-select">
             <asp:DropDownList id="bas_bankaddress" runat="server"></asp:DropDownList>  
          </span>
           
    </dd>
  </dl>

  <dl>
    <dt>银行账号</dt>
    <dd>  
            <asp:TextBox ID="bas_bankaddress1" runat="server" CssClass="input normal"  ></asp:TextBox>
       
          
    </dd>
  </dl>


   <dl>
    <dt>开户姓名</dt>
    <dd>  
            <asp:TextBox ID="zhanghuming" runat="server" CssClass="input normal"  MaxLength="50"    ></asp:TextBox>
       
          
    </dd>
  </dl>

   <dl>
    <dt>银行支行</dt>
    <dd>  
            <asp:TextBox ID="bank_zhi" runat="server" CssClass="input normal"  MaxLength="50"    ></asp:TextBox>
       
          
    </dd>
  </dl>
  <asp:ScriptManager ID="ProvinceContect" runat="server">
                </asp:ScriptManager>
                <asp:UpdatePanel ID="UpdatePanel" runat="server">
                    <ContentTemplate>
                        <dl>
                            <dt>地址</dt>
                            <dd>
                                <asp:DropDownList ID="bind_Province" runat="server" AutoPostBack="True" 
                                    OnSelectedIndexChanged="bind_Province_SelectedIndexChanged" CssClass="input normal">
                                </asp:DropDownList>
                                
                            </dd>
                        </dl>
                        <dl>
                            <dt>选择市</dt>
                            <dd>
                                <asp:DropDownList ID="bind_City" runat="server" AutoPostBack="True" 
                                    OnSelectedIndexChanged="bind_City_SelectedIndexChanged" CssClass="input normal">
                                </asp:DropDownList>
                                
                            </dd>
                        </dl>
                        <dl>
                            <dt>选择县</dt>
                            <dd>
                                <asp:DropDownList ID="bind_Borough" runat="server" CssClass="input normal">
                                </asp:DropDownList>
                                
                            </dd>
                        </dl>
                    </ContentTemplate>
                </asp:UpdatePanel>
    <dl>
    <dt>地址</dt>
    <dd>  
            <asp:TextBox ID="huiyuan_address" runat="server" CssClass="input normal"  MaxLength="50"    ></asp:TextBox>
       
          
    </dd>
  </dl>
  <dl>
    <dt>出生日期</dt>
    <dd>  
            <asp:TextBox ID="born" runat="server" CssClass="input normal"  MaxLength="50"    ></asp:TextBox>
       
          
    </dd>
  </dl>
   <dl>
    <dt>身份证号</dt>
    <dd>  
            <asp:TextBox ID="huiyuan_idcard" runat="server" CssClass="input normal"  MaxLength="50"    ></asp:TextBox>
       
          
    </dd>
  </dl>
   <dl>
    <dt>微信号</dt>
    <dd>  
            <asp:TextBox ID="weixin" runat="server" CssClass="input normal"  MaxLength="50"    ></asp:TextBox>
       
          
    </dd>
  </dl>
<%--      <dl >
    <dt>上传身份证明</dt>
    <dd> <asp:FileUpload ID="shenfen_img" runat="server" CssClass="input normal"/>
    <span class="Validform_checktip">*</span>
    </dd>
  </dl>
  <dl >
    <dt>上传期权证明</dt>
    <dd><asp:FileUpload ID="zl_img" runat="server" CssClass="input normal"/>
    <span class="Validform_checktip">*</span>
    </dd>
  </dl>
    <asp:Repeater ID="rptList" runat="server">
<HeaderTemplate>
     <table class="imgtable">
    	<thead>
    	<tr>
       
		<th width="140px;">商品图片</th>
		<th >商品名称</th>
    
		 <th>商品类别</th>
         
		<th width="80px;">销售单价</th>
 
 
         <th width="180px;">选择数量</th>
        </tr>
        </thead>
        <tbody>
	 </HeaderTemplate>
<ItemTemplate> 
        <tr>
        
              <td class="imgtd"><img src="<%# Eval("pro_imgs")%>" width="80" height="80"   /></td>
             <td><%# Eval("pro_name")%><asp:HiddenField ID="hidId" Value='<%#Eval("pro_id")%>' runat="server" /></td>	
           
             <td><%#new tbl_sinkia_sub().GetTitle_sub(Convert.ToInt32(Eval("pro_pid")))%></td>	      
    
            <td> <asp:Label ID="Label2" runat="server" Text=<%# Eval("salse_price")%>></asp:Label> </td>		
      
         
            <td>  <asp:TextBox ID="shuliang" runat="server" CssClass="input small"    MaxLength="15"   sucmsg="" Text=0   ></asp:TextBox></td>
        </tr>      
	   </ItemTemplate>
<FooterTemplate>
  <%#rptList.Items.Count == 0 ? "<tr><td align=\"center\" colspan=\"10\"><font color=red><font color=red>暂无记录</font></font></td></tr>" : ""%>
   </tbody>
    </table>
</FooterTemplate>
</asp:Repeater>
--%>
</div>
<!--/会员信息-->    
    </div>

    <!--工具栏-->
<div class="page-footer">
  <div class="btn-list">
    <asp:Button ID="btnSubmit" runat="server" Text="提交保存 " CssClass="btn"  onclick="btnSubmit_Click"  />
  </div>
  <div class="clear"></div>
</div>
<!--/工具栏-->
	</div> 
    </form>
</body>
</html>
