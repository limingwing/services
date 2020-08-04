<%@ Page Language="C#" AutoEventWireup="true" CodeFile="xiaofei.aspx.cs" Inherits="manager_yeji_xiaofei" %>

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
        function opdg(s_type, s_url) {
            var t_width, t_height, t_title, t_url, t_id;
            t_id = 'w_1';
            switch (s_type) {
                case 'info':
                    t_width = 980;
                    t_height = 500;
                    t_title = '查看备注';
                    t_url = s_url;
                    break;
            }
            $.dialog({
                width: t_width,
                height: t_height,
                title: t_title,
                max: false,
                content: 'url:' + t_url
            });
        } 

    </script>
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
            <li><a href="#">电子钱包管理</a></li>
        </ul>
    </div>
    <div class="rightinfo">
        <dl class="seachform">
            <dd>
                <span class="rule-single-select">
                    <asp:DropDownList ID="type" runat="server">
                        <asp:ListItem Value="1" Selected="True">会员编号</asp:ListItem>
                        <asp:ListItem Value="2">会员姓名</asp:ListItem>
                        <%--     <asp:ListItem Value=3  >订单号</asp:ListItem>
                 <asp:ListItem Value=4  >服务中心</asp:ListItem>--%>
                    </asp:DropDownList>
                </span><span class="single-select">
                    <asp:TextBox ID="txtNote_no" runat="server" Width="120" CssClass="scinput"></asp:TextBox></span></dd>
            <dd style="display: none">
                <label>
                    投资类型</label>
                <span class="rule-single-select">
                    <asp:DropDownList ID="ddlproduct_category_id" runat="server" AutoPostBack="True"
                        OnSelectedIndexChanged="ddlproduct_category_id_SelectedIndexChanged1">
                        <asp:ListItem Value="0" Selected="True">--未选择--</asp:ListItem>
                        <asp:ListItem Value="1">活期</asp:ListItem>
                        <asp:ListItem Value="2">定投一年</asp:ListItem>
                        <asp:ListItem Value="3">虚拟本金</asp:ListItem>
                    </asp:DropDownList>
                </span>
            </dd>
            <dd style="display: none">
                <label>
                    状态</label>
                <span class="rule-single-select">
                    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlproduct_category_id_SelectedIndexChanged2">
                        <asp:ListItem Value="0" Selected="True">--未选择--</asp:ListItem>
                        <asp:ListItem Value="1">正常</asp:ListItem>
                        <asp:ListItem Value="2">已撤销</asp:ListItem>
                    </asp:DropDownList>
                </span>
            </dd>
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
            <dd class="toolbar1">
                <asp:LinkButton ID="btnExport" runat="server" CssClass="save" OnClick="btnExport_Click">   <li><span><img src="../../images/t04.png" /></span>导出Execl</li></asp:LinkButton>
            </dd>
        </dl>
        <!--列表-->
        <table class="tablelist">
            <thead>
                <tr>
                    <th width="40px;">
                        订单号
                    </th>
                    <th width="40px;">
                        订单类型
                    </th>
                    <th width="60px;">
                        会员编号
                    </th>
                    <th width="60px;">
                        会员姓名
                    </th>
                    <th width="60px;">
                        会员级别
                    </th>
                    <th width="100px;">
                        投资金额 <font color="red">(总累计:<asp:Literal ID="Literal_hj" runat="server"></asp:Literal>)</font>
                    </th>
                    <th width="40px;">
                        投资时间
                    </th>
                    <%--    <th width="40px;">犹豫期</th>
        <th width="40px;">分红天数</th>
 
        <th  width="150px;">投资类型</th>
        <th  width="50px;">冻结金额</th>
        <th width="20px;">收益率</th>
        <th width="100px;">修改收益</th>
          <th width="100px;">修改冻结金额</th>--%>
                    <th width="50px;">
                        状态
                    </th>
                </tr>
            </thead>
            <tbody>
                <asp:Repeater ID="rptList" runat="server" OnItemCommand="rptKindInfoList_ItemCommand">
                    <ItemTemplate>
                        <tr>
                            <td>
                                <a href="javascript:opdg('info','beizhu.aspx?id=<%# Eval("xiaofei_id")%>');" class="tablelink">
                                    <%# Eval("xiaofei_id")%></a>
                            </td>
                            <td>
                                <%#GetzhifuStatus1(Convert.ToInt32(Eval("zhuce_flag")))%>
                            </td>
                            <td>
                                <%# Eval("huiyuan_bianhao")%>
                            </td>
                            <td>
                                <%# Eval("huiyuan_name")%>
                            </td>
                            <td>
                                <%#new tbl_reg_jiebie().GetTitle(Convert.ToInt32( Eval("huiyuan_jiebie")))%>
                            </td>
                            <td>
                                <%#decimal.Parse(Eval("xiaofei_money", "{0:f}")) %>
                            </td>
                            <td>
                                <%# Eval("xiaofei_date")%>
                            </td>
                            <%--<td>
                                <%# Eval("fahuo_date")%>
                            </td>
                            <td>
                                <%# Eval("xiaofei_pro_count")%>天
                            </td>
                            <td>
                                <%#Getstatus(Convert.ToInt32(Eval("zhuce_flag")), Convert.ToInt32(Eval("wang_flag")))%>
                            </td>
                            <td>
                                <%#double.Parse(Eval("xiaofei_money1", "{0:f}"))%>
                            </td>
                            <td>
                                <%#double.Parse(Eval("fh_money").ToString()) * 100%>%
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox1" runat="server" CssClass="input small" MaxLength="15" sucmsg=""></asp:TextBox><asp:LinkButton
                                    ID="LinkButton3" runat="server" OnClientClick="return confirm('确定要充值吗？');" CommandArgument='<%# Eval("xiaofei_id")+","+(Container as RepeaterItem).ItemIndex%>'
                                    CommandName="save1"><font color =green>[修改]</font></asp:LinkButton>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox2" runat="server" CssClass="input small" MaxLength="15" sucmsg=""></asp:TextBox><asp:LinkButton
                                    ID="LinkButton1" runat="server" OnClientClick="return confirm('确定要修改冻结金额吗？');"
                                    CommandArgument='<%# Eval("xiaofei_id")+","+(Container as RepeaterItem).ItemIndex%>'
                                    CommandName="save2"><font color =green>[修改]</font></asp:LinkButton>
                            </td>--%>
                            <td>
                                <%#GetzhifuStatus(Convert.ToInt32(Eval("is_flag")))%>
                                <%--<asp:LinkButton ID="LinkButton2" runat="server" OnClientClick="return confirm('确定要退出计算吗？');"
                                    CommandArgument='<%# Eval("xiaofei_id")+","+(Container as RepeaterItem).ItemIndex%>'
                                    Visible='<%# !Convert.ToBoolean(Convert.ToInt16(Eval("is_flag"))) %>' CommandName="save6"><font color =green>[退出计算]</font></asp:LinkButton>--%>
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
