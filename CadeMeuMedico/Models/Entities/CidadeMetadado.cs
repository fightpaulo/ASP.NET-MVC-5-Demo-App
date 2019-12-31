using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CadeMeuMedico.Models.Entities
{
    public class CidadeMetadado
    {
        [Required(ErrorMessage = "Obrigatório informar o Nome da Cidade")]
        [StringLength(100, ErrorMessage = "O campo Nome da Cidade deve possuir nó máximo 100 caracteres")]
        [Display(Name = "Cidade")]
        public string Nome { get; set; }
    }
}