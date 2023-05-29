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
        SqlConnection conn;
        SqlCommand cmd;
        public Form2()
        {
            InitializeComponent();
        }
       
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

            if (textBox_email.Text != string.Empty || textBox_user.Text != string.Empty || textBox_pass1.Text != string.Empty || textBox_pass2.Text != string.Empty || textBox_Adress.Text != string.Empty || textBox_phone.Text != string.Empty)
            {
                if (textBox_pass1.Text == textBox_pass2.Text)
                {

                    string name = textBox_user.Text;
                    string email = textBox_email.Text;
                    string pass = textBox_pass1.Text;
                    string address = textBox_Adress.Text;
                    string phoneNo = textBox_phone.Text;


                    User user = new User();
                    user.register(name, email, pass, address, phoneNo);


                    MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Form1 login = new Form1();
                    login.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Passwords don't match ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



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

        private void Form2_Load_1(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"Data Source=desktop-94fv2gg\sqlexpress;Initial Catalog=CoffeShop;Integrated Security=True");
            conn.Open();

        }
    }
}
