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
    public partial class FormAddEditDeleteQuestion : Form
    {
        private int questionId = 0;
        public string themesName = "";
        public FormAddEditDeleteQuestion()
        {
            InitializeComponent();
        }

        private void UpdateIdQuestion(int rowIndex)
        {
            this.AnswersTableAdapter.Adapter.Update(baseDataSetAnswers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "baseDataSet1.ANSWERS". При необходимости она может быть перемещена или удалена.
            this.AnswersTableAdapter.Fill(this.baseDataSetAnswers.ANSWERS);
            if (DataGridViewQuestion.Rows[rowIndex].Cells["DataGridViewquestionId"].Value?.ToString() == null)
                questionId = 0;
            else
                questionId = int.Parse(DataGridViewQuestion.Rows[rowIndex].Cells["DataGridViewquestionId"].Value.ToString());
            this.AnswersTableAdapter.Adapter.SelectCommand.CommandText = "SELECT AnswerID, AnswerText, CorrectAnswer FROM ANSWERS WHERE QuestionId = " + questionId;
            this.AnswersTableAdapter.Adapter.InsertCommand.CommandText = "INSERT INTO ANSWERS (QuestionId, AnswerText, CorrectAnswer) SELECT QuestionId, ?,? FROM QUESTION WHERE QuestionId = " + questionId;
            this.AnswersTableAdapter.Fill(this.baseDataSetAnswers.ANSWERS);
        }

        private void FormAddEditDeleteQuestion_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "baseDataSet.QUESTION". При необходимости она может быть перемещена или удалена.
            this.QuestionTableAdapter.Fill(this.baseDataSetQuestion.QUESTION);
            this.QuestionTableAdapter.Adapter.SelectCommand.CommandText = "SELECT q.QuestionId, q.ThemesId, q.Description FROM QUESTION q INNER JOIN Themes t ON q.ThemesId = t.ThemesId WHERE t.Name = '" + themesName + "'";
            this.QuestionTableAdapter.Adapter.InsertCommand.CommandText = "INSERT INTO `QUESTION` (`ThemesId`, `Description`) SELECT ThemesId, ? FROM THEMES WHERE Name = '" + themesName + "'";
            this.QuestionTableAdapter.Fill(this.baseDataSetQuestion.QUESTION);
            UpdateIdQuestion(0);
        }

        private void DataGridViewQuestion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateIdQuestion(DataGridViewQuestion.CurrentCell.RowIndex);
        }
        private void ButtonUpdateSynchronizeQuestion_Click(object sender, EventArgs e)
        {
            this.QuestionTableAdapter.Update(baseDataSetQuestion);
            this.QuestionTableAdapter.Fill(this.baseDataSetQuestion.QUESTION);
            UpdateIdQuestion(DataGridViewQuestion.CurrentCell.RowIndex);
        }

        private void DataGridViewQuestion_Sorted(object sender, EventArgs e)
        {
            UpdateIdQuestion(DataGridViewQuestion.CurrentCell.RowIndex);
        }
        private void DataGridViewQuestion_KeyUp(object sender, KeyEventArgs e)
        {
            UpdateIdQuestion(DataGridViewQuestion.CurrentCell.RowIndex);
        }

        private void ButtonUpdateSynchronizationAnswerQuestion_Click(object sender, EventArgs e)
        {
            this.AnswersTableAdapter.Adapter.Update(baseDataSetAnswers);
            this.AnswersTableAdapter.Fill(this.baseDataSetAnswers.ANSWERS);
        }


    }
}
