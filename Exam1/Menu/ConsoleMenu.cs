using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1.Menu
{
    public class ConsoleMenu
    {
        private string header; //заголовок
        private int cursor; //текущая позиция меню
        private string cursorText; //курсор
        private bool exitMenu; //флаг выхода из меню
        private List<MenuItem> menuItemList; //Список меню
        public ConsoleMenu ParrentMenu { get; set; } //Родительское меню
        public ConsoleMenu(string header, string cursorText="->")
        {
            this.header = header;
            this.cursorText = cursorText;
            cursor = 0;
            exitMenu = false;
            menuItemList = new List<MenuItem>();
        }
        //Добавление пункта меню
        public void addMenuItem(int id, string text, Action del)
        {
            if (!menuItemList.Any(item => item.id == id))
                menuItemList.Add(new MenuItem(id, text, del));
        }
        //Отображение меню
        public void ShowMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\t" + header + "\n");
            Console.ResetColor();
            for (int i = 0; i < menuItemList.Count; i++)
            {
                menuItemList[i].CursorPosition = (Console.CursorLeft, Console.CursorTop);
                if (i == cursor)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(cursorText + " ");
                    Console.WriteLine(menuItemList[i].text);
                    Console.ResetColor();
                }
                else
                {
                    Console.Write(new string(' ', cursorText.Length + 1));
                    Console.WriteLine(menuItemList[i].text);
                }
            }

            /*while (!exitMenu)
            {
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.UpArrow
                }
            }*/
        }

    }
}
