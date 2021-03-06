﻿using System.Windows.Forms;

namespace Calculator.Command
{
    internal class Divide : ICommand
    {
        private Calculator calculator;
        private string symbol = "/";

        public Divide(Calculator calculator)
        {
            this.calculator = calculator;
        }

        public void Executive(Keys key)
        {
            if (key == Keys.Divide&&calculator.DivideEnabled)
            {
                calculator.AddInBuffer(symbol);
            }
        }
    }
}