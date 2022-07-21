/*Задание 1
Пользователь вводит с клавиатуры три числа. Необходимо подсчитать сколько раз последовательность из этих
трёх чисел встречается в массиве.
Например:
пользователь ввёл: 7 6 5;
массив: 7 6 5 3 4 7 6 5 8 7 6 5;
количество повторений последовательности: 3.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*List - список однотипный объектов. https://metanit.com/sharp/tutorial/4.5.php
             Нужно будет для заполнения массива чисел.*/
            List<int> arr = new List<int>();
            while (true)
            {
                Console.Write("Введите число (от 0 до 9) для добавления в коллекцию или наберите 1234 для выхода ");
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    if (number == 1234) break;
                    else
                    {
                        if (number < 0 || number > 9)
                            Console.WriteLine("Допутимый ввод чисел в от 0 до 9 включительно");
                        else
                            arr.Add(number);
                    }
                }
                else
                    Console.WriteLine("Вы ввели не число");
            }
            if (arr.Count() > 0)
            {
                Console.Write("Итоговый массив ");
                foreach (int item in arr)
                    Console.Write(item + " ");
                string result = string.Join("", arr); //формирую итоговую строку из массива чисел
                int countUserNumbers = 0;
                string resultUserNumbers = "";
                Console.WriteLine("\nВам необходимо будет ввести три числа (от 0 до 9) ");
                while (true)
                {
                    Console.Write("Введите " + (countUserNumbers + 1) + " число ");
                    if (int.TryParse(Console.ReadLine(), out int number))
                    {
                        if (number < 0 || number > 9)
                            Console.WriteLine("Допутимый ввод чисел в от 0 до 9 включительно");
                        else
                        {
                            resultUserNumbers = string.Concat(resultUserNumbers, number.ToString());
                            countUserNumbers++;
                        }
                    }
                    else
                        Console.WriteLine("Вы ввели не число. Повторите ввод ");
                    if (countUserNumbers == 3) break;
                }
                /*Regex.Matches - регулярные выражения. https://metanit.com/sharp/tutorial/7.4.php */
                Console.WriteLine("Количество повторений последовательности чисел " + resultUserNumbers + " в массиве равно " + Regex.Matches(result, resultUserNumbers).Count);
            }
            else
            {
                Console.WriteLine("В массиве не содержаться числа. Продолжение не возможно");
            }
            Console.ReadKey();
        }
    }
}
