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

            infoMenu.AddMenuItem(0, "Отобразить весь список", InfoWordDistionary);
            infoMenu.AddMenuItem(1, "Найти перевод слова", null);
            infoMenu.AddMenuItem(2, "Назад", infoMenu.HideMenu);
           
            mainMenu.AddMenuItem(0, "Выбрать словарь", null);
            mainMenu.AddMenuItem(1, "Редактирование словаря", null);
            mainMenu.AddMenuItem(2, "Информация", infoMenu.ShowMenu);
            mainMenu.AddMenuItem(3, "Экспорт", null);
            mainMenu.AddMenuItem(4, "Выход", Exit);
            mainMenu.ShowMenu();
            Console.ReadKey();
   
        }

        static void Exit() => Environment.Exit(0);
        static void InfoWordDistionary()
        {
            MyDataBase.ShowInfo();
            Console.ReadKey(true);
        }
    }
}

