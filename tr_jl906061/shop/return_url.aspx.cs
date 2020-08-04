using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Collections.Specialized;
using System.Collections.Generic;
using Com.Alipay;

/// <summary>
/// 功能：页面跳转同步通知页面
/// 版本：3.3
/// 日期：2012-07-10
/// 说明：
/// 以下代码只是为了方便商户测试而提供的样例代码，商户可以根据自己网站的需要，按照技术文档编写,并非一定要使用该代码。
/// 该代码仅供学习和研究支付宝接口使用，只是提供一个参考。
/// 
/// ///////////////////////页面功能说明///////////////////////
/// 该页面可在本机电脑测试
/// 可放入HTML等美化页面的代码、商户业务逻辑程序代码
/// 该页面可以使用ASP.NET开发工具调试，也可以使用写文本函数LogResult进行调试
/// </summary>
public partial class return_url : A_BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SortedDictionary<string, string> sPara = GetRequestGet();

        if (sPara.Count > 0)//判断是否有带返回参数
        {
            Notify aliNotify = new Notify();
            bool verifyResult = aliNotify.Verify(sPara, Request.QueryString["notify_id"], Request.QueryString["sign"]);

            if (verifyResult)//验证成功
            {
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////
                //请在这里加上商户的业务逻辑程序代码


                //——请根据您的业务逻辑来编写程序（以下代码仅作参考）——
                //获取支付宝的通知返回参数，可参考技术文档中页面跳转同步通知参数列表

                //商户订单号
                string out_trade_no = Request.QueryString["out_trade_no"];

                //支付宝交易号
                string trade_no = Request.QueryString["trade_no"];

                //交易状态
                string trade_status = Request.QueryString["trade_status"];

                string money = Request.QueryString["total_fee"];


                if (Request.QueryString["trade_status"] == "TRADE_FINISHED" || Request.QueryString["trade_status"] == "TRADE_SUCCESS")
                {
                    //判断该笔订单是否在商户网站中已经做过处理
                    //如果没有做过处理，根据订单号（out_trade_no）在商户网站的订单系统中查到该笔订单的详细，并执行商户的业务程序
                    //如果有做过处理，不执行商户的业务程序
                    tbl_huiyuan model1 = new tbl_huiyuan();
                    model1.GetModel_hui_id(hy_id1);
                    tbl_orders model = new tbl_orders();
                    model.GetModel(out_trade_no);
                    if (int.Parse(model1.net_hege.ToString()) == 0)
                    {
                        int i = DbHelperSQL.ExecuteSql("exec sp_kaitong_huiyuan '" + hy_id1 + "','A00000000'");
                    }
                    else
                    {
                        model.payment_status = 2;
                        model.status = 2;

                        model.address = model1.Getshen("ProID=" + model1.bid.ToString() + "", "ProName") + model1.Getshi("CityID=" + model1.mmid.ToString() + "", "CityName") + model1.Getxian("Id=" + model1.sid.ToString() + "", "DisName") + model1.huiyuan_address;
                        model.shouhuo_name = model1.huiyuan_name;
                        model.phone = model1.huiyuan_mob;
                        if (model.Update())
                        {
                            //tbl_reg_jiebie reg = new tbl_reg_jiebie();
                            //reg.GetModeljibie(int.Parse(model1.huiyuan_jiebie.ToString()));
                            //if (model.flag == 0)
                            //{
                            //    if (model.real_amount > reg.need_money)
                            //    {
                            //        if (model.real_amount >= 2000 && model.real_amount < 5000)
                            //        {
                            //            model1.huiyuan_jiebie = 2;
                            //        }
                            //        if (model.real_amount >= 5000 && model.real_amount < 10000)
                            //        {
                            //            model1.huiyuan_jiebie = 3;
                            //        }
                            //        if (model.real_amount >= 10000 && model.real_amount < 30000)
                            //        {
                            //            model1.huiyuan_jiebie = 4;
                            //        }
                            //        if (model.real_amount >= 30000 && model.real_amount < 50000)
                            //        {
                            //            model1.huiyuan_jiebie = 5;
                            //        }
                            //        if (model.real_amount >= 50000 && model.real_amount < 1000000)
                            //        {
                            //            model1.huiyuan_jiebie = 6;
                            //        }
                            //        if (model.real_amount >= 1000000)
                            //        {
                            //            model1.huiyuan_jiebie = 7;
                            //        }
                            //        model1.Update();
                            //    }

                            //    tbl_xiaofei model_xf = new tbl_xiaofei();
                            //    model_xf.xiaofei_hui_id = model.user_id;
                            //    model_xf.xiaofei_money = model.payable_amount;
                            //    model_xf.xiaofei_money1 = model.payable_amount;
                            //    model_xf.zhuce_flag = 2;//升级
                            //    model_xf.xiaofei_qr_date = DateTime.Now;
                            //    model_xf.xiaofei_qr_flag = 1;
                            //    model_xf.Add();
                            //    int i = DbHelperSQL.ExecuteSql("exec sp_kt003 '" + hy_id1 + "','"+ model.payable_amount + "'");
                            //}
                            //else
                            //{
                            //    tbl_xiaofei model_xf = new tbl_xiaofei();
                            //    model_xf.xiaofei_hui_id = model.user_id;
                            //    model_xf.xiaofei_money = model.payable_amount;
                            //    model_xf.xiaofei_money1 = model.payable_amount;
                            //    model_xf.zhuce_flag = 3;//折扣
                            //    model_xf.xiaofei_qr_date = DateTime.Now;
                            //    model_xf.xiaofei_qr_flag = 1;
                            //    model_xf.Add();
                            //    int i = DbHelperSQL.ExecuteSql("exec sp_kt004 '" + hy_id1 + "','"+ model.payable_amount + "'");
                            //}

                        }
                    }
                }
                else
                {
                    Response.Write("trade_status=" + Request.QueryString["trade_status"]);
                }

                //打印页面
                this.msg.InnerText="验证成功";

                //——请根据您的业务逻辑来编写程序（以上代码仅作参考）——

                /////////////////////////////////////////////////////////////////////////////////////////////////////////////
            }
            else//验证失败
            {
                this.msg.InnerText="验证失败";
            }
        }
        else
        {
            Response.Write("无返回参数");
        }
    }

    /// <summary>
    /// 获取支付宝GET过来通知消息，并以“参数名=参数值”的形式组成数组
    /// </summary>
    /// <returns>request回来的信息组成的数组</returns>
    public SortedDictionary<string, string> GetRequestGet()
    {
        int i = 0;
        SortedDictionary<string, string> sArray = new SortedDictionary<string, string>();
        NameValueCollection coll;
        //Load Form variables into NameValueCollection variable.
        coll = Request.QueryString;

        // Get names of all forms into a string array.
        String[] requestItem = coll.AllKeys;

        for (i = 0; i < requestItem.Length; i++)
        {
            sArray.Add(requestItem[i], Request.QueryString[requestItem[i]]);
        }

        return sArray;
    }
}
