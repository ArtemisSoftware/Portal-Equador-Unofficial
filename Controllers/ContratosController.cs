using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PortalEquador.Models;
using PortalEquador.Util.Constantes;

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
            /*
            var leaveTypes = await _leaveTyperepo.FindAll();

            var leaveTypeItems = leaveTypes.Select(result => new SelectListItem
            {

                Text = result.Name,
                Value = result.Id.ToString()

            });
            */

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


            var itemsFuncoes = funcoes.Select(resultado => new SelectListItem
            {

                Text = resultado.Descricao,
                Value = resultado.Id.ToString()

            });


            var itemsEmpresas = empresas.Select(resultado => new SelectListItem
            {

                Text = resultado.Descricao,
                Value = resultado.Id.ToString()

            });


            var modelo = new CriarContratoViewModel
            {
                Funcoes = itemsFuncoes,
                Empresas = itemsEmpresas
            };
            

            return View(modelo);
        }

        // POST: Contratos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CriarContratoViewModel modelo)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                ModelState.AddModelError("", Sintaxe.ERRO_INSERIR + "Contrato");
                return View();
            }
        }

        // GET: Contratos/Edit/5
        public ActionResult Edit(int id)
        {

            /*
            if (!_repo.isExists(id))
            {
                return NotFound();
            }

            var contrato = _repo.FindById(id);
            var modelo = _mapper.Map<CriarContratoViewModel>(contrato);
            */

            var funcoes = new List<TipoViewModel>();
            funcoes.Add(new TipoViewModel
            {
                Descricao = "Função numero 1",
                Id = 1
                
            });
            funcoes.Add(new TipoViewModel
            {
                Descricao = "Função numero 2",
                Id = 2
            });

            var empresas = new List<TipoViewModel>();
            empresas.Add(new TipoViewModel
            {
                Descricao = "Empresa numero 1",
                Id = 1
            });
            empresas.Add(new TipoViewModel
            {
                Descricao = "Empresa numero 2",
                Id = 2
            });


            var itemsFuncoes = funcoes.Select(resultado => new SelectListItem
            {

                Text = resultado.Descricao,
                Value = resultado.Id.ToString()

            });


            var itemsEmpresas = empresas.Select(resultado => new SelectListItem
            {

                Text = resultado.Descricao,
                Value = resultado.Id.ToString()

            });


            var modelo = new CriarContratoViewModel
            {
                Nome = "Nome 1",
                NumeroMecanografico = "000100",
                DataInicio = "01-09-2009",
                Funcoes = itemsFuncoes,
                IdFuncao = 2,
                Empresas = itemsEmpresas,
                IdEmpresa = 1,
            };



            int posicao = 0;


            foreach (SelectListItem item in itemsFuncoes)
            {
                ++posicao;

                if (modelo.IdFuncao.ToString() == item.Value)
                {
                    break;
                }
            }

            modelo.PosicaoFuncao = posicao;

            posicao = 0;

            foreach (SelectListItem item in itemsEmpresas)
            {
                ++posicao;

                if (modelo.IdEmpresa.ToString() == item.Value)
                {
                    break;
                }
            }
            

            modelo.PosicaoEmpresa = posicao;


            return View(modelo);
        }

        // POST: Contratos/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CriarContratoViewModel modelo)
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