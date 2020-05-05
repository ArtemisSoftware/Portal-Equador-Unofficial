using AutoMapper;
using PortalEquador.Data;
using PortalEquador.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalEquador.Mappings
{
    public class Maps : Profile
    {

        public Maps()
        {
            CreateMap<Grupo, GrupoViewModel>().ReverseMap();
            CreateMap<Tipo, TipoViewModel>().ReverseMap();
        }

    }
}
