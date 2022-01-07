using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyFinance.Models;
using System;
using System.Collections.Generic;

namespace MyFinance.Controllers
{
    public class TransacaoController : Controller
    {
       
      
        public IActionResult Index()
        {
            //TransacaoModel objTransacao = new TransacaoModel(Http);
            //ViewBag.ListaTransacao = objTransacao.ListaTransacao();
            return View();
        }


        [HttpPost]
        public IActionResult Registrar(TransacaoModel formulario)
        {
            if (ModelState.IsValid)
            {
               // formulario.Http = Http;
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
              //  TransacaoModel objTransacao = new TransacaoModel(Http);
                //ViewBag.Registro = objTransacao.CarregarRegistro(id);
            }
            //ViewBag.ListaContas = new ContaModel(Http).ListaConta();
            //ViewBag.ListaPlanoContas = new PlanoContaModel(Http).ListaPlanoContas();

            return View();
        }

        
        [HttpGet]
        public IActionResult ExcluirTransacao(int id)
        {

            //TransacaoModel objTransacao = new TransacaoModel(Http);
            //objTransacao.ExcluirConta(id);
            return RedirectToAction("Index");
            
        }

        [HttpGet]
        [HttpPost]
        public IActionResult Extrato(TransacaoModel formulario)
        {
            //formulario.Http = Http;
            ViewBag.ListaTransacao = formulario.ListaTransacao();
            //ViewBag.ListaContas = new ContaModel(Http).ListaConta();
            return View();
        }
        public IActionResult Dashboard()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Dashboard(int? id)
        {
            
            ////List<Dashboard> lista = new Dashboard(Http).RetornaGrafico();
            ////List<Dashboard> listaReceita = new Dashboard(Http).RetornaGraficoReceita();
            //string valores = "";
            //string labels = "";
            //string cores = "";
            //var random = new Random();
            //for (int i = 0; i < lista.Count; i++)
            //{
            //    valores +=  lista[i].Total.ToString() + ",";
            //    labels += "'"+ lista[i].PlanoConta.ToString()+"',";
            //    cores += "'" + String.Format("#{0:X6}", random.Next(0x1000000)) + "',";
            //}

            //ViewBag.Labels = labels;
            //ViewBag.Valores = valores;
            //ViewBag.cores = cores;

            return View();
        }



        public IActionResult Relatorio()
        {
            return View();
        }

    }
}