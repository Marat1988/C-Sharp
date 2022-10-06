using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Ранее в одном из практических заданий вы создавали класс «Журнал».
 Добавьте к уже созданному классу информацию о количестве сотрудников. Выполните перегрузку
 + (для увеличения количества сотрудников на указанную величину),
 — (для уменьшения количества сотрудников на указанную величину),
 == (проверка на равенство количества сотрудников),
 < и > (проверка на меньше или больше количества сотрудников),
 != и Equals. Используйте механизм свойств для полей класса
 (название журнала, год основания, описание журнала, контактный телефон, контактный e-mail).*/

namespace Task1_HomeWork19_20
{
    class Program
    {
        class Journal
        {
            private int countPeople = 0; //Количество сотрудников
            public string Name { get; set; } //Название журнала
            public int Year { get; set; } //Год основания
            public string Description { get; set; } //Описание журнала
            public string TelephoneNumber { get; set; } //Контанктный телефон
            public string Email { get; set; } //Контактный e-mail
            public Journal(int countPeople, string name, int year, string description, string telephoneNumber, string email)
            {
                if (countPeople < 0)
                    Console.WriteLine("Количество сотрудников в жернале не может быть меньше нуля. Будет присвоено значение равное нулю");
                else
                    this.countPeople = countPeople;
                Name = name;
                Year = year;
                Description = description;
                TelephoneNumber = telephoneNumber;
                Email = email;
            }
            public int CountPeople
            {
                get
                {
                    return countPeople;
                }
                set
                {
                    if (value < 0)
                        Console.WriteLine("Количество сотрудников в жернале не может быть меньше нуля");
                    else
                        countPeople = value;
                }
            }
            public static Journal operator+(Journal journal, int countPeople) //Перегрузка оператора +
            {
                journal.CountPeople += countPeople;
                return journal;
            }
            public static Journal operator+(int countPeople, Journal journal) //Перегрузка оператора +
            {
                journal.CountPeople += countPeople;
                return journal;
            }
            public static Journal operator-(Journal journal, int countPeople) //Перегрузка оператора -
            {
                journal.CountPeople = (journal.CountPeople < countPeople) ? 0 : (journal.CountPeople - countPeople);
                return journal;
            }
            public static Journal operator -(int countPeople, Journal journal) //Перегрузка оператора -
            {
                journal.CountPeople = (journal.CountPeople < countPeople) ? 0 : (journal.CountPeople - countPeople);
                return journal;
            }
            public static bool operator ==(Journal journal_1, Journal journal_2) => journal_1.Equals(journal_2); //Перегрузка оператора ==
            public static bool operator !=(Journal journal_1, Journal journal_2) => !(journal_1==journal_2); //Перегрузка оператора !=
            public static bool operator >(Journal journal_1, Journal journal_2) => journal_1.CountPeople > journal_2.CountPeople; //Перегрузка оператора >
            public static bool operator <(Journal journal_1, Journal journal_2) => journal_1.CountPeople > journal_2.CountPeople; //Перегрузка оператора <
            public override bool Equals(object obj) => this.ToString() == obj.ToString(); //Перегрузка Equals
            public override int GetHashCode() => this.ToString().GetHashCode();
            public override string ToString()
            {
                return "1. Название журнала: " + Name + "\n" +
                       "2. Год основания: " + Year + "\n" +
                       "3. Описание журнала: " + Description + "\n" +
                       "4. Контактный телефон: " + TelephoneNumber + "\n" +
                       "5. Email: " + Email + "\n" +
                       "6. Всего сотрудников: " + countPeople;
            }
        }

        static void Main(string[] args)
        {
            Journal journal1 = new Journal(45, "Журнал 1", 2022, "Журнал Марата", "+79114753483", "pirat03071988@mail.ru");
            Journal journal2 = new Journal(90, "Журнал 2", 2022, "Журнал Максима", "999999", "max@mail.ru");
            Console.WriteLine(journal1.ToString());
            Console.WriteLine();
            Console.WriteLine(journal2.ToString());
            Console.WriteLine();
            Console.WriteLine($"journal1 > journal2 {journal1 > journal2}");
            Console.WriteLine($"journal1 < journal2 {journal1 < journal2}");
            Console.WriteLine($"journal1 == journal2 {journal1 == journal2}");
            Console.WriteLine($"journal1 != journal2 {journal1 != journal2}");
            Console.WriteLine("==========================================");
            Console.WriteLine("Прибавляем к журналу 1 43 сотрудника");
            journal1 += 43;
            Console.WriteLine("Уменьшаем из журнала 2 двух сотрудников");
            journal2 -= 2;
            Console.WriteLine();
            Console.WriteLine(journal1.ToString());
            Console.WriteLine();
            Console.WriteLine(journal2.ToString());
            Console.WriteLine();
            Console.WriteLine("Создаем новый журнал (копия журнала 2)");
            Journal journal3 = journal2;
            Console.WriteLine(journal3.ToString());
            Console.WriteLine();
            Console.WriteLine($"journal3 == journal2 {journal3 == journal2}");
            Console.ReadKey();
        }
    }
}
