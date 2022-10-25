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

namespace Task1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            //заполняем дерево дисками
            FillDriveNodes();
        }
        // получаем все диски на компьютере
        private void FillDriveNodes()
        {
            try
            {
                foreach (DriveInfo drive in DriveInfo.GetDrives())
                {
                    TreeNode driveNode = new TreeNode { Text = drive.Name };
                    LoadSubdirectory(driveNode, drive.Name);
                    LoadFiles(driveNode, drive.Name);
                    treeView1.Nodes.Add(driveNode);
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
        //получаем дочерние узлы для определенного узла
        private void LoadSubdirectory(TreeNode driveNode, string path)
        {
            try
            {
                string[] dirs = Directory.GetDirectories(path);
                foreach (string dir in dirs)
                {
                    TreeNode dirNode = new TreeNode { Text = dir.Remove(0, dir.LastIndexOf("\\") + 1), ImageIndex = 1, SelectedImageIndex = 1 };
                    driveNode.Nodes.Add(dirNode);
                }
            }
            catch (Exception){}
        }
        //Получаем список файлов
        private void LoadFiles(TreeNode td, string dir)
        {
            try
            {
                string[] Files = Directory.GetFiles(dir, "*.*");
                // Loop through them to see files
                foreach (string file in Files)
                {
                    FileInfo fi = new FileInfo(file);
                    TreeNode tds = td.Nodes.Add(fi.Name);
                    tds.ImageIndex = 2;
                    tds.SelectedImageIndex = 2;
                }
            }
            catch (Exception){}

        }
        //Событие перед раскрытием узла
        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.Nodes.Clear();
            try
            {
                if (Directory.Exists(e.Node.FullPath))
                {
                    string[] dirs = Directory.GetDirectories(e.Node.FullPath);
                    if (dirs.Length != 0)
                    {
                        for (int i = 0; i < dirs.Length; i++)
                        {
                            TreeNode dirNode = new TreeNode { Text = new DirectoryInfo(dirs[i]).Name, ImageIndex = 1, SelectedImageIndex = 1 };
                            LoadSubdirectory(dirNode, dirs[i]);
                            LoadFiles(dirNode, dirs[i]);
                            e.Node.Nodes.Add(dirNode);
                        }
                    }
                }
                LoadFiles(e.Node, e.Node.FullPath);
            }
            catch (Exception) { }
        }
    }
}
