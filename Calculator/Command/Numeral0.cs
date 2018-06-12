using System.Windows.Forms;

namespace Calculator.Command
{
    internal class Numeral0 : ICommand
    {
        private Calculator calculator;
        private string symbol = "0";

        public Numeral0(Calculator canculator)
        {
            this.calculator = canculator;
        }

        public void Executive(Keys key)
        {
            if (key == Keys.NumPad0 || key == Keys.D0)
            {
                calculator.AddInBuffer(symbol);
            }
        }
    }
}