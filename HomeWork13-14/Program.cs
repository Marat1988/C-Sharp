using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Задание 1
Объявить одномерный (5 элементов) массив с именем A и двумерный массив (3 строки, 4 столбца) дробных чисел с именем B. 
Заполнить одномерный массив А числами, введенными с клавиатуры пользователем, а
двумерный массив В случайными числами с помощью
циклов. Вывести на экран значения массивов: массива
А в одну строку, массива В — в виде матрицы. Найти в
данных массивах общий максимальный элемент, минимальный элемент, общую сумму всех элементов, общее
произведение всех элементов, сумму четных элементов
массива А, сумму нечетных столбцов массива В.
*/
namespace HomeWork13_14
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] arr = { 1, 2, 3, 4, 5 };
            long[,] arr2 = new long[4, 5]
            {
                { 1,2,3,4,5},
                { 6,7,8,9,10},
                { 1,2,3,4,5},
                { 6,7,8,9,10}
            };
            if (arr.Intersect(arr2.Cast<long>()).Count()>0)
            {
                Console.WriteLine("Общий максимальный элемент двух массивов равен " + arr.Intersect(arr2.Cast<long>()).Max());
                Console.WriteLine("Общий минимальный элемент двух массивов равен " + arr.Intersect(arr2.Cast<long>()).Min());
                Console.WriteLine("Общая сумма элементов двух массивов равна " + arr.Sum() + arr2.Cast<long>().Sum());
                Console.WriteLine("Общая произведение элементов двух массивов равна  " + arr.Aggregate((x, y) => x * y) * arr2.Cast<long>().Aggregate((x, y) => x * y));
                Console.WriteLine("Сумма четных элементов массива arr равна " + arr.Where(i => i % 2 == 0).Sum());
                Console.WriteLine("Сумма не четных столбцов массива B " + arr2.Cast<long>().Where((n, i) => (i++ % 2) == 0).Sum());
            }
            else
            {
                Console.WriteLine("Не содержит общих элементов");
            }

            /*Random rnd = new Random(DateTime.Now.Millisecond);
            long[] msv = (new long[10]).Select(i => rnd.Next(-5, 6)).ToArray();
            Console.WriteLine("Исходный массив:");
            foreach (long i in msv) Console.Write("{0} ", i);
            var sum1 = msv.Where((n, i) => (i++ % 2) == 0).Sum();
            Console.Write("\n\nCуммa элементов массива с нечетными номерами: {0}\n\n", sum1);*/
        }
    }
}
