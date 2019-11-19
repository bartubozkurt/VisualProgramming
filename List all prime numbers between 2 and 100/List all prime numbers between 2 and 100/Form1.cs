using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List_all_prime_numbers_between_2_and_100
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, j;
            for (i = 2; i < 200; i++)
            {
                bool f = true;
                for (j= 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        f = false;
                    }
                }
                if (f == true)
                {
                    listBox1.Items.Add(i);
                }
            }

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
