using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task4
{
    public partial class FormEditTextFiles : Form
    {
        private string fileName = "";

        public FormEditTextFiles()
        {
            InitializeComponent();
        }

        public FormEditTextFiles(string fileName, string textData)
        {
            this.fileName = fileName;
            InitializeComponent();
            TextBoxEditTextFile.Text = textData;
        }

        private void ButtonSaveTextFile_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter(fileName);
            //Записываем в файл содержимое поля
            writer.Write(TextBoxEditTextFile.Text);
            writer.Close();
            this.DialogResult = DialogResult.OK;
            //Закрывем writer;
            this.Close();
        }

        private void ButtonCancel_Click(object sender, EventArgs e) => this.Close();
    }
}
