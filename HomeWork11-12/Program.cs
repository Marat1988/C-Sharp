using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork11_12
{
    class Program
    {
        static void showOneDimensionalArray(int [] arr) //для вывода одномерного массива
        {
            foreach (int item in arr)
                Console.Write(item + "\t");
        }
        static void showTwoDimensionalArray(int[,] arr) //для вывода двумерного массива
        {
            for (int i = 0; i < arr.GetLength(0); i++) 
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                    Console.Write(arr[i,j] + "\t");
                Console.WriteLine();
            }
        }
        static void fillTwoDimensionalArray(int [,] arr) //для заполнения двумерного массива
        {
            Random rand = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                    arr[i, j] = rand.Next(50);
            }
        }
        /*1. Написать программу, которая предлагает пользователю ввести число и считает, сколько раз это число встречается в массиве.*/
        static void task1()
        {
            int[] arr = { 1, 2, 3, 6, 6, 8, 9, 5, 1, 5, 6, 7, 1 };
            Console.WriteLine("Исходный массив ");
            showOneDimensionalArray(arr);
            Console.Write("\nВведите число для поиска в массиве ");
            Console.WriteLine((int.TryParse(Console.ReadLine(), out int number)) ? "Число встречается в массиве " + arr.Where(i => i == number).Count() + " раз/а" : "Вы ввели не число");
        }
        /*2. В двумерном массиве порядка M на N поменяйте местами заданные столбцы.*/
        static void task2()
        {
            Console.Write("Введите количество строк ");
            string userRow = Console.ReadLine();
            Console.Write("Введите количество столбцов ");
            string userCol = Console.ReadLine();
            if (int.TryParse(userRow, out int row) && int.TryParse(userCol, out int col))
            {
                if (row > 0 && col > 0)
                {
                    int[,] arr = new int[row, col];
                    fillTwoDimensionalArray(arr);
                    Console.WriteLine("Исходный массив ");
                    showTwoDimensionalArray(arr);
                    Console.Write("Введите номер первого столбца для обмена (начиная с 1) ");
                    string column1 = Console.ReadLine();
                    Console.Write("Введите номер второго столбца для обмена (начиная с 1) ");
                    string column2 = Console.ReadLine();
                    if (int.TryParse(column1, out int swapColumn1) && int.TryParse(column2, out int swapColumn2))
                    {
                        if (swapColumn1 > 0 && swapColumn2 > 0 && swapColumn1 <= arr.GetLength(1) && swapColumn2 <= arr.GetLength(1))
                        {
                            for (int i = 0; i < arr.GetLength(0); i++)
                                (arr[i, swapColumn1 - 1], arr[i, swapColumn2 - 1]) = (arr[i, swapColumn2 - 1], arr[i, swapColumn1 - 1]); /*Лучшего способа для обмена столбцами не нашел.
                                                                                                                                         Если бы нужно было обменять строки, то тогда можно было использовать Array.Copy*/
                            Console.Write("Конечный массив\n");
                            showTwoDimensionalArray(arr);
                        }
                        else
                            Console.Write("Не корректный ввод номера столбцов.\nНомера столбцов должны быть больше нуля и не превышать фактическом количество столбцов");
                    }
                    else
                        Console.Write("Ошибка ввода. Вы ввели не число");                     
                }
                else
                    Console.Write("Число строк или столбцов должно быть больше нуля");
            }
            else
                Console.Write("Не корректный ввод номера строк или столбцов");
        }
        static void Main(string[] args)
        {
            task1();
            Console.WriteLine("=================================================================================================================");
            task2();
        }
    }
}
