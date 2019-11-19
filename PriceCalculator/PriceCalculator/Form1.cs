using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PriceCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double unitPrice, tax, totalPrice;
            int amount;
            unitPrice = Convert.ToDouble(textBox1.Text);
            amount = Convert.ToInt16(textBox2.Text);
            tax = Convert.ToDouble(textBox3.Text);
            totalPrice = unitPrice * amount * (1 + tax / 100);
            if(checkBox1.Checked == true)
            {
                totalPrice = totalPrice * 0.95;
            }
            textBox4.Text = Convert.ToString(totalPrice);
        }
    }
}
