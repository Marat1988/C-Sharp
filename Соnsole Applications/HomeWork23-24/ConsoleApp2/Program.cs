using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    /*Задание 2
     * Создайте класс «Заграничный паспорт». Вам необходимо хранить информацию
     * о номере паспорта, ФИО владельца, дате выдачи и т.д. Предусмотреть механизмы
     * для инициализации полей класса. Если значение для инициализации неверное, генерируйте исключение.*/
    class Program
    {
        class ForeignPassport
        {
            private string lastName; //ФИО владельца
            private int number; //номер паспорта
            private DateTime dateIssue; //дата выдачи

            public ForeignPassport (string lastName, int number, DateTime dateIssue)
            {
                if (lastName.ToCharArray().Where(symbol => char.IsDigit(symbol)).Count() > 0)
                    throw new Exception("В фамилии не могу содержаться цифры");
                if (number <= 0)
                    throw new Exception("Значение номера паспорта не может быть меньше нуля");
                this.lastName = lastName ?? throw new ArgumentNullException(nameof(LastName));
                this.number = number;
                this.dateIssue = dateIssue;
            }

            public string LastName
            {
                get
                {
                    return lastName;
                }
                set
                {
                    if (value.ToCharArray().Where(symbol => char.IsDigit(symbol)).Count() > 0)
                        throw new Exception("В фамилии не могу содержаться цифры");
                    else
                        lastName = value;
                }
            }

            public int Number
            {
                get
                {
                    return number;
                }
                set
                {
                    if (number <= 0)
                        throw new Exception("Значение номера паспорта не может быть меньше нуля");
                    else
                        number = value;
                }
            }
            public DateTime DateIssue
            {
                get
                {
                    return dateIssue;
                }
                set
                {
                    try
                    {
                        dateIssue = value;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }

            public override string ToString()
            {
                return $"Номер паспорта: {number}\n" +
                    $"Дата выдачи: { DateIssue.ToShortDateString()}\n" +
                    $"ФИО Владельца: {lastName}";
            }
        }
        static void Main(string[] args)
        {
            try
            {
                ForeignPassport foreignPassport = new ForeignPassport("Иванов", 435, new DateTime(2001, 1, 1));
                Console.WriteLine(foreignPassport.ToString());
                Console.WriteLine();
                ForeignPassport foreignPassport1 = new ForeignPassport("Петров", 56, new DateTime(2022, 1, 1));
                Console.WriteLine(foreignPassport1.ToString());
                foreignPassport1.LastName = "Петров11"; //Исключение (в фамилии не могут быть цифры)
                foreignPassport1.Number = -45; //Исключение (не может быть отрицательного значения в номере паспорта)
                foreignPassport1.DateIssue = new DateTime(2022,32,32); //Исключение (не корректная дата)
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();


        }
    }
}
