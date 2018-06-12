using System.Windows.Forms;

namespace Calculator.Command
{
    internal class Numeral5 : ICommand
    {
        private Calculator calculator;
        private string symbol = "5";

        public Numeral5(Calculator canculator)
        {
            this.calculator = canculator;
        }

        public void Executive(Keys key)
        {
            if (key == Keys.NumPad5 || key == Keys.D5)
            {
                calculator.AddInBuffer(symbol);
            }
        }
    }
}