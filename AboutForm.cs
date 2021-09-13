using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSave
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            int now = 2021;
            if (DateTime.Now.Year > now)
            {
                now = DateTime.Now.Year;
            }
            this.aboutlabel.Text = "刘汉涛   版权所有  2021 - " + now;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void richTextBox1_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            this.Close();
            this.Dispose();
            System.Diagnostics.Process.Start(e.LinkText);
        }
    }
}
