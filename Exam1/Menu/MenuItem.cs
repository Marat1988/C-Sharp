using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1.Menu
{
    public class MenuItem
    {
        private int id { get; }
        private string text { get; }
        private Action _delegate { get; }
        public MenuItem() { }
        public MenuItem(int id, string text, Action _del)
        {
            this.id = id;
            this.text = text;
            _delegate = _del;
        }
    }
}
