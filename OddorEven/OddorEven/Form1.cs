using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OddorEven
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double result = 0;
            if(radioButton1.Checked == true)
            {
                double i;
                for (i = a; i <= b; i++)
                {
                    result += i;
                    textBox3.Text = Convert.ToString(result);
                }
            }
            if(radioButton2.Checked == true)
            {
                if (a % 2 == 1)
                {
                    double i;
                    for (i = a; i <= b; i= i+2)
                    {
                        result += i;
                        textBox3.Text = Convert.ToString(result);
                    }     
                }
                if(a % 2 == 0)
                {
                    a++;
                    double i;
                    for (i = a; i <= b; i= i + 2)
                    {
                        result += i;
                        textBox3.Text = Convert.ToString(result);
                    }
                }
            }
            if(radioButton3.Checked == true)
            {
                if(a%2 == 0)
                {
                    double i;
                    for (i = a; i <= b; i = i + 2)
                    {
                        result += i;
                        textBox3.Text = Convert.ToString(result);
                    }
                }
                if(a%2 == 1)
                {
                    a++;
                    double i;
                    for(i=a;i<=b; i= i + 2)
                    {
                        result += i;
                        textBox3.Text = Convert.ToString(result);
                    }
                }
            }
        }
    }
}
