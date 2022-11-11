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

namespace Task12
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonLoadTextFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстовые файлы(*txt)|*.txt";
            openFileDialog.FilterIndex = 1;
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader reader = File.OpenText(openFileDialog.FileName))
                {
                    string textFromFile = reader.ReadToEnd();
                    progressBar1.Maximum = textFromFile.Length;
                    for (int i = 0; i < textFromFile.Length; i++)
                    {
                        textBoxDescription.Text += textFromFile[i];
                        System.Threading.Thread.Sleep(100);
                        progressBar1.Value++;
                    }
                    MessageBox.Show($"Количество символов в тексте {textFromFile.Length}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }                  
            }
        }
    }
}
