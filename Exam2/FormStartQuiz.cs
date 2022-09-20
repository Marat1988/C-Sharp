using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyDBHelper;

namespace WinFormsApp1
{
    public partial class FormStartQuiz : Form
    {
        public string themesName = "Смешанная";
        public int numberAnswer = 1; //Текущая позиция вопроса
        private List<RadioButton> rdbtn = new List<RadioButton>(); //Для загрузки ответов
        private DateTime DateTimeStartGame = DateTime.Now; //Начало игры
        private int CountCorrectQuestion = 0; //Количество правильных ответов (для записи в базу данных)
        private class QuestionGames
        {
            public int IdQuestion { get; set; } //id вопроса из базы данных
            public string Description { get; set; } //Описание вопроса
            public List<(string, bool)> OptionQuestion { get; set; }  //Варианты вопроса
            public List<string> PlayerAnswer { get; set; } //Ответы игрока
        }

        private List<QuestionGames> games = new List<QuestionGames>();
        private void LoadQuestion()
        {
            //Загружаю вопросы
            string strSQL = "SELECT TOP 20 q.QuestionId, q.Desctiption FROM THEMES t INNER JOIN QUESTION q ON t.ThemesId = q.ThemesId WHERE t.Name = '" + themesName + "' ORDER BY Rnd(-(100000*q.QuestionId)*Time())";
            using (OleDbConnection connection = new OleDbConnection(MyDataBase.connectionString))
            {
                OleDbCommand command = new OleDbCommand(strSQL, connection);
                try
                {
                    connection.Open();
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            games.Add(new QuestionGames { IdQuestion = Convert.ToInt32(reader["QuestionId"].ToString()), Description = reader["Desctiption"].ToString() });
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            //Загружаю правильные ответы
            for (int i = 0; i < games.Count; i++)
            {
                strSQL = "SELECT AnswerText, CorrectAnswer FROM ANSWERS WHERE QuestionId = " + games[i].IdQuestion;
                using (OleDbConnection connection = new OleDbConnection(MyDataBase.connectionString))
                {
                    OleDbCommand command = new OleDbCommand(strSQL, connection);
                    try
                    {
                        connection.Open();
                        using (OleDbDataReader reader = command.ExecuteReader())
                        {
                            games[i].OptionQuestion = new List<(string, bool)>();
                            while (reader.Read())
                            {         
                                games[i].OptionQuestion.Add((reader["AnswerText"].ToString(), Convert.ToBoolean(reader["CorrectAnswer"])));
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        private void AddOption(int numberAnswer)
        {
            int x2 = 10;
            int y2 = labelQuestion.Height + 20;
            labelQuestion.Text = games[numberAnswer - 1].Description;
            for (int j = 0; j < games[numberAnswer - 1].OptionQuestion.Count; j++)
            {
                rdbtn.Add(new RadioButton());
                rdbtn[j].AutoSize = true;
                rdbtn[j].Text = games[numberAnswer - 1].OptionQuestion[j].Item1;
                rdbtn[j].Location = new Point(x2, y2);
                this.Controls.Add(rdbtn[j]);
                y2 += 40;
            }
            ButtonNextQuestion.Location = new Point(x2, rdbtn[rdbtn.Count - 1].Top + rdbtn[rdbtn.Count - 1].Height + 10);
        }
        public FormStartQuiz()
        {
            InitializeComponent();
        }
        private void StartQuiz_Load(object sender, EventArgs e)
        {
            LoadQuestion();
            AddOption(numberAnswer);
            this.Text = $"Викторина. Вопрос {numberAnswer} из {games.Count}";
        }
        private void ButtonNextQuestion_Click(object sender, EventArgs e)
        {
            games[numberAnswer - 1].PlayerAnswer = new List<string>();
            foreach (var item in rdbtn)
            {
                if (item.Checked)
                    games[numberAnswer - 1].PlayerAnswer.Add(item.Text);
                this.Controls.Remove(item);
            }
            rdbtn.Clear();
            int rightAnswer = 0;
            //Проверка, правильно ли ответил пользователь на вопрос
            for (int i = 0; i < games[numberAnswer - 1].PlayerAnswer.Count; i++)
            {
                for (int j = 0; j < games[numberAnswer - 1].OptionQuestion.Count; j++)
                {
                    if ((games[numberAnswer - 1].PlayerAnswer[i] == games[numberAnswer - 1].OptionQuestion[j].Item1) && games[numberAnswer - 1].OptionQuestion[j].Item2 == true)
                        rightAnswer++;
                }
            }
            if (rightAnswer == games[numberAnswer - 1].PlayerAnswer.Count)
                CountCorrectQuestion++;
            numberAnswer++;
            if (numberAnswer > games.Count)
            {
                MessageBox.Show($"Тест окончен. Всего вопросов: {games.Count}.\nПравильных ответов: {CountCorrectQuestion}.\n Ну ты заходи если че!!", "Статистика", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();
            }
            else
            {
                AddOption(numberAnswer);
                this.Text = $"Викторина. Вопрос {numberAnswer} из {games.Count}";
           }
        }
    }
}
