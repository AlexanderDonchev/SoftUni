using Empires.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empires.Commands;
using System.Reflection;

namespace Empires.Core
{

    class CommandExecutor : ICommandExecutor
    {
        private IDatabase database;

        public CommandExecutor(IDatabase database)
        {
            this.Database = database;
        }

        public IDatabase Database { get { return this.database; } private set { this.database = value; } }
        public string Execute(Command command)
        {
            NewTurn(this.database);
            string output = null;

            switch (command.CommandName)
            {
                case "build":
                  
                    IBuilding building = (IBuilding)(ExecuteBuild(command.CommandArguments));

                    this.database.Buildings.Add(building);
                    break;
                    
                case "skip":
                    break;
                    
                    
            }
            ApplyTurn(this.Database);
            return output;
        }

        public static object ExecuteBuild(IList<string> commandargs)
        {
            var assemblyName = "Empires.Buildings.";
            var buildingTypeName = commandargs[0];
            Type buildingType = Assembly
                .GetExecutingAssembly()
                .GetType(assemblyName + buildingTypeName);
            var building = Activator.CreateInstance(buildingType) as IBuilding;
            return building;
        }

        private static void ApplyTurn(IDatabase db)
        {
            foreach(var building in db.Buildings)
            {
                building.TurnsElapsed++;
            }
        }

        private static void NewTurn(IDatabase db)
        {
            foreach (var building in db.Buildings)
            {
                if (building.CanProduceUnit())
                {
                    var unit = building.ProduceUnit();
                    db.Units.Add(unit);
                }

                if (building.CanProduceResource())
                {
                    var resource = building.ProduceResource();
                    db.AddResource(resource);
                }
            }
        }
    }
}
