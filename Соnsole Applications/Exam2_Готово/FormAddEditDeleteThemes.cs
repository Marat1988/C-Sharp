using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormAddEditDeleteThemes : Form
    {
        public FormAddEditDeleteThemes()
        {
            InitializeComponent();
        }

        private void FormAddEditDeleteThemes_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "baseDataSetThemes.THEMES". При необходимости она может быть перемещена или удалена.
            this.ThemesTableAdapter.Fill(this.baseDataSetThemes.THEMES);
        }

        private void ButtonUpdateSynchronizationThemes_Click(object sender, EventArgs e)
        {
            try
            {
                this.ThemesTableAdapter.Adapter.Update(baseDataSetThemes);
                this.ThemesTableAdapter.Fill(this.baseDataSetThemes.THEMES);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
