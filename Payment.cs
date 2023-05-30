using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace SWDesign1
{
    class Payment
    {
        public string paymentMethod { set; get; }
       
       

        public User user = new User();
        SqlConnection conn;
        SqlCommand cmd;

        public Payment()
        {
           
        }

        public void saveMethod(string paymentMethod, string totalPrice) 
        {

            conn = new SqlConnection(@"Data Source=desktop-94fv2gg\sqlexpress;Initial Catalog=CoffeShop;Integrated Security=True");
            conn.Open();

            cmd = new SqlCommand("INSERT INTO [dbo].[payment] VALUES( @paymentMethod, @totalPrice)", conn);
            cmd.Parameters.AddWithValue("paymentMethod", paymentMethod);
            cmd.Parameters.AddWithValue("totalPrice", totalPrice);
            //cmd.ExecuteNonQuery();
            

        }


    }
}
