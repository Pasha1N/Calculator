using System.Windows.Forms;

namespace Calculator.Command
{
    internal class Numeral2 : ICommand
    {
        private Canculator canculator;
        private string symbol = "2";

        public Numeral2(Canculator canculator)
        {
            this.canculator = canculator;
        }

        public void Executive(Keys key)
        {
            if (key == Keys.NumPad2 || key == Keys.D2)
            {
                canculator.AddInBuffer(symbol);
            }
        }
    }
}