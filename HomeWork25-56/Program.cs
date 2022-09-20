using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork25_56
{
    class Program
    {
        /*Задание 1. Программа «Статистика»
         * Подсчитать, сколько раз каждое слово встречается в заданном тексте. Результат записать в коллекцию Dictionary<TKey, TValue>. Текст использовать из приложения 1.
         * Вывести статистику по тексту в виде таблицы (рисунок 1).
         * Приложение 1.
         * Вот дом, Который построил Джек. А это пшеница, Которая в темном чулане хранится в доме, Который построил Джек. 
         * А это веселая птица-синица, Которая часто ворует пшеницу, Которая в темном чулане хранится В доме, Который построил Джек.*/
        static void Main(string[] args)
        {
            string text = " Вот дом, Который построил Джек.\n" +
                         " А это пшеница, Которая в темном чулане хранится в доме,\n" +
                         " Который построил Джек. А это веселая птица-синица,\n" +
                         " Которая часто ворует пшеницу, Которая в темном чулане хранится В доме,\n" +
                         " Который построил Джек.";
            string[] newWordArray = text.Split(new Char[] { ' ', ',', '.', ':', '(', ')', '“', '”', '\t', '\n' }).Where(i => i != "").ToArray();
            string[] uniqueWordArray = newWordArray.Distinct().ToArray();
            Dictionary<string, int> myWorld = new Dictionary<string, int>();
            for (int i = 0; i < uniqueWordArray.Count(); i++)
                myWorld.Add(uniqueWordArray[i], newWordArray.Where(word => word == uniqueWordArray[i]).Count());
            Console.WriteLine("{0, 19} {1, 10}", "Слово", "Кол-во");
            foreach (var item in myWorld)
            {
                Console.Write(Console.CursorTop < 10 ? (" " + Console.CursorTop + ".") : (Console.CursorTop + "."));
                Console.WriteLine("{0, 16}{1, 9}", item.Key, item.Value);
            }
            /*Точки, запятые я исключаю из расчета. Поэтому получилось 36 слов вместо 45.*/
            Console.WriteLine($"Всего слов: {newWordArray.Count()} из них уникальных: {uniqueWordArray.Count()}");
            Console.ReadKey();
        }
    }
}
