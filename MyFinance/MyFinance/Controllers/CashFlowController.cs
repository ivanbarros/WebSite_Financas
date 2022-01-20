using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyFinance.Domain.Entities;
using MyFinance.Interfaces.Services;
using System;

namespace MyFinance.Controllers
{
    public class CashFlowController : Controller
    {
        private readonly ICashFlowServiceApplication _service;
        private readonly IUserServiceApplication _userServiceApp;
        IHttpContextAccessor _httpContextAccessor;

        public CashFlowController(ICashFlowServiceApplication service, IUserServiceApplication userServiceApp, IHttpContextAccessor httpContextAccessor)
        {
            _service = service;
            _userServiceApp = userServiceApp;
            _httpContextAccessor = httpContextAccessor;
        }

        public IActionResult Index()
        {
            string id_usuario_logado = _httpContextAccessor.HttpContext.Session.GetString("IdUsuarioLogado");
            var idUsuario = Convert.ToInt32(id_usuario_logado);
            var result = _service.ListaPlanoContas(idUsuario);

            ViewBag.ListaFluxo = result;
            
            return View();
        }

        [HttpPost]
        public IActionResult FluxoCaixa(CashFlowEntity NovaContaFormulario)
        {
            string id_usuario_logado = HttpContext.Session.GetString("IdUsuarioLogado");
            var idUsuario = Convert.ToInt32(id_usuario_logado);

            NovaContaFormulario.Usuario_id = idUsuario;
            
            _service.Insert(NovaContaFormulario);

            return View();
        }
        [HttpGet]
        public IActionResult FluxoCaixa() 
        {
            string id_usuario_logado = _httpContextAccessor.HttpContext.Session.GetString("IdUsuarioLogado");
            var idUsuario = Convert.ToInt32(id_usuario_logado);
            return View();
        }
    }
}
