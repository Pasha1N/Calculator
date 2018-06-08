using System.Windows.Forms;

namespace Calculator.Command
{
    internal class Numeral4 : ICommand
    {
        private Canculator canculator;
        private string symbol = "4";

        public Numeral4(Canculator canculator)
        {
            this.canculator = canculator;
        }

        public void Executive(Keys key)
        {
            if (key == Keys.NumPad4 || key == Keys.D4)
            {
                canculator.AddInBuffer(symbol);
            }
        }
    }
}