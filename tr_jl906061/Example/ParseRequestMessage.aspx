<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ParseRequestMessage.aspx.cs" Inherits="Example_ParseRequestMessage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>解析消息</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h3>解析消息&nbsp;<a href="http://mp.weixin.qq.com/wiki/2/3478f69c0d0bbe8deb48d66a3111ff6e.html" target="_blank">微信开发者文档</a></h3>
        <h4 style="color: red;">提示：本示例演示解析消息。</h4>
        <p>
            消息文本：
            <asp:TextBox runat="server" ID="txtMessage" Text="" TextMode="MultiLine" Height="200" Width="500" />
        </p>
        <p>
            解析结果：
            <asp:TextBox runat="server" ID="txtResult" Text="" TextMode="MultiLine" Height="200" Width="500" />
        </p>
        <p>
            <asp:Button runat="server" ID="btnParse" Text="开始解析" OnClick="btnParse_Click" />
        </p>
    </div>
    </form>
</body>
</html>
