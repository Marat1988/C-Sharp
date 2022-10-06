using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9_10
{
    class Program
    {
        static void showArray<T>(T[] arr)
        {
            foreach (T item in arr)
                Console.Write(item + "\t");
        }
        /*1. Сжать массив, удалив из него все 0 и, заполнить освободившиеся справа элементы значениями –1*/
        static void task1()
        {
            int[] arr = { 1, 6, 7, 9, 0, 6, 0, 5, 6, 0, 9, 0, 6 };
            Console.WriteLine("Изначальный массив ");
            showArray<int>(arr); //Показываю массив на экран
            int masLength = arr.Length; //Узнаю длину массива
            int countZero = arr.Where(i => i == 0).Count(); //Узнаю количество элементов, равное нулю
            arr = arr.Where(i => i != 0).ToArray(); //Удаление из массива элементы, равными нуню
            Array.Resize(ref arr, masLength); //Возвращаю длину массив на первонанальный
            //Заполняю оставшиеся элементы массив -1.
            for (int i = masLength - countZero; i < masLength; i++)
                arr[i] = -1;
            Console.WriteLine("\nКонечный массив ");
            showArray<int>(arr); //Показываю массив на экран
            Console.WriteLine();
        }
        /*2. Преобразовать массив так, чтобы сначала шли все отрицательные элементы, а потом положительные (0 считать положительным)*/
        static void task2()
        {
            //Array.Sort(arr); - либо просто отсортировать.
            /*Или, если сортировать не нужно, а выводить по факту (т.е. сначала идут отрицательные
             * элементы, а  потом положительные), то тогда так.*/
            int[] arr = { 8, 5, -4, -7, 0, 3, 8, 0, -8, -5, 4, 6, 7 };
            Console.WriteLine("Изначальный массив ");
            showArray<int>(arr); //Показываю массив на экран
            int[] tempArr1 = arr.Where(i => i < 0).ToArray(); //Временный массив для хранения отрицательных чисел
            int[] tempArr2 = arr.Where(i => i >= 0).ToArray(); //Временный массив для хранения положительных чисел, включая 0
            Array.ConstrainedCopy(tempArr1, 0, arr, 0, tempArr1.Length); //Копирую отрицательные числа
            Array.ConstrainedCopy(tempArr2, 0, arr, tempArr1.Length, tempArr2.Length); //Копирую положительные числа
            Console.WriteLine("\nКонечный массив ");
            showArray<int>(arr); //Показываю массив на экран
        }
        /*Задание 3 Пользователь вводит фразу, например, Hello World.  
         * Необходимо перевернуть каждое слово в этой фразе. Должно получиться olleH dlroW.*/
        static void ClassWork3()
        {
            Console.Write("Введите фразу, например Hello World ");
            string str = Console.ReadLine();
            string[] st = str.Split(' '); //Загоняю в массив
            for (int i = 0; i < st.Length; i++)
                st[i] = string.Join("", st[i].Reverse().ToArray()); //переворачиваю каждое слово
            Console.WriteLine(string.Join(" ", st)); //Вывожу
        }

        static void Main(string[] args)
        {
            task1();
            Console.WriteLine("=========================================================================================================");
            task2();
            Console.WriteLine("\n=========================================================================================================");
            ClassWork3();
            Console.ReadKey();
        }
    }
}
