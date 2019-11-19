using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EhliyetAlmayaUygunlukYasKontrolSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double yas = Convert.ToInt32(textBox1.Text);
            if(yas >= 18)
            {
                MessageBox.Show("Yaşınız Ehliyet almaya uygundur!", "Ehliyet Almaya Uygunluk Yaş Kontrol Sistemi", MessageBoxButtons.OKCancel);
            }
            else
            {
                MessageBox.Show("Yaşınız Ehliyet almaya uygun değildir!", "Ehliyet Almaya Uygunluk Yaş Kontrol Sistemi", MessageBoxButtons.OKCancel);
            }
        }
    }
}
