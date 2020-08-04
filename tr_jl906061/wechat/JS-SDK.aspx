<%@ Page Language="C#" AutoEventWireup="true" CodeFile="JS-SDK.aspx.cs" Inherits="wechat_JS_SDK" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, user-scalable=0">
    <title>微信JS-SDK接口测试</title>
    <link href="http://203.195.235.76/jssdk/css/style.css" rel="stylesheet" />
    <script src="/scripts/jquery/jquery-1.10.2.min.js"></script>
    <script src="http://res.wx.qq.com/open/js/jweixin-1.0.0.js"></script>
    <script>
        wx.config({
            debug: false, // 开启调试模式,调用的所有api的返回值会在客户端alert出来，若要查看传入的参数，可以在pc端打开，参数信息会通过log打出，仅在pc端时才会打印。
            appId: '<%=appId%>', // 必填，公众号的唯一标识
            timestamp:<%=timestamp%>, // 必填，生成签名的时间戳
            nonceStr: '<%=nonceStr%>', // 必填，生成签名的随机串
            signature: '<%=signature%>',// 必填，签名，见附录1
            jsApiList: ['checkJsApi','onMenuShareTimeline','chooseImage','uploadImage','getNetworkType','chooseWXPay'] // 必填，需要使用的JS接口列表，所有JS接口列表见附录2
        });
        wx.ready(function () {
            //拍照、本地选图、上传图片
            var images = {
                localId: [],
                serverId: []
            };
            document.querySelector('#checkJsApi').onclick = function () {
                wx.checkJsApi({
                    jsApiList: [
                      'getNetworkType'
                    ],
                    success: function (res) {
                        alert(JSON.stringify(res));
                    }
                });
            };
            document.querySelector('#chooseImage').onclick = function () {
                images.localId = [];
                wx.chooseImage({
                    success: function (res) {
                        images.localId = res.localIds;
                        if (images.localId.length == 0) {
                            alert('请先使用 chooseImage 接口选择图片');
                            return;
                        }
                        if(images.localId.length > 1) {
                            alert('目前仅支持单张图片上传,请重新上传');
                            images.localId = [];
                            return;
                        }
                        var i = 0, length = images.localId.length;
                        if(length==1)
                        {
                            wx.uploadImage({
                                localId: images.localId[0],
                                success: function (res) {     
                                    $("#showurl").append("<img src='"+images.localId[0]+"' />"); 
                                    images.serverId.push(res.serverId);
                                    //$("#showurl").append(images.serverId[0]); 
                                },
                                fail: function (res) {
                                    alert(JSON.stringify(res));
                                }
                            });       
                        }        
                    }
                });
            };
            document.querySelector('#getNetworkType').onclick = function () {
                wx.getNetworkType({
                    success: function (res) {
                        alert(res.networkType);
                    },
                    fail: function (res) {
                        alert(JSON.stringify(res));
                    }
                });
            };
            document.querySelector('#onMenuShareTimeline').onclick = function () {
                wx.onMenuShareTimeline({
                    title: '紫牛官网公众号测试',
                    link: 'http://ziniusoft.com/',
                    imgUrl: 'http://ziniusoft.com/images/logo.png',
                    trigger: function (res) {
                        // 用户确认分享后执行的回调函数
                        alert('请点击右上角“分享到朋友圈”');
                    },
                    success: function (res) {
                        alert('“分享到朋友圈”操作成功');
                    },
                    cancel: function (res) {
                        alert('您选择关闭了“分享到朋友圈”');
                    },
                    fail: function (res) {
                        alert(JSON.stringify(res));
                    }
                });
                alert('请点击右上角“分享到朋友圈”');
            };
            document.querySelector('#chooseWXPay').onclick = function () {
                wx.chooseWXPay({
                    timestamp: 1414723227, //支付签名时间戳
                    nonceStr: 'noncestr',//支付签名随机串，不长于 32 位
                    package: 'addition=action_id%3dgaby1234%26limit_pay%3d&bank_type=WX&body=innertest&fee_type=1&input_charset=GBK&notify_url=http%3A%2F%2F120.204.206.246%2Fcgi-bin%2Fmmsupport-bin%2Fnotifypay&out_trade_no=1414723227818375338&partner=1900000109&spbill_create_ip=127.0.0.1&total_fee=1&sign=432B647FE95C7BF73BCD177CEECBEF8D',//统一支付接口返回的prepay_id参数值
                    signType: 'SHA1', //签名方式
                    paySign: 'bd5b1933cda6e9548862944836a9b52e8c9a2b69'//支付签名
                });
            };
        });
    </script>
</head>
<body>
    <div class="lbox_close wxapi_form">
        <h3 id="menu-basic">基础接口</h3>
        <span class="desc">判断当前客户端是否支持指定JS接口</span>
        <button class="btn btn_primary" id="checkJsApi">checkJsApi</button>

        <h3 id="menu-share">分享接口</h3>
        <span class="desc">获取“分享到朋友圈”按钮点击状态及自定义分享内容接口</span>
        <button class="btn btn_primary" id="onMenuShareTimeline">onMenuShareTimeline</button>

        <h3 id="menu-image">图像接口</h3>
        <span class="desc">拍照或从手机相册中选图接口</span>
        <button class="btn btn_primary" id="chooseImage">chooseImage</button>

        <h3 id="menu-device">设备信息接口</h3>
        <span class="desc">获取网络状态接口</span>
        <button class="btn btn_primary" id="getNetworkType">getNetworkType</button>

        <h3 id="menu-pay">微信支付接口</h3>
        <span class="desc">发起一个微信支付请求</span>
        <button class="btn btn_primary" id="chooseWXPay">chooseWXPay</button>
    </div>
    <div id="showurl"></div>
</body>
</html>
