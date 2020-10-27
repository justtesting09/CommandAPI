using System.Collections.Generic; 
using CommandAPI.Models; 

namespace CommandAPI.Data 
{
    public class MockCommandAPIRepo : ICommandAPIRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command
                {
                    Id = 0, 
                    HowTo = "How to generate a migration",
                    CommandLine = "dotnet ef migrations add <Name of migration>",
                    Platform = ".NetCoreEF",
                },
                new Command
                {
                    Id = 1, 
                    HowTo = "Run migrations",
                    CommandLine = "dotnet ef migrations add <Name of migration>",
                    Platform = ".NetCoreEF",
                },
                new Command
                {
                    Id = 3, 
                    HowTo = "List active migrations",
                    CommandLine = "dotnet ef migrations add <Name of migration>",
                    Platform = ".NetCoreEF",
                }
            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{
                Id=0,
                HowTo = "How to generate a migration",
                CommandLine ="dotnet ef migraions add <name of migration>",
                Platform=".NetCoreEF"
            };
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }
    }
}