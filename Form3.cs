using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SWDesign1
{
  
    public partial class Form3 : Form
    {
        public static string name="";
        public static string price="" ;
        public static string quantity= "1";
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 ins = new Form4();
            ins.MdiParent = this.MdiParent;
            this.Hide();
            ins.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IproductFactory coffeFactory = new CoffeeFactory();

            Iproduct coffee = coffeFactory.createProduct();

            string yourChoice = coffee.YourChoice();

            MessageBox.Show(yourChoice, "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

             name = label1.Text;
             price = "45";
             quantity = "1";

            this.Hide();
            CartForm cart = new CartForm();
            cart.ShowDialog();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            IproductFactory pasteryFactory = new PasteryFactory();

            Iproduct pastery = pasteryFactory.createProduct();

            string yourChoice = pastery.YourChoice();

            MessageBox.Show(yourChoice, "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

             name = label9.Text;
             price = "25";
             quantity = "1";

            this.Hide();
            CartForm cart = new CartForm();
            cart.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IproductFactory coffeFactory = new CoffeeFactory();

            Iproduct coffee = coffeFactory.createProduct();

            string yourChoice = coffee.YourChoice();

            MessageBox.Show(yourChoice, "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

             name = label4.Text;
             price = "55";
            

            this.Hide();
            CartForm cart = new CartForm();
            cart.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            IproductFactory coffeFactory = new CoffeeFactory();

            Iproduct coffee = coffeFactory.createProduct();

            string yourChoice = coffee.YourChoice();

            MessageBox.Show(yourChoice, "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

             name = label7.Text;
             price = "50";
             

            this.Hide();
            CartForm cart = new CartForm();
            cart.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            IproductFactory coffeFactory = new CoffeeFactory();

            Iproduct coffee = coffeFactory.createProduct();

            string yourChoice = coffee.YourChoice();

            MessageBox.Show(yourChoice, "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
             name = label5.Text;
             price = "35";
             

            this.Hide();
            CartForm cart = new CartForm();
            cart.ShowDialog();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            IproductFactory coffeFactory = new CoffeeFactory();

            Iproduct coffee = coffeFactory.createProduct();

            string yourChoice = coffee.YourChoice();

            MessageBox.Show(yourChoice, "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

             name = label6.Text;
             price = "40";
             

            this.Hide();
            CartForm cart = new CartForm();
            cart.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            IproductFactory coffeFactory = new CoffeeFactory();

            Iproduct coffee = coffeFactory.createProduct();

            string yourChoice = coffee.YourChoice();

            MessageBox.Show(yourChoice, "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

             name = label3.Text;
             price = "40";
            
 
            this.Hide();
            CartForm cart = new CartForm();
            cart.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            IproductFactory pasteryFactory = new PasteryFactory();

            Iproduct pastery = pasteryFactory.createProduct();

            string yourChoice = pastery.YourChoice();

            MessageBox.Show(yourChoice, "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

             name = label11.Text;
             price = "35";
             

            this.Hide();
            CartForm cart = new CartForm();
            cart.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            IproductFactory pasteryFactory = new PasteryFactory();

            Iproduct pastery = pasteryFactory.createProduct();

            string yourChoice = pastery.YourChoice();

            MessageBox.Show(yourChoice, "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

             name = label12.Text;
             price = "45";
             

            this.Hide();
            CartForm cart = new CartForm();
            cart.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            IproductFactory pasteryFactory = new PasteryFactory();

            Iproduct pastery = pasteryFactory.createProduct();

            string yourChoice = pastery.YourChoice();

            MessageBox.Show(yourChoice, "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

             name = label10.Text;
             price = "40";
             

            this.Hide();
            CartForm cart = new CartForm();
            cart.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            IproductFactory pasteryFactory = new PasteryFactory();

            Iproduct pastery = pasteryFactory.createProduct();

            string yourChoice = pastery.YourChoice();

            MessageBox.Show(yourChoice, "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

             name = label8.Text;
             price = "50";
             

            this.Hide();
            CartForm cart = new CartForm();
            cart.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            IproductFactory pasteryFactory = new PasteryFactory();

            Iproduct pastery = pasteryFactory.createProduct();

            string yourChoice = pastery.YourChoice();

            MessageBox.Show(yourChoice, "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

             name = label2.Text;
             price = "30";

            this.Hide();
            CartForm cart = new CartForm();
            cart.ShowDialog();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
