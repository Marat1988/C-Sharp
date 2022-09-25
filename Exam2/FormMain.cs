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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {         
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(ButtonStart, "Старт выбранной викторины");
            toolTip1.SetToolTip(ButtonShowResult, "Просмотреть прошлые результаты по выбранной викторине");
            toolTip1.SetToolTip(ButtonShowTop20, "Посмотреть ТОП 20 лучших пользователей по выбранной викторине");
            toolTip1.SetToolTip(ButtonSettingUser, "Изменить настройки пользователя");
            toolTip1.SetToolTip(ButtonExit, "Выход из системы");
            toolTip1.SetToolTip(ButtonAddEditDeleteQuestion, "Добавить, изменить или удалить вопросы из баз данных");
            LabelHelloUser.Text = "Привет " + MyDataBase.login + ".\n" + "Добро пожаловать на игру \"Викторина\"";
            List<string> themes = new List<string>();
            MyDataBase.LoadThemes(ref themes);
            if (themes.Count > 0)
            {
                foreach (var item in themes)
                {
                    ComboBoxChooseQuiz.Items.Add(item);
                }
                ComboBoxChooseQuiz.Select();
                ComboBoxChooseQuiz.SelectedIndex = 0;
            }
            ButtonAddEditDeleteQuestion.Visible = MyDataBase.isAdmin;
        }
        private void ButtonExit_Click(object sender, EventArgs e) => this.Close();


        private void ButtonSettingUser_Click(object sender, EventArgs e)
        {
            FormSettingUser formSettingUser = new FormSettingUser();
            formSettingUser.ShowDialog();
        }

        private void ButtonShowResult_Click(object sender, EventArgs e)
        {
            MyDataBase.ResultThemesQuiz(ComboBoxChooseQuiz.Text, out int countRows, out string msg);
            MessageBox.Show(msg, "Результаты прошлых тестов");
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            FormStartQuiz formStartQuiz = new FormStartQuiz();
            formStartQuiz.Text = "Викторина. Вопрос 1 из 20";
            formStartQuiz.themesName = ComboBoxChooseQuiz.Text;
            formStartQuiz.ShowDialog();
        }

        private void ButtonShowTop20_Click(object sender, EventArgs e)
        {
            MyDataBase.ResultThemesQuizTOP20(ComboBoxChooseQuiz.Text, out int countRows, out string msg);
            MessageBox.Show(msg, $"TOP 20 по теме {ComboBoxChooseQuiz.Text}");
        }

        private void ButtonAddEditDeleteQuestion_Click(object sender, EventArgs e)
        {
            FormAddEditDeleteQuestion formAddEditDeleteQuestion = new FormAddEditDeleteQuestion();
            formAddEditDeleteQuestion.themesName = ComboBoxChooseQuiz.Text;
            formAddEditDeleteQuestion.Show();
        }
    }
}
