using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHAPTER_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewApp listView = new ListViewApp();
            listView.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TreeViewApp treeView = new TreeViewApp();
            treeView.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TreeNodeApp treeNode = new TreeNodeApp();
            treeNode.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DomainUpDownApp domain = new DomainUpDownApp();
            domain.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            NumericDownApp numeric = new NumericDownApp();
            numeric.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TrackBarApp trackBar = new TrackBarApp();
            trackBar.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ProgressBarApp progress = new ProgressBarApp();
            progress.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TimerApp timer = new TimerApp();
            timer.Show();
        }
    }
}
