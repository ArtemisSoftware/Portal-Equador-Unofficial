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
        public int NumberUpdated { get; set; }

        public List<GrupoViewModel> Grupos { get; set; }
    }
}
