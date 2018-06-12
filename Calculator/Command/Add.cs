using System.Windows.Forms;

namespace Calculator.Command
{
    internal class Add : ICommand
    {
        private Calculator calculator;
        private string symbol = "+";

        public Add(Calculator canculator)
        {
            this.calculator = canculator;
        }

        public void Executive(Keys key)
        {
            if (key == Keys.Add)
            {
                calculator.AddInBuffer(symbol);
            }
        }
    }
}