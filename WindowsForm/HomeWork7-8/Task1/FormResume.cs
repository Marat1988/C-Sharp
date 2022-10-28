using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class FormResume : Form
    {
        public FormResume()
        {
            InitializeComponent();
        }

        private void buttonResume_Click(object sender, EventArgs e)
        {
            string[] resume = { "Тухтаров Марат Ринадович", "Студент академии шаг, г. Калининград", "Работаю в ООО Три брата. P.S. Хочу стать разработчиком.\nВ будущем планирую сменить место работы" };
            for (int i = 0; i < resume.Length; i++)
            {
                MessageBox.Show(resume[i], (i < resume.Length - 1) ?
                                                "Информация" :
                                                $"Среднее число символов на странице {Math.Round(string.Join("", resume).Length / 3.0)}",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
        
            }
        }
    }
}
