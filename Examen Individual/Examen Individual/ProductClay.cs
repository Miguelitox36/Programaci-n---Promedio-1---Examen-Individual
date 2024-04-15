using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Individual
{
    class ProductClay : Product
    {
        private string size;
        private string color;
        private float weight;

        public ProductClay(string name, float price, string size, string color, float weight)
            : base(name, price)
        {
            this.size = size;            
            this.color = color;
            this.weight = weight;
        }

        public override string showFeatures()
        {
            return $"{name} - Size: {size}, Color: {color}, Weight: {weight}";
        }
    }
}
