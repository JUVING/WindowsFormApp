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
    public partial class MessageBoxDefaultButtonApp : Form
    {
        public MessageBoxDefaultButtonApp()
        {
            InitializeComponent();
        }

        private void MessageBoxDefaultButtonApp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("MessageBoxDefaultButton", "Title Bar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        }
    }
}
