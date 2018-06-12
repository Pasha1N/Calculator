using System.Windows.Forms;

namespace Calculator.Command
{
    internal class Multiply : ICommand
    {
        private Calculator calculator;
        private string symbol = "*";

        public Multiply(Calculator canculator)
        {
            this.calculator = canculator;
        }

        public void Executive(Keys key)
        {
            if (key == Keys.Multiply)
            {
                calculator.AddInBuffer(symbol);
            }
        }
    }
}