using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hoşgeldiniz !");

        }

        private void label2_Click(object sender, EventArgs e)
        {
            double sayi1 = 0, sayi2 = 0, sonuç = 0;
            sayi1 = Convert.ToDouble("textBox1  .Text");
            sayi2= Convert.ToDouble("textBox2  .Text");
            sonuç = sayi1 + sayi2;
            label4.Text = Convert.ToString(sonuç);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi1 = 0, sayi2 = 0, sonuç = 0;
            sayi1 = Convert.ToDouble(textBox1.Text);
            sayi2 = Convert.ToDouble(textBox2 .Text);
            sonuç = sayi1 + sayi2;
            label4.Text = Convert.ToString(sonuç);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double sayi1 = 0, sayi2 = 0, sonuç = 0;
            sayi1 = Convert.ToDouble(textBox1.Text);
            sayi2 = Convert.ToDouble(textBox2.Text);
            sonuç = sayi1 - sayi2;
            label4.Text = Convert.ToString(sonuç);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double sayi1 = 0, sayi2 = 0, sonuç = 0;
            sayi1 = Convert.ToDouble(textBox1  .Text);
            sayi2 = Convert.ToDouble(textBox2  .Text);
            sonuç = sayi1 * sayi2;
            label4.Text = Convert.ToString(sonuç);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double sayi1 = 0, sayi2 = 0, sonuç = 0;
            sayi1 = Convert.ToDouble(textBox1  .Text);
            sayi2 = Convert.ToDouble(textBox2  .Text);
            sonuç = sayi1 / sayi2;
            label4.Text = Convert.ToString(sonuç);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
