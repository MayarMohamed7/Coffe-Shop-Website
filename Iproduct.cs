using System;
using System.Collections.Generic;
using System.Text;

namespace SWDesign1
{
    interface Iproduct
    {
        public String name { set; get; }
        public double price { set; get; }

        public string YourChoice();
    }
}
