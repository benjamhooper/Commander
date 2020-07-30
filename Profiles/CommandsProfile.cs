using AutoMapper;
using Commander.DTOS;
using Commander.Models;

namespace Commander.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            //Source -> Target
           CreateMap<Command, CommandReadDto>(); 

           CreateMap<CommandCreateDto, Command>();

           CreateMap<CommandUpdateDto, Command>();

           CreateMap<Command, CommandUpdateDto>();
        }
    }
}