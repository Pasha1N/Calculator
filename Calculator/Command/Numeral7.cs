using System.Windows.Forms;

namespace Calculator.Command
{
    internal class Numeral7 : ICommand
    {
        private Calculator calculator;
        private string symbol = "7";

        public Numeral7(Calculator canculator)
        {
            this.calculator = canculator;
        }

        public void Executive(Keys key)
        {
            if (key == Keys.NumPad7 || key == Keys.D7)
            {
                calculator.AddInBuffer(symbol);
            }
        }
    }
}