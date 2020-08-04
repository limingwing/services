using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using WechatService;
using System.Drawing;

public partial class Example_TemplateMessage : WechatBasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            InitControls();
        }
    }

    /// <summary>
    /// 初始化控件，包括：公众号列表
    /// </summary>
    private void InitControls()
    {
        foreach (AccountInfo account in AccountInfoCollection.AccountInfos)
            lbPublicAccount.Items.Add(new ListItem(account.Caption, account.UserName));
        foreach (Industry industry in Industry.Industries)
            cblIndustry.Items.Add(new ListItem(string.Format("{0}-{1}", industry.PrimaryIndustry, industry.Name), industry.Code));
    }

    /// <summary>
    /// 设置所属行业
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnSetIndustry_Click(object sender, EventArgs e)
    {
        string userName = lbPublicAccount.SelectedValue;
        string industryCode1 = "", industryCode2 = "";
        int count = 0;
        foreach (ListItem item in cblIndustry.Items)
        {
            if (item.Selected)
            {
                count++;
                if (count == 1)
                    industryCode1 = item.Value;
                else if (count == 2)
                {
                    industryCode2 = item.Value;
                    break;
                }
            }
        }
        if (count != 2)
            ltrMessage.Text = "请选择两个行业。";
        else
        {
            ErrorMessage errorMessage = TemplateMessage.SetIndustry(userName, industryCode1, industryCode2);
            ltrMessage.Text = string.Format("设置所属行业{0}。{1}",
                errorMessage.IsSuccess ? "成功" : "失败",
                errorMessage.IsSuccess ? "" : errorMessage.ToString());
        }
    }

    /// <summary>
    /// 添加并模板id
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnGetTemplateId_Click(object sender, EventArgs e)
    {
        string userName = lbPublicAccount.SelectedValue;
        ErrorMessage errorMessage;
        string templateId = TemplateMessage.GetId(userName, txtTemplateIdShort.Text, out errorMessage);
        if (errorMessage.IsSuccess)
            ltrMessage.Text = string.Format("添加并获取模板id成功。模板id：{0}", templateId);
        else
            ltrMessage.Text = string.Format("添加并获取模板id失败。{0}", errorMessage.ToString());
    }

    /// <summary>
    /// 得到用户列表
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnGetUser_Click(object sender, EventArgs e)
    {
        string userName = lbPublicAccount.SelectedValue;
        ErrorMessage errorMessage;
        rblUser.Items.Clear();
        string[] openIds = UserManagement.GetUserList(userName);
        if (openIds != null && openIds.Length > 0)
        {
            foreach (string openId in openIds)
            {
                UserInfo user = UserManagement.GetUserInfo(userName, openId, out errorMessage);
                if (errorMessage.IsSuccess && user != null)
                    rblUser.Items.Add(new ListItem(user.nickname, openId));
            }
            ltrMessage.Text = "获取用户成功。";
        }
        else
            ltrMessage.Text = "获取用户失败。";
    }

    /// <summary>
    /// 发送模板消息
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnSend_Click(object sender, EventArgs e)
    {
        if (rblUser.SelectedIndex >= 0)
        {
            string userName = lbPublicAccount.SelectedValue;
            string openId = rblUser.SelectedValue;
            string templateId = txtID.Text;
            string title = txtTitle.Text;
            string name = txtUserName.Text;
            string time = DateTime.Now.ToString();
            Tuple<string, string, Color>[] data = new Tuple<string, string, Color>[]{
                new Tuple<string,string,Color>("title",title,Color.Blue),
                new Tuple<string,string,Color>("username",name,Color.Green),
                new Tuple<string,string,Color>("time",time,Color.Red)
            };
            ErrorMessage errorMessage;
            long msgId = TemplateMessage.Send(userName, rblUser.SelectedValue, templateId, "", Color.Black, data, out errorMessage);
            if (errorMessage.IsSuccess)
                ltrMessage.Text = string.Format("发送模板消息成功。消息id：{0}", msgId);
            else
                ltrMessage.Text = string.Format("发送模板消息失败。{0}", errorMessage);
        }
    }
}