
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
            this.ButtonSaveSettings = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // ButtonSeeNotSeePassword
            // 
            this.ButtonSeeNotSeePassword.ImageIndex = 0;
            this.ButtonSeeNotSeePassword.ImageList = this.imageList1;
            this.ButtonSeeNotSeePassword.Location = new System.Drawing.Point(452, 23);
            this.ButtonSeeNotSeePassword.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonSeeNotSeePassword.Name = "ButtonSeeNotSeePassword";
            this.ButtonSeeNotSeePassword.Size = new System.Drawing.Size(40, 33);
            this.ButtonSeeNotSeePassword.TabIndex = 3;
            this.ButtonSeeNotSeePassword.UseVisualStyleBackColor = true;
            this.ButtonSeeNotSeePassword.Click += new System.EventHandler(this.ButtonSeeNotSeePassword_Click);
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBirthday.Location = new System.Drawing.Point(21, 71);
            this.labelBirthday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(179, 30);
            this.labelBirthday.TabIndex = 11;
            this.labelBirthday.Text = "Дата рождения:";
            // 
            // dateTimePickerBirthday
            // 
            this.dateTimePickerBirthday.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerBirthday.Location = new System.Drawing.Point(216, 67);
            this.dateTimePickerBirthday.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerBirthday.Name = "dateTimePickerBirthday";
            this.dateTimePickerBirthday.Size = new System.Drawing.Size(232, 35);
            this.dateTimePickerBirthday.TabIndex = 1;
            this.dateTimePickerBirthday.Value = new System.DateTime(2022, 9, 14, 0, 0, 0, 0);
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxPassword.Location = new System.Drawing.Point(216, 21);
            this.TextBoxPassword.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxPassword.MaxLength = 50;
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.PasswordChar = '*';
            this.TextBoxPassword.Size = new System.Drawing.Size(232, 35);
            this.TextBoxPassword.TabIndex = 0;
            this.TextBoxPassword.TextChanged += new System.EventHandler(this.TextBoxPassword_TextChanged);
            this.TextBoxPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxPassword_KeyPress);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassword.Location = new System.Drawing.Point(21, 21);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(97, 30);
            this.labelPassword.TabIndex = 8;
            this.labelPassword.Text = "Пароль:";
            // 
            // ButtonSaveSettings
            // 
            this.ButtonSaveSettings.Enabled = false;
            this.ButtonSaveSettings.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold);
            this.ButtonSaveSettings.Location = new System.Drawing.Point(26, 124);
            this.ButtonSaveSettings.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonSaveSettings.Name = "ButtonSaveSettings";
            this.ButtonSaveSettings.Size = new System.Drawing.Size(422, 55);
            this.ButtonSaveSettings.TabIndex = 2;
            this.ButtonSaveSettings.Text = "Сохранить настройки";
            this.ButtonSaveSettings.UseVisualStyleBackColor = true;
            this.ButtonSaveSettings.Click += new System.EventHandler(this.ButtonSaveSettings_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-closed-eye-80.png");
            this.imageList1.Images.SetKeyName(1, "icons8-eye-80.png");
            // 
            // FormSettingUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 205);
            this.Controls.Add(this.ButtonSaveSettings);
            this.Controls.Add(this.ButtonSeeNotSeePassword);
            this.Controls.Add(this.labelBirthday);
            this.Controls.Add(this.dateTimePickerBirthday);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.labelPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthday;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button ButtonSaveSettings;
        private System.Windows.Forms.ImageList imageList1;
    }
}