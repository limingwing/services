<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TemplateMessage.aspx.cs" Inherits="Example_TemplateMessage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>模板消息</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>模板消息&nbsp;<a href="http://mp.weixin.qq.com/wiki/17/304c1885ea66dbedf7dc170d84999a9d.html" target="_blank">微信开发者文档</a></h3>
            <h4 style="color: red;">提示：<asp:Literal runat="server" ID="ltrMessage" Text="本示例演示模板消息的使用。" /></h4>
            <p>
                请选择公众号：
           
                <asp:ListBox runat="server" ID="lbPublicAccount" Rows="1"></asp:ListBox>
            </p>
            <p>
                <h5>设置所属行业</h5>
                <asp:CheckBoxList runat="server" ID="cblIndustry" RepeatDirection="Vertical" RepeatColumns="5" /><br />
                <asp:Button runat="server" ID="btnSetIndustry" Text="设置所属行业" OnClick="btnSetIndustry_Click" />
            </p>
            <p>
                <h5>添加并获得模板id</h5>
                模板编号：<asp:TextBox runat="server" ID="txtTemplateIdShort" Text="TM00015" /><br />
                <asp:Button runat="server" ID="btnGetTemplateId" Text="添加并获得模板id" OnClick="btnGetTemplateId_Click" />
            </p>
            <p>
                <h5>发送模板消息</h5>
                请选择用户：<br />
                <asp:RadioButtonList runat="server" ID="rblUser" RepeatDirection="Vertical" RepeatColumns="5" /><br />
                <asp:Button runat="server" ID="btnGetUser" Text="获取用户列表" OnClick="btnGetUser_Click" /><br />
                模板编号：<asp:TextBox runat="server" ID="txtID" Text="3m_n1DQhdwMGaHc34HyfWBtZ7XB2xt3pgCV3Dcm9hLM" /><br />
                标题：<asp:TextBox runat="server" ID="txtTitle" Text="" /><br />
                称呼：<asp:TextBox runat="server" ID="txtUserName" Text="" /><br />
                <asp:Button runat="server" ID="btnSend" Text="发送模板消息" OnClick="btnSend_Click" />
            </p>
        </div>
    </form>
</body>
</html>
