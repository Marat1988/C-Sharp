using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

        }

        private void FormMain_Load(object sender, EventArgs e)
        {         
            ComboBoxChooseQuiz.Select();
            ComboBoxChooseQuiz.SelectedIndex = 0;
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(ButtonStart, "Старт выбранной викторины");
            toolTip1.SetToolTip(ButtonShowResult, "Просмотреть прошлые результаты по выбранной викторине");
            toolTip1.SetToolTip(ButtonShowTop20, "Посмотреть ТОП 20 лучших пользователей по выбранной викторине");
            toolTip1.SetToolTip(ButtonSettingUser, "Изменить настройки пользователя");
            toolTip1.SetToolTip(ButtonExit, "Выход из системы");
        }
        private void ButtonExit_Click(object sender, EventArgs e) => this.Close();

        private void ComboBoxChooseQuiz_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
