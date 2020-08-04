<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Access_token.aspx.cs" Inherits="fuwu_Access_token" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <h3></h3>
    <form id="form1" runat="server">
        <div>
            appid:<asp:TextBox runat="server" ID="textBox_appid" />
            <br />secret:<asp:TextBox runat="server" ID="textBox_secret" />
            <br /><asp:Button runat="server" ID="button_get"  Text="获取Access_token" OnClick="button_get_Click"/>
            <br />
            <asp:Button runat="server" ID="button1"  Text="获取next_openid" 
                onclick="button1_Click"/>
            <br />
            <asp:Literal runat="server" ID="literal_tips" />
        </div>
    </form>
</body>
</html>
