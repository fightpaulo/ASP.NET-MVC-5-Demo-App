using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CadeMeuMedico.Models.Entities
{    
    public class MedicoMetadado
    {
        [Required(ErrorMessage = "Obrigatório informar o CRM")]
        [StringLength(30, ErrorMessage = "O CRM deve possuir no máximo 30 caracteres")]
        public string CRM { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Nome")]
        [StringLength(30, ErrorMessage = "O Nome deve possuir no máximo 30 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Endereço")]
        [StringLength(100, ErrorMessage = "O Endereço deve possuir no máximo 100 caracteres")]
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Bairro")]
        [StringLength(60, ErrorMessage = "O Bairro deve possuir no máximo 60 caracteres")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o E-mail")]
        [StringLength(100, ErrorMessage = "O E-mail deve possuir no máximo 100 caracteres")]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Obrigatório informar se Atende por Convênio")]
        [Display(Name = "Atende por Convênio")]
        public bool AtendePorConvenio { get; set; }

        [Required(ErrorMessage = "Obrigatório informar se Tem Clínica")]
        [Display(Name = "Tem Clínica")]
        public bool TemClinica { get; set; }

        [StringLength(80, ErrorMessage = "O Website deve possuir no máximo 80 caracteres")]
        [Display(Name = "WebSite Blog")]
        public string WebsiteBlog { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a Cidade")]
        public int IDCidade { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a Especialidade")]
        public int IDEspecialidade { get; set; }
        
    }
}