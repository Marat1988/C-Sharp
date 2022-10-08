
namespace Task2
{
    partial class FormSearch
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
            this.ListBoxFiles = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.openFileDialogSearch = new System.Windows.Forms.OpenFileDialog();
            this.ComboBoxSearch = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ListBoxFiles
            // 
            this.ListBoxFiles.FormattingEnabled = true;
            this.ListBoxFiles.Location = new System.Drawing.Point(26, 12);
            this.ListBoxFiles.Name = "ListBoxFiles";
            this.ListBoxFiles.Size = new System.Drawing.Size(377, 199);
            this.ListBoxFiles.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(23, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите маску (например, *.exe)";
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Location = new System.Drawing.Point(323, 224);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(80, 20);
            this.ButtonSearch.TabIndex = 3;
            this.ButtonSearch.Text = "ПОИСК";
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // openFileDialogSearch
            // 
            this.openFileDialogSearch.FileName = "openFileDialog1";
            // 
            // ComboBoxSearch
            // 
            this.ComboBoxSearch.FormattingEnabled = true;
            this.ComboBoxSearch.Items.AddRange(new object[] {
            "*.txt",
            "*.exe",
            "*.doc",
            "*.docx",
            "*.xls",
            "*.xlsx",
            "*.pdf"});
            this.ComboBoxSearch.Location = new System.Drawing.Point(196, 224);
            this.ComboBoxSearch.Name = "ComboBoxSearch";
            this.ComboBoxSearch.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxSearch.TabIndex = 4;
            this.ComboBoxSearch.TextChanged += new System.EventHandler(this.ComboBoxSearch_TextChanged);
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 279);
            this.Controls.Add(this.ComboBoxSearch);
            this.Controls.Add(this.ButtonSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListBoxFiles);
            this.Name = "FormSearch";
            this.Text = "Форма поиска";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxFiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.OpenFileDialog openFileDialogSearch;
        private System.Windows.Forms.ComboBox ComboBoxSearch;
    }
}