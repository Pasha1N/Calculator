using System.Windows.Forms;

namespace Calculator.Command
{
    internal class Multiply : ICommand
    {
        private Canculator canculator;
        private string symbol = "*";

        public Multiply(Canculator canculator)
        {
            this.canculator = canculator;
        }

        public void Executive(Keys key)
        {
            if (key == Keys.Multiply)
            {
                canculator.AddInBuffer(symbol);
            }
        }
    }
}