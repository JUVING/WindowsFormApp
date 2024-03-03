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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Modal form2 = new Modal();
            form2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Modeless modeless = new Modeless();
            modeless.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to close?", "prmpt", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("MessageBox Loding . . .","Chapter 09",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBoxIconApp IconApp = new MessageBoxIconApp();
            IconApp.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBoxDefaultButtonApp DefaultButtonApp = new MessageBoxDefaultButtonApp();
            DefaultButtonApp.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            openFileDialog1 openfile = new openFileDialog1();
            openfile.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MultiSelectionApp multiSelection = new MultiSelectionApp();
            multiSelection.Show();
        }
    }
}
