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

namespace Task2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            listView1.View = (View)int.Parse(groupBoxDisplayTypeFiles.Controls.OfType<RadioButton>().FirstOrDefault(item => item.Checked == true).Tag.ToString());
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string[] files = Directory.GetFiles(fbd.SelectedPath); //Получаем все файлы
                    if (files.Length == 0)
                    {
                        MessageBox.Show("Файлы не найдены", "Результат поиска", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        textBoxFolderPath.Text = fbd.SelectedPath;
                        listView1.Items.Clear();
                        foreach (string file in files)
                        {
                            ListViewItem lvi = new ListViewItem();
                            //установка названия файла
                            lvi.Text = file.Remove(0, file.LastIndexOf('\\') + 1);
                            lvi.ImageIndex = 0; //установка картинки для файла
                            //Добавляем элемент в ListView
                            listView1.Items.Add(lvi);
                        }
                    }
                }
            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton.Checked)
            {

                listView1.View = (View)int.Parse(radioButton.Tag.ToString());
            }
        }
    }
}
