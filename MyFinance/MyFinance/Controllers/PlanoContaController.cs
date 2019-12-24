using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyFinance.Models;

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
            PlanoContaModel objConta = new PlanoContaModel(HttpContextAccessor);
            ViewBag.ListaPlanoConta = objConta.ListaPlanoContas();
            return View();
        }

        [HttpPost]
        public IActionResult NovoPlanoConta(PlanoContaModel formulario)
        {
            if (ModelState.IsValid)
            {
                formulario.HttpContextAccessor = HttpContextAccessor;
                formulario.Insert();
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult NovoPlanoConta(int? id)
        {
            if (id != null)
            {
                PlanoContaModel objPlanoContas = new PlanoContaModel(HttpContextAccessor);
                // ViewBag.Registro = objPlanoContas.CarregarRegistro(id);
            }

            return View();
        }

        [HttpGet]
        public IActionResult ExcluirConta(int id)
        {

            PlanoContaModel objConta = new PlanoContaModel(HttpContextAccessor);
            objConta.ExcluirConta(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditarPlanoConta()
        {

            return View();

        }

        [HttpPut]
        public IActionResult EditarPlanoConta(PlanoContaModel formulario)
        {
            if (ModelState.IsValid)
            {
                formulario.HttpContextAccessor = HttpContextAccessor;
                formulario.EditarPlanoConta(formulario);
                return RedirectToAction("Index");
            }
            return View();
        }

    }
}
