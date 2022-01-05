using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyFinance.Models;
using System;
using System.Collections.Generic;

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
            TransacaoModel objTransacao = new TransacaoModel(HttpContextAccessor);
            ViewBag.ListaTransacao = objTransacao.ListaTransacao();
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
                TransacaoModel objTransacao = new TransacaoModel(HttpContextAccessor);
                ViewBag.Registro = objTransacao.CarregarRegistro(id);
            }
            //ViewBag.ListaContas = new ContaModel(HttpContextAccessor).ListaConta();
            ViewBag.ListaPlanoContas = new PlanoContaModel(HttpContextAccessor).ListaPlanoContas();

            return View();
        }

        
        [HttpGet]
        public IActionResult ExcluirTransacao(int id)
        {

            TransacaoModel objTransacao = new TransacaoModel(HttpContextAccessor);
            objTransacao.ExcluirConta(id);
            return RedirectToAction("Index");
            
        }

        [HttpGet]
        [HttpPost]
        public IActionResult Extrato(TransacaoModel formulario)
        {
            formulario.HttpContextAccessor = HttpContextAccessor;
            ViewBag.ListaTransacao = formulario.ListaTransacao();
            //ViewBag.ListaContas = new ContaModel(HttpContextAccessor).ListaConta();
            return View();
        }
        public IActionResult Dashboard()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Dashboard(int? id)
        {
            
            List<Dashboard> lista = new Dashboard(HttpContextAccessor).RetornaGrafico();
            List<Dashboard> listaReceita = new Dashboard(HttpContextAccessor).RetornaGraficoReceita();
            string valores = "";
            string labels = "";
            string cores = "";
            var random = new Random();
            for (int i = 0; i < lista.Count; i++)
            {
                valores +=  lista[i].Total.ToString() + ",";
                labels += "'"+ lista[i].PlanoConta.ToString()+"',";
                cores += "'" + String.Format("#{0:X6}", random.Next(0x1000000)) + "',";
            }

            ViewBag.Labels = labels;
            ViewBag.Valores = valores;
            ViewBag.cores = cores;

            return View();
        }



        public IActionResult Relatorio()
        {
            return View();
        }

    }
}