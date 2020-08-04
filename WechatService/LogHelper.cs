using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace WechatService
{
    /// <summary>
    /// 日志记录
    /// </summary>
    public class LogHelper
    {
        public static string Path = HttpContext.Current.Server.MapPath("~/log.txt");
        public static void Log(string infos)
        {
            var s = string.Join(Environment.NewLine, infos);
            var file = File.AppendText(Path);
            file.WriteLine("----------------------------- {0} -----------------------------", DateTime.Now);
            file.WriteLine(s);
            file.Flush();
            file.WriteLine("-------------------------------------------------------------------------");
            file.Close();
        }
    }
}
