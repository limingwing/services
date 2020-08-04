using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

/// <summary>
///ResultNotify 的摘要说明
/// </summary>
public class ResultNotify : Notify
{
    public ResultNotify(Page page) : base(page)
    {
    }

    public override void ProcessNotify()
    {
        WxPayData notifyData = GetNotifyData();

        //检查支付结果中transaction_id是否存在
        if (!notifyData.IsSet("transaction_id"))
        {
            //若transaction_id不存在，则立即返回结果给微信支付后台
            WxPayData res = new WxPayData();
            res.SetValue("return_code", "FAIL");
            res.SetValue("return_msg", "支付结果中微信订单号不存在");
            Log.Error(this.GetType().ToString(), "The Pay result is error : " + res.ToXml());
            page.Response.Write(res.ToXml());
            page.Response.End();
        }

        string transaction_id = notifyData.GetValue("transaction_id").ToString();
        string out_trade_no = notifyData.GetValue("out_trade_no").ToString();

        //查询订单，判断订单真实性
        if (!QueryOrder(transaction_id))
        {
            //若订单查询失败，则立即返回结果给微信支付后台
            WxPayData res = new WxPayData();
            res.SetValue("return_code", "FAIL");
            res.SetValue("return_msg", "订单查询失败");
            Log.Error(this.GetType().ToString(), "Order query failure : " + res.ToXml());
            page.Response.Write(res.ToXml());
            page.Response.End();
        }
        //查询订单成功
        else
        {
          

            WxPayData res = new WxPayData();
            res.SetValue("return_code", "SUCCESS");
            res.SetValue("return_msg", "OK");
            tbl_canshu canshu = new tbl_canshu();
            canshu.GetModel(1);
            canshu.canshu_gonggao = out_trade_no;
            canshu.sys_name = transaction_id;
            canshu.Update();
            tbl_orders orders = new tbl_orders();
            orders.GetModel(out_trade_no);
            tbl_huiyuan huiyuan = new tbl_huiyuan();
            huiyuan.GetModel_hui_bianhao(orders.user_bianhao);
            huiyuan.huiyuan_jiebie = 1;
            huiyuan.Update();
            int id = orders.id;
            if (orders.payment_status != 2)
            {
                orders.payment_status = 2;
                orders.Update();
                DbHelperSQL.ExecuteSql("exec sp_zhixing '" + orders.user_id + "'," + orders.order_amount + "");
                DbHelperSQL.ExecuteSql("exec sp_jiangjin_4 '" + orders.user_id + "'");
            }
             
        }
    }

    //查询订单
    private bool QueryOrder(string transaction_id)
    {
        WxPayData req = new WxPayData();
        req.SetValue("transaction_id", transaction_id);
        WxPayData res = WxPayApi.OrderQuery(req);
        if (res.GetValue("return_code").ToString() == "SUCCESS" &&
            res.GetValue("result_code").ToString() == "SUCCESS")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}