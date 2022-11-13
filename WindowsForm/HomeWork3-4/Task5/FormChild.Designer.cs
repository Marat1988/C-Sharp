
namespace Task5
{
    partial class FormChild
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
            this.dataGridViewEmployees = new System.Windows.Forms.DataGridView();
            this.groupBoxEmployees = new System.Windows.Forms.GroupBox();
            this.labelSurName = new System.Windows.Forms.Label();
            this.textBoxSurName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxMiddleName = new System.Windows.Forms.TextBox();
            this.labelMiddleName = new System.Windows.Forms.Label();
            this.labelBirthDay = new System.Windows.Forms.Label();
            this.dateTimePickerBirthDay = new System.Windows.Forms.DateTimePicker();
            this.labelPlaceBirth = new System.Windows.Forms.Label();
            this.textBoxPlaceBirth = new System.Windows.Forms.TextBox();
            this.buttonAddEmployee = new System.Windows.Forms.Button();
            this.buttonRemoveEmployee = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSaveXMLFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).BeginInit();
            this.groupBoxEmployees.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewEmployees
            // 
            this.dataGridViewEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployees.Location = new System.Drawing.Point(12, 45);
            this.dataGridViewEmployees.MultiSelect = false;
            this.dataGridViewEmployees.Name = "dataGridViewEmployees";
            this.dataGridViewEmployees.Size = new System.Drawing.Size(861, 223);
            this.dataGridViewEmployees.TabIndex = 2;
            // 
            // groupBoxEmployees
            // 
            this.groupBoxEmployees.Controls.Add(this.buttonAddEmployee);
            this.groupBoxEmployees.Controls.Add(this.textBoxPlaceBirth);
            this.groupBoxEmployees.Controls.Add(this.labelPlaceBirth);
            this.groupBoxEmployees.Controls.Add(this.dateTimePickerBirthDay);
            this.groupBoxEmployees.Controls.Add(this.labelBirthDay);
            this.groupBoxEmployees.Controls.Add(this.labelMiddleName);
            this.groupBoxEmployees.Controls.Add(this.textBoxMiddleName);
            this.groupBoxEmployees.Controls.Add(this.textBoxName);
            this.groupBoxEmployees.Controls.Add(this.labelName);
            this.groupBoxEmployees.Controls.Add(this.textBoxSurName);
            this.groupBoxEmployees.Controls.Add(this.labelSurName);
            this.groupBoxEmployees.Location = new System.Drawing.Point(12, 285);
            this.groupBoxEmployees.Name = "groupBoxEmployees";
            this.groupBoxEmployees.Size = new System.Drawing.Size(278, 295);
            this.groupBoxEmployees.TabIndex = 5;
            this.groupBoxEmployees.TabStop = false;
            this.groupBoxEmployees.Text = "Данные сотрудника";
            // 
            // labelSurName
            // 
            this.labelSurName.AutoSize = true;
            this.labelSurName.Location = new System.Drawing.Point(6, 30);
            this.labelSurName.Name = "labelSurName";
            this.labelSurName.Size = new System.Drawing.Size(59, 13);
            this.labelSurName.TabIndex = 0;
            this.labelSurName.Text = "Фамилия:";
            // 
            // textBoxSurName
            // 
            this.textBoxSurName.Location = new System.Drawing.Point(116, 27);
            this.textBoxSurName.Name = "textBoxSurName";
            this.textBoxSurName.Size = new System.Drawing.Size(145, 20);
            this.textBoxSurName.TabIndex = 1;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(6, 66);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(32, 13);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Имя:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(116, 63);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(145, 20);
            this.textBoxName.TabIndex = 3;
            // 
            // textBoxMiddleName
            // 
            this.textBoxMiddleName.Location = new System.Drawing.Point(116, 100);
            this.textBoxMiddleName.Name = "textBoxMiddleName";
            this.textBoxMiddleName.Size = new System.Drawing.Size(145, 20);
            this.textBoxMiddleName.TabIndex = 4;
            // 
            // labelMiddleName
            // 
            this.labelMiddleName.AutoSize = true;
            this.labelMiddleName.Location = new System.Drawing.Point(6, 103);
            this.labelMiddleName.Name = "labelMiddleName";
            this.labelMiddleName.Size = new System.Drawing.Size(57, 13);
            this.labelMiddleName.TabIndex = 5;
            this.labelMiddleName.Text = "Отчество:";
            // 
            // labelBirthDay
            // 
            this.labelBirthDay.AutoSize = true;
            this.labelBirthDay.Location = new System.Drawing.Point(6, 141);
            this.labelBirthDay.Name = "labelBirthDay";
            this.labelBirthDay.Size = new System.Drawing.Size(89, 13);
            this.labelBirthDay.TabIndex = 6;
            this.labelBirthDay.Text = "Дата рождения:";
            // 
            // dateTimePickerBirthDay
            // 
            this.dateTimePickerBirthDay.Location = new System.Drawing.Point(116, 141);
            this.dateTimePickerBirthDay.Name = "dateTimePickerBirthDay";
            this.dateTimePickerBirthDay.Size = new System.Drawing.Size(145, 20);
            this.dateTimePickerBirthDay.TabIndex = 7;
            // 
            // labelPlaceBirth
            // 
            this.labelPlaceBirth.AutoSize = true;
            this.labelPlaceBirth.Location = new System.Drawing.Point(8, 186);
            this.labelPlaceBirth.Name = "labelPlaceBirth";
            this.labelPlaceBirth.Size = new System.Drawing.Size(95, 13);
            this.labelPlaceBirth.TabIndex = 8;
            this.labelPlaceBirth.Text = "Место рождения:";
            // 
            // textBoxPlaceBirth
            // 
            this.textBoxPlaceBirth.Location = new System.Drawing.Point(116, 186);
            this.textBoxPlaceBirth.Name = "textBoxPlaceBirth";
            this.textBoxPlaceBirth.Size = new System.Drawing.Size(145, 20);
            this.textBoxPlaceBirth.TabIndex = 9;
            // 
            // buttonAddEmployee
            // 
            this.buttonAddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddEmployee.Location = new System.Drawing.Point(11, 223);
            this.buttonAddEmployee.Name = "buttonAddEmployee";
            this.buttonAddEmployee.Size = new System.Drawing.Size(250, 66);
            this.buttonAddEmployee.TabIndex = 10;
            this.buttonAddEmployee.Text = "Добавить сотрудника";
            this.buttonAddEmployee.UseVisualStyleBackColor = true;
            this.buttonAddEmployee.Click += new System.EventHandler(this.buttonAddEmployee_Click);
            // 
            // buttonRemoveEmployee
            // 
            this.buttonRemoveEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonRemoveEmployee.Location = new System.Drawing.Point(308, 294);
            this.buttonRemoveEmployee.Name = "buttonRemoveEmployee";
            this.buttonRemoveEmployee.Size = new System.Drawing.Size(229, 52);
            this.buttonRemoveEmployee.TabIndex = 6;
            this.buttonRemoveEmployee.Text = "Удалить сотрудника";
            this.buttonRemoveEmployee.UseVisualStyleBackColor = true;
            this.buttonRemoveEmployee.Click += new System.EventHandler(this.buttonRemoveEmployee_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(585, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Таблица сотрудников. Редактирование записей в колонке таблицы";
            // 
            // buttonSaveXMLFile
            // 
            this.buttonSaveXMLFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonSaveXMLFile.Location = new System.Drawing.Point(592, 294);
            this.buttonSaveXMLFile.Name = "buttonSaveXMLFile";
            this.buttonSaveXMLFile.Size = new System.Drawing.Size(229, 52);
            this.buttonSaveXMLFile.TabIndex = 8;
            this.buttonSaveXMLFile.Text = "Сохранить в XML-файл";
            this.buttonSaveXMLFile.UseVisualStyleBackColor = true;
            this.buttonSaveXMLFile.Click += new System.EventHandler(this.buttonSaveXMLFile_Click);
            // 
            // FormChild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 602);
            this.Controls.Add(this.buttonSaveXMLFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRemoveEmployee);
            this.Controls.Add(this.groupBoxEmployees);
            this.Controls.Add(this.dataGridViewEmployees);
            this.Name = "FormChild";
            this.Text = "MDI Child";
            this.Load += new System.EventHandler(this.FormChild_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).EndInit();
            this.groupBoxEmployees.ResumeLayout(false);
            this.groupBoxEmployees.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewEmployees;
        private System.Windows.Forms.GroupBox groupBoxEmployees;
        private System.Windows.Forms.TextBox textBoxSurName;
        private System.Windows.Forms.Label labelSurName;
        private System.Windows.Forms.Label labelMiddleName;
        private System.Windows.Forms.TextBox textBoxMiddleName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelBirthDay;
        private System.Windows.Forms.Label labelPlaceBirth;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthDay;
        private System.Windows.Forms.TextBox textBoxPlaceBirth;
        private System.Windows.Forms.Button buttonAddEmployee;
        private System.Windows.Forms.Button buttonRemoveEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSaveXMLFile;
    }
}