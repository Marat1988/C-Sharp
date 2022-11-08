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

namespace Task9
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void buttonSaveProfileTextFile_Click(object sender, EventArgs e)
        {
            string gender = groupBoxGender.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;
            Profile profile = new Profile(textBoxSurName.Text, 
                                          textBoxName.Text, 
                                          textBoxMiddleName.Text,
                                          gender,
                                          dateTimePickerBirthday.Value,
                                          textBoxAdditionalInfo.Text);
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Текстовый файлы (*.txt)|*.txt",
                FilterIndex = 1,
                RestoreDirectory = true
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    writer.Write(profile.ToString());
                }
            }
        }
    }
}
