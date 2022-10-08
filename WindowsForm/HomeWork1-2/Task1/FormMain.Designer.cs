
namespace Task1
{
    partial class FormGasStation
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGasStation));
            this.GroupBoxData = new System.Windows.Forms.GroupBox();
            this.LabelTotalPrice = new System.Windows.Forms.Label();
            this.ButtonTotalPrice = new System.Windows.Forms.Button();
            this.TextBoxVolume = new System.Windows.Forms.TextBox();
            this.LabelVolume = new System.Windows.Forms.Label();
            this.LabelPrice = new System.Windows.Forms.Label();
            this.TextBoxPrice = new System.Windows.Forms.TextBox();
            this.LabelChooseTypeFuel = new System.Windows.Forms.Label();
            this.ComboBoxChooseTypeFuel = new System.Windows.Forms.ComboBox();
            this.statusStripFormMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelTimeOrDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.ToolStripMenuItemDayOfWeek = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemBackgroundColor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButtonLanguage = new System.Windows.Forms.ToolStripDropDownButton();
            this.RusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.PanelColor = new System.Windows.Forms.Panel();
            this.ButtonHidePanet = new System.Windows.Forms.Button();
            this.ButtonHideRGB = new System.Windows.Forms.Button();
            this.labelB = new System.Windows.Forms.Label();
            this.labelG = new System.Windows.Forms.Label();
            this.labelR = new System.Windows.Forms.Label();
            this.trackBarB = new System.Windows.Forms.TrackBar();
            this.trackBarG = new System.Windows.Forms.TrackBar();
            this.trackBarR = new System.Windows.Forms.TrackBar();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.GroupBoxData.SuspendLayout();
            this.statusStripFormMain.SuspendLayout();
            this.PanelColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarR)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBoxData
            // 
            this.GroupBoxData.Controls.Add(this.LabelTotalPrice);
            this.GroupBoxData.Controls.Add(this.ButtonTotalPrice);
            this.GroupBoxData.Controls.Add(this.TextBoxVolume);
            this.GroupBoxData.Controls.Add(this.LabelVolume);
            this.GroupBoxData.Controls.Add(this.LabelPrice);
            this.GroupBoxData.Controls.Add(this.TextBoxPrice);
            this.GroupBoxData.Controls.Add(this.LabelChooseTypeFuel);
            this.GroupBoxData.Controls.Add(this.ComboBoxChooseTypeFuel);
            resources.ApplyResources(this.GroupBoxData, "GroupBoxData");
            this.GroupBoxData.Name = "GroupBoxData";
            this.GroupBoxData.TabStop = false;
            // 
            // LabelTotalPrice
            // 
            resources.ApplyResources(this.LabelTotalPrice, "LabelTotalPrice");
            this.LabelTotalPrice.Name = "LabelTotalPrice";
            // 
            // ButtonTotalPrice
            // 
            resources.ApplyResources(this.ButtonTotalPrice, "ButtonTotalPrice");
            this.ButtonTotalPrice.Name = "ButtonTotalPrice";
            this.ButtonTotalPrice.UseVisualStyleBackColor = true;
            this.ButtonTotalPrice.Click += new System.EventHandler(this.ButtonTotalPrice_Click);
            // 
            // TextBoxVolume
            // 
            resources.ApplyResources(this.TextBoxVolume, "TextBoxVolume");
            this.TextBoxVolume.Name = "TextBoxVolume";
            this.TextBoxVolume.TextChanged += new System.EventHandler(this.TextBoxPrice_TextChanged);
            this.TextBoxVolume.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxPrice_KeyPress);
            // 
            // LabelVolume
            // 
            resources.ApplyResources(this.LabelVolume, "LabelVolume");
            this.LabelVolume.Name = "LabelVolume";
            // 
            // LabelPrice
            // 
            resources.ApplyResources(this.LabelPrice, "LabelPrice");
            this.LabelPrice.Name = "LabelPrice";
            // 
            // TextBoxPrice
            // 
            resources.ApplyResources(this.TextBoxPrice, "TextBoxPrice");
            this.TextBoxPrice.Name = "TextBoxPrice";
            this.TextBoxPrice.TextChanged += new System.EventHandler(this.TextBoxPrice_TextChanged);
            this.TextBoxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxPrice_KeyPress);
            // 
            // LabelChooseTypeFuel
            // 
            resources.ApplyResources(this.LabelChooseTypeFuel, "LabelChooseTypeFuel");
            this.LabelChooseTypeFuel.Name = "LabelChooseTypeFuel";
            // 
            // ComboBoxChooseTypeFuel
            // 
            this.ComboBoxChooseTypeFuel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxChooseTypeFuel.FormattingEnabled = true;
            this.ComboBoxChooseTypeFuel.Items.AddRange(new object[] {
            resources.GetString("ComboBoxChooseTypeFuel.Items"),
            resources.GetString("ComboBoxChooseTypeFuel.Items1"),
            resources.GetString("ComboBoxChooseTypeFuel.Items2"),
            resources.GetString("ComboBoxChooseTypeFuel.Items3"),
            resources.GetString("ComboBoxChooseTypeFuel.Items4"),
            resources.GetString("ComboBoxChooseTypeFuel.Items5")});
            resources.ApplyResources(this.ComboBoxChooseTypeFuel, "ComboBoxChooseTypeFuel");
            this.ComboBoxChooseTypeFuel.Name = "ComboBoxChooseTypeFuel";
            // 
            // statusStripFormMain
            // 
            this.statusStripFormMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelTimeOrDate,
            this.toolStripDropDownButton1,
            this.toolStripDropDownButtonLanguage});
            resources.ApplyResources(this.statusStripFormMain, "statusStripFormMain");
            this.statusStripFormMain.Name = "statusStripFormMain";
            // 
            // toolStripStatusLabelTimeOrDate
            // 
            this.toolStripStatusLabelTimeOrDate.Name = "toolStripStatusLabelTimeOrDate";
            resources.ApplyResources(this.toolStripStatusLabelTimeOrDate, "toolStripStatusLabelTimeOrDate");
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemDayOfWeek,
            this.ToolStripMenuItemBackgroundColor});
            resources.ApplyResources(this.toolStripDropDownButton1, "toolStripDropDownButton1");
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            // 
            // ToolStripMenuItemDayOfWeek
            // 
            this.ToolStripMenuItemDayOfWeek.Name = "ToolStripMenuItemDayOfWeek";
            resources.ApplyResources(this.ToolStripMenuItemDayOfWeek, "ToolStripMenuItemDayOfWeek");
            // 
            // ToolStripMenuItemBackgroundColor
            // 
            this.ToolStripMenuItemBackgroundColor.Name = "ToolStripMenuItemBackgroundColor";
            resources.ApplyResources(this.ToolStripMenuItemBackgroundColor, "ToolStripMenuItemBackgroundColor");
            this.ToolStripMenuItemBackgroundColor.Click += new System.EventHandler(this.ToolStripMenuItemBackgroundColor_Click);
            // 
            // toolStripDropDownButtonLanguage
            // 
            this.toolStripDropDownButtonLanguage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButtonLanguage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RusToolStripMenuItem,
            this.EngToolStripMenuItem});
            resources.ApplyResources(this.toolStripDropDownButtonLanguage, "toolStripDropDownButtonLanguage");
            this.toolStripDropDownButtonLanguage.Name = "toolStripDropDownButtonLanguage";
            this.toolStripDropDownButtonLanguage.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // RusToolStripMenuItem
            // 
            this.RusToolStripMenuItem.Name = "RusToolStripMenuItem";
            resources.ApplyResources(this.RusToolStripMenuItem, "RusToolStripMenuItem");
            this.RusToolStripMenuItem.Click += new System.EventHandler(this.RusToolStripMenuItem_Click);
            // 
            // EngToolStripMenuItem
            // 
            this.EngToolStripMenuItem.Name = "EngToolStripMenuItem";
            resources.ApplyResources(this.EngToolStripMenuItem, "EngToolStripMenuItem");
            this.EngToolStripMenuItem.Click += new System.EventHandler(this.EngToolStripMenuItem_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // PanelColor
            // 
            this.PanelColor.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.PanelColor.Controls.Add(this.ButtonHidePanet);
            this.PanelColor.Controls.Add(this.ButtonHideRGB);
            this.PanelColor.Controls.Add(this.labelB);
            this.PanelColor.Controls.Add(this.labelG);
            this.PanelColor.Controls.Add(this.labelR);
            this.PanelColor.Controls.Add(this.trackBarB);
            this.PanelColor.Controls.Add(this.trackBarG);
            this.PanelColor.Controls.Add(this.trackBarR);
            resources.ApplyResources(this.PanelColor, "PanelColor");
            this.PanelColor.Name = "PanelColor";
            // 
            // ButtonHidePanet
            // 
            resources.ApplyResources(this.ButtonHidePanet, "ButtonHidePanet");
            this.ButtonHidePanet.Name = "ButtonHidePanet";
            this.ButtonHidePanet.UseVisualStyleBackColor = true;
            this.ButtonHidePanet.Click += new System.EventHandler(this.ButtonHidePanet_Click);
            // 
            // ButtonHideRGB
            // 
            resources.ApplyResources(this.ButtonHideRGB, "ButtonHideRGB");
            this.ButtonHideRGB.Name = "ButtonHideRGB";
            this.ButtonHideRGB.UseVisualStyleBackColor = true;
            this.ButtonHideRGB.Click += new System.EventHandler(this.ButtonHideRGB_Click);
            // 
            // labelB
            // 
            resources.ApplyResources(this.labelB, "labelB");
            this.labelB.Name = "labelB";
            // 
            // labelG
            // 
            resources.ApplyResources(this.labelG, "labelG");
            this.labelG.Name = "labelG";
            // 
            // labelR
            // 
            resources.ApplyResources(this.labelR, "labelR");
            this.labelR.Name = "labelR";
            // 
            // trackBarB
            // 
            resources.ApplyResources(this.trackBarB, "trackBarB");
            this.trackBarB.Maximum = 255;
            this.trackBarB.Name = "trackBarB";
            this.trackBarB.ValueChanged += new System.EventHandler(this.trackBarR_ValueChanged);
            // 
            // trackBarG
            // 
            resources.ApplyResources(this.trackBarG, "trackBarG");
            this.trackBarG.Maximum = 255;
            this.trackBarG.Name = "trackBarG";
            this.trackBarG.ValueChanged += new System.EventHandler(this.trackBarR_ValueChanged);
            // 
            // trackBarR
            // 
            resources.ApplyResources(this.trackBarR, "trackBarR");
            this.trackBarR.Maximum = 255;
            this.trackBarR.Name = "trackBarR";
            this.trackBarR.ValueChanged += new System.EventHandler(this.trackBarR_ValueChanged);
            // 
            // notifyIcon1
            // 
            resources.ApplyResources(this.notifyIcon1, "notifyIcon1");
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // FormGasStation
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.Controls.Add(this.PanelColor);
            this.Controls.Add(this.statusStripFormMain);
            this.Controls.Add(this.GroupBoxData);
            this.Name = "FormGasStation";
            this.Resize += new System.EventHandler(this.FormGasStation_Resize);
            this.GroupBoxData.ResumeLayout(false);
            this.GroupBoxData.PerformLayout();
            this.statusStripFormMain.ResumeLayout(false);
            this.statusStripFormMain.PerformLayout();
            this.PanelColor.ResumeLayout(false);
            this.PanelColor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoxData;
        private System.Windows.Forms.Button ButtonTotalPrice;
        private System.Windows.Forms.TextBox TextBoxVolume;
        private System.Windows.Forms.Label LabelVolume;
        private System.Windows.Forms.Label LabelPrice;
        private System.Windows.Forms.TextBox TextBoxPrice;
        private System.Windows.Forms.Label LabelChooseTypeFuel;
        private System.Windows.Forms.ComboBox ComboBoxChooseTypeFuel;
        private System.Windows.Forms.Label LabelTotalPrice;
        private System.Windows.Forms.StatusStrip statusStripFormMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTimeOrDate;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDayOfWeek;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemBackgroundColor;
        private System.Windows.Forms.Panel PanelColor;
        private System.Windows.Forms.Button ButtonHideRGB;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelG;
        private System.Windows.Forms.Label labelR;
        private System.Windows.Forms.TrackBar trackBarB;
        private System.Windows.Forms.TrackBar trackBarG;
        private System.Windows.Forms.TrackBar trackBarR;
        private System.Windows.Forms.Button ButtonHidePanet;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonLanguage;
        private System.Windows.Forms.ToolStripMenuItem RusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EngToolStripMenuItem;
    }
}

