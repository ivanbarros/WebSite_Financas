using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyFinance.Models;
using MyFinance.Service.Interfaces.Services;

namespace MyFinance.Controllers
{
    public class ContaController : Controller
    {
        private readonly IContaService _service;
        IHttpContextAccessor HttpContextAccessor;
        public ContaController(IContaService service,IHttpContextAccessor httpContextAccessor)
        {
            _service = service;
            HttpContextAccessor = httpContextAccessor;
        }

        public IActionResult _PartialConta(string login, string password)
        {
            //ContaModel objConta = new ContaModel(HttpContextAccessor);
            
            //ViewBag.ListaConta = objConta.ListaConta();
            ViewBag.ListaConta = _service.ListaConta(login, password);
            return View();
        }

       [HttpPost]
        public IActionResult NovaConta(ContaModel formulario)
        {
            if (ModelState.IsValid)
            {
                formulario.HttpContextAccessor = HttpContextAccessor;
                formulario.Insert();
              return  RedirectToAction("_PartialConta");
            }
            return View();
        }

        [HttpGet]
        public IActionResult NovaConta()
        {

            return View();
        }

        [HttpGet]
        public IActionResult ExcluirConta(int id)
        {

            ContaModel objConta = new ContaModel(HttpContextAccessor);
            objConta.ExcluirConta(id);
            return RedirectToAction("_PartialConta");
        }
    }
   
}
