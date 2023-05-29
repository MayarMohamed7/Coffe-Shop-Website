
namespace SWDesign1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label_phone = new System.Windows.Forms.Label();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Adress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_pass2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_pass1 = new System.Windows.Forms.TextBox();
            this.textBox_user = new System.Windows.Forms.TextBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label_phone);
            this.groupBox1.Controls.Add(this.textBox_phone);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox_Adress);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox_pass2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_pass1);
            this.groupBox1.Controls.Add(this.textBox_user);
            this.groupBox1.Controls.Add(this.textBox_email);
            this.groupBox1.Location = new System.Drawing.Point(1, 1);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(566, 729);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Signup";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(148, 603);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 27);
            this.button1.TabIndex = 15;
            this.button1.Text = "Create Account";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_phone
            // 
            this.label_phone.AutoSize = true;
            this.label_phone.BackColor = System.Drawing.Color.Transparent;
            this.label_phone.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_phone.ForeColor = System.Drawing.Color.Black;
            this.label_phone.Location = new System.Drawing.Point(24, 564);
            this.label_phone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_phone.Name = "label_phone";
            this.label_phone.Size = new System.Drawing.Size(141, 21);
            this.label_phone.TabIndex = 14;
            this.label_phone.Text = "Phone Number";
            this.label_phone.Click += new System.EventHandler(this.label7_Click);
            // 
            // textBox_phone
            // 
            this.textBox_phone.BackColor = System.Drawing.Color.White;
            this.textBox_phone.Location = new System.Drawing.Point(271, 558);
            this.textBox_phone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(232, 27);
            this.textBox_phone.TabIndex = 13;
            this.textBox_phone.TextChanged += new System.EventHandler(this.textBox_phone_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(24, 493);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(217, 63);
            this.label6.TabIndex = 12;
            this.label6.Text = "Enter your Adress\r\nStreet no, Building No,\r\nfloor .. etc";
            // 
            // textBox_Adress
            // 
            this.textBox_Adress.BackColor = System.Drawing.Color.White;
            this.textBox_Adress.Location = new System.Drawing.Point(271, 515);
            this.textBox_Adress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_Adress.Name = "textBox_Adress";
            this.textBox_Adress.Size = new System.Drawing.Size(232, 27);
            this.textBox_Adress.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(24, 458);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Re-enter Password";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox_pass2
            // 
            this.textBox_pass2.BackColor = System.Drawing.Color.White;
            this.textBox_pass2.Location = new System.Drawing.Point(271, 466);
            this.textBox_pass2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_pass2.Name = "textBox_pass2";
            this.textBox_pass2.Size = new System.Drawing.Size(232, 27);
            this.textBox_pass2.TabIndex = 6;
            this.textBox_pass2.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(25, 414);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(25, 369);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(25, 325);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Email\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_pass1
            // 
            this.textBox_pass1.BackColor = System.Drawing.Color.White;
            this.textBox_pass1.Location = new System.Drawing.Point(271, 419);
            this.textBox_pass1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_pass1.Name = "textBox_pass1";
            this.textBox_pass1.Size = new System.Drawing.Size(232, 27);
            this.textBox_pass1.TabIndex = 2;
            this.textBox_pass1.TextChanged += new System.EventHandler(this.textBox_pass1_TextChanged);
            // 
            // textBox_user
            // 
            this.textBox_user.BackColor = System.Drawing.Color.White;
            this.textBox_user.Location = new System.Drawing.Point(271, 371);
            this.textBox_user.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_user.Name = "textBox_user";
            this.textBox_user.Size = new System.Drawing.Size(232, 27);
            this.textBox_user.TabIndex = 1;
            // 
            // textBox_email
            // 
            this.textBox_email.BackColor = System.Drawing.Color.White;
            this.textBox_email.Location = new System.Drawing.Point(271, 325);
            this.textBox_email.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(232, 27);
            this.textBox_email.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 641);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_pass1;
        private System.Windows.Forms.TextBox textBox_user;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_pass2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Adress;
        private System.Windows.Forms.Label label_phone;
        private System.Windows.Forms.TextBox textBox_phone;
        private System.Windows.Forms.Button button1;
    }
}