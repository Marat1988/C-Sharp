﻿using System;
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
            Console.ReadKey();
        }
    }
}

