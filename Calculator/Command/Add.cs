﻿using System.Windows.Forms;

namespace Calculator.Command
{
    internal class Add : ICommand
    {
        private Calculator calculator;
        private string symbol = "+";

        public Add(Calculator calculator)
        {
            this.calculator = calculator;
        }

        public void Executive(Keys key)
        {
            if (key == Keys.Add&&calculator.AddEnabled)
            {
                calculator.AddInBuffer(symbol);
            }
        }
    }
}