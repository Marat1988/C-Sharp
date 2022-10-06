using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Задание 1
Реализовать программу “Строительство дома”
Реализовать:
• Классы
 - House (Дом), Basement (Фундамент), Walls (Стены), Door (Дверь), Window (Окно), Roof (Крыша);
 - Team (Бригада строителей), Worker (Строитель), TeamLeader (Бригадир).
• Интерфейсы
 - IWorker, IPart.
Все части дома должны реализовать интерфейс IPart (Часть дома), для рабочих и бригадира предоставляется базовый интерфейс
IWorker (Рабочий). Бригада строителей (Team) строит дом (House). Дом состоит из фундамента (Basement), стен (Wall),
окон (Window), дверей (Door), крыши (Part).
Согласно проекту, в доме должно быть 1 фундамент, 4 стены, 1 дверь, 4 окна и 1 крыша.
Бригада начинает работу, и строители последовательно “строят” дом, начиная с фундамента. Каждый строитель
не знает заранее, на чём завершился предыдущий этап строительства, поэтому он “проверяет”, что
уже построено и продолжает работу. Если в игру вступает бригадир (TeamLeader), он не строит, а формирует отчёт,
что уже построено и какая часть работы выполнена.
В конечном итоге на консоль выводится сообщение, что строительство дома завершено
и отображается “рисунок дома” (вариант отображения выбрать самостоятельно).*/


namespace HomeWork21_22
{

    public interface IPart
    {
        void BuildPart(); //Строить часть дома
    }

    public class Basement : IPart
    {
        private readonly string nameParts = "Фундамент";
        public void BuildPart() => Console.WriteLine("Часть стройки: " + nameParts);
    }

    public class Walls : IPart
    {
        private readonly string nameParts = "Стены";
        public void BuildPart() => Console.WriteLine("Часть стройки: " + nameParts);
    }

    public class Door : IPart
    {
        private readonly string nameParts = "Дверь";
        public void BuildPart() => Console.WriteLine("Часть стройки: " + nameParts);
    }

    public class Window : IPart
    {
        private readonly string nameParts = "Окно";
        public void BuildPart() => Console.WriteLine("Часть стройки: " + nameParts);
    }

    public class Roof : IPart
    {
        private readonly string nameParts = "Крыша";
        public void BuildPart() => Console.WriteLine("Часть стройки: " + nameParts);
    }

    public class House
    {
        private IPart[] parts;

        public House(IPart[] parts)
        {
            this.parts = parts;
        }

        public IPart this[int index]
        {
            get
            {
                return parts[index];
            }
        }        
    }

    public interface IWorker
    {
        void Work(IPart partHouse, int countPartHouse);
    }

    public class Worker: IWorker
    {
        public string FIO { get; set; }
        public bool IsWorkFinished { get; set; } = false;

        public Worker(string FIO)
        {
            this.FIO = FIO;
        }

        public void Work(IPart partHouse, int countPartHouse)
        {
            Console.WriteLine("Фамилия строителя: " + FIO + ". Начинаю работать");
            partHouse.BuildPart();
            Console.WriteLine("Количество частей: " + countPartHouse);
            Console.WriteLine(FIO + " работать закончил");
            IsWorkFinished = true;
            Console.WriteLine("=====================================================");
        }
    }

    public class Team
    {
        private Worker[] workers;

        public Team(Worker[] workers)
        {
            this.workers = workers;
        }
        
        public Worker this[int index]
        {
            get
            {
                return workers[index];
            }
        }

        public int CountWorkers() => workers.Length;
    
    }

    public class TeamLeader
    {
        private Team team;
        private House house;
        private string FIO;

        public TeamLeader(Team team, House house, string FIO)
        {
            this.team = team;
            this.house = house;
            this.FIO = FIO;
        }

        public void BeginWork()
        {
            Console.WriteLine("Процесс стройки дома");
            Console.WriteLine("====================================================");
            for (int i = 0; i < team.CountWorkers(); i++)
            {
                if (i == 0)
                    team[i].Work(house[i], i % 2 == 0 ? 1 : 4);
                else
                {
                    if (team[i - 1].IsWorkFinished == true) //Проверка, закончил ли предыдущий строитель свою работу
                        team[i].Work(house[i], i % 2 == 0 ? 1 : 4);
                }
            }
        }

        public void Report()
        {
            Console.WriteLine("********Отчет о строительстве дома********");
            Console.WriteLine("Бригадир: " + FIO);
            Console.WriteLine("Дом построен");
            string myHouse = @"
                           (   )
                          (    )
                           (    )
                          (    )
                            )  )
                           (  (                  /\
                            (_)                 /  \  /\
                    ________[_]________      /\/    \/  \
           /\      /\        ______    \    /   /\/\  /\/\
          /  \    //_\       \    /\    \  /\/\/    \/    \
   /\    / /\/\  //___\       \__/  \    \/
  /  \  /\/    \//_____\       \ |[]|     \
 /\/\/\/       //_______\       \|__|      \
/      \      /XXXXXXXXXX\                  \
        \    /_I_II  I__I_\__________________\
               I_I|  I__I_____[]_|_[]_____I
               I_II  I__I_____[]_|_[]_____I
               I II__I  I     XXXXXXX     I
            ~~~~~'   '~~~~~~~~~~~~~~~~~~~~~~~~";
            Console.WriteLine(myHouse);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IPart[] parts = new IPart[5]
            {
                new Basement(),
                new Walls(),
                new Door(),
                new Window(),
                new Roof()
            };

            House house = new House(parts);
            Worker[] workers = new Worker[5]
            {
               new Worker("Михалыч"),
               new Worker("Потапыч"),
               new Worker("Саныч"),
               new Worker("Джамшут"),
               new Worker("Равшан")
            };
            Team team = new Team(workers);
            TeamLeader teamLeader = new TeamLeader(team, house, "Иванов Иван Иваныч");
            teamLeader.BeginWork();
            teamLeader.Report();
            Console.ReadKey();
        }
    }
}
