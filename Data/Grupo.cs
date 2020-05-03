using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PortalEquador.Data
{
    public class Grupo : DataBase
    {

        [Key]
        public int Id { get; set; }


        public string Descricao { get; set; }


    }
}
