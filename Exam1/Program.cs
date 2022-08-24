using System;
using System.Data.OleDb;
using MyDBHelper;
using Exam1.Menu;

namespace Exam1
{
    class Program
    {
        private static ConsoleMenu dictionaryMenu; //Меню выбора словаря
        public struct SettingDistionary //Данные выбранного текущего словаря
        {
            public static string dictionary = "Текущий словарь: ";
            public static string tableName = "RusEng";
        }
        static void Main(string[] args)
        {
            Console.Title = "Словари. Учебный проект";
            //Выбор словаря по-умолчанию
            MyDataBase.SettingDictionary(ref SettingDistionary.dictionary, ref SettingDistionary.tableName);
            //Создание меню
            ConsoleMenu mainMenu = new ConsoleMenu("Главное меню");
            dictionaryMenu = new ConsoleMenu("Выбор словаря");
            ConsoleMenu editDictionaryMenu = new ConsoleMenu("Редактирование словаря");
            ConsoleMenu infoMenu = new ConsoleMenu("Информация");
            ConsoleMenu exportMenu = new ConsoleMenu("Экспорт в текстовый файл");
            ConsoleMenu.header = SettingDistionary.dictionary;
            //Формирование меню словарей из полученных данных SQL-запроса
            SetMenuDictionaries();
            //Меню редактирование словаря
            editDictionaryMenu.AddMenuItem(0, "Добавить слово в словарь", InsertWordInDataBase);
            editDictionaryMenu.AddMenuItem(1, "Заменить слово в словаре", RenameWord);
            editDictionaryMenu.AddMenuItem(2, "Изменить перевод слова в словаре", EditTranslateWord);
            editDictionaryMenu.AddMenuItem(3, "Удаление слова из базы данных", DeleteWord);
            editDictionaryMenu.AddMenuItem(4, "Удаление слова из базы данных по id", DeleteWordId);
            editDictionaryMenu.AddMenuItem(5, "Удалить переводы слова из базы данных (последний перевод не удаляется)", ClearTranslateWord);
            editDictionaryMenu.AddMenuItem(6, "Добавить новый словарь в базу данных", AddDictionary);
            editDictionaryMenu.AddMenuItem(7, "Назад", editDictionaryMenu.HideMenu);
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
            mainMenu.AddMenuItem(0, "Выбрать словарь", dictionaryMenu.ShowMenu);
            mainMenu.AddMenuItem(1, "Редактирование словаря", editDictionaryMenu.ShowMenu);
            mainMenu.AddMenuItem(2, "Информация", infoMenu.ShowMenu);
            mainMenu.AddMenuItem(3, "Экспорт", exportMenu.ShowMenu);
            mainMenu.AddMenuItem(4, "Об авторе", InfoAuthor);
            mainMenu.AddMenuItem(5, "Выход", Exit);
            mainMenu.ShowMenu();
        }
        static void Exit() => Environment.Exit(0);
        /****Меню выбора словаря****/
        static void SetMenuDictionaries() //Формирование выбора меню словаря
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
                        int countRow = 0;
                        while (reader.Read())
                        {
                            dictionaryMenu.AddMenuItem(countRow, reader["Description"].ToString(), ChooseDistionary);
                            countRow++;
                        }
                        dictionaryMenu.AddMenuItem(countRow, "Назад", dictionaryMenu.HideMenu);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        static void ChooseDistionary() //Выбор словаря
        {
            string dictionary = dictionaryMenu.GetCursorText();
            string tableName = SettingDistionary.tableName;
            MyDataBase.SettingDictionary(ref dictionary, ref tableName, false);
            SettingDistionary.dictionary = dictionary;
            SettingDistionary.tableName = tableName;
            ConsoleMenu.header = SettingDistionary.dictionary;
        }
        /****Меню редактирования словаря****/
        static void InsertWordInDataBase() //Добавление слова с словарь
        {
            Console.Write("Введите слово: ");
            string word = Console.ReadLine();
            Console.Write("Введите перевод слова: ");
            string translateWord = Console.ReadLine();
            MyDataBase.InsertData(word, translateWord);
            Console.ReadKey(true);
        }
        static void RenameWord() //Изменить слово в словаре
        {
            Console.Write("Введите слово из словаря: ");
            string word = Console.ReadLine();
            Console.Write("Введите новое слово: ");
            string newWord = Console.ReadLine();
            MyDataBase.RenameWord(word, newWord);
            Console.ReadKey(true);
        }
        static void EditTranslateWord() //Изменить перевод стола
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
            Console.ReadKey(true);
        }
        static void DeleteWord() //Удалить слово
        {
            Console.Write("Введите слово: ");
            MyDataBase.DeleteWord(Console.ReadLine());
            Console.ReadKey(true);
        }
        static void DeleteWordId() //Удалить слово по Id
        {
            Console.Write("Введите id слова: ");
            if (int.TryParse(Console.ReadLine(), out int id))
                MyDataBase.DeleteWord(id);
            Console.ReadKey(true);
        }
        static void ClearTranslateWord() //Удалить перевод слова
        {
            Console.Write("Введите id слова: ");
            MyDataBase.ClearTranslateWord(Console.ReadLine());
            Console.ReadKey(true);
        }
        static void AddDictionary() //Добавление словаря
        {
            Console.Write("Введите описание словаря (например, англо-русский словарь): ");
            MyDataBase.InsertDictionary(Console.ReadLine());
            dictionaryMenu.ClearMenuItemList();
            SetMenuDictionaries();
            Console.ReadKey(true);
        }
        /****Меню Информация****/
        static void AllWords() //Показать список слов
        {
            MyDataBase.ShowInfo();
            Console.ReadKey(true);
        }
        static void InfoTranslateWord() //Показать переводы слова
        {
            Console.Write("Введите слово: ");
            MyDataBase.ShowTranslateWord(Console.ReadLine());
            Console.ReadKey(true);
        }
        static void NoTranslate() //Показать слово без перевода
        {
            MyDataBase.ShowWordNoTranslate();
            Console.ReadKey(true);
        }
        /****Меню Экспорт****/
        static void ExportTranslateWord() //Экспортировать переводы слова в базу данных
        {
            Console.Write("Введите слово: ");
            MyDataBase.ExportWordTranslateInFile(Console.ReadLine());
        }
        /****Меню Об авторе****/
        static void InfoAuthor() {
            Console.WriteLine("Тухтаров Марат. Группа БВ112. Академия \"ТОП\" г. Калининград, 2022");
            Console.ReadKey(true);
        }
    }
}