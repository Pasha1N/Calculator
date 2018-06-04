using Calculator.Command;
using System;
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
        private string bufferString;
        private IList<ICommand> commands = new List<ICommand>();

        private IList<string> arithmeticOperations = new List<string>();

        public Canculator()
        {
            InitializeComponent();
            Initialization();


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
            //buffer.Text = "f";
            //StringBuilder copyBuffer = new StringBuilder(buffer.Text);

            //for(int i=0;i<copyBuffer.Length;i++)
            //{
            //    if (!char.IsNumber(Convert.ToChar(copyBuffer[i])))
            //    {
            //        foreach (string item in arithmeticOperations)
            //        {
            //            if (copyBuffer[i] == Convert.ToChar(item))
            //            {

            //            }
            //        }
            //    }


            //}



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
            bufferString = null;
            label1.Text = bufferString;
            if (bufferString == null)
            {
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
            if (bufferString != null)
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

        private void Canculator_KeyDown(object sender, KeyEventArgs e)
        {
            foreach(ICommand command in commands)
            {
                command.Executive(e.KeyCode);
            }
        }

        public void AddInBuffer(string symbol)
        {
            if (label1.Text != null)
            {
                divide.Enabled = true;
                multiply.Enabled = true;
                minus.Enabled = true;
                add.Enabled = true;
            }

            if (buffer.Text != null)
            {
                equally.Enabled = true;
            }

            bool @is = false;
            if (!char.IsNumber(Convert.ToChar(symbol)))
            {
                foreach (string item in arithmeticOperations)
                {
                    if (symbol == item)
                    {
                        @is = true;
                    }
                }
            }

            if (@is)
            {
                label1.Text = string.Concat(label1.Text, symbol);
                buffer.Text = string.Concat(buffer.Text, label1.Text);
                label1.Text = null;
            }
            else
            {
                label1.Text = string.Concat(label1.Text, symbol);
            }
            Console.Beep();
        }

        public void Initialization()
        {
            arithmeticOperations.Add("+");
            arithmeticOperations.Add("/");
            arithmeticOperations.Add("-");
            arithmeticOperations.Add("*");

            Numeral1 one = new Numeral1(this);
            Numeral2 two = new Numeral2(this);
            Numeral3 three = new Numeral3(this);
            Numeral4 four = new Numeral4(this);
            Numeral5 five = new Numeral5(this);
            Numeral6 six = new Numeral6(this);
            Numeral7 seven = new Numeral7(this);
            Numeral8 eight = new Numeral8(this);
            Numeral9 nine = new Numeral9(this);
            Numeral0 zero = new Numeral0(this);
            Add add = new Add(this);
            Divide divide = new Divide(this);
            Multiply multiply = new Multiply(this);
            Subtraction Subtraction = new Subtraction(this);

            commands.Add(zero);
            commands.Add(one);
            commands.Add(two);
            commands.Add(three);
            commands.Add(four);
            commands.Add(five);
            commands.Add(six);
            commands.Add(seven);
            commands.Add(eight);
            commands.Add(nine);
            commands.Add(add);
            commands.Add(divide);
            commands.Add(multiply);
            commands.Add(Subtraction);
        }
    }
}
