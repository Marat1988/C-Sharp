
namespace Task3
{
    partial class FormSalesDepartment
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ListBoxSales = new System.Windows.Forms.ListBox();
            this.comboBoxListProducts = new System.Windows.Forms.ComboBox();
            this.GroupBoxListProducts = new System.Windows.Forms.GroupBox();
            this.LabelPrice = new System.Windows.Forms.Label();
            this.TextBoxPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GroupBoxAddEdit = new System.Windows.Forms.GroupBox();
            this.ButtonEditProducts = new System.Windows.Forms.Button();
            this.ButtonAddProduct = new System.Windows.Forms.Button();
            this.GroupBoxSales = new System.Windows.Forms.GroupBox();
            this.TextBoxTotalSum = new System.Windows.Forms.TextBox();
            this.LabelSalesSumProduct = new System.Windows.Forms.Label();
            this.LabelCount = new System.Windows.Forms.Label();
            this.TextBoxCount = new System.Windows.Forms.TextBox();
            this.ButtonSellProducts = new System.Windows.Forms.Button();
            this.TextBoxDescription = new System.Windows.Forms.TextBox();
            this.LabelDescription = new System.Windows.Forms.Label();
            this.GroupBoxListProducts.SuspendLayout();
            this.GroupBoxAddEdit.SuspendLayout();
            this.GroupBoxSales.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListBoxSales
            // 
            this.ListBoxSales.FormattingEnabled = true;
            this.ListBoxSales.Location = new System.Drawing.Point(12, 12);
            this.ListBoxSales.Name = "ListBoxSales";
            this.ListBoxSales.Size = new System.Drawing.Size(247, 498);
            this.ListBoxSales.Sorted = true;
            this.ListBoxSales.TabIndex = 0;
            // 
            // comboBoxListProducts
            // 
            this.comboBoxListProducts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxListProducts.FormattingEnabled = true;
            this.comboBoxListProducts.Location = new System.Drawing.Point(6, 54);
            this.comboBoxListProducts.Name = "comboBoxListProducts";
            this.comboBoxListProducts.Size = new System.Drawing.Size(188, 21);
            this.comboBoxListProducts.Sorted = true;
            this.comboBoxListProducts.TabIndex = 1;
            this.comboBoxListProducts.SelectedIndexChanged += new System.EventHandler(this.comboBoxListProducts_SelectedIndexChanged);
            // 
            // GroupBoxListProducts
            // 
            this.GroupBoxListProducts.Controls.Add(this.LabelDescription);
            this.GroupBoxListProducts.Controls.Add(this.TextBoxDescription);
            this.GroupBoxListProducts.Controls.Add(this.LabelPrice);
            this.GroupBoxListProducts.Controls.Add(this.TextBoxPrice);
            this.GroupBoxListProducts.Controls.Add(this.label1);
            this.GroupBoxListProducts.Controls.Add(this.comboBoxListProducts);
            this.GroupBoxListProducts.Location = new System.Drawing.Point(281, 12);
            this.GroupBoxListProducts.Name = "GroupBoxListProducts";
            this.GroupBoxListProducts.Size = new System.Drawing.Size(200, 216);
            this.GroupBoxListProducts.TabIndex = 2;
            this.GroupBoxListProducts.TabStop = false;
            this.GroupBoxListProducts.Text = "Список товаров:";
            // 
            // LabelPrice
            // 
            this.LabelPrice.AutoSize = true;
            this.LabelPrice.Location = new System.Drawing.Point(6, 84);
            this.LabelPrice.Name = "LabelPrice";
            this.LabelPrice.Size = new System.Drawing.Size(65, 13);
            this.LabelPrice.TabIndex = 4;
            this.LabelPrice.Text = "Цена (руб.):";
            // 
            // TextBoxPrice
            // 
            this.TextBoxPrice.Location = new System.Drawing.Point(84, 81);
            this.TextBoxPrice.Name = "TextBoxPrice";
            this.TextBoxPrice.ReadOnly = true;
            this.TextBoxPrice.Size = new System.Drawing.Size(110, 20);
            this.TextBoxPrice.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберите товар из списка:";
            // 
            // GroupBoxAddEdit
            // 
            this.GroupBoxAddEdit.Controls.Add(this.ButtonEditProducts);
            this.GroupBoxAddEdit.Controls.Add(this.ButtonAddProduct);
            this.GroupBoxAddEdit.Location = new System.Drawing.Point(281, 234);
            this.GroupBoxAddEdit.Name = "GroupBoxAddEdit";
            this.GroupBoxAddEdit.Size = new System.Drawing.Size(200, 105);
            this.GroupBoxAddEdit.TabIndex = 3;
            this.GroupBoxAddEdit.TabStop = false;
            this.GroupBoxAddEdit.Text = "Действия:";
            // 
            // ButtonEditProducts
            // 
            this.ButtonEditProducts.Enabled = false;
            this.ButtonEditProducts.Location = new System.Drawing.Point(9, 58);
            this.ButtonEditProducts.Name = "ButtonEditProducts";
            this.ButtonEditProducts.Size = new System.Drawing.Size(185, 33);
            this.ButtonEditProducts.TabIndex = 1;
            this.ButtonEditProducts.Text = "Редактировать товар";
            this.ButtonEditProducts.UseVisualStyleBackColor = true;
            this.ButtonEditProducts.Click += new System.EventHandler(this.ButtonEditProducts_Click);
            // 
            // ButtonAddProduct
            // 
            this.ButtonAddProduct.Location = new System.Drawing.Point(9, 19);
            this.ButtonAddProduct.Name = "ButtonAddProduct";
            this.ButtonAddProduct.Size = new System.Drawing.Size(185, 33);
            this.ButtonAddProduct.TabIndex = 0;
            this.ButtonAddProduct.Text = "Добавить товар";
            this.ButtonAddProduct.UseVisualStyleBackColor = true;
            this.ButtonAddProduct.Click += new System.EventHandler(this.ButtonAddProduct_Click);
            // 
            // GroupBoxSales
            // 
            this.GroupBoxSales.Controls.Add(this.TextBoxTotalSum);
            this.GroupBoxSales.Controls.Add(this.LabelSalesSumProduct);
            this.GroupBoxSales.Controls.Add(this.LabelCount);
            this.GroupBoxSales.Controls.Add(this.TextBoxCount);
            this.GroupBoxSales.Controls.Add(this.ButtonSellProducts);
            this.GroupBoxSales.Location = new System.Drawing.Point(281, 345);
            this.GroupBoxSales.Name = "GroupBoxSales";
            this.GroupBoxSales.Size = new System.Drawing.Size(200, 165);
            this.GroupBoxSales.TabIndex = 4;
            this.GroupBoxSales.TabStop = false;
            this.GroupBoxSales.Text = "Продажа:";
            // 
            // TextBoxTotalSum
            // 
            this.TextBoxTotalSum.Location = new System.Drawing.Point(9, 126);
            this.TextBoxTotalSum.Name = "TextBoxTotalSum";
            this.TextBoxTotalSum.ReadOnly = true;
            this.TextBoxTotalSum.Size = new System.Drawing.Size(184, 20);
            this.TextBoxTotalSum.TabIndex = 4;
            this.TextBoxTotalSum.Text = "0";
            this.TextBoxTotalSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LabelSalesSumProduct
            // 
            this.LabelSalesSumProduct.AutoSize = true;
            this.LabelSalesSumProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelSalesSumProduct.Location = new System.Drawing.Point(20, 100);
            this.LabelSalesSumProduct.Name = "LabelSalesSumProduct";
            this.LabelSalesSumProduct.Size = new System.Drawing.Size(173, 13);
            this.LabelSalesSumProduct.TabIndex = 3;
            this.LabelSalesSumProduct.Text = "Общая сумма продаж (руб.)";
            // 
            // LabelCount
            // 
            this.LabelCount.AutoSize = true;
            this.LabelCount.Location = new System.Drawing.Point(6, 25);
            this.LabelCount.Name = "LabelCount";
            this.LabelCount.Size = new System.Drawing.Size(44, 13);
            this.LabelCount.TabIndex = 2;
            this.LabelCount.Text = "Кол-во:";
            // 
            // TextBoxCount
            // 
            this.TextBoxCount.Location = new System.Drawing.Point(56, 22);
            this.TextBoxCount.Name = "TextBoxCount";
            this.TextBoxCount.Size = new System.Drawing.Size(137, 20);
            this.TextBoxCount.TabIndex = 1;
            this.TextBoxCount.TextChanged += new System.EventHandler(this.TextBoxCount_TextChanged);
            this.TextBoxCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxCount_KeyPress);
            // 
            // ButtonSellProducts
            // 
            this.ButtonSellProducts.Enabled = false;
            this.ButtonSellProducts.Location = new System.Drawing.Point(9, 48);
            this.ButtonSellProducts.Name = "ButtonSellProducts";
            this.ButtonSellProducts.Size = new System.Drawing.Size(188, 35);
            this.ButtonSellProducts.TabIndex = 0;
            this.ButtonSellProducts.Text = "Продать";
            this.ButtonSellProducts.UseVisualStyleBackColor = true;
            this.ButtonSellProducts.Click += new System.EventHandler(this.ButtonSellProducts_Click);
            // 
            // TextBoxDescription
            // 
            this.TextBoxDescription.Location = new System.Drawing.Point(9, 137);
            this.TextBoxDescription.Multiline = true;
            this.TextBoxDescription.Name = "TextBoxDescription";
            this.TextBoxDescription.ReadOnly = true;
            this.TextBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TextBoxDescription.Size = new System.Drawing.Size(184, 73);
            this.TextBoxDescription.TabIndex = 5;
            // 
            // LabelDescription
            // 
            this.LabelDescription.AutoSize = true;
            this.LabelDescription.Location = new System.Drawing.Point(6, 121);
            this.LabelDescription.Name = "LabelDescription";
            this.LabelDescription.Size = new System.Drawing.Size(98, 13);
            this.LabelDescription.TabIndex = 6;
            this.LabelDescription.Text = "Описание товара:";
            // 
            // FormSalesDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 538);
            this.Controls.Add(this.GroupBoxSales);
            this.Controls.Add(this.GroupBoxAddEdit);
            this.Controls.Add(this.GroupBoxListProducts);
            this.Controls.Add(this.ListBoxSales);
            this.Name = "FormSalesDepartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Торговый отдел";
            this.GroupBoxListProducts.ResumeLayout(false);
            this.GroupBoxListProducts.PerformLayout();
            this.GroupBoxAddEdit.ResumeLayout(false);
            this.GroupBoxSales.ResumeLayout(false);
            this.GroupBoxSales.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxSales;
        private System.Windows.Forms.ComboBox comboBoxListProducts;
        private System.Windows.Forms.GroupBox GroupBoxListProducts;
        private System.Windows.Forms.Label LabelPrice;
        private System.Windows.Forms.TextBox TextBoxPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GroupBoxAddEdit;
        private System.Windows.Forms.Button ButtonEditProducts;
        private System.Windows.Forms.Button ButtonAddProduct;
        private System.Windows.Forms.GroupBox GroupBoxSales;
        private System.Windows.Forms.Label LabelCount;
        private System.Windows.Forms.TextBox TextBoxCount;
        private System.Windows.Forms.Button ButtonSellProducts;
        private System.Windows.Forms.TextBox TextBoxTotalSum;
        private System.Windows.Forms.Label LabelSalesSumProduct;
        private System.Windows.Forms.Label LabelDescription;
        private System.Windows.Forms.TextBox TextBoxDescription;
    }
}

