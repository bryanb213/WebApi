using System;
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

        public void CreateCommand(Command cmd)
        {
            if(cmd == null)
            {
                throw new ArgumentNullException(nameof(cmd));
            }

            _repo.Commands.Add(cmd);
        }

        public void DeleteCommand(Command cmd)
        {
            if(cmd == null)
            {
                throw new ArgumentNullException(nameof(cmd));
            }
            _repo.Remove(cmd);
        }

        public Command GetCommandById(int id)
        {
            return _repo.Commands.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable <Command> GetCommands()
        {
            return _repo.Commands.ToList();
        }

        public bool SaveChanges()
        {
            return (_repo.SaveChanges() >= 0);
        }

        public void UpdateCommand(Command cmd)
        {
            //Nothing
        }
    }
}