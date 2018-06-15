using System.Windows.Forms;

namespace Calculator.Command
{
    internal class Numeral4 : ICommand
    {
        private Calculator calculator;
        private string symbol = "4";

        public Numeral4(Calculator calculator)
        {
            this.calculator = calculator;
        }

        public void Executive(Keys key)
        {
            if (key == Keys.NumPad4 || key == Keys.D4)
            {
                calculator.AddInBuffer(symbol);
            }
        }
    }
}