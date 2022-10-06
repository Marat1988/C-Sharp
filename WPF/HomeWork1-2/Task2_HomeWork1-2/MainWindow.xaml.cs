using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Z.Expressions; //для работы с арифметическим выражением

namespace Task2_HomeWork1_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        //Цифры (0-9)
        private void ButtonNumbers_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (TextBoxResult.Text.Length == 1 && TextBoxResult.Text[0] == '0')
                TextBoxResult.Clear();
            TextBoxResult.Text += button.Content.ToString();
        }
        //Оператор + - * /
        private void ButtonOperator_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (TextBoxResult.Text.Length > 0)
                TextBoxExpression.Text += TextBoxResult.Text + button.Content.ToString();
            else
                TextBoxExpression.Text = TextBoxExpression.Text.Remove(TextBoxExpression.Text.Length - 1, 1) + button.Content.ToString();
            TextBoxResult.Clear();
        }
        //Знак равно. Конечный результат
        private void ButtonResult_Click(object sender, RoutedEventArgs e)
        {
            string expression = "0";
            if (TextBoxResult.Text.Length > 0)
                expression = TextBoxExpression.Text + TextBoxResult.Text;
            else
                expression = TextBoxExpression.Text[0..^1];
            try
            {
                if (expression[^1] == '.')
                    expression = expression.Remove(expression.Length - 1);
                TextBoxResult.Text = Eval.Execute<double>(expression.Replace(',', '.')).ToString();
                TextBoxExpression.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        //Кнопка «C»
        private void ButtonC_Click(object sender, RoutedEventArgs e)
        {
            TextBoxResult.Clear();
            TextBoxExpression.Clear();
        }
        //Разделитель точка
        private void ButtonPoint_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (TextBoxResult.Text.Length == 0)
                TextBoxResult.Text = "0.";
            if (TextBoxResult.Text.Count(symbol => symbol == '.') == 0)
                TextBoxResult.Text += button.Content.ToString();
        }
        //Кнопка «CE»
        private void ButtonCE_Click(object sender, RoutedEventArgs e) => TextBoxResult.Clear();
        //Кнопка «<»
        private void ButtonLastClear_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxResult.Text.Length > 0)
                TextBoxResult.Text = TextBoxResult.Text.Remove(TextBoxResult.Text.Length - 1);
        }
    }
}
