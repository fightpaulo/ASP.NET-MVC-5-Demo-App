using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CadeMeuMedico.Models.ViewModels
{
    public class MedicoViewModel
    {
        public List<Medico> Medicos { get; set; }
        public string TextoPesquisaMedico { get; set; }
    }
}