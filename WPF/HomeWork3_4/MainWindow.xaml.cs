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
using System.Windows.Threading;

namespace KeyboardTraining
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const int maxStrLenght = 75;
        private readonly DispatcherTimer timer = new DispatcherTimer();
        private int secondCount = 0;
        private int countErrors = 0;
        private bool shiftKey = false; //Зажата ли клавиша SHIFT
        private readonly string sourceString = "QWERTYUIOPASDFGHJKLZXCVBNM~!@#$%^&*()_+{}|:\"<>?1234567890[],./\\`-=;'qwertyuiopasdfghjklzxcvbnm";
        public MainWindow()
        {
            InitializeComponent();
            timer.Tick += Timer_Tick;
            timer.Interval = new TimeSpan(0, 0, 0, 0, 1000);
        }
        private void CapitalLetters()
        {
            Q.Content = "Q";
            W.Content = "W";
            E.Content = "E";
            R.Content = "R";
            T.Content = "T";
            Y.Content = "Y";
            U.Content = "U";
            I.Content = "I";
            O.Content = "O";
            P.Content = "P";
            A.Content = "A";
            S.Content = "S";
            D.Content = "D";
            F.Content = "F";
            G.Content = "G";
            H.Content = "H";
            J.Content = "J";
            K.Content = "K";
            L.Content = "L";
            Z.Content = "Z";
            X.Content = "X";
            C.Content = "C";
            V.Content = "V";
            B.Content = "B";
            N.Content = "N";
            M.Content = "M";
        }
        private void LoverLetters()
        {
            Q.Content = "q";
            W.Content = "w";
            E.Content = "e";
            R.Content = "r";
            T.Content = "t";
            Y.Content = "y";
            U.Content = "u";
            I.Content = "i";
            O.Content = "o";
            P.Content = "p";
            A.Content = "a";
            S.Content = "s";
            D.Content = "d";
            F.Content = "f";
            G.Content = "g";
            H.Content = "h";
            J.Content = "j";
            K.Content = "k";
            L.Content = "l";
            Z.Content = "z";
            X.Content = "x";
            C.Content = "c";
            V.Content = "v";
            B.Content = "b";
            N.Content = "n";
            M.Content = "m";
        }
        private void CapitalSymbol()
        {
            Oem3.Content = "~";
            D1.Content = "!";
            D2.Content = "@";
            D3.Content = "#";
            D4.Content = "$";
            D5.Content = "%";
            D6.Content = "^";
            D7.Content = "&";
            D8.Content = "*";
            D9.Content = "(";
            D0.Content = ")";
            OemMinus.Content = "_";
            OemPlus.Content = "+";
            OemOpenBrackets.Content = "{";
            Oem6.Content = "}";
            Oem5.Content = "|";
            Oem1.Content = ":";
            OemQuotes.Content = "\"";
            OemComma.Content = "<";
            OemPeriod.Content = ">";
            OemQuestion.Content = "?";
        }
        private void LoverSymbol()
        {
            Oem3.Content = "`";
            D1.Content = "1";
            D2.Content = "2";
            D3.Content = "3";
            D4.Content = "4";
            D5.Content = "5";
            D6.Content = "6";
            D7.Content = "7";
            D8.Content = "8";
            D9.Content = "9";
            D0.Content = "0";
            OemMinus.Content = "-";
            OemPlus.Content = "=";
            OemOpenBrackets.Content = "[";
            Oem6.Content = "]";
            Oem5.Content = "\\";
            Oem1.Content = ";";
            OemQuotes.Content = "'";
            OemComma.Content = ",";
            OemPeriod.Content = ".";
            OemQuestion.Content = "/";
        }
        private void GenerateString()
        {
            Random rendChar = new Random();
            string str = "";
            int countSymbols = (int)(SliderDifficulty.Value);
            for (int i = 0; i < countSymbols; i++)
            {
                str += sourceString[rendChar.Next(countSymbols, sourceString.Length)];
            }
            str += " ";
            if (CaseSensitive.IsChecked == false)
                str = str.ToLower();
            for (int i = 0; i < maxStrLenght; i++)
            {
                TextPrograms.Text += str[rendChar.Next(0, str.Length)];
            }
        }
        private void CheckText(string symbol)
        {
            if (EndGame() == false)
            {
                string programText = TextPrograms.Text;
                if (symbol == "Backspace")
                {
                    if (string.IsNullOrEmpty(TextUser.Text) == false)
                    {
                        string newText = TextUser.Text.Remove(TextUser.Text.Length - 1, 1);
                        TextUser.Text = "";
                        for (int i = 0; i < newText.Length; i++)
                        {
                            if (programText[i] == newText[i])
                                TextUser.Inlines.Add(new Run(newText[i].ToString()) { Background = Brushes.GreenYellow });
                            else
                                TextUser.Inlines.Add(new Run(newText[i].ToString()) { Background = Brushes.Red });
                        }
                    }
                    ColorTextBackground(programText);
                }
                else
                {
                    if (symbol == "Space")
                        symbol = " ";
                    int lenghtUserStr = TextUser.Text.Length;

                    if (programText[lenghtUserStr].ToString() == symbol)
                        TextUser.Inlines.Add(new Run(symbol) { Background = Brushes.GreenYellow });
                    else
                    {
                        TextUser.Inlines.Add(new Run(symbol) { Background = Brushes.Red });
                        countErrors++;
                        Fails.Content = countErrors;
                    }
                    ColorTextBackground(programText);
                }
            }
            else
            {
                TextUser.IsEnabled = true;
            }
        }
        private void ColorTextBackground(string programText)
        {
            TextPrograms.Text = "";
            for (int i = 0; i < programText.Length; i++)
            {
                if (i <= TextUser.Text.Length - 1)
                {
                    if (programText[i] != TextUser.Text[i])
                        TextPrograms.Inlines.Add(new Run(programText[i].ToString()) { Background = Brushes.Red });
                    else
                        TextPrograms.Inlines.Add(new Run(programText[i].ToString()) { Background = Brushes.GreenYellow });
                }
                else
                    TextPrograms.Inlines.Add(new Run(programText[i].ToString()));
            }
        }
        private void Start_Click(object sender, RoutedEventArgs e)
        {
            GenerateString();
            timer.Start();
            SliderDifficulty.IsEnabled = false;
            CaseSensitive.IsEnabled = false;
            Start.IsEnabled = false;
            Stop.IsEnabled = true;
        }
        private void FormKeyboardTraining_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key.ToString() == "LeftShift" || e.Key.ToString() == "RightShift")
            {
                CapitalSymbol();
                shiftKey = true;
            }
            if (e.Key.ToString() == "Capital")
                CapsLookinclude.IsChecked = !CapsLookinclude.IsChecked;
            if (CapsLookinclude.IsChecked == true)
            {
                if (shiftKey == false)
                    CapitalLetters();
                else
                    LoverLetters();
            }
            else
            {
                if (shiftKey == false)
                    LoverLetters();
                else
                    CapitalLetters();
            }

            foreach (UIElement element in MainGrid.Children)
            {
                if (element is Grid)
                {
                    foreach (UIElement childrenElement in (element as Grid).Children)
                    {
                        if (childrenElement is Button)
                        {
                            if (e.Key.ToString() == (childrenElement as Button).Name)
                            {
                                if (Start.IsEnabled == false) //Считаем, что игра началась
                                {
                                    if ((childrenElement as Button).Tag?.ToString() == "PrintingText" ||
                                        (childrenElement as Button).Content.ToString() == "Space" ||
                                        (childrenElement as Button).Content.ToString() == "Backspace")
                                    {
                                        CheckText((childrenElement as Button).Content.ToString());
                                    }
                                }
                                (childrenElement as Button).Opacity = 0.5;
                            }
                        }
                    }
                }
            }
        }
        private void FormKeyboardTraining_PreviewKeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key.ToString() == "LeftShift" || e.Key.ToString() == "RightShift")
            {
                LoverSymbol(); //Замена символов
                shiftKey = false;
                if (CapsLookinclude.IsChecked == false)
                    LoverLetters();
                else
                    CapitalLetters();
            }
            foreach (UIElement element in MainGrid.Children)
            {
                if (element is Grid)
                {
                    foreach (UIElement childrenElement in (element as Grid).Children)
                    {
                        if (childrenElement is Button)
                        {
                            if (e.Key.ToString() == (childrenElement as Button).Name)
                            {
                                (childrenElement as Button).Opacity = 1;
                            }

                        }
                    }
                }
            }
            if (EndGame()) {
                timer.Stop();
                MessageBox.Show($"Игра завершена\n Длина текста {TextUser.Text.Length}.\n Количество ошибок {Fails.Content}.\nДля завершения задания нажмите Stop.", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
        private bool EndGame() => Start.IsEnabled == false && (TextUser.Text.Length == TextPrograms.Text.Length); //Проерка, закончена ли ингра
        private void SliderDifficulty_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) => Difficulty.Content = (int)SliderDifficulty.Value;
        private void Timer_Tick(object sender, EventArgs e)
        {
            secondCount++;
            SpeedChar.Content = Math.Round(((double)TextUser.Text.Length / secondCount) * 60).ToString();
        }
        private void CaseSensitive_Checked(object sender, RoutedEventArgs e) => SliderDifficulty.Maximum = 92;
        private void CaseSensitive_Unchecked(object sender, RoutedEventArgs e)=> SliderDifficulty.Maximum = 47;
        private void Stop_Click(object sender, RoutedEventArgs e)
        {
            if (TextUser.Text.Length != TextPrograms.Text.Length)
                MessageBox.Show("Очень жаль, что вы не доиграли", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
            timer.Stop();
            TextUser.Text = "";
            TextPrograms.Text = "";
            SliderDifficulty.IsEnabled = true;
            CaseSensitive.IsEnabled = true;
            Start.IsEnabled = true;
            Stop.IsEnabled = false;
            Fails.Content = "0";
            SpeedChar.Content = "0";
            secondCount = 0;
            countErrors = 0;
        }
    }
}
