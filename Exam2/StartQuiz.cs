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
        private List<RadioButton> rdbtn = new List<RadioButton>(); //Для загрузки ответов
        private class QuestionGames
        {
            public int IdQuestion { get; set; }
            public string Description { get; set; }
            public List<(string, bool)> OptionQuestion { get; set; }
        }
        private List<QuestionGames> games = new List<QuestionGames>();
        private void AddOption()
        {
            int x2 = 10;
            int y2 = labelQuestion.Height + 20;
            for (int j = 0; j < 5; j++)
            {
                rdbtn.Add(new RadioButton());
                rdbtn[j].AutoSize = true;
                rdbtn[j].Text = "Вариант круглой кнопки" + j;
                rdbtn[j].Location = new Point(x2, y2);
                this.Controls.Add(rdbtn[j]);
                y2 += 40;
            }
            ButtonNextQuestion.Location = new Point(x2, rdbtn[rdbtn.Count - 1].Top - 5);
        }
        private void LoadQuestion()
        {
            //Загружаю вопросы
            string strSQL = "SELECT q.QuestionId, q.Desctiption FROM THEMES t INNER JOIN QUESTION q ON t.ThemesId = q.ThemesId WHERE t.Name = '" + themesName + "'";
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

        public FormStartQuiz()
        {
            InitializeComponent();
        }

        private void StartQuiz_Load(object sender, EventArgs e)
        {
            LoadQuestion();
        }

        private void ButtonNextQuestion_Click(object sender, EventArgs e)
        {
           
        }
    }
}
