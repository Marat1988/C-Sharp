using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task6
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDayOfWeek_Click(object sender, EventArgs e)
        {
            DateTime date = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day);
            MessageBox.Show($"Дата: {dateTimePicker1.Value.ToShortDateString()}\nДень недели: " + CultureInfo.CurrentCulture.DateTimeFormat.GetDayName(date.DayOfWeek), "День недели", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
