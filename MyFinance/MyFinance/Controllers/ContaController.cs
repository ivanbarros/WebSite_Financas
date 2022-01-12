using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyFinance.Domain.Entities;
using MyFinance.Models;
using MyFinance.Service.Interfaces.Services;
using System;

namespace MyFinance.Controllers
{
    public class ContaController : Controller
    {
        private readonly IContaService _service;
        IHttpContextAccessor _httpContextAccessor;

        public ContaController(IContaService service, IHttpContextAccessor httpContextAccessor)
        {
            _service = service;
            _httpContextAccessor = httpContextAccessor;
        }

        public IActionResult _PartialConta()
        {
         string id_usuario_logado = _httpContextAccessor.HttpContext.Session.GetString("IdUsuarioLogado");
            var idUsuario = Convert.ToInt32(id_usuario_logado);
            var result = _service.ListaConta(idUsuario);
            //ContaModel objConta = new ContaModel(Http);

            //ViewBag.ListaConta = objConta.ListaConta();
            ViewBag.ListaConta = result;
            return View();
        }

       [HttpPost]
        public IActionResult NovaConta(ContaEntity NovaContaFormulario)
        {
            if (ModelState.IsValid)
            {
         string id_usuario_logado = _httpContextAccessor.HttpContext.Session.GetString("IdUsuarioLogado");
                NovaContaFormulario.HttpContextAccessor = _httpContextAccessor;
                //formulario.Insert();
                NovaContaFormulario.Usuario_idUsuario = Convert.ToInt32(id_usuario_logado);
                _service.Insert(NovaContaFormulario);
              return  RedirectToAction("_PartialConta");
            }
            return View();
        }

        [HttpGet]
        public IActionResult NovaConta()
        {
            string id_usuario_logado = _httpContextAccessor.HttpContext.Session.GetString("IdUsuarioLogado");
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
