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
    public partial class FormStartQuiz : Form
    {
        List<RadioButton> rdbtn = new List<RadioButton>();


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

        public FormStartQuiz()
        {
            InitializeComponent();
        }

        private void StartQuiz_Load(object sender, EventArgs e)
        {
            AddOption();
        }

        private void ButtonNextQuestion_Click(object sender, EventArgs e)
        {
        }
    }
}
