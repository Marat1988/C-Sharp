using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Задание 1

Создайте класс заказы (свойства: номер накладной, дата заказа, клиент, код города, телефон, город, количество, стоимость).
Создайте коллекцию из не менее 10 заказов.
1.	Найдите всех клиентов, у которых были заказы, превосходящие по сумме величину X
2.	Найти самый дорогой заказ, самый дешевый. Посчитать сумму всех продаж и среднюю стоимость всех заказов, среднюю цену одного товар (сумма всех стоимостей/сумму всех товаров).
3.	Для каждого клиента составьте список заказов. Сделайте задания с использованием группировки с сортировкой и без.
4.	Сгруппируйте всех клиентов сначала по городам затем по стоимости заказа.
5.	Сгруппируйте всех клиентов по коду города c помощью вложенного запроса.
6.	Сгруппируйте заказы по группам «дешевые», «средняя цена», «дорогие». Границы каждой группы задайте сами.
7.	Добавьте к городу название страны (создайте новые поля).
8.	Создайте новое поле: цена 1 единицы товара (стоимость / на количество) 
9.	Сгруппируйте все продажи по кварталам.
10.	Рассчитайте среднюю стоимость заказов каждого города */
namespace HomeWork29_30
{
    class Program
    {
        public class Order
        {
            public int NumberInvoice { get; set; }
            public DateTime Date { get; set; }
            public string Customer { get; set; }
            public int KodCity { get; set; }
            public int Telephone { get; set; }
            public string City { get; set; }
            public int Num { get; set; }
            public int Price { get; set; }
            public Order(int numberInvoice, DateTime date, string customer, int kodCity, int telephone, string city, int num, int price)
            {
                NumberInvoice = numberInvoice;
                Date = date;
                Customer = customer;
                KodCity = kodCity;
                Telephone = telephone;
                City = city;
                Num = num;
                Price = price;
            }
            public override string ToString() => $"NumberInvoice:{NumberInvoice}, Date:{Date}, Customer:{Customer}, KodCity:{KodCity}, Telephone:{Telephone}, City:{City}, Num:{Num}, Price:{Price}";
        }

