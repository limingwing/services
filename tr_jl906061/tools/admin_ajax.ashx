<%@ WebHandler Language="C#" Class="admin_ajax" %>

using System;
using System.IO;
using System.Net;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.SessionState;


public class admin_ajax : IHttpHandler, IRequiresSessionState
{

    public void ProcessRequest(HttpContext context)
    {
        //取得处事类型
        string action = AXRequest.GetQueryString("action");

        switch (action)
        {
            case "manager_validate": //验证管理员用户名是否重复
                manager_validate(context);
                break;
            case "huiyuan_validate": //验证管理员用户名是否重复
                huiyuan_validate(context);
                break;
            case "code_validate": //验证商品名称是否重复
                code_validate(context);
                break;
            case "tjr_validate": //验证推荐人是否存在
                tjr_validate(context);
                break;
            case "jdr_validate": //验证接点人是否存在
                jdr_validate(context);
                break;
            case "jsr_validate": //验证接点人是否存在
                jsr_validate(context);
                break; 
            case "edit_order_status": //修改订单信息和状态
               edit_order_status(context);
               break;

            case "bianhao_name": //修改订单信息和状态
               bianhao_name(context);
               break;
          
                
        }

    }

    #region 修改订单信息和状态==============================
    private void edit_order_status(HttpContext context)
    {
        //取得登录信息
        ManagePage mym = new ManagePage();
        if (!mym.IsAdminLogin())
        {
            context.Response.Write("{\"status\": 0, \"msg\": \"未登录或已超时，请重新登录！\"}");
            return;
        }

        string order_no = AXRequest.GetString("order_no");
        string edit_type = AXRequest.GetString("edit_type");

        if (order_no == "")
        {
            context.Response.Write("{\"status\": 0, \"msg\": \"传输参数有误，无法获取订单号！\"}");
            return;
        }
        if (edit_type == "")
        {
            context.Response.Write("{\"status\": 0, \"msg\": \"无法获取修改订单类型！\"}");
            return;
        }
        tbl_orders model = new tbl_orders();
        model.GetModel(order_no);
        if (!model.Exists(order_no))
        {
            context.Response.Write("{\"status\": 0, \"msg\": \"订单号不存在或已被删除！\"}");
            return;
        }
        switch (edit_type.ToLower())
        {
            case "order_confirm": //确认订单

                if (model.status > 1)
                {
                    context.Response.Write("{\"status\": 0, \"msg\": \"订单已经确认，不能重复处理！\"}");
                    return;
                }
                model.status = 2;
                model.confirm_time = DateTime.Now;
                if (!model.Update())
                {
                    context.Response.Write("{\"status\": 0, \"msg\": \"订单确认失败！\"}");
                    return;
                }
                else//增加订单销售记录
                {
                    //ps_salse_depot model1 = new ps_salse_depot();
                    //model1.note_no = order_no;
                    //model1.depot_category_id = model.depot_category_id;
                    //model1.add_time = DateTime.Now;
                    //model1.depot_id = model.depot_id;
                    //model1.order_id = model.id;
                    //model1.user_id = model.user_id;

                    //ps_order_goods bll = new ps_order_goods();
                    //DataTable dt = bll.GetList(model.id);
                    //foreach (DataRow dr in dt.Rows)
                    //{
                    //    model1.goods_id = int.Parse(dr["goods_id"].ToString());
                    //    model1.goods_title = dr["goods_title"].ToString().Trim();
                    //    model1.goods_price = Convert.ToDecimal(dr["goods_price"].ToString());
                    //    model1.real_price = Convert.ToDecimal(dr["real_price"].ToString());
                    //    model1.quantity = int.Parse(dr["quantity"].ToString());
                    //    model1.here_depot_id = int.Parse(dr["goods_id"].ToString());

                    //    ps_here_depot model2 = new ps_here_depot();
                    //    model2.GetModel(int.Parse(dr["goods_id"].ToString()));
                    //    model2.product_num = int.Parse(model2.product_num.ToString()) - int.Parse(dr["quantity"].ToString());
                    //    model2.UpdateALL();
                    //    model1.Add();
                    //}

                }
                context.Response.Write("{\"status\": 1, \"msg\": \"订单确认成功！\"}");
                break;

            case "order_complete": //完成订单=========================================

                if (model.status > 2)
                {
                    context.Response.Write("{\"status\": 0, \"msg\": \"订单已经完成，不能重复处理！\"}");
                    return;
                }
                model.status = 3;
                model.complete_time = DateTime.Now;
                if (!model.Update())
                {
                    context.Response.Write("{\"status\": 0, \"msg\": \"确认订单完成失败！\"}");
                    return;
                }

                context.Response.Write("{\"status\": 1, \"msg\": \"确认订单完成成功！\"}");
                break;
            case "order_cancel": //取消订单==========================================

                if (model.status > 2)
                {
                    context.Response.Write("{\"status\": 0, \"msg\": \"订单已经完成，不能取消订单！\"}");
                    return;
                }
                model.status = 4;
                if (!model.Update())
                {
                    context.Response.Write("{\"status\": 0, \"msg\": \"取消订单失败！\"}");
                    return;
                }

                context.Response.Write("{\"status\": 1, \"msg\": \"取消订单成功！\"}");
                break;

            case "edit_accept_info": //修改订单备注=================================
                string remark = AXRequest.GetFormString("remark");
                string address = AXRequest.GetFormString("address");
                string mobile = AXRequest.GetFormString("mobile");
                string accept_name = AXRequest.GetFormString("accept_name");
                string bianhao = AXRequest.GetFormString("telphone");
                if (address == "")
                {
                    context.Response.Write("{\"status\": 0, \"msg\": \"请填写地址！\"}");
                    return;
                }
                model.address = address;
                model.phone = mobile;
                model.shouhuo_name = accept_name;
                model.remark = remark;
                if (!model.Update())
                {
                    
                    context.Response.Write("{\"status\": 0, \"msg\": \"修改订单信息失败！\"}");
                    return;
                }
                //tbl_huiyuan huiyuan = new tbl_huiyuan();
                //huiyuan.GetModel_hui_bianhao(bianhao);
                //tbl_xiaofei xiaofei = new tbl_xiaofei();
                //    xiaofei.GetModel_pid(model.id);
                //    xiaofei.xiaofei_zhuanmai = huiyuan.huiyuan_id;
                //    xiaofei.Update();
                context.Response.Write("{\"status\": 1, \"msg\": \"修改订单信息成功！\"}");
                break;

            case "edit_accept_wuliu": //修改订单备注=================================
                string wuliu_company1 = AXRequest.GetFormString("wuliu_company1");
                string wuliu_no1 = AXRequest.GetFormString("wuliu_no1");



                model.wuliu_company = wuliu_company1;
                model.wuliu_no = wuliu_no1;
        
                if (!model.Update())
                {
                    context.Response.Write("{\"status\": 0, \"msg\": \"修改物流信息失败！\"}");
                    return;
                }
                context.Response.Write("{\"status\": 1, \"msg\": \"修改物流信息成功！\"}");
                break;

            case "edit_payment_fee": //调整商品总金额================================

                if (model.status > 1)
                {
                    context.Response.Write("{\"status\": 0, \"msg\": \"订单已经确认，不能调整商品实际总金额！\"}");
                    return;
                }
                decimal payment_fee = AXRequest.GetFormDecimal("payment_fee", 0);

                model.order_amount = payment_fee;
                model.real_amount = payment_fee - model.payable_amount;
                if (!model.Update())
                {
                    context.Response.Write("{\"status\": 0, \"msg\": \"调整商品实际总金额失败！\"}");
                    return;
                }
                context.Response.Write("{\"status\": 1, \"msg\": \"调整商品实际总金额成功！\"}");
                break;
        }

    }
    #endregion

