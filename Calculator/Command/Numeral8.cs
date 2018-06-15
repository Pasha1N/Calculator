using System.Windows.Forms;

namespace Calculator.Command
{
    internal class Numeral8 : ICommand
    {
        private Calculator calculator;
        private string symbol = "8";

        public Numeral8(Calculator calculator)
        {
            this.calculator = calculator;
        }

        public void Executive(Keys key)
        {
            if (key == Keys.NumPad8 || key == Keys.D8)
            {
                calculator.AddInBuffer(symbol);
            }
        }
    }
}