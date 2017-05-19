using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad7
{
    class Program
    {
        static void Main(string[] args)
        {
            var cart = new ShoppingCart();
            foreach(Product item in cart)
            {
                Console.WriteLine(item.Name);
            }
            Console.ReadKey();
        }
    }
}
