using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace CastReceiver
{
    public partial class Form1 : Form
    {
        HubConnection connection;
        public Form1()
        {
            InitializeComponent();
            pic = new Bitmap(1, 1);
            ConfigSignalRConnection();
        }
        async void ConfigSignalRConnection()
        {
            connection = new HubConnectionBuilder()
                .WithUrl("http://192.168.1.111:5000/CastHub")
                .WithAutomaticReconnect()
                .Build();
            connection.On<string, int, int>("UpdateScreen", UpdateScreen);
            await connection.StartAsync();
            await connection.InvokeAsync("AddToGroup", "main");
        }
        Bitmap pic = null;
        int x = 6, y = 5;
        void UpdateScreen(string base64, int r, int c)
        {
            Image img = Image.FromStream(new MemoryStream(Convert.FromBase64String(decoded(base64))));
            if (pic.Width / x != img.Width || pic.Height / y != img.Height)
                pic = new Bitmap(img.Width * x, img.Height * y);
            Rectangle re = new Rectangle(new Point(0, 0), new Size(img.Width, img.Height));
            using (Graphics g = Graphics.FromImage(pic))
                g.DrawImage(img, c * img.Width, r * img.Height, re, GraphicsUnit.Pixel);
            pb.Image = (Image)pic;
        }
        string pass = "mainmain";
        string decoded(string s)
        {
            //return s;
            var result = new StringBuilder();
            for (int c = 0; c < s.Length; c++)
                result.Append((char)((uint)s[c] ^ (uint)pass[c % pass.Length]));
            return result.ToString();
        }
    }
}
