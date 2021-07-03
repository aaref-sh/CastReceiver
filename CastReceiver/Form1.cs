using CastReceiver.Properties;
using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Drawing;
using System.IO;
using System.Media;
using System.Text;
using System.Windows.Forms;
using VoiceClient;

namespace CastReceiver
{
    public partial class Form1 : Form
    {
        public static HubConnection connection;
        Bitmap pic = null;
        int x = 10, y = 10;
        public static StreamClient sc;
        int port;
        string group;
        public static string pass,myname;
        public Form1()
        {
            InitializeComponent();
            pic = new Bitmap(1, 1,System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            myname = logger.name;
            ConfigSignalRConnection();
            FormClosing += (sender, e) => sc.ConnectToServer();
        }
        async void ConfigSignalRConnection()
        {
            connection = new HubConnectionBuilder()
                .WithUrl("http://"+logger.URL+"/CastHub")
                .WithAutomaticReconnect()
                .Build();
            connection.On<string, int, int, bool, int, int>("UpdateScreen", UpdateScreen);
            await connection.StartAsync();
            await connection.InvokeAsync("SetName", myname);
            group = pass = await connection.InvokeAsync<string>("GetGroupId", logger.room_name);
            await connection.InvokeAsync("AddToGroup", group);
            port = await connection.InvokeAsync<int>("getport", group);
            await connection.InvokeAsync("getscreen");
            wpfChatForm1.adds();
            await connection.InvokeAsync("getMessages");
            sc = new StreamClient(port,logger.URL);
            sc.Init();
            sc.ConnectToServer();
            sc.mictougle();
        }

        void UpdateScreen(string ms, int r, int c, bool encrypted, int height, int width)
        {
            if (ms != null)
            {
                if (encrypted) ms = Decoded(ms.Substring(0, 200)) + ms.Substring(200);
                Image img = Image.FromStream(new MemoryStream(Convert.FromBase64String(ms)));
                if (pic.Width / x != img.Width || pic.Height / y != img.Height)
                    pic = new Bitmap(img.Width * x, img.Height * y);
                Rectangle re = new Rectangle(new Point(0, 0), new Size(img.Width, img.Height));
                using (Graphics g = Graphics.FromImage(pic))
                    g.DrawImage(img, c * img.Width, r * img.Height, re, GraphicsUnit.Pixel);
                pb.Image = pic;
            }
        }

        public static string Decoded(string input)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
                sb.Append((char)(input[i] ^ pass[(i % pass.Length)]));
            return sb.ToString();
        }
    }
}
