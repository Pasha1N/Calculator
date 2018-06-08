using System.Windows.Forms;

namespace Calculator.Command
{
    internal class Numeral8 : ICommand
    {
        private Canculator canculator;
        private string symbol = "8";

        public Numeral8(Canculator canculator)
        {
            this.canculator = canculator;
        }

        public void Executive(Keys key)
        {
            if (key == Keys.NumPad8)
            {
                canculator.AddInBuffer(symbol);
            }
        }
    }
}