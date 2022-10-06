using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork17_18
{
    class Program
    {
        /*Задание 1
        Создайте класс «Веб-сайт». Необходимо хранить в полях класса: название сайта, путь к сайту, описание сайта, ip адрес сайта.
        Реализуйте методы класса для ввода данных, вывода данных, реализуйте доступ к отдельным полям через методы класса.*/
        class WebSite
        {
            private string title = "METANIT.COM - Сайт о программировании"; //название сайта <title></title>
            private string url = "https://metanit.com/";                    //путь к сайту (URL адрес к сайту, например https://yandex.ru)
            private string desctiprion = "METANIT.COM - Сайт о программировании на C#, .NET, Java, Python, Golang"; //описание сайта
            private string ip = "77.222.61.70";                   //ip-адрес сайта
            //Через методы (по заданию).
            public void setTitle(string title) => this.title = title;
            public void setUrl(string url)
            {
                if (Uri.IsWellFormedUriString(url, UriKind.Absolute)) //проверка ввода корректности URL адреса
                    this.url = url;
                else
                    Console.WriteLine("Не корректный ввод адреса");
            }
            public void setDesctiprion(string desctiprion) => this.desctiprion = desctiprion;
            public void setIp(string ip)
            {
                if (IPAddress.TryParse(ip, out IPAddress ipAddress))
                    this.ip = ip;
                else
                    Console.WriteLine("Не корректный ввод ip-адреса");
            }
            public string getTittle()
            {
                return title;
            }
            public string getUrl()
            {
                return url;
            }
            public string getDesctiprion()
            {
                return desctiprion;
            }
            public string getIp()
            {
                return ip;
            }

            public void showInfo()
            {
                Console.WriteLine($"Название сайта: \t {title}\n"
                                   + $"Путь к сайту (url): \t {url}\n"
                                   + $"Описание: \t\t {desctiprion}\n"
                                   + $"IP-адрес: \t\t {ip}");
            }
        }

        static void Main(string[] args)
        {
            WebSite site = new WebSite();
            site.showInfo();
            Console.ReadKey();
        }
    }
}
