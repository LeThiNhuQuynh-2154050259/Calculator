﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

           

            if (txtA.Text != String.Empty && txtB.Text != String.Empty)


            {
                double a = double.Parse(txtA.Text);
                double b = double.Parse(txtB.Text);
                double c = a + b;
                txtKetQua.Text = c.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                double a = double.Parse(txtA.Text);
                double b = double.Parse(txtB.Text);
                double c = a - b;
                txtKetQua.Text = c.ToString();
            }
        }
    }
}
