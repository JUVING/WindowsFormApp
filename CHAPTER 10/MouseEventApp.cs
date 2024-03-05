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
    public partial class MouseEventApp : Form
    {
        public MouseEventApp()
        {
            InitializeComponent();
        }

        private void UpdateEventLabels(string msg, int x, int y, MouseEventArgs e)
        {
            string message = string.Format($"{msg} X:{x} Y:{y}");
            string eventMsg = DateTime.Now.ToShortTimeString();
            eventMsg += " " + message;
            listBox1.Items.Insert(0, eventMsg);
            listBox1.TopIndex = 0;
            string mouseInfo;
            if (e != null)
            {
                mouseInfo = string.Format($"Clicks: {e.Clicks}, Delta: {e.Delta}," +
                    $" Buttons: {e.Button.ToString()}");
            }
            else
            {
                mouseInfo = string.Format($"clicks: {msg}");
            }
            label1.Text = mouseInfo;
        }
        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            UpdateEventLabels("(ListBox)MouseDown", e.X, e.Y, e);
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            Point mousePoint = PointToClient(MousePosition);
            UpdateEventLabels("(ListBox)DoubleClick", mousePoint.X, mousePoint.Y, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
