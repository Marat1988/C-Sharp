using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task7
{
    public partial class FormMain : Form
    {
        private DateTime dateTimeEnd = new DateTime();
        private DateTime dateTimeBegin = new DateTime();
        public FormMain()
        {
            InitializeComponent();
        }

        private void maskedTextBoxDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBoxDate_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void buttonCalcDate_Click(object sender, EventArgs e)
        {
            dateTimeBegin = DateTime.Now;
            try
            {
                dateTimeEnd = DateTime.Parse(maskedTextBoxDate.Text);
                if (dateTimeEnd < dateTimeBegin)
                    MessageBox.Show("Введенная вами дата больше текущей. Введите другую дату", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    if (radioButtonYear.Checked)
                        MessageBox.Show($"{(dateTimeEnd - dateTimeBegin).TotalDays / 365}", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (radioButtonMonth.Checked)
                        MessageBox.Show($"{(dateTimeEnd - dateTimeBegin).TotalDays / 30.5}", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (radioButtonDays.Checked)
                        MessageBox.Show($"{(dateTimeEnd - dateTimeBegin).TotalDays}", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (radioButtonMinute.Checked)
                        MessageBox.Show($"{(dateTimeEnd - dateTimeBegin).TotalMinutes}", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (radioButtonSeconds.Checked)
                        MessageBox.Show($"{(dateTimeEnd - dateTimeBegin).TotalSeconds}", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
