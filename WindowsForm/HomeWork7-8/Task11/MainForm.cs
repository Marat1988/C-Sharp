using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task11
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void textBoxDays_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)Keys.Back) ? false : true;
        }
        private void textBoxDays_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int days = int.Parse((textBoxDays.Text.Length > 0) ? textBoxDays.Text : "1"); // день
                int month = int.Parse((textBoxMonth.Text.Length > 0) ? textBoxMonth.Text : "1"); // месяц
                int year = int.Parse((textBoxYear.Text.Length > 0) ? textBoxYear.Text : DateTime.Now.Year.ToString()); // год
                monthCalendar1.SetDate(new DateTime(year, month, days));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
