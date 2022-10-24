using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            richTextBox1.AllowDrop = true;
            richTextBox1.DragDrop += new DragEventHandler(richTextBox1_DragDrop);
        }

        private void richTextBox1_DragDrop(object sender, DragEventArgs e)
        {
            richTextBox1.Clear();
            try
            {
                var data = e.Data.GetData(DataFormats.FileDrop);
                if (data != null)
                {
                    var fileNames = data as string[];
                    if (fileNames.Length > 0)
                    {
                        richTextBox1.LoadFile(fileNames[0]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.BulletIndent = 10;
            richTextBox1.SelectionFont = new Font("Georgia", 16, FontStyle.Bold);
            richTextBox1.SelectedText = "Загрузите файл RFT нажатием на кнопку или перетащите сюда (drag-and-drop)";
            richTextBox1.SelectionFont = new Font("Verdana", 12);
            richTextBox1.ForeColor = Color.Red;
        }

        private void buttonLoadRTF_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "RFT files (*.rtf)|*.rtf";
            ofd.FilterIndex = 1;
            ofd.RestoreDirectory = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(ofd.FileName);
                richTextBox1.Find("Text", RichTextBoxFinds.MatchCase);
            }
        }
    }
}
