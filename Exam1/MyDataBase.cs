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
        //Добавление данных
        public static void InsertData(string word, string translateWord)
        {
            string strSQL = "INSERT INTO RusEng ([Word], [Translate]) VALUES('" + word + "','" + translateWord + "')";
            try
            {
                OpenConnection(strSQL);
                using (command.ExecuteReader())
                {
                    Console.WriteLine("Успешное добавление в базу данных");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            connection.Close();
        }
        //Удаление данных по id
        public static void DeleteData(int id)
        {
            string strSQL = "DELETE FROM RusEng WHERE id = " + id;
            try
            {
                OpenConnection(strSQL);
                using (command.ExecuteReader())
                {
                    Console.WriteLine("Успешное удаление из базы данных");
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
