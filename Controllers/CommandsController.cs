using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using NetApi.Data;
using NetApi.Dtos;
using NetApi.Models;

namespace NetApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly ICommanderRepo _repo;
        private readonly IMapper _map;
        public CommandsController(ICommanderRepo context, IMapper mapper)
        {
            _repo = context;
            _map = mapper;

        }

        [HttpGet]
        public ActionResult <IEnumerable<CommandDto>> GetCommands()
        {
            var commands = _repo.GetCommands();
            return Ok(_map.Map<IEnumerable<CommandDto>>(commands));
        }

        [HttpGet("{id}", Name = "GetCommandById")]
        public ActionResult <CommandDto> GetCommandById(int id)
        {
            var command =_repo.GetCommandById(id);
            if(command != null)
            {
                return Ok(_map.Map<CommandDto>(command));
            }

            return NotFound();
        }

        [HttpPost]
        public ActionResult <CommandDto> CreateCommand(CreateCommandDto dto)
        {
            var model = _map.Map<Command>(dto);
            _repo.CreateCommand(model);
            _repo.SaveChanges();

            var CmdDto = _map.Map<CommandDto>(model);

            return CreatedAtRoute(nameof(GetCommandById), new { Id = CmdDto.Id }, CmdDto);

            //return Ok(CmdDto);
        }

        [HttpPut("{id}")]
        public ActionResult UpdateCommand(int id, UpdateCommandDto dto)
        {
            var modelFromRepo = _repo.GetCommandById(id);
            if(modelFromRepo == null)
            {
                return NotFound();
            }

            _map.Map(dto, modelFromRepo);

            _repo.UpdateCommand(modelFromRepo);
            _repo.SaveChanges();

            return NoContent();
        }

        [HttpPatch("{id}")]
        public ActionResult PartialCommandUpdate(int id, JsonPatchDocument<UpdateCommandDto> patchDoc)
        {
            //get command
            var commandModelFromRepo = _repo.GetCommandById(id);

            //check if cmd exist 
            if(commandModelFromRepo == null)
            {
                return NotFound();
            }

            var commandToPatch = _map.Map<UpdateCommandDto>(commandModelFromRepo);
            patchDoc.ApplyTo(commandToPatch, ModelState);

            if(!TryValidateModel(commandToPatch))
            {
                return ValidationProblem(ModelState);
            }

            _map.Map(commandToPatch, commandModelFromRepo);

            _repo.UpdateCommand(commandModelFromRepo);
            _repo.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteCommand(int id)
        {
            var commandFromRepo = _repo.GetCommandById(id);
            if(commandFromRepo == null)
            {
                return NotFound();
            }
            _repo.DeleteCommand(commandFromRepo);
            _repo.SaveChanges();
            
            return NoContent();
        }
    }
}