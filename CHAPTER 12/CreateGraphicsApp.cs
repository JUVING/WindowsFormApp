using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace CHAPTER_12
{
    public partial class CreateGraphicsApp : Form
    {
        public CreateGraphicsApp()
        {
            InitializeComponent();
        }

        private void CreateGraphicsApp_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            Random r = new Random();
            Color c = Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255));
            g.FillRectangle(new SolidBrush(c), ClientRectangle);
        }
    }
}
