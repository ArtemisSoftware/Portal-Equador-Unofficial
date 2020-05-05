using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
            return View();
        }

        // GET: Tipos/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Tipos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tipos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
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