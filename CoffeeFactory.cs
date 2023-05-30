using System;
using System.Collections.Generic;
using System.Text;

namespace SWDesign1
{
    class CoffeeFactory : IproductFactory
    {
        public Iproduct createProduct()
        {
            return new Coffee();
        }
    }
}
