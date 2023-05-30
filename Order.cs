using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace SWDesign1
{
    class Order
    {
        SqlConnection conn;
        SqlCommand cmd;

        public void saveOrder()
        {
           cmd = new SqlCommand("INSERT INTO [dbo].[userrOrder] VALUES(@totalPrice)", conn);
        }
        
    }
}
