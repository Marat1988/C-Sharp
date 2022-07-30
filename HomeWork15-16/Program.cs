using System;
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

        //Шифрование слова (метод "Цезаря")
        public static string encryptionWorld(string world, int countShift)
        {
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
                            break;
                        }
                    }
                }
            }
            return string.Join("", worlds);
        }

        private static bool checkText(string text) //Проверка введенных допустимых символов
        {
            bool flag = false;
            for (int i = 0; i < text.Length; i++)
            {
                if (!((text[i] >= 1072 && text[i] <= 1103) || text[i] == 1105 || text[i]=='.' || text[i]==',' || text[i]==' '))
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }

        static void fillArray(double[,] arr) //для заполнения двумерного массива
        {
            Random rand = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                    arr[i, j] = rand.Next(0, 10);
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
                    string tempText = text;
                    text = text.ToLower();//Преобразую в нижний регистр регистр
                    string[] str = text.Split(' '); //загоняю в массив
                    for (int i = 0; i < str.Length; i++)
                        str[i] = encryptionWorld(str[i], countShift); //Шифрую каждое слово в предложении
                    Console.WriteLine(string.Join(" ",str));
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
                fillArray(arr);
                fillArray(arr2);
                Matrix<double> matrixA = Matrix<double>.Build.DenseOfArray(arr);
                Console.WriteLine("Матрица A");
                Console.WriteLine(matrixA);
                Matrix<double> matrixB = Matrix<double>.Build.DenseOfArray(arr2);
                Console.WriteLine("Матрица B");
                Console.WriteLine(matrixB);
                Console.WriteLine("Умножение матрицы A на матрицу B");
                Console.WriteLine(matrixA * matrixB);
                Console.WriteLine("Сложение матрицы A с матрицой B");
                Console.WriteLine(matrixA + matrixB);
                Console.Write("Введите число для умножения матрицы ");
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    Console.WriteLine("Умножение матрицы A " + number);
                    Console.WriteLine(matrixA * number);
                    Console.WriteLine("Умножение матрицы B " + number);
                    Console.WriteLine(matrixB * number);
                }
                else
                    Console.WriteLine("Не корректный ввод числа");
            }
            else
                Console.WriteLine("Не корректный ввод количества строк и столбцов");
        }
        static void Main(string[] args)
        {
            task1();  

        }
    }
}
