using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    internal class BasketManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Tebrikler.Sepete Eklendi : " + product.Name);
        }

        public void Add2(string productName, string Description, double Price, int stockQuantity)
        {
            Console.WriteLine("Tebrikler.Sepete Eklendi : " + productName);
        }
    }
}
