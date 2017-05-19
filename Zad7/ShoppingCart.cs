using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Zad7
{
    class ShoppingCart : IEnumerable, IEnumerator
    {
        private List<Product> cart = new List<Product>();
        private int position = -1;

        public ShoppingCart()
        {
            cart.Add(new Product { Name = "jeden" });
            cart.Add(new Product { Name = "dwa" });
            cart.Add(new Product { Name = "trzy" });
        }

        public object Current => cart.ElementAt(position);

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            position++;
            return (position < cart.Count);
        }

        public void Reset()
        {
            position = 0;
        }
    }
}
