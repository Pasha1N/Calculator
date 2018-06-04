using System.Windows.Forms;

namespace Calculator.Command
{
    internal class Add : ICommand
    {
        private Canculator canculator;
        private string symbol = "+";

        public Add(Canculator canculator)
        {
            this.canculator = canculator;
        }

        public void Executive(Keys key)
        {
            if (key == Keys.Add)
            {
                canculator.AddInBuffer(symbol);
            }
        }
    }
}