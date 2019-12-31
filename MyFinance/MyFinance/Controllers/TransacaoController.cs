using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyFinance.Models;

namespace MyFinance.Controllers
{
    public class TransacaoController : Controller
    {
        IHttpContextAccessor HttpContextAccessor;
        public TransacaoController(IHttpContextAccessor httpContextAccessor)
        {
            HttpContextAccessor = httpContextAccessor;
        }
        public IActionResult Index()
        {
            TransacaoModel objConta = new TransacaoModel(HttpContextAccessor);
            ViewBag.ListaTransacao = objConta.ListaTransacao();
            return View();
        }

        [HttpPost]
        public IActionResult Registrar(TransacaoModel formulario)
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
        public IActionResult Registrar(int? id)
        {
            if (id != null)
            {
                TransacaoModel objPlanoContas = new TransacaoModel(HttpContextAccessor);
                ViewBag.Registro = objPlanoContas.CarregarRegistro(id);
                
               

            }

            return View();
        }

        [HttpGet]
        public IActionResult ExcluirPlanoConta(int id)
        {

            TransacaoModel objConta = new TransacaoModel(HttpContextAccessor);
            objConta.ExcluirConta(id);
            return RedirectToAction("Index");
        }
        public IActionResult Extrato()
        {
            return View();
        }

        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult Relatorio()
        {
            return View();
        }
    }
}