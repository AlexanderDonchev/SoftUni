using Empires.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empires.Commands
{
    class Command : ICommand
    {
        private string commandName;
        private IList<string> commandArguments;

        public Command(string commandString)
        {
            string[] CommandSplit = commandString.Split(' ');
            this.commandName = CommandSplit[0];
            this.commandArguments = CommandSplit.Skip(1).ToArray();
        }

        public string CommandName
        {
            get
            {
                return this.commandName;
            }
        }

       public IList<string> CommandArguments
        {
            get
            {
                return this.commandArguments;
            }
        }
    }
}
