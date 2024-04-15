using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Individual
{
    abstract class Product
    {
        protected string name;
        protected float price;

        public Product(string name, float price)
        {
            this.name = name;
            this.price = price;
        }

        public abstract string showFeatures();

        public float GetPrice()
        {
            return price;
        }
    }
}
