using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ucgen_Alanı_Hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int taban, yukseklik, alan=0;
            taban = Convert.ToInt32(textBox1.Text);
            yukseklik = Convert.ToInt32(textBox2.Text);
            alan = (taban * yukseklik) / 2;
            textBox3.Text = Convert.ToString(alan);
        }
    }
}
