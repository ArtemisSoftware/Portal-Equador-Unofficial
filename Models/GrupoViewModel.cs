using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PortalEquador.Models
{
    public class GrupoViewModel
    {


        public int Id { get; set; }


        [Required]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }


        [Display(Name = "Data de criação")]
        public DateTime DataCriacao { get; set; }


        [Display(Name = "Numero de Tipos")]
        public int NumeroTipos { get; set; }


        /*
        public class CriarGrupoViewModel
        {

            [Required]
            public string Descricao { get; set; } 

            public DateTime DataCriacao { get; set; }
        }


        public class DetalhesGrupoViewModel
        {

            public int Id { get; set; }

            public string Descricao { get; set; }

            public DateTime DataCriacao { get; set; }
        }
        */
    }
}
