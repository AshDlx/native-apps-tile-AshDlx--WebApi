using System.Linq;
using AutoMapper;
using PartyAtHomes_Lib;

namespace PartyAtHomes_WebApi.Services
{
    public class AutoMapperProfileConfiguration : Profile
    {
        public AutoMapperProfileConfiguration() : this("MyProfile")
        {
        }

        protected AutoMapperProfileConfiguration(string profileName)
            : base(profileName)
        {
            CreateMap<Event, EventDto>();
            CreateMap<Event, EventCRUDDto>();
            CreateMap<User, UserDto>();
        }
    }
}
