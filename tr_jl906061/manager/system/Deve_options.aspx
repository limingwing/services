<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Deve_options.aspx.cs" Inherits="manager_system_Deve_options" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>编辑商家</title>
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
         });
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div class="place">
        <span>位置：</span>
        <ul class="placeul">
            <li><a href="../index.aspx">首页</a></li>
            <li><a href="Deve_options.aspx">开发人员选项</a></li>
        </ul>
    </div>
    <div class="formbody">
        <div class="formtitle">
            <span>开发人员选项<font color="red">(备注：“开发人员选项”用户严禁有任何修改。)</font></span></div>
        <div class="tab-content">
            <dl>
                <dt>系统名称</dt>
                <dd>
                    <asp:TextBox ID="sys_name" runat="server" MaxLength="20" CssClass="input normal"
                        errormsg="" Width="150"></asp:TextBox>
                </dd>
            </dl>
           <%-- <dl>
                <dt>平台维护费</dt>
                <dd>
                    <asp:TextBox ID="TextBox59" runat="server" MaxLength="20" CssClass="input normal"
                        errormsg="" Width="150"></asp:TextBox>%
                </dd>
            </dl>
               <dl>
                <dt>系统产品税</dt>
                <dd>
                    <asp:TextBox ID="TextBox60" runat="server" MaxLength="20" CssClass="input normal"
                        errormsg="" Width="150"></asp:TextBox>%
                </dd>
            </dl>
            
            <dl>
                <dt>分享利润</dt>
                <dd>
                     VIP会员 分享同级或下级 享受一级<asp:TextBox ID="TextBox1" runat="server" MaxLength="20" CssClass="input normal"
                        errormsg="" Width="150"></asp:TextBox>% 二级<asp:TextBox ID="TextBox2" runat="server" MaxLength="20" CssClass="input normal"
                        errormsg="" Width="150"></asp:TextBox>% 下级分享上级 享受一级<asp:TextBox ID="TextBox3" runat="server" MaxLength="20" CssClass="input normal"
                        errormsg="" Width="150"></asp:TextBox>% 二级<asp:TextBox ID="TextBox4" runat="server" MaxLength="20" CssClass="input normal"
                        errormsg="" Width="150"></asp:TextBox>% 
                </dd>
                <dd>
                     金牌代理商 分享同级或下级 享受一级<asp:TextBox ID="TextBox12" runat="server" MaxLength="20" CssClass="input normal"
                        errormsg="" Width="150"></asp:TextBox>% 二级<asp:TextBox ID="TextBox13" runat="server" MaxLength="20" CssClass="input normal"
                        errormsg="" Width="150"></asp:TextBox>% 下级分享上级 享受一级<asp:TextBox ID="TextBox14" runat="server" MaxLength="20" CssClass="input normal"
                        errormsg="" Width="150"></asp:TextBox>% 二级<asp:TextBox ID="TextBox15" runat="server" MaxLength="20" CssClass="input normal"
                        errormsg="" Width="150"></asp:TextBox>% 
                </dd>
                <dd>
                     首席 分享同级或下级 享受一级<asp:TextBox ID="TextBox16" runat="server" MaxLength="20" CssClass="input normal"
                        errormsg="" Width="150"></asp:TextBox>% 二级<asp:TextBox ID="TextBox17" runat="server" MaxLength="20" CssClass="input normal"
                        errormsg="" Width="150"></asp:TextBox>% 下级分享上级 享受一级<asp:TextBox ID="TextBox18" runat="server" MaxLength="20" CssClass="input normal"
                        errormsg="" Width="150"></asp:TextBox>% 二级<asp:TextBox ID="TextBox19" runat="server" MaxLength="20" CssClass="input normal"
                        errormsg="" Width="150"></asp:TextBox>% 
                </dd>
                <dd>
                     联合创始人 分享同级或下级 享受一级<asp:TextBox ID="TextBox20" runat="server" MaxLength="20" CssClass="input normal"
                        errormsg="" Width="150"></asp:TextBox>% 二级<asp:TextBox ID="TextBox21" runat="server" MaxLength="20" CssClass="input normal"
                        errormsg="" Width="150"></asp:TextBox>% 下级分享上级 享受一级<asp:TextBox ID="TextBox22" runat="server" MaxLength="20" CssClass="input normal"
                        errormsg="" Width="150"></asp:TextBox>% 二级<asp:TextBox ID="TextBox23" runat="server" MaxLength="20" CssClass="input normal"
                        errormsg="" Width="150"></asp:TextBox>% 
                </dd>
                <dd>
                     分公司 分享下级 享受一级<asp:TextBox ID="TextBox31" runat="server" MaxLength="20" CssClass="input normal"
                        errormsg="" Width="150"></asp:TextBox>% 二级<asp:TextBox ID="TextBox32" runat="server" MaxLength="20" CssClass="input normal"
                        errormsg="" Width="150"></asp:TextBox>% 
                </dd>
                <dd>
                     2万分享分公司：一次性给与<asp:TextBox ID="TextBox35" runat="server" MaxLength="20" CssClass="input normal"
                        errormsg="" Width="150"></asp:TextBox>%奖励 后续进货业绩<asp:TextBox ID="TextBox36" runat="server" MaxLength="20" CssClass="input normal"
                        errormsg="" Width="150"></asp:TextBox>% 10万分享分公司：一次性给与<asp:TextBox ID="TextBox43" runat="server" MaxLength="20" CssClass="input normal"
                        errormsg="" Width="150"></asp:TextBox>%奖励 后续进货业绩<asp:TextBox ID="TextBox44" runat="server" MaxLength="20" CssClass="input normal"
                        errormsg="" Width="150"></asp:TextBox>%
                        30万分享分公司：一次性给与<asp:TextBox ID="TextBox45" runat="server" MaxLength="20" CssClass="input normal"
                        errormsg="" Width="150"></asp:TextBox>%奖励 后续进货业绩<asp:TextBox ID="TextBox46" runat="server" MaxLength="20" CssClass="input normal"
                        errormsg="" Width="150"></asp:TextBox>% 分公司分享分公司<asp:TextBox ID="TextBox37" runat="server" MaxLength="20" CssClass="input normal"
                        errormsg="" Width="150"></asp:TextBox>% 特享分公司全业绩进货提成<asp:TextBox ID="TextBox38" runat="server" MaxLength="20" CssClass="input normal"
                        errormsg="" Width="150"></asp:TextBox>%
                </dd>
            </dl>
      <dl>
                <dt>管理奖</dt>
                <dd>
                         2万以上级别满足有<asp:TextBox ID="TextBox39" runat="server" MaxLength="20" CssClass="input normal"
                        errormsg="" Width="150"></asp:TextBox>个直推 同级或高级以上团队<asp:TextBox ID="TextBox40" runat="server" MaxLength="20" CssClass="input normal"
                        errormsg="" Width="150"></asp:TextBox>个 
                      2万<asp:TextBox ID="TextBox5" runat="server" MaxLength="20" CssClass="input normal"
                        errormsg="" Width="150"></asp:TextBox>% 周封顶<asp:TextBox ID="TextBox6" runat="server" MaxLength="20" CssClass="input normal"
                        errormsg="" Width="150"></asp:TextBox>元 10万<asp:TextBox ID="TextBox7" runat="server" MaxLength="20" CssClass="input normal"
                        errormsg="" Width="150"></asp:TextBox>% 周封顶<asp:TextBox ID="TextBox8" runat="server" MaxLength="20" CssClass="input normal"
                        errormsg="" Width="150"></asp:TextBox>元 30万<asp:TextBox ID="TextBox9" runat="server" MaxLength="20" CssClass="input normal"
                        errormsg="" Width="150"></asp:TextBox>% 周封顶<asp:TextBox ID="TextBox10" runat="server" MaxLength="20" CssClass="input normal"
                        errormsg="" Width="150"></asp:TextBox>元 130万<asp:TextBox ID="TextBox33" runat="server" MaxLength="20" CssClass="input normal"
                        errormsg="" Width="150"></asp:TextBox>% 周封顶<asp:TextBox ID="TextBox34" runat="server" MaxLength="20" CssClass="input normal"
                        errormsg="" Width="150"></asp:TextBox>元
                </dd>
            </dl>

            <dl>
                <dt>拿货折扣</dt>
                <dd>
                      会员<asp:TextBox ID="TextBox24" runat="server" MaxLength="20" CssClass="input normal"
                        errormsg="" Width="150"></asp:TextBox>折 金牌代理商<asp:TextBox ID="TextBox25" runat="server" MaxLength="20" CssClass="input normal"
                        errormsg="" Width="150"></asp:TextBox>折 首席<asp:TextBox ID="TextBox26" runat="server" MaxLength="20" CssClass="input normal"
                        errormsg="" Width="150"></asp:TextBox>折 联合创始人<asp:TextBox ID="TextBox27" runat="server" MaxLength="20" CssClass="input normal"
                        errormsg="" Width="150"></asp:TextBox>折 分公司 <asp:TextBox ID="TextBox28" runat="server" MaxLength="20" CssClass="input normal"
                        errormsg="" Width="150"></asp:TextBox>折
                </dd>
            </dl>
            
            <dl>
                <dt>发货奖</dt>
                <dd>
                    <asp:TextBox ID="TextBox48" runat="server" MaxLength="20" CssClass="input normal"
                        errormsg="" Width="150"></asp:TextBox>%
                </dd>
            </dl>
             <dl>
                <dt>业绩升级</dt>
                <dd>
                 VIP会员 直推<asp:TextBox ID="TextBox41" runat="server" MaxLength="20" CssClass="input normal"
                        errormsg="" Width="150"></asp:TextBox>个 团队<asp:TextBox ID="TextBox42" runat="server" MaxLength="20" CssClass="input normal"
                        errormsg="" Width="150"></asp:TextBox>个
                    金牌代理商 直推<asp:TextBox ID="TextBox29" runat="server" MaxLength="20" CssClass="input normal"
                        errormsg="" Width="150"></asp:TextBox>个 团队<asp:TextBox ID="TextBox30" runat="server" MaxLength="20" CssClass="input normal"
                        errormsg="" Width="150"></asp:TextBox>个
                </dd>
            </dl>
            <dl>
                <dt>报单中心报单奖励</dt>
                <dd>
                    <asp:TextBox ID="TextBox47" runat="server" MaxLength="20" CssClass="input normal"
                        errormsg="" Width="150"></asp:TextBox>%
                </dd>
            </dl>
            <dl>
                <dt>直推下级进货</dt>
                <dd>
                      VIP会员 零售<asp:TextBox ID="TextBox49" runat="server" MaxLength="20" CssClass="input normal"
                        errormsg="" Width="150"></asp:TextBox>% <br />金牌代理商 零售<asp:TextBox ID="TextBox50" runat="server" MaxLength="20" CssClass="input normal"
                        errormsg="" Width="150"></asp:TextBox>% VIP会员<asp:TextBox ID="TextBox51" runat="server" MaxLength="20" CssClass="input normal"
                        errormsg="" Width="150"></asp:TextBox>% <br />首席 零售<asp:TextBox ID="TextBox52" runat="server" MaxLength="20" CssClass="input normal"
                        errormsg="" Width="150"></asp:TextBox>% VIP会员<asp:TextBox ID="TextBox53" runat="server" MaxLength="20" CssClass="input normal"
                        errormsg="" Width="150"></asp:TextBox>% 金牌代理商<asp:TextBox ID="TextBox54" runat="server" MaxLength="20" CssClass="input normal"
                        errormsg="" Width="150"></asp:TextBox>% <br />联合创始人 零售<asp:TextBox ID="TextBox55" runat="server" MaxLength="20" CssClass="input normal"
                        errormsg="" Width="150"></asp:TextBox>% VIP会员<asp:TextBox ID="TextBox56" runat="server" MaxLength="20" CssClass="input normal"
                        errormsg="" Width="150"></asp:TextBox>% 金牌代理商<asp:TextBox ID="TextBox57" runat="server" MaxLength="20" CssClass="input normal"
                        errormsg="" Width="150"></asp:TextBox>% 首席<asp:TextBox ID="TextBox58" runat="server" MaxLength="20" CssClass="input normal"
                        errormsg="" Width="150"></asp:TextBox>% <br />分公司 零售<asp:TextBox ID="TextBox61" runat="server" MaxLength="20" CssClass="input normal"
                        errormsg="" Width="150"></asp:TextBox>% VIP会员<asp:TextBox ID="TextBox62" runat="server" MaxLength="20" CssClass="input normal"
                        errormsg="" Width="150"></asp:TextBox>% 金牌代理商<asp:TextBox ID="TextBox63" runat="server" MaxLength="20" CssClass="input normal"
                        errormsg="" Width="150"></asp:TextBox>% 首席<asp:TextBox ID="TextBox64" runat="server" MaxLength="20" CssClass="input normal"
                        errormsg="" Width="150"></asp:TextBox>% 联合创始人<asp:TextBox ID="TextBox65" runat="server" MaxLength="20" CssClass="input normal"
                        errormsg="" Width="150"></asp:TextBox>% 间推 <asp:TextBox ID="TextBox66" runat="server" MaxLength="20" CssClass="input normal"
                        errormsg="" Width="150"></asp:TextBox>%
                </dd>
                <dt>直推上级或同级进货</dt>
                <dd>
                      <asp:TextBox ID="TextBox11" runat="server" MaxLength="20" CssClass="input normal"
                        errormsg="" Width="150"></asp:TextBox>% 间推 <asp:TextBox ID="TextBox67" runat="server" MaxLength="20" CssClass="input normal"
                        errormsg="" Width="150"></asp:TextBox>%
                </dd>
            </dl>--%>
            <dl style="width: 100%; margin: 0; padding: 0; text-align: center; }">
                <asp:Button ID="btnSubmit" runat="server" Text="提交保存" CssClass="btn" OnClick="btnSubmit_Click" />
                <input name="btnReturn" type="button" value="返回上一页" class="btn yellow" onclick="javascript:history.back(-1);" />
            </dl>
            <!--工具栏-->
            <div class="page-footer">
                <div class="btn-list">
                </div>
                <div class="clear">
                </div>
            </div>
        </div>
        <!--/商家信息-->
    </div>
    <!--/工具栏-->
    <div class="rightinfo">
        <div class="tools">
            <ul class="toolbar">
                <a href="Deve_jiebie_edit.aspx?action=Add">
                    <li><span>
                        <img src="../../images/t01.png" /></span>添加级别</li></a>
            </ul>
            <ul class="toolbar1">
                <asp:LinkButton ID="btnSave" runat="server" CssClass="save" OnClick="btnSave_Click"> <li><span><img src="../../images/t05.png" /></span>保存排序</li></asp:LinkButton>
            </ul>
        </div>
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
                                级别名称
                            </th>
                            <th width="10%">
                                级别赋值
                            </th>
                            <th width="10%">
                                注册所需金额
                            </th>
                            <th width="10%">
                                注册是否启用
                            </th>
                            <th width="10%">
                                排序号
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
                        <%# Eval("jiebie_name")%>
                    </td>
                    <td>
                        <%# Eval("jiebie_value")%>
                    </td>
                    <td>
                        <%# Eval("need_money")%>
                    </td>
                    <td>
                        <%# Convert.ToInt32(Eval("show_flag")) == 0 ? "<font color=red>不启用</font>" : "<font color=green>启用中</font>"%>
                    </td>
                    <td>
                        <asp:TextBox ID="txtSortId" runat="server" Height="25" Text='<%#Eval("sort_id")%>'
                            CssClass="scinput" Width="40" onkeydown="return checkNumber(event);" />
                    </td>
                    <td>
                        <a href="Deve_jiebie_edit.aspx?action=Edit&id=<%#Eval("id")%>&page=<%=page%>" class="tablelink">
                            <font color="green">[修改]</font></a> &nbsp;&nbsp;<asp:LinkButton ID="lbtnDelCa" runat="server"
                                CommandArgument='<%# Eval("id")%>' OnClientClick="return confirm('是否真的要删除？')"
                                OnClick="lbtnDelCa_Click"><font color =red>[删除]</font></asp:LinkButton>
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
