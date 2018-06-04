using System.Windows.Forms;

namespace Calculator.Command
{
    internal class Numeral7 : ICommand
    {
        private Canculator canculator;
        private string symbol = "7";

        public Numeral7(Canculator canculator)
        {
            this.canculator = canculator;
        }

        public void Executive(Keys key)
        {
            if (key == Keys.NumPad7)
            {
                canculator.AddInBuffer(symbol);
            }
        }
    }
}