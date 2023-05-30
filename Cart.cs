using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace SWDesign1
{
    class Cart
    {
        SqlConnection conn;
        SqlCommand cmd;
        public string cartItem { get; set; }
        public string cartItemPrice { get; set; }
        public int quantity { get; set; }
        User user = new User();
        public void addToCart(string email, string productName, string price,string quantity){
            conn = new SqlConnection(@"Data Source=desktop-94fv2gg\sqlexpress;Initial Catalog=CoffeShop;Integrated Security=True");
            conn.Open();

            cmd = new SqlCommand("INSERT INTO [dbo].[userCart] VALUES(@email, @productName,@price, @quantity)", conn);
            cmd.Parameters.AddWithValue("email", email);
            cmd.Parameters.AddWithValue("productName", productName);
            cmd.Parameters.AddWithValue("price", price);
            cmd.Parameters.AddWithValue("quantity", quantity);
            cmd.ExecuteNonQuery();
        }
        

    }
}
