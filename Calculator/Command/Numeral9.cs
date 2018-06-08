using System.Windows.Forms;

namespace Calculator.Command
{
    internal class Numeral9 : ICommand
    {
        private Canculator canculator;
        private string symbol = "9";

        public Numeral9(Canculator canculator)
        {
            this.canculator = canculator;
        }

        public void Executive(Keys key)
        {
            if (key == Keys.NumPad9 || key == Keys.D9)
            {
                canculator.AddInBuffer(symbol);
            }
        }
    }
}