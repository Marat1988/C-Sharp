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

namespace Task5
{
    public partial class FormTextEditor : Form
    {
        private string fileName = "";
        private OpenFileDialog open = new OpenFileDialog
        {
            //Создали экземпляр. Установим фильтр для файлов
            Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
            FilterIndex = 1, //по умолчанию фильтруются текстовые файлы
            InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) //По-умолчанию. Пусть к рабочему столу
        };

        public FormTextEditor()
        {
            InitializeComponent();
        }

        private void toolStripButtonAddOpenDocument_Click(object sender, EventArgs e)
        {
            textBox.Clear();
            if (open.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = File.OpenText(open.FileName);
                textBox.Text = reader.ReadToEnd(); //Считываем файл до конца
                if (textBox.Text.Length > 0)
                {
                    fileName = open.FileName;
                    this.Text = fileName;
                }
                reader.Close();
            }
        }

        private void statusEnableNotEnableButtons()
        {
            toolStripButtonSaveDocument.Enabled = textBox.Text.Length > 0 && open.FileName.Length > 0;
            SaveDocumentToolStripMenuItem.Enabled = textBox.Text.Length > 0 && open.FileName.Length > 0;
            toolStripButtonCopy.Enabled = textBox.SelectionLength > 0;
            toolStripButtonСut.Enabled = textBox.SelectionLength > 0;
        }

        private void toolStripButtonSaveDocument_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter(fileName);
            //Записываем в файл содержимое поля
            writer.Write(textBox.Text);
            writer.Close();
        }

        private void toolStripButtonNewDocument_Click(object sender, EventArgs e)
        {
            FormTextEditor newDocument = new FormTextEditor();
            newDocument.Show();
        }

        private void textBox_TextChanged(object sender, EventArgs e) => statusEnableNotEnableButtons();

        private void textBox_Click(object sender, EventArgs e) => statusEnableNotEnableButtons();

        private void textBox_KeyUp(object sender, KeyEventArgs e) => statusEnableNotEnableButtons();



        private void toolStripButtonCopy_Click(object sender, EventArgs e)
        {
            //Ensure that text is selected in the text box.    
            if (textBox.SelectionLength > 0)
                //Copy the selected text to the Clipboard
                textBox.Copy();
        }

        private void toolStripButtonPaste_Click(object sender, EventArgs e)
        {
            //Determine if there is any text in the Clipboard to paste into the text box.
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {
                //Ask user if they want to paste over currently selected text.
                if (MessageBox.Show("Do you want to paste over current selection?", "Cut Example", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    //Move selection to the point after the current selection and paste
                    textBox.SelectionStart = textBox.SelectionStart + textBox.SelectionLength;
                }
                //Paste current text in Clipboard into the text box.
                textBox.Paste();
            }
        }

        private void toolStripButtonСut_Click(object sender, EventArgs e)
        {
            //Ensure that text is currently selected in the text box
            if (textBox.SelectedText != "")
                //Cut the selected text in the control and paste it into the Clipboard
                textBox.Cut();
        }

        private void toolStripButtonUndo_Click(object sender, EventArgs e)
        {
            //Determine if last operation can be undone in the text box.
            if (textBox.CanUndo == true)
            {
                //Undo the last operation
                textBox.Undo();
                //Clear the undo buffer to prevent last action from being redone
                textBox.ClearUndo();
            }
        }

        
    }
}
