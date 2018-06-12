using System.Windows.Forms;

namespace Calculator.Command
{
    internal class Divide : ICommand
    {
        private Calculator calculator;
        private string symbol = "/";

        public Divide(Calculator canculator)
        {
            this.calculator = canculator;
        }

        public void Executive(Keys key)
        {
            if (key == Keys.Divide)
            {
                calculator.AddInBuffer(symbol);
            }
        }
    }
}