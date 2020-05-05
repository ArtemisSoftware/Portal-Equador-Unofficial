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
        public ActionResult Index()
        {
            /*
            var tipos = _repo.FindAll().ToList();
            var modelo = _mapper.Map<List<Tipo>, List<TipoViewModel>>(tipos);
            */

            List<TipoViewModel> modelo = new List<TipoViewModel>();
            modelo.Add(new TipoViewModel
            {
                Id = 0,
                Descricao = "Tipo um",
                Codigo = "TU",
                Ativo = true,
                DataCriacao = DateTime.Now
            });
            modelo.Add(new TipoViewModel
            {
                Id = 1,
                Descricao = "Tipo dois",
                Codigo = "TD",
                Ativo = false,
                DataCriacao = DateTime.Now
            });


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
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                ModelState.AddModelError("", Sintaxe.ERRO_INSERIR + "Tipo");
                return View();
            }
        }





        // GET: Tipos/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Tipos/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
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
    }
}