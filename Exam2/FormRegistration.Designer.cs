
namespace WinFormsApp1
{
    partial class FormRegistration
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
            this.labelLogin = new System.Windows.Forms.Label();
            this.TextBoxLogin = new System.Windows.Forms.TextBox();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.dateTimePickerBirthday = new System.Windows.Forms.DateTimePicker();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.ButtonUserRegistration = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLogin.Location = new System.Drawing.Point(32, 25);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(77, 28);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "Логин:";
            // 
            // TextBoxLogin
            // 
            this.TextBoxLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxLogin.Location = new System.Drawing.Point(220, 25);
            this.TextBoxLogin.MaxLength = 15;
            this.TextBoxLogin.Name = "TextBoxLogin";
            this.TextBoxLogin.PlaceholderText = "Введите имя пользователя";
            this.TextBoxLogin.Size = new System.Drawing.Size(263, 34);
            this.TextBoxLogin.TabIndex = 1;
            this.TextBoxLogin.TextChanged += new System.EventHandler(this.TextBoxLogin_TextChanged);
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxPassword.Location = new System.Drawing.Point(220, 81);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.PasswordChar = '*';
            this.TextBoxPassword.PlaceholderText = "Введите пароль";
            this.TextBoxPassword.Size = new System.Drawing.Size(263, 34);
            this.TextBoxPassword.TabIndex = 3;
            this.TextBoxPassword.TextChanged += new System.EventHandler(this.TextBoxPassword_TextChanged);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPassword.Location = new System.Drawing.Point(32, 81);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(90, 28);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Пароль:";
            // 
            // dateTimePickerBirthday
            // 
            this.dateTimePickerBirthday.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerBirthday.Location = new System.Drawing.Point(220, 138);
            this.dateTimePickerBirthday.Name = "dateTimePickerBirthday";
            this.dateTimePickerBirthday.Size = new System.Drawing.Size(263, 34);
            this.dateTimePickerBirthday.TabIndex = 4;
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelBirthday.Location = new System.Drawing.Point(32, 138);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(170, 28);
            this.labelBirthday.TabIndex = 5;
            this.labelBirthday.Text = "Дата рождения:";
            // 
            // ButtonUserRegistration
            // 
            this.ButtonUserRegistration.Enabled = false;
            this.ButtonUserRegistration.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonUserRegistration.Location = new System.Drawing.Point(32, 205);
            this.ButtonUserRegistration.Name = "ButtonUserRegistration";
            this.ButtonUserRegistration.Size = new System.Drawing.Size(451, 85);
            this.ButtonUserRegistration.TabIndex = 6;
            this.ButtonUserRegistration.Text = "Зарегистрироваться";
            this.ButtonUserRegistration.UseVisualStyleBackColor = true;
            this.ButtonUserRegistration.Click += new System.EventHandler(this.ButtonUserRegistration_Click);
            // 
            // FormRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 334);
            this.Controls.Add(this.ButtonUserRegistration);
            this.Controls.Add(this.labelBirthday);
            this.Controls.Add(this.dateTimePickerBirthday);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.TextBoxLogin);
            this.Controls.Add(this.labelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация в системе";
            this.Load += new System.EventHandler(this.FormRegistration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox TextBoxLogin;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthday;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.Button ButtonUserRegistration;
    }
}