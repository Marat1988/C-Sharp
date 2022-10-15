using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task7
{
    public partial class FormMenu : Form
    {
        private readonly MenuStrip topMenu = new MenuStrip();
        public FormMenu()
        {
            InitializeComponent();
            this.MainMenuStrip = topMenu;
            this.Controls.Add(topMenu); //Добавляем меню на форму
        }

        private void TopLevelMenu_TextChanged(object sender, EventArgs e)
        {
            ButtonAdMenu.Enabled = TopLevelMenu.Text.Length > 0;
            ButtonAdSubMenu.Enabled = (TopLevelMenu.Text.Length > 0 && SubItem.Text.Length > 0);
        }

        private void ButtonAdMenu_Click(object sender, EventArgs e)
        {
            if (CheckTopLevelMenu(TopLevelMenu.Text, out int index) == false)
            {
                ToolStripMenuItem newMenu = (ToolStripMenuItem)topMenu.Items.Add(TopLevelMenu.Text);
                newMenu.Click += ToolStripMenuItem_Click;
            }

            else
                MessageBox.Show("Такой пункт меню уже существует", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void ButtonAdSubMenu_Click(object sender, EventArgs e)
        {
            if (CheckTopLevelMenu(TopLevelMenu.Text, out int index) == false)
            {
                MessageBox.Show("Невозможно добавить подменю. Такого пункта меню не существует", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (CheckSubMenu(SubItem.Text, (ToolStripMenuItem)topMenu.Items[index]) == true)
                {
                    MessageBox.Show("Такое подмменю уже существует в меню " + TopLevelMenu.Text, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    ToolStripMenuItem newSubMenu = (ToolStripMenuItem)topMenu.Items[index];
                    newSubMenu.DropDownItems.Add(SubItem.Text);
                }
            }
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e) => TopLevelMenu.Text = (sender as ToolStripMenuItem).Text;

        /*Проверки*/
        private bool CheckTopLevelMenu(string text, out int index) //Проверка существоваанию меню
        {
            index = -1;
            for (int i = 0; i < topMenu.Items.Count; i++)
            {
                if (topMenu.Items[i].Text == text)
                {
                    index = i;
                    return true;
                }
            }
            return false;
        }

        private bool CheckSubMenu(string text, ToolStripMenuItem menu) //Проверка существованию подменю
        {
            for (int i = 0; i < menu.DropDownItems.Count; i++)
            {
                if (menu.DropDownItems[i].Text == text)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
