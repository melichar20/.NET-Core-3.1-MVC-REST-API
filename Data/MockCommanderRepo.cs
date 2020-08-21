using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
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
                new Command{Id=0, HowTo="Boil and egg", Line="Boil water", Platform="Kettle and Pan"},
                new Command{Id=1, HowTo="Cut break", Line="Get a knief", Platform="knife & chopping board"},
                new Command{Id=2, HowTo="Make tea", Line="teabag in cup", Platform="Kettle and cup"}
            };

            return commands;
        }

        public Command GetCommandByID(int id) 
        {
            return new Command{Id=0, HowTo="Boil and egg", Line="Boil water", Platform="Kettle and Pan"};
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }
    }
}