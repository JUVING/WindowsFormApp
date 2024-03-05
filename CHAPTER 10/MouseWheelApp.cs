using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHAPTER_10
{
    public partial class MouseWheelApp : Form
    {
        public MouseWheelApp()
        {
            InitializeComponent();
        }
        private int num;
        private void MouseWheelApp_Load(object sender, EventArgs e)
        {
            this.MouseWheel += new MouseEventHandler(this.Form1_MuseWheel);
        }

        private void Form1_MuseWheel(object sender,MouseEventArgs e)
        {
            textBox1.Text = (e.Delta > 0 ? num++ : num--).ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            num = 0;
            textBox1.Text = num.ToString();
        }

    }
}
