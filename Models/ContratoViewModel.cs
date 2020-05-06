using PortalEquador.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PortalEquador.Models
{
    public class ContratoViewModel
    {


        //public Empregado Empregado { get; set; }


        [Display(Name = "Empregado")]
        public string IdEmpregado { get; set; }


        public TipoViewModel Funcao { get; set; }

        [Display(Name = "Função")]
        public int IdFuncao { get; set; }



        public TipoViewModel Empresa { get; set; }

        [Display(Name = "Empresa")]
        public int IdEmpresa { get; set; }


        [Display(Name = "Data Inicio")]
        public DateTime DataInicio { get; set; }

    }
}
