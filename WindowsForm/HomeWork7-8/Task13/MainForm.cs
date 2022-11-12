using System;
using System.Collections.Generic;
using System.Xml;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Task13
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            UpdateStatusEnableElement();
        }

        private void UpdateStatusEnableElement()
        {
            buttonSaveToTextFile.Enabled = listBoxUser.Items.Count > 0;
            buttonExportXMLFile.Enabled = listBoxUser.Items.Count > 0;
            toolStripMenuItemEditUser.Enabled = listBoxUser.Items.Count > 0;
            toolStripMenuItemDeleteUser.Enabled = listBoxUser.Items.Count > 0;
        }

        private void buttonAddToListBox_Click(object sender, EventArgs e)
        {
            string userInfo = textBoxName.Text + "\t" + textBoxSurName.Text + "\t" + textBoxMail.Text + "\t" + textBoxTelephone.Text;
            listBoxUser.Items.Add(userInfo);
            UpdateStatusEnableElement();
        }

        private void listBoxUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateStatusEnableElement();
            try
            {
                string[] user = listBoxUser.SelectedItem?.ToString().Split('\t');
                int index = 0;
                foreach (var item in groupBoxPersonalData.Controls)
                {
                    if (item is TextBoxBase)
                    {
                        (item as TextBoxBase).Text = user?[index];
                        index++;
                    }
                }
            }
            catch (Exception){}
        }

        private void toolStripMenuItemEditUser_Click(object sender, EventArgs e)
        {
            string userInfo = textBoxName.Text + "\t" + textBoxSurName.Text + "\t" + textBoxMail.Text + "\t" + textBoxTelephone.Text;
            listBoxUser.Items[listBoxUser.SelectedIndex] = userInfo;
        }

        private void buttonSaveToTextFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовый файлы(*.txt)|*.txt";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using(StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    for (int i = 0; i < listBoxUser.Items.Count; i++)
                    {
                        writer.WriteLine(listBoxUser.Items[i].ToString());
                    }
                }
            }
        }

        private void toolStripMenuItemDeleteUser_Click(object sender, EventArgs e)
        {
            listBoxUser.Items.RemoveAt(listBoxUser.SelectedIndex);
            UpdateStatusEnableElement();
        }

        private void buttonDownloadFromTextFile_Click(object sender, EventArgs e)
        {
            listBoxUser.Items.Clear();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстовые файлы(*.txt)|*.txt";
            openFileDialog.FilterIndex = 1;
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                IEnumerable<string> lines = File.ReadLines(openFileDialog.FileName);
                foreach (var str in lines)
                {
                    listBoxUser.Items.Add(str);
                }
            }
            UpdateStatusEnableElement();
        }

        private void buttonExportXMLFile_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовый файлы(*.xml)|*.xml";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                XmlTextWriter writer = null;
                try
                {
                    writer = new XmlTextWriter(saveFileDialog.FileName, Encoding.UTF8);
                    writer.Formatting = Formatting.Indented;
                    writer.WriteStartDocument();
                    writer.WriteStartElement("Peoples");
                    for (int i = 0; i < listBoxUser.Items.Count; i++)
                    {
                        writer.WriteStartElement("People");
                        listBoxUser.SelectedIndex = i;
                        string[] user = listBoxUser.SelectedItem?.ToString().Split('\t');
                        int index = 0;
                        for (int j = 0; j < groupBoxPersonalData.Controls.Count; j++)
                        {
                            if (groupBoxPersonalData.Controls[j] is TextBoxBase)
                            {
                                (groupBoxPersonalData.Controls[j] as TextBoxBase).Text = user?[index];
                                var label = groupBoxPersonalData.Controls[(groupBoxPersonalData.Controls[j] as TextBoxBase).Name.Replace("textBox", "label")];
                                writer.WriteAttributeString(label.Text, (groupBoxPersonalData.Controls[j] as TextBoxBase).Text);
                                index++;
                            }
                        }
                        writer.WriteEndElement();
                    }
                    writer.WriteEndDocument();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (writer != null)
                        writer.Close();
                }
            }
        }

        private void buttonDownloadFromXMLFile_Click(object sender, EventArgs e)
        {
            listBoxUser.Items.Clear();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстовый файлы(*.xml)|*.xml"; ;
            openFileDialog.FilterIndex = 1;
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                XmlTextReader reader = null;
                try
                {
                    reader = new XmlTextReader(openFileDialog.FileName);
                    reader.ReadStartElement("Peoples");
                    reader.WhitespaceHandling = WhitespaceHandling.None;
                    while (reader.Read())
                    {
                        if (reader.AttributeCount > 0)
                        {
                            string textReader = "";
                            while (reader.MoveToNextAttribute())
                            {
                                textReader += reader.Value + "\t";
                            }
                            listBoxUser.Items.Add(textReader.Remove(textReader.Length - 1, 1));
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (reader != null)
                    {
                        reader.Close();
                    }
                }
            }
            UpdateStatusEnableElement();
        }
    }
}
