using Api.Domain.Dtos.Cep;
using Api.Domain.Dtos.Municipio;
using Api.Domain.Dtos.Uf;
using Api.Domain.Dtos.User;
using Api.Domain.Models;
using AutoMapper;

namespace Api.CrossCutting.Mappings
{
    public class DtoToModelProfile: Profile
    {
        public DtoToModelProfile()
        {
            #region User
            CreateMap<UserModel, UserDto>()
                    .ReverseMap();
            CreateMap<UserModel, UserDtoCreate>()
                    .ReverseMap();
            CreateMap<UserModel, UserDtoUpdate>()
                    .ReverseMap();
            #endregion

            #region Uf
            CreateMap<UfModel, UfDto>()
                    .ReverseMap();
            #endregion
            
            #region Municipio
            CreateMap<MunicipioModel, MunicipioDto>()
                    .ReverseMap();
            CreateMap<MunicipioModel, MunicipioDtoCreate>()
                    .ReverseMap();
            CreateMap<MunicipioModel, MunicipioDtoUpdate>()
                    .ReverseMap();
            #endregion

            #region Cep
            CreateMap<CepModel, CepDto>()
                    .ReverseMap();
            CreateMap<CepModel, CepDtoCreate>()
                    .ReverseMap();
            CreateMap<CepModel, CepDtoUpdate>()
                    .ReverseMap();
            #endregion
            
        }
    }
}
