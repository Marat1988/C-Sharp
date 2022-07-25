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
            for (int i = 0; i < arr.GetUpperBound(0) + 1; i++) 
            {
                for (int j = 0; j < arr.GetUpperBound(1) + 1; j++)
                    Console.Write(arr[i,j] + "\t");
                Console.WriteLine();
            }
        }
        static void fillTwoDimensionalArray(int [,] arr) //для звполнения двумерного массива
        {
            Random rand = new Random();
            for (int i = 0; i < arr.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < arr.GetUpperBound(1) + 1; j++)
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
            Console.WriteLine((int.TryParse(Console.ReadLine(), out int number)) ? "Число встречается в массиве " + arr.Where(i => i == number).Count() + " раз" : "Вы ввели не число");
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
                    for (int i = 0; i < arr.GetUpperBound(0) + 1; i++)
                        (arr[i, 2], arr[i, 5]) = (arr[i, 5], arr[i, 2]);
                    Console.WriteLine("Конечный массив ");
                    showTwoDimensionalArray(arr);
                }
                else
                    Console.WriteLine("Число строк или столбцов должно быть больше нуля");
            }
            else
                Console.WriteLine("Не корректный ввод номера строк или столбцов");
        }
        static void Main(string[] args)
        {
            //task1();
            Console.WriteLine("===========================================================");
            task2();
        }
    }
}
