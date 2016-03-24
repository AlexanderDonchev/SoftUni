using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empires.Interfaces
{
    interface ICommand
    {
        string CommandName { get; }
        IList<string> CommandArguments { get; }
    }
}
