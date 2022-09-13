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
            
        }

        private void ButtonUserRegistration_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxLogin_TextChanged(object sender, EventArgs e)=>ButtonUserRegistration.Enabled = CheckEnableButton();
        private void TextBoxPassword_TextChanged(object sender, EventArgs e) => ButtonUserRegistration.Enabled = CheckEnableButton();
    }
}
