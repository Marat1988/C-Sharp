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
    public partial class FormProduct : Form
    {
        private string nameProduct;

        public FormProduct()
        {
            InitializeComponent();
        }

        public FormProduct(string nameProduct)
        {
            InitializeComponent();
            this.nameProduct = nameProduct;
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
            if (this.Tag.ToString() == "Add")
            {
                this.Text = "Добавить товар";
            }
            else
            {
                this.Text = "Изменить товар";
                if (DataBaseProduct.FindProduct(nameProduct, out int index) == true) 
                {
                    TextBoxNameProduct.Text = DataBaseProduct.products[index].NameProduct;
                    TextBoxDescription.Text = DataBaseProduct.products[index].Description;
                    TextBoxCharacteristic.Text = DataBaseProduct.products[index].Characteristic;
                    TextBoxPrice.Text = DataBaseProduct.products[index].Price.ToString();
                }
            }
                
        }

        private void ButtonSaveProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Tag.ToString() == "Add")
                {
                    DataBaseProduct.AddProduct(TextBoxNameProduct.Text, TextBoxCharacteristic.Text, TextBoxDescription.Text, double.Parse(TextBoxPrice.Text), out string infoAdd);
                    if (infoAdd.Length == 0)
                        this.DialogResult = DialogResult.OK;
                    else
                        MessageBox.Show(infoAdd, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DataBaseProduct.UpdateProduct(nameProduct, TextBoxNameProduct.Text, TextBoxCharacteristic.Text, TextBoxDescription.Text, double.Parse(TextBoxPrice.Text), out string infoEdit);
                    if (infoEdit.Length == 0)
                        this.DialogResult = DialogResult.OK;
                    else
                        MessageBox.Show(infoEdit, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TextBoxName_TextChanged(object sender, EventArgs e)=>ButtonSaveProduct.Enabled = (TextBoxNameProduct.TextLength > 0 && TextBoxCharacteristic.TextLength > 0 && TextBoxDescription.TextLength > 0 && TextBoxPrice.TextLength > 0);

        private void TextBoxPrice_KeyPress(object sender, KeyPressEventArgs e)=>e.Handled = ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator[0] || e.KeyChar == (char)Keys.Back) ? false : true;
    }
}
