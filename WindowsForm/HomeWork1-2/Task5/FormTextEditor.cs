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
        private OpenFileDialog open = new OpenFileDialog
        {
            //Создали экземпляр. Установим фильтр для файлов
            Filter = "txt files (*.txt)|*.txt",
            FilterIndex = 1, //по умолчанию фильтруются текстовые файлы
            InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) //По-умолчанию. Пусть к рабочему столу
        };

        public FormTextEditor()
        {
            InitializeComponent();
        }
        //Обновление статуса кнопок (т.е. когда должна быть кнопка доступна (свойство Enable))
        private void statusEnableNotEnableButtons()
        {
            toolStripButtonSaveDocument.Enabled = textBox.Text.Length > 0 && open.FileName.Length > 0;
            SaveDocumentToolStripMenuItem.Enabled = toolStripButtonSaveDocument.Enabled;
            toolStripButtonCopy.Enabled = textBox.SelectionLength > 0;
            CopyToolStripMenuItem.Enabled = toolStripButtonCopy.Enabled;
            toolStripButtonСut.Enabled = textBox.SelectionLength > 0;
            CutToolStripMenuItem.Enabled = toolStripButtonСut.Enabled;
            toolStripButtonUndo.Enabled = (textBox.CanUndo == true);
            UndoToolStripMenuItem.Enabled = toolStripButtonUndo.Enabled;
        }

        private void textBox_TextChanged(object sender, EventArgs e) => statusEnableNotEnableButtons();

        private void textBox_Click(object sender, EventArgs e) => statusEnableNotEnableButtons();

        private void textBox_KeyUp(object sender, KeyEventArgs e) => statusEnableNotEnableButtons();

        /***************************Меню Файл***************************/
        private void toolStripButtonAddOpenDocument_Click(object sender, EventArgs e)
        {
            textBox.Clear();
            if (open.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader reader = File.OpenText(open.FileName))
                {
                    textBox.Text = reader.ReadToEnd(); //Считываем файл до конца
                    if (textBox.Text.Length > 0)
                        this.Text = open.FileName;
                }
            }
        }

        private void toolStripButtonSaveDocument_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(open.FileName))
            {
                //Записываем в файл содержимое поля
                writer.Write(textBox.Text);
            }
        }

        private void toolStripButtonNewDocument_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "txt files (*.txt)|*.txt";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                open.FileName = saveFileDialog.FileName;
                this.Text = open.FileName;
                statusEnableNotEnableButtons();
            }
        }

        private void SelectAllTextToolStripMenuItem_Click(object sender, EventArgs e) => textBox.SelectAll();

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "txt files (*.txt)|*.txt";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    writer.Write(textBox.Text);
                    open.FileName = saveFileDialog.FileName;
                    this.Text = open.FileName;
                    statusEnableNotEnableButtons();
                }
            }
        }
        /***************************Меню Правка***************************/
        private void toolStripButtonCopy_Click(object sender, EventArgs e)
        {
            //Ensure that text is selected in the text box.    
            if (textBox.SelectionLength > 0)
                //Copy the selected text to the Clipboard
                textBox.Copy();
        }

        private void toolStripButtonСut_Click(object sender, EventArgs e)
        {
            //Ensure that text is currently selected in the text box
            if (textBox.SelectedText != "")
                //Cut the selected text in the control and paste it into the Clipboard
                textBox.Cut();
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
            statusEnableNotEnableButtons();
        }
        /***************************Меню Настройки***************************/
        private void toolStripButtonFontAndColorText_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowColor = true;
            fontDialog.Font = textBox.Font;
            fontDialog.Color = textBox.ForeColor;
            if (fontDialog.ShowDialog() != DialogResult.Cancel)
            {
                textBox.Font = fontDialog.Font;
                textBox.ForeColor = fontDialog.Color;
            }
        }

        private void toolStripButtonBackColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = textBox.BackColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
                textBox.BackColor = colorDialog.Color;
        }
    }
}
