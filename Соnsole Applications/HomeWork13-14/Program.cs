using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void fillOneDimensionalArray(double[] arr) //для заполнения одномерного массива
        {
            Console.WriteLine("Заполните массив числами ");
            int i = 0;
            while (true)
            {
                Console.Write("Введите " + (i + 1) + " элемент массива ");
                if (double.TryParse(Console.ReadLine(), out double number))
                {
                    arr[i] = number;
                    i++;
                    if (i == 5) break;
                }
                else
                    Console.WriteLine("Не корректный ввод элемента массива");
            }
        }
        static void showOneDimensionalArray(double[] arr) //для вывода одномерного массива
        {
            Console.WriteLine("Исходный одномерный массив A ");
            foreach (double item in arr)
                Console.Write(item + "\t");
        }
        static void fillTwoDimensionalArray(double[,] arr) //для заполнения двумерного массива
        {
            Random rand = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                    arr[i, j] = Math.Round(rand.NextDouble() * (5 - 1) + 1, 2); //от 1 до 5
            }
        }
        static void showTwoDimensionalArray(double[,] arr) //для вывода двумерного массива
        {
            Console.WriteLine("\nИсходный двумерный массив B ");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                    Console.Write(arr[i, j] + "\t");
                Console.WriteLine();
            }
        }
        /*Задание 1
        Объявить одномерный (5 элементов) массив с именем A и двумерный массив (3 строки, 4 столбца) дробных чисел с именем B.  Заполнить одномерный массив А 
        числами, введенными с клавиатуры пользователем, а двумерный массив В случайными числами с помощью циклов. Вывести на экран значения массивов:
        массива А в одну строку, массива В — в виде матрицы. Найти в данных массивах общий максимальный элемент, минимальный элемент, общую сумму всех элементов, 
        общее произведение всех элементов, сумму четных элементов массива А, сумму нечетных столбцов массива В.*/
        static void task1()
        {
            double[] arr1 = new double[5];
            fillOneDimensionalArray(arr1);
            showOneDimensionalArray(arr1);
            double[,] arr2 = new double[3, 4];
            fillTwoDimensionalArray(arr2);
            showTwoDimensionalArray(arr2);
            //arr1.Intersect(arr2.Cast<double>()) - нахожу общие элементы двух массивов
            if (arr1.Intersect(arr2.Cast<double>()).Count() > 0)
            {
                Console.WriteLine("Общий максимальный элемент двух массивов равен " + arr1.Intersect(arr2.Cast<double>()).Max()); //и далее, если общие элементы есть, то нахожу максимальный
                Console.WriteLine("Общий минимальный элемент двух массивов равен " + arr1.Intersect(arr2.Cast<double>()).Min()); //и минимальный            
            }
            else
                Console.WriteLine("Общих элементов в двух массивах нет");
            Console.WriteLine("Сумма элементов массива A равна " + arr1.Sum());
            Console.WriteLine("Сумма элементов массива B равна " + arr2.Cast<double>().Sum());
            Console.WriteLine("Общая сумма элементов двух массивов равна " + (arr1.Sum() + arr2.Cast<double>().Sum()));
            Console.WriteLine("Произведение элементов массив A  " + arr1.Aggregate((x, y) => x * y));
            Console.WriteLine("Произведение элементов массив B  " + arr2.Cast<double>().Aggregate((x, y) => x * y));
            Console.WriteLine("Общее произведение элементов двух массивов равна  " + (arr1.Aggregate((x, y) => x * y) * arr2.Cast<double>().Aggregate((x, y) => x * y)));
            Console.WriteLine("Сумма четных элементов массива A равна " + arr1.Where(i => i % 2 == 0).Sum());
            Console.WriteLine("Сумма не четных столбцов (нумерация столбцов начинается с 1) массива B равна " + arr2.Cast<double>().Where((number, index) => (index++ % 2) == 0).Sum());
        }
        /*Задание 2
        Дан двумерный массив размерностью 5×5, заполненный случайными числами из диапазона от –100 до 100.
        Определить сумму элементов массива, расположенных между минимальным и максимальным элементами.*/
        static void task2()
        {
            int[,] arr = new int[5, 5];
            Random rand = new Random();
            Console.WriteLine("Исходный массив ");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rand.Next(-100, 101); //101 не включается в диапазон
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
            int[] tempArr = arr.Cast<int>().ToArray(); //Перегоняю элементы из двумерного массива в одномерный
            int indexMax = Array.IndexOf(tempArr, tempArr.Max()); //Нахожу индекс максимального элемента массива
            int indexMin = Array.IndexOf(tempArr, tempArr.Min()); //Нахожу индекс минимального элемента массива
            Console.WriteLine("Максимальный элемент массива {0}. Его индекс {1}", tempArr.Max(), indexMax);
            Console.WriteLine("Минимальный элемент массива {0}. Его индекс {1}", tempArr.Min(), indexMin);
            Console.WriteLine("Сумма элементов массива, расположенных между минимальным и максимальным элементами\n(максимальным и минимальный элемент в расчет не включаются) равна " + tempArr.Where((n, i) => i > Math.Min(indexMax, indexMin) && i < Math.Max(indexMax, indexMin)).Sum());
        }
        static void Main(string[] args)
        {
            task1();
            Console.WriteLine("=================================================================================");
            task2();
        }
    }
}
