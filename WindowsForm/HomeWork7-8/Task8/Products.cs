using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    public class Products
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public static double RevenuePerDay { get; set; } = 0;

        public Products(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }
    }

    class OrderProducts : Products
    {
        private int countProduct;

        public OrderProducts(string name, double price, int countProduct) : base(name, price)
        {
            this.countProduct = countProduct;
        }

        public static double CalcSum(List<OrderProducts> orderClient, out string text)
        {
            text = "руб.";
            return (orderClient.Count > 0) ? Math.Round(orderClient.Sum(p => p.countProduct * p.Price), 2) : 0;
        }
            
        
    }
}
