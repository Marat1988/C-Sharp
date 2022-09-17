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
            public DateTime DateIssue { get; set; } //дата выдачи

            public ForeignPassport (string lastName, int number, DateTime dateIssue)
            {
                if (lastName.ToCharArray().Where(symbol => char.IsDigit(symbol)).Count() > 0)
                    throw new Exception("В фамилии не могу содержаться цифры");
                if (lastName == null)
                    throw new ArgumentNullException(nameof(LastName));
                if (number <= 0)
                    throw new Exception("Значение номера паспорта не может быть меньше нуля");
                this.lastName = lastName;
                this.number = number;
                DateIssue = dateIssue;
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
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();


        }
    }
}
