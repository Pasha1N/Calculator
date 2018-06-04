﻿using System.Windows.Forms;

namespace Calculator.Command
{
    internal class Divide : ICommand
    {
        private Canculator canculator;
        private string symbol = "/";

        public Divide(Canculator canculator)
        {
            this.canculator = canculator;
        }

        public void Executive(Keys key)
        {
            if (key == Keys.Divide)
            {
                canculator.AddInBuffer(symbol);
            }
        }
    }
}