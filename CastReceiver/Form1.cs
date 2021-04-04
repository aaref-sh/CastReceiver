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
            ConfigSignalRConnection();
            dic["00"] = p00;
            dic["01"] = p01;
            dic["02"] = p02;
            dic["10"] = p10;
            dic["11"] = p11;
            dic["12"] = p12;
        }
        async void ConfigSignalRConnection()
        {
            connection = new HubConnectionBuilder()
                .WithUrl("http://localhost:5000/CastHub")
                .WithAutomaticReconnect()
                .Build();
            connection.On<string, int, int>("UpdateScreen", UpdateScreen);
            await connection.StartAsync();
        }
        Dictionary<string, PictureBox> dic = new Dictionary<string, PictureBox>();
        void UpdateScreen(string base64,int r,int c)
        {
            Image img = Image.FromStream(new MemoryStream(Convert.FromBase64String(base64)));
            dic["" + r + c].Image = img;
            p00.Width = p01.Width = p02.Width = p10.Width = p11.Width = p12.Width = img.Width;
            p00.Height = p01.Height = p02.Height = p10.Height = p11.Height = p12.Height = img.Height;
            p10.Top = p11.Top = p12.Top = p00.Bottom;
            p01.Left = p11.Left = p00.Right;
            p02.Left = p12.Left = p01.Right;
            this.Width = img.Width * 3 + 16;
            this.Height = img.Height * 2 + 39;

        }
    }
}
