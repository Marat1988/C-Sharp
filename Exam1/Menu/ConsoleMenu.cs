using System;
using System.Collections.Generic;
using System.Linq;

namespace Exam1.Menu
{
    public class ConsoleMenu
    {
        private readonly string subheader; //подзаголовок
        private readonly string cursorText; //текст курсора
        private int cursor; //текущая позиция меню
        private readonly List<MenuItem> menuItemList; //Список меню
        private bool exitMenu; //флаг выхода из меню
        //Активная позиция курсора
        private void ActiveCursorPozition(int cursorPozition)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(cursorText + " ");
            Console.WriteLine(menuItemList[cursorPozition].Text);
            Console.ResetColor();
        }
        //Позиция курсора
        private void CursorPozition(int cursorPozition)
        {
            Console.Write(new string(' ', cursorText.Length + 1));
            Console.WriteLine(menuItemList[cursorPozition].Text);
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
        //Взять текст текущего курсора
        public string GetCursorText() => menuItemList[cursor].Text;
        public void ClearMenuItemList() => menuItemList.Clear();
        public static string header = "Русско-английский словарь";
        //Конструктор
        public ConsoleMenu(string subheader, string cursorText = "=>")
        {
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
                        menuItemList[cursor].Delegate?.Invoke();
                        DrawMenu();
                        Console.CursorVisible = false;
                    }
                    break;
            }
        }
        //Добавление пункта меню
        public void AddMenuItem(int id, string text, Action del)
        {
            if (!menuItemList.Any(item => item.Id == id))
                menuItemList.Add(new MenuItem(id, text, del));
        }
        //Выход из меню
        public void HideMenu() => exitMenu = true;
        //Отображение меню
        public void ShowMenu()
        {
            DrawMenu();
            exitMenu = false;
            while (!exitMenu)
            {
                NavigationMenu();
            }
        }
    }
}
