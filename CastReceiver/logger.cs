using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net;
using System.Text;
using System.Web.Helpers;
using System.Windows.Forms;

namespace CastReceiver
{
    public partial class logger : Form
    {
        public static string room_name;
        public static string name;
        public static Form1 form;
        public logger()
        {
            InitializeComponent();
            get_sessions();
        }
        void get_sessions()
        {
            using (WebClient client = new WebClient())
            {
                byte[] response = client.UploadValues("http://192.168.1.111:5000/api/Rooms/get_rooms", new NameValueCollection() { });
                string result = Encoding.UTF8.GetString(response);
                SessionList = Json.Decode<List<string>>(result);
            }
            session_list.Items.Clear();
            foreach (var session in SessionList) session_list.Items.Add(session);
        }
        List<string> SessionList;

        private void login_btn_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tbname.Text.Trim()))
            {
                MessageBox.Show("يرجى ادخال الاسم");
                return;
            }
            if(session_list.SelectedIndex == -1)
            {
                MessageBox.Show("اختر المحاضرة للدخول");
                return;
            }
            room_name = SessionList[session_list.SelectedIndex];
            name = tbname.Text;
            form = new Form1();
            form.Show();
            form.FormClosing += (s, a) => { Close(); };
            Hide();
            
        }
        private void bnrefresh_Click(object sender, EventArgs e) => get_sessions();
    }
}
