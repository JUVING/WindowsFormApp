﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHAPTER_12
{
    public partial class PaintEventApp : Form
    {
        public PaintEventApp()
        {
            InitializeComponent();
        }

        private void PaintEventApp_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Random r = new Random();
            Color c = Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255));
            g.FillRectangle(new SolidBrush(c), e.ClipRectangle);
        }
    }
}
