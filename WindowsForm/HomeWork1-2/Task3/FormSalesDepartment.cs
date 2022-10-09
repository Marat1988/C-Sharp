using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3
{
    public partial class FormSalesDepartment : Form
    {

        public FormSalesDepartment()
        {
            InitializeComponent();
        }

        private void RefreshProduct()
        {
            if (DataBaseProduct.products.Count > 0)
            {
                comboBoxListProducts.Items.Clear();
                for (int i = 0; i < DataBaseProduct.products.Count; i++)
                    comboBoxListProducts.Items.Add(DataBaseProduct.products[i].NameProduct);
                comboBoxListProducts.SelectedIndex = 0;
            }
        }

        private void ButtonAddProduct_Click(object sender, EventArgs e)
        {
            FormProduct formProduct = new FormProduct();
            formProduct.Tag = "Add";
            if (formProduct.ShowDialog() == DialogResult.OK)
            {
                RefreshProduct();
            }
        }

        private void ButtonSellProducts_Click(object sender, EventArgs e)
        {
            double total = double.Parse(TextBoxTotalSum.Text);
            total += Math.Round(double.Parse(TextBoxPrice.Text) * double.Parse(TextBoxCount.Text), 2);
            TextBoxTotalSum.Text = total.ToString();
            ListBoxSales.Items.Add(comboBoxListProducts.Text);

        }

        private void ButtonEditProducts_Click(object sender, EventArgs e)
        {
            FormProduct formProduct = new FormProduct(comboBoxListProducts.Text);
            formProduct.Tag = "Edit";
            if (formProduct.ShowDialog() == DialogResult.OK)
            {
                RefreshProduct();
            }
        }

        private void TextBoxCount_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)Keys.Back) ? false : true;

        private void comboBoxListProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DataBaseProduct.FindProduct(comboBoxListProducts.Text, out int index) == true)
            {
                TextBoxPrice.Text = DataBaseProduct.products[index].Price.ToString();
                TextBoxDescription.Text = DataBaseProduct.products[index].Description;
            }
  
            ButtonEditProducts.Enabled = comboBoxListProducts.Text.Length > 0;
            ButtonSellProducts.Enabled = comboBoxListProducts.Text.Length > 0 && TextBoxCount.TextLength > 0;
        }

        private void TextBoxCount_TextChanged(object sender, EventArgs e)
        {
            ButtonSellProducts.Enabled = comboBoxListProducts.Text.Length > 0 && TextBoxCount.TextLength > 0;
        }
    }
}
