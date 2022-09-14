﻿
namespace WinFormsApp1
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.TextBoxUser = new System.Windows.Forms.TextBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.ButtonInputSystem = new System.Windows.Forms.Button();
            this.LinkLabelAuthorization = new System.Windows.Forms.LinkLabel();
            this.ButtonSeeNotSeePassword = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // TextBoxUser
            // 
            this.TextBoxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxUser.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TextBoxUser.Location = new System.Drawing.Point(146, 28);
            this.TextBoxUser.MaxLength = 15;
            this.TextBoxUser.Name = "TextBoxUser";
            this.TextBoxUser.PlaceholderText = "Введите имя пользователя";
            this.TextBoxUser.Size = new System.Drawing.Size(270, 30);
            this.TextBoxUser.TabIndex = 0;
            this.TextBoxUser.TextChanged += new System.EventHandler(this.TextBoxUser_TextChanged);
            this.TextBoxUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxUser_KeyPress);
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUser.Location = new System.Drawing.Point(32, 28);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(74, 25);
            this.labelUser.TabIndex = 1;
            this.labelUser.Text = "Логин:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPassword.Location = new System.Drawing.Point(32, 75);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(86, 25);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Пароль:";
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TextBoxPassword.Location = new System.Drawing.Point(146, 72);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.PasswordChar = '*';
            this.TextBoxPassword.PlaceholderText = "Введите пароль";
            this.TextBoxPassword.Size = new System.Drawing.Size(270, 30);
            this.TextBoxPassword.TabIndex = 1;
            this.TextBoxPassword.TextChanged += new System.EventHandler(this.TextBoxPassword_TextChanged);
            this.TextBoxPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxPassword_KeyPress);
            // 
            // ButtonInputSystem
            // 
            this.ButtonInputSystem.Enabled = false;
            this.ButtonInputSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonInputSystem.Location = new System.Drawing.Point(32, 118);
            this.ButtonInputSystem.Name = "ButtonInputSystem";
            this.ButtonInputSystem.Size = new System.Drawing.Size(384, 63);
            this.ButtonInputSystem.TabIndex = 2;
            this.ButtonInputSystem.Text = "Войти";
            this.ButtonInputSystem.UseVisualStyleBackColor = true;
            this.ButtonInputSystem.Click += new System.EventHandler(this.ButtonInputSystem_Click);
            // 
            // LinkLabelAuthorization
            // 
            this.LinkLabelAuthorization.AutoSize = true;
            this.LinkLabelAuthorization.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LinkLabelAuthorization.Location = new System.Drawing.Point(127, 204);
            this.LinkLabelAuthorization.Name = "LinkLabelAuthorization";
            this.LinkLabelAuthorization.Size = new System.Drawing.Size(190, 25);
            this.LinkLabelAuthorization.TabIndex = 3;
            this.LinkLabelAuthorization.TabStop = true;
            this.LinkLabelAuthorization.Text = "Еще нет аккаунта?";
            this.LinkLabelAuthorization.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelAuthorization_LinkClicked);
            // 
            // ButtonSeeNotSeePassword
            // 
            this.ButtonSeeNotSeePassword.ImageIndex = 0;
            this.ButtonSeeNotSeePassword.ImageList = this.imageList1;
            this.ButtonSeeNotSeePassword.Location = new System.Drawing.Point(422, 72);
            this.ButtonSeeNotSeePassword.Name = "ButtonSeeNotSeePassword";
            this.ButtonSeeNotSeePassword.Size = new System.Drawing.Size(37, 30);
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
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(483, 254);
            this.Controls.Add(this.ButtonSeeNotSeePassword);
            this.Controls.Add(this.LinkLabelAuthorization);
            this.Controls.Add(this.ButtonInputSystem);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.TextBoxUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход в систему";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxUser;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.Button ButtonInputSystem;
        private System.Windows.Forms.LinkLabel LinkLabelAuthorization;
        private System.Windows.Forms.Button ButtonSeeNotSeePassword;
        private System.Windows.Forms.ImageList imageList1;
    }
}

