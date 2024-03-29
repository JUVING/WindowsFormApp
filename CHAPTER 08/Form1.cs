﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        //버튼 v
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = FlatStyle.Flat.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = FlatStyle.Popup.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = FlatStyle.Standard.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = FlatStyle.System.ToString();
        }

        //버튼 ^


        //체크박스 v
        private void UpdataLabel(string s, bool b)
        {
            if (b)
            {
                if (label2.Text != null)
                {
                    label2.Text += " + ";
                }
                label2.Text += s;
            }
            else
            {
                string strTemp = label2.Text;
                int i = strTemp.IndexOf(s);
                if (i >= 0)
                {
                    if (i > 0 && strTemp[i - 1] == ' ')
                    {
                        i -= 2; // 앞에 공백과 + 를 함께 제거하기 위해 추가
                    }
                    else if (i == 0)
                    {
                        i = -1; // 문자열이 가장 앞에 있을 때 공백만 제거하기 위해 추가
                    }
                    label2.Text = strTemp.Remove(i, s.Length + 2);
                }
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            UpdataLabel(checkBox1.Text, checkBox1.Checked);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            UpdataLabel(checkBox2.Text, checkBox2.Checked);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            UpdataLabel(checkBox3.Text, checkBox3.Checked);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            UpdataLabel(checkBox4.Text, checkBox4.Checked);
        }

        //체크 박스 ^


        //라디오 박스 v

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = radioButton1.Text;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = radioButton2.Text;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = radioButton3.Text;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = radioButton4.Text;
        }

       
        //링크 레이블 v
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(linkLabel1.Text);
            label7.Text = "유튜브 : ";
            label7.Text += linkLabel1.Text;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(linkLabel2.Text);
            label7.Text = "구글  : ";
            label7.Text += linkLabel2.Text;
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(linkLabel3.Text);
            label7.Text = "네이버 : ";
            label7.Text += linkLabel3.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox3.Text = "Name : " + textBox1.Text + "\r\nPassword : "
                + textBox2.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(textBox4.Text!= "")
            {
                listBox1.Items.Add(textBox4.Text);
                textBox4.Text = "";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            { 
                comboBox1.Items.Add(listBox2.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                listBox2.Items.Add(comboBox1.SelectedItem);
                comboBox1.Items.Remove(comboBox1.SelectedItem);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string strTemp = "";
            foreach(object obj in checkedListBox1.CheckedItems)
            {
                strTemp += obj.ToString();
                strTemp += "";
            }
            MessageBox.Show("당신의 취미는 " + strTemp + "입니다.");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to close?", "Prompt", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }
    }
}
