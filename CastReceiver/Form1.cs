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
        bool Updating = false;
        public static StreamClient sc;
        int port;
        string group;
        public static string pass,myname;
        public Form1()
        {
            InitializeComponent();
            pb.Image = new Bitmap(1, 1);
            myname = logger.name;
            ConfigSignalRConnection();
            FormClosing += (sender, e) => sc.ConnectToServer();
        }
        async void ConfigSignalRConnection()
        {
            connection = new HubConnectionBuilder().WithUrl("http://"+logger.URL+":5000/CastHub")
                .WithAutomaticReconnect().Build();
            connection.On<string, int, int, bool, int, int>("UpdateScreen", UpdateScreen);
            await connection.StartAsync();
            await connection.InvokeAsync("SetName", myname);
            group = pass = await connection.InvokeAsync<string>("GetGroupId", logger.room_name);
            WPFChatForm.key = Encoding.ASCII.GetBytes(group.Substring(0, 8));
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
            if (ms != null && !Updating)
            {
                Updating ^= true;
                if (encrypted) ms = Decoded(ms.Substring(0, 200)) + ms.Substring(200);
                using (Image img = Image.FromStream(new MemoryStream(Convert.FromBase64String(ms))))
                {
                    if (height != pb.Image.Height / 10 || width != pb.Image.Width / 10) 
                        pb.Image = new Bitmap(width * 10, height * 10);
                    using (Graphics g = Graphics.FromImage(pb.Image)) 
                        g.DrawImage(img, new Point(c * width, r * height));
                    pb.Invalidate();
                }
                Updating ^= true;
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
