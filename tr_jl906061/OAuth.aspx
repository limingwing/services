<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OAuth.aspx.cs" Inherits="OAuth" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Literal runat="server" ID="ltrResult" Text="" />
        <table style="width: 100%;">
            <tr>
                <td style="width: 150px;">
                    <p>
                        openid:<%=openid%></p>
                </td>
                <td>
                    <p>
                        nickname:<%=nickname%></p>
                </td>
                <td>
                    <p>
                        sex:<%=sex%></p>
                </td>
            </tr>
            <tr>
                <td>
                    <p>
                        language:<%=language%></p>
                </td>
                <td>
                    <p>
                        city:<%=city%></p>
                </td>
                <td>
                    <p>
                        country:<%=country%></p>
                </td>
            </tr>
            <tr>
                <td>
                    <p>
                        headimgurl:<img width="50px;" src="<%=headimgurl %>" alt=""></p>
                </td>
                <td>
                    <p>
                        privilege:<%=privilege%></p>
                </td>
                <td>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
