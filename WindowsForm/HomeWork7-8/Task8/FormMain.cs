using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task8
{
    public partial class FormMain : Form
    {
        private List<Benzin> benzins;
        private List<Products> products;
        private List<OrderProducts> orderClient = new List<OrderProducts>();
        private int timeSeconds = 11;
        public FormMain()
        {
            InitializeComponent();         
            benzins = new List<Benzin>()
            {
                new Benzin("AИ - 92", 47.46),
                new Benzin("AИ - 95", 53.25),
                new Benzin("Дизельное топливо",54.86)
            };
            products = new List<Products>()
            {
                new Products("Хот-дог", 35.4),
                new Products("Гамбургер", 45),
                new Products("Картофель-фри", 20.5),
                new Products("Кока-кола", 15.6)
            };
            int masProductIndex = 0;
            for (int i = 0; i < groupBoxCafeGasStation.Controls.Count; i++)
            {
                if (groupBoxCafeGasStation.Controls[i] is CheckBox)
                {
                    (groupBoxCafeGasStation.Controls[i] as CheckBox).Text = products[masProductIndex].Name;
                    var textBox = groupBoxCafeGasStation.Controls[(groupBoxCafeGasStation.Controls[i] as CheckBox).Name.Replace("checkBox", "textBoxPrice")];
                    textBox.Text = products[masProductIndex].Price.ToString("0.00");
                    masProductIndex++;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < benzins.Count; i++)
                comboBoxBenzine.Items.Add(benzins[i].Name);
            comboBoxBenzine.SelectedIndex = 0;
        }

        private void comboBoxBenzine_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxPriceBenzine.Text = benzins[comboBoxBenzine.SelectedIndex].Price.ToString("0.00");
            CalcSumBenzine(out double sumBenzine);
        }
            
        private void textBoxLiters_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator[0] || e.KeyChar == (char)Keys.Back) ? false : true;
        }

        private void radioButtonLiters_CheckedChanged(object sender, EventArgs e)
        {
            textBoxLiters.Clear();
            textBoxLiters.ReadOnly = !radioButtonLiters.Checked;
            CalcSumBenzine(out double sumBenzine);
        } 

        private void radioButtonSum_CheckedChanged(object sender, EventArgs e)
        {
            textBoxSum.Clear();
            textBoxSum.ReadOnly= !radioButtonSum.Checked;
            CalcSumBenzine(out double sumBenzine);
        }

        private void textBoxLiters_TextChanged(object sender, EventArgs e) => CalcSumBenzine(out double sumBenzine);

        private void textBoxSum_TextChanged(object sender, EventArgs e) => CalcSumBenzine(out double sumBenzine);

        private void CalcSumBenzine(out double sumBenzine)
        {
            sumBenzine = 0;
            if (radioButtonLiters.Checked)
            {
                groupBoxSumMoneyBenzine.Text = "К оплате";
                if (textBoxLiters.Text.Length > 0)
                {                  
                    labelSumMoneyBenzine.Text = Benzin.CalcSum(double.Parse(textBoxLiters.Text), benzins[comboBoxBenzine.SelectedIndex].Price, true, out string text, out double totalAmount).ToString() + " " + text;
                    sumBenzine = totalAmount;
                }
                else
                {
                    labelSumMoneyBenzine.Text = Benzin.CalcSum(0, benzins[comboBoxBenzine.SelectedIndex].Price, true, out string text, out double totalAmount).ToString() + " " + text;
                    sumBenzine = totalAmount;
                }
            }
            if (radioButtonSum.Checked)
            {
                groupBoxSumMoneyBenzine.Text = "К выдаче";
                if (textBoxSum.Text.Length > 0)
                {
                    labelSumMoneyBenzine.Text = Benzin.CalcSum(double.Parse(textBoxSum.Text), benzins[comboBoxBenzine.SelectedIndex].Price, false, out string text, out double totalAmount).ToString() + " " + text;
                    sumBenzine = totalAmount;
                }
                else
                {
                    labelSumMoneyBenzine.Text = Benzin.CalcSum(0, benzins[comboBoxBenzine.SelectedIndex].Price, false, out string text, out double totalAmount).ToString() + " " + text;
                    sumBenzine = totalAmount;
                }
            }
        }

        /*Кафе*/
        private void textBoxCountHotDog_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)Keys.Back) ? false : true;

        private void checkBoxHotDog_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox s = sender as CheckBox;
            var textBoxCount = groupBoxCafeGasStation.Controls[s.Name.Replace("checkBox","textBoxCount")];
            (textBoxCount as TextBox).ReadOnly = !s.Checked;
            if (s.Checked == false)
                orderClient.RemoveAll(orderClient => orderClient.Name == s.Text);
            else
            {
                if (textBoxCount.Text.Length > 0 && double.Parse(textBoxCount.Text) > 0)
                {
                    var textBoxPrice = groupBoxCafeGasStation.Controls[s.Name.Replace("checkBox", "textBoxPrice")];
                    orderClient.Add(new OrderProducts(s.Text, double.Parse((textBoxPrice as TextBox).Text), int.Parse(textBoxCount.Text)));
                }
            }
            labelSumMoneyCafe.Text = OrderProducts.CalcSum(orderClient, out string text).ToString();
            labelSumMoneyCafe.Text += " " + text;
        }

        private void textBoxCountProduct1_TextChanged(object sender, EventArgs e)
        {
            TextBox textBoxCount = sender as TextBox;
            var textBoxPrice = groupBoxCafeGasStation.Controls[textBoxCount.Name.Replace("textBoxCount", "textBoxPrice")];
            var checkBox = groupBoxCafeGasStation.Controls[textBoxCount.Name.Replace("textBoxCount", "checkBox")];
            if (textBoxCount.Text.Length > 0)
            {
                if (int.Parse(textBoxCount.Text) > 0)
                {
                    orderClient.Add(new OrderProducts(checkBox.Text, double.Parse(textBoxPrice.Text), int.Parse(textBoxCount.Text)));
                }
                else
                {
                    orderClient.RemoveAll(orderClient => orderClient.Name == checkBox.Text);
                }
            }
            else
                orderClient.RemoveAll(orderClient => orderClient.Name == checkBox.Text);
            labelSumMoneyCafe.Text = OrderProducts.CalcSum(orderClient,out string text).ToString();
            labelSumMoneyCafe.Text += " " + text;
        }
        
        private void buttonCalculateAmount_Click(object sender, EventArgs e)
        {
            sumClient(false, out double sumBenzine, out double sumCafe);
            buttonCalculateAmount.Enabled = false;
            enableComponentControl(false);
            timer1.Start();
        }

        private void enableComponentControl(bool enabled)
        {
            for (int i = 0; i < groupBoxCafeGasStation.Controls.Count; i++)
            {
                groupBoxCafeGasStation.Controls[i].Enabled = enabled;
            }
            for (int i = 0; i < groupBoxRefuelling.Controls.Count; i++)
            {
                groupBoxRefuelling.Controls[i].Enabled = enabled;
            }
        }

        private void sumClient(bool registrationSales, out double sumBenzine, out double sumCafe)
        {
            sumCafe = 0;
            sumBenzine = 0;
            CalcSumBenzine(out double sum);
            sumBenzine = sum;
            sumCafe = OrderProducts.CalcSum(orderClient, out string text2);
            labelTotalPay.Text = (sumBenzine + sumCafe).ToString()+ " " + text2;
            if (registrationSales)
            {
                Benzin.RevenuePerDay += sumBenzine;
                Products.RevenuePerDay += sumCafe;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeSeconds--;
            labelTimeSeconds.Text = timeSeconds.ToString();
            if (timeSeconds == 0)
            {
                timer1.Stop();
                timeSeconds = 11;
                labelTimeSeconds.Text = "";
                buttonCalculateAmount.Enabled = true;
                enableComponentControl(true);
                if (MessageBox.Show("Зарегистрировать продажу?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    sumClient(true, out double sumBenzine, out double sumCafe);
                    textBoxCountProduct1.Text = "0";
                    for (int i = 0; i < groupBoxCafeGasStation.Controls.Count; i++)
                    {
                        if (groupBoxCafeGasStation.Controls[i] is TextBox)
                        {
                            if ((groupBoxCafeGasStation.Controls[i] as TextBox).Tag != null)
                            {
                                (groupBoxCafeGasStation.Controls[i] as TextBox).Text = (groupBoxCafeGasStation.Controls[i] as TextBox).Tag.ToString();
                                var checkBox = groupBoxCafeGasStation.Controls[(groupBoxCafeGasStation.Controls[i] as TextBox).Name.Replace("textBoxCount", "checkBox")];
                                (checkBox as CheckBox).Checked = false;
                            }
                        }
                    }
                    comboBoxBenzine.SelectedIndex = 0;
                    labelTotalPay.Text = "0 руб.";
                    radioButtonLiters.Checked = true;
                    textBoxSum.Text = "";
                    textBoxLiters.Text = "10";
                    labelProfitDay.Text = $"Общая выручка за день { Benzin.RevenuePerDay + Products.RevenuePerDay}";
                }
            }
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show(labelProfitDay.Text, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
