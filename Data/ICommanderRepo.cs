using System.Collections.Generic;
using NetApi.Models;

namespace NetApi.Data
{
    public interface ICommanderRepo
    {
        IEnumerable<Command> GetCommands();
        Command GetCommandById(int id);
    }
}
