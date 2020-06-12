using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using NetApi.Models;

namespace NetApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly DataContext _repo;
        public CommandsController(DataContext context)
        {
            _repo = context;
        }

        [HttpGet]
        public ActionResult <IEnumerable<Command>>GetCommands()
        {
            
        }

        [HttpGet("{id}")]
        public ActionResult GetCommandById(int id)
        {

        }
    }
}