using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyFinance.Domain.Entities;
using MyFinance.Interfaces;
using MyFinance.Models;

namespace MyFinance.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUserServiceApplication _serviceApplication;

        public UsuarioController(IUserServiceApplication servuceApplication)
        {
            _serviceApplication = servuceApplication;
        }

        [HttpGet]
        public IActionResult Login( int? id)
        {
            if (id != null)
            {
                if (id == 0)
                {
                    HttpContext.Session.SetString("IdUsuarioLogado",string.Empty);
                    HttpContext.Session.SetString("NomeUsuarioLogado", string.Empty);
                    HttpContext.Session.SetString("EmailUsuarioLogado", string.Empty);
                }
            }
            return View();
        }
        [HttpPost]
        public IActionResult ValidarLogin(UsuarioModel usuario)
        {
            bool login = usuario.ValidarLogin();
            if (login)
            {
                HttpContext.Session.SetString("NomeUsuarioLogado", usuario.NomeUsuario);
                HttpContext.Session.SetString("IdUsuarioLogado", usuario.idUsuario.ToString());
                HttpContext.Session.SetString("EmailUsuarioLogado", usuario.Email.ToString());
                return RedirectToAction("_PartialMenu", "Menu");
            }
            else
            {
             
                TempData["LoginIvalido"] = "Usuario ou senha não estão corretos!";                
                return RedirectToAction("Login");
            }
        }

        [HttpPost]
        
        public IActionResult Registrar(UserEntity usuario)
        {
            
            if (ModelState.IsValid)
            {
                _serviceApplication.Insert(usuario);
                //usuario.RegistrarUsuario();
                return RedirectToAction("Sucesso");
                
            }
            return View();
        }
        [HttpGet]
        public IActionResult Registrar() { return View(); }

        [HttpGet]
        public IActionResult Sucesso() { return View(); }
    }
}