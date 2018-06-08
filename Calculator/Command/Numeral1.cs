using System.Windows.Forms;

namespace Calculator.Command
{
    internal class Numeral1 : ICommand
    {
        private Canculator canculator;
        private string symbol = "1";

        public Numeral1(Canculator canculator)
        {
            this.canculator = canculator;
        }

        public void Executive(Keys key)
        {
            if (key == Keys.NumPad1 || key == Keys.D1)
            {
                canculator.AddInBuffer(symbol);
            }
        }
    }
}