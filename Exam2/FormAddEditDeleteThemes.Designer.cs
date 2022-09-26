
namespace WindowsFormsApp1
{
    partial class FormAddEditDeleteThemes
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
            this.dataGridViewThemes = new System.Windows.Forms.DataGridView();
            this.baseDataSetThemes = new WindowsFormsApp1.BaseDataSetThemes();
            this.ThemesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ThemesTableAdapter = new WindowsFormsApp1.BaseDataSetThemesTableAdapters.THEMESTableAdapter();
            this.ButtonUpdateSynchronizationThemes = new System.Windows.Forms.Button();
            this.themesIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThemes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDataSetThemes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThemesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewThemes
            // 
            this.dataGridViewThemes.AutoGenerateColumns = false;
            this.dataGridViewThemes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewThemes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewThemes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewThemes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.themesIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridViewThemes.DataSource = this.ThemesBindingSource;
            this.dataGridViewThemes.Location = new System.Drawing.Point(18, 19);
            this.dataGridViewThemes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewThemes.MultiSelect = false;
            this.dataGridViewThemes.Name = "dataGridViewThemes";
            this.dataGridViewThemes.RowHeadersWidth = 51;
            this.dataGridViewThemes.RowTemplate.Height = 24;
            this.dataGridViewThemes.Size = new System.Drawing.Size(425, 288);
            this.dataGridViewThemes.TabIndex = 0;
            // 
            // baseDataSetThemes
            // 
            this.baseDataSetThemes.DataSetName = "BaseDataSetThemes";
            this.baseDataSetThemes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ThemesBindingSource
            // 
            this.ThemesBindingSource.DataMember = "THEMES";
            this.ThemesBindingSource.DataSource = this.baseDataSetThemes;
            // 
            // ThemesTableAdapter
            // 
            this.ThemesTableAdapter.ClearBeforeFill = true;
            // 
            // ButtonUpdateSynchronizationThemes
            // 
            this.ButtonUpdateSynchronizationThemes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonUpdateSynchronizationThemes.Location = new System.Drawing.Point(18, 317);
            this.ButtonUpdateSynchronizationThemes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonUpdateSynchronizationThemes.Name = "ButtonUpdateSynchronizationThemes";
            this.ButtonUpdateSynchronizationThemes.Size = new System.Drawing.Size(425, 102);
            this.ButtonUpdateSynchronizationThemes.TabIndex = 1;
            this.ButtonUpdateSynchronizationThemes.Text = "Обновить и синхронизировать темы с базой данных";
            this.ButtonUpdateSynchronizationThemes.UseVisualStyleBackColor = true;
            this.ButtonUpdateSynchronizationThemes.Click += new System.EventHandler(this.ButtonUpdateSynchronizationThemes_Click);
            // 
            // themesIdDataGridViewTextBoxColumn
            // 
            this.themesIdDataGridViewTextBoxColumn.DataPropertyName = "ThemesId";
            this.themesIdDataGridViewTextBoxColumn.HeaderText = "ThemesId";
            this.themesIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.themesIdDataGridViewTextBoxColumn.Name = "themesIdDataGridViewTextBoxColumn";
            this.themesIdDataGridViewTextBoxColumn.Width = 129;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Тема";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 91;
            // 
            // FormAddEditDeleteThemes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1209, 736);
            this.Controls.Add(this.ButtonUpdateSynchronizationThemes);
            this.Controls.Add(this.dataGridViewThemes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormAddEditDeleteThemes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить, изменить, удалить тему";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormAddEditDeleteThemes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThemes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDataSetThemes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThemesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewThemes;
        private BaseDataSetThemes baseDataSetThemes;
        private System.Windows.Forms.BindingSource ThemesBindingSource;
        private BaseDataSetThemesTableAdapters.THEMESTableAdapter ThemesTableAdapter;
        private System.Windows.Forms.Button ButtonUpdateSynchronizationThemes;
        private System.Windows.Forms.DataGridViewTextBoxColumn themesIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}