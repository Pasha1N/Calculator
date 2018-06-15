using System.Windows.Forms;

namespace Calculator.Command
{
    internal class Numeral9 : ICommand
    {
        private Calculator calculator;
        private string symbol = "9";

        public Numeral9(Calculator calculator)
        {
            this.calculator = calculator;
        }

        public void Executive(Keys key)
        {
            if (key == Keys.NumPad9 || key == Keys.D9)
            {
                calculator.AddInBuffer(symbol);
            }
        }
    }
}