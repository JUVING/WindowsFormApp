using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            startDateTime = DateTime.Now;
        }
        DateTime startDateTime;
        public DateTime GetStartDateTime()
        {
            return startDateTime;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(GetStartDateTime().ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("This Form is leaded");
            SetButtonText1();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("This Form is Closed");
            SetButtonText(); //346
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to close?", "Prompt", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SetButtonText()
        {
            button3.Text = "Form.FormBorderStyle = "
                + FormBorderStyle.ToString() + "\n" +
                "Fomr.ClientSize = " + ClientSize.ToString();
        }
      
        private void button3_Click(object sender, EventArgs e)
        {
            if (FormBorderStyle == FormBorderStyle.SizableToolWindow)
                FormBorderStyle = FormBorderStyle.None;
            else
                FormBorderStyle++;
            SetButtonText();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Random r = new Random();
            Color c = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
            g.FillRectangle(new SolidBrush(c), e.ClipRectangle);
        }

        private void SetButtonText1()
        {
            button5.Text =
                "Location = " + Location + "\n" +
                "Left/ Right/ Width = " + Left + ", " + Right + ", " + Width + "\n" +
                "Top/ Bottom/ Height = " + Top + ", " + Bottom + ", " + Height;
        }

        private void Form1_Move(object sender, EventArgs e)
        {
            SetButtonText1();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            SetButtonText1();
        }
    }
}
