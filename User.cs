using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace SWDesign1
{

    class User
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader dr;

        public string name { set; get; }
        public string email { set; get; }
        public string password { set; get; }
        public string address { set; get; }
        public string phoneNo { set; get; }


        public User()
        {
        }

        public void register(string name, string email, string pass, string address, string phoneNo)
        {
            conn = new SqlConnection(@"Data Source=desktop-94fv2gg\sqlexpress;Initial Catalog=CoffeShop;Integrated Security=True");
            conn.Open();

            cmd = new SqlCommand("INSERT INTO [dbo].[user] VALUES(@name, @email,@password, @address, @phoneNo)", conn);
            cmd.Parameters.AddWithValue("name", name);
            cmd.Parameters.AddWithValue("email", email);
            cmd.Parameters.AddWithValue("password", pass);
            cmd.Parameters.AddWithValue("address", address);
            cmd.Parameters.AddWithValue("phoneNo", phoneNo);
            cmd.ExecuteNonQuery();
        }

        public SqlDataReader login(string email, string pass)
        {
            conn = new SqlConnection(@"Data Source=desktop-94fv2gg\sqlexpress;Initial Catalog=CoffeShop;Integrated Security=True");
            conn.Open();

            cmd = new SqlCommand
                    ("select * from[dbo].[user] where email = '" + email + "' and password = '" + pass + "'", conn);

            dr = cmd.ExecuteReader();
            return dr;


        }
    }
}
