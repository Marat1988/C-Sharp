using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Products
    {
        public string NameProduct { get; set; }
        public string Characteristic { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public Products(string nameProduct, string characteristic, string description, double price)
        {
            this.NameProduct = nameProduct;
            this.Characteristic = characteristic;
            this.Description = description;
            this.Price = price;
        }

    }
}
