using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PortalEquador.Models;

namespace PortalEquador.Controllers
{
    public class GruposController : Controller
    {

        //private readonly ILeaveTypeRepository _repo;
        private readonly IMapper _mapper;



        public GruposController(/*ILeaveTypeRepository repo, */IMapper mapper)
        {
            //this._repo = repo;
            this._mapper = mapper;
        }


        // GET: Grupos
        public ActionResult Index()
        {

            List<GrupoViewModel> modelo = new List<GrupoViewModel>();
            modelo.Add(new GrupoViewModel
            {
                Descricao = "Item um",
                DataCriacao = DateTime.Now
            });
            modelo.Add(new GrupoViewModel
            {
                Descricao = "Item dois",
                DataCriacao = DateTime.Now
            });


            return View(modelo);
        }

        // GET: Grupos/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Grupos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Grupos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(GrupoViewModel modelo)
        {
            try
            {
                // TODO: Add insert logic here
                if (!ModelState.IsValid)
                {
                    return View(modelo);
                }
                /*
                var leaveType = _mapper.Map<LeaveType>(model);
                leaveType.DateCreated = DateTime.Now;

                var isSuccess = _repo.Create(leaveType);

                if (!isSuccess)
                {
                    ModelState.AddModelError("", "Something Went wrong...");
                    return View(model);
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

        // GET: Grupos/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Grupos/Edit/5
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

        // GET: Grupos/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Grupos/Delete/5
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