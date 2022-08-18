using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using MyDBHelper;

namespace Exam1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDataBase.ShowInfo();
           // MyDataBase.InsertData("Дувушка", "Girl");
           // MyDataBase.ShowInfo();
            MyDataBase.RenameWord("Дувушка", "Девушка");
            MyDataBase.ShowInfo();
            Console.ReadKey();
        }
    }
}

