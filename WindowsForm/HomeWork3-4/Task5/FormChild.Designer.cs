
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
            this.buttonAddEmployee = new System.Windows.Forms.Button();
            this.textBoxPlaceBirth = new System.Windows.Forms.TextBox();
            this.labelPlaceBirth = new System.Windows.Forms.Label();
            this.dateTimePickerBirthDay = new System.Windows.Forms.DateTimePicker();
            this.labelBirthDay = new System.Windows.Forms.Label();
            this.labelMiddleName = new System.Windows.Forms.Label();
            this.textBoxMiddleName = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxSurName = new System.Windows.Forms.TextBox();
            this.labelSurName = new System.Windows.Forms.Label();
            this.buttonRemoveEmployee = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSaveOtherXMLFile = new System.Windows.Forms.Button();
            this.buttonLoadXMLFile = new System.Windows.Forms.Button();
            this.buttonSaveXMLFile = new System.Windows.Forms.Button();
            this.labelCurrentFilePath = new System.Windows.Forms.Label();
            this.textBoxCurrentFilePath = new System.Windows.Forms.TextBox();
            this.listBoxChildForms = new System.Windows.Forms.ListBox();
            this.buttonGetChildForms = new System.Windows.Forms.Button();
            this.buttonDataTransfer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).BeginInit();
            this.groupBoxEmployees.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewEmployees
            // 
            this.dataGridViewEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployees.Location = new System.Drawing.Point(12, 72);
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
            this.groupBoxEmployees.Location = new System.Drawing.Point(12, 312);
            this.groupBoxEmployees.Name = "groupBoxEmployees";
            this.groupBoxEmployees.Size = new System.Drawing.Size(278, 295);
            this.groupBoxEmployees.TabIndex = 5;
            this.groupBoxEmployees.TabStop = false;
            this.groupBoxEmployees.Text = "Данные сотрудника";
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
            // textBoxPlaceBirth
            // 
            this.textBoxPlaceBirth.Location = new System.Drawing.Point(116, 186);
            this.textBoxPlaceBirth.Name = "textBoxPlaceBirth";
            this.textBoxPlaceBirth.Size = new System.Drawing.Size(145, 20);
            this.textBoxPlaceBirth.TabIndex = 9;
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
            // dateTimePickerBirthDay
            // 
            this.dateTimePickerBirthDay.Location = new System.Drawing.Point(116, 141);
            this.dateTimePickerBirthDay.Name = "dateTimePickerBirthDay";
            this.dateTimePickerBirthDay.Size = new System.Drawing.Size(145, 20);
            this.dateTimePickerBirthDay.TabIndex = 7;
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
            // labelMiddleName
            // 
            this.labelMiddleName.AutoSize = true;
            this.labelMiddleName.Location = new System.Drawing.Point(6, 103);
            this.labelMiddleName.Name = "labelMiddleName";
            this.labelMiddleName.Size = new System.Drawing.Size(57, 13);
            this.labelMiddleName.TabIndex = 5;
            this.labelMiddleName.Text = "Отчество:";
            // 
            // textBoxMiddleName
            // 
            this.textBoxMiddleName.Location = new System.Drawing.Point(116, 100);
            this.textBoxMiddleName.Name = "textBoxMiddleName";
            this.textBoxMiddleName.Size = new System.Drawing.Size(145, 20);
            this.textBoxMiddleName.TabIndex = 4;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(116, 63);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(145, 20);
            this.textBoxName.TabIndex = 3;
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
            // textBoxSurName
            // 
            this.textBoxSurName.Location = new System.Drawing.Point(116, 27);
            this.textBoxSurName.Name = "textBoxSurName";
            this.textBoxSurName.Size = new System.Drawing.Size(145, 20);
            this.textBoxSurName.TabIndex = 1;
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
            // buttonRemoveEmployee
            // 
            this.buttonRemoveEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonRemoveEmployee.Location = new System.Drawing.Point(312, 549);
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
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(585, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Таблица сотрудников. Редактирование записей в колонке таблицы";
            // 
            // buttonSaveOtherXMLFile
            // 
            this.buttonSaveOtherXMLFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonSaveOtherXMLFile.Location = new System.Drawing.Point(312, 321);
            this.buttonSaveOtherXMLFile.Name = "buttonSaveOtherXMLFile";
            this.buttonSaveOtherXMLFile.Size = new System.Drawing.Size(229, 52);
            this.buttonSaveOtherXMLFile.TabIndex = 8;
            this.buttonSaveOtherXMLFile.Text = "Сохранить в другой XML-файл";
            this.buttonSaveOtherXMLFile.UseVisualStyleBackColor = true;
            this.buttonSaveOtherXMLFile.Click += new System.EventHandler(this.buttonSaveOtherXMLFile_Click);
            // 
            // buttonLoadXMLFile
            // 
            this.buttonLoadXMLFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonLoadXMLFile.Location = new System.Drawing.Point(312, 466);
            this.buttonLoadXMLFile.Name = "buttonLoadXMLFile";
            this.buttonLoadXMLFile.Size = new System.Drawing.Size(229, 52);
            this.buttonLoadXMLFile.TabIndex = 9;
            this.buttonLoadXMLFile.Text = "Загрузить из XML-файла";
            this.buttonLoadXMLFile.UseVisualStyleBackColor = true;
            this.buttonLoadXMLFile.Click += new System.EventHandler(this.buttonLoadXMLFile_Click);
            // 
            // buttonSaveXMLFile
            // 
            this.buttonSaveXMLFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonSaveXMLFile.Location = new System.Drawing.Point(312, 394);
            this.buttonSaveXMLFile.Name = "buttonSaveXMLFile";
            this.buttonSaveXMLFile.Size = new System.Drawing.Size(229, 52);
            this.buttonSaveXMLFile.TabIndex = 10;
            this.buttonSaveXMLFile.Text = "Сохранить текущий XML-файл";
            this.buttonSaveXMLFile.UseVisualStyleBackColor = true;
            this.buttonSaveXMLFile.Click += new System.EventHandler(this.buttonSaveXMLFile_Click);
            // 
            // labelCurrentFilePath
            // 
            this.labelCurrentFilePath.AutoSize = true;
            this.labelCurrentFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCurrentFilePath.Location = new System.Drawing.Point(16, 13);
            this.labelCurrentFilePath.Name = "labelCurrentFilePath";
            this.labelCurrentFilePath.Size = new System.Drawing.Size(126, 13);
            this.labelCurrentFilePath.TabIndex = 11;
            this.labelCurrentFilePath.Text = "Текущий XML-файл:";
            // 
            // textBoxCurrentFilePath
            // 
            this.textBoxCurrentFilePath.Location = new System.Drawing.Point(148, 10);
            this.textBoxCurrentFilePath.Name = "textBoxCurrentFilePath";
            this.textBoxCurrentFilePath.ReadOnly = true;
            this.textBoxCurrentFilePath.Size = new System.Drawing.Size(725, 20);
            this.textBoxCurrentFilePath.TabIndex = 12;
            // 
            // listBoxChildForms
            // 
            this.listBoxChildForms.FormattingEnabled = true;
            this.listBoxChildForms.HorizontalScrollbar = true;
            this.listBoxChildForms.Location = new System.Drawing.Point(568, 321);
            this.listBoxChildForms.Name = "listBoxChildForms";
            this.listBoxChildForms.ScrollAlwaysVisible = true;
            this.listBoxChildForms.Size = new System.Drawing.Size(305, 160);
            this.listBoxChildForms.TabIndex = 13;
            // 
            // buttonGetChildForms
            // 
            this.buttonGetChildForms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonGetChildForms.Location = new System.Drawing.Point(568, 487);
            this.buttonGetChildForms.Name = "buttonGetChildForms";
            this.buttonGetChildForms.Size = new System.Drawing.Size(305, 50);
            this.buttonGetChildForms.TabIndex = 14;
            this.buttonGetChildForms.Text = "Получить список дочерних форм";
            this.buttonGetChildForms.UseVisualStyleBackColor = true;
            this.buttonGetChildForms.Click += new System.EventHandler(this.buttonGetChildForms_Click);
            // 
            // buttonDataTransfer
            // 
            this.buttonDataTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonDataTransfer.Location = new System.Drawing.Point(568, 549);
            this.buttonDataTransfer.Name = "buttonDataTransfer";
            this.buttonDataTransfer.Size = new System.Drawing.Size(305, 49);
            this.buttonDataTransfer.TabIndex = 15;
            this.buttonDataTransfer.Text = "Передача данных в другую дочернуюю форму";
            this.buttonDataTransfer.UseVisualStyleBackColor = true;
            this.buttonDataTransfer.Click += new System.EventHandler(this.buttonDataTransfer_Click);
            // 
            // FormChild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1015, 629);
            this.Controls.Add(this.buttonDataTransfer);
            this.Controls.Add(this.buttonGetChildForms);
            this.Controls.Add(this.listBoxChildForms);
            this.Controls.Add(this.textBoxCurrentFilePath);
            this.Controls.Add(this.labelCurrentFilePath);
            this.Controls.Add(this.buttonSaveXMLFile);
            this.Controls.Add(this.buttonLoadXMLFile);
            this.Controls.Add(this.buttonSaveOtherXMLFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRemoveEmployee);
            this.Controls.Add(this.groupBoxEmployees);
            this.Controls.Add(this.dataGridViewEmployees);
            this.Name = "FormChild";
            this.Text = "MDI Child";
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
        private System.Windows.Forms.Button buttonSaveOtherXMLFile;
        private System.Windows.Forms.Button buttonLoadXMLFile;
        private System.Windows.Forms.Button buttonSaveXMLFile;
        private System.Windows.Forms.Label labelCurrentFilePath;
        private System.Windows.Forms.TextBox textBoxCurrentFilePath;
        private System.Windows.Forms.ListBox listBoxChildForms;
        private System.Windows.Forms.Button buttonGetChildForms;
        private System.Windows.Forms.Button buttonDataTransfer;
    }
}