using System;
using System.Collections.Generic;
using System.Text;

namespace SWDesign1
{
    class Coffee : Iproduct
    {
        public string name { get; set; }
        public double price { get; set; }


        public string YourChoice()
        {
            return "Your coffee is added to cart.";
        }
    }
}
