﻿using System;
using System.IO;
using System.Data.OleDb;
using MyDBHelper;
using Exam1.Menu;

namespace Exam1
{
    class Program
    {
        public struct settingDistionary //Данные словаря
        {
            public static string dictionary = "Русско-английский словарь";
            public static string tableName = "RusEng";
        }
        static void Main(string[] args)
        {
            //Создание меню
            ConsoleMenu mainMenu = new ConsoleMenu(settingDistionary.dictionary, "Главное меню");
            ConsoleMenu dictionaryMenu = new ConsoleMenu(settingDistionary.dictionary, "Выбор словаря");
            ConsoleMenu editDictionatyMenu = new ConsoleMenu(settingDistionary.dictionary, "Редактирование словаря");
            ConsoleMenu infoMenu = new ConsoleMenu(settingDistionary.dictionary, "Информация");
            ConsoleMenu exportMenu = new ConsoleMenu(settingDistionary.dictionary, "Экспорт в текстовый файл");
            //Выбор словаря и формирование меню
            MyDataBase.SettingDictionary(ref settingDistionary.dictionary, ref settingDistionary.tableName);
            SetMenuDictionaries(ref dictionaryMenu);
            //Меню редактирование словаря
            editDictionatyMenu.AddMenuItem(0, "Добавить слово в словарь", InsertWordInDataBase);
            editDictionatyMenu.AddMenuItem(1, "Заменить слово в словаре", RenameWord);
            editDictionatyMenu.AddMenuItem(2, "Изменить перевод слова в словаре", EditTranslateWord);
            editDictionatyMenu.AddMenuItem(3, "Удаление слова из базы данных", DeleteWord);
            editDictionatyMenu.AddMenuItem(4, "Удаление слова из базы данных по id", DeleteWordId);
            editDictionatyMenu.AddMenuItem(5, "Удалить переводы слова из базы данных (последний перевод не удаляется)", ClearTranslateWord);
            editDictionatyMenu.AddMenuItem(6, "Назад", editDictionatyMenu.HideMenu);
            //Меню информация
            infoMenu.AddMenuItem(0, "Отобразить весь список", AllWords);
            infoMenu.AddMenuItem(1, "Найти перевод слова", InfoTranslateWord);
            infoMenu.AddMenuItem(2, "Посмотреть слова без перевода", NoTranslate);
            infoMenu.AddMenuItem(3, "Назад", infoMenu.HideMenu);
            //Меню Экспорт
            exportMenu.AddMenuItem(0, "Экспорт словаря в файл", MyDataBase.ExportAllWordInFile);
            exportMenu.AddMenuItem(1, "Экспорт перевода слова в файл", ExportTranslateWord);
            exportMenu.AddMenuItem(2, "Назад", exportMenu.HideMenu);
            //Формирование главного меню
            mainMenu.AddMenuItem(0, "Выбрать словарь", null);
            mainMenu.AddMenuItem(1, "Редактирование словаря", editDictionatyMenu.ShowMenu);
            mainMenu.AddMenuItem(2, "Информация", infoMenu.ShowMenu);
            mainMenu.AddMenuItem(3, "Экспорт", exportMenu.ShowMenu);
            mainMenu.AddMenuItem(4, "Об авторе", InfoAuthor);
            mainMenu.AddMenuItem(5, "Выход", Exit);
            mainMenu.ShowMenu();
            Console.ReadKey();  
        }
        //Главное меню
        static void Exit() => Environment.Exit(0);
        //Меню редактирование словаря
        static void InsertWordInDataBase()
        {
            Console.Write("Введите слово: ");
            string word = Console.ReadLine();
            Console.Write("Введите перевод слова: ");
            string translateWord = Console.ReadLine();
            MyDataBase.InsertData(word, translateWord);
        }
        static void RenameWord()
        {
            Console.Write("Введите слово из словаря: ");
            string word = Console.ReadLine();
            Console.Write("Введите новое слово: ");
            string newWord = Console.ReadLine();
            MyDataBase.RenameWord(word, newWord);
        }
        static void EditTranslateWord()
        {
            Console.Write("Введите слово из словаря: ");
            string word = Console.ReadLine();
            Console.WriteLine("================Список===============");
            MyDataBase.ShowTranslateWord(word);
            Console.Write("Введите id слова: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                Console.Write("Введите новый перевод слова: ");
                string newTranslate = Console.ReadLine();
                MyDataBase.NewTranslateWord(word, id, newTranslate);
            }
        }
        static void DeleteWord()
        {
            Console.Write("Введите слово: ");
            MyDataBase.DeleteWord(Console.ReadLine());
            Console.ReadKey(true);
        }
        static void DeleteWordId()
        {
            Console.Write("Введите id слова: ");
            if (int.TryParse(Console.ReadLine(), out int id))
                MyDataBase.DeleteWord(id);
            Console.ReadKey(true);
        }
        static void ClearTranslateWord()
        {
            Console.Write("Введите id слова: ");
            MyDataBase.ClearTranslateWord(Console.ReadLine());
            Console.ReadKey(true);
        }
        //Меню информация
        static void AllWords()
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
        static void NoTranslate()
        {
            MyDataBase.ShowWordNoTranslate();
            Console.ReadKey(true);
        }
        //Меню экспорт
        static void ExportTranslateWord()
        {
            Console.Write("Введите слово: ");
            MyDataBase.ExportWordTranslateInFile(Console.ReadLine());
        }
        //Меню об авторе
        static void InfoAuthor() {
            Console.WriteLine("Тухтаров Марат. Группа БВ112. Академия \"ТОП\" г. Калининград, 2022");
            Console.ReadKey(true);
        }
        //Выбор словаря
        static void ChooseDistionary()
        {

        }
        static void SetMenuDictionaries(ref ConsoleMenu dictionaryMenu)
        {
            string strSQL = "SELECT * FROM ListDictionaries";  
            using (OleDbConnection connection = new OleDbConnection(MyDataBase.connectionString))
            {
                OleDbCommand command = new OleDbCommand(strSQL, connection); 
                try
                {
                    connection.Open();
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        Console.WriteLine("------------Original data----------------");
                        while (reader.Read())
                        {
                            dictionaryMenu.AddMenuItem((int)reader["id"], reader["Description"].ToString(), ChooseDistionary);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }  
            }
        }
    }
}