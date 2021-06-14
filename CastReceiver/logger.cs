using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CastReceiver
{
    public partial class logger : Form
    {
        public static string room_name;
        public static string name;
        public logger()
        {
            InitializeComponent();
        }

        private void btnconnect_Click(object sender, EventArgs e)
        {
            group = tbgroup.Text;
            name = tbname.Text;
            var form = new Form1();
            form.Show();
            Hide();
        }
    }
}
