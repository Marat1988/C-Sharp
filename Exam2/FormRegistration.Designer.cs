
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistration));
            this.labelLogin = new System.Windows.Forms.Label();
            this.TextBoxLogin = new System.Windows.Forms.TextBox();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.dateTimePickerBirthday = new System.Windows.Forms.DateTimePicker();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.ButtonUserRegistration = new System.Windows.Forms.Button();
            this.ButtonSeeNotSeePassword = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
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
            this.TextBoxLogin.TabIndex = 0;
            this.TextBoxLogin.TextChanged += new System.EventHandler(this.TextBoxLogin_TextChanged);
            this.TextBoxLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxLogin_KeyPress);
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxPassword.Location = new System.Drawing.Point(220, 81);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.PasswordChar = '*';
            this.TextBoxPassword.PlaceholderText = "Введите пароль";
            this.TextBoxPassword.Size = new System.Drawing.Size(263, 34);
            this.TextBoxPassword.TabIndex = 1;
            this.TextBoxPassword.TextChanged += new System.EventHandler(this.TextBoxPassword_TextChanged);
            this.TextBoxPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxPassword_KeyPress);
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
            this.dateTimePickerBirthday.TabIndex = 2;
            this.dateTimePickerBirthday.Value = new System.DateTime(2022, 9, 14, 0, 0, 0, 0);
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
            this.ButtonUserRegistration.TabIndex = 3;
            this.ButtonUserRegistration.Text = "Зарегистрироваться";
            this.ButtonUserRegistration.UseVisualStyleBackColor = true;
            this.ButtonUserRegistration.Click += new System.EventHandler(this.ButtonUserRegistration_Click);
            // 
            // ButtonSeeNotSeePassword
            // 
            this.ButtonSeeNotSeePassword.ImageIndex = 0;
            this.ButtonSeeNotSeePassword.ImageList = this.imageList1;
            this.ButtonSeeNotSeePassword.Location = new System.Drawing.Point(489, 81);
            this.ButtonSeeNotSeePassword.Name = "ButtonSeeNotSeePassword";
            this.ButtonSeeNotSeePassword.Size = new System.Drawing.Size(44, 34);
            this.ButtonSeeNotSeePassword.TabIndex = 4;
            this.ButtonSeeNotSeePassword.UseVisualStyleBackColor = true;
            this.ButtonSeeNotSeePassword.Click += new System.EventHandler(this.ButtonSeeNotSeePassword_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-closed-eye-80.png");
            this.imageList1.Images.SetKeyName(1, "icons8-eye-80.png");
            // 
            // FormRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 334);
            this.Controls.Add(this.ButtonSeeNotSeePassword);
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
        private System.Windows.Forms.Button ButtonSeeNotSeePassword;
        private System.Windows.Forms.ImageList imageList1;
    }
}