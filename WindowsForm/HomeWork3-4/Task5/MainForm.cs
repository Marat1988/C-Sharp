using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task5
{
    public partial class MainForm : Form
    {
        private int numberFormChild = 1;
        public MainForm()
        {
            InitializeComponent();
        }

        private void newFormChildToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChild formChild = new FormChild(numberFormChild);
            formChild.MdiParent = this;
            formChild.Show();
            numberFormChild++;
        }



        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(Form form in this.MdiChildren)
            {
                MessageBox.Show(form.Name);
                form.Close();
            }
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi((MdiLayout)int.Parse((sender as ToolStripMenuItem).Tag.ToString()));
        }

        public Form[] getFormChild()
        {
            Form[] forms = MdiChildren;
            return forms;
        }
    }
}
