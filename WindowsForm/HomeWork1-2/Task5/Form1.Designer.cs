
namespace Task5
{
    partial class FormTextEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTextEditor));
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAddOpenDocument = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSaveDocument = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonNewDocument = new System.Windows.Forms.ToolStripButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonCopy = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonСut = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPaste = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.textBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьДокументToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьДокументToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйДокументToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вырезатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAddOpenDocument,
            this.toolStripButtonSaveDocument,
            this.toolStripButtonNewDocument,
            this.toolStripSeparator1,
            this.toolStripButtonCopy,
            this.toolStripButtonСut,
            this.toolStripButtonPaste,
            this.toolStripButtonCancel,
            this.toolStripSeparator2});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 28);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(800, 57);
            this.toolStripMenu.TabIndex = 0;
            this.toolStripMenu.Text = "toolStripMenu";
            // 
            // toolStripButtonAddOpenDocument
            // 
            this.toolStripButtonAddOpenDocument.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAddOpenDocument.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAddOpenDocument.Image")));
            this.toolStripButtonAddOpenDocument.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddOpenDocument.Name = "toolStripButtonAddOpenDocument";
            this.toolStripButtonAddOpenDocument.Size = new System.Drawing.Size(54, 54);
            this.toolStripButtonAddOpenDocument.Text = "Открыть документ";
            // 
            // toolStripButtonSaveDocument
            // 
            this.toolStripButtonSaveDocument.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSaveDocument.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSaveDocument.Image")));
            this.toolStripButtonSaveDocument.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSaveDocument.Name = "toolStripButtonSaveDocument";
            this.toolStripButtonSaveDocument.Size = new System.Drawing.Size(54, 54);
            this.toolStripButtonSaveDocument.Text = "Сохранить документ";
            // 
            // toolStripButtonNewDocument
            // 
            this.toolStripButtonNewDocument.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonNewDocument.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNewDocument.Image")));
            this.toolStripButtonNewDocument.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNewDocument.Name = "toolStripButtonNewDocument";
            this.toolStripButtonNewDocument.Size = new System.Drawing.Size(54, 54);
            this.toolStripButtonNewDocument.Text = "Новый документ";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "open.bmp");
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 57);
            // 
            // toolStripButtonCopy
            // 
            this.toolStripButtonCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCopy.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCopy.Image")));
            this.toolStripButtonCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCopy.Name = "toolStripButtonCopy";
            this.toolStripButtonCopy.Size = new System.Drawing.Size(54, 54);
            this.toolStripButtonCopy.Text = "Копировать";
            // 
            // toolStripButtonСut
            // 
            this.toolStripButtonСut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonСut.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonСut.Image")));
            this.toolStripButtonСut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonСut.Name = "toolStripButtonСut";
            this.toolStripButtonСut.Size = new System.Drawing.Size(54, 54);
            this.toolStripButtonСut.Text = "Вырезать";
            // 
            // toolStripButtonPaste
            // 
            this.toolStripButtonPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPaste.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPaste.Image")));
            this.toolStripButtonPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPaste.Name = "toolStripButtonPaste";
            this.toolStripButtonPaste.Size = new System.Drawing.Size(54, 54);
            this.toolStripButtonPaste.Text = "Вставить";
            // 
            // toolStripButtonCancel
            // 
            this.toolStripButtonCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCancel.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCancel.Image")));
            this.toolStripButtonCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCancel.Name = "toolStripButtonCancel";
            this.toolStripButtonCancel.Size = new System.Drawing.Size(54, 54);
            this.toolStripButtonCancel.Text = "Отменить";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 57);
            // 
            // textBox
            // 
            this.textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox.Location = new System.Drawing.Point(0, 85);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox.Size = new System.Drawing.Size(800, 365);
            this.textBox.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.правкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьДокументToolStripMenuItem,
            this.сохранитьДокументToolStripMenuItem,
            this.новыйДокументToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьДокументToolStripMenuItem
            // 
            this.открытьДокументToolStripMenuItem.Name = "открытьДокументToolStripMenuItem";
            this.открытьДокументToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.открытьДокументToolStripMenuItem.Text = "Открыть документ";
            // 
            // сохранитьДокументToolStripMenuItem
            // 
            this.сохранитьДокументToolStripMenuItem.Name = "сохранитьДокументToolStripMenuItem";
            this.сохранитьДокументToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.сохранитьДокументToolStripMenuItem.Text = "Сохранить документ";
            // 
            // новыйДокументToolStripMenuItem
            // 
            this.новыйДокументToolStripMenuItem.Name = "новыйДокументToolStripMenuItem";
            this.новыйДокументToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.новыйДокументToolStripMenuItem.Text = "Новый документ";
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.копироватьToolStripMenuItem,
            this.вырезатьToolStripMenuItem,
            this.вставитьToolStripMenuItem,
            this.отменитьToolStripMenuItem});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.правкаToolStripMenuItem.Text = "Правка";
            // 
            // копироватьToolStripMenuItem
            // 
            this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.копироватьToolStripMenuItem.Text = "Копировать";
            // 
            // вырезатьToolStripMenuItem
            // 
            this.вырезатьToolStripMenuItem.Name = "вырезатьToolStripMenuItem";
            this.вырезатьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.вырезатьToolStripMenuItem.Text = "Вырезать";
            // 
            // вставитьToolStripMenuItem
            // 
            this.вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            this.вставитьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.вставитьToolStripMenuItem.Text = "Вставить";
            // 
            // отменитьToolStripMenuItem
            // 
            this.отменитьToolStripMenuItem.Name = "отменитьToolStripMenuItem";
            this.отменитьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.отменитьToolStripMenuItem.Text = "Отменить";
            // 
            // FormTextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.toolStripMenu);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormTextEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Текстовый редактор";
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddOpenDocument;
        private System.Windows.Forms.ToolStripButton toolStripButtonSaveDocument;
        private System.Windows.Forms.ToolStripButton toolStripButtonNewDocument;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonCopy;
        private System.Windows.Forms.ToolStripButton toolStripButtonСut;
        private System.Windows.Forms.ToolStripButton toolStripButtonPaste;
        private System.Windows.Forms.ToolStripButton toolStripButtonCancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьДокументToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьДокументToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новыйДокументToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вырезатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отменитьToolStripMenuItem;
    }
}

