
namespace CHAPTER_11
{
    partial class TreeNodeApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Console");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("MultiCastDelegate");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Delegate", new System.Windows.Forms.TreeNode[] {
            treeNode16});
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("AppicationException");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("SystemException");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Exception", new System.Windows.Forms.TreeNode[] {
            treeNode18,
            treeNode19});
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Math");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("TextReader");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("TextWriter");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Timer");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("TreeNode");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("MarshalByRefObject", new System.Windows.Forms.TreeNode[] {
            treeNode22,
            treeNode23,
            treeNode24,
            treeNode25});
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("String");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("object", new System.Windows.Forms.TreeNode[] {
            treeNode15,
            treeNode17,
            treeNode20,
            treeNode21,
            treeNode26,
            treeNode27});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(13, 13);
            this.treeView1.Name = "treeView1";
            treeNode15.Name = "노드5";
            treeNode15.Text = "Console";
            treeNode16.Name = "노드11";
            treeNode16.Text = "MultiCastDelegate";
            treeNode17.Name = "노드6";
            treeNode17.Text = "Delegate";
            treeNode18.Name = "노드12";
            treeNode18.Text = "AppicationException";
            treeNode19.Name = "노드13";
            treeNode19.Text = "SystemException";
            treeNode20.Name = "노드7";
            treeNode20.Text = "Exception";
            treeNode21.Name = "노드8";
            treeNode21.Text = "Math";
            treeNode22.Name = "노드14";
            treeNode22.Text = "TextReader";
            treeNode23.Name = "노드15";
            treeNode23.Text = "TextWriter";
            treeNode24.Name = "노드16";
            treeNode24.Text = "Timer";
            treeNode25.Name = "노드17";
            treeNode25.Text = "TreeNode";
            treeNode26.Name = "노드9";
            treeNode26.Text = "MarshalByRefObject";
            treeNode27.Name = "노드10";
            treeNode27.Text = "String";
            treeNode28.Name = "노드4";
            treeNode28.Text = "object";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode28});
            this.treeView1.Size = new System.Drawing.Size(345, 281);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "선택한 노드";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "부모 노드";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "이전 형제 노드";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 397);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "다음 형제 노드";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(119, 309);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(119, 339);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(119, 366);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 21);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(119, 393);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 21);
            this.textBox4.TabIndex = 8;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(238, 327);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 88);
            this.listBox1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(238, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "자식 노드";
            // 
            // TreeNodeApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 434);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeView1);
            this.Name = "TreeNodeApp";
            this.Text = "TreeNodeApp";
            this.Load += new System.EventHandler(this.TreeNodeApp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label5;
    }
}