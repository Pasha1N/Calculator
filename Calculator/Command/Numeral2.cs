using System.Windows.Forms;

namespace Calculator.Command
{
    internal class Numeral2 : ICommand
    {
        private Calculator calculator;
        private string symbol = "2";

        public Numeral2(Calculator calculator)
        {
            this.calculator = calculator;
        }

        public void Executive(Keys key)
        {
            if (key == Keys.NumPad2 || key == Keys.D2)
            {
                calculator.AddInBuffer(symbol);
            }
        }
    }
}