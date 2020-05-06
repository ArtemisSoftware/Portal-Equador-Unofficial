using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PortalEquador.Data;
using PortalEquador.Models;
using PortalEquador.Util.Constantes;

namespace PortalEquador.Controllers
{
    public class TiposController : Controller
    {


        //private readonly ILeaveTypeRepository _repo;
        private readonly IMapper _mapper;



        public TiposController(/*ILeaveTypeRepository repo, */IMapper mapper)
        {
            //this._repo = repo;
            this._mapper = mapper;
        }






        // GET: Tipos
        public ActionResult Index(int id)
        {
            /*
            var tip os = _repo.FindAll().ToList();
            var modelo = _mapper.Map<List<Tipo>, List<TipoViewModel>>(tipos);
            */


            List<GrupoViewModel> grupos = new List<GrupoViewModel>();
            grupos.Add(new GrupoViewModel
            {
                Id = 12,
                Descricao = "Grupo um"
            });
            grupos.Add(new GrupoViewModel
            {
                Id = 2,
                Descricao = "Grupo dois"
            });

            var items = grupos.Select(resultado => new SelectListItem
            {

                Text = resultado.Descricao,
                Value = resultado.Id.ToString()

            });


            int posicao = 0;

            if (id != 0)
            {
                foreach (SelectListItem item in items)
                {
                    ++posicao;

                    if (item.Value == id.ToString())
                    {
                        break;
                    }
                }
            }


            List<TipoViewModel> tipos = new List<TipoViewModel>();
            tipos.Add(new TipoViewModel
            {
                Id = 0,
                Descricao = "Tipo um",
                Codigo = "TU",
                Ativo = true,
                DataCriacao = DateTime.Now
            });
            tipos.Add(new TipoViewModel
            {
                Id = 1,
                Descricao = "Tipo dois",
                Codigo = "TD",
                Ativo = false,
                DataCriacao = DateTime.Now
            });

            var modelo = new ListaTipoViewModel
            {
                Grupos = items,
                Tipos = tipos,
                Ordem = posicao
            };



            return View(modelo);
        }

        [HttpPost]
        public ActionResult Index(ListaTipoViewModel value)
        {
            /*
            var tip os = _repo.FindAll().ToList();
            var modelo = _mapper.Map<List<Tipo>, List<TipoViewModel>>(tipos);
            */


            List<GrupoViewModel> grupos = new List<GrupoViewModel>();
            grupos.Add(new GrupoViewModel
            {
                Id = 1,
                Descricao = "Grupo um"
            });
            grupos.Add(new GrupoViewModel
            {
                Id = 2,
                Descricao = "Grupo dois"
            });

            var items = grupos.Select(resultado => new SelectListItem
            {

                Text = resultado.Descricao,
                Value = resultado.Id.ToString()

            });




            List<TipoViewModel> tipos = new List<TipoViewModel>();
            tipos.Add(new TipoViewModel
            {
                Id = 0,
                Descricao = "Tipo um",
                Codigo = "TU",
                Ativo = true,
                DataCriacao = DateTime.Now
            });


            var modelo = new ListaTipoViewModel
            {
                Grupos = items,
                Tipos = tipos
            };



            return View(modelo);
        }


        // GET: Tipos/Details/5
        public ActionResult Details(int id)
        {

            return View();
        }





        // GET: Tipos/Create
        public ActionResult Create()
        {
            /*
            var leaveTypes = _leaveTyperepo.FindAll();

            var leaveTypeItems = leaveTypes.Select(resultado => new SelectListItem
            {

                Text = resultado.Name,
                Value = resultado.Id.ToString()

            });

            */



            List<GrupoViewModel> grupos = new List<GrupoViewModel>();
            grupos.Add(new GrupoViewModel
            {
                Id = 1,
                Descricao = "Grupo um"
            });
            grupos.Add(new GrupoViewModel
            {
                Id = 2,
                Descricao = "Grupo dois"
            });

            var items = grupos.Select(resultado => new SelectListItem
            {

                Text = resultado.Descricao,
                Value = resultado.Id.ToString()

            });


            var modelo = new CriarTipoViewModel
            {
                Grupos = items
            };

            return View(modelo);

        }

        // POST: Tipos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TipoViewModel modelo)
        {

            try
            {

                if (ModelState.IsValid == false)
                {
                    return View(modelo);
                }

                var tipo = _mapper.Map<Tipo>(modelo);
                tipo.DataCriacao = DateTime.Now;
                tipo.Ativo = true;
                /*
                var resultado = _repo.Create(tipo);

                if (resultado == false)
                {
                    ModelState.AddModelError("", Sintaxe.ERRO_INSERIR + "Tipo");
                    return View(modelo);
                }
                */
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                ModelState.AddModelError("", "Something Went wrong...");
                return View();
            }


        }





        // GET: Tipos/Edit/5
        public ActionResult Edit(int id)
        {
            /*
            if (!_repo.isExists(id))
            {
                return NotFound();
            }
            
            var tipo = _repo.FindById(id);
            var modelo = _mapper.Map<TipoViewModel>(tipo);
            */


            GrupoViewModel grupo = new GrupoViewModel
            {
                Id = 1,
                Descricao = "Grupo um"
            };


            TipoViewModel modelo = new TipoViewModel
            {
                Id = 0,
                Descricao = "Tipo um",
                Codigo = "TU",
                Ativo = true,
                DataCriacao = DateTime.Now,
                Grupo = grupo,
                IdGrupo = grupo.Id

            };


            return View(modelo);
        }

        // POST: Tipos/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(TipoViewModel modelo)
        {
            try
            {
                if (ModelState.IsValid == false)
                {
                    return View(modelo);
                }

                /*
                var registo = _leaveallocationrepo.FindById(modelo.Id);
                registo.Descricao = modelo.Descricao;
                registo.Ativo = modelo.Ativo;

                var resultado = _leaveallocationrepo.Update(registo);

                if (resultado == false)
                {
                    ModelState.AddModelError("", Sintaxe.ERRO_EDITAR + "Tipo");
                    return View(modelo);
                }
                */
                return RedirectToAction(nameof(Index));
                //return RedirectToAction(nameof(Details), new { id = model.EmployeeId });
            }
            catch
            {
                return View(modelo);
            }
        }









        // GET: Tipos/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Tipos/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }



        public ActionResult UpdateProduct(ListaTipoViewModel value)
        {


            return View();

        }


    }

}