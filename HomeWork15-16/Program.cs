using System;
using Z.Expressions; //для работы с арифметическим выражением
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.LinearAlgebra; //для работы с матрицами

namespace HomeWork15_16
{
    class Program
    {
        const string alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        //Сдвиг алфавита (по методу "Цезаря")
        private static string encryptionAlphabet(int countShift)
        {
            char[] key = alphabet.ToCharArray();
            for (int i = 1; i <= countShift; i++) //Сдвиг алфавита. Смещение вправо
                for (int j = 0; j <= alphabet.Length - 2; j++) 
                    (key[j], key[j + 1]) = (key[j + 1], key[j]);
            return string.Join("", key);
        }
        private static bool checkText(string text) //Проверка введенных допустимых символов
        {
            bool flag = false;
            for (int i = 0; i < text.Length; i++)
            {
                if (!((text[i] >= 1040 && text[i] <= 1103) || text[i] == 1105 || text[i] == 1025 || text[i] == '.' || text[i] == ',' || text[i] == ' '))
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }
        //Шифрование слова (метод "Цезаря"). Сайт для проверки https://planetcalc.ru/1434/?ysclid=l69btd0xzx544112516
        public static string encryptionWorld(string world, int countShift)
        {
            string tempWorld = world; //Копия переданного стола world. Нужно для проверки регистра (большая буква)
            world = world.ToLower(); //преобразую исходное переданное слово в нижний регистр
            string key = encryptionAlphabet(countShift);
            char[] worlds = world.ToCharArray();
            for (int i = 0; i < worlds.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (world[i] == ',' || world[i] == '.')
                        continue;
                    else
                    {
                        if (world[i] == alphabet[j])
                        {
                            worlds[i] = key[j];
                            if ((tempWorld[i] >= 1040 && tempWorld[i] <= 1071) || tempWorld[i] == 1025) //Проверяю буквы в верхнем регистре они или нет
                                worlds[i] = char.ToUpper(worlds[i]); //Перевожу в вержний регистр
                            break;
                        }
                    }
                }
            }
            return string.Join("", worlds);
        }
        //Дешифрование слова
        public static string descriptionWorld(string world, int countShift)
        {
            string tempWorld = world; //Копия переданного стола world. Нужно для проверки регистра (большая буква)
            world = world.ToLower(); //преобразую исходное переданное слово в нижний регистр
            string key = encryptionAlphabet(countShift);
            char[] worlds = world.ToCharArray();
            for (int i = 0; i < worlds.Length; i++)
            {
                for (int j = 0; j < key.Length; j++)
                {
                    if (worlds[i] == key[j])
                    {
                        worlds[i] = key[(j - countShift < 0) ? (j+(key.Length- countShift)) : (j - countShift)];
                        if ((tempWorld[i] >= 1040 && tempWorld[i] <= 1071) || tempWorld[i] == 1025) //Проверяю буквы в верхнем регистре они или нет
                            worlds[i] = char.ToUpper(worlds[i]); //Перевожу в вержний регистр
                        break;
                    }
                }
            }
            return string.Join("", worlds);
        }
        //для заполнения двумерного массива
        static void fillArray(double[,] mas1, double[,] mas2)
        {
            Random rand = new Random();
            for (int i = 0; i < mas1.GetLength(0); i++)
                for (int j = 0; j < mas1.GetLength(1); j++)
                {
                    mas1[i, j] = rand.Next(0, 10); //Все равно оба массива одинакового размера
                    mas2[i, j] = rand.Next(0, 10); //Все равно оба массива одинакового размера
                }
        }
        /*Задание 1
        Пользователь вводит строку с клавиатуры. Необходимо зашифровать данную строку используя шифр Цезаря.
        Из Википедии: Шифр Цезаря — это вид шифра подстановки, в котором каждый символ в открытом тексте заменяется
        символом, находящимся на некотором постоянном числе позиций левее или правее него в алфавите. Например,
        в шифре со сдвигом вправо на 3, A была бы заменена на D, B станет E, и так далее. Подробнее тут: 
        https://en.wikipedia.org/wiki/Caesar_cipher. Кроме механизма шифровки, реализуйте механизм расшифрования.*/
        static void task1()
        {
            Console.WriteLine("Введите текст (допустимы только русские буквы, пробелы, точка и запятая) ");
            string text = Console.ReadLine();
            if (checkText(text))
                Console.WriteLine("В введенной строке присутствуют недопустимые символы");
            else
            {
                Console.WriteLine("Введите количество сдвигов (от 1 до 32) ");
                if (int.TryParse(Console.ReadLine(), out int countShift) && countShift >= 1 && countShift <= 32)
                {
                    text = string.Join(" ", text.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)); //Удаление лишних пробелов
                    string[] str = text.Split(' '); //загоняю в массив
                    for (int i = 0; i < str.Length; i++)
                        str[i] = encryptionWorld(str[i], countShift); //Шифрую каждое слово в предложении
                    text = string.Join(" ", str);
                    Console.WriteLine("Зашифрованное слово: " + text);
                    //Расшифровываю слово
                    string[] str2 = text.Split(' ');
                    for (int i = 0; i < str2.Length; i++)
                        str2[i] = descriptionWorld(str2[i], countShift); //Расшифровываю каждое слово в предложении
                    text = string.Join(" ", str2);
                    Console.WriteLine("Расшифрованное  слово: " + text);

                }
                else
                    Console.WriteLine("Не корректный ввод количества сдвигов!");
            }
        }
        /*Задание 2
        Создайте приложение, которое производит операции над матрицами:
        ■ Умножение матрицы на число;
        ■ Сложение матриц;
        ■ Произведение матриц.*/
        static void task2()
        {
            Console.Write("Введите количество строк и столбцов квадратной матрицы ");
            if (int.TryParse(Console.ReadLine(), out int size) && size > 0)
            {
                double[,] arr = new double[size, size];
                double[,] arr2 = new double[size, size];
                fillArray(arr, arr2);
                Matrix<double> matrixA = Matrix<double>.Build.DenseOfArray(arr); //создаем матрицу из двумерного массива
                                                                                 // https://numerics.mathdotnet.com/Matrix.html#Creating-Matrices-and-Vectors
                Console.WriteLine("Матрица A");
                Console.WriteLine(matrixA);
                Matrix<double> matrixB = Matrix<double>.Build.DenseOfArray(arr2); //создаем матрицу из двумерного массива
                Console.WriteLine("Матрица B");
                Console.WriteLine(matrixB);
                Console.WriteLine("Умножение матрицы A на матрицу B");
                Console.WriteLine(matrixA * matrixB);
                Console.WriteLine("Сложение матрицы A с матрицой B");
                Console.WriteLine(matrixA + matrixB);
                Console.Write("Введите число для умножения матрицы ");
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    Console.WriteLine("Умножение матрицы A на число " + number);
                    Console.WriteLine(matrixA * number);
                    Console.WriteLine("Умножение матрицы B на число " + number);
                    Console.WriteLine(matrixB * number);
                }
                else
                    Console.WriteLine("Не корректный ввод числа");
            }
            else
                Console.WriteLine("Не корректный ввод количества строк и столбцов");
        }
        /*Задание 3
        Пользователь с клавиатуры вводит в строку арифметическое выражение. Приложение должно посчитать
        его результат. Необходимо поддерживать только две операции: + и –.  */
        static void task3()
        {
            Console.WriteLine("Введите строку с арифметического выражения, например 2+3 (допустимы только цифры и знак + и -)");
            string expression = Console.ReadLine();
            bool flag = false; //Проверка на допустимые символы
            for (int i = 0; i < expression.Length; i++)
            {
                if (!((expression[i] >= 48 && expression[i] <= 57) || expression[i] == 43 || expression[i] == 45))
                {
                    flag = true;
                    break;
                }
            }
            if (flag)
                Console.WriteLine("В введенной строке присутствуют недопустимые символы ");
            else
            {
                try
                {
                    Console.WriteLine(expression + " = " + Eval.Execute<int>(expression)); //Eval.Execute<int>(expression) выполняет
                                                                                           //выражение (expression) и возвращает результат
                                                                                          //сссылка https://eval-expression.net/eval-compile
                }
                catch (Exception)
                {
                    Console.WriteLine("Ошибка при вычислении");
                }    
            }
        }

        static void Main(string[] args)
        {
            task1();
            Console.WriteLine("=======================================================================================");
            task2();
            Console.WriteLine("=======================================================================================");
            task3();
            Console.ReadKey();
        }
    }
}
