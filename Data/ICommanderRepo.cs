using System.Collections.Generic;
using NetApi.Models;

namespace NetApi.Data
{
    public interface ICommanderRepo
    {
        bool SaveChanges();

        IEnumerable<Command> GetCommands();
        Command GetCommandById(int id);
        void CreateCommand(Command cmd);

    }
}
