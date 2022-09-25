using System;
using System.Collections.Generic;
using System.IO;
using System.Data.OleDb;
using System.Text;

namespace MyDBHelper
{
    public static class MyDataBase
    {
        public const string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Base.mdb";
        public static string login = "";
        public static bool isAdmin = false;
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

        private static void CheckAdmin(string strSQL)
        {
            try
            {
                OpenConnection(strSQL);
                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                        isAdmin = (bool)reader[0];
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
            if (countRows > 0)
                CheckAdmin("SELECT IsAdmin FROM USERS WHERE [Login] = '" + login + "'");
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
        //Загрука тем
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
        //Запись результата в таблицу
        public static void FinishGame(DateTime dateBegin, string themesName, DateTime dateEnd, int countQuestion, int countCorrectQuestion)
        {
            ExecuteSQL("INSERT INTO GAMES ([DateBegin], [UserId], [ThemesId], [DateEnd], [CountQuestion], [CountCorrectQuestion]) SELECT '" + dateBegin + "' AS DateBegin, (SELECT UserId FROM USERS WHERE [Login] = '" + login + "') AS UserId, ThemesId, '" + dateEnd + "' AS DateEnd, '" + countQuestion + "' AS CountQuestion, '" + countCorrectQuestion + "' AS CountCorrectQuestion FROM THEMES WHERE [Name] = '" + themesName + "'");
        }
        //Результаты прошлых викторин
        public static void ResultThemesQuiz(string nameThemes, out int countRows, out string msg)
        {
            countRows = 0;
            msg = "Нет данных";
            StringBuilder sb = new StringBuilder();
            try
            {
                OpenConnection("SELECT g.DateBegin, g.DateEnd, g.CountQuestion, g.CountCorrectQuestion FROM ((GAMES g INNER JOIN THEMES t ON g.ThemesId=t.ThemesId) INNER JOIN USERS u ON g.UserId=u.UserId) WHERE u.Login = '" + login + "' AND t.Name = '" + nameThemes + "'");
                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    sb.Append("Дата начало\tДата конца\tВсего\tВерно\n");
                    sb.Append("======================================\n");
                    while (reader.Read())
                    {
                        sb.Append(reader["DateBegin"]);
                        sb.Append("\t" + reader["DateEnd"]);
                        sb.Append("\t   " + reader["CountQuestion"]);
                        sb.Append("\t   " + reader["CountCorrectQuestion"] + "\n");
                        countRows++;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            if (countRows > 0) msg = sb.ToString();
            connection.Close();
        }
        //ТОП 20
        public static void ResultThemesQuizTOP20(string nameThemes, out int countRows, out string msg)
        {
            countRows = 0;
            msg = "Нет данных";
            StringBuilder sb = new StringBuilder();
            try
            {
                OpenConnection("SELECT TOP 20 Login, CountCorrectQuestion FROM TotalPoints WHERE Name = '" + nameThemes + "' ORDER BY CountCorrectQuestion DESC");
                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    sb.Append("Логин\t\tВсего");
                    sb.Append("\n==================\n");
                    while (reader.Read())
                    {
                        sb.Append(reader["Login"]);
                        sb.Append("\t   " + reader["CountCorrectQuestion"] + "\n");
                        countRows++;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            if (countRows > 0) msg = sb.ToString();
            connection.Close();
        }
        //Ранг пользователя
        public static void RankUser(string nameThemes,  out string msg)
        {
            msg = "Нет данных";
            try
            {
                OpenConnection("SELECT rank FROM (SELECT Login, CountCorrectQuestion, (SELECT COUNT(*) FROM TotalPoints AS tbl2 WHERE TotalPoints.CountCorrectQuestion < tbl2.CountCorrectQuestion AND TotalPoints.Name = tbl2.Name) + 1 as rank FROM TotalPoints WHERE Name = '" + nameThemes + "') result WHERE result.Login = '" + login + "'");
                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                        msg = reader["rank"].ToString();
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
