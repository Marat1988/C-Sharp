using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Задание 1
Пользователь вводит шестизначное число. После чего
пользователь вводит номера разрядов для обмена цифр.
Например, если пользователь ввёл один и шесть — это
значит, что надо обменять местами первую и шестую
цифры. Число 723895 должно превратиться в 523897.
Если пользователь ввел не шестизначное число требуется вывести сообщение об ошибке.
Задание 2
Пользователь вводит с клавиатуры дату. Приложение должно отобразить название сезона и дня недели.
Например, если введено 22.12.2021, приложение должно
отобразить Winter Wednesday*/
namespace HomeWord3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            try
            {
                Console.WriteLine("Задание 1");
                Console.Write("Введите целое шестизначное число от 100000 до 999999 включительно ");
                string number = Console.ReadLine();
                if (int.TryParse(number, out int resultNumber)) //Проверяю, действительно ли пользователь ввел число
                {
                    if (resultNumber < 100000 || resultNumber > 999999)
                        Console.WriteLine("Вы ввели не шестизначное число");
                    else
                    {
                        Console.Write("Введите первый разряд (от 1 до 6) ");
                        int numberDischarge1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введите второй разряд (от 1 до 6) ");
                        int numberDischarge2 = Convert.ToInt32(Console.ReadLine());
                        if (numberDischarge1 < 1 || numberDischarge1 > 6 || numberDischarge2 < 1 || numberDischarge2 > 6)
                            Console.WriteLine("Не корректный ввод номеров разряда");
                        {
                            char[] charArray = number.ToCharArray();
                            //Кортежи https://metanit.com/sharp/tutorial/2.19.php
                            (charArray[numberDischarge1 - 1], charArray[numberDischarge2 - 1]) = (charArray[numberDischarge2 - 1], charArray[numberDischarge1 - 1]);
                            Console.Write("Итоговое число ");
                            Console.Write(charArray);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Вы ввели не число");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Не известная ошибка");
            }
            //Задание 2
            try
            {
                Console.WriteLine("\nЗадание 2");
                Console.Write("Введите дату, например 22.12.2021 ");
                DateTime dateTime = new DateTime();
                dateTime = Convert.ToDateTime(Console.ReadLine());
                switch (dateTime.Month)
                {
                    case 12:
                    case 1:
                    case 2:
                        Console.Write("Winter"); //Зима
                        break;
                    case 3:
                    case 4:
                    case 5:
                        Console.Write("Spring"); //Весна
                        break;
                    case 6:
                    case 7:
                    case 8:
                        Console.Write("Summer"); //Лето
                        break;
                    case 9:
                    case 10:
                    case 11:
                        Console.Write("Autumn"); //Осень
                        break;
                }
                Console.Write(" " + dateTime.DayOfWeek);
            }
            catch (Exception)
            {
                Console.WriteLine("Не известная ошибка");
            }
            Console.ReadKey();
        }
    }
}
