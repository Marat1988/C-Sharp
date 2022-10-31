using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    class Benzin
    {
        public string Name { get; private set; }
        public double Price { get; private set; }
        public static double RevenuePerDay { get; set; } = 0;

        public Benzin (string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }

        public static double CalcSum(double total, double price, bool liters, out string text, out double totalAmount) //liters = true Литры, false - сумма
        {
            text = (liters) ? "руб." : "л.";
            totalAmount = 0;
            if (liters)
            {
                totalAmount = Math.Round(total * price, 2);
                return Math.Round(total * price, 2);
            }
            else
            {
                totalAmount = total;
                return (liters) ? Math.Round(total * price, 2) : Math.Round(total / price, 2);
            }
        }
    }
}
