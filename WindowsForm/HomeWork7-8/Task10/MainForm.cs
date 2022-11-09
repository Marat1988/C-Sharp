using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task10
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonNumberOfDays_Click(object sender, EventArgs e)
        {
            DateTime dateTimeBegin = dateTimePickerBegin.Value.Date;
            DateTime dateTimeEnd = dateTimePickerEnd.Value.Date;
            double countDays = Math.Abs((dateTimeEnd - dateTimeBegin).TotalDays);
            labelCountDays.Text = $"Количество дней между двемя датами: {countDays}";
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(new Rectangle(0, 0, 600, 600));
            Region region = new Region(path);
            this.Region = region;
        }

        private void buttonCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
