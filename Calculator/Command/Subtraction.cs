using System.Windows.Forms;

namespace Calculator.Command
{
    internal class Subtraction : ICommand
    {
        private Calculator calculator;
        private string symbol = "-";

        public Subtraction(Calculator calculator)
        {
            this.calculator = calculator;
        }

        public void Executive(Keys key)
        {
            if (key == Keys.Subtract&&calculator.MinusEnabled)
            {
                calculator.AddInBuffer(symbol);
            }
        }
    }
}