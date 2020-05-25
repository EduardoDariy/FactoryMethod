using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    abstract class Product
    {
        public abstract decimal PurchasePrice { get; set; }

        public abstract decimal Price { get; set; }

        public abstract string Description { get; set; }
    }
}
