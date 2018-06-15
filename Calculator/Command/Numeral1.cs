using System.Windows.Forms;

namespace Calculator.Command
{
    internal class Numeral1 : ICommand
    {
        private Calculator calculator;
        private string symbol = "1";

        public Numeral1(Calculator calculator)
        {
            this.calculator = calculator;
        }

        public void Executive(Keys key)
        {
            if (key == Keys.NumPad1 || key == Keys.D1)
            {
                calculator.AddInBuffer(symbol);
            }
        }
    }
}