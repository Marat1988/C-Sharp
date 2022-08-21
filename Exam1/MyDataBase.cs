using System;
using System.IO;
using System.Data.OleDb;

namespace MyDBHelper
{
    public static class MyDataBase
    {
        const string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=dictionary.mdb";
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
        }
        private static void SelectSQL(string strSQL)
        {
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
                    }
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
            Console.WriteLine("Начинаю перевод");
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
                Console.WriteLine("Перевод успешно выполнен");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            connection.Close();
            Console.ReadKey(true);
        }
        //Экспорт информации в текстовый файл
        public static void ExportAllWordInFile() => ExportInfoFile("SELECT * FROM RusEng ORDER BY 2,3");
        //Отображение данных таблицы
        public static void ShowInfo() => SelectSQL("SELECT * FROM RusEng ORDER BY 2,3");
        //Поиск перевода слова из таблицы
        public static void ShowTranslateWord(string word) => SelectSQL("SELECT * FROM RusEng WHERE [Word] = '" + word + "'");
        //Добавление слова и его перевода в базу данных
        public static void InsertData(string word, string translateWord)
        {
            word.Trim(' '); translateWord.Trim(' ');
            if (word.Length <= 0)
                Console.WriteLine("Слово не может быть пустым");
            else
            {
                ExecuteSQL("INSERT INTO RusEng ([Word], [Translate]) VALUES('" + word + "','" + ((translateWord.Length == 0) ? null : translateWord) + "')");
            }
        } 
        //Заменить слово
        public static void RenameWord(string word, string newWord)
        {
            word.Trim(' '); newWord.Trim(' ');
            if (word.Length <= 0)
                Console.WriteLine("Слово не может быть пустым");
            else
                ExecuteSQL("UPDATE RusEng SET [Word] ='" + newWord + "' WHERE [Word] = '" + word + "'");
        }
        //Заменить перевод слова
        public static void NewTranslateWord(string word, int id, string newTranslate)
        {
            word.Trim(' '); newTranslate.Trim(' ');
            if (word.Length == 0)
                Console.WriteLine("Слово не может быть пустым");
            else
                ExecuteSQL("UPDATE RusEng SET [Translate] ='" + ((newTranslate.Length == 0) ? null : newTranslate) + "' WHERE [Word] = '" + word + "' AND [id] = " + id);
        }
        //Удаление слова по id
        public static void DeleteWord(int id) => ExecuteSQL("DELETE FROM RusEng WHERE [id] = " + id);
        //Удаление слова
        public static void DeleteWord(string word) => ExecuteSQL("DELETE FROM RusEng WHERE [Word] ='" + word.Trim(' ') + "'");
    }
}
