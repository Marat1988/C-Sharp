using System;

namespace Exam1.Menu
{
    public class MenuItem
    {
        public int Id { get; }
        public string Text { get; } //описание
        public Action Delegate { get; }
        public (int, int) CursorPosition { get; set; } = (0, 0); //Позиция меню на экране
        public MenuItem(int id, string text, Action _del)
        {
            Id = id;
            Text = text;
            Delegate = _del;
        }
    }
}
