using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private bool CheckEnableButton() => TextBoxUser.TextLength > 0 && TextBoxPassword.TextLength > 0;

        private void ButtonInputSystem_Click(object sender, EventArgs e)
        {

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
        }

        private void TextBoxUser_TextChanged(object sender, EventArgs e) => ButtonInputSystem.Enabled = CheckEnableButton();
        private void TextBoxPassword_TextChanged(object sender, EventArgs e) => ButtonInputSystem.Enabled = CheckEnableButton();
    
    }
}
