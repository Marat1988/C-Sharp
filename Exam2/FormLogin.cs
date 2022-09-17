using System;
using System.Data.OleDb;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyDBHelper;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        private bool CheckEnableButton() => TextBoxUser.TextLength > 0 && TextBoxPassword.TextLength > 0;
        private void ButtonInputSystem_Click(object sender, EventArgs e)
        {
            if (Setting.CheckLogin(TextBoxUser.Text, out string messageLogin) == false)
            {
                MessageBox.Show(messageLogin, "Ошибка в логине", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (Setting.CheckPassword(TextBoxPassword.Text, out string messagePassword) == false)
                {
                    MessageBox.Show(messagePassword, "Ошибка в пароле", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (MyDataBase.CheckLogin(TextBoxUser.Text, TextBoxPassword.Text) == false)
                        MessageBox.Show("Не корректный ввод логина или пароля", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        MyDataBase.Login = TextBoxUser.Text;
                        this.Hide();
                        FormMain formMain = new FormMain();
                        formMain.Closed += (s, args) => this.Close();
                        formMain.Show();
                    }
                }
            }
        }
        private void LinkLabelAuthorization_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegistration formRegistration = new FormRegistration();
            formRegistration.ShowDialog();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(ButtonInputSystem, "Вход в систему");
            toolTip1.SetToolTip(ButtonSeeNotSeePassword, "Всевидящее око");
            toolTip1.SetToolTip(TextBoxUser, "Введите имя пользователя");
            toolTip1.SetToolTip(TextBoxPassword, "Введите пароль");
        }
        private void TextBoxUser_TextChanged(object sender, EventArgs e) => ButtonInputSystem.Enabled = CheckEnableButton();
        private void TextBoxPassword_TextChanged(object sender, EventArgs e) => ButtonInputSystem.Enabled = CheckEnableButton();

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
        private void TextBoxUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') ||
             (e.KeyChar >= 'a' && e.KeyChar <= 'z') ||
             (e.KeyChar >= '0' && e.KeyChar <= '9') ||
             e.KeyChar == (char)Keys.Back) ? false : true;
        }
    }
}
