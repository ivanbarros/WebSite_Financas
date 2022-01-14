using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyFinance.Domain.Entities;
using MyFinance.Service.Interfaces.Services;
using System;

namespace MyFinance.Controllers
{
    public class CashFlowController : Controller
    {
        private readonly ICashFlowService _service;
        //private readonly IUserService _userService;
        IHttpContextAccessor _httpContextAccessor;

        public CashFlowController(ICashFlowService service, IHttpContextAccessor httpContextAccessor)
        {
            _service = service;
            _httpContextAccessor = httpContextAccessor;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CriarFluxoCaixa(CashFlowEntity NovaContaFormulario)
        {

            NovaContaFormulario.HttpContextAccessor = _httpContextAccessor;
            string id_usuario_logado = _httpContextAccessor.HttpContext.Session.GetString("IdUsuarioLogado");
            var idUsuario = Convert.ToInt32(id_usuario_logado);

            NovaContaFormulario.Usuario_id = idUsuario;

            //if (ModelState.IsValid)
            //{


            _service.Insert(NovaContaFormulario);

            return RedirectToAction("Index");
            //}
            //return View();
        }

    }
}
