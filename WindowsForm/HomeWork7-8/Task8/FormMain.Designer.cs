
namespace Task8
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxRefuelling = new System.Windows.Forms.GroupBox();
            this.groupBoxSumMoneyBenzine = new System.Windows.Forms.GroupBox();
            this.labelSumMoneyBenzine = new System.Windows.Forms.Label();
            this.labelRubles2 = new System.Windows.Forms.Label();
            this.textBoxSum = new System.Windows.Forms.TextBox();
            this.labelLiters = new System.Windows.Forms.Label();
            this.labelRubles = new System.Windows.Forms.Label();
            this.textBoxLiters = new System.Windows.Forms.TextBox();
            this.panelChoicePayment = new System.Windows.Forms.Panel();
            this.radioButtonSum = new System.Windows.Forms.RadioButton();
            this.radioButtonLiters = new System.Windows.Forms.RadioButton();
            this.textBoxPriceBenzine = new System.Windows.Forms.TextBox();
            this.labelPriceBenzine = new System.Windows.Forms.Label();
            this.labelBenzine = new System.Windows.Forms.Label();
            this.comboBoxBenzine = new System.Windows.Forms.ComboBox();
            this.groupBoxCafeGasStation = new System.Windows.Forms.GroupBox();
            this.labelCountProduct = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxCountProduct4 = new System.Windows.Forms.TextBox();
            this.textBoxCountProduct3 = new System.Windows.Forms.TextBox();
            this.textBoxCountProduct2 = new System.Windows.Forms.TextBox();
            this.textBoxCountProduct1 = new System.Windows.Forms.TextBox();
            this.textBoxPriceProduct4 = new System.Windows.Forms.TextBox();
            this.textBoxPriceProduct3 = new System.Windows.Forms.TextBox();
            this.textBoxPriceProduct2 = new System.Windows.Forms.TextBox();
            this.textBoxPriceProduct1 = new System.Windows.Forms.TextBox();
            this.checkBoxProduct4 = new System.Windows.Forms.CheckBox();
            this.checkBoxProduct3 = new System.Windows.Forms.CheckBox();
            this.checkBoxProduct2 = new System.Windows.Forms.CheckBox();
            this.checkBoxProduct1 = new System.Windows.Forms.CheckBox();
            this.groupBoxSumMoneyCafe = new System.Windows.Forms.GroupBox();
            this.labelSumMoneyCafe = new System.Windows.Forms.Label();
            this.groupBoxTotalPay = new System.Windows.Forms.GroupBox();
            this.labelTotalPay = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonCalculateAmount = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBoxProfitDay = new System.Windows.Forms.GroupBox();
            this.labelTimeSeconds = new System.Windows.Forms.Label();
            this.labelProfitDay = new System.Windows.Forms.Label();
            this.groupBoxRefuelling.SuspendLayout();
            this.groupBoxSumMoneyBenzine.SuspendLayout();
            this.panelChoicePayment.SuspendLayout();
            this.groupBoxCafeGasStation.SuspendLayout();
            this.groupBoxSumMoneyCafe.SuspendLayout();
            this.groupBoxTotalPay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxProfitDay.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxRefuelling
            // 
            this.groupBoxRefuelling.Controls.Add(this.groupBoxSumMoneyBenzine);
            this.groupBoxRefuelling.Controls.Add(this.labelRubles2);
            this.groupBoxRefuelling.Controls.Add(this.textBoxSum);
            this.groupBoxRefuelling.Controls.Add(this.labelLiters);
            this.groupBoxRefuelling.Controls.Add(this.labelRubles);
            this.groupBoxRefuelling.Controls.Add(this.textBoxLiters);
            this.groupBoxRefuelling.Controls.Add(this.panelChoicePayment);
            this.groupBoxRefuelling.Controls.Add(this.textBoxPriceBenzine);
            this.groupBoxRefuelling.Controls.Add(this.labelPriceBenzine);
            this.groupBoxRefuelling.Controls.Add(this.labelBenzine);
            this.groupBoxRefuelling.Controls.Add(this.comboBoxBenzine);
            this.groupBoxRefuelling.ForeColor = System.Drawing.Color.Blue;
            this.groupBoxRefuelling.Location = new System.Drawing.Point(13, 13);
            this.groupBoxRefuelling.Name = "groupBoxRefuelling";
            this.groupBoxRefuelling.Size = new System.Drawing.Size(282, 327);
            this.groupBoxRefuelling.TabIndex = 0;
            this.groupBoxRefuelling.TabStop = false;
            this.groupBoxRefuelling.Text = "Автозаправка";
            // 
            // groupBoxSumMoneyBenzine
            // 
            this.groupBoxSumMoneyBenzine.Controls.Add(this.labelSumMoneyBenzine);
            this.groupBoxSumMoneyBenzine.ForeColor = System.Drawing.Color.Blue;
            this.groupBoxSumMoneyBenzine.Location = new System.Drawing.Point(6, 212);
            this.groupBoxSumMoneyBenzine.Name = "groupBoxSumMoneyBenzine";
            this.groupBoxSumMoneyBenzine.Size = new System.Drawing.Size(246, 100);
            this.groupBoxSumMoneyBenzine.TabIndex = 10;
            this.groupBoxSumMoneyBenzine.TabStop = false;
            this.groupBoxSumMoneyBenzine.Text = "К оплате:";
            // 
            // labelSumMoneyBenzine
            // 
            this.labelSumMoneyBenzine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSumMoneyBenzine.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSumMoneyBenzine.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelSumMoneyBenzine.Location = new System.Drawing.Point(3, 16);
            this.labelSumMoneyBenzine.Name = "labelSumMoneyBenzine";
            this.labelSumMoneyBenzine.Size = new System.Drawing.Size(240, 81);
            this.labelSumMoneyBenzine.TabIndex = 0;
            this.labelSumMoneyBenzine.Text = "0 руб.";
            this.labelSumMoneyBenzine.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelRubles2
            // 
            this.labelRubles2.AutoSize = true;
            this.labelRubles2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelRubles2.Location = new System.Drawing.Point(225, 165);
            this.labelRubles2.Name = "labelRubles2";
            this.labelRubles2.Size = new System.Drawing.Size(27, 13);
            this.labelRubles2.TabIndex = 9;
            this.labelRubles2.Text = "руб.";
            // 
            // textBoxSum
            // 
            this.textBoxSum.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxSum.Location = new System.Drawing.Point(127, 162);
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.ReadOnly = true;
            this.textBoxSum.Size = new System.Drawing.Size(92, 20);
            this.textBoxSum.TabIndex = 4;
            this.textBoxSum.TextChanged += new System.EventHandler(this.textBoxSum_TextChanged);
            this.textBoxSum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLiters_KeyPress);
            // 
            // labelLiters
            // 
            this.labelLiters.AutoSize = true;
            this.labelLiters.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelLiters.Location = new System.Drawing.Point(225, 129);
            this.labelLiters.Name = "labelLiters";
            this.labelLiters.Size = new System.Drawing.Size(16, 13);
            this.labelLiters.TabIndex = 7;
            this.labelLiters.Text = "л.";
            // 
            // labelRubles
            // 
            this.labelRubles.AutoSize = true;
            this.labelRubles.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelRubles.Location = new System.Drawing.Point(225, 78);
            this.labelRubles.Name = "labelRubles";
            this.labelRubles.Size = new System.Drawing.Size(27, 13);
            this.labelRubles.TabIndex = 6;
            this.labelRubles.Text = "руб.";
            // 
            // textBoxLiters
            // 
            this.textBoxLiters.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxLiters.Location = new System.Drawing.Point(127, 126);
            this.textBoxLiters.Name = "textBoxLiters";
            this.textBoxLiters.Size = new System.Drawing.Size(92, 20);
            this.textBoxLiters.TabIndex = 3;
            this.textBoxLiters.Text = "10";
            this.textBoxLiters.TextChanged += new System.EventHandler(this.textBoxLiters_TextChanged);
            this.textBoxLiters.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLiters_KeyPress);
            // 
            // panelChoicePayment
            // 
            this.panelChoicePayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelChoicePayment.Controls.Add(this.radioButtonSum);
            this.panelChoicePayment.Controls.Add(this.radioButtonLiters);
            this.panelChoicePayment.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelChoicePayment.Location = new System.Drawing.Point(6, 115);
            this.panelChoicePayment.Name = "panelChoicePayment";
            this.panelChoicePayment.Size = new System.Drawing.Size(115, 82);
            this.panelChoicePayment.TabIndex = 2;
            // 
            // radioButtonSum
            // 
            this.radioButtonSum.AutoSize = true;
            this.radioButtonSum.Location = new System.Drawing.Point(14, 46);
            this.radioButtonSum.Name = "radioButtonSum";
            this.radioButtonSum.Size = new System.Drawing.Size(59, 17);
            this.radioButtonSum.TabIndex = 1;
            this.radioButtonSum.Text = "Сумма";
            this.radioButtonSum.UseVisualStyleBackColor = true;
            this.radioButtonSum.CheckedChanged += new System.EventHandler(this.radioButtonSum_CheckedChanged);
            // 
            // radioButtonLiters
            // 
            this.radioButtonLiters.AutoSize = true;
            this.radioButtonLiters.Checked = true;
            this.radioButtonLiters.Location = new System.Drawing.Point(14, 13);
            this.radioButtonLiters.Name = "radioButtonLiters";
            this.radioButtonLiters.Size = new System.Drawing.Size(62, 17);
            this.radioButtonLiters.TabIndex = 0;
            this.radioButtonLiters.TabStop = true;
            this.radioButtonLiters.Text = "Литров";
            this.radioButtonLiters.UseVisualStyleBackColor = true;
            this.radioButtonLiters.CheckedChanged += new System.EventHandler(this.radioButtonLiters_CheckedChanged);
            // 
            // textBoxPriceBenzine
            // 
            this.textBoxPriceBenzine.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxPriceBenzine.Location = new System.Drawing.Point(71, 75);
            this.textBoxPriceBenzine.Name = "textBoxPriceBenzine";
            this.textBoxPriceBenzine.ReadOnly = true;
            this.textBoxPriceBenzine.Size = new System.Drawing.Size(148, 20);
            this.textBoxPriceBenzine.TabIndex = 1;
            // 
            // labelPriceBenzine
            // 
            this.labelPriceBenzine.AutoSize = true;
            this.labelPriceBenzine.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelPriceBenzine.Location = new System.Drawing.Point(6, 78);
            this.labelPriceBenzine.Name = "labelPriceBenzine";
            this.labelPriceBenzine.Size = new System.Drawing.Size(36, 13);
            this.labelPriceBenzine.TabIndex = 2;
            this.labelPriceBenzine.Text = "Цена:";
            // 
            // labelBenzine
            // 
            this.labelBenzine.AutoSize = true;
            this.labelBenzine.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelBenzine.Location = new System.Drawing.Point(6, 35);
            this.labelBenzine.Name = "labelBenzine";
            this.labelBenzine.Size = new System.Drawing.Size(47, 13);
            this.labelBenzine.TabIndex = 1;
            this.labelBenzine.Text = "Бензин:";
            // 
            // comboBoxBenzine
            // 
            this.comboBoxBenzine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBenzine.ForeColor = System.Drawing.SystemColors.ControlText;
            this.comboBoxBenzine.FormattingEnabled = true;
            this.comboBoxBenzine.Location = new System.Drawing.Point(71, 32);
            this.comboBoxBenzine.Name = "comboBoxBenzine";
            this.comboBoxBenzine.Size = new System.Drawing.Size(148, 21);
            this.comboBoxBenzine.TabIndex = 0;
            this.comboBoxBenzine.SelectedIndexChanged += new System.EventHandler(this.comboBoxBenzine_SelectedIndexChanged);
            // 
            // groupBoxCafeGasStation
            // 
            this.groupBoxCafeGasStation.Controls.Add(this.labelCountProduct);
            this.groupBoxCafeGasStation.Controls.Add(this.labelPrice);
            this.groupBoxCafeGasStation.Controls.Add(this.textBoxCountProduct4);
            this.groupBoxCafeGasStation.Controls.Add(this.textBoxCountProduct3);
            this.groupBoxCafeGasStation.Controls.Add(this.textBoxCountProduct2);
            this.groupBoxCafeGasStation.Controls.Add(this.textBoxCountProduct1);
            this.groupBoxCafeGasStation.Controls.Add(this.textBoxPriceProduct4);
            this.groupBoxCafeGasStation.Controls.Add(this.textBoxPriceProduct3);
            this.groupBoxCafeGasStation.Controls.Add(this.textBoxPriceProduct2);
            this.groupBoxCafeGasStation.Controls.Add(this.textBoxPriceProduct1);
            this.groupBoxCafeGasStation.Controls.Add(this.checkBoxProduct4);
            this.groupBoxCafeGasStation.Controls.Add(this.checkBoxProduct3);
            this.groupBoxCafeGasStation.Controls.Add(this.checkBoxProduct2);
            this.groupBoxCafeGasStation.Controls.Add(this.checkBoxProduct1);
            this.groupBoxCafeGasStation.Controls.Add(this.groupBoxSumMoneyCafe);
            this.groupBoxCafeGasStation.ForeColor = System.Drawing.Color.Blue;
            this.groupBoxCafeGasStation.Location = new System.Drawing.Point(316, 13);
            this.groupBoxCafeGasStation.Name = "groupBoxCafeGasStation";
            this.groupBoxCafeGasStation.Size = new System.Drawing.Size(282, 327);
            this.groupBoxCafeGasStation.TabIndex = 1;
            this.groupBoxCafeGasStation.TabStop = false;
            this.groupBoxCafeGasStation.Text = "Мини-кафе";
            // 
            // labelCountProduct
            // 
            this.labelCountProduct.AutoSize = true;
            this.labelCountProduct.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelCountProduct.Location = new System.Drawing.Point(206, 26);
            this.labelCountProduct.Name = "labelCountProduct";
            this.labelCountProduct.Size = new System.Drawing.Size(41, 13);
            this.labelCountProduct.TabIndex = 24;
            this.labelCountProduct.Text = "Кол-во";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelPrice.Location = new System.Drawing.Point(134, 26);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(33, 13);
            this.labelPrice.TabIndex = 23;
            this.labelPrice.Text = "Цена";
            // 
            // textBoxCountProduct4
            // 
            this.textBoxCountProduct4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxCountProduct4.Location = new System.Drawing.Point(197, 148);
            this.textBoxCountProduct4.Name = "textBoxCountProduct4";
            this.textBoxCountProduct4.ReadOnly = true;
            this.textBoxCountProduct4.Size = new System.Drawing.Size(55, 20);
            this.textBoxCountProduct4.TabIndex = 22;
            this.textBoxCountProduct4.Tag = "0";
            this.textBoxCountProduct4.Text = "0";
            this.textBoxCountProduct4.TextChanged += new System.EventHandler(this.textBoxCountProduct1_TextChanged);
            this.textBoxCountProduct4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCountHotDog_KeyPress);
            // 
            // textBoxCountProduct3
            // 
            this.textBoxCountProduct3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxCountProduct3.Location = new System.Drawing.Point(197, 113);
            this.textBoxCountProduct3.Name = "textBoxCountProduct3";
            this.textBoxCountProduct3.ReadOnly = true;
            this.textBoxCountProduct3.Size = new System.Drawing.Size(55, 20);
            this.textBoxCountProduct3.TabIndex = 21;
            this.textBoxCountProduct3.Tag = "0";
            this.textBoxCountProduct3.Text = "0";
            this.textBoxCountProduct3.TextChanged += new System.EventHandler(this.textBoxCountProduct1_TextChanged);
            this.textBoxCountProduct3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCountHotDog_KeyPress);
            // 
            // textBoxCountProduct2
            // 
            this.textBoxCountProduct2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxCountProduct2.Location = new System.Drawing.Point(197, 75);
            this.textBoxCountProduct2.Name = "textBoxCountProduct2";
            this.textBoxCountProduct2.ReadOnly = true;
            this.textBoxCountProduct2.Size = new System.Drawing.Size(55, 20);
            this.textBoxCountProduct2.TabIndex = 20;
            this.textBoxCountProduct2.Tag = "0";
            this.textBoxCountProduct2.Text = "0";
            this.textBoxCountProduct2.TextChanged += new System.EventHandler(this.textBoxCountProduct1_TextChanged);
            this.textBoxCountProduct2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCountHotDog_KeyPress);
            // 
            // textBoxCountProduct1
            // 
            this.textBoxCountProduct1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxCountProduct1.Location = new System.Drawing.Point(199, 42);
            this.textBoxCountProduct1.Name = "textBoxCountProduct1";
            this.textBoxCountProduct1.ReadOnly = true;
            this.textBoxCountProduct1.Size = new System.Drawing.Size(53, 20);
            this.textBoxCountProduct1.TabIndex = 19;
            this.textBoxCountProduct1.Tag = "0";
            this.textBoxCountProduct1.Text = "0";
            this.textBoxCountProduct1.TextChanged += new System.EventHandler(this.textBoxCountProduct1_TextChanged);
            this.textBoxCountProduct1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCountHotDog_KeyPress);
            // 
            // textBoxPriceProduct4
            // 
            this.textBoxPriceProduct4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxPriceProduct4.Location = new System.Drawing.Point(127, 148);
            this.textBoxPriceProduct4.Name = "textBoxPriceProduct4";
            this.textBoxPriceProduct4.ReadOnly = true;
            this.textBoxPriceProduct4.Size = new System.Drawing.Size(53, 20);
            this.textBoxPriceProduct4.TabIndex = 18;
            this.textBoxPriceProduct4.Text = "1";
            // 
            // textBoxPriceProduct3
            // 
            this.textBoxPriceProduct3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxPriceProduct3.Location = new System.Drawing.Point(127, 112);
            this.textBoxPriceProduct3.Name = "textBoxPriceProduct3";
            this.textBoxPriceProduct3.ReadOnly = true;
            this.textBoxPriceProduct3.Size = new System.Drawing.Size(53, 20);
            this.textBoxPriceProduct3.TabIndex = 17;
            this.textBoxPriceProduct3.Text = "1";
            // 
            // textBoxPriceProduct2
            // 
            this.textBoxPriceProduct2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxPriceProduct2.Location = new System.Drawing.Point(127, 75);
            this.textBoxPriceProduct2.Name = "textBoxPriceProduct2";
            this.textBoxPriceProduct2.ReadOnly = true;
            this.textBoxPriceProduct2.Size = new System.Drawing.Size(53, 20);
            this.textBoxPriceProduct2.TabIndex = 16;
            this.textBoxPriceProduct2.Text = "1";
            // 
            // textBoxPriceProduct1
            // 
            this.textBoxPriceProduct1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxPriceProduct1.Location = new System.Drawing.Point(127, 42);
            this.textBoxPriceProduct1.Name = "textBoxPriceProduct1";
            this.textBoxPriceProduct1.ReadOnly = true;
            this.textBoxPriceProduct1.Size = new System.Drawing.Size(53, 20);
            this.textBoxPriceProduct1.TabIndex = 15;
            this.textBoxPriceProduct1.Text = "1";
            // 
            // checkBoxProduct4
            // 
            this.checkBoxProduct4.AutoSize = true;
            this.checkBoxProduct4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBoxProduct4.Location = new System.Drawing.Point(12, 151);
            this.checkBoxProduct4.Name = "checkBoxProduct4";
            this.checkBoxProduct4.Size = new System.Drawing.Size(32, 17);
            this.checkBoxProduct4.TabIndex = 14;
            this.checkBoxProduct4.Tag = "3";
            this.checkBoxProduct4.Text = "4";
            this.checkBoxProduct4.UseVisualStyleBackColor = true;
            this.checkBoxProduct4.CheckedChanged += new System.EventHandler(this.checkBoxHotDog_CheckedChanged);
            // 
            // checkBoxProduct3
            // 
            this.checkBoxProduct3.AutoSize = true;
            this.checkBoxProduct3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBoxProduct3.Location = new System.Drawing.Point(12, 115);
            this.checkBoxProduct3.Name = "checkBoxProduct3";
            this.checkBoxProduct3.Size = new System.Drawing.Size(32, 17);
            this.checkBoxProduct3.TabIndex = 13;
            this.checkBoxProduct3.Tag = "2";
            this.checkBoxProduct3.Text = "3";
            this.checkBoxProduct3.UseVisualStyleBackColor = true;
            this.checkBoxProduct3.CheckedChanged += new System.EventHandler(this.checkBoxHotDog_CheckedChanged);
            // 
            // checkBoxProduct2
            // 
            this.checkBoxProduct2.AutoSize = true;
            this.checkBoxProduct2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBoxProduct2.Location = new System.Drawing.Point(12, 78);
            this.checkBoxProduct2.Name = "checkBoxProduct2";
            this.checkBoxProduct2.Size = new System.Drawing.Size(32, 17);
            this.checkBoxProduct2.TabIndex = 12;
            this.checkBoxProduct2.Tag = "1";
            this.checkBoxProduct2.Text = "2";
            this.checkBoxProduct2.UseVisualStyleBackColor = true;
            this.checkBoxProduct2.CheckedChanged += new System.EventHandler(this.checkBoxHotDog_CheckedChanged);
            // 
            // checkBoxProduct1
            // 
            this.checkBoxProduct1.AutoSize = true;
            this.checkBoxProduct1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBoxProduct1.Location = new System.Drawing.Point(12, 45);
            this.checkBoxProduct1.Name = "checkBoxProduct1";
            this.checkBoxProduct1.Size = new System.Drawing.Size(32, 17);
            this.checkBoxProduct1.TabIndex = 11;
            this.checkBoxProduct1.Tag = "0";
            this.checkBoxProduct1.Text = "1";
            this.checkBoxProduct1.UseVisualStyleBackColor = true;
            this.checkBoxProduct1.CheckedChanged += new System.EventHandler(this.checkBoxHotDog_CheckedChanged);
            // 
            // groupBoxSumMoneyCafe
            // 
            this.groupBoxSumMoneyCafe.Controls.Add(this.labelSumMoneyCafe);
            this.groupBoxSumMoneyCafe.ForeColor = System.Drawing.Color.Blue;
            this.groupBoxSumMoneyCafe.Location = new System.Drawing.Point(6, 212);
            this.groupBoxSumMoneyCafe.Name = "groupBoxSumMoneyCafe";
            this.groupBoxSumMoneyCafe.Size = new System.Drawing.Size(246, 100);
            this.groupBoxSumMoneyCafe.TabIndex = 10;
            this.groupBoxSumMoneyCafe.TabStop = false;
            this.groupBoxSumMoneyCafe.Text = "К оплате:";
            // 
            // labelSumMoneyCafe
            // 
            this.labelSumMoneyCafe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSumMoneyCafe.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSumMoneyCafe.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelSumMoneyCafe.Location = new System.Drawing.Point(3, 16);
            this.labelSumMoneyCafe.Name = "labelSumMoneyCafe";
            this.labelSumMoneyCafe.Size = new System.Drawing.Size(240, 81);
            this.labelSumMoneyCafe.TabIndex = 0;
            this.labelSumMoneyCafe.Text = "0 руб.";
            this.labelSumMoneyCafe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBoxTotalPay
            // 
            this.groupBoxTotalPay.Controls.Add(this.labelTotalPay);
            this.groupBoxTotalPay.Controls.Add(this.pictureBox1);
            this.groupBoxTotalPay.Controls.Add(this.buttonCalculateAmount);
            this.groupBoxTotalPay.ForeColor = System.Drawing.Color.Blue;
            this.groupBoxTotalPay.Location = new System.Drawing.Point(13, 356);
            this.groupBoxTotalPay.Name = "groupBoxTotalPay";
            this.groupBoxTotalPay.Size = new System.Drawing.Size(585, 105);
            this.groupBoxTotalPay.TabIndex = 2;
            this.groupBoxTotalPay.TabStop = false;
            this.groupBoxTotalPay.Text = "Всего к оплате";
            // 
            // labelTotalPay
            // 
            this.labelTotalPay.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelTotalPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTotalPay.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelTotalPay.Location = new System.Drawing.Point(318, 16);
            this.labelTotalPay.Name = "labelTotalPay";
            this.labelTotalPay.Size = new System.Drawing.Size(264, 86);
            this.labelTotalPay.TabIndex = 2;
            this.labelTotalPay.Text = "0 руб.";
            this.labelTotalPay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // buttonCalculateAmount
            // 
            this.buttonCalculateAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalculateAmount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonCalculateAmount.Location = new System.Drawing.Point(127, 16);
            this.buttonCalculateAmount.Name = "buttonCalculateAmount";
            this.buttonCalculateAmount.Size = new System.Drawing.Size(155, 76);
            this.buttonCalculateAmount.TabIndex = 0;
            this.buttonCalculateAmount.Text = "Подсчитать ";
            this.buttonCalculateAmount.UseVisualStyleBackColor = true;
            this.buttonCalculateAmount.Click += new System.EventHandler(this.buttonCalculateAmount_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBoxProfitDay
            // 
            this.groupBoxProfitDay.Controls.Add(this.labelTimeSeconds);
            this.groupBoxProfitDay.Controls.Add(this.labelProfitDay);
            this.groupBoxProfitDay.ForeColor = System.Drawing.Color.Blue;
            this.groupBoxProfitDay.Location = new System.Drawing.Point(13, 467);
            this.groupBoxProfitDay.Name = "groupBoxProfitDay";
            this.groupBoxProfitDay.Size = new System.Drawing.Size(585, 105);
            this.groupBoxProfitDay.TabIndex = 3;
            this.groupBoxProfitDay.TabStop = false;
            this.groupBoxProfitDay.Text = "Выручка за день";
            // 
            // labelTimeSeconds
            // 
            this.labelTimeSeconds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTimeSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTimeSeconds.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelTimeSeconds.Location = new System.Drawing.Point(3, 16);
            this.labelTimeSeconds.Name = "labelTimeSeconds";
            this.labelTimeSeconds.Size = new System.Drawing.Size(188, 86);
            this.labelTimeSeconds.TabIndex = 3;
            this.labelTimeSeconds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelProfitDay
            // 
            this.labelProfitDay.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelProfitDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProfitDay.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelProfitDay.Location = new System.Drawing.Point(191, 16);
            this.labelProfitDay.Name = "labelProfitDay";
            this.labelProfitDay.Size = new System.Drawing.Size(391, 86);
            this.labelProfitDay.TabIndex = 2;
            this.labelProfitDay.Text = "Общая выручка за день 0 руб.";
            this.labelProfitDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 579);
            this.Controls.Add(this.groupBoxProfitDay);
            this.Controls.Add(this.groupBoxTotalPay);
            this.Controls.Add(this.groupBoxCafeGasStation);
            this.Controls.Add(this.groupBoxRefuelling);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BestOil";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxRefuelling.ResumeLayout(false);
            this.groupBoxRefuelling.PerformLayout();
            this.groupBoxSumMoneyBenzine.ResumeLayout(false);
            this.panelChoicePayment.ResumeLayout(false);
            this.panelChoicePayment.PerformLayout();
            this.groupBoxCafeGasStation.ResumeLayout(false);
            this.groupBoxCafeGasStation.PerformLayout();
            this.groupBoxSumMoneyCafe.ResumeLayout(false);
            this.groupBoxTotalPay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxProfitDay.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxRefuelling;
        private System.Windows.Forms.TextBox textBoxPriceBenzine;
        private System.Windows.Forms.Label labelPriceBenzine;
        private System.Windows.Forms.Label labelBenzine;
        private System.Windows.Forms.ComboBox comboBoxBenzine;
        private System.Windows.Forms.Panel panelChoicePayment;
        private System.Windows.Forms.RadioButton radioButtonSum;
        private System.Windows.Forms.RadioButton radioButtonLiters;
        private System.Windows.Forms.GroupBox groupBoxSumMoneyBenzine;
        private System.Windows.Forms.Label labelSumMoneyBenzine;
        private System.Windows.Forms.Label labelRubles2;
        private System.Windows.Forms.TextBox textBoxSum;
        private System.Windows.Forms.Label labelLiters;
        private System.Windows.Forms.Label labelRubles;
        private System.Windows.Forms.TextBox textBoxLiters;
        private System.Windows.Forms.GroupBox groupBoxCafeGasStation;
        private System.Windows.Forms.TextBox textBoxCountProduct4;
        private System.Windows.Forms.TextBox textBoxCountProduct3;
        private System.Windows.Forms.TextBox textBoxCountProduct2;
        private System.Windows.Forms.TextBox textBoxCountProduct1;
        private System.Windows.Forms.TextBox textBoxPriceProduct4;
        private System.Windows.Forms.TextBox textBoxPriceProduct3;
        private System.Windows.Forms.TextBox textBoxPriceProduct2;
        private System.Windows.Forms.TextBox textBoxPriceProduct1;
        private System.Windows.Forms.CheckBox checkBoxProduct4;
        private System.Windows.Forms.CheckBox checkBoxProduct3;
        private System.Windows.Forms.CheckBox checkBoxProduct2;
        private System.Windows.Forms.CheckBox checkBoxProduct1;
        private System.Windows.Forms.GroupBox groupBoxSumMoneyCafe;
        private System.Windows.Forms.Label labelSumMoneyCafe;
        private System.Windows.Forms.GroupBox groupBoxTotalPay;
        private System.Windows.Forms.Label labelTotalPay;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonCalculateAmount;
        private System.Windows.Forms.Label labelCountProduct;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBoxProfitDay;
        private System.Windows.Forms.Label labelTimeSeconds;
        private System.Windows.Forms.Label labelProfitDay;
    }
}

