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
    public partial class FormMain : Form
    {
        private string fileName = "";

        public FormMain()
        {
            InitializeComponent();
        }

        private void Load_Data()
        {
            TextBoxDescription.Clear();
            OpenFileDialog open = new OpenFileDialog
            {
                //создали экземпляр. Установим фильтр для файлов
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
                FilterIndex = 1, //По умолчанию фильтруются текстовые файлы
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) //По умолчанию путь к рабочему столу
            };
            if (open.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = File.OpenText(open.FileName);
                TextBoxDescription.Text = reader.ReadToEnd();//Считываем файл до конца
                if (TextBoxDescription.Text.Length > 0)
                    fileName = open.FileName;
                reader.Close(); //Закрываем файл
            }
        }

        private void RefreshData()
        {
            StreamReader reader = File.OpenText(fileName);
            TextBoxDescription.Text = reader.ReadToEnd();//Считываем файл до конца
            reader.Close(); //Закрываем файл
        }

        private void ButtonLoadTextFile_Click(object sender, EventArgs e) => Load_Data();

        private void TextBoxDescription_TextChanged(object sender, EventArgs e) => ButtonEditTextFile.Enabled = TextBoxDescription.Text.Length > 0;

        private void ButtonEditTextFile_Click(object sender, EventArgs e)
        {
            FormEditTextFiles formEditTextFiles = new FormEditTextFiles(fileName, TextBoxDescription.Text);
            formEditTextFiles.Show();
            formEditTextFiles.Closed += (s, args) => RefreshData();

        }
    }
}
