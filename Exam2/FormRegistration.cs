using MyDBHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FormRegistration : Form
    {
        public FormRegistration()
        {
            InitializeComponent();
        }
        private bool CheckEnableButton() => TextBoxLogin.TextLength > 0 && TextBoxPassword.TextLength > 0;
        private void FormRegistration_Load(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(ButtonUserRegistration, "Регистрация в системе");
            toolTip1.SetToolTip(ButtonSeeNotSeePassword, "Всевидящее око");
            toolTip1.SetToolTip(TextBoxLogin, "Введите логин");
            toolTip1.SetToolTip(TextBoxPassword, "Введите пароль");
        }
        private void ButtonUserRegistration_Click(object sender, EventArgs e)
        {
            if (Setting.CheckLogin(TextBoxLogin.Text, out string messageLogin) == false) 
            {
                MessageBox.Show(messageLogin, "Ошибка в логине", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (Setting.CheckPassword(TextBoxPassword.Text, out string message) == false)
                {
                    MessageBox.Show(message, "Ошибка в пароле", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (MyDataBase.CheckLogin(TextBoxLogin.Text) == true)
                    {
                        MessageBox.Show("Такой логин уже существует", "Логин занят", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MyDataBase.InsertUser(TextBoxLogin.Text, TextBoxPassword.Text, dateTimePickerBirthday.Value.Date);
                        this.Close();
                    }
                }
            }
        }
        private void TextBoxLogin_TextChanged(object sender, EventArgs e)=>ButtonUserRegistration.Enabled = CheckEnableButton();
        private void TextBoxPassword_TextChanged(object sender, EventArgs e) => ButtonUserRegistration.Enabled = CheckEnableButton();
        private void ButtonSeeNotSeePassword_Click(object sender, EventArgs e)
        {
            ButtonSeeNotSeePassword.ImageIndex = (ButtonSeeNotSeePassword.ImageIndex == 0) ? 1 : 0;
            TextBoxPassword.PasswordChar = (ButtonSeeNotSeePassword.ImageIndex == 1) ? '\0' : '*';
        }
        private void TextBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') ||
                         (e.KeyChar >= 'a' && e.KeyChar <= 'z') ||
                         (e.KeyChar >= '0' && e.KeyChar <= '9') ||
                         e.KeyChar == '!' || e.KeyChar == '.' ||
                         e.KeyChar == ',' || e.KeyChar == (char)Keys.Back) ? false : true;
        }
        private void TextBoxLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') ||
                         (e.KeyChar >= 'a' && e.KeyChar <= 'z') ||
                         (e.KeyChar >= '0' && e.KeyChar <= '9') ||
                         e.KeyChar == (char)Keys.Back) ? false : true;
        }
    }
}
