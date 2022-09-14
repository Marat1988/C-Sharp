using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FormSettingUser : Form
    {
        public FormSettingUser()
        {
            InitializeComponent();
        }
        private bool CheckEnableButton() => (TextBoxPassword.TextLength > 0);

        private void ButtonSeeNotSeePassword_Click(object sender, EventArgs e)
        {
            ButtonSeeNotSeePassword.ImageIndex = (ButtonSeeNotSeePassword.ImageIndex == 0) ? 1 : 0;
            TextBoxPassword.PasswordChar = (ButtonSeeNotSeePassword.ImageIndex == 1) ? '\0' : '*';
        }

        private void TextBoxPassword_TextChanged(object sender, EventArgs e) => ButtonSaveSettings.Enabled = CheckEnableButton();

        private void TextBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') ||
                         (e.KeyChar >= 'a' && e.KeyChar <= 'z') ||
                         (e.KeyChar >= '0' && e.KeyChar <= '9') ||
                         e.KeyChar == '!' || e.KeyChar == '.' ||
                         e.KeyChar == ',' || e.KeyChar == (char)Keys.Back) ? false : true;
        }
        private void FormSettingUser_Load(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(ButtonSaveSettings, "Соханение настроек пользователя");
            toolTip1.SetToolTip(ButtonSeeNotSeePassword, "Всевидящее око");
        }
        private void ButtonSaveSettings_Click(object sender, EventArgs e)
        {
            if (Setting.CheckPassword(TextBoxPassword.Text, out string messagePassword) == false)
            {
                MessageBox.Show(messagePassword, "Ошибка в пароле", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
