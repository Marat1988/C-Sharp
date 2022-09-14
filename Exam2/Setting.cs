using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    public static class Setting
    {
        public static bool CheckPassword(string password, out string msg)
        {
            if (password.Length < 8)
            {
                msg = "Длина пароля должна быть больше 8 символов";
                return false;
            }
            else
            {
                int smallLetterCount = 0;
                int digitalCount = 0;
                int specialSymbol = 0;
                for (int i = 0; i < password.Length; i++)
                {
                    if (!((password[i] >= 'A' && password[i] <= 'Z') || 
                        (password[i] >= 'a' && password[i] <= 'z') || 
                        (password[i] >= '0' && password[i] <= '9') || 
                        password[i] == '!' || password[i] == '.'   || 
                        password[i] == ','))
                    {
                        msg = "Пароль должен содержать буквы английского алфавита, а также цифры и символы ! , . ";
                        return false;
                    }
                    if (!(password[i] >= 'A' && password[i] <= 'Z') && i == 0)
                    {
                        msg = "Пароль должен начинаться с большой буквой";
                        return false;
                    }
                    if (password[i] >= 'a' && password[i] <= 'z') smallLetterCount++;
                    if (password[i] >= '0' && password[i] <= '9') digitalCount++;
                    if (password[i] == '!' || password[i] == '.' || password[i] == ',') specialSymbol++;
                }
                if (smallLetterCount == 0)
                {
                    msg = "В пароле должна быть хотя бы одна маленькая буква";
                    return false;
                }
                if (digitalCount == 0)
                {
                    msg = "В пароле должна быть хотя бы одна цифра";
                    return false;
                }
                if (specialSymbol == 0)
                {
                    msg = "В пароле должен присутствовать хотя бы один из символов ! , . ";
                    return false;
                }
            }
            msg = "Все ОК";
            return true;
        }
        public static bool CheckLogin(string login, out string msg)
        {
            if (login.Length < 5)
            {
                msg = "Длина логина должна быть больше 5 символов";
                return false;
            }
            else
            {
                int smallLetterCount = 0;
                int digitalCount = 0;
                for (int i = 0; i < login.Length; i++)
                {
                    if (!((login[i] >= 'A' && login[i] <= 'Z') || 
                        (login[i] >= 'a' && login[i] <= 'z') || 
                        (login[i] >= '0' && login[i] <= '9')))
                    {
                        msg = "Логин должен содержать буквы английского алфавита, а также цифры";
                        return false;
                    }
                    if (!(login[i] >= 'A' && login[i] <= 'Z') && i == 0) 
                    {
                        msg = "Логин лолжен начинаться с большой буквой";
                        return false;
                    }
                    if (login[i] >= 'a' && login[i] <= 'z') smallLetterCount++;
                    if (login[i] >= '0' && login[i] <= '9') digitalCount++;
                }
                if (smallLetterCount == 0)
                {
                    msg = "В логине должна быть хотя бы одна маленькая буква";
                    return false;
                }
                if (digitalCount == 0)
                {
                    msg = "В логине должна быть хотя бы одна цифра";
                    return false;
                }
            }
            msg = "Все ОК";
            return true;
        }
    }
}
