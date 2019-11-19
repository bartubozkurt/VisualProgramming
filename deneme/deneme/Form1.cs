using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            string tmp = "";

            listBox1.Sorted = true;
            foreach (char i in text)
            {
                if(i == ' ')
                {
                    listBox1.Items.Add(tmp);
                    tmp = null;
                }
                else
                {
                    tmp += i;
                }
            }
            listBox1.Items.Add(tmp);
        }
    }
}