    #region 验证用户账号是否重复========================
    private void huiyuan_validate(HttpContext context)
    {
        string user_name = AXRequest.GetString("param");
        if (string.IsNullOrEmpty(user_name))
        {
            context.Response.Write("{ \"info\":\"请输入会员编号\", \"status\":\"n\" }");
            return;
        }
        tbl_huiyuan bll = new tbl_huiyuan();
        if (bll.Exists_hui_bianhao(user_name))
        {
            context.Response.Write("{ \"info\":\"会员编号已被占用，请更换！\", \"status\":\"n\" }");
            return;
        }
        context.Response.Write("{ \"info\":\"会员编号可使用\", \"status\":\"y\" }");
        return;
    }
    #endregion


    #region 验证推荐人是否存在========================
    private void tjr_validate(HttpContext context)
    {
        string user_name = AXRequest.GetString("param");
        if (string.IsNullOrEmpty(user_name))
        {
            context.Response.Write("{ \"info\":\"请输入推荐人编号\", \"status\":\"n\" }");
            return;
        }
        tbl_huiyuan bll = new tbl_huiyuan();
        if (bll.Exists_hui_bianhao(user_name))
        {

            bll.GetModel_hui_bianhao(user_name);
            string huiyuan_name = bll.huiyuan_name;
            context.Response.Write("{ \"info\":\"推荐人姓名：" + huiyuan_name + "\", \"status\":\"y\" }");
            return;
        }
        context.Response.Write("{ \"info\":\"对不起没有该推荐人\", \"status\":\"n\" }");
        return;
    }
    #endregion


