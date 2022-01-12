using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyFinance.Models;
using System;

namespace MyFinance.Controllers
{
    public class PlanoContaController : Controller
    {
        IHttpContextAccessor HttpContextAccessor;
        public PlanoContaController(IHttpContextAccessor httpContextAccessor)
        {
            HttpContextAccessor = httpContextAccessor;
        }

        public IActionResult Index()
        {
            //PlanoContaModel objConta = new PlanoContaModel(Http);
            //ViewBag.ListaPlanoConta = objConta.ListaPlanoContas();
            return View();
        }

        [HttpPost]
        public IActionResult CriarPlanoConta(PlanoContaModel formulario)
        {
            if (ModelState.IsValid)
            {
                //formulario.Http = Http;
                formulario.Insert();
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult CriarPlanoConta(int? id)
        {
            if (id != null)
            {
                //PlanoContaModel objPlanoContas = new PlanoContaModel(Http);
                // ViewBag.Registro = objPlanoContas.CarregarRegistro(id);
               
            }

            return View();
        }

        [HttpGet]
        public IActionResult ExcluirPlanoConta(int id)
        {

            //PlanoContaModel objConta = new PlanoContaModel(Http);
            //objConta.ExcluirConta(id);
            return RedirectToAction("Index");
        }


       
    }
}
