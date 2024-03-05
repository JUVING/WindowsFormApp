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
    public partial class FocusEventApp : Form
    {
        public FocusEventApp()
        {
            InitializeComponent();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("비밀번호를 입력하세요");
        }
    }
}
