using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Individual
{
    class CraftsStore
    {
        private List<Product> ListProducts = new List<Product>();

        public void AddProduct(Product product)
        {
            ListProducts.Add(product);
        }

        public float CalculateTotalPrice()
        {
            float total = 0;
            foreach (Product product in ListProducts)
            {
                total += product.GetPrice();
            }
            return total;
        }

        public void showCartContents()
        {
           
                Console.WriteLine("Cart content:");
                foreach (Product product in ListProducts)
                {
                Console.WriteLine(product.showFeatures());
                }
                Console.WriteLine("Total price: " + CalculateTotalPrice());           
        }
    }
}
