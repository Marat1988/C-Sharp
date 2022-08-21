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
            ConsoleMenu exportMenu = new ConsoleMenu("Экспорт в текстовый файл");
            //Меню информация
            infoMenu.AddMenuItem(0, "Отобразить весь список", InfoWordDistionary);
            infoMenu.AddMenuItem(1, "Найти перевод слова", InfoTranslateWord);
            infoMenu.AddMenuItem(2, "Назад", infoMenu.HideMenu);
            //Меню Экспорт
            exportMenu.AddMenuItem(0, "Экспорт словаря в файл", MyDataBase.ExportAllWordInFile);
            exportMenu.AddMenuItem(1, "Экспорт перевода слова в файл", null);
            exportMenu.AddMenuItem(2, "Назад", exportMenu.HideMenu);
            //Формирование главного меню
            mainMenu.AddMenuItem(0, "Выбрать словарь", null);
            mainMenu.AddMenuItem(1, "Редактирование словаря", null);
            mainMenu.AddMenuItem(2, "Информация", infoMenu.ShowMenu);
            mainMenu.AddMenuItem(3, "Экспорт", exportMenu.ShowMenu);
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
        static void InfoTranslateWord()
        {
            Console.Write("Введите слово: ");
            MyDataBase.ShowTranslateWord(Console.ReadLine());
            Console.ReadKey(true);
        }
    }
}

