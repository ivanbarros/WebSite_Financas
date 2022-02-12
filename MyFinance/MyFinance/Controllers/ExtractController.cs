using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyFinance.Interfaces.Services;
using System;

namespace MyFinance.Controllers
{
    public class ExtractController : Controller
    {
        private readonly IExtractServiceApplication _serviceApplication;
        IHttpContextAccessor _httpContextAccessor;

        public ExtractController(IExtractServiceApplication serviceApplication, IHttpContextAccessor httpContextAccessor)
        {
            _serviceApplication = serviceApplication;
            _httpContextAccessor = httpContextAccessor;
        }

        [HttpGet]
        public IActionResult Index() 
        {
            string id_usuario_logado = HttpContext.Session.GetString("IdUsuarioLogado");
            var idUsuario = Convert.ToInt32(id_usuario_logado);
            var result = _serviceApplication.GetAll();
            ViewBag.Extract = result;
            return View();
        }

        [HttpPost]
        public IActionResult VisaoGeral() 
        {
            return PartialView();
        }
    }
}
