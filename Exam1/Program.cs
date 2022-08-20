using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using MyDBHelper;
using Exam1.Menu;

namespace Exam1
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleMenu mainMenu = new ConsoleMenu("Главное меню");
            mainMenu.addMenuItem(0, "Выбрать словарь", null);
            mainMenu.addMenuItem(1, "Действия", null);
            mainMenu.addMenuItem(2, "Информация", null);
            mainMenu.addMenuItem(3, "Экспорт", null);
            mainMenu.addMenuItem(4, "Выход", null);
            mainMenu.ShowMenu();
            Console.ReadKey();
        }
    }
}

