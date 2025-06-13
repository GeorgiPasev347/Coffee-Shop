using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double plsSugar = 0;
            if (checkBox1.Checked == true) { plsSugar = plsSugar + 2.50; }
            if (checkBox2.Checked == true) { plsSugar = plsSugar + 2; }
            if (checkBox3.Checked == true) { plsSugar = plsSugar + 3; }
            if (checkBox4.Checked == true) { plsSugar = plsSugar + 3.50; }
            double a = 0;
            if (comboBox1.Text == "1") { label2.Text = (a + 0).ToString(); }
            if (comboBox1.Text == "2") { label2.Text = (a + 0.2).ToString(); }
            if (comboBox1.Text == "3") { label2.Text = (a + 0.3).ToString(); }
            if (comboBox1.Text == "4") { label2.Text = (a + 0.5).ToString(); }
            label2.Text = (plsSugar+a).ToString();
           
        }
    }
}
