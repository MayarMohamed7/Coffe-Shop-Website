using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SWDesign1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=HABIBA\SQLEXPRESS;Initial Catalog='Coffeshop System';Integrated Security=True");
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)

        {
           
            string connectionString = @"Data Source=HABIBA\SQLEXPRESS;Initial Catalog='Coffeshop System';Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString)) ;
            {
                string query = @"INSERT INTO [dbo]. [UserInfo]
            ([email], [username], [password],[Adress],[phone])
            VALUES (@email, @username, @password, @address, @phone)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@email", textBox_email.Text);
                cmd.Parameters.AddWithValue("@username", textBox_user.Text);
                cmd.Parameters.AddWithValue("@password", textBox_pass1.Text);
                cmd.Parameters.AddWithValue("@address", textBox_Adress.Text);
                cmd.Parameters.AddWithValue("@phone", textBox_phone.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                Form3 ins = new Form3();
                ins.MdiParent = this.MdiParent;
                this.Hide();
                ins.ShowDialog();
                // SaldataAdapter da = new SqlDataAdapter(cmd);
                //DataTable dt = new DataTable();
                //da.Fill (dt);
            } }

                
        
            private void Form2_Load(object sender, EventArgs e)
            {
                conn = new SqlConnection(@"Data Source=desktop-94fv2gg\sqlexpress;Initial Catalog=CoffeShop;Integrated Security=True");
                conn.Open();
            }

            private void textBox_pass1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_phone_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
