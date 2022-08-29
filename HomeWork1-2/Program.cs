using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Задание 1
Пользователь вводит с клавиатуры число в диапазоне от 1 до 100. Если число кратно 3 (делится на 3 без
остатка) нужно вывести слово Fizz. Если число кратно 5
нужно вывести слово Buzz. Если число кратно 3 и 5 нужно
вывести Fizz Buzz. Если число не кратно не 3 и 5 нужно
вывести само число.
Если пользователь ввел значение не в диапазоне от 1
до 100 требуется вывести сообщение об ошибке.

Задание 2
Пользователь вводит с клавиатуры два числа. Первое
число — это значение, второе число процент, который
необходимо посчитать. Например, мы ввели с клавиатуры
90 и 10. Требуется вывести на экран 10 процентов от 90.
Результат: 9.*/

namespace HomeWork1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Задание 1*/
            Console.WriteLine("Задание 1");
            double number = 0;
            while (true)
            {
                Console.Write("Введите число (от 1 до 100) либо наберите 1234 для выхода из цикла: ");
                try
                {
                    number = Convert.ToDouble(Console.ReadLine());
                    if (number == 1234) break;
                    if (number >= 1 && number <= 100)
                    {
                        if (number % 3 == 0 && number % 5 == 0)
                        {
                            Console.WriteLine("Fizz Buzz");
                        }
                        else
                        {
                            if (number % 3 == 0) Console.WriteLine("Fizz");
                            if (number % 5 == 0) Console.WriteLine("Buzz");
                        }
                        if (number % 3 != 0 && number % 5 != 0) Console.WriteLine($"Вы ввели число {number}");
                    }
                    else
                    {
                        Console.WriteLine("Не допустимый диапазон ввода числа");
                    }
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Вы ввели не число");
                }
                catch (Exception)
                {
                    Console.WriteLine("Не известная ошибка");
                }
            }
            Console.WriteLine("Задание 2");
            /*Задание 2*/
            try
            {
                Console.Write("Введите число ");
                decimal number2 = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Введите процент ");
                decimal percent = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("{0} процента от числа {1} равно " + (number2 * percent / 100), percent, number2);
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Вы ввели не число");
            }
            catch (Exception)
            {
                Console.WriteLine("Не известная ошибка");
            }
            Console.ReadKey();
        }
    }
}
