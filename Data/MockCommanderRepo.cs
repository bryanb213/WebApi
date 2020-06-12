using System.Collections.Generic;
using NetApi.Models;

namespace NetApi.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public Command GetCommandById(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetCommands()
        {
            throw new System.NotImplementedException();
        }
    }
}