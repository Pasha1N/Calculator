using System.Windows.Forms;

namespace Calculator.Command
{
    internal class Numeral6 : ICommand
    {
        private Canculator canculator;
        private string symbol = "6";

        public Numeral6(Canculator canculator)
        {
            this.canculator = canculator;
        }

        public void Executive(Keys key)
        {
            if (key == Keys.NumPad6 || key == Keys.D6)
            {
                canculator.AddInBuffer(symbol);
            }
        }
    }
}