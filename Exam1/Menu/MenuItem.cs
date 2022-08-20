using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1.Menu
{
    public class MenuItem
    {
        public int id { get; }
        public string text { get; }
        public Action _delegate { get; }
        public (int, int) CursorPosition { get; set; } = (0, 0); //Позиция меню на экране
        public MenuItem() { }
        public MenuItem(int id, string text, Action _del)
        {
            this.id = id;
            this.text = text;
            _delegate = _del;
        }
    }
}
