﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddthestringwrittenintextBox1intolistBox1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ch = textBox1.Text;
            listBox1.Items.Add(ch);
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int indeks = listBox1.SelectedIndex;
            listBox1.Items.RemoveAt(indeks);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
