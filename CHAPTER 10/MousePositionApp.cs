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
    public partial class MousePositionApp : Form
    {
        public MousePositionApp()
        {
            InitializeComponent();
        }
       
        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            
            Point mousePoint = PointToClient(MousePosition);
            string msg = "Mouse Position : " + MousePosition.X + ", " +
                        MousePosition.Y;
            MessageBox.Show(msg);
        }

    }
}
