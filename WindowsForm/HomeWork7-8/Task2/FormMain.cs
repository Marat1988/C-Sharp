using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2
{
    public partial class FormPlay : Form
    {
        private Random random = new Random();
        private int number = 0;
        public FormPlay()
        {
            InitializeComponent();
        }

        private void buttonPlayGame_Click(object sender, EventArgs e)
        {
            int numberAttempts = 0;
            while (true)
            {
                number = random.Next(1, 2001);
                numberAttempts++;
                if (MessageBox.Show($"Вы загадали число {number}?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (MessageBox.Show($"Число попыток {numberAttempts}. Хотите сыграть еще?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        break;
                }
            }
        }
    }
}
