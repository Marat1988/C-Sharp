using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class FormGasStation : Form
    {
        public static class Localizer
        {
            public static event EventHandler LocaleChanged;
            public static void SetLocale(string name)
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(name);
                Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(name);
                LocaleChanged?.Invoke(null, EventArgs.Empty);
            }
        }

        public FormGasStation()
        {
            Localizer.LocaleChanged += Localizer_LocaleChanged;
            InitializeComponent();
            InitialControls();
        }

        private void Localizer_LocaleChanged(object sender, EventArgs e)
        {
            timer.Stop();
            Controls.Clear();
            InitializeComponent();
            InitialControls();
        }

        private void InitialControls()
        {
            ComboBoxChooseTypeFuel.SelectedIndex = 0;
            toolStripStatusLabelTimeOrDate.Text = DateTime.Now.ToLongTimeString();
            ToolStripMenuItemDayOfWeek.Text = CultureInfo.CurrentCulture.DateTimeFormat.GetDayName(DateTime.Now.DayOfWeek);
            notifyIcon1.Text = this.Text;
            timer.Start();
        }

        private void ButtonTotalPrice_Click(object sender, EventArgs e)
        {
            try
            {
                double price = double.Parse(TextBoxPrice.Text);
                double volume = double.Parse(TextBoxVolume.Text);
                LabelTotalPrice.Text = MyStrings.The_total_cost + " " + Math.Round(price * volume, 2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, MyStrings.Error, MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void timer_Tick(object sender, EventArgs e) => toolStripStatusLabelTimeOrDate.Text = (DateTime.Now.Second % 5 == 0) ? DateTime.Now.ToLongTimeString() : DateTime.Now.ToLongDateString();

        private void ToolStripMenuItemBackgroundColor_Click(object sender, EventArgs e) => PanelColor.Visible = true;
    
        private void trackBarR_ValueChanged(object sender, EventArgs e) => BackColor = Color.FromArgb(trackBarR.Value, trackBarG.Value, trackBarB.Value);

        private void ButtonHideRGB_Click(object sender, EventArgs e)=>PanelColor.Visible = false;

        private void FormGasStation_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon1.Visible = true;
            }
            else
            {
                if (FormWindowState.Normal == this.WindowState)
                    notifyIcon1.Visible = false;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            notifyIcon1.Visible = false;
            WindowState = FormWindowState.Normal;
        }

        private void TextBoxPrice_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator[0] || e.KeyChar == (char)Keys.Back) ? false : true;

        private void ButtonHidePanet_Click(object sender, EventArgs e)
        {
            trackBarR.Value = 0;
            trackBarG.Value = 0;
            trackBarB.Value = 0;
            BackColor = Color.Yellow;
        }

        private void EngToolStripMenuItem_Click(object sender, EventArgs e) => Localizer.SetLocale("en-US");

        private void RusToolStripMenuItem_Click(object sender, EventArgs e) => Localizer.SetLocale("ru-RU");

        private void TextBoxPrice_TextChanged(object sender, EventArgs e) => ButtonTotalPrice.Enabled = (string.IsNullOrEmpty(TextBoxPrice.Text) == false && string.IsNullOrEmpty(TextBoxVolume.Text) == false);
    }
}
