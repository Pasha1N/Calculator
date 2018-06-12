using System.Windows.Forms;

namespace Calculator.Command
{
    internal class Numeral6 : ICommand
    {
        private Calculator calculator;
        private string symbol = "6";

        public Numeral6(Calculator canculator)
        {
            this.calculator = canculator;
        }

        public void Executive(Keys key)
        {
            if (key == Keys.NumPad6 || key == Keys.D6)
            {
                calculator.AddInBuffer(symbol);
            }
        }
    }
}