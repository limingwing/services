<%@ Page Language="C#" AutoEventWireup="true" CodeFile="get_pass.aspx.cs" Inherits="get_pass" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">



<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head><title>
	找回密码
</title>
   
<style type="text/css">
#form1 div table tr td p {
	font-size: 18px;
}
#form1 div table {
	font-size: 18px;
}
</style>
<link href="App_Themes/fl/base.css" type="text/css" rel="stylesheet" /><link href="App_Themes/fl/index.css" type="text/css" rel="stylesheet" /><link href="App_Themes/fl/jquery.lightbox-0.5.css" type="text/css" rel="stylesheet" /><link href="App_Themes/fl/skin.css" type="text/css" rel="stylesheet" /></head>
<body  style="background-image:url(index_files/lgbg.jpg)">
 <form id="form1" runat="server">
<div>
 
</div>

<div>

	 
</div>
    <div align="center">
    <table align="center" style="padding-top:150px;">
    <tr>
    <td ><p>&nbsp;</p>
      <p>请输入您注册时的手机号码。</p></td>
    </tr>
   
    <tr>
    <td>手机号码：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                 </td>
    </tr>
   
    
    
    <tr>
    <td> 
        <asp:Button ID="Button1" runat="server" Text="获取密码" onclick="Button1_Click" /></td>
    </tr>
    </table>
        
    </div>
    </form>
</body>
</html>