        static void Main(string[] args)
        {
            var orders = new[]
           {
                new Order(1,new DateTime(2021, 1, 1), "Apple",  7, 123456789, "Moscow", 12, 237000 ),
                new Order(2, new DateTime(2021, 2, 1), "Yandex", 7, 123456789, "Moscow", 12, 43000),
                new Order(3, new DateTime(2021, 3, 1), "Microsoft", 1, 123456789, "NewYork", 122, 53000),
                new Order(4, new DateTime(2021, 4, 1), "Google", 1, 123456789, "NewYork", 312, 63000),
                new Order(5, new DateTime(2021, 5, 1), "Google", 0, 123456789, "London", 125, 73000),
                new Order(6, new DateTime(2022, 6, 1), "Apple", 0, 123456789, "London", 232, 83000),
                new Order(7, new DateTime(2021, 7, 1), "Yandex", 2, 123456789, "Paris", 125, 93000),
                new Order(8, new DateTime(2021, 8, 1), "Microsoft", 2, 123456789, "Paris", 512, 123000),
                new Order(9, new DateTime(2022, 9, 1), "Apple", 3, 123456789, "Toronto", 612, 223000),
                new Order(10, new DateTime(2021,10, 1),"Google", 3, 123456789, "Toronto", 712, 243000),
                new Order(11, new DateTime(2021,11, 1),"Microsoft", 7, 123456789, "Moscow", 812, 231000),
            };

            Console.WriteLine("Полный список");
            foreach (var item in orders)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("==========================================================================================");
            Console.WriteLine("Пункт 1. Клиенты, сумма которых превывает 100000");
            var ordersClient = orders.Where(sales => sales.Price > 100000).Select(sales => sales.Customer).Distinct();
            foreach (var item in ordersClient)
                Console.WriteLine(item);
            Console.WriteLine("==========================================================================================");

            Console.WriteLine("Пункт 2");
            Console.WriteLine("Самый дорогой заказ по цене (Price) равен " + orders.Max(sales => sales.Price));
            Console.WriteLine("Самый дешевый заказ по цене (Price) равен " + orders.Min(sales => sales.Price));
            Console.WriteLine("Сумма продаж равна " + orders.Sum(sales => sales.Price * sales.Num));
            Console.WriteLine("Средняя стоимость всех заказов " + orders.Average(sales => sales.Price));
            Console.WriteLine("Средняя цена на один товар " + orders.Sum(sales => sales.Price * sales.Num) / orders.Sum(sales => sales.Price)); //Не уверен, правильная ли формула
            Console.WriteLine("==========================================================================================");

            Console.WriteLine("Пункт 3");
            Console.WriteLine("Групировка и сортировка");
            var orderGroupSort = orders.OrderBy(sales => sales.Customer).GroupBy(sales => sales.Customer);
            foreach (var cust in orderGroupSort)
            {
                Console.WriteLine("{0} - {1}", cust.Key, cust.Count());
                foreach (var c in cust)
                {
                    Console.WriteLine("\t{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}", c.NumberInvoice, c.Date, c.KodCity, c.Telephone, c.City, c.Num, c.Price);
                }
            }
            Console.WriteLine("Без сортировки");
            var orderGroup = orders.GroupBy(sales => sales.Customer);
            foreach (var cust in orderGroup)
            {
                Console.WriteLine("{0} - {1}", cust.Key, cust.Count());
                foreach (var c in cust)
                {
                    Console.WriteLine("\t{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}", c.NumberInvoice, c.Date, c.KodCity, c.Telephone, c.City, c.Num, c.Price);
                }
            }
            Console.WriteLine("==========================================================================================");

            Console.WriteLine("Пункт 4");
            var orderGroupCityPrice = orders.GroupBy(sales => sales.City);
            foreach (var city in orderGroupCityPrice)
            {
                Console.WriteLine("{0} - {1}", city.Key, city.Count());
                foreach (var price in city.GroupBy(sales => sales.Price))
                {
                    Console.WriteLine("\tЦена: {0}", price.Key);
                    foreach (var item in price)
                    {
                        Console.WriteLine("\t\t{0}\t{1}\t{2}\t{3}\t{4}", item.NumberInvoice, item.Date, item.KodCity, item.Telephone, item.Num);
                    }
                }
            }
            Console.WriteLine("==========================================================================================");

            Console.WriteLine("Пункт 5");
            var clients = from person in orders
                             group person by person.KodCity into g
                             select new
                             {
                                 Code = g.Key,
                                 Count = g.Count(),
                                 OrderClients = from p in g select p
                             };
            foreach (var item in clients)
            {
                Console.WriteLine("Код города: {0} - Количество: {1}", item.Code, item.Count);
                foreach (var cust in item.OrderClients)
                {
                    Console.WriteLine("\t\t{0}\t{1}\t{2}", cust.NumberInvoice, cust.Date, cust.Customer);
                }
                Console.WriteLine();
            }
            Console.WriteLine("==========================================================================================");

            Console.WriteLine("Пункт 6");
            var ordersPrice = orders.GroupBy(order =>
            {
                if (order.Price < 45000)
                    return "Дешевые по цене:";
                if (order.Price >= 45000 && order.Price <= 95000)
                    return "Средние по цене:";
                if (order.Price > 95000)
                    return "Дорогие по цене:";
                return "Группа не определена";
            });
            foreach (var cust in ordersPrice)
            {
                Console.WriteLine("{0} - {1}", cust.Key, cust.Count());
                foreach (var c in cust)
                    Console.WriteLine("\t{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}", c.NumberInvoice, c.Date, c.KodCity, c.Telephone, c.City, c.Num, c.Price);
            }
            Console.WriteLine("==========================================================================================");

            Console.WriteLine("Пункт 7");
            var newField = from c in orders
                           let city = c.City
                           let country = (c.City == "Moscow") ? "Россия" : (c.City == "Paris") ? "Франция" : (c.City == "London") ? "Англия" : (c.City == "NewYork") ? "США" : "Канада"
                           let numberInvoce = c.NumberInvoice
                           let count = c.Num
                           let price = c.Price
                           select new
                           {
                               City = city,
                               Country = country,
                               NumberInvoce = numberInvoce,
                               Count = count,
                               Price = price

                           };
            foreach (var item in newField)
            {
                Console.WriteLine("{0}  {1}  {2}  {3}  {4}", item.City, item.Country, item.NumberInvoce, item.Count, item.Price);
            }
            Console.WriteLine("==========================================================================================");

            Console.WriteLine("Пункт 8");
            var newField2 = from c in orders
                           let number = c.NumberInvoice
                           let date = c.Date
                           let count = c.Num
                           let price = c.Price
                           let costDividedQuantity = c.Price/c.Num //Стоимость деленное на количество
                           select new
                           {
                               Number = number,
                               Date = date,
                               Count = count,
                               Price = price,
                               CostDividedQuantity = costDividedQuantity
                           };
            foreach (var item in newField2)
            {
                Console.WriteLine("\t{0}\t{1}\t{2}\t{3}\t{4}", item.Number,item.Date,item.Count,item.Price,item.CostDividedQuantity);
            }
            Console.WriteLine("==========================================================================================");

            Console.WriteLine("Пункт 9");
            var salesQuarter = orders.GroupBy(order =>
            {
                if (order.Date.Month >= 1 && order.Date.Month <= 3)
                    return "1 квартал";
                if (order.Date.Month >= 4 && order.Date.Month <= 6)
                    return "2 квартал";
                if (order.Date.Month >= 7 && order.Date.Month <= 9)
                    return "3 квартал";
                return "4 квартал";
            });
            foreach (var cust in salesQuarter)
            {
                Console.WriteLine("{0}. Количество заказов -  {1}", cust.Key, cust.Count());
                foreach (var c in cust)
                    Console.WriteLine("\t{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}", c.NumberInvoice, c.Date, c.KodCity, c.Telephone, c.City, c.Num, c.Price);
            }
            Console.WriteLine("==========================================================================================");

            Console.WriteLine("Пункт 10");

            var GroupCityAverage = from p in orders
                               group p by p.City into g
                               select new { Name = g.Key, Count = g.Count(), AverageCity = g.Average(price => price.Price) };
            foreach (var city in GroupCityAverage)
            {
                Console.WriteLine($"Город: {city.Name}\tСредняя стоимость: (Price): {city.AverageCity}");
            }
            Console.WriteLine("==========================================================================================");
            Console.ReadKey();
        }
    }
}
