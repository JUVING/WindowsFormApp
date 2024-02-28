using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            startDateTime = DateTime.Now;
        }
        DateTime startDateTime;
        public DateTime GetStartDateTime()
        {
            return startDateTime;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(GetStartDateTime().ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("This Form is leaded");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("This Form is Closed");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to close?", "Prompt", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
