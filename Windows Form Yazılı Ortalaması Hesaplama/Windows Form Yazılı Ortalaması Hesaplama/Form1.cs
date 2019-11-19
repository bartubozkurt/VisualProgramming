using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Form_Yazılı_Ortalaması_Hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double v1, v2, f, ort;
            v1 = Convert.ToDouble(textBox1.Text);
            v2 = Convert.ToDouble(textBox2.Text);
            f = Convert.ToDouble(textBox3.Text);
            ort = (v1 + v2 + f) / 3;
            textBox4.Text = Convert.ToString(ort);
            if(ort >= 50)
            {
                textBox5.Text = "GEÇTİNİZ ! :)";
                textBox5.ForeColor = Color.Green;
            }
            else
            {
                textBox5.Text = "KALDINIZ ! :(";
                textBox5.ForeColor = Color.Red;
            }
        }
    }
}
