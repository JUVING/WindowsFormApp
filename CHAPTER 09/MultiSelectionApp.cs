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
    public partial class MultiSelectionApp : Form
    {
        public MultiSelectionApp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Filter = "텍스트 파일(*.txt)|*.txt|모든파일(*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Multiselect = true;
            openFileDialog1.ShowDialog();
            foreach(string strTmp in openFileDialog1.FileNames)
            {
                textBox1.Text += strTmp;
                textBox1.Text += "\r\n";
            }
        }
    }
}
