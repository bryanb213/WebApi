using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using NetApi.Data;
using NetApi.Models;

namespace NetApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly ICommanderRepo _repo;
        public CommandsController(ICommanderRepo context)
        {
            _repo = context;
        }

        [HttpGet]
        public ActionResult <IEnumerable<Command>> GetCommands()
        {
            var commands = _repo.GetCommands();
            return Ok(commands);
        }

        [HttpGet("{id}")]
        public ActionResult <Command> GetCommandById(int id)
        {
            var command =_repo.GetCommandById(id);

            return Ok(command);
        }
    }
}