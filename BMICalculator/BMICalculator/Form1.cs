using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMICalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double w = Convert.ToInt32(textBox1.Text);
            double h = Convert.ToDouble(textBox2.Text);
            double bmi = w / (h * h);
            textBox3.Text = Convert.ToString(bmi);
            if(bmi < 18.5)
            {
                textBox4.Text = "Zayıf";
            }
            if(18.5 < bmi && bmi < 24.9)
            {
                textBox4.Text = "Normal Kilo";
            }
            if (bmi < 25 && bmi< 29.9)
            {
                textBox4.Text = "Balık Etli";
            }
            if(bmi > 30)
            {
                textBox4.Text = "Obez";
            }




        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
