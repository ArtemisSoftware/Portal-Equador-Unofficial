using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PortalEquador.Data
{
    public class Contrato : DataBase
    {

        [Key]
        public int Id { get; set; }


        [ForeignKey("IdEmpregado")]
        public Empregado Empregado { get; set; }

        public string IdEmpregado { get; set; }



        [ForeignKey("IdFuncao")]
        public Tipo Funcao { get; set; }

        public int IdFuncao { get; set; }



        [ForeignKey("IdEmpresa")]
        public Tipo Empresa { get; set; }
        public int IdEmpresa { get; set; }


        public DateTime DataInicio { get; set; }




        public DateTime DataTermino { get; set; }

        public int Motivo { get; set; }


        //public int Status { get; set; }



        public bool Ativo { get; set; }
    }
}
