﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

public partial class img : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string[] str = new string[4];
        string serverCode = "";
        //生成随机生成器 
        Random random = new Random();
        for (int i = 0; i < 4; i++)
        {
            str[i] = random.Next(10).ToString().Substring(0, 1);
        }
        CreateCheckCodeImage(str);
        foreach (string s in str)
        {
            serverCode += s;
        }
        Session["serverCode"] = serverCode;
    }

    private void CreateCheckCodeImage(string[] checkCode)
    {
        if (checkCode == null || checkCode.Length <= 0)
            return;

        System.Drawing.Bitmap image = new System.Drawing.Bitmap((int)Math.Ceiling((checkCode.Length * 12.5)), 20);
        System.Drawing.Graphics g = Graphics.FromImage(image);

        try
        {
            Random random = new Random();
            //清空图片背景色 
            g.Clear(Color.White);

            //定义颜色
            Color[] c = { Color.Black, Color.Red, Color.DarkBlue, Color.Green, Color.Orange, Color.Brown, Color.DarkCyan, Color.Purple };
            //定义字体
            string[] f = { "Verdana", "Microsoft Sans Serif", "Comic Sans MS", "Arial", "宋体" };

            for (int k = 0; k <= checkCode.Length - 1; k++)
            {
                int cindex = random.Next(7);
                int findex = random.Next(5);

                Font drawFont = new Font(f[findex], 11, (System.Drawing.FontStyle.Bold));



                SolidBrush drawBrush = new SolidBrush(c[cindex]);

                float x = 3.0F;
                float y = 0.0F;
                float width = 10.0F;
                float height = 20.0F;
                int sjx = random.Next(2);
                int sjy = random.Next(image.Height - (int)height);

                RectangleF drawRect = new RectangleF(x + sjx + (k * 10), y + sjy, width, height);

                StringFormat drawFormat = new StringFormat();
                drawFormat.Alignment = StringAlignment.Center;

                g.DrawString(checkCode[k], drawFont, drawBrush, drawRect, drawFormat);
            }

            //画图片的边框线 
            g.DrawRectangle(new Pen(Color.Silver), 0, 0, image.Width - 1, image.Height - 1);

            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            Response.ClearContent();
            Response.ContentType = "image/Gif";
            Response.BinaryWrite(ms.ToArray());
        }
        finally
        {
            g.Dispose();
            image.Dispose();
        }
    }
}