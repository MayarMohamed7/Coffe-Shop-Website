using System;
using System.Collections.Generic;
using System.Text;

namespace SWDesign1
{
    class PasteryFactory : IproductFactory
    {
        public Iproduct createProduct()
        {
            return new Pastery();
        }
    }
}
