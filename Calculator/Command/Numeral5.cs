using System.Windows.Forms;

namespace Calculator.Command
{
    internal class Numeral5 : ICommand
    {
        private Canculator canculator;
        private string symbol = "5";

        public Numeral5(Canculator canculator)
        {
            this.canculator = canculator;
        }

        public void Executive(Keys key)
        {
            if (key == Keys.NumPad5)
            {
                canculator.AddInBuffer(symbol);
            }
        }
    }
}