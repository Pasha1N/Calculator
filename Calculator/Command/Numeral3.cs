using System.Windows.Forms;

namespace Calculator.Command
{
    internal class Numeral3 : ICommand
    {
        private Canculator canculator;
        private string symbol = "3";

        public Numeral3(Canculator canculator)
        {
            this.canculator = canculator;
        }

        public void Executive(Keys key)
        {
            if (key == Keys.NumPad3 || key == Keys.D3)
            {
                canculator.AddInBuffer(symbol);
            }
        }
    }
}