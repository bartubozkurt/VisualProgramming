using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Addevenoddnumbersfrom50to100
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            for (i = 50; i <= 100; i++)
            {
                 if(i % 2 == 0)
                {
                    listBox2.Items.Add(i);

                }
                else
                {
                    listBox1.Items.Add(i);
                }
            }
        }
    }
}
