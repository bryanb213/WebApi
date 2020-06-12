using System.Collections.Generic;
using System.Linq;
using NetApi.Models;

namespace NetApi.Data
{
    public class SqlCommanderRepo : ICommanderRepo
    {
        private readonly DataContext _repo;
        public SqlCommanderRepo(DataContext context)
        {
            _repo = context;
        }
        public Command GetCommandById(int id)
        {
            return _repo.Commands.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable <Command> GetCommands()
        {
            return _repo.Commands.ToList();
        }
    }
}