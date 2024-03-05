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
        protected int cxBlock, cyBlock;
        private void Form1_Load(object sender, EventArgs e)
        {
            OnResize(EventArgs.Empty);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            cxBlock = ClientSize.Width/ YNum;
            cyBlock = ClientSize.Height / YNum;
            Invalidate();
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            int x = e.X / cxBlock;
            int y = e.Y / cyBlock;
            if(x<XNum && y<YNum)
            {
                abchecked[y, x] ^= true;
                Invalidate(new Rectangle(x * cxBlock, y * cyBlock, cxBlock, cyBlock));
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(ForeColor);
            for(int y=0;y<YNum;y++)
            {
                for(int x=0;x<XNum;x++)
                {
                    g.DrawRectangle(pen, x * cxBlock, y * cyBlock, cxBlock, cyBlock);
                    if(abchecked[y,x])
                    {
                        g.DrawLine(pen, x * cxBlock, y * cyBlock, (x + 1) * cxBlock, (y + 1) * cyBlock);
                        g.DrawLine(pen, x * cxBlock, (y + 1) * cyBlock, (x + 1) * cxBlock, y * cyBlock);
                    }
                }
            }
        }
    }
}
