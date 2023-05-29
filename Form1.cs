using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SWDesign1
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader dr;
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty || textBox2.Text != string.Empty)
            {
                if (textBox1.Text != string.Empty || textBox2.Text != string.Empty)
                {

                    string email = textBox1.Text;
                    string pass = textBox2.Text;

                    User user = new User();
                    dr = user.login(email, pass);

                    if (dr.Read())
                    {
                        dr.Close();
                        this.Hide();
                        // Home home = new Home();//lma nhot l homepage
                        //home.ShowDialog();
                    }
                    else
                    {
                        dr.Close();
                        MessageBox.Show("No Account avilable with this email and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form2 ins = new Form2();
            ins.MdiParent = this.MdiParent;
            this.Hide();
            ins.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 ins = new Form3();
            ins.MdiParent = this.MdiParent;
            this.Hide();
            ins.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"Data Source=desktop-94fv2gg\sqlexpress;Initial Catalog=CoffeShop;Integrated Security=True");
            conn.Open();

        }
    }
}
