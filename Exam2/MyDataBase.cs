using System;
using System.Collections.Generic;
using System.IO;
using System.Data.OleDb;

namespace MyDBHelper
{
    public static class MyDataBase
    {
        public const string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Base.mdb";
        public static string login = "";
        private static OleDbConnection connection;
        private static OleDbCommand command;
        //Открытие соеднинения с базой данных
        private static void OpenConnection(string strSQL)
        {
            connection = new OleDbConnection(connectionString);
            command = new OleDbCommand(strSQL, connection);
            connection.Open();
        }
        //Выполнение запросов INSERT, UDPATE, DELETE и прочее
        private static void ExecuteSQL(string strSQL)
        {
            try
            {
                OpenConnection(strSQL);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            connection.Close();
        }
        //Запрос на выборку
        private static void SelectSQL(string strSQL, out int countRows)
        {
            countRows = 0;
            try
            {
                OpenConnection(strSQL);
                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        countRows++;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            connection.Close();
        }
        //Проверка существования логина
        public static bool CheckLogin(string login)
        {
            SelectSQL("SELECT * FROM USERS WHERE [Login] = '" + login + "'", out int countRows);
            return (countRows > 0);
        }
        //Проверка существования логина и пароля
        public static bool CheckLogin(string login, string password)
        {
            SelectSQL("SELECT * FROM USERS WHERE [Login] = '" + login + "' AND [Password] = '" + password + "'", out int countRows);
            return (countRows > 0);
        }
        //Ввод нового пользователя в базу данных
        public static void InsertUser(string login, string password, DateTime birthDay)
        {
            ExecuteSQL("INSERT INTO USERS ([Login], [Password], [BirthDay]) VALUES ('" + login + "','" + password + "','" + birthDay + "')");
        }
        //Отображение логина и пароля
        public static void ShowInfoUser(out string password, out DateTime birthDay)
        {
            password = "";
            birthDay = DateTime.Now.Date;
            try
            {
                OpenConnection("SELECT Password, BirthDay FROM USERS WHERE [Login] = '" + login + "'");
                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        password = reader["Password"].ToString();
                        birthDay = DateTime.Parse(reader["BirthDay"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            connection.Close();
        }
        //Обновление пароля и дня рождения у пользователя
        public static void UpdateSettingUser(string password, DateTime birthDay)
        {
            ExecuteSQL("UPDATE USERS SET [Password] ='" + password + "', [BirthDay] ='" + birthDay + "' WHERE [Login] = '" + login + "'");
        }

        public static void LoadThemes(ref List<string> themes)
        {
            try
            {
                OpenConnection("SELECT [Name], IIF(ThemesId=1, 1,2) AS OrderThemes  FROM THEMES ORDER BY 2,1");
                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        themes.Add(reader["Name"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            connection.Close();
        }

    }
}
