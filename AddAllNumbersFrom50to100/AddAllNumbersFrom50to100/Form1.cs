using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddAllNumbersFrom50to100
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, sum = 0;
            for (i = 50; i <= 100; i++)
            {
                sum += i;
                listBox1.Items.Add(i);
            }
        }
    }
}
