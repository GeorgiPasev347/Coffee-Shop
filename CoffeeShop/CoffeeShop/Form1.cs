﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "User" && textBox2.Text == "1234")
            {
                Form2 formtwo = new Form2();
                formtwo.Show();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password! \n Try again! ", "System Warning");
            }
        }
    }
}
