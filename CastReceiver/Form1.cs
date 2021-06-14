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
        HubConnection connection;
        Bitmap pic = null;
        int x = 10, y = 10;
        bool mic_muted = false;
        bool speaker_muted = false;
        StreamClient sc;
        int port;
        string group;
        static string pass;
        public Form1()
        {
            InitializeComponent();
            pic = new Bitmap(1, 1);
            ConfigSignalRConnection();
            FormClosing += (sender, e) => sc.ConnectToServer();
        }
        async void ConfigSignalRConnection()
        {
            connection = new HubConnectionBuilder()
                .WithUrl("http://192.168.1.111:5000/CastHub")
                .WithAutomaticReconnect()
                .Build();
            connection.On<string, int, int, bool, int, int>("UpdateScreen", UpdateScreen);
            connection.On<string, string>("newMessage", NewMessage);
            await connection.StartAsync();
            await connection.InvokeAsync("SetName", logger.name);
            group = pass = await connection.InvokeAsync<string>("GetGroupId", logger.room_name);
            await connection.InvokeAsync("AddToGroup", group);
            port = await connection.InvokeAsync<int>("getport", group);
            await connection.InvokeAsync("getscreen");
            await connection.InvokeAsync("getMessages");
            sc = new StreamClient(port,"192.168.1.111");
            sc.Init();
            sc.ConnectToServer();
        }
        void NewMessage(string sender, string message)
        {
            messagesrtb.Text += "\n\n" + sender + "\n" + message;
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (messagetb.Text != string.Empty)
            {
                connection.InvokeAsync("newMessage", messagetb.Text);
                messagetb.Text = "";
            }
        }

        private void pbmic_Click(object sender, EventArgs e)
        {
            if (mic_muted) pbmic.Image = Resources.um;
            else pbmic.Image = Resources.m;
            mic_muted = !mic_muted;
            sc.mictougle();
        }

        private void pbspeaker_Click(object sender, EventArgs e)
        {
            if (speaker_muted) pbspeaker.Image = Resources.su;
            else pbspeaker.Image = Resources.sm;
            speaker_muted = !speaker_muted;
            sc.speakertougle();
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
