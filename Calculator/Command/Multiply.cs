using System.Windows.Forms;

namespace Calculator.Command
{
    internal class Multiply : ICommand
    {
        private Calculator calculator;
        private string symbol = "*";

        public Multiply(Calculator calculator)
        {
            this.calculator = calculator;
        }

        public void Executive(Keys key)
        {
            if (key == Keys.Multiply&&calculator.MultiplyEnabled)
            {
                calculator.AddInBuffer(symbol);
            }
        }
    }
}