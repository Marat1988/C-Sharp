using System;
using System.IO;
using System.Data.OleDb;
using static Exam1.Program;
using Exam1.Menu;

namespace MyDBHelper
{
    public static class MyDataBase
    {
        public const string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=dictionary.mdb";
        private static OleDbConnection connection;
        private static OleDbCommand command;
        private static void OpenConnection(string strSQL)
        {
            connection = new OleDbConnection(connectionString);
            command = new OleDbCommand(strSQL, connection);
            connection.Open();
        }
        private static void ExecuteSQL(string strSQL)
        {
            try
            {
                OpenConnection(strSQL);
                command.ExecuteNonQuery();
                Console.WriteLine("Операция выполнена успешно.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            connection.Close();
            Console.ReadKey(true);
        }
        private static void SelectSQL(string strSQL, int countRows=0)
        {
            countRows = 0;
            try
            {
                OpenConnection(strSQL);               
                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    Console.WriteLine("id\t\tСлово\t\t\tПеревод");
                    Console.WriteLine("======================================================");
                    while (reader.Read())
                    {
                        Console.WriteLine("{0} \t\t{1}", reader["id"], reader["Word"]);
                        Console.SetCursorPosition(40, Console.CursorTop - 1);
                        Console.WriteLine(reader["Translate"]);
                        countRows++;
                    }
                    Console.WriteLine("======================================================");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            connection.Close();
        }
        private static void ExportInfoFile(string strSQL)
        {
            Console.WriteLine("Начинаю экспорт");
            try
            {
                OpenConnection(strSQL);
                using (OleDbDataReader reader = command.ExecuteReader())               
                using (StreamWriter writer = new StreamWriter("info.txt"))
                {
                    writer.WriteLine("id\t\tСлово\t\t\tПеревод");
                    writer.WriteLine("======================================================");
                    int countWorld = 1;
                    while (reader.Read())
                    {
                        Console.WriteLine(countWorld + " слово");
                        writer.WriteLine("{0}\t\t{1}\t\t{2}", reader["id"], reader["Word"], reader["Translate"]);
                        countWorld++;
                    }
                }
                Console.WriteLine("Экспорт успешно выполнен");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            connection.Close();
            Console.ReadKey(true);
        }
        public static string getTableName() {
            return settingDistionary.dictionary;
        }
        //Экспорт информации в текстовый файл
        public static void ExportAllWordInFile() => ExportInfoFile("SELECT * FROM " + getTableName() + " ORDER BY 2,3");
        //Экспорт слова и его перевода в файл
        public static void ExportWordTranslateInFile(string word) => ExportInfoFile("SELECT * FROM " + getTableName() + " WHERE [Word] = '" + word + "'");
        //Отображение данных таблицы
        public static void ShowInfo() => SelectSQL("SELECT * FROM " + getTableName() + " ORDER BY 2,3");
        //Поиск перевода слова из таблицы
        public static void ShowTranslateWord(string word) => SelectSQL("SELECT * FROM " + getTableName() + " WHERE [Word] = '" + word + "'");
        //Посмотреть слова без перевода
        public static void ShowWordNoTranslate() => SelectSQL("SELECT * FROM " + getTableName() + " WHERE Len([Translate])=0 OR [Translate] IS NULL");
        //Добавление слова и его перевода в базу данных
        public static void InsertData(string word, string translateWord)
        {
            word.Trim(' '); translateWord.Trim(' ');
            if (word.Length <= 0)
                Console.WriteLine("Слово не может быть пустым");
            else
                ExecuteSQL("INSERT INTO " + getTableName() + " ([Word], [Translate]) VALUES('" + word + "','" + ((translateWord.Length == 0) ? null : translateWord) + "')");
        } 
        //Заменить слово
        public static void RenameWord(string word, string newWord)
        {
            word.Trim(' '); newWord.Trim(' ');
            if (word.Length <= 0)
                Console.WriteLine("Слово не может быть пустым");
            else
                ExecuteSQL("UPDATE " + getTableName() + " SET [Word] ='" + newWord + "' WHERE [Word] = '" + word + "'");
        }
        //Заменить перевод слова
        public static void NewTranslateWord(string word, int id, string newTranslate)
        {
            word.Trim(' '); newTranslate.Trim(' ');
            if (word.Length == 0)
                Console.WriteLine("Слово не может быть пустым");
            else
                ExecuteSQL("UPDATE " + getTableName() + " SET [Translate] ='" + ((newTranslate.Length == 0) ? null : newTranslate) + "' WHERE [Word] = '" + word + "' AND [id] = " + id);
        }
        //Удаление слова
        public static void DeleteWord(string word) => ExecuteSQL("DELETE FROM " + getTableName() + " WHERE [Word] ='" + word.Trim(' ') + "'");
        //Удаление слова по id
        public static void DeleteWord(int id) => ExecuteSQL("DELETE FROM " + getTableName() + " WHERE [id] =" + id);
        //Удаление перевода слова (кроме последнего)
        public static void ClearTranslateWord(string word) => ExecuteSQL("UPDATE " + getTableName() + " SET [Translate] = null WHERE [Word] = '" + word + "' AND [id] NOT IN (SELECT Max(id) AS MaxId FROM " + getTableName() + " WHERE [Word] = '" + word + "')");
        //Для выбора словаря при запуске
       public static void SettingDictionary(ref string dictionary, ref string tableName)
       {
            try
            {
                OpenConnection("SELECT Description, TableName FROM ListDictionaries WHERE id=(SELECT MIN(id) FROM ListDictionaries)");
                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        tableName = reader["TableName"].ToString();
                        dictionary = reader["Description"].ToString();
                    }                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            connection.Close();
        }
        
    }
}
