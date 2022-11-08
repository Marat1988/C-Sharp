
namespace Task9
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
            this.groupBoxProfile = new System.Windows.Forms.GroupBox();
            this.textBoxAdditionalInfo = new System.Windows.Forms.TextBox();
            this.labelAdditionalInfo = new System.Windows.Forms.Label();
            this.dateTimePickerBirthday = new System.Windows.Forms.DateTimePicker();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.groupBoxGender = new System.Windows.Forms.GroupBox();
            this.radioButtonWoman = new System.Windows.Forms.RadioButton();
            this.radioButtonMens = new System.Windows.Forms.RadioButton();
            this.textBoxMiddleName = new System.Windows.Forms.TextBox();
            this.labelMiddleName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxSurName = new System.Windows.Forms.TextBox();
            this.labelSurName = new System.Windows.Forms.Label();
            this.buttonSaveProfileTextFile = new System.Windows.Forms.Button();
            this.radioButtonIt = new System.Windows.Forms.RadioButton();
            this.groupBoxProfile.SuspendLayout();
            this.groupBoxGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxProfile
            // 
            this.groupBoxProfile.Controls.Add(this.textBoxAdditionalInfo);
            this.groupBoxProfile.Controls.Add(this.labelAdditionalInfo);
            this.groupBoxProfile.Controls.Add(this.dateTimePickerBirthday);
            this.groupBoxProfile.Controls.Add(this.labelBirthday);
            this.groupBoxProfile.Controls.Add(this.groupBoxGender);
            this.groupBoxProfile.Controls.Add(this.textBoxMiddleName);
            this.groupBoxProfile.Controls.Add(this.labelMiddleName);
            this.groupBoxProfile.Controls.Add(this.textBoxName);
            this.groupBoxProfile.Controls.Add(this.labelName);
            this.groupBoxProfile.Controls.Add(this.textBoxSurName);
            this.groupBoxProfile.Controls.Add(this.labelSurName);
            this.groupBoxProfile.Location = new System.Drawing.Point(12, 12);
            this.groupBoxProfile.Name = "groupBoxProfile";
            this.groupBoxProfile.Size = new System.Drawing.Size(283, 417);
            this.groupBoxProfile.TabIndex = 0;
            this.groupBoxProfile.TabStop = false;
            this.groupBoxProfile.Text = "Анкета:";
            // 
            // textBoxAdditionalInfo
            // 
            this.textBoxAdditionalInfo.Location = new System.Drawing.Point(122, 251);
            this.textBoxAdditionalInfo.Multiline = true;
            this.textBoxAdditionalInfo.Name = "textBoxAdditionalInfo";
            this.textBoxAdditionalInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxAdditionalInfo.Size = new System.Drawing.Size(147, 151);
            this.textBoxAdditionalInfo.TabIndex = 10;
            // 
            // labelAdditionalInfo
            // 
            this.labelAdditionalInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAdditionalInfo.Location = new System.Drawing.Point(15, 300);
            this.labelAdditionalInfo.Name = "labelAdditionalInfo";
            this.labelAdditionalInfo.Size = new System.Drawing.Size(105, 42);
            this.labelAdditionalInfo.TabIndex = 9;
            this.labelAdditionalInfo.Text = "Дополнительная информация:";
            // 
            // dateTimePickerBirthday
            // 
            this.dateTimePickerBirthday.Location = new System.Drawing.Point(122, 215);
            this.dateTimePickerBirthday.Name = "dateTimePickerBirthday";
            this.dateTimePickerBirthday.Size = new System.Drawing.Size(147, 20);
            this.dateTimePickerBirthday.TabIndex = 8;
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBirthday.Location = new System.Drawing.Point(13, 215);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(103, 13);
            this.labelBirthday.TabIndex = 7;
            this.labelBirthday.Text = "Дата рождения:";
            // 
            // groupBoxGender
            // 
            this.groupBoxGender.Controls.Add(this.radioButtonIt);
            this.groupBoxGender.Controls.Add(this.radioButtonWoman);
            this.groupBoxGender.Controls.Add(this.radioButtonMens);
            this.groupBoxGender.Location = new System.Drawing.Point(10, 152);
            this.groupBoxGender.Name = "groupBoxGender";
            this.groupBoxGender.Size = new System.Drawing.Size(257, 48);
            this.groupBoxGender.TabIndex = 6;
            this.groupBoxGender.TabStop = false;
            this.groupBoxGender.Text = "Пол:";
            // 
            // radioButtonWoman
            // 
            this.radioButtonWoman.AutoSize = true;
            this.radioButtonWoman.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonWoman.Location = new System.Drawing.Point(100, 19);
            this.radioButtonWoman.Name = "radioButtonWoman";
            this.radioButtonWoman.Size = new System.Drawing.Size(79, 17);
            this.radioButtonWoman.TabIndex = 1;
            this.radioButtonWoman.Text = "Женский";
            this.radioButtonWoman.UseVisualStyleBackColor = true;
            // 
            // radioButtonMens
            // 
            this.radioButtonMens.AutoSize = true;
            this.radioButtonMens.Checked = true;
            this.radioButtonMens.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonMens.Location = new System.Drawing.Point(6, 19);
            this.radioButtonMens.Name = "radioButtonMens";
            this.radioButtonMens.Size = new System.Drawing.Size(78, 17);
            this.radioButtonMens.TabIndex = 0;
            this.radioButtonMens.TabStop = true;
            this.radioButtonMens.Text = "Мужской";
            this.radioButtonMens.UseVisualStyleBackColor = true;
            // 
            // textBoxMiddleName
            // 
            this.textBoxMiddleName.Location = new System.Drawing.Point(87, 113);
            this.textBoxMiddleName.Name = "textBoxMiddleName";
            this.textBoxMiddleName.Size = new System.Drawing.Size(180, 20);
            this.textBoxMiddleName.TabIndex = 5;
            // 
            // labelMiddleName
            // 
            this.labelMiddleName.AutoSize = true;
            this.labelMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMiddleName.Location = new System.Drawing.Point(7, 116);
            this.labelMiddleName.Name = "labelMiddleName";
            this.labelMiddleName.Size = new System.Drawing.Size(66, 13);
            this.labelMiddleName.TabIndex = 4;
            this.labelMiddleName.Text = "Отчество:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(87, 68);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(180, 20);
            this.textBoxName.TabIndex = 3;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(7, 71);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(36, 13);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Имя:";
            // 
            // textBoxSurName
            // 
            this.textBoxSurName.Location = new System.Drawing.Point(87, 27);
            this.textBoxSurName.Name = "textBoxSurName";
            this.textBoxSurName.Size = new System.Drawing.Size(180, 20);
            this.textBoxSurName.TabIndex = 1;
            // 
            // labelSurName
            // 
            this.labelSurName.AutoSize = true;
            this.labelSurName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSurName.Location = new System.Drawing.Point(7, 30);
            this.labelSurName.Name = "labelSurName";
            this.labelSurName.Size = new System.Drawing.Size(67, 13);
            this.labelSurName.TabIndex = 0;
            this.labelSurName.Text = "Фамилия:";
            // 
            // buttonSaveProfileTextFile
            // 
            this.buttonSaveProfileTextFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaveProfileTextFile.Location = new System.Drawing.Point(12, 447);
            this.buttonSaveProfileTextFile.Name = "buttonSaveProfileTextFile";
            this.buttonSaveProfileTextFile.Size = new System.Drawing.Size(282, 47);
            this.buttonSaveProfileTextFile.TabIndex = 1;
            this.buttonSaveProfileTextFile.Text = "Сохранить в файл";
            this.buttonSaveProfileTextFile.UseVisualStyleBackColor = true;
            this.buttonSaveProfileTextFile.Click += new System.EventHandler(this.buttonSaveProfileTextFile_Click);
            // 
            // radioButtonIt
            // 
            this.radioButtonIt.AutoSize = true;
            this.radioButtonIt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonIt.Location = new System.Drawing.Point(203, 19);
            this.radioButtonIt.Name = "radioButtonIt";
            this.radioButtonIt.Size = new System.Drawing.Size(48, 17);
            this.radioButtonIt.TabIndex = 2;
            this.radioButtonIt.Text = "Оно";
            this.radioButtonIt.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 509);
            this.Controls.Add(this.buttonSaveProfileTextFile);
            this.Controls.Add(this.groupBoxProfile);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Анкета";
            this.groupBoxProfile.ResumeLayout(false);
            this.groupBoxProfile.PerformLayout();
            this.groupBoxGender.ResumeLayout(false);
            this.groupBoxGender.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxProfile;
        private System.Windows.Forms.TextBox textBoxSurName;
        private System.Windows.Forms.Label labelSurName;
        private System.Windows.Forms.TextBox textBoxMiddleName;
        private System.Windows.Forms.Label labelMiddleName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxAdditionalInfo;
        private System.Windows.Forms.Label labelAdditionalInfo;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthday;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.GroupBox groupBoxGender;
        private System.Windows.Forms.RadioButton radioButtonWoman;
        private System.Windows.Forms.RadioButton radioButtonMens;
        private System.Windows.Forms.Button buttonSaveProfileTextFile;
        private System.Windows.Forms.RadioButton radioButtonIt;
    }
}

