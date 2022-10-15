using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Task6
{
    public partial class FormExplorer : Form
    {
        private string curentAddressString = "";

        public FormExplorer()
        {
            InitializeComponent();
        }

        private void FormExplorer_Load(object sender, EventArgs e)
        {
            Timer1.Start();
            ShowDisk();
        }

        private void ShowDisk() //Отобразить список всех дисков
        {
            ClearAllData();
            ToolStripAddressStringStatusLabel.Text = "";
            DriveInfo[] drivers = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drivers)
                ListBoxFolders.Items.Add(drive.Name);
        }

        private void ClearAllData() //Чистка данных
        {
            ListBoxFolders.Items.Clear();
            ListBoxFiles.Items.Clear();
            ToolStripStatusCurrentCatalog.Text = "";
            ToolStripStatusSelectedFile.Text = "";
        }

        private void ShowFolders(string path) //Отобразить папки
        {
            if (Directory.Exists(path))
            {
                curentAddressString = path;
                ToolStripAddressStringStatusLabel.Text = curentAddressString;
                ClearAllData();
                ListBoxFolders.Items.Add("<=");
                try
                {
                    string[] dirs = Directory.GetDirectories(path);                 
                    foreach (string folder in dirs)
                    {
                        ListBoxFolders.Items.Add(folder);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                ShowDisk();
            }
        }

        private string CurrentPath(bool menu)
        {
            if (menu || ListBoxFolders.SelectedItem.ToString() == "<=")
            {
                if (curentAddressString.Length > 0)
                    return Path.GetDirectoryName(curentAddressString);
            }
            return ToolStripStatusCurrentCatalog.Text;
        }

        /*************************Меню*************************/
        private void BackToolStripMenuItem_Click(object sender, EventArgs e) => ShowFolders(CurrentPath(true));

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ListBoxFiles.SelectedIndex != -1)
                ListBoxFiles_DoubleClick(sender, e);
            else
            {
                if (ListBoxFolders.SelectedIndex != -1)
                    ListBoxFolders_DoubleClick(sender, e);
            }
        }

        private void ListBoxFolders_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBoxFiles.Items.Clear();
            ToolStripStatusSelectedFile.Text = "";
            if (ListBoxFolders.SelectedItems.Count > 0)
            {
                if (ListBoxFolders.SelectedItems[0].ToString() != "<=")
                {
                    try
                    {
                        ToolStripStatusCurrentCatalog.Text = ListBoxFolders.SelectedItem.ToString();
                        string[] files = Directory.GetFiles(ToolStripStatusCurrentCatalog.Text);
                        ListBoxFiles.Items.Clear();
                        foreach (string s in files)
                        {
                            ListBoxFiles.Items.Add(s);
                        }
                        ToolStripStatusSelectedFile.Text = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ListBoxFolders_DoubleClick(object sender, EventArgs e) => ShowFolders(CurrentPath(false));

        private void ListBoxFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBoxFiles.SelectedItems.Count > 0)
                ToolStripStatusSelectedFile.Text = ListBoxFiles.SelectedItem.ToString();
        }

        private void ListBoxFiles_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Process.Start(ToolStripStatusSelectedFile.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Timer1_Tick(object sender, EventArgs e) => ToolStripStatusGetTime.Text = DateTime.Now.ToLongTimeString();


    }
}
