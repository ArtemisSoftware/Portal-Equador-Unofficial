using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PortalEquador.Models
{
    public class GrupoViewModel
    {

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

    }
}
