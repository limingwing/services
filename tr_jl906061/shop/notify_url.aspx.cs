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
/// 功能：服务器异步通知页面
/// 版本：3.3
/// 日期：2012-07-10
/// 说明：
/// 以下代码只是为了方便商户测试而提供的样例代码，商户可以根据自己网站的需要，按照技术文档编写,并非一定要使用该代码。
/// 该代码仅供学习和研究支付宝接口使用，只是提供一个参考。
/// 
/// ///////////////////页面功能说明///////////////////
/// 创建该页面文件时，请留心该页面文件中无任何HTML代码及空格。
/// 该页面不能在本机电脑测试，请到服务器上做测试。请确保外部可以访问该页面。
/// 该页面调试工具请使用写文本函数logResult。
/// 如果没有收到该页面返回的 success 信息，支付宝会在24小时内按一定的时间策略重发通知
/// </summary>
public partial class notify_url : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SortedDictionary<string, string> sPara = GetRequestPost();

        if (sPara.Count > 0)//判断是否有带返回参数
        {
            Notify aliNotify = new Notify();
            bool verifyResult = aliNotify.Verify(sPara, Request.Form["notify_id"], Request.Form["sign"]);

            if (verifyResult)//验证成功
            {
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////
                //请在这里加上商户的业务逻辑程序代码


                //——请根据您的业务逻辑来编写程序（以下代码仅作参考）——
                //获取支付宝的通知返回参数，可参考技术文档中服务器异步通知参数列表

                //商户订单号

                string out_trade_no = Request.Form["out_trade_no"];

                //支付宝交易号

                string trade_no = Request.Form["trade_no"];

                //交易状态
                string trade_status = Request.Form["trade_status"];

                string money = Request.Form["total_fee"];

                if (Request.Form["trade_status"] == "TRADE_FINISHED")
                {
                    //判断该笔订单是否在商户网站中已经做过处理
                    //如果没有做过处理，根据订单号（out_trade_no）在商户网站的订单系统中查到该笔订单的详细，并执行商户的业务程序
                    //请务必判断请求时的total_fee、seller_id与通知时获取的total_fee、seller_id为一致的
                    //如果有做过处理，不执行商户的业务程序

                    //注意：
                    //退款日期超过可退款期限后（如三个月可退款），支付宝系统发送该交易状态通知
                }
                else if (Request.Form["trade_status"] == "TRADE_SUCCESS")
                {
                    //判断该笔订单是否在商户网站中已经做过处理
                    //如果没有做过处理，根据订单号（out_trade_no）在商户网站的订单系统中查到该笔订单的详细，并执行商户的业务程序
                    //请务必判断请求时的total_fee、seller_id与通知时获取的total_fee、seller_id为一致的
                    //如果有做过处理，不执行商户的业务程序

                    //注意：
                    //付款完成后，支付宝系统发送该交易状态通知
                    tbl_orders model = new tbl_orders();
                    model.GetModel(out_trade_no);
                    tbl_huiyuan model1 = new tbl_huiyuan();
                    model1.GetModel_hui_id(model.user_id);

                    if (int.Parse(model1.net_hege.ToString()) == 0)
                    {
                        int i = DbHelperSQL.ExecuteSql("exec sp_kaitong_huiyuan '" + model.user_id + "','A00000000'");
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
                            //    int i = DbHelperSQL.ExecuteSql("exec sp_kt003 '" + model.user_id + "','" + model.payable_amount + "'");

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
                            //    int i = DbHelperSQL.ExecuteSql("exec sp_kt004 '" + model.user_id + "','" + model.payable_amount + "'");
                            //}
                        }

                    }


                }
                else
                {
                }

                //——请根据您的业务逻辑来编写程序（以上代码仅作参考）——

                Response.Write("success");  //请不要修改或删除

                /////////////////////////////////////////////////////////////////////////////////////////////////////////////
            }
            else//验证失败
            {
                Response.Write("fail");
            }
        }
        else
        {
            Response.Write("无通知参数");
        }
    }

    /// <summary>
    /// 获取支付宝POST过来通知消息，并以“参数名=参数值”的形式组成数组
    /// </summary>
    /// <returns>request回来的信息组成的数组</returns>
    public SortedDictionary<string, string> GetRequestPost()
    {
        int i = 0;
        SortedDictionary<string, string> sArray = new SortedDictionary<string, string>();
        NameValueCollection coll;
        //Load Form variables into NameValueCollection variable.
        coll = Request.Form;

        // Get names of all forms into a string array.
        String[] requestItem = coll.AllKeys;

        for (i = 0; i < requestItem.Length; i++)
        {
            sArray.Add(requestItem[i], Request.Form[requestItem[i]]);
        }

        return sArray;
    }
}
