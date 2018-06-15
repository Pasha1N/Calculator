using Calculator.Command;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        private ICollection<string> arithmeticOperations = new List<string>();
        private string bufferString;
        private ICollection<ICommand> commands = new List<ICommand>();

        public Calculator()
        {
            InitializeComponent();
            Initialization();
        }

        public bool AddEnabled => add.Enabled;

        public bool DivideEnabled => divide.Enabled;

        public bool MultiplyEnabled => multiply.Enabled;

        public bool MinusEnabled => minus.Enabled;

        private void add_Click(object sender, EventArgs e)
        {
            AddInBuffer("+");
        }

        private void Calculator_KeyDown(object sender, KeyEventArgs e)
        {
            foreach (ICommand command in commands)
            {
                command.Executive(e.KeyCode);
            }
        }

        private void conclusion_TextChanged(object sender, EventArgs e)
        {
            if (buffer.Text.Length > 0 && conclusion.Text.Length >= 1)
            {
                equally.Enabled = true;
            }
            else
            {
                equally.Enabled = false;
            }
        }

        private void ClearClick(object sender, EventArgs e)
        {
            bufferString = null;
            conclusion.Text = bufferString;

            if (bufferString == null)
            {
                divide.Enabled = false;
                multiply.Enabled = false;
                minus.Enabled = false;
                add.Enabled = false;
            }
        }

        private void divideClick(object sender, EventArgs e)
        {
            AddInBuffer("/");
        }

        private void EquallyClick(object sender, EventArgs e)
        {
            if (conclusion.Text.Length > 0 && buffer.Text.Length > 0)
            {
                buffer.Text = string.Concat(buffer.Text, conclusion.Text);
                conclusion.Text = null;
                string copyBuffer = buffer.Text;
                double result = 0;
                ICollection<char> operations = new List<char>();
                int startIndex = 0;
                IList<double> WholeNumbers = new List<double>();

                foreach (string arithmeticOperation in arithmeticOperations)
                {
                    operations.Add(Convert.ToChar(arithmeticOperation));
                }

                for (int i = 0; i < buffer.Text.Length; i++)
                {
                    foreach (char operation in operations)
                    {
                        if (buffer.Text[i] == operation)
                        {
                            string substring = buffer.Text.Substring(startIndex, i);
                            buffer.Text = buffer.Text.Remove(startIndex, i);
                            i -= i;
                            startIndex = i;
                            WholeNumbers.Add(double.Parse(substring));
                        }
                    }
                }

                buffer.Text = buffer.Text.Remove(0, 1);
                WholeNumbers.Add(double.Parse(buffer.Text));
                result = WholeNumbers[0];

                for (int j = 1; j < WholeNumbers.Count; j++)
                {
                    for (int i = 0; i < copyBuffer.Length; i++)
                    {
                        if (copyBuffer[i] == '+')
                        {
                            result += WholeNumbers[j];
                        }
                        else if (copyBuffer[i] == '-')
                        {
                            result -= WholeNumbers[j];
                        }
                        else if (copyBuffer[i] == '/')
                        {
                            result /= WholeNumbers[j];
                        }
                        else if (copyBuffer[i] == '*')
                        {
                            result *= WholeNumbers[j];
                        }
                    }
                }

                conclusion.Text = result.ToString();
                buffer.Text = null;
                equally.Enabled = false;

                divide.Enabled = false;
                multiply.Enabled = false;
                minus.Enabled = false;
                add.Enabled = false;

                Tag = true;
            }
        }

        private void minusClick(object sender, EventArgs e)
        {
            AddInBuffer("-");
        }

        private void multiplyClick(object sender, EventArgs e)
        {
            AddInBuffer("*");
        }

        private void Numeral0_Click(object sender, EventArgs e)
        {
            AddInBuffer("0");
        }

        private void Numeral1_Click(object sender, EventArgs e)
        {
            AddInBuffer("1");
        }

        private void Numeral2_Click(object sender, EventArgs e)
        {
            AddInBuffer("2");
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

        private void Numeral6_Click(object sender, EventArgs e)
        {
            AddInBuffer("6");
        }

        private void Numeral7_Click(object sender, EventArgs e)
        {
            AddInBuffer("7");
        }

        private void Numeral8_Click(object sender, EventArgs e)
        {
            AddInBuffer("8");
        }

        private void Numeral9_Click(object sender, EventArgs e)
        {
            AddInBuffer("9");
        }

        public void AddInBuffer(string symbol)
        {
            if (Tag != null)
            {
                conclusion.Text = null;
                Tag = null;
            }

            if (conclusion.Text != null)
            {
                divide.Enabled = true;
                multiply.Enabled = true;
                minus.Enabled = true;
                add.Enabled = true;
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
                conclusion.Text = string.Concat(conclusion.Text, symbol);
                buffer.Text = string.Concat(buffer.Text, conclusion.Text);
                conclusion.Text = null;

                divide.Enabled = false;
                multiply.Enabled = false;
                minus.Enabled = false;
                add.Enabled = false;
            }
            else
            {
                conclusion.Text = string.Concat(conclusion.Text, symbol);
            }
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