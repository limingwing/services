<%@ Page Language="C#" AutoEventWireup="true" CodeFile="main.aspx.cs" Inherits="manager_main" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>无标题文档</title>
<link href="../css/style.css" rel="stylesheet" type="text/css" />
 
 <link href="js/jqplot/jquery.jqplot.min.css" rel="stylesheet" type="text/css" />
    <script src="js/jqplot/jquery.min.js" type="text/javascript"></script>
  <script src="js/jqplot/jquery.jqplot.min.js" type="text/javascript"></script>
    <script src="js/jqplot/excanvas.min.js" type="text/javascript"></script>
       <script src="js/jqplot/jqplot.dateAxisRenderer.js" type="text/javascript"></script>
  
    <script src="js/jqplot/jqplot.cursor.js" type="text/javascript"></script>
    <script src="js/jqplot/jqplot.dateAxisRenderer.min.js" type="text/javascript"></script>
    <script src="js/jqplot/jqplot.json2.js" type="text/javascript"></script>
    <script src="js/jqplot/jqplot.highlighter.min.js" type="text/javascript"></script>
</head>


<body>

	<div class="place">
    <span>位置：</span>
    <ul class="placeul">
    <li><a href="#">首页</a></li>
    </ul>
    </div>
    
    <div class="mainindex">
    
    
    <div class="welinfo">
    
    <b><asp:Literal ID="Litreal_name" runat="server"></asp:Literal>好，欢迎使用管理系统</b> 
    <a href="system/my_info.aspx">帐号设置</a>
    </div>
    
    <div class="welinfo">
    <span><img src="../images/time.png" alt="时间" /></span>
    <i>您最近一次登录的时间：<asp:Literal ID="Literal_time" runat="server"></asp:Literal></i> （不是您登录的？<a href="system/login_gl.aspx">请点这里</a>）
    </div>
    
    <div class="xline"></div>
    
   
      <div class="box"></div>
    
    <div class="welinfo"  style="height:60px"  >
     <%--<span><img src="../images/sun.png" alt="天气" /></span>--%>
    <b><iframe name="weather_inc" src="http://i.tianqi.com/index.php?c=code&id=2&num=4" width="550" height="70" frameborder="0" marginwidth="0" marginheight="0" scrolling="no"></iframe></b>
    </div>
    
    
     
    <div class="box"></div>
    
    <div class="welinfo">
    <span><img src="../images/dp.png" alt="提醒" /></span>
    <b><a href="mail/in_box.aspx">您有<asp:Literal ID="Literal1" runat="server"></asp:Literal>条未读留言信息</a></b>
    </div>
    
    
    
    <div class="xline" style="height:500px">
    
   <%-- <div class="example-plot" id="chart1"></div> 
      <script type="text/javascript">
          $(document).ready(function () {
              laodData();
              $("#btnLoadData").bind("click", laodData);
          });
          var laodData = function () {
              var ajaxDataRenderer = function (url, plot, options) {
                  var ret = null;
                  var dataJson = [[], []];
                  $.ajax({
                      async: false,
                      url: url,
                      dataType: "json",
                      success: function (data) {
                          //构造数组
                          for (var i = 0; i < data.length; i++) {
                              var chObj = data[i];
                              for (var j = 0; j < chObj.length; j++) {
                                  dataJson[i].push([chObj[j].dTime, chObj[j].V]);
                              }

                          }
                          //dataJson.sort();
                          ret = dataJson;
                      }
                  });
                  return ret;
              };

              var jsonurl = "yeji/ajax/ajaxbochu.aspx";
              var options = {
                  title: "拨出统计图",
                  seriesDefaults: {
                      showMarker: true, //是否显示点

                      pointLabels: { show: true },
                      //, label: '曲线1'
                      label: '积分',
                      label: '收入'
                  },
                  animate: true,

                  series: [{ label: '积分', neighborThreshold: -1 }, { label: '收入', neighborThreshold: -1}],
                  legend: { show: true, location: 'se' },
                  //横轴为日期时必须有如下代码
                  axes: {
                      xaxis: { renderer: $.jqplot.DateAxisRenderer, tickOptions: { formatString: "20%y-%m-%d"} //,

                          //                           numberTicks: 4
                          //                          ,tickInterval: '10 minutes'
                          //                           , max: '23:59'
                          //                           , min: "23:59AM" 
                          //                          , ticks: ['00:05', '00:10', '00:15', '00:20', '00:25', '00:30', '00:35']
                      }, //%m-%#d:MM-dd;%H:%M:小时:分钟形式
                      yaxis: { renderer: $.jqplot.LogAxisRenderer }
                  },
                  //悬浮展现控制
                  highlighter: { show: true, yvalues: 1, tooltipAxes: "xy",
                      formatString: '<table class="jqplot-highlighter"> \
                <tr><td>日期:</td><td>%s</td></tr> \
                <tr><td>金额:</td><td>%s</td></tr></table>'
                  },
                  dataRenderer: ajaxDataRenderer,
                  cursor: {
                      show: true
                  },
                  dataRendererOptions: { unusedOptionalUrl: jsonurl }
              }
              plot = $.jqplot("chart1", jsonurl, options);
          }
    </script>
    
    </div>--%>
    
    <%--<span>总拨比：</span><asp:Literal ID="Literal2" runat="server"></asp:Literal>%；
    
   <span>今日拨比：</span><asp:Literal ID="Literal3" runat="server"></asp:Literal>%；
    <b>今日会员注册数：<%=count%> ；今日注册金额：<%=shouru_z%>；</b>--%>
    
    
    </div>
    
    

</body>

</html>
