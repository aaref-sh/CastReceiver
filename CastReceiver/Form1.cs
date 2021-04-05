using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                .WithUrl("http://localhost:5000/CastHub")
                .WithAutomaticReconnect()
                .Build();
            connection.On<string, int, int>("UpdateScreen", UpdateScreen);
            await connection.StartAsync();
            await connection.InvokeAsync("AddToGroup", "main");
        }
        Bitmap pic = null;
        void UpdateScreen(string base64,int r,int c)
        {
            Image img = Image.FromStream(new MemoryStream(Convert.FromBase64String(base64)));
            if(pic.Width/6 != img.Width || pic.Height/5 != img.Height)
                pic = new Bitmap(img.Width*6, img.Height*5);
            Rectangle re = new Rectangle(new Point(0,0), new Size(img.Width, img.Height));
            using (Graphics g = Graphics.FromImage(pic))
                g.DrawImage(img, c*img.Width, r*img.Height, re, GraphicsUnit.Pixel);
            pb.Image = (Image) pic;
        }
    }
}
