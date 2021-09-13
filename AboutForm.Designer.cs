
namespace AutoSave
{
    partial class AboutForm
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.RichTextBox richTextBox1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.button1 = new System.Windows.Forms.Button();
            this.aboutlabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            label1.Location = new System.Drawing.Point(181, 18);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(125, 12);
            label1.TabIndex = 2;
            label1.Text = "Excel自动保存 加载项";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            label3.Location = new System.Drawing.Point(158, 168);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(173, 24);
            label3.TabIndex = 4;
            label3.Text = "版本号：1.0.2.0\r\n电子邮箱地址：lhtxq@live.com";
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = System.Drawing.SystemColors.Control;
            richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            richTextBox1.Location = new System.Drawing.Point(47, 46);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.ShortcutsEnabled = false;
            richTextBox1.Size = new System.Drawing.Size(395, 119);
            richTextBox1.TabIndex = 5;
            richTextBox1.TabStop = false;
            richTextBox1.Text = "项目地址：https://github.com/LHTXQ/ExcelAutoSave\n\n注意：\n1、在打开或关闭工作簿前请先关闭开关，否则会产生错误。\n2、本插" +
    "件尽可能考虑所有异常处理，但不能保证不会出现意料之外的错误导致宿主程序崩溃。作者不对使用该插件造成的任何损失负责。";
            richTextBox1.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richTextBox1_LinkClicked);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(206, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "关闭";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // aboutlabel
            // 
            this.aboutlabel.AutoSize = true;
            this.aboutlabel.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.aboutlabel.Location = new System.Drawing.Point(158, 202);
            this.aboutlabel.Name = "aboutlabel";
            this.aboutlabel.Size = new System.Drawing.Size(185, 12);
            this.aboutlabel.TabIndex = 1;
            this.aboutlabel.Text = "刘汉涛   版权所有  2021 - 2021";
            // 
            // AboutForm
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(richTextBox1);
            this.Controls.Add(label3);
            this.Controls.Add(label1);
            this.Controls.Add(this.aboutlabel);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "关于";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label aboutlabel;
    }
}