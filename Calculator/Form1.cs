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
    public partial class Canculator : Form
    {
        private string buffer;
       // private IList<string> arithmeticOperations = new List<string>();

        public Canculator()
        {
            InitializeComponent();

            //arithmeticOperations.Add("+");
            //arithmeticOperations.Add("/");
            //arithmeticOperations.Add("-");
            //arithmeticOperations.Add("*");
            //arithmeticOperations.Add("=");
        }

        public void AddInBuffer(string symbol)
        {
            buffer = string.Concat(buffer, symbol);
            label1.Text = buffer;

            if (buffer != null)
            {
                equally.Enabled = true;
                divide.Enabled = true;
                multiply.Enabled = true;
                minus.Enabled = true;
                add.Enabled = true;
            }
            Console.Beep();
        }

        private void Numeral2_Click(object sender, EventArgs e)
        {
            AddInBuffer("2");
        }

        private void Numeral6_Click(object sender, EventArgs e)
        {
            AddInBuffer("6");
        }

        private void Numeral7_Click(object sender, EventArgs e)
        {
            AddInBuffer("7");
        }

        private void Numeral9_Click(object sender, EventArgs e)
        {
            AddInBuffer("9");
        }

        private void Equally_Click(object sender, EventArgs e)
        {
            AddInBuffer("=");
        }

        private void Numeral1_Click(object sender, EventArgs e)
        {
            AddInBuffer("1");
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            buffer = null;
            label1.Text = buffer;
            if (buffer == null)
            {
                equally.Enabled = false;
                divide.Enabled = false;
                multiply.Enabled = false;
                minus.Enabled = false;
                add.Enabled = false;
            }
        }

        private void Numeral3_Click(object sender, EventArgs e)
        {
            AddInBuffer("3");
        }

        private void Numeral4_Click(object sender, EventArgs e)
        {
            AddInBuffer("4");
        }

        private void Numeral5_Click(object sender, EventArgs e)
        {
            AddInBuffer("5");
        }

        private void Numeral8_Click(object sender, EventArgs e)
        {
            AddInBuffer("8");
        }

        private void Numeral0_Click(object sender, EventArgs e)
        {
            if (buffer != null)
            {
                AddInBuffer("0");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void divide_Click(object sender, EventArgs e)
        {
            AddInBuffer("/");
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            AddInBuffer("*");
        }

        private void minus_Click(object sender, EventArgs e)
        {
            AddInBuffer("-");
        }

        private void add_Click(object sender, EventArgs e)
        {
            AddInBuffer("+");
        }
    }
}
