using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task5
{
    public partial class FormMain : Form
    {
        Random random = new Random();
        public FormMain()
        {
            InitializeComponent();
            this.MinimumSize = new Size(buttonRun.Width + 40, buttonRun.Height + 70);

        }

        private void randomLeftTopButton()
        {
            buttonRun.Left = random.Next(0, ClientSize.Width - buttonRun.Width);
            buttonRun.Top = random.Next(0, ClientSize.Height - buttonRun.Height);
        }

        private void buttonRun_MouseMove(object sender, MouseEventArgs e) => randomLeftTopButton();

        private void buttonRun_Click(object sender, EventArgs e) => MessageBox.Show("Ура! Поймал", "Победа!", MessageBoxButtons.OK, MessageBoxIcon.Information);

        private void FormMain_SizeChanged(object sender, EventArgs e)
        {
            if (ClientSize.Width <= buttonRun.Left + buttonRun.Width || ClientSize.Height <= buttonRun.Top + buttonRun.Height)
                randomLeftTopButton();
        }
    }
}
