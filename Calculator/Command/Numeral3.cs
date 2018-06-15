using System.Windows.Forms;

namespace Calculator.Command
{
    internal class Numeral3 : ICommand
    {
        private Calculator calculator;
        private string symbol = "3";

        public Numeral3(Calculator calculator)
        {
            this.calculator = calculator;
        }

        public void Executive(Keys key)
        {
            if (key == Keys.NumPad3 || key == Keys.D3)
            {
                calculator.AddInBuffer(symbol);
            }
        }
    }
}