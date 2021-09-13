using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace AutoSave
{
    public partial class Excel_AutoSave
    {
        private int IntervalTime = 7;
        private int SaveCount = 0;
        private int SaveAsCount = 0;
        private void Excel_AutoSave_Load(object sender, RibbonUIEventArgs e)
        {
            try
            {
                SaveAsPath.Text = Globals.ThisAddIn.Application.ActiveWorkbook.Path;
                if(SaveAsPath.Text.Length==0)
                {
                    SaveAsPath.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                }
            }
            catch
            {
                SaveAsPath.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            }
        }


        private void SelectPathButton_Click(object sender, RibbonControlEventArgs e)
        {
            folderBrowserDialog1.Description = "请选择另存文件的路径";
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                SaveAsPath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void SwitchButton_Click(object sender, RibbonControlEventArgs e)
        {
            if (SwitchButton.Checked == false)
            {
                timer1.Stop();
                timer1.Enabled = false;
                SwitchButton.Label = "开关(关)";
                label1.Label = "已保存操作计数：" + SaveCount.ToString();
                label2.Label = "已另存操作计数：" + SaveAsCount.ToString();
            }
            else
            {
                timer1.Interval = IntervalTime * 60000;
                timer1.Enabled = true;
                timer1.Start();
                SwitchButton.Label = "开关(开)";
                SaveCount = 0;
                SaveAsCount = 0;
                label1.Label = "保存操作计数：0" ;
                label2.Label = "另存操作计数：0" ;
            }
        }

        private void Interval_TextChanged(object sender, RibbonControlEventArgs e)
        {
            int OriginalIntervalTime = IntervalTime;
            int.TryParse(Interval.Text, out IntervalTime);
            if (IntervalTime < 1)
            {
                IntervalTime = OriginalIntervalTime;
                Interval.Text = IntervalTime.ToString();
            }
            else if (IntervalTime > 360)
            {
                IntervalTime = 360;
                Interval.Text = IntervalTime.ToString();
            }
            timer1.Interval = IntervalTime * 60000;
        }

        private void SaveAsPath_TextChanged(object sender, RibbonControlEventArgs e)
        {
            if (!Directory.Exists(SaveAsPath.Text))
            {
                try
                {
                    SaveAsPath.Text = Globals.ThisAddIn.Application.ActiveWorkbook.Path;
                    if (SaveAsPath.Text.Length == 0)
                    {
                        SaveAsPath.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    }
                }
                catch
                {
                    SaveAsPath.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (SaveType.SelectedItem == SaveType.Items[0])
                {
                    Globals.ThisAddIn.Application.ActiveWorkbook.Save();
                    SaveCount++;
                    label1.Label = "保存操作计数：" + SaveCount.ToString();
                }
                else
                {
                    Globals.ThisAddIn.Application.ActiveWorkbook.Save();
                    SaveCount++;
                    label1.Label = "保存操作计数：" + SaveCount.ToString();
                    File.Copy(Globals.ThisAddIn.Application.ActiveWorkbook.FullName, SaveAsPath.Text + "\\" + DateTime.Now.ToString("yyyyMMddHHmmss") + Globals.ThisAddIn.Application.ActiveWorkbook.Name);
                    SaveAsCount++;
                    label2.Label = "另存操作计数：" + SaveAsCount.ToString();
                }
            }
            catch
            {
                timer1.Stop();
                timer1.Enabled = false;
                SwitchButton.Label = "开关(关)";
                SwitchButton.Checked = false;
                SaveCount = 0;
                SaveAsCount = 0;
                MessageBox.Show("在保存时遇到错误！已关闭自动保存开关，如需要请自行重新打开。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void DonateButton_Click(object sender, RibbonControlEventArgs e)
        {
            DonateForm d = new DonateForm();
            d.Show();
        }

        private void AboutButton_Click(object sender, RibbonControlEventArgs e)
        {
            AboutForm a = new AboutForm();
            a.Show();
        }
    }
}
