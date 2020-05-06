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
    public class ContratosController : Controller
    {

        private readonly IMapper _mapper;


        public ContratosController(IMapper mapper)
        {
            this._mapper = mapper;
        }




        // GET: Contratos
        public ActionResult Index()
        {


            //var leaveRequestsModel = _mapper.Map<List<LeaveRequestViewModel>>(await _leaveaRequestrepo.FindAll());

            var funcoes = new List<TipoViewModel>();
            funcoes.Add(new TipoViewModel
            {
                Descricao = "Função numero 1"
            });
            funcoes.Add(new TipoViewModel
            {
                Descricao = "Função numero 2"
            });

            var empresas = new List<TipoViewModel>();
            empresas.Add(new TipoViewModel
            {
                Descricao = "Empresa numero 1"
            });
            empresas.Add(new TipoViewModel
            {
                Descricao = "Empresa numero 2"
            });


            var empregados = new List<EmpregadoViewModel>();
            empregados.Add(new EmpregadoViewModel
            {
                Nome = "Nome 1"
            });
            empregados.Add(new EmpregadoViewModel
            {
                Nome = "Nome 2"
            });


            List<ContratoViewModel> modelo = new List<ContratoViewModel>();
            modelo.Add(new ContratoViewModel
            {
                Id = 732489,
                Funcao = funcoes[0],
                Empresa = empresas[0],
                Empregado = empregados[0],
                DataInicio = DateTime.Now
            });
            modelo.Add(new ContratoViewModel
            {

                Id = 567,
                Funcao = funcoes[1],
                Empresa = empresas[1],
                Empregado = empregados[1],
                DataInicio = DateTime.Now
            });


            return View(modelo);

        }

        // GET: Contratos/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Contratos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Contratos/Create
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

        // GET: Contratos/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Contratos/Edit/5
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

        // GET: Contratos/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Contratos/Delete/5
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