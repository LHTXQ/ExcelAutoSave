
namespace AutoSave
{
    partial class Excel_AutoSave : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Excel_AutoSave()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl1 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl2 = this.Factory.CreateRibbonDropDownItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Excel_AutoSave));
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.box1 = this.Factory.CreateRibbonBox();
            this.SaveType = this.Factory.CreateRibbonDropDown();
            this.SaveAsPath = this.Factory.CreateRibbonEditBox();
            this.SelectPathButton = this.Factory.CreateRibbonButton();
            this.separator1 = this.Factory.CreateRibbonSeparator();
            this.Interval = this.Factory.CreateRibbonEditBox();
            this.label1 = this.Factory.CreateRibbonLabel();
            this.label2 = this.Factory.CreateRibbonLabel();
            this.separator2 = this.Factory.CreateRibbonSeparator();
            this.SwitchButton = this.Factory.CreateRibbonToggleButton();
            this.group2 = this.Factory.CreateRibbonGroup();
            this.AboutButton = this.Factory.CreateRibbonButton();
            this.DonateButton = this.Factory.CreateRibbonButton();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            this.box1.SuspendLayout();
            this.group2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.group1);
            this.tab1.Groups.Add(this.group2);
            this.tab1.Label = "自动保存";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.box1);
            this.group1.Items.Add(this.SaveAsPath);
            this.group1.Items.Add(this.SelectPathButton);
            this.group1.Items.Add(this.separator1);
            this.group1.Items.Add(this.Interval);
            this.group1.Items.Add(this.label1);
            this.group1.Items.Add(this.label2);
            this.group1.Items.Add(this.separator2);
            this.group1.Items.Add(this.SwitchButton);
            this.group1.Label = "设置";
            this.group1.Name = "group1";
            // 
            // box1
            // 
            this.box1.Items.Add(this.SaveType);
            this.box1.Name = "box1";
            // 
            // SaveType
            // 
            ribbonDropDownItemImpl1.Label = "定时保存";
            ribbonDropDownItemImpl2.Label = "定时保存并另存";
            this.SaveType.Items.Add(ribbonDropDownItemImpl1);
            this.SaveType.Items.Add(ribbonDropDownItemImpl2);
            this.SaveType.Label = "保存选项";
            this.SaveType.Name = "SaveType";
            this.SaveType.ScreenTip = "选择仅自动保存或是自动保存并另存一份副本。";
            this.SaveType.ShowItemImage = false;
            // 
            // SaveAsPath
            // 
            this.SaveAsPath.Label = "另存路径";
            this.SaveAsPath.Name = "SaveAsPath";
            this.SaveAsPath.ScreenTip = "填写保存选项为“定时保存并另存”时的另存路径。当填写的路径不存在时会自动变为“我的文档”文件夹。";
            this.SaveAsPath.Text = null;
            this.SaveAsPath.TextChanged += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.SaveAsPath_TextChanged);
            // 
            // SelectPathButton
            // 
            this.SelectPathButton.Image = ((System.Drawing.Image)(resources.GetObject("SelectPathButton.Image")));
            this.SelectPathButton.Label = "浏览路径";
            this.SelectPathButton.Name = "SelectPathButton";
            this.SelectPathButton.ScreenTip = "选择保存选项为“定时保存并另存”时的另存路径";
            this.SelectPathButton.ShowImage = true;
            this.SelectPathButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.SelectPathButton_Click);
            // 
            // separator1
            // 
            this.separator1.Name = "separator1";
            // 
            // Interval
            // 
            this.Interval.Label = "间隔(分钟)";
            this.Interval.Name = "Interval";
            this.Interval.ScreenTip = "填写每隔多久执行一次保存操作。请输入属于[1, 360]的整数。填写内容不正确时会自动撤销更改。";
            this.Interval.Text = "7";
            this.Interval.TextChanged += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Interval_TextChanged);
            // 
            // label1
            // 
            this.label1.Label = "已保存操作计数：0";
            this.label1.Name = "label1";
            // 
            // label2
            // 
            this.label2.Label = "已另存操作计数：0";
            this.label2.Name = "label2";
            // 
            // separator2
            // 
            this.separator2.Name = "separator2";
            // 
            // SwitchButton
            // 
            this.SwitchButton.Image = ((System.Drawing.Image)(resources.GetObject("SwitchButton.Image")));
            this.SwitchButton.Label = "开关(关)";
            this.SwitchButton.Name = "SwitchButton";
            this.SwitchButton.ScreenTip = "当前工作簿为新建工作簿且从未保存时，将自动保存到默认本地文件位置，通常为“我的文档”文件夹。";
            this.SwitchButton.ShowImage = true;
            this.SwitchButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.SwitchButton_Click);
            // 
            // group2
            // 
            this.group2.Items.Add(this.AboutButton);
            this.group2.Items.Add(this.DonateButton);
            this.group2.Label = "其他";
            this.group2.Name = "group2";
            // 
            // AboutButton
            // 
            this.AboutButton.Image = ((System.Drawing.Image)(resources.GetObject("AboutButton.Image")));
            this.AboutButton.Label = "关于";
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.ShowImage = true;
            this.AboutButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.AboutButton_Click);
            // 
            // DonateButton
            // 
            this.DonateButton.Image = ((System.Drawing.Image)(resources.GetObject("DonateButton.Image")));
            this.DonateButton.Label = "捐赠";
            this.DonateButton.Name = "DonateButton";
            this.DonateButton.ShowImage = true;
            this.DonateButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.DonateButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 420000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Excel_AutoSave
            // 
            this.Name = "Excel_AutoSave";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Excel_AutoSave_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.box1.ResumeLayout(false);
            this.box1.PerformLayout();
            this.group2.ResumeLayout(false);
            this.group2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonEditBox Interval;
        internal Microsoft.Office.Tools.Ribbon.RibbonDropDown SaveType;
        internal Microsoft.Office.Tools.Ribbon.RibbonToggleButton SwitchButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group2;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton AboutButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton DonateButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonBox box1;
        internal Microsoft.Office.Tools.Ribbon.RibbonEditBox SaveAsPath;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton SelectPathButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        internal Microsoft.Office.Tools.Ribbon.RibbonSeparator separator1;
        internal Microsoft.Office.Tools.Ribbon.RibbonSeparator separator2;
        private System.Windows.Forms.Timer timer1;
        internal Microsoft.Office.Tools.Ribbon.RibbonLabel label1;
        internal Microsoft.Office.Tools.Ribbon.RibbonLabel label2;
    }

    partial class ThisRibbonCollection
    {
        internal Excel_AutoSave Excel_AutoSave
        {
            get { return this.GetRibbon<Excel_AutoSave>(); }
        }
    }
}
