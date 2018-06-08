using System.Windows.Forms;

namespace Calculator.Command
{
    internal class Numeral0 : ICommand
    {
        private Canculator canculator;
        private string symbol = "0";

        public Numeral0(Canculator canculator)
        {
            this.canculator = canculator;
        }

        public void Executive(Keys key)
        {
            if (key == Keys.NumPad0 || key == Keys.D0)
            {
                canculator.AddInBuffer(symbol);
            }
        }
    }
}