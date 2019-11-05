using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bartubozkurt2017280013odev2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("label2" + label2.Location);
            listBox1.Items.Add("checkBox1" + checkBox1.Location);
            listBox1.Items.Add("button1" + button1.Location);
            listBox1.Items.Add("richTextBox1" + richTextBox1.Location);
            listBox1.Items.Add("label1" + label1.Location);
            listBox1.Items.Add("progressBar1" + progressBar1.Location);
            listBox1.Items.Add("maskedTextBox1" + maskedTextBox1.Location);
            listBox1.Items.Add("listBox1" + listBox1.Location);
        }
        private string konum(int x, int y, int height, int width)
        {
            string a = ("(" + " " + x + "," + y + ")" + "-" +
          "(" + (x + width / 2) + "," + (y + height / 2) + ")");
            return a;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("label2 " + konum(label2.Location.X, label2.Location.Y,
                label2.Height, label2.Width));
            listBox1.Items.Add("checkBox1 " + konum(checkBox1.Location.X, checkBox1.Location.Y,
                checkBox1.Height, checkBox1.Width));
            listBox1.Items.Add("button1 " + konum(button1.Location.X, button1.Location.Y,
                button1.Height, button1.Width));
            listBox1.Items.Add("richTextBox1 " + konum(richTextBox1.Location.X, richTextBox1.Location.Y,
                richTextBox1.Height, richTextBox1.Width));
            listBox1.Items.Add("label1 " + konum(label1.Location.X, label1.Location.Y, 
                label1.Height, label1.Width));
            listBox1.Items.Add("progressBar1 " + konum(progressBar1.Location.X, progressBar1.Location.Y,
                progressBar1.Height, progressBar1.Width));
            listBox1.Items.Add("maskedTextBox1 " + konum(maskedTextBox1.Location.X, maskedTextBox1.Location.Y,
                maskedTextBox1.Height, maskedTextBox1.Width));
            listBox1.Items.Add("listBox1 " + konum(listBox1.Location.X, listBox1.Location.Y, 
                listBox1.Height, listBox1.Width));
        }
    }
}
