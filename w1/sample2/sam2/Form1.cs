﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sam2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)// submit
        {
            double n1;
            double.TryParse(textBox1.Text, out n1);
            textBox2.Text = (n1 * 2).ToString();

            
        }

        private void button1_Click(object sender, EventArgs e) // clear
        {
            textBox1.Text = textBox2.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
