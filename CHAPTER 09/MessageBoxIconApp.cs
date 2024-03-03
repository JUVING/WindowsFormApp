using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MessageBoxIconApp : Form
    {
        public MessageBoxIconApp()
        {
            InitializeComponent();
        }
        private int i;
        private void MessageBoxIconApp_Click(object sender, EventArgs e)
        {
            i = i < 64 ? i += 16 : 0;
            this.Text = ((MessageBoxIcon)i).ToString();
            MessageBox.Show("MessageBoxIcon", "Title Bar", MessageBoxButtons.OKCancel, (MessageBoxIcon)i);
        }
    }
}
