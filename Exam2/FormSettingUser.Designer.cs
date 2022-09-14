
namespace WinFormsApp1
{
    partial class FormSettingUser
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettingUser));
            this.ButtonSeeNotSeePassword = new System.Windows.Forms.Button();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.dateTimePickerBirthday = new System.Windows.Forms.DateTimePicker();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ButtonSaveSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonSeeNotSeePassword
            // 
            this.ButtonSeeNotSeePassword.ImageIndex = 0;
            this.ButtonSeeNotSeePassword.ImageList = this.imageList1;
            this.ButtonSeeNotSeePassword.Location = new System.Drawing.Point(485, 32);
            this.ButtonSeeNotSeePassword.Name = "ButtonSeeNotSeePassword";
            this.ButtonSeeNotSeePassword.Size = new System.Drawing.Size(44, 34);
            this.ButtonSeeNotSeePassword.TabIndex = 12;
            this.ButtonSeeNotSeePassword.UseVisualStyleBackColor = true;
            this.ButtonSeeNotSeePassword.Click += new System.EventHandler(this.ButtonSeeNotSeePassword_Click);
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelBirthday.Location = new System.Drawing.Point(28, 89);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(170, 28);
            this.labelBirthday.TabIndex = 11;
            this.labelBirthday.Text = "Дата рождения:";
            // 
            // dateTimePickerBirthday
            // 
            this.dateTimePickerBirthday.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerBirthday.Location = new System.Drawing.Point(216, 89);
            this.dateTimePickerBirthday.Name = "dateTimePickerBirthday";
            this.dateTimePickerBirthday.Size = new System.Drawing.Size(263, 34);
            this.dateTimePickerBirthday.TabIndex = 10;
            this.dateTimePickerBirthday.Value = new System.DateTime(2022, 9, 14, 0, 0, 0, 0);
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxPassword.Location = new System.Drawing.Point(216, 32);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.PasswordChar = '*';
            this.TextBoxPassword.PlaceholderText = "Введите пароль";
            this.TextBoxPassword.Size = new System.Drawing.Size(263, 34);
            this.TextBoxPassword.TabIndex = 9;
            this.TextBoxPassword.TextChanged += new System.EventHandler(this.TextBoxPassword_TextChanged);
            this.TextBoxPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxPassword_KeyPress);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPassword.Location = new System.Drawing.Point(28, 32);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(90, 28);
            this.labelPassword.TabIndex = 8;
            this.labelPassword.Text = "Пароль:";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-closed-eye-80.png");
            this.imageList1.Images.SetKeyName(1, "icons8-eye-80.png");
            // 
            // ButtonSaveSettings
            // 
            this.ButtonSaveSettings.Enabled = false;
            this.ButtonSaveSettings.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonSaveSettings.Location = new System.Drawing.Point(28, 147);
            this.ButtonSaveSettings.Name = "ButtonSaveSettings";
            this.ButtonSaveSettings.Size = new System.Drawing.Size(451, 99);
            this.ButtonSaveSettings.TabIndex = 13;
            this.ButtonSaveSettings.Text = "Сохранить настройки";
            this.ButtonSaveSettings.UseVisualStyleBackColor = true;
            this.ButtonSaveSettings.Click += new System.EventHandler(this.ButtonSaveSettings_Click);
            // 
            // FormSettingUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 275);
            this.Controls.Add(this.ButtonSaveSettings);
            this.Controls.Add(this.ButtonSeeNotSeePassword);
            this.Controls.Add(this.labelBirthday);
            this.Controls.Add(this.dateTimePickerBirthday);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.labelPassword);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSettingUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменить настройки пользователя";
            this.Load += new System.EventHandler(this.FormSettingUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonSeeNotSeePassword;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthday;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button ButtonSaveSettings;
    }
}