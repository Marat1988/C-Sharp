using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3
{
    public static class DataBaseProduct
    {
        public static List<Products> products = new List<Products>();

        //Добавить товар
        public static void AddProduct(string nameProduct, string characteristic, string description, double price, out string info)
        {
            info = "";
            if (FindProduct(nameProduct, out int index) == true)
                info = "Товар с таким наименованием уже существует";
            else
                products.Add(new Products(nameProduct, characteristic, description, price));
        }
            
        
        //Изменить товар
        public static void UpdateProduct(string nameProduct, string newNameProduct, string newCharacteristic, string newDescription, double newPrice, out string info)
        {
            info = "";
            if (FindProduct(newNameProduct, out int findProductIndex) == true && (nameProduct != newNameProduct))
            {
                info = "Товар с таким наименованием уже существует";
            }
            else
            {
                if (FindProduct(nameProduct, out int index) == true)
                {
                    products[index].NameProduct = newNameProduct;
                    products[index].Characteristic = newCharacteristic;
                    products[index].Description = newDescription;
                    products[index].Price = newPrice;
                }
            }
        }

        //Проверить существование товара
        public static bool FindProduct(string nameProduct, out int indexProduct)
        {
            indexProduct = 0;
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].NameProduct == nameProduct)
                {
                    indexProduct = i;
                    return true;
                }
            }
            return false;
        }
 
    }
}
