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

            ConsoleMenu infoMenu = new ConsoleMenu("Информация");
            //infoMenu.ParrentMenu = mainMenu;
            infoMenu.addMenuItem(0, "Отобразить весь список", null);
            infoMenu.addMenuItem(1, "Найти перевод слова", null);
            infoMenu.addMenuItem(2, "Назад", infoMenu.HideMenu);
           
            mainMenu.addMenuItem(0, "Выбрать словарь", null);
            mainMenu.addMenuItem(1, "Редактирование словаря", infoMenu.ShowMenu);
            mainMenu.addMenuItem(2, "Информация", infoMenu.ShowMenu);
            mainMenu.addMenuItem(3, "Экспорт", null);
            mainMenu.addMenuItem(4, "Выход", Exit);
            mainMenu.ShowMenu();
            Console.ReadKey();
   
        }

        static void Exit() => Environment.Exit(0);
    }
}

