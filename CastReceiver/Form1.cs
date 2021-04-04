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
        }
        async void ConfigSignalRConnection()
        {
            connection = new HubConnectionBuilder()
                .WithUrl("http://localhost:5000/CastHub")
                .WithAutomaticReconnect()
                .Build();
            connection.On<string, int, int>("UpdateScreen", UpdateScreen);
            await connection.StartAsync();
            dic["00"] = p00;
            dic["01"] = p01;
            dic["02"] = p02;
            dic["10"] = p10;
            dic["11"] = p11;
            dic["12"] = p12;
        }
        Dictionary<string, PictureBox> dic = new Dictionary<string, PictureBox>();
        void UpdateScreen(string base64,int r,int c)
        {
            dic[""+r+c].Image = Image.FromStream(new MemoryStream(Convert.FromBase64String(base64)));
        }
    }
}
