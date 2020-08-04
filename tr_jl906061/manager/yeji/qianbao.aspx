<%@ Page Language="C#" AutoEventWireup="true" CodeFile="qianbao.aspx.cs" Inherits="manager_yeji_qianbao" %>

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
            <li><a href="#">电子钱包管理</a></li>
        </ul>
    </div>
    <div class="rightinfo">
        <%-- <div class="tools">
    
    	<ul class="toolbar">
        <a href="add_touzi.aspx?action=Add"><li><span><img src="../../images/t01.png" /></span>追加投资</li></a>
    
         <a href="add_benjin.aspx?action=Add"><li><span><img src="../../images/t01.png" /></span>追加虚拟本金</li></a>
        </ul>        
       
    
    </div>--%>
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
                 <dd class="toolbar1">
        <asp:LinkButton ID="btnExport" runat="server" CssClass="save" onclick="btnExport_Click">   <li><span><img src="../../images/t04.png" /></span>导出Execl</li></asp:LinkButton>
        </dd>
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
                    <th>会员级别</th>
                    <%-- <th>奖励积分<font color="red">(总:<asp:Literal ID="Literal_hj" runat="server"></asp:Literal>)</font></th>
        <th>修改</th>--%>
                    <th>
                        消费积分<%--<font color="red">(总:<asp:Literal ID="Literal3" runat="server"></asp:Literal>)</font>--%>
                    </th>
                    <th>
                        修改
                    </th>
                    <%--<th>
                        购物积分 <font color="red">(总:<asp:Literal ID="Literal4" runat="server"></asp:Literal>)</font>
                    </th>
                    <th>
                        修改
                    </th>--%>
                    <%--<th>
                        分享积分 <font color="red">(总:<asp:Literal ID="Literal5" runat="server"></asp:Literal>)</font>
                    </th>
                    <th>
                        修改
                    </th>--%>
                  <%--  <th>
                        肽豆 <%--<font color="red">(总:<asp:Literal ID="Literal1" runat="server"></asp:Literal>)</font>
                    </th>
                    <th>
                        修改
                    </th>
                    <th>
                        消费佣金 <%--<font color="red">(总:<asp:Literal ID="Literal6" runat="server"></asp:Literal>)</font>
                    </th>
                    <th>
                        修改
                    </th>
                     <th>
                        领养金 <%--<font color="red">(总:<asp:Literal ID="Literal1" runat="server"></asp:Literal>)</font>
                    </th>
                    <th>
                        修改
                    </th>
                    <th>
                        代金券 <%--<font color="red">(总:<asp:Literal ID="Literal6" runat="server"></asp:Literal>)</font>
                    </th>
                    <th>
                        修改
                    </th>
                    <th>
                        奖金累计 <font color="red">(总:<asp:Literal ID="Literal2" runat="server"></asp:Literal>)</font>
                    </th>--%>
                </tr>
            </thead>
            <tbody>
                <asp:Repeater ID="rptList" runat="server" OnItemCommand="rptKindInfoList_ItemCommand">
                    <ItemTemplate>
                        <tr>
                            <td>
                                <%# pageSize * page + Container.ItemIndex + 1 - pageSize%>
                            </td>
                            <td>
                                <%# Eval("huiyuan_bianhao")%>
                            </td>
                            <td>
                                <%# Eval("huiyuan_name")%>
                            </td>
                            <td><%#new tbl_reg_jiebie().GetTitle(Convert.ToInt32(Eval("huiyuan_jiebie")))%></td>
                            <%-- <td> <%#decimal.Parse(Eval("qianbao", "{0:f}")) - decimal.Parse(Eval("fenhong_canshu1", "{0:f2}")) %></td>	
          <td>
            
            <asp:TextBox ID="TextBox2" runat="server" CssClass="input small"    MaxLength="15"   sucmsg=""  ></asp:TextBox><asp:LinkButton ID="lbtnSave" runat="server"    OnClientClick="return confirm('确定要充值吗？');" CommandArgument='<%# Eval("huiyuan_id")+","+(Container as RepeaterItem).ItemIndex%>'  CommandName="save"><font color =green>[修改]</font></asp:LinkButton></td>--%>
                            <td>
                                <%#decimal.Parse(Eval("chongfu_zong", "{0:f}"))%>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox4" runat="server" CssClass="input small" MaxLength="15" sucmsg=""></asp:TextBox><asp:LinkButton
                                    ID="LinkButton3" runat="server" OnClientClick="return confirm('确定要充值吗？');" CommandArgument='<%# Eval("huiyuan_id")+","+(Container as RepeaterItem).ItemIndex%>'
                                    CommandName="save3"><font color =green>[修改]</font></asp:LinkButton>
                            </td>
                            <%--<td>
                                <%#decimal.Parse(Eval("glf_money", "{0:f}"))%>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox5" runat="server" CssClass="input small" MaxLength="15" sucmsg=""></asp:TextBox><asp:LinkButton
                                    ID="LinkButton4" runat="server" OnClientClick="return confirm('确定要充值吗？');" CommandArgument='<%# Eval("huiyuan_id")+","+(Container as RepeaterItem).ItemIndex%>'
                                    CommandName="save4"><font color =green>[修改]</font></asp:LinkButton>
                            </td>--%>
                            <%--<td>
                                <%#decimal.Parse(Eval("fh_money", "{0:f}"))%>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox3" runat="server" CssClass="input small" MaxLength="15" sucmsg=""></asp:TextBox><asp:LinkButton
                                    ID="LinkButton2" runat="server" OnClientClick="return confirm('确定要充值吗？');" CommandArgument='<%# Eval("huiyuan_id")+","+(Container as RepeaterItem).ItemIndex%>'
                                    CommandName="save2"><font color =green>[修改]</font></asp:LinkButton>
                            </td>--%>
                          <%--  <td>
                                <%#decimal.Parse(Eval("jiangjin_zong", "{0:f}")) - decimal.Parse(Eval("jiangjin_yong", "{0:f2}"))%>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox1" runat="server" CssClass="input small" MaxLength="15" sucmsg=""></asp:TextBox><asp:LinkButton
                                    ID="LinkButton1" runat="server" OnClientClick="return confirm('确定要充值吗？');" CommandArgument='<%# Eval("huiyuan_id")+","+(Container as RepeaterItem).ItemIndex%>'
                                    CommandName="save1"><font color =green>[修改]</font></asp:LinkButton>
                            </td>
                            <td>
                                <%#decimal.Parse(Eval("jiangjing", "{0:f}"))%>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox6" runat="server" CssClass="input small" MaxLength="15" sucmsg=""></asp:TextBox><asp:LinkButton
                                    ID="LinkButton5" runat="server" OnClientClick="return confirm('确定要充值吗？');" CommandArgument='<%# Eval("huiyuan_id")+","+(Container as RepeaterItem).ItemIndex%>'
                                    CommandName="save5"><font color =green>[修改]</font></asp:LinkButton>
                            </td>

                            <td>
                                <%#decimal.Parse(Eval("chongfu_kechu", "{0:f}"))%>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox7" runat="server" CssClass="input small" MaxLength="15" sucmsg=""></asp:TextBox><asp:LinkButton
                                    ID="LinkButton6" runat="server" OnClientClick="return confirm('确定要充值吗？');" CommandArgument='<%# Eval("huiyuan_id")+","+(Container as RepeaterItem).ItemIndex%>'
                                    CommandName="save6"><font color =green>[修改]</font></asp:LinkButton>
                            </td>
                            <td>
                                <%#decimal.Parse(Eval("chongfu_money", "{0:f}"))%>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox8" runat="server" CssClass="input small" MaxLength="15" sucmsg=""></asp:TextBox><asp:LinkButton
                                    ID="LinkButton7" runat="server" OnClientClick="return confirm('确定要充值吗？');" CommandArgument='<%# Eval("huiyuan_id")+","+(Container as RepeaterItem).ItemIndex%>'
                                    CommandName="save7"><font color =green>[修改]</font></asp:LinkButton>
                            </td>
                            <td>
                                <%#decimal.Parse(Eval("huiyuan_yu", "{0:f}"))%>
                            </td>--%>
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
