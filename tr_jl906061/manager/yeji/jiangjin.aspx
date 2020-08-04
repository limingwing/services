<%@ Page Language="C#" AutoEventWireup="true" CodeFile="jiangjin.aspx.cs" Inherits="manager_yeji_jiangjin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>积分查询</title>
    <link href="../../css/style.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="../../js/lhgcore.min.js"></script>
    <script type="text/javascript" src="../../js/lhgcalendar.min.js"></script>
    <script type="text/javascript" src="../../js/jquery/jquery-1.10.2.min.js"></script>
    <script type="text/javascript" src="../../js/lhgdialog/lhgdialog.js?skin=idialog"></script>
    <script type="text/javascript" src="../../js/jquery/Validform_v5.3.2_min.js"></script>
    <script type="text/javascript" src="../../js/lhgdialog/lhgdialog.js?skin=idialog"></script>
    <script type="text/javascript" src="../../js/layout.js"></script>
    <script type="text/javascript" src="../../js/pinyin.js"></script>
    <script type="text/javascript">
        J(function () {
            J('#txtstart_time').calendar({ btnBar: true });
            J('#txtstop_time').calendar({ btnBar: true });
        }); 
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div class="place">
        <span>位置:</span>
        <ul class="placeul">
            <li><a href="#">首页</a></li>
            <li><a href="#">积分查询</a></li>
        </ul>
    </div>
    <div class="rightinfo">
        <dl class="seachform">
            <dd>
                <span class="rule-single-select">
                    <asp:DropDownList ID="type" runat="server">
                        <asp:ListItem Value="1" Selected="True">会员编号</asp:ListItem>
                        <asp:ListItem Value="2">会员姓名</asp:ListItem>
                    </asp:DropDownList>
                </span><span class="single-select">
                    <asp:TextBox ID="txtNote_no" runat="server" Width="120" CssClass="scinput"></asp:TextBox></span></dd>
            <dd>
                <label>
                    开始日期</label><span class="single-select"><input type="text" class="timeinput" id="txtstart_time"
                        name="txtstart_time" readonly="readonly" runat="server" /></span></dd>
            <dd>
                <label>
                    截止日期</label><span class="single-select"><input type="text" class="timeinput" id="txtstop_time"
                        name="txtstop_time" readonly="readonly" runat="server" /></span></dd>
            <dd class="cx">
                <asp:Button ID="lbtnSearch" runat="server" CssClass="scbtn" OnClick="btnSearch_Click"
                    Text="查询"></asp:Button>
            </dd>
                <%-- <dd class="toolbar1">
        <asp:LinkButton ID="btnExport" runat="server" CssClass="save" onclick="btnExport_Click">   <li><span><img src="../../images/t04.png" /></span>导出Execl</li></asp:LinkButton>
        </dd>--%>
        </dl>
        <!--列表-->
        <table class="tablelist">
            <thead>
                <tr>
                    <th width="40px;">
                        序号
                    </th>
                    <th>
                        会员编号
                    </th>
                    <th>
                        会员姓名
                    </th>
                    <th>
                        消费积分
                    </th>
                    <th>
                        拓展奖
                    </th>
                    <th>
                        管理奖
                    </th>
                    <th>
                        合计
                    </th>
                    <th>
                        结算时间
                    </th>
                </tr>
            </thead>
            <tbody>
                <asp:Repeater ID="rptList" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td>
                                <%# pageSize * page + Container.ItemIndex + 1 - pageSize%>
                            </td>
                            <td>
                                <%#Eval("cha_hui_bianhao")%>
                            </td>
                            <td>
                                <%# Eval("cha_name")%>
                            </td>
                            <td>
                                <%#money_Convert(Eval("cha_001").ToString())%>
                            </td>
                            <td>
                                <%#money_Convert(Eval("cha_002").ToString())%>
                            </td>
                            <td>
                                <%#money_Convert(Eval("cha_003").ToString())%>
                            </td>
                            <td>
                                <%#money_Convert(Eval("cha_013").ToString())%>
                            </td>
                            <td>
                                <%#string.Format("{0:g}",Eval("cha_date"))%>
                            </td>
                        </tr>
                    </ItemTemplate>
                    <FooterTemplate>
                        <%#rptList.Items.Count == 0 ? "<tr><td align=\"center\" colspan=\"9\"><font color=red>暂无记录</font></td></tr>" : ""%>
                        </tbody> </table>
                    </FooterTemplate>
                </asp:Repeater>
                <div class="pagelist">
                    <div class="l-btns">
                        <span>显示</span><asp:TextBox ID="txtPageNum" runat="server" MaxLength="3" CssClass="pagenum"
                            onkeydown="return checkNumber(event);" OnTextChanged="txtPageNum_TextChanged"
                            AutoPostBack="True"></asp:TextBox><span>条/页</span>
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
