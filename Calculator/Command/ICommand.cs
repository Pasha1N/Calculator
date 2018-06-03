using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Command
{
   internal interface ICommand
    {

        void Executive(ConsoleKeyInfo key);
    }
}
