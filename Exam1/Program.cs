using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Exam1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Строка подключения и SQL-запрос
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=dictionary.mdb";
            string strSQL = "SELECT * FROM RusEng";
            // Создаем соединение    
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                // Создаем команду и устанавливаем ее подключение    
                OleDbCommand command = new OleDbCommand(strSQL, connection);
                // Открываем соединение и выполняем команду select.    
                try
                {
                    // Открыть соединение    
                    connection.Open();
                    // Выполнить команду   
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        Console.WriteLine("****************Англо-русский словарь****************");
                        Console.WriteLine("id\t\tСлово\t\t\tПеревод");
                        Console.WriteLine("======================================================");
                        while (reader.Read())
                        {
                            Console.WriteLine("{0} \t\t{1}", reader["id"], reader["RusWord"]);
                            Console.SetCursorPosition(40, Console.CursorTop - 1);
                            Console.WriteLine(reader["EngWord"]);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                // Соединение автоматически закрывается из-за using блока   
            }
            Console.ReadKey();
        }
    }
}

