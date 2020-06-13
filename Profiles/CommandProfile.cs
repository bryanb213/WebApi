using AutoMapper;
using NetApi.Models;
using NetApi.Dtos;

namespace NetApi.Profiles
{
    public class CommandProile : Profile
    {
        public CommandProile()
        {
            //Source -> Target
            CreateMap<Command, CommandDto>();
            CreateMap<CreateCommandDto, Command>();
        }
    }
}