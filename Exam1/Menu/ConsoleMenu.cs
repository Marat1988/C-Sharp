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
        private string subheader; //подзаголовок
        private int cursor; //текущая позиция меню
        private string cursorText; //текст курсора
        private List<MenuItem> menuItemList; //Список меню
        private bool ExitMenu; //флаг выхода из меню
        //Активная позиция курсора
        private void ActiveCursorPozition(int cursorPozition)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(cursorText + " ");
            Console.WriteLine(menuItemList[cursorPozition].text);
            Console.ResetColor();
        }
        //Позиция курсора
        private void CursorPozition(int cursorPozition)
        {
            Console.Write(new string(' ', cursorText.Length + 1));
            Console.WriteLine(menuItemList[cursorPozition].text);
        }
        //Навигация по меню
        private void NavigationCursorPozition(ConsoleKey key)
        {
            Console.SetCursorPosition(menuItemList[cursor].CursorPosition.Item1, menuItemList[cursor].CursorPosition.Item2);
            CursorPozition(cursor);
            cursor = (key == ConsoleKey.UpArrow) ? (cursor - 1) : (cursor + 1);
            Console.SetCursorPosition(menuItemList[cursor].CursorPosition.Item1, menuItemList[cursor].CursorPosition.Item2);
            ActiveCursorPozition(cursor);
        }
        //Конструктор
        public ConsoleMenu(string header, string subheader, string cursorText = "=>")
        {
            this.header = header;
            this.subheader = subheader;
            this.cursorText = cursorText;
            cursor = 0;
            menuItemList = new List<MenuItem>();
        }
        //Прорисовка пунктов меню
        public void DrawMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(header + "\n");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\t" + subheader + "\n");
            Console.ResetColor();
            for (int i = 0; i < menuItemList.Count; i++)
            {
                menuItemList[i].CursorPosition = (Console.CursorLeft, Console.CursorTop);
                if (i == cursor)
                    ActiveCursorPozition(i);
                else
                    CursorPozition(i);
            }
            Console.CursorVisible = false;
        }
        //Навигация по меню
        public void NavigationMenu()
        {
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.UpArrow:
                    {
                        if (cursor > 0)
                            NavigationCursorPozition(ConsoleKey.UpArrow);
                    }
                    break;
                case ConsoleKey.DownArrow:
                    {
                        if (cursor < menuItemList.Count - 1)
                            NavigationCursorPozition(ConsoleKey.DownArrow);
                    }
                    break;
                case ConsoleKey.Enter:
                    {
                        Console.Clear();
                        Console.CursorVisible = true;
                        menuItemList[cursor]._delegate?.Invoke();
                        DrawMenu();
                        Console.CursorVisible = false;
                    }
                    break;
            }
        }
        //Добавление пункта меню
        public void AddMenuItem(int id, string text, Action del)
        {
            if (!menuItemList.Any(item => item.id == id))
                menuItemList.Add(new MenuItem(id, text, del));
        }
        //Выход из меню
        public void HideMenu() => ExitMenu = true;
        //Отображение меню
        public void ShowMenu()
        {
            DrawMenu();
            ExitMenu = false;
            while (!ExitMenu)
            {
                NavigationMenu();
            }
        }
    }
}
