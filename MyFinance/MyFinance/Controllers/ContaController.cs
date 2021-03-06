﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyFinance.Models;

namespace MyFinance.Controllers
{
    public class ContaController : Controller
    {
        IHttpContextAccessor HttpContextAccessor;
        public ContaController(IHttpContextAccessor httpContextAccessor)
        {
            HttpContextAccessor = httpContextAccessor;
        }

        public IActionResult _PartialConta()
        {
            ContaModel objConta = new ContaModel(HttpContextAccessor);
            ViewBag.ListaConta = objConta.ListaConta();
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
