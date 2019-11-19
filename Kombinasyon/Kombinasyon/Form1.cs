using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kombinasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int faktorhesaplama(int sayi)
        {
            int sum = 1;
            for (int i = 1; i <= sayi; i++)
            {
                sum *= i;
            }
            return sum;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int n, r,sonuc;
            n = Convert.ToInt32(textBox1.Text);
            r = Convert.ToInt32(textBox2.Text);
            sonuc = faktorhesaplama(n) / (faktorhesaplama(r) * faktorhesaplama(n - r));
            textBox3.Text = Convert.ToString(sonuc);
        }
    }
}
