﻿
namespace WinFormsApp1
{
    partial class FormAddEditDeleteQuestion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.DataGridViewQuestion = new System.Windows.Forms.DataGridView();
            this.groupBoxQuestion = new System.Windows.Forms.GroupBox();
            this.groupBoxAnswerQuestion = new System.Windows.Forms.GroupBox();
            this.dataGridViewAnswerQuestion = new System.Windows.Forms.DataGridView();
            this.ButtonUpdateSynchronizeQuestion = new System.Windows.Forms.Button();
            this.ButtonUpdateSynchronizationAnswerQuestion = new System.Windows.Forms.Button();
            this.answerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.answerTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correctAnswerDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.AnswersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baseDataSetAnswers = new WindowsFormsApp1.BaseDataSet1();
            this.DataGridViewquestionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumnQuestion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuestionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baseDataSetQuestion = new WindowsFormsApp1.BaseDataSet();
            this.QuestionTableAdapter = new WindowsFormsApp1.BaseDataSetTableAdapters.QUESTIONTableAdapter();
            this.AnswersTableAdapter = new WindowsFormsApp1.BaseDataSet1TableAdapters.ANSWERSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewQuestion)).BeginInit();
            this.groupBoxQuestion.SuspendLayout();
            this.groupBoxAnswerQuestion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnswerQuestion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnswersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDataSetAnswers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuestionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDataSetQuestion)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewQuestion
            // 
            this.DataGridViewQuestion.AutoGenerateColumns = false;
            this.DataGridViewQuestion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataGridViewQuestion.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridViewQuestion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewQuestion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewquestionId,
            this.DataGridViewTextBoxColumnQuestion});
            this.DataGridViewQuestion.DataSource = this.QuestionBindingSource;
            this.DataGridViewQuestion.Location = new System.Drawing.Point(0, 31);
            this.DataGridViewQuestion.Margin = new System.Windows.Forms.Padding(4);
            this.DataGridViewQuestion.MultiSelect = false;
            this.DataGridViewQuestion.Name = "DataGridViewQuestion";
            this.DataGridViewQuestion.RowHeadersWidth = 51;
            this.DataGridViewQuestion.Size = new System.Drawing.Size(1379, 666);
            this.DataGridViewQuestion.TabIndex = 0;
            this.DataGridViewQuestion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewQuestion_CellClick);
            this.DataGridViewQuestion.Sorted += new System.EventHandler(this.DataGridViewQuestion_Sorted);
            this.DataGridViewQuestion.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DataGridViewQuestion_KeyUp);
            // 
            // groupBoxQuestion
            // 
            this.groupBoxQuestion.Controls.Add(this.DataGridViewQuestion);
            this.groupBoxQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxQuestion.Location = new System.Drawing.Point(16, 15);
            this.groupBoxQuestion.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxQuestion.Name = "groupBoxQuestion";
            this.groupBoxQuestion.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxQuestion.Size = new System.Drawing.Size(1395, 703);
            this.groupBoxQuestion.TabIndex = 3;
            this.groupBoxQuestion.TabStop = false;
            this.groupBoxQuestion.Text = "Список вопросов";
            // 
            // groupBoxAnswerQuestion
            // 
            this.groupBoxAnswerQuestion.Controls.Add(this.dataGridViewAnswerQuestion);
            this.groupBoxAnswerQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxAnswerQuestion.Location = new System.Drawing.Point(1431, 15);
            this.groupBoxAnswerQuestion.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxAnswerQuestion.Name = "groupBoxAnswerQuestion";
            this.groupBoxAnswerQuestion.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxAnswerQuestion.Size = new System.Drawing.Size(431, 404);
            this.groupBoxAnswerQuestion.TabIndex = 4;
            this.groupBoxAnswerQuestion.TabStop = false;
            this.groupBoxAnswerQuestion.Text = "Ответ на вопрос";
            // 
            // dataGridViewAnswerQuestion
            // 
            this.dataGridViewAnswerQuestion.AutoGenerateColumns = false;
            this.dataGridViewAnswerQuestion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewAnswerQuestion.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewAnswerQuestion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAnswerQuestion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.answerIDDataGridViewTextBoxColumn,
            this.answerTextDataGridViewTextBoxColumn,
            this.correctAnswerDataGridViewCheckBoxColumn});
            this.dataGridViewAnswerQuestion.DataSource = this.AnswersBindingSource;
            this.dataGridViewAnswerQuestion.Location = new System.Drawing.Point(8, 31);
            this.dataGridViewAnswerQuestion.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewAnswerQuestion.MultiSelect = false;
            this.dataGridViewAnswerQuestion.Name = "dataGridViewAnswerQuestion";
            this.dataGridViewAnswerQuestion.RowHeadersWidth = 51;
            this.dataGridViewAnswerQuestion.Size = new System.Drawing.Size(420, 366);
            this.dataGridViewAnswerQuestion.TabIndex = 0;
            // 
            // ButtonUpdateSynchronizeQuestion
            // 
            this.ButtonUpdateSynchronizeQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonUpdateSynchronizeQuestion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonUpdateSynchronizeQuestion.Location = new System.Drawing.Point(16, 725);
            this.ButtonUpdateSynchronizeQuestion.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonUpdateSynchronizeQuestion.Name = "ButtonUpdateSynchronizeQuestion";
            this.ButtonUpdateSynchronizeQuestion.Size = new System.Drawing.Size(388, 75);
            this.ButtonUpdateSynchronizeQuestion.TabIndex = 5;
            this.ButtonUpdateSynchronizeQuestion.Text = "Обновить вопросы и синхронизировать с базой данных";
            this.ButtonUpdateSynchronizeQuestion.UseVisualStyleBackColor = true;
            this.ButtonUpdateSynchronizeQuestion.Click += new System.EventHandler(this.ButtonUpdateSynchronizeQuestion_Click);
            // 
            // ButtonUpdateSynchronizationAnswerQuestion
            // 
            this.ButtonUpdateSynchronizationAnswerQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonUpdateSynchronizationAnswerQuestion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonUpdateSynchronizationAnswerQuestion.Location = new System.Drawing.Point(1431, 438);
            this.ButtonUpdateSynchronizationAnswerQuestion.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonUpdateSynchronizationAnswerQuestion.Name = "ButtonUpdateSynchronizationAnswerQuestion";
            this.ButtonUpdateSynchronizationAnswerQuestion.Size = new System.Drawing.Size(388, 75);
            this.ButtonUpdateSynchronizationAnswerQuestion.TabIndex = 6;
            this.ButtonUpdateSynchronizationAnswerQuestion.Text = "Обновить ответы на вопросы и синхронизировать с базой данных";
            this.ButtonUpdateSynchronizationAnswerQuestion.UseVisualStyleBackColor = true;
            this.ButtonUpdateSynchronizationAnswerQuestion.Click += new System.EventHandler(this.ButtonUpdateSynchronizationAnswerQuestion_Click);
            // 
            // answerIDDataGridViewTextBoxColumn
            // 
            this.answerIDDataGridViewTextBoxColumn.DataPropertyName = "AnswerID";
            this.answerIDDataGridViewTextBoxColumn.HeaderText = "AnswerID";
            this.answerIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.answerIDDataGridViewTextBoxColumn.Name = "answerIDDataGridViewTextBoxColumn";
            this.answerIDDataGridViewTextBoxColumn.Visible = false;
            this.answerIDDataGridViewTextBoxColumn.Width = 96;
            // 
            // answerTextDataGridViewTextBoxColumn
            // 
            this.answerTextDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.answerTextDataGridViewTextBoxColumn.DataPropertyName = "AnswerText";
            this.answerTextDataGridViewTextBoxColumn.HeaderText = "Ответ";
            this.answerTextDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.answerTextDataGridViewTextBoxColumn.Name = "answerTextDataGridViewTextBoxColumn";
            this.answerTextDataGridViewTextBoxColumn.Width = 101;
            // 
            // correctAnswerDataGridViewCheckBoxColumn
            // 
            this.correctAnswerDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.correctAnswerDataGridViewCheckBoxColumn.DataPropertyName = "CorrectAnswer";
            this.correctAnswerDataGridViewCheckBoxColumn.HeaderText = "Верно/Не верно";
            this.correctAnswerDataGridViewCheckBoxColumn.MinimumWidth = 150;
            this.correctAnswerDataGridViewCheckBoxColumn.Name = "correctAnswerDataGridViewCheckBoxColumn";
            this.correctAnswerDataGridViewCheckBoxColumn.Width = 150;
            // 
            // AnswersBindingSource
            // 
            this.AnswersBindingSource.DataMember = "ANSWERS";
            this.AnswersBindingSource.DataSource = this.baseDataSetAnswers;
            // 
            // baseDataSetAnswers
            // 
            this.baseDataSetAnswers.DataSetName = "BaseDataSetAnswers";
            this.baseDataSetAnswers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataGridViewquestionId
            // 
            this.DataGridViewquestionId.DataPropertyName = "QuestionId";
            this.DataGridViewquestionId.HeaderText = "QuestionId";
            this.DataGridViewquestionId.MinimumWidth = 6;
            this.DataGridViewquestionId.Name = "DataGridViewquestionId";
            this.DataGridViewquestionId.Visible = false;
            this.DataGridViewquestionId.Width = 105;
            // 
            // DataGridViewTextBoxColumnQuestion
            // 
            this.DataGridViewTextBoxColumnQuestion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DataGridViewTextBoxColumnQuestion.DataPropertyName = "Description";
            this.DataGridViewTextBoxColumnQuestion.HeaderText = "Вопрос";
            this.DataGridViewTextBoxColumnQuestion.MinimumWidth = 6;
            this.DataGridViewTextBoxColumnQuestion.Name = "DataGridViewTextBoxColumnQuestion";
            this.DataGridViewTextBoxColumnQuestion.Width = 107;
            // 
            // QuestionBindingSource
            // 
            this.QuestionBindingSource.DataMember = "QUESTION";
            this.QuestionBindingSource.DataSource = this.baseDataSetQuestion;
            // 
            // baseDataSetQuestion
            // 
            this.baseDataSetQuestion.DataSetName = "BaseDataSetQuestion";
            this.baseDataSetQuestion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // QuestionTableAdapter
            // 
            this.QuestionTableAdapter.ClearBeforeFill = true;
            // 
            // AnswersTableAdapter
            // 
            this.AnswersTableAdapter.ClearBeforeFill = true;
            // 
            // FormAddEditDeleteQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(2342, 795);
            this.Controls.Add(this.ButtonUpdateSynchronizationAnswerQuestion);
            this.Controls.Add(this.ButtonUpdateSynchronizeQuestion);
            this.Controls.Add(this.groupBoxAnswerQuestion);
            this.Controls.Add(this.groupBoxQuestion);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormAddEditDeleteQuestion";
            this.Text = "Добавить, изменить или удалить вопросы из БД";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormAddEditDeleteQuestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewQuestion)).EndInit();
            this.groupBoxQuestion.ResumeLayout(false);
            this.groupBoxAnswerQuestion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnswerQuestion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnswersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDataSetAnswers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuestionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDataSetQuestion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewQuestion;
        private WindowsFormsApp1.BaseDataSet baseDataSetQuestion;
        private System.Windows.Forms.BindingSource QuestionBindingSource;
        private WindowsFormsApp1.BaseDataSetTableAdapters.QUESTIONTableAdapter QuestionTableAdapter;
        private System.Windows.Forms.GroupBox groupBoxQuestion;
        private System.Windows.Forms.GroupBox groupBoxAnswerQuestion;
        private System.Windows.Forms.DataGridView dataGridViewAnswerQuestion;
        private WindowsFormsApp1.BaseDataSet1 baseDataSetAnswers;
        private System.Windows.Forms.BindingSource AnswersBindingSource;
        private WindowsFormsApp1.BaseDataSet1TableAdapters.ANSWERSTableAdapter AnswersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn answerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn answerTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn correctAnswerDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button ButtonUpdateSynchronizeQuestion;
        private System.Windows.Forms.Button ButtonUpdateSynchronizationAnswerQuestion;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewquestionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumnQuestion;
    }
}