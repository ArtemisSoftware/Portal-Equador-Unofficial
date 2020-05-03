using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalEquador.Data
{
    public abstract class DataBase
    {

        public string IdCriador { get; set; }

        public DateTime DataCriacao { get; set; }

    }
}
