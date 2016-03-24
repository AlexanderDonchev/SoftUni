using Empires.Core;
using Empires.Units;
using Empires.UserInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empires
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new Empire();
            var commandEx = new CommandExecutor(db);
            var userInterface = new ConsoleUserInterface();
            var engine = new Engine(userInterface, commandEx);
            engine.Run();
        }
    }
}
