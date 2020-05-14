using Microsoft.AspNetCore.Mvc.Rendering;
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
        public int Id { get; set; }


        public EmpregadoViewModel Empregado { get; set; }

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



    public class CriarContratoViewModel
    {

        [Required]
        public string Nome { get; set; }


        [Display(Name = "Nº Mecanográfico")]
        [Required]
        public string NumeroMecanografico { get; set; }



        [Display(Name = "Data Inicio")]
        [Required]
        public string DataInicio { get; set; }



        public IEnumerable<SelectListItem> Funcoes { get; set; }

        public int PosicaoFuncao { get; set; }

        [Display(Name = "Função")]
        public int IdFuncao { get; set; }



        public IEnumerable<SelectListItem> Empresas { get; set; }

        public int PosicaoEmpresa { get; set; }

        [Display(Name = "Empresa")]
        public int IdEmpresa { get; set; }



    }

}
