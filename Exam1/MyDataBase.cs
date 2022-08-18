using System;
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
        //Отображение данных таблицы
        public static void ShowInfo()
        {
            string strSQL = "SELECT * FROM RusEng ORDER BY 2,3";
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
        //Добавление слова и его перевода в базу данных
        public static void InsertData(string word, string translateWord)
        {
            if (word.Length <= 0)
                Console.WriteLine("Слово не может быть пустым");
            else
            {
                if (translateWord.Length <= 0) translateWord = null;
                ExecuteSQL("INSERT INTO RusEng ([Word], [Translate]) VALUES('" + word + "','" + translateWord + "')");
            }
        } 
        //Заменить слово
        public static void RenameWord(string word, string newWord)
        {
            if (word.Length <= 0 || newWord.Length <= 0)
                Console.WriteLine("Слово не может быть пустым");
            else
                ExecuteSQL("UPDATE RusEng SET [Word] ='" + newWord + "' WHERE [Word] = '" + word + "'");
        }
        //Заменить перевод слова
        public static void NewTranslateWord(string word, int id, string newTranslate)
        {
            if (word.Length <= 0 || id <= 0) 
                Console.WriteLine("Слово или перевод слова не может быть пустым или введен не корректный id");
            else
                ExecuteSQL("UPDATE RusEng SET [Translate] ='" + newTranslate + "' WHERE [Word] = '" + word + "' AND [id] = " + id);
        }
        //Удаление слова по id
        public static void DeleteWord(int id)
        {
            if (id <= 0)
                Console.WriteLine("id слова не может быть меньше нуля");
            else
                ExecuteSQL("DELETE FROM RusEng WHERE [id] = " + id);
        }
        //Удаление слова
        public static void DeleteWord(string word)
        {
            if (word.Length <= 0)
                Console.WriteLine("Слово не может быть пустым");
            else
                ExecuteSQL("DELETE FROM RusEng WHERE [Word] ='" + word + "'");
        }
    }
}
