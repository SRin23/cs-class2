using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSClass2
{
    internal class Product : IComparable<Product>
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public int CompareTo(Product other)
        {
            return this.Name.CompareTo(other.Name);
            //return this.Price - other.Price;
            //return this.Price.CompareTo(other.Price);
        }

        public override string ToString()
        {
            return this.Name + " : " + this.Price + " 원";
        }
    }
}
