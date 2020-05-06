using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PortalEquador.Data
{
    public class Tipo : DataBase
    {

        [Key]
        public int Id { get; set; }


        [ForeignKey("RequestingEmployeeId")]
        public Employee RequestingEmployee { get; set; }

        public string RequestingEmployeeId { get; set; }




        public string Descricao { get; set; }


        public string Codigo { get; set; }


        public bool Ativo { get; set; }

    }
}
