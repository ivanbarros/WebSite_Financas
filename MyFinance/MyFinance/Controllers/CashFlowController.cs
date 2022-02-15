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
            var receita = 0.0M;
            var despesa = 0.0M;
            var result = _service.GetDespesaReceita(idUsuario, decision, categoryName);

            if (decision == "1" || String.IsNullOrEmpty(decision))
            {

                despesa = _service.ValorTotalDespesa(idUsuario,categoryName, decision);
                ViewBag.Despesa = despesa;
            }
            if (decision =="0" || String.IsNullOrEmpty(decision))
            {

                receita = _service.ValorTotalReceita(idUsuario,categoryName, decision);
                ViewBag.Receita = receita;
            }
            
           

            ViewBag.ListaDespesaReceita = result;            

            return PartialView("GetDespesaReceita");
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            string id_usuario_logado = HttpContext.Session.GetString("IdUsuarioLogado");
            var idUsuario = Convert.ToInt32(id_usuario_logado);
           var result =  _service.Get(id);
            //ViewBag.EditCash = result;


            return View(result);
        }
        
        
        [HttpPost]
        public IActionResult Editar(CashFlowEntity entity)
        {
            string id_usuario_logado = HttpContext.Session.GetString("IdUsuarioLogado");
            var idUsuario = Convert.ToInt32(id_usuario_logado);
            _service.Update(entity);
            return View();
        }

        [HttpGet]
        public IActionResult Detalhes(int id) 
        {
            string id_usuario_logado = HttpContext.Session.GetString("IdUsuarioLogado");
            var idUsuario = Convert.ToInt32(id_usuario_logado);
            var result = _service.Get(id);
            
            return PartialView("Detalhes",result);
        }
    }
}
