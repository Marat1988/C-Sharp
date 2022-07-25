using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork11_12
{
    class Program
    {
        static void showArray<T>(T[] arr)
        {
            foreach (T item in arr)
                Console.Write(item + "\t");
        }
        /*1. Написать программу, которая предлагает пользователю ввести число и считает, сколько раз это число
        встречается в массиве.*/
        static void task1()
        {
            int[] arr = { 5, 6, 7, 8, 9, 9, 4, 6, 7, 8, 9, 1, 5 };
            Console.WriteLine("Исходный массив ");
            showArray(arr);
            Console.Write("\nВведите число для поиска в массиве ");
            Console.WriteLine((int.TryParse(Console.ReadLine(), out int number)) ? ("Число встречается в массиве " + arr.Where(i => i == number).Count() + " раз") : ("Вы ввели не число"));

        }
        static void Main(string[] args)
        {
            task1();
            Console.WriteLine("=============================================================================");
        }
    }
}
