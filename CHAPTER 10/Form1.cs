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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuClickApp menuClick = new MenuClickApp();
            menuClick.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MouseWheelApp wheel = new MouseWheelApp();
            wheel.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MousePositionApp position = new MousePositionApp();
            position.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MouseEventApp mouseEvent = new MouseEventApp();
            mouseEvent.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HitTestingApp hitest = new HitTestingApp();
            hitest.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FocusApp focus = new FocusApp();
            focus.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FocusEventApp focusEvent = new FocusEventApp();
            focusEvent.Show();
        }
    }
}
