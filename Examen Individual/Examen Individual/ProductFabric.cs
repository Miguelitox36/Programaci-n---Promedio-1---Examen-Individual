using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Examen_Individual
{
    class ProductFabric : Product
    {
        private string size;
        private string material;
        private string color;

        public ProductFabric(string name, float price, string size, string material, string color)
            : base(name, price)
        {
            this.size = size;
            this.material = material;
            this.color = color;
        }

        public override string showFeatures()
        {
            return $"{name} - Size: {size}, Material: {material}, Color: {color}";
        }
    }
}
