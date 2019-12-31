using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CadeMeuMedico.Models.Entities
{
    public class EspecialidadeMetadado
    {
        [Required(ErrorMessage = "Obrigatório informar o Nome da Especialidade")]
        [StringLength(80, ErrorMessage = "O Nome da Especialidade deve possuir no máximo 80 caracteres")]
        [Display(Name = "Especialidade")]
        public string Nome { get; set; }
    }
}