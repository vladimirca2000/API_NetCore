using System;
using Api.Domain.Dtos.Municipio;

namespace Api.Domain.Dtos.Cep
{
    public class CepDtoCompleto
    {
        public Guid Id { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public Guid MunicipioId { get; set; }
        public MunicipioDtoCompleta Municipio { get; set; }
    }
}
