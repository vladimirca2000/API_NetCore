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

            CreateMap<UfEntity, UfModel>()
                .ReverseMap();
            
            CreateMap<MunicipioEntity, MunicipioModel>()
                .ReverseMap();

            CreateMap<CepEntity, CepModel>()
                .ReverseMap();
        }
    }
}
