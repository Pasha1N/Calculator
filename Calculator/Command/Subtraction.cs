using System.Windows.Forms;

namespace Calculator.Command
{
    internal class Subtraction : ICommand
    {
        private Canculator canculator;
        private string symbol = "-";

        public Subtraction(Canculator canculator)
        {
            this.canculator = canculator;
        }

        public void Executive(Keys key)
        {
            if (key == Keys.Subtract)
            {
                canculator.AddInBuffer(symbol);
            }
        }
    }
}