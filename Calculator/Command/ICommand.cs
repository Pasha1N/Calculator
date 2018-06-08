using System.Windows.Forms;

namespace Calculator.Command
{
    internal interface ICommand
    {
        void Executive(Keys key);
    }
}