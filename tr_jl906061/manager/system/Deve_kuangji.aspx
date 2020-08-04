<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Deve_kuangji.aspx.cs" Inherits="manager_system_Deve_kuangji" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>打印机</title>
    <link href="../../css/style.css" rel="stylesheet" type="text/css" />
        <script type="text/javascript" src="../../js/lhgcore.min.js"></script>
    <script type="text/javascript" src="../../js/lhgcalendar.min.js"></script>
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
     <script type="text/javascript">
         J(function () {
             J('#txtstart_time').calendar({ btnBar: true });
             J('#txt_time1').calendar({ format: 'HH:mm' });
             J('#txt_time2').calendar({ format: 'HH:mm' });

         });
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div class="place">
        <span>位置：</span>
        <ul class="placeul">
            <li><a href="../index.aspx">首页</a></li>
            <li><a href="Deve_kuangji.aspx"> 打印机</a></li>
        </ul>
    </div>
    <div class="formbody">
     
        <!--列表-->
        <asp:Repeater ID="rptList" runat="server">
            <HeaderTemplate>
                <table class="tablelist">
                    <thead>
                        <tr>
                            <th width="10%">
                                序号
                            </th>
                            <th width="10%">
                                单价（元）
                            </th>
                            
                            <th width="10%">
                               打印量（%）
                            </th>
                             <th width="10%">
                             周期（天）
                            </th>
                            <th width="10%">
                                操作
                            </th>
                        </tr>
                    </thead>
                    <tbody>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td>
                          <%# pageSize * page + Container.ItemIndex + 1 - pageSize%><asp:HiddenField ID="hidId"
                            Value='<%#Eval("id")%>' runat="server" />
                    </td>
                    <td>
                        <%# Eval("price")%>
                    </td>
                    <td>
                        <%# Eval("percent")%>
                    </td>
                     <td>
                        <%# Eval("date")%>
                    </td>
                 
                    <td>
                        <a href="Deve_kuangji1.aspx?action=Edit&id=<%#Eval("id")%>&page=<%=page%>" class="tablelink">
                            <font color="green">[修改]</font></a> &nbsp;&nbsp;<asp:LinkButton ID="lbtnDelCa" runat="server"></asp:LinkButton>
                            
                    </td>
                </tr>
            </ItemTemplate>
            <FooterTemplate>
                <%#rptList.Items.Count == 0 ? "<tr><td align=\"center\" colspan=\"5\"><font color=red>暂无记录</font></td></tr>" : ""%>
                </tbody> </table>
            </FooterTemplate>
        </asp:Repeater>
        <div class="pagelist">
            <div class="l-btns">
                <span>显示</span><asp:TextBox ID="txtPageNum" runat="server" CssClass="pagenum" onkeydown="return checkNumber(event);"
                    OnTextChanged="txtPageNum_TextChanged" AutoPostBack="True"></asp:TextBox><span>条/页</span>
            </div>
            <div id="PageContent" runat="server" class="default">
            </div>
        </div>
    </div>
    <script type="text/javascript">
        $('.tablelist tbody tr:odd').addClass('odd');
    </script>
    </form>
</body>
</html>
