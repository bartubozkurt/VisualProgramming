using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBoxexp2
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
            string bildigi_diller = "";
            if(checkBox1.Checked == true)
            {
                bildigi_diller = bildigi_diller + "," + checkBox1.Text;
            }
            if (checkBox2.Checked == true)
            {
                bildigi_diller = bildigi_diller + "," + checkBox2.Text;
            }
            if (checkBox3.Checked == true)
            {
                bildigi_diller = bildigi_diller + "," + checkBox3.Text;
            }
            bildigi_diller = bildigi_diller.Substring(1);
            label2.Text = bildigi_diller;
        }
    }
}
