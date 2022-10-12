using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void ButtonLoadTextFile_Click(object sender, EventArgs e)
        {
            FormEditTextFiles formEditTextFiles = new FormEditTextFiles();
            formEditTextFiles.Show();
        }
    }
}
