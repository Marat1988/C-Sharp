using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            FillDriveNodes();
        }
        // получаем все диски на компьютере
        private void FillDriveNodes()
        {
            try
            {
                foreach (DriveInfo drive in DriveInfo.GetDrives())
                {
                        TreeNode rootNode = new TreeNode(drive.Name);
                        LoadSubdirectory(rootNode, drive.Name);
                        treeView1.Nodes.Add(rootNode);                   
                }
            }
            catch (Exception){}
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
            catch (Exception) { }
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            /*Немного отошел от задания. Сделал по-другому. В TreeView отображаются логические диски и папки. 
             * В ListView папки и файлы выбранной директории из TreeView
             При этом в ListView отображается информация, касающая папки или файла:
            1). Дата время создания файла или папки;
            2). Размер файла. Для папки ничего не выаодится;
            3). Тип (файл или папка)
            4). Чисто файлов в папке. Для файла ничего не отображается
            5). Аттрибуты файла или папки*/
            TreeNode newSelected = e.Node;
            listView1.Items.Clear();
            DirectoryInfo nodeDirInfo =  new DirectoryInfo(e.Node.FullPath);
            ListViewItem.ListViewSubItem[] subItems;
            ListViewItem item = null;
            bool notReadDirectory = false;
            try
            {
                foreach (DirectoryInfo dir in nodeDirInfo.GetDirectories())
                {
                    item = new ListViewItem(dir.Name, 1);
                    try
                    {
                        subItems = new ListViewItem.ListViewSubItem[]
                        {
                            new ListViewItem.ListViewSubItem(item,dir.CreationTime.ToString()),
                            new ListViewItem.ListViewSubItem(item,""),
                            new ListViewItem.ListViewSubItem(item,"Directory"),
                            new ListViewItem.ListViewSubItem(item, dir.GetFiles().Length.ToString()),
                            new ListViewItem.ListViewSubItem(item,dir.Attributes.ToString())
                        };
                    }
                    catch (Exception)
                    {
                        subItems = new ListViewItem.ListViewSubItem[]
                        {
                            new ListViewItem.ListViewSubItem(item,dir.CreationTime.ToString()),
                            new ListViewItem.ListViewSubItem(item,""),
                            new ListViewItem.ListViewSubItem(item,"Directory"),
                            new ListViewItem.ListViewSubItem(item, ""),
                            new ListViewItem.ListViewSubItem(item,dir.Attributes.ToString())
                        };
                    }

                    item.SubItems.AddRange(subItems);
                    listView1.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                notReadDirectory = true;
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Список файлов
            if (notReadDirectory == false)
            {
                foreach (FileInfo file in nodeDirInfo.GetFiles())
                {
                    item = new ListViewItem(file.Name, 2);
                    subItems = new ListViewItem.ListViewSubItem[]
                    {
                        new ListViewItem.ListViewSubItem(item,file.CreationTime.ToString()),
                        new ListViewItem.ListViewSubItem(item,file.Length.ToString()),
                        new ListViewItem.ListViewSubItem(item,"File"),
                        new ListViewItem.ListViewSubItem(item,""),
                        new ListViewItem.ListViewSubItem(item,file.Attributes.ToString())
                    };
                    item.SubItems.AddRange(subItems);
                    listView1.Items.Add(item);
                }
            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

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
                            e.Node.Nodes.Add(dirNode);
                        }
                    }
                }
            }
            catch (Exception) { }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
