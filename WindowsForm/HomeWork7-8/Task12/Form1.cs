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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстовые файлы(*txt)|*.txt";
            openFileDialog.FilterIndex = 1;
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader reader = File.OpenText(openFileDialog.FileName))
                {
                    string text = reader.ReadToEnd();

                        string text2 = text;
                        //progressBar1.Maximum = text.Length;
                        for (int i = 0; i < text.Length-1; i++)
                        {

                        Task.Run(() => {
                            textBox1.Text += text[i];
                            progressBar1.Value++;


                        });
                           
                           // System.Threading.Thread.Sleep(100);
                        }
                    
 
                }
            }
        }
    }
}
