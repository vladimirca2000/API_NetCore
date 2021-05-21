using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos.Municipio
{
    public class MunicipioDtoCreate
    {
        [Required(ErrorMessage = "Nome do Município é Obrigatório")]
        [StringLength(60, ErrorMessage = "Nome do Município deve ter no maximo {1} caracteres.")]
        public string Nome { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Código do IBGE Inválido")]
        public int CodIbge { get; set; }

        [Required(ErrorMessage = "Unidade Federativa é Obrigatório")]
        public Guid UfId { get; set; }
    }
}
