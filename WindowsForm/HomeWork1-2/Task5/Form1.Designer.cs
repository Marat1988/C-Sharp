﻿
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
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonCopy = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonСut = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPaste = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUndo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.textBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenDocumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveDocumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewDocumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UndoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.toolStripButtonUndo,
            this.toolStripSeparator2});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 24);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(600, 57);
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
            this.toolStripButtonAddOpenDocument.Click += new System.EventHandler(this.toolStripButtonAddOpenDocument_Click);
            // 
            // toolStripButtonSaveDocument
            // 
            this.toolStripButtonSaveDocument.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSaveDocument.Enabled = false;
            this.toolStripButtonSaveDocument.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSaveDocument.Image")));
            this.toolStripButtonSaveDocument.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSaveDocument.Name = "toolStripButtonSaveDocument";
            this.toolStripButtonSaveDocument.Size = new System.Drawing.Size(54, 54);
            this.toolStripButtonSaveDocument.Text = "Сохранить документ";
            this.toolStripButtonSaveDocument.Click += new System.EventHandler(this.toolStripButtonSaveDocument_Click);
            // 
            // toolStripButtonNewDocument
            // 
            this.toolStripButtonNewDocument.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonNewDocument.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNewDocument.Image")));
            this.toolStripButtonNewDocument.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNewDocument.Name = "toolStripButtonNewDocument";
            this.toolStripButtonNewDocument.Size = new System.Drawing.Size(54, 54);
            this.toolStripButtonNewDocument.Text = "Новый документ";
            this.toolStripButtonNewDocument.Click += new System.EventHandler(this.toolStripButtonNewDocument_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 57);
            // 
            // toolStripButtonCopy
            // 
            this.toolStripButtonCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCopy.Enabled = false;
            this.toolStripButtonCopy.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCopy.Image")));
            this.toolStripButtonCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCopy.Name = "toolStripButtonCopy";
            this.toolStripButtonCopy.Size = new System.Drawing.Size(54, 54);
            this.toolStripButtonCopy.Text = "Копировать";
            this.toolStripButtonCopy.Click += new System.EventHandler(this.toolStripButtonCopy_Click);
            // 
            // toolStripButtonСut
            // 
            this.toolStripButtonСut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonСut.Enabled = false;
            this.toolStripButtonСut.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonСut.Image")));
            this.toolStripButtonСut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonСut.Name = "toolStripButtonСut";
            this.toolStripButtonСut.Size = new System.Drawing.Size(54, 54);
            this.toolStripButtonСut.Text = "Вырезать";
            this.toolStripButtonСut.Click += new System.EventHandler(this.toolStripButtonСut_Click);
            // 
            // toolStripButtonPaste
            // 
            this.toolStripButtonPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPaste.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPaste.Image")));
            this.toolStripButtonPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPaste.Name = "toolStripButtonPaste";
            this.toolStripButtonPaste.Size = new System.Drawing.Size(54, 54);
            this.toolStripButtonPaste.Text = "Вставить";
            this.toolStripButtonPaste.Click += new System.EventHandler(this.toolStripButtonPaste_Click);
            // 
            // toolStripButtonUndo
            // 
            this.toolStripButtonUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonUndo.Enabled = false;
            this.toolStripButtonUndo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUndo.Image")));
            this.toolStripButtonUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUndo.Name = "toolStripButtonUndo";
            this.toolStripButtonUndo.Size = new System.Drawing.Size(54, 54);
            this.toolStripButtonUndo.Text = "Отменить последнюю операцию";
            this.toolStripButtonUndo.Click += new System.EventHandler(this.toolStripButtonUndo_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 57);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "open.bmp");
            // 
            // textBox
            // 
            this.textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox.Location = new System.Drawing.Point(0, 81);
            this.textBox.Margin = new System.Windows.Forms.Padding(2);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox.ShortcutsEnabled = false;
            this.textBox.Size = new System.Drawing.Size(600, 285);
            this.textBox.TabIndex = 1;
            this.textBox.Click += new System.EventHandler(this.textBox_Click);
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.EditToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenDocumentToolStripMenuItem,
            this.SaveDocumentToolStripMenuItem,
            this.NewDocumentToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.FileToolStripMenuItem.Text = "Файл";
            // 
            // OpenDocumentToolStripMenuItem
            // 
            this.OpenDocumentToolStripMenuItem.Name = "OpenDocumentToolStripMenuItem";
            this.OpenDocumentToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenDocumentToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.OpenDocumentToolStripMenuItem.Text = "Открыть документ";
            this.OpenDocumentToolStripMenuItem.Click += new System.EventHandler(this.toolStripButtonAddOpenDocument_Click);
            // 
            // SaveDocumentToolStripMenuItem
            // 
            this.SaveDocumentToolStripMenuItem.Enabled = false;
            this.SaveDocumentToolStripMenuItem.Name = "SaveDocumentToolStripMenuItem";
            this.SaveDocumentToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveDocumentToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.SaveDocumentToolStripMenuItem.Text = "Сохранить документ";
            this.SaveDocumentToolStripMenuItem.Click += new System.EventHandler(this.toolStripButtonSaveDocument_Click);
            // 
            // NewDocumentToolStripMenuItem
            // 
            this.NewDocumentToolStripMenuItem.Name = "NewDocumentToolStripMenuItem";
            this.NewDocumentToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.NewDocumentToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.NewDocumentToolStripMenuItem.Text = "Новый документ";
            this.NewDocumentToolStripMenuItem.Click += new System.EventHandler(this.toolStripButtonNewDocument_Click);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopyToolStripMenuItem,
            this.CutToolStripMenuItem,
            this.PasteToolStripMenuItem,
            this.UndoToolStripMenuItem});
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.EditToolStripMenuItem.Text = "Правка";
            // 
            // CopyToolStripMenuItem
            // 
            this.CopyToolStripMenuItem.Enabled = false;
            this.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem";
            this.CopyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.CopyToolStripMenuItem.Size = new System.Drawing.Size(298, 22);
            this.CopyToolStripMenuItem.Text = "Копировать";
            this.CopyToolStripMenuItem.Click += new System.EventHandler(this.toolStripButtonCopy_Click);
            // 
            // CutToolStripMenuItem
            // 
            this.CutToolStripMenuItem.Enabled = false;
            this.CutToolStripMenuItem.Name = "CutToolStripMenuItem";
            this.CutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.CutToolStripMenuItem.Size = new System.Drawing.Size(298, 22);
            this.CutToolStripMenuItem.Text = "Вырезать";
            this.CutToolStripMenuItem.Click += new System.EventHandler(this.toolStripButtonСut_Click);
            // 
            // PasteToolStripMenuItem
            // 
            this.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem";
            this.PasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.PasteToolStripMenuItem.Size = new System.Drawing.Size(298, 22);
            this.PasteToolStripMenuItem.Text = "Вставить";
            this.PasteToolStripMenuItem.Click += new System.EventHandler(this.toolStripButtonPaste_Click);
            // 
            // UndoToolStripMenuItem
            // 
            this.UndoToolStripMenuItem.Enabled = false;
            this.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem";
            this.UndoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.UndoToolStripMenuItem.Size = new System.Drawing.Size(298, 22);
            this.UndoToolStripMenuItem.Text = "Отменить последнюю операцию";
            this.UndoToolStripMenuItem.Click += new System.EventHandler(this.toolStripButtonUndo_Click);
            // 
            // FormTextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.toolStripMenu);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.ToolStripButton toolStripButtonUndo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenDocumentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveDocumentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewDocumentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UndoToolStripMenuItem;
    }
}

