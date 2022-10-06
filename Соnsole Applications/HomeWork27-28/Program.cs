using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork27_28
{
    class Program
    {
        /*Задание 1. Игра «Автомобильные гонки»
         * Разработать игру "Автомобильные гонки" с использованием делегатов.
         * 1. В игре использовать несколько типов автомобилей: спортивные, легковые, грузовые и автобусы.
         * 2. Реализовать игру «Гонки». Принцип игры: Автомобили двигаются от старта к финишу со скоростями, которые 
         * изменяются в установленных пределах случайным образом. Победителем считается автомобиль, пришедший к финишу первым.
         * Рекомендации по выполнению работы
         * 1. Разработать абстрактный класс «автомобиль» (класс Car). Собрать в нем все общие поля, 
         * свойства (например, скорость) методы (например, ехать).
         * 2. Разработать классы автомобилей с конкретной реализацией конструкторов и методов, свойств.
         * В классы автомобилей добавить необходимые события (например, финиш).
         * 3. Класс игры должен производить запуск соревнований автомобилей, выводить сообщения о текущем положении автомобилей,
         * выводить сообщение об автомобиле, победившем в гонках. Создать делегаты, обеспечивающие вызов методов из классов автомобилей (например, выйти на старт, начать гонку).
         * 4. Игра заканчивается, когда какой-то из автомобилей проехал определенное расстояние (старт в положении 0, финиш в положении 100). 
         * Уведомление об окончании гонки (прибытии какого-либо автомобиля на финиш) реализовать с помощью событий.*/

        public delegate void CarEventHandler();
        public static Random rand = new Random();
        //Абстрактный класс Автомобиль
        public abstract class Car
        {
            public string Name { get; set; } //Марка автомобиля (Toyota, ferrari и прочее)
            public int MaxSpeed { get; set; } //Максимальная скорость
            public int DrivenDistance { get; set; } = 0; //Пройденное расстояние
            public abstract void GoDrive(); //Метод ехать
        }
        //Автобус
        public class Bus : Car
        {
            public event CarEventHandler Finish;
            public override void GoDrive()
            {
                int distancePerSec = rand.Next(1, MaxSpeed);
                DrivenDistance += distancePerSec;
                if (DrivenDistance >= 100)
                    Finish();
            }
        }
        //Легковой автомобиль
        public class PassengerCar : Car
        {
            public event CarEventHandler Finish;
            public override void GoDrive()
            {
                int distancePerSec = rand.Next(1, 10);
                DrivenDistance += distancePerSec;
                if (DrivenDistance >= 100)
                    Finish();
            }
        }
        //Спортивный автомобиль
        public class SportsCar : Car
        {
            public event CarEventHandler Finish;
            public override void GoDrive()
            {
                int distancePerSec = rand.Next(1, 10);
                DrivenDistance += distancePerSec;
                if (DrivenDistance >= 100)
                    Finish();
            }
        }
        //Грузовой автомобиль
        public class Truck : Car
        {
            public event CarEventHandler Finish;
            public override void GoDrive()
            {
                int distancePerSec = rand.Next(1, MaxSpeed);
                DrivenDistance += distancePerSec;
                if (DrivenDistance >= 100)
                    Finish();
            }
        }
        //Класс запуска игры
        public class Game
        {
            public void StartRace()
            {
                SportsCar sportsCar = new SportsCar() { MaxSpeed = 10, Name = "Toyota Supra" };
                PassengerCar passengerCar = new PassengerCar() { MaxSpeed = 10, Name = "Lada Granta" };
                Truck truck = new Truck() { MaxSpeed = 3, Name = "Камаз 6520" };
                Bus bus = new Bus() { MaxSpeed = 5, Name = "НефАЗ-5299" };

                sportsCar.Finish += () => Console.WriteLine($"{ sportsCar.Name} {sportsCar.GetType().Name} доехал до финиша первым");
                passengerCar.Finish += () => Console.WriteLine($"{ passengerCar.Name} {passengerCar.GetType().Name} доехал до финиша первым");
                truck.Finish += () => Console.WriteLine($"{ truck.Name} {truck.GetType().Name} доехал до финиша первым");
                bus.Finish += () => Console.WriteLine($"{ bus.Name} {bus.GetType().Name} доехал до финиша первым");

                int countSec = 1;
                Console.WriteLine("Время (cек)\t\tSportsCar\tPassengerCar\tTruck\t\tBus");
                Console.WriteLine("================================================================================");
                while (!(sportsCar.DrivenDistance >= 100 || passengerCar.DrivenDistance >= 100 || truck.DrivenDistance >= 100 || bus.DrivenDistance >= 100))
                {
                    sportsCar.GoDrive();
                    passengerCar.GoDrive();
                    truck.GoDrive();
                    bus.GoDrive();
                    Console.WriteLine("{0}\t\t\t{1}m\t\t{2}m\t\t{3}m\t\t{4}m", countSec++, sportsCar.DrivenDistance, passengerCar.DrivenDistance, truck.DrivenDistance, bus.DrivenDistance);
                    if (sportsCar.DrivenDistance >= 100 || passengerCar.DrivenDistance >= 100 || truck.DrivenDistance >= 100 || bus.DrivenDistance >= 100)
                        break;
                }
            }
        }
        static void Main(string[] args)
        {
             Game game = new Game();
             game.StartRace();
             Console.ReadKey();
        }
    }
}
