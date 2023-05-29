using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace SWDesign1
{
    class Payment
    {
        public string paymentMethod { set; get; }
        public double TotalPrice { set; get; }

        public User user = new User();
        SqlConnection conn;
        SqlCommand cmd;

        public Payment(string paymentM, double price)
        {
            this.paymentMethod = paymentM;
            this.TotalPrice = price;

        }

        public void saveMethod(string paymentMethod, double totalPrice) // put the the textbox.Text in these parameters and send them to this function
        {
            //still
            string userEmail = user.email;

            cmd = new SqlCommand("INSERT INTO [dbo].[payment] VALUES(@userEmail,@paymentMethod, @totalPrice)", conn);
            cmd.Parameters.AddWithValue("userId", userEmail);
            cmd.Parameters.AddWithValue("paymentMethod", paymentMethod);
            cmd.Parameters.AddWithValue("totalPrice", totalPrice);
            cmd.ExecuteNonQuery();
            /*MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            Form1 login = new Form1();
            login.ShowDialog();*/ //cut this and paste it in the design file

        }


    }
}