    #region 验证姓名========================
    private void bianhao_name(HttpContext context)
    {
        string user_name = AXRequest.GetString("param");
        if (string.IsNullOrEmpty(user_name))
        {
            context.Response.Write("{ \"info\":\"请输入编号\", \"status\":\"n\" }");
            return;
        }
        tbl_huiyuan bll = new tbl_huiyuan();
        if (bll.Exists_hui_bianhao(user_name))
        {

            bll.GetModel_hui_bianhao(user_name);
            string huiyuan_name = bll.huiyuan_name;
            context.Response.Write("{ \"info\":\"姓名：" + huiyuan_name + "\", \"status\":\"y\" }");
            return;
        }
        context.Response.Write("{ \"info\":\"对不起没有该会员\", \"status\":\"n\" }");
        return;
    }
    #endregion

    #region 验证会员编号是否存在========================
    private void jsr_validate(HttpContext context)
    {
        string user_name = AXRequest.GetString("param");
        if (string.IsNullOrEmpty(user_name))
        {
            context.Response.Write("{ \"info\":\"请输入编号\", \"status\":\"n\" }");
            return;
        }
        tbl_huiyuan bll = new tbl_huiyuan();
        if (bll.Exists_hui_bianhao(user_name))
        {

            bll.GetModel_hui_bianhao(user_name);
            string huiyuan_name = bll.huiyuan_name;
            context.Response.Write("{ \"info\":\"姓名：" + huiyuan_name + "\", \"status\":\"y\" }");
            return;
        }
        context.Response.Write("{ \"info\":\"对不起没有该会员编号\", \"status\":\"n\" }");
        return;
    }
    #endregion
    #region 验证接点人是否存在========================
    private void jdr_validate(HttpContext context)
    {
        string user_name = AXRequest.GetString("param");
        if (string.IsNullOrEmpty(user_name))
        {
            context.Response.Write("{ \"info\":\"请输入接点人编号\", \"status\":\"n\" }");
            return;
        }
        tbl_huiyuan bll = new tbl_huiyuan();
        if (bll.Exists_hui_bianhao(user_name))
        {

            bll.GetModel_hui_bianhao(user_name);
            string huiyuan_name = bll.huiyuan_name;
            context.Response.Write("{ \"info\":\"接点人姓名：" + huiyuan_name + "\", \"status\":\"y\" }");
            return;
        }
        context.Response.Write("{ \"info\":\"对不起没有该接点人\", \"status\":\"n\" }");
        return;
    }
    #endregion


    #region 验证管理员账号是否重复========================
    private void manager_validate(HttpContext context)
    {
        string user_name = AXRequest.GetString("param");
        if (string.IsNullOrEmpty(user_name))
        {
            context.Response.Write("{ \"info\":\"请输入管理员编号\", \"status\":\"n\" }");
            return;
        }
        tbl_admin bll = new tbl_admin();
        if (bll.Exists(user_name))
        {
            context.Response.Write("{ \"info\":\"管理员编号已被占用，请更换！\", \"status\":\"n\" }");
            return;
        }
        context.Response.Write("{ \"info\":\"管理员编号可使用\", \"status\":\"y\" }");
        return;
    }
    #endregion


    #region 验证商品名称是否重复========================
    private void code_validate(HttpContext context)
    {
        string product_name = AXRequest.GetString("param");
        if (string.IsNullOrEmpty(product_name))
        {
            context.Response.Write("{ \"info\":\"请输入商品名称\", \"status\":\"n\" }");
            return;
        }

        tbl_product bll = new tbl_product();
        if (bll.Exists(product_name))
        {
            context.Response.Write("{ \"info\":\"商品名称已被占用，请更换！\", \"status\":\"n\" }");
            return;
        }
        context.Response.Write("{ \"info\":\"商品名称可使用\", \"status\":\"y\" }");
        return;
    }
    #endregion

    public bool IsReusable
    {
        get
        {
            return false;
        }
    }

}