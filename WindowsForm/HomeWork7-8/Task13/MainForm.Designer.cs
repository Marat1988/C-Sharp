
namespace Task13
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBoxPersonalData = new System.Windows.Forms.GroupBox();
            this.buttonAddToListBox = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelSurname = new System.Windows.Forms.Label();
            this.textBoxSurName = new System.Windows.Forms.TextBox();
            this.labelMail = new System.Windows.Forms.Label();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.labelTelephone = new System.Windows.Forms.Label();
            this.textBoxTelephone = new System.Windows.Forms.MaskedTextBox();
            this.listBoxUser = new System.Windows.Forms.ListBox();
            this.contextMenuStripEditDeleteUser = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemEditUser = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDeleteUser = new System.Windows.Forms.ToolStripMenuItem();
            this.labelListUsers = new System.Windows.Forms.Label();
            this.buttonSaveToTextFile = new System.Windows.Forms.Button();
            this.buttonDownloadFromTextFile = new System.Windows.Forms.Button();
            this.labelInfo = new System.Windows.Forms.Label();
            this.buttonExportXMLFile = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBoxPersonalData.SuspendLayout();
            this.contextMenuStripEditDeleteUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxPersonalData
            // 
            this.groupBoxPersonalData.Controls.Add(this.buttonAddToListBox);
            this.groupBoxPersonalData.Controls.Add(this.labelName);
            this.groupBoxPersonalData.Controls.Add(this.textBoxName);
            this.groupBoxPersonalData.Controls.Add(this.labelSurname);
            this.groupBoxPersonalData.Controls.Add(this.textBoxSurName);
            this.groupBoxPersonalData.Controls.Add(this.labelMail);
            this.groupBoxPersonalData.Controls.Add(this.textBoxMail);
            this.groupBoxPersonalData.Controls.Add(this.labelTelephone);
            this.groupBoxPersonalData.Controls.Add(this.textBoxTelephone);
            this.groupBoxPersonalData.Location = new System.Drawing.Point(12, 12);
            this.groupBoxPersonalData.Name = "groupBoxPersonalData";
            this.groupBoxPersonalData.Size = new System.Drawing.Size(299, 273);
            this.groupBoxPersonalData.TabIndex = 0;
            this.groupBoxPersonalData.TabStop = false;
            this.groupBoxPersonalData.Text = "Анкетные данные:";
            // 
            // buttonAddToListBox
            // 
            this.buttonAddToListBox.Location = new System.Drawing.Point(9, 182);
            this.buttonAddToListBox.Name = "buttonAddToListBox";
            this.buttonAddToListBox.Size = new System.Drawing.Size(263, 57);
            this.buttonAddToListBox.TabIndex = 8;
            this.buttonAddToListBox.Text = "Добавить в ListBox";
            this.buttonAddToListBox.UseVisualStyleBackColor = true;
            this.buttonAddToListBox.Click += new System.EventHandler(this.buttonAddToListBox_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(7, 29);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(32, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Имя:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(82, 26);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(190, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(7, 67);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(59, 13);
            this.labelSurname.TabIndex = 2;
            this.labelSurname.Text = "Фамилия:";
            // 
            // textBoxSurName
            // 
            this.textBoxSurName.Location = new System.Drawing.Point(82, 64);
            this.textBoxSurName.Name = "textBoxSurName";
            this.textBoxSurName.Size = new System.Drawing.Size(190, 20);
            this.textBoxSurName.TabIndex = 2;
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Location = new System.Drawing.Point(7, 108);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(37, 13);
            this.labelMail.TabIndex = 5;
            this.labelMail.Text = "e-mail:";
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(82, 105);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(190, 20);
            this.textBoxMail.TabIndex = 3;
            // 
            // labelTelephone
            // 
            this.labelTelephone.AutoSize = true;
            this.labelTelephone.Location = new System.Drawing.Point(6, 149);
            this.labelTelephone.Name = "labelTelephone";
            this.labelTelephone.Size = new System.Drawing.Size(69, 13);
            this.labelTelephone.TabIndex = 7;
            this.labelTelephone.Text = "Моб. номер:";
            // 
            // textBoxTelephone
            // 
            this.textBoxTelephone.Location = new System.Drawing.Point(85, 146);
            this.textBoxTelephone.Mask = "+7(000)00-00-000";
            this.textBoxTelephone.Name = "textBoxTelephone";
            this.textBoxTelephone.Size = new System.Drawing.Size(187, 20);
            this.textBoxTelephone.TabIndex = 4;
            // 
            // listBoxUser
            // 
            this.listBoxUser.ContextMenuStrip = this.contextMenuStripEditDeleteUser;
            this.listBoxUser.FormattingEnabled = true;
            this.listBoxUser.HorizontalScrollbar = true;
            this.listBoxUser.Location = new System.Drawing.Point(358, 41);
            this.listBoxUser.Name = "listBoxUser";
            this.listBoxUser.ScrollAlwaysVisible = true;
            this.listBoxUser.Size = new System.Drawing.Size(294, 251);
            this.listBoxUser.Sorted = true;
            this.listBoxUser.TabIndex = 1;
            this.listBoxUser.SelectedIndexChanged += new System.EventHandler(this.listBoxUser_SelectedIndexChanged);
            // 
            // contextMenuStripEditDeleteUser
            // 
            this.contextMenuStripEditDeleteUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemEditUser,
            this.toolStripMenuItemDeleteUser});
            this.contextMenuStripEditDeleteUser.Name = "contextMenuStripEditDeleteUser";
            this.contextMenuStripEditDeleteUser.Size = new System.Drawing.Size(277, 48);
            // 
            // toolStripMenuItemEditUser
            // 
            this.toolStripMenuItemEditUser.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemEditUser.Image")));
            this.toolStripMenuItemEditUser.Name = "toolStripMenuItemEditUser";
            this.toolStripMenuItemEditUser.Size = new System.Drawing.Size(276, 22);
            this.toolStripMenuItemEditUser.Text = "Редактировать данные пользователя";
            this.toolStripMenuItemEditUser.Click += new System.EventHandler(this.toolStripMenuItemEditUser_Click);
            // 
            // toolStripMenuItemDeleteUser
            // 
            this.toolStripMenuItemDeleteUser.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemDeleteUser.Image")));
            this.toolStripMenuItemDeleteUser.Name = "toolStripMenuItemDeleteUser";
            this.toolStripMenuItemDeleteUser.Size = new System.Drawing.Size(276, 22);
            this.toolStripMenuItemDeleteUser.Text = "Удалить пользователя";
            this.toolStripMenuItemDeleteUser.Click += new System.EventHandler(this.toolStripMenuItemDeleteUser_Click);
            // 
            // labelListUsers
            // 
            this.labelListUsers.AutoSize = true;
            this.labelListUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelListUsers.Location = new System.Drawing.Point(355, 22);
            this.labelListUsers.Name = "labelListUsers";
            this.labelListUsers.Size = new System.Drawing.Size(184, 16);
            this.labelListUsers.TabIndex = 2;
            this.labelListUsers.Text = "Список пользователей:";
            // 
            // buttonSaveToTextFile
            // 
            this.buttonSaveToTextFile.Location = new System.Drawing.Point(358, 311);
            this.buttonSaveToTextFile.Name = "buttonSaveToTextFile";
            this.buttonSaveToTextFile.Size = new System.Drawing.Size(134, 54);
            this.buttonSaveToTextFile.TabIndex = 3;
            this.buttonSaveToTextFile.Text = "Экспорт в текстовый файл";
            this.buttonSaveToTextFile.UseVisualStyleBackColor = true;
            this.buttonSaveToTextFile.Click += new System.EventHandler(this.buttonSaveToTextFile_Click);
            // 
            // buttonDownloadFromTextFile
            // 
            this.buttonDownloadFromTextFile.Location = new System.Drawing.Point(518, 311);
            this.buttonDownloadFromTextFile.Name = "buttonDownloadFromTextFile";
            this.buttonDownloadFromTextFile.Size = new System.Drawing.Size(134, 54);
            this.buttonDownloadFromTextFile.TabIndex = 4;
            this.buttonDownloadFromTextFile.Text = "Импорт из текстового файла";
            this.buttonDownloadFromTextFile.UseVisualStyleBackColor = true;
            this.buttonDownloadFromTextFile.Click += new System.EventHandler(this.buttonDownloadFromTextFile_Click);
            // 
            // labelInfo
            // 
            this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo.ForeColor = System.Drawing.Color.Blue;
            this.labelInfo.Location = new System.Drawing.Point(13, 302);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(298, 75);
            this.labelInfo.TabIndex = 5;
            this.labelInfo.Text = "ПОДСКАЗКА: Правой копкой мыши по ListBox для вызова контекстного меню";
            // 
            // buttonExportXMLFile
            // 
            this.buttonExportXMLFile.Location = new System.Drawing.Point(358, 371);
            this.buttonExportXMLFile.Name = "buttonExportXMLFile";
            this.buttonExportXMLFile.Size = new System.Drawing.Size(134, 54);
            this.buttonExportXMLFile.TabIndex = 6;
            this.buttonExportXMLFile.Text = "Экспорт в XML файл";
            this.buttonExportXMLFile.UseVisualStyleBackColor = true;
            this.buttonExportXMLFile.Click += new System.EventHandler(this.buttonExportXMLFile_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(518, 371);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 54);
            this.button2.TabIndex = 7;
            this.button2.Text = "Импорт из XML файла";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonExportXMLFile);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.buttonDownloadFromTextFile);
            this.Controls.Add(this.buttonSaveToTextFile);
            this.Controls.Add(this.labelListUsers);
            this.Controls.Add(this.listBoxUser);
            this.Controls.Add(this.groupBoxPersonalData);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.groupBoxPersonalData.ResumeLayout(false);
            this.groupBoxPersonalData.PerformLayout();
            this.contextMenuStripEditDeleteUser.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPersonalData;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.TextBox textBoxSurName;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.Label labelTelephone;
        private System.Windows.Forms.MaskedTextBox textBoxTelephone;
        private System.Windows.Forms.ListBox listBoxUser;
        private System.Windows.Forms.Button buttonAddToListBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripEditDeleteUser;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEditUser;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDeleteUser;
        private System.Windows.Forms.Label labelListUsers;
        private System.Windows.Forms.Button buttonSaveToTextFile;
        private System.Windows.Forms.Button buttonDownloadFromTextFile;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Button buttonExportXMLFile;
        private System.Windows.Forms.Button button2;
    }
}

