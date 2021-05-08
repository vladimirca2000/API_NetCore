using Api.Domain.Entities;
using Api.Domain.Models;
using AutoMapper;

namespace Api.CrossCutting.Mappings
{
    public class ModelToEntityprofile: Profile
    {
        public ModelToEntityprofile()
        {
            CreateMap<UserEntity, UserModel>()
                .ReverseMap();
        }
    }
}
