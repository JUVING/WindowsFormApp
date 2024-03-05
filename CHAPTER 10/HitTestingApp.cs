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
    public partial class HitTestingApp : Form
    {
        public HitTestingApp()
        {
            InitializeComponent();
        }

        protected const int XNum = 5;
        protected const int YNum = 4;
        protected bool[,] abchecked = new bool[YNum, XNum];

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            

        }
    }
}
