using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*1.Даны целые положительные числа A, B, C. Значение
этих чисел программа должна запрашивать у пользователя. На прямоугольнике размера A*B размещено
максимально возможное количество квадратов со
стороной C. Квадраты не накладываются друг на
друга. Найти количество квадратов, размещенных на
прямоугольнике, а также площадь незанятой части
прямоугольника.
Необходимо предусмотреть служебные сообщения
в случае, если в прямоугольнике нельзя разместить ни
одного квадрата со стороной С (например, если значение С превышает размер сторон прямоугольника).

2. Начальный вклад в банке равен 10000 руб. Через
каждый месяц размер вклада увеличивается на P
процентов от имеющейся суммы (P — вещественное
число, 0 < P < 25). Значение Р программа должна получать у пользователя. По данному P определить через
сколько месяцев размер вклада превысит 11000 руб,
и вывести найденное количество месяцев K (целое
число) и итоговый размер вклада S (вещественное
число).*/

namespace HomeWork5_6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Задание 1*/
            Console.WriteLine("Задание 1");
            try
            {
                Console.Write("Введите длину прямоугольника (сторона А) ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите ширину прямоугольника (сторона B) ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите размер сторон квадрата ");
                int c = Convert.ToInt32(Console.ReadLine());
                if (c > a || c > b)
                {
                    Console.WriteLine("Квадрат нельзя поместить в треугольник");
                }
                else
                {
                    int numberSquares = (a / c) * (b / c);
                    Console.WriteLine($"На прямоугольнике можно разместить {numberSquares} квадратов");
                    Console.WriteLine($"Не занятая площадь прямоугольника равна {a * b - numberSquares * Math.Pow(c, 2)}");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка при преобразовании данных");
            }
            catch (Exception)
            {
                Console.WriteLine("Не известная ошибка");
            }
            /*Задание 2*/
            Console.WriteLine("Задание 2");
            Console.WriteLine("Начальный вклад в банке равен 10000 руб");
            double deposit = 10000;
            try
            {
                Console.Write("Введите процент ");
                if (double.TryParse(Console.ReadLine(), out double persent))
                {
                    if (persent <= 0 || persent > 25)
                    {
                        Console.WriteLine("Не корректный ввод размера процента. Размер процента должен быть 0 < P < 25, где Р - это размер процента");
                    }
                    else
                    {
                        int countMonth = 0;
                        while (deposit <= 11000)
                        {
                            countMonth++;
                            deposit += (deposit * persent / 100);
                        }
                        Console.WriteLine($"Количество месяцев, через который размер вклада превысит 11000 руб. составляет {countMonth}. Итоговый размер вклада {Math.Round(deposit, 2)}");
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка при преобразовании вещественного числа");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Не известная ошибка");
            }
            Console.ReadKey();
        }
    }
}
