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
        private readonly DataContext _repo;
        public CommandsController(DataContext context)
        {
            _repo = context;
        }

        [HttpGet]
        public ActionResult <IEnumerable<Command>>GetCommands()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public ActionResult GetCommandById(int id)
        {
            return Ok();
        }
    }
}