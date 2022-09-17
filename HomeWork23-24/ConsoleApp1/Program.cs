using System;


namespace ConsoleApp1
{
    class Program
    {
        /*Задание 1
         * Пользователь вводит в строку с клавиатуры логическое выражение. 
         * Например, 3>2 или 7<3. Программа должна посчитать результат 
         * введенного выражения и дать результат true или false. В строке могут быть 
         * только целые числа и операторы: <, >, <=, >=, ==, !=. Для обработки 
         * ошибок ввода используйте механизм исключений.*/
        public class MyStringException : ApplicationException //Мое собственное исключение
        {
            public DateTime TimeException { get; private set; }
            public MyStringException() : base("Не корректный ввод строки")
            {
                TimeException = DateTime.Now;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку, например 3>2. В строке могут быть только целые числа и операторы: <, >, <=, >=, ==, != ");
            string str = Console.ReadLine();
            string strOperator = string.Empty;
            int indexOperator = -1;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '>' || str[i] == '<' || str[i] == '!' || str[i] == '=') //Ищу один из символов в строке
                {
                    indexOperator = i; //И получаю его индекс
                    break;
                }
            }
            if (indexOperator == 0 || indexOperator == -1)
                throw new MyStringException();
            else
            {
                try
                {
                    int number1 = int.Parse(str.Substring(0, indexOperator));
                    strOperator += str[indexOperator];
                    if (str[indexOperator + 1] == '=') //Проверяю следующий символ с строке (для того, чтобы понять, есть ли в строке операторы >= <= == != )
                    {
                        strOperator += str[indexOperator + 1];
                        indexOperator += 1;
                    }
                    int number2 = int.Parse(str.Substring(indexOperator + 1, str.Length - 1 - indexOperator));
                    switch (strOperator)
                    {
                        case ">":
                            Console.WriteLine(number1 > number2);
                            break;
                        case "<":
                            Console.WriteLine(number1 < number2);
                            break;
                        case "<=":
                            Console.WriteLine(number1 <= number2);
                            break;
                        case ">=":
                            Console.WriteLine(number1 >= number2);
                            break;
                        case "==":
                            Console.WriteLine(number1 >= number2);
                            break;
                        case "!=":
                            Console.WriteLine(number1 >= number2);
                            break;
                        default: throw new MyStringException();
                    }
                }
                catch (MyStringException my)
                {
                    Console.WriteLine(my.Message);
                    Console.WriteLine(my.TimeException);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.ReadKey();
        }
    }
}
