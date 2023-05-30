using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SWDesign1
{
    public partial class CartForm : Form
    {
        SqlConnection conn;
        SqlCommand cmd;

        public static string method;
        public CartForm()
        {
            InitializeComponent();
        }

        private void CartForm_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"Data Source=desktop-94fv2gg\sqlexpress;Initial Catalog=CoffeShop;Integrated Security=True");
            conn.Open();

            label7.Text = Form3.name;
            label10.Text = Form3.price;
            label8.Text = Form3.quantity;
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            method = "Visa";
           
           /*string paymentMethod = method;
            string totalPrice = label10.Text;
            Payment payment = new Payment();
            payment.saveMethod(paymentMethod, totalPrice);*/


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User();
            Cart cart = new Cart();
           
            string email =Form1.usermail;
            string productName = label7.Text;
            string price = label10.Text;
            string quantity = label8.Text;

            cart.addToCart(email, productName, price, quantity);
            this.Hide();
            Form4 last = new Form4();
            last.ShowDialog();


        }
    }
}
