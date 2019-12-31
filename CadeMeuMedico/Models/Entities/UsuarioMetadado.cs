using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CadeMeuMedico.Models.Entities
{
    public class UsuarioMetadado
    {
        [Required(ErrorMessage = "Obrigatório informar o Nome do Usuário")]
        [StringLength(80, ErrorMessage = "O Nome do Usuário deve possuir no máximo 80 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Login")]
        [StringLength(30, ErrorMessage = "O Login deve possuir no máximo 30 caracteres")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a Senha")]
        [StringLength(100, ErrorMessage = "A senha deve possuir no máximo 100 caracteres")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o E-mail")]
        [StringLength(100, ErrorMessage = "O E-mail deve possuir no máximo 100 caracteres")]
        public string Email { get; set; }
    }
}