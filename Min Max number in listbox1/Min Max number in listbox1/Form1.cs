using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Min_Max_number_in_listbox1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double min = Convert.ToDouble(listBox1.Items[0]);
            double number;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                number = Convert.ToDouble(listBox1.Items[i]); 
                if (number < min)
                {
                    min = number;
                }
                textBox2.Text = Convert.ToString(min);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double max = Convert.ToDouble(listBox1.Items[0]);
            double number;
            for (int i = 0; i < listBox1.Items.Count ; i++)
            {
                number = Convert.ToDouble(listBox1.Items[i]);
                if (number > max)
                { 
                    max = number;
                }
                textBox2.Text = Convert.ToString(max);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
