using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyFinance.Domain.Entities;
using MyFinance.Interfaces.Services;
using Newtonsoft.Json;
using System;


namespace MyFinance.Controllers
{
    public class CashFlowController : Controller
    {
        private readonly ICashFlowServiceApplication _service;

        IHttpContextAccessor _httpContextAccessor;

        public CashFlowController(ICashFlowServiceApplication service, IHttpContextAccessor httpContextAccessor)
        {
            _service = service;

            _httpContextAccessor = httpContextAccessor;
        }

        public IActionResult Index()
        {
            string id_usuario_logado = HttpContext.Session.GetString("IdUsuarioLogado");
            var idUsuario = Convert.ToInt32(id_usuario_logado);
            return View();

        }

        [HttpPost]
        public PartialViewResult FluxoCaixa(CashFlowEntity NovaContaFormulario)
        {
            string id_usuario_logado = HttpContext.Session.GetString("IdUsuarioLogado");
            var idUsuario = Convert.ToInt32(id_usuario_logado);

            NovaContaFormulario.Usuario_id = idUsuario;

            _service.Insert(NovaContaFormulario);

            return PartialView("FluxoCaixa");
        }
        [HttpGet]
        public PartialViewResult FluxoCaixa()
        {
            string id_usuario_logado = HttpContext.Session.GetString("IdUsuarioLogado");
            var idUsuario = Convert.ToInt32(id_usuario_logado);
            return PartialView("FluxoCaixa");
        }

        public IActionResult GetDespesaReceita(string categoryName, string decision)
        {
            string id_usuario_logado = HttpContext.Session.GetString("IdUsuarioLogado");
            var idUsuario = Convert.ToInt32(id_usuario_logado);
            
            var result = _service.GetDespesaReceita(idUsuario, decision, categoryName);
            //var convert = JsonConvert.SerializeObject(result, Formatting.Indented);
            ViewBag.ListaDespesaReceita = result;
            return PartialView(result);
        }

        public PartialViewResult GetAllDespesas()
        {
            string id_usuario_logado = HttpContext.Session.GetString("IdUsuarioLogado");
            var idUsuario = Convert.ToInt32(id_usuario_logado);
            var result = _service.ListaPlanoContas(idUsuario);

            ViewBag.ListaFluxo = result;
            return PartialView("GetAllDespesas", ViewBag.ListaFluxo);
        }
    }
}
