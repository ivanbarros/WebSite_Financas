using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyFinance.Domain.Entities;
using MyFinance.Interfaces.Services;
using MyFinance.Service.Interfaces.Services;
using System;

namespace MyFinance.Controllers
{
    public class ContaController : Controller
    {
        private readonly IContaServiceApplication _service;
        private readonly IUserService _userService;
        IHttpContextAccessor _httpContextAccessor;

        public ContaController(IContaServiceApplication service, IUserService userService, IHttpContextAccessor httpContextAccessor)
        {
            _service = service;
            _userService = userService;
            _httpContextAccessor = httpContextAccessor;
        }


        public IActionResult _PartialConta()
        {
         string id_usuario_logado = _httpContextAccessor.HttpContext.Session.GetString("IdUsuarioLogado");
            var idUsuario = Convert.ToInt32(id_usuario_logado);
            var result = _service.ListaConta(idUsuario);

            ViewBag.ListaConta = result;
            return View();
        }

       [HttpPost]
        public IActionResult NovaConta(AccountEntity NovaContaFormulario)
        {
         
            NovaContaFormulario.HttpContextAccessor = _httpContextAccessor;
            string id_usuario_logado = _httpContextAccessor.HttpContext.Session.GetString("IdUsuarioLogado");
            var idUsuario = Convert.ToInt32(id_usuario_logado);
            var tipoconta = Convert.ToString(NovaContaFormulario.TypeAccountEnum);
            NovaContaFormulario.AccountType = tipoconta;
            NovaContaFormulario.Usuario_idUsuario = idUsuario;
            NovaContaFormulario.CreateDate = DateTime.UtcNow;
            _service.Insert(NovaContaFormulario);

              return  RedirectToAction("_PartialConta");
            
        }

        [HttpGet]
        public IActionResult NovaConta()
        {
            string id_usuario_logado = _httpContextAccessor.HttpContext.Session.GetString("IdUsuarioLogado");
            var idUsuario = Convert.ToInt32(id_usuario_logado);
            return View();
        }

        [HttpGet]
        public IActionResult ExcluirConta(int id)
        {
            string id_usuario_logado = _httpContextAccessor.HttpContext.Session.GetString("IdUsuarioLogado");
            //ContaModel objConta = new ContaModel(Http);
            //objConta.ExcluirConta(id);
            return RedirectToAction("_PartialConta");
        }
    }
   
}
