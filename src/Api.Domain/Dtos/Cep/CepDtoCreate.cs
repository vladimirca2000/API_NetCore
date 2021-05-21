using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos.Cep
{
    public class CepDtoCreate
    {
        [Required(ErrorMessage = "CEP é Obrigatório")]
        [StringLength(10, ErrorMessage = "CEP deve ter no maximo {1} caracteres.")]
        public string Cep { get; set; }

        [Required(ErrorMessage = "Logradouro é Obrigatório")]
        [StringLength(60, ErrorMessage = "Logradouro deve ter no maximo {1} caracteres.")]
        public string Logradouro { get; set; }

        [StringLength(10, ErrorMessage = "Número deve ter no maximo {1} caracteres.")]
        public string Numero { get; set; }
        
        [Required(ErrorMessage = "Município é Obrigatório")]
        public Guid MunicipioId { get; set; }
    }
}
