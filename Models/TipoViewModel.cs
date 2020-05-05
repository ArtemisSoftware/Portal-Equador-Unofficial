using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PortalEquador.Models
{
    public class TipoViewModel
    {

        public int IdGrupo { get; set; }

        public int Id { get; set; }

        [Required]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }


        [Display(Name = "Código")]
        public string Codigo { get; set; }


        [Display(Name = "Data de criação")]
        public DateTime DataCriacao { get; set; }


        public bool Ativo { get; set; }

    }

    public class CriarTipoViewModel
    {


        [Display(Name = "Grupo")]
        public int IdGrupo { get; set; }


        public IEnumerable<SelectListItem> Grupos { get; set; }

        [Required]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }


        [Display(Name = "Código")]
        public string Codigo { get; set; }



    }
}
