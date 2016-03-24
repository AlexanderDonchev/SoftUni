using Empires.Commands;
using Empires.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empires.Core
{
    class Engine : IEngine
    {
        private IUserInterface engineInterface;
        private CommandExecutor commandExecutor;

        public Engine(IUserInterface engineInterface, CommandExecutor commandExecutor)
        {
            this.commandExecutor = commandExecutor;
            this.engineInterface = engineInterface;
        }

        public void Run()
        {
            while (true)
            {
                var input = engineInterface.ReadLine();
                if (input == "armistice")
                {
                    break;
                }
                var command = new Command(input);
               var output = commandExecutor.Execute(command);
                engineInterface.WriteLine(output);
            }
        }
    }
}
